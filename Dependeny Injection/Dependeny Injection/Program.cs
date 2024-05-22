using Dependeny_Injection;
using Dependeny_Injection.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Xml.Serialization;

var document = new Document
{
    Title = "Document WP 1",
    Content = "Dependency Injection"
};

new DocumentService(new TextRepository()).AddDocumentToRepository(document);

var service = new DocumentService(new NetworkRepository());

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IRepository, TextRepository>();

var provider = serviceCollection.BuildServiceProvider();

provider.GetService<TextRepository>();