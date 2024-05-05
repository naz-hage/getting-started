using DisplayLib;

namespace DisplayTests
{
    [TestClass]
    public class DisplayHelperTests
    {
        [TestMethod]
        public void GetString_ReturnsCorrectString()
        {
            // Arrange
            DisplayHelper displayHelper = new DisplayHelper();

            // Act
            string result = displayHelper.GetString();

            // Assert
            Assert.AreEqual("Hello from DisplayLib!", result);
        }
    }
}
