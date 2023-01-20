namespace Lotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.blindShotCheckBox = new System.Windows.Forms.CheckBox();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.selectedNumbersLabel = new System.Windows.Forms.Label();
            this.trafioneNumeryLabel = new System.Windows.Forms.Label();
            this.numberSix = new System.Windows.Forms.Label();
            this.numberFive = new System.Windows.Forms.Label();
            this.numberFour = new System.Windows.Forms.Label();
            this.numberThree = new System.Windows.Forms.Label();
            this.numberTwo = new System.Windows.Forms.Label();
            this.numberOne = new System.Windows.Forms.Label();
            this.generateNumbersButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.blindShotCheckBox);
            this.tabPage1.Controls.Add(this.selectedLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wybierz swoje liczby";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // blindShotCheckBox
            // 
            this.blindShotCheckBox.AutoSize = true;
            this.blindShotCheckBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blindShotCheckBox.Location = new System.Drawing.Point(329, 341);
            this.blindShotCheckBox.Name = "blindShotCheckBox";
            this.blindShotCheckBox.Size = new System.Drawing.Size(134, 36);
            this.blindShotCheckBox.TabIndex = 3;
            this.blindShotCheckBox.Text = "Ślepy traf";
            this.blindShotCheckBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.blindShotCheckBox.UseVisualStyleBackColor = true;
            this.blindShotCheckBox.CheckedChanged += new System.EventHandler(this.blindShotCheckBox_CheckedChanged);
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedLabel.Location = new System.Drawing.Point(21, 378);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(102, 30);
            this.selectedLabel.TabIndex = 2;
            this.selectedLabel.Text = "Wybrano:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zaznacz 6 numerów";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 88;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49"});
            this.checkedListBox1.Location = new System.Drawing.Point(21, 55);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(442, 280);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.selectedNumbersLabel);
            this.tabPage2.Controls.Add(this.trafioneNumeryLabel);
            this.tabPage2.Controls.Add(this.numberSix);
            this.tabPage2.Controls.Add(this.numberFive);
            this.tabPage2.Controls.Add(this.numberFour);
            this.tabPage2.Controls.Add(this.numberThree);
            this.tabPage2.Controls.Add(this.numberTwo);
            this.tabPage2.Controls.Add(this.numberOne);
            this.tabPage2.Controls.Add(this.generateNumbersButton);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Controls.Add(this.pictureBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Losowanie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // selectedNumbersLabel
            // 
            this.selectedNumbersLabel.AutoSize = true;
            this.selectedNumbersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedNumbersLabel.Location = new System.Drawing.Point(23, 276);
            this.selectedNumbersLabel.Name = "selectedNumbersLabel";
            this.selectedNumbersLabel.Size = new System.Drawing.Size(210, 32);
            this.selectedNumbersLabel.TabIndex = 14;
            this.selectedNumbersLabel.Text = "Wybrane numery: ";
            // 
            // trafioneNumeryLabel
            // 
            this.trafioneNumeryLabel.AutoSize = true;
            this.trafioneNumeryLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trafioneNumeryLabel.Location = new System.Drawing.Point(23, 349);
            this.trafioneNumeryLabel.Name = "trafioneNumeryLabel";
            this.trafioneNumeryLabel.Size = new System.Drawing.Size(201, 32);
            this.trafioneNumeryLabel.TabIndex = 13;
            this.trafioneNumeryLabel.Text = "Trafione numery: ";
            // 
            // numberSix
            // 
            this.numberSix.AutoSize = true;
            this.numberSix.Font = new System.Drawing.Font("FujiyamaExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberSix.Location = new System.Drawing.Point(433, 38);
            this.numberSix.Name = "numberSix";
            this.numberSix.Size = new System.Drawing.Size(22, 24);
            this.numberSix.TabIndex = 6;
            this.numberSix.Text = "6";
            // 
            // numberFive
            // 
            this.numberFive.AutoSize = true;
            this.numberFive.Font = new System.Drawing.Font("FujiyamaExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberFive.Location = new System.Drawing.Point(354, 38);
            this.numberFive.Name = "numberFive";
            this.numberFive.Size = new System.Drawing.Size(22, 24);
            this.numberFive.TabIndex = 5;
            this.numberFive.Text = "5";
            // 
            // numberFour
            // 
            this.numberFour.AutoSize = true;
            this.numberFour.Font = new System.Drawing.Font("FujiyamaExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberFour.Location = new System.Drawing.Point(276, 38);
            this.numberFour.Name = "numberFour";
            this.numberFour.Size = new System.Drawing.Size(22, 24);
            this.numberFour.TabIndex = 4;
            this.numberFour.Text = "4";
            // 
            // numberThree
            // 
            this.numberThree.AutoSize = true;
            this.numberThree.Font = new System.Drawing.Font("FujiyamaExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberThree.Location = new System.Drawing.Point(201, 39);
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(22, 24);
            this.numberThree.TabIndex = 3;
            this.numberThree.Text = "3";
            // 
            // numberTwo
            // 
            this.numberTwo.AutoSize = true;
            this.numberTwo.Font = new System.Drawing.Font("FujiyamaExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberTwo.Location = new System.Drawing.Point(122, 38);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(22, 24);
            this.numberTwo.TabIndex = 2;
            this.numberTwo.Text = "2";
            // 
            // numberOne
            // 
            this.numberOne.AutoSize = true;
            this.numberOne.Font = new System.Drawing.Font("FujiyamaExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberOne.Location = new System.Drawing.Point(46, 38);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(22, 24);
            this.numberOne.TabIndex = 1;
            this.numberOne.Text = "1";
            // 
            // generateNumbersButton
            // 
            this.generateNumbersButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateNumbersButton.Location = new System.Drawing.Point(143, 165);
            this.generateNumbersButton.Name = "generateNumbersButton";
            this.generateNumbersButton.Size = new System.Drawing.Size(190, 58);
            this.generateNumbersButton.TabIndex = 0;
            this.generateNumbersButton.Text = "Losowanie!";
            this.generateNumbersButton.UseVisualStyleBackColor = true;
            this.generateNumbersButton.Click += new System.EventHandler(this.generateNumbersButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(90, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Lotto.Properties.Resources.white_ball;
            this.pictureBox3.Location = new System.Drawing.Point(168, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Lotto.Properties.Resources.white_ball;
            this.pictureBox4.Location = new System.Drawing.Point(244, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Lotto.Properties.Resources.white_ball;
            this.pictureBox5.Location = new System.Drawing.Point(322, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(72, 82);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Lotto.Properties.Resources.white_ball;
            this.pictureBox6.Location = new System.Drawing.Point(400, 18);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(72, 82);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lotto";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckedListBox checkedListBox1;
        private TabPage tabPage2;
        private Button generateNumbersButton;
        private Label numberSix;
        private Label numberFive;
        private Label numberFour;
        private Label numberThree;
        private Label numberTwo;
        private Label numberOne;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label selectedLabel;
        private Label label1;
        private Label trafioneNumeryLabel;
        private Label selectedNumbersLabel;
        private CheckBox blindShotCheckBox;
    }
}