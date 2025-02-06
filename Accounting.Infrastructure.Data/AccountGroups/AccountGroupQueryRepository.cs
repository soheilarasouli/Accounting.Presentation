using Accounting.Domain.AccountGroups.Contracts;
using Accounting.Domain.AccountGroups.Dtos;
using Accounting.Domain.AccountGroups.Models;
using Accounting.Infrastructure.Data.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Data.AccountGroups
{
    public class AccountGroupQueryRepository : IAccountGroupQueryRepository
    {
        private AccountingDbContext _dbContext;

        public AccountGroupQueryRepository(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public AccountGroupDto GetById(Guid Id)
        {
            var query = _dbContext
                .AccountGroups
                .Where(x => x.Id == Id)
                .Select(x => new AccountGroupDto
                {
                    Id = x.Id,
                    Code = x.Code,
                    Name = x.Name
                });

            return query.FirstOrDefault();
        }
    }
}
