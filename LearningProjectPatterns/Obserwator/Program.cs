using Obserwator;

var subject = new ConcreteSubject();

var observer1 = new ConcreteObserver("Observer 1");
var observer2 = new ConcreteObserver("Observer 2");
var observer3 = new ConcreteObserver("Observer 3");

subject.Attach(observer1);
subject.Attach(observer2);
subject.Attach(observer3);

subject.State = 1;

subject.Detach(observer3);

subject.State = 2;