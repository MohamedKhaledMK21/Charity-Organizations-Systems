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
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=project;Integrated Security=True");
            con.Open();
            string insertString = @"insert into department(dep_type , number) values('" + department_Name.Text + "', '" + drpartmet_ID.Text + "')";
            SqlCommand cmd = new SqlCommand(insertString, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Load(object sender, EventArgs e)
        {

        }
    }
}
