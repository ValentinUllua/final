namespace FinalRegular
{
    public class DNINotExistsException : Exception
    {
        public DNINotExistsException() : base(Constants.ClienteNoExisteErrorMessage)
        {
        }
    }
}
