namespace W21.Test
{
    internal class StatisticsTest
    {


        [Test]
        public void StatisticMaxValueTest()
        {
            var employee = new Employee("Gostek", "Testowy");

            employee.AddRate(5);
            employee.AddRate(10);
            employee.AddRate(3);

            var statistic1 = employee.GetStatistics();


            Assert.AreEqual(10, statistic1.MaxValue);


        }

        [Test]
        public void StatisticMinValueTest()
        {
            var employee = new Employee("Gostek", "Testowy");

            employee.AddRate(5);
            employee.AddRate(10);
            employee.AddRate(3);

            var statistic1 = employee.GetStatistics();


            Assert.AreEqual(3, statistic1.MinValue);


        }

        [Test]
        public void StatisticAverageValueTest()
        {
            var employee = new Employee("Gostek", "Testowy");

            employee.AddRate(5);
            employee.AddRate(10);
            employee.AddRate(3);

            var statistic1 = employee.GetStatistics();


            Assert.AreEqual(6, statistic1.AverageValue);


        }




    }
}
