namespace LibraryManagementSystem
{
    partial class RegisterationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.signINBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.Register_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Register_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterPassTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Register_showPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 47);
            this.panel1.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Appearance.BackColor = System.Drawing.Color.Purple;
            this.btn_Close.Appearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_Close.Appearance.Options.UseBackColor = true;
            this.btn_Close.Appearance.Options.UseBorderColor = true;
            this.btn_Close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.ImageOptions.Image")));
            this.btn_Close.Location = new System.Drawing.Point(370, 4);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Close.Size = new System.Drawing.Size(46, 43);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // signINBtn
            // 
            this.signINBtn.BackColor = System.Drawing.Color.Purple;
            this.signINBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signINBtn.FlatAppearance.BorderSize = 0;
            this.signINBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.signINBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.signINBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signINBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signINBtn.ForeColor = System.Drawing.Color.White;
            this.signINBtn.Location = new System.Drawing.Point(14, 593);
            this.signINBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signINBtn.Name = "signINBtn";
            this.signINBtn.Size = new System.Drawing.Size(391, 38);
            this.signINBtn.TabIndex = 19;
            this.signINBtn.Text = "SIGNIN";
            this.signINBtn.UseVisualStyleBackColor = false;
            this.signINBtn.Click += new System.EventHandler(this.signINBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 572);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Register Account";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.Purple;
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(14, 516);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(391, 41);
            this.RegisterBtn.TabIndex = 17;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // Register_Name
            // 
            this.Register_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Name.Location = new System.Drawing.Point(14, 377);
            this.Register_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_Name.Multiline = true;
            this.Register_Name.Name = "Register_Name";
            this.Register_Name.Size = new System.Drawing.Size(390, 36);
            this.Register_Name.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 417);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // Register_Email
            // 
            this.Register_Email.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Email.Location = new System.Drawing.Point(14, 310);
            this.Register_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_Email.Multiline = true;
            this.Register_Email.Name = "Register_Email";
            this.Register_Email.Size = new System.Drawing.Size(390, 36);
            this.Register_Email.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registration From";
            // 
            // RegisterPassTxt
            // 
            this.RegisterPassTxt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPassTxt.Location = new System.Drawing.Point(14, 439);
            this.RegisterPassTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterPassTxt.Multiline = true;
            this.RegisterPassTxt.Name = "RegisterPassTxt";
            this.RegisterPassTxt.PasswordChar = '*';
            this.RegisterPassTxt.Size = new System.Drawing.Size(390, 36);
            this.RegisterPassTxt.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email:";
            // 
            // Register_showPass
            // 
            this.Register_showPass.AutoSize = true;
            this.Register_showPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_showPass.Location = new System.Drawing.Point(268, 484);
            this.Register_showPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_showPass.Name = "Register_showPass";
            this.Register_showPass.Size = new System.Drawing.Size(148, 25);
            this.Register_showPass.TabIndex = 24;
            this.Register_showPass.Text = "Show Password";
            this.Register_showPass.UseVisualStyleBackColor = true;
            this.Register_showPass.CheckedChanged += new System.EventHandler(this.Register_showPass_CheckedChanged);
            // 
            // RegisterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 646);
            this.Controls.Add(this.Register_showPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegisterPassTxt);
            this.Controls.Add(this.signINBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.Register_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Register_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterationForm";
            this.Load += new System.EventHandler(this.RegisterationForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signINBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox Register_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Register_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Register_showPass;
        private System.Windows.Forms.TextBox RegisterPassTxt;
    }
}