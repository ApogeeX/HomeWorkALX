namespace HomeWorkALX
{
    public partial class Form1 : Form
    {
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
                MessageBox.Show($"Result of dividing Number 1 by Number 2 is: {numb1/numb2}, and that is a even number", "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show($"Result of dividing Number 1 by Number 2 is: {numb1 / numb2}, and that is a odd number", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
    }
}