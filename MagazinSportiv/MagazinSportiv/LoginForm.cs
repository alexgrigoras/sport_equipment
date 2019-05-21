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
using MongoDB.Driver;
using MongoDB.Bson;

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
        /// <param name="e"></param>
        /// <summary>Callback for login button</summary>
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            UserType user;
            MainForm frm;

            user = ValidateLogin(username, password);

            if(user != UserType.InvalidUser)
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
        /// <summary>Callback for create user button</summary>
        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            // get data from user interface
            string username = "";
            string password = "";
            string type = "";
            
            CreateUserOnDB(username, password, type);
        }

        #endregion

        #region Private Methods

        /// <function>ValidateLogin</function>
        /// <param name="username">The username of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Returns the user type</returns>
        /// <summary>Login check for the created user</summary>
        private UserType ValidateLogin(string username, string password)
        {
            UserType userType;

            // mongodb access for credentials validation
            string result = CheckDBForUser(username, password);

            if (result == "Fitness")
            {
                userType = UserType.FitnessUser;
            }
            else if (result == "Zumba")
            {
                userType = UserType.ZumbaUser;
            }
            else if (result == "Aerobic")
            {
                userType = UserType.AerobicUser;
            }
            else
            {
                userType = UserType.InvalidUser;
            }

            // return the selected user
            return userType;
        }

        /// <function>CheckDBForUser</function>
        /// <param name="username">The username of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Returns the user type</returns>
        /// <summary>Check if user exists in DB</summary>
        private string CheckDBForUser(string username, string password)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("ProiectIP");
            var col = db.GetCollection<BsonDocument>("Utilizatori");

            var filter = Builders<BsonDocument>.Filter.Eq("Nume_Utilizator", username);
            filter &= (Builders<BsonDocument>.Filter.Eq("Parola", password));

            var projectionDefinition = Builders<BsonDocument>.Projection.Include("Tip_Utilizator").Exclude("_id");

            var document = col.Find(filter).Project(projectionDefinition).FirstOrDefault();
            var value = document.GetElement("Tip_Utilizator").Value.ToString();

            return value;
        }

        /// <function>CheckDBForUser</function>
        /// <param name="username">The username of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>Returns the user type</returns>
        /// <summary>Check if user exists in DB</summary>
        static void CreateUserOnDB(string username, string password, string type)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("Proiect");
            var col = db.GetCollection<BsonDocument>("User");

            var document = new BsonDocument{
                { "Nume_Utilizator", username },
                { "Parola", password },
                { "Tip_Utilizator", type }};

            col.InsertOne(document);
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
