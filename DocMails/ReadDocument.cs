using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TikaOnDotNet.TextExtraction;

namespace DocMails
{
    class ReadDocument
    {
        public List<string> FolderFiles { get; set; }
        public HashSet<string> FoundEmails { get; set; }
        public List<string> FilesStatus { get; set; }
        public List<string> ErrorsList { get; set; }
        public int ProcessingFile { get; set; }

        private string FolderPath { get; set; }

        private const string emailRegex = @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

        public ReadDocument(string folderPath)
        {
            FolderPath = folderPath;
            FolderFiles = new List<string>();
            FoundEmails = new HashSet<string>();
            ErrorsList = new List<string>();
            FilesStatus = new List<string>();
            ProcessingFile = 0;
        }

        public List<string> GetFiles()
        {
            FolderFiles.Clear();

            foreach (string fileName in Directory.GetFiles(FolderPath))
            {
                if (fileName.EndsWith(".doc", StringComparison.Ordinal) ||
                    fileName.EndsWith(".docx", StringComparison.Ordinal) ||
                    fileName.EndsWith(".rtf", StringComparison.Ordinal) ||
                    fileName.EndsWith(".pdf", StringComparison.Ordinal))
                {
                    FolderFiles.Add(fileName);
                }
            }
            return FolderFiles;
        }

        public void ExtractEmailFromDoc(string docFile)
        {
            ProcessingFile++;
            var textExtractor = new TextExtractor();
            var result = textExtractor.Extract(docFile);

            var regex = new Regex(emailRegex);

            MatchCollection matches = regex.Matches(result.Text);
            if (matches.Count == 0)
            {
                ErrorsList.Add(docFile);
            }
            else
            {
                int count = 0;
                foreach (Match match in matches)
                {
                    string email = Regex.Replace(match.Value.ToString(), @"\s+", "");
                    FoundEmails.Add(email);
                    count++;
                }
                FilesStatus.Add(count + " : "+docFile);
            }
        }

        public void ClearData()
        {
            FoundEmails.Clear();
            FilesStatus.Clear();
            ErrorsList.Clear();
        }

        public void FinishExtraction()
        {
            Clipboard.Clear();
            ProcessingFile = 0;

            if (FoundEmails.Count > 0)
            {
                string clip = "";
                foreach (object item in FoundEmails) clip += item.ToString() + "\r\n";
                Clipboard.SetText(clip);
            }
        }
    }
}
