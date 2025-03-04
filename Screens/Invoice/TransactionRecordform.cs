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
    public partial class TransactionRecordform : MetroFramework.Forms.MetroForm
    {
        public TransactionRecordform()
        {
            InitializeComponent();
        }

        private void TransactionRecordform_Load(object sender, EventArgs e)
        {
            LoadAllProductsIntoDataGridView();
            TransactionRecordGridView.Columns[0].Width = 200;
            TransactionRecordGridView.Columns[1].Width = 200;
            TransactionRecordGridView.Columns[2].Width = 150;
            TransactionRecordGridView.Columns[3].Width = 150;
            TransactionRecordGridView.Columns[4].Width = 150;
            TransactionRecordGridView.Columns[5].Width = 150;






        }

        private void LoadAllProductsIntoDataGridView()
        {
            TransactionRecordGridView.DataSource = GetData();
        }

        private DataTable GetData()
        {
            DataTable dtrecord = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_InvoiceDetails_LoadInvoiceDataintodatagridview", con))
                {

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                    dtrecord.Load(sdr);

                }

            }
            return dtrecord;
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Searchinvoice_Click(object sender, EventArgs e)
        {

        }

        private void Searchinvoice_TextChanged(object sender, EventArgs e)
        {
            if (Searchinvoice.Text.Trim() == string.Empty)
            {
                LoadAllProductsIntoDataGridView();
            }
            else
            {
                try
                {
                    TransactionRecordGridView.DataSource = gettransactiondetails();
                }
                catch (System.Data.SqlClient.SqlException searcherror)
                {


                    Searchinvoice.Clear();
                    MessageBox.Show("Invoice Number must be in numbers ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private object gettransactiondetails()
        {

            DataTable dtrecord = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_InvoiceDetails_searchInvoiceDataintodatagridview", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@InvoiceNumber",Searchinvoice.Text.Trim());

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
















                }

            }
            return dtrecord;
        }
    }
}
