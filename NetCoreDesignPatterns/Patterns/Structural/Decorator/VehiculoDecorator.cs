namespace NetCoreDessignPatterns.Patterns.Structural.Decorator
{
    public abstract class VehiculoDecorator : IVehiculo
    {
        public virtual string Descripcion { get; set; }
        public virtual string Tipo { get; set; }
        public virtual double Precio { get; set; }

        public abstract string GetDatosVehiculos();
    }
}
