namespace TeamElderberryProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using System.Data;
    using System.Data.OleDb;

    using TeamElderberryProject.Interfaces;

    public class ExcelExporter : IExporter
    {
        public void Export(ITransaction transaction)
        {
            OleDbConnection excelCon =
                new OleDbConnection(@"Data Source=..\..\..\..\..\..\TextFiles\TransactionsData.xlsx; Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties=Excel 12.0 XML ");

            excelCon.Open();

            using (excelCon)
            {
                OleDbCommand addNewTransaction = new OleDbCommand("INSERT INTO [Transactions$](Id, Amount, [Date], [Type], Description) VALUES(@Id, @Amount, @Date, @Type, @Description)", excelCon);
  
                addNewTransaction.Parameters.AddWithValue("@Id", transaction.TransactionID);
                addNewTransaction.Parameters.AddWithValue("@Amount", transaction.Data.Amount);
                addNewTransaction.Parameters.AddWithValue("@Date", transaction.Data.Date.Date.ToShortDateString().ToString());
                addNewTransaction.Parameters.AddWithValue("@Type", transaction.TransactionType.ToString());
                addNewTransaction.Parameters.AddWithValue("@Description", transaction.Description);

                addNewTransaction.ExecuteNonQuery();
            }

        }

    }
}
