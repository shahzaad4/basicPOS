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
    public partial class Changepasswordform : MetroFramework.Forms.MetroForm
    {
        public Changepasswordform()
        {
            InitializeComponent();
        }

        private void Changepasswordform_Load(object sender, EventArgs e)
        {

        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to change password ?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    changepassword();
                }
                else if (dialogResult == DialogResult.No)
                {
                    UserNameTextBox.Clear();
                    PasswordTextBox.Clear();
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

        private void changepassword()
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_LoginUser_changepassword", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Username", UserNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);


                    con.Open();
                    int id = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show("Password is changed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
