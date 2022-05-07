namespace NetCoreDessignPatterns.Patterns.Structural.Decorator
{
    public class Camion : VehiculoDecorator
    {
        public int Puertas { get; set; }
        private IVehiculo _vehiculo;
        public Camion(IVehiculo vehiculo)
        {
            _vehiculo = vehiculo;
            Descripcion = "Camion ";
        }

        public override string GetDatosVehiculos()
        {
            return _vehiculo.GetDatosVehiculos() + Descripcion;
        }
    }
}
