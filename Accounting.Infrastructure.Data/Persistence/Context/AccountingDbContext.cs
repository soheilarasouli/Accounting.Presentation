using Accounting.Domain.AccountGroups.Models;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Data.Persistence.Context
{
    public class AccountingDbContext : DbContext
    {
        public AccountingDbContext(DbContextOptions<AccountingDbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<AccountGroup> AccountGroups { get; set; }
    }
}
