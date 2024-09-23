namespace Form1
{
    partial class frm_studentoinformation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_studentoinformation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_studentinformation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.cbage = new System.Windows.Forms.ComboBox();
            this.cbyear = new System.Windows.Forms.ComboBox();
            this.cbday = new System.Windows.Forms.ComboBox();
            this.cbmonth = new System.Windows.Forms.ComboBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbcourse = new System.Windows.Forms.TextBox();
            this.tblastname = new System.Windows.Forms.TextBox();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tbfirstname = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1099, 629);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // lbl_studentinformation
            // 
            this.lbl_studentinformation.Font = new System.Drawing.Font("Nihonium113 Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_studentinformation.ForeColor = System.Drawing.Color.White;
            this.lbl_studentinformation.Location = new System.Drawing.Point(51, 52);
            this.lbl_studentinformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_studentinformation.Name = "lbl_studentinformation";
            this.lbl_studentinformation.Size = new System.Drawing.Size(352, 34);
            this.lbl_studentinformation.TabIndex = 0;
            this.lbl_studentinformation.Text = "Student Information";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1025, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Controls.Add(this.cbgender);
            this.panel1.Controls.Add(this.cbage);
            this.panel1.Controls.Add(this.cbyear);
            this.panel1.Controls.Add(this.cbday);
            this.panel1.Controls.Add(this.cbmonth);
            this.panel1.Controls.Add(this.tbemail);
            this.panel1.Controls.Add(this.tbcourse);
            this.panel1.Controls.Add(this.tblastname);
            this.panel1.Controls.Add(this.tbaddress);
            this.panel1.Controls.Add(this.tbfirstname);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.lbl_course);
            this.panel1.Controls.Add(this.lbl_age);
            this.panel1.Controls.Add(this.lbl_gender);
            this.panel1.Controls.Add(this.lbl_birthday);
            this.panel1.Controls.Add(this.lbl_address);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lbl_studentinformation);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 629);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(323, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(169, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // btn_register
            // 
            this.btn_register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_register.BackgroundImage")));
            this.btn_register.Font = new System.Drawing.Font("Nihonium113 Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(192, 543);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(152, 44);
            this.btn_register.TabIndex = 18;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "",
            "Female",
            "",
            "Non-binary",
            "",
            "Genderqueer",
            "",
            "Genderfluid",
            "",
            "Agender",
            "",
            "Bigender",
            "",
            "Two-Spirit",
            "",
            "Demiboy",
            "",
            "Demigirl",
            "",
            "Intersex",
            "",
            "Transgender",
            "",
            "Gender Non-Conforming",
            "",
            "Gender Variant",
            "",
            "Pangender"});
            this.cbgender.Location = new System.Drawing.Point(173, 319);
            this.cbgender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(149, 24);
            this.cbgender.TabIndex = 17;
            // 
            // cbage
            // 
            this.cbage.FormattingEnabled = true;
            this.cbage.Items.AddRange(new object[] {
            "1  ",
            "2  ",
            "3  ",
            "4  ",
            "5  ",
            "6  ",
            "7  ",
            "8  ",
            "9  ",
            "10  ",
            "11  ",
            "12  ",
            "13  ",
            "14  ",
            "15  ",
            "16  ",
            "17  ",
            "18  ",
            "19  ",
            "20  ",
            "21  ",
            "22  ",
            "23  ",
            "24  ",
            "25  ",
            "26  ",
            "27  ",
            "28  ",
            "29  ",
            "30  ",
            "31  ",
            "32  ",
            "33  ",
            "34  ",
            "35  ",
            "36  ",
            "37  ",
            "38  ",
            "39  ",
            "40  ",
            "41  ",
            "42  ",
            "43  ",
            "44  ",
            "45  ",
            "46  ",
            "47  ",
            "48  ",
            "49  ",
            "50  ",
            "51  ",
            "52  ",
            "53  ",
            "54  ",
            "55  ",
            "56  ",
            "57  ",
            "58  ",
            "59  ",
            "60  ",
            "61  ",
            "62  ",
            "63  ",
            "64  ",
            "65  ",
            "66  ",
            "67  ",
            "68  ",
            "69  ",
            "70  ",
            "71  ",
            "72  ",
            "73  ",
            "74  ",
            "75  ",
            "76  ",
            "77  ",
            "78  ",
            "79  ",
            "80  ",
            "81  ",
            "82  ",
            "83  ",
            "84  ",
            "85  ",
            "86  ",
            "87  ",
            "88  ",
            "89  ",
            "90  ",
            "91  ",
            "92  ",
            "93  ",
            "94  ",
            "95  ",
            "96  ",
            "97  ",
            "98  ",
            "99  ",
            "100  "});
            this.cbage.Location = new System.Drawing.Point(396, 319);
            this.cbage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbage.Name = "cbage";
            this.cbage.Size = new System.Drawing.Size(80, 24);
            this.cbage.TabIndex = 16;
            // 
            // cbyear
            // 
            this.cbyear.FormattingEnabled = true;
            this.cbyear.Items.AddRange(new object[] {
            "1900  ",
            "1901  ",
            "1902  ",
            "1903  ",
            "1904  ",
            "1905  ",
            "1906  ",
            "1907  ",
            "1908  ",
            "1909  ",
            "1910  ",
            "1911  ",
            "1912  ",
            "1913  ",
            "1914  ",
            "1915  ",
            "1916  ",
            "1917  ",
            "1918  ",
            "1919  ",
            "1920  ",
            "1921  ",
            "1922  ",
            "1923  ",
            "1924  ",
            "1925  ",
            "1926  ",
            "1927  ",
            "1928  ",
            "1929  ",
            "1930  ",
            "1931  ",
            "1932  ",
            "1933  ",
            "1934  ",
            "1935  ",
            "1936  ",
            "1937  ",
            "1938  ",
            "1939  ",
            "1940  ",
            "1941  ",
            "1942  ",
            "1943  ",
            "1944  ",
            "1945  ",
            "1946  ",
            "1947  ",
            "1948  ",
            "1949  ",
            "1950  ",
            "1951  ",
            "1952  ",
            "1953  ",
            "1954  ",
            "1955  ",
            "1956  ",
            "1957  ",
            "1958  ",
            "1959  ",
            "1960  ",
            "1961  ",
            "1962  ",
            "1963  ",
            "1964  ",
            "1965  ",
            "1966  ",
            "1967  ",
            "1968  ",
            "1969  ",
            "1970  ",
            "1971  ",
            "1972  ",
            "1973  ",
            "1974  ",
            "1975  ",
            "1976  ",
            "1977  ",
            "1978  ",
            "1979  ",
            "1980  ",
            "1981  ",
            "1982  ",
            "1983  ",
            "1984  ",
            "1985  ",
            "1986  ",
            "1987  ",
            "1988  ",
            "1989  ",
            "1990  ",
            "1991  ",
            "1992  ",
            "1993  ",
            "1994  ",
            "1995  ",
            "1996  ",
            "1997  ",
            "1998  ",
            "1999  ",
            "2000  ",
            "2001  ",
            "2002  ",
            "2003  ",
            "2004  ",
            "2005  ",
            "2006  ",
            "2007  ",
            "2008  ",
            "2009  ",
            "2010  ",
            "2011  ",
            "2012  ",
            "2013  ",
            "2014  ",
            "2015  ",
            "2016  ",
            "2017  ",
            "2018  ",
            "2019  ",
            "2020  ",
            "2021  ",
            "2022  ",
            "2023  ",
            "2024  "});
            this.cbyear.Location = new System.Drawing.Point(352, 251);
            this.cbyear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbyear.Name = "cbyear";
            this.cbyear.Size = new System.Drawing.Size(124, 24);
            this.cbyear.TabIndex = 15;
            this.cbyear.Text = "Year";
            // 
            // cbday
            // 
            this.cbday.FormattingEnabled = true;
            this.cbday.Items.AddRange(new object[] {
            "1  ",
            "2  ",
            "3  ",
            "4  ",
            "5  ",
            "6  ",
            "7  ",
            "8  ",
            "9  ",
            "10  ",
            "11  ",
            "12  ",
            "13  ",
            "14  ",
            "15  ",
            "16  ",
            "17  ",
            "18  ",
            "19  ",
            "20  ",
            "21  ",
            "22  ",
            "23  ",
            "24  ",
            "25  ",
            "26  ",
            "27  ",
            "28  ",
            "29  ",
            "30  ",
            "31  "});
            this.cbday.Location = new System.Drawing.Point(263, 251);
            this.cbday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbday.Name = "cbday";
            this.cbday.Size = new System.Drawing.Size(80, 24);
            this.cbday.TabIndex = 14;
            this.cbday.Text = "Day";
            this.cbday.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbmonth
            // 
            this.cbmonth.FormattingEnabled = true;
            this.cbmonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November\t",
            "December"});
            this.cbmonth.Location = new System.Drawing.Point(173, 251);
            this.cbmonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmonth.Name = "cbmonth";
            this.cbmonth.Size = new System.Drawing.Size(80, 24);
            this.cbmonth.TabIndex = 13;
            this.cbmonth.Text = "Month";
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(173, 453);
            this.tbemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(303, 30);
            this.tbemail.TabIndex = 12;
            // 
            // tbcourse
            // 
            this.tbcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcourse.Location = new System.Drawing.Point(173, 388);
            this.tbcourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcourse.Name = "tbcourse";
            this.tbcourse.Size = new System.Drawing.Size(303, 30);
            this.tbcourse.TabIndex = 11;
            // 
            // tblastname
            // 
            this.tblastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblastname.Location = new System.Drawing.Point(327, 110);
            this.tblastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblastname.Name = "tblastname";
            this.tblastname.Size = new System.Drawing.Size(149, 30);
            this.tblastname.TabIndex = 10;
            this.tblastname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbaddress
            // 
            this.tbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaddress.Location = new System.Drawing.Point(173, 178);
            this.tbaddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(303, 30);
            this.tbaddress.TabIndex = 9;
            // 
            // tbfirstname
            // 
            this.tbfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfirstname.Location = new System.Drawing.Point(173, 110);
            this.tbfirstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbfirstname.Name = "tbfirstname";
            this.tbfirstname.Size = new System.Drawing.Size(144, 30);
            this.tbfirstname.TabIndex = 8;
            this.tbfirstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(51, 462);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(75, 23);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course.ForeColor = System.Drawing.Color.White;
            this.lbl_course.Location = new System.Drawing.Point(36, 396);
            this.lbl_course.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(88, 23);
            this.lbl_course.TabIndex = 6;
            this.lbl_course.Text = "Course";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.Color.White;
            this.lbl_age.Location = new System.Drawing.Point(332, 321);
            this.lbl_age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(49, 23);
            this.lbl_age.TabIndex = 5;
            this.lbl_age.Text = "Age";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_gender.Location = new System.Drawing.Point(36, 321);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(88, 23);
            this.lbl_gender.TabIndex = 4;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthday.ForeColor = System.Drawing.Color.White;
            this.lbl_birthday.Location = new System.Drawing.Point(7, 249);
            this.lbl_birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(114, 23);
            this.lbl_birthday.TabIndex = 3;
            this.lbl_birthday.Text = "Birthday";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.White;
            this.lbl_address.Location = new System.Drawing.Point(21, 187);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(101, 23);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Address";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Nihonium113 Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(65, 118);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(62, 23);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frm_studentoinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_studentoinformation";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_studentinformation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbcourse;
        private System.Windows.Forms.TextBox tblastname;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tbfirstname;
        private System.Windows.Forms.ComboBox cbyear;
        private System.Windows.Forms.ComboBox cbday;
        private System.Windows.Forms.ComboBox cbmonth;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.ComboBox cbage;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

