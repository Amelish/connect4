using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Feld
    {
        

        Spieler spieler;

        public Spieler getSpieler()                     // Liest den Spieler aus dem Feld aus
        {
            return spieler;
        }
        public void setSpieler(Spieler newSpieler)              // stezt einen Spieler auf ein freies Feld
        {
            if (istbelegt() == false)
                spieler = newSpieler;
        }

        public bool istbelegt() {                   // prüft ob das Feld einem SPieler gehört
            if (spieler == null)
                return false;
            else
               return true;
        }

        

    }



}
