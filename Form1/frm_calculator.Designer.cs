namespace Form1
{
    partial class frm_calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_calculator));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_calculatorclose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Calculator = new System.Windows.Forms.Label();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.txt_resultcalculator = new System.Windows.Forms.TextBox();
            this.lbl_currentoperation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Operator_click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btn_calculatorclose
            // 
            this.btn_calculatorclose.BackColor = System.Drawing.Color.Orchid;
            this.btn_calculatorclose.FlatAppearance.BorderSize = 0;
            this.btn_calculatorclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_calculatorclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_calculatorclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculatorclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculatorclose.ForeColor = System.Drawing.Color.White;
            this.btn_calculatorclose.Location = new System.Drawing.Point(448, 0);
            this.btn_calculatorclose.Name = "btn_calculatorclose";
            this.btn_calculatorclose.Size = new System.Drawing.Size(29, 23);
            this.btn_calculatorclose.TabIndex = 1;
            this.btn_calculatorclose.Text = "X";
            this.btn_calculatorclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_calculatorclose.UseVisualStyleBackColor = false;
            this.btn_calculatorclose.Click += new System.EventHandler(this.btn_calculatorclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orchid;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_Calculator);
            this.panel1.Controls.Add(this.btn_calculatorclose);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 33);
            this.panel1.TabIndex = 2;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Calculator
            // 
            this.lbl_Calculator.AutoSize = true;
            this.lbl_Calculator.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Calculator.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calculator.ForeColor = System.Drawing.Color.White;
            this.lbl_Calculator.Location = new System.Drawing.Point(31, 4);
            this.lbl_Calculator.Name = "lbl_Calculator";
            this.lbl_Calculator.Size = new System.Drawing.Size(119, 19);
            this.lbl_Calculator.TabIndex = 3;
            this.lbl_Calculator.Text = "Calculator";
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_7.FlatAppearance.BorderSize = 3;
            this.btn_7.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.Black;
            this.btn_7.Location = new System.Drawing.Point(44, 191);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(71, 67);
            this.btn_7.TabIndex = 3;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.Button_click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_8.FlatAppearance.BorderSize = 3;
            this.btn_8.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.Black;
            this.btn_8.Location = new System.Drawing.Point(121, 191);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(71, 67);
            this.btn_8.TabIndex = 4;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.Button_click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_9.FlatAppearance.BorderSize = 3;
            this.btn_9.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.Black;
            this.btn_9.Location = new System.Drawing.Point(198, 191);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(71, 67);
            this.btn_9.TabIndex = 5;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.Button_click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_division.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_division.FlatAppearance.BorderSize = 3;
            this.btn_division.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.ForeColor = System.Drawing.Color.Teal;
            this.btn_division.Location = new System.Drawing.Point(275, 191);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(71, 67);
            this.btn_division.TabIndex = 6;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.Operator_click);
            // 
            // btn_CE
            // 
            this.btn_CE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CE.FlatAppearance.BorderSize = 3;
            this.btn_CE.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CE.ForeColor = System.Drawing.Color.White;
            this.btn_CE.Location = new System.Drawing.Point(352, 191);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(71, 67);
            this.btn_CE.TabIndex = 7;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = false;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_C.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_C.FlatAppearance.BorderSize = 3;
            this.btn_C.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C.ForeColor = System.Drawing.Color.White;
            this.btn_C.Location = new System.Drawing.Point(352, 264);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(71, 67);
            this.btn_C.TabIndex = 12;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_multiply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_multiply.FlatAppearance.BorderSize = 3;
            this.btn_multiply.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.ForeColor = System.Drawing.Color.Teal;
            this.btn_multiply.Location = new System.Drawing.Point(275, 264);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(71, 67);
            this.btn_multiply.TabIndex = 11;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = false;
            this.btn_multiply.Click += new System.EventHandler(this.Operator_click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_6.FlatAppearance.BorderSize = 3;
            this.btn_6.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.Black;
            this.btn_6.Location = new System.Drawing.Point(198, 264);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(71, 67);
            this.btn_6.TabIndex = 10;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.Button_click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_5.FlatAppearance.BorderSize = 3;
            this.btn_5.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.Black;
            this.btn_5.Location = new System.Drawing.Point(121, 264);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(71, 67);
            this.btn_5.TabIndex = 9;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.Button_click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_4.FlatAppearance.BorderSize = 3;
            this.btn_4.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.Black;
            this.btn_4.Location = new System.Drawing.Point(44, 264);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(71, 67);
            this.btn_4.TabIndex = 8;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.Button_click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_minus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_minus.FlatAppearance.BorderSize = 3;
            this.btn_minus.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.ForeColor = System.Drawing.Color.Teal;
            this.btn_minus.Location = new System.Drawing.Point(275, 337);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(71, 67);
            this.btn_minus.TabIndex = 16;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.Operator_click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_3.FlatAppearance.BorderSize = 3;
            this.btn_3.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.Black;
            this.btn_3.Location = new System.Drawing.Point(198, 337);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(71, 67);
            this.btn_3.TabIndex = 15;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.Button_click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_2.FlatAppearance.BorderSize = 3;
            this.btn_2.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.Black;
            this.btn_2.Location = new System.Drawing.Point(121, 337);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(71, 67);
            this.btn_2.TabIndex = 14;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.Button_click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_1.FlatAppearance.BorderSize = 3;
            this.btn_1.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.Black;
            this.btn_1.Location = new System.Drawing.Point(44, 337);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(71, 67);
            this.btn_1.TabIndex = 13;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.Button_click);
            // 
            // btn_equals
            // 
            this.btn_equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_equals.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_equals.FlatAppearance.BorderSize = 3;
            this.btn_equals.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equals.ForeColor = System.Drawing.Color.Black;
            this.btn_equals.Location = new System.Drawing.Point(352, 337);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(71, 140);
            this.btn_equals.TabIndex = 22;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = false;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_add.FlatAppearance.BorderSize = 3;
            this.btn_add.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Teal;
            this.btn_add.Location = new System.Drawing.Point(275, 410);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(71, 67);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Operator_click);
            // 
            // btn_point
            // 
            this.btn_point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_point.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_point.FlatAppearance.BorderSize = 3;
            this.btn_point.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.ForeColor = System.Drawing.Color.Teal;
            this.btn_point.Location = new System.Drawing.Point(198, 410);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(71, 67);
            this.btn_point.TabIndex = 20;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = false;
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_0.FlatAppearance.BorderSize = 3;
            this.btn_0.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.Black;
            this.btn_0.Location = new System.Drawing.Point(44, 410);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(148, 67);
            this.btn_0.TabIndex = 18;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.Button_click);
            // 
            // txt_resultcalculator
            // 
            this.txt_resultcalculator.Font = new System.Drawing.Font("Nihonium113 Console", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultcalculator.Location = new System.Drawing.Point(44, 117);
            this.txt_resultcalculator.Multiline = true;
            this.txt_resultcalculator.Name = "txt_resultcalculator";
            this.txt_resultcalculator.Size = new System.Drawing.Size(379, 46);
            this.txt_resultcalculator.TabIndex = 23;
            this.txt_resultcalculator.Text = "0";
            this.txt_resultcalculator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_currentoperation
            // 
            this.lbl_currentoperation.AutoSize = true;
            this.lbl_currentoperation.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentoperation.Location = new System.Drawing.Point(49, 95);
            this.lbl_currentoperation.Name = "lbl_currentoperation";
            this.lbl_currentoperation.Size = new System.Drawing.Size(0, 19);
            this.lbl_currentoperation.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(416, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 511);
            this.Controls.Add(this.lbl_currentoperation);
            this.Controls.Add(this.txt_resultcalculator);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_calculator";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_calculatorclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Calculator;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.TextBox txt_resultcalculator;
        private System.Windows.Forms.Label lbl_currentoperation;
        private System.Windows.Forms.Button button1;
    }
}