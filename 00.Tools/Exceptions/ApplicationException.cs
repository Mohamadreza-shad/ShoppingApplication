namespace _00.Tools.Exceptions
{
    public class ApplicationException : Exception
    {
        public Error Error { get; set; }
        public ApplicationException(Error error)
        {
            Error = error;
        }
    }
}
