using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Items
{
    //COMPONENT
    internal interface Item
    {
        ItemClass Class { get; }
        string Name { get; }

        int Size { get; }

        string AddItem(Item item);

        string RemoveItem(Item item);

        string GetInformation(int depth);

        string GetDetails();
    }
}
