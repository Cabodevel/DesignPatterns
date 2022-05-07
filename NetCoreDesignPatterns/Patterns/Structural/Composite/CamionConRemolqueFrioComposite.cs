

using System;

namespace NetCoreDessignPatterns.Patterns.Structural.Composite
{
    public class CamionConRemolqueFrioComposite : VehiculoComposite
    {
        public int Temperatura { get; set; }

        public CamionConRemolqueFrioComposite(VehiculoComposite vehiculo) : base(vehiculo)
        {
            Descripcion = "Con Remolque Frio ";
            Add(vehiculo);
            foreach (var item in vehiculo.GetChildsList())
            {
                Add(item);
            }
        }
    }
}
