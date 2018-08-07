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
    public partial class Test_Usor_Pagina_1 : Form
    {
        public Test_Usor_Pagina_1()
        {
            InitializeComponent();
        }
        private void Test_Usor_Pagina_1_Load(object sender, EventArgs e)
        {
            foreach (Control Ctrl in panel1.Controls)
            {
                if(Ctrl is Label)
                {
                    if (Ctrl.Text.ToUpper() == "BISECTOARE" || Ctrl.Text.ToUpper() == "BISECTOAREA" || Ctrl.Text.ToUpper() == "ÎNĂLȚIME" || Ctrl.Text.ToUpper() == "ÎNĂLȚIMEA" || Ctrl.Text.ToUpper() == "MEDIANA" || Ctrl.Text.ToUpper() == "MEDIANĂ")
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
        // Realizam o scurtatura la cateva functii de pe forma1
        private bool Corespondenta_2(string s1, string s2, string sol1,string sol2, int SL)
        {
            return (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(s1, s2, sol1, sol2, SL);
        }
        private bool Corespondenta_1(string s1, string sol1, int SL)
        {
            return (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Stringul(s1, sol1, SL);
        }

        // Navigare
        private void Inapoi_La_Lectii_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("TESTE", this, "CLOSE");
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
            if (lb.Text.ToUpper() == "BISECTOARE" || lb.Text.ToUpper() == "BISECTOAREA")
            {
                Proprietati_Bisectoare f = new Proprietati_Bisectoare();
                f.ShowDialog();
            }
            if (lb.Text.ToUpper() == "ÎNĂLȚIME" || lb.Text.ToUpper() == "ÎNĂLȚIMEA")
            {
                Propietati_Inaltime f = new Propietati_Inaltime();
                f.ShowDialog();
            }
            if (lb.Text.ToUpper() == "MEDIANA" || lb.Text.ToUpper() == "MEDIANĂ")
            {
                Propietati_Mediana f = new Propietati_Mediana();
                f.ShowDialog();
            }
        }

        //Validari peste validari
        private void Verifica_1_Click(object sender, EventArgs e)
        {
            if (chb_1_1.Checked && chb_1_3.Checked)
            {
                MessageBox.Show("Raspuns corect! Primul pas spre a deveni mai bun!");
                Raspuns_corect(Verifica_1);
            }
            else
                MessageBox.Show("Mai incearca! Sfat: priveste atent unghiurile corespondente.");
        }

        private void Verifica_2_Click(object sender, EventArgs e)
        {
            if (txt_2_1.Text == "110" && txt_2_2.Text == "3" && txt_2_3.Text == "5")
            {
                MessageBox.Show("Raspuns corect! Te felicit! Tine-o tot asa! :P");
                Raspuns_corect(Verifica_2);
            }
            else
                MessageBox.Show("Mai incearca! Sfat: priveste atent unghiurile corespondente.");
        }

        private void Verifica_3_Click(object sender, EventArgs e)
        {
            if (txt_3_1.Text == "14" && txt_3_2.Text == "7" && txt_3_3.Text == "9")
            {
                MessageBox.Show("Raspuns corect! Te-am subestimat!");
                Raspuns_corect(Verifica_3);
            }
            else
                MessageBox.Show("Mai incearca! Sfat: priveste atent unghiurile corespondente.");
        }

        private void Verifica_4_Click(object sender, EventArgs e)
        {
            if(Corespondenta_2(txt_4_1.Text.ToUpper(),txt_4_2.Text.ToUpper(),"ABC,ACB,BCA,BAC,CAB,CBA,ADE,AED,DEA,DAE,EAD,EDA","ADE,AED,DEA,DAE,EAD,EDA,ABC,ACB,BCA,BAC,CAB,CBA",3) &&
            (txt_4_3.Text.ToUpper()=="LLL" ||txt_4_3.Text.ToUpper()=="L.L.L" || txt_4_3.Text.ToUpper()=="L.L.L."))
            {
                MessageBox.Show("Raspuns corect! Te pricepi!");
                Raspuns_corect(Verifica_4);
            }
            else
                MessageBox.Show("Mai incearca! Sfat: Afla unghiurile corespondente din congruenta laturilor, de exemplu: In triunghiurile XYZ si DEF daca XY=DE inseamna ca m(<Z)=m(<F).");
        }

        private void Verifica_5_Click(object sender, EventArgs e)
        {
            if (txt_5_2.Text.ToUpper() == "CONGRUENTE" && (txt_5_1.Text.ToUpper() == "LLL" || txt_5_2.Text.ToUpper() == "L.L.L" || txt_5_2.Text.ToUpper() == "L.L.L."))
            {
                MessageBox.Show("Raspuns corect! Esti omul meu! xD");
                Raspuns_corect(Verifica_5);
            }
            else
                MessageBox.Show("Mai incearca! Sfat: Două câte două se referă la faptul că toate sunt egale!");
        }

        private void Verifica_6_Click(object sender, EventArgs e)
        {
            if (Corespondenta_1(txt_6_1.Text.ToUpper(), "PMN,NMP", 3))
            {
                MessageBox.Show("Raspuns corect! Nu incetezi sa ma uimesti!");
                Raspuns_corect(Verifica_6);
            }
            else
                MessageBox.Show("Mai incearca! Sfat: Poti considera [AC] calatura comuna.");
        }

        private void Verifica_7_Click(object sender, EventArgs e)
        {
            if (Corespondenta_1(txt_7_1.Text.ToUpper(), "ACD,DCA", 3))
            {
                MessageBox.Show("Raspuns corect! Smecherie cu dublu SM! ;)");
                Raspuns_corect(Verifica_6);
            }
            else
                MessageBox.Show("Mai incearca! Sfat: Poti considera [AC] calatura comuna.");
        }

    }
}
