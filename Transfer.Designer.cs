using System;

namespace FinanseManager
{
    partial class Transfer
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
            this.type = new System.Windows.Forms.ComboBox();
            this.date_type = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.type.Location = new System.Drawing.Point(210, 48);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(164, 28);
            this.type.TabIndex = 0;
            // 
            // date_type
            // 
            this.date_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.date_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.date_type.FormattingEnabled = true;
            this.date_type.Items.AddRange(new object[] {
            "Today",
            "Choose Date"});
            this.date_type.Location = new System.Drawing.Point(210, 82);
            this.date_type.Name = "date_type";
            this.date_type.Size = new System.Drawing.Size(164, 28);
            this.date_type.TabIndex = 1;
            this.date_type.SelectedIndexChanged += new System.EventHandler(this.date_type_SelectedIndexChanged);
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.date.Location = new System.Drawing.Point(210, 116);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(164, 26);
            this.date.TabIndex = 2;
            this.date.Text = "24-03-2024";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date_KeyPress);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date);
            this.Controls.Add(this.date_type);
            this.Controls.Add(this.type);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox date_type;
        private System.Windows.Forms.TextBox date;
    }
}