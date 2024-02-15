using System.Windows.Forms;

namespace NotePad
{
    public partial class NotepadForm : Form
    {
        private FileInfo? file;
        private bool isChanged;

        public NotepadForm()
        {
            InitializeComponent();
            Text = "New";
            menuStripSaveFile.ShortcutKeys = Keys.Control | Keys.S;
            menuStripSaveFileAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
        }

        private static FileInfo? GetFile(FileDialog dialog)
        {
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            return new FileInfo(dialog.FileName);
        }

        private void Save()
        {
            if (file is not null)
            {
                using var writer = file.CreateText();
                writer.Write(textBox.Text);
                isChanged = false;
            }
        }

        private void SaveAs()
        {
            file = GetFile(saveFileDialog);
            Save();
        }

        private static DialogResult SaveOnClose() =>
            MessageBox.Show("Сохранить файл?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        private void menuStripOpenFile_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {
                switch (SaveOnClose())
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        if (file is not null)
                        {
                            Save();
                        }
                        else
                        {
                            SaveAs();
                        }
                        break;
                    default:
                        break;
                }
            }
            file = GetFile(openFileDialog);
            if (file is not null)
            {
                using var reader = file.OpenText();
                textBox.Text = reader.ReadToEnd();
                isChanged = false;
                Text = file.Name;
            }
        }

        private void menuStripSaveFile_Click(object sender, EventArgs e)
        {
            if (file is not null)
            {
                Save();
            }
            else
            {
                SaveAs();
            }
        }

        private void menuStripSaveFileAs_Click(object sender, EventArgs e) => SaveAs();

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
    }
}
