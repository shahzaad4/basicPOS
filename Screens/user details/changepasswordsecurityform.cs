using basicPointOfSalesSoftware.General;
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

namespace basicPointOfSalesSoftware.Screens
{
    public partial class changepasswordsecurityform : MetroFramework.Forms.MetroForm
    {
        public changepasswordsecurityform()
        {
            InitializeComponent();
        }

        private void changepasswordsecurityform_Load(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {

                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Login_VerifyLoginDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text.Trim());
           
                       cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text.Trim());
              con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            this.Hide();
                            Changepasswordform df = new Changepasswordform();
                            df.Show();
                        }
                        else
                        {
                            MessageBox.Show("UserName or Password is incorrect", " Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }



            }
        }

        private bool isValid()
        {
            if (UserNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User Name is required!", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Focus();
                return false;
            }

            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" Password is required!", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Focus();
                return false;
            }

            return true;

        }
    }
}
