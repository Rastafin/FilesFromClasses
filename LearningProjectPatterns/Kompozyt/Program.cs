using Kompozyt;

Composite tree = new Composite();

Composite composite1 = new Composite();
Composite composite2 = new Composite();

Leaf leaf1 = new Leaf();
Leaf leaf2 = new Leaf();
Leaf leaf3 = new Leaf();
Leaf leaf4 = new Leaf();
Leaf leaf5 = new Leaf();

composite1.AddComponent(leaf1);
composite1.AddComponent(leaf2);
composite1.AddComponent(leaf3);

composite2.AddComponent(leaf4);

tree.AddComponent(composite1);
tree.AddComponent(composite2);
tree.AddComponent(leaf5);

Console.WriteLine(tree.Operation());


