namespace MoneyManagerForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using TeamElderberryProject;
    using TeamElderberryProject.Interfaces;
    public partial class FormStart : Form
    {
        private static ICollection<ITransaction> allTransactions;
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormAddIncome();
            form2.Show(this);

        }

        private void buttonExpense_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new FormAddExpense();
            form3.Show(this);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.ResetText();
            ListAllExpenses(dateTimePicker1.Value, textBox1);
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Location = this.Owner.Location;
                this.Left += this.Owner.ClientSize.Width / 2 - this.Width / 2;
                this.Top += this.Owner.ClientSize.Height / 2 - this.Height / 2;
            }
            var importer = new ExcelImporter();
            allTransactions = ImportFromFile.ImportData(importer);
            ListAllExpenses(DateTime.Now, textBox1);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form5 = new FormStatistics();
            form5.Show(this);
        }

        private static void ListAllExpenses(DateTime date, TextBox container)
        {
            var allExpenses = allTransactions.Where(t => t.Data.Date.Date == date.Date && t is Expense).ToList();

            if (allExpenses.Count > 0)
            {
                container.AppendText(string.Format("{0} {1} for this date:",
                    allExpenses.Count,
                    allExpenses.Count == 1 ? "expense" : "expenses"));
                container.AppendText(Environment.NewLine);

                foreach (var expense in allExpenses)
                {
                    container.AppendText(expense.ToString());
                    container.AppendText(Environment.NewLine);
                }
            }
            else
            {
                container.Text = "No expenses for this date.";
            }
        }
    }
}
