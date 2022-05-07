namespace NetCoreDessignPatterns.Patterns.Structural.Decorator
{
    public interface IVehiculo
    {
        string Descripcion { get; set; }
        string Tipo { get; set; }
        double Precio { get; set; }

        string GetDatosVehiculos();
    }
}