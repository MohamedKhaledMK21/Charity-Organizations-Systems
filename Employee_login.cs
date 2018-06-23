using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS_PROJECT
{
    public partial class Employee_login : Form
    {
        public String name = "";
        public Employee_login()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=project;Integrated Security=True");
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select count(*) from employee where employee_ID= '" + textBox1.Text + "'and pass_word= '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form4 x= new Form4();
                x.Show();
            }
            else { MessageBox.Show("please check user name or password"); }
            name = textBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            START x = new START();
            x.Show();
        }
    }
}
