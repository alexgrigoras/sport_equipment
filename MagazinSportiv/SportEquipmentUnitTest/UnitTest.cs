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

        /// <function>Test_GetDataFromDB_CorrectWrongCategory</function>
        /// <summary>Tests if the category is wrong it displays empty collection</summary>
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

        /// <function>Test_FilePrinter_CorrectOpenFile</function>
        /// <summary>Tests if the file is opened successfully</summary>
        [TestMethod]
        public void Test_FilePrinter_CorrectOpenFile()
        {
            bool expectedResult = true;
            string fileName = "files/file.txt";
            LibPrinter.Printer p = new LibPrinter.Printer(fileName);

            bool realResult = p.OpenFile();

            Assert.AreEqual(realResult, expectedResult);
        }

        /// <function>Test_FilePrinter_IncorrecDirectoryOpenFile</function>
        /// <summary>Tests if the file directory is invalid</summary>
        [TestMethod]
        public void Test_FilePrinter_IncorrecDirectoryOpenFile()
        {
            bool expectedResult = true;
            string fileName = "docs/file.txt";
            LibPrinter.Printer p = new LibPrinter.Printer(fileName);

            bool realResult = p.OpenFile();

            Assert.AreEqual(realResult, expectedResult);
        }

        /// <function>Test_FilePrinter_IncorrectWriteWithoutOpenFile</function>
        /// <summary>Tests if it writes without file opened</summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_FilePrinter_ExceptionWriteWithoutOpenFile()
        {
            string fileName = "file/file.txt";
            LibPrinter.Printer p = new LibPrinter.Printer(fileName);

            p.Write("abc");
        }

        /// <function>Test_FilePrinter_IncorrectWritelnWithoutOpenFile</function>
        /// <summary>Tests if it writes without file opened</summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_FilePrinter_ExceptionWritelnWithoutOpenFile()
        {
            string fileName = "file/file.txt";
            LibPrinter.Printer p = new LibPrinter.Printer(fileName);

            p.Writeln("def");
        }

        /// <function>Test_FilePrinter_CorrectWriteOnFile</function>
        /// <summary>Tests if it writes on file</summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_FilePrinter_CorrectWriteOnFile()
        {
            string fileName = "file/file.txt";
            LibPrinter.Printer p = new LibPrinter.Printer(fileName);

            p.OpenFile();
            p.Write("abc");
        }

        /// <function>Test_FilePrinter_CorrectWritelnOnFile</function>
        /// <summary>Tests if it writes on file</summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_FilePrinter_CorrectWritelnOnFile()
        {
            string fileName = "file/file.txt";
            LibPrinter.Printer p = new LibPrinter.Printer(fileName);

            p.OpenFile();
            p.Writeln("def");
        }

        /// <function>Test_MainForm_ComboBoxSupliments</function>
        /// <summary>Tests if the interface displays correct information on supliments combo box</summary>
        [TestMethod]
        public void Test_MainForm_ComboBoxSupliments_OneValue()
        {
            var userType = UserType.FitnessUser;
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            mainForm.Show();

            var privateObject = new PrivateObject(mainForm);

            System.Windows.Forms.Button randomizeButton = (System.Windows.Forms.Button)privateObject.GetFieldOrProperty("randomizeButton");

            randomizeButton.PerformClick();

            System.Windows.Forms.ComboBox suplimentsComboBox = (System.Windows.Forms.ComboBox)privateObject.GetFieldOrProperty("suplimentsComboBox");

            string realText = suplimentsComboBox.Text;
            string expectedText = "Magneziu";

            Assert.AreEqual(expectedText, realText);
        }

        /// <function>Test_MainForm_ComboBoxEquipment</function>
        /// <summary>Tests if the interface displays correct information on equipment combo box</summary>
        [TestMethod]
        public void Test_MainForm_ComboBoxEquipment_MultipleValues()
        {
            var userType = UserType.FitnessUser;
            string userTypeString = "Fitness";
            string category = "Equipment";
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            mainForm.Show();

            var privateObject = new PrivateObject(mainForm);

            System.Windows.Forms.Button randomizeButton = (System.Windows.Forms.Button)privateObject.GetFieldOrProperty("randomizeButton");

            randomizeButton.PerformClick();

            System.Windows.Forms.ComboBox equipmentComboBox = (System.Windows.Forms.ComboBox)privateObject.GetFieldOrProperty("equipmentComboBox");

            List<string> realProductListEquipment = (List<string>)privateObject.Invoke("GetDataFromDB", new object[] { userTypeString, category });

            string realText = equipmentComboBox.Text;

            CollectionAssert.Contains(realProductListEquipment, realText);
        }

        /// <function>Test_MainForm_ComboBoxGear</function>
        /// <summary>Tests if the interface displays correct information on gear combo box</summary>
        [TestMethod]
        public void Test_MainForm_ComboBoxGear()
        {
            var userType = UserType.FitnessUser;
            string userTypeString = "Fitness";
            string category = "Clothes";
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            mainForm.Show();

            var privateObject = new PrivateObject(mainForm);

            System.Windows.Forms.Button randomizeButton = (System.Windows.Forms.Button)privateObject.GetFieldOrProperty("randomizeButton");

            randomizeButton.PerformClick();

            System.Windows.Forms.ComboBox gearComboBox = (System.Windows.Forms.ComboBox)privateObject.GetFieldOrProperty("gearComboBox");

            List<string> realProductListGear = (List<string>)privateObject.Invoke("GetDataFromDB", new object[] { userTypeString, category });

            string realText = gearComboBox.Text;

            CollectionAssert.Contains(realProductListGear, realText);
        }

        /// <function>Test_MainForm_ComboBoxGear</function>
        /// <summary>Tests if the interface displays correct information on trainer combo box</summary>
        [TestMethod]
        public void Test_MainForm_ComboBoxTrainer()
        {
            var userType = UserType.FitnessUser;
            string userTypeString = "Fitness";
            string category = "Trainer";
            string username = "alex";
            var loginForm = new LoginForm();
            var mainForm = new MainForm(userType, username, loginForm);

            mainForm.Show();

            var privateObject = new PrivateObject(mainForm);

            System.Windows.Forms.Button randomizeButton = (System.Windows.Forms.Button)privateObject.GetFieldOrProperty("randomizeButton");

            randomizeButton.PerformClick();

            System.Windows.Forms.ComboBox trainerComboBox = (System.Windows.Forms.ComboBox)privateObject.GetFieldOrProperty("trainerComboBox");

            List<string> realProductListTrainer = (List<string>)privateObject.Invoke("GetDataFromDB", new object[] { userTypeString, category });

            string realText = trainerComboBox.Text;

            CollectionAssert.Contains(realProductListTrainer, realText);
        }
    }
}
