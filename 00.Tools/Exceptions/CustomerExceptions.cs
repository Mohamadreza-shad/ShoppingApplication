namespace _00.Tools.Exceptions
{
    public class CustomerExceptions : ApplicationException
    {
        public CustomerExceptions(Error error) : base(error)
        {
        }
    }
}
