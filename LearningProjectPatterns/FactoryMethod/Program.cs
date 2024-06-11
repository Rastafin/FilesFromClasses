using FactoryMethod;

Factory factoryA = new FactoryA();
Factory factoryB = new FactoryB();

List<Factory> factories = new List<Factory>();
factories.Add(factoryA);
factories.Add(factoryB);

factories.ForEach(f => Console.WriteLine(f.CreateProduct().Print()));
