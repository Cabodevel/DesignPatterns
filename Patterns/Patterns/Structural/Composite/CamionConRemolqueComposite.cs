namespace ConsoleApp1.Patterns.Structural.Composite
{
    public class CamionConRemolqueComposite : VehiculoComposite
    {
        public int Peso { get; set; }

        public CamionConRemolqueComposite(VehiculoComposite vehiculo) :base(vehiculo)
        {
            Descripcion = "con remolque ";
        }
    }
}
