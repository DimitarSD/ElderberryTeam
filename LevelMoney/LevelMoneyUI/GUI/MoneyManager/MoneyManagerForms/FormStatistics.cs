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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new FormStart();
            form4.Show();
        }
        private void PrintTransaction(ITransaction transaction)
        {
            switch (transaction.TransactionType)
            {
                case TransactionType.RegularIncome: StatisticsTextBox.SelectionColor = Color.LightGreen; break;
                case TransactionType.IrregularIncome: StatisticsTextBox.SelectionColor = Color.GreenYellow; break;
                case TransactionType.RegularExpense: StatisticsTextBox.SelectionColor = Color.Orange; break;
                case TransactionType.IrregularExpense: StatisticsTextBox.SelectionColor = Color.Red; break;
            }
            StatisticsTextBox.AppendText(string.Format("{0}\n", transaction));
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
            var importer = new ExcelImporter();
            var currentList = ImportFromFile.ImportData(importer);
            foreach (var transaction in currentList)
            {
                currentAccount.AddTransaction(transaction);
            }
            labelTotalMoney.Text = string.Format("Your current money: {0}", currentAccount.Balance);
            StringBuilder builder = new StringBuilder();
            foreach (var transaction in currentAccount.Transactions
                                                      .Where(x => x.Data.Date.CompareTo(startDate) >= 0 && x.Data.Date.CompareTo(endDate) <= 0)
                                                      .OrderBy(x => x.TransactionType)
                                                      .ThenByDescending(x => x.Data.Amount))
            {
                PrintTransaction(transaction);
            }
        }
        private void ChangeTextbox(DateTime startDate, DateTime endDate, TransactionType type)
        {
            var currentAccount = Account.Instance;
            var importer = new ExcelImporter();
            var currentList = ImportFromFile.ImportData(importer);
            var wantedlist = currentList.Where(x => x.Data.Date.CompareTo(startDate) >= 0 && x.Data.Date.CompareTo(endDate) <= 0)
                                        .Where(x => x.TransactionType == type)
                                        .OrderByDescending(x => x.Data.Amount);
            foreach (var transaction in wantedlist)
            {
                PrintTransaction(transaction);
            }
        }

        private void buttonIncomes_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularIncome);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularIncome);
        }

        private void buttonRegularIncomes_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularIncome);
        }

        private void buttonIrregularIncomes_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularIncome);
        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularExpense);
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularExpense);
        }

        private void buttonRegularExpenses_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.RegularExpense);
        }

        private void buttonIrregularExpenses_Click(object sender, EventArgs e)
        {
            StatisticsTextBox.Clear();
            ChangeTextbox(datePickerStart.Value, datePickerEnd.Value, TransactionType.IrregularExpense);
        }
    }
}
