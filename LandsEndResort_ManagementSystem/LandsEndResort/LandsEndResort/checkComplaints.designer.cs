namespace HotelManagementSystem
{
    partial class checkComplaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkComplaints));
            this.dataGridView_com = new System.Windows.Forms.DataGridView();
            this.btn_com = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_com)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_com
            // 
            this.dataGridView_com.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_com.Location = new System.Drawing.Point(32, 89);
            this.dataGridView_com.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_com.Name = "dataGridView_com";
            this.dataGridView_com.RowHeadersWidth = 51;
            this.dataGridView_com.Size = new System.Drawing.Size(597, 379);
            this.dataGridView_com.TabIndex = 0;
            // 
            // btn_com
            // 
            this.btn_com.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_com.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_com.Location = new System.Drawing.Point(756, 233);
            this.btn_com.Margin = new System.Windows.Forms.Padding(4);
            this.btn_com.Name = "btn_com";
            this.btn_com.Size = new System.Drawing.Size(204, 59);
            this.btn_com.TabIndex = 1;
            this.btn_com.Text = "Get Complaints";
            this.btn_com.UseVisualStyleBackColor = false;
            this.btn_com.Click += new System.EventHandler(this.btn_com_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(968, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_com);
            this.Controls.Add(this.dataGridView_com);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "checkComplaints";
            this.Text = "checkComplaints";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_com)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_com;
        private System.Windows.Forms.Button btn_com;
        private System.Windows.Forms.Button button1;
    }
}