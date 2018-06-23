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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete  from employee_phone where employee_id = @empid";
            cmd.Parameters.AddWithValue("@empid", delete_id.Text);
   
            cmd.ExecuteNonQuery();
           
            SqlCommand Cmd = con.CreateCommand();
            cmd.CommandText = "delete  from employee where employee_ID = @emp_id";
            cmd.Parameters.AddWithValue("@emp_id", delete_id.Text);

       
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted");
            
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
