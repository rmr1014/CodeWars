using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.Commands;

namespace CodeWars.UnitTests
{
    [TestFixture]
    public class StringHandlerTests
    {
        #region GetVowelCount

        [TestCase]
        public void GetVowelCount_StringWithOneVowel_ReturnsZero()
        {
            // Arrange
            var stringHandler = new StringHandler();
            var str = "???";

            // Act
            var result = stringHandler.GetVowelCount(str);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestCase]
        public void GetVowelCount_StringWithOneVowel_ReturnsOne()
        {
            // Arrange
            var stringHandler = new StringHandler();
            var str = "Bad";

            // Act
            var result = stringHandler.GetVowelCount(str);

            // Assert
            Assert.AreEqual(1, result);
        }

        #endregion

    }
}
