using DotNetEnv;
using System.Data.SqlClient;

namespace Invitation_Project
{
    public partial class loginForm : Form
    {
        //String con_str = Environment.GetEnvironmentVariable("con_string");
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=SPIRIT-SOLUTION\\SQLEXPRESS;Initial Catalog=Invitation_Project;Integrated Security=True");
        SqlDataReader dr;
     
        public loginForm()
        {
            Env.Load(); 
            InitializeComponent();
        }
        
        private void loginForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\UTU\\GUI_1\\Invitation_Project\\picture\\system_pic\\1.png");
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = new SqlCommand("select * from tbl_auth where username = @username and password = @psd;" , con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@psd" , txt_pass.Text);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                btn_submit.Enabled = false;
                UserData.username = txt_username.Text;
                UserData.modified_pass = 0;
                if (txt_pass.Text == "password")
                {
                    
                        changePass ch = new changePass();
                        ch.Show();
                    this.Hide();
                }
                else
                {
                    Form2 a = new Form2();
                    a.Show();
                    this.Hide();
                }

              

            }
            else
            {
                lbl_err.Text = "Not Valid credentials ";
            }
            con.Close() ;

        }
    }
}