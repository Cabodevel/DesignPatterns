namespace ConsoleApp1.Patterns.Creational.Prototype
{
    public class Nano : BasicCar
    {
        public Nano(string m)
        {
            ModelName = m;
        }
        public override BasicCar Clone()
        {
            return (Nano)this.MemberwiseClone();
        }
    }
}
        
