using Dzien_6;

namespace Dzien6.Test_Dzien7_
{
    public class TypeTest
    {
        [Test]
        public void CheckReferenceType()
        {
            //arrange
            var employee1 = GetEmployee("Karol", "Pierwszy", 24);
            var employee2 = GetEmployee("Ania", "Druga", 42);

            //act


            //assert
            Assert.AreNotEqual(employee1, employee2);

        }

        [Test]
        public void CheckValueType()
        {
            //arrange
            var number1 = 22;
            var number2 = 25;

            //act


            //assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void CheckStringType()
        {
            //arrange
            var word1 = "Karol";
            var word2 = "Ania";

            //act


            //assert
            Assert.AreNotEqual(word1, word2);

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
