namespace W21.Test
{
    internal class StatisticsTest
    {


        [Test]
        public void StatisticMaxValueTestByChar()
        {
            var employee = new EmployeeInMemory("Gostek", "Testowy");

            employee.AddRate('b');
            employee.AddRate('e');
            employee.AddRate('C');

            var statistic1 = employee.GetStatistics();

            Assert.AreEqual(80, statistic1.MaxValue);
        }

        [Test]
        public void StatisticMinValueTestByChar()
        {
            var employee = new EmployeeInMemory("Gostek", "Testowy");

            employee.AddRate('a');
            employee.AddRate('D');
            employee.AddRate('c');

            var statistic1 = employee.GetStatistics();

            Assert.AreEqual(40, statistic1.MinValue);
        }
       
        [Test]
        public void StatisticAverageValueTest()
        {
            var employee = new EmployeeInMemory("Gostek", "Testowy");

            employee.AddRate('B');
            employee.AddRate('E');
            employee.AddRate('e');

            var statistic1 = employee.GetStatistics();

            Assert.AreEqual(40, statistic1.AverageValue);


        }




    }
}
