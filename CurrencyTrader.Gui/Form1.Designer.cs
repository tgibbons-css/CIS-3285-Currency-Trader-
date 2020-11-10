namespace CurrencyTrader.Gui
{
    partial class Form1
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
            this.btnReadTrades = new System.Windows.Forms.Button();
            this.btnParseTrades = new System.Windows.Forms.Button();
            this.btnStoreTrades = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeUrl = new System.Windows.Forms.TextBox();
            this.lbTradeLines = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumTrades = new System.Windows.Forms.TextBox();
            this.txtStoreStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadTrades
            // 
            this.btnReadTrades.Location = new System.Drawing.Point(50, 67);
            this.btnReadTrades.Name = "btnReadTrades";
            this.btnReadTrades.Size = new System.Drawing.Size(187, 60);
            this.btnReadTrades.TabIndex = 0;
            this.btnReadTrades.Text = "Read Trades";
            this.btnReadTrades.UseVisualStyleBackColor = true;
            this.btnReadTrades.Click += new System.EventHandler(this.btnReadTrades_Click);
            // 
            // btnParseTrades
            // 
            this.btnParseTrades.Location = new System.Drawing.Point(303, 67);
            this.btnParseTrades.Name = "btnParseTrades";
            this.btnParseTrades.Size = new System.Drawing.Size(187, 60);
            this.btnParseTrades.TabIndex = 1;
            this.btnParseTrades.Text = "Parse Trades";
            this.btnParseTrades.UseVisualStyleBackColor = true;
            this.btnParseTrades.Click += new System.EventHandler(this.btnParseTrades_Click);
            // 
            // btnStoreTrades
            // 
            this.btnStoreTrades.Location = new System.Drawing.Point(560, 67);
            this.btnStoreTrades.Name = "btnStoreTrades";
            this.btnStoreTrades.Size = new System.Drawing.Size(187, 60);
            this.btnStoreTrades.TabIndex = 2;
            this.btnStoreTrades.Text = "Store Trades";
            this.btnStoreTrades.UseVisualStyleBackColor = true;
            this.btnStoreTrades.Click += new System.EventHandler(this.btnStoreTrades_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.Location = new System.Drawing.Point(203, 466);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(408, 108);
            this.lbStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status Messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trade URL";
            // 
            // txtTradeUrl
            // 
            this.txtTradeUrl.Location = new System.Drawing.Point(50, 30);
            this.txtTradeUrl.Name = "txtTradeUrl";
            this.txtTradeUrl.Size = new System.Drawing.Size(234, 20);
            this.txtTradeUrl.TabIndex = 6;
            this.txtTradeUrl.Text = "http://faculty.css.edu/tgibbons/trades100.txt";
            // 
            // lbTradeLines
            // 
            this.lbTradeLines.FormattingEnabled = true;
            this.lbTradeLines.Location = new System.Drawing.Point(50, 148);
            this.lbTradeLines.Name = "lbTradeLines";
            this.lbTradeLines.Size = new System.Drawing.Size(187, 251);
            this.lbTradeLines.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trades parsed ";
            // 
            // txtNumTrades
            // 
            this.txtNumTrades.Location = new System.Drawing.Point(306, 200);
            this.txtNumTrades.Name = "txtNumTrades";
            this.txtNumTrades.Size = new System.Drawing.Size(171, 20);
            this.txtNumTrades.TabIndex = 9;
            // 
            // txtStoreStatus
            // 
            this.txtStoreStatus.Location = new System.Drawing.Point(560, 211);
            this.txtStoreStatus.Name = "txtStoreStatus";
            this.txtStoreStatus.Size = new System.Drawing.Size(187, 20);
            this.txtStoreStatus.TabIndex = 11;
            this.txtStoreStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trades Storeage Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 586);
            this.Controls.Add(this.txtStoreStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumTrades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTradeLines);
            this.Controls.Add(this.txtTradeUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnStoreTrades);
            this.Controls.Add(this.btnParseTrades);
            this.Controls.Add(this.btnReadTrades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadTrades;
        private System.Windows.Forms.Button btnParseTrades;
        private System.Windows.Forms.Button btnStoreTrades;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeUrl;
        private System.Windows.Forms.ListBox lbTradeLines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumTrades;
        private System.Windows.Forms.TextBox txtStoreStatus;
        private System.Windows.Forms.Label label4;
    }
}

