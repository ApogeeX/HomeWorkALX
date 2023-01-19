using System.Windows.Forms.Design;

namespace HomeWorkALX
{
    public partial class Form1 : Form
    {
        public string FileName { get; private set; }
        public bool Modified { get; private set; }
        public string AppName { get; private set; }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random RandomObj = new Random();
            Point StartPoint = new Point(tabMovingButton.Size);

            int X = RandomObj.Next(1, StartPoint.X -99);
            int Y = RandomObj.Next(1, StartPoint.Y -23);

            this.button1.Location = new Point(X, Y);
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            var numb1 = Convert.ToDouble(number1.Text);
            var numb2 = Convert.ToDouble(number2.Text);
            if ((numb1/numb2) % 2 == 0)
            {
                MessageBox.Show($"Result of dividing {numb1} by {numb2} is: {numb1/numb2}, and that is a even number!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show($"Result of dividing {numb1} by {numb2} is: {numb1 / numb2}, and that is a odd number!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void zamknijProgramToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void moveButtonToMiddleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button1.Location = new Point(tabMovingButton.Width/2-50, tabMovingButton.Height/2-12);
        }

        private void toolStripCutButton_Click(object sender, EventArgs e)
        {
            notePadBox.Cut();
        }

        private void toolStripCopyButton_Click(object sender, EventArgs e)
        {
            notePadBox.Copy();
        }

        private void toolStripPasteButton_Click(object sender, EventArgs e)
        {
            notePadBox.Paste();
        }

        private void toolStripNewButton_Click(object sender, EventArgs e)
        {
            if (Modified == true)
            {
                DialogResult dr = MessageBox.Show("Plik nie zosta³ zapisany. Zapisaæ?", "Plik niezapisany", MessageBoxButtons.YesNoCancel);
                
                if (dr == DialogResult.Cancel) 
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    toolStripSaveButton_Click(sender, e);
                }

                    FileName = null;
                    Text = AppName;
                    notePadBox.Clear();
                    Modified = false;
            }

            FileName = null;
            Text = AppName;
            notePadBox.Clear();
            Modified = false;
        }

        private void toolStripOpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                notePadBox.LoadFile(openFileDialog1.FileName);
                Text = AppName + " [" + openFileDialog1.FileName + "]";
                Modified = false;
            }
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                toolStripSaveAsButton_Click(sender, e);
            }
            else
            {
                notePadBox.SaveFile(FileName);
                Modified = false;
            }
        }

        private void toolStripSaveAsButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                notePadBox.SaveFile(saveFileDialog1.FileName);
                Text = AppName + " [" + saveFileDialog1.FileName + "]";

                FileName = saveFileDialog1.FileName;
                Modified = false;
            }
        }

        private void notePadBox_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        private void toolStripUndoButton_Click(object sender, EventArgs e)
        {
            notePadBox.Undo();
        }

        private void toolStripRedoButton_Click(object sender, EventArgs e)
        {
            notePadBox.Redo();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openImageDialog.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

/*        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
*/
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void radioOriginal_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void radioFill_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}