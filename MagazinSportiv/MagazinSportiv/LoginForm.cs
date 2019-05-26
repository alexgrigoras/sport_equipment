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
            string username = usernameBox_login.Text;
            string password = passwordBox_login.Text;
            UserType user;
            MainForm frm;

            SideBar.Text = "";

            user = ValidateLogin(username, password);

            if(user != UserType.InvalidUser)
            {
                frm = new MainForm(user, this);
                frm.Show();
                this.Hide();
            }
            else
            {
                errorLabel_login.Visible = true;
                SideBar.Text = "Wrong log in information, please try again.";
            }
        }

        /// <function>ButtonCreateUser_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Callback for create user button</summary>
        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            // get data from user interface
            string username = usernameBox_signup.Text;
            string password = passwordBox_signup.Text;
            string vpassword = vpasswordBox_signup.Text;

            if(password!=vpassword)
            {
                errorLabel_login.Visible = true;
                errorLabel_login.Text = "Passwords does not match";
            }
            else
            {
                errorLabel_login.Visible = false;
            }

            string type = activityTypecomboBox_signup.Text;
            
            CreateUserOnDB(username, password, type);

            //Hide sign up information
            backButton_signup.Visible = false;
            username_signup.Visible = false;
            usernameBox_signup.Visible = false;
            password_signup.Visible = false;
            passwordBox_signup.Visible = false;
            vpassword_signup.Visible = false;
            vpasswordBox_signup.Visible = false;
            activityType_signup.Visible = false;
            activityTypecomboBox_signup.Visible = false;
            buttonCreateUser.Visible = false;

            //Show log in information
            username_login.Visible = true;
            usernameBox_login.Visible = true;
            password_login.Visible = true;
            passwordBox_login.Visible = true;
            haveAccount_login.Visible = true;
            SignUpButton_login.Visible = true;
            buttonLogin.Visible = true;
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

            if (result == "FitnessUser")
            {
                userType = UserType.FitnessUser;
            }
            else if (result == "ZumbaUser")
            {
                userType = UserType.ZumbaUser;
            }
            else if (result == "AerobicUser")
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
            var db = client.GetDatabase("ProiectIP");
            var col = db.GetCollection<BsonDocument>("Utilizatori");

            var document = new BsonDocument{
                { "Nume_Utilizator", username },
                { "Parola", password },
                { "Tip_Utilizator", type }};

            col.InsertOne(document);
        }

        #endregion

        /// <function>SignUpButton_login_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Hides Login information and shows Sign up form</summary>
        private void SignUpButton_login_Click(object sender, EventArgs e)
        {
            //Hide log in information
            username_login.Visible = false;
            usernameBox_login.Visible = false;
            password_login.Visible = false;
            passwordBox_login.Visible = false;
            haveAccount_login.Visible = false;
            SignUpButton_login.Visible = false;
            buttonLogin.Visible = false;

            //Show sign up information
            backButton_signup.Visible = true;
            username_signup.Visible = true;
            usernameBox_signup.Visible = true;
            password_signup.Visible = true;
            passwordBox_signup.Visible = true;
            vpassword_signup.Visible = true;
            vpasswordBox_signup.Visible = true;
            activityType_signup.Visible = true;
            activityTypecomboBox_signup.Visible = true;
            buttonCreateUser.Visible = true;

            //Move error label
            errorLabel_login.Left = 52;
            errorLabel_login.Top = 710;
        }

        /// <function>LoginForm_Load</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Hides Sign up form when the windows is loaded</summary>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Hide sign up information
            errorLabel_login.Visible = false;
            backButton_signup.Visible = false;
            username_signup.Visible = false;
            usernameBox_signup.Visible = false;
            password_signup.Visible = false;
            passwordBox_signup.Visible = false;
            vpassword_signup.Visible = false;
            vpasswordBox_signup.Visible = false;
            activityType_signup.Visible = false;
            activityTypecomboBox_signup.Visible = false;
            buttonCreateUser.Visible = false;
        }

        /// <function>BackButton_signup_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Sends the user back to Login page</summary>
        private void BackButton_signup_Click(object sender, EventArgs e)
        {
            //Hide sign up information
            backButton_signup.Visible = false;
            username_signup.Visible = false;
            usernameBox_signup.Visible = false;
            password_signup.Visible = false;
            passwordBox_signup.Visible = false;
            vpassword_signup.Visible = false;
            vpasswordBox_signup.Visible = false;
            activityType_signup.Visible = false;
            activityTypecomboBox_signup.Visible = false;
            buttonCreateUser.Visible = false;

            //Show log in information
            username_login.Visible = true;
            usernameBox_login.Visible = true;
            password_login.Visible = true;
            passwordBox_login.Visible = true;
            haveAccount_login.Visible = true;
            SignUpButton_login.Visible = true;
            buttonLogin.Visible = true;

            //Move error label
            errorLabel_login.Left = 261;
            errorLabel_login.Top = 676;
        }

        /// <function>ExitForm_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Closes the window</summary>
        private void ExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <function>HelpButton_Click</function>
        /// <param name="sender"></param>
        /// <param name="EventArgs"></param>
        /// <summary>Opens Help Center</summary>
        private void HelpButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Gestionarea_activitatii_fitness.chm");
        }
        // This method will change the square button to a circular button by 
        // creating a new circle-shaped GraphicsPath object and setting it 
        // to the RoundButton objects region.
        private void ButtonLogin_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = buttonLogin.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            buttonLogin.Region = new System.Drawing.Region(buttonPath);

        }

        private void MainFormButton_Click(object sender, EventArgs e)
        {
            
        }
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
