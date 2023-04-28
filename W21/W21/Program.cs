using W21;

Employee employee1 = new Employee ("Andrzej","Kowalski");



Console.WriteLine("Program do oceny pracowników");
Console.WriteLine("============================");
Console.WriteLine("aby zakończyć działanie programu wciśnij 'q' ");
Console.WriteLine("aby ocenić pracownika wciśnij '1' ");
Console.WriteLine("aby ocenić kierownika wciśnij '2");





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

}while(true);

var statistic = employee1.GetStatistics();

Console.WriteLine($"ocena pracowanika : {employee1.FirstName} {employee1.LastName}");
Console.WriteLine($"najwyższa ocena : {statistic.MaxValue} ");
Console.WriteLine($"najniższa ocena : {statistic.MinValue} ");
Console.WriteLine($" średnia ocena : {statistic.AverageValue :N2} ");
Console.WriteLine($"średnia ocena literowa : {statistic.AverageLetter}");











