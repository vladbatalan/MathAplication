using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }



        private void Inapoi_La_Lectii_Click_1(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA CAZURI2", this, "CLOSE");
        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA CAZURI4", this, "HIDE");
        }

        // Butoane Menu Strip Comenzi rapide:
        private void inapoiLaMeniulPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("MENIU", this, "CLOSE");
        }

        private void inapoiLaMeniulLectiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("LECTII", this, "CLOSE");
        }

        private void inchideAplicatiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Exercitii
       

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text.Length == 3 && txt2.Text.Length == 3)
            {
                Verifica2.Enabled = true;
            }
            else
            {
                Verifica2.Enabled = false;
            }

        }
        //Validare
        int Nr_gresite = 0;
        private void Verifica2_Click(object sender, EventArgs e)
        {
            if ((System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt1.Text.ToUpper(), txt2.Text.ToUpper(), "ABC,ACB,BCA,BAC,CAB,CBA,MNP,MPN,NPM,NMP,PMN,PNM", "MNP,MPN,NPM,NMP,PMN,PNM,ABC,ACB,BCA,BAC,CAB,CBA", 3))
            {
                MessageBox.Show("Raspuns corect! Felicitari!");
                Verifica2.Text = "Corect!";
                Verifica2.Enabled = false;
                txt1.Enabled = false;
                txt2.Enabled = false;
            }
            else
            {
                Nr_gresite++;
                if (Nr_gresite == 3)
                {
                    MessageBox.Show("Raspuns gresit! Rezultatul corect va fi afisat!");
                    Verifica2.Text = "Gresit!";
                    txt1.Text = "ABC";
                    txt2.Text = "PNM";
                    txt1.Enabled = false;
                    txt2.Enabled = false;
                    Verifica2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Raspuns gresit!"+"\n"+"Indiciu: Calculeaza masura unghiului <BAC si vezi daca este congruent cu vreun alt unghi.");
                }
            }

        }

    }
}
