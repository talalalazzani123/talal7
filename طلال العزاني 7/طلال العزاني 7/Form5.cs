using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace الواجب_رقم_7_بسام_سمير
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        formadd add;//زر جمع


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(add == null || add.IsDisposed)
            {
                add=new formadd();
                add.Show();
            }
            else
            {
                add.Show();
            }

        }
        formsub sub;
        private void button2_Click(object sender, EventArgs e)
        {
            if (sub == null || sub.IsDisposed)
            {
                sub = new formsub();
                sub.Show();
            }
            else
            {
                sub.Show();
            }
        }
        formmul mul;

        private void button3_Click(object sender, EventArgs e)
        {
            if (mul == null || mul.IsDisposed)
            {
                mul = new formmul();
                mul.Show();
            }
            else
            {
                mul.Show();
            }
        }
        formdiv div;

        private void button4_Click(object sender, EventArgs e)
        {
            if (div == null || div.IsDisposed)
            {
                div = new formdiv();
                div.Show();
            }
            else
            {
                div.Show();
            }
        }

        private void جمعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add == null || add.IsDisposed)
            {
                add = new formadd();
                add.Show();
            }
            else
            {
                add.Show();
            }
        }

        private void طرحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sub == null || sub.IsDisposed)
            {
                sub = new formsub();
                sub.Show();
            }
            else
            {
                sub.Show();
            }
        }

        private void ضربToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mul == null || mul.IsDisposed)
            {
                mul = new formmul();
                mul.Show();
            }
            else
            {
                mul.Show();
            }
        }

        private void قسمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (div == null || div.IsDisposed)
            {
                div = new formdiv();
                div.Show();
            }
            else
            {
                div.Show();
            }
        }
    }
}
