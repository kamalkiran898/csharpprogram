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

namespace Database_example
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NARASIMHARAO\Desktop\csharp\DB.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("Procedure", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@param", "Add");
                sqlcmd.Parameters.AddWithValue("@contactId",0);
                sqlcmd.Parameters.AddWithValue("@Name",txtName.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@MobileNumber",txtMobileNumber.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Address",txtAddress.Text.Trim());
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("saved successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR Message");
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
