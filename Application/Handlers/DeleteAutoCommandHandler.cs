using Application.Commands;
using Domain.Interfaces;
using MediatR;

namespace Application.Handlers
{
    public class DeleteAutoCommandHandler : IRequestHandler<DeleteAutoCommand, Unit>
    {
        private readonly IAutoRepository _autoRepository;

        public DeleteAutoCommandHandler(IAutoRepository autoRepository)
        {
            _autoRepository = autoRepository;
        }

        public async Task<Unit> Handle(DeleteAutoCommand request, CancellationToken cancellationToken)
        {
            await _autoRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}