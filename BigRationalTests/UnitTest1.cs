using BigRationalLib;

namespace BigRationalTests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 2, 1, 2)]
        [DataRow(2, 4, 1, 2)] // upraszczanie
        [DataRow(32, 12, 8, 3)] // upraszczanie
        [DataRow(1, -2, -1, 2)] // normalizacja znaku
        [DataRow(-1, 2, -1, 2)] // normalizacja znaku
        [DataRow(-1, -2, 1, 2)] // normaluzacja znaku
        public void Test_Constructor_2args_OK(int a, int b, int x, int y)
        {
            // Arrange
            // Act
            BigRational u = new BigRational(a, b);

            // Assert
            Assert.AreEqual(x, u.Numerator);
            Assert.AreEqual(y, u.Denominator);
        }
    }
}