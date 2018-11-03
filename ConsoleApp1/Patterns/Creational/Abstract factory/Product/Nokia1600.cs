namespace ConsoleApp1.Patterns.Creational.Abstract_factory
{
    /// The 'ProductB1' class  
    /// </summary>  
    public class Nokia1600 : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}