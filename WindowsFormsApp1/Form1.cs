using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void button1_Click(object sender, EventArgs e)
            {
                Mokinys[] Mok = new Mokinys[100];
                int nm = 0;
                SkaitytiMokinys(Mok, ref nm);
                this.Hide();
                Antras form2 = new Antras(Mok, nm);
                form2.ShowDialog();
                this.Close();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                this.Hide();
                Apie form3 = new Apie();
                form3.ShowDialog();
                this.Show();
            }
    }
    
}

