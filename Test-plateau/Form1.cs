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
    public partial class Form1 : Form
    {
        public int Dim = 5; //Ne génère que en carrée Dim = 5 ==> 5 x 5 mettre la dimension ici
        public Panel Plateau;
        public Panel RedPlateau;
        public Panel BluePlateau;
        public static Form1 myForm1;
        public Form1()
        {
            myForm1 = this;
            InitializeComponent();
            Plateau = new Panel();
            Plateau.Location = new Point(100, 125);
            Plateau.Size = new Size(700, 700);
            Plateau.BackColor = Color.Aqua;
            this.Controls.Add(Plateau);


            //AJOUTER UN IF QUI CHANGE LA ZONE SI ON EST RED OR BLUE!!!
            RedPlateau = new Panel();
            RedPlateau.Location = new Point(100, 13);
            RedPlateau.Size = new Size(700, 100);
            RedPlateau.BackColor = Color.Red;
            this.Controls.Add(RedPlateau);


            BluePlateau = new Panel();
            BluePlateau.Location = new Point(100, GetHeight() - 125 - 35);
            BluePlateau.Size = new Size(700, 100);
            BluePlateau.BackColor = Color.Blue;
            this.Controls.Add(BluePlateau);


            int CaseNum = 0;
            while (CaseNum != Dim*Dim)
            {
                Case c = new Case(CaseNum);
                //this.Controls.Add(c); //NOUS PERMET D'AJOUTER L'OBJET C DONC LES button !!!
                Plateau.Controls.Add(c);
                c.Click += maFonctionExterieur;
                CaseNum++;
            }

            int CardNum = 0;
            while (CardNum != 6)
            {
                if (CardNum < 3)
                {
                    Card Redc = new Card(CardNum);
                    RedPlateau.Controls.Add(Redc);
                } else
                {
                    Card Bluec = new Card(CardNum);
                    BluePlateau.Controls.Add(Bluec);

                }
                CardNum++;

            }
        }

        private void maFonctionExterieur(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /*
         * 
         *  Panel Plateau = new Panel();
            Plateau.Location = new Point(95, 100);
            Plateau.Size = new Size(400, 400);
            Plateau.BackColor = Color.Aqua;
            this.Controls.Add(Plateau);

            int x = 20;
            int y = 20;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Case case_ = new Case(x,y);
                    case_.Location = new Point(x, y);
                    //Nommer la case par ses coordonées
                    Plateau.Controls.Add(case_);
                    x += 35;
                }
                x = 20;
                y += 35;
            }

         * 
         */

        public int GetHeight()  {
            return this.Height;
        }
        public int GetWidth()
        {
            return this.Width;
        }
        public int GetHeightPanel()
        {
            return Plateau.Height;
        }
        public int GetWidthPanel()
        {
            return Plateau.Width;
        }
        public int GetHeightRedPanel()
        {
            return RedPlateau.Height;
        }
        public int GetWidthRedPanel()
        {
            return RedPlateau.Width;
        }
        public int GetHeightBluePanel()
        {
            return BluePlateau.Height;
        }
        public int GetWidthBluePanel()
        {

            return BluePlateau.Width;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
