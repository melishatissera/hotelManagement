namespace login
{
    partial class Frmcrtus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcrtus));
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Button1 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbadmin = new System.Windows.Forms.RadioButton();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Button5 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.txtitm = new System.Windows.Forms.TextBox();
            this.txtupd = new System.Windows.Forms.TextBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button1.Location = new System.Drawing.Point(12, 477);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(164, 43);
            this.Button1.TabIndex = 48;
            this.Button1.Text = "Select Photo";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label5.Location = new System.Drawing.Point(301, 26);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(257, 33);
            this.Label5.TabIndex = 36;
            this.Label5.Text = "User handling window";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbadmin);
            this.GroupBox1.Controls.Add(this.rb0);
            this.GroupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox1.Location = new System.Drawing.Point(278, 291);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(211, 102);
            this.GroupBox1.TabIndex = 40;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Type";
            // 
            // rbadmin
            // 
            this.rbadmin.AutoSize = true;
            this.rbadmin.BackColor = System.Drawing.Color.Transparent;
            this.rbadmin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbadmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbadmin.Location = new System.Drawing.Point(6, 19);
            this.rbadmin.Name = "rbadmin";
            this.rbadmin.Size = new System.Drawing.Size(78, 27);
            this.rbadmin.TabIndex = 29;
            this.rbadmin.TabStop = true;
            this.rbadmin.Text = "Admin";
            this.rbadmin.UseVisualStyleBackColor = false;
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.BackColor = System.Drawing.Color.Transparent;
            this.rb0.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb0.Location = new System.Drawing.Point(6, 57);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(115, 27);
            this.rb0.TabIndex = 30;
            this.rb0.TabStop = true;
            this.rb0.Text = "Guest user ";
            this.rb0.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(14, 291);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 23);
            this.Label4.TabIndex = 46;
            this.Label4.Text = "User Type";
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.Black;
            this.Button5.Location = new System.Drawing.Point(419, 476);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(139, 44);
            this.Button5.TabIndex = 42;
            this.Button5.Text = "Create user";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(510, 99);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(324, 340);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 47;
            this.PictureBox1.TabStop = false;
            // 
            // ErrorProvider2
            // 
            this.ErrorProvider2.ContainerControl = this;
            this.ErrorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider2.Icon")));
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(14, 228);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(150, 23);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "ReEnter Password";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(14, 183);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 23);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(14, 134);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 23);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "User name";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox1.Location = new System.Drawing.Point(284, 182);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '*';
            this.TextBox1.Size = new System.Drawing.Size(205, 31);
            this.TextBox1.TabIndex = 38;
            this.TextBox1.Text = "password";
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button4.Location = new System.Drawing.Point(212, 476);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(168, 44);
            this.Button4.TabIndex = 41;
            this.Button4.Text = "Change Password ";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // txtitm
            // 
            this.txtitm.BackColor = System.Drawing.SystemColors.Info;
            this.txtitm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtitm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtitm.Location = new System.Drawing.Point(284, 132);
            this.txtitm.Name = "txtitm";
            this.txtitm.Size = new System.Drawing.Size(205, 31);
            this.txtitm.TabIndex = 37;
            this.txtitm.Text = "Enter Username";
            // 
            // txtupd
            // 
            this.txtupd.BackColor = System.Drawing.SystemColors.Info;
            this.txtupd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtupd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtupd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtupd.Location = new System.Drawing.Point(284, 227);
            this.txtupd.Name = "txtupd";
            this.txtupd.PasswordChar = '*';
            this.txtupd.Size = new System.Drawing.Size(205, 31);
            this.txtupd.TabIndex = 39;
            this.txtupd.Text = "ReEnter password";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // Frmcrtus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 532);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.txtitm);
            this.Controls.Add(this.txtupd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcrtus";
            this.Text = "Club Palm Bay Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ErrorProvider ErrorProvider1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rbadmin;
        internal System.Windows.Forms.RadioButton rb0;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.TextBox txtitm;
        internal System.Windows.Forms.TextBox txtupd;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.ErrorProvider ErrorProvider2;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
    }
}