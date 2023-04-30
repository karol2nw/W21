using W21;

EmployeeInFile employee1 = new EmployeeInFile ("Andrzej","Kowalski");



//Console.WriteLine("Program do oceny pracowników");
//Console.WriteLine("============================");
//Console.WriteLine("aby zakończyć działanie programu wciśnij 'q' ");


employee1.AddRate("5");
employee1.AddRate("A");
employee1.AddRate ("B");
employee1.AddRate ("68");

var statistic = employee1.GetStatistics();
Console.WriteLine($" min : {statistic.MinValue} , max: {statistic.MaxValue}, avg: {statistic.AverageValue}");




//do
//{
//   Console.WriteLine("podaj ocenę pracownika");
   
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

//}while(true);

//var statistic = employee1.GetStatistics();

//Console.WriteLine($"ocena pracowanika : {employee1.FirstName} {employee1.LastName}");
//Console.WriteLine($"najwyższa ocena : {statistic.MaxValue} ");
//Console.WriteLine($"najniższa ocena : {statistic.MinValue} ");
//Console.WriteLine($" średnia ocena : {statistic.AverageValue :N2} ");
//Console.WriteLine($"średnia ocena literowa : {statistic.AverageLetter}");











