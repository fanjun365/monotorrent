using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using MonoTorrent;
using MonoTorrent.Dht;
using MonoTorrent.Client;
using System.IO;
using MonoTorrent.Client.Tracker;
using MonoTorrent.Common;
using System.Threading;

namespace torrenut
{
    public partial class TorrenutMainForm : Form
    {
        bool reallyClose = false;
        public static String TorrentsDir;
        public static readonly int TorrenutVersion = 30500;

        private bool UpdateTabsFirstTime = true;
        public BindingList<TorrentManager> list2 = new BindingList<TorrentManager>();

        DataSet1 dataSet1 = new DataSet1();

        private bool m_Quiting = false;

        public TorrenutMainForm()
        {
            ConfigurationStation.Load();
            if (Directory.Exists(ConfigurationStation.DownloadsInProgressPath))
            {
               // Directory.Delete(ConfigurationStation.DownloadsInProgressPath, true);
            }

            List<String> _xmlfiles = new List<string>();
            _xmlfiles.Add(TorrHelper.GeneralXMLPath);
            _xmlfiles.Add(TorrHelper.FilesXMLPath);
            _xmlfiles.Add(TorrHelper.PeersXMLPath);
            _xmlfiles.Add(TorrHelper.TrackersXMLPath);

            foreach (String filepath in _xmlfiles)
            {
                if (File.Exists(filepath))
                    File.Delete(filepath);
            }

            InitializeComponent();
  
            dataGridView1.AutoGenerateColumns = true;
                  
            System.Windows.Forms.Timer upgradesTimer = new System.Windows.Forms.Timer();
            upgradesTimer.Tick += upgradesTimer_Tick;
            upgradesTimer.Interval = 1000 * 3600 * 24;
            upgradesTimer.Start();
        }

        void upgradesTimer_Tick(object sender, EventArgs e)
        {
            CheckForNewVersion();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            
            CheckForNewVersion();

            contextMenuStrip_torrents.Opened += contextMenuStrip_torrents_Opened;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;

            dataGridView1.DataSource = bindingSource1;
            bindingSource1.DataSource = dataSet1.torrents;

            dataGridView_general.DataSource = dataSet1.general;
            dataGridView_peers.DataSource = dataSet1.peers;
            dataGridView_files.DataSource = dataSet1.files;
            dataGridView_trackers.DataSource = dataSet1.trackers;

            dataGridView1.Columns["Name"].DisplayIndex = 0;
            dataGridView1.Columns["DotTorrentPath"].Visible = false;
            dataGridView1.Columns["InfoHash"].Visible = false;

            dataGridView1.Columns["Downloaded"].Width = 65;
            dataGridView1.Columns["Uploaded"].Width = 65;
            dataGridView1.Columns["DownloadSpeed"].Width =65;
            dataGridView1.Columns["UploadSpeed"].Width = 65;
            dataGridView1.Columns["PeersAvailable"].Width = 65;
            dataGridView1.Columns["Leechs"].Width = 65;
            dataGridView1.Columns["Seeds"].Width = 65;
            dataGridView1.Columns["Size"].Width = 65;
            dataGridView1.Columns["Progress"].Width = 65;
            dataGridView1.Columns["State"].Width = 65;
            dataGridView1.Columns["Name"].Width = 250;


            dataGridView_peers.Columns["InfoHash"].DisplayIndex = 1;
            dataGridView_peers.Columns["InfoHash"].Visible = false;
            dataGridView_peers.Columns["PeerId"].Visible = false;

            dataGridView_files.Columns["Filename"].DisplayIndex = 0;
            dataGridView_files.Columns["InfoHash"].DisplayIndex = 1;
            dataGridView_files.Columns["InfoHash"].Visible = false;
            //dataGridView_files.Columns["Size"].Width = 70;
            //dataGridView_files.Columns["Downloaded"].Width = 70;

            dataGridView_trackers.Columns["InfoHash"].DisplayIndex = 1;
            dataGridView_trackers.Columns["InfoHash"].Visible = false;
            dataGridView_trackers.Columns["id"].Visible = false;

            
            backgroundWorker1.RunWorkerAsync();
        }

        void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //try
            //{
            //    if (e.Button == MouseButtons.Right)
            //    {
            //        this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //        //contextMenuStrip_torrents.Show(this.dataGridView1, new Point(e.RowIndex, e.ColumnIndex));
            //        //contextMenuStrip_torrents.Show(this.dataGridView1, new Point(e.RowIndex, e.ColumnIndex));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
        }



        void contextMenuStrip_torrents_Opened(object sender, EventArgs e)
        {
            String ih = CurrentSingleSelectedInfoHash;
            int sdg = 1;
            //throw new NotImplementedException();
        }

        private void CheckForNewVersion()
        {

            backgroundWorker_updateChecker.DoWork += delegate(object sender, DoWorkEventArgs e)
            {
                bool newVersion = UpdateChecker.NewVersionAvailable();
                if (newVersion)
                {
                    this.Invoke((MethodInvoker)delegate()
                    {
                        notifyIcon_upgrade.Visible = true;
                        notifyIcon_upgrade.BalloonTipTitle = "New version";
                        notifyIcon_upgrade.BalloonTipText = "New version available!";
                        notifyIcon_upgrade.ShowBalloonTip(1000 * 3600 * 24);
                    });                    
                }
            };
            backgroundWorker_updateChecker.RunWorkerAsync();       
        }

        private void SaveDatagridviewColumns()
        {           
        }

        public String CurrentSingleSelectedInfoHash
        {
            get
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataRowView w = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                    DataSet1.torrentsRow r = (DataSet1.torrentsRow)w.Row;
                    return r.InfoHash.ToString();
                }
                return null;
            }
        }

        private void ToggleVisible()
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ToggleVisible();
        }

        private String[] InfoHashListOfSelectedRows
        {
            get
            {
                List<String> slist = new List<string>();
                DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow r in rows)
                {
                    object oooo = r.DataBoundItem;
                    if (r != null && r.DataBoundItem != null)
                    {
                        DataSet1.torrentsRow row = (DataSet1.torrentsRow)((DataRowView)r.DataBoundItem).Row;
                        slist.Add(row.InfoHash);
                    }
                }

                return slist.ToArray();
            }
        }

        private void button_remove_torrent_Click(object sender, EventArgs e)
        {
            Remove();
        }
        private void Remove()
        {
            foreach (String s in InfoHashListOfSelectedRows)
            {
                lock (TorrentsOrganizer.QueueRemove)
                {
                    TorrentsOrganizer.QueueRemove.Add(s);
                }
            }
        }

        private void button_resume_Click(object sender, EventArgs e)
        {
            Resume();         
        }

        private void Resume()
        {
            foreach (String s in InfoHashListOfSelectedRows)
            {
                lock (TorrentsOrganizer.QueueStart)
                {
                    TorrentsOrganizer.QueueStart.Add(s);
                }
            }
        }
        private void button_stop_torrent_Click(object sender, EventArgs e)
        {
            Stop();
        }
        private void Stop()
        {
            foreach (String s in InfoHashListOfSelectedRows)
            {
                lock (TorrentsOrganizer.QueueStop)
                {
                    TorrentsOrganizer.QueueStop.Add(s);
                }
            }
        }

        private void dsToolStripMenuItem_quit_Click(object sender, EventArgs e)
        {
            reallyClose = true;
            Close();
        }

        
        private void button_add_torrents(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            // textBox1.Text = "";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                //   textBox1.Text = openFileDialog1.FileName;
                foreach (String fn in openFileDialog1.FileNames)
                {
                    lock (TorrentsOrganizer.QueueAdd)
                    {
                        TorrentsOrganizer.QueueAdd.Add(fn);
                    }
                }
                tabControl_upper.SelectTab(0);
            }

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button_pause_torrent_Click(object sender, EventArgs e)
        {
            Pause();
        }
        private void Pause()
        {
            foreach (String s in InfoHashListOfSelectedRows)
            {
                lock (TorrentsOrganizer.QueuePause)
                {
                    TorrentsOrganizer.QueuePause.Add(s);
                }
            }
        }
        private void OpenFileLocation()
        {
            List<String> _folders = new List<string>();

            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            foreach (DataGridViewRow r in rows)
            {
                object oooo = r.DataBoundItem;
                if (r != null && r.DataBoundItem != null)
                {
                    DataSet1.torrentsRow row = (DataSet1.torrentsRow)((DataRowView)r.DataBoundItem).Row;
                    if (!_folders.Contains(row.SavePath)) _folders.Add(row.SavePath);
                }
            }

            foreach (String f in _folders)
            {
                System.Diagnostics.Process.Start("explorer.exe", "/select," + f);
            }
        }

        private void notifyIcon_upgrade_Click(object sender, EventArgs e)
        {
            if (!notifyIcon_upgrade.Visible) return;
            OpenUpgradeLink();
        }

        private void notifyIcon_upgrade_BalloonTipClicked(object sender, EventArgs e)
        {
            if (!notifyIcon_upgrade.Visible) return;
            OpenUpgradeLink();
        }

        private void OpenUpgradeLink()
        {
            System.Diagnostics.Process.Start("http://torrenut.com/?upgrade=1");
            notifyIcon_upgrade.Visible = false;
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            ToggleVisible();
        }      


        

        private void torrenutForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (reallyClose && m_Quiting)
            {
                return;
            }
            if (reallyClose)
            {
                SaveDatagridviewColumns();
                //backgroundWorker1.CancelAsync();
                m_Quiting = true;
                e.Cancel = true;
                return;
            }
            this.Hide();
            e.Cancel = true;
            notifyIcon1.ShowBalloonTip(5000);
        
        }

        private void UpdateDataset(DataSet1 ds)
        {
            // remove from datasource items that are now more in ds
            for (int i = dataSet1.torrents.Count - 1; i >= 0; i--)
            {
                if (ds.torrents.Rows.Find(dataSet1.torrents[i].InfoHash) == null)
                {
                    dataSet1.torrents.RemovetorrentsRow(dataSet1.torrents[i]);
                }
            }

            // add new items to ds
            foreach (DataSet1.torrentsRow r in ds.torrents)
            {
                if (dataSet1.torrents.Rows.Find(r.InfoHash) == null)
                {

                    DataSet1.torrentsRow newRow = ((DataSet1.torrentsRow)ds.torrents.Rows.Find(r.InfoHash));
                    dataSet1.torrents.ImportRow(newRow);
                }
            }

            foreach(DataSet1.torrentsRow r in dataSet1.torrents)
            {
                DataSet1.torrentsRow rSource = (DataSet1.torrentsRow)ds.torrents.Rows.Find(r.InfoHash);
                DataSet1.torrentsRow rDest = (DataSet1.torrentsRow)dataSet1.torrents.Rows.Find(r.InfoHash);

                rDest.Leechs = rSource.Leechs;
                rDest.Seeds = rSource.Seeds;
                rDest.State = rSource.State;
                //rDest.DotTorrentPath = rSource.DotTorrentPath;
                rDest.Progress = rSource.Progress;
                rDest.UploadSpeed = rSource.UploadSpeed;
                rDest.DownloadSpeed = rSource.DownloadSpeed;
                rDest.Uploaded = rSource.Uploaded;
                rDest.Downloaded = rSource.Downloaded;
                rDest.Name = rSource.Name;
                
            }
            
            try
            {
                DataSet1 dataset_temp = new DataSet1();

                dataset_temp.general.ReadXml(TorrHelper.GeneralXMLPath);
                dataset_temp.trackers.ReadXml(TorrHelper.TrackersXMLPath);
                dataset_temp.files.ReadXml(TorrHelper.FilesXMLPath);
                dataset_temp.peers.ReadXml(TorrHelper.PeersXMLPath);

                dataSet1.general.Clear();
                foreach (DataSet1.generalRow r in dataset_temp.general)
                {
                    dataSet1.general.ImportRow(r);
                }

                for (int i = dataSet1.trackers.Count - 1; i >= 0; i--)
                {
                    DataSet1.trackersRow r = dataSet1.trackers[i];
                    object o = dataset_temp.trackers.FindByInfoHashUriid(r.InfoHash, r.Uri, r.id);
                    if (o == null)
                    {
                        dataSet1.trackers.RemovetrackersRow(r);
                    }
                }
                foreach (DataSet1.trackersRow r in dataset_temp.trackers)
                {
                    object o = dataSet1.trackers.FindByInfoHashUriid(r.InfoHash, r.Uri, r.id);
                    if(o==null) dataSet1.trackers.ImportRow(r);                                       
                }
                for (int i = dataSet1.trackers.Count - 1; i >= 0; i--)
                {
                    DataSet1.trackersRow rDest = dataSet1.trackers[i];
                    DataSet1.trackersRow rSrc = dataset_temp.trackers.FindByInfoHashUriid(rDest.InfoHash, rDest.Uri, rDest.id);

                    rDest.InfoHash = rSrc.InfoHash;
                    rDest.id = rSrc.id;
                    rDest.Uri = rSrc.Uri;
                   
                }










                for (int i = dataSet1.files.Count - 1; i >= 0; i--)
                {
                    DataSet1.filesRow r = dataSet1.files[i];
                    object o = dataset_temp.files.FindByInfoHashFullPath(r.InfoHash, r.FullPath);
                    if (o == null)
                    {
                        dataSet1.files.RemovefilesRow(r);
                    }
                }
                foreach (DataSet1.filesRow r in dataset_temp.files)
                {
                    object o = dataSet1.files.FindByInfoHashFullPath(r.InfoHash, r.FullPath);
                    if (o == null) dataSet1.files.ImportRow(r);
                }
                for (int i = dataSet1.files.Count - 1; i >= 0; i--)
                {
                    DataSet1.filesRow rDest = dataSet1.files[i];
                    DataSet1.filesRow rSrc = dataset_temp.files.FindByInfoHashFullPath(rDest.InfoHash, rDest.FullPath);

                    rDest.InfoHash = rSrc.InfoHash;
                    rDest.FullPath = rSrc.FullPath;
                    rDest.Filename = rSrc.Filename;
                    rDest.Size = rSrc.Size;
                    rDest.Downloaded = rSrc.Downloaded;
                    
                }
















                for (int i = dataSet1.peers.Count - 1; i >= 0; i--)
                {
                    DataSet1.peersRow r = dataSet1.peers[i];
                    object o = dataset_temp.peers.FindByUriInfoHashPeerId(r.InfoHash, r.Uri, r.PeerId);
                    if (o == null)
                    {
                        dataSet1.peers.RemovepeersRow(r);
                    }
                }
                foreach (DataSet1.peersRow r in dataset_temp.peers)
                {
                    object o = dataSet1.peers.FindByUriInfoHashPeerId(r.InfoHash, r.Uri,r.PeerId);
                    if (o == null) dataSet1.peers.ImportRow(r);
                }
                for (int i = dataSet1.peers.Count - 1; i >= 0; i--)
                {
                    DataSet1.peersRow rDest = dataSet1.peers[i];
                    DataSet1.peersRow rSrc = dataset_temp.peers.FindByUriInfoHashPeerId(rDest.InfoHash, rDest.Uri, rDest.PeerId);

                    rDest.InfoHash = rSrc.InfoHash;
                    rDest.Uri = rSrc.Uri;
                    rDest.UploadSpeed = rSrc.UploadSpeed;
                    rDest.DownloadSpeed = rSrc.DownloadSpeed;
                    rDest.Downloaded = rSrc.Downloaded;
                    rDest.Uploaded = rSrc.Uploaded;
                    rDest.PeerId = rSrc.PeerId;
                }



                

            }
            catch (Exception ex)
            {
                TorrHelper.Log(ex.Message);
                //throw;
            }
        }


        

        private void contextMenuStrip_torrents_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {            
            if (e.ClickedItem == startresumeToolStripMenuItem)
            {
                Resume();   
            }
            if (e.ClickedItem == stopToolStripMenuItem)
            {
                Stop();
            }
            if (e.ClickedItem == pauseToolStripMenuItem)
            {
                Pause();
            }
            if (e.ClickedItem == removeToolStripMenuItem)
            {
                Remove();
            }
            if (e.ClickedItem == removeTorrentDataToolStripMenuItem)
            {
                MessageBox.Show("remove + delete data not supported yet");
            }
            if (e.ClickedItem == openContainingFolderToolStripMenuItem)
            {
                OpenFileLocation();
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
                    
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            String columnNAme = dataGridView1.Columns[e.ColumnIndex].Name;


            if (columnNAme == "Progress")
            {
                e.Value = ( ((double)e.Value)/(100) ).ToString("P2");
               
            }
            if (columnNAme == "DownloadSpeed" || columnNAme == "UploadSpeed")
            {
                e.Value = TorrHelper.bitsSpeedToString((int)e.Value);
               
            }
            if (columnNAme == "Downloaded" || columnNAme == "Uploaded" || columnNAme == "Size")
            {
                e.Value = TorrHelper.bytesToString((long)e.Value);

            } 
       
        }

        private void dataGridView_peers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            String columnNAme = ((DataGridView)sender).Columns[e.ColumnIndex].Name;


            if (columnNAme == "Progress")
            {
                e.Value = (((double)e.Value) / (100)).ToString("P2");

            }
            if (columnNAme == "DownloadSpeed" || columnNAme == "UploadSpeed")
            {
                e.Value = TorrHelper.bitsSpeedToString((int)e.Value);

            }
            if (columnNAme == "Downloaded" || columnNAme == "Uploaded" || columnNAme == "Size")
            {
                e.Value = TorrHelper.bytesToString((long)e.Value);

            } 
        }

        private void dataGridView_files_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            String columnNAme = ((DataGridView)sender).Columns[e.ColumnIndex].Name;


            if (columnNAme == "Progress")
            {
                e.Value = (((double)e.Value) / (100)).ToString("P2");

            }
            if (columnNAme == "DownloadSpeed" || columnNAme == "UploadSpeed")
            {
                e.Value = TorrHelper.bitsSpeedToString((int)e.Value);

            }
            if (columnNAme == "Downloaded" || columnNAme == "Uploaded" || columnNAme == "Size")
            {
                object eva = e.Value;
                e.Value = TorrHelper.bytesToString((long)e.Value);

            } 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            TorrentsOrganizer organizer = new TorrentsOrganizer();
            int counterQuiting = 0;

            organizer.StartupAll();

                                 
            int _interval = 50;

            while (organizer.TorrentEngine != null)
            {
                if (m_Quiting)
                {
                    counterQuiting++;
                    organizer.StopAndSaveAllTorrents();

                    if ( organizer.m_allStopped || counterQuiting > 8)
                    {
                        organizer.SaveFastResume();

                        this.Invoke((MethodInvoker)delegate()
                        {
                            Close();
                        });
                    }
                    
                }
                

                if(organizer != null && organizer.TorrentEngine != null)
                {
                    Thread.Sleep(_interval);
                    while (_interval < 2000)
                    {
                        _interval += 50;
                    }

                    this.Invoke((MethodInvoker)delegate()
                    {
                        organizer.SetCurrentSelectedSingleManager(CurrentSingleSelectedInfoHash);
                    });

                    organizer.Tick();

                    this.Invoke((MethodInvoker)delegate()
                    {
                        DataSet1 s1 = (DataSet1)organizer.dataset1.Copy();
                        UpdateDataset(s1);

                        String _Dht = "DHT: " + organizer.TorrentEngine.DhtEngine.State.ToString();
                        String _up = TorrHelper.bitsSpeedToString(organizer.TorrentEngine.TotalUploadSpeed);
                        string _down = TorrHelper.bitsSpeedToString(organizer.TorrentEngine.TotalDownloadSpeed);


                        toolStripStatusLabel1.Text  = _Dht + ", upload speed: " + _up + " download speed: " + _down;
                    });
                }

            }
        }

    }
}
