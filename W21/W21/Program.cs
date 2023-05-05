using W21;

var employee1 = new EmployeeInMemory ("Andrzej","Kowalski");



Console.WriteLine("program do oceny pracowników");
Console.WriteLine("============================");
Console.WriteLine("aby zakończyć wpisywanie ocen programu wciśnij 'q' ");




employee1.RateAdded += RateAdded; 
    


void RateAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

do
{
    Console.WriteLine("podaj ocenę pracownika");

    var input = Console.ReadLine();

    try
    {
        employee1.AddRate(input);                
    }
    catch (Exception e)
    {
        Console.WriteLine($"exeption catched : {e.Message}");
    }

    if (input == "q")
    {
        break;
    }


} while (true);

var statistic = employee1.GetStatistics();
Console.WriteLine($"impljec1 : {statistic.MinValue}");
Console.WriteLine($"impljec1 : {statistic.Sum}");
Console.WriteLine($"impljec1 : {statistic.AverageValue}");
Console.WriteLine($"impljec1 : {statistic.AverageLetter}");















