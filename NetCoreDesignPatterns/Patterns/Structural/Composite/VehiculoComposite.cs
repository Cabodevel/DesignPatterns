using System.Collections.Generic;
using System.Text;

namespace NetCoreDessignPatterns.Patterns.Structural.Composite
{
    public abstract class VehiculoComposite
    {
        public virtual string Descripcion { get; set; }
        public virtual string Tipo { get; set; }
        public virtual double Precio { get; set; }
        private List<VehiculoComposite> childs { get; set; }

        public VehiculoComposite()
        {

        }
        public VehiculoComposite(VehiculoComposite v)
        {
            Add(v);
        }
        public void Add(params VehiculoComposite[] v)
        {
            if (childs == null)
                childs = new List<VehiculoComposite>();
                childs.AddRange(v);
        }

        public virtual void Remove(VehiculoComposite v)
        {
            if (childs != null)
            {
                if(childs.Count > 0)
                    childs.Remove(v);
            }
        }
        
        public virtual List<VehiculoComposite> GetChildsList()
        {
            if(childs != null)
                return childs;
            return new List<VehiculoComposite>();
        }

        public virtual string GetChilds()
        {
            if(childs != null)
            {
                StringBuilder res = new StringBuilder();
                res.Append(GetType().ToString());
                foreach (var item in childs)
                {
                    res.Append($" {item.GetType().ToString()} ");
                }
                return res.ToString();
            }
            return "";
        }
    }
}
