namespace TeamElderberryProject
{
    using System.IO;
    using System.Text;
    using System.Web.Script.Serialization;

    using TeamElderberryProject.Interfaces;

    public class ExportInFile 
    {
        // Strategy
        public static void SaveExpenseData(IExporter exporter, ITransaction transaction)
        {
            exporter.Export(transaction);
        }
    }
}