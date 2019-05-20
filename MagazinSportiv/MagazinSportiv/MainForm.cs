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
        }

        #endregion

        #region Private Methods

        private void createTraining()
        {
            User _activeUser = _userFactory.CreateUser(_userType);

            // parameters for the training program
            string trainer = "";
            string food = "";
            string clothes = "";
            string equipment = "";

            // get the values from text boxes


            // create training program 
             _activeUser.selectTrainer(trainer);
             _activeUser.selectFood(food);
             _activeUser.selectClothes(clothes);
             _activeUser.selectEquipment(equipment);

            // display training program

        }

        #endregion
    }
}
