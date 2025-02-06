namespace Accounting.Domain.AccountGroups.Ecxeptions
{
    public class EmptyCodeException : Exception
    {
        public EmptyCodeException() : base("Code is empty!") { }
    }
}
