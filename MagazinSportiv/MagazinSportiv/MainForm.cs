/// <copyright file="MainForm.cs" >
/// Copyright (c) MagazinSportiv. All Right Reserved
/// </copyright>
/// <author>
/// Bodnariu Andreea, Grigoras Alexandru, Luncanu Iuliana, Suflet Ioan
/// </author>
/// <summary>
/// MainForm Class executed when the user successfully enters login credentials; has all the main logic of the application.
/// </summary>

#region using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace SportEquipment
{
    public partial class MainForm : Form
    {
        #region Private Fields

        private UserType _userType;
        private UserFactory _userFactory;
        private User _activeUser;

        #endregion

        #region Constructor 

        /// <function>Login</function>
        /// <param name="userType">The type of the user</param>
        /// <summary>Costructor of the class</summary>
        public MainForm(UserType userType)
        {
            InitializeComponent();

            _userType = userType;

            _userFactory = new UserFactory();

            _activeUser = _userFactory.CreateUser(_userType);

            GetDataFromDB();
        }

        #endregion

        #region Private Methods

        private void GetDataFromDB()
        {
            // get data

            // put data to interface
        }

        private void createTraining()
        {
            // parameters for the training program
            string trainer = "";
            string food = "";
            string clothes = "";
            string equipment = "";

            // get the values from text boxes


            // create training program 
             _activeUser.SelectTrainer(trainer);
             _activeUser.SelectFood(food);
             _activeUser.SelectClothes(clothes);
             _activeUser.SelectEquipment(equipment);

            // display training program

            // print training program
            _activeUser.PrintTraining();
        }

        #endregion
    }
}
