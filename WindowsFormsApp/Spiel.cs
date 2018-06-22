using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Spiel
    {
        Spieler spieler1;
        Spieler spieler2;
        Spieler aktuellerSpieler;
        Spielfeld aktuellesSpielfeld;
        
       

        public Spiel (Spieler spieler1, Spieler spieler2, Spielfeld aktuellesSpielfeld)            //Konstruktor
        {
            this.spieler1 = spieler1;                                                           // erstellt Spieler 1 und SPieler 2
            this.spieler2 = spieler2;
            this.aktuellesSpielfeld = aktuellesSpielfeld;                                       // erstellt ein Spielfeld
            this.aktuellerSpieler = spieler1;                                                   // (Spieler 1 beginnt)
     
        }

        public Spielfeld getSpielfeld()                                                     // liest das Spielfeld
        {
            return aktuellesSpielfeld;
        }

       public void setAktuellenspieler(Spieler aktuellerspieler)
        {
            this.aktuellerSpieler = aktuellerspieler;
        }

        public Spieler getSpieler1()                                                    
        {
            return this.spieler1;
        }
        public Spieler getSpieler2()
        {
            return this.spieler2;
        }
        public Spieler getAktuellenSpieler()
        {
            return aktuellerSpieler;
        }
        
        private void spielerwechsel()
        {
            if (aktuellerSpieler == spieler1)
                aktuellerSpieler = spieler2;
            else
                aktuellerSpieler = spieler1;
        }

        bool spielende()
        {
          return false;
        }

        bool gewonnen()
        {
            return false;
        }

        
}
}
