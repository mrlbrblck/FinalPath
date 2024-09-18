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
    public partial class frm_calculator : Form
    {
        public const int WM_NCLBUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public frm_calculator()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {
            if ((txt_resultcalculator.Text == "0") || (isOperationPerformed))
                txt_resultcalculator.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txt_resultcalculator.Text.Contains("."))
                    txt_resultcalculator.Text = txt_resultcalculator.Text + button.Text;

            }
            else
                txt_resultcalculator.Text = txt_resultcalculator.Text + button.Text;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                btn_equals.PerformClick();
                operationPerformed = button.Text;
                lbl_currentoperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txt_resultcalculator.Text);
                lbl_currentoperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_resultcalculator.Text = "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_resultcalculator.Text = "0";
            resultValue = 0;
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txt_resultcalculator.Text = (resultValue + Double.Parse(txt_resultcalculator.Text)).ToString();
                    break;
                case "-":
                    txt_resultcalculator.Text = (resultValue - Double.Parse(txt_resultcalculator.Text)).ToString();
                    break;
                case "*":
                    txt_resultcalculator.Text = (resultValue * Double.Parse(txt_resultcalculator.Text)).ToString();
                    break;
                case "/":
                    txt_resultcalculator.Text = (resultValue / Double.Parse(txt_resultcalculator.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(txt_resultcalculator.Text);
            lbl_currentoperation.Text = "";
        }

        private void btn_calculatorclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
