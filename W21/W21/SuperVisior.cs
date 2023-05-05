
namespace W21
{
    public class SuperVisior : EmployeeBase
    {
        public SuperVisior(string firstName, string lastName)
        : base(firstName, lastName)
        {

        }

        private List<float> rates = new List<float>();
        public float result
        {
            get
            {
                return rates.Sum();
            }
        }


        public override void AddRate(float rate)
        {
            if (rate >= 0 && rate <= 100)
            {
                this.rates.Add(result);
            }
            else
            {
                throw new Exception("out of range");
            }
        }

        public override void AddRate(string rate)
        {
            switch (rate)
            {
                case "6":
                    rates.Add(100);
                    break;
                case "6-":
                case "-6":
                    rates.Add(95);
                    break;
                case "5+":
                case "+5":
                    rates.Add(85);
                    break;
                case "5":
                    rates.Add(80);
                    break;
                case "5-":
                case "-5":
                    rates.Add(75);
                    break;
                case "4+":
                case "+4":
                    rates.Add(65);
                    break;
                case "4":
                    rates.Add(60);
                    break;
                case "4-":
                case "-4":
                    rates.Add(55);
                    break;
                case "3+":
                case "+3":
                    rates.Add(45);
                    break;
                case "3":
                    rates.Add(40);
                    break;
                case "3-":
                case "-3":
                    rates.Add(35);
                    break;
                case "2+":
                case "+2":
                    rates.Add(25);
                    break;
                case "2":
                    rates.Add(20);
                    break;
                case "2-":
                case "-2":
                    rates.Add(15);
                    break;
                case "1+":
                case "+1":
                    rates.Add(5);
                    break;
                case "1":
                    rates.Add(0);
                    break;
                default:
                    throw new Exception("invalid string value");
            }

            if (char.TryParse(rate, out char letter))
            {
                this.rates.Add(letter);
            }
            else
            {
                throw new Exception("invalid letter");
            }
        }
        public override void AddRate(char letter)
        {
            switch (letter)
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

        public override Statistics GetStatistics()
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
