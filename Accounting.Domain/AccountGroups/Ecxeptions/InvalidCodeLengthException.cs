using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.AccountGroups.Ecxeptions
{
    public class InvalidCodeLengthException : Exception
    {
        public InvalidCodeLengthException() : base("Length of name should be between 3 and 5!") { }
    }
}
