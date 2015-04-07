namespace TeamElderberryProject
{
    using System.Collections.Generic;

    using TeamElderberryProject.Interfaces;

    public static class ImportFromFile
    {
        public static ICollection<ITransaction> ImportData(IImporter importer)
        {
            return importer.Import();
        }
    }
}