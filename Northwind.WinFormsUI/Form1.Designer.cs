namespace Northwind.WinFormsUI
{
    partial class FrmProduct
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProductNameSearch = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cbxCategoryIdAdd = new System.Windows.Forms.ComboBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.tbxUnitInStockAdd = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.lblUnitInStock = new System.Windows.Forms.Label();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.lblCategoryNameUpdate = new System.Windows.Forms.Label();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.tbxUnitInStockUpdate = new System.Windows.Forms.TextBox();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitInStockUpdate = new System.Windows.Forms.Label();
            this.tbxProducNameUpdate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 402);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 62;
            this.dgwProduct.RowTemplate.Height = 28;
            this.dgwProduct.Size = new System.Drawing.Size(1126, 410);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 312);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(539, 72);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Arama";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(124, 32);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(284, 28);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(19, 32);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.tbxProductNameSearch);
            this.gbxProduct.Controls.Add(this.lblProduct);
            this.gbxProduct.Location = new System.Drawing.Point(578, 307);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(423, 77);
            this.gbxProduct.TabIndex = 2;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Ürün Adına Göre Arama";
            // 
            // tbxProductNameSearch
            // 
            this.tbxProductNameSearch.Location = new System.Drawing.Point(125, 37);
            this.tbxProductNameSearch.Name = "tbxProductNameSearch";
            this.tbxProductNameSearch.Size = new System.Drawing.Size(284, 26);
            this.tbxProductNameSearch.TabIndex = 1;
            this.tbxProductNameSearch.TextChanged += new System.EventHandler(this.tbxProductNameSearch_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(23, 38);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(71, 20);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Ürün Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductName);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryIdAdd);
            this.gbxProductAdd.Controls.Add(this.lblCategoryName);
            this.gbxProductAdd.Controls.Add(this.tbxUnitInStockAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitInStock);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 31);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(539, 275);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 31);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Kaydet";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(31, 31);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(71, 20);
            this.lblProductName.TabIndex = 14;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // cbxCategoryIdAdd
            // 
            this.cbxCategoryIdAdd.FormattingEnabled = true;
            this.cbxCategoryIdAdd.Location = new System.Drawing.Point(136, 63);
            this.cbxCategoryIdAdd.Name = "cbxCategoryIdAdd";
            this.cbxCategoryIdAdd.Size = new System.Drawing.Size(202, 28);
            this.cbxCategoryIdAdd.TabIndex = 23;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(31, 66);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(68, 20);
            this.lblCategoryName.TabIndex = 15;
            this.lblCategoryName.Text = "Kategori";
            // 
            // tbxUnitInStockAdd
            // 
            this.tbxUnitInStockAdd.Location = new System.Drawing.Point(136, 138);
            this.tbxUnitInStockAdd.Name = "tbxUnitInStockAdd";
            this.tbxUnitInStockAdd.Size = new System.Drawing.Size(202, 26);
            this.tbxUnitInStockAdd.TabIndex = 22;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(31, 100);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(43, 20);
            this.lblUnitPrice.TabIndex = 16;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(136, 175);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(202, 26);
            this.tbxQuantityPerUnitAdd.TabIndex = 21;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(31, 138);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(87, 20);
            this.lblStock.TabIndex = 17;
            this.lblStock.Text = "Stok Adedi";
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(136, 100);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(202, 26);
            this.tbxUnitPriceAdd.TabIndex = 20;
            // 
            // lblUnitInStock
            // 
            this.lblUnitInStock.AutoSize = true;
            this.lblUnitInStock.Location = new System.Drawing.Point(31, 178);
            this.lblUnitInStock.Name = "lblUnitInStock";
            this.lblUnitInStock.Size = new System.Drawing.Size(89, 20);
            this.lblUnitInStock.TabIndex = 18;
            this.lblUnitInStock.Text = "Birim Adedi";
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(136, 28);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(202, 26);
            this.tbxProductNameAdd.TabIndex = 19;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblProductNameUpdate);
            this.gbxUpdate.Controls.Add(this.cbxCategoryIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblCategoryNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitInStockUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitInStockUpdate);
            this.gbxUpdate.Controls.Add(this.tbxProducNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(578, 31);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(560, 275);
            this.gbxUpdate.TabIndex = 4;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(173, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 31);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(31, 31);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(71, 20);
            this.lblProductNameUpdate.TabIndex = 14;
            this.lblProductNameUpdate.Text = "Ürün Adı";
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(136, 63);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(202, 28);
            this.cbxCategoryIdUpdate.TabIndex = 23;
            // 
            // lblCategoryNameUpdate
            // 
            this.lblCategoryNameUpdate.AutoSize = true;
            this.lblCategoryNameUpdate.Location = new System.Drawing.Point(31, 66);
            this.lblCategoryNameUpdate.Name = "lblCategoryNameUpdate";
            this.lblCategoryNameUpdate.Size = new System.Drawing.Size(68, 20);
            this.lblCategoryNameUpdate.TabIndex = 15;
            this.lblCategoryNameUpdate.Text = "Kategori";
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(136, 175);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(202, 26);
            this.tbxQuantityPerUnitUpdate.TabIndex = 22;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(31, 100);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(43, 20);
            this.lblUnitPriceUpdate.TabIndex = 16;
            this.lblUnitPriceUpdate.Text = "Fiyat";
            // 
            // tbxUnitInStockUpdate
            // 
            this.tbxUnitInStockUpdate.Location = new System.Drawing.Point(136, 138);
            this.tbxUnitInStockUpdate.Name = "tbxUnitInStockUpdate";
            this.tbxUnitInStockUpdate.Size = new System.Drawing.Size(202, 26);
            this.tbxUnitInStockUpdate.TabIndex = 21;
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(31, 138);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(87, 20);
            this.lblStockAmountUpdate.TabIndex = 17;
            this.lblStockAmountUpdate.Text = "Stok Adedi";
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(136, 100);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(202, 26);
            this.tbxUnitPriceUpdate.TabIndex = 20;
            // 
            // lblUnitInStockUpdate
            // 
            this.lblUnitInStockUpdate.AutoSize = true;
            this.lblUnitInStockUpdate.Location = new System.Drawing.Point(31, 178);
            this.lblUnitInStockUpdate.Name = "lblUnitInStockUpdate";
            this.lblUnitInStockUpdate.Size = new System.Drawing.Size(89, 20);
            this.lblUnitInStockUpdate.TabIndex = 18;
            this.lblUnitInStockUpdate.Text = "Birim Adedi";
            // 
            // tbxProducNameUpdate
            // 
            this.tbxProducNameUpdate.Location = new System.Drawing.Point(136, 28);
            this.tbxProducNameUpdate.Name = "tbxProducNameUpdate";
            this.tbxProducNameUpdate.Size = new System.Drawing.Size(202, 26);
            this.tbxProducNameUpdate.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1008, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 71);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 824);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "FrmProduct";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.TextBox tbxProductNameSearch;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cbxCategoryIdAdd;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox tbxUnitInStockAdd;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.Label lblUnitInStock;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.Label lblCategoryNameUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxUnitInStockUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Label lblUnitInStockUpdate;
        private System.Windows.Forms.TextBox tbxProducNameUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

