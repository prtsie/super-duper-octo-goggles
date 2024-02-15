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
            menuStripOpenFile.ShortcutKeys = Keys.Control | Keys.O;
            menuStripSaveFile.ShortcutKeys = Keys.Control | Keys.S;
            menuStripSaveFileAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
        }

        private static FileInfo? RequestFile(FileDialog dialog)
        {
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            return new FileInfo(dialog.FileName);
        }

        private static DialogResult RequestSaveOnClose() =>
            MessageBox.Show("Сохранить файл?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        private Color? RequestColor()
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            return colorDialog.Color;
        }

        private (Font font, Color color)? RequestFont()
        {
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            return (fontDialog.Font, fontDialog.Color);
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
            file = RequestFile(saveFileDialog);
            Save();
        }

        private void menuStripOpenFile_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {
                switch (RequestSaveOnClose())
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
            file = RequestFile(openFileDialog);
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

        private void NotepadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                switch (RequestSaveOnClose())
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
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
        }

        private void menuStripBackGroundColor_Click(object sender, EventArgs e)
        {
            var color = RequestColor();
            if (color is not null)
            {
                textBox.BackColor = color.Value;
            }
        }

        private void menuStripFont_Click(object sender, EventArgs e)
        {
            var userInput = RequestFont();
            if (userInput is not null)
            {
                textBox.Font = userInput.Value.font;
                textBox.ForeColor = userInput.Value.color;
            }
        }
    }
}
