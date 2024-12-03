namespace Pos
{
    partial class Work_Station
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
            btnStock = new Button();
            btnPayments = new Button();
            btnInvoice = new Button();
            btnCustomer = new Button();
            btnBusinessDetails = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            lblSalesTodayCredit = new Label();
            label6 = new Label();
            panel3 = new Panel();
            lblSalesToday = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lblSalesCount = new Label();
            label1 = new Label();
            btnRefresh = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnStock.Image = Properties.Resources.packages;
            btnStock.Location = new Point(10, 29);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(131, 108);
            btnStock.TabIndex = 0;
            btnStock.Text = "Stock";
            btnStock.TextAlign = ContentAlignment.BottomCenter;
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnPayments
            // 
            btnPayments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPayments.Image = Properties.Resources.payment_method;
            btnPayments.Location = new Point(421, 29);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(131, 108);
            btnPayments.TabIndex = 2;
            btnPayments.Text = "Payments";
            btnPayments.TextAlign = ContentAlignment.BottomCenter;
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnInvoice
            // 
            btnInvoice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnInvoice.Image = Properties.Resources.invoice;
            btnInvoice.Location = new Point(147, 29);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(131, 108);
            btnInvoice.TabIndex = 1;
            btnInvoice.Text = "invoice";
            btnInvoice.TextAlign = ContentAlignment.BottomCenter;
            btnInvoice.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCustomer.Image = Properties.Resources.rating;
            btnCustomer.Location = new Point(284, 29);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(131, 108);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "Customers";
            btnCustomer.TextAlign = ContentAlignment.BottomCenter;
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnBusinessDetails
            // 
            btnBusinessDetails.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBusinessDetails.Image = Properties.Resources.packages1;
            btnBusinessDetails.Location = new Point(558, 29);
            btnBusinessDetails.Name = "btnBusinessDetails";
            btnBusinessDetails.Size = new Size(131, 108);
            btnBusinessDetails.TabIndex = 4;
            btnBusinessDetails.Text = "Business Details";
            btnBusinessDetails.TextAlign = ContentAlignment.BottomCenter;
            btnBusinessDetails.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(227, 204, 255);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(992, -202);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 979);
            panel1.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(42, 650);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 71);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 1;
            label7.Text = "RS. 00.00.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 34);
            label8.Name = "label8";
            label8.Size = new Size(176, 28);
            label8.TabIndex = 0;
            label8.Text = "Total Sales:(Cash)";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblSalesTodayCredit);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(36, 818);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 2;
            // 
            // lblSalesTodayCredit
            // 
            lblSalesTodayCredit.AutoSize = true;
            lblSalesTodayCredit.BackColor = Color.Black;
            lblSalesTodayCredit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesTodayCredit.Location = new Point(38, 71);
            lblSalesTodayCredit.Name = "lblSalesTodayCredit";
            lblSalesTodayCredit.Size = new Size(94, 25);
            lblSalesTodayCredit.TabIndex = 1;
            lblSalesTodayCredit.Text = "RS. 00.00.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 26);
            label6.Name = "label6";
            label6.Size = new Size(189, 28);
            label6.TabIndex = 0;
            label6.Text = "Total Sales:(Credit)";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblSalesToday);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(42, 506);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 1;
            // 
            // lblSalesToday
            // 
            lblSalesToday.AutoSize = true;
            lblSalesToday.BackColor = Color.Black;
            lblSalesToday.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesToday.Location = new Point(38, 71);
            lblSalesToday.Name = "lblSalesToday";
            lblSalesToday.Size = new Size(94, 25);
            lblSalesToday.TabIndex = 1;
            lblSalesToday.Text = "RS. 00.00.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 26);
            label4.Name = "label4";
            label4.Size = new Size(188, 28);
            label4.TabIndex = 0;
            label4.Text = "Total Sales:(Today)";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblSalesCount);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(42, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 0;
            // 
            // lblSalesCount
            // 
            lblSalesCount.AutoSize = true;
            lblSalesCount.BackColor = Color.Black;
            lblSalesCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesCount.Location = new Point(38, 71);
            lblSalesCount.Name = "lblSalesCount";
            lblSalesCount.Size = new Size(94, 25);
            lblSalesCount.TabIndex = 1;
            lblSalesCount.Text = "RS. 00.00.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 26);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 0;
            label1.Text = " Sales Sales:(Today)";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRefresh.Image = Properties.Resources.exit;
            btnRefresh.Location = new Point(695, 29);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 108);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.BottomCenter;
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExit.Image = Properties.Resources.exit1;
            btnExit.Location = new Point(832, 29);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 108);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Work_Station
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 1055);
            Controls.Add(btnExit);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Controls.Add(btnBusinessDetails);
            Controls.Add(btnCustomer);
            Controls.Add(btnInvoice);
            Controls.Add(btnPayments);
            Controls.Add(btnStock);
            Name = "Work_Station";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Work Station";
            WindowState = FormWindowState.Maximized;
            Load += Work_Station_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStock;
        private Button btnPayments;
        private Button btnInvoice;
        private Button btnCustomer;
        private Button btnBusinessDetails;
        private Panel panel1;
        private Panel panel4;
        private Label lblSalesTodayCredit;
        private Label label6;
        private Panel panel3;
        private Label lblSalesToday;
        private Label label4;
        private Panel panel2;
        private Label lblSalesCount;
        private Label label1;
        private Panel panel5;
        private Label label7;
        private Label label8;
        private Button btnRefresh;
        private Button btnExit;
    }
}