using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Spalte
    {
        public Spalte()                     //Konstruktor
        {
            for (int i = 0; i < 6; i++)
                felder[i] = new Feld();     // Erstellen eines neuen Feld.Objeks
        }

        Feld[] felder = new Feld[6];        // Feld array mit 6 Feldern für die Spalten

        public Feld getFeld(int i)          // lesen eines bestimmten Feldes
        {
            return felder[i];
        }

        public bool istVoll()                  // prüfen ob die Splate voll ist, also alle felder belegt sind
        {
            return felder[0].istbelegt();       // für das Spiel reicht das prüfen des obersten Feldes
        }

        public void einwerfen (Spieler spieler)     // 
        {
          
            Feld feld = getFreiesfeld();
            feld.setSpieler(spieler);            //setzt Spieler auf das freie Feld
            
            

        }

        public Feld getFreiesfeld ()                           // lese das erste freie Feld aus von unten beginnend
        {
            for (int i= felder.Length - 1; i>=0; i--)
            {
                if (felder[i].istbelegt() == false)
                    return felder[i];                   // rückgabe des freien feldes
            }
            return null;
        }

     

     
         

    }
}
