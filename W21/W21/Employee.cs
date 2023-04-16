namespace W21
{
    public class Employee
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private List<float> rates = new List<float>();
        public float Result

        {
            get
            {
                return rates.Sum();
            }

        }
        public Employee(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }
        public void AddRate(float Rate)
        {
            if (Rate >= 0 && Rate <= 100)
                
            {
                rates.Add(Rate);
            }
            else
            {
                Console.WriteLine("out of range");
            }
        }
        public void AddRate(string Rate)
        {
            float.TryParse(Rate, out float result);
            this.AddRate(result);
        }
        public void AddRate(int Rate)
        {
            this.AddRate((float)Rate);
        }
        public void AddRate(decimal Rate)
        {
            this.AddRate((float)Rate);
        }
        public void AddRate(byte Rate)
        {
            this.AddRate((float)Rate);
        }

        public void SubstractRate(float Rate)
        {
            rates.Add(-Rate);
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

            return statistic;
        }

    }
}
