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
            if (MyBet != null)
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            else
            {
                MyLabel.Text = Name + " hasn't placed a bet";
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

        public void Collect(int Winner)
        {
            if (MyBet != null)
            {
                Cash += MyBet.PayOut(Winner); 
            }
        }
    }
}
