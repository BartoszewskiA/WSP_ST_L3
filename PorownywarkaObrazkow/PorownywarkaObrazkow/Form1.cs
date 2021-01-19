using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorownywarkaObrazkow
{
    public partial class Form1 : Form
    {

        Form2 oknoOK;
        Form3 oknoNO;
        public Form1()
        {
            InitializeComponent();
            oknoOK = new Form2();
            oknoNO = new Form3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog2.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == openFileDialog2.FileName) // czy zostały utworzone z tego samego pliku
            {
                oknoOK.ShowDialog();
            }
            else
            {
                oknoNO.ShowDialog();
            }
        }
    }
}

//  Pliki JPEG (*.jpg)|*.jpg|Pliki BMP (*.bmp)|*.bmp|Wszystkie pliki (*.*)|*.*
