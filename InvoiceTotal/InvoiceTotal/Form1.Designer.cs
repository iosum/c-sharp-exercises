namespace InvoiceTotal
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
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(292, 64);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 29);
            this.txtSubtotal.TabIndex = 0;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(292, 117);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 29);
            this.txtDiscountPercent.TabIndex = 1;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(292, 164);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 29);
            this.txtDiscountAmount.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(292, 213);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 29);
            this.txtTotal.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(161, 295);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 39);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(450, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Subtotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Discount Percent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total";
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(304, 295);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(108, 41);
            this.btnClearTotals.TabIndex = 10;
            this.btnClearTotals.Text = "Clear Total";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(614, 60);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.ReadOnly = true;
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(100, 29);
            this.txtNumberOfInvoices.TabIndex = 11;
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(614, 117);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.ReadOnly = true;
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(100, 29);
            this.txtTotalOfInvoices.TabIndex = 12;
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Location = new System.Drawing.Point(614, 175);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(100, 29);
            this.txtInvoiceAverage.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "# Of Invoices";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total of Invoices";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Invoices average";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

