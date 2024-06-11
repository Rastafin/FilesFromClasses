using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton4
    {
        private static readonly Lazy<Singleton4> instance = new Lazy<Singleton4>(() => new Singleton4());

        public static Singleton4 GetInstance()
        {
            return instance.Value;
        }

        public static Singleton4 Instance { get { return instance.Value; } }

        private Singleton4() { }

        public int X { get; set; }
    }
}
