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

        public MainWindow()
        {
            InitializeComponent();
        }


        private void openFolder_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();

            String folderPathString = folderDialog.SelectedPath;
            if (!folderPathString.Equals(""))
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

        private void fillStatusList(Dictionary<string, string> filesStatuses)
        {
            filesStatus.Items.Add("Błędy:");
            List<string> errList = new List<string>();
            List<string> okList = new List<string>();

            foreach (KeyValuePair<string, string> kv in filesStatuses)
            {
                if (kv.Value.Equals("Nie znaleziono."))
                {
                    errList.Add(kv.Key);
                }
                else
                {
                    okList.Add(kv.Key + " : " + kv.Value);
                }
            }
            filesStatus.Items.AddRange(errList.ToArray());
            filesStatus.Items.Add("\n");
            filesStatus.Items.AddRange(okList.ToArray());
        }

        private void fillEmailList(HashSet<string> emails)
        {
            emailsList.Items.AddRange(emails.ToArray());
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = readDocument.ProcessingFile;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fillEmailList(readDocument.FoundEmails);
            fillStatusList(readDocument.FileStatus);
            readDocument.FinishExtraction();
            progressBar.Value = 0;
            enableButtons();
            MessageBox.Show("Zakończono przeszukiwanie plików.", "Koniec", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Zawartość skopiowano do schowka.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program do przeszukiwania dokumentów (doc, docx, pdf)\n" +
                "pod kątem wyszukiwania adresów email.\n" +
                "Wykorzystuje port biblioteki Apache Tika.\n\n" +
                "Autor : Kamil Golis.", "O programie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
