namespace TeamElderberryProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using System.Data.OleDb;
    using TeamElderberryProject.Interfaces;

    public class ExcelImporter
    {
        public IList<ITransaction> Import()
        {
            OleDbConnection excelCon =
                new OleDbConnection(@"Data Source=..\..\..\..\..\..\TextFiles\TransactionsData.xlsx; Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties=Excel 12.0 XML ");

            excelCon.Open();

            OleDbCommand cmdReadTable = new OleDbCommand("SELECT * FROM [Transactions$]", excelCon);
            OleDbDataReader reader = cmdReadTable.ExecuteReader();

            var allTransactions = new List<ITransaction>();

            using (excelCon)
            {
                while (reader.Read())
                {
                    var id = (string)reader["Id"];
                    var amountAsString = reader["Amount"].ToString();
                    var amount = decimal.Parse(amountAsString);
                    var dateAsString = reader["Date"].ToString();
                    var date = DateTime.Parse(dateAsString);
                    var typeAsString = (string)reader["Type"];
                    var description = (string)reader["Description"];
                    var transaction = GenerateTransaction(amount, date, typeAsString, description);
                    allTransactions.Add(transaction);
                }
            }

            return allTransactions;
        }

        private static ITransaction GenerateTransaction(decimal amount, DateTime date, string typeAsString, string description)
        {

            Transaction transaction = null;

            switch (typeAsString)
            {
                case "IrregularExpense":
                    transaction = new IrregularExpense(new TransactionData(amount, date), description);
                    break;
                case "IrregularIncome":
                    transaction = new IrregularIncome(new TransactionData(amount, date), description);
                    break;
                case "RegularExpense":
                    transaction = new RegularExpense(new TransactionData(amount, date), description);
                    break;
                case "RegularIncome":
                    transaction = new RegularIncome(new TransactionData(amount, date), description);
                    break;
                default:
                    break;
            }

            return transaction;
        }
    }
}
