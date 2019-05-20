/// <copyright file="LoginForm.cs" >
/// Copyright (c) MagazinSportiv. All Right Reserved
/// </copyright>
/// <author>
/// Bodnariu Andreea, Grigoras Alexandru, Luncanu Iuliana, Suflet Ioan
/// </author>
/// <summary>
/// LoginForm class that is called when the application is executed; it allows the user to enter user name and password to login in the application
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
    public partial class LoginForm : Form
    {
        #region Default Constructor 

        /// <function>LoginForm</function>
        /// <arguments></arguments>
        /// <summary>Default Costructor</summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Login Form Events 

        /// <function>ButtonLogin_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Login check for the created user</summary>
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            UserType user;
            MainForm frm = null;

            user = ValidateLogin(username, password);

            if(user == UserType.InvalidUser)
            {
                frm = new MainForm(user);
                frm.Show();
                this.Hide();
            }
            else
            {
                // meesage box eroare utilizator
            }
        }

        /// <function>ButtonCreateUser_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Create a new user if it doesn't exists</summary>
        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Private Methods

        /// <function>ValidateLogin</function>
        /// <param name="username">The username of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Returns the user type</returns>
        /// <summary>Create a new user if it doesn't exists</summary>
        private UserType ValidateLogin(string username, string password)
        {
            UserType userType = UserType.InvalidUser;

            // mongodb access for credentials validation


            // return the selected user
            return userType;
        }

        #endregion
    }

    /// <enum>UserType</enum>
    /// <summary>The user type</summary>
    public enum UserType
    {
        FitnessUser,
        ZumbaUser,
        AerobicUser,
        InvalidUser
    }
}
