namespace My_Own_Version_of_Contact_Tracing_App
{
    partial class Form3
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
            this.btnqr1 = new System.Windows.Forms.Button();
            this.lblqr1 = new System.Windows.Forms.Label();
            this.comp1 = new System.Windows.Forms.ComboBox();
            this.pctb1 = new System.Windows.Forms.PictureBox();
            this.tbxqr1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnqr1
            // 
            this.btnqr1.Location = new System.Drawing.Point(128, 68);
            this.btnqr1.Name = "btnqr1";
            this.btnqr1.Size = new System.Drawing.Size(75, 23);
            this.btnqr1.TabIndex = 0;
            this.btnqr1.Text = "SEARCH";
            this.btnqr1.UseVisualStyleBackColor = true;
            this.btnqr1.Click += new System.EventHandler(this.btnqr1_Click);
            // 
            // lblqr1
            // 
            this.lblqr1.AutoSize = true;
            this.lblqr1.Location = new System.Drawing.Point(400, 68);
            this.lblqr1.Name = "lblqr1";
            this.lblqr1.Size = new System.Drawing.Size(58, 15);
            this.lblqr1.TabIndex = 1;
            this.lblqr1.Text = "CAMERA:";
            // 
            // comp1
            // 
            this.comp1.FormattingEnabled = true;
            this.comp1.Location = new System.Drawing.Point(464, 65);
            this.comp1.Name = "comp1";
            this.comp1.Size = new System.Drawing.Size(192, 23);
            this.comp1.TabIndex = 2;
            this.comp1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pctb1
            // 
            this.pctb1.Location = new System.Drawing.Point(336, 113);
            this.pctb1.Name = "pctb1";
            this.pctb1.Size = new System.Drawing.Size(383, 313);
            this.pctb1.TabIndex = 3;
            this.pctb1.TabStop = false;
            // 
            // tbxqr1
            // 
            this.tbxqr1.Location = new System.Drawing.Point(44, 113);
            this.tbxqr1.Multiline = true;
            this.tbxqr1.Name = "tbxqr1";
            this.tbxqr1.Size = new System.Drawing.Size(245, 313);
            this.tbxqr1.TabIndex = 4;
            this.tbxqr1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.tbxqr1);
            this.Controls.Add(this.pctb1);
            this.Controls.Add(this.comp1);
            this.Controls.Add(this.lblqr1);
            this.Controls.Add(this.btnqr1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnqr1;
        private Label lblqr1;
        private ComboBox comp1;
        private PictureBox pctb1;
        private TextBox tbxqr1;
    }
}