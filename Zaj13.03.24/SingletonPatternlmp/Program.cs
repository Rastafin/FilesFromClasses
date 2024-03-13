namespace SingletonPatternlmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Sources.FileSource().DownloadData();
            new Sources.NetworkSource().DownloadData();
            new Sources.WebSource().DownloadData();
        }
    }
}
