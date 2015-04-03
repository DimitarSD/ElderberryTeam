namespace TeamElderberryProject
{
    using System.IO;
    using System.Text;

    using TeamElderberryProject.Interfaces;

    public class ExportInFile : TextFiles
    {
        private const string SaveExpenseDataStringFormat = "Type of expense: {0}";
        private const string SaveIncomeDataStringFormat = "Type of income: {0}";

        public static void SaveExpenseData(Expense currentExpense)
        {
            StreamWriter writeExpenseData = new StreamWriter(); // TO DO
            StringBuilder dataToString = new StringBuilder();

            dataToString.Append(""); // TO DO

            using (writeExpenseData)
            {
                writeExpenseData.WriteLine(dataToString.ToString());
            }
        }

        public static void SaveIncomeData(Income currentIncome)
        {
            StreamWriter writeIncomeData = new StreamWriter(); // TO DO
            StringBuilder dataToString = new StringBuilder();

            dataToString.Append(""); // TO DO

            using (writeIncomeData)
            {
                writeIncomeData.WriteLine(dataToString.ToString());
            }
        }
    }
}
