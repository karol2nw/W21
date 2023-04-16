namespace W21
{
    public class Employee
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
      

        private List<int> rates = new List<int>();
        public int Result

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
        public void AddRate(int Rate)
        {
            rates.Add(Rate);
        }

        public void SubstractRate(int Rate)
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
