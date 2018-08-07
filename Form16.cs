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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            foreach (Control Ctrl in this.Controls)
            {
                if (Ctrl is PictureBox)
                {
                    PictureBox pb = (PictureBox)Ctrl;
                    pb.MouseEnter += new EventHandler(pb_MouseEnter);
                    pb.MouseLeave += new EventHandler(pb_MouseLeave);
                }
            }

        }
        private void pb_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb == Test1_Intelegere)
                pb.Image = Properties.Resources.Test_NivelUsor;
            if (pb == Test2_Exersare)
                pb.Image = Properties.Resources.Test_NivelMediu;
            if (pb == Test3_Aprofundare)
                pb.Image = Properties.Resources.Test_NivelGreu;
        }
        private void pb_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = null;
        }

        // Butoane Menu Strip Comenzi rapide:
        private void inapoiLaMeniulPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("MENIU", this, "CLOSE");
        }

        private void inapoiLaMeniulTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("TESTE", this, "CLOSE");
        }

        private void inchideAplicatiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Navigare
        private void Intoarcere_Meniu_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("MENIU", this, "CLOSE");
        }
        private void Test1_Intelegere_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("TEST USOR", this, "HIDE");
        }
        private void Test2_Exersare_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("TEST MEDIU", this, "HIDE");
        }

        private void Test3_Aprofundare_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("TEST GREU", this, "HIDE");
        }
        
    }
}
