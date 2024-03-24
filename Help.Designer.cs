namespace FinanseManager
{
    partial class Help_Page
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
            this.username_label = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.Location = new System.Drawing.Point(107, 145);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(298, 26);
            this.username.TabIndex = 1;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username_label.Location = new System.Drawing.Point(213, 122);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(91, 20);
            this.username_label.TabIndex = 7;
            this.username_label.Text = "Username";
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.help.Location = new System.Drawing.Point(107, 256);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(120, 31);
            this.help.TabIndex = 8;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancel.Location = new System.Drawing.Point(285, 256);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(120, 31);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Help_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.help);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.username);
            this.Name = "Help_Page";
            this.Text = "Help";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Help_Page_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button cancel;
    }
}