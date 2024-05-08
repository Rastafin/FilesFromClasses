using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Models
{
    internal class DataModel(string id) : IModel
    {
        public string ID { get; } = id;
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
    }
}
