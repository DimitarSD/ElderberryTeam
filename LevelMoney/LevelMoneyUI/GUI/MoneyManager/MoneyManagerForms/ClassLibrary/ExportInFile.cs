namespace TeamElderberryProject
{
    using System.IO;
    using System.Text;
    using System.Web.Script.Serialization;

    using TeamElderberryProject.Interfaces;

    public class ExportInFile 
    {
        public static void SaveExpenseData(IExporter exporter, ITransaction transaction)
        {
            //StreamWriter writeExpenseData = new StreamWriter(@"..\..\..\..\..\..\TextFiles\SaveData.txt",true); 
            ////StringBuilder dataToString = new StringBuilder(currentExpense.ToString());

            //var json = new JavaScriptSerializer().Serialize(currentExpense);

            //using (writeExpenseData)
            //{
            //    writeExpenseData.WriteLine(json);
            //}
            exporter.Export(transaction);

        }
    }
}