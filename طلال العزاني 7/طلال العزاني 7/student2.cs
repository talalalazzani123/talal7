using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace الواجب_رقم_7_بسام_سمير
{
    internal class student2 : person
    {
        private int id;
        public string name;
        static string gender;
        public static string address;

        public student2()
        {
            id = 1;
            name = "";
            gender = "";
            address = "";
        }
        public student2(int id,string name,string g)
        {
            this.id = id;
            this.name = name;
            gender = g;
            MessageBox.Show(id.ToString() + "  " + name + "  " + gender);

        }
        private void setid(int id)
        {
            this.id=id;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public int getid()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }
        public string getgender()
        {
            return gender;
        }
        private static string getaddress()
        {
            return address;
        }

    }
}
