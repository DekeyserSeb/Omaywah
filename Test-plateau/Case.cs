using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_plateau
{
    enum Position { Void = 0, Red = 1, BigRed = 2, Blue = 3, BigBlue = 4 }
    enum Carte { Void = 0, Red = 1, Blue = 2 }

    class Case : Button
    {
        public int[] positionXYC = new int[2];

        int change = 1;
        int Dim_Load = Form1.myForm1.Dim;

        public Case(int CaseNum)
        {

            while (CaseNum > (Dim_Load-1))
            {
                CaseNum = CaseNum - Dim_Load;
                ++change;
            }
            int H = Form1.myForm1.GetHeightPanel();
            int W = Form1.myForm1.GetWidthPanel();
            Size = new Size(W/(Dim_Load+1) + W/(Dim_Load*9), W/ (Dim_Load+1) + W /(Dim_Load*9));
            Location = new Point((W/ Dim_Load * CaseNum) + W/(Dim_Load*28), (W/ Dim_Load * (change-1)) + W/ (Dim_Load * 28));
            BackColor = Color.GreenYellow;      
            Name = ("Case" + (1 + CaseNum).ToString() + ((Dim_Load+1) - change).ToString());
            Console.WriteLine(Name);

            Click += MaFonctionDuClick; // génération de l'évènement
            MouseHover += MaFonctionDeSurvol;//trouve ou se trouve la souris
        }

        private void MaFonctionDeSurvol(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MaFonctionDuClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void update()
        {

        }

    }
}
