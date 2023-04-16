namespace W21.Test
{
    public class Tests
    {
        
        [Test]
        public void EmployeeSumScoreTest()
        {
            var employee = new Employee("Gostek", "Testowy");

            employee.AddRate(5);
            employee.AddRate(3);
            employee.AddRate(9);   
            

            Assert.AreEqual(17, employee.Result);
        
        
        }

        [Test]
        public void EmployeeSbstractScoreTest()
        {
            var employee = new Employee("Gostek", "Testowy");

            employee.SubstractRate(5);
            employee.AddRate(9);
            employee.AddRate(7);


            Assert.AreEqual(11, employee.Result);


        }









    }

}