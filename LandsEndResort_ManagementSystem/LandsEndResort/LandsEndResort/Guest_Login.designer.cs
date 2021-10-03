namespace loginformp
{
    partial class Guest_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_Login));
            this.uNametxt = new System.Windows.Forms.TextBox();
            this.pwordtxt = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.pwordlbl = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.guestlbl = new System.Windows.Forms.Label();
            this.hnamelbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // uNametxt
            // 
            this.uNametxt.BackColor = System.Drawing.Color.White;
            this.uNametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uNametxt.ForeColor = System.Drawing.Color.Black;
            this.uNametxt.Location = new System.Drawing.Point(128, 262);
            this.uNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.uNametxt.Name = "uNametxt";
            this.uNametxt.Size = new System.Drawing.Size(285, 22);
            this.uNametxt.TabIndex = 1;
            this.uNametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pwordtxt
            // 
            this.pwordtxt.BackColor = System.Drawing.Color.White;
            this.pwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwordtxt.Location = new System.Drawing.Point(128, 404);
            this.pwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.pwordtxt.Name = "pwordtxt";
            this.pwordtxt.PasswordChar = '*';
            this.pwordtxt.Size = new System.Drawing.Size(285, 22);
            this.pwordtxt.TabIndex = 2;
            this.pwordtxt.TextChanged += new System.EventHandler(this.pwordtxt_TextChanged);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.BackColor = System.Drawing.Color.Transparent;
            this.namelbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.White;
            this.namelbl.Location = new System.Drawing.Point(123, 222);
            this.namelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(122, 23);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "USER NAME";
            this.namelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // pwordlbl
            // 
            this.pwordlbl.AutoSize = true;
            this.pwordlbl.BackColor = System.Drawing.Color.Transparent;
            this.pwordlbl.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwordlbl.ForeColor = System.Drawing.Color.White;
            this.pwordlbl.Location = new System.Drawing.Point(124, 357);
            this.pwordlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwordlbl.Name = "pwordlbl";
            this.pwordlbl.Size = new System.Drawing.Size(106, 23);
            this.pwordlbl.TabIndex = 4;
            this.pwordlbl.Text = "PASSWORD";
            this.pwordlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Black;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(205, 462);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(132, 38);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // guestlbl
            // 
            this.guestlbl.AutoSize = true;
            this.guestlbl.BackColor = System.Drawing.Color.Transparent;
            this.guestlbl.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestlbl.ForeColor = System.Drawing.Color.Black;
            this.guestlbl.Location = new System.Drawing.Point(173, 54);
            this.guestlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestlbl.Name = "guestlbl";
            this.guestlbl.Size = new System.Drawing.Size(193, 26);
            this.guestlbl.TabIndex = 6;
            this.guestlbl.Text = "GUEST LOGIN";
            this.guestlbl.Click += new System.EventHandler(this.guestlbl_Click);
            // 
            // hnamelbl
            // 
            this.hnamelbl.AutoSize = true;
            this.hnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.hnamelbl.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hnamelbl.ForeColor = System.Drawing.Color.White;
            this.hnamelbl.Location = new System.Drawing.Point(7, 564);
            this.hnamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hnamelbl.Name = "hnamelbl";
            this.hnamelbl.Size = new System.Drawing.Size(231, 23);
            this.hnamelbl.TabIndex = 10;
            this.hnamelbl.Text = "Land\'s End Resorts & Spa";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(39, 508);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgotten Password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(307, 508);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(148, 20);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Delete Account?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Guest_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 596);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.hnamelbl);
            this.Controls.Add(this.guestlbl);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pwordlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.pwordtxt);
            this.Controls.Add(this.uNametxt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Guest_Login";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uNametxt;
        private System.Windows.Forms.TextBox pwordtxt;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label pwordlbl;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label guestlbl;
        private System.Windows.Forms.Label hnamelbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

