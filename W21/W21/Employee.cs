namespace W21
{
    public class Employee : Person

    {

       

        private List<float> rates = new List<float>();
        public float Result

        {
            get
            {
                return rates.Sum();
            }

        }
        public Employee(string FirstName, string LastName)
           : base(FirstName,LastName)        
        {
            

        }
        public void AddRate(float Rate)
        {
            if (Rate >= 0 && Rate <= 100)

            {
                rates.Add(Rate);
            }
            else
            {
                throw new Exception("out of range");
            }
        }
        public void AddRate(string Rate)
        {
           if( float.TryParse(Rate, out float result))
           {
                this.AddRate(result);
           }
           else if(char.TryParse(Rate, out char letter))
            {
                this.AddRate(letter);

            }
            
            else
           {
                throw new Exception("invalid string value");
           }
        }
        
        public void AddRate(char Rate)
        {
            switch (Rate)
            {
                case 'A':
                case 'a':
                    rates.Add(100);
                    break;

                case 'B':
                case 'b':

                    rates.Add(80);
                    break;

                case 'C':
                case 'c':
                    rates.Add(60);
                    break;

                case 'D':
                case 'd':
                    rates.Add(40);
                    break;

                case 'E':
                case 'e':
                    rates.Add(20);
                    break;

                default:
                    throw new Exception("wrong letter");

            }
        }

        public Statistics GetStatistics()
        {
            var statistic = new Statistics();
            statistic.MaxValue = float.MinValue;
            statistic.MinValue = float.MaxValue;
            statistic.AverageValue = 0;

            foreach (var rate in rates)
            {

                statistic.MaxValue = Math.Max(statistic.MaxValue, rate);
                statistic.MinValue = Math.Min(statistic.MinValue, rate);
                statistic.AverageValue += rate;

            }

            statistic.AverageValue /= rates.Count;

            switch (statistic.AverageValue)
            {
                case var average when average >= 80:
                    statistic.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistic.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistic.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistic.AverageLetter = 'D';
                    break;
                case var average when average >= 0:
                    statistic.AverageLetter = 'E';
                    break;
                default:
                    throw new Exception("invalid letter");
            }

            return statistic;
        }
    }
}
