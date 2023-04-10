using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invitation_Project
{
    public partial class changePass : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=SPIRIT-SOLUTION\\SQLEXPRESS;Initial Catalog=Invitation_Project;Integrated Security=True");
        SqlDataReader dr;
        public changePass()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePass_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromFile("D:\\UTU\\GUI_1\\Invitation_Project\\picture\\system_pic\\1.png");

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
          
          
            if(txt_pass.Text == "password")
            {
                lbl_err.Text = "Enter password other than : password";
            }
            else{
                if (txt_pass.Text != txt_pass_con.Text)
                {
                lbl_err.Text = "Enter Same Password";
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("update tbl_auth set password = @password where username = @username" , con);
                    cmd.Parameters.AddWithValue("@password", txt_pass.Text);
                    cmd.Parameters.AddWithValue("@username", UserData.username);
                    int n = (int)cmd.ExecuteNonQuery();
                    if(n > 0)
                    {
                        Form2 a = new Form2();
                        UserData.modified_pass = 0;
                        a.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong");
                    }

                    con.Close();
                }
            }
        }
    }
}
