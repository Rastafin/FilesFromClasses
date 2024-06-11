using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton3
    {
        #region SINGLETON

        private static readonly Singleton3 instance = new Singleton3();

        public static Singleton3 GetInstance()
        {
            return instance;
        }

        private Singleton3() { }

        #endregion
    }
}
