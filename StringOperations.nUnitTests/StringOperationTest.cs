using BegginerCourse;

namespace StringOperations.nUnitTests
{
    public class StringOperationsTests
    {
        BegginerCourse.StringOperations stringOperations;

        [SetUp]
        public void Setup()
        {
            stringOperations = new BegginerCourse.StringOperations();
        }

        [Test]
        public void CountNumberOfVowels_SumTheNumberOfVowelsOfAnWord_ShouldReturn6()
        {
            //Arrange
            int expectedOutput = 6;

            //Act
            var result = stringOperations.CountNumberOfVowels("Ola amigos do C#");

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void CountNumberOfVowels_SumTheNumberOfVowelsOfAnWord_ShouldReturn3()
        {
            //Arrange
            int expectedOutput = 3;

            //Act
            var result = stringOperations.CountNumberOfVowels("João");

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void CountNumberOfVowels_SumTheNumberOfVowelsOfAnWord_ShouldReturn0()
        {
            //Arrange
            int expectedOutput = 0;

            //Act
            var result = stringOperations.CountNumberOfVowels("CTT");

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void CountNumberOfVowels_SumTheNumberOfVowelsOfAnWord_ShouldReturnZero()
        {
            //Arrange
            int expectedOutput = 0;

            //Act
            var result = stringOperations.CountNumberOfVowels("");

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void CountNumberOfVowels_SumTheNumberOfVowelsOfAnWord_ShouldReturn15()
        {
            //Arrange
            int expectedOutput = 15;

            //Act
            var result = stringOperations.CountNumberOfVowels("AAAAAAAAAAbbbbbEEEEE");

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ReverseString_ReverseTheInputedText_ShouldReturnInvertedText()
        {
            //Arrange
            string expectedOutput = "luaR";

            //Act
            var result = stringOperations.ReverseString("Raul");

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ReverseString_ReverseTheInputedText_ShouldReturnInvertedTextWithNumber()
        {
            //Arrange
            string expectedOutput = "lu23aR";

            //Act
            var result = stringOperations.ReverseString("Ra32ul");

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

    }
}