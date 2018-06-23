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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("donate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@donator_id", textBox1.Text));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table_donator = new DataTable();
            table_donator.Columns.Add("first_name");
            table_donator.Columns.Add("middle_name");
            table_donator.Columns.Add("last_name");
            DataRow row;
            while (reader.Read())
            {
                row = table_donator.NewRow();
                row["first_name"] = reader["first_name"];
                row["middle_name"] = reader["middle_name"];
                row["last_name"] = reader["last_name"];
                table_donator.Rows.Add(row);

            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = table_donator;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
