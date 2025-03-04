
namespace basicPointOfSalesSoftware.Screens.ProductsF
{
    partial class NewInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewInvoiceForm));
            this.InvoiceDataGridView = new MetroFramework.Controls.MetroGrid();
            this.AddToInvoiceButton = new MetroFramework.Controls.MetroButton();
            this.InvoiceBarcodeTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PriceTextbox = new MetroFramework.Controls.MetroTextBox();
            this.QuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TotalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CalculateButton = new MetroFramework.Controls.MetroButton();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.DeleteBUTTON = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.VatpercentTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NetTextBox = new MetroFramework.Controls.MetroTextBox();
            this.VatAmountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.GrandTotalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.invoiceproductsselectgrid = new MetroFramework.Controls.MetroGrid();
            this.invoice1textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.invoice2textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.saveandprintbutton = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timetxt = new MetroFramework.Controls.MetroTextBox();
            this.Closebutton = new MetroFramework.Controls.MetroButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.vatregnumtextbox = new MetroFramework.Controls.MetroTextBox();
            this.shopaddresstextbox = new MetroFramework.Controls.MetroTextBox();
            this.shopnametextbox = new MetroFramework.Controls.MetroTextBox();
            this.ProductRecordGrid = new MetroFramework.Controls.MetroGrid();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printpreviewbutton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceproductsselectgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductRecordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceDataGridView
            // 
            this.InvoiceDataGridView.AllowUserToAddRows = false;
            this.InvoiceDataGridView.AllowUserToDeleteRows = false;
            this.InvoiceDataGridView.AllowUserToResizeRows = false;
            this.InvoiceDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.InvoiceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvoiceDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InvoiceDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvoiceDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.InvoiceDataGridView.EnableHeadersVisualStyles = false;
            this.InvoiceDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InvoiceDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InvoiceDataGridView.Location = new System.Drawing.Point(21, 190);
            this.InvoiceDataGridView.Name = "InvoiceDataGridView";
            this.InvoiceDataGridView.ReadOnly = true;
            this.InvoiceDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.InvoiceDataGridView.RowHeadersVisible = false;
            this.InvoiceDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InvoiceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoiceDataGridView.Size = new System.Drawing.Size(603, 299);
            this.InvoiceDataGridView.TabIndex = 0;
            this.InvoiceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceDataGridView_CellContentClick);
            // 
            // AddToInvoiceButton
            // 
            this.AddToInvoiceButton.Location = new System.Drawing.Point(52, 150);
            this.AddToInvoiceButton.Name = "AddToInvoiceButton";
            this.AddToInvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.AddToInvoiceButton.TabIndex = 1;
            this.AddToInvoiceButton.Text = "Add ";
            this.AddToInvoiceButton.UseSelectable = true;
            this.AddToInvoiceButton.Click += new System.EventHandler(this.AddToInvoiceButton_Click);
            // 
            // InvoiceBarcodeTextbox
            // 
            // 
            // 
            // 
            this.InvoiceBarcodeTextbox.CustomButton.Image = null;
            this.InvoiceBarcodeTextbox.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.InvoiceBarcodeTextbox.CustomButton.Name = "";
            this.InvoiceBarcodeTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InvoiceBarcodeTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InvoiceBarcodeTextbox.CustomButton.TabIndex = 1;
            this.InvoiceBarcodeTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InvoiceBarcodeTextbox.CustomButton.UseSelectable = true;
            this.InvoiceBarcodeTextbox.CustomButton.Visible = false;
            this.InvoiceBarcodeTextbox.Lines = new string[0];
            this.InvoiceBarcodeTextbox.Location = new System.Drawing.Point(112, 73);
            this.InvoiceBarcodeTextbox.MaxLength = 32767;
            this.InvoiceBarcodeTextbox.Name = "InvoiceBarcodeTextbox";
            this.InvoiceBarcodeTextbox.PasswordChar = '\0';
            this.InvoiceBarcodeTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InvoiceBarcodeTextbox.SelectedText = "";
            this.InvoiceBarcodeTextbox.SelectionLength = 0;
            this.InvoiceBarcodeTextbox.SelectionStart = 0;
            this.InvoiceBarcodeTextbox.ShortcutsEnabled = true;
            this.InvoiceBarcodeTextbox.Size = new System.Drawing.Size(324, 23);
            this.InvoiceBarcodeTextbox.TabIndex = 2;
            this.InvoiceBarcodeTextbox.UseSelectable = true;
            this.InvoiceBarcodeTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InvoiceBarcodeTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InvoiceBarcodeTextbox.TextChanged += new System.EventHandler(this.InvoiceBarcodeTextbox_TextChanged);
            this.InvoiceBarcodeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InvoiceBarcodeTextbox_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Barcode:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(464, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Price:";
            // 
            // PriceTextbox
            // 
            // 
            // 
            // 
            this.PriceTextbox.CustomButton.Image = null;
            this.PriceTextbox.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.PriceTextbox.CustomButton.Name = "";
            this.PriceTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PriceTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PriceTextbox.CustomButton.TabIndex = 1;
            this.PriceTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PriceTextbox.CustomButton.UseSelectable = true;
            this.PriceTextbox.CustomButton.Visible = false;
            this.PriceTextbox.Lines = new string[0];
            this.PriceTextbox.Location = new System.Drawing.Point(511, 112);
            this.PriceTextbox.MaxLength = 32767;
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.PasswordChar = '\0';
            this.PriceTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PriceTextbox.SelectedText = "";
            this.PriceTextbox.SelectionLength = 0;
            this.PriceTextbox.SelectionStart = 0;
            this.PriceTextbox.ShortcutsEnabled = true;
            this.PriceTextbox.Size = new System.Drawing.Size(87, 23);
            this.PriceTextbox.TabIndex = 5;
            this.PriceTextbox.UseSelectable = true;
            this.PriceTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriceTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QuantityTextBox
            // 
            // 
            // 
            // 
            this.QuantityTextBox.CustomButton.Image = null;
            this.QuantityTextBox.CustomButton.Location = new System.Drawing.Point(55, 1);
            this.QuantityTextBox.CustomButton.Name = "";
            this.QuantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityTextBox.CustomButton.TabIndex = 1;
            this.QuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityTextBox.CustomButton.UseSelectable = true;
            this.QuantityTextBox.CustomButton.Visible = false;
            this.QuantityTextBox.Lines = new string[0];
            this.QuantityTextBox.Location = new System.Drawing.Point(698, 112);
            this.QuantityTextBox.MaxLength = 32767;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.SelectionLength = 0;
            this.QuantityTextBox.SelectionStart = 0;
            this.QuantityTextBox.ShortcutsEnabled = true;
            this.QuantityTextBox.Size = new System.Drawing.Size(77, 23);
            this.QuantityTextBox.TabIndex = 6;
            this.QuantityTextBox.UseSelectable = true;
            this.QuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(631, 112);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Quantity:";
            // 
            // TotalTextBox
            // 
            // 
            // 
            // 
            this.TotalTextBox.CustomButton.Image = null;
            this.TotalTextBox.CustomButton.Location = new System.Drawing.Point(55, 1);
            this.TotalTextBox.CustomButton.Name = "";
            this.TotalTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TotalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalTextBox.CustomButton.TabIndex = 1;
            this.TotalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TotalTextBox.CustomButton.UseSelectable = true;
            this.TotalTextBox.CustomButton.Visible = false;
            this.TotalTextBox.Lines = new string[0];
            this.TotalTextBox.Location = new System.Drawing.Point(849, 112);
            this.TotalTextBox.MaxLength = 32767;
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.PasswordChar = '\0';
            this.TotalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalTextBox.SelectedText = "";
            this.TotalTextBox.SelectionLength = 0;
            this.TotalTextBox.SelectionStart = 0;
            this.TotalTextBox.ShortcutsEnabled = true;
            this.TotalTextBox.Size = new System.Drawing.Size(77, 23);
            this.TotalTextBox.TabIndex = 8;
            this.TotalTextBox.UseSelectable = true;
            this.TotalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(804, 113);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Total:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(952, 112);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(48, 23);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "...";
            this.CalculateButton.UseSelectable = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // NameTextBox
            // 
            // 
            // 
            // 
            this.NameTextBox.CustomButton.Image = null;
            this.NameTextBox.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.NameTextBox.CustomButton.Name = "";
            this.NameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTextBox.CustomButton.TabIndex = 1;
            this.NameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTextBox.CustomButton.UseSelectable = true;
            this.NameTextBox.CustomButton.Visible = false;
            this.NameTextBox.Lines = new string[0];
            this.NameTextBox.Location = new System.Drawing.Point(112, 112);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.ShortcutsEnabled = true;
            this.NameTextBox.Size = new System.Drawing.Size(324, 23);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.UseSelectable = true;
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(50, 109);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Name:";
            // 
            // DeleteBUTTON
            // 
            this.DeleteBUTTON.Location = new System.Drawing.Point(185, 150);
            this.DeleteBUTTON.Name = "DeleteBUTTON";
            this.DeleteBUTTON.Size = new System.Drawing.Size(75, 23);
            this.DeleteBUTTON.TabIndex = 13;
            this.DeleteBUTTON.Text = "Delete";
            this.DeleteBUTTON.UseSelectable = true;
            this.DeleteBUTTON.Click += new System.EventHandler(this.DeleteBUTTON_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(59, 538);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Vat Amount:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(301, 501);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Vat%";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(59, 498);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(79, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "GrandTotal: ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(305, 539);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(33, 19);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "Net:";
            // 
            // VatpercentTextBox
            // 
            // 
            // 
            // 
            this.VatpercentTextBox.CustomButton.Image = null;
            this.VatpercentTextBox.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.VatpercentTextBox.CustomButton.Name = "";
            this.VatpercentTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VatpercentTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VatpercentTextBox.CustomButton.TabIndex = 1;
            this.VatpercentTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VatpercentTextBox.CustomButton.UseSelectable = true;
            this.VatpercentTextBox.CustomButton.Visible = false;
            this.VatpercentTextBox.Lines = new string[0];
            this.VatpercentTextBox.Location = new System.Drawing.Point(344, 498);
            this.VatpercentTextBox.MaxLength = 32767;
            this.VatpercentTextBox.Name = "VatpercentTextBox";
            this.VatpercentTextBox.PasswordChar = '\0';
            this.VatpercentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VatpercentTextBox.SelectedText = "";
            this.VatpercentTextBox.SelectionLength = 0;
            this.VatpercentTextBox.SelectionStart = 0;
            this.VatpercentTextBox.ShortcutsEnabled = true;
            this.VatpercentTextBox.Size = new System.Drawing.Size(131, 23);
            this.VatpercentTextBox.TabIndex = 18;
            this.VatpercentTextBox.UseSelectable = true;
            this.VatpercentTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VatpercentTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NetTextBox
            // 
            // 
            // 
            // 
            this.NetTextBox.CustomButton.Image = null;
            this.NetTextBox.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.NetTextBox.CustomButton.Name = "";
            this.NetTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NetTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NetTextBox.CustomButton.TabIndex = 1;
            this.NetTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NetTextBox.CustomButton.UseSelectable = true;
            this.NetTextBox.CustomButton.Visible = false;
            this.NetTextBox.Lines = new string[0];
            this.NetTextBox.Location = new System.Drawing.Point(344, 538);
            this.NetTextBox.MaxLength = 32767;
            this.NetTextBox.Name = "NetTextBox";
            this.NetTextBox.PasswordChar = '\0';
            this.NetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NetTextBox.SelectedText = "";
            this.NetTextBox.SelectionLength = 0;
            this.NetTextBox.SelectionStart = 0;
            this.NetTextBox.ShortcutsEnabled = true;
            this.NetTextBox.Size = new System.Drawing.Size(131, 23);
            this.NetTextBox.TabIndex = 19;
            this.NetTextBox.UseSelectable = true;
            this.NetTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NetTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // VatAmountTextBox
            // 
            // 
            // 
            // 
            this.VatAmountTextBox.CustomButton.Image = null;
            this.VatAmountTextBox.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.VatAmountTextBox.CustomButton.Name = "";
            this.VatAmountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VatAmountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VatAmountTextBox.CustomButton.TabIndex = 1;
            this.VatAmountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VatAmountTextBox.CustomButton.UseSelectable = true;
            this.VatAmountTextBox.CustomButton.Visible = false;
            this.VatAmountTextBox.Lines = new string[0];
            this.VatAmountTextBox.Location = new System.Drawing.Point(144, 535);
            this.VatAmountTextBox.MaxLength = 32767;
            this.VatAmountTextBox.Name = "VatAmountTextBox";
            this.VatAmountTextBox.PasswordChar = '\0';
            this.VatAmountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VatAmountTextBox.SelectedText = "";
            this.VatAmountTextBox.SelectionLength = 0;
            this.VatAmountTextBox.SelectionStart = 0;
            this.VatAmountTextBox.ShortcutsEnabled = true;
            this.VatAmountTextBox.Size = new System.Drawing.Size(131, 23);
            this.VatAmountTextBox.TabIndex = 20;
            this.VatAmountTextBox.UseSelectable = true;
            this.VatAmountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VatAmountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.VatAmountTextBox.Click += new System.EventHandler(this.VatAmountTextBox_Click);
            // 
            // GrandTotalTextBox
            // 
            // 
            // 
            // 
            this.GrandTotalTextBox.CustomButton.Image = null;
            this.GrandTotalTextBox.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.GrandTotalTextBox.CustomButton.Name = "";
            this.GrandTotalTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.GrandTotalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.GrandTotalTextBox.CustomButton.TabIndex = 1;
            this.GrandTotalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GrandTotalTextBox.CustomButton.UseSelectable = true;
            this.GrandTotalTextBox.CustomButton.Visible = false;
            this.GrandTotalTextBox.Lines = new string[0];
            this.GrandTotalTextBox.Location = new System.Drawing.Point(144, 498);
            this.GrandTotalTextBox.MaxLength = 32767;
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.PasswordChar = '\0';
            this.GrandTotalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GrandTotalTextBox.SelectedText = "";
            this.GrandTotalTextBox.SelectionLength = 0;
            this.GrandTotalTextBox.SelectionStart = 0;
            this.GrandTotalTextBox.ShortcutsEnabled = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(131, 23);
            this.GrandTotalTextBox.TabIndex = 21;
            this.GrandTotalTextBox.UseSelectable = true;
            this.GrandTotalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GrandTotalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.GrandTotalTextBox.TextChanged += new System.EventHandler(this.GrandTotalTextBox_TextChanged);
            this.GrandTotalTextBox.Click += new System.EventHandler(this.GrandTotalTextBox_Click);
            // 
            // invoiceproductsselectgrid
            // 
            this.invoiceproductsselectgrid.AllowUserToAddRows = false;
            this.invoiceproductsselectgrid.AllowUserToDeleteRows = false;
            this.invoiceproductsselectgrid.AllowUserToResizeRows = false;
            this.invoiceproductsselectgrid.BackgroundColor = System.Drawing.Color.White;
            this.invoiceproductsselectgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoiceproductsselectgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.invoiceproductsselectgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceproductsselectgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.invoiceproductsselectgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.invoiceproductsselectgrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.invoiceproductsselectgrid.EnableHeadersVisualStyles = false;
            this.invoiceproductsselectgrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.invoiceproductsselectgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.invoiceproductsselectgrid.Location = new System.Drawing.Point(487, 138);
            this.invoiceproductsselectgrid.Name = "invoiceproductsselectgrid";
            this.invoiceproductsselectgrid.ReadOnly = true;
            this.invoiceproductsselectgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceproductsselectgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.invoiceproductsselectgrid.RowHeadersVisible = false;
            this.invoiceproductsselectgrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.invoiceproductsselectgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceproductsselectgrid.Size = new System.Drawing.Size(535, 35);
            this.invoiceproductsselectgrid.TabIndex = 22;
            this.invoiceproductsselectgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // invoice1textbox
            // 
            // 
            // 
            // 
            this.invoice1textbox.CustomButton.Image = null;
            this.invoice1textbox.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.invoice1textbox.CustomButton.Name = "";
            this.invoice1textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.invoice1textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.invoice1textbox.CustomButton.TabIndex = 1;
            this.invoice1textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.invoice1textbox.CustomButton.UseSelectable = true;
            this.invoice1textbox.CustomButton.Visible = false;
            this.invoice1textbox.Lines = new string[0];
            this.invoice1textbox.Location = new System.Drawing.Point(584, 17);
            this.invoice1textbox.MaxLength = 32767;
            this.invoice1textbox.Name = "invoice1textbox";
            this.invoice1textbox.PasswordChar = '\0';
            this.invoice1textbox.ReadOnly = true;
            this.invoice1textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.invoice1textbox.SelectedText = "";
            this.invoice1textbox.SelectionLength = 0;
            this.invoice1textbox.SelectionStart = 0;
            this.invoice1textbox.ShortcutsEnabled = true;
            this.invoice1textbox.Size = new System.Drawing.Size(119, 23);
            this.invoice1textbox.TabIndex = 24;
            this.invoice1textbox.UseSelectable = true;
            this.invoice1textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.invoice1textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.invoice1textbox.Click += new System.EventHandler(this.invoice1textbox_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(472, 17);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(106, 19);
            this.metroLabel10.TabIndex = 23;
            this.metroLabel10.Text = "Invoice Number:";
            // 
            // invoice2textbox
            // 
            // 
            // 
            // 
            this.invoice2textbox.CustomButton.Image = null;
            this.invoice2textbox.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.invoice2textbox.CustomButton.Name = "";
            this.invoice2textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.invoice2textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.invoice2textbox.CustomButton.TabIndex = 1;
            this.invoice2textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.invoice2textbox.CustomButton.UseSelectable = true;
            this.invoice2textbox.CustomButton.Visible = false;
            this.invoice2textbox.Lines = new string[0];
            this.invoice2textbox.Location = new System.Drawing.Point(730, 17);
            this.invoice2textbox.MaxLength = 32767;
            this.invoice2textbox.Name = "invoice2textbox";
            this.invoice2textbox.PasswordChar = '\0';
            this.invoice2textbox.ReadOnly = true;
            this.invoice2textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.invoice2textbox.SelectedText = "";
            this.invoice2textbox.SelectionLength = 0;
            this.invoice2textbox.SelectionStart = 0;
            this.invoice2textbox.ShortcutsEnabled = true;
            this.invoice2textbox.Size = new System.Drawing.Size(124, 23);
            this.invoice2textbox.TabIndex = 25;
            this.invoice2textbox.UseSelectable = true;
            this.invoice2textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.invoice2textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(709, 17);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(15, 19);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "-";
            this.metroLabel11.Click += new System.EventHandler(this.metroLabel11_Click);
            // 
            // saveandprintbutton
            // 
            this.saveandprintbutton.BackgroundImage = global::basicPointOfSalesSoftware.Properties.Resources.OIP__3_;
            this.saveandprintbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveandprintbutton.Location = new System.Drawing.Point(952, 329);
            this.saveandprintbutton.Name = "saveandprintbutton";
            this.saveandprintbutton.Size = new System.Drawing.Size(85, 78);
            this.saveandprintbutton.TabIndex = 27;
            this.saveandprintbutton.Text = "Print Reciept";
            this.saveandprintbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.saveandprintbutton.UseSelectable = true;
            this.saveandprintbutton.Click += new System.EventHandler(this.saveandprintbutton_Click);
            // 
            // timetxt
            // 
            // 
            // 
            // 
            this.timetxt.CustomButton.Image = null;
            this.timetxt.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.timetxt.CustomButton.Name = "";
            this.timetxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.timetxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timetxt.CustomButton.TabIndex = 1;
            this.timetxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timetxt.CustomButton.UseSelectable = true;
            this.timetxt.CustomButton.Visible = false;
            this.timetxt.Lines = new string[0];
            this.timetxt.Location = new System.Drawing.Point(942, 17);
            this.timetxt.MaxLength = 32767;
            this.timetxt.Name = "timetxt";
            this.timetxt.PasswordChar = '\0';
            this.timetxt.ReadOnly = true;
            this.timetxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timetxt.SelectedText = "";
            this.timetxt.SelectionLength = 0;
            this.timetxt.SelectionStart = 0;
            this.timetxt.ShortcutsEnabled = true;
            this.timetxt.Size = new System.Drawing.Size(124, 23);
            this.timetxt.TabIndex = 28;
            this.timetxt.UseSelectable = true;
            this.timetxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timetxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(963, 554);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(134, 23);
            this.Closebutton.TabIndex = 29;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseSelectable = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(753, 46);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(78, 19);
            this.metroLabel12.TabIndex = 35;
            this.metroLabel12.Text = "Vat Reg No:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(474, 77);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(93, 19);
            this.metroLabel13.TabIndex = 34;
            this.metroLabel13.Text = "Shop Address:";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(474, 46);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(82, 19);
            this.metroLabel14.TabIndex = 33;
            this.metroLabel14.Text = "Shop Name:";
            // 
            // vatregnumtextbox
            // 
            // 
            // 
            // 
            this.vatregnumtextbox.CustomButton.Image = null;
            this.vatregnumtextbox.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.vatregnumtextbox.CustomButton.Name = "";
            this.vatregnumtextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.vatregnumtextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.vatregnumtextbox.CustomButton.TabIndex = 1;
            this.vatregnumtextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vatregnumtextbox.CustomButton.UseSelectable = true;
            this.vatregnumtextbox.CustomButton.Visible = false;
            this.vatregnumtextbox.Lines = new string[0];
            this.vatregnumtextbox.Location = new System.Drawing.Point(837, 46);
            this.vatregnumtextbox.MaxLength = 32767;
            this.vatregnumtextbox.Name = "vatregnumtextbox";
            this.vatregnumtextbox.PasswordChar = '\0';
            this.vatregnumtextbox.ReadOnly = true;
            this.vatregnumtextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vatregnumtextbox.SelectedText = "";
            this.vatregnumtextbox.SelectionLength = 0;
            this.vatregnumtextbox.SelectionStart = 0;
            this.vatregnumtextbox.ShortcutsEnabled = true;
            this.vatregnumtextbox.Size = new System.Drawing.Size(260, 23);
            this.vatregnumtextbox.TabIndex = 32;
            this.vatregnumtextbox.UseSelectable = true;
            this.vatregnumtextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vatregnumtextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // shopaddresstextbox
            // 
            // 
            // 
            // 
            this.shopaddresstextbox.CustomButton.Image = null;
            this.shopaddresstextbox.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.shopaddresstextbox.CustomButton.Name = "";
            this.shopaddresstextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.shopaddresstextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.shopaddresstextbox.CustomButton.TabIndex = 1;
            this.shopaddresstextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.shopaddresstextbox.CustomButton.UseSelectable = true;
            this.shopaddresstextbox.CustomButton.Visible = false;
            this.shopaddresstextbox.Lines = new string[0];
            this.shopaddresstextbox.Location = new System.Drawing.Point(568, 75);
            this.shopaddresstextbox.MaxLength = 32767;
            this.shopaddresstextbox.Name = "shopaddresstextbox";
            this.shopaddresstextbox.PasswordChar = '\0';
            this.shopaddresstextbox.ReadOnly = true;
            this.shopaddresstextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.shopaddresstextbox.SelectedText = "";
            this.shopaddresstextbox.SelectionLength = 0;
            this.shopaddresstextbox.SelectionStart = 0;
            this.shopaddresstextbox.ShortcutsEnabled = true;
            this.shopaddresstextbox.Size = new System.Drawing.Size(337, 23);
            this.shopaddresstextbox.TabIndex = 31;
            this.shopaddresstextbox.UseSelectable = true;
            this.shopaddresstextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.shopaddresstextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // shopnametextbox
            // 
            // 
            // 
            // 
            this.shopnametextbox.CustomButton.Image = null;
            this.shopnametextbox.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.shopnametextbox.CustomButton.Name = "";
            this.shopnametextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.shopnametextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.shopnametextbox.CustomButton.TabIndex = 1;
            this.shopnametextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.shopnametextbox.CustomButton.UseSelectable = true;
            this.shopnametextbox.CustomButton.Visible = false;
            this.shopnametextbox.Lines = new string[0];
            this.shopnametextbox.Location = new System.Drawing.Point(568, 46);
            this.shopnametextbox.MaxLength = 32767;
            this.shopnametextbox.Name = "shopnametextbox";
            this.shopnametextbox.PasswordChar = '\0';
            this.shopnametextbox.ReadOnly = true;
            this.shopnametextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.shopnametextbox.SelectedText = "";
            this.shopnametextbox.SelectionLength = 0;
            this.shopnametextbox.SelectionStart = 0;
            this.shopnametextbox.ShortcutsEnabled = true;
            this.shopnametextbox.Size = new System.Drawing.Size(179, 23);
            this.shopnametextbox.TabIndex = 30;
            this.shopnametextbox.UseSelectable = true;
            this.shopnametextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.shopnametextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductRecordGrid
            // 
            this.ProductRecordGrid.AllowUserToAddRows = false;
            this.ProductRecordGrid.AllowUserToDeleteRows = false;
            this.ProductRecordGrid.AllowUserToResizeColumns = false;
            this.ProductRecordGrid.AllowUserToResizeRows = false;
            this.ProductRecordGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductRecordGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductRecordGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductRecordGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductRecordGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductRecordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ProductRecordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductRecordGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.ProductRecordGrid.EnableHeadersVisualStyles = false;
            this.ProductRecordGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductRecordGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductRecordGrid.Location = new System.Drawing.Point(880, 660);
            this.ProductRecordGrid.Name = "ProductRecordGrid";
            this.ProductRecordGrid.ReadOnly = true;
            this.ProductRecordGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductRecordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ProductRecordGrid.RowHeadersVisible = false;
            this.ProductRecordGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductRecordGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductRecordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductRecordGrid.Size = new System.Drawing.Size(11, 32);
            this.ProductRecordGrid.TabIndex = 36;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printpreviewbutton
            // 
            this.printpreviewbutton.BackgroundImage = global::basicPointOfSalesSoftware.Properties.Resources.images__1_;
            this.printpreviewbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.printpreviewbutton.Location = new System.Drawing.Point(952, 233);
            this.printpreviewbutton.Name = "printpreviewbutton";
            this.printpreviewbutton.Size = new System.Drawing.Size(85, 73);
            this.printpreviewbutton.TabIndex = 37;
            this.printpreviewbutton.Text = "Print preview";
            this.printpreviewbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.printpreviewbutton.UseSelectable = true;
            this.printpreviewbutton.Click += new System.EventHandler(this.printpreviewbutton_Click);
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 655);
            this.Controls.Add(this.printpreviewbutton);
            this.Controls.Add(this.ProductRecordGrid);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.vatregnumtextbox);
            this.Controls.Add(this.shopaddresstextbox);
            this.Controls.Add(this.shopnametextbox);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.timetxt);
            this.Controls.Add(this.saveandprintbutton);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.invoice2textbox);
            this.Controls.Add(this.invoice1textbox);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.invoiceproductsselectgrid);
            this.Controls.Add(this.GrandTotalTextBox);
            this.Controls.Add(this.VatAmountTextBox);
            this.Controls.Add(this.NetTextBox);
            this.Controls.Add(this.VatpercentTextBox);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.DeleteBUTTON);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.InvoiceBarcodeTextbox);
            this.Controls.Add(this.AddToInvoiceButton);
            this.Controls.Add(this.InvoiceDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewInvoiceForm";
            this.Text = "New Invoice";
            this.Load += new System.EventHandler(this.NewInvoiceForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewInvoiceForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceproductsselectgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductRecordGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid InvoiceDataGridView;
        private MetroFramework.Controls.MetroButton AddToInvoiceButton;
        private MetroFramework.Controls.MetroTextBox InvoiceBarcodeTextbox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox PriceTextbox;
        private MetroFramework.Controls.MetroTextBox QuantityTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TotalTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton CalculateButton;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton DeleteBUTTON;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox VatpercentTextBox;
        private MetroFramework.Controls.MetroTextBox NetTextBox;
        private MetroFramework.Controls.MetroTextBox VatAmountTextBox;
        private MetroFramework.Controls.MetroTextBox GrandTotalTextBox;
        private MetroFramework.Controls.MetroGrid invoiceproductsselectgrid;
        private MetroFramework.Controls.MetroTextBox invoice1textbox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox invoice2textbox;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton saveandprintbutton;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox timetxt;
        private MetroFramework.Controls.MetroButton Closebutton;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox vatregnumtextbox;
        private MetroFramework.Controls.MetroTextBox shopaddresstextbox;
        private MetroFramework.Controls.MetroTextBox shopnametextbox;
        private MetroFramework.Controls.MetroGrid ProductRecordGrid;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroButton printpreviewbutton;
    }
}