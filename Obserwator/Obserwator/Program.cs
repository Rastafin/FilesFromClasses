using Obserwator;

var o1 = new ConcreteObserver();
var o2 = new ConcreteObserver();

var subject = new ConcreteSubject();

subject.Attach(o1);
subject.Attach(o2);

subject.ID = 19;
subject.ID = 1;
subject.ID = 22;