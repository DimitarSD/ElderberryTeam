namespace TeamElderberryProject
{
    using System.IO;
    using System.Text;
    using System.Web.Script.Serialization;

    using TeamElderberryProject.Interfaces;

    public class ExportInFile 
    {
        public static void SaveExpenseData(ITransaction currentExpense)
        {
            StreamWriter writeExpenseData = new StreamWriter(@"..\..\..\TextFiles\SaveData.txt"); 
            //StringBuilder dataToString = new StringBuilder(currentExpense.ToString());

            var json = new JavaScriptSerializer().Serialize(currentExpense);

            using (writeExpenseData)
            {
                writeExpenseData.WriteLine(json);
            }
        }

        public static void SaveIncomeData(ITransaction currentIncome)
        {
            StreamWriter writeIncomeData = new StreamWriter(@"..\..\..\TextFiles\SaveData.txt"); 
            //StringBuilder dataToString = new StringBuilder(currentIncome.ToString());

            var json = new JavaScriptSerializer().Serialize(currentIncome);

            using (writeIncomeData)
            {
                writeIncomeData.WriteLine(json);
            }
        }
    }
}
