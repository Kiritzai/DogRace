using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dog_Race
{
    class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLenth;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        static Random Randomizer = new Random();

        public bool Run()
        {
            int distance = Randomizer.Next(0,5);
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            if (p.X >= RacetrackLenth)
            {
                //MyPictureBox.Location = p;
                return true;
            }
            else
            {
                
                return false;
            }
        }

        public void TakeStartingPosistion()
        {
            Point p = MyPictureBox.Location;
            p.X = this.StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}
