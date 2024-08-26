
namespace LibraryManagementSystem
{
    partial class AddBooksForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooksForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CountTxt = new System.Windows.Forms.TextBox();
            this.addBooks_clearBtn = new System.Windows.Forms.Button();
            this.addBooks_deleteBtn = new System.Windows.Forms.Button();
            this.addBooks_published = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.addBooks_updateBtn = new System.Windows.Forms.Button();
            this.addBooks_addBtn = new System.Windows.Forms.Button();
            this.addBooks_author = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBooks_bookTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(311, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 526);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(3, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(545, 460);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Books";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CountTxt);
            this.panel1.Controls.Add(this.addBooks_clearBtn);
            this.panel1.Controls.Add(this.addBooks_deleteBtn);
            this.panel1.Controls.Add(this.addBooks_published);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addBooks_updateBtn);
            this.panel1.Controls.Add(this.addBooks_addBtn);
            this.panel1.Controls.Add(this.addBooks_author);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.addBooks_bookTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(14, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 526);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Count:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountTxt
            // 
            this.CountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountTxt.Location = new System.Drawing.Point(94, 331);
            this.CountTxt.Name = "CountTxt";
            this.CountTxt.Size = new System.Drawing.Size(168, 22);
            this.CountTxt.TabIndex = 24;
            // 
            // addBooks_clearBtn
            // 
            this.addBooks_clearBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addBooks_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBooks_clearBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBooks_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBooks_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_clearBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_clearBtn.Location = new System.Drawing.Point(27, 475);
            this.addBooks_clearBtn.Name = "addBooks_clearBtn";
            this.addBooks_clearBtn.Size = new System.Drawing.Size(96, 34);
            this.addBooks_clearBtn.TabIndex = 22;
            this.addBooks_clearBtn.Text = "CLEAR";
            this.addBooks_clearBtn.UseVisualStyleBackColor = false;
            this.addBooks_clearBtn.Click += new System.EventHandler(this.addBooks_clearBtn_Click);
            // 
            // addBooks_deleteBtn
            // 
            this.addBooks_deleteBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addBooks_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBooks_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBooks_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBooks_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_deleteBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_deleteBtn.Location = new System.Drawing.Point(156, 475);
            this.addBooks_deleteBtn.Name = "addBooks_deleteBtn";
            this.addBooks_deleteBtn.Size = new System.Drawing.Size(96, 34);
            this.addBooks_deleteBtn.TabIndex = 21;
            this.addBooks_deleteBtn.Text = "DELETE";
            this.addBooks_deleteBtn.UseVisualStyleBackColor = false;
            this.addBooks_deleteBtn.Click += new System.EventHandler(this.addBooks_deleteBtn_Click);
            // 
            // addBooks_published
            // 
            this.addBooks_published.Location = new System.Drawing.Point(95, 293);
            this.addBooks_published.Name = "addBooks_published";
            this.addBooks_published.Size = new System.Drawing.Size(167, 20);
            this.addBooks_published.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Published:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBooks_updateBtn
            // 
            this.addBooks_updateBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addBooks_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBooks_updateBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBooks_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBooks_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_updateBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_updateBtn.Location = new System.Drawing.Point(27, 418);
            this.addBooks_updateBtn.Name = "addBooks_updateBtn";
            this.addBooks_updateBtn.Size = new System.Drawing.Size(96, 34);
            this.addBooks_updateBtn.TabIndex = 16;
            this.addBooks_updateBtn.Text = "UPDATE";
            this.addBooks_updateBtn.UseVisualStyleBackColor = false;
            this.addBooks_updateBtn.Click += new System.EventHandler(this.addBooks_updateBtn_Click);
            // 
            // addBooks_addBtn
            // 
            this.addBooks_addBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addBooks_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBooks_addBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBooks_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBooks_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_addBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_addBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_addBtn.Location = new System.Drawing.Point(156, 418);
            this.addBooks_addBtn.Name = "addBooks_addBtn";
            this.addBooks_addBtn.Size = new System.Drawing.Size(96, 34);
            this.addBooks_addBtn.TabIndex = 15;
            this.addBooks_addBtn.Text = "ADD";
            this.addBooks_addBtn.UseVisualStyleBackColor = false;
            this.addBooks_addBtn.Click += new System.EventHandler(this.addBooks_addBtn_Click);
            // 
            // addBooks_author
            // 
            this.addBooks_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_author.Location = new System.Drawing.Point(94, 255);
            this.addBooks_author.Name = "addBooks_author";
            this.addBooks_author.Size = new System.Drawing.Size(168, 22);
            this.addBooks_author.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Author:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBooks_bookTitle
            // 
            this.addBooks_bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_bookTitle.Location = new System.Drawing.Point(94, 210);
            this.addBooks_bookTitle.Name = "addBooks_bookTitle";
            this.addBooks_bookTitle.Size = new System.Drawing.Size(168, 22);
            this.addBooks_bookTitle.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Book TItle:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddBooksForm";
            this.Size = new System.Drawing.Size(880, 619);
            this.Load += new System.EventHandler(this.AddBooksForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBooks_updateBtn;
        private System.Windows.Forms.Button addBooks_addBtn;
        private System.Windows.Forms.TextBox addBooks_author;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addBooks_bookTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker addBooks_published;
        private System.Windows.Forms.Button addBooks_clearBtn;
        private System.Windows.Forms.Button addBooks_deleteBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CountTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
