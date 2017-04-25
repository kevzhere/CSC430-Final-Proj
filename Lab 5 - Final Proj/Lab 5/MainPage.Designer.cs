namespace Lab_5
{
    partial class MainPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkIn = new System.Windows.Forms.Button();
            this.CheckOut = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.MakeRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Rerservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkIn
            // 
            this.checkIn.Location = new System.Drawing.Point(117, 114);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(89, 55);
            this.checkIn.TabIndex = 1;
            this.checkIn.Text = "Check In";
            this.checkIn.UseVisualStyleBackColor = true;
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.Location = new System.Drawing.Point(295, 114);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(89, 55);
            this.CheckOut.TabIndex = 2;
            this.CheckOut.Text = "Check Out";
            this.CheckOut.UseVisualStyleBackColor = true;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(200, 200);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(89, 55);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // MakeRes
            // 
            this.MakeRes.Location = new System.Drawing.Point(40, 33);
            this.MakeRes.Name = "MakeRes";
            this.MakeRes.Size = new System.Drawing.Size(89, 55);
            this.MakeRes.TabIndex = 4;
            this.MakeRes.Text = "Make Reservation";
            this.MakeRes.UseVisualStyleBackColor = true;
            this.MakeRes.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 283);
            this.Controls.Add(this.MakeRes);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.button1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button checkIn;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button MakeRes;
    }
}