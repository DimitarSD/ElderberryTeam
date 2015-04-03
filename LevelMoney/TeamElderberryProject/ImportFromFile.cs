namespace TeamElderberryProject
{
    using System.Collections.Generic;
    using System.IO;
    using System.Web.Script.Serialization;

    using TeamElderberryProject.Interfaces;

    public class ImportFromFile
    {
        public static ICollection<ITransaction> ImportData()
        {
            ICollection<ITransaction> dataList = new List<ITransaction>();

            StreamReader readData = new StreamReader(@"..\..\..\TextFiles\SaveData.txt");

            var readLine = readData.ReadLine();

            ITransaction data = new JavaScriptSerializer().DeserializeObject(readLine) as ITransaction;

            dataList.Add(data);

            while (readLine != null)
            {
                readLine = readData.ReadLine();
                data = new JavaScriptSerializer().DeserializeObject(readLine) as ITransaction;

                dataList.Add(data);
            }

            return dataList;
        }
    }
}
