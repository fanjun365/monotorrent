using MonoTorrent.BEncoding;
using MonoTorrent.Client;
using MonoTorrent.Common;
using MonoTorrent.Client.Tracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Net;
using MonoTorrent.Dht;
using MonoTorrent;

namespace torrenut
{   
    public class TorrentsOrganizer
    {             
        private ClientEngine engine;
        private String fastResumePath = TorrHelper.ConfFolder+  "\\fastresume";
        public DataSet1 dataset1 = new DataSet1();

        public static List<String> QueueAdd, QueueRemove, QueueStop, QueuePause, QueueStart;

        private TorrentManager currentSelectedSingleManager = null;

        public bool m_allStopped = false;

        public TorrentsOrganizer()
        {
            QueueAdd = new List<string>();
            QueuePause = new List<string>();
            QueueRemove = new List<string>();
            QueueStart = new List<string>();
            QueueStop = new List<string>();

            EngineSettings engSettings = new EngineSettings(ConfigurationStation.DownloadsInProgressPath, ConfigurationStation.Port);
            
            engine = new ClientEngine(engSettings);

            if (ConfigurationStation.EnableDHT)
            {
                StartDht(engine, ConfigurationStation.DHTPort);
            }

            engine.TorrentRegistered += engine_TorrentRegistered;
            engine.TorrentUnregistered += engine_TorrentUnregistered;
        }

        public ClientEngine TorrentEngine
        {
            get
            {
                return engine;
            }
        }


        void engine_TorrentUnregistered(object sender, TorrentEventArgs e)
        {           
        }


        void engine_TorrentRegistered(object sender, TorrentEventArgs e)
        {
        }

        public void AddTorrent(String path)
        {
            try
            {

                FileInfo f = new FileInfo(path);

                String destFile = TorrHelper.ConfFolder + "\\" + f.Name;

                if (File.Exists(destFile)) File.Delete(destFile);

                File.Copy(path, destFile);

                Torrent torrent = Torrent.Load(destFile);
                TorrentManager manager = new TorrentManager(torrent, ConfigurationStation.DownloadsInProgressPath, new TorrentSettings());
                
                if (engine.Contains(manager)) return;

                engine.Register(manager);

                FastResume frData = FindFastResumeData(manager);
                if (frData != null)
                {                    
                    manager.LoadFastResume(frData);
                }

                manager.Start();

                dataset1.torrents.AddtorrentsRow(ConfigurationStation.DownloadsInProgressPath, destFile, TorrentState.Downloading.ToString(), manager.InfoHash.ToString(), (double)0, 0, 0, 0, 0, manager.Torrent.Size, 0, 0, 0, manager.Torrent.Name);
            }
            catch (Exception ex)
            {
                TorrHelper.Log(ex.Message);
                //throw;
            }
            SaveAllTorrents();
        }
        public void Start(String hash)
        {                         
            TorrentManager m = FindTorrentManagerByInfoHash(hash);
            if (m == null) return;
            m.Start();
        }
        public void Stop(String hash)
        {
            TorrentManager m = FindTorrentManagerByInfoHash(hash);
            if (m == null) return;
            m.Stop();
        }
        public void Pause(String hash)
        {
            TorrentManager m = FindTorrentManagerByInfoHash(hash);
            if (m == null) return;
            m.Pause();
        }

        public void Remove(String hash)
        {
            ///engine.Unregister(m);
            TorrentManager m = FindTorrentManagerByInfoHash(hash);
            if (m == null) return;            
           
            m.TorrentStateChanged += delegate(object o, TorrentStateChangedEventArgs e)
            {
                if (e.NewState == TorrentState.Stopping)
                {
                    //Console.WriteLine("Torrent {0} has begun stopping", e.TorrentManager.Torrent.Name);
                }
                else if (e.NewState == TorrentState.Stopped)
                {

                    // It is now safe to unregister the torrent from the engine and dispose of it (if required)
                    try
                    {
                        //DataSet1.torrentsRow row = dataset1.torrents.FindByInfoHash(m.InfoHash.ToString());

                        engine.Unregister(m);
                        m.Dispose();

                        //dataset1.torrents.RemovetorrentsRow(row);
                    }
                    catch (Exception ex)
                    {
                        TorrHelper.Log(ex.Message);
                        //throw;
                    }
                    //Console.WriteLine("Torrent {0} has stopped", e.TorrentManager.Torrent.Name);
                }
            };

            m.Stop();

        }
        public void SetDLLimit(String hash, int limit)
        {
        }
        public void SetULLimit(String hash, int limit)
        {
        }
        public void StartupAll()
        {

            if (File.Exists(TorrHelper.XMLTorr))
            {
                dataset1.ReadXml(TorrHelper.XMLTorr);
            }
            else
            {
                return;
            }
            foreach (torrenut.DataSet1.torrentsRow row in dataset1.torrents.ToList())
            {
                Torrent torrent = Torrent.Load(row.DotTorrentPath);
               TorrentManager manager = new TorrentManager(torrent, row.SavePath, new TorrentSettings());

               { // Do fastresume
                    if (File.Exists(fastResumePath))
                    {
                        BEncodedList list = (BEncodedList)BEncodedValue.Decode(File.ReadAllBytes(fastResumePath));
                        foreach (BEncodedDictionary fastResume in list)
                        {
                            FastResume data = new FastResume(fastResume);
                            if (manager.InfoHash == data.Infohash)
                            {
                                manager.LoadFastResume(data);        
                            }
                            else
                            {
                            }
                        }
                    }
               }

               engine.Register(manager);
               manager.Start();
               row.Leechs = 0;

            }
            if (File.Exists(fastResumePath))
            {
                File.Delete(fastResumePath);
            }
        }
        public void StopAndSaveAllTorrents()
        {
            SaveAllTorrents();

            foreach (TorrentManager m in engine.Torrents)
            {
                m.TorrentStateChanged += delegate(object o, TorrentStateChangedEventArgs e)
                {
                    if (engine == null || engine.Torrents == null) return;

                    bool _temp_m_allStopped = true;

                    foreach (TorrentManager m2 in engine.Torrents)
                    {
                        switch (m2.State)
                        {
                            case TorrentState.Stopping:
                                _temp_m_allStopped = false;
                                break;
                            case TorrentState.Downloading:
                                _temp_m_allStopped = false;
                                break;
                            case TorrentState.Seeding:
                                _temp_m_allStopped = false;
                                break;
                            case TorrentState.Hashing:
                                _temp_m_allStopped = false;
                                break;
                            case       TorrentState.Paused:
                                _temp_m_allStopped = false;
                                break;
                                
                        }
                    }
                    m_allStopped = _temp_m_allStopped;
                    if (e.NewState == TorrentState.Stopped)
                    {
                        //engine.Unregister(m);
                        //m.Dispose();
                    }
                };
                m.Stop();               
            }
        }
        public void SaveAllTorrents()
        {
            dataset1.WriteXml(TorrHelper.XMLTorr);
        }

        public void SetCurrentSelectedSingleManager(String hash)
        {
            TorrentManager _m = FindTorrentManagerByInfoHash(hash);

            if (currentSelectedSingleManager != _m)
            {
                dataset1.peers.Clear();
                dataset1.files.Clear();
                dataset1.trackers.Clear();
                dataset1.general.Clear();
            }

            currentSelectedSingleManager = _m;
        }

        public void SaveFastResume ()
         {
             // Store the fast resume for each torrent in a list,
             // then serialise the list to the disk.
             BEncodedList list = new BEncodedList ();
             foreach (TorrentManager manager in engine.Torrents) {

                 if (manager.State == TorrentState.Stopped && manager.HashChecked)
                 {
                     // Get the fast resume data for the torrent
                     FastResume data = manager.SaveFastResume();

                     // Encode the FastResume data to a BEncodedDictionary.
                     BEncodedDictionary fastResume = data.Encode();

                     // Add the FastResume dictionary to the main dictionary using
                     // the torrents infohash as the key
                     list.Add(fastResume);
                 }
                 
             }
 
             // Write all the fast resume data to disk
             File.WriteAllBytes (fastResumePath, list.Encode ());
         }

        public FastResume FindFastResumeData(TorrentManager m)
        {
            if (!File.Exists(fastResumePath))
            {
                return null;
            }
                BEncodedList list = (BEncodedList) BEncodedValue.Decode (File.ReadAllBytes (fastResumePath));
                foreach (BEncodedDictionary fastResume in list) {

                    // Decode the FastResume data from the BEncodedDictionary
                    FastResume data = new FastResume (fastResume);

                    // Find the torrentmanager that the fastresume belongs to
                    // and then load it
                    
                    if (m.InfoHash == data.Infohash)
                    {
                        return data;
                    }
                }
                return null;
        }

        internal void Tick()
        {
            //throw new NotImplementedException();
            TickAdd();
            TickRemove();
            TickStart();
            TickPause();
            TickStop();
            TickQuit();

            
            foreach (TorrentManager m in engine.Torrents.ToList())
            {               
                DataSet1.torrentsRow row = (DataSet1.torrentsRow)dataset1.torrents.Rows.Find(m.InfoHash.ToString());
                row.DownloadSpeed = m.Monitor.DownloadSpeed;
                row.UploadSpeed = m.Monitor.UploadSpeed;
                row.Progress =  m.Progress ;
                row.State = m.State.ToString();
                row.Seeds = m.Peers.Seeds ;
                row.Leechs = m.Peers.Leechs;
                row.Downloaded = m.Monitor.DataBytesDownloaded;
                row.Uploaded = m.Monitor.DataBytesUploaded;
                row.PeersAvailable = m.Peers.Available;
            }

            for (int i = dataset1.torrents.Count() - 1; i >= 0; i--)
            {
                DataSet1.torrentsRow r = dataset1.torrents[i];
                 TorrentManager _mfind = engine.Torrents.ToList().Find(delegate(TorrentManager _m)
                {
                    return _m.InfoHash.ToString() == r.InfoHash;
                });
                 if (_mfind == null)
                 {
                     dataset1.torrents.RemovetorrentsRow(r);
                 }
            }
            

            if (currentSelectedSingleManager != null)
            {

                dataset1.peers.Clear();
                dataset1.files.Clear();
                dataset1.trackers.Clear();
                dataset1.general.Clear();

                List<PeerId> __peers = currentSelectedSingleManager.GetPeers();
                

                try
                {
                    try
                    {

                        int cnt = 0;
                        foreach (PeerId p in currentSelectedSingleManager.GetPeers())
                        {
                            String _peerid = "";
                            for (int l = 0; l < p.PeerID.Length; l++)
                            {
                                _peerid += ((int)(p.PeerID[l])).ToString() + "";
                            }
                            dataset1.peers.AddpeersRow(currentSelectedSingleManager.InfoHash.ToString(), p.Uri.ToString(), p.Monitor.DataBytesDownloaded, p.Monitor.DataBytesUploaded, p.Monitor.DownloadSpeed, p.Monitor.UploadSpeed, p.ClientApp.ToString(), _peerid);

                        }
                    }
                    catch (Exception ex)
                    {
                        TorrHelper.Log(ex.Message);
                        //throw;
                    }

                    try
                    {
                        foreach (TorrentFile f in currentSelectedSingleManager.Torrent.Files)
                        {
                            dataset1.files.AddfilesRow(currentSelectedSingleManager.InfoHash.ToString(),
                                f.Length,
                                f.BytesDownloaded,
                                f.Path,
                                f.FullPath);

                        }
                    }
                    catch (Exception ex)
                    {
                        TorrHelper.Log(ex.Message);
                        //throw;
                    }

                    short i = 0;
                    foreach (Tracker t in currentSelectedSingleManager.TrackerManager.TrackerTiers[0].GetTrackers())
                    {
                        String ih = currentSelectedSingleManager.InfoHash.ToString();
                        String us = t.Uri.AbsoluteUri.ToString();
                        dataset1.trackers.AddtrackersRow(currentSelectedSingleManager.InfoHash.ToString(), us, (i++), t.Status.ToString(), t.WarningMessage);
                    }

                    {//general
                        TorrentManager _m = currentSelectedSingleManager;
                        if(_m != null) {
                            dataset1.general.AddgeneralRow(_m.InfoHash.ToString(),
                                TorrHelper.bytesToString(_m.Torrent.Size),
                                _m.Torrent.Comment,
                                _m.Error == null ? null : _m.Error.ToString(),
                                _m.Torrent.CreatedBy,
                                _m.Torrent.CreationDate,
                                _m.Torrent.Encoding,
                                _m.Torrent.IsPrivate,
                                _m.Torrent.PublisherUrl,
                                _m.Torrent.Publisher,
                                _m.CanUseDht);
                            DataSet1.generalRow row2 = dataset1.general[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    TorrHelper.Log(ex.Message);
                    //throw;
                }
                dataset1.general.WriteXml(TorrHelper.GeneralXMLPath);
                dataset1.trackers.WriteXml(TorrHelper.TrackersXMLPath);
                dataset1.files.WriteXml(TorrHelper.FilesXMLPath);
                dataset1.peers.WriteXml(TorrHelper.PeersXMLPath);
            }
        }

        internal void TickAdd()
        {
            lock (QueueAdd)
            {
                while (QueueAdd.Count > 0)
                {
                    String s = QueueAdd[0];
                    AddTorrent(s);
                    QueueAdd.Remove(s);                    
                }
            }
        }
        internal void TickRemove()
        {
            lock (QueueRemove)
            {
                while (QueueRemove.Count > 0)
                {
                    String s = QueueRemove[0];
                    Remove(s);
                    QueueRemove.Remove(s);
                }
            }
        }
        private void TickStop()
        {
            lock (QueueStop)
            {
                while (QueueStop.Count > 0)
                {
                    String s = QueueStop[0];
                    Stop(s);
                    QueueStop.Remove(s);
                }
            }
        }
        internal void TickPause()
        {
            lock (QueuePause)
            {
                while (QueuePause.Count > 0)
                {
                    String s = QueuePause[0];
                    Pause(s);
                    QueuePause.Remove(s);
                }
            }
        }
        internal void TickStart()
        {
            lock (QueueStart)
            {
                while (QueueStart.Count > 0)
                {
                    String s = QueueStart[0];
                    Start(s);
                    QueueStart.Remove(s);
                }
            }
        }
        internal void TickQuit()
        {
        }

        private TorrentManager FindTorrentManagerByInfoHash(String hash)
        {
            foreach (TorrentManager m in engine.Torrents)
            {
                if (m.InfoHash.ToString() == hash) return m;
            }
            return null;
        }       

        public void StartDht (ClientEngine engine, int port)
         {
             // Send/receive DHT messages on the specified port
             IPEndPoint listenAddress = new IPEndPoint (IPAddress.Any, port);
 
             // Create a listener which will process incoming/outgoing dht messages
             MonoTorrent.Dht.Listeners.DhtListener listener = new MonoTorrent.Dht.Listeners.DhtListener(listenAddress);
 
             // Create the dht engine
             DhtEngine dht = new DhtEngine (listener);
 
             // Connect the Dht engine to the MonoTorrent engine
             engine.RegisterDht (dht);
 
             // Start listening for dht messages and activate the DHT engine
             listener.Start ();
 
             // If there are existing DHT nodes stored on disk, load them
             // into the DHT engine so we can try and avoid a (very slow)
             // full bootstrap
             byte[] nodes = null;

             string path = TorrHelper.ConfFolder + "dht";
             if (File.Exists (path))
                 nodes = File.ReadAllBytes (path);
             dht.Start (nodes);
         }
 
         public void StopDht (DhtEngine dht, MonoTorrent.Dht.Listeners.DhtListener listener)
         {
             // Stop the listener and dht engine. This does not
             // clear internal data so the DHT can be started again
             // later without needing a full bootstrap.
             listener.Stop ();
             dht.Stop ();
 
             // Save all known dht nodes to disk so they can be restored
             // later. This is *highly* recommended as it makes startup
             // much much faster.
             File.WriteAllBytes(TorrHelper.ConfFolder + "dht", dht.SaveNodes());
         }

    }
}
