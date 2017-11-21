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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.filesStatus = new System.Windows.Forms.ListBox();
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
            this.copyToClip = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gb3.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infoButton);
            this.panel1.Controls.Add(this.copyToClip);
            this.panel1.Controls.Add(this.gb3);
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
            // gb3
            // 
            this.gb3.Controls.Add(this.filesStatus);
            this.gb3.Location = new System.Drawing.Point(575, 41);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(301, 287);
            this.gb3.TabIndex = 8;
            this.gb3.TabStop = false;
            this.gb3.Text = "Status";
            // 
            // filesStatus
            // 
            this.filesStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesStatus.FormattingEnabled = true;
            this.filesStatus.HorizontalScrollbar = true;
            this.filesStatus.Location = new System.Drawing.Point(3, 16);
            this.filesStatus.Name = "filesStatus";
            this.filesStatus.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.filesStatus.Size = new System.Drawing.Size(295, 268);
            this.filesStatus.TabIndex = 0;
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
            this.progressBar});
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
            this.progressBar.Size = new System.Drawing.Size(300, 16);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
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
            this.gb3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.ListBox emailsList;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.ListBox filesList;
        private System.Windows.Forms.ListBox filesStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button copyToClip;
        private System.Windows.Forms.Button infoButton;
    }
}

