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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=project;Integrated Security=True");
            con.Open();
            string updatestring = @"update employee set first_name=@nvarcharname where employee_ID=@intid";
            SqlCommand cmd = new SqlCommand(updatestring, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter paramid = new SqlParameter("@intid", txt_id.Text);
            cmd.Parameters.Add(paramid);
            SqlParameter paramname = new SqlParameter("@nvarcharname", txt_name.Text);
            cmd.Parameters.Add(paramname);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated");
           
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }
    }
}
