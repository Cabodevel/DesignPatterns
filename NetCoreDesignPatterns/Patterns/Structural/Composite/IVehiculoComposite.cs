using System.Collections.Generic;

namespace NetCoreDessignPatterns.Patterns.Structural.Composite
{
    public interface IVehiculoComposite
    {
        string Descripcion { get; set; }
        string Tipo { get; set; }
        double Precio { get; set; }

        string GetDatosVehiculos();
        void Add(params IVehiculoComposite[] v);
        void Remove(IVehiculoComposite v);
        string GetChilds();
    }
}