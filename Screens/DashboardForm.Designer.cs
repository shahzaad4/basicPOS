
namespace basicPointOfSalesSoftware.Screens
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.AboutButton = new MetroFramework.Controls.MetroButton();
            this.NewInvoiceButton = new MetroFramework.Controls.MetroButton();
            this.ChangePasswordButton = new MetroFramework.Controls.MetroButton();
            this.ManageProductsButton = new MetroFramework.Controls.MetroButton();
            this.ExitApplicationButton = new MetroFramework.Controls.MetroButton();
            this.DefineProductsButton = new MetroFramework.Controls.MetroButton();
            this.TransactionsRecordButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(854, 574);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 12;
            this.AboutButton.Text = "About";
            this.AboutButton.UseSelectable = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // NewInvoiceButton
            // 
            this.NewInvoiceButton.BackColor = System.Drawing.Color.Transparent;
            this.NewInvoiceButton.BackgroundImage = global::basicPointOfSalesSoftware.Properties.Resources.download__7_;
            this.NewInvoiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewInvoiceButton.Location = new System.Drawing.Point(80, 434);
            this.NewInvoiceButton.Name = "NewInvoiceButton";
            this.NewInvoiceButton.Size = new System.Drawing.Size(343, 134);
            this.NewInvoiceButton.TabIndex = 10;
            this.NewInvoiceButton.Text = "Add New Invoice";
            this.NewInvoiceButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.NewInvoiceButton.UseSelectable = true;
            this.NewInvoiceButton.Click += new System.EventHandler(this.Newinvoice_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.ChangePasswordButton.BackgroundImage = global::basicPointOfSalesSoftware.Properties.Resources.download__5_;
            this.ChangePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChangePasswordButton.Location = new System.Drawing.Point(277, 247);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(146, 134);
            this.ChangePasswordButton.TabIndex = 9;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ChangePasswordButton.UseSelectable = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ManageProductsButton
            // 
            this.ManageProductsButton.BackColor = System.Drawing.Color.Transparent;
            this.ManageProductsButton.BackgroundImage = global::basicPointOfSalesSoftware.Properties.Resources.images__2_1;
            this.ManageProductsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ManageProductsButton.Location = new System.Drawing.Point(277, 82);
            this.ManageProductsButton.Name = "ManageProductsButton";
            this.ManageProductsButton.Size = new System.Drawing.Size(146, 134);
            this.ManageProductsButton.TabIndex = 5;
            this.ManageProductsButton.Text = "Manage Products";
            this.ManageProductsButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ManageProductsButton.UseSelectable = true;
            this.ManageProductsButton.Click += new System.EventHandler(this.ManageProductsButton_Click);
            // 
            // ExitApplicationButton
            // 
            this.ExitApplicationButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitApplicationButton.BackgroundImage = global::basicPointOfSalesSoftware.Properties.Resources.download__2_;
            this.ExitApplicationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitApplicationButton.Location = new System.Drawing.Point(662, 434);
            this.ExitApplicationButton.Name = "ExitApplicationButton";
            this.ExitApplicationButton.Size = new System.Drawing.Size(146, 134);
            this.ExitApplicationButton.TabIndex = 2;
            this.ExitApplicationButton.Text = "Exit Application";
            this.ExitApplicationButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ExitApplicationButton.UseSelectable = true;
            this.ExitApplicationButton.Click += new System.EventHandler(this.ExitApplicationButton_Click);
            // 
            // DefineProductsButton
            // 
            this.DefineProductsButton.BackColor = System.Drawing.Color.Transparent;
            this.DefineProductsButton.BackgroundImage = global::basicPointOfSalesSoftware.Properties.Resources.download1;
            this.DefineProductsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DefineProductsButton.Location = new System.Drawing.Point(80, 82);
            this.DefineProductsButton.Name = "DefineProductsButton";
            this.DefineProductsButton.Size = new System.Drawing.Size(146, 134);
            this.DefineProductsButton.TabIndex = 1;
            this.DefineProductsButton.Text = "Define Products";
            this.DefineProductsButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DefineProductsButton.UseSelectable = true;
            this.DefineProductsButton.Click += new System.EventHandler(this.DefineProductsButton_Click);
            // 
            // TransactionsRecordButton
            // 
            this.TransactionsRecordButton.BackColor = System.Drawing.Color.Transparent;
            this.TransactionsRecordButton.BackgroundImage = global::basicPointOfSalesSoftware.Properties.Resources.OIP__1_;
            this.TransactionsRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TransactionsRecordButton.Location = new System.Drawing.Point(80, 247);
            this.TransactionsRecordButton.Name = "TransactionsRecordButton";
            this.TransactionsRecordButton.Size = new System.Drawing.Size(146, 134);
            this.TransactionsRecordButton.TabIndex = 0;
            this.TransactionsRecordButton.Text = "Transactions Record";
            this.TransactionsRecordButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TransactionsRecordButton.UseSelectable = true;
            this.TransactionsRecordButton.Click += new System.EventHandler(this.TransactionsRecordButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 655);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.NewInvoiceButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ManageProductsButton);
            this.Controls.Add(this.ExitApplicationButton);
            this.Controls.Add(this.DefineProductsButton);
            this.Controls.Add(this.TransactionsRecordButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(852, 546);
            this.Name = "DashboardForm";
            this.Text = "basicPOS|Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton TransactionsRecordButton;
        private MetroFramework.Controls.MetroButton DefineProductsButton;
        private MetroFramework.Controls.MetroButton ExitApplicationButton;
        private MetroFramework.Controls.MetroButton ManageProductsButton;
        private MetroFramework.Controls.MetroButton ChangePasswordButton;
        private MetroFramework.Controls.MetroButton NewInvoiceButton;
        private MetroFramework.Controls.MetroButton AboutButton;
    }
}