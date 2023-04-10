namespace SMS
{
    partial class generateBill
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
            this.com_design = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDesignId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qnt = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactSearch = new System.Windows.Forms.MaskedTextBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.com_cust = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_grand_total = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_amt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_design
            // 
            this.com_design.FormattingEnabled = true;
            this.com_design.Location = new System.Drawing.Point(200, 44);
            this.com_design.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_design.Name = "com_design";
            this.com_design.Size = new System.Drawing.Size(252, 33);
            this.com_design.TabIndex = 0;
            this.com_design.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "select Design name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDesignId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_qnt);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.com_design);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(55, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(479, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Designs";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDesignId
            // 
            this.txtDesignId.Location = new System.Drawing.Point(200, 87);
            this.txtDesignId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesignId.Name = "txtDesignId";
            this.txtDesignId.Size = new System.Drawing.Size(252, 31);
            this.txtDesignId.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 28);
            this.label6.TabIndex = 48;
            this.label6.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Design";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 309);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(200, 232);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(263, 31);
            this.txt_total.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 237);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // txt_qnt
            // 
            this.txt_qnt.Location = new System.Drawing.Point(200, 182);
            this.txt_qnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_qnt.Name = "txt_qnt";
            this.txt_qnt.Size = new System.Drawing.Size(124, 31);
            this.txt_qnt.TabIndex = 3;
            this.txt_qnt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(200, 131);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(124, 31);
            this.txt_price.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtContactSearch);
            this.groupBox2.Controls.Add(this.txtCustId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.com_cust);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(628, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(436, 286);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 28);
            this.label5.TabIndex = 47;
            this.label5.Text = "Contact Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtContactSearch
            // 
            this.txtContactSearch.Location = new System.Drawing.Point(202, 114);
            this.txtContactSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContactSearch.Mask = "9990009999";
            this.txtContactSearch.Name = "txtContactSearch";
            this.txtContactSearch.Size = new System.Drawing.Size(181, 31);
            this.txtContactSearch.TabIndex = 46;
            this.txtContactSearch.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtContactSearch_MaskInputRejected);
            this.txtContactSearch.TextChanged += new System.EventHandler(this.txtContactSearch_TextChanged);
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(200, 181);
            this.txtCustId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(183, 31);
            this.txtCustId.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 229);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 36);
            this.button5.TabIndex = 18;
            this.button5.Text = "Add new Customer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // com_cust
            // 
            this.com_cust.FormattingEnabled = true;
            this.com_cust.Location = new System.Drawing.Point(200, 44);
            this.com_cust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_cust.Name = "com_cust";
            this.com_cust.Size = new System.Drawing.Size(183, 33);
            this.com_cust.TabIndex = 0;
            this.com_cust.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "select cutomer name";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(55, 473);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1008, 249);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(824, 741);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Grand Total";
            // 
            // txt_grand_total
            // 
            this.txt_grand_total.Enabled = false;
            this.txt_grand_total.Location = new System.Drawing.Point(960, 736);
            this.txt_grand_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_grand_total.Name = "txt_grand_total";
            this.txt_grand_total.Size = new System.Drawing.Size(103, 31);
            this.txt_grand_total.TabIndex = 10;
            this.txt_grand_total.Text = "0";
            this.txt_grand_total.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_discount
            // 
            this.txt_discount.Enabled = false;
            this.txt_discount.Location = new System.Drawing.Point(960, 780);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(103, 31);
            this.txt_discount.TabIndex = 14;
            this.txt_discount.Text = "0";
            this.txt_discount.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(824, 784);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Discount";
            // 
            // txt_amt
            // 
            this.txt_amt.Enabled = false;
            this.txt_amt.Location = new System.Drawing.Point(960, 823);
            this.txt_amt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_amt.Name = "txt_amt";
            this.txt_amt.Size = new System.Drawing.Size(103, 31);
            this.txt_amt.TabIndex = 16;
            this.txt_amt.Text = "0";
            this.txt_amt.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(824, 828);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "Payabel Amount";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(828, 867);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "Generate Bill";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(270, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 31);
            this.txtId.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(66, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 28);
            this.label14.TabIndex = 22;
            this.label14.Text = "Id";
            // 
            // generateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 922);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_amt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_grand_total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "generateBill";
            this.Text = "generateBill";
            this.Load += new System.EventHandler(this.generateBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_design;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_qnt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox com_cust;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_grand_total;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_amt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private TextBox txtId;
        private Label label14;
        private Button button1;
        private Button button5;
        private TextBox txtCustId;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtContactSearch;
        private TextBox txtDesignId;
        private Label label6;
    }
}