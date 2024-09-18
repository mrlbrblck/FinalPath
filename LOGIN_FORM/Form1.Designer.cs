namespace LOGIN_FORM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic_loginformcover = new System.Windows.Forms.PictureBox();
            this.lbl_welcomeback = new System.Windows.Forms.Label();
            this.pnl_loginpanel = new System.Windows.Forms.Panel();
            this.llbl_signup = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_logincheckpass = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_loginpassword = new System.Windows.Forms.Label();
            this.lbl_loginusername = new System.Windows.Forms.Label();
            this.btn_loginclose = new System.Windows.Forms.Button();
            this.pnl_windowbuttonlogin = new System.Windows.Forms.Panel();
            this.pic_loginbgpicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loginformcover)).BeginInit();
            this.pnl_loginpanel.SuspendLayout();
            this.pnl_windowbuttonlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loginbgpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_loginformcover
            // 
            this.pic_loginformcover.Location = new System.Drawing.Point(-2, -2);
            this.pic_loginformcover.Name = "pic_loginformcover";
            this.pic_loginformcover.Size = new System.Drawing.Size(332, 337);
            this.pic_loginformcover.TabIndex = 3;
            this.pic_loginformcover.TabStop = false;
            this.pic_loginformcover.Click += new System.EventHandler(this.pic_loginformcover_Click);
            // 
            // lbl_welcomeback
            // 
            this.lbl_welcomeback.AutoSize = true;
            this.lbl_welcomeback.Font = new System.Drawing.Font("Nihonium113 Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeback.ForeColor = System.Drawing.Color.White;
            this.lbl_welcomeback.Location = new System.Drawing.Point(62, 17);
            this.lbl_welcomeback.Name = "lbl_welcomeback";
            this.lbl_welcomeback.Size = new System.Drawing.Size(207, 25);
            this.lbl_welcomeback.TabIndex = 0;
            this.lbl_welcomeback.Text = "Welcome back!";
            // 
            // pnl_loginpanel
            // 
            this.pnl_loginpanel.BackColor = System.Drawing.Color.Black;
            this.pnl_loginpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_loginpanel.Controls.Add(this.llbl_signup);
            this.pnl_loginpanel.Controls.Add(this.label1);
            this.pnl_loginpanel.Controls.Add(this.chk_logincheckpass);
            this.pnl_loginpanel.Controls.Add(this.button1);
            this.pnl_loginpanel.Controls.Add(this.textBox2);
            this.pnl_loginpanel.Controls.Add(this.textBox1);
            this.pnl_loginpanel.Controls.Add(this.lbl_loginpassword);
            this.pnl_loginpanel.Controls.Add(this.lbl_loginusername);
            this.pnl_loginpanel.Controls.Add(this.lbl_welcomeback);
            this.pnl_loginpanel.Controls.Add(this.pic_loginformcover);
            this.pnl_loginpanel.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_loginpanel.ForeColor = System.Drawing.Color.Transparent;
            this.pnl_loginpanel.Location = new System.Drawing.Point(30, 77);
            this.pnl_loginpanel.Name = "pnl_loginpanel";
            this.pnl_loginpanel.Size = new System.Drawing.Size(332, 337);
            this.pnl_loginpanel.TabIndex = 2;
            this.pnl_loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_loginpanel_Paint);
            // 
            // llbl_signup
            // 
            this.llbl_signup.AutoSize = true;
            this.llbl_signup.Font = new System.Drawing.Font("Nihonium113 Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_signup.LinkColor = System.Drawing.Color.White;
            this.llbl_signup.Location = new System.Drawing.Point(267, 311);
            this.llbl_signup.Name = "llbl_signup";
            this.llbl_signup.Size = new System.Drawing.Size(49, 13);
            this.llbl_signup.TabIndex = 8;
            this.llbl_signup.TabStop = true;
            this.llbl_signup.Text = "Signup";
            this.llbl_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_signup_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nihonium113 Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Don\'t have an account?";
            // 
            // chk_logincheckpass
            // 
            this.chk_logincheckpass.AutoSize = true;
            this.chk_logincheckpass.Font = new System.Drawing.Font("Nihonium113 Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_logincheckpass.Location = new System.Drawing.Point(198, 185);
            this.chk_logincheckpass.Name = "chk_logincheckpass";
            this.chk_logincheckpass.Size = new System.Drawing.Size(108, 15);
            this.chk_logincheckpass.TabIndex = 6;
            this.chk_logincheckpass.Text = "Check password";
            this.chk_logincheckpass.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(103, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(175, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 26);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_loginpassword
            // 
            this.lbl_loginpassword.AutoSize = true;
            this.lbl_loginpassword.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginpassword.Location = new System.Drawing.Point(28, 160);
            this.lbl_loginpassword.Name = "lbl_loginpassword";
            this.lbl_loginpassword.Size = new System.Drawing.Size(97, 19);
            this.lbl_loginpassword.TabIndex = 2;
            this.lbl_loginpassword.Text = "Password";
            // 
            // lbl_loginusername
            // 
            this.lbl_loginusername.AutoSize = true;
            this.lbl_loginusername.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginusername.Location = new System.Drawing.Point(28, 113);
            this.lbl_loginusername.Name = "lbl_loginusername";
            this.lbl_loginusername.Size = new System.Drawing.Size(97, 19);
            this.lbl_loginusername.TabIndex = 1;
            this.lbl_loginusername.Text = "Username";
            // 
            // btn_loginclose
            // 
            this.btn_loginclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loginclose.FlatAppearance.BorderSize = 0;
            this.btn_loginclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_loginclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_loginclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loginclose.ForeColor = System.Drawing.Color.Transparent;
            this.btn_loginclose.Location = new System.Drawing.Point(765, 0);
            this.btn_loginclose.Name = "btn_loginclose";
            this.btn_loginclose.Size = new System.Drawing.Size(36, 25);
            this.btn_loginclose.TabIndex = 0;
            this.btn_loginclose.Text = " X";
            this.btn_loginclose.UseVisualStyleBackColor = true;
            this.btn_loginclose.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_windowbuttonlogin
            // 
            this.pnl_windowbuttonlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.pnl_windowbuttonlogin.Controls.Add(this.btn_loginclose);
            this.pnl_windowbuttonlogin.Location = new System.Drawing.Point(-1, 0);
            this.pnl_windowbuttonlogin.Name = "pnl_windowbuttonlogin";
            this.pnl_windowbuttonlogin.Size = new System.Drawing.Size(801, 25);
            this.pnl_windowbuttonlogin.TabIndex = 1;
            this.pnl_windowbuttonlogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnl_windowbuttonlogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pic_loginbgpicture
            // 
            this.pic_loginbgpicture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pic_loginbgpicture.Image = ((System.Drawing.Image)(resources.GetObject("pic_loginbgpicture.Image")));
            this.pic_loginbgpicture.Location = new System.Drawing.Point(0, 0);
            this.pic_loginbgpicture.Name = "pic_loginbgpicture";
            this.pic_loginbgpicture.Size = new System.Drawing.Size(800, 450);
            this.pic_loginbgpicture.TabIndex = 0;
            this.pic_loginbgpicture.TabStop = false;
            this.pic_loginbgpicture.Click += new System.EventHandler(this.pic_loginbgpicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_loginpanel);
            this.Controls.Add(this.pnl_windowbuttonlogin);
            this.Controls.Add(this.pic_loginbgpicture);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_loginformcover)).EndInit();
            this.pnl_loginpanel.ResumeLayout(false);
            this.pnl_loginpanel.PerformLayout();
            this.pnl_windowbuttonlogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_loginbgpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_loginformcover;
        private System.Windows.Forms.Label lbl_welcomeback;
        private System.Windows.Forms.Panel pnl_loginpanel;
        private System.Windows.Forms.Label lbl_loginpassword;
        private System.Windows.Forms.Label lbl_loginusername;
        private System.Windows.Forms.CheckBox chk_logincheckpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel llbl_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_loginclose;
        private System.Windows.Forms.Panel pnl_windowbuttonlogin;
        private System.Windows.Forms.PictureBox pic_loginbgpicture;
    }
}

