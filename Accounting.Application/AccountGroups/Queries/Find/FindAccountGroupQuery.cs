using Accounting.Domain.AccountGroups.Dtos;
using MediatR;

namespace Accounting.Application.AccountGroups.Queries.Find
{
    public class FindAccountGroupQuery : IRequest<AccountGroupDto>
    {
        public Guid Id { get; set; }
    }
}
