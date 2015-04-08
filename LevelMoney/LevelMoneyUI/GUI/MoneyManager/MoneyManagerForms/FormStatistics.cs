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
                                                      .OrderBy(x=>x.TransactionType)
                                                      .ThenByDescending(x=>x.Data.Amount))
            {
                PrintTransaction(transaction);
            }
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
            StatisticsTextBox.AppendText(string.Format("{0}\n",transaction));
        }
    }
}
