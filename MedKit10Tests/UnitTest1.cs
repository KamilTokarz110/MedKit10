using System;
using System.Data.SqlClient;
using MedKit10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MedKit10Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void If_Med_Ex()
        {

            //Arrange
            bool expected = false;
            // ShareSqlCom sqlCo = new ShareSqlCom();
            SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-BQITBQR\\SQLEXPRESS;Initial Catalog=MedkitDB;Integrated Security=True");
            Medicaments med2 = new Medicaments();


            //Act


            bool actual = med2.IfMedExists(con2,"2");

            //Assert

            Assert.AreEqual(expected, actual, "Zwraca prawde");
        }
       
        
            [TestMethod]
            public void If_Med_Ex_2()
            {

                //Arrange
                bool expected = true;
                // ShareSqlCom sqlCo = new ShareSqlCom();
                SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-BQITBQR\\SQLEXPRESS;Initial Catalog=MedkitDB;Integrated Security=True");
                Medicaments med2 = new Medicaments();


                //Act


                bool actual = med2.IfMedExists(con2, "1");

                //Assert

                Assert.AreEqual(expected, actual, "Zwraca false");
            }



            [TestMethod]
        public void Validation_Test()
        {
            //Arrange
            bool expected = false;
            Medicaments med = new Medicaments();

            //Act

            bool actual = med.Validation();

            //Assert

            Assert.AreEqual(expected, actual, "Zwraca Prawdę");
        }
        [TestMethod]
        public void Validation_Test_2()
        {
            //Arrange
            bool expected = true;
            Medicaments med = new Medicaments();

            //Act

            bool actual = med.Validation();

            //Assert

            Assert.AreEqual(expected, actual, "Zwraca Fałsz");
        }


    }


}
