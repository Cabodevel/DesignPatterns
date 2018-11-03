using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class Class1
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Pass { get; set; }
    }
}