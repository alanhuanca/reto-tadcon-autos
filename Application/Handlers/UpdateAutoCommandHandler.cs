using Application.Commands;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.Handlers
{
    public class UpdateAutoCommandHandler : IRequestHandler<UpdateAutoCommand, Unit>
    {
        private readonly IAutoRepository _autoRepository;

        public UpdateAutoCommandHandler(IAutoRepository autoRepository)
        {
            _autoRepository = autoRepository;
        }

        public async Task<Unit> Handle(UpdateAutoCommand request, CancellationToken cancellationToken)
        {
            var auto = new Auto
            {
                Id = request.Id,
                Marca = request.Marca,
                Modelo = request.Modelo,
                Tipo = request.Tipo,
                CantidadAsientos = request.CantidadAsientos,
                AñoFabricacion = request.AñoFabricacion
            };

            await _autoRepository.UpdateAsync(auto);
            return Unit.Value;
        }
    }
}