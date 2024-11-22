using Application.Queries;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.Handlers
{
    public class GetAutoByIdQueryHandler : IRequestHandler<GetAutoByIdQuery, Auto>
    {
        private readonly IAutoRepository _autoRepository;

        public GetAutoByIdQueryHandler(IAutoRepository autoRepository)
        {
            _autoRepository = autoRepository;
        }

        public async Task<Auto> Handle(GetAutoByIdQuery request, CancellationToken cancellationToken)
        {
            return await _autoRepository.GetByIdAsync(request.Id);
        }
    }
}