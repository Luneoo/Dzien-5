using Dzien_6;

namespace Dzien6.Test_Dzien7_
{
    public class Tests
    {

        [Test]
        public void CheckResultSum()
        {
            //arrange
            var employee = new Employee("Karol", "Testowy", 24);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-10);
            employee.AddScore(-5);

            //act
            var resultTest = employee.ScoreCheck;

            //assert
            Assert.AreEqual(-4, resultTest);

        }
    }
}