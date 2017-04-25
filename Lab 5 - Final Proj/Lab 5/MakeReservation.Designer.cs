namespace Lab_5
{
    partial class MakeReservation
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
            this.reservationTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkIn = new System.Windows.Forms.DateTimePicker();
            this.checkOut = new System.Windows.Forms.DateTimePicker();
            this.BackToMp = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationTable
            // 
            this.reservationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationTable.Location = new System.Drawing.Point(331, 40);
            this.reservationTable.Name = "reservationTable";
            this.reservationTable.Size = new System.Drawing.Size(272, 232);
            this.reservationTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Check In Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Check Out Date";
            // 
            // checkIn
            // 
            this.checkIn.Location = new System.Drawing.Point(142, 40);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(183, 20);
            this.checkIn.TabIndex = 3;
            this.checkIn.ValueChanged += new System.EventHandler(this.checkIn_ValueChanged);
            // 
            // checkOut
            // 
            this.checkOut.Location = new System.Drawing.Point(142, 88);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(183, 20);
            this.checkOut.TabIndex = 4;
            // 
            // BackToMp
            // 
            this.BackToMp.Location = new System.Drawing.Point(28, 182);
            this.BackToMp.Name = "BackToMp";
            this.BackToMp.Size = new System.Drawing.Size(75, 39);
            this.BackToMp.TabIndex = 6;
            this.BackToMp.Text = "Main Page";
            this.BackToMp.UseVisualStyleBackColor = true;
            this.BackToMp.Click += new System.EventHandler(this.BackToMp_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(222, 182);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(77, 39);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Days Unavailable";
            // 
            // MakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.BackToMp);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservationTable);
            this.Name = "MakeReservation";
            this.Text = "MakeReservation";
            ((System.ComponentModel.ISupportInitialize)(this.reservationTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker checkIn;
        private System.Windows.Forms.DateTimePicker checkOut;
        private System.Windows.Forms.Button BackToMp;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label3;
    }
}