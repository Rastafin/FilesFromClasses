using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLearning
{
    public class Singleton
    {
        private readonly static Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

        public int X { get; set; } = 0;

        public int Y { get; set; } = 0;

        private Singleton()
        {
            Console.WriteLine("Creating Singleton Lazy instance");
        }

        public static Singleton Instance { get { return _instance.Value; } }

        public int Sum() {  return X + Y; }

    }
}
