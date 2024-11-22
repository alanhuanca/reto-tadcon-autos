using Domain.Entities;
using MediatR;

namespace Application.Queries
{
    public class GetAllAutosQuery : IRequest<IEnumerable<Auto>> { }
}
