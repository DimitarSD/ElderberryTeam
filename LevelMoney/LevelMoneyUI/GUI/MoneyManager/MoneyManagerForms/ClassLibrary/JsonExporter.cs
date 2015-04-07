namespace TeamElderberryProject
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Script.Serialization;
    using TeamElderberryProject.Interfaces;

    public class JsonExporter : IExporter
    {
        public void Export(ITransaction transaction)
        {
            StreamWriter writeExpenseData = new StreamWriter(@"..\..\..\..\..\..\TextFiles\SaveData.txt", true);

            var json = new JavaScriptSerializer().Serialize(transaction);

            using (writeExpenseData)
            {
                writeExpenseData.WriteLine(json);
            }
        }
    }
}
