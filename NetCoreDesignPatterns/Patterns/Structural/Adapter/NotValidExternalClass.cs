using System;

/// <summary>
/// Simulacion de clase de libreria externa que no se puede manipular
/// </summary>
namespace NetCoreDesignPatterns.Patterns.Structural.Adapter
{
    public interface INotValidExternal
    {
        float CurrentSpeedInMilesPerHour { get; set; }
        void EnablePartialFirstLawMode();
        void Jump(float feet);
    }

    public class NotValidExternalClass : INotValidExternal
    {
        private float CurrentSpeed;
        public float CurrentSpeedInMilesPerHour
        {
            get { return CurrentSpeed; }
            set { CurrentSpeed = value; }
        }

        public NotValidExternalClass()
        {
            this.CurrentSpeed = 0;
        }

        public void EnablePartialFirstLawMode()
        {
            Console.WriteLine("Partial first law enabled");
        }

        public void Jump(float feet)
        {
            Console.WriteLine($"Jump {feet}!!");
        }
    }
}
