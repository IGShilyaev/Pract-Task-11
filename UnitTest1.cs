using Microsoft.VisualStudio.TestTools.UnitTesting;
using PractTask11;

namespace TestPractTask11
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCiphText()
        {
            //Arrange
            string text = "ABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCA";
            string expected1 = "ACABCBACBABCABCABACBACBACBCABCABCABCACBACBACBACBACABCABCABCABCABCBACBACBACBACBACBABCABCABCABCABCABCABACBACBACBACBACBACBAC";
            string text2 = "";
            string text3 = "Wrong text";
            string expected23 = "";
            //Act
            string actual1 = Program.CiphText(text);
            string actual2 = Program.CiphText(text2);
            string actual3 = Program.CiphText(text3);
            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected23, actual2);
            Assert.AreEqual(expected23, actual3);
        }

        [TestMethod]

        public void TestDeciphText()
        {
            //Arrange
            string expected1 = "ABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCA";
            string text1 = "ACABCBACBABCABCABACBACBACBCABCABCABCACBACBACBACBACABCABCABCABCABCBACBACBACBACBACBABCABCABCABCABCABCABACBACBACBACBACBACBAC";
            string text2 = "";
            string text3 = "Wrong text";
            string expected23 = "";
            //Act
            string actual1 = Program.DeCiphText(text1);
            string actual2 = Program.DeCiphText(text2);
            string actual3 = Program.DeCiphText(text3);
            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected23, actual2);
            Assert.AreEqual(expected23, actual3);
        }
    }
}
