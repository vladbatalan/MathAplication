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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            foreach(Control Ctrl in groupBox1.Controls)
            {
                if(Ctrl is TextBox)
                {
                    TextBox tb = (TextBox)Ctrl;
                    tb.DragDrop +=new DragEventHandler(tb_DragDrop);
                }
            }
            foreach (Control Ctrl in groupBox2.Controls)
            {
                if (Ctrl is TextBox)
                {
                    TextBox tb = (TextBox)Ctrl;
                    tb.DragDrop += new DragEventHandler(tb2_DragDrop);
                }
            }

        }




        //Navigare
        private void Inapoi_La_Lectii_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA CAZURI1", this, "CLOSE");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA CAZURI3", this, "HIDE");
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

        // Exercitii 
        // Drag efecte
        private void txt28_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = e.AllowedEffect;
            }
            else
                e.Effect = DragDropEffects.None;
        }
        private void txt11_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = e.AllowedEffect;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Move);
        }

        private void tb_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb=(TextBox)sender;
            if(listBox1.SelectedItem!=null)
            {
                tb.Text = listBox1.SelectedItem.ToString();
                //Activam Butonul Verifica1? sau ba?
                foreach(Control Ctrl in groupBox1.Controls)
                {
                    bool ok=true;
                    if(Ctrl is TextBox)
                    {
                        TextBox t=(TextBox)Ctrl;
                        if (t.Text == null)
                            ok = false;
                    }
                    if (ok)
                        Verifica1.Enabled = true;
                } 
            }
        }
        private void tb2_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (listBox1.SelectedItem != null)
            {
                tb.Text = listBox1.SelectedItem.ToString();
                //Activam Butonul Verifica1? sau ba?
                foreach (Control Ctrl in groupBox2.Controls)
                {
                    bool ok = true;
                    if (Ctrl is TextBox)
                    {
                        TextBox t = (TextBox)Ctrl;
                        if (t.Text == null)
                            ok = false;
                    }
                    if (ok)
                        Verifica2.Enabled = true;
                }
            }
        }

        //validari
        int Nr_incercari1=0,Nr_incercari2=0;
        private void Verifica1_Click(object sender, EventArgs e)
        {
            if ((System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt11.Text.ToUpper(), txt12.Text.ToUpper(), "AB,NP,MN,BC", "NP,AB,BC,MN",2) &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt13.Text.ToUpper(), txt14.Text.ToUpper(), "AB,NP,MN,BC", "NP,AB,BC,MN",2) &&
                txt11.Text != txt13.Text && txt11.Text != txt14.Text && txt15.Text.Length == 3 && txt17.Text.Length == 3 &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt17.Text.ToUpper(), txt18.Text.ToUpper(), "ABC,ACB,BCA,BAC,CAB,CBA,PNM,PMN,NMP,NPM,MPN,MNP", "PNM,PMN,NMP,NPM,MPN,MNP,ABC,ACB,BCA,BAC,CAB,CBA",3) &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt15.Text.ToUpper(), txt16.Text.ToUpper(), "ABC,ABC,CBA,CBA,MNP,PNM,MNP,PNM", "MNP,PNM,MNP,PNM,ABC,ABC,CBA,CBA",3))
            {
                MessageBox.Show("Raspuns corect! Felicitari!");
                foreach (Control Ctrl in groupBox1.Controls)
                {
                    if (Ctrl is TextBox)
                        Ctrl.Enabled = false;
                }
                Verifica1.Text = "Corect!";
                Verifica1.Enabled = false;
            }
            else
            {
                Nr_incercari1++;
                if (Nr_incercari1 == 3)
                {
                    MessageBox.Show("Raspuns Gresit! Raspunsul corect va fi afisat!");
                    txt11.Text = "AB";
                    txt12.Text = "NP";
                    txt13.Text = "BC";
                    txt14.Text = "MN";
                    txt15.Text = "ABC";
                    txt16.Text = "MNP";
                    txt17.Text = "ABC";
                    txt18.Text = "PMN";
                    foreach (Control Ctrl in groupBox1.Controls)
                    {
                        if (Ctrl is TextBox)
                            Ctrl.Enabled = false;
                    }
                    Verifica1.Text = "Gresit!";
                    Verifica1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Raspuns Gresit!"+'\n'+"Indiciu: Afla unghiurile corespondente din congruenta laturilor, de exemplu: In triunghiurile XYZ si DEF daca XY=DE inseamna ca m(<Z)=m(<F).");
                }
            }
        }

        private void Verifica2_Click(object sender, EventArgs e)
        {
            if ((System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt21.Text.ToUpper(), txt22.Text.ToUpper(), "AC,MP,BC,NP", "MP,AB,NP,BC",2) &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt23.Text.ToUpper(), txt24.Text.ToUpper(), "AC,MP,BC,NP", "MP,AB,NP,BC",2) &&
                txt21.Text != txt23.Text && txt21.Text != txt24.Text && txt25.Text.Length == 3 && txt27.Text.Length == 3 &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt27.Text.ToUpper(), txt28.Text.ToUpper(), "ABC,ACB,BCA,BAC,CAB,CBA,MNP,MPN,NPM,NMP,PMN,PNM", "MNP,MPN,NPM,NMP,PMN,PNM,ABC,ACB,BCA,BAC,CAB,CBA",3) &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt25.Text.ToUpper(), txt26.Text.ToUpper(), "ACB,ACB,BCA,BCA,MNP,PNM,MNP,PNM", "MPN,NPM,MPN,NPM,ACB,ACB,BCA,BCA",3))
            {
                MessageBox.Show("Raspuns corect! Felicitari!");
                foreach (Control Ctrl in groupBox2.Controls)
                {
                    if (Ctrl is TextBox)
                        Ctrl.Enabled = false;
                }
                Verifica2.Text = "Corect!";
                Verifica2.Enabled = false;
            }
            else
            {
                Nr_incercari2++;
                if (Nr_incercari2 == 3)
                {
                    MessageBox.Show("Raspuns Gresit! Raspunsul corect va fi afisat!");
                    txt21.Text = "AC";
                    txt22.Text = "MP";
                    txt23.Text = "BC";
                    txt24.Text = "NP";
                    txt25.Text = "ACB";
                    txt26.Text = "MPN";
                    txt27.Text = "ABC";
                    txt28.Text = "MNP";
                    foreach (Control Ctrl in groupBox2.Controls)
                    {
                        if (Ctrl is TextBox)
                            Ctrl.Enabled = false;
                    }
                    Verifica2.Text = "Gresit!";
                    Verifica2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Raspuns Gresit!" + '\n' + "Indiciu: Afla unghiurile corespondente din congruenta laturilor, de exemplu: In triunghiurile XYZ si DEF daca XY=DE inseamna ca m(<Z)=m(<F).");
                }
            }
        }

        


        
    }
}
