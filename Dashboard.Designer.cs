namespace FinanseManager
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.budget_label = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.TextBox();
            this.monthly_income_label = new System.Windows.Forms.Label();
            this.monthly_expenses_label = new System.Windows.Forms.Label();
            this.income_label = new System.Windows.Forms.Label();
            this.expenses_label = new System.Windows.Forms.Label();
            this.monthly_income = new System.Windows.Forms.TextBox();
            this.monthly_expenses = new System.Windows.Forms.TextBox();
            this.income = new System.Windows.Forms.TextBox();
            this.expenses = new System.Windows.Forms.TextBox();
            this.transfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcome_label.Location = new System.Drawing.Point(12, 9);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(115, 25);
            this.welcome_label.TabIndex = 8;
            this.welcome_label.Text = "Welcome ";
            // 
            // budget_label
            // 
            this.budget_label.AutoSize = true;
            this.budget_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.budget_label.Location = new System.Drawing.Point(34, 75);
            this.budget_label.Name = "budget_label";
            this.budget_label.Size = new System.Drawing.Size(137, 20);
            this.budget_label.TabIndex = 9;
            this.budget_label.Text = "Current Budget:";
            // 
            // budget
            // 
            this.budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.budget.Location = new System.Drawing.Point(188, 72);
            this.budget.Name = "budget";
            this.budget.ReadOnly = true;
            this.budget.Size = new System.Drawing.Size(164, 26);
            this.budget.TabIndex = 10;
            this.budget.Text = "0 PLN";
            this.budget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // monthly_income_label
            // 
            this.monthly_income_label.AutoSize = true;
            this.monthly_income_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthly_income_label.Location = new System.Drawing.Point(31, 107);
            this.monthly_income_label.Name = "monthly_income_label";
            this.monthly_income_label.Size = new System.Drawing.Size(140, 20);
            this.monthly_income_label.TabIndex = 11;
            this.monthly_income_label.Text = "Monthly Income:";
            // 
            // monthly_expenses_label
            // 
            this.monthly_expenses_label.AutoSize = true;
            this.monthly_expenses_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthly_expenses_label.Location = new System.Drawing.Point(12, 139);
            this.monthly_expenses_label.Name = "monthly_expenses_label";
            this.monthly_expenses_label.Size = new System.Drawing.Size(159, 20);
            this.monthly_expenses_label.TabIndex = 12;
            this.monthly_expenses_label.Text = "Monthly Expenses:";
            // 
            // income_label
            // 
            this.income_label.AutoSize = true;
            this.income_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.income_label.Location = new System.Drawing.Point(53, 171);
            this.income_label.Name = "income_label";
            this.income_label.Size = new System.Drawing.Size(118, 20);
            this.income_label.TabIndex = 13;
            this.income_label.Text = "Total Income:";
            // 
            // expenses_label
            // 
            this.expenses_label.AutoSize = true;
            this.expenses_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expenses_label.Location = new System.Drawing.Point(34, 203);
            this.expenses_label.Name = "expenses_label";
            this.expenses_label.Size = new System.Drawing.Size(137, 20);
            this.expenses_label.TabIndex = 14;
            this.expenses_label.Text = "Total Expenses:";
            // 
            // monthly_income
            // 
            this.monthly_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthly_income.Location = new System.Drawing.Point(188, 104);
            this.monthly_income.Name = "monthly_income";
            this.monthly_income.ReadOnly = true;
            this.monthly_income.Size = new System.Drawing.Size(164, 26);
            this.monthly_income.TabIndex = 15;
            this.monthly_income.Text = "0 PLN";
            this.monthly_income.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // monthly_expenses
            // 
            this.monthly_expenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthly_expenses.Location = new System.Drawing.Point(188, 136);
            this.monthly_expenses.Name = "monthly_expenses";
            this.monthly_expenses.ReadOnly = true;
            this.monthly_expenses.Size = new System.Drawing.Size(164, 26);
            this.monthly_expenses.TabIndex = 16;
            this.monthly_expenses.Text = "0 PLN";
            this.monthly_expenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // income
            // 
            this.income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.income.Location = new System.Drawing.Point(188, 168);
            this.income.Name = "income";
            this.income.ReadOnly = true;
            this.income.Size = new System.Drawing.Size(164, 26);
            this.income.TabIndex = 17;
            this.income.Text = "0 PLN";
            this.income.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // expenses
            // 
            this.expenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expenses.Location = new System.Drawing.Point(188, 200);
            this.expenses.Name = "expenses";
            this.expenses.ReadOnly = true;
            this.expenses.Size = new System.Drawing.Size(164, 26);
            this.expenses.TabIndex = 18;
            this.expenses.Text = "0 PLN";
            this.expenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // transfer
            // 
            this.transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.transfer.Location = new System.Drawing.Point(35, 271);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(110, 29);
            this.transfer.TabIndex = 19;
            this.transfer.Text = "Transfer";
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.expenses);
            this.Controls.Add(this.income);
            this.Controls.Add(this.monthly_expenses);
            this.Controls.Add(this.monthly_income);
            this.Controls.Add(this.expenses_label);
            this.Controls.Add(this.income_label);
            this.Controls.Add(this.monthly_expenses_label);
            this.Controls.Add(this.monthly_income_label);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.budget_label);
            this.Controls.Add(this.welcome_label);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label budget_label;
        private System.Windows.Forms.TextBox budget;
        private System.Windows.Forms.Label monthly_income_label;
        private System.Windows.Forms.Label monthly_expenses_label;
        private System.Windows.Forms.Label income_label;
        private System.Windows.Forms.Label expenses_label;
        private System.Windows.Forms.TextBox monthly_income;
        private System.Windows.Forms.TextBox monthly_expenses;
        private System.Windows.Forms.TextBox income;
        private System.Windows.Forms.TextBox expenses;
        private System.Windows.Forms.Button transfer;
    }
}