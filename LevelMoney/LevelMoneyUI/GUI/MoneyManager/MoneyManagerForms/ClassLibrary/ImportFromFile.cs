namespace TeamElderberryProject
{
    using System.Collections.Generic;
    using System.IO;
    using System.Web.Script.Serialization;

    using TeamElderberryProject.Interfaces;

    public static class ImportFromFile
    {
        public static ICollection<ITransaction> ImportData()
        {
            ICollection<ITransaction> dataList = new List<ITransaction>();

            StreamReader readData = new StreamReader(@"..\..\..\..\..\..\TextFiles\SaveData.txt");

            var readLine = readData.ReadLine();

            ITransaction data;

            data = CheckForType(dataList, readLine);

            while (readLine != null)
            {
                readLine = readData.ReadLine();

                data = CheckForType(dataList, readLine);

                dataList.Add(data);
            }

            return dataList;
        }

        private static ITransaction CheckForType(ICollection<ITransaction> dataList, string readLine)
        {
            ITransaction data;
            if (readLine.Contains("RegularIncome"))
            {
                data = new JavaScriptSerializer().Deserialize<RegularIncome>(readLine);
                dataList.Add(data);
            }
            else if (readLine.Contains("IrregularIncome"))
            {
                data = new JavaScriptSerializer().Deserialize<IrregularIncome>(readLine);
                dataList.Add(data);
            }
            else if (readLine.Contains("RegularExpense"))
            {
                data = new JavaScriptSerializer().Deserialize<RegularExpense>(readLine);
                dataList.Add(data);
            }
            else
            {
                data = new JavaScriptSerializer().Deserialize<IrregularExpense>(readLine);
                dataList.Add(data);
            }

            return data;
        }
    }
}