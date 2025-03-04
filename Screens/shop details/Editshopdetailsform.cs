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

namespace basicPointOfSalesSoftware.Screens.shop_details
{
    public partial class Editshopdetailsform : MetroFramework.Forms.MetroForm
    {
        public Editshopdetailsform()
        {
            InitializeComponent();
        }

        private void Editshopdetailsform_Load(object sender, EventArgs e)
        {

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update shop details ?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                saveshopdetails();
                shopnametextbox.Clear();
                shopaddresstextbox.Clear();
                vatregnumtextbox.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                shopnametextbox.Clear();
                shopaddresstextbox.Clear();
                vatregnumtextbox.Clear();

            }

        }

        private void saveshopdetails()
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_ShopDetails_editdetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Shopname", shopnametextbox.Text);
                    cmd.Parameters.AddWithValue("@Shopaddress", shopaddresstextbox.Text);

                    cmd.Parameters.AddWithValue("@Vatnumber", vatregnumtextbox.Text);


                    con.Open();
                    int id = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show("Details are Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }
    }
}
