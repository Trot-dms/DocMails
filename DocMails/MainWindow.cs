using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DocMails
{
    public partial class MainWindow : Form
    {
        private ReadDocument readDocument;
        private const string FINISH = "Koniec";
        private const string FINISH_OK = "Zakończono przeszukiwanie plików";
        private const string READING = "Czytam...";
        private const string WARNING = "Uwaga.";
        private const string CLIP_COPY = "Zawartość skopiowano do schowka.";
        private const string ABOUT_INFO = "Program do przeszukiwania dokumentów (doc, docx, pdf)\n" +
                "pod kątem wyszukiwania adresów email.\n" +
                "Wykorzystuje port biblioteki Apache Tika.\n\n" +
                "Autor : Kamil Golis." +
                "\n\nProgram na licencji Open Source (Apache 2.0)";
        private const string ABOUT = "O programie";

        public MainWindow()
        {
            InitializeComponent();
        }


        private void openFolder_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();

            string folderPathString = folderDialog.SelectedPath;
            if (!string.IsNullOrEmpty(folderPathString))
            {
                filesList.Items.Clear();
                filesStatus.Items.Clear();
                readDocument = new ReadDocument(folderPathString);
                folderPath.Text = folderPathString;
                startProcess.Enabled = true;
                fillFolderList(readDocument.GetFiles());
            }
            else
            {
                startProcess.Enabled = false;
            }

        }

        private void startProcess_Click(object sender, EventArgs e)
        {
            if (readDocument != null)
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = filesList.Items.Count + 1;
                progressBar.Value = 1;
                fileProcessing.Text = READING;
                disableButtons();
                emailsList.Items.Clear();
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void disableButtons()
        {
            startProcess.Enabled = false;
            openFolder.Enabled = false;
            copyToClip.Enabled = false;
        }

        private void enableButtons()
        {
            startProcess.Enabled = true;
            openFolder.Enabled = true;
            copyToClip.Enabled = true;
        }

        private void fillFolderList(List<string> files)
        {
            foreach (string fileName in files)
            {
                filesList.Items.Add(fileName);
            }
        }

        private void fillStatusList(ReadDocument document)
        {
            errorsList.Items.AddRange(document.ErrorsList.ToArray());
            filesStatus.Items.AddRange(document.FilesStatus.ToArray());
        }

        private void fillEmailList(ReadDocument document)
        {
            emailsList.Items.AddRange(document.FoundEmails.ToArray());
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = readDocument.ProcessingFile;
            fileProcessing.Text = readDocument.ProcessingFile + " / " + filesList.Items.Count;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fillEmailList(readDocument);
            fillStatusList(readDocument);
            readDocument.FinishExtraction();
            progressBar.Value = 0;
            fileProcessing.Text = "";
            enableButtons();
            MessageBox.Show(FINISH_OK, FINISH, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            readDocument.ClearData();
            foreach (string fileName in readDocument.FolderFiles)
            {
                readDocument.ExtractEmailFromDoc(fileName);
                backgroundWorker.ReportProgress(readDocument.ProcessingFile);
            }
        }

        private void copyToClip_Click(object sender, EventArgs e)
        {
            readDocument.FinishExtraction();
            MessageBox.Show(CLIP_COPY, WARNING, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ABOUT_INFO, ABOUT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            string selectedFile = errorsList.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedFile))
            {
                System.Diagnostics.Process.Start(selectedFile);
            }
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (errorsList.SelectedItem != null)
            {
                contextMenu.Enabled = true;
            }
            else
            {
                contextMenu.Enabled = false;
            }
        }

        private void errorsList_MouseDown(object sender, MouseEventArgs e)
        {
            errorsList.SelectedIndex = errorsList.IndexFromPoint(e.X, e.Y);
        }
    }
}
