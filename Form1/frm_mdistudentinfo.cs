using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class frm_mdistudentinfo : Form
    {
        public frm_mdistudentinfo()
        {
            InitializeComponent();
        }

        private void btn_register1_Click(object sender, EventArgs e)
        {
            tb2name.Text = tbfirstname1.Text + " " + tblastname1.Text;
            tb2ddress.Text = tbaddress1.Text;
            tb2birthday.Text = cbmonth1.Text + "" + cbday1.Text + "" + cbyear1.Text;
            tb2gender.Text = cbgender1.Text;
            tb2age.Text = cbage1.Text;
            tb2course.Text = tbcourse1.Text;
            tb2email.Text = tbemail1.Text;

        }
    }
}
