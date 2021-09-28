namespace HotelManagementSystem
{
    partial class Transport_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transport_Details));
            this.dataGridView_transport = new System.Windows.Forms.DataGridView();
            this.lbl_transportinfo = new System.Windows.Forms.Label();
            this.btn_showtransport = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_transport
            // 
            this.dataGridView_transport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transport.Location = new System.Drawing.Point(16, 89);
            this.dataGridView_transport.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_transport.Name = "dataGridView_transport";
            this.dataGridView_transport.RowHeadersWidth = 51;
            this.dataGridView_transport.Size = new System.Drawing.Size(573, 336);
            this.dataGridView_transport.TabIndex = 0;
            // 
            // lbl_transportinfo
            // 
            this.lbl_transportinfo.AutoSize = true;
            this.lbl_transportinfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_transportinfo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transportinfo.Location = new System.Drawing.Point(343, 38);
            this.lbl_transportinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_transportinfo.Name = "lbl_transportinfo";
            this.lbl_transportinfo.Size = new System.Drawing.Size(376, 27);
            this.lbl_transportinfo.TabIndex = 2;
            this.lbl_transportinfo.Text = "Bus Transportation Details";
            // 
            // btn_showtransport
            // 
            this.btn_showtransport.BackColor = System.Drawing.Color.Black;
            this.btn_showtransport.ForeColor = System.Drawing.Color.White;
            this.btn_showtransport.Location = new System.Drawing.Point(610, 149);
            this.btn_showtransport.Margin = new System.Windows.Forms.Padding(4);
            this.btn_showtransport.Name = "btn_showtransport";
            this.btn_showtransport.Size = new System.Drawing.Size(197, 47);
            this.btn_showtransport.TabIndex = 3;
            this.btn_showtransport.Text = "Show Transportation Details";
            this.btn_showtransport.UseVisualStyleBackColor = false;
            this.btn_showtransport.Click += new System.EventHandler(this.btn_showtransport_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(727, 509);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(65, 33);
            this.Backbtn.TabIndex = 4;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Transport_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 554);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.btn_showtransport);
            this.Controls.Add(this.lbl_transportinfo);
            this.Controls.Add(this.dataGridView_transport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Transport_Details";
            this.Text = "Transport_Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_transport;
        private System.Windows.Forms.Label lbl_transportinfo;
        private System.Windows.Forms.Button btn_showtransport;
        private System.Windows.Forms.Button Backbtn;
    }
}