using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprawdzaniePoprawnosciDanych_OknaDialogowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool sprawdzNazwisko()
        {
            bool wynik = true;
            string s = textBox2.Text;
            
            if(s.Length==0)
            {
                MessageBox.Show("Pole Nazwisko jest obowiązkowe","Błąd", MessageBoxButtons.OK);
                wynik = false;
            } else if(s.IndexOf(' ')>=0)
            {
                if (MessageBox.Show("Pole Nazwisko powinno zawierać jeden wyraz", "Błąd", MessageBoxButtons.OKCancel)!=DialogResult.OK)
                    textBox2.Text="";
                wynik = false;
            }
            
            return wynik;
        }

        private bool sprawdzImie()
        {
            bool wynik = true;
            string s = textBox2.Text;

            if (s.Length == 0)
            {
                MessageBox.Show("Pole Nazwisko jest obowiązkowe", "Błąd", MessageBoxButtons.OK);
                wynik = false;
            }
            return wynik;
        }

        private bool sprawdzWiek()
        {
            bool wynik = true;
            int wiek;
            if (!int.TryParse(textBox3.Text, out wiek)) wiek = 0;
            if (wiek == 0)
            {
                MessageBox.Show("Pole Wiek jest obowiązkowe", "Błąd", MessageBoxButtons.OK);
                wynik = false;
            } else if(wiek<10 || wiek>110)
            {
                MessageBox.Show("wiek nie miesci się w zakresie", "Błąd", MessageBoxButtons.OK);
                wynik = false;
            }

            return wynik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            if(sprawdzNazwisko() && sprawdzNazwisko() && sprawdzWiek()) label4.Text="OK";
        }
    }
}
