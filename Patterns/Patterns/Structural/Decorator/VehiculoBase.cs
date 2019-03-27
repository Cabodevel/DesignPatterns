using System;

namespace ConsoleApp1.Patterns.Structural.Decorator
{
    public class VehiculoBase: VehiculoDecorator, IVehiculo
    {
        public VehiculoBase()
        {
            Descripcion = "Vehiculo ";
        }
        
        public override string GetDatosVehiculos()
        {
            return Descripcion;
        }
    }
}
