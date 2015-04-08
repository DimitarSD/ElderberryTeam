namespace TeamElderberryProject.Interfaces
{
    using System.Collections.Generic;
    public interface IImporter
    {
        IList<ITransaction> Import();
    }
}
