using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternlmp.Sources
{
    internal class NetworkSource : IDataSource
    {
        public void DownloadData()
        {
            for(int i = 0; i < 10; i++)
            {
                Data.Instance.Add(new DataEntry
                {
                    Source = "network",
                    Title = "Element ze źródła NetworkSource"
                });
            }
        }
    }
}
