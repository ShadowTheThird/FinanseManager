namespace FinanseManager
{
    partial class Authenticator
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.logon = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.Location = new System.Drawing.Point(162, 114);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(298, 26);
            this.username.TabIndex = 0;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.Location = new System.Drawing.Point(162, 203);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(298, 26);
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseSystemPasswordChar = true;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // logon
            // 
            this.logon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logon.Location = new System.Drawing.Point(162, 297);
            this.logon.Name = "logon";
            this.logon.Size = new System.Drawing.Size(80, 31);
            this.logon.TabIndex = 2;
            this.logon.Text = "Log in";
            this.logon.UseVisualStyleBackColor = true;
            this.logon.Click += new System.EventHandler(this.logon_Click);
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.help.Location = new System.Drawing.Point(380, 297);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(80, 31);
            this.help.TabIndex = 3;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_label.Location = new System.Drawing.Point(271, 180);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(86, 20);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Password";
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username_label.Location = new System.Drawing.Point(271, 91);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(91, 20);
            this.username_label.TabIndex = 6;
            this.username_label.Text = "Username";
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register.Location = new System.Drawing.Point(261, 297);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(100, 31);
            this.register.TabIndex = 7;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // Authenticator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 458);
            this.Controls.Add(this.register);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.help);
            this.Controls.Add(this.logon);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Authenticator";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button logon;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button register;
    }
}

