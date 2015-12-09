
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace torrenut
{
    class TorrHelper
    {
        private static String logFile = null;

        public static String bytesToString(long bytes)
        {
            if (bytes > 1000000000) return ((double)bytes / (1024 * 1024 * 1024)).ToString("0.00")+ " GB";
            if (bytes > 1000000) return ((double)bytes / (1024 * 1024)).ToString("0.00") + " MB";
            return ((double)bytes / 1024).ToString("0.00") + " KB";
        }
        public static String bitsSpeedToString(long bytes)
        {
            if (bytes > 1000000000) return ((double)bytes / (1024 * 1024 * 1024)).ToString("0.00") + " Gb/s";
            if (bytes > 1000000) return ((double)bytes / (1024 * 1024)).ToString("0.00") + " Mb/s";
            return ((double)bytes / 1024).ToString("0.00") + " Kb/s";
        }

        public static void Log(String s)
        {
            if(logFile == null) {
                //logFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\torrenut\\log_" + DateTime.Now.ToFileTime() + ".txt";
                logFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\torrenut\\log.txt";
                if (!File.Exists(logFile))
                {
                    FileStream stream = File.Create(logFile);
                    stream.Close();
                }
            }
            {
                StreamWriter sw = File.AppendText(logFile);
                sw.WriteLine(DateTime.Now.ToFileTimeUtc() + ": " + s);
                sw.Close();
            }
        }

        public static String XMLTorr
        {
            get
            {
                return ConfFolder + "torr.xml";
            }
        }
        public static String ConfFolder
        {
            get 
            {
                String folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\torrenut\\";
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                return folder;
            }            
        }
        public static String GeneralXMLPath
        {
            get
            {
                return ConfFolder + "general.xml";
            }
        }
        public static String TrackersXMLPath
        {
            get
            {
                return ConfFolder + "trackers.xml";
            }
        }
        public static String FilesXMLPath
        {
            get
            {
                return ConfFolder + "files.xml";
            }
        }
        public static String PeersXMLPath
        {
            get
            {
                return ConfFolder + "peers.xml";
            }
        }

        public static String ConstructTorrentErrorMessage(MonoTorrent.Client.Error err)
        {
            String _s = "";
            try
            {
                _s = err.Reason.ToString();
            }
            catch (Exception ex)
            {
            }
            try
            {
                _s += " : " + err.Exception.Message;
            }
            catch (Exception ex)
            {
            }
            try
            {
                _s += ":" + err.Exception.Source;
            }
            catch (Exception ex)
            {
            }

            return _s;
        }
    }
}
