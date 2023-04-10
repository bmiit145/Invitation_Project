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
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=SPIRIT-SOLUTION\\SQLEXPRESS;Initial Catalog=Invitation_Project;Integrated Security=True");
        SqlDataReader dr;
        bool con_loaded = false , state_loaded = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            all_clear();
        }

        private void all_clear()
        {
            initial_stage();
            autoId();
            txtAddress.Clear();
            txtConNum.Clear();
            txtEmail.Clear();
            txtName.Clear();
            loadAllComboBox();
            //throw new NotImplementedException();
        }

        private void loadAllComboBox()
        {
            com_state.Enabled = false;
            com_city.Enabled = false;

            // load country combo box
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from countries", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            com_country.DataSource = dt;
            com_country.ValueMember = "id";
            com_country.DisplayMember = "name";
            con.Close();

            com_city.Text = null; // initial clear display
            com_country.Text = null;
            con_loaded = true;
            //throw new NotImplementedException();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            // check for employee role
            
            con.Close();
            con.Open();
            cmd = new SqlCommand("select * from tblEmployee inner join tbl_auth on tbl_auth.user_id = tblEmployee.id where tbl_auth.username = @username", con);
            cmd.Parameters.AddWithValue("@username", UserData.username);
            dr = cmd.ExecuteReader();
            dr.Read();

            UserData.role = dr.GetInt32(7);
            
            if(UserData.role < 3)
                {
               employeeToolStripMenuItem.Visible= false;
               employeeToolStripMenuItem.Enabled= false;
                }
            con.Close();
            
            initial_stage();
            autoId();
            loadAllComboBox();
            loadGridView();
            lblUsername.Text = UserData.username;
        }

        private void autoId()
        {
            int num = 0;
            con.Close();
            con.Open();
            try
            {
                cmd = new SqlCommand("Select MAX(id) from tblCust", con);
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
            con_loaded = false;
            state_loaded = false;
            btn_new.Enabled = true;
            btn_save.Enabled = true;
            btn_reset.Enabled = true;
            btn_Fill.Enabled = false;
            btn_delete.Enabled = false;
            btnSearch.Enabled = true;
            btn_update.Enabled = false;
            btn_save.Enabled = false;

            //throw new NotImplementedException();

            txtId.Enabled = false;
        }

        private void com_country_SelectedIndexChanged(object sender, EventArgs e)
        {

            state_loaded = false;   // It prevent to run city load method at start while loading
            if (con_loaded)
            {
                com_state.Enabled = true;
                // load state combo box with join query
                con.Close();
                con.Open();

                // MessageBox.Show("1 " + com_country.SelectedValue.ToString());
                cmd = new SqlCommand("select * from states where country_id = @con_id;", con);
                cmd.Parameters.AddWithValue("@con_id", com_country.SelectedValue);
                //select * from states join countries ON states.country_id = countries.id;
                // for display country details using state
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                com_state.DataSource = dt;
                com_state.ValueMember = "id";
                com_state.DisplayMember = "name";
                con.Close();

                com_state.Text = null;
            }

            state_loaded = true;
        }

        private void com_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state_loaded)
            {
                com_city.Enabled = true;
                // load state combo box with join query
                con.Close();
                con.Open();

                cmd = new SqlCommand("select * from cities where state_id = " + com_state.SelectedValue + ";", con);
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                com_city.DataSource = dt;
                com_city.ValueMember = "id";
                com_city.DisplayMember = "name";
                con.Close();

                com_city.Text = null;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            all_clear();
            initial_stage();
            btn_save.Enabled = true;
        }

        private void loadGridView()
        {
            clearSearch();
            con.Close();
            con.Open();
            cmd = new SqlCommand("select tblCust.id , tblCust.name , tblCust.con_no as 'Contact NUmber' , tblCust.email , tblCust.address , cities.name as City , states.name as State , countries.name as Country from tblCust inner join cities on tblCust.city_id = cities.id inner join states on states.id = cities.state_id inner join countries on countries.id = states.country_id ;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
            //throw new NotImplementedException();
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
            cmd = new SqlCommand("insert into tblCust values(@name , @con_no , @email , @address , @city_id)", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@con_no", Convert.ToInt64(txtConNum.Text));
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@city_id", com_city.SelectedValue);
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

            cmd = new SqlCommand("update tblCust set name = @name , con_no = @con_no , email = @email , address = @address , city_id = @city_id where id = @custID ;" , con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@con_no", Convert.ToInt64(txtConNum.Text)); 
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@custID", txtId.Text);
            cmd.Parameters.AddWithValue("@city_id", com_city.SelectedValue);

            int n = cmd.ExecuteNonQuery();
            if(n < 0)
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
            cmd = new SqlCommand("select * from tblCust where id = @cust_id", con);
            cmd.Parameters.AddWithValue("@cust_id", Convert.ToInt32(txtId.Text));
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
            txtName.Text = dr.GetString(1);
                txtConNum.Text = dr.GetInt64(2).ToString();
                txtEmail.Text = dr.GetString(3);
                txtAddress.Text = dr.GetString(4);
                com_city.Enabled = true;
                com_state.Enabled = true;
                com_country.Enabled = true;

                int city_id = dr.GetInt32(5);

                con.Close();
                con.Open();

                cmd = new SqlCommand("select state_id from cities where id = "+ city_id +";" , con);
                dr = cmd.ExecuteReader();
                dr.Read();
                int state_id = dr.GetInt32(0);

                con.Close();
                con.Open();

                cmd = new SqlCommand("select country_id from states where id = " + state_id + ";", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                int country_id = dr.GetInt32(0);

                com_country.SelectedValue = country_id;
                com_state.SelectedValue = state_id;
                com_city.SelectedValue = city_id;


                btn_delete.Enabled = true;
                btn_update.Enabled = true;
            }
            else{
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
                cmd = new SqlCommand("select tblCust.id , tblCust.name , tblCust.con_no as 'Contact NUmber' , tblCust.email , tblCust.address , cities.name as City , states.name as State , countries.name as Country from tblCust inner join cities on tblCust.city_id = cities.id inner join states on states.id = cities.state_id inner join countries on countries.id = states.country_id where tblCust.id = @cust_id;", con);
                cmd.Parameters.AddWithValue("@cust_id", int.Parse(txtIdSearch.Text));
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
                cmd = new SqlCommand("select tblCust.id , tblCust.name , tblCust.con_no as 'Contact NUmber' , tblCust.email , tblCust.address , cities.name as City , states.name as State , countries.name as Country from tblCust inner join cities on tblCust.city_id = cities.id inner join states on states.id = cities.state_id inner join countries on countries.id = states.country_id where con_no = @con_no;", con);
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

            cmd = new SqlCommand("delete from tblCust where id = @cust_id", con);
            cmd.Parameters.AddWithValue("@cust_id", Convert.ToInt32( txtId.Text));
            int n = cmd.ExecuteNonQuery();
            if(n > 0)
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

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.Hide();
            emp.Show();
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
    }
}
