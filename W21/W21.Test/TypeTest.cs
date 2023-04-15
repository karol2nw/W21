using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W21.Test
{
    internal class TypeTest
    {
        [Test]
        public void IntValueTest()
        {
            int number1  = 5;
            int number2 = 5;


            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void StringValueTest()
        {
            string phrase1 = "Hello";
            string phrase2 = "Hello";


            Assert.AreEqual(phrase1, phrase2);
      
        }

        [Test]
        public void StringDifferentValueTest()
        {
            string phrase1 = "Hello";
            string phrase2 = "Yellow";

            
            Assert.AreNotEqual(phrase1, phrase2);

        }

        [Test]
        public void FloatValueTest()
        {
            float number1 = 5.47f;
            float number2 = 5.47f;


            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void FloatDifferenValueTest()
        {
            float number1 = 5.47f;
            float number2 = 8.32f;


            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void ReferenceDifferentValueTest()
        {
            var testmen1 = new Employee("Testowy", "Gostek", 20);
            var testmen2 = new Employee("Testowy", "Gostek", 20);


            Assert.AreNotEqual(testmen1, testmen2);

        }











    }
}
