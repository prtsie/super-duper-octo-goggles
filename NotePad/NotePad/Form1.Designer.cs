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
            components = new System.ComponentModel.Container();
            textBox = new TextBox();
            menuStrip = new MenuStrip();
            menuStripFile = new ToolStripMenuItem();
            menuStripOpenFile = new ToolStripMenuItem();
            menuStripSaveFile = new ToolStripMenuItem();
            menuStripSaveFileAs = new ToolStripMenuItem();
            menuStripView = new ToolStripMenuItem();
            menuStripFont = new ToolStripMenuItem();
            menuStripBackGroundColor = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            colorDialog = new ColorDialog();
            fontDialog = new FontDialog();
            timer = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            typingSpeedLabel = new ToolStripStatusLabel();
            cursorPositionLabel = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.AcceptsTab = true;
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Location = new Point(0, 26);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Size = new Size(800, 402);
            textBox.TabIndex = 0;
            textBox.WordWrap = false;
            textBox.TextChanged += textBox_TextChanged;
            textBox.KeyPress += textBox_KeyPress;
            textBox.KeyUp += textBox_KeyUp;
            textBox.MouseDown += textBox_MouseDown;
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
            menuStripOpenFile.ShortcutKeyDisplayString = "Ctrl + O";
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
            menuStripView.DropDownItems.AddRange(new ToolStripItem[] { menuStripFont, menuStripBackGroundColor });
            menuStripView.Name = "menuStripView";
            menuStripView.Size = new Size(39, 20);
            menuStripView.Text = "Вид";
            // 
            // menuStripFont
            // 
            menuStripFont.Name = "menuStripFont";
            menuStripFont.Size = new Size(132, 22);
            menuStripFont.Text = "Шрифт";
            menuStripFont.Click += menuStripFont_Click;
            // 
            // menuStripBackGroundColor
            // 
            menuStripBackGroundColor.Name = "menuStripBackGroundColor";
            menuStripBackGroundColor.Size = new Size(132, 22);
            menuStripBackGroundColor.Text = "Цвет фона";
            menuStripBackGroundColor.Click += menuStripBackGroundColor_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "txt";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "txt";
            // 
            // fontDialog
            // 
            fontDialog.ShowColor = true;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { typingSpeedLabel, cursorPositionLabel });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // typingSpeedLabel
            // 
            typingSpeedLabel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            typingSpeedLabel.Name = "typingSpeedLabel";
            typingSpeedLabel.Size = new Size(118, 19);
            typingSpeedLabel.Text = "toolStripStatusLabel1";
            // 
            // cursorPositionLabel
            // 
            cursorPositionLabel.BorderSides = ToolStripStatusLabelBorderSides.Left;
            cursorPositionLabel.Name = "cursorPositionLabel";
            cursorPositionLabel.RightToLeft = RightToLeft.No;
            cursorPositionLabel.Size = new Size(122, 19);
            cursorPositionLabel.Text = "toolStripStatusLabel1";
            // 
            // NotepadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(textBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "NotepadForm";
            Text = "Form1";
            FormClosing += NotepadForm_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStripMenuItem menuStripFont;
        private ToolStripMenuItem menuStripBackGroundColor;
        private ColorDialog colorDialog;
        private FontDialog fontDialog;
        private System.Windows.Forms.Timer timer;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel typingSpeedLabel;
        private ToolStripStatusLabel cursorPositionLabel;
    }
}
