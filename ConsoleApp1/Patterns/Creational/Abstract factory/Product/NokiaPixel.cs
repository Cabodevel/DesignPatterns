﻿namespace DesignPattern.Patterns.Creational.Abstract_factory.Product
{
    /// <summary>  
    /// The 'ProductA1' class  
    /// </summary>  
    class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
