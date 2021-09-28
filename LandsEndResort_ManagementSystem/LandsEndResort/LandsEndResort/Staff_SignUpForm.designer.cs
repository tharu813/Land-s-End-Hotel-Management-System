namespace Staff_Registration
{
    partial class Staff_SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_SignUpForm));
            this.Registerlbl = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.lblrname = new System.Windows.Forms.Label();
            this.btnstaffRegister = new System.Windows.Forms.Button();
            this.TxtPost = new System.Windows.Forms.TextBox();
            this.LblPost = new System.Windows.Forms.Label();
            this.TxtDept = new System.Windows.Forms.TextBox();
            this.LblDept = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtLname = new System.Windows.Forms.TextBox();
            this.TxtFname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Registerlbl
            // 
            this.Registerlbl.AutoSize = true;
            this.Registerlbl.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerlbl.Location = new System.Drawing.Point(311, 50);
            this.Registerlbl.Name = "Registerlbl";
            this.Registerlbl.Size = new System.Drawing.Size(256, 24);
            this.Registerlbl.TabIndex = 0;
            this.Registerlbl.Text = "STAFF REGISTRATION FORM";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(212, 122);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(92, 23);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "First Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BackButton);
            this.groupBox1.Controls.Add(this.lblrname);
            this.groupBox1.Controls.Add(this.btnstaffRegister);
            this.groupBox1.Controls.Add(this.TxtPost);
            this.groupBox1.Controls.Add(this.LblPost);
            this.groupBox1.Controls.Add(this.TxtDept);
            this.groupBox1.Controls.Add(this.LblDept);
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.TxtContact);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtPW);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtLname);
            this.groupBox1.Controls.Add(this.TxtFname);
            this.groupBox1.Controls.Add(this.Registerlbl);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 730);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(813, 671);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(53, 46);
            this.BackButton.TabIndex = 18;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // lblrname
            // 
            this.lblrname.AutoSize = true;
            this.lblrname.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrname.Location = new System.Drawing.Point(0, 704);
            this.lblrname.Name = "lblrname";
            this.lblrname.Size = new System.Drawing.Size(168, 23);
            this.lblrname.TabIndex = 17;
            this.lblrname.Text = "Land\'s End Resort n Spa";
            // 
            // btnstaffRegister
            // 
            this.btnstaffRegister.BackColor = System.Drawing.Color.Silver;
            this.btnstaffRegister.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaffRegister.Location = new System.Drawing.Point(367, 596);
            this.btnstaffRegister.Name = "btnstaffRegister";
            this.btnstaffRegister.Size = new System.Drawing.Size(131, 34);
            this.btnstaffRegister.TabIndex = 3;
            this.btnstaffRegister.Text = "SIGN UP";
            this.btnstaffRegister.UseVisualStyleBackColor = false;
            this.btnstaffRegister.Click += new System.EventHandler(this.btnstaffRegister_Click);
            // 
            // TxtPost
            // 
            this.TxtPost.BackColor = System.Drawing.Color.White;
            this.TxtPost.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPost.Location = new System.Drawing.Point(452, 526);
            this.TxtPost.Name = "TxtPost";
            this.TxtPost.Size = new System.Drawing.Size(212, 25);
            this.TxtPost.TabIndex = 16;
            // 
            // LblPost
            // 
            this.LblPost.AutoSize = true;
            this.LblPost.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPost.Location = new System.Drawing.Point(212, 531);
            this.LblPost.Name = "LblPost";
            this.LblPost.Size = new System.Drawing.Size(43, 23);
            this.LblPost.TabIndex = 15;
            this.LblPost.Text = "Post";
            // 
            // TxtDept
            // 
            this.TxtDept.BackColor = System.Drawing.Color.White;
            this.TxtDept.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDept.Location = new System.Drawing.Point(452, 465);
            this.TxtDept.Name = "TxtDept";
            this.TxtDept.Size = new System.Drawing.Size(212, 25);
            this.TxtDept.TabIndex = 14;
            // 
            // LblDept
            // 
            this.LblDept.AutoSize = true;
            this.LblDept.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDept.Location = new System.Drawing.Point(212, 470);
            this.LblDept.Name = "LblDept";
            this.LblDept.Size = new System.Drawing.Size(102, 23);
            this.LblDept.TabIndex = 13;
            this.LblDept.Text = "Department";
            // 
            // TxtAddress
            // 
            this.TxtAddress.BackColor = System.Drawing.Color.White;
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(452, 403);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(212, 23);
            this.TxtAddress.TabIndex = 12;
            // 
            // TxtContact
            // 
            this.TxtContact.BackColor = System.Drawing.Color.White;
            this.TxtContact.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContact.Location = new System.Drawing.Point(452, 340);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(212, 25);
            this.TxtContact.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(212, 340);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(138, 23);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name";
            // 
            // TxtPW
            // 
            this.TxtPW.BackColor = System.Drawing.Color.White;
            this.TxtPW.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPW.Location = new System.Drawing.Point(452, 285);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(212, 25);
            this.TxtPW.TabIndex = 5;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.White;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(452, 224);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(212, 25);
            this.TxtEmail.TabIndex = 4;
            // 
            // TxtLname
            // 
            this.TxtLname.BackColor = System.Drawing.Color.White;
            this.TxtLname.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLname.Location = new System.Drawing.Point(452, 170);
            this.TxtLname.Name = "TxtLname";
            this.TxtLname.Size = new System.Drawing.Size(212, 25);
            this.TxtLname.TabIndex = 3;
            // 
            // TxtFname
            // 
            this.TxtFname.BackColor = System.Drawing.Color.White;
            this.TxtFname.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFname.Location = new System.Drawing.Point(452, 117);
            this.TxtFname.Name = "TxtFname";
            this.TxtFname.Size = new System.Drawing.Size(212, 25);
            this.TxtFname.TabIndex = 2;
            this.TxtFname.TextChanged += new System.EventHandler(this.TxtFname_TextChanged);
            // 
            // Staff_SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 754);
            this.Controls.Add(this.groupBox1);
            this.Name = "Staff_SignUpForm";
            this.Text = "Member Registration";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Staff_SignUpForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Registerlbl;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtLname;
        private System.Windows.Forms.TextBox TxtFname;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnstaffRegister;
        private System.Windows.Forms.TextBox TxtPost;
        private System.Windows.Forms.Label LblPost;
        private System.Windows.Forms.TextBox TxtDept;
        private System.Windows.Forms.Label LblDept;
        private System.Windows.Forms.Label lblrname;
        private System.Windows.Forms.Button BackButton;
    }
}

