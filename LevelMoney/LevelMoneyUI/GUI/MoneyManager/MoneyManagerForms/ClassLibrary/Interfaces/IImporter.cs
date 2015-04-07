namespace TeamElderberryProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TeamElderberryProject.Interfaces;

    public interface IImporter
    {
        IList<ITransaction> Import();
    }
}
