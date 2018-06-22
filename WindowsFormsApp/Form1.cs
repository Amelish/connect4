using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {

        Spiel aktuellesSpiel;
        System.Windows.Forms.Button[,] felder = new System.Windows.Forms.Button[7, 7];              // erstellt neue Buttonsarray


        public Form1()
        {
            InitializeComponent();          // erstellt die Sachen vom FormDesigner
            eigenerCodeFelder();                  // erstellt die eigenen designeten Felder
            ausgabeGewinner();
        }


       

        private void eigenerCodeFelder()
        {

           

            for (int i = 0; i < 7; i++)         // gibt den Buttons felder eine Identität
            {
                for (int j = 0; j < 6; j++)
                {
                    felder[i, j] = new System.Windows.Forms.Button();
                    initFeld(felder[i, j], i, j);                       // erstellen der button eigenschafeten
                }
            }

            void initFeld(System.Windows.Forms.Button feld, int x, int y)
            {
                feld.BackColor = System.Drawing.Color.White;
                feld.Location = new System.Drawing.Point(105 + x * 73, 114 + 73 * y);         // berechnung Postition
                feld.Name = "feld_" + x + y;
                feld.Size = new System.Drawing.Size(77, 73);
                feld.TabIndex = 3;
                feld.UseVisualStyleBackColor = false;
                this.Controls.Add(feld);
            }
        }

        private void spielfeldZeichnen(Spielfeld spielfeld)             // Zeichnet das Feld beim spielen
        {               
            for(int i = 0; i < 7; i++)
            {
                for(int j=0; j<6;j++)
                {   
                    if(spielfeld.getSpalte(i).getFeld(j).istbelegt())
                    {
                        Farbe farbe = spielfeld.getSpalte(i).getFeld(j).getSpieler().getFarbe();                // guckt welches Feld von welchem Spieler mit welcher Farbe belegt ist
                        if (farbe == Farbe.gelb)                                                                 // ist die Farbe geld, so wird auf das Beld ein gelber Kreis eingefügt
                            felder[i, j].Image = global::WindowsFormsApp.Properties.Resources.gelberKreis;
                        else if (farbe == Farbe.rot)
                            felder[i, j].Image = global::WindowsFormsApp.Properties.Resources.roterKreis;
                    }                    
                }
            }
        }


        void ausgabeGewinner()
        {
           
        }
     


        private void btn_Spalte_0_Click(object sender, EventArgs e)                             
        {
            aktuellesSpiel.getSpielfeld().getSpalte(0).einwerfen(aktuellesSpiel.getSpieler1()); // liest vom aktuellen Spielfeld die Spalte 0 und wirft dort rein in der Farbe von Spieler1
            spielfeldZeichnen(aktuellesSpiel.getSpielfeld());                                   // hier muss jetzt noch das Spielfeld in der Oberfäche dargestellt werden
          
            
        }
         private void btn_Spalte_1_Click(object sender, EventArgs e)
        {
            aktuellesSpiel.getSpielfeld().getSpalte(1).einwerfen(aktuellesSpiel.getSpieler1());
            spielfeldZeichnen(aktuellesSpiel.getSpielfeld());

        }

        private void btn_Spalte_2_Click(object sender, EventArgs e)
        {
            aktuellesSpiel.getSpielfeld().getSpalte(2).einwerfen(aktuellesSpiel.getSpieler1());
            spielfeldZeichnen(aktuellesSpiel.getSpielfeld());
  
        }

        private void btn_Spalte_3_Click(object sender, EventArgs e)
        {
            aktuellesSpiel.getSpielfeld().getSpalte(3).einwerfen(aktuellesSpiel.getSpieler1());
            spielfeldZeichnen(aktuellesSpiel.getSpielfeld());

        }
        private void btn_Spalte_4_Click(object sender, EventArgs e)
        {
            aktuellesSpiel.getSpielfeld().getSpalte(4).einwerfen(aktuellesSpiel.getSpieler1());
            spielfeldZeichnen(aktuellesSpiel.getSpielfeld());
       
        }
        private void btn_Spalte_5_Click(object sender, EventArgs e)
        {
            aktuellesSpiel.getSpielfeld().getSpalte(5).einwerfen(aktuellesSpiel.getSpieler1());
            spielfeldZeichnen(aktuellesSpiel.getSpielfeld());
        
        }
        private void btn_Spalte_6_Click(object sender, EventArgs e)
        {
            aktuellesSpiel.getSpielfeld().getSpalte(6).einwerfen(aktuellesSpiel.getSpieler1());
            spielfeldZeichnen(aktuellesSpiel.getSpielfeld());
  
        }

        private void entwicklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simon Knappe \nMiriam Krämer", "Entwickler");
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spieler spieler1 = new Spieler(); // Erstellt neuen Spieler 1 
            spieler1.setFarbe(Farbe.gelb);      // mit Farbe gelb
            Spieler spieler2 = new Spieler();       // Spiler 2 wäre dann der KI mit Frabe rot
            spieler2.setFarbe(Farbe.rot);
            Spielfeld spielfeld = new Spielfeld(); // Erstellt neues leeres Spielfeld
            Spiel spiel = new Spiel(spieler1, spieler2, spielfeld);                            // erzeugen eines neuen Objekts von der Klasse Spiel
            aktuellesSpiel = spiel;                                                             // setzt ein neues Spie
            spielfeldZeichnen(aktuellesSpiel.getSpielfeld());


        }

   
    }
}
