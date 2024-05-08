using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Models
{
    internal class DataListModel(string id) : List<DataModel>, IModel
    {
        public string ID { get; } = id;
    }
}
