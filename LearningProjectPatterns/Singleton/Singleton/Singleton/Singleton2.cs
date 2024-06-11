using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton2
    {
        #region SINGLETON

        private static Singleton2 instance;

        private static object o = new object();

        public static Singleton2 GetInstance()
        {
            lock (o)
            {
                if (instance == null)
                {
                    instance = new Singleton2();
                }
                return instance;
            }
        }

        private Singleton2() { }

        #endregion

        #region PROPS

        public int X { get; set; }

        public int Y { get; set; }

        public int Sum()
        {
            return X + Y;
        }

        #endregion
    }
}
