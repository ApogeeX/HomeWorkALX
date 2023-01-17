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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMovingButton = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabMovingButton.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMovingButton);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMovingButton
            // 
            this.tabMovingButton.Controls.Add(this.button1);
            this.tabMovingButton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabMovingButton.Location = new System.Drawing.Point(4, 24);
            this.tabMovingButton.Name = "tabMovingButton";
            this.tabMovingButton.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovingButton.Size = new System.Drawing.Size(792, 423);
            this.tabMovingButton.TabIndex = 2;
            this.tabMovingButton.Text = "MovingButton";
            this.tabMovingButton.UseVisualStyleBackColor = true;
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
            this.tabPage1.Size = new System.Drawing.Size(792, 423);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Praca domowa z WinForms";
            this.tabControl1.ResumeLayout(false);
            this.tabMovingButton.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}