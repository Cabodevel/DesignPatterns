

namespace NetCoreDessignPatterns.Patterns.Structural.Decorator
{
    public class CamionConRemolqueFrio : VehiculoDecorator,IVehiculo
    {
        public IVehiculo VehiculoPadre { get; set; }
        public int Temperatura { get; set; }

        public CamionConRemolqueFrio(IVehiculo vehiculo)
        {
            Descripcion = "Con Remolque Frio ";
            VehiculoPadre = vehiculo;
        }

        public override string GetDatosVehiculos()
        {
            return VehiculoPadre.GetDatosVehiculos() + Descripcion;
        }
    }
}
