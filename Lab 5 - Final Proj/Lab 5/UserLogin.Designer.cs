namespace Lab_5
{
    partial class UserLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.labUser = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.btnNewAct = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(198, 161);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 22);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(38, 50);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(55, 13);
            this.labUser.TabIndex = 1;
            this.labUser.Text = "Username";
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Location = new System.Drawing.Point(40, 97);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(53, 13);
            this.labPass.TabIndex = 2;
            this.labPass.Text = "Password";
            // 
            // btnNewAct
            // 
            this.btnNewAct.Location = new System.Drawing.Point(62, 161);
            this.btnNewAct.Name = "btnNewAct";
            this.btnNewAct.Size = new System.Drawing.Size(87, 22);
            this.btnNewAct.TabIndex = 3;
            this.btnNewAct.Text = "New Account";
            this.btnNewAct.UseVisualStyleBackColor = true;
            this.btnNewAct.Click += new System.EventHandler(this.btnNewAct_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(154, 50);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(131, 20);
            this.txtUser.TabIndex = 4;
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(154, 97);
            this.txtPas.Name = "txtPas";
            this.txtPas.PasswordChar = '*';
            this.txtPas.Size = new System.Drawing.Size(131, 20);
            this.txtPas.TabIndex = 5;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 236);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnNewAct);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.btnLogin);
            this.Name = "UserLogin";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Button btnNewAct;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPas;
    }
}