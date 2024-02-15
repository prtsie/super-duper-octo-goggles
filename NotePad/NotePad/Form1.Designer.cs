namespace NotePad
{
    partial class NotepadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            menuStrip = new MenuStrip();
            menuStripFile = new ToolStripMenuItem();
            menuStripOpenFile = new ToolStripMenuItem();
            menuStripSaveFile = new ToolStripMenuItem();
            menuStripSaveFileAs = new ToolStripMenuItem();
            menuStripView = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.AcceptsTab = true;
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(0, 24);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Size = new Size(800, 423);
            textBox.TabIndex = 0;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { menuStripFile, menuStripView });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // menuStripFile
            // 
            menuStripFile.DropDownItems.AddRange(new ToolStripItem[] { menuStripOpenFile, menuStripSaveFile, menuStripSaveFileAs });
            menuStripFile.Name = "menuStripFile";
            menuStripFile.Size = new Size(48, 20);
            menuStripFile.Text = "Файл";
            // 
            // menuStripOpenFile
            // 
            menuStripOpenFile.Name = "menuStripOpenFile";
            menuStripOpenFile.Size = new Size(247, 22);
            menuStripOpenFile.Text = "Открыть";
            menuStripOpenFile.Click += menuStripOpenFile_Click;
            // 
            // menuStripSaveFile
            // 
            menuStripSaveFile.Name = "menuStripSaveFile";
            menuStripSaveFile.ShortcutKeyDisplayString = "Ctrl + S";
            menuStripSaveFile.Size = new Size(247, 22);
            menuStripSaveFile.Text = "Сохранить";
            menuStripSaveFile.Click += menuStripSaveFile_Click;
            // 
            // menuStripSaveFileAs
            // 
            menuStripSaveFileAs.Name = "menuStripSaveFileAs";
            menuStripSaveFileAs.ShortcutKeyDisplayString = "Ctrl + Shift + S";
            menuStripSaveFileAs.Size = new Size(247, 22);
            menuStripSaveFileAs.Text = "Сохранить как...";
            menuStripSaveFileAs.Click += menuStripSaveFileAs_Click;
            // 
            // menuStripView
            // 
            menuStripView.Name = "menuStripView";
            menuStripView.Size = new Size(39, 20);
            menuStripView.Text = "Вид";
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "txt";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "txt";
            // 
            // NotepadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "NotepadForm";
            Text = "Form1";
            FormClosing += NotepadForm_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuStripFile;
        private ToolStripMenuItem menuStripSaveFile;
        private ToolStripMenuItem menuStripSaveFileAs;
        private ToolStripMenuItem menuStripView;
        private ToolStripMenuItem menuStripOpenFile;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
