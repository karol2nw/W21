namespace W21.Test
{
    public class Tests
    {

        [Test]
        public void EmployeeSumScoreTest()
        {
            var employee = new EmployeeInMemory("Gostek", "Testowy");

            employee.AddRate(5);
            employee.AddRate(3);
            employee.AddRate(9);


            Assert.AreEqual(17, employee.result);


        }



    }

}