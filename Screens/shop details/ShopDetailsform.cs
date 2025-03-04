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
    public partial class ShopDetailsform : MetroFramework.Forms.MetroForm
    {
        public ShopDetailsform()
        {
            InitializeComponent();
        }

        private void ShopDetailsform_Load(object sender, EventArgs e)
        {
            loadalldataintotextbox();
        }

        private void loadalldataintotextbox()
        {
            ProductRecordGrid.DataSource = Getdetails();
            shopnametextbox.Text = ProductRecordGrid.Rows[0].Cells[0].Value.ToString();
            shopaddresstextbox.Text = ProductRecordGrid.Rows[0].Cells[1].Value.ToString();
            vatregnumtextbox.Text = ProductRecordGrid.Rows[0].Cells[2].Value.ToString();



        }


        private DataTable Getdetails()
        {
            DataTable dtrecord = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_ShopDetails_loadshopdetails", con))
                {
                    con.Open();
                    

                    SqlDataReader sdr = cmd.ExecuteReader();
                   
                    dtrecord.Load(sdr);
                    dtrecord.Load(sdr);

                }

            }
            return dtrecord;
        }


        private void Editshopdetailsbutton_Click(object sender, EventArgs e)
        {
            shopdetailssecurityform sdsf = new shopdetailssecurityform();
            sdsf.Show();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Closetextbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
