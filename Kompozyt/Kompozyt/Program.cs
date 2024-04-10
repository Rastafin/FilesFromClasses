// See https://aka.ms/new-console-template for more information
using Kompozyt;
using System.ComponentModel;

Console.WriteLine("Hello, World!");

var root = CreateTree();
root.Display(0);

static Kompozyt.Component CreateTree()
{
    var root = new Composite("root");
    var composite1a = new Composite("element_1_a");

    var composite1b = new Composite("element_1_b");

    var composite1c = new Composite("element_1_b");

    var composite2a = new Composite("element_2_a");

    var composite2b = new Composite("element_2_b");

    var composite2c = new Composite("element_2_c");

    var composite3a = new Composite("element_3_a");

    var composite3b = new Composite("element_3_b");

    var composite3c = new Composite("element_3_c");

    var composite4a = new Composite("element_4_a");

    var composite3a2 = new Composite("element_3_a_2");

    var composite3a3 = new Composite("element_3_a_3");

    var leaf1 = new Leaf("plik1.txt");

    var leaf2 = new Leaf("plik2.txt");

    var leaf3 = new Leaf("plik3.txt");

    var leaf4 = new Leaf("plik4.txt");

    root.Add(composite1a);
    root.Add(composite1b);
    root.Add(composite1c);

    composite1a.Add(composite2a);
    composite1b.Add(composite2b);

    composite2a.Add(composite3a);
    composite2a.Add(composite3a);
    composite2a.Add(composite3a);

    composite3a.Add(composite4a);

    composite4a.Add(leaf1);
    composite4a.Add(leaf2);

    composite2a.Add(leaf3);
    composite1b.Add(leaf4);

    return root;

}