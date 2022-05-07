namespace NetCoreDesignPatterns.Patterns.Creational.Abstract_factory.Product
{
    /// <summary>  
    /// The 'ProductB2' class  
    /// </summary>  
    public class SamsungGuru : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
