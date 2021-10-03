namespace HotelManagementSystem
{
    partial class viewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewOrders));
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.btn_orders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Location = new System.Drawing.Point(31, 64);
            this.dataGridView_order.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowHeadersWidth = 51;
            this.dataGridView_order.Size = new System.Drawing.Size(552, 410);
            this.dataGridView_order.TabIndex = 0;
            // 
            // btn_orders
            // 
            this.btn_orders.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_orders.Location = new System.Drawing.Point(751, 225);
            this.btn_orders.Margin = new System.Windows.Forms.Padding(4);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(181, 63);
            this.btn_orders.TabIndex = 1;
            this.btn_orders.Text = "See Orders";
            this.btn_orders.UseVisualStyleBackColor = false;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // viewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.dataGridView_order);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "viewOrders";
            this.Text = "viewOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.Button btn_orders;
    }
}