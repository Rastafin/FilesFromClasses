using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternlmp
{
    internal class Data
    {
        #region Singleton

        private readonly static Lazy<Data> _instance = new(() => new Data());

        public static Data Instance { get { return _instance.Value; } }

        private Data() { }

        #endregion
    }
}
