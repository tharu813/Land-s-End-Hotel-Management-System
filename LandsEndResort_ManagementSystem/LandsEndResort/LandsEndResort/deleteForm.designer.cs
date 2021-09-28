namespace loginformp
{
    partial class deleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteForm));
            this.deletelbl = new System.Windows.Forms.Label();
            this.uID = new System.Windows.Forms.Label();
            this.deletetxt = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deletelbl
            // 
            this.deletelbl.AutoSize = true;
            this.deletelbl.BackColor = System.Drawing.Color.Transparent;
            this.deletelbl.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletelbl.Location = new System.Drawing.Point(177, 41);
            this.deletelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deletelbl.Name = "deletelbl";
            this.deletelbl.Size = new System.Drawing.Size(195, 24);
            this.deletelbl.TabIndex = 0;
            this.deletelbl.Text = "DELETE ACCOUNT";
            // 
            // uID
            // 
            this.uID.AutoSize = true;
            this.uID.BackColor = System.Drawing.Color.Transparent;
            this.uID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uID.Location = new System.Drawing.Point(101, 140);
            this.uID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uID.Name = "uID";
            this.uID.Size = new System.Drawing.Size(89, 20);
            this.uID.TabIndex = 1;
            this.uID.Text = "USER ID";
            // 
            // deletetxt
            // 
            this.deletetxt.Location = new System.Drawing.Point(271, 140);
            this.deletetxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletetxt.Name = "deletetxt";
            this.deletetxt.Size = new System.Drawing.Size(176, 22);
            this.deletetxt.TabIndex = 2;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.White;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(183, 204);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(192, 32);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "DELETE ACCOUNT";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // deleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 514);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.deletetxt);
            this.Controls.Add(this.uID);
            this.Controls.Add(this.deletelbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "deleteForm";
            this.Text = "deleteForm";
            this.Load += new System.EventHandler(this.deleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deletelbl;
        private System.Windows.Forms.Label uID;
        private System.Windows.Forms.TextBox deletetxt;
        private System.Windows.Forms.Button deletebtn;
    }
}