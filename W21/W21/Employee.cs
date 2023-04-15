using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace W21
{
    public class Employee
    {
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        
        private List<int> score = new List<int>();
        public int Result

        {
            get
            {
                return score.Sum();
            }
        
        }
       
       public  Employee(string FirstName,string LastName, int Age)
       {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
       }
        public void AddScore(int Score)
        {
            score.Add(Score);
        }
        
        public void SubstractScore(int Score)
        {
            score.Add(-Score);
        }
        
        
        public void ShowScore()
        {
            Console.WriteLine(this.Result);
        }  

    }
}
