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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Aceasta parte a formei 1 cuprinde toate metodele generale ale proiectului
        public bool Valideaza_Corespondenta_Trighiurilor(string s1, string s2, string solutie1, string solutie2,int StringLength)
        {
            if (s1.Length == s2.Length && s1.Length == StringLength)
            {
                int lghsol = solutie1.Length, lghs = s1.Length;
                int i = 0, j;
                while (i + lghs <= lghsol)
                {
                    int ok = 1;
                    for (j = i; j < i + lghs; j++)
                    {
                        if (s1[j - i] != solutie1[j] || s2[j - i] != solutie2[j])
                            ok = 0;
                    }
                    if (ok == 1)
                        return true;
                    else
                        i = j + 1;
                }
            }
            return false;
        }

        public bool Valideaza_Stringul(string s, string solutie, int StringLength)
        {
            int lghsol = solutie.Length, lghs = s.Length;
            int i = 0, j;
            if (lghs == StringLength)
            {
                while (i < lghsol)
                {

                    int ok = 1;
                    for (j = i; j < i + lghs; j++)
                    {
                        if (s[j - i] != solutie[j])
                            ok = 0;
                    }
                    if (ok == 1)
                        return true;
                    else
                        i = j + 1;
                }
            }
            return false;
        }

        private void Verifica_daca_Close_sau_Hide(string s, Form f)
        {
            if (s == "CLOSE")
                f.Close();
            else
                f.Hide();
        }

        public void Afisare_Forma(string Text_Forma, Form frn, string Close_or_Hide)
        {
            Form f = new Form();
            switch (Text_Forma)
            {
                case "MENIU": f = new Form1(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;

                case "LECTII": f = new Form2(); f.Show(); 
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;

                case "CONGRUENTA INTRODUCERE1": 
                    f = new Form3(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;

                case "CONGRUENTA INTRODUCERE2": 
                    f = new Form4(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;

                case "CONGRUENTA INTRODUCERE3":
                    f = new Form5();f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;
                case "CONGRUENTA CAZURI1":
                    f = new Form6(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;
                case "CONGRUENTA CAZURI2":
                    f = new Form7(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;
                case "CONGRUENTA CAZURI3":
                    f = new Form8(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;
                case "CONGRUENTA CAZURI4":
                    f = new Form9(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;
                case "CONGRUENTA CAZURI5":
                    f = new Form10(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;
                case "CONGRUENTA CAZURI6":
                    f = new Form11(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;
                case "CONGRUENTA DREPTUNGHICE":
                    f = new Form12(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break; 
                case "TESTE":
                    f = new Form16(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;
                case "TEST USOR":
                    f = new Test_Usor_Pagina_1(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;
                case "TEST MEDIU":
                    f = new Test_Mediu(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break;
                case "TEST GREU":
                    f = new Test_Greu(); f.Show();
                    Verifica_daca_Close_sau_Hide(Close_or_Hide, frn);
                    break; 

            }

        }
        //Aici se termina sectiunea cu metode generale
        //Navigare
        private void Lectii_Click(object sender, EventArgs e)
        {
             Afisare_Forma("LECTII", this, "HIDE");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Autor_Click(object sender, EventArgs e)
        {
            Form15 f = new Form15();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIncepe_teste_Click(object sender, EventArgs e)
        {
            Afisare_Forma("TESTE", this, "HIDE");
        }

      


    }
}
