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
    public partial class Form3 : Form
    {
        public static string staticvarible = "";
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string name)
        {
            InitializeComponent();
            this.Text = name;
        }
        Form4 objf11;

        public Form3(Form4 objectform11)
        {
            InitializeComponent();
            txtform3.Text = objectform11.getname();
            //txtform3.Text = objectform11.txtform4.Text;
            objf11 = objectform11;
        }

        public Form3(ListBox mylist)
        {
            InitializeComponent();
            listBox1 = mylist;
        }

        public void setvalue(string name)
        {
            txtform3.Text = name;

        }
        public string getvalue() 
        {
            return txtform3.Text;
        
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtform3.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objf11.Updatename(getvalue());
        }
    }
}
