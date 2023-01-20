using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace Lotto
{
    public partial class Form1 : Form
    {

        Label[] labelArray;

        public Form1()
        {
            InitializeComponent();
            labelArray = new Label[] { numberOne, numberTwo, numberThree, numberFour, numberFive, numberSix };
            ClearLabels(); 
        }

        private void generateNumbersButton_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            List<int> randomList = new List<int>();
            int myNumber = 0;
            Random generator = new Random();
            string[] selectedNumbersStrings = checkedListBox1.CheckedItems.OfType<string>().ToArray();
            int[] selectedNumbersInt = Array.ConvertAll(selectedNumbersStrings, s => int.Parse(s));

            if (checkedListBox1.CheckedItems.Count == 6)
            {
                for (int x = 0; x < 6;)
                {
                    myNumber = a.Next(1, 49);
                    if (!randomList.Contains(myNumber))
                    {
                        randomList.Add(myNumber);
                        labelArray[x].Text = myNumber.ToString();
                        x++;
                    }
                }
            }
            else
            {
                MessageBox.Show($"Wybrano jedynie {checkedListBox1.CheckedItems.Count} liczb, musisz wybraæ 6 aby braæ udzia³ w loterii", "Za ma³o numerów wybrano", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearLabels();
            }


            var intersect = selectedNumbersInt.Intersect(randomList);
            trafioneNumeryLabel.Text = "Trafione numery " + selectedNumbersInt.Intersect(randomList).Count().ToString() + ":"; 
            foreach (int res in intersect)
            {
                trafioneNumeryLabel.Text = trafioneNumeryLabel.Text + " " + res.ToString();
            }
            if (selectedNumbersInt.Intersect(randomList).Count() == 3)
            {
                MessageBox.Show($"Gratulacje trafi³eœ 3 liczby, wygrywasz 12z³", "3ka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedNumbersInt.Intersect(randomList).Count() == 4)
            {
                MessageBox.Show($"Gratulacje trafi³eœ 4 liczby, udaj siê do kolektury aby odebraæ nagrodzê", "4ka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedNumbersInt.Intersect(randomList).Count() == 5)
            {
                MessageBox.Show($"Gratulacje trafi³eœ 5 liczb, udaj siê do kolektury aby odebraæ nagrodzê", "5ka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedNumbersInt.Intersect(randomList).Count() == 6)
            {
                MessageBox.Show($"Gratulacje zosta³eœ MILIONEREM, udaj siê do kolektury aby odebraæ nagrodzê", "6ka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearLabels()
        {
            foreach(var labelText in labelArray)
            {
                labelText.Text = String.Empty ;
            } 
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLabel.Text = "Wybrano: " + checkedListBox1.CheckedItems.Count.ToString();
            checkedListBox1.ItemCheck += (sender, e) =>
            {
                // is the item being checked when 3 are already checked?
                if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count == 6)
                {
                    // block the change
                    e.NewValue = CheckState.Unchecked;
                }
            };           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] selectedNumbersStrings = checkedListBox1.CheckedItems.OfType<string>().ToArray();
            selectedNumbersLabel.Text = "Wybrane numery: ";
            foreach (var item in selectedNumbersStrings)
            {
                selectedNumbersLabel.Text = selectedNumbersLabel.Text + " " + item;
            }
            
        }

        private void blindShotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (blindShotCheckBox.Checked)
            {
                int blindNumber = 0;
                Random a = new Random();
                List<int> blindList = new List<int>();

                for (int x = 0; x < 6;)
                {
                    blindNumber = a.Next(1, 49);
                    if (!blindList.Contains(blindNumber))
                    {
                        checkedListBox1.SetItemChecked(blindNumber, true);
                        blindList.Add(blindNumber);
                        x++;
                    }
                    selectedLabel.Text = "Wybrano: " + checkedListBox1.CheckedItems.Count.ToString();
                }
            }
            else
            {
                for (int x = 0; x < 49; x++)
                    {
                        checkedListBox1.SetItemChecked(x, false);
                    
                    }
                selectedLabel.Text = "Wybrano: " + checkedListBox1.CheckedItems.Count.ToString();
            }
        }
    }
}