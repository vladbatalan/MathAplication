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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }



        private void Inapoi_La_Lectii_Click_1(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA CAZURI3", this, "CLOSE");
        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA CAZURI5", this, "HIDE");
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
        //Validare
        private void Verifica1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToUpper()=="CONGRUENTE" && (textBox2.Text.ToUpper()=="ULU" || textBox2.Text.ToUpper()=="U.L.U." || textBox2.Text.ToUpper()=="U.L.U"))
            {
                MessageBox.Show("Raspuns corect! Felicitari!");
                Verifica1.Text="Corect!";
                Verifica1.Enabled=false;
                textBox1.Enabled=false;
                textBox2.Enabled=false;
            }
            else
            {
                MessageBox.Show("Raspuns gresit!"+"\n"+"Idiciu: Hai ca este prea usor. Verifica eventuale greseli de scriere. Daca nici asta nu functioneaza mai consulta odata lectia.");
            }
        }

    }
}
