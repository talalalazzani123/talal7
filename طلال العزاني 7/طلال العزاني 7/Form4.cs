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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public string getname()
        {
            return txtform4.Text;
        }
        public void Updatename(string name)
        {
            txtform4.Text = name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f1=new Form3();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f=new Form3("التعامل مع الواجهات المتعددة");
            f.ShowDialog();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.setvalue(txtform4.Text);
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 f=new Form3();
            //f.txtform3.Text = txtform4.Text;
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            Form3.staticvarible = txtform4.Text;
            f.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Form3(txtform4.Text).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form=new Form3(listBox1);

            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f= new Form3(this);
            f.Show();
        }
        Form3 formons=new Form3();
        private void button6_Click(object sender, EventArgs e)
        {
            formons.Show();

        }
        Form3 formalobject;
        private void button8_Click(object sender, EventArgs e)
        {
            if(formalobject==null||formalobject.IsDisposed)
            {
                formalobject=new Form3();
                //formalobject.txtform3.Text=txtform4.Text;
                formalobject.Show();
            }
            else
            {
                //formalobject.setvalue(txtform4.Text);
                formalobject.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
