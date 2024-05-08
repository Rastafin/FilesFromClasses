using MVCPattern.Controllers;

var controller = new DataController();

controller.DisplaySimpleView("MD1");

controller.DisplaySimpleListView();

controller.DisplayComplexView("MD1");

controller.DisplayComplexListView();

