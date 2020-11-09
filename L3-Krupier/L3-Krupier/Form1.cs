using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L3_Krupier
{
    public partial class Form1 : Form
    {
        Krupier krupier;
        public Form1()
        {
            InitializeComponent();
            krupier = new Krupier(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = krupier.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = krupier.wezKarte();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            krupier.potasuj();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            button4.Text = "Weź "+hScrollBar1.Value.ToString() +" kart";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> l = krupier.wezKarty(hScrollBar1.Value);
            string s = "";
            for (int i = 0; i < l.Count(); i++)
                s = s + l[i] + " ";
            textBox1.Text = s;
        }
    }

}
