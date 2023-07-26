using NUnit.Framework;
using BegginerCourse;


namespace NumberValidator.nUnitTests
{
    public class NumberValidatorTests
    {
        BegginerCourse.NumberValidator numberValidator;

        public NumberValidatorTests()
        {
           numberValidator = new BegginerCourse.NumberValidator();

        }

        [Test]
        public void IsNumberValid_VerifyIfNumberIsValid_ShouldReturnFalse()
        {
            //Arrange
            bool expectedOutput = false;

            //Act
            var result = numberValidator.IsNumberValid("12a" , out int number);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void IsNumberValid_VerifyIfNumberIsValid_ShouldReturnTrue()
        {
            //Arrange
            bool expectedOutput = true;

            //Act
            var result = numberValidator.IsNumberValid("12", out int number);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void IsGreaterThen_VerifyIfNumberIsGreaterThenTheOther_ShouldReturnTrue()
        {
            //Arrange
            bool expectedOutput = true;

            //Act
            var result = numberValidator.IsGreaterThan(3,2);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void IsGreaterThen_VerifyIfNumberIsGreaterThenTheOther_ShouldReturnFalse()
        {
            //Arrange
            bool expectedOutput = false;

            //Act
            var result = numberValidator.IsGreaterThan(2, 10);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void IsGreaterThen_VerifyIfNumberIsIdentical_ShouldReturnFalse()
        {
            //Arrange
            bool expectedOutput = false;

            //Act
            var result = numberValidator.IsIdentical(2, 10);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void IsGreaterThen_VerifyIfNumberIsIdentical_ShouldReturnTrue()
        {
            //Arrange
            bool expectedOutput = true;

            //Act
            var result = numberValidator.IsIdentical(10, 10);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }


    }
}