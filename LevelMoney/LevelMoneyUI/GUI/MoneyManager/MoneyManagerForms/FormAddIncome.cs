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
    public partial class FormAddIncome : Form
    {
        public FormAddIncome()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = this.Owner.Location;
            this.Left += this.Owner.ClientSize.Width / 2 - this.Width / 2;
            this.Top += this.Owner.ClientSize.Height / 2 - this.Height / 2;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult result1 = MessageBox.Show("Are you sure you want to add a new income",
            //                                                "Caution!",
            //                                                MessageBoxButtons.YesNo); 
            //

            var ammount = decimal.Parse(textBox1.Text);
            var comment = textBox2.Text;
            var date = DateTime.Parse(dateTimePicker1.Text);

            Income incomeToAdd = null;

            switch (comboBox1.Text)
            {
                case "Irregular":
                    incomeToAdd = new IrregularIncome(new TransactionData(ammount, date), comment);
                    break;
                case "Regular":
                    incomeToAdd = new RegularIncome(new TransactionData(ammount, date), comment);
                    break;
                default: MessageBox.Show("Please fill the form!");
                    break;
            }
            ExcelExporter exporter = new ExcelExporter();

            exporter.Export(incomeToAdd);



            MessageBox.Show(GlobalMessages.IncomeAdded, GlobalMessages.ExpenseTitle);

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
            dateTimePicker1.ResetText();

            //Old way printing with json serializer
            //ExportInFile.SaveIncomeData(incomeToAdd);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MoreActions form2 = new MoreActions();
            //form2.Show();
            //this.Close();

            this.Hide();
            var form4 = new FormStart();
            form4.Show(this);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
