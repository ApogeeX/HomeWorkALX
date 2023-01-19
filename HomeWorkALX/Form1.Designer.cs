namespace HomeWorkALX
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMovingButton = new System.Windows.Forms.TabPage();
            this.contextMenuStripMovingButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveButtonToMiddleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.notePadBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveAsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopyButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripUndoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripRedoButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabMovingButton.SuspendLayout();
            this.contextMenuStripMovingButton.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMovingButton);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMovingButton
            // 
            this.tabMovingButton.ContextMenuStrip = this.contextMenuStripMovingButton;
            this.tabMovingButton.Controls.Add(this.button1);
            this.tabMovingButton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabMovingButton.Location = new System.Drawing.Point(4, 24);
            this.tabMovingButton.Name = "tabMovingButton";
            this.tabMovingButton.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovingButton.Size = new System.Drawing.Size(792, 394);
            this.tabMovingButton.TabIndex = 2;
            this.tabMovingButton.Text = "MovingButton";
            this.tabMovingButton.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripMovingButton
            // 
            this.contextMenuStripMovingButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveButtonToMiddleToolStripMenuItem});
            this.contextMenuStripMovingButton.Name = "contextMenuStrip1";
            this.contextMenuStripMovingButton.Size = new System.Drawing.Size(198, 26);
            // 
            // moveButtonToMiddleToolStripMenuItem
            // 
            this.moveButtonToMiddleToolStripMenuItem.Name = "moveButtonToMiddleToolStripMenuItem";
            this.moveButtonToMiddleToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.moveButtonToMiddleToolStripMenuItem.Text = "Move button to middle";
            this.moveButtonToMiddleToolStripMenuItem.Click += new System.EventHandler(this.moveButtonToMiddleToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kliknij mnie!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.goButton);
            this.tabPage1.Controls.Add(this.number2);
            this.tabPage1.Controls.Add(this.number1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 394);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Dzielenie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Press GO! to divide frist number by second number and test if result is even numb" +
    "er";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter second number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter first number";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(13, 178);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(100, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "GO!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(13, 113);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 23);
            this.number2.TabIndex = 1;
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(13, 50);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 23);
            this.number1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.notePadBox);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 394);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Simple NotePad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // notePadBox
            // 
            this.notePadBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notePadBox.Location = new System.Drawing.Point(3, 28);
            this.notePadBox.Name = "notePadBox";
            this.notePadBox.Size = new System.Drawing.Size(786, 363);
            this.notePadBox.TabIndex = 1;
            this.notePadBox.Text = "";
            this.notePadBox.TextChanged += new System.EventHandler(this.notePadBox_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewButton,
            this.toolStripOpenButton,
            this.toolStripSaveButton,
            this.toolStripSaveAsButton,
            this.toolStripSeparator1,
            this.toolStripCutButton,
            this.toolStripCopyButton,
            this.toolStripPasteButton,
            this.toolStripSeparator2,
            this.toolStripUndoButton,
            this.toolStripRedoButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNewButton
            // 
            this.toolStripNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewButton.Image")));
            this.toolStripNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewButton.Name = "toolStripNewButton";
            this.toolStripNewButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripNewButton.Text = "New";
            this.toolStripNewButton.Click += new System.EventHandler(this.toolStripNewButton_Click);
            // 
            // toolStripOpenButton
            // 
            this.toolStripOpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenButton.Image")));
            this.toolStripOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenButton.Name = "toolStripOpenButton";
            this.toolStripOpenButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpenButton.Text = "Open";
            this.toolStripOpenButton.Click += new System.EventHandler(this.toolStripOpenButton_Click);
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveButton.Image")));
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveButton.Text = "Save";
            this.toolStripSaveButton.Click += new System.EventHandler(this.toolStripSaveButton_Click);
            // 
            // toolStripSaveAsButton
            // 
            this.toolStripSaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveAsButton.Image")));
            this.toolStripSaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveAsButton.Name = "toolStripSaveAsButton";
            this.toolStripSaveAsButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveAsButton.Text = "Save as...";
            this.toolStripSaveAsButton.Click += new System.EventHandler(this.toolStripSaveAsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripCutButton
            // 
            this.toolStripCutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCutButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCutButton.Image")));
            this.toolStripCutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCutButton.Name = "toolStripCutButton";
            this.toolStripCutButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripCutButton.Text = "Cut";
            this.toolStripCutButton.Click += new System.EventHandler(this.toolStripCutButton_Click);
            // 
            // toolStripCopyButton
            // 
            this.toolStripCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopyButton.Image")));
            this.toolStripCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopyButton.Name = "toolStripCopyButton";
            this.toolStripCopyButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripCopyButton.Text = "Copy";
            this.toolStripCopyButton.Click += new System.EventHandler(this.toolStripCopyButton_Click);
            // 
            // toolStripPasteButton
            // 
            this.toolStripPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPasteButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPasteButton.Image")));
            this.toolStripPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPasteButton.Name = "toolStripPasteButton";
            this.toolStripPasteButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripPasteButton.Text = "Paste";
            this.toolStripPasteButton.Click += new System.EventHandler(this.toolStripPasteButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripUndoButton
            // 
            this.toolStripUndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUndoButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUndoButton.Image")));
            this.toolStripUndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUndoButton.Name = "toolStripUndoButton";
            this.toolStripUndoButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripUndoButton.Text = "Undo";
            this.toolStripUndoButton.Click += new System.EventHandler(this.toolStripUndoButton_Click);
            // 
            // toolStripRedoButton
            // 
            this.toolStripRedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedoButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRedoButton.Image")));
            this.toolStripRedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedoButton.Name = "toolStripRedoButton";
            this.toolStripRedoButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripRedoButton.Text = "toolStripButton2";
            this.toolStripRedoButton.ToolTipText = "Redo";
            this.toolStripRedoButton.Click += new System.EventHandler(this.toolStripRedoButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijProgramToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijProgramToolStripMenuItem
            // 
            this.zamknijProgramToolStripMenuItem.Name = "zamknijProgramToolStripMenuItem";
            this.zamknijProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zamknijProgramToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.zamknijProgramToolStripMenuItem.Text = "Zamknij program";
            this.zamknijProgramToolStripMenuItem.Click += new System.EventHandler(this.zamknijProgramToolStripMenuItem_Click_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "rtf";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "rtf";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Praca domowa z WinForms";
            this.tabControl1.ResumeLayout(false);
            this.tabMovingButton.ResumeLayout(false);
            this.contextMenuStripMovingButton.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabMovingButton;
        private Button button1;
        private TabPage tabPage1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button goButton;
        private TextBox number2;
        private TextBox number1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem zamknijProgramToolStripMenuItem;
        private ContextMenuStrip contextMenuStripMovingButton;
        private ToolStripMenuItem moveButtonToMiddleToolStripMenuItem;
        private TabPage tabPage2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripNewButton;
        private ToolStripButton toolStripOpenButton;
        private ToolStripButton toolStripSaveButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripCutButton;
        private ToolStripButton toolStripCopyButton;
        private ToolStripButton toolStripPasteButton;
        private RichTextBox notePadBox;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripButton toolStripSaveAsButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripUndoButton;
        private ToolStripButton toolStripRedoButton;
    }
}