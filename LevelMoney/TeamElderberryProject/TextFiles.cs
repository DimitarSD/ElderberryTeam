namespace TeamElderberryProject
{
    using System.Text;

    public abstract class TextFiles
    {
        private const string TextFilesDataStringFormat = "Date and time: {0} | Amount: {1} | ";

        public override string ToString()
        {
            StringBuilder textFilesToString = new StringBuilder();

            //textFilesToString.Append(string.Format(TextFilesDataStringFormat, )); // TO DO

            return textFilesToString.ToString();
        }
    }
}