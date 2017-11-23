namespace DocMails
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorsList = new System.Windows.Forms.ListBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.filesStatus = new System.Windows.Forms.ListBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.copyToClip = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.emailsList = new System.Windows.Forms.ListBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.filesList = new System.Windows.Forms.ListBox();
            this.startProcess = new System.Windows.Forms.Button();
            this.openFolder = new System.Windows.Forms.Button();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.fileProcessing = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.infoButton);
            this.panel1.Controls.Add(this.copyToClip);
            this.panel1.Controls.Add(this.gb2);
            this.panel1.Controls.Add(this.gb1);
            this.panel1.Controls.Add(this.startProcess);
            this.panel1.Controls.Add(this.openFolder);
            this.panel1.Controls.Add(this.folderPath);
            this.panel1.Controls.Add(this.statusStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 361);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(575, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(297, 287);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(289, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Błędy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorsList
            // 
            this.errorsList.ContextMenuStrip = this.contextMenu;
            this.errorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorsList.FormattingEnabled = true;
            this.errorsList.Location = new System.Drawing.Point(3, 3);
            this.errorsList.Name = "errorsList";
            this.errorsList.Size = new System.Drawing.Size(283, 255);
            this.errorsList.TabIndex = 0;
            this.errorsList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.errorsList_MouseDown);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(135, 26);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(134, 22);
            this.openFile.Text = "Otwórz plik";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.filesStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(289, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Status plików";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // filesStatus
            // 
            this.filesStatus.ContextMenuStrip = this.contextMenu;
            this.filesStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesStatus.FormattingEnabled = true;
            this.filesStatus.HorizontalScrollbar = true;
            this.filesStatus.Location = new System.Drawing.Point(3, 3);
            this.filesStatus.Name = "filesStatus";
            this.filesStatus.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.filesStatus.Size = new System.Drawing.Size(283, 255);
            this.filesStatus.TabIndex = 2;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(851, 12);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(25, 23);
            this.infoButton.TabIndex = 10;
            this.infoButton.Text = "?";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // copyToClip
            // 
            this.copyToClip.Enabled = false;
            this.copyToClip.Location = new System.Drawing.Point(600, 10);
            this.copyToClip.Name = "copyToClip";
            this.copyToClip.Size = new System.Drawing.Size(113, 23);
            this.copyToClip.TabIndex = 9;
            this.copyToClip.Text = "Kopiuj do schowka";
            this.copyToClip.UseVisualStyleBackColor = true;
            this.copyToClip.Click += new System.EventHandler(this.copyToClip_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.emailsList);
            this.gb2.Location = new System.Drawing.Point(325, 41);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(244, 287);
            this.gb2.TabIndex = 7;
            this.gb2.TabStop = false;
            this.gb2.Text = "Znalezione emaile";
            // 
            // emailsList
            // 
            this.emailsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailsList.FormattingEnabled = true;
            this.emailsList.Location = new System.Drawing.Point(3, 16);
            this.emailsList.Name = "emailsList";
            this.emailsList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.emailsList.Size = new System.Drawing.Size(238, 268);
            this.emailsList.TabIndex = 3;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.filesList);
            this.gb1.Location = new System.Drawing.Point(12, 39);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(304, 289);
            this.gb1.TabIndex = 6;
            this.gb1.TabStop = false;
            this.gb1.Text = "Lista plików";
            // 
            // filesList
            // 
            this.filesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesList.FormattingEnabled = true;
            this.filesList.Location = new System.Drawing.Point(3, 16);
            this.filesList.Name = "filesList";
            this.filesList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.filesList.Size = new System.Drawing.Size(298, 270);
            this.filesList.TabIndex = 2;
            // 
            // startProcess
            // 
            this.startProcess.Enabled = false;
            this.startProcess.Location = new System.Drawing.Point(515, 10);
            this.startProcess.Name = "startProcess";
            this.startProcess.Size = new System.Drawing.Size(79, 23);
            this.startProcess.TabIndex = 5;
            this.startProcess.Text = "Start";
            this.startProcess.UseVisualStyleBackColor = true;
            this.startProcess.Click += new System.EventHandler(this.startProcess_Click);
            // 
            // openFolder
            // 
            this.openFolder.Location = new System.Drawing.Point(12, 10);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(32, 23);
            this.openFolder.TabIndex = 4;
            this.openFolder.Text = "...";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(50, 12);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(459, 20);
            this.folderPath.TabIndex = 3;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBar,
            this.fileProcessing});
            this.statusStrip.Location = new System.Drawing.Point(0, 339);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(884, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(500, 16);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // fileProcessing
            // 
            this.fileProcessing.Name = "fileProcessing";
            this.fileProcessing.Size = new System.Drawing.Size(0, 17);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "DocMails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gb2.ResumeLayout(false);
            this.gb1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startProcess;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.ListBox emailsList;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.ListBox filesList;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button copyToClip;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox errorsList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox filesStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripStatusLabel fileProcessing;
    }
}

