using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp
{
    class Spielfeld
    {
        public Spielfeld()                  //Konstruktor
        {
            for (int i=0; i<7; i++)
            {
                spalten[i] = new Spalte();       // erstellen neuer Spalten.Objekte           
            }
        }

        private
        //int runde;
        Spalte[] spalten = new Spalte[7];       //Erstellen eines arrays von 7

        public Spalte getSpalte(int i)      // Lesen einer bestimmten Spalte
        {
            return spalten[i];
        }

   
    }
}
