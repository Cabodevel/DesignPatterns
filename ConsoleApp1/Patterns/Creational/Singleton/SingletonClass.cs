using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns
{
    public class SingletonClass
    {
        private static SingletonClass _singleton;

        protected SingletonClass()
        {

        }

        public static SingletonClass Instance()
        {
            if (_singleton == null)
                _singleton = new SingletonClass();
            return _singleton;
        }

    }
}
