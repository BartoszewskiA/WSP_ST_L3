using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03p01
{
    public partial class Form1 : Form
    {

        //private string u1 = "Kowalski";
        // private int p1 = 111;

        string[] users = new string[] { "Kowalski", 
                                        "Nowak", 
                                        "Iksoński", 
                                        "Ktoś" };

        int[] piny = new int[] { 111, 222, 333, 444 };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            //int pin = int.Parse(textBox2.Text);
            int pin, temp;
            if (int.TryParse(textBox2.Text, out temp)) pin = temp;
            else pin = 0;

            // if (s == u1 && pin == p1) label3.Text = "YES";
            // else label3.Text = "NO";

            bool dostep = false;
            for (int i=0; i<users.Length; i++)
            {
                if (s == users[i] && pin == piny[i])
                {
                    dostep = true;
                    break;
                }
            }

            if (dostep)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "YES";
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "NO";
            }

        }
    }
}
