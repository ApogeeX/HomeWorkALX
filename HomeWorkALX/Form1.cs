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
    }
}