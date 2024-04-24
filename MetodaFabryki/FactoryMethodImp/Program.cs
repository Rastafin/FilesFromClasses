// See https://aka.ms/new-console-template for more information
using FactoryMethodImp.Documents;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");


List<FactoryMethodImp.Documents.Document> documents = [
    new Article{Title = "Wzorce projektowe"},
    new Report{Title = "Tytul dwa"}
    ];

documents.ForEach(document => document.Print());