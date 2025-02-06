using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.AccountGroups.Ecxeptions
{
    public class EmptyNameException : Exception
    {
        public EmptyNameException() : base("Name is empty!") { }
    }
}
