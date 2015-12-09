using MonoTorrent;
using MonoTorrent.Client;
using MonoTorrent.Client.Encryption;
using MonoTorrent.Client.Tracker;
using MonoTorrent.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace torrenut
{
    public class TorrentManagerGridLine
    {
        [Browsable(false)]
        public String SavePathReal
        {
            get;
            set;
        }

        public String SavePath
        {
            get;
            //{
            //    return torrentManager.SavePath;
            //}
            set;
        }

        public String Torrent
        {
            set;
            get;
            //{
            //    return torrentManager.Torrent.Name;
            //}            
        }

        public InfoHash InfoHash {
            get;
            set;

        //    get {
        //    return torrentManager.InfoHash;
        //}  
        }

        public String Peers
        {
            get;
            set;
            //get
            //{
            //    return torrentManager.Peers.Seeds + "(" + torrentManager.Peers.Available + ")";
            //}
        }

        public String Leechs
        {
            //get
            //{
            //    return torrentManager.Peers.Leechs + "";
            //}
            get;
            set;
        }

        public String Progress
        {
            get;
            set;
            //get
            //{
            //    return String.Format("{0,2:P2}", torrentManager.Progress / 100);
            //}
        }


        public TorrentState State
        {
            get;
            set;
            //get
            //{
            //    return torrentManager.State;
            //}
        }

        public String DownloadSpeed
        {
            get;
            set;
            //get
            //{
            //    TorrHelper.Log("TorrentManagerGridLine.DownloadSpeed " + DateTime.Now.ToLongTimeString());
            //    return TorrHelper.bitsSpeedToString( manager.Monitor.DownloadSpeed);
            //}
        }
        public String UploadSpeed
        {
            get;
            set;

            //get
            //{
            //    return TorrHelper.bitsSpeedToString(manager.Monitor.UploadSpeed);
            //}
        }
        public String Size
        {
            get;
            set;
            //get
            //{
            //    return TorrHelper.bytesToString(manager.Torrent.Size);
            //}
        }
        //public int Availability
        //{
        //    get;
        //    set;
        //    get
        //    {
        //        return -1;
        //    }
        //}
        public String Error
        {
            get;
            set;

            //get
            //{
            //    String _s = "";
            //    try
            //    {
            //        _s = torrentManager.Error.Reason.ToString();
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //    try
            //    {
            //        _s += " : " + torrentManager.Error.Exception.Message;
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //    try
            //    {
            //        _s += ":" + torrentManager.Error.Exception.Source;
            //    }
            //    catch (Exception ex)
            //    {
            //    }

            //    return _s;
            //}
        }

        //[Browsable(false)]    
        //public TorrentGridLine  TorrentGridLine
        //{
        //    get
        //    {
        //        if (manager == null || manager.Torrent == null || manager.Torrent.AnnounceUrls == null) return null;

        //        TorrentGridLine line = new TorrentGridLine();

        //        line.Comment = manager.Torrent.Comment;
        //        line.CreatedBy = manager.Torrent.CreatedBy;
        //        line.CreationDate = manager.Torrent.CreationDate;
        //        line.ED2K = manager.Torrent.ED2K == null ? "" : manager.Torrent.ED2K.ToString();
        //        line.Encoding = manager.Torrent.Encoding;
        //        foreach(String _seed in manager.Torrent.GetRightHttpSeeds)
        //        {
        //            line.GetRightHttpSeeds += _seed;
        //        }
                
        //        line.IsPrivate = manager.Torrent.IsPrivate;
        //        line.Name = manager.Torrent.Name;
        //        line.Nodes = manager.Torrent.Nodes == null ? null: manager.Torrent.Nodes.ToString();
        //        line.PieceLength = manager.Torrent.PieceLength;
        //        line.Pieces = manager.Torrent.Pieces.ToString();
        //        line.Publisher = manager.Torrent.Publisher;
        //        line.PublisherUrl = manager.Torrent.PublisherUrl;
        //        line.SHA1 = manager.Torrent.SHA1 == null ? null :  manager.Torrent.SHA1.ToString();
        //        line.Size = TorrHelper.bytesToString(manager.Torrent.Size);
        //        line.Source = manager.Torrent.Source;
                
        //        return line;

        //    }
        //}

        //[Browsable(false)] 
        //public MonitorGridLine MonitorGridLine
        //{
        //    get
        //    {
        //        MonitorGridLine line = new MonitorGridLine();
        //        line.DataBytesDownloaded = TorrHelper.bytesToString(manager.Monitor.DataBytesDownloaded);
        //        line.DataBytesUploaded = TorrHelper.bytesToString(manager.Monitor.DataBytesUploaded);

        //        line.DownloadSpeed = TorrHelper.bitsSpeedToString(manager.Monitor.DownloadSpeed);
        //        line.UploadSpeed = TorrHelper.bitsSpeedToString(manager.Monitor.UploadSpeed);

        //        line.ProtocolBytesDownloaded = TorrHelper.bytesToString(manager.Monitor.ProtocolBytesDownloaded);
        //        line.ProtocolBytesUploaded = TorrHelper.bytesToString(manager.Monitor.ProtocolBytesUploaded);

        //        return line;
        //    }
        //}

        //[Browsable(false)] 
        //public BindingList<TorrentFileGridLine> TorrentFileGridLineList
        //{
        //    get
        //    {
        //        if (manager == null || manager.Torrent == null || manager.Torrent.Files == null) return null;

        //        BindingList<TorrentFileGridLine> list = new BindingList<TorrentFileGridLine>();
        //        foreach (TorrentFile file in manager.Torrent.Files)
        //        {
        //            TorrentFileGridLine line = new TorrentFileGridLine();

        //            line.BitField = file.BitField== null ? null : file.BitField.ToString();
        //            line.BytesDownloaded = TorrHelper.bytesToString( file.BytesDownloaded);
        //            line.ED2K = file.ED2K == null ? null : file.ED2K.ToString();
        //            line.EndPieceIndex = file.EndPieceIndex;
        //            line.Path = file.Path;
        //            line.Length = TorrHelper.bytesToString( file.Length);
        //            line.MD5 = file.MD5== null ? null :file.MD5.ToString();
                    

        //            list.Add(line);
        //        }
        //        return list;
                
        //    }
        //}

        //[Browsable(false)] 
        //public BindingList<PeerIdGridLine> PeerIdGridLineList
        //{
        //    get
        //    {
                
        //        if (manager == null || manager.GetPeers() == null) return null;
        //        BindingList<PeerIdGridLine> list = new BindingList<PeerIdGridLine>();
        //        foreach(PeerId peer in manager.GetPeers())
        //        {                    
        //            PeerIdGridLine line = new PeerIdGridLine();

        //            line.AmChoking = peer.AmChoking;
        //            line.AmInterested = peer.AmInterested;
        //            line.AmRequestingPiecesCount = peer.AmRequestingPiecesCount;
        //            line.BitField = peer.BitField == null ? null : peer.BitField.ToString();
        //            line.ClientApp = peer.ClientApp.ToString();
        //            line.IsChoking = peer.IsChoking;
        //            line.IsConnected = peer.IsConnected;
        //            line.IsInterested = peer.IsInterested;
        //            line.IsRequestingPiecesCount = peer.IsRequestingPiecesCount;
        //            line.IsSeeder = peer.IsSeeder;
        //            if (peer.Monitor != null)
        //            {
        //                line.Downloaded = TorrHelper.bytesToString (peer.Monitor.DataBytesDownloaded) ;
        //                line.Uploaded = TorrHelper.bytesToString(peer.Monitor.DataBytesUploaded) ;

        //                line.UploadSpeed  = TorrHelper.bitsSpeedToString ( peer.Monitor.UploadSpeed ) ;
        //                line.DownloadeSpeed = TorrHelper.bitsSpeedToString(peer.Monitor.DownloadSpeed) ;
        //            }
        //            line.PeerID = peer.PeerID;
        //            line.PiecesReceived = peer.PiecesReceived;
        //            line.PiecesSent = peer.PiecesSent;
        //            line.SupportsFastPeer = peer.SupportsFastPeer;
        //            line.SupportsLTMessages = peer.SupportsLTMessages;
        //            line.Uri = peer.Uri== null ? null : peer.Uri.ToString();
                                                                                                 
        //            list.Add(line);
        //        }
        //        return list;
        //    }
        //}
    }

    //public class TorrentGridLine
    //{
    //    public TorrentGridLine()
    //    {            
    //    }

    //    [Browsable(false)]
    //    public Torrent Torrent
    //    {
    //        get;
    //        set;
    //    }



    //    public string Comment{
    //        get;
    //        set;
    //    }
    //    public string CreatedBy{
    //        get;
    //        set;
    //    }
    //    public DateTime CreationDate{
    //        get;
    //        set;
    //    }
    //    public String ED2K{
    //        get;
    //        set;
    //    }
    //    public string Encoding{
    //        get;
    //        set;
    //    }

    //    public bool IsPrivate{
    //        get;
    //        set;
    //    }
    //    public string Name{
    //        get;
    //        set;
    //    }
    //    public String Nodes{
    //        get;
    //        set;
    //    }
    //    public int PieceLength{
    //        get;
    //        set;
    //    }
    //    public String Pieces{
    //        get;
    //        set;
    //    }
    //    public string Publisher{
    //        get;
    //        set;
    //    }
    //    public string PublisherUrl{
    //        get;
    //        set;
    //    }
    //    public String SHA1{
    //        get;
    //        set;
    //    }
    //    public String Size{
    //        get;
    //        set;
    //    }
    //    public string Source{
    //        get;
    //        set;
    //    }
    //    public string TorrentPath{
    //        get;
    //        set;
    //    }
    //    public String GetRightHttpSeeds{
    //        get;
    //        set;
    //    }

    //}
    //public class TorrentFileGridLine
    //{
    //    public TorrentFileGridLine()
    //    {
        
    //    }

    //    [Browsable(false)]
    //    public TorrentFile TorrentFile
    //    {
    //        get;
    //        set;
    //    }

    //    public String BitField{
    //        get;
    //        set;
    //    }
    //    public String BytesDownloaded{
    //        get;
    //        set;
    //    }
    //    public String ED2K
    //    {
    //        get;
    //        set;
    //    }
    //    public int EndPieceIndex{
    //        get;
    //        set;
    //    }
    //    public string Path{
    //        get;
    //        set;
    //    }
    //    public String Length{
    //        get;
    //        set;
    //    }
    //    public String MD5
    //    {
    //        get;
    //        set;
    //    }

    //}

    //public class MonitorGridLine
    //{
    //    public MonitorGridLine()
    //    {
    //    }
    //    public String DataBytesDownloaded
    //    {
    //        get;
    //        set;
    //    }

    //    public String DataBytesUploaded
    //    {
    //        get;
    //        set;
    //    }

    //    public String DownloadSpeed
    //    {
    //        get;
    //        set;
    //    }

    //    public String ProtocolBytesDownloaded
    //    {
    //        get;
    //        set;
    //    }

    //    public String ProtocolBytesUploaded
    //    {
    //        get;
    //        set;
    //    }

    //    public String UploadSpeed
    //    {
    //        get;
    //        set;
    //    }

    //}

    //public class PeerIdGridLine
    //{       
    //    public PeerIdGridLine()
    //    {
    //    }

    //    [Browsable(false)]
    //    public PeerId PeerId
    //    {
    //        get;
    //        set;
    //    }

    //    public bool AmChoking{
    //        get;
    //        set;
    //    }
    //    public bool AmInterested{
    //        get;
    //        set;
    //    }
    //    public int AmRequestingPiecesCount{
    //        get;
    //        set;
    //    }
    //    public String BitField
    //    {
    //        get;
    //        set;
    //    }
    //    public String ClientApp
    //    {
    //        get;
    //        set;
    //    }

    //    public int HashFails{
    //        get;
    //        set;
    //    }
    //    public bool IsChoking{
    //        get;
    //        set;
    //    }
    //    public bool IsConnected{
    //        get;
    //        set;
    //    }
    //    public bool IsInterested{
    //        get;
    //        set;
    //    }
    //    public bool IsSeeder{
    //        get;
    //        set;
    //    }
    //    public int IsRequestingPiecesCount{
    //        get;
    //        set;
    //    }
    //    public String Downloaded
    //    {
    //        get;
    //        set;
    //    }
    //    public String Uploaded
    //    {
    //        get;
    //        set;
    //    }

    //    public String DownloadeSpeed
    //    {
    //        get;
    //        set;
    //    }
    //    public String UploadSpeed
    //    {
    //        get;
    //        set;
    //    }

    //    public string PeerID{
    //        get;
    //        set;
    //    }
    //    public int PiecesSent{
    //        get;
    //        set;
    //    }
    //    public int PiecesReceived{
    //        get;
    //        set;
    //    }
    //    public bool SupportsFastPeer{
    //        get;
    //        set;
    //    }
    //    public bool SupportsLTMessages{
    //        get;
    //        set;
    //    }
    //    public String Uri
    //    {
    //        get;
    //        set;
    //    }
    //}
}
