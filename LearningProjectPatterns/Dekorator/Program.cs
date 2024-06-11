using Dekorator;

IComponent simpleText = new ConcreteComponent();

IComponent boldText = new BoldDecorator(simpleText);
IComponent italicText = new ItalicDecorator(simpleText);

IComponent boldItalicText = new BoldDecorator(new ItalicDecorator(simpleText));

Console.WriteLine("Original: " + simpleText.Operation());
Console.WriteLine("Bold: " + boldText.Operation());
Console.WriteLine("Italic: " + italicText.Operation());
Console.WriteLine("Bold & Italic: " + boldItalicText.Operation());