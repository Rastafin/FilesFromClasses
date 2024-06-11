using ChainOfResponsibility;

Manager manager = new Manager();
Director director = new Director();
CEO ceo = new CEO();

manager.SetNext(director).SetNext(ceo);

Console.WriteLine("Sending request to approve budget");
manager.HandleRequest("Approve Budget");

Console.WriteLine("Sending request to approve project");
manager.HandleRequest("Approve Project");

Console.WriteLine("Sending request to approve strategy");
manager.HandleRequest("Approve Strategy");

Console.WriteLine("Sending unknown request");
manager.HandleRequest("Unknown Request");
