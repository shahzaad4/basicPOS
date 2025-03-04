
namespace basicPointOfSalesSoftware.Screens.ProductsF
{
    partial class ProductsRecordForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsRecordForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SearchbyBarcodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductRecordGrid = new MetroFramework.Controls.MetroGrid();
            this.CloseButton_pr = new MetroFramework.Controls.MetroButton();
            this.calculatevatbtt = new MetroFramework.Controls.MetroButton();
            this.VatTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.BarcodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SalesPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DeleteButton = new MetroFramework.Controls.MetroButton();
            this.UpdateButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProductRecordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Search by Barcode";
            // 
            // SearchbyBarcodeTextBox
            // 
            // 
            // 
            // 
            this.SearchbyBarcodeTextBox.CustomButton.Image = null;
            this.SearchbyBarcodeTextBox.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.SearchbyBarcodeTextBox.CustomButton.Name = "";
            this.SearchbyBarcodeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchbyBarcodeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchbyBarcodeTextBox.CustomButton.TabIndex = 1;
            this.SearchbyBarcodeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchbyBarcodeTextBox.CustomButton.UseSelectable = true;
            this.SearchbyBarcodeTextBox.CustomButton.Visible = false;
            this.SearchbyBarcodeTextBox.Lines = new string[0];
            this.SearchbyBarcodeTextBox.Location = new System.Drawing.Point(148, 104);
            this.SearchbyBarcodeTextBox.MaxLength = 32767;
            this.SearchbyBarcodeTextBox.Name = "SearchbyBarcodeTextBox";
            this.SearchbyBarcodeTextBox.PasswordChar = '\0';
            this.SearchbyBarcodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchbyBarcodeTextBox.SelectedText = "";
            this.SearchbyBarcodeTextBox.SelectionLength = 0;
            this.SearchbyBarcodeTextBox.SelectionStart = 0;
            this.SearchbyBarcodeTextBox.ShortcutsEnabled = true;
            this.SearchbyBarcodeTextBox.Size = new System.Drawing.Size(262, 23);
            this.SearchbyBarcodeTextBox.TabIndex = 1;
            this.SearchbyBarcodeTextBox.UseSelectable = true;
            this.SearchbyBarcodeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchbyBarcodeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchbyBarcodeTextBox.TextChanged += new System.EventHandler(this.SearchbyBarcodeTextBox_TextChanged);
            this.SearchbyBarcodeTextBox.Click += new System.EventHandler(this.SearchProductTextBox_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductRecordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductRecordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductRecordGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductRecordGrid.EnableHeadersVisualStyles = false;
            this.ProductRecordGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductRecordGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductRecordGrid.Location = new System.Drawing.Point(23, 137);
            this.ProductRecordGrid.Name = "ProductRecordGrid";
            this.ProductRecordGrid.ReadOnly = true;
            this.ProductRecordGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductRecordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductRecordGrid.RowHeadersVisible = false;
            this.ProductRecordGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductRecordGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductRecordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductRecordGrid.Size = new System.Drawing.Size(537, 324);
            this.ProductRecordGrid.TabIndex = 2;
            this.ProductRecordGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductRecordGrid_CellContentClick);
            this.ProductRecordGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductRecordGrid_CellContentClick);
            // 
            // CloseButton_pr
            // 
            this.CloseButton_pr.Location = new System.Drawing.Point(43, 488);
            this.CloseButton_pr.Name = "CloseButton_pr";
            this.CloseButton_pr.Size = new System.Drawing.Size(75, 23);
            this.CloseButton_pr.TabIndex = 3;
            this.CloseButton_pr.Text = "Close";
            this.CloseButton_pr.UseSelectable = true;
            this.CloseButton_pr.Click += new System.EventHandler(this.CloseButton_pr_Click);
            // 
            // calculatevatbtt
            // 
            this.calculatevatbtt.Location = new System.Drawing.Point(964, 227);
            this.calculatevatbtt.Name = "calculatevatbtt";
            this.calculatevatbtt.Size = new System.Drawing.Size(58, 23);
            this.calculatevatbtt.TabIndex = 30;
            this.calculatevatbtt.Text = "calculate";
            this.calculatevatbtt.UseSelectable = true;
            this.calculatevatbtt.Click += new System.EventHandler(this.calculatevatbtt_Click);
            // 
            // VatTextBox
            // 
            // 
            // 
            // 
            this.VatTextBox.CustomButton.Image = null;
            this.VatTextBox.CustomButton.Location = new System.Drawing.Point(47, 1);
            this.VatTextBox.CustomButton.Name = "";
            this.VatTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VatTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VatTextBox.CustomButton.TabIndex = 1;
            this.VatTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VatTextBox.CustomButton.UseSelectable = true;
            this.VatTextBox.CustomButton.Visible = false;
            this.VatTextBox.Lines = new string[0];
            this.VatTextBox.Location = new System.Drawing.Point(877, 227);
            this.VatTextBox.MaxLength = 32767;
            this.VatTextBox.Name = "VatTextBox";
            this.VatTextBox.PasswordChar = '\0';
            this.VatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VatTextBox.SelectedText = "";
            this.VatTextBox.SelectionLength = 0;
            this.VatTextBox.SelectionStart = 0;
            this.VatTextBox.ShortcutsEnabled = true;
            this.VatTextBox.Size = new System.Drawing.Size(69, 23);
            this.VatTextBox.TabIndex = 29;
            this.VatTextBox.UseSelectable = true;
            this.VatTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VatTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(830, 227);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 28;
            this.metroLabel8.Text = "Vat %";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(576, 133);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(58, 19);
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = "Barcode";
            // 
            // BarcodeTextBox
            // 
            // 
            // 
            // 
            this.BarcodeTextBox.CustomButton.Image = null;
            this.BarcodeTextBox.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.BarcodeTextBox.CustomButton.Name = "";
            this.BarcodeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BarcodeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BarcodeTextBox.CustomButton.TabIndex = 1;
            this.BarcodeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BarcodeTextBox.CustomButton.UseSelectable = true;
            this.BarcodeTextBox.CustomButton.Visible = false;
            this.BarcodeTextBox.Lines = new string[0];
            this.BarcodeTextBox.Location = new System.Drawing.Point(689, 133);
            this.BarcodeTextBox.MaxLength = 32767;
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.PasswordChar = '\0';
            this.BarcodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BarcodeTextBox.SelectedText = "";
            this.BarcodeTextBox.SelectionLength = 0;
            this.BarcodeTextBox.SelectionStart = 0;
            this.BarcodeTextBox.ShortcutsEnabled = true;
            this.BarcodeTextBox.Size = new System.Drawing.Size(257, 23);
            this.BarcodeTextBox.TabIndex = 24;
            this.BarcodeTextBox.UseSelectable = true;
            this.BarcodeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BarcodeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(576, 227);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Sales Price";
            // 
            // SalesPriceTextBox
            // 
            // 
            // 
            // 
            this.SalesPriceTextBox.CustomButton.Image = null;
            this.SalesPriceTextBox.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.SalesPriceTextBox.CustomButton.Name = "";
            this.SalesPriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SalesPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SalesPriceTextBox.CustomButton.TabIndex = 1;
            this.SalesPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SalesPriceTextBox.CustomButton.UseSelectable = true;
            this.SalesPriceTextBox.CustomButton.Visible = false;
            this.SalesPriceTextBox.Lines = new string[0];
            this.SalesPriceTextBox.Location = new System.Drawing.Point(689, 227);
            this.SalesPriceTextBox.MaxLength = 32767;
            this.SalesPriceTextBox.Name = "SalesPriceTextBox";
            this.SalesPriceTextBox.PasswordChar = '\0';
            this.SalesPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SalesPriceTextBox.SelectedText = "";
            this.SalesPriceTextBox.SelectionLength = 0;
            this.SalesPriceTextBox.SelectionStart = 0;
            this.SalesPriceTextBox.ShortcutsEnabled = true;
            this.SalesPriceTextBox.Size = new System.Drawing.Size(135, 23);
            this.SalesPriceTextBox.TabIndex = 25;
            this.SalesPriceTextBox.UseSelectable = true;
            this.SalesPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SalesPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductNameTextBox
            // 
            // 
            // 
            // 
            this.ProductNameTextBox.CustomButton.Image = null;
            this.ProductNameTextBox.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.ProductNameTextBox.CustomButton.Name = "";
            this.ProductNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductNameTextBox.CustomButton.TabIndex = 1;
            this.ProductNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductNameTextBox.CustomButton.UseSelectable = true;
            this.ProductNameTextBox.CustomButton.Visible = false;
            this.ProductNameTextBox.Lines = new string[0];
            this.ProductNameTextBox.Location = new System.Drawing.Point(689, 178);
            this.ProductNameTextBox.MaxLength = 32767;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.PasswordChar = '\0';
            this.ProductNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameTextBox.SelectedText = "";
            this.ProductNameTextBox.SelectionLength = 0;
            this.ProductNameTextBox.SelectionStart = 0;
            this.ProductNameTextBox.ShortcutsEnabled = true;
            this.ProductNameTextBox.Size = new System.Drawing.Size(257, 23);
            this.ProductNameTextBox.TabIndex = 23;
            this.ProductNameTextBox.UseSelectable = true;
            this.ProductNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(576, 178);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Product Name";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(576, 302);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 31;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseSelectable = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(689, 302);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 32;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseSelectable = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ProductsRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 655);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.calculatevatbtt);
            this.Controls.Add(this.VatTextBox);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.BarcodeTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.SalesPriceTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.CloseButton_pr);
            this.Controls.Add(this.ProductRecordGrid);
            this.Controls.Add(this.SearchbyBarcodeTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductsRecordForm";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Products Record";
            this.Load += new System.EventHandler(this.ProductsRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductRecordGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox SearchbyBarcodeTextBox;
        private MetroFramework.Controls.MetroGrid ProductRecordGrid;
        private MetroFramework.Controls.MetroButton CloseButton_pr;
        private MetroFramework.Controls.MetroButton calculatevatbtt;
        private MetroFramework.Controls.MetroTextBox VatTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox BarcodeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox SalesPriceTextBox;
        private MetroFramework.Controls.MetroTextBox ProductNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton DeleteButton;
        private MetroFramework.Controls.MetroButton UpdateButton;
    }
}