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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        Image[] Pagina = new Image[7];
        private void Form12_Load(object sender, EventArgs e)
        {
            
            Pagina[0] = Properties.Resources.Congruenta_triunghiuri_dreptunghice1;
            Pagina[1] = Properties.Resources.Congruenta_triunghiuri_dreptunghice2;
            Pagina[2] = Properties.Resources.Congruenta_triunghiuri_dreptunghice3;
            Pagina[3] = Properties.Resources.Congruenta_triunghiuri_dreptunghice4;
            Pagina[4] = Properties.Resources.Congruenta_triunghiuri_dreptunghice5;
            Pagina[5] = Properties.Resources.Congruenta_triunghiuri_dreptunghice6;
            foreach (Control Ctrl in panel1.Controls)
            {
                if (Ctrl is Label)
                {
                    Label l = (Label)Ctrl;
                    l.MouseEnter += new EventHandler(l_MouseEnter);
                    l.MouseLeave += new EventHandler(l_MouseLeave);
                }

                if (Ctrl is TextBox && Ctrl.Name[Ctrl.Name.Length - 1] == '3')
                {
                    TextBox tb = (TextBox)Ctrl;
                    tb.DragDrop += new DragEventHandler(tb_DragDrop_3);
                }
            }

        }
        private void l_MouseEnter(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = Color.LightGray;
        }
        private void l_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = Color.Transparent;
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

        //Navigare intre paginile formei
        int pagina_curenta = 0;
        private void Inapoi_La_Lectii_Click(object sender, EventArgs e)
        {
            if (pagina_curenta % 6 == 0)
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("LECTII", this, "CLOSE");
            else
            {
                pagina_curenta--;
                Reda_controalele_de_pe_pagini();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (pagina_curenta % 6 == 5)
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Afisare_Forma("LECTII", this, "CLOSE");
            else
            {
                pagina_curenta++;
                Reda_controalele_de_pe_pagini();
            }
        }

        private void Reda_controalele_de_pe_pagini()
        {
            panel1.BackgroundImage = Pagina[pagina_curenta % 6];
            this.Text = "Lectie 3 Congruenta triunghiurilor dreptunghice Pagina " + (pagina_curenta + 1);
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name[ctrl.Name.Length - 1] == (pagina_curenta + 1).ToString()[0])
                {
                    if (ctrl is TextBox)
                        ctrl.Text = "";
                    ctrl.Enabled = true;
                    ctrl.Visible = true;
                }
                else
                {
                    if (ctrl != Inapoi_La_Lectii && ctrl != Next && ctrl != menuStrip1)
                    {
                        ctrl.Enabled = false;
                        ctrl.Visible = false;
                    }
                }
            }
            switch (pagina_curenta)
            {
                case 0:
                    Inapoi_La_Lectii.Text = "Inapoi la lista cu lectii";
                    Inapoi_La_Lectii.Size = new Size(268,35);
                    break;
                case 1:
                    Inapoi_La_Lectii.Text = "Anterior";
                    Inapoi_La_Lectii.Size = Next.Size;
                    Verifica_2.Enabled = false;
                    Verifica_2.Text = "Verifica";
                    Nr_incercari2 = 0;
                    break;
                case 2:
                    Verifica3.Enabled = false;
                    Verifica3.Text = "Verifica";
                    Nr_incercari3 = 0;
                    break;
                case 4:
                    Next.Size = new Size(147, 35);
                    Next.Text = "Urmator";
                    Next.Location = new Point(385, Inapoi_La_Lectii.Location.Y);
                    break;
                case 5:
                    Next.Location = new Point(260, Inapoi_La_Lectii.Location.Y);
                    Next.Size = new Size(268, 35);
                    Next.Text = "Inapoi la lista cu lectii";
                    break;

            }
        }
        //Exercitii
        //Pagina 2
        private void txt6_2_TextChanged(object sender, EventArgs e)
        {
            bool ok = true;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name[ctrl.Name.Length - 1] == (pagina_curenta + 1).ToString()[0] && ctrl is TextBox)
                {
                    if (ctrl.Text == "")
                        ok = false;
                }
            }
            if (ok)
                Verifica_2.Enabled = true;
            else
                Verifica_2.Enabled = false;
        }
        int Nr_incercari2 = 0;
        private void Verifica_2_Click(object sender, EventArgs e)
        {
            if ((System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Stringul(txt1_2.Text.ToUpper(), "MNP,PMN", 3) &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Stringul(txt2_2.Text.ToUpper(), "30", 2) &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Stringul(txt3_2.Text.ToUpper(), "60", 2) &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Corespondenta_Trighiurilor(txt4_2.Text.ToUpper(), txt5_2.Text.ToUpper(), "MPN,MPN,NPM,NPM,ACB,BCA,ACB,BCA", "ACB,BCA,ACB,BCA,MPN,MPN,NPM,NPM", 3) &&
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Valideaza_Stringul(txt6_2.Text.ToUpper(), "MNP", 3))
            {
                MessageBox.Show("Raspuns corect! Felicitari!");
                Verifica_2.Enabled = false;
                Verifica_2.Text = "Corect";
                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl.Name[ctrl.Name.Length - 1] == (pagina_curenta + 1).ToString()[0] && ctrl is TextBox)
                    {
                        ctrl.Enabled = false;
                    }
                }
            }
            else
            {
                Nr_incercari2++;
                if (Nr_incercari2 == 3)
                {
                    MessageBox.Show("Raspuns gresit! Raspunsurile corecte vor fi afisate!");
                    Verifica_2.Enabled = false;
                    Verifica_2.Text = "Gresit";
                    foreach (Control ctrl in panel1.Controls)
                    {
                        if (ctrl.Name[ctrl.Name.Length - 1] == (pagina_curenta + 1).ToString()[0] && ctrl is TextBox)
                        {
                            ctrl.Enabled = false;
                        }
                    }
                    txt1_2.Text = "MNP";
                    txt2_2.Text = "30";
                    txt3_2.Text = "60";
                    txt4_2.Text = "ACB";
                    txt5_2.Text = "MPN";
                    txt6_2.Text = "MNP";
                    Verifica_2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Raspuns gresit!");
                }
            }
        }

        //Pagina 3
        private void listBox3_MouseDown(object sender, MouseEventArgs e)
        {
            listBox3.DoDragDrop(listBox3.SelectedItem.ToString(), DragDropEffects.Move);
        }
        private void txt1_3_DragEnter(object sender, DragEventArgs e)
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
        private void tb_DragDrop_3(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (listBox3.SelectedItem != null)
            {
                tb.Text = listBox3.SelectedItem.ToString();
                //Activam Butonul Verifica3? sau ba?
                foreach (Control Ctrl in panel1.Controls)
                {
                    bool ok = true;
                    if (Ctrl is TextBox && Ctrl.Name[Ctrl.Name.Length - 1] == '3')
                    {
                        TextBox t = (TextBox)Ctrl;
                        if (t.Text == null)
                            ok = false;
                    }
                    if (ok)
                        Verifica3.Enabled = true;
                }
            }
        }
        int Nr_incercari3 = 0;
        private void Verifica3_Click(object sender, EventArgs e)
        {
            if (txt1_3.Text == "C.U." && txt2_3.Text == "C.C." && txt3_3.Text == "I.U.")
            {
                MessageBox.Show("Raspuns corect! Felicitari!");
                Verifica3.Enabled = false;
                Verifica3.Text = "Corect";
                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl.Name[ctrl.Name.Length - 1] == (pagina_curenta + 1).ToString()[0] && ctrl is TextBox)
                    {
                        ctrl.Enabled = false;
                    }
                }
            }
            else
            {
                Nr_incercari3++;
                if (Nr_incercari3 == 3)
                {
                    MessageBox.Show("Raspuns gresit! Raspunsurile corecte vor fi afisate!");
                    foreach (Control ctrl in panel1.Controls)
                    {
                        if (ctrl.Name[ctrl.Name.Length - 1] == (pagina_curenta + 1).ToString()[0] && ctrl is TextBox)
                        {
                            ctrl.Enabled = false;
                        }
                    }
                    txt1_3.Text = "C.U.";
                    txt2_3.Text = "C.C.";
                    txt3_3.Text = "I.U.";
                    Verifica3.Enabled = false;
                    Verifica3.Text = "Gresit";
                }
                else
                {
                    MessageBox.Show("Raspuns gresit!"+'\n'+"Indiciu: Foloseste-te de figura 1.8. si aminteste-ti ca ipotenuza este latura opusa unghiului de 90 de grade.");
                }
            }
        }

        //Pagina 4
        private void lb1_4_Click(object sender, EventArgs e)
        {
            Proprietati_Bisectoare f = new Proprietati_Bisectoare();
            f.ShowDialog();
        }

        //Pagina 6
        private void lb3_6_Click(object sender, EventArgs e)
        {
            Proprietati_Bisectoare f = new Proprietati_Bisectoare();
            f.ShowDialog();
        }

        private void lb2_6_Click(object sender, EventArgs e)
        {
            Propietati_Mediana f = new Propietati_Mediana();
            f.ShowDialog();
        }

        private void lb1_6_Click(object sender, EventArgs e)
        {
            Propietati_Inaltime f = new Propietati_Inaltime();
            f.ShowDialog();
        }
    }
}
