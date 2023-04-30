

namespace W21
{
    internal interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }
        void AddRate(float rate);
        void AddRate(char rate);
        void AddRate(string rate);
        Statistics GetStatistics();







    }
}
