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

    public partial class FormAddExpense : Form
    {
        private const int CommentLenghtManimumValue = 30;
        private const int AmmountMinimumValue = 0;

        public FormAddExpense()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = this.Owner.Location;
            this.Left += this.Owner.ClientSize.Width / 2 - this.Width / 2;
            this.Top += this.Owner.ClientSize.Height / 2 - this.Height / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ammount = decimal.Parse(textBox1.Text);
            var comment = textBox2.Text;
            var date = DateTime.Parse(dateTimePicker1.Text);

            Expense expense = null;


            switch (comboBox1.Text)
            {
                case "Irregular":
                    expense = new IrregularExpense(new TransactionData(ammount, date), comment);
                    break;
                case "Regular":
                    expense = new RegularExpense(new TransactionData(ammount, date), comment);
                    break;
                default:
                    break;
            }

            // You can change the logic from here.
            // Only instantiate new JsonExporter/ExcelExporter or anything that implements IExporter
            var exporter = new ExcelExporter();

            if (ammount < AmmountMinimumValue)
            {
                MessageBox.Show(GlobalMessages.NonNegativeInput, GlobalMessages.ExpenseTitle);

                textBox1.Clear();
            }
            else if (comment == string.Empty)
            {
                MessageBox.Show(GlobalMessages.CommentFieldErrorMessage, GlobalMessages.ExpenseTitle);
            }
            else
            {
                ExportInFile.SaveExpenseData(exporter, expense);

                MessageBox.Show(GlobalMessages.ExpenseAdded, GlobalMessages.ExpenseTitle);

                textBox1.Clear();
                textBox2.Clear();
                comboBox1.ResetText();
                dateTimePicker1.ResetText();
            }

            //Old way printing with json serializer
            //ExportInFile.SaveExpenseData(expense);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new FormStart();
            form4.Show(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var commentLenght = textBox2.TextLength;

            if (commentLenght > CommentLenghtManimumValue)
            {
                string errorMessage = string.Format(GlobalMessages.ExpenseCommentLenghtErrorMessage, CommentLenghtManimumValue);
                MessageBox.Show(errorMessage, GlobalMessages.ExpenseTitle);

                textBox1.Clear();
                textBox2.Clear();
                comboBox1.ResetText();
                dateTimePicker1.ResetText();
            }
        }
    }
}
