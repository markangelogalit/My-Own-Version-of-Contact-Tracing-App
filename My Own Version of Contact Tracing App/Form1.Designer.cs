namespace My_Own_Version_of_Contact_Tracing_App
{
    partial class CTA1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTA1));
            this.lbl1name = new System.Windows.Forms.Label();
            this.lbl2name = new System.Windows.Forms.Label();
            this.lbl3name = new System.Windows.Forms.Label();
            this.lbl4age = new System.Windows.Forms.Label();
            this.lbl5bdate = new System.Windows.Forms.Label();
            this.lbl6number = new System.Windows.Forms.Label();
            this.lbl7email = new System.Windows.Forms.Label();
            this.lbl9address = new System.Windows.Forms.Label();
            this.lbl8temp = new System.Windows.Forms.Label();
            this.lbl10in = new System.Windows.Forms.Label();
            this.lbl11out = new System.Windows.Forms.Label();
            this.lbl12visited = new System.Windows.Forms.Label();
            this.lbl16thanks = new System.Windows.Forms.Label();
            this.lbl15city = new System.Windows.Forms.Label();
            this.lbl13expe = new System.Windows.Forms.Label();
            this.lbl14colleagues = new System.Windows.Forms.Label();
            this.tbx1name = new System.Windows.Forms.TextBox();
            this.tbx10in = new System.Windows.Forms.TextBox();
            this.tbx13expe = new System.Windows.Forms.TextBox();
            this.tbx11out = new System.Windows.Forms.TextBox();
            this.tbxtemp8 = new System.Windows.Forms.TextBox();
            this.tbx9address = new System.Windows.Forms.TextBox();
            this.tbx7email = new System.Windows.Forms.TextBox();
            this.tbx6number = new System.Windows.Forms.TextBox();
            this.tbx5bdate = new System.Windows.Forms.TextBox();
            this.tbx3name = new System.Windows.Forms.TextBox();
            this.tbx2name = new System.Windows.Forms.TextBox();
            this.tbx14colleagues = new System.Windows.Forms.TextBox();
            this.tbx4age = new System.Windows.Forms.TextBox();
            this.tbx12visited = new System.Windows.Forms.TextBox();
            this.tbx15city = new System.Windows.Forms.TextBox();
            this.bnt1save = new System.Windows.Forms.Button();
            this.lbl17title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1name
            // 
            this.lbl1name.AutoSize = true;
            this.lbl1name.Location = new System.Drawing.Point(26, 65);
            this.lbl1name.Name = "lbl1name";
            this.lbl1name.Size = new System.Drawing.Size(64, 15);
            this.lbl1name.TabIndex = 0;
            this.lbl1name.Text = "First Name";
            this.lbl1name.Click += new System.EventHandler(this.lbl1name_Click);
            // 
            // lbl2name
            // 
            this.lbl2name.AutoSize = true;
            this.lbl2name.Location = new System.Drawing.Point(222, 65);
            this.lbl2name.Name = "lbl2name";
            this.lbl2name.Size = new System.Drawing.Size(79, 15);
            this.lbl2name.TabIndex = 1;
            this.lbl2name.Text = "Middle Name";
            this.lbl2name.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl3name
            // 
            this.lbl3name.AutoSize = true;
            this.lbl3name.Location = new System.Drawing.Point(421, 65);
            this.lbl3name.Name = "lbl3name";
            this.lbl3name.Size = new System.Drawing.Size(63, 15);
            this.lbl3name.TabIndex = 2;
            this.lbl3name.Text = "Last Name";
            this.lbl3name.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl4age
            // 
            this.lbl4age.AutoSize = true;
            this.lbl4age.Location = new System.Drawing.Point(684, 65);
            this.lbl4age.Name = "lbl4age";
            this.lbl4age.Size = new System.Drawing.Size(28, 15);
            this.lbl4age.TabIndex = 3;
            this.lbl4age.Text = "Age";
            // 
            // lbl5bdate
            // 
            this.lbl5bdate.AutoSize = true;
            this.lbl5bdate.Location = new System.Drawing.Point(26, 145);
            this.lbl5bdate.Name = "lbl5bdate";
            this.lbl5bdate.Size = new System.Drawing.Size(59, 15);
            this.lbl5bdate.TabIndex = 4;
            this.lbl5bdate.Text = "Birth Date";
            // 
            // lbl6number
            // 
            this.lbl6number.AutoSize = true;
            this.lbl6number.Location = new System.Drawing.Point(188, 145);
            this.lbl6number.Name = "lbl6number";
            this.lbl6number.Size = new System.Drawing.Size(96, 15);
            this.lbl6number.TabIndex = 5;
            this.lbl6number.Text = "Contact Number";
            // 
            // lbl7email
            // 
            this.lbl7email.AutoSize = true;
            this.lbl7email.Location = new System.Drawing.Point(421, 145);
            this.lbl7email.Name = "lbl7email";
            this.lbl7email.Size = new System.Drawing.Size(36, 15);
            this.lbl7email.TabIndex = 6;
            this.lbl7email.Text = "Email";
            this.lbl7email.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl9address
            // 
            this.lbl9address.AutoSize = true;
            this.lbl9address.Location = new System.Drawing.Point(26, 230);
            this.lbl9address.Name = "lbl9address";
            this.lbl9address.Size = new System.Drawing.Size(92, 15);
            this.lbl9address.TabIndex = 7;
            this.lbl9address.Text = "Current Address";
            // 
            // lbl8temp
            // 
            this.lbl8temp.AutoSize = true;
            this.lbl8temp.Location = new System.Drawing.Point(586, 145);
            this.lbl8temp.Name = "lbl8temp";
            this.lbl8temp.Size = new System.Drawing.Size(73, 15);
            this.lbl8temp.TabIndex = 8;
            this.lbl8temp.Text = "Temperature";
            // 
            // lbl10in
            // 
            this.lbl10in.AutoSize = true;
            this.lbl10in.Location = new System.Drawing.Point(325, 230);
            this.lbl10in.Name = "lbl10in";
            this.lbl10in.Size = new System.Drawing.Size(48, 15);
            this.lbl10in.TabIndex = 9;
            this.lbl10in.Text = "Time-In";
            // 
            // lbl11out
            // 
            this.lbl11out.AutoSize = true;
            this.lbl11out.Location = new System.Drawing.Point(432, 230);
            this.lbl11out.Name = "lbl11out";
            this.lbl11out.Size = new System.Drawing.Size(58, 15);
            this.lbl11out.TabIndex = 10;
            this.lbl11out.Text = "Time-Out";
            // 
            // lbl12visited
            // 
            this.lbl12visited.AutoSize = true;
            this.lbl12visited.Location = new System.Drawing.Point(541, 229);
            this.lbl12visited.Name = "lbl12visited";
            this.lbl12visited.Size = new System.Drawing.Size(97, 15);
            this.lbl12visited.TabIndex = 11;
            this.lbl12visited.Text = "Last Place Visited";
            // 
            // lbl16thanks
            // 
            this.lbl16thanks.AutoSize = true;
            this.lbl16thanks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl16thanks.Location = new System.Drawing.Point(325, 443);
            this.lbl16thanks.Name = "lbl16thanks";
            this.lbl16thanks.Size = new System.Drawing.Size(221, 20);
            this.lbl16thanks.TabIndex = 12;
            this.lbl16thanks.Text = "Thank you for your cooperation!";
            this.lbl16thanks.Click += new System.EventHandler(this.label13_Click);
            // 
            // lbl15city
            // 
            this.lbl15city.AutoSize = true;
            this.lbl15city.Location = new System.Drawing.Point(26, 393);
            this.lbl15city.Name = "lbl15city";
            this.lbl15city.Size = new System.Drawing.Size(506, 15);
            this.lbl15city.TabIndex = 13;
            this.lbl15city.Text = "3.) Did you go out of this city at the height of the pandemic for a vacation or a" +
    " walk? Yes or no?";
            // 
            // lbl13expe
            // 
            this.lbl13expe.AutoSize = true;
            this.lbl13expe.Location = new System.Drawing.Point(26, 297);
            this.lbl13expe.Name = "lbl13expe";
            this.lbl13expe.Size = new System.Drawing.Size(459, 15);
            this.lbl13expe.TabIndex = 14;
            this.lbl13expe.Text = "1.) Have you experienced symptomps of COVID 19, such as cough or fever? Yes or no" +
    "?";
            // 
            // lbl14colleagues
            // 
            this.lbl14colleagues.AutoSize = true;
            this.lbl14colleagues.Location = new System.Drawing.Point(26, 346);
            this.lbl14colleagues.Name = "lbl14colleagues";
            this.lbl14colleagues.Size = new System.Drawing.Size(441, 15);
            this.lbl14colleagues.TabIndex = 15;
            this.lbl14colleagues.Text = "2.) Do you have colleagues at home or work who have had such a virus? Yes or no?";
            // 
            // tbx1name
            // 
            this.tbx1name.Location = new System.Drawing.Point(96, 62);
            this.tbx1name.Name = "tbx1name";
            this.tbx1name.Size = new System.Drawing.Size(115, 23);
            this.tbx1name.TabIndex = 16;
            // 
            // tbx10in
            // 
            this.tbx10in.Location = new System.Drawing.Point(379, 227);
            this.tbx10in.Name = "tbx10in";
            this.tbx10in.Size = new System.Drawing.Size(47, 23);
            this.tbx10in.TabIndex = 17;
            // 
            // tbx13expe
            // 
            this.tbx13expe.Location = new System.Drawing.Point(491, 294);
            this.tbx13expe.Name = "tbx13expe";
            this.tbx13expe.Size = new System.Drawing.Size(100, 23);
            this.tbx13expe.TabIndex = 18;
            // 
            // tbx11out
            // 
            this.tbx11out.Location = new System.Drawing.Point(496, 227);
            this.tbx11out.Name = "tbx11out";
            this.tbx11out.Size = new System.Drawing.Size(39, 23);
            this.tbx11out.TabIndex = 19;
            // 
            // tbxtemp8
            // 
            this.tbxtemp8.Location = new System.Drawing.Point(665, 142);
            this.tbxtemp8.Name = "tbxtemp8";
            this.tbxtemp8.Size = new System.Drawing.Size(71, 23);
            this.tbxtemp8.TabIndex = 20;
            // 
            // tbx9address
            // 
            this.tbx9address.Location = new System.Drawing.Point(120, 227);
            this.tbx9address.Name = "tbx9address";
            this.tbx9address.Size = new System.Drawing.Size(206, 23);
            this.tbx9address.TabIndex = 21;
            // 
            // tbx7email
            // 
            this.tbx7email.Location = new System.Drawing.Point(473, 142);
            this.tbx7email.Name = "tbx7email";
            this.tbx7email.Size = new System.Drawing.Size(100, 23);
            this.tbx7email.TabIndex = 22;
            // 
            // tbx6number
            // 
            this.tbx6number.Location = new System.Drawing.Point(290, 142);
            this.tbx6number.Name = "tbx6number";
            this.tbx6number.Size = new System.Drawing.Size(117, 23);
            this.tbx6number.TabIndex = 23;
            // 
            // tbx5bdate
            // 
            this.tbx5bdate.Location = new System.Drawing.Point(91, 142);
            this.tbx5bdate.Name = "tbx5bdate";
            this.tbx5bdate.Size = new System.Drawing.Size(91, 23);
            this.tbx5bdate.TabIndex = 24;
            // 
            // tbx3name
            // 
            this.tbx3name.Location = new System.Drawing.Point(485, 62);
            this.tbx3name.Name = "tbx3name";
            this.tbx3name.Size = new System.Drawing.Size(180, 23);
            this.tbx3name.TabIndex = 25;
            // 
            // tbx2name
            // 
            this.tbx2name.Location = new System.Drawing.Point(307, 62);
            this.tbx2name.Name = "tbx2name";
            this.tbx2name.Size = new System.Drawing.Size(100, 23);
            this.tbx2name.TabIndex = 26;
            this.tbx2name.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // tbx14colleagues
            // 
            this.tbx14colleagues.Location = new System.Drawing.Point(473, 343);
            this.tbx14colleagues.Name = "tbx14colleagues";
            this.tbx14colleagues.Size = new System.Drawing.Size(100, 23);
            this.tbx14colleagues.TabIndex = 27;
            // 
            // tbx4age
            // 
            this.tbx4age.Location = new System.Drawing.Point(718, 62);
            this.tbx4age.Name = "tbx4age";
            this.tbx4age.Size = new System.Drawing.Size(51, 23);
            this.tbx4age.TabIndex = 28;
            this.tbx4age.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // tbx12visited
            // 
            this.tbx12visited.Location = new System.Drawing.Point(644, 226);
            this.tbx12visited.Name = "tbx12visited";
            this.tbx12visited.Size = new System.Drawing.Size(144, 23);
            this.tbx12visited.TabIndex = 29;
            // 
            // tbx15city
            // 
            this.tbx15city.Location = new System.Drawing.Point(538, 390);
            this.tbx15city.Name = "tbx15city";
            this.tbx15city.Size = new System.Drawing.Size(100, 23);
            this.tbx15city.TabIndex = 30;
            // 
            // bnt1save
            // 
            this.bnt1save.BackColor = System.Drawing.Color.Transparent;
            this.bnt1save.Location = new System.Drawing.Point(684, 418);
            this.bnt1save.Name = "bnt1save";
            this.bnt1save.Size = new System.Drawing.Size(104, 42);
            this.bnt1save.TabIndex = 31;
            this.bnt1save.Text = "Save Information";
            this.bnt1save.UseVisualStyleBackColor = false;
            this.bnt1save.Click += new System.EventHandler(this.bnt1save_Click);
            // 
            // lbl17title
            // 
            this.lbl17title.AutoSize = true;
            this.lbl17title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl17title.Location = new System.Drawing.Point(290, 9);
            this.lbl17title.Name = "lbl17title";
            this.lbl17title.Size = new System.Drawing.Size(229, 25);
            this.lbl17title.TabIndex = 32;
            this.lbl17title.Text = "CONTACT TRACING APP";
            // 
            // CTA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.lbl17title);
            this.Controls.Add(this.bnt1save);
            this.Controls.Add(this.tbx15city);
            this.Controls.Add(this.tbx12visited);
            this.Controls.Add(this.tbx4age);
            this.Controls.Add(this.tbx14colleagues);
            this.Controls.Add(this.tbx2name);
            this.Controls.Add(this.tbx3name);
            this.Controls.Add(this.tbx5bdate);
            this.Controls.Add(this.tbx6number);
            this.Controls.Add(this.tbx7email);
            this.Controls.Add(this.tbx9address);
            this.Controls.Add(this.tbxtemp8);
            this.Controls.Add(this.tbx11out);
            this.Controls.Add(this.tbx13expe);
            this.Controls.Add(this.tbx10in);
            this.Controls.Add(this.tbx1name);
            this.Controls.Add(this.lbl14colleagues);
            this.Controls.Add(this.lbl13expe);
            this.Controls.Add(this.lbl15city);
            this.Controls.Add(this.lbl16thanks);
            this.Controls.Add(this.lbl12visited);
            this.Controls.Add(this.lbl11out);
            this.Controls.Add(this.lbl10in);
            this.Controls.Add(this.lbl8temp);
            this.Controls.Add(this.lbl9address);
            this.Controls.Add(this.lbl7email);
            this.Controls.Add(this.lbl6number);
            this.Controls.Add(this.lbl5bdate);
            this.Controls.Add(this.lbl4age);
            this.Controls.Add(this.lbl3name);
            this.Controls.Add(this.lbl2name);
            this.Controls.Add(this.lbl1name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CTA1";
            this.Text = "My Contact Tracing App";
            this.Load += new System.EventHandler(this.CTA1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1name;
        private Label lbl2name;
        private Label lbl3name;
        private Label lbl4age;
        private Label lbl5bdate;
        private Label lbl6number;
        private Label lbl7email;
        private Label lbl9address;
        private Label lbl8temp;
        private Label lbl10in;
        private Label lbl11out;
        private Label lbl12visited;
        private Label lbl16thanks;
        private Label lbl15city;
        private Label lbl13expe;
        private Label lbl14colleagues;
        private TextBox tbx1name;
        private TextBox tbx10in;
        private TextBox tbx13expe;
        private TextBox tbx11out;
        private TextBox tbxtemp8;
        private TextBox tbx9address;
        private TextBox tbx7email;
        private TextBox tbx6number;
        private TextBox tbx5bdate;
        private TextBox tbx3name;
        private TextBox tbx2name;
        private TextBox tbx14colleagues;
        private TextBox tbx4age;
        private TextBox tbx12visited;
        private TextBox tbx15city;
        private Button bnt1save;
        private Label lbl17title;
    }
}