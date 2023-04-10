namespace Invitation_Project
{
    partial class Employee
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
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContactSearch = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_err = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rad_des = new System.Windows.Forms.RadioButton();
            this.rad_staff = new System.Windows.Forms.RadioButton();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdSearch = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_Fill = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtConNum = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.designsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(157, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Contact Number";
            // 
            // txtContactSearch
            // 
            this.txtContactSearch.Location = new System.Drawing.Point(157, 360);
            this.txtContactSearch.Mask = "9990009999";
            this.txtContactSearch.Name = "txtContactSearch";
            this.txtContactSearch.Size = new System.Drawing.Size(169, 23);
            this.txtContactSearch.TabIndex = 44;
            this.txtContactSearch.TextChanged += new System.EventHandler(this.txtContactSearch_TextChanged_1);
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
            this.dataGridView1.TabIndex = 23;
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.employeeToolStripMenuItem.Text = "Employee / Designers";
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_clear_search);
            this.panel2.Controls.Add(this.lbl_err);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.rad_des);
            this.panel2.Controls.Add(this.rad_staff);
            this.panel2.Controls.Add(this.txt_date);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_salary);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtContactSearch);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtIdSearch);
            this.panel2.Controls.Add(this.btn_print);
            this.panel2.Controls.Add(this.btn_Fill);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtConNum);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
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
            this.panel2.TabIndex = 22;
            // 
            // lbl_err
            // 
            this.lbl_err.AutoSize = true;
            this.lbl_err.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_err.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_err.Location = new System.Drawing.Point(496, 259);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(247, 18);
            this.lbl_err.TabIndex = 24;
            this.lbl_err.Text = "Default Password is password";
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(606, 216);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(169, 23);
            this.txt_username.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(467, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "UserName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(62, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Roles";
            // 
            // rad_des
            // 
            this.rad_des.AutoSize = true;
            this.rad_des.Location = new System.Drawing.Point(303, 260);
            this.rad_des.Name = "rad_des";
            this.rad_des.Size = new System.Drawing.Size(71, 19);
            this.rad_des.TabIndex = 51;
            this.rad_des.Text = "Designer";
            this.rad_des.UseVisualStyleBackColor = true;
            this.rad_des.CheckedChanged += new System.EventHandler(this.rad_des_CheckedChanged);
            // 
            // rad_staff
            // 
            this.rad_staff.AutoSize = true;
            this.rad_staff.Checked = true;
            this.rad_staff.Location = new System.Drawing.Point(214, 260);
            this.rad_staff.Name = "rad_staff";
            this.rad_staff.Size = new System.Drawing.Size(49, 19);
            this.rad_staff.TabIndex = 50;
            this.rad_staff.TabStop = true;
            this.rad_staff.Text = "Staff";
            this.rad_staff.UseVisualStyleBackColor = true;
            this.rad_staff.CheckedChanged += new System.EventHandler(this.rad_staff_CheckedChanged);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(603, 149);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(169, 23);
            this.txt_date.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(467, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 17);
            this.label14.TabIndex = 48;
            this.label14.Text = "Joining Of Date";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(606, 179);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(169, 23);
            this.txt_salary.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(467, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Salary";
            this.label13.Click += new System.EventHandler(this.label13_Click);
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
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(601, 86);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(174, 60);
            this.txtAddress.TabIndex = 39;
            this.txtAddress.Text = "";
            // 
            // txtConNum
            // 
            this.txtConNum.Location = new System.Drawing.Point(205, 178);
            this.txtConNum.Mask = "9990009999";
            this.txtConNum.Name = "txtConNum";
            this.txtConNum.Size = new System.Drawing.Size(169, 23);
            this.txtConNum.TabIndex = 35;
            this.txtConNum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtConNum_MaskInputRejected);
            this.txtConNum.TextChanged += new System.EventHandler(this.txtConNum_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(205, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 23);
            this.txtEmail.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(467, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(62, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(62, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Contact Number";
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
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(205, 99);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(89, 23);
            this.txtId.TabIndex = 21;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Employee Details";
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
            // 
            // designsToolStripMenuItem
            // 
            this.designsToolStripMenuItem.Name = "designsToolStripMenuItem";
            this.designsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.designsToolStripMenuItem.Text = "Designs";
            this.designsToolStripMenuItem.Click += new System.EventHandler(this.designsToolStripMenuItem_Click);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 98);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.panel1.TabIndex = 21;
            // 
            // btn_clear_search
            // 
            this.btn_clear_search.Location = new System.Drawing.Point(346, 354);
            this.btn_clear_search.Name = "btn_clear_search";
            this.btn_clear_search.Size = new System.Drawing.Size(100, 29);
            this.btn_clear_search.TabIndex = 58;
            this.btn_clear_search.Text = "clear Search";
            this.btn_clear_search.UseVisualStyleBackColor = true;
            this.btn_clear_search.Click += new System.EventHandler(this.btn_clear_search_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 633);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStripMenuItem addEmployeeToolStripMenuItem;
        private Label label12;
        private MaskedTextBox txtContactSearch;
        private DataGridView dataGridView1;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem addCustomerToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private Label label6;
        private Panel panel2;
        private TextBox txtIdSearch;
        private Button btn_print;
        private Button btn_Fill;
        private RichTextBox txtAddress;
        private MaskedTextBox txtConNum;
        private TextBox txtEmail;
        private Label label8;
        private Label label5;
        private Label label4;
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
        private ToolStripMenuItem designsToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private Button btnClose;
        private Label lblUsername;
        private PictureBox pictureBox1;
        private Label label7;
        private Panel panel1;
        private TextBox txt_salary;
        private Label label13;
        private Label label14;
        private DateTimePicker txt_date;
        private RadioButton rad_des;
        private RadioButton rad_staff;
        private Label label9;
        private TextBox txt_username;
        private Label label10;
        private Label lbl_err;
        private Button btn_clear_search;
    }
}