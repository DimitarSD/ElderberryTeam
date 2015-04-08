namespace MoneyManagerForms
{
    partial class FormStatistics
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
            this.StatisticsTextBox = new System.Windows.Forms.RichTextBox();
            this.datePickerStart = new System.Windows.Forms.DateTimePicker();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.buttonExpenses = new System.Windows.Forms.Button();
            this.buttonIncomes = new System.Windows.Forms.Button();
            this.buttonRegularIncomes = new System.Windows.Forms.Button();
            this.buttonIrregularIncomes = new System.Windows.Forms.Button();
            this.buttonRegularExpenses = new System.Windows.Forms.Button();
            this.buttonIrregularExpenses = new System.Windows.Forms.Button();
            this.labelTotalMoney = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatisticsTextBox
            // 
            this.StatisticsTextBox.BackColor = System.Drawing.Color.Black;
            this.StatisticsTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticsTextBox.ForeColor = System.Drawing.Color.Yellow;
            this.StatisticsTextBox.Location = new System.Drawing.Point(12, 33);
            this.StatisticsTextBox.Name = "StatisticsTextBox";
            this.StatisticsTextBox.Size = new System.Drawing.Size(760, 422);
            this.StatisticsTextBox.TabIndex = 2;
            this.StatisticsTextBox.Text = "";
            // 
            // datePickerStart
            // 
            this.datePickerStart.Location = new System.Drawing.Point(12, 461);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(200, 20);
            this.datePickerStart.TabIndex = 3;
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Location = new System.Drawing.Point(218, 461);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.datePickerEnd.TabIndex = 4;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.DarkCyan;
            this.labelStart.ForeColor = System.Drawing.Color.Yellow;
            this.labelStart.Location = new System.Drawing.Point(49, 486);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(55, 13);
            this.labelStart.TabIndex = 5;
            this.labelStart.Text = "Start Date";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.BackColor = System.Drawing.Color.DarkCyan;
            this.labelEnd.ForeColor = System.Drawing.Color.Yellow;
            this.labelEnd.Location = new System.Drawing.Point(268, 486);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(52, 13);
            this.labelEnd.TabIndex = 6;
            this.labelEnd.Text = "End Date";
            // 
            // buttonExpenses
            // 
            this.buttonExpenses.Location = new System.Drawing.Point(427, 527);
            this.buttonExpenses.Name = "buttonExpenses";
            this.buttonExpenses.Size = new System.Drawing.Size(75, 23);
            this.buttonExpenses.TabIndex = 7;
            this.buttonExpenses.Text = "Expenses";
            this.buttonExpenses.UseVisualStyleBackColor = true;
            this.buttonExpenses.Click += new System.EventHandler(this.buttonExpenses_Click);
            // 
            // buttonIncomes
            // 
            this.buttonIncomes.Location = new System.Drawing.Point(12, 527);
            this.buttonIncomes.Name = "buttonIncomes";
            this.buttonIncomes.Size = new System.Drawing.Size(75, 23);
            this.buttonIncomes.TabIndex = 8;
            this.buttonIncomes.Text = "Incomes";
            this.buttonIncomes.UseVisualStyleBackColor = true;
            this.buttonIncomes.Click += new System.EventHandler(this.buttonIncomes_Click);
            // 
            // buttonRegularIncomes
            // 
            this.buttonRegularIncomes.Location = new System.Drawing.Point(93, 521);
            this.buttonRegularIncomes.Name = "buttonRegularIncomes";
            this.buttonRegularIncomes.Size = new System.Drawing.Size(75, 34);
            this.buttonRegularIncomes.TabIndex = 9;
            this.buttonRegularIncomes.Text = "Regular Incomes";
            this.buttonRegularIncomes.UseVisualStyleBackColor = true;
            this.buttonRegularIncomes.Click += new System.EventHandler(this.buttonRegularIncomes_Click);
            // 
            // buttonIrregularIncomes
            // 
            this.buttonIrregularIncomes.Location = new System.Drawing.Point(174, 521);
            this.buttonIrregularIncomes.Name = "buttonIrregularIncomes";
            this.buttonIrregularIncomes.Size = new System.Drawing.Size(75, 34);
            this.buttonIrregularIncomes.TabIndex = 10;
            this.buttonIrregularIncomes.Text = "Irregular Incomes";
            this.buttonIrregularIncomes.UseVisualStyleBackColor = true;
            this.buttonIrregularIncomes.Click += new System.EventHandler(this.buttonIrregularIncomes_Click);
            // 
            // buttonRegularExpenses
            // 
            this.buttonRegularExpenses.Location = new System.Drawing.Point(508, 521);
            this.buttonRegularExpenses.Name = "buttonRegularExpenses";
            this.buttonRegularExpenses.Size = new System.Drawing.Size(75, 34);
            this.buttonRegularExpenses.TabIndex = 11;
            this.buttonRegularExpenses.Text = "Regular Expenses";
            this.buttonRegularExpenses.UseVisualStyleBackColor = true;
            this.buttonRegularExpenses.Click += new System.EventHandler(this.buttonRegularExpenses_Click);
            // 
            // buttonIrregularExpenses
            // 
            this.buttonIrregularExpenses.Location = new System.Drawing.Point(589, 521);
            this.buttonIrregularExpenses.Name = "buttonIrregularExpenses";
            this.buttonIrregularExpenses.Size = new System.Drawing.Size(75, 34);
            this.buttonIrregularExpenses.TabIndex = 12;
            this.buttonIrregularExpenses.Text = "Regular Expenses";
            this.buttonIrregularExpenses.UseVisualStyleBackColor = true;
            this.buttonIrregularExpenses.Click += new System.EventHandler(this.buttonIrregularExpenses_Click);
            // 
            // labelTotalMoney
            // 
            this.labelTotalMoney.AutoSize = true;
            this.labelTotalMoney.BackColor = System.Drawing.Color.DarkCyan;
            this.labelTotalMoney.ForeColor = System.Drawing.Color.Yellow;
            this.labelTotalMoney.Location = new System.Drawing.Point(383, 9);
            this.labelTotalMoney.Name = "labelTotalMoney";
            this.labelTotalMoney.Size = new System.Drawing.Size(0, 13);
            this.labelTotalMoney.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(672, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back to main";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelTotalMoney);
            this.Controls.Add(this.buttonIrregularExpenses);
            this.Controls.Add(this.buttonRegularExpenses);
            this.Controls.Add(this.buttonIrregularIncomes);
            this.Controls.Add(this.buttonRegularIncomes);
            this.Controls.Add(this.buttonIncomes);
            this.Controls.Add(this.buttonExpenses);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.datePickerEnd);
            this.Controls.Add(this.datePickerStart);
            this.Controls.Add(this.StatisticsTextBox);
            this.Name = "FormStatistics";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StatisticsTextBox;
        private System.Windows.Forms.DateTimePicker datePickerStart;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Button buttonExpenses;
        private System.Windows.Forms.Button buttonIncomes;
        private System.Windows.Forms.Button buttonRegularIncomes;
        private System.Windows.Forms.Button buttonIrregularIncomes;
        private System.Windows.Forms.Button buttonRegularExpenses;
        private System.Windows.Forms.Button buttonIrregularExpenses;
        private System.Windows.Forms.Label labelTotalMoney;
        private System.Windows.Forms.Button button2;

    }
}