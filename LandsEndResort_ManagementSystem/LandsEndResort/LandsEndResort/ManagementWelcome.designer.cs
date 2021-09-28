namespace HotelManagementSystem
{
    partial class ManagementWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementWelcome));
            this.lbl_mgmtwlcm = new System.Windows.Forms.Label();
            this.radioButton_order = new System.Windows.Forms.RadioButton();
            this.radioButton_lreq = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_mgmtwlcm
            // 
            this.lbl_mgmtwlcm.AutoSize = true;
            this.lbl_mgmtwlcm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mgmtwlcm.Font = new System.Drawing.Font("Matura MT Script Capitals", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mgmtwlcm.Location = new System.Drawing.Point(432, 122);
            this.lbl_mgmtwlcm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mgmtwlcm.Name = "lbl_mgmtwlcm";
            this.lbl_mgmtwlcm.Size = new System.Drawing.Size(292, 36);
            this.lbl_mgmtwlcm.TabIndex = 0;
            this.lbl_mgmtwlcm.Text = "Select what you want";
            // 
            // radioButton_order
            // 
            this.radioButton_order.AutoSize = true;
            this.radioButton_order.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_order.Location = new System.Drawing.Point(537, 281);
            this.radioButton_order.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_order.Name = "radioButton_order";
            this.radioButton_order.Size = new System.Drawing.Size(119, 24);
            this.radioButton_order.TabIndex = 2;
            this.radioButton_order.Text = "View orders";
            this.radioButton_order.UseVisualStyleBackColor = false;
            this.radioButton_order.CheckedChanged += new System.EventHandler(this.radioButton_order_CheckedChanged);
            // 
            // radioButton_lreq
            // 
            this.radioButton_lreq.AutoSize = true;
            this.radioButton_lreq.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_lreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_lreq.Location = new System.Drawing.Point(537, 367);
            this.radioButton_lreq.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_lreq.Name = "radioButton_lreq";
            this.radioButton_lreq.Size = new System.Drawing.Size(191, 24);
            this.radioButton_lreq.TabIndex = 3;
            this.radioButton_lreq.Text = "Check leave requests";
            this.radioButton_lreq.UseVisualStyleBackColor = false;
            this.radioButton_lreq.CheckedChanged += new System.EventHandler(this.radioButton_lreq_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(537, 207);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(166, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "Check Complaints";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // ManagementWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton_lreq);
            this.Controls.Add(this.radioButton_order);
            this.Controls.Add(this.lbl_mgmtwlcm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagementWelcome";
            this.Text = "ManagementWelcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mgmtwlcm;
        private System.Windows.Forms.RadioButton radioButton_order;
        private System.Windows.Forms.RadioButton radioButton_lreq;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}