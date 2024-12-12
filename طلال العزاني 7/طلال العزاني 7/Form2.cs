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
    public partial class Form2 : Form
    {
        Button b;
        Label l;
        TextBox t;
        ListBox lst;

        public Form2()
        {
            InitializeComponent();
            b=new Button();
            lst=new ListBox();
            l = new Label();
            t = new TextBox();
            b.Click += bclick;

            //visual();
            //disgin();
        }
        public Form2(string btntext,string lbltext)
        {
            InitializeComponent();
            b = new Button();
            lst = new ListBox();
            l = new Label();
            t = new TextBox();
            b.Text = btntext;
            l.Text = lbltext;
            b.Click += bclick;
            //visual();
            //disgin();
        }

        public void set(string btntext,string lbltext)
        {
            b.Text = btntext;
            l.Text = lbltext;

        }
        public void bclick(object sender, EventArgs e)
        {
            lst.Items.Add(t.Text);
        }
        public void disgin()
        {
            b.Top=30;b.Left = 25;lst.Top = 60;
            t.Top = 10;l.Left = 110;l.Top = 10;
            t.Left = lst.Left = 10;
        }
        public void visual()
        {
            this.Controls.Add(b);
            this.Controls.Add(l);
            this.Controls.Add(t);
            this.Controls.Add(lst);
        }
        public string getbtmtext()
        {
            return b.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 g=new Form2();
            g.disgin();
            g.visual();
            g.Show();
        }

        public void ddd()
        {
            Form2 f1 = new Form2("add", "insert item");
            MessageBox.Show(f1.getbtmtext());
            f1.disgin();
            f1.visual();
            f1.Show();
            Form2 f2 = new Form2();
            f2.set("إضافة ", "ادخل العنصر");
            f2.disgin();
            f2.visual();
            f2.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f1 = new Form2("add", "insert item");
            MessageBox.Show(f1.getbtmtext());
            f1.disgin();
            f1.visual();
            f1.Show();
            Form2 f2 = new Form2();
            f2.set("إضافة ", "ادخل العنصر");
            f2.disgin();
            f2.visual();
            f2.Show();
        }
    }
}
