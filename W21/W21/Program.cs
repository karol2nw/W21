using W21;

Employee employee1 = new Employee ("Andrzej","Kowalski",25);
Employee employee2 = new Employee ("Maria","Jaworska",30);
Employee employee3 = new Employee("Edward", "Psikuta", 45);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(7);
employee1.AddScore(6);
employee1.AddScore(10);

employee2.AddScore(1);
employee2.AddScore(9);
employee2.AddScore(8);
employee2.AddScore(7);
employee2.AddScore(10);

employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(9);
employee3.AddScore(8);
employee3.AddScore(7);

List<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3 
};

int maxValue = 0;
Employee employeeWithMaxValue = null;

foreach (var employee in employees)
{
    if(employee.Result > maxValue)
    {
        maxValue = employee.Result;
        employeeWithMaxValue = employee;
    }

}
Console.WriteLine($"pracownik z największą ilością punktów : \n{ employeeWithMaxValue.FirstName} { employeeWithMaxValue.LastName }, w wieku {employeeWithMaxValue.Age} lat");
Console.WriteLine($"z ilością punktów : {maxValue} ");