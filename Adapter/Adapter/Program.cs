namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Target>()
            {
                new Target(),
                new Adapter(),
                new LibraryAdapter()
            };

            list.ForEach(target => target.PrintInformation());
        }
    }
}
