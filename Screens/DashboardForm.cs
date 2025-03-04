using basicPointOfSalesSoftware.Screens.ProductsF;
using basicPointOfSalesSoftware.Screens.shop_details;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicPointOfSalesSoftware.Screens
{
    public partial class DashboardForm : MetroFramework.Forms.MetroForm 
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void ManageProductsButton_Click(object sender, EventArgs e)
        {
            ProductsRecordForm prd = new ProductsRecordForm();
            prd.Show();
        }

        private void ExitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DefineProductsButton_Click(object sender, EventArgs e)
        {
            DefineProductScreen dps = new DefineProductScreen();
            dps.Show();
        }

        private void Newinvoice_Click(object sender, EventArgs e)
        {
            NewInvoiceForm nif = new NewInvoiceForm();
            nif.Show();
        }


        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            changepasswordsecurityform csf = new changepasswordsecurityform();
            csf.Show();
        }

        private void TransactionsRecordButton_Click(object sender, EventArgs e)
        {

            TransactionRecordform trf = new TransactionRecordform();
            trf.Show();

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            ShopDetailsform sdf = new ShopDetailsform();
                sdf.Show();
        }
    }
}
