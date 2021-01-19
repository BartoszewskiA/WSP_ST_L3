using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        string adresPliku = "pytania.txt";
        List<string> pytania = new List<string>();
        List<string> odpowiedzi = new List<string>();
        List<int> wyniki = new List<int>();
        int numerPytania = 0;
        int liczbaDobrychOdp = 0;
        int liczbaZlychOdp = 0;

        public Form1()
        {
            InitializeComponent();
            utworzListy();
            wypiszPytanie(numerPytania);
        }

        private void wypiszPytanie(int nr)
        {
            richTextBox1.Text = pytania[nr];
            richTextBox2.Text = odpowiedzi[nr];
            textBox1.Text = liczbaDobrychOdp.ToString();
            textBox2.Text = liczbaZlychOdp.ToString();
        }

        private void utworzListy()
        {    
            try
            {
                FileStream fs = new FileStream(adresPliku, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string odp="";
                while (!sr.EndOfStream)
                {
                    pytania.Add(sr.ReadLine());
                    //odpowiedzi.Add(sr.ReadLine() + sr.ReadLine() + sr.ReadLine());
                    odp += "a) ";
                    odp += sr.ReadLine();
                    odp += "\n";
                    odp += "b) ";
                    odp += sr.ReadLine();
                    odp += "\n";
                    odp += "c) ";
                    odp += sr.ReadLine();
                    odpowiedzi.Add(odp);
                    odp = "";
                    wyniki.Add(int.Parse(sr.ReadLine()));
                }
                sr.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Błąd otwarcia pliku \n" + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int odp = 0;
            if (radioButton1.Checked) odp = 1;
            else if (radioButton2.Checked) odp = 2;
            else if (radioButton3.Checked) odp = 3;
            if (odp == wyniki[numerPytania]) liczbaDobrychOdp++;
            else liczbaZlychOdp++;

            numerPytania++;
            wypiszPytanie(numerPytania);

        }
    }
}
