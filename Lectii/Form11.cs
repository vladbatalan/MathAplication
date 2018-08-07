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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            foreach (Control Ctrl in groupBox1.Controls)
            {
                if (Ctrl is TextBox)
                {
                    TextBox tb = (TextBox)Ctrl;
                    tb.DragDrop += new DragEventHandler(tb_DragDrop);
                }
            }
        }


        //Navigare
        private void Inapoi_La_Lectii_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("LECTII", this, "CLOSE");
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("CONGRUENTA CAZURI5", this, "CLOSE");
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
        //Apelare Drag Effects
        private void txt18_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = e.AllowedEffect;
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void tb_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (listBox1.SelectedItem != null)
            {
                tb.Text = listBox1.SelectedItem.ToString();
                //Activam Butonul Verifica1? sau ba?
                foreach (Control Ctrl in groupBox1.Controls)
                {
                    bool ok = true;
                    if (Ctrl is TextBox)
                    {
                        TextBox t = (TextBox)Ctrl;
                        if (t.Text == null)
                            ok = false;
                    }
                    if (ok)
                        Verifica1.Enabled = true;
                }
            }
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Move);
        }

        //Validare
        int Nr_incercari1 = 0;
        private void Verifica1_Click(object sender, EventArgs e)
        {
            if ((System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt11.Text.ToUpper(), txt12.Text.ToUpper(), "AB,EF,DE,BC,DF,AC", "EF,AB,BC,DE,AC,DF",2) &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt13.Text.ToUpper(), txt14.Text.ToUpper(), "AB,EF,DE,BC,DF,AC", "EF,AB,BC,DE,AC,DF",2) &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt15.Text.ToUpper(), txt16.Text.ToUpper(), "AB,EF,DE,BC,DF,AC", "EF,AB,BC,DE,AC,DF",2) &&
                txt11.Text != txt13.Text && txt11.Text != txt14.Text && txt11.Text != txt15.Text && txt11.Text != txt16.Text &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt17.Text.ToUpper(), txt18.Text.ToUpper(), "ABC,ACB,BAC,BCA,CAB,CBA,FED,FDE,EFD,EDF,DFE,DEF", "FED,FDE,EFD,EDF,DFE,DEF,ABC,ACB,BAC,BCA,CAB,CBA",3))
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
                    txt12.Text = "EF";
                    txt13.Text = "BC";
                    txt14.Text = "DE";
                    txt15.Text = "AC";
                    txt16.Text = "DF";
                    txt17.Text = "ABC";
                    txt18.Text = "FED";
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
                    MessageBox.Show("Raspuns Gresit!" + '\n' + "Indiciu: Afla unghiurile corespondente din congruenta laturilor, de exemplu: In triunghiurile XYZ si DEF daca XY=DE inseamna ca m(<Z)=m(<F).");
                }
            }
        }





        
    }
}
