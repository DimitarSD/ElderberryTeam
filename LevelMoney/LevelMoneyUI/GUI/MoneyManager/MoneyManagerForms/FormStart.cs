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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormAddIncome();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new FormAddExpense();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new FormAddLoan();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.ResetText();
            ListAllExpenses(dateTimePicker1.Value, label2);
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            var importer = new ExcelImporter();
            allTransactions = ImportFromFile.ImportData(importer);
            ListAllExpenses(DateTime.Now, label2);
            

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form5 = new FormStatistics();
            form5.Show();
        }

        private static void ListAllExpenses(DateTime date, Control label)
        {
            var allExpenses = allTransactions.Where(t => t.Data.Date.Date == date.Date).ToList();

            foreach (var expense in allExpenses)
            {
                label.Text += expense.ToString() + Environment.NewLine;
            }
        }
    }
}
