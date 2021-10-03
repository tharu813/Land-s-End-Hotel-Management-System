namespace HotelManagementSystem
{
    partial class leavereq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leavereq));
            this.dataGridView_lreq = new System.Windows.Forms.DataGridView();
            this.btn_lreq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lreq)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_lreq
            // 
            this.dataGridView_lreq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lreq.Location = new System.Drawing.Point(29, 52);
            this.dataGridView_lreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_lreq.Name = "dataGridView_lreq";
            this.dataGridView_lreq.RowHeadersWidth = 51;
            this.dataGridView_lreq.Size = new System.Drawing.Size(575, 446);
            this.dataGridView_lreq.TabIndex = 0;
            // 
            // btn_lreq
            // 
            this.btn_lreq.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_lreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lreq.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_lreq.Location = new System.Drawing.Point(707, 238);
            this.btn_lreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_lreq.Name = "btn_lreq";
            this.btn_lreq.Size = new System.Drawing.Size(285, 68);
            this.btn_lreq.TabIndex = 1;
            this.btn_lreq.Text = "Check Leave Requests";
            this.btn_lreq.UseVisualStyleBackColor = false;
            this.btn_lreq.Click += new System.EventHandler(this.btn_lreq_Click);
            // 
            // leavereq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_lreq);
            this.Controls.Add(this.dataGridView_lreq);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "leavereq";
            this.Text = "leavereq";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lreq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_lreq;
        private System.Windows.Forms.Button btn_lreq;
    }
}