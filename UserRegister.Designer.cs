
namespace MyLogInApplication
{
    partial class UserRegister
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_register = new System.Windows.Forms.Label();
            this.lbl_login_hint = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_password_again = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_top.Controls.Add(this.lbl_login);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(570, 109);
            this.panel_top.TabIndex = 9;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(247, 44);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(129, 24);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "WELCOME!";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Red;
            this.lbl_message.Location = new System.Drawing.Point(168, 493);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(212, 15);
            this.lbl_message.TabIndex = 17;
            this.lbl_message.Text = "                            message                         ";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_register.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_register.Location = new System.Drawing.Point(330, 448);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(79, 20);
            this.lbl_register.TabIndex = 16;
            this.lbl_register.Text = "Login here";
            this.lbl_register.Click += new System.EventHandler(this.lbl_register_Click);
            // 
            // lbl_login_hint
            // 
            this.lbl_login_hint.AutoSize = true;
            this.lbl_login_hint.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_hint.Location = new System.Drawing.Point(137, 448);
            this.lbl_login_hint.Name = "lbl_login_hint";
            this.lbl_login_hint.Size = new System.Drawing.Size(178, 20);
            this.lbl_login_hint.TabIndex = 15;
            this.lbl_login_hint.Text = "Already have an account?";
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_signup.Location = new System.Drawing.Point(145, 398);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(276, 32);
            this.btn_signup.TabIndex = 14;
            this.btn_signup.Text = "Sign up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_password.Location = new System.Drawing.Point(241, 305);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(180, 26);
            this.txt_password.TabIndex = 13;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_username.Location = new System.Drawing.Point(241, 210);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(180, 26);
            this.txt_username.TabIndex = 12;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(141, 308);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(78, 20);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Password :";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(137, 213);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(82, 20);
            this.lbl_username.TabIndex = 10;
            this.lbl_username.Text = "Username :";
            // 
            // txt_password_again
            // 
            this.txt_password_again.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_password_again.Location = new System.Drawing.Point(241, 350);
            this.txt_password_again.Name = "txt_password_again";
            this.txt_password_again.PasswordChar = '•';
            this.txt_password_again.Size = new System.Drawing.Size(180, 26);
            this.txt_password_again.TabIndex = 18;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_fullname.Location = new System.Drawing.Point(241, 166);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(180, 26);
            this.txt_fullname.TabIndex = 20;
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(143, 166);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(76, 20);
            this.lbl_fullname.TabIndex = 19;
            this.lbl_fullname.Text = "Fullname :";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_email.Location = new System.Drawing.Point(241, 260);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(180, 26);
            this.txt_email.TabIndex = 22;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(166, 266);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(53, 20);
            this.lbl_email.TabIndex = 21;
            this.lbl_email.Text = "Email :";
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm.Location = new System.Drawing.Point(143, 356);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(69, 20);
            this.lbl_confirm.TabIndex = 23;
            this.lbl_confirm.Text = "Confirm :";
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 529);
            this.Controls.Add(this.lbl_confirm);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.txt_password_again);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.lbl_login_hint);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "UserRegister";
            this.Text = "Signup";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Label lbl_login_hint;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_password_again;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_confirm;
    }
}