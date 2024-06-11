using SingletonLearning;

var instance = Singleton.Instance;
var instance2 = Singleton2.GetInstance();

instance.X = 1;
instance.Y = 2;

instance2.X = 3;
instance2.Y = 4;

Console.WriteLine(instance.Sum().ToString());
Console.WriteLine(instance2.Sum().ToString());