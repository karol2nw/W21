using W21;

Employee employee1 = new Employee ("Andrzej","Kowalski");
Employee employee2 = new Employee ("Maria","Jaworska");
Employee employee3 = new Employee("Edward", "Psikuta");

employee1.AddRate(5);
employee1.AddRate(8);

var stats = employee1.GetStatistics();
Console.WriteLine(stats.AverageValue );


List<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3 
};

