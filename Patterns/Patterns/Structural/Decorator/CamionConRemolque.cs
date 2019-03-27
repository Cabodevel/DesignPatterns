using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns.Structural.Decorator
{
    public class CamionConRemolque : VehiculoDecorator, IVehiculo
    {
        public IVehiculo VehiculoPadre;
        public int Peso { get; set; }

        public CamionConRemolque(IVehiculo vehiculo) 
        {
            VehiculoPadre = vehiculo;
            Descripcion = "con remolque ";
        }

        public override string GetDatosVehiculos()
        {
            return VehiculoPadre.GetDatosVehiculos() + Descripcion;
        }
    }
}
