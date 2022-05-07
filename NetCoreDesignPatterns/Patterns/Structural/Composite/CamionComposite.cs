namespace NetCoreDessignPatterns.Patterns.Structural.Composite
{
    public class CamionComposite : VehiculoComposite
    {
        public int Puertas { get; set; }
        public CamionComposite(VehiculoComposite vehiculo) : base(vehiculo)
        {
            Descripcion = "Camion ";
        }
    }
}
