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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Inapoi_La_Lectii_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA CAZURI4", this, "CLOSE");
        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA CAZURI6", this, "HIDE");
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

        private void Verifica1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == "CONGRUENTE" && (textBox2.Text.ToUpper() == "LLL" || textBox2.Text.ToUpper() == "L.L.L." || textBox2.Text.ToUpper() == "L.L.L"))
            {
                MessageBox.Show("Raspuns corect! Felicitari!");
                Verifica1.Text = "Corect!";
                Verifica1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Raspuns gresit!" + "\n" + "Idiciu: Hai ca este prea usor. Verifica eventuale greseli de scriere. Daca nici asta nu functioneaza mai consulta odata lectia.");
            }
        }
    }
}
