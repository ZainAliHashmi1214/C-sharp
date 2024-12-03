namespace Pos
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnClearEntries = new Button();
            btnAddItem = new Button();
            cmbSupplier = new Label();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            txtPurchasingOrderNo = new Label();
            textBox6 = new TextBox();
            txtMRP = new Label();
            textBox5 = new TextBox();
            txtPurchasingValue = new Label();
            textBox4 = new TextBox();
            txtPurchasingQuantity = new Label();
            textBox3 = new TextBox();
            txtDescription = new Label();
            textBox2 = new TextBox();
            txtPurchasingPrice = new Label();
            btntextbox1 = new TextBox();
            txtItemCode = new Label();
            dataGridView1 = new DataGridView();
            btnVeiwStock = new Button();
            btnPrintStock = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            removeItemToolStripMenuItem = new ToolStripMenuItem();
            fullScreenViewToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lblStockCount = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lblStcokValue = new Label();
            label4 = new Label();
            btnPurchasingSummery = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(btnClearEntries);
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(cmbSupplier);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(txtPurchasingOrderNo);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(txtMRP);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(txtPurchasingValue);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(txtPurchasingQuantity);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(txtPurchasingPrice);
            panel1.Controls.Add(btntextbox1);
            panel1.Controls.Add(txtItemCode);
            panel1.Location = new Point(23, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 727);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // btnClearEntries
            // 
            btnClearEntries.BackColor = Color.FromArgb(255, 192, 128);
            btnClearEntries.FlatStyle = FlatStyle.Flat;
            btnClearEntries.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearEntries.ForeColor = Color.White;
            btnClearEntries.Image = Properties.Resources.add;
            btnClearEntries.Location = new Point(160, 625);
            btnClearEntries.Name = "btnClearEntries";
            btnClearEntries.Size = new Size(120, 72);
            btnClearEntries.TabIndex = 10;
            btnClearEntries.Text = "Remove item:";
            btnClearEntries.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClearEntries.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(128, 64, 0);
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Image = Properties.Resources.add;
            btnAddItem.Location = new Point(33, 625);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(120, 72);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "Add Item:";
            btnAddItem.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddItem.UseVisualStyleBackColor = false;
            // 
            // cmbSupplier
            // 
            cmbSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbSupplier.AutoSize = true;
            cmbSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSupplier.Location = new Point(33, 548);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(90, 28);
            cmbSupplier.TabIndex = 15;
            cmbSupplier.Text = "Supplier";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 579);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 28);
            comboBox1.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(35, 511);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(245, 34);
            textBox7.TabIndex = 7;
            // 
            // txtPurchasingOrderNo
            // 
            txtPurchasingOrderNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPurchasingOrderNo.AutoSize = true;
            txtPurchasingOrderNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPurchasingOrderNo.Location = new Point(35, 480);
            txtPurchasingOrderNo.Name = "txtPurchasingOrderNo";
            txtPurchasingOrderNo.Size = new Size(252, 28);
            txtPurchasingOrderNo.TabIndex = 12;
            txtPurchasingOrderNo.Text = "Purchasing order number";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(33, 428);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(245, 34);
            textBox6.TabIndex = 6;
            // 
            // txtMRP
            // 
            txtMRP.AutoSize = true;
            txtMRP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMRP.Location = new Point(35, 397);
            txtMRP.Name = "txtMRP";
            txtMRP.Size = new Size(56, 28);
            txtMRP.TabIndex = 10;
            txtMRP.Text = "MRP";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(35, 267);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 34);
            textBox5.TabIndex = 4;
            // 
            // txtPurchasingValue
            // 
            txtPurchasingValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPurchasingValue.AutoSize = true;
            txtPurchasingValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPurchasingValue.Location = new Point(35, 316);
            txtPurchasingValue.Name = "txtPurchasingValue";
            txtPurchasingValue.Size = new Size(154, 28);
            txtPurchasingValue.TabIndex = 8;
            txtPurchasingValue.Text = "Purchase Value";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(35, 347);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 34);
            textBox4.TabIndex = 5;
            // 
            // txtPurchasingQuantity
            // 
            txtPurchasingQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPurchasingQuantity.AutoSize = true;
            txtPurchasingQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPurchasingQuantity.Location = new Point(35, 236);
            txtPurchasingQuantity.Name = "txtPurchasingQuantity";
            txtPurchasingQuantity.Size = new Size(205, 28);
            txtPurchasingQuantity.TabIndex = 6;
            txtPurchasingQuantity.Text = "Purchasing Quantity";
            txtPurchasingQuantity.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(35, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 34);
            textBox3.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDescription.AutoSize = true;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(33, 80);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(121, 28);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(35, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 34);
            textBox2.TabIndex = 3;
            // 
            // txtPurchasingPrice
            // 
            txtPurchasingPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPurchasingPrice.AutoSize = true;
            txtPurchasingPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPurchasingPrice.Location = new Point(33, 157);
            txtPurchasingPrice.Name = "txtPurchasingPrice";
            txtPurchasingPrice.Size = new Size(169, 28);
            txtPurchasingPrice.TabIndex = 2;
            txtPurchasingPrice.Text = "Purchasing Price";
            // 
            // btntextbox1
            // 
            btntextbox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btntextbox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntextbox1.Location = new Point(33, 43);
            btntextbox1.Name = "btntextbox1";
            btntextbox1.Size = new Size(245, 34);
            btntextbox1.TabIndex = 1;
            // 
            // txtItemCode
            // 
            txtItemCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItemCode.AutoSize = true;
            txtItemCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtItemCode.Location = new Point(35, 12);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new Size(113, 28);
            txtItemCode.TabIndex = 0;
            txtItemCode.Text = "Item Code:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(345, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(970, 553);
            dataGridView1.TabIndex = 14;
            // 
            // btnVeiwStock
            // 
            btnVeiwStock.BackColor = Color.FromArgb(66, 74, 94);
            btnVeiwStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVeiwStock.Image = Properties.Resources.report;
            btnVeiwStock.Location = new Point(345, 620);
            btnVeiwStock.Name = "btnVeiwStock";
            btnVeiwStock.Size = new Size(139, 114);
            btnVeiwStock.TabIndex = 11;
            btnVeiwStock.Text = "View All Item";
            btnVeiwStock.UseVisualStyleBackColor = false;
            // 
            // btnPrintStock
            // 
            btnPrintStock.BackColor = Color.FromArgb(66, 76, 94);
            btnPrintStock.FlatAppearance.BorderSize = 0;
            btnPrintStock.FlatStyle = FlatStyle.Flat;
            btnPrintStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintStock.Image = Properties.Resources.printer;
            btnPrintStock.Location = new Point(490, 620);
            btnPrintStock.Name = "btnPrintStock";
            btnPrintStock.Size = new Size(139, 114);
            btnPrintStock.TabIndex = 12;
            btnPrintStock.Text = "Print Stock Balance";
            btnPrintStock.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { removeItemToolStripMenuItem, fullScreenViewToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 52);
            // 
            // removeItemToolStripMenuItem
            // 
            removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            removeItemToolStripMenuItem.Size = new Size(185, 24);
            removeItemToolStripMenuItem.Text = "Remove Item";
            // 
            // fullScreenViewToolStripMenuItem
            // 
            fullScreenViewToolStripMenuItem.Name = "fullScreenViewToolStripMenuItem";
            fullScreenViewToolStripMenuItem.Size = new Size(185, 24);
            fullScreenViewToolStripMenuItem.Text = "Full Screen View";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(lblStockCount);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(809, 617);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 5;
            // 
            // lblStockCount
            // 
            lblStockCount.AutoSize = true;
            lblStockCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockCount.Location = new Point(34, 57);
            lblStockCount.Name = "lblStockCount";
            lblStockCount.Size = new Size(32, 25);
            lblStockCount.TabIndex = 1;
            lblStockCount.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 0;
            label1.Text = "Stock item Count:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 255);
            panel3.Controls.Add(lblStcokValue);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(1065, 617);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 6;
            // 
            // lblStcokValue
            // 
            lblStcokValue.AutoSize = true;
            lblStcokValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStcokValue.Location = new Point(34, 57);
            lblStcokValue.Name = "lblStcokValue";
            lblStcokValue.Size = new Size(94, 25);
            lblStcokValue.TabIndex = 1;
            lblStcokValue.Text = "RS. 00.00 ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 12);
            label4.Name = "label4";
            label4.Size = new Size(163, 28);
            label4.TabIndex = 0;
            label4.Text = "Purchasing Value:";
            // 
            // btnPurchasingSummery
            // 
            btnPurchasingSummery.BackColor = Color.FromArgb(66, 76, 94);
            btnPurchasingSummery.FlatAppearance.BorderSize = 0;
            btnPurchasingSummery.FlatStyle = FlatStyle.Flat;
            btnPurchasingSummery.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchasingSummery.Image = Properties.Resources.printer;
            btnPurchasingSummery.Location = new Point(635, 620);
            btnPurchasingSummery.Name = "btnPurchasingSummery";
            btnPurchasingSummery.Size = new Size(139, 114);
            btnPurchasingSummery.TabIndex = 13;
            btnPurchasingSummery.Text = "Purchasing Summery";
            btnPurchasingSummery.UseVisualStyleBackColor = false;
            btnPurchasingSummery.Click += btnPurchasingSummery_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 754);
            Controls.Add(btnPurchasingSummery);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnPrintStock);
            Controls.Add(btnVeiwStock);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            MinimumSize = new Size(1100, 801);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txtItemCode;
        private TextBox textBox3;
        private Label txtDescription;
        private TextBox textBox2;
        private Label txtPurchasingPrice;
        private TextBox btntextbox1;
        private TextBox textBox7;
        private Label txtPurchasingOrderNo;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label txtPurchasingValue;
        private TextBox textBox4;
        private Label txtPurchasingQuantity;
        private Label cmbSupplier;
        private ComboBox comboBox1;
        private Button btnAddItem;
        private Button btnClearEntries;
        private Label txtMRP;
        private DataGridView dataGridView1;
        private Button btnVeiwStock;
        private Button btnPrintStock;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem removeItemToolStripMenuItem;
        private ToolStripMenuItem fullScreenViewToolStripMenuItem;
        private Panel panel2;
        private Label label1;
        private Label lblStockCount;
        private Panel panel3;
        private Label lblStcokValue;
        private Label label4;
        private Button btnPurchasingSummery;
    }
}