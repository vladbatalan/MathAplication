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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Sectiunea rezolvare exercitii
        int Nr_apasare_Validare1 = 0, Nr_apasare_Validare2 = 0;
        private void txt11_TextChanged(object sender, EventArgs e)
        {
            //Verifica daca toate texboxurile sunt completate
            if (txt11.TextLength == 1 && txt12.TextLength == 1 && txt13.TextLength == 2 && txt14.TextLength == 2)
                Verifica.Enabled = true;
            else
                Verifica.Enabled = false;
        }

        private void txt22_TextChanged(object sender, EventArgs e)
        {
            //Verifica daca toate texboxurile sunt completate
            if (txt21.Text.Length == 3 && txt22.Text.Length == 3)
                Verifica2.Enabled = true;
            else
                Verifica2.Enabled = false;
        }

        private void Verifica_Click(object sender, EventArgs e)
        {
            if ((System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Stringul(txt11.Text.ToUpper(), "P",1) && (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Stringul(txt12.Text.ToUpper(), "R",1) && (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Stringul(txt13.Text.ToUpper(), "PQ,QP",2) && (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Stringul(txt14.Text.ToUpper(), "PR,RP",2))
            {
                MessageBox.Show("Raspuns corect! Felicitari!");
                Verifica.ForeColor = Color.Green;
                Verifica.Text = "Corect";
                Verifica.Enabled = false;
                txt11.Enabled = false;
                txt12.Enabled = false;
                txt13.Enabled = false;
                txt14.Enabled = false;
            }
            else
            {
                Nr_apasare_Validare1++;
                if (Nr_apasare_Validare1 == 3)
                {
                    MessageBox.Show("Raspuns Gresit! Raspunsul corect va fi afisat!");
                    Verifica.ForeColor = Color.Red;
                    Verifica.Text = "Gresit";
                    txt11.Text = "P";
                    txt12.Text = "R";
                    txt13.Text = "PQ";
                    txt14.Text = "PR";
                    txt11.Enabled = false;
                    txt12.Enabled = false;
                    txt13.Enabled = false;
                    txt14.Enabled = false;
                    Verifica.Enabled = false;

                }
                else
                    MessageBox.Show("Gresit!"+"\n"+"Indiciu: Incearca sa faci o corespondenta dintre unghiurile din primul si al doilea triunghi (lui B ii corespunde Q)");
            }
        }

        private void Verifica2_Click(object sender, EventArgs e)
        {
            if ((System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt21.Text.ToUpper(), txt22.Text.ToUpper(), "ABC,CBA,BAC,CAB,ACB,BCA", "XZY,YZX,ZXY,YXZ,XYZ,ZYX",3))
            {
                MessageBox.Show("Raspuns corect! Felicitari!");
                Verifica2.ForeColor = Color.Green;
                Verifica2.Text = "Corect";
                Verifica2.Enabled = false;
                txt21.Enabled = false;
                txt22.Enabled = false;
            }
            else
            {
                Nr_apasare_Validare2++;
                if (Nr_apasare_Validare2 == 3)
                {
                    MessageBox.Show("Raspuns Gresit! Raspunsul corect va fi afisat!");
                    Verifica2.ForeColor = Color.Red;
                    Verifica2.Text = "Gresit";
                    txt21.Text = "ABC";
                    txt22.Text = "XZY";
                    txt21.Enabled = false;
                    txt22.Enabled = false;
                    Verifica2.Enabled = false;

                }
                else
                    MessageBox.Show("Gresit!" + "\n" + "Indiciu: Foloseste-te de faptul ca unghiurile corespondente sunt congruente, de exemplu pe pozitia unde este B va fi pus in celalalt triunghi Z");
            }
        }
        // Inchidem sectiunea rezolvare exercitii
        private void Next_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA INTRODUCERE3", this, "HIDE");
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA INTRODUCERE1", this, "CLOSE");
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
