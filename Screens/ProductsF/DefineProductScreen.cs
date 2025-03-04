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
using basicPointOfSalesSoftware.General;

namespace basicPointOfSalesSoftware.Screens.ProductsF
{
    public partial class DefineProductScreen : MetroFramework.Forms.MetroForm 
    {
        public DefineProductScreen()
        {
            InitializeComponent();
        }

        public bool IsUpdate { get; set; }

        
        private void DefineProductScreen_Load(object sender, EventArgs e)
        {
            if (!this.IsUpdate )
            {

            }
            LoadDataIntoComboBoxes();

        }

        private void LoadDataIntoComboBoxes()
        {
          


        }

        

        private DataTable  GetComboBoxData(int ListTypeID)
        {
            DataTable dtrecord = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_ListTypeData_LoadDataIntoComboBox" , con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ListTypeID ",  ListTypeID);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                    dtrecord.Load(sdr);

                }

            }
            return dtrecord;

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void BarcodeTextBox_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_dps_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewButton_dps_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
        }

        private void SaveButton_dps_Click(object sender, EventArgs e)
        { 
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
                {
                    using(SqlCommand cmd = new SqlCommand("usp_Products_InsertNewProduct" , con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                       
                        cmd.Parameters.AddWithValue("@Barcode", BarcodeTextBox.Text );
                        cmd.Parameters.AddWithValue("@Name", ProductNameTextBox.Text );
                        
                        cmd.Parameters.AddWithValue("@Vat", VatTextBox.Text );
                        cmd.Parameters.AddWithValue("@SalesPrice" , SalesPriceTextBox.Text );
                       
                        con.Open();
                        int id = Convert.ToInt32(cmd.ExecuteScalar());

                        MessageBox.Show( "Product is Saved Succesfully" , "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information );

                    }
                }
            }
        }

        private bool IsValid()
        {
            
            
                if (ProductNameTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Product Name is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ProductNameTextBox.Focus();
                    return false;
                }




            if (BarcodeTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Barcode is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BarcodeTextBox.Focus();
                    return false;
                }



            if (SalesPriceTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Sales Price is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SalesPriceTextBox.Focus();
                return false;
            }

            return true;
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void calculatevatbtt_Click(object sender, EventArgs e)
        {
            deductvatpercent();
        }

        private void deductvatpercent()
        {
            decimal price = Convert.ToDecimal(SalesPriceTextBox.Text.Trim()) ;

            decimal vat = Convert.ToDecimal(VatTextBox.Text.Trim());
            decimal vatper = 1 + (vat / 100);
            decimal  net = price/vatper ;
            net  = decimal.Round(net, 2);
             
            SalesPriceTextBox.Text = net.ToString() ;
        }

        private void VatTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
