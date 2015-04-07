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
        public FormAddExpense()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ammount = 0m;
            if (!(textBox1.Text.GetType() == typeof(string)))
            {
                ammount = decimal.Parse(textBox1.Text);

            }
            else
            {
                MessageBox.Show(GlobalMessages.InvalivDecimalInput);
            }

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

            ExcelExporter exporter = new ExcelExporter();

            exporter.Export(expense);



            MessageBox.Show(GlobalMessages.ExpenseAdded, GlobalMessages.ExpenseTitle);

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
            dateTimePicker1.ResetText();

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
            form4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
