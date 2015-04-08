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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new FormStart();
            form4.Show();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            this.Location = this.Owner.Location;
            this.Left += this.Owner.ClientSize.Width / 2 - this.Width / 2;
            this.Top += this.Owner.ClientSize.Height / 2 - this.Height / 2;

            var today = DateTime.Now;
            datePickerStart.Value = new DateTime(today.Year, today.Month, 1);
            datePickerEnd.Value = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));

            var startDate = datePickerStart.Value;
            var endDate = datePickerEnd.Value;
            var currentAccount = Account.Instance;
            currentAccount.Clear();
            var importer = new ExcelImporter();
            var currentList = ImportFromFile.ImportData(importer);
            foreach (var transaction in currentList)
            {
                currentAccount.AddTransaction(transaction);
            }
            labelTotalMoney.Text = string.Format("Your current money: {0}", currentAccount.Balance);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularIncome, StatisticsTextBox);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularIncome, StatisticsTextBox);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularExpense, StatisticsTextBox);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularExpense, StatisticsTextBox);
            CheckIfEmpty(datePickerStart.Value, datePickerEnd.Value, "Transaction", StatisticsTextBox);
        }

        private void buttonIncomes_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularIncome, StatisticsTextBox);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularIncome, StatisticsTextBox);
            CheckIfEmpty(datePickerStart.Value, datePickerEnd.Value, "Income", StatisticsTextBox);
        }

        private void buttonRegularIncomes_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularIncome, StatisticsTextBox);
            CheckIfEmpty(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularIncome.ToString(), StatisticsTextBox);
        }

        private void buttonIrregularIncomes_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularIncome, StatisticsTextBox);
            CheckIfEmpty(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularIncome.ToString(), StatisticsTextBox);
        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularExpense, StatisticsTextBox);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularExpense, StatisticsTextBox);
            CheckIfEmpty(datePickerStart.Value, datePickerEnd.Value, "Expense", StatisticsTextBox);
        }

        private void buttonRegularExpenses_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularExpense, StatisticsTextBox);
            CheckIfEmpty(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularExpense.ToString(), StatisticsTextBox);
        }

        private void buttonIrregularExpenses_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularExpense, StatisticsTextBox);
            CheckIfEmpty(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularExpense.ToString(), StatisticsTextBox);
        }
        private void buttonAll_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularIncome, StatisticsTextBox);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularIncome, StatisticsTextBox);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularExpense, StatisticsTextBox);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularExpense, StatisticsTextBox);
            CheckIfEmpty(datePickerStart.Value, datePickerEnd.Value, "Transaction", StatisticsTextBox);
        }
        private void PrintTransaction(ITransaction transaction, RichTextBox textBox)
        {
            switch (transaction.TransactionType)
            {
                case TransactionType.RegularIncome: textBox.SelectionColor = Color.LightGreen; break;
                case TransactionType.IrregularIncome: textBox.SelectionColor = Color.GreenYellow; break;
                case TransactionType.RegularExpense: textBox.SelectionColor = Color.Orange; break;
                case TransactionType.IrregularExpense: textBox.SelectionColor = Color.Red; break;
            }
            textBox.AppendText(string.Format("{0}\n\n", transaction));
        }
        private void ChangeTextbox(DateTime startDate, DateTime endDate, TransactionType type, RichTextBox textBox)
        {
            var currentAccount = Account.Instance;
            var currentList = currentAccount.Transactions;
            var wantedlist = currentList.Where(x => x.Data.Date.CompareTo(startDate) >= 0 && x.Data.Date.CompareTo(endDate) <= 0)
                                        .Where(x => x.TransactionType == type)
                                        .OrderByDescending(x => x.Data.Amount);
            foreach (var transaction in wantedlist)
            {
                PrintTransaction(transaction, textBox);
            }
        }
        private void CheckIfEmpty(DateTime startDate, DateTime endDate, string type, RichTextBox textBox)
        {
            if (textBox.TextLength == 0)
            {
                textBox.SelectionColor = Color.Yellow;
                textBox.AppendText(string.Format("You have no {0}s from {1} to {2}.", type, startDate.ToShortDateString(), endDate.ToShortDateString()));
            }
        }
    }
}
