namespace ADO.NET_WinForm_HW1.ButtonForms
{
    partial class MakeSell
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
            this.labelState = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productCB = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sellerCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buyerCB = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.quantTB = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalNumLabel = new System.Windows.Forms.Label();
            this.stockNumLabel = new System.Windows.Forms.Label();
            this.quantNumLabel = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Yellow;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.Color.Black;
            this.labelState.Location = new System.Drawing.Point(12, 9);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(53, 20);
            this.labelState.TabIndex = 8;
            this.labelState.Text = "State";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 40);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(118, 17);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Selling Stationery";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product type";
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(110, 76);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(206, 24);
            this.typeCB.TabIndex = 11;
            this.typeCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product";
            // 
            // productCB
            // 
            this.productCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCB.Enabled = false;
            this.productCB.FormattingEnabled = true;
            this.productCB.Location = new System.Drawing.Point(110, 119);
            this.productCB.Name = "productCB";
            this.productCB.Size = new System.Drawing.Size(206, 24);
            this.productCB.TabIndex = 13;
            this.productCB.SelectedIndexChanged += new System.EventHandler(this.productCB_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(107, 146);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(79, 17);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "StockPrice:";
            // 
            // quantLabel
            // 
            this.quantLabel.AutoSize = true;
            this.quantLabel.Location = new System.Drawing.Point(107, 163);
            this.quantLabel.Name = "quantLabel";
            this.quantLabel.Size = new System.Drawing.Size(65, 17);
            this.quantLabel.TabIndex = 15;
            this.quantLabel.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seller";
            // 
            // sellerCB
            // 
            this.sellerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sellerCB.FormattingEnabled = true;
            this.sellerCB.Location = new System.Drawing.Point(110, 194);
            this.sellerCB.Name = "sellerCB";
            this.sellerCB.Size = new System.Drawing.Size(206, 24);
            this.sellerCB.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Buyer";
            // 
            // buyerCB
            // 
            this.buyerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyerCB.FormattingEnabled = true;
            this.buyerCB.Location = new System.Drawing.Point(110, 236);
            this.buyerCB.Name = "buyerCB";
            this.buyerCB.Size = new System.Drawing.Size(206, 24);
            this.buyerCB.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1138, 402);
            this.dataGridView1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sell price";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(110, 290);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(206, 22);
            this.priceTB.TabIndex = 22;
            this.priceTB.TextChanged += new System.EventHandler(this.priceTB_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantity";
            // 
            // quantTB
            // 
            this.quantTB.Location = new System.Drawing.Point(110, 332);
            this.quantTB.Name = "quantTB";
            this.quantTB.Size = new System.Drawing.Size(206, 22);
            this.quantTB.TabIndex = 24;
            this.quantTB.TextChanged += new System.EventHandler(this.quantTB_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(14, 386);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(76, 29);
            this.totalLabel.TabIndex = 25;
            this.totalLabel.Text = "Total:";
            // 
            // totalNumLabel
            // 
            this.totalNumLabel.AutoSize = true;
            this.totalNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumLabel.Location = new System.Drawing.Point(96, 386);
            this.totalNumLabel.Name = "totalNumLabel";
            this.totalNumLabel.Size = new System.Drawing.Size(27, 29);
            this.totalNumLabel.TabIndex = 26;
            this.totalNumLabel.Text = "0";
            // 
            // stockNumLabel
            // 
            this.stockNumLabel.AutoSize = true;
            this.stockNumLabel.Location = new System.Drawing.Point(192, 146);
            this.stockNumLabel.Name = "stockNumLabel";
            this.stockNumLabel.Size = new System.Drawing.Size(16, 17);
            this.stockNumLabel.TabIndex = 27;
            this.stockNumLabel.Text = "0";
            // 
            // quantNumLabel
            // 
            this.quantNumLabel.AutoSize = true;
            this.quantNumLabel.Location = new System.Drawing.Point(178, 163);
            this.quantNumLabel.Name = "quantNumLabel";
            this.quantNumLabel.Size = new System.Drawing.Size(16, 17);
            this.quantNumLabel.TabIndex = 28;
            this.quantNumLabel.Text = "0";
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(229, 386);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(87, 29);
            this.sellButton.TabIndex = 29;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // MakeSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 427);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.quantNumLabel);
            this.Controls.Add(this.stockNumLabel);
            this.Controls.Add(this.totalNumLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.quantTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buyerCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sellerCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelState);
            this.Name = "MakeSell";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MakeSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productCB;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sellerCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox buyerCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantTB;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalNumLabel;
        private System.Windows.Forms.Label stockNumLabel;
        private System.Windows.Forms.Label quantNumLabel;
        private System.Windows.Forms.Button sellButton;
    }
}