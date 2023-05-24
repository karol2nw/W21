using W21;

var employee1 = new EmployeeInFile ("Andrzej","Kowalski");
var employee2 = new EmployeeInFile("skurwiały", "chooj");


Console.WriteLine("program do oceny pracowników");
Console.WriteLine("============================");
Console.WriteLine("aby zakończyć wpisywanie ocen programu wciśnij 'q' ");




employee1.RateAdded += RateAdded;



void RateAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employee1.AddRate(5);
employee1.AddRate(10);
employee1.AddRate(20);
employee2.AddRate(25);
employee2.AddRate(30);
//do
//{
//    Console.WriteLine("podaj ocenę pracownika");

//    var input = Console.ReadLine();

//    try
//    {
//        employee1.AddRate(input);                
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"exeption catched : {e.Message}");
//    }

//    if (input == "q")
//    {
//        break;
//    }


//} while (true);

var statistic = employee1.GetStatistics();
Console.WriteLine($"employee1: {statistic.MinValue}");
Console.WriteLine($"employee1 : {statistic.Sum}");
Console.WriteLine($"employee1 : {statistic.AverageValue}");
Console.WriteLine($"employee1 : {statistic.AverageLetter}");















