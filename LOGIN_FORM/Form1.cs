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


namespace LOGIN_FORM
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var posi = this.PointToScreen(pnl_loginpanel.Location);
            posi = pnl_loginpanel.PointToClient(posi);
            pnl_loginpanel.Parent = pic_loginbgpicture;
            
            pnl_loginpanel.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void pnl_loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_loginbgpicture_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pic_loginformcover_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void llbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 sForm = new Form2();
            sForm.Show();
            this.Hide();
        }
    }
}
