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
        private int progress1, progress2, progress3, progress4;
        private Form _login;

        #endregion
        public MainForm()
        {
            InitializeComponent();
        }
        #region Constructor 

        /// <function>Login</function>
        /// <param name="userType">The type of the user</param>
        /// <summary>Costructor of the class</summary>
        public MainForm(UserType userType, Form login)
        {
            InitializeComponent();

            _userType = userType;

            _userFactory = new UserFactory();

            _activeUser = _userFactory.CreateUser(_userType);

            _login = login;

            // add data to comboboxes

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

            List<string> productListEquipment = GetDataFromDB(userTypeString, "Equipment");
            List<string> productListFood = GetDataFromDB(userTypeString, "Food");
            List<string> productListClothes = GetDataFromDB(userTypeString, "Clothes");
            List<string> productListTrainer = GetDataFromDB(userTypeString, "Trainer");

            SetDataToUI(productListEquipment, productListFood, productListClothes, productListTrainer);
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
            var db = client.GetDatabase("ProiectIP");
            var col = db.GetCollection<BsonDocument>("Produse");

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
        private void SetDataToUI(List<string> Equipment, List<string> Food, List<string> Clothes, List<string> Trainer)
        {
            // put data on interface
            foreach(string s in Equipment)
            {
                equipmentComboBox.Items.Add(s);
            }
            // put data on interface
            foreach (string s in Food)
            {
                suplimentsComboBox.Items.Add(s);
            }
            // put data on interface
            foreach (string s in Clothes)
            {
                gearComboBox.Items.Add(s);
            }
            // put data on interface
            foreach (string s in Trainer)
            {
                trainerComboBox.Items.Add(s);
            }
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

            //string equipment = equipmentComboBox.Items[equipmentComboBox.SelectedIndex].ToString();

            // get the values from text boxes
            trainer = trainerComboBox.Text;
            food = suplimentsComboBox.Text;
            clothes = gearComboBox.Text;
            equipment = equipmentComboBox.Text;

            // create training program
            _activeUser.SelectTrainer(trainer);
            _activeUser.SelectFood(food);
            _activeUser.SelectClothes(clothes);
            _activeUser.SelectEquipment(equipment);

            // display training program
            MessageBox.Show("Selected training: " +
                trainer + " - " + food + " - " + clothes + " - " + equipment);
        }

        /// <function>SaveTraining</function>
        /// <summary>Save the training program to file</summary>
        private void SaveTraining()
        {
            // print training program
            try
            {
                _activeUser.PrintTraining();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        /// <function>ExitFormButton_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Exits the forme</summary>
        private void ExitFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(1);
        }

        /// <function>ExportButton_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Exits the forme</summary>
        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveTraining();
        }

        /// <function>HelpButton_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Exits the forme</summary>
        private void HelpButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Gestionarea_activitatii_fitness.chm");
        }

        /// <function>RandomizeButton_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Randomizes items in comboBoxes</summary>
        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int newIndex = -1;

            do
            {
                newIndex = random.Next(equipmentComboBox.Items.Count);
            } while (newIndex == equipmentComboBox.SelectedIndex && equipmentComboBox.Items.Count > 1);

            try
            {
                equipmentComboBox.SelectedIndex = random.Next(equipmentComboBox.Items.Count);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Randomize incomplete, no data found on equipment");
            }

            newIndex = -1;

            do
            {
                newIndex = random.Next(suplimentsComboBox.Items.Count);
            } while (newIndex == suplimentsComboBox.SelectedIndex && suplimentsComboBox.Items.Count > 1);

            try { 
            suplimentsComboBox.SelectedIndex = random.Next(suplimentsComboBox.Items.Count);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Randomize incomplete, no data found on suppliments");
            }

            newIndex = -1;

            do
            {
                newIndex = random.Next(gearComboBox.Items.Count);
            } while (newIndex == gearComboBox.SelectedIndex && gearComboBox.Items.Count > 1);

            try { 
                gearComboBox.SelectedIndex = random.Next(gearComboBox.Items.Count);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Randomize incomplete, no data found on gear");
            }

            newIndex = -1;

            do
            {
                newIndex = random.Next(trainerComboBox.Items.Count);
            } while (newIndex == trainerComboBox.SelectedIndex && trainerComboBox.Items.Count > 1);

            try
            {
                trainerComboBox.SelectedIndex = random.Next(trainerComboBox.Items.Count);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Randomize incomplete, no data found on trainer");
            }
        }

        /// <function>logoutButton_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Logs out to login screen</summary>
        private void logoutButton_Click(object sender, EventArgs e)
        {
            _login.Show();
            this.Close();
        }

        /// <function>ReadyButton_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>reates the training based on selected options</summary>
        private void ReadyButton_Click(object sender, EventArgs e)
        {
            CreateTraining();
            exportButton.Enabled = true;
        }

        /// <function>MainForm_Load</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Updates circular progress bar</summary>
        private void MainForm_Load(object sender, EventArgs e)
        {         
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 10 secs
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        /// <function>Timer_Tick</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Every second</summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(trainerComboBox.SelectedIndex==-1)
            {
                progress1=0;
            }
            else
            {
                progress1 = 25;
            }
            if (gearComboBox.SelectedIndex==-1)
            {
                progress2=0;
            }
            else
            {
                progress2=25;
            }
            if (suplimentsComboBox.SelectedIndex==-1)
            {
                progress3=0;
            }
            else
            {
                progress3=25;
            }
            if (equipmentComboBox.SelectedIndex==-1)
            {
                progress4=0;
            }
            else
            {
                progress4=25;
            }
           // progressLabel.Text = equipmentComboBox.SelectedIndex.ToString();
            progressLabel.Text = (progress1+progress2+progress3+progress4).ToString();
            circularProgressBar.Value = (progress1 + progress2 + progress3 + progress4);
        }
    }
}
