using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invitation_Project
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserData.username;
            pictureBox1.Image = Image.FromFile("D:\\UTU\\GUI_1\\Invitation_Project\\picture\\system_pic\\1.png");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }
    }
}
