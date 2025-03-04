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

namespace basicPointOfSalesSoftware.Screens.ProductsF
{
    public partial class ProductsRecordForm : MetroFramework.Forms.MetroForm
    {
        public ProductsRecordForm()
        {
            InitializeComponent();
        }

        private void ProductsRecordForm_Load(object sender, EventArgs e)
        {
            LoadAllProductsIntoDataGridView();
            ProductRecordGrid.Columns[0].Visible = false;

        }

        private void LoadAllProductsIntoDataGridView()
        {
            if(ProductRecordGrid.Columns.Contains("Delete"))
            {
                ProductRecordGrid.Columns.Remove("Delete"); 
            }

            ProductRecordGrid.DataSource = GetData();

          
                
        }

        private DataTable GetData()
        {
            DataTable dtrecord = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_Products_LoadAllProductsForDataGridView", con))
                {
                   
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                    dtrecord.Load(sdr);

                }

            }
            return dtrecord;
        }

        private void SearchProductTextBox_Click(object sender, EventArgs e)
        {
           
        }

        private DataTable GetProductByBarcode()
        {

            DataTable dtrecord = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_Products_LoadAllProductsByNameOrBarcode", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Barcode", (SearchbyBarcodeTextBox.Text.Trim()));

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);

                   
                    
                    
                       
                    
                   
                    
                    
                    
                        
                    


                   

                }

            }
            return dtrecord;
        }

        private void ProductRecordGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { int i = ProductRecordGrid.CurrentCell.RowIndex;
            BarcodeTextBox.Text = ProductRecordGrid.Rows[i].Cells[1].Value.ToString();
            ProductNameTextBox.Text = ProductRecordGrid.Rows[i].Cells[2].Value.ToString();
            VatTextBox.Text = ProductRecordGrid.Rows[i].Cells[3].Value.ToString();
            SalesPriceTextBox.Text = ProductRecordGrid.Rows[i].Cells[4].Value.ToString();



        }

        private void SearchbyBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchbyBarcodeTextBox.Text.Trim() == string.Empty)
            {
                LoadAllProductsIntoDataGridView();
            }
            else
            {
                try
                {
                    ProductRecordGrid.DataSource = GetProductByBarcode();
                }
                catch (System.Data.SqlClient.SqlException searcherror)
                {


                    SearchbyBarcodeTextBox.Clear();
                    MessageBox.Show("Barcode must be in numbers ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void CloseButton_pr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product ?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                deleteproduct();
            }
            else if (dialogResult == DialogResult.No)
            {
                SearchbyBarcodeTextBox.Clear();
                SearchbyBarcodeTextBox.Focus();
                ProductNameTextBox.Clear();
                SalesPriceTextBox.Clear();
                VatTextBox.Clear();
                BarcodeTextBox.Clear();
            }

        }

        private void deleteproduct()
        {

            {
                

                int _id = Convert.ToInt32(ProductRecordGrid.Rows[0].Cells[0].Value);

                if (_id > 0)
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_Products_DeleteProduct", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@ProductID", _id);

                            con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Product is Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadAllProductsIntoDataGridView();
                        }
                    }
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update product data ?", "Update confirmation", MessageBoxButtons.YesNo , MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                updatedata();
                ProductNameTextBox.Clear();
                SalesPriceTextBox.Clear();
                VatTextBox.Clear();
                BarcodeTextBox.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                ProductNameTextBox.Clear();
                SalesPriceTextBox.Clear();
                VatTextBox.Clear();
                BarcodeTextBox.Clear();

            }
            
           
        }

        private void updatedata()
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_Products_updateproductsinrecordform", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Barcode", BarcodeTextBox.Text);
                    cmd.Parameters.AddWithValue("@Name", ProductNameTextBox.Text);

                    cmd.Parameters.AddWithValue("@Vatper", VatTextBox.Text);
                    cmd.Parameters.AddWithValue("@SalesPrice", SalesPriceTextBox.Text);

                    con.Open();
                    int id = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show("Product is Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAllProductsIntoDataGridView();
                }
            }
        }

        private void calculatevatbtt_Click(object sender, EventArgs e)
        {
            deductvat();
        }

        private void deductvat()
        {

            decimal price = Convert.ToDecimal(SalesPriceTextBox.Text.Trim());

            decimal vat = Convert.ToDecimal(VatTextBox.Text.Trim());
            decimal vatper = 1 + (vat / 100);
            decimal net = price / vatper;
            net = decimal.Round(net, 2);

            SalesPriceTextBox.Text = net.ToString();

        }
    }
}
