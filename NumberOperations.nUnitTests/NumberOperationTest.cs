using BegginerCourse;
namespace NumberOperations.nUnitTests
{
    public class NumberOperationsTests
    {

        BegginerCourse.NumberOperations numberOperations;

        private List<int> numberList = new List<int>();

        public NumberOperationsTests()
        {
            numberOperations = new BegginerCourse.NumberOperations();
        }

        [OneTimeSetUp]
        public void SetUp()
        {
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
        }

        [Test]
        public void CalculateFactorialNumber_CalculateFactorialOfNumber5_ShouldReturn120()
        {
            //Arrange
            int expectedOutput = 120;

            //Act
            var result = numberOperations.CalculateFactorialNumber(5);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void CalculateFactorialNumber_CalculateFactorialOfNumber10_ShouldReturn3628800()
        {
            //Arrange
            int expectedOutput = 3628800;

            //Act
            var result = numberOperations.CalculateFactorialNumber(10);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void SumThemAll_SumAllTheNumbersFromList_ShouldReturn6()
        {
            //Arrange
            int expectedOutput = 6;

            //Act
            var result = numberOperations.SumThemAll(numberList);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void NumbersAreConsecutive_CheckIfNumbersFromListAreConsecutive_ShouldReturnFalse()
        {
            //Arrange
            bool expectedOutput = false;

            string[] numbers = new string[4] { "1", "2", "4","5" };

            //Act
            var result = numberOperations.NumbersAreConsecutive(numbers);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }


        [Test]
        public void NumbersAreConsecutive_CheckIfNumbersFromListAreConsecutive_ShouldReturnTrue()
        {
            //Arrange
            bool expectedOutput = true;

            string[] numbers = new string[4] { "20", "19", "18", "17" };

            //Act
            var result = numberOperations.NumbersAreConsecutive(numbers);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }


    }
}