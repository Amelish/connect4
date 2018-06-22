using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp { 

enum Farbe
{
    rot,
    blau,
    gelb,
    pink,
    tuerkis
};

    class Spieler
    {

        private Farbe farbe;

        public Farbe getFarbe()             // liest die Farbe des Spielers
        {
            return farbe;
        }
        public void setFarbe (Farbe newFarbe)       // setzt eine neue Farbe 
        {
            farbe = newFarbe;
        }
        public bool istKI()                         // überprüft ob der Spieler eine KI ist
        {
            return false;
        }
    }
}
