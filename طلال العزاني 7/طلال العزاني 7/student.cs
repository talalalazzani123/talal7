using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace الواجب_رقم_7_بسام_سمير
{
    internal class student :Form
    {
        private int id;
        public string name;
        static string gender;
        public static string address;

        public person myperson;
        student()
        {
            id = 1;
            name = "";
            gender = "";
            address = "";

        }
        public student(int id, string name, string g)
        {
            this.id = id;
            this.name = name;
            gender = g;
            MessageBox.Show(id.ToString() + name + "  " + gender);
        }
        private void setid(int id)
        {
            this.id = id;
        }
        public string getname()
        {
            return name;
        }
        public int getId()
        {
            return id;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public string setgender(string gender)
        {
            return gender;
        }
        public static void setaddress(string add)
        {
            address = add;
        }
        private static string getaddress()
        {
            return address;
        }
        //==============================
        public void setfristlastname(string frist, string last)
        {
            myperson.setfristname(frist);
            myperson.lastname = last;
        }
        public string getlastfristname()
        {
            return myperson.getfristname()+" "+myperson.lastname;
        }
    }
}
