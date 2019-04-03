using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_plateau
{
    class DelegateEventOriginal
    {
        public delegate void MyAwesomeEventHandler();
        public delegate ConsoleColor WITHCOLORMyAwesomeEventHandler(Case myCase);//return color

        public MyAwesomeEventHandler oncreate; //oncreate évenement appelé a la fin du constructeur (vide par définition)

        public MyAwesomeEventHandler oninit;

        public MyAwesomeEventHandler onIDchange;

        public WITHCOLORMyAwesomeEventHandler OnPieceChange;

        //Ceci ne sert a rien
        private int _ID; //Champs

        public int ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                _ID = value;
                onIDchange();
            }
        }// control R+E pourquoi private? Sécurité ex bank si admin ils doit pouvoir changer mais pas si client, empêche de faire des conneries  

        //Propriétés = référence à la variable


        // ARDUINO
        string portName = "COM4";

        //public void SetPortNbr(int x)
        //{
        //    portName = "COM" + x;
        //}

        public int PortNbr { set { portName = "COM" + value; } }

        public DelegateEventOriginal()
        {
            PortNbr = 3;

            oncreate += MyEmptyFunction;

            oninit+= MyEmptyFunction;

            onIDchange+= MyEmptyFunction;

          //  OnPieceChange+= MyEmptyFunction;





        }

        private void MyEmptyFunction()
        {
            return;
        }
    }
}
