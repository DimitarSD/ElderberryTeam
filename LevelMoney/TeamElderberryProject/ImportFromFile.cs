namespace TeamElderberryProject
{
    using System.Collections.Generic;

    using TeamElderberryProject.Interfaces;

    public static class ImportFromFile
    {
        public static IList<ITransaction> ImportData(IImporter importer)
        {
            return importer.Import();
        }
    }
}