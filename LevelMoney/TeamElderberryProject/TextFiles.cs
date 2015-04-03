namespace TeamElderberryProject
{
    using System.Text;

    public class TextFiles
    {
        private const string TextFilesDataStringFormat = "ID: {0} | Date and time: {1} | Amount: {2} | ";

        public override string ToString()
        {
            StringBuilder textFilesToString = new StringBuilder();

            textFilesToString.Append(string.Format(TextFilesDataStringFormat, )); // TO DO

            return textFilesToString.ToString();
        }
    }
}
