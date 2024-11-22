using MediatR;

namespace Application.Commands
{
    public class DeleteAutoCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}