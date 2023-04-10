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
    public partial class design : Form
    {
        bool cat_loaded = false;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=SPIRIT-SOLUTION\\SQLEXPRESS;Initial Catalog=Invitation_Project;Integrated Security=True");
        SqlDataReader dr;

        public design()
        {
            InitializeComponent();
        }

        private void design_Load(object sender, EventArgs e)
        {
            bind_cat();
            initial_stage();
            loadGridView();
            lblUsername.Text = UserData.username;
            autoId();

            if(UserData.role == 1)
            {
                btn_new.Visible = false;
                btn_save.Visible = false;
            }
        }
        private void loadGridView()
        {
            clearSearch();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select tblDesign.id , tblDesign.name , tblDesign.date ,tblDesign.price, tblCat.name as 'Category Name' , tblEmployee.name as 'Employee Name' from tblDesign inner join tblCat on tblCat.id = tblDesign.cat_id inner join tblEmployee on  tblEmployee.id = tblDesign.user_id", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
            //throw new NotImplementedException();
        }

        private void clearSearch()
        {
            txtId.Clear();
           
           // throw new NotImplementedException();
        }

        private void autoId()
        {
            int num = 0;
            con.Close();
            con.Open();
            try
            {
                cmd = new SqlCommand("Select MAX(id) from tblDesign", con);
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

        private void initial_stage()
        {
            txt_cat.Visible = false;
            com_cat.Visible = true;
            btn_cat_save.Enabled = false;
            btn_new.Enabled = true;
            btn_save.Enabled = true;
            btn_reset.Enabled = true;
            btn_Fill.Enabled = false;
            btn_delete.Enabled = false;
            btnSearch.Enabled = true;
            btn_update.Enabled = false;
            btn_save.Enabled = false;
            txt_date.Text = DateTime.Now.ToString();
            btn_clear_cat.Enabled = true;
            btn_cat_add.Enabled = true;
            //throw new NotImplementedException();

            txtId.Enabled = false;
        }
        private void bind_cat()
        {
            cat_loaded = false;
            con.Close();
            con.Open();
            cmd = new SqlCommand("select * from tblCat", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            com_cat.DataSource = dt;
            com_cat.ValueMember = "id";
            com_cat.DisplayMember = "name";

            com_cat_search.DataSource = dt;
            com_cat_search.ValueMember = "id";
            com_cat_search.DisplayMember = "name";
            con.Close();
            //throw new NotImplementedException();

            com_cat.Text = null;
            com_cat_search.Text = null;
            cat_loaded= true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void designsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            design d = new design();
            d.Show();
            this.Close();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee ex = new Employee();
            ex.Show();
            this.Close();
        }

        private void com_city_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            all_clear();
            initial_stage();
            autoId();
            btn_save.Enabled = true;
        }

        private void all_clear()
        {
            initial_stage();
            autoId();
            txtDesc.Clear();
            txtName.Clear();
            bind_cat();
            
            txt_date.Text = DateTime.Now.ToString();

            //throw new NotImplementedException();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtId.Clear();
            btn_Fill.Enabled = true;
            btn_new.Enabled = false;
            btn_save.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void btn_Fill_Click(object sender, EventArgs e)
        {
            btn_new.Enabled=true;
            btn_cat_add.Enabled=false;
            btn_clear_cat.Enabled=false;
            txtId.Enabled = false;
            btnSearch.Enabled = true;

            con.Close();
            con.Open();
            cmd = new SqlCommand("select * from tblDesign where id = @d_id", con);
            cmd.Parameters.AddWithValue("@d_id", Convert.ToInt32(txtId.Text));
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtName.Text = dr.GetString(1);
                txtDesc.Text = dr.GetString(2);
                txt_date.Value = dr.GetDateTime(3);
                com_cat.SelectedValue= dr.GetInt32(4);
                txt_price.Text = dr.GetInt32(6).ToString();

                con.Close();
                con.Open();

                btn_delete.Enabled = true;
                btn_update.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO record Found");
            }
            con.Close();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            all_clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            cmd = new SqlCommand("delete from tblDesign where id = @d_id", con);
            cmd.Parameters.AddWithValue("@d_id", Convert.ToInt32(txtId.Text));
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = new SqlCommand("insert into tblDesign values(@name , @desc, @date, @cat_id , @user_id , @price)", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@price", txt_price.Text);
            cmd.Parameters.AddWithValue("@desc" , txtDesc.Text);
            cmd.Parameters.AddWithValue("@date" , txt_date.Value.ToString());
            cmd.Parameters.AddWithValue("@cat_id", com_cat.SelectedValue);
            cmd.Parameters.AddWithValue("user_id", UserData.user_id);
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
                loadGridView();
                all_clear();
            }
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            cmd = new SqlCommand("update tblDesign set name = @name , description = @desc, date = @date, cat_id = @cat_id , price = @price;", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@price", txt_price.Text);
            cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
            cmd.Parameters.AddWithValue("@date", txt_date.Value.ToString());
            cmd.Parameters.AddWithValue("@cat_id", com_cat.SelectedValue);

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
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Use the Graphics object to draw the DataGridView onto the page
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            this.dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
           // Create a PrintDocument object
            PrintDocument printDoc = new PrintDocument();

            // Set the PrintPage event handler
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

            // Define the PrintPage event handler


            // Preview or print the DataGridView using the PrintPreviewDialog or PrintDialog
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDoc;
            printPreviewDialog.ShowDialog();

        }

        private void btn_cat_add_Click(object sender, EventArgs e)
        {
            com_cat.Visible = false;
            txt_cat.Visible = true;
            txt_cat.Clear();
            btn_cat_save.Enabled = true;
            btn_save.Enabled = false;
        }

        private void btn_cat_save_Click(object sender, EventArgs e)
        {

            con.Close();
            con.Open();
            cmd = new SqlCommand("insert into tblCat values(@name)", con);
            cmd.Parameters.AddWithValue("@name", txt_cat.Text);
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
                bind_cat();
                txt_cat.Visible = false;
                com_cat.Visible = true;
                btn_cat_save.Enabled = false;
                btn_cat_add.Enabled = true;
                btn_save.Enabled = true;
            }
            con.Close();

        }

        private void com_cat_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cat_loaded)
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select tblDesign.id , tblDesign.name , tblDesign.date , tblDesign.price , tblCat.name as 'Category Name' , tblEmployee.name as 'Employee Name' from tblDesign inner join tblCat on tblCat.id = tblDesign.cat_id inner join tblEmployee on tblEmployee.id = tblDesign.user_id where tblDesign.cat_id = @cat_id", con);
                cmd.Parameters.AddWithValue("@cat_id", com_cat_search.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void btn_clear_cat_Click(object sender, EventArgs e)
        {
            txt_cat.Visible = false;
            com_cat.Visible = true;
            btn_cat_add.Enabled=true;
            btn_cat_save.Enabled=false;
            btn_save.Enabled = true;
        }

        private void btn_clear_search_Click(object sender, EventArgs e)
        {
            txtIdSearch.Text = null;
            cat_loaded= false;
            com_cat_search.Text = null;
            cat_loaded = true;

            loadGridView();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order op = new order();
            op.Show();
            this.Close();
        }

        private void txt_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtIdSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txt_cat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
