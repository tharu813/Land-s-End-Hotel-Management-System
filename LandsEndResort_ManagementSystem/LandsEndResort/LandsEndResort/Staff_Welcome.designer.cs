namespace HotelManagementSystem
{
    partial class Staff_Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Welcome));
            this.lbl_swelcome = new System.Windows.Forms.Label();
            this.lbl_srequirement = new System.Windows.Forms.Label();
            this.radbtn_leaves = new System.Windows.Forms.RadioButton();
            this.radbtn_transport = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_swelcome
            // 
            this.lbl_swelcome.AutoSize = true;
            this.lbl_swelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_swelcome.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_swelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_swelcome.Location = new System.Drawing.Point(144, 62);
            this.lbl_swelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_swelcome.Name = "lbl_swelcome";
            this.lbl_swelcome.Size = new System.Drawing.Size(523, 36);
            this.lbl_swelcome.TabIndex = 0;
            this.lbl_swelcome.Text = "Staff Management System";
            this.lbl_swelcome.UseWaitCursor = true;
            // 
            // lbl_srequirement
            // 
            this.lbl_srequirement.AutoSize = true;
            this.lbl_srequirement.BackColor = System.Drawing.Color.Transparent;
            this.lbl_srequirement.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srequirement.Location = new System.Drawing.Point(261, 166);
            this.lbl_srequirement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_srequirement.Name = "lbl_srequirement";
            this.lbl_srequirement.Size = new System.Drawing.Size(339, 38);
            this.lbl_srequirement.TabIndex = 1;
            this.lbl_srequirement.Text = "Select your Requirement";
            // 
            // radbtn_leaves
            // 
            this.radbtn_leaves.AutoSize = true;
            this.radbtn_leaves.BackColor = System.Drawing.Color.Transparent;
            this.radbtn_leaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_leaves.Location = new System.Drawing.Point(330, 373);
            this.radbtn_leaves.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radbtn_leaves.Name = "radbtn_leaves";
            this.radbtn_leaves.Size = new System.Drawing.Size(103, 29);
            this.radbtn_leaves.TabIndex = 3;
            this.radbtn_leaves.Text = "Leaves";
            this.radbtn_leaves.UseVisualStyleBackColor = false;
            this.radbtn_leaves.CheckedChanged += new System.EventHandler(this.radbtn_leaves_CheckedChanged);
            // 
            // radbtn_transport
            // 
            this.radbtn_transport.AutoSize = true;
            this.radbtn_transport.BackColor = System.Drawing.Color.Transparent;
            this.radbtn_transport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_transport.Location = new System.Drawing.Point(330, 481);
            this.radbtn_transport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radbtn_transport.Name = "radbtn_transport";
            this.radbtn_transport.Size = new System.Drawing.Size(239, 29);
            this.radbtn_transport.TabIndex = 4;
            this.radbtn_transport.Text = "Transport Information";
            this.radbtn_transport.UseVisualStyleBackColor = false;
            this.radbtn_transport.CheckedChanged += new System.EventHandler(this.radbtn_transport_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(330, 284);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(197, 29);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Salary/Payments";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeBtn.Location = new System.Drawing.Point(15, 580);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(76, 44);
            this.HomeBtn.TabIndex = 6;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Staff_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 638);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radbtn_transport);
            this.Controls.Add(this.radbtn_leaves);
            this.Controls.Add(this.lbl_srequirement);
            this.Controls.Add(this.lbl_swelcome);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Staff_Welcome";
            this.Text = "Staff_Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_swelcome;
        private System.Windows.Forms.Label lbl_srequirement;
        private System.Windows.Forms.RadioButton radbtn_leaves;
        private System.Windows.Forms.RadioButton radbtn_transport;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button HomeBtn;
    }
}