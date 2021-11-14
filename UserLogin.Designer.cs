
namespace MyLogInApplication
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_register_hint = new System.Windows.Forms.Label();
            this.bl_register = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
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
            this.panel_top.Size = new System.Drawing.Size(582, 109);
            this.panel_top.TabIndex = 0;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
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
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(133, 178);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(82, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username :";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(137, 227);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(78, 20);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password :";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_username.Location = new System.Drawing.Point(237, 175);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(180, 26);
            this.txt_username.TabIndex = 3;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_password.Location = new System.Drawing.Point(237, 221);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(180, 26);
            this.txt_password.TabIndex = 4;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Location = new System.Drawing.Point(141, 273);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(276, 32);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_register_hint
            // 
            this.lbl_register_hint.AutoSize = true;
            this.lbl_register_hint.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_hint.Location = new System.Drawing.Point(133, 339);
            this.lbl_register_hint.Name = "lbl_register_hint";
            this.lbl_register_hint.Size = new System.Drawing.Size(187, 20);
            this.lbl_register_hint.TabIndex = 6;
            this.lbl_register_hint.Text = "Don\'t have an account yet?";
            this.lbl_register_hint.Click += new System.EventHandler(this.lbl_register_hint_Click);
            // 
            // bl_register
            // 
            this.bl_register.AutoSize = true;
            this.bl_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bl_register.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_register.ForeColor = System.Drawing.Color.SteelBlue;
            this.bl_register.Location = new System.Drawing.Point(326, 339);
            this.bl_register.Name = "bl_register";
            this.bl_register.Size = new System.Drawing.Size(96, 20);
            this.bl_register.TabIndex = 7;
            this.bl_register.Text = "Register here";
            this.bl_register.Click += new System.EventHandler(this.bl_register_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Red;
            this.lbl_message.Location = new System.Drawing.Point(175, 384);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(212, 15);
            this.lbl_message.TabIndex = 18;
            this.lbl_message.Text = "                            message                         ";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.bl_register);
            this.Controls.Add(this.lbl_register_hint);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel_top);
            this.Name = "UserLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_register_hint;
        private System.Windows.Forms.Label bl_register;
        private System.Windows.Forms.Label lbl_message;
    }
}