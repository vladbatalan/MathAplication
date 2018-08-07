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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Lectie1_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA INTRODUCERE1", this, "HIDE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("MENIU",this, "CLOSE");
        }

        private void Lectie2_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA CAZURI1", this, "HIDE");
        }

        private void Lectie3_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA DREPTUNGHICE", this, "HIDE");
        }



        // Butoane Menu Strip Comenzi rapide:
        private void inapoiLaMeniulPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("MENIU", this, "CLOSE");
        }

        private void inchideAplicatiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
