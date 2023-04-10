namespace Invitation_Project
{
    partial class design
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdSearch = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_Fill = new System.Windows.Forms.Button();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.designsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_clear_search = new System.Windows.Forms.Button();
            this.btn_clear_cat = new System.Windows.Forms.Button();
            this.com_cat_search = new System.Windows.Forms.ComboBox();
            this.txt_cat = new System.Windows.Forms.TextBox();
            this.btn_cat_add = new System.Windows.Forms.Button();
            this.btn_cat_save = new System.Windows.Forms.Button();
            this.com_cat = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(603, 149);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(169, 23);
            this.txt_date.TabIndex = 49;
            this.txt_date.ValueChanged += new System.EventHandler(this.txt_date_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(467, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 17);
            this.label14.TabIndex = 48;
            this.label14.Text = "Creation  Date";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(157, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Category";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(45, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Id";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtIdSearch
            // 
            this.txtIdSearch.Location = new System.Drawing.Point(45, 360);
            this.txtIdSearch.Name = "txtIdSearch";
            this.txtIdSearch.Size = new System.Drawing.Size(89, 23);
            this.txtIdSearch.TabIndex = 42;
            this.txtIdSearch.TextChanged += new System.EventHandler(this.txtIdSearch_TextChanged);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(767, 354);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(69, 29);
            this.btn_print.TabIndex = 41;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_Fill
            // 
            this.btn_Fill.Location = new System.Drawing.Point(364, 96);
            this.btn_Fill.Name = "btn_Fill";
            this.btn_Fill.Size = new System.Drawing.Size(58, 33);
            this.btn_Fill.TabIndex = 40;
            this.btn_Fill.Text = "Fill";
            this.btn_Fill.UseVisualStyleBackColor = true;
            this.btn_Fill.Click += new System.EventHandler(this.btn_Fill_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Font = new System.Drawing.Font("Daddy Rewind", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(62, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Brush Script MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(88, 170);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(49, 29);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "User";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 98);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // designsToolStripMenuItem
            // 
            this.designsToolStripMenuItem.Name = "designsToolStripMenuItem";
            this.designsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.designsToolStripMenuItem.Text = "Designs";
            this.designsToolStripMenuItem.Click += new System.EventHandler(this.designsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 631);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Brush Script MT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 46);
            this.label7.TabIndex = 5;
            this.label7.Text = "WelCome,";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(238, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 242);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.employeeToolStripMenuItem.Text = "Employee / Designers";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_clear_search);
            this.panel2.Controls.Add(this.btn_clear_cat);
            this.panel2.Controls.Add(this.com_cat_search);
            this.panel2.Controls.Add(this.txt_cat);
            this.panel2.Controls.Add(this.btn_cat_add);
            this.panel2.Controls.Add(this.btn_cat_save);
            this.panel2.Controls.Add(this.com_cat);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_date);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtIdSearch);
            this.panel2.Controls.Add(this.btn_print);
            this.panel2.Controls.Add(this.btn_Fill);
            this.panel2.Controls.Add(this.txtDesc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(238, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 389);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(205, 246);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(169, 23);
            this.txt_price.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(62, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Price";
            // 
            // btn_clear_search
            // 
            this.btn_clear_search.Location = new System.Drawing.Point(360, 356);
            this.btn_clear_search.Name = "btn_clear_search";
            this.btn_clear_search.Size = new System.Drawing.Size(100, 29);
            this.btn_clear_search.TabIndex = 57;
            this.btn_clear_search.Text = "clear Search";
            this.btn_clear_search.UseVisualStyleBackColor = true;
            this.btn_clear_search.Click += new System.EventHandler(this.btn_clear_search_Click);
            // 
            // btn_clear_cat
            // 
            this.btn_clear_cat.Location = new System.Drawing.Point(503, 202);
            this.btn_clear_cat.Name = "btn_clear_cat";
            this.btn_clear_cat.Size = new System.Drawing.Size(55, 29);
            this.btn_clear_cat.TabIndex = 56;
            this.btn_clear_cat.Text = "Clear";
            this.btn_clear_cat.UseVisualStyleBackColor = true;
            this.btn_clear_cat.Click += new System.EventHandler(this.btn_clear_cat_Click);
            // 
            // com_cat_search
            // 
            this.com_cat_search.FormattingEnabled = true;
            this.com_cat_search.Location = new System.Drawing.Point(157, 360);
            this.com_cat_search.Name = "com_cat_search";
            this.com_cat_search.Size = new System.Drawing.Size(169, 23);
            this.com_cat_search.TabIndex = 55;
            this.com_cat_search.SelectedIndexChanged += new System.EventHandler(this.com_cat_search_SelectedIndexChanged);
            // 
            // txt_cat
            // 
            this.txt_cat.Location = new System.Drawing.Point(205, 206);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.Size = new System.Drawing.Size(169, 23);
            this.txt_cat.TabIndex = 54;
            this.txt_cat.TextChanged += new System.EventHandler(this.txt_cat_TextChanged);
            // 
            // btn_cat_add
            // 
            this.btn_cat_add.Location = new System.Drawing.Point(381, 202);
            this.btn_cat_add.Name = "btn_cat_add";
            this.btn_cat_add.Size = new System.Drawing.Size(51, 29);
            this.btn_cat_add.TabIndex = 53;
            this.btn_cat_add.Text = "add";
            this.btn_cat_add.UseVisualStyleBackColor = true;
            this.btn_cat_add.Click += new System.EventHandler(this.btn_cat_add_Click);
            // 
            // btn_cat_save
            // 
            this.btn_cat_save.Location = new System.Drawing.Point(442, 202);
            this.btn_cat_save.Name = "btn_cat_save";
            this.btn_cat_save.Size = new System.Drawing.Size(55, 29);
            this.btn_cat_save.TabIndex = 52;
            this.btn_cat_save.Text = "Save";
            this.btn_cat_save.UseVisualStyleBackColor = true;
            this.btn_cat_save.Click += new System.EventHandler(this.btn_cat_save_Click);
            // 
            // com_cat
            // 
            this.com_cat.FormattingEnabled = true;
            this.com_cat.Location = new System.Drawing.Point(205, 206);
            this.com_cat.Name = "com_cat";
            this.com_cat.Size = new System.Drawing.Size(169, 23);
            this.com_cat.TabIndex = 51;
            this.com_cat.SelectedIndexChanged += new System.EventHandler(this.com_city_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(62, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "Category";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(601, 86);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(174, 60);
            this.txtDesc.TabIndex = 39;
            this.txtDesc.Text = "";
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(467, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Description";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(308, 295);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 40);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(300, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 33);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(45, 295);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(69, 40);
            this.btn_new.TabIndex = 24;
            this.btn_new.Text = "new";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(205, 133);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 23);
            this.txtName.TabIndex = 23;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(205, 99);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(89, 23);
            this.txtId.TabIndex = 21;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Design Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(706, 286);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(69, 40);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(216, 295);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(69, 40);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(131, 295);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(69, 40);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.designsToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "design";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "design";
            this.Load += new System.EventHandler(this.design_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DateTimePicker txt_date;
        private Label label14;
        private Label label12;
        private Label label6;
        private TextBox txtIdSearch;
        private Button btn_print;
        private Button btn_Fill;
        private ToolStripMenuItem orderToolStripMenuItem;
        private Button btnClose;
        private Label lblUsername;
        private PictureBox pictureBox1;
        private ToolStripMenuItem designsToolStripMenuItem;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView1;
        private ToolStripMenuItem addEmployeeToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem addCustomerToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private Panel panel2;
        private Button btn_delete;
        private Button btnSearch;
        private Button btn_new;
        private TextBox txtName;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private Button btn_reset;
        private Button btn_update;
        private Button btn_save;
        private MenuStrip menuStrip1;
        private RichTextBox txtDesc;
        private Label label8;
        private ComboBox com_cat;
        private Label label11;
        private Button btn_cat_add;
        private Button btn_cat_save;
        private TextBox txt_cat;
        private ComboBox com_cat_search;
        private Button btn_clear_cat;
        private Button btn_clear_search;
        private TextBox txt_price;
        private Label label4;
    }
}