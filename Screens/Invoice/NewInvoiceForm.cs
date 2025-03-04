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
using System.Drawing.Printing;

namespace basicPointOfSalesSoftware.Screens.ProductsF
{
    public partial class NewInvoiceForm : MetroFramework.Forms.MetroForm
    {

        DataTable invoice;

        public NewInvoiceForm()
        {
            InitializeComponent();
        }



        private void NewInvoiceForm_Load(object sender, EventArgs e)
        {
            showtime();
            generateinvoiceNo();
            loadalldataintotextbox();




            invoice = new DataTable();
            InvoiceDataGridView.DataSource = invoice;
            invoice.Columns.Add("Description", typeof(string));

            invoice.Columns.Add("Price", typeof(string));
            invoice.Columns.Add("Quantity", typeof(string));
            invoice.Columns.Add("Total", typeof(string));
            InvoiceDataGridView.Columns[0].Width = 300;








        }

        private void loadalldataintotextbox()
        {
            ProductRecordGrid.DataSource = Getdetails();
            shopnametextbox.Text = ProductRecordGrid.Rows[0].Cells[0].Value.ToString();
            shopaddresstextbox.Text = ProductRecordGrid.Rows[0].Cells[1].Value.ToString();
            vatregnumtextbox.Text = ProductRecordGrid.Rows[0].Cells[2].Value.ToString();

        }

        private object Getdetails()
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

        private void showtime()
        {
            DateTime dateTimeinv = DateTime.Now;
            timetxt.Text = dateTimeinv.ToString("MM/dd/yyyy hh:mm");
         
             
        }

        private void generateinvoiceNo()
        {
            Random rnd = new Random();
            int invoice1 = rnd.Next(10000, 90000);
            int invoice2 = rnd.Next(10000, 90000);
            invoice1textbox.Text = Convert.ToString(invoice1);
            invoice2textbox.Text = Convert.ToString(invoice2);


        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (System.FormatException e1)
            {
                MessageBox.Show("data is not entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void Calculate()
        {
            if (QuantityTextBox.Text.Trim() == String.Empty)
            {
                QuantityTextBox.Text = Convert.ToString(1);
            }
            decimal Price = Convert.ToDecimal(PriceTextbox.Text.Trim());
            decimal Quantity = Convert.ToDecimal(QuantityTextBox.Text.Trim());
            decimal Total = Price * Quantity;
            Total = decimal.Round(Total, 2);
            TotalTextBox.Text = Convert.ToString(Total);
        }

        private void AddToInvoiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate();

                invoice.Rows.Add(NameTextBox.Text.Trim(), PriceTextbox.Text.Trim(), QuantityTextBox.Text.Trim(), TotalTextBox.Text.Trim());

                InvoiceBarcodeTextbox.Clear();
                NameTextBox.Clear();
                PriceTextbox.Clear();
                QuantityTextBox.Clear();
                TotalTextBox.Clear();

                Grandtotal();
            }
            catch (System.FormatException e1)
            {
                MessageBox.Show("data is not entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }





        private void InvoiceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DeleteBUTTON_Click(object sender, EventArgs e)
        {

            try
            {
                deleteproductfrominvoice();
            }
            catch (System.NullReferenceException e1)
            {
                MessageBox.Show("Nothing is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
           



        }

        private void deleteproductfrominvoice()
        {
            
                int sd = InvoiceDataGridView.CurrentCell.RowIndex;
                invoice.Rows[sd].Delete();
          
            
        }

        private void Grandtotal()
        {
            decimal grandttl = 0;
            for (int i = 0; i < InvoiceDataGridView.Rows.Count; i++)
            {
                grandttl += Convert.ToDecimal(InvoiceDataGridView.Rows[i].Cells[3].Value);

                GrandTotalTextBox.Text = Convert.ToString(grandttl);
            }



        }





        private void GrandTotalTextBox_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceBarcodeTextbox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                invoiceproductsselectgrid.DataSource = GetProductByBarcode();
            }
            catch (System.Data.SqlClient.SqlException searcherror)
            {


                InvoiceBarcodeTextbox.Clear();
                MessageBox.Show("Barcode must be in numbers ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void loadtotextboxes()
        {
            int i = invoiceproductsselectgrid.RowCount;



            NameTextBox.Text = invoiceproductsselectgrid.Rows[0].Cells[2].Value.ToString();
            VatpercentTextBox.Text = invoiceproductsselectgrid.Rows[0].Cells[3].Value.ToString();
            PriceTextbox.Text = invoiceproductsselectgrid.Rows[0].Cells[4].Value.ToString();










        }

        private DataTable GetProductByBarcode()
        {
            DataTable dtrecord = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_Products_LoadAllProductsByNameOrBarcode", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Barcode", (InvoiceBarcodeTextbox.Text.Trim()));

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);



















                }
                return dtrecord;

            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InvoiceBarcodeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loadtotextboxes();
            }
        }

        private void GrandTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal grndtotal = Convert.ToDecimal(GrandTotalTextBox.Text.Trim());
            decimal Vat = Convert.ToDecimal(VatpercentTextBox.Text.Trim());
            decimal vatper = 1 + (Vat / 100);
            decimal net = grndtotal * (vatper);
            decimal vatamount = net - grndtotal;

            net = decimal.Round(net, 2);
            vatamount = decimal.Round(vatamount, 2);

            VatAmountTextBox.Text = vatamount.ToString();
            NetTextBox.Text = net.ToString();

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void invoice1textbox_Click(object sender, EventArgs e)
        {

        }



        private void saveandprintbutton_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                
                SaveData();

                print();


            }


        }

        private void print()
        {
            int d1 = InvoiceDataGridView.Rows.Count;
            if (d1 > 0 & d1<=5)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                printDocument1.Print();
            }

            if (d1 > 5 & d1 <= 10)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 700);
                printDocument1.Print();
            }

            if (d1 > 10 & d1 <= 15)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 800);
                printDocument1.Print();
            }



            if (d1 > 15 & d1 <= 20)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 900);
                printDocument1.Print();
            }




            if (d1 > 20 & d1 <= 25)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1000);
                printDocument1.Print();
            }





            if (d1 > 25 & d1 <= 30)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1100);
                printDocument1.Print();
            }





            if (d1 > 30 & d1 <= 35)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1200);
                printDocument1.Print();
            }
        }

        private bool isFilled()
        {
            if (invoice1textbox.Text.Trim() == string.Empty || invoice2textbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Invoice Number is required", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }else if (timetxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Date and time  is required", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (GrandTotalTextBox.Text.Trim() == string.Empty )
            {
                MessageBox.Show("GrandTotal is required", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (VatpercentTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vat Percentage is required", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (VatAmountTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vat Amount is required", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (NetTextBox.Text.Trim()== string.Empty)
            {
                MessageBox.Show("Net amount is required", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true; ;
            }
        }

        private void SaveData()
        {
            long invoicenum = Convert.ToInt64($"" + invoice1textbox.Text + "" + invoice2textbox.Text + "");

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionStrin()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_InvoiceDetails_Saveinvoicedata", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@InvoiceNum", invoicenum);
                    cmd.Parameters.AddWithValue("@InvoiceDate", timetxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Grandtotal", Convert.ToDecimal(GrandTotalTextBox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Vat", Convert.ToDecimal(VatpercentTextBox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@VatAmount", Convert.ToDecimal(VatpercentTextBox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Net", Convert.ToDecimal(NetTextBox.Text.Trim()));


                    con.Open();
                    int id = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show("details are Saved Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
           

        }
        

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics mygraphics = e.Graphics;
            Font myfont = new Font("Arial" , 12, FontStyle.Regular);
            string hell = "____________________________________________________________";
            int myX = 0;
            int myY = 0;
            int myNewLine = 0;


            

            myNewLine = myNewLine + 60;
            StringFormat formt0 = new StringFormat();
            StringFormat formt3 = new StringFormat();
            SolidBrush myColour = new SolidBrush(Color.Black);
            formt3 = new StringFormat(StringFormatFlags.DirectionVertical);
            mygraphics.DrawString(shopnametextbox.Text.ToUpper(), new Font("Arial ", 12, FontStyle.Bold), myColour, 50, 10);
            myNewLine = myNewLine + 10;
            mygraphics.DrawString(shopaddresstextbox.Text, new Font("Arial ", 12, FontStyle.Regular), myColour, 50, myY + myNewLine);
            myNewLine = myNewLine + 15;
            mygraphics.DrawString("Vat Reg No:  " + vatregnumtextbox.Text.ToString() + "", new Font("Arial ", 12, FontStyle.Regular), myColour, 5, myY + myNewLine);
            myNewLine = myNewLine + 5;
            mygraphics.DrawString(hell, new Font("Arial ", 23, FontStyle.Bold), myColour, 2, myY + myNewLine);
            myNewLine = myNewLine + 40;
            mygraphics.DrawString("Invoice Number :  " +  invoice1textbox.Text.ToString() + invoice2textbox.Text.ToString()      + "", new Font("Arial ", 8, FontStyle.Regular), myColour, 5, myY + myNewLine);
            myNewLine = myNewLine + 15;
            mygraphics.DrawString("Date & Time : " + timetxt.Text.ToString() +  "", new Font("Arial ", 8, FontStyle.Regular), myColour, 5, myY + myNewLine);
            myNewLine = myNewLine + 30;
            mygraphics.DrawString(hell, new Font("Arial ", 23, FontStyle.Regular), myColour, 2, myY + myNewLine);
            myNewLine = myNewLine + 35;

            mygraphics.DrawString("DESCRIPTION", new Font("Arial ", 5, FontStyle.Regular), myColour, 5, myY + myNewLine);
            mygraphics.DrawString("QTY", new Font("Arial ", 5, FontStyle.Regular), myColour, myX + 100, myY + myNewLine);
            mygraphics.DrawString("PRiCE", new Font("Arial ", 5, FontStyle.Regular), myColour, myX+ 150, myY + myNewLine);
            
            mygraphics.DrawString("TOTAL", new Font("Arial ", 5, FontStyle.Regular), myColour, myX+230, myY + myNewLine);
            myNewLine = myNewLine ;
            mygraphics.DrawString(hell, new Font("Arial ", 23, FontStyle.Regular), myColour, 2, myY + myNewLine);
            myNewLine = myNewLine + 20;

            for (int i = 0; i < InvoiceDataGridView.Rows.Count; i++)
            {
                string description =  InvoiceDataGridView.Rows[i].Cells["Description"].Value.ToString();
                string quantity = InvoiceDataGridView.Rows[i].Cells["Quantity"].Value.ToString();
                string price = InvoiceDataGridView.Rows[i].Cells["Price"].Value.ToString();
                string total = InvoiceDataGridView.Rows[i].Cells["Total"].Value.ToString();
                myNewLine = myNewLine + 15;
                mygraphics.DrawString(description, new Font("Arial ", 5, FontStyle.Regular), myColour, 5, myY + myNewLine);
                mygraphics.DrawString(quantity, new Font("Arial ", 5, FontStyle.Regular), myColour, 100, myY + myNewLine);
                mygraphics.DrawString(price , new Font("Arial ", 5, FontStyle.Regular), myColour, 150, myY + myNewLine);
                mygraphics.DrawString(total, new Font("Arial ", 5, FontStyle.Regular), myColour, 230, myY + myNewLine);
                myNewLine = myNewLine + 5;




            }
            myNewLine = myNewLine + 20;
            mygraphics.DrawString(hell, new Font("Arial ", 23, FontStyle.Regular), myColour, 5, myY + myNewLine);
            myNewLine = myNewLine + 50;

            mygraphics.DrawString("Grand Total:", new Font("Arial ", 8, FontStyle.Regular), myColour, 100, myY + myNewLine);
            mygraphics.DrawString(GrandTotalTextBox.Text.ToString(), new Font("Arial ", 8, FontStyle.Regular), myColour, 230, myY + myNewLine);
            myNewLine = myNewLine + 30;

            mygraphics.DrawString("Vat:", new Font("Arial ", 8, FontStyle.Regular), myColour, 100, myY + myNewLine);
            mygraphics.DrawString(VatpercentTextBox.Text.ToString(), new Font("Arial ", 8, FontStyle.Regular), myColour, 230, myY + myNewLine);
            myNewLine = myNewLine + 30;

            mygraphics.DrawString("Vat Amount:", new Font("Arial ", 8, FontStyle.Regular), myColour, 100, myY + myNewLine);
            mygraphics.DrawString(VatAmountTextBox.Text.ToString(), new Font("Arial ", 8, FontStyle.Regular), myColour, 230, myY + myNewLine);
            myNewLine = myNewLine + 30;

            mygraphics.DrawString("Net Amount:", new Font("Arial ", 8, FontStyle.Regular), myColour, 100, myY + myNewLine);
            mygraphics.DrawString(NetTextBox.Text.ToString(), new Font("Arial ", 8, FontStyle.Regular), myColour, 230, myY + myNewLine);


            myNewLine = myNewLine + 10;
            mygraphics.DrawString(hell, new Font("Arial ", 23, FontStyle.Regular), myColour, myX, myY + myNewLine);
            myNewLine = myNewLine + 50;
            mygraphics.DrawString("*THANKS FOR SHOPPING*", new Font("Arial ", 8, FontStyle.Regular), myColour, 40, myY + myNewLine);
            myNewLine = myNewLine + 10;
            mygraphics.DrawString(hell, new Font("Arial ", 23, FontStyle.Regular), myColour, myX, myY + myNewLine);


















        }


        private void printpreviewbutton_Click(object sender, EventArgs e)
        {


            printPreviewDialog1.Document = printDocument1;
            int d1 = InvoiceDataGridView.Rows.Count;
            if (d1 > 0 & d1 <= 5)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                printPreviewDialog1.Show();
            }

            if (d1 > 5 & d1 <= 10)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 700);
                printPreviewDialog1.Show();
            }

            if (d1 > 10 & d1 <= 15)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 800);
                printPreviewDialog1.Show();
            }



            if (d1 > 15 & d1 <= 20)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 900);
                printPreviewDialog1.Show();
            }




            if (d1 > 20 & d1 <= 25)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1000);
                printPreviewDialog1.Show();
            }





            if (d1 > 25 & d1 <= 30)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1100);
                printPreviewDialog1.Show();
            }





            if (d1 > 30 & d1 <= 35)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1200);
                printPreviewDialog1.Show();
            }

            printPreviewDialog1.Show();
            
        }

        private void VatAmountTextBox_Click(object sender, EventArgs e)
        {

        }

        private void NewInvoiceForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F12)
            {
                if (isFilled())
                {

                    SaveData();

                    print();


                }
            }

        }
    }   }
