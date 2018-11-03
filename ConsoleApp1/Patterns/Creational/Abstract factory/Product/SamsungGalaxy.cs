﻿namespace ConsoleApp1.Patterns.Creational.Abstract_factory.Product
{
    /// <summary>  
    /// The 'ProductA2' class  
    /// </summary>  
    public class SamsungGalaxy : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
