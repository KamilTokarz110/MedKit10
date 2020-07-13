using System;
using MedKit10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MedKit10Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_Con_True()
        {

            //Arrange
            bool expected = true;
            ShareSqlCom sqlCo = new ShareSqlCom();

            //Act

            bool actual = sqlCo.IfMedExists(1);

            //Assert

            Assert.AreEqual(expected, actual, "Zwraca fałsz ");
        }
        [TestMethod]
        public void Get_Con_False()
        {

            //Arrange
            bool expected = false;
            ShareSqlCom sqlCo = new ShareSqlCom();

            //Act

            bool actual = sqlCo.IfMedExists(-1);

            //Assert

            Assert.AreEqual(expected, actual, "Zwraca Prawdę ");

        }
    }
}
