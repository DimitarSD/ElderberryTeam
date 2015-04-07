namespace TeamElderberryProject
{
    using TeamElderberryProject.Interfaces;

    public interface IExporter
    {
        void Export(ITransaction transaction);
    }
}
