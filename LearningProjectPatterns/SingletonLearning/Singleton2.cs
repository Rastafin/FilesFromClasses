using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLearning
{
    internal class Singleton2
    {
        private static readonly Singleton2 _instance = new Singleton2();

        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        private Singleton2()
        {
            Console.WriteLine("Creating Singleton instance");
        }

        public static Singleton2 GetInstance() { return _instance; }

        public int Sum()
        {
            return X + Y;
        }
    }
}
