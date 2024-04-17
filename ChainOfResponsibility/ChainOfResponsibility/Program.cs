using ChainOfResponsibility;

var h1 = new Handler1();
var h2 = new Handler2();
var h3 = new Handler3();

h1.SetSuccessor(h2);
h2.SetSuccessor(h3);

h1.HandleRequest(new Request { Name = "Request 1", Value = 3333 });
h1.HandleRequest(new Request { Name = "Request 2", Value = 333 });
h1.HandleRequest(new Request { Name = "Request 3", Value = 33 });
h1.HandleRequest(new Request { Name = "Request 4", Value = 3 });