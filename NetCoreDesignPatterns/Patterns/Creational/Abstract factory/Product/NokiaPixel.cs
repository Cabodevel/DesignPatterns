﻿namespace NetCoreDesignPatterns.Patterns.Creational.Abstract_factory.Product
{
    /// <summary>  
    /// The 'ProductA1' class  
    /// </summary>  
    public class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
