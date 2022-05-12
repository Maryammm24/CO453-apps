using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter2 converter = new DistanceConverter2();

                converter.FromUnit = DistanceUnits.Miles;
                converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 5280;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
            
        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter2 converter = new DistanceConverter2();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 5280;
            converter.CalculateDistance();

            double expectedDistance = 1;

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter2 converter = new DistanceConverter2();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 3.28084;
            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter2 converter = new DistanceConverter2();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 3.28084;

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter2 converter = new DistanceConverter2();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 1609.34;

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter2 converter = new DistanceConverter2();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 1609.34;
            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
    }
}
