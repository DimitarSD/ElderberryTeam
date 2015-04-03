namespace TeamElderberryProject
{
    using System.IO;
    using System.Text;

    using TeamElderberryProject.Interfaces;

    public class ExportInFile 
    {
        public static void SaveExpenseData(ITransaction currentExpense)
        {
            StreamWriter writeExpenseData = new StreamWriter(@"..\..\..\TextFiles\SaveData.txt"); 
            StringBuilder dataToString = new StringBuilder(currentExpense.ToString());

            using (writeExpenseData)
            {
                writeExpenseData.WriteLine(dataToString.ToString());
            }
        }

        public static void SaveIncomeData(ITransaction currentIncome)
        {
            StreamWriter writeIncomeData = new StreamWriter(@"..\..\..\TextFiles\SaveData.txt"); 
            StringBuilder dataToString = new StringBuilder(currentIncome.ToString());

            using (writeIncomeData)
            {
                writeIncomeData.WriteLine(dataToString.ToString());
            }
        }
    }
}
