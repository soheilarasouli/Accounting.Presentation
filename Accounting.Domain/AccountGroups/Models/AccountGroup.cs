using Accounting.Domain.AccountGroups.Ecxeptions;
using Accounting.Domain.Common.Models;

namespace Accounting.Domain.AccountGroups.Models
{
    public class AccountGroup : Entity
    {
        public string Name { get; set; }
        public string Code { get; set; }

        private AccountGroup()
        {
            
        }

        private AccountGroup(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public static AccountGroup Create(string code, string name)
        {
            if (code == null)
            {
                throw new EmptyCodeException();
            }

            if(name == null)
            {
                throw new EmptyNameException();
            }

            if (code.Length < 3 && code.Length > 5)
            {
                throw new InvalidCodeLengthException();
            }

            return new AccountGroup(code, name);
        }
    }
}
