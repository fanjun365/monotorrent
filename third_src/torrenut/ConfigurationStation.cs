using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace torrenut
{
    class ConfigurationStation
    {
        
        public static void Load()
        {
            ConfigurationStation.DownloadsInProgressPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\torrents";
            ConfigurationStation.EnableDHT = false;
            ConfigurationStation.Port = 6881;
            ConfigurationStation.DHTPort = 6882;

            try
            {
                if(!File.Exists(TorrHelper.ConfFolder+ "settings.xml"))
                {
                    return;
                }
                DataSet1.configurationDataTable table = new DataSet1.configurationDataTable();
                table.ReadXml( TorrHelper.ConfFolder+ "settings.xml");

                DataSet1.configurationRow row = table[0];

                DownloadsInProgressPath = row.DownloadDir;
                EnableDHT = row.DHT;
                Port = row.port;
                DHTPort = 6882;
                DHTPort = row.DHTPort;
            }
            catch (Exception ex)
            {
                TorrHelper.Log(ex.Message);
                //throw;
            }
            Save();
        }
        public static void Save()
        {
            DataSet1.configurationDataTable table = new DataSet1.configurationDataTable();
            table.AddconfigurationRow(Port, DownloadsInProgressPath, EnableDHT, 0, 0, DHTPort);
            table.WriteXml(TorrHelper.ConfFolder + "settings.xml");
        }
        public static String DownloadsInProgressPath
        {
            get;
            set;
        }

        public static int Port
        {
            get;
            set;
        }

        private static Boolean _enableDht = false;
        public static Boolean EnableDHT
        {
            get
            {
                return _enableDht;
            }
            set
            {
                if (value == true)
                {
                }
                _enableDht = value;
            }
        }

        public static int DHTPort
        {
            get;
            set;
        }
    }
}
