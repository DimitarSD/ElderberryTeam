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
    public partial class FormAddLoan : Form
    {
        public FormAddLoan()
        {
            InitializeComponent();
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

            MessageBox.Show(GlobalMessages.LoanAdded, GlobalMessages.LoanTitle);
        }

        private void FormAddLoan_Load(object sender, EventArgs e)
        {

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

    }
}
