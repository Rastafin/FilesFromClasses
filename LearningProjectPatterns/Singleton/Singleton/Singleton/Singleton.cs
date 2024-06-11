using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        #region SINGLETON

        private static Singleton instance;

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        private Singleton() { }

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
