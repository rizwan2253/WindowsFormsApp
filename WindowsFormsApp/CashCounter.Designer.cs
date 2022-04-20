namespace WindowsFormsApp
{
    partial class CashCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashCounter));
            this.dataGridViewItemsDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxCustomerId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSalePrice = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalQuantity = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.TotalAmountlbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSavePrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewItemsDetail
            // 
            this.dataGridViewItemsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemsDetail.Location = new System.Drawing.Point(255, 39);
            this.dataGridViewItemsDetail.Name = "dataGridViewItemsDetail";
            this.dataGridViewItemsDetail.Size = new System.Drawing.Size(372, 140);
            this.dataGridViewItemsDetail.TabIndex = 0;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(729, 147);
            this.dataGridViewCustomer.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddDetail);
            this.groupBox1.Controls.Add(this.textBoxQuantity);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBoxCustomerId);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBoxCategory);
            this.groupBox1.Controls.Add(this.textBoxBarcode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSalePrice);
            this.groupBox1.Controls.Add(this.textBoxManufacturer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxItems);
            this.groupBox1.Controls.Add(this.dataGridViewItemsDetail);
            this.groupBox1.Location = new System.Drawing.Point(21, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Detail";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(129, 185);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(97, 20);
            this.btnAddDetail.TabIndex = 31;
            this.btnAddDetail.Text = "Add Detail";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(79, 185);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(44, 20);
            this.textBoxQuantity.TabIndex = 32;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Quantity";
            // 
            // txtBoxCustomerId
            // 
            this.txtBoxCustomerId.Location = new System.Drawing.Point(79, 23);
            this.txtBoxCustomerId.Name = "txtBoxCustomerId";
            this.txtBoxCustomerId.ReadOnly = true;
            this.txtBoxCustomerId.Size = new System.Drawing.Size(147, 20);
            this.txtBoxCustomerId.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Enter to Search :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(345, 11);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(282, 20);
            this.textBox4.TabIndex = 27;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(79, 133);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.ReadOnly = true;
            this.textBoxCategory.Size = new System.Drawing.Size(147, 20);
            this.textBoxCategory.TabIndex = 26;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(79, 49);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(147, 20);
            this.textBoxBarcode.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sale Price";
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Location = new System.Drawing.Point(79, 159);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.ReadOnly = true;
            this.textBoxSalePrice.Size = new System.Drawing.Size(147, 20);
            this.textBoxSalePrice.TabIndex = 18;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(79, 107);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.ReadOnly = true;
            this.textBoxManufacturer.Size = new System.Drawing.Size(147, 20);
            this.textBoxManufacturer.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Category";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(79, 80);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(147, 21);
            this.comboBoxItems.TabIndex = 14;
            this.comboBoxItems.SelectedValueChanged += new System.EventHandler(this.SelectedValueChanged_Items);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total Quantity";
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.AutoSize = true;
            this.TotalQuantity.Location = new System.Drawing.Point(550, 180);
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.Size = new System.Drawing.Size(46, 13);
            this.TotalQuantity.TabIndex = 30;
            this.TotalQuantity.Text = ".............";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Location = new System.Drawing.Point(689, 180);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(46, 13);
            this.TotalAmount.TabIndex = 32;
            this.TotalAmount.Text = ".............";
            // 
            // TotalAmountlbl
            // 
            this.TotalAmountlbl.AutoSize = true;
            this.TotalAmountlbl.Location = new System.Drawing.Point(613, 180);
            this.TotalAmountlbl.Name = "TotalAmountlbl";
            this.TotalAmountlbl.Size = new System.Drawing.Size(70, 13);
            this.TotalAmountlbl.TabIndex = 31;
            this.TotalAmountlbl.Text = "Total Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSavePrint);
            this.groupBox2.Controls.Add(this.dataGridViewCustomer);
            this.groupBox2.Controls.Add(this.TotalAmount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TotalAmountlbl);
            this.groupBox2.Controls.Add(this.TotalQuantity);
            this.groupBox2.Location = new System.Drawing.Point(21, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 209);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Detail";
            // 
            // buttonSavePrint
            // 
            this.buttonSavePrint.Location = new System.Drawing.Point(7, 180);
            this.buttonSavePrint.Name = "buttonSavePrint";
            this.buttonSavePrint.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePrint.TabIndex = 33;
            this.buttonSavePrint.Text = "Save && Print";
            this.buttonSavePrint.UseVisualStyleBackColor = true;
            this.buttonSavePrint.Click += new System.EventHandler(this.buttonSavePrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(21, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // CashCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CashCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashCounter";
            this.Load += new System.EventHandler(this.CashCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItemsDetail;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSalePrice;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCustomerId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalQuantity;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label TotalAmountlbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSavePrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}