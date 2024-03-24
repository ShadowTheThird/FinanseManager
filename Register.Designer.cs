namespace FinanseManager
{
    partial class Register
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
            this.confirm_password = new System.Windows.Forms.TextBox();
            this.help = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.confirm_password_label = new System.Windows.Forms.Label();
            this.help_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.Location = new System.Drawing.Point(192, 64);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(298, 26);
            this.username.TabIndex = 1;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.Location = new System.Drawing.Point(192, 170);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(298, 26);
            this.password.TabIndex = 3;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseSystemPasswordChar = true;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // confirm_password
            // 
            this.confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirm_password.Location = new System.Drawing.Point(192, 227);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.Size = new System.Drawing.Size(298, 26);
            this.confirm_password.TabIndex = 4;
            this.confirm_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirm_password.UseSystemPasswordChar = true;
            this.confirm_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.help.Location = new System.Drawing.Point(192, 281);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(298, 26);
            this.help.TabIndex = 5;
            this.help.Text = "-- something to help you remember --";
            this.help.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.help.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username_label.Location = new System.Drawing.Point(74, 67);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(91, 20);
            this.username_label.TabIndex = 8;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_label.Location = new System.Drawing.Point(79, 173);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(86, 20);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "Password";
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // confirm_password_label
            // 
            this.confirm_password_label.AutoSize = true;
            this.confirm_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirm_password_label.Location = new System.Drawing.Point(12, 227);
            this.confirm_password_label.Name = "confirm_password_label";
            this.confirm_password_label.Size = new System.Drawing.Size(153, 20);
            this.confirm_password_label.TabIndex = 10;
            this.confirm_password_label.Text = "Confirm Password";
            this.confirm_password_label.Click += new System.EventHandler(this.confirm_password_label_Click);
            // 
            // help_label
            // 
            this.help_label.AutoSize = true;
            this.help_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.help_label.Location = new System.Drawing.Point(45, 284);
            this.help_label.Name = "help_label";
            this.help_label.Size = new System.Drawing.Size(123, 20);
            this.help_label.TabIndex = 11;
            this.help_label.Text = "Help message";
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_button.Location = new System.Drawing.Point(192, 347);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(120, 31);
            this.register_button.TabIndex = 12;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancel_button.Location = new System.Drawing.Point(370, 347);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(120, 31);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.Location = new System.Drawing.Point(192, 117);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(298, 26);
            this.name.TabIndex = 2;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name_label.Location = new System.Drawing.Point(110, 120);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(55, 20);
            this.name_label.TabIndex = 15;
            this.name_label.Text = "Name";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 431);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.help_label);
            this.Controls.Add(this.confirm_password_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.help);
            this.Controls.Add(this.confirm_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirm_password;
        private System.Windows.Forms.TextBox help;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label confirm_password_label;
        private System.Windows.Forms.Label help_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label name_label;
    }
}