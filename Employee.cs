using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invitation_Project
{
    public partial class Employee : Form
    {
        int role;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=SPIRIT-SOLUTION\\SQLEXPRESS;Initial Catalog=Invitation_Project;Integrated Security=True");
        SqlDataReader dr;
        public Employee()
        {
            role = 0;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

            con.Close();
            con.Open();
            cmd = new SqlCommand("select * from tblEmployee inner join tbl_auth on tbl_auth.user_id = tblEmployee.id where tbl_auth.username = @username", con);
            cmd.Parameters.AddWithValue("@username", UserData.username);
            dr = cmd.ExecuteReader();
            dr.Read();

            UserData.role = dr.GetInt32(7);

            if (UserData.role < 3)
            {
                employeeToolStripMenuItem.Visible = false;
                employeeToolStripMenuItem.Enabled = false;
            }


            con.Close();

            initial_stage();
            autoId();
            loadGridView();
            lblUsername.Text = UserData.username;
        }
            private void all_clear()
            {
                initial_stage();
                autoId();
                txtAddress.Clear();
                txtConNum.Clear();
            txt_salary.Clear();
                txtEmail.Clear();
                txtName.Clear();
            txt_username.Clear();
            txt_date.Text = DateTime.Now.ToString();
                
                //throw new NotImplementedException();
            }
        private void initial_stage()
        {
            btn_new.Enabled = true;
            btn_save.Enabled = true;
            btn_reset.Enabled = true;
            btn_Fill.Enabled = false;
            btn_delete.Enabled = false;
            btnSearch.Enabled = true;
            btn_update.Enabled = false;
            btn_save.Enabled = false;
            txt_date.Text = DateTime.Now.ToString();
            //throw new NotImplementedException();

            txtId.Enabled = false;
        }
        private void loadGridView()
        {
            clearSearch();
            con.Close();
            con.Open();
            cmd = new SqlCommand("select * from tblEmployee", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
            //throw new NotImplementedException();
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            all_clear();
            initial_stage();
            btn_save.Enabled = true;
            txt_username.Enabled = true;
        }
        private void autoId()
        {
            int num = 0;
            con.Close();
            con.Open();
            try
            {
                cmd = new SqlCommand("Select MAX(id) from tblEmployee", con);
                num = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                num = 0;
            }
            txtId.Text = (num + 1).ToString();
            con.Close();
            // throw new NotImplementedException();
        }

        private void clearSearch()
        {
            txtIdSearch.Clear();
            txtContactSearch.Clear();
            //throw new NotImplementedException();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            con.Close();
            con.Open();
            cmd = new SqlCommand("select * from tbl_auth where username = @username", con);
            cmd.Parameters.AddWithValue("@username" , txt_username.Text);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("duplicate Username");
                return;
            }
            
            con.Close();
            con.Open();
            cmd = new SqlCommand("insert into tblEmployee values(@name , @con_no , @email , @address , @date , @salary ,@role)", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@con_no", Convert.ToInt64(txtConNum.Text));
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@date" , txt_date.Value.ToString());
            cmd.Parameters.AddWithValue("@salary", txt_salary.Text);
            cmd.Parameters.AddWithValue("@role", role);
            //   try
            // {

            int num = cmd.ExecuteNonQuery();
            //MessageBox.Show(num.ToString());
            if (num <= 0)
            {

                MessageBox.Show("Something wrong");
            }
            else
            {
                con.Close();
                con.Open();
                cmd = new SqlCommand("insert into tbl_auth values(@username , 'password',@user_id)" , con);
                cmd.Parameters.AddWithValue("@user_id" , txtId.Text);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                loadGridView();
                all_clear();
            }
            //}
            /*     catch (Exception ex)
                 {
                     MessageBox.Show("Something wrong Exception");
                 }
            */
            con.Close();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            cmd = new SqlCommand("update tblCust set name = @name , con_no = @con_no , email = @email , address = @address , salary = @salary  , date = @date , role = @role  where id = @emp_id;", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@con_no", Convert.ToInt64(txtConNum.Text));
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@date", txt_date.Value.ToString());
            cmd.Parameters.AddWithValue("@salary", txt_salary.Text);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@emp_id" , txtId.Text);
            int n = cmd.ExecuteNonQuery();
            if (n < 0)
            {
                MessageBox.Show("Something Wrong");
            }
            else
            {
                loadGridView();
                all_clear();
                MessageBox.Show("Updated");
            }

        }

        private void btn_Fill_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            btnSearch.Enabled = true;

            con.Close();
            con.Open();
            cmd = new SqlCommand("select * from tblCust where id = @emp_id", con);
            cmd.Parameters.AddWithValue("@emp_id", Convert.ToInt32(txtId.Text));
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtName.Text = dr.GetString(1);
                txtConNum.Text = dr.GetInt64(2).ToString();
                txtEmail.Text = dr.GetString(3);
                txtAddress.Text = dr.GetString(4);
                txt_date.Value = dr.GetDateTime(5);
                txt_salary.Text = dr.GetInt32(6).ToString();
                int temp = dr.GetInt32(7);
                if(temp == 0)
                {
                    rad_staff.Checked = true;
                }
                else
                {
                    rad_des.Checked= true;
                }

                con.Close();
                con.Open();
                cmd = new SqlCommand("select username from tbl_auth where user_id = @user_id", con);
                cmd.Parameters.AddWithValue("@user_id" , txtId.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows) { 
                txt_username.Text = dr.GetString(0);
                }
                con.Close();

                btn_delete.Enabled = true;
                btn_update.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO record Found");
            }
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void txtIdSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtIdSearch.Text != "")
            {
                con.Close();
                con.Open();
                cmd = new SqlCommand("select * from tblEmployeewhere id = @emp_id;", con);
                cmd.Parameters.AddWithValue("@emp_id", int.Parse(txtIdSearch.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                loadGridView();
            }
        }

        private void txtContactSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (txtContactSearch.Text.Length == 10)
            {
                con.Close();
                con.Open();
                cmd = new SqlCommand("select * from tblEmployeewhere con_no = @con_no;", con);
                cmd.Parameters.AddWithValue("@con_no", Convert.ToInt64(txtContactSearch.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                loadGridView();
            }
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Use the Graphics object to draw the DataGridView onto the page
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            this.dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {// Create a PrintDocument object
            PrintDocument printDoc = new PrintDocument();

            // Set the PrintPage event handler
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

            // Define the PrintPage event handler


            // Preview or print the DataGridView using the PrintPreviewDialog or PrintDialog
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDoc;
            printPreviewDialog.ShowDialog();


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            cmd = new SqlCommand("delete from tblEmployee where id = @emp_id", con);
            cmd.Parameters.AddWithValue("@emp_id", Convert.ToInt32(txtId.Text));
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Deleted Successfully");
                loadGridView();
            }
            else
            {
                MessageBox.Show("Something went wrong .");
            }
            con.Close();

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.DestroyHandle();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtId.Clear();
            btn_Fill.Enabled = true;
            btn_new.Enabled = false;
            btn_save.Enabled = false;
            txt_username.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void rad_staff_CheckedChanged(object sender, EventArgs e)
        {
            role = 0;
        }

        private void rad_des_CheckedChanged(object sender, EventArgs e)
        {
            role = 1;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            all_clear();    
        }

        private void txtConNum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtConNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
