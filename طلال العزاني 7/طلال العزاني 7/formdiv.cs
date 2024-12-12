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
    public partial class formdiv : Form
    {
        public formdiv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);

            if(number2 != 0)
            {
               
                int result = number1 + number2;

                textBox3.Text = result.ToString();

            }
            else
            {
                MessageBox.Show("ادخل رقم صحيح ");
            }

            
        }
    }
}
