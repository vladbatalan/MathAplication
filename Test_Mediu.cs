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
    public partial class Test_Mediu : Form
    {
        public Test_Mediu()
        {
            InitializeComponent();
        }
        private void Test_Mediu_Load(object sender, EventArgs e)
        {
            foreach (Control Ctrl in panel1.Controls)
            {
                if (Ctrl is Label)
                {
                    if (Ctrl.Text.ToUpper() == "BISECTOARE" || Ctrl.Text.ToUpper() == "BISECTOARELE" || Ctrl.Text.ToUpper() == "BISECTOAREA")
                    {
                        Label lb = (Label)Ctrl;
                        lb.MouseEnter += new EventHandler(bisectoare_MouseEnter);
                        lb.MouseLeave += new EventHandler(bisectoare_MouseLeave);
                        lb.MouseClick += new MouseEventHandler(bisectoare_MouseClick);
                    }
                }
            }
        }
        private void Raspuns_corect(Button b)
        {
            b.Text = "Corect";
            b.ForeColor = Color.Green;
        }
        // INDICII COLORATE 
        private void bisectoare_MouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.LightGray;
        }
        private void bisectoare_MouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.Transparent;
        }
        private void bisectoare_MouseClick(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            if (lb.Text.ToUpper() == "BISECTOARE" || lb.Text.ToUpper() == "BISECTOAREA" || lb.Text.ToUpper() == "BISECTOARELE")
            {
                Proprietati_Bisectoare f = new Proprietati_Bisectoare();
                f.ShowDialog();
            }
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
        private void Inapoi_La_Lectii_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("TESTE", this, "CLOSE");
        }
        

    }
}
