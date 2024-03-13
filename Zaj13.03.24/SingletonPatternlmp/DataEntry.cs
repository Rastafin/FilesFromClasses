using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternlmp
{
    internal class DataEntry
    {
        public required string Source { get; set; }
        public required string Title { get; set; }
        public string? Text { get; set; }
    }
}
