using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerOpuznionyStartProgramu
{
    public partial class Form1 : Form
    {
        int l = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l--;
            label2.Text = "Program uruchimi się za: " + l.ToString() + " s.";
            if (l<=0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                label1.Enabled = true;
                timer1.Stop();
                label2.Visible = false;
            }


            
        }
    }
}
