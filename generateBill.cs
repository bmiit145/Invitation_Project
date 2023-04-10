using Invitation_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class generateBill : Form
    {
        
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=SPIRIT-SOLUTION\\SQLEXPRESS;Initial Catalog=Invitation_Project;Integrated Security=True");
        SqlDataReader dr;
        private bool loadCombo;

        public generateBill()
        {
            InitializeComponent();
        }
        private void generateBill_Load(object sender, EventArgs e)
        {
            txtDesignId.Enabled = false;
            txtCustId.Enabled = false;
            txt_price.Enabled = false;
            txtId.Enabled = false;
            autoId();
            cust_bind();
            product_bind();
        }

        private void product_bind()
        {
            loadCombo = false;
            con.Close();
            con.Open();

            cmd = new SqlCommand("select * from tblDesign", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd) ;
            adp.Fill(dt);
            com_design.DataSource = dt;
            com_design.ValueMember = "id";
            com_design.DisplayMember = "name";
            con.Close();
            loadCombo = true;
           // throw new NotImplementedException();
        }

        private void cust_bind()
        {
            loadCombo = false;
            con.Close();
            con.Open();

            cmd = new SqlCommand("select * from tblCust", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            com_cust.DataSource = dt;
            com_cust.ValueMember = "id";
            com_cust.DisplayMember = "name";
            con.Close();
            loadCombo = true;
            // throw new NotImplementedException();
        }

        private void autoId()
        {
            int num = 0;
            con.Close();
            con.Open();
            try
            {
                cmd = new SqlCommand("Select MAX(id) from tblBill", con);
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

        void Myloading()
        {
            //this will change the cursor to the loading
            Cursor.Current = Cursors.WaitCursor;
            //where this will shown on form
        }

        void myListInit()
        {
            //it will add columns to the listview1
            listView1.View = View.Details;
            listView1.Columns.Add("Product ID", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Product Name", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Product Quantity", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Product Price", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Customer ID", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Customer Name", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Customer Contact", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Total", 80, HorizontalAlignment.Left);
        }



        public void ComboBindaMy()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from product", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //add p_name to combobox
            com_design.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                com_design.Items.Add(dt.Rows[i][1].ToString());
            }
            con.Close();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from cutomer", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            //add c_name to combobox
            com_cust.Items.Clear();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                com_cust.Items.Add(dt1.Rows[i][1].ToString());
            }
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill the detail in textBoxes
            if (loadCombo)
            {
                con.Close();
                con.Open();
                cmd = new SqlCommand("select * from tblDesign where id = @d_id", con);
                cmd.Parameters.AddWithValue("@d_id", com_design.SelectedValue);
                dr = cmd.ExecuteReader();
                dr.Read();
                txtDesignId.Text = dr.GetInt32(0).ToString();
               txt_price.Text = dr.GetInt32(6).ToString();
                con.Close();
            }
        }

      
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill the detail in textBoxes
            if (loadCombo)
            {
                con.Close();
                con.Open();
                cmd = new SqlCommand("select * from tblCust where id = @cust_id", con);
                cmd.Parameters.AddWithValue("@cust_id", com_cust.SelectedValue);
                dr = cmd.ExecuteReader();
                dr.Read();
                txtCustId.Text = dr.GetInt32(0).ToString();
                txtContactSearch.Text= dr.GetInt64(2).ToString();
                con.Close();
            }
        }

        
        private void cu_co_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboBindaMy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //it will add the value into the listview1
                    //add the value into the listview
            ListViewItem l1 = new ListViewItem(txtDesignId.Text);
            l1.SubItems.Add(com_design.Text);
            l1.SubItems.Add(txt_qnt.Text);
            l1.SubItems.Add(txt_price.Text);
            l1.SubItems.Add(txtCustId.Text);
            l1.SubItems.Add(com_cust.Text);
            l1.SubItems.Add(txtContactSearch.Text);
            l1.SubItems.Add(txt_total.Text);

            //code will also update the gradtotal of textbox6 and update quanity in a database
            //it will update the total price of the product
            //code for displayig total

            listView1.Items.Add(l1);
            //code for updating the quantity of the product

            int total = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                total += Convert.ToInt32(listView1.Items[i].SubItems[7].Text);
            }
            txt_grand_total.Text = total.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //it will give discount if the total is more than 10000 = 5%
            //if 20000>10%
            //if 30000>15%
            //if 40000>20%
            if (txt_grand_total.Text != "")
            {
               if(txt_discount != null)
                {
                    txt_amt.Text = (int.Parse(txt_grand_total.Text) - int.Parse(txt_discount.Text)).ToString();
                }
                else
                {
                    txt_amt.Text = txt_grand_total.Text.ToString();
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //it will remove discount from the total
            if (txt_discount.Text != "")
            {
                txt_amt.Text = Convert.ToString(Convert.ToInt32(txt_grand_total.Text) - Convert.ToInt32(txt_discount.Text));
            }
            else
            {
                txt_amt.Text = txt_grand_total.Text;
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            //how to store multiple items in database in a single row
            //CREATE TABLE[dbo].[bill_product]
            //(
            //    [bill_id] INT NOT NULL ,
            //    p_id INT,
            //    FOREIGN KEY(bill_id) REFERENCES bill(bill_id),
            //    FOREIGN KEY(p_id) REFERENCES product(p_id)
            //)
            //CREATE TABLE[dbo].[bill] (
            //    [bill_id] INT NOT NULL,
            //    [cu_id] INT NULL,
            //    [total_bill]     FLOAT(53) NULL,
            //    [dicount_amount] FLOAT(53) NULL,
            //    [net_amount] FLOAT(53) NULL,
            //    PRIMARY KEY CLUSTERED([bill_id] ASC),
            //    FOREIGN KEY([cu_id]) REFERENCES[dbo].[cutomer]([cu_id])
            //);
            //write a insert query for a bill_product and bill
            //it will add the value into the database
            try
            {
                con.Close();
                con.Open();
                cmd = new SqlCommand("insert into tblBill values(@cust_id , @total , @discount , @net_amt)" , con);
                cmd.Parameters.AddWithValue("@cust_id" , txtCustId.Text);
                cmd.Parameters.AddWithValue("@total", txt_grand_total.Text);
                cmd.Parameters.AddWithValue("@discount" , txt_discount.Text);
                cmd.Parameters.AddWithValue("@net_amt" , txt_amt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill Added");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //for the bill_product tabel it will add from the listview item price is on last index
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                try
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tblBillProduct values(@bill_id , @d_id)", con);
                    cmd.Parameters.AddWithValue("@bill_id", txtId.Text);
                    cmd.Parameters.AddWithValue("@d_id", listView1.Items[i].SubItems[0].Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Product Added");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //this will reload entire form and clear all the field and load new Id
            generateBill generateBill = new generateBill();
            generateBill.Show();
            this.Close();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtContactSearch_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtContactSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtContactSearch.Text.Length == 10)
            {
                con.Close();
                con.Open();
                cmd = new SqlCommand("select * from tblCust where con_no = @con_no", con);
                cmd.Parameters.AddWithValue("@con_no", Convert.ToInt64(txtContactSearch.Text));
                dr = cmd.ExecuteReader();
                dr.Read();
                txtCustId.Text = dr.GetInt32(0).ToString();
                con.Close();
            }
            else
            {
                txtCustId.Clear();    
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            design d = new design();
            d.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(txt_price.Text != null && txt_qnt.Text != null)
            {
                txt_total.Text = (int.Parse(txt_price.Text ) *int.Parse( txt_qnt.Text)).ToString();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
