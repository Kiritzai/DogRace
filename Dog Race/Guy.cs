using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dog_Race
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            if (MyBet == null)
            {
                MyLabel.Text = Name + " hasn't place a bet";
            }
            else
            {
                MyLabel.Text = Name + " bets " + MyBet.Amount;
            }
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public void ClearBet() { MyBet = null; }

        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount <= Cash)
            {
                if (MyBet == null)
                {
                    MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };
                    Cash -= Amount;
                    return true;
                }
                else
                {
                    MessageBox.Show("Already placed a bet", "Message");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Not enough cash to bet", "Message");
                return false;
            }
        }

        public void Collect(int Winner) { }
    }
}
