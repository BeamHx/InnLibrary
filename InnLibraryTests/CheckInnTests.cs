using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InnLibrary;

namespace InnLibraryTests
{
    [TestClass]
    public class CheckInnTests
    {
        //return - true
        [DataTestMethod]
        [DataRow("500100732259")]
        [DataRow("825002039663")]
        [DataRow("663555067806")]
        [DataRow("128808228380")]
        [DataRow("454510869905")]
        [DataRow("112107486650")]
        [DataRow("996581708551")]


        [TestMethod]
        public void AllTestsTrue(string INNCode)
        {
            bool actual = CheckInn.CorrectFillINN(INNCode);
            Assert.IsTrue(actual);
        }

        //return - falsee
        [DataTestMethod]
        [DataRow("500100232259")]
        [DataRow("510100232259")]
        [DataRow("580100232259")]
        [DataRow("520100232254")]
        [DataRow("500232259")]
        [DataRow("")]
        [DataRow("   ")]



        [TestMethod]
        public void AllTestsFalse(string INNCode)
        {
            bool actual = CheckInn.CorrectFillINN(INNCode);
            Assert.IsFalse(actual);
        }
    }
}
