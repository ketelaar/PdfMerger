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
            var openFileDialog = new OpenFileDialog
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

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            foreach (var file in openFileDialog.FileNames)
            {
                FileList.Items.Add(new PdfEntry(file));
            }


        }

        private bool IsIndexValid(ListBox lb) => lb.SelectedIndex >= 0;

        private void Remove_Click(object sender, EventArgs e)
        {
            if (IsIndexValid(FileList))
                FileList.Items.RemoveAt(FileList.SelectedIndex);
        }

        private void MoveTop_Click(object sender, EventArgs e)
        {
            if (! IsIndexValid(FileList)) return;
            
            var file = FileList.SelectedItem;
            FileList.Items.Remove(file);
            FileList.Items.Insert(0, file);
            FileList.SetSelected(0, true);
        }

        private void MoveBottom_Click(object sender, EventArgs e)
        {
            if (!IsIndexValid(FileList)) return;

            var file = FileList.SelectedItem;
            FileList.Items.Remove(file);
            FileList.Items.Insert(FileList.Items.Count - 1, file);
            FileList.SetSelected(FileList.Items.Count - 1, true);
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            var newIndex = FileList.SelectedIndex - 1;
            // if the new index is not invalid then continue, else do nothing
            if (newIndex < 0) return;

            var file = FileList.SelectedItem;
            FileList.Items.Remove(file);
            FileList.Items.Insert(newIndex, file);
            FileList.SetSelected(newIndex, true);
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            var newIndex = FileList.SelectedIndex + 1;

            if (newIndex >= FileList.Items.Count) return;

            var file = FileList.SelectedItem;
            FileList.Items.Remove(file);
            FileList.Items.Insert(newIndex, file);
            FileList.SetSelected(newIndex, true);
        }

        private void Merge_Click(object sender, EventArgs e)
        {
            if (FileList.Items.Count==0)
            {
                MessageBox.Show("Select at least 2 pdf files", "CANNOT MERGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Title = "Select where you want to save your PDF",

                CheckPathExists = true,

                DefaultExt = "pdf",
                Filter = "PDF files (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            var output = new PdfDocument();
            foreach (PdfEntry file in FileList.Items)
            {
                var newPdf = PdfReader.Open(file.FilePath, PdfDocumentOpenMode.Import);
                for (var i = 0; i < newPdf.PageCount; i++)
                {
                    output.AddPage(newPdf.Pages[i]);
                }
            }

            output.Save(saveFileDialog.FileName);

            MessageBox.Show("Successfully saved " + Path.GetFileName(saveFileDialog.FileName));
        }
    }
}
