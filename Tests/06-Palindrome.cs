using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class Palindrome_Tests
    {
        [TestMethod]
        public void Palindrome_Test()
        {
            //Arrange
            string original = Utils.RandomString(Utils.random.Next(5, 10));
            bool result = false;
            bool resultOK = false;
            if (original.Length % 2 == 0)
            {
                string halfA = original.Substring(0, original.Length / 2);
                string halfB = original.Substring(original.Length / 2, original.Length / 2);
                halfB = new string(halfB.Reverse().ToArray());
                resultOK = halfA == halfB;
            }
            //Act
            result = Palindrome.Program.IsPalindrome(original);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
    }
}
