namespace HotelManagementSystem
{
    partial class Leaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaves));
            this.lbl_selectdate = new System.Windows.Forms.Label();
            this.lbl_reqleave = new System.Windows.Forms.Label();
            this.btn_sendreq = new System.Windows.Forms.Button();
            this.dateTimePicker_leaves = new System.Windows.Forms.DateTimePicker();
            this.lbl_reason = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_selectdate
            // 
            this.lbl_selectdate.AutoSize = true;
            this.lbl_selectdate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_selectdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectdate.Location = new System.Drawing.Point(340, 289);
            this.lbl_selectdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectdate.Name = "lbl_selectdate";
            this.lbl_selectdate.Size = new System.Drawing.Size(126, 20);
            this.lbl_selectdate.TabIndex = 0;
            this.lbl_selectdate.Text = "Select the date ";
            // 
            // lbl_reqleave
            // 
            this.lbl_reqleave.AutoSize = true;
            this.lbl_reqleave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reqleave.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqleave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_reqleave.Location = new System.Drawing.Point(151, 214);
            this.lbl_reqleave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reqleave.Name = "lbl_reqleave";
            this.lbl_reqleave.Size = new System.Drawing.Size(287, 37);
            this.lbl_reqleave.TabIndex = 1;
            this.lbl_reqleave.Text = "Requesting for a leave";
            this.lbl_reqleave.Click += new System.EventHandler(this.lbl_reqleave_Click);
            // 
            // btn_sendreq
            // 
            this.btn_sendreq.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sendreq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sendreq.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendreq.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sendreq.Location = new System.Drawing.Point(463, 457);
            this.btn_sendreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sendreq.Name = "btn_sendreq";
            this.btn_sendreq.Size = new System.Drawing.Size(179, 33);
            this.btn_sendreq.TabIndex = 3;
            this.btn_sendreq.Text = "Send Request";
            this.btn_sendreq.UseVisualStyleBackColor = false;
            this.btn_sendreq.Click += new System.EventHandler(this.btn_sendreq_Click);
            // 
            // dateTimePicker_leaves
            // 
            this.dateTimePicker_leaves.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_leaves.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_leaves.Location = new System.Drawing.Point(556, 282);
            this.dateTimePicker_leaves.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_leaves.Name = "dateTimePicker_leaves";
            this.dateTimePicker_leaves.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker_leaves.TabIndex = 4;
            // 
            // lbl_reason
            // 
            this.lbl_reason.AutoSize = true;
            this.lbl_reason.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reason.Location = new System.Drawing.Point(340, 336);
            this.lbl_reason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reason.Name = "lbl_reason";
            this.lbl_reason.Size = new System.Drawing.Size(142, 20);
            this.lbl_reason.TabIndex = 5;
            this.lbl_reason.Text = "Enter your reason";
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(556, 336);
            this.txt_reason.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(152, 22);
            this.txt_reason.TabIndex = 6;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(340, 390);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(108, 20);
            this.lbl_id.TabIndex = 7;
            this.lbl_id.Text = "Enter your ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(556, 386);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(152, 22);
            this.txt_id.TabIndex = 8;
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(43, 35);
            this.Back.TabIndex = 9;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Leaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 550);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.lbl_reason);
            this.Controls.Add(this.dateTimePicker_leaves);
            this.Controls.Add(this.btn_sendreq);
            this.Controls.Add(this.lbl_reqleave);
            this.Controls.Add(this.lbl_selectdate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Leaves";
            this.Text = "Leaves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selectdate;
        private System.Windows.Forms.Label lbl_reqleave;
        private System.Windows.Forms.Button btn_sendreq;
        private System.Windows.Forms.DateTimePicker dateTimePicker_leaves;
        private System.Windows.Forms.Label lbl_reason;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button Back;
    }
}