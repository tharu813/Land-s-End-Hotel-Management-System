namespace loginformp
{
    partial class updateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.Label();
            this.nwpword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userIDtxt = new System.Windows.Forms.TextBox();
            this.nwpwordtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE PASSWORD";
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.BackColor = System.Drawing.Color.Transparent;
            this.userID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.Location = new System.Drawing.Point(75, 158);
            this.userID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(89, 20);
            this.userID.TabIndex = 1;
            this.userID.Text = "USER ID";
            this.userID.Click += new System.EventHandler(this.label2_Click);
            // 
            // nwpword
            // 
            this.nwpword.AutoSize = true;
            this.nwpword.BackColor = System.Drawing.Color.Transparent;
            this.nwpword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwpword.Location = new System.Drawing.Point(75, 244);
            this.nwpword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nwpword.Name = "nwpword";
            this.nwpword.Size = new System.Drawing.Size(169, 20);
            this.nwpword.TabIndex = 2;
            this.nwpword.Text = "NEW PASSWORD";
            this.nwpword.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userIDtxt
            // 
            this.userIDtxt.Location = new System.Drawing.Point(272, 156);
            this.userIDtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userIDtxt.Name = "userIDtxt";
            this.userIDtxt.Size = new System.Drawing.Size(168, 22);
            this.userIDtxt.TabIndex = 6;
            this.userIDtxt.TextChanged += new System.EventHandler(this.userIDtxt_TextChanged);
            // 
            // nwpwordtxt
            // 
            this.nwpwordtxt.Location = new System.Drawing.Point(272, 239);
            this.nwpwordtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nwpwordtxt.Name = "nwpwordtxt";
            this.nwpwordtxt.Size = new System.Drawing.Size(168, 22);
            this.nwpwordtxt.TabIndex = 7;
            this.nwpwordtxt.TextChanged += new System.EventHandler(this.nwpwordtxt_TextChanged);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 554);
            this.Controls.Add(this.nwpwordtxt);
            this.Controls.Add(this.userIDtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nwpword);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "updateForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.Label nwpword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userIDtxt;
        private System.Windows.Forms.TextBox nwpwordtxt;
    }
}