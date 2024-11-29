using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FlightApp
{
    public partial class FormFlightApp : Form
    {
        
       private List<string[]> _vluchtenlist = new List<string[]>();

        public FormFlightApp()
        {
            InitializeComponent();
        }

        private void FormFlightApp_Load(object sender, EventArgs e)
        {
            //Declaratie
            string volledigeLijn;
            string[] vlucht;



            //Instellen van het dialoogvenster openen
            OpenFileDialog dlgOpen = new OpenFileDialog();
            //Eigenschappen instellen 
            dlgOpen.Title = "Openen";
            dlgOpen.FileName = "";
            dlgOpen.DefaultExt = ".txt";
            dlgOpen.InitialDirectory = Application.StartupPath;
            dlgOpen.Filter = "Tekstbestannden (.txt)|*.txt|Alle bestanden (*.*)|*.*";

            //Dialoogvenster tonen en de keuze opvangen
            DialogResult resultaat = dlgOpen.ShowDialog();

            //Kijken of de gebruiker "openen" geklikt heeft
            if (resultaat == DialogResult.OK)
            {



                using (StreamReader streamLees = new StreamReader(dlgOpen.FileName))
                {

                    while (streamLees.Peek() != -1)
                    {
                        volledigeLijn = streamLees.ReadLine();
                        vlucht = volledigeLijn.Split(';');

                        //we voegen deze 1D array toe aan de list
                        _vluchtenlist.Add(vlucht);
                    }
                }

            }
            //Layout maken en opvullen
            layout(_vluchtenlist);
        }

        private void layout(List<string[]> vluchtenlist)
        {
            string temp = "";

            foreach (string[] vlucht in vluchtenlist)
            {
                temp = ("[" + vlucht[7] + "]").PadRight(20);
                temp += ("[" + vlucht[1] + "]").PadRight(30)+"==>"+ vlucht[3].PadRight(45);
                temp += (vlucht[4] +"/" + vlucht[5]).PadRight(6);
                temp += (vlucht[8]).PadRight(6);

                listBoxFlights.Items.Add(temp);

            }
            
        }

        private void checkBoxDom_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }

       

        private void checkBoxInt_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }
        private void filter()
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaratie
            string volledigeLijn;
            string[] vlucht;



            //Instellen van het dialoogvenster openen
            OpenFileDialog dlgOpen = new OpenFileDialog();
            //Eigenschappen instellen 
            dlgOpen.Title = "Openen";
            dlgOpen.FileName = "";
            dlgOpen.DefaultExt = ".txt";
            dlgOpen.InitialDirectory = Application.StartupPath;
            dlgOpen.Filter = "Tekstbestannden (.txt)|*.txt|Alle bestanden (*.*)|*.*";

            //Dialoogvenster tonen en de keuze opvangen
            DialogResult resultaat = dlgOpen.ShowDialog();

            //Kijken of de gebruiker "openen" geklikt heeft
            if (resultaat == DialogResult.OK)
            {



                using (StreamReader streamLees = new StreamReader(dlgOpen.FileName))
                {

                    while (streamLees.Peek() != -1)
                    {
                        volledigeLijn = streamLees.ReadLine();
                        vlucht = volledigeLijn.Split(';');

                        //we voegen deze 1D array toe aan de list
                        _vluchtenlist.Add(vlucht);
                    }
                }

            }
            //Layout maken en opvullen
            layout(_vluchtenlist);
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

        /*
         * Naam:
         * Klas:
         */





}

