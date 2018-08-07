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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int Nr_apasare_Validare = 0;
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Form4 f=new Form4();
            this.Close();
            f.Show();
        }

        private void Verifica1_Click(object sender, EventArgs e)
        {
            string a="Raspunsul a este ";
            int Raspunsuri_Gresite=0;
            if (rdi1_isoscel.Checked == true)
                a += "Corect";
            else
            {
                a += "Gresit ";
                Raspunsuri_Gresite++;
            }
            a += "! Raspunsul b este ";
            if (rdi2_echilateral.Checked == true)
                a += "Corect!";
            else
            {
                a += "Gresit!";
                Raspunsuri_Gresite++;
            }
            MessageBox.Show(a);
            if (Raspunsuri_Gresite == 0)
                Verifica1.ForeColor = Color.Green;
            else
                if (Raspunsuri_Gresite == 2)
                    Verifica1.ForeColor = Color.Red;
                else
                    Verifica1.ForeColor = DefaultForeColor;
            Verifica1.Text = a;

        }

        public bool Valideaza_Corespondenta_Trighiurilor(string s1, string s2, string solutie1, string solutie2)
        {
            int lghsol = solutie1.Length, lghs = s1.Length;
            int i = 0, j;
            while (i < lghsol)
            {
                int ok = 1;
                for (j = i; j < i + lghs; j++)
                {
                    if (s1[j - i] != solutie1[j] || s2[j - i] != solutie2[j])
                        ok = 0;
                }
                if (ok == 1)
                    return true;
                else
                    i = j + 1;
            }
            return false;
        }

        private void Verifica2_Click(object sender, EventArgs e)
        {
            if (Valideaza_Corespondenta_Trighiurilor(txt41.Text.ToUpper(), txt42.Text.ToUpper(), "ABC,ACB,BCA,BAC,CBA,CAB", "PMN,PNM,MNP,MPN,NMP,NPM"))
            {
                MessageBox.Show("Raspuns corect! Felicitari!");
                Verifica2.ForeColor = Color.Green;
                Verifica2.Text = "Corect";
                Verifica2.Enabled = false;
                txt41.Enabled = false;
                txt42.Enabled = false;
            }
            else
            {
                Nr_apasare_Validare++;
                if (Nr_apasare_Validare == 3)
                {
                    MessageBox.Show("Raspuns Gresit! Raspunsul corect va fi afisat!");
                    Verifica2.ForeColor = Color.Red;
                    Verifica2.Text = "Gresit";
                    txt41.Text = "ABC";
                    txt42.Text = "PMN";
                    txt41.Enabled = false;
                    txt42.Enabled = false;
                    Verifica2.Enabled = false;

                }
                else
                    MessageBox.Show("Gresit!" + "\n" + "Indiciu: Priveste cu atentie figura si vezi care sunt unghiurile congruente.");
            }
        }

        private void txt41_TextChanged(object sender, EventArgs e)
        {
            //Verifica daca toate texboxurile sunt completate
            if (txt41.TextLength == 3 && txt42.TextLength == 3)
                Verifica2.Enabled = true;
            else
                Verifica2.Enabled = false;
        }

        private void Inapoi_La_Lectii_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("LECTII", this, "CLOSE");
            //Inchidem ferestele ascunse
            Form f = new Form();
            f = new Form3();
            f.Close();
            f = new Form4();
            f.Close();
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

    }
}
