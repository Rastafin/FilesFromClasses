using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Items
{
    internal class ComplexItem : Item
    {

        private readonly List<Item> _items = new();

        private int _itemsSize = 0;
        public ItemClass Class {  get; private set; }

        public string Name { get; private set; }

        public int Size { get; private set; }

        public int Capacity { get; private set; }

        public List<ItemClass> AllowedItems { get; private set; }

        public ComplexItem(ItemClass itemClass, string name, int size, int capacity, List<ItemClass> allowedItems)
        {
            Class = itemClass;
            Name = name;
            Size = size;
            Capacity = capacity;
            AllowedItems = allowedItems;
        }

        public string AddItem(Item item)
        {
            if (item == null) { return "Nie mozna dodac elementu";  }

            if(!AllowedItems.Contains(item.Class)) { return "Nie mozna dodac elementu tej klasy"; }

            if(Capacity < _itemsSize + item.Size) { return "Nie ma miejsca na dodanie przedmiotu"; }

            _items.Add(item);
            _itemsSize += item.Size;

            return $"Dodano element do przedmiotu: ${item.Name}"; 
        }

        public string GetDetails()
        {
            return $@"
{new string('-', 5)} {this.Name} {new string('-', 5)}
Klasa przedmoitu : {this.Class}
Rozmiar : {this.Size}
Pojemnosc : {this.Capacity}
Zajete miejsce: {this.Capacity - this._itemsSize}
Dozwolone przedmioty do dodania: {String.Join(',', AllowedItems)}
";
        }

        public string GetInformation(int depth)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{new string('*', depth)} ${this.Name}");

            _items.ForEach(component => stringBuilder.AppendLine(component.GetInformation(depth + 3)));

            return stringBuilder.ToString();
        }

        public string RemoveItem(Item item)
        {
            if (item == null) { return "Nie mozna usunac elementu"; }

            if (_items.Remove(item))
            {
                _itemsSize -= item.Size;
                return $"Usuniety element z listy {item.Name}";
            }
            else return $"Nie ma takiego elementu na liscie {item.Name}";
        }
    }
}
