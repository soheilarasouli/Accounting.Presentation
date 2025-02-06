using Accounting.Domain.AccountGroups.Contracts;
using Accounting.Domain.AccountGroups.Dtos;
using MediatR;

namespace Accounting.Application.AccountGroups.Queries.Find
{
    public class FindAccountGroupQueryHandler : IRequestHandler<FindAccountGroupQuery, AccountGroupDto>
    {
        private IAccountGroupQueryRepository _repository;

        public FindAccountGroupQueryHandler(IAccountGroupQueryRepository repository)
        {
            _repository = repository;
        }

        public Task<AccountGroupDto> Handle(FindAccountGroupQuery request, CancellationToken cancellationToken)
        {
            var accountGroup = _repository.GetById(request.Id);
            return Task.FromResult(accountGroup);
        }
    }
}
