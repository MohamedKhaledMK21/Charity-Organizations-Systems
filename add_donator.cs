using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_PROJECT
{
    public partial class add_donator : Form
    {
        public add_donator()
        {
            InitializeComponent();
        }

        private void add_donator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.projectDataSet.department);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=project;Integrated Security=True");
            con.Open();
            string insert = @"insert into Donator(first_name,middle_name,last_name,email,phone,addres) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            string insert_type = @"insert into donation (Donation_time) values ('" + textBox7.Text+ "')";
            SqlCommand CMD = new SqlCommand(insert_type, con);
            CMD.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Donate added");


        }
    }
}
