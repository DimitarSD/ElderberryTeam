namespace TeamElderberryProject
{
    using System.IO;
    using System.Text;

    public class ExportInFile : TextFiles
    {
        private const string SaveExpenseDataStringFormat = "Type of expense: {0}";
        private const string SaveIncomeDataStringFormat = "Type of income: {0}";

        public static void SaveExpenseData(Expense currentExpense)
        {
            StreamWriter writeExpenseData = new StreamWriter();
            StringBuilder dataToString = new StringBuilder(this.ToString());

            dataToString.Append(string.Format(SaveExpenseDataStringFormat, )); // TO DO

            using (writeExpenseData)
            {
                writeExpenseData.WriteLine(dataToString.ToString());
            }
        }

        public static void SaveIncomeData(Income currentIncome)
        {
            StreamWriter writeIncomeData = new StreamWriter();
            StringBuilder dataToString = new StringBuilder(this.ToString());

            dataToString.Append(string.Format(SaveIncomeDataStringFormat, )); // TO DO

            using (writeIncomeData)
            {
                writeIncomeData.WriteLine(dataToString.ToString());
            }
        }
    }
}
