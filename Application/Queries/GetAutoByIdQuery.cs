using Domain.Entities;
using MediatR;

namespace Application.Queries
{
    public class GetAutoByIdQuery : IRequest<Auto>
    {
        public int Id { get; set; }
    }
}