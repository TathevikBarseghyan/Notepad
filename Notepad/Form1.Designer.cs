namespace Notepad
{
    partial class Form1
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
            textBox = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewToolStrip = new ToolStripMenuItem();
            OpenToolStrip = new ToolStripMenuItem();
            SaveAsToolStrip = new ToolStripMenuItem();
            ExitToolStrip = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            DateTimeToolStrip = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            undoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStrip = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            WordWrapToolStrip = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            StatusBarToolStrip = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            ViewHelpToolStrip = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            statusContent = new StatusStrip();
            status = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusContent.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(0, 28);
            textBox.Name = "textBox";
            textBox.Size = new Size(800, 422);
            textBox.TabIndex = 0;
            textBox.Text = "";
            textBox.SelectionChanged += textBox_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStrip, OpenToolStrip, SaveAsToolStrip, ExitToolStrip });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // NewToolStrip
            // 
            NewToolStrip.Name = "NewToolStrip";
            NewToolStrip.ShortcutKeys = Keys.Control | Keys.N;
            NewToolStrip.Size = new Size(193, 26);
            NewToolStrip.Text = "New";
            NewToolStrip.Click += NewToolStrip_Click;
            // 
            // OpenToolStrip
            // 
            OpenToolStrip.Name = "OpenToolStrip";
            OpenToolStrip.ShortcutKeys = Keys.Control | Keys.O;
            OpenToolStrip.Size = new Size(193, 26);
            OpenToolStrip.Text = "Open";
            OpenToolStrip.Click += OpenToolStrip_Click;
            // 
            // SaveAsToolStrip
            // 
            SaveAsToolStrip.Name = "SaveAsToolStrip";
            SaveAsToolStrip.ShortcutKeys = Keys.Control | Keys.S;
            SaveAsToolStrip.Size = new Size(193, 26);
            SaveAsToolStrip.Text = "Save As";
            SaveAsToolStrip.Click += SaveAsToolStrip_Click;
            // 
            // ExitToolStrip
            // 
            ExitToolStrip.Name = "ExitToolStrip";
            ExitToolStrip.Size = new Size(193, 26);
            ExitToolStrip.Text = "Exit";
            ExitToolStrip.Click += ExitToolStrip_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DateTimeToolStrip, toolStripMenuItem1, undoToolStripMenuItem, toolStripMenuItem2, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripMenuItem3, selectAllToolStripMenuItem, DeleteToolStrip });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // DateTimeToolStrip
            // 
            DateTimeToolStrip.Name = "DateTimeToolStrip";
            DateTimeToolStrip.Size = new Size(224, 26);
            DateTimeToolStrip.Text = "Date/Time";
            DateTimeToolStrip.Click += DateTimeToolStrip_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(224, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(221, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(224, 26);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(224, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(224, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(221, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(224, 26);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // DeleteToolStrip
            // 
            DeleteToolStrip.Enabled = false;
            DeleteToolStrip.Name = "DeleteToolStrip";
            DeleteToolStrip.ShortcutKeys = Keys.Delete;
            DeleteToolStrip.Size = new Size(224, 26);
            DeleteToolStrip.Text = "Delete";
            DeleteToolStrip.Click += DeleteToolStrip_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem, WordWrapToolStrip });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "&Format";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(168, 26);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(168, 26);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // WordWrapToolStrip
            // 
            WordWrapToolStrip.CheckOnClick = true;
            WordWrapToolStrip.Name = "WordWrapToolStrip";
            WordWrapToolStrip.Size = new Size(168, 26);
            WordWrapToolStrip.Text = "Word Wrap";
            WordWrapToolStrip.CheckedChanged += WordWrapToolStrip_CheckedChanged;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { StatusBarToolStrip });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "&View";
            // 
            // StatusBarToolStrip
            // 
            StatusBarToolStrip.CheckOnClick = true;
            StatusBarToolStrip.Name = "StatusBarToolStrip";
            StatusBarToolStrip.Size = new Size(158, 26);
            StatusBarToolStrip.Text = "Status Bar";
            StatusBarToolStrip.Click += StatusBarToolStrip_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewHelpToolStrip });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // ViewHelpToolStrip
            // 
            ViewHelpToolStrip.Name = "ViewHelpToolStrip";
            ViewHelpToolStrip.Size = new Size(160, 26);
            ViewHelpToolStrip.Text = "View Help";
            ViewHelpToolStrip.Click += ViewHelpToolStrip_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // statusContent
            // 
            statusContent.ImageScalingSize = new Size(20, 20);
            statusContent.Items.AddRange(new ToolStripItem[] { status });
            statusContent.Location = new Point(0, 424);
            statusContent.Name = "statusContent";
            statusContent.Size = new Size(800, 26);
            statusContent.TabIndex = 2;
            statusContent.Text = "statusStrip1";
            // 
            // status
            // 
            status.Name = "status";
            status.Size = new Size(81, 20);
            status.Text = "Ln 1,  Col 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusContent);
            Controls.Add(textBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusContent.ResumeLayout(false);
            statusContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox textBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem NewToolStrip;
        private ToolStripMenuItem OpenToolStrip;
        private ToolStripMenuItem SaveAsToolStrip;
        private ToolStripMenuItem ExitToolStrip;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem DateTimeToolStrip;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem DeleteToolStrip;
        private ToolStripMenuItem WordWrapToolStrip;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem StatusBarToolStrip;
        private StatusStrip statusContent;
        private ToolStripStatusLabel status;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem ViewHelpToolStrip;
    }
}