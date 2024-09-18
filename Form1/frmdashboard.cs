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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Form1
{
    public partial class frmdashboard : Form
    {
        private Form activeform = null;

        public const int WM_NCLBUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmdashboard()
        { 
            InitializeComponent();
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
        private void position(System.Windows.Forms.Button b)
        {
            p1.Location = new Point(b.Location.X - p1.Width, b.Location.Y);
        
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            position(btnhome);
            btnhome.ForeColor = Color.Maroon;
            btnvideos.ForeColor = Color.Black;
            btnabout.ForeColor = Color.Black;
            btndownloads.ForeColor = Color.Black;

            activeform.Close();

        }

        private void btnvideos_Click(object sender, EventArgs e)
        {
            position(btnvideos);
            btnhome.ForeColor = Color.Black;
            btnvideos.ForeColor = Color.Maroon;
            btnabout.ForeColor = Color.Black;
            btndownloads.ForeColor = Color.Black;

            openChildFormInPanel(new frmvideos());
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            position(btnabout);
            btnhome.ForeColor = Color.Black;
            btnvideos.ForeColor = Color.Black;
            btnabout.ForeColor = Color.Maroon;
            btndownloads.ForeColor = Color.Black;

            openChildFormInPanel(new frmabout());
        }

        private void btndownloads_Click(object sender, EventArgs e)
        {
            position(btndownloads);
            btnhome.ForeColor = Color.Black;
            btnvideos.ForeColor = Color.Black;
            btnabout.ForeColor = Color.Black;
            btndownloads.ForeColor = Color.Maroon;

            openChildFormInPanel(new frmdownloads());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void openChildFormInPanel(Form childForm)
        {
            if (activeform != null)
            
                activeform.Close();
                activeform = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChild.Controls.Add(childForm);
                panelChild.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
