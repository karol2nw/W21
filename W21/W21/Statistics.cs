namespace W21
{
    public class Statistics
    {
        public float MinValue { get; private set; }
        public float MaxValue { get; private set; }
        public float Sum { get; private set; }
        public float AverageValue 
        {
            get
            {
                return Sum / Count;
            }
        }
        public char AverageLetter 
        { 
            get
            {
                switch (this.AverageValue)
                {
                    case var average when average >= 80:
                        return 'A';                      
                    case var average when average >= 60:
                        return 'B';                    
                    case var average when average >= 40:
                        return 'C';                 
                    case var average when average >= 20:
                        return 'D';                   
                    default :
                        return 'E';                                       
                }
            }
        }
        public int Count { get; set; }

        public Statistics()
        {
            MinValue = float.MaxValue;
            MaxValue = float.MinValue;
            Sum = 0;
            Count = 0;
        }

        public void AddRate(float rate)
        {
            Sum += rate;
            Count++;
            MinValue = Math.Min(MinValue, rate);
            MaxValue = Math.Max(MaxValue, rate);
        }







    }
}
