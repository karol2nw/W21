using W21;

Employee employee1 = new Employee ("Andrzej","Kowalski");
Employee employee2 = new Employee ("Maria","Jaworska");
Employee employee3 = new Employee("Edward", "Psikuta");

employee1.AddRate('A');
employee1.AddRate(8);

var stats = employee1.GetStatistics();
Console.WriteLine(stats.MaxValue );


List<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3 
};

