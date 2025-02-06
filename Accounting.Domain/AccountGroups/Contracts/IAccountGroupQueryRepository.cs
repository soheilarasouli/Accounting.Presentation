using Accounting.Domain.AccountGroups.Dtos;

namespace Accounting.Domain.AccountGroups.Contracts
{
    public interface IAccountGroupQueryRepository
    {
        AccountGroupDto GetById(Guid Id);
    }
}
