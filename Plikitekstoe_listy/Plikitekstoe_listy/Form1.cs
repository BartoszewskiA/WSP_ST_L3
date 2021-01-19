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

namespace Plikitekstoe_listy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                List<string> tekst = new List<string>();
                try
                {
                    StreamReader sr = new StreamReader(fs);
                    while(!sr.EndOfStream)
                    {
                        tekst.Add(sr.ReadLine());
                    }
                    sr.Close();
                    richTextBox1.Lines = tekst.ToArray();

                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.ToString());
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> temp = new List<string>(richTextBox1.Lines);
            //  List<string> wynik = new List<string>();
            //  for (int i= temp.Count()-1; i>=0; i--)
            //  {
            //      wynik.Add(temp[i]);
            //  }

            //  richTextBox2.Lines = wynik.ToArray();
            temp.Reverse();
            richTextBox2.Lines = temp.ToArray();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                List<string> temp = new List<string>(richTextBox2.Lines);
                try 
                {
                    StreamWriter sw = new StreamWriter(fs);
                    for (int i=0;i<temp.Count(); i++)
                    {
                        sw.WriteLine(temp[i]);
                    }
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
