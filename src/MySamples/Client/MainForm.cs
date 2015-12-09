using MonoTorrent;
using MonoTorrent.Client;
using MonoTorrent.Client.Encryption;
using MonoTorrent.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace fanjun.UseMonoTorrent.Client
{
    public partial class MainForm : Form
    {
        ClientEngine m_engine;
        string m_torrentsPath;
        string m_downloadPath;

        public MainForm()
        {
            InitializeComponent();

            // Create a basic ClientEngine without changing any settings
            this.m_engine = new ClientEngine(new EngineSettings());

            this.m_torrentsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "torrents");
            if (!Directory.Exists(this.m_torrentsPath)) Directory.CreateDirectory(this.m_torrentsPath);

            this.m_downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "download");
            if (!Directory.Exists(this.m_downloadPath)) Directory.CreateDirectory(this.m_downloadPath);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string file;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "seed|*.torrent|all|*.*";
                dialog.CheckFileExists = true;
                dialog.Multiselect = false;
                dialog.InitialDirectory = m_torrentsPath;
                if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                file = dialog.FileName;
            }
            Torrent monoTorrent = Torrent.Load(file);
            this.txtMagnetUriScheme.Text = "magnet:?xt=urn:btih:" + monoTorrent.InfoHash.ToHex();
            //"magnet:?xt=urn:btih:" + BitConverter.ToString(monoTorrent.InfoHash.ToArray()).Replace("-", "");


            //InfoHash.FromHex(hash);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //string file = @"D:\WorkSpace\Visual Studio 2005\Projects\ZSocket\UseMonoTorrent\UseMonoTorrent\bin\Debug\new\dotnet.torrent";
            string file;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "seed|*.torrent|all|*.*";
                dialog.CheckFileExists = true;
                dialog.Multiselect = false;
                dialog.InitialDirectory = this.m_torrentsPath;
                if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                file = dialog.FileName;
            }
            DownloadTorrent(file, this.m_downloadPath);



            //EngineSettings settings = new EngineSettings();
            //settings.AllowedEncryption = EncryptionTypes.All;
            //settings.SavePath = savePath;

            //if (!Directory.Exists(settings.SavePath))
            //    Directory.CreateDirectory(settings.SavePath);

            //ClientEngine engine = new ClientEngine(settings);

            //engine.ChangeListenEndpoint(new IPEndPoint(IPAddress.Any, 6963));

            //Torrent torrent = Torrent.Load(@"D:\WorkSpace\Visual Studio 2005\Projects\ZSocket\UseMonoTorrent\UseMonoTorrent\bin\Debug\new\dotnet.torrent");

            //TorrentManager manager = new TorrentManager(torrent, engine.Settings.SavePath, new TorrentSettings());

            //engine.Register(manager);

            //manager.Start();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string file;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "all|*.*";
                dialog.CheckFileExists = true;
                dialog.Multiselect = false;
                if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                file = dialog.FileName;
            }
            
            string saveFile = Path.Combine(m_torrentsPath, Path.GetFileNameWithoutExtension(file) + VersionInfo.ClientVersion + ".torrent");

            try
            {
                CreateTorrent(file, saveFile);
            }
            catch (Exception ex)
            {
                AppendTextLine("CreateTorrent Error", ex);
            }
        }



        // 'path' is the location of the file/folder which is going to be converted to a torrent. 
        // 'savePath' is where the .torrent file will be saved.
        public void CreateTorrent(string path, string savePath)
        {
            // The class used for creating the torrent
            TorrentCreator c = new TorrentCreator();

            // Add one tier which contains two trackers
            RawTrackerTier tier = new RawTrackerTier();
            tier.Add(this.txtTracker.Text.Trim());

            c.Announces.Add(tier);
            c.Comment = "This is the comment";
            c.CreatedBy = "FanJun using " + VersionInfo.ClientVersion;
            c.Publisher = "FanJun";
            c.PieceLength = 256 * 1024;


            // Set the torrent as private so it will not use DHT or peer exchange
            // Generally you will not want to set this.
            //c.Private = true;

            // Every time a piece has been hashed, this event will fire. It is an
            // asynchronous event, so you have to handle threading yourself.
            c.Hashed += delegate(object o, TorrentCreatorEventArgs e)
            {
                AppendTextLine("Current File is {0}% hashed， Overall {1}% hashed， Total data to hash: {2}", 
                    e.FileCompletion, e.OverallCompletion, e.OverallSize);
            };

            // ITorrentFileSource can be implemented to provide the TorrentCreator
            // with a list of files which will be added to the torrent metadata.
            // The default implementation takes a path to a single file or a path
            // to a directory. If the path is a directory, all files will be
            // recursively added


            ITorrentFileSource fileSource = new TorrentFileSource(path);

            // Create the torrent file and save it directly to the specified path
            // Different overloads of 'Create' can be used to save the data to a Stream
            // or just return it as a BEncodedDictionary (its native format) so it can be
            // processed in memory
            c.Create(fileSource, savePath);
        }
        //shows how to create a torrent and load it without having to hash the data a second time
        public static void CreateAndLoadTorrent(ClientEngine engine, string path, string savePath)
        {
            // Instantiate a torrent creator
            TorrentCreator creator = new TorrentCreator();

            // Create a TorrentFileSource which is used to populate the .torrent
            ITorrentFileSource files = new TorrentFileSource(path);

            // Create the Torrent metadata blob
            MonoTorrent.BEncoding.BEncodedDictionary torrentDict = creator.Create(files);

            // Instantiate a torrent
            Torrent torrent = Torrent.Load(torrentDict);

            // Create a fake fast resume data with all the pieces set to true so we
            // don't have to hash the torrent when adding it directly to the engine.
            BitField bitfield = new BitField(torrent.Pieces.Count).Not();
            FastResume fastResumeData = new FastResume(torrent.InfoHash, bitfield);

            // Create a TorrentManager so the torrent can be downloaded and load
            // the FastResume data so we don't have to hash it again.
            TorrentManager manager = new TorrentManager(torrent, savePath, new TorrentSettings());
            manager.LoadFastResume(fastResumeData);

            // Register it with the engine and start the download
            engine.Register(manager);
            engine.StartAll();
        }

        public void DownloadTorrent(string path, string savePath)
        {
            // Open the .torrent file
            Torrent torrent = Torrent.Load(path);

            // Create the manager which will download the torrent to savePath
            // using the default settings.
            TorrentManager manager = new TorrentManager(torrent, savePath, new TorrentSettings());

            // Register the manager with the engine
            this.m_engine.Register(manager);

            // Begin the download. It is not necessary to call HashCheck on the manager
            // before starting the download. If a hash check has not been performed, the
            // manager will enter the Hashing state and perform a hash check before it
            // begins downloading.


            SelectiveDownload(manager);
            HashTorrent(manager);

            // If the torrent is fully downloaded already, calling 'Start' will place
            // the manager in the Seeding state.
            manager.Start();
        }

        public void SelectiveDownload(TorrentManager manager)
        {
            Torrent torrent = manager.Torrent;

            //// Don't download any files in the 'Docs' subfolder
            //foreach (TorrentFile file in torrent.Files)
            //{
            //    if (file.Path.StartsWith("Docs"))
            //        file.Priority = Priority.DoNotDownload;
            //}

            //// Prioritise everything in the 'Data' subfolder
            //foreach (TorrentFile file in torrent.Files)
            //{
            //    if (file.Path.StartsWith("Data"))
            //        file.Priority = Priority.High;
            //}

            // Get all '.txt' files first
            foreach (TorrentFile file in torrent.Files)
            {
                switch (Path.GetExtension(file.Path).ToLower())
                {
                    case ".exe":
                    case ".txt":
                        file.Priority = Priority.Immediate;
                        break;
                    default:
                        break;
                }
            }
        }

        public void HashTorrent(TorrentManager manager)
        {
            // Note: The manager must be in the 'Stopped' state in order to perform
            // a hash check. Also, to make the sample easier the event handler
            // is not unregistered. In your application be careful you don't
            // accidentally attach a new event handler every time the torrent is hashed
            manager.PieceHashed += delegate(object o, PieceHashedEventArgs e)
            {
                int pieceIndex = e.PieceIndex;
                int totalPieces = e.TorrentManager.Torrent.Pieces.Count;
                double progress = (double)pieceIndex / totalPieces * 100.0;
                if (e.HashPassed)
                    AppendTextLine("Piece {0} of {1} is complete", pieceIndex, totalPieces);
                else
                    AppendTextLine("Piece {0} of {1} is corrupt or incomplete ", pieceIndex, totalPieces);

                // This shows how complete the hashing is.
                AppendTextLine("Total progress is: {0}%", progress);

                // This shows the percentage completion of the download. This value
                // is updated as the torrent is hashed or new pieces are downloaded
                AppendTextLine("{0}% of the torrent is complete");
            };

            // If 'true' is passed, the torrent will automatically go to the 'Downloading' or 'Seeding'
            // state once the hash check is finished. Otherwise it will return to the 'Stopped' state.
            manager.HashCheck(false);
        }

        public void StopTorrent(TorrentManager manager)
        {
            // When stopping a torrent, certain cleanup tasks need to be perfomed
            // such as flushing unwritten data to disk and informing the tracker
            // the client is no longer downloading/seeding the torrent. To allow for
            // this, when Stop is called the manager enters a 'Stopping' state. Once
            // all the tasks are completed the manager will enter the 'Stopped' state.

            // Hook into the TorrentStateChanged event so we can tell when the torrent
            // finishes cleanup
            manager.TorrentStateChanged += delegate(object o, TorrentStateChangedEventArgs e)
            {
                if (e.NewState == TorrentState.Stopping)
                {
                    AppendTextLine("Torrent {0} has begun stopping", e.TorrentManager.Torrent.Name);
                }
                else if (e.NewState == TorrentState.Stopped)
                {
                    // It is now safe to unregister the torrent from the engine and dispose of it (if required)
                    m_engine.Unregister(manager);
                    manager.Dispose();

                    AppendTextLine("Torrent {0} has stopped", e.TorrentManager.Torrent.Name);
                }
            };

            // Begin the process to stop the torrent
            manager.Stop();
        }

        //public void SaveFastResume(List<TorrentManager> managers)
        //{
        //    // Store the fast resume for each torrent in a list,
        //    // then serialise the list to the disk.
        //    MonoTorrent.BEncoding.BEncodedList list = new MonoTorrent.BEncoding.BEncodedList();
        //    foreach (TorrentManager manager in managers)
        //    {

        //        // Get the fast resume data for the torrent
        //        FastResume data = manager.SaveFastResume();

        //        // Encode the FastResume data to a BEncodedDictionary.
        //        MonoTorrent.BEncoding.BEncodedDictionary fastResume = data.Encode();

        //        // Add the FastResume dictionary to the main dictionary using
        //        // the torrents infohash as the key
        //        list.Add(data);
        //    }

        //    // Write all the fast resume data to disk
        //    File.WriteAllBytes(fastResumePath, list.Encode());
        //}

        //public void LoadFastResume(List<TorrentManager> managers)
        //{
        //    // Read the main dictionary from disk and iterate through
        //    // all the fast resume items
        //    MonoTorrent.BEncoding.BEncodedList list = 
        //        (MonoTorrent.BEncoding.BEncodedList)MonoTorrent.BEncoding.BEncodedValue.Decode(File.ReadAllBytes(fastResumePath));
        //    foreach (MonoTorrent.BEncoding.BEncodedDictionary fastResume in list)
        //    {

        //        // Decode the FastResume data from the BEncodedDictionary
        //        FastResume data = new FastResume(fastResume);

        //        // Find the torrentmanager that the fastresume belongs to
        //        // and then load it
        //        foreach (TorrentManager manager in managers)
        //            if (manager.InfoHash == data.Infohash)
        //                manager.LoadFastResume(data);
        //    }
        //}


        #region >> 辅助 <<

        private void AppendTextLine(string text, bool outputTime)
        {
            string textLine;
            if (outputTime)
            {
                textLine = string.Format("[{0}]{1}\n",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffffff"), text ?? string.Empty);
            }
            else
            {
                textLine = (text ?? "") + "\n";
            }

            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(delegate { this.AppendTextLine(text, outputTime); }));
            }
            else
            {
                if (outputTime)
                {
                    textLine = string.Format("[{0}]{1}\n",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffffff"), text ?? string.Empty);
                }
                else
                {
                    textLine = (text ?? "") + "\n";
                }

                this.WriteFileLog(textLine);

                if (this.chkShowLog.Checked)
                {
                    this.rtbLog.Text += textLine;
                    this.rtbLog.SelectionStart = this.rtbLog.Text.Length - 1;
                    this.rtbLog.SelectionLength = 0;
                    this.rtbLog.ScrollToCaret();
                }
            }
        }
        private void AppendTextLine(string text)
        {
            this.AppendTextLine(text, true);
        }
        private void AppendTextLine(string formatText, params object[] args)
        {
            this.AppendTextLine(string.Format(formatText, args), true);
        }


        private string m_LogFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            "Log\\log_" + DateTime.Now.ToString("yyyyMMdd") + ".txt");
        private StreamWriter m_logWriter;
        private void WriteFileLog(string text)
        {
            if (text == null || !text.Contains("<异常>"))
                return;

            try
            {
                if (this.m_logWriter == null)
                {
                    lock (this.m_LogFilePath)
                    {
                        if (this.m_logWriter == null)
                        {
                            string dirPath = Path.GetDirectoryName(this.m_LogFilePath);
                            if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);

                            this.m_logWriter = new System.IO.StreamWriter(this.m_LogFilePath, true,
                                System.Text.Encoding.Default);
                        }
                    }
                }

                this.m_logWriter.Write(text);
            }
            catch { }
        }

        #endregion
    }
}
