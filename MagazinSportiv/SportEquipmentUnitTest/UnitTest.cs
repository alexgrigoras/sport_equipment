/// <copyright file="UnitTest.cs" >
/// Copyright (c) MagazinSportiv. All Right Reserved
/// </copyright>
/// <author>
/// Bodnariu Andreea, Grigoras Alexandru, Luncanu Iuliana, Suflet Ioan
/// </author>
/// <summary>
/// UnitTest class used for testing the application
/// </summary>

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportEquipment
{
    [TestClass]
    public class UnitTest
    {
        /// <function>Test_ValidateLogin_CorrectLogin</function>
        /// <summary>Tests if the login data is correct</summary>
        [TestMethod]
        public void Test_ValidateLogin_CorrectLogin()
        {
            var loginForm = new LoginForm();
            var expectedResult = UserType.FitnessUser;
            string username = "alex";
            string password = "alex";

            var privateObject = new PrivateObject(loginForm);

            var realResult = privateObject.Invoke("ValidateLogin", new object[] { username, password });

            Assert.AreEqual(realResult, expectedResult);
        }

        /// <function>Test_ValidateLogin_IncorrectLogin</function>
        /// <summary>Tests if the login data is incorrect</summary>
        [TestMethod]
        public void Test_ValidateLogin_IncorrectLogin()
        {
            var loginForm = new LoginForm();
            var expectedResult = UserType.FitnessUser;
            string username = "alex";
            string password = "1324";

            var privateObject = new PrivateObject(loginForm);

            var realResult = privateObject.Invoke("ValidateLogin", new object[] { username, password });

            Assert.AreEqual(realResult, expectedResult);
        }

        /// <function>Test_ValidateLogin_WrongPassword</function>
        /// <summary>Tests if the password is wrong</summary>
        [TestMethod]
        public void Test_ValidateLogin_WrongPassword()
        {
            var loginForm = new LoginForm();
            var expectedResult = UserType.InvalidUser;
            string username = "alex";
            string password = "1324";

            var privateObject = new PrivateObject(loginForm);

            var realResult = privateObject.Invoke("ValidateLogin", new object[] { username, password });

            Assert.AreEqual(realResult, expectedResult);
        }

        /// <function>Test_ValidateLogin_WrongUsername</function>
        /// <summary>Tests if the username is wrong</summary>
        [TestMethod]
        public void Test_ValidateLogin_WrongUsername()
        {
            var loginForm = new LoginForm();
            var expectedResult = UserType.InvalidUser;
            string username = "gigel";
            string password = "alex";

            var privateObject = new PrivateObject(loginForm);

            var realResult = privateObject.Invoke("ValidateLogin", new object[] { username, password });

            Assert.AreEqual(realResult, expectedResult);
        }

        /// <function>Test_GetDataFromDB_CorrectFitnessEquipment</function>
        /// <summary>Tests if the returned collection is valid</summary>
        [TestMethod]
        public void Test_GetDataFromDB_CorrectFitnessEquipment()
        {
            var userType = UserType.FitnessUser;
            string userTypeString = "Fitness";
            string category = "Equipment";
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            var privateObject = new PrivateObject(mainForm);

            var realProductListEquipment = privateObject.Invoke("GetDataFromDB", new object[] { userTypeString, category });

            List<string> expectedProductListEquipment = new List<string>();

            expectedProductListEquipment.Add("Greutati 5kg");
            expectedProductListEquipment.Add("Prosop");

            CollectionAssert.AreEqual(expectedProductListEquipment, (List<string>)realProductListEquipment);
        }

        /// <function>Test_GetDataFromDB_IncorrectOrderFitnessEquipment</function>
        /// <summary>Tests if the returned collection has valid order for items</summary>
        [TestMethod]
        public void Test_GetDataFromDB_IncorrectOrderFitnessEquipment()
        {
            var userType = UserType.FitnessUser;
            string userTypeString = "Fitness";
            string category = "Equipment";
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            var privateObject = new PrivateObject(mainForm);

            var realProductListEquipment = privateObject.Invoke("GetDataFromDB", new object[] { userTypeString, category });

            List<string> expectedProductListEquipment = new List<string>();

            expectedProductListEquipment.Add("Prosop");
            expectedProductListEquipment.Add("Greutati 5kg");

            CollectionAssert.AreEqual(expectedProductListEquipment, (List<string>)realProductListEquipment);
        }

        /// <function>Test_GetDataFromDB_IncorrectFitnessEquipment</function>
        /// <summary>Tests if the returned collection is invalid</summary>
        [TestMethod]
        public void Test_GetDataFromDB_IncorrectFitnessEquipment()
        {
            var userType = UserType.FitnessUser;
            string userTypeString = "Fitness";
            string category = "Equipment";
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            var privateObject = new PrivateObject(mainForm);

            var realProductListEquipment = privateObject.Invoke("GetDataFromDB", new object[] { userTypeString, category });

            List<string> expectedProductListEquipment = new List<string>();

            expectedProductListEquipment.Add("Abcd");
            expectedProductListEquipment.Add("Efgh");

            CollectionAssert.AreEqual(expectedProductListEquipment, (List<string>)realProductListEquipment);
        }

        /// <function>Test_GetDataFromDB_IncorrectUserType</function>
        /// <summary>Tests if the user type is wrong it displays correct collection</summary>
        [TestMethod]
        public void Test_GetDataFromDB_IncorrectUserType()
        {
            var userType = UserType.FitnessUser;
            string userTypeString = "ABCD";
            string category = "Equipment";
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            var privateObject = new PrivateObject(mainForm);

            var realProductListEquipment = privateObject.Invoke("GetDataFromDB", new object[] { userTypeString, category });

            List<string> expectedProductListEquipment = new List<string>();

            expectedProductListEquipment.Add("Prosop");
            expectedProductListEquipment.Add("Greutati 5kg");

            CollectionAssert.AreEqual(expectedProductListEquipment, (List<string>)realProductListEquipment);
        }

        /// <function>Test_GetDataFromDB_CorrectWrongUserType</function>
        /// <summary>Tests if the user type is wrong it displays empty collection</summary>
        [TestMethod]
        public void Test_GetDataFromDB_CorrectWrongUserType()
        {
            var userType = UserType.FitnessUser;
            string userTypeString = "ABCD";
            string category = "Equipment";
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            var privateObject = new PrivateObject(mainForm);

            var realProductListEquipment = privateObject.Invoke("GetDataFromDB", new object[] { userTypeString, category });

            List<string> expectedProductListEquipment = new List<string>();

            CollectionAssert.AreEqual(expectedProductListEquipment, (List<string>)realProductListEquipment);
        }

        /// <function>Test_GetDataFromDB_IncorrectCategory</function>
        /// <summary>Tests if the category is wrong it displays correct collection</summary>
        [TestMethod]
        public void Test_GetDataFromDB_IncorrectCategory()
        {
            var userType = UserType.FitnessUser;
            string userTypeString = "Fitness";
            string category = "ABCD";
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            var privateObject = new PrivateObject(mainForm);

            var realProductListEquipment = privateObject.Invoke("GetDataFromDB", new object[] { userTypeString, category });

            List<string> expectedProductListEquipment = new List<string>();

            expectedProductListEquipment.Add("Prosop");
            expectedProductListEquipment.Add("Greutati 5kg");

            CollectionAssert.AreEqual(expectedProductListEquipment, (List<string>)realProductListEquipment);
        }

        /// <function>Test_GetDataFromDB_CorrectWrongUserType</function>
        /// <summary>Tests if the user type is wrong it displays empty collection</summary>
        [TestMethod]
        public void Test_GetDataFromDB_CorrectWrongCategory()
        {
            var userType = UserType.FitnessUser;
            string userTypeString = "Fitness";
            string category = "ABCD";
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            var privateObject = new PrivateObject(mainForm);

            var realProductListEquipment = privateObject.Invoke("GetDataFromDB", new object[] { userTypeString, category });

            List<string> expectedProductListEquipment = new List<string>();

            CollectionAssert.AreEqual(expectedProductListEquipment, (List<string>)realProductListEquipment);
        }
    }
}
