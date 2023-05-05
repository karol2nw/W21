
namespace W21
{
    public abstract class EmployeeBase : IEmployee
    {

        public delegate void RateAddedDelegate(object sender, EventArgs args);
        public event RateAddedDelegate RateAdded;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public EmployeeBase(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public abstract void AddRate(float rate);
        public abstract void AddRate(char rate);
        public abstract void AddRate(string rate);
        public abstract Statistics GetStatistics();



    }
}
