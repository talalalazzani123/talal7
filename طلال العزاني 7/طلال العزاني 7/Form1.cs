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
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            student s = new student(1, "ali", "male");
            int id = s.getId();
            MessageBox.Show(id.ToString());

            s.setname("yaser");
            string name = s.getname();
            MessageBox.Show(name);
            //==============================

            //messageBox.Show(student().getid().tostring());

            MessageBox.Show(new student(1, "fatma", "female").getId().ToString());
            student s2 = new student(1000, "dog", "animale");
            MessageBox.Show(s.getId().ToString());
            MessageBox.Show(s2.getId().ToString());

            student.setaddress("ibb");
            MessageBox.Show(student.address);
            student.setaddress("taiz");
            MessageBox.Show(student.address);

            student s3 = new student(120, "ali", "male");
            s3.setfristlastname("ali", "mohammed");
            MessageBox.Show(s3.getlastfristname());

            //--------------------------------

            s3.myperson.lastname = "bbb";
            s3.myperson.setfristname("ali");
            MessageBox.Show(s3.myperson.getfristname());


            person p = new person();
            p.lastname = "kkk";

            p.setfristname("ali");
            MessageBox.Show(p.getfristname() + " " + p.lastname);

            /////////////////////////////////////////
            //student s4 = new student();
            

        }

    }
}
