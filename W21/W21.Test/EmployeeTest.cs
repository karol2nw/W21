namespace W21.Test
{
    public class Tests
    {
        
        [Test]
        public void EmployeeSumScoreTest()
        {
            var employee = new Employee("Gostek","Testowy",20);

            employee.AddScore(5);
            employee.AddScore(3);
            employee.AddScore(7);


            Assert.AreEqual(15, employee.Result);
        
        
        }

        [Test]
        public void EmployeeSbstractScoreTest()
        {
            var employee = new Employee("Gostek", "Testowy", 20);

            employee.SubstractScore(5);
            employee.AddScore(9);
            employee.AddScore(7);


            Assert.AreEqual(11, employee.Result);


        }









    }

}