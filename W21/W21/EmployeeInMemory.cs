namespace W21
{
    public class EmployeeInMemory : EmployeeBase, IEmployee
    {
        public event RateAddedDelegate RateAdded;


        private List<float> rates = new List<float>();
        
        public EmployeeInMemory(string firstName, string lastName)
           : base(firstName, lastName)
        {
        }
        public override void AddRate(float rate)
        {
            if (rate >= 0 && rate <= 100)

            {
                rates.Add(rate);
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
                throw new Exception("invalid string value");
            }
        }

        public override void AddRate(char rate)
        {
            switch (rate)
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

                case 'q':
                    break;

                default:
                    throw new Exception("wrong letter");
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
             foreach (var rate in rates)
             {
                statistics.AddRate(rate);                   
             }
            return statistics;
        }
    }
}
