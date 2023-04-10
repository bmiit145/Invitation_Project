using SMS;
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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            generateBill gb = new generateBill();
            gb.Show();
        }
    }
}
