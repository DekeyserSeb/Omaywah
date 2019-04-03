using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_plateau
{
    class Card : Button
    {

        public Card(int CardNum)
        {
   
            int Dim_Load = Form1.myForm1.Dim;


            int H = Form1.myForm1.GetHeightRedPanel();
            int W = Form1.myForm1.GetWidthRedPanel();
            Size = new Size(H, H);
            Location = new Point(((W/7)*3) * Loca(CardNum), 0);
            BackColor = Color.Brown;
            Name = ("Card" + (1 + CardNum).ToString());
            Console.WriteLine(Name);
       
        }

        private int Loca(int PosX)
        {
            if (PosX >= 3)
            {
                return PosX - 3;
            }
            else
            {
                return PosX;

            }
        }
    }
}
