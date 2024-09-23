using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class MDIForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public MDIForm()
        {
            InitializeComponent();
        }
        private void CloseAllMdiChildren()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tsmiprofile_Click(object sender, EventArgs e)
        {
            
                // Close all existing child forms
                CloseAllMdiChildren();

                // Open the new Dashboard form
                frmdashboard frmdashboard = new frmdashboard();
                frmdashboard.Text = "Profile";
                frmdashboard.Size = new Size(801, 511); // Set a default size for visibility
                frmdashboard.MdiParent = this;
                frmdashboard.Show();
            

        }

        private void tsmicalculator_Click(object sender, EventArgs e)
        {
            // Close all existing child forms
            CloseAllMdiChildren();

            // Open the new Calculator form
            frm_calculator frm_calculator = new frm_calculator();
            frm_calculator.Text = "Calculator";
            frm_calculator.Size = new Size(477, 513);
            frm_calculator.MdiParent = this;
            frm_calculator.Show();

        }

        private void btnmdiclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDIForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {

        }

        private void studentInformtionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void itsm_info_Click(object sender, EventArgs e)
        {
            frm_mdistudentinfo frm_mdistudentinfo = new frm_mdistudentinfo();
            frm_mdistudentinfo.Size = new Size(1015, 668);
            frm_mdistudentinfo.MdiParent = this;
            frm_mdistudentinfo.Show();
        }
    }
}
