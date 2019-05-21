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
using MongoDB.Driver;
using MongoDB.Bson;

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

            // de pus in callback la butonul de alegere echipament

            string category = "";   // get data from user interface

            string userTypeString = "";

            if (userType == UserType.FitnessUser)
            {
                userTypeString = "Fitness";
            }
            else if (userType == UserType.ZumbaUser)
            {
                userTypeString = "Zumba";
            }
            else if (userType == UserType.AerobicUser)
            {
                userTypeString = "Aerobic";
            }
            else
            {
                throw new Exception("Tipul utilizatorului este invalid");
            }

            List<string> productList = GetDataFromDB(userTypeString, category);

            SetDataToUI(productList);

            // ...
        }

        #endregion

        #region Private Methods

        /// <function>GetDataFromDB</function>
        /// <param name="userType">The type of the user</param>
        /// <param name="productType">The type of product</param>
        /// <return>A list of the results</return>
        /// <summary>Get the data from the MongoDB</summary>
        private List<string> GetDataFromDB(string userType, string productType)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("Proiect");
            var col = db.GetCollection<BsonDocument>("Produs");

            var filter = Builders<BsonDocument>.Filter.Eq("Categorie", userType);
            filter &= (Builders<BsonDocument>.Filter.Eq("Tip_Produs", productType));

            var projectionDefinition = Builders<BsonDocument>.Projection.Include("Nume_Produs").Exclude("_id");

            var document = col.Find(filter).Project(projectionDefinition).ToList();

            List<string> listaNoua = new List<string>();

            document.ForEach(doc =>
            {
                var val = doc.GetElement("Nume_Produs").Value.ToString();
                listaNoua.Add(val);
            });

            return listaNoua;
        }

        /// <function>GetDataFromDB</function>
        /// <param name="productsList">The list of the products</param>
        /// <summary>Display data on interface</summary>
        private void SetDataToUI(List<string> productsList)
        {
            // put data on interface
        }

        /// <function>CreateTraining</function>
        /// <summary>Create a training program</summary>
        private void CreateTraining()
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

        }

        /// <function>SaveTraining</function>
        /// <summary>Save the training program to file</summary>
        private void SaveTraining()
        {
            // print training program
            _activeUser.PrintTraining();
        }

        #endregion
    }
}
