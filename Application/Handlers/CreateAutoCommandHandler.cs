using Application.Commands;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace Application.Handlers
{
    public class CreateAutoCommandHandler : IRequestHandler<CreateAutoCommand, int>
    {
        private readonly IAutoRepository _autoRepository;

        public CreateAutoCommandHandler(IAutoRepository autoRepository)
        {
            _autoRepository = autoRepository;
        }

        public async Task<int> Handle(CreateAutoCommand request, CancellationToken cancellationToken)
        {
            var auto = new Auto
            {
                Marca = request.Marca,
                Modelo = request.Modelo,
                Tipo = request.Tipo,
                CantidadAsientos = request.CantidadAsientos,
                AñoFabricacion = request.AñoFabricacion
            };

            await _autoRepository.AddAsync(auto);
            return auto.Id;
        }
    }
}