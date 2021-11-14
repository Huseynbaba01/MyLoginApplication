
namespace MyLogInApplication
{
    partial class Dashboard
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
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.AutoSize = true;
            this.lbl_greeting.Font = new System.Drawing.Font("Times Roman AzCyr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_greeting.Location = new System.Drawing.Point(215, 35);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(106, 21);
            this.lbl_greeting.TabIndex = 0;
            this.lbl_greeting.Text = "Hello, User!";
            this.lbl_greeting.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(79, 88);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(386, 205);
            this.txt_input.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(79, 312);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(386, 40);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_greeting);
            this.Name = "Dashboard";
            this.Text = "Dahboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_greeting;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_save;
    }
}

