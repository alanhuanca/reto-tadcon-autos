using Application.Queries;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.Handlers
{
    public class GetAllAutosQueryHandler : IRequestHandler<GetAllAutosQuery, IEnumerable<Auto>>
    {
        private readonly IAutoRepository _autoRepository;

        public GetAllAutosQueryHandler(IAutoRepository autoRepository)
        {
            _autoRepository = autoRepository;
        }

        public async Task<IEnumerable<Auto>> Handle(GetAllAutosQuery request, CancellationToken cancellationToken)
        {
            return await _autoRepository.GetAllAsync();
        }
    }
}