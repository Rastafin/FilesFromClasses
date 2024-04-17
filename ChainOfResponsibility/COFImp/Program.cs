using COFImp;
using COFImp.Employees;

var director = new RegionDirector
{
    FirstName = "Jan",
    LastName = "Kowalski",
    Position = "IT Director",
};

var manager = new CountryManager
{
    FirstName = "Adam",
    LastName = "Nowak",
    Position = "Polish Country Manager",
    Supervisor = director
};

var expert = new LowLevelEmployee
{
    FirstName = "Maciej",
    LastName = "Wolski",
    Position = "Help Desk Spiecialist",
    Supervisor = manager
};

var department = new Department { Name = "IT Department" };

department.Employees.Add(expert);
department.Employees.Add(manager);
department.Employees.Add(director);

department.RequestOrderApproval(new Order
{
    ID = "01/02/2024",
    Count = 331,
    Price = 1000
});