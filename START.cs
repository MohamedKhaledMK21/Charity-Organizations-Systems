using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_PROJECT
{
    public partial class START : Form
    {
        public START()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            USRE_OPTION fr = new USRE_OPTION();
            fr.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_login fr3 = new Employee_login();
            fr3.Show();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
