

namespace W21
{
    public abstract class Person
    {
       public string FirstName {  get; private set; }
       public string Lastname { get; private set; }

        public Person(string Name, string LastName)
        {
            this.FirstName = Name;

            this.Lastname = LastName;
        }

    }
}
