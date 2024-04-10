using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Items
{
    //LEAF
    internal class SimpleItem : Item
    {
        public ItemClass Class { get; private set; }

        public string Name { get; private set; }

        public int Size { get; private set; }

        public SimpleItem(ItemClass itemClass, string name, int size)
        {
            Class = itemClass;
            Name = name;
            Size = size;
        }

        public string AddItem(Item item)
        {
            return "Nie mozna dodawac przedmiotu";
        }

        public string GetDetails()
        {
            return $@"
{new string('-', 5)} {this.Name} {new string('-', 5)}
Klasa przedmoitu : {this.Class}
Rozmiar : {this.Size}";
        }

        public string GetInformation(int depth)
        {
            return $"{new string('*', depth)} ${this.Name}";
        }

        public string RemoveItem(Item item)
        {
            return "Nie mozna usuwac przedmiotu";
        }
    }
}
