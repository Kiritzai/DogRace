using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Race
{
    public partial class Form1 : Form
    {
        Guy[] guys = new Guy[3];
        Greyhound[] dog = new Greyhound[4];

        string sName1 = "Remy";
        string sName2 = "Erwin";
        string sName3 = "Denise";

        public Form1()
        {
            InitializeComponent();

            guys[0] = new Guy() { Name = sName1, MyRadioButton = radioGuy1, MyLabel = labelGuy1, Cash = 50, MyBet = null };
            guys[1] = new Guy() { Name = sName2, MyRadioButton = radioGuy2, MyLabel = labelGuy2, Cash = 50, MyBet = null };
            guys[2] = new Guy() { Name = sName3, MyRadioButton = radioGuy3, MyLabel = labelGuy3, Cash = 50, MyBet = null };

            dog[0] = new Greyhound() { MyPictureBox = pictureBox1, RacetrackLenth = pictureBox5.Width };
            dog[1] = new Greyhound() { MyPictureBox = pictureBox2, RacetrackLenth = pictureBox5.Width };
            dog[2] = new Greyhound() { MyPictureBox = pictureBox3, RacetrackLenth = pictureBox5.Width };
            dog[3] = new Greyhound() { MyPictureBox = pictureBox4, RacetrackLenth = pictureBox5.Width };

            labelMinBet.Text = "Minimum bet is " + numericUpDown1.Minimum + " bucks";

            for (int i = 0; i <= 2; i++)
            {
                guys[i].UpdateLabels();
            }
            labelName.Text = sName1;
        }

        private void radioGuy1_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = sName1;
        }

        private void radioGuy2_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = sName2;
        }

        private void radioGuy3_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = sName3;
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            if (radioGuy1.Checked)
            {
                guys[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                guys[0].UpdateLabels();
            }
            else if (radioGuy2.Checked)
            {
                guys[1].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                guys[1].UpdateLabels();
            }
            else if (radioGuy3.Checked)
            {
                guys[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                guys[2].UpdateLabels();
            }
        }

        private void buttonRace_Click(object sender, EventArgs e)
        {
            timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (dog[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Winner dog number #" + i, "test");
                    break;
                }
                //dog[i].MyPictureBox.Refresh();
            }
        }
    }
}
