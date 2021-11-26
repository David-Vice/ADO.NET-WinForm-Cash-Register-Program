namespace ADO.NET_WinForm_HW1
{
    partial class Main
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.addType = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.addStationery = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addManager = new System.Windows.Forms.Button();
            this.addCompany = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.pwButton = new System.Windows.Forms.Button();
            this.hwButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Lime;
            this.buttonConnect.Location = new System.Drawing.Point(12, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 36);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.Red;
            this.buttonDisconnect.Location = new System.Drawing.Point(118, 12);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(99, 36);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Yellow;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.Color.Black;
            this.labelState.Location = new System.Drawing.Point(12, 63);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(180, 20);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "State: Disconnected";
            // 
            // addType
            // 
            this.addType.Location = new System.Drawing.Point(12, 98);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(205, 36);
            this.addType.TabIndex = 3;
            this.addType.Text = "Stationery Types";
            this.addType.UseVisualStyleBackColor = true;
            this.addType.Click += new System.EventHandler(this.addType_Click);
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(223, 39);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.RowTemplate.Height = 24;
            this.dataGV.Size = new System.Drawing.Size(763, 419);
            this.dataGV.TabIndex = 15;
            // 
            // addStationery
            // 
            this.addStationery.Location = new System.Drawing.Point(12, 140);
            this.addStationery.Name = "addStationery";
            this.addStationery.Size = new System.Drawing.Size(205, 38);
            this.addStationery.TabIndex = 16;
            this.addStationery.Text = "Stationery Products";
            this.addStationery.UseVisualStyleBackColor = true;
            this.addStationery.Click += new System.EventHandler(this.addStationery_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(632, 22);
            this.textBox1.TabIndex = 17;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(861, 12);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(59, 23);
            this.runButton.TabIndex = 18;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(926, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addManager
            // 
            this.addManager.Location = new System.Drawing.Point(12, 184);
            this.addManager.Name = "addManager";
            this.addManager.Size = new System.Drawing.Size(205, 38);
            this.addManager.TabIndex = 20;
            this.addManager.Text = "Managers";
            this.addManager.UseVisualStyleBackColor = true;
            this.addManager.Click += new System.EventHandler(this.addManager_Click);
            // 
            // addCompany
            // 
            this.addCompany.Location = new System.Drawing.Point(12, 228);
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(205, 38);
            this.addCompany.TabIndex = 21;
            this.addCompany.Text = "Companies";
            this.addCompany.UseVisualStyleBackColor = true;
            this.addCompany.Click += new System.EventHandler(this.addCompany_Click);
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.Color.Lime;
            this.sellButton.Location = new System.Drawing.Point(12, 272);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(205, 38);
            this.sellButton.TabIndex = 22;
            this.sellButton.Text = "Sell Stationery";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // pwButton
            // 
            this.pwButton.Location = new System.Drawing.Point(12, 420);
            this.pwButton.Name = "pwButton";
            this.pwButton.Size = new System.Drawing.Size(205, 38);
            this.pwButton.TabIndex = 23;
            this.pwButton.Text = "PW Tasks";
            this.pwButton.UseVisualStyleBackColor = true;
            this.pwButton.Click += new System.EventHandler(this.pwButton_Click);
            // 
            // hwButton
            // 
            this.hwButton.Location = new System.Drawing.Point(12, 376);
            this.hwButton.Name = "hwButton";
            this.hwButton.Size = new System.Drawing.Size(205, 38);
            this.hwButton.TabIndex = 25;
            this.hwButton.Text = "HW Tasks";
            this.hwButton.UseVisualStyleBackColor = true;
            this.hwButton.Click += new System.EventHandler(this.hwButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 467);
            this.Controls.Add(this.hwButton);
            this.Controls.Add(this.pwButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.addCompany);
            this.Controls.Add(this.addManager);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addStationery);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.addType);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.MaximumSize = new System.Drawing.Size(1013, 514);
            this.MinimumSize = new System.Drawing.Size(1013, 514);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button addType;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button addStationery;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addManager;
        private System.Windows.Forms.Button addCompany;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button pwButton;
        private System.Windows.Forms.Button hwButton;
    }
}

