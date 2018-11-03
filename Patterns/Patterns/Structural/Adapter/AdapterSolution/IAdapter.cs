namespace DesignPattern.Patterns.Structural.Adapter
{
    /// <summary>
    /// Adapta los valores no válidos a nuestras necesidades
    /// </summary>
    public interface IAdapter
    {
        float CurrentSpeedInKilometersPerHour { get; set; }
        void Jump(float meters);
    }
    /// <summary>
    /// IAdapter no implementa el método de la clase NotValidExternalClass que no necesitamos
    /// </summary>
    public class ValidAdapterClass : IAdapter
    {
        private NotValidExternalClass Nv;

        public ValidAdapterClass()
        {
            Nv = new NotValidExternalClass();
        }
        //Convierte los valores al adaptador
        public float CurrentSpeedInKilometersPerHour {
            get { return Nv.CurrentSpeedInMilesPerHour * 1.6093f; }
            set { Nv.CurrentSpeedInMilesPerHour = value * 0.62137f; }
        }

        public void Jump(float meters)
        {
            Nv.Jump(meters * 0.3048f);
        }
    }
}
