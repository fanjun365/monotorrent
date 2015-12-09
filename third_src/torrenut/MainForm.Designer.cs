namespace torrenut
{
    partial class TorrenutMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TorrenutMainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl_upper = new System.Windows.Forms.TabControl();
            this.tabPage_torrents = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_torrents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startresumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTorrentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_addtorrents = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage_settings = new System.Windows.Forms.TabPage();
            this.preferencesUI1 = new torrenut.PreferencesUI();
            this.tabControl_lower = new System.Windows.Forms.TabControl();
            this.tabPage_general = new System.Windows.Forms.TabPage();
            this.dataGridView_general = new System.Windows.Forms.DataGridView();
            this.tabPage_peers = new System.Windows.Forms.TabPage();
            this.dataGridView_peers = new System.Windows.Forms.DataGridView();
            this.tabPage_files = new System.Windows.Forms.TabPage();
            this.dataGridView_files = new System.Windows.Forms.DataGridView();
            this.tabPage_trackers = new System.Windows.Forms.TabPage();
            this.dataGridView_trackers = new System.Windows.Forms.DataGridView();
            this.tabPage_log = new System.Windows.Forms.TabPage();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dsToolStripMenuItem_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_resume = new System.Windows.Forms.Button();
            this.button_remove_torrent = new System.Windows.Forms.Button();
            this.button_stop_torrent = new System.Windows.Forms.Button();
            this.button_pause_torrent = new System.Windows.Forms.Button();
            this.torrenutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notifyIcon_upgrade = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_updateChecker = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl_upper.SuspendLayout();
            this.tabPage_torrents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip_torrents.SuspendLayout();
            this.tabPage_addtorrents.SuspendLayout();
            this.tabPage_settings.SuspendLayout();
            this.tabControl_lower.SuspendLayout();
            this.tabPage_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_general)).BeginInit();
            this.tabPage_peers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_peers)).BeginInit();
            this.tabPage_files.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_files)).BeginInit();
            this.tabPage_trackers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_trackers)).BeginInit();
            this.tabPage_log.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.torrenutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 63);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl_upper);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl_lower);
            this.splitContainer1.Size = new System.Drawing.Size(742, 346);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabControl_upper
            // 
            this.tabControl_upper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_upper.Controls.Add(this.tabPage_torrents);
            this.tabControl_upper.Controls.Add(this.tabPage_addtorrents);
            this.tabControl_upper.Controls.Add(this.tabPage_settings);
            this.tabControl_upper.Location = new System.Drawing.Point(8, 4);
            this.tabControl_upper.Name = "tabControl_upper";
            this.tabControl_upper.SelectedIndex = 0;
            this.tabControl_upper.Size = new System.Drawing.Size(731, 190);
            this.tabControl_upper.TabIndex = 0;
            // 
            // tabPage_torrents
            // 
            this.tabPage_torrents.Controls.Add(this.dataGridView1);
            this.tabPage_torrents.Location = new System.Drawing.Point(4, 22);
            this.tabPage_torrents.Name = "tabPage_torrents";
            this.tabPage_torrents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_torrents.Size = new System.Drawing.Size(723, 164);
            this.tabPage_torrents.TabIndex = 0;
            this.tabPage_torrents.Text = "torrents";
            this.tabPage_torrents.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip_torrents;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(710, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // contextMenuStrip_torrents
            // 
            this.contextMenuStrip_torrents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contextMenuStrip_torrents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startresumeToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.toolStripSeparator1,
            this.removeToolStripMenuItem,
            this.removeTorrentDataToolStripMenuItem,
            this.toolStripSeparator2,
            this.openContainingFolderToolStripMenuItem});
            this.contextMenuStrip_torrents.Name = "contextMenuStrip";
            this.contextMenuStrip_torrents.Size = new System.Drawing.Size(196, 148);
            this.contextMenuStrip_torrents.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_torrents_ItemClicked);
            // 
            // startresumeToolStripMenuItem
            // 
            this.startresumeToolStripMenuItem.Name = "startresumeToolStripMenuItem";
            this.startresumeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.startresumeToolStripMenuItem.Text = "start/resume";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.stopToolStripMenuItem.Text = "stop";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.pauseToolStripMenuItem.Text = "pause";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.removeToolStripMenuItem.Text = "remove torrent only";
            // 
            // removeTorrentDataToolStripMenuItem
            // 
            this.removeTorrentDataToolStripMenuItem.Name = "removeTorrentDataToolStripMenuItem";
            this.removeTorrentDataToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.removeTorrentDataToolStripMenuItem.Text = "remove torrent + data";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // openContainingFolderToolStripMenuItem
            // 
            this.openContainingFolderToolStripMenuItem.Name = "openContainingFolderToolStripMenuItem";
            this.openContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openContainingFolderToolStripMenuItem.Text = "open containing folder";
            // 
            // tabPage_addtorrents
            // 
            this.tabPage_addtorrents.Controls.Add(this.button1);
            this.tabPage_addtorrents.Location = new System.Drawing.Point(4, 22);
            this.tabPage_addtorrents.Name = "tabPage_addtorrents";
            this.tabPage_addtorrents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_addtorrents.Size = new System.Drawing.Size(723, 164);
            this.tabPage_addtorrents.TabIndex = 1;
            this.tabPage_addtorrents.Text = "add torrents";
            this.tabPage_addtorrents.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_add_torrents);
            // 
            // tabPage_settings
            // 
            this.tabPage_settings.Controls.Add(this.preferencesUI1);
            this.tabPage_settings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_settings.Name = "tabPage_settings";
            this.tabPage_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_settings.Size = new System.Drawing.Size(723, 164);
            this.tabPage_settings.TabIndex = 2;
            this.tabPage_settings.Text = "settings";
            this.tabPage_settings.UseVisualStyleBackColor = true;
            // 
            // preferencesUI1
            // 
            this.preferencesUI1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesUI1.AutoScroll = true;
            this.preferencesUI1.Location = new System.Drawing.Point(7, 7);
            this.preferencesUI1.Name = "preferencesUI1";
            this.preferencesUI1.Size = new System.Drawing.Size(710, 151);
            this.preferencesUI1.TabIndex = 0;
            // 
            // tabControl_lower
            // 
            this.tabControl_lower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_lower.Controls.Add(this.tabPage_general);
            this.tabControl_lower.Controls.Add(this.tabPage_peers);
            this.tabControl_lower.Controls.Add(this.tabPage_files);
            this.tabControl_lower.Controls.Add(this.tabPage_trackers);
            this.tabControl_lower.Controls.Add(this.tabPage_log);
            this.tabControl_lower.Location = new System.Drawing.Point(4, 4);
            this.tabControl_lower.Name = "tabControl_lower";
            this.tabControl_lower.SelectedIndex = 0;
            this.tabControl_lower.Size = new System.Drawing.Size(735, 138);
            this.tabControl_lower.TabIndex = 0;
            // 
            // tabPage_general
            // 
            this.tabPage_general.Controls.Add(this.dataGridView_general);
            this.tabPage_general.Location = new System.Drawing.Point(4, 22);
            this.tabPage_general.Name = "tabPage_general";
            this.tabPage_general.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_general.Size = new System.Drawing.Size(727, 112);
            this.tabPage_general.TabIndex = 0;
            this.tabPage_general.Text = "general";
            this.tabPage_general.UseVisualStyleBackColor = true;
            // 
            // dataGridView_general
            // 
            this.dataGridView_general.AllowUserToAddRows = false;
            this.dataGridView_general.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_general.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_general.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_general.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_general.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_general.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_general.Name = "dataGridView_general";
            this.dataGridView_general.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_general.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_general.RowTemplate.ReadOnly = true;
            this.dataGridView_general.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_general.ShowEditingIcon = false;
            this.dataGridView_general.Size = new System.Drawing.Size(727, 116);
            this.dataGridView_general.TabIndex = 0;
            // 
            // tabPage_peers
            // 
            this.tabPage_peers.Controls.Add(this.dataGridView_peers);
            this.tabPage_peers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_peers.Name = "tabPage_peers";
            this.tabPage_peers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_peers.Size = new System.Drawing.Size(727, 112);
            this.tabPage_peers.TabIndex = 1;
            this.tabPage_peers.Text = "peers";
            this.tabPage_peers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_peers
            // 
            this.dataGridView_peers.AllowUserToAddRows = false;
            this.dataGridView_peers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_peers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_peers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_peers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_peers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_peers.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_peers.Name = "dataGridView_peers";
            this.dataGridView_peers.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_peers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_peers.Size = new System.Drawing.Size(727, 116);
            this.dataGridView_peers.TabIndex = 0;
            this.dataGridView_peers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_peers_CellFormatting);
            // 
            // tabPage_files
            // 
            this.tabPage_files.Controls.Add(this.dataGridView_files);
            this.tabPage_files.Location = new System.Drawing.Point(4, 22);
            this.tabPage_files.Name = "tabPage_files";
            this.tabPage_files.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_files.Size = new System.Drawing.Size(727, 112);
            this.tabPage_files.TabIndex = 3;
            this.tabPage_files.Text = "files";
            this.tabPage_files.UseVisualStyleBackColor = true;
            // 
            // dataGridView_files
            // 
            this.dataGridView_files.AllowUserToAddRows = false;
            this.dataGridView_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_files.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_files.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_files.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_files.Name = "dataGridView_files";
            this.dataGridView_files.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_files.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_files.Size = new System.Drawing.Size(727, 116);
            this.dataGridView_files.TabIndex = 0;
            this.dataGridView_files.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_files_CellFormatting);
            // 
            // tabPage_trackers
            // 
            this.tabPage_trackers.Controls.Add(this.dataGridView_trackers);
            this.tabPage_trackers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_trackers.Name = "tabPage_trackers";
            this.tabPage_trackers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_trackers.Size = new System.Drawing.Size(727, 112);
            this.tabPage_trackers.TabIndex = 9;
            this.tabPage_trackers.Text = "trackers";
            this.tabPage_trackers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_trackers
            // 
            this.dataGridView_trackers.AllowUserToAddRows = false;
            this.dataGridView_trackers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_trackers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_trackers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_trackers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_trackers.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_trackers.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_trackers.Name = "dataGridView_trackers";
            this.dataGridView_trackers.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_trackers.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView_trackers.Size = new System.Drawing.Size(731, 116);
            this.dataGridView_trackers.TabIndex = 0;
            // 
            // tabPage_log
            // 
            this.tabPage_log.Controls.Add(this.richTextBox_log);
            this.tabPage_log.Location = new System.Drawing.Point(4, 22);
            this.tabPage_log.Name = "tabPage_log";
            this.tabPage_log.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_log.Size = new System.Drawing.Size(727, 112);
            this.tabPage_log.TabIndex = 10;
            this.tabPage_log.Text = "log";
            this.tabPage_log.UseVisualStyleBackColor = true;
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_log.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(727, 116);
            this.richTextBox_log.TabIndex = 0;
            this.richTextBox_log.Text = "";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Click here to restore torrenut";
            this.notifyIcon1.BalloonTipTitle = "torrenut";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "torrenut";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsToolStripMenuItem_quit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(96, 26);
            // 
            // dsToolStripMenuItem_quit
            // 
            this.dsToolStripMenuItem_quit.Name = "dsToolStripMenuItem_quit";
            this.dsToolStripMenuItem_quit.Size = new System.Drawing.Size(95, 22);
            this.dsToolStripMenuItem_quit.Text = "quit";
            this.dsToolStripMenuItem_quit.Click += new System.EventHandler(this.dsToolStripMenuItem_quit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // button_resume
            // 
            this.button_resume.Image = global::torrenut.Properties.Resources.Button_Play;
            this.button_resume.Location = new System.Drawing.Point(15, 12);
            this.button_resume.Name = "button_resume";
            this.button_resume.Size = new System.Drawing.Size(73, 44);
            this.button_resume.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_resume, "Start");
            this.button_resume.UseVisualStyleBackColor = true;
            this.button_resume.Click += new System.EventHandler(this.button_resume_Click);
            // 
            // button_remove_torrent
            // 
            this.button_remove_torrent.Image = global::torrenut.Properties.Resources.Button_Delete;
            this.button_remove_torrent.Location = new System.Drawing.Point(256, 13);
            this.button_remove_torrent.Name = "button_remove_torrent";
            this.button_remove_torrent.Size = new System.Drawing.Size(74, 44);
            this.button_remove_torrent.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_remove_torrent, "Remove");
            this.button_remove_torrent.UseVisualStyleBackColor = true;
            this.button_remove_torrent.Click += new System.EventHandler(this.button_remove_torrent_Click);
            // 
            // button_stop_torrent
            // 
            this.button_stop_torrent.Image = global::torrenut.Properties.Resources.Button_Stop;
            this.button_stop_torrent.Location = new System.Drawing.Point(175, 12);
            this.button_stop_torrent.Name = "button_stop_torrent";
            this.button_stop_torrent.Size = new System.Drawing.Size(75, 45);
            this.button_stop_torrent.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_stop_torrent, "Stop");
            this.button_stop_torrent.UseVisualStyleBackColor = true;
            this.button_stop_torrent.Click += new System.EventHandler(this.button_stop_torrent_Click);
            // 
            // button_pause_torrent
            // 
            this.button_pause_torrent.Image = global::torrenut.Properties.Resources.Button_Pause;
            this.button_pause_torrent.Location = new System.Drawing.Point(94, 12);
            this.button_pause_torrent.Name = "button_pause_torrent";
            this.button_pause_torrent.Size = new System.Drawing.Size(75, 44);
            this.button_pause_torrent.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_pause_torrent, "Pause");
            this.button_pause_torrent.UseVisualStyleBackColor = true;
            this.button_pause_torrent.Click += new System.EventHandler(this.button_pause_torrent_Click);
            // 
            // notifyIcon_upgrade
            // 
            this.notifyIcon_upgrade.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_upgrade.Icon")));
            this.notifyIcon_upgrade.Text = "new version available";
            this.notifyIcon_upgrade.BalloonTipClicked += new System.EventHandler(this.notifyIcon_upgrade_BalloonTipClicked);
            this.notifyIcon_upgrade.Click += new System.EventHandler(this.notifyIcon_upgrade_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // torrenutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 434);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_resume);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button_remove_torrent);
            this.Controls.Add(this.button_stop_torrent);
            this.Controls.Add(this.button_pause_torrent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "torrenutForm";
            this.Text = "torrenut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.torrenutForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl_upper.ResumeLayout(false);
            this.tabPage_torrents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip_torrents.ResumeLayout(false);
            this.tabPage_addtorrents.ResumeLayout(false);
            this.tabPage_settings.ResumeLayout(false);
            this.tabControl_lower.ResumeLayout(false);
            this.tabPage_general.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_general)).EndInit();
            this.tabPage_peers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_peers)).EndInit();
            this.tabPage_files.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_files)).EndInit();
            this.tabPage_trackers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_trackers)).EndInit();
            this.tabPage_log.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.torrenutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_pause_torrent;
        private System.Windows.Forms.Button button_stop_torrent;
        private System.Windows.Forms.Button button_remove_torrent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button_resume;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl_upper;
        private System.Windows.Forms.TabPage tabPage_torrents;
        private System.Windows.Forms.TabPage tabPage_addtorrents;
        private System.Windows.Forms.TabPage tabPage_settings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dsToolStripMenuItem_quit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource torrenutBindingSource;
        private PreferencesUI preferencesUI1;
        private System.Windows.Forms.NotifyIcon notifyIcon_upgrade;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl_lower;
        private System.Windows.Forms.TabPage tabPage_general;
        private System.Windows.Forms.DataGridView dataGridView_general;
        private System.Windows.Forms.TabPage tabPage_peers;
        private System.Windows.Forms.DataGridView dataGridView_peers;
        private System.Windows.Forms.TabPage tabPage_files;
        private System.Windows.Forms.DataGridView dataGridView_files;
        private System.Windows.Forms.TabPage tabPage_trackers;
        private System.Windows.Forms.DataGridView dataGridView_trackers;
        private System.Windows.Forms.TabPage tabPage_log;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_updateChecker;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_torrents;
        private System.Windows.Forms.ToolStripMenuItem startresumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeTorrentDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

