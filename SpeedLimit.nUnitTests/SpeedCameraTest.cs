using BegginerCourse;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace BegginerCoruse.Tests
{
    public class SpeedLimitTests
    {
        [TestCase]
        public void RunSpeedCamera_CarSpeedInsideLimits_ShouldPrintOk()
        {
            SpeedCamera speedCamera = new SpeedCamera(60, 60);

            //Arrange
            string expectedOutput = "Ok";

            //Act
            var result = speedCamera.RunSpeedCamera();

            //Assert
            Assert.AreEqual(expectedOutput, result);

        }

        [TestCase]
        public void RunSpeedCamera_CarSpeedInsideLimits_ShouldPrint2DemeritPoints()
        {

            SpeedCamera camera = new SpeedCamera(64, 50);

            //Arrange
            string expectedOutput = "Demerit Points: 2";


            //Act
            string result;
            result = camera.RunSpeedCamera();

            //Assert
            Assert.AreEqual(expectedOutput, result);

        }

        [TestCase]
        public void RunSpeedCamera_CarSpeedInsideLimits_ShouldPrint12DemeritPoints()
        {

           SpeedCamera camera = new SpeedCamera(120,60);

            //Arrange
            string expectedOutput = "Demerit Points: 12";


            //Act
            string result;
            result = camera.RunSpeedCamera();

            //Assert
            Assert.AreEqual(expectedOutput, result);

        }



        [TestCase]
        public void RunSpeedCamera_CarSpeedInsideLimits_ShouldPrintLicenseSuspended()
        {

            SpeedCamera camera = new SpeedCamera(160, 60);

            //Arrange
            string expectedOutput = "License Suspended";


            //Act
            string result;
            result = camera.RunSpeedCamera();

            //Assert
            Assert.AreEqual(expectedOutput, result);

        }

        


    }
}