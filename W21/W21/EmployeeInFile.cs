﻿namespace W21
{
    public class EmployeeInFile : EmployeeBase
    {
        public event RateAddedDelegate RateAdded;

        private const string fileName = "rates.txt";
        public EmployeeInFile(string firstName, string lastName)
        : base(firstName, lastName)
        {

        }
        public override void AddRate(float rate)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (rate >= 0 && rate <= 100)
                {

                    writer.WriteLine(rate);
                    if (RateAdded != null)
                    {
                        RateAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("out of range");
                }
            }
        }
        public override void AddRate(string rate)
        {
            if (float.TryParse(rate, out float result))
            {
                this.AddRate(result);
            }
            else if (char.TryParse(rate, out char letter))
            {
                this.AddRate(letter);
            }
            else
            {
                throw new Exception("Invalid string value");
            }
        }
        public override void AddRate(char rate)
        {
            switch (rate)
            {
                case 'A':
                case 'a':
                    this.AddRate(100);
                    break;

                case 'B':
                case 'b':

                    this.AddRate(80);
                    break;

                case 'C':
                case 'c':
                    this.AddRate(60);
                    break;

                case 'D':
                case 'd':
                    this.AddRate(40);
                    break;

                case 'E':
                case 'e':
                    this.AddRate(20);
                    break;

                default:
                    throw new Exception("wrong letter");
            }
        }





        public override Statistics GetStatistics()
        {
            var ratesFromFile = this.ReadRates();
            var statistics = this.CountStatistics(ratesFromFile);
            return statistics;


        }

        private List<float> ReadRates()
        {
            var rates = new List<float>();
           
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        rates.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return rates;
        }

        private Statistics CountStatistics (List<float> rates)
        {
            var statistics = new Statistics();

            statistics.AverageValue = 0;
            statistics.MaxValue = float.MinValue;
            statistics.MinValue = float.MaxValue;

            foreach (var rate in rates)
            {                                
                    statistics.MaxValue = Math.Max(statistics.MaxValue, rate);
                    statistics.MinValue = Math.Min(statistics.MinValue, rate);
                    statistics.AverageValue += rate;                
            }
                statistics.AverageValue /= rates.Count;

                switch (statistics.AverageValue)
                {
                    case var average when average >= 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        statistics.AverageLetter = 'D';
                        break;
                    case var average when average >= 0:
                        statistics.AverageLetter = 'E';
                        break;
                    default:
                        throw new Exception("invalid letter");
                }                                    
            return statistics;
        }




    }
}
