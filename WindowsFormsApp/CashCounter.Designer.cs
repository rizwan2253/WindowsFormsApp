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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashCounter));
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxCustomerId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMobNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(688, 147);
            this.dataGridViewCustomer.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMobNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAddDetail);
            this.groupBox1.Controls.Add(this.textBoxQuantity);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBoxCustomerId);
            this.groupBox1.Controls.Add(this.label11);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Detail";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetail.Location = new System.Drawing.Point(553, 91);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(141, 53);
            this.btnAddDetail.TabIndex = 31;
            this.btnAddDetail.Text = "Add Detail";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(469, 91);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(70, 26);
            this.textBoxQuantity.TabIndex = 32;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(392, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Quantity";
            // 
            // txtBoxCustomerId
            // 
            this.txtBoxCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCustomerId.Location = new System.Drawing.Point(111, 21);
            this.txtBoxCustomerId.Name = "txtBoxCustomerId";
            this.txtBoxCustomerId.ReadOnly = true;
            this.txtBoxCustomerId.Size = new System.Drawing.Size(43, 26);
            this.txtBoxCustomerId.TabIndex = 30;
            this.txtBoxCustomerId.Text = "8888";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Customer ID";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategory.Location = new System.Drawing.Point(469, 27);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.ReadOnly = true;
            this.textBoxCategory.Size = new System.Drawing.Size(225, 26);
            this.textBoxCategory.TabIndex = 26;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.Location = new System.Drawing.Point(111, 55);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(225, 26);
            this.textBoxBarcode.TabIndex = 25;
            this.textBoxBarcode.TextChanged += new System.EventHandler(this.textBoxBarcode_TextChanged);
            this.textBoxBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarcode_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sale Price";
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalePrice.Location = new System.Drawing.Point(111, 121);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.ReadOnly = true;
            this.textBoxSalePrice.Size = new System.Drawing.Size(225, 26);
            this.textBoxSalePrice.TabIndex = 18;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxManufacturer.Location = new System.Drawing.Point(469, 59);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.ReadOnly = true;
            this.textBoxManufacturer.Size = new System.Drawing.Size(225, 26);
            this.textBoxManufacturer.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Category";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(111, 87);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(225, 28);
            this.comboBoxItems.TabIndex = 14;
            this.comboBoxItems.SelectedValueChanged += new System.EventHandler(this.SelectedValueChanged_Items);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total Quantity";
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.AutoSize = true;
            this.TotalQuantity.Location = new System.Drawing.Point(487, 180);
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.Size = new System.Drawing.Size(46, 15);
            this.TotalQuantity.TabIndex = 30;
            this.TotalQuantity.Text = ".............";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Location = new System.Drawing.Point(626, 180);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(46, 15);
            this.TotalAmount.TabIndex = 32;
            this.TotalAmount.Text = ".............";
            // 
            // TotalAmountlbl
            // 
            this.TotalAmountlbl.AutoSize = true;
            this.TotalAmountlbl.Location = new System.Drawing.Point(550, 180);
            this.TotalAmountlbl.Name = "TotalAmountlbl";
            this.TotalAmountlbl.Size = new System.Drawing.Size(79, 15);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 209);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Detail";
            // 
            // buttonSavePrint
            // 
            this.buttonSavePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePrint.Location = new System.Drawing.Point(7, 172);
            this.buttonSavePrint.Name = "buttonSavePrint";
            this.buttonSavePrint.Size = new System.Drawing.Size(137, 31);
            this.buttonSavePrint.TabIndex = 33;
            this.buttonSavePrint.Text = "Save && Print";
            this.buttonSavePrint.UseVisualStyleBackColor = true;
            this.buttonSavePrint.Click += new System.EventHandler(this.buttonSavePrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(21, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 30);
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
            this.printPreviewDialog.ShowIcon = false;
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(635, 234);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(93, 33);
            this.buttonRemove.TabIndex = 35;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mob.No.";
            // 
            // txtMobNo
            // 
            this.txtMobNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobNo.Location = new System.Drawing.Point(224, 23);
            this.txtMobNo.Name = "txtMobNo";
            this.txtMobNo.Size = new System.Drawing.Size(112, 26);
            this.txtMobNo.TabIndex = 34;
            this.txtMobNo.Text = "03233382253";
            // 
            // CashCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 550);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CashCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashCounter";
            this.Load += new System.EventHandler(this.CashCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox txtMobNo;
        private System.Windows.Forms.Label label4;
    }
}