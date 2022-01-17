
namespace Loans
{
    partial class Small
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Small));
            this.txtAmountOfLoan = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtfReceipt = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.PictureBox();
            this.receiptBtn = new System.Windows.Forms.PictureBox();
            this.resetBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.calculateBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmountOfLoan
            // 
            this.txtAmountOfLoan.Location = new System.Drawing.Point(142, 122);
            this.txtAmountOfLoan.Name = "txtAmountOfLoan";
            this.txtAmountOfLoan.Size = new System.Drawing.Size(303, 20);
            this.txtAmountOfLoan.TabIndex = 0;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Location = new System.Drawing.Point(142, 193);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(303, 20);
            this.txtNumberOfYears.TabIndex = 1;
            this.txtNumberOfYears.TextChanged += new System.EventHandler(this.txtNumberOfYears_TextChanged);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(142, 261);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(303, 20);
            this.txtInterestRate.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1309, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Monthly Payment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Period";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Payment";
            // 
            // rtfReceipt
            // 
            this.rtfReceipt.Location = new System.Drawing.Point(722, 70);
            this.rtfReceipt.Name = "rtfReceipt";
            this.rtfReceipt.Size = new System.Drawing.Size(465, 342);
            this.rtfReceipt.TabIndex = 14;
            this.rtfReceipt.Text = "";
            this.rtfReceipt.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gateway Technologies";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(142, 322);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(303, 26);
            this.lblMonthlyPayment.TabIndex = 16;
            this.lblMonthlyPayment.Click += new System.EventHandler(this.lblMonthlyPayment_Click);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPayment.Location = new System.Drawing.Point(139, 386);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(306, 26);
            this.lblTotalPayment.TabIndex = 17;
            this.lblTotalPayment.Click += new System.EventHandler(this.lblTotalPayment_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Image = ((System.Drawing.Image)(resources.GetObject("calculateBtn.Image")));
            this.calculateBtn.Location = new System.Drawing.Point(142, 426);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(59, 62);
            this.calculateBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.calculateBtn.TabIndex = 18;
            this.calculateBtn.TabStop = false;
            this.calculateBtn.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // receiptBtn
            // 
            this.receiptBtn.Image = ((System.Drawing.Image)(resources.GetObject("receiptBtn.Image")));
            this.receiptBtn.Location = new System.Drawing.Point(264, 426);
            this.receiptBtn.Name = "receiptBtn";
            this.receiptBtn.Size = new System.Drawing.Size(55, 67);
            this.receiptBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.receiptBtn.TabIndex = 19;
            this.receiptBtn.TabStop = false;
            this.receiptBtn.Click += new System.EventHandler(this.receiptBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.Image")));
            this.resetBtn.Location = new System.Drawing.Point(388, 426);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(57, 62);
            this.resetBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resetBtn.TabIndex = 20;
            this.resetBtn.TabStop = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Small
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 500);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.receiptBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtfReceipt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtAmountOfLoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Small";
            this.Text = "Small";
            this.Load += new System.EventHandler(this.Small_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calculateBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmountOfLoan;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtfReceipt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.PictureBox calculateBtn;
        private System.Windows.Forms.PictureBox receiptBtn;
        private System.Windows.Forms.PictureBox resetBtn;
    }
}