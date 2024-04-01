namespace Register_Login_WFroms
{
    partial class MainWindow
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
            this.MainWindowText = new System.Windows.Forms.Label();
            this.SuccessLogin = new System.Windows.Forms.Label();
            this.GoBackToLogin = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainWindowText
            // 
            this.MainWindowText.AutoSize = true;
            this.MainWindowText.BackColor = System.Drawing.Color.Transparent;
            this.MainWindowText.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWindowText.Location = new System.Drawing.Point(181, 32);
            this.MainWindowText.Name = "MainWindowText";
            this.MainWindowText.Size = new System.Drawing.Size(259, 78);
            this.MainWindowText.TabIndex = 0;
            this.MainWindowText.Text = "SUCCESS";
            // 
            // SuccessLogin
            // 
            this.SuccessLogin.AutoSize = true;
            this.SuccessLogin.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.SuccessLogin.Location = new System.Drawing.Point(121, 161);
            this.SuccessLogin.Name = "SuccessLogin";
            this.SuccessLogin.Size = new System.Drawing.Size(410, 26);
            this.SuccessLogin.TabIndex = 1;
            this.SuccessLogin.Text = "You have successfully logged into your account";
            // 
            // GoBackToLogin
            // 
            this.GoBackToLogin.BackColor = System.Drawing.Color.Violet;
            this.GoBackToLogin.FlatAppearance.BorderSize = 0;
            this.GoBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackToLogin.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.GoBackToLogin.Location = new System.Drawing.Point(248, 323);
            this.GoBackToLogin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.GoBackToLogin.Name = "GoBackToLogin";
            this.GoBackToLogin.Padding = new System.Windows.Forms.Padding(3);
            this.GoBackToLogin.Size = new System.Drawing.Size(106, 58);
            this.GoBackToLogin.TabIndex = 2;
            this.GoBackToLogin.Text = "Login";
            this.GoBackToLogin.UseVisualStyleBackColor = false;
            this.GoBackToLogin.Click += new System.EventHandler(this.GoBackToLogin_Click);
            // 
            // GoBack
            // 
            this.GoBack.AutoSize = true;
            this.GoBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.Location = new System.Drawing.Point(142, 283);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(319, 19);
            this.GoBack.TabIndex = 3;
            this.GoBack.Text = "You can go back to login with this button bellow";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(641, 420);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.GoBackToLogin);
            this.Controls.Add(this.SuccessLogin);
            this.Controls.Add(this.MainWindowText);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainWindowText;
        private System.Windows.Forms.Label SuccessLogin;
        private System.Windows.Forms.Button GoBackToLogin;
        private System.Windows.Forms.Label GoBack;
    }
}