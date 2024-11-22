using Domain.Entities;
using MediatR;

namespace Application.Commands
{
    public class CreateAutoCommand : IRequest<int>
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public int CantidadAsientos { get; set; }
        public int AñoFabricacion { get; set; }
    }
}