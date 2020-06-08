using PdfMerger.Objects;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.IO;
using System.Windows.Forms;

namespace PdfMerger
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Title = "Select PDF files to merge",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "pdf",
                Filter = "PDF files (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,

                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog.FileNames)
                {
                    FileList.Items.Add(new PdfEntry(file));
                }
            }


        }

        private void Remove_Click(object sender, EventArgs e)
        {
            FileList.Items.RemoveAt(FileList.SelectedIndex);
        }

        private void MoveTop_Click(object sender, EventArgs e)
        {
            object File = FileList.SelectedItem;
            FileList.Items.Remove(File);
            FileList.Items.Insert(0, File);
            FileList.SetSelected(0, true);
        }

        private void MoveBottom_Click(object sender, EventArgs e)
        {
            object File = FileList.SelectedItem;
            FileList.Items.Remove(File);
            FileList.Items.Insert(FileList.Items.Count - 1, File);
            FileList.SetSelected(FileList.Items.Count - 1, true);
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            int NewIndex = FileList.SelectedIndex - 1;
            // if the new index is not invalid then continue, else do nothing
            if (!(NewIndex < 0))
            {
                object File = FileList.SelectedItem;
                FileList.Items.Remove(File);
                FileList.Items.Insert(NewIndex, File);
                FileList.SetSelected(NewIndex, true);
            }
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            int NewIndex = FileList.SelectedIndex + 1;
            if (!(NewIndex >= FileList.Items.Count))
            {
                object File = FileList.SelectedItem;
                FileList.Items.Remove(File);
                FileList.Items.Insert(NewIndex, File);
                FileList.SetSelected(NewIndex, true);
            }
        }

        private void Merge_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Title = "Select where you want to save your PDF",

                CheckPathExists = true,

                DefaultExt = "pdf",
                Filter = "PDF files (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PdfDocument output = new PdfDocument();
                foreach (PdfEntry File in FileList.Items)
                {
                    PdfDocument newPdf = PdfReader.Open(File.FilePath, PdfDocumentOpenMode.Import);
                    for (int i = 0; i < newPdf.PageCount; i++)
                    {
                        output.AddPage(newPdf.Pages[i]);
                    }
                }

                output.Save(saveFileDialog.FileName);

                MessageBox.Show("Succesfully saved " + Path.GetFileName(saveFileDialog.FileName));
            }
        }
    }
}
