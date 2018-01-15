using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKata
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void GetOutput_0_ReturnsBlankString()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var output = game.GetOutput(0);

            // Assert
            Assert.AreEqual(output, "");
        }

        [TestMethod]
        public void GetOutput_1_Returns1()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var output = game.GetOutput(1);

            // Assert
            Assert.AreEqual(output, "1");
        }


        [TestMethod]
        public void GetOutput_2_Returns2()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var output = game.GetOutput(2);

            // Assert
            Assert.AreEqual(output, "2");
        }

        [TestMethod]
        public void GetOutput_3_ReturnsFizz()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var output = game.GetOutput(3);

            // Assert
            Assert.AreEqual(output, "Fizz");
        }

        [TestMethod]
        public void GetOutput_4_Returns4()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var output = game.GetOutput(4);
            
            // Assert
            Assert.AreEqual(output, "4");
        }

        [TestMethod]
        public void GetOutput_5_ReturnsBuzz()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var output = game.GetOutput(5);

            // Assert
            Assert.AreEqual(output, "Buzz");
        }

        [TestMethod]
        public void GetOutput_15_ReturnsFizzBuzz()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var output = game.GetOutput(15);

            // Assert
            Assert.AreEqual(output, "FizzBuzz");
        }
    }
}
