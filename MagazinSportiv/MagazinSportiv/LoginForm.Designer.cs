namespace SportEquipment
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.usernameBox_login = new System.Windows.Forms.TextBox();
            this.passwordBox_login = new System.Windows.Forms.TextBox();
            this.username_login = new System.Windows.Forms.Label();
            this.password_login = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.activityTypecomboBox_signup = new System.Windows.Forms.ComboBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.backButton_signup = new System.Windows.Forms.Button();
            this.errorLabel_login = new System.Windows.Forms.Label();
            this.vpasswordBox_signup = new System.Windows.Forms.TextBox();
            this.vpassword_signup = new System.Windows.Forms.Label();
            this.activityType_signup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SignUpButton_login = new System.Windows.Forms.Button();
            this.haveAccount_login = new System.Windows.Forms.Label();
            this.password_signup = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordBox_signup = new System.Windows.Forms.TextBox();
            this.usernameBox_signup = new System.Windows.Forms.TextBox();
            this.username_signup = new System.Windows.Forms.Label();
            this.GymHive = new System.Windows.Forms.Label();
            this.exitForm = new System.Windows.Forms.Button();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(265, 268);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(82, 31);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonCreateUser.FlatAppearance.BorderSize = 0;
            this.buttonCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateUser.ForeColor = System.Drawing.Color.White;
            this.buttonCreateUser.Location = new System.Drawing.Point(265, 366);
            this.buttonCreateUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(82, 31);
            this.buttonCreateUser.TabIndex = 1;
            this.buttonCreateUser.Text = "sign up\r\n";
            this.buttonCreateUser.UseVisualStyleBackColor = false;
            this.buttonCreateUser.Click += new System.EventHandler(this.ButtonCreateUser_Click);
            // 
            // usernameBox_login
            // 
            this.usernameBox_login.BackColor = System.Drawing.Color.White;
            this.usernameBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox_login.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox_login.ForeColor = System.Drawing.Color.DarkOrange;
            this.usernameBox_login.Location = new System.Drawing.Point(27, 163);
            this.usernameBox_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameBox_login.Name = "usernameBox_login";
            this.usernameBox_login.Size = new System.Drawing.Size(320, 40);
            this.usernameBox_login.TabIndex = 6;
            // 
            // passwordBox_login
            // 
            this.passwordBox_login.BackColor = System.Drawing.Color.White;
            this.passwordBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox_login.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox_login.ForeColor = System.Drawing.Color.DarkOrange;
            this.passwordBox_login.Location = new System.Drawing.Point(27, 219);
            this.passwordBox_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox_login.Name = "passwordBox_login";
            this.passwordBox_login.Size = new System.Drawing.Size(320, 40);
            this.passwordBox_login.TabIndex = 7;
            // 
            // username_login
            // 
            this.username_login.AutoSize = true;
            this.username_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username_login.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_login.ForeColor = System.Drawing.Color.Gray;
            this.username_login.Location = new System.Drawing.Point(28, 148);
            this.username_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_login.Name = "username_login";
            this.username_login.Size = new System.Drawing.Size(54, 13);
            this.username_login.TabIndex = 8;
            this.username_login.Text = "username";
            // 
            // password_login
            // 
            this.password_login.AutoSize = true;
            this.password_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_login.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_login.ForeColor = System.Drawing.Color.Gray;
            this.password_login.Location = new System.Drawing.Point(28, 204);
            this.password_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_login.Name = "password_login";
            this.password_login.Size = new System.Drawing.Size(53, 13);
            this.password_login.TabIndex = 9;
            this.password_login.Text = "password";
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.White;
            this.SideBar.Controls.Add(this.activityTypecomboBox_signup);
            this.SideBar.Controls.Add(this.helpButton);
            this.SideBar.Controls.Add(this.backButton_signup);
            this.SideBar.Controls.Add(this.errorLabel_login);
            this.SideBar.Controls.Add(this.vpasswordBox_signup);
            this.SideBar.Controls.Add(this.vpassword_signup);
            this.SideBar.Controls.Add(this.buttonCreateUser);
            this.SideBar.Controls.Add(this.activityType_signup);
            this.SideBar.Controls.Add(this.label1);
            this.SideBar.Controls.Add(this.label8);
            this.SideBar.Controls.Add(this.SignUpButton_login);
            this.SideBar.Controls.Add(this.haveAccount_login);
            this.SideBar.Controls.Add(this.password_signup);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.SideBar.Controls.Add(this.password_login);
            this.SideBar.Controls.Add(this.passwordBox_signup);
            this.SideBar.Controls.Add(this.passwordBox_login);
            this.SideBar.Controls.Add(this.usernameBox_signup);
            this.SideBar.Controls.Add(this.username_login);
            this.SideBar.Controls.Add(this.username_signup);
            this.SideBar.Controls.Add(this.usernameBox_login);
            this.SideBar.Controls.Add(this.buttonLogin);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(382, 490);
            this.SideBar.TabIndex = 15;
            // 
            // activityTypecomboBox_signup
            // 
            this.activityTypecomboBox_signup.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityTypecomboBox_signup.FormattingEnabled = true;
            this.activityTypecomboBox_signup.Items.AddRange(new object[] {
            "Fitness",
            "Zumba",
            "Aerobic"});
            this.activityTypecomboBox_signup.Location = new System.Drawing.Point(27, 320);
            this.activityTypecomboBox_signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activityTypecomboBox_signup.Name = "activityTypecomboBox_signup";
            this.activityTypecomboBox_signup.Size = new System.Drawing.Size(321, 37);
            this.activityTypecomboBox_signup.TabIndex = 23;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.helpButton.Location = new System.Drawing.Point(23, 430);
            this.helpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(91, 20);
            this.helpButton.TabIndex = 18;
            this.helpButton.Text = "need help?";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // backButton_signup
            // 
            this.backButton_signup.FlatAppearance.BorderSize = 0;
            this.backButton_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton_signup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton_signup.ForeColor = System.Drawing.Color.DarkOrange;
            this.backButton_signup.Location = new System.Drawing.Point(27, 109);
            this.backButton_signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton_signup.Name = "backButton_signup";
            this.backButton_signup.Size = new System.Drawing.Size(66, 27);
            this.backButton_signup.TabIndex = 22;
            this.backButton_signup.Text = "< back";
            this.backButton_signup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton_signup.UseVisualStyleBackColor = true;
            this.backButton_signup.Click += new System.EventHandler(this.BackButton_signup_Click);
            // 
            // errorLabel_login
            // 
            this.errorLabel_login.AutoSize = true;
            this.errorLabel_login.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorLabel_login.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel_login.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabel_login.Location = new System.Drawing.Point(28, 385);
            this.errorLabel_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel_login.Name = "errorLabel_login";
            this.errorLabel_login.Size = new System.Drawing.Size(90, 13);
            this.errorLabel_login.TabIndex = 15;
            this.errorLabel_login.Text = "Invalid Username";
            this.errorLabel_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vpasswordBox_signup
            // 
            this.vpasswordBox_signup.BackColor = System.Drawing.Color.White;
            this.vpasswordBox_signup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vpasswordBox_signup.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpasswordBox_signup.Location = new System.Drawing.Point(27, 264);
            this.vpasswordBox_signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vpasswordBox_signup.Name = "vpasswordBox_signup";
            this.vpasswordBox_signup.Size = new System.Drawing.Size(320, 36);
            this.vpasswordBox_signup.TabIndex = 18;
            // 
            // vpassword_signup
            // 
            this.vpassword_signup.AutoSize = true;
            this.vpassword_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vpassword_signup.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpassword_signup.ForeColor = System.Drawing.Color.Gray;
            this.vpassword_signup.Location = new System.Drawing.Point(28, 250);
            this.vpassword_signup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vpassword_signup.Name = "vpassword_signup";
            this.vpassword_signup.Size = new System.Drawing.Size(84, 13);
            this.vpassword_signup.TabIndex = 20;
            this.vpassword_signup.Text = "verify password";
            // 
            // activityType_signup
            // 
            this.activityType_signup.AutoSize = true;
            this.activityType_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activityType_signup.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityType_signup.ForeColor = System.Drawing.Color.Gray;
            this.activityType_signup.Location = new System.Drawing.Point(28, 305);
            this.activityType_signup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activityType_signup.Name = "activityType_signup";
            this.activityType_signup.Size = new System.Drawing.Size(67, 13);
            this.activityType_signup.TabIndex = 21;
            this.activityType_signup.Text = "activity type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(26, 453);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "Disclaimer: This app is for educational purpose only. Therefore, we do not own an" +
    "y copyrights.\r\nWe reserve the rights to make any changes.\r\n ";
            // 
            // SignUpButton_login
            // 
            this.SignUpButton_login.FlatAppearance.BorderSize = 0;
            this.SignUpButton_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SignUpButton_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SignUpButton_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton_login.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton_login.ForeColor = System.Drawing.Color.DarkOrange;
            this.SignUpButton_login.Location = new System.Drawing.Point(139, 276);
            this.SignUpButton_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignUpButton_login.Name = "SignUpButton_login";
            this.SignUpButton_login.Size = new System.Drawing.Size(87, 25);
            this.SignUpButton_login.TabIndex = 12;
            this.SignUpButton_login.Text = "Sign up";
            this.SignUpButton_login.UseVisualStyleBackColor = true;
            this.SignUpButton_login.Click += new System.EventHandler(this.SignUpButton_login_Click);
            // 
            // haveAccount_login
            // 
            this.haveAccount_login.AutoSize = true;
            this.haveAccount_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.haveAccount_login.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveAccount_login.ForeColor = System.Drawing.Color.Gray;
            this.haveAccount_login.Location = new System.Drawing.Point(28, 283);
            this.haveAccount_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.haveAccount_login.Name = "haveAccount_login";
            this.haveAccount_login.Size = new System.Drawing.Size(120, 13);
            this.haveAccount_login.TabIndex = 11;
            this.haveAccount_login.Text = "Don\'t have an account?";
            // 
            // password_signup
            // 
            this.password_signup.AutoSize = true;
            this.password_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_signup.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_signup.ForeColor = System.Drawing.Color.Gray;
            this.password_signup.Location = new System.Drawing.Point(28, 193);
            this.password_signup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_signup.Name = "password_signup";
            this.password_signup.Size = new System.Drawing.Size(53, 13);
            this.password_signup.TabIndex = 17;
            this.password_signup.Text = "password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 36);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // passwordBox_signup
            // 
            this.passwordBox_signup.BackColor = System.Drawing.Color.White;
            this.passwordBox_signup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox_signup.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox_signup.Location = new System.Drawing.Point(27, 208);
            this.passwordBox_signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox_signup.Name = "passwordBox_signup";
            this.passwordBox_signup.Size = new System.Drawing.Size(320, 36);
            this.passwordBox_signup.TabIndex = 15;
            // 
            // usernameBox_signup
            // 
            this.usernameBox_signup.BackColor = System.Drawing.Color.White;
            this.usernameBox_signup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox_signup.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox_signup.Location = new System.Drawing.Point(27, 152);
            this.usernameBox_signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameBox_signup.Name = "usernameBox_signup";
            this.usernameBox_signup.Size = new System.Drawing.Size(320, 36);
            this.usernameBox_signup.TabIndex = 14;
            // 
            // username_signup
            // 
            this.username_signup.AutoSize = true;
            this.username_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username_signup.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_signup.ForeColor = System.Drawing.Color.Gray;
            this.username_signup.Location = new System.Drawing.Point(28, 138);
            this.username_signup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_signup.Name = "username_signup";
            this.username_signup.Size = new System.Drawing.Size(54, 13);
            this.username_signup.TabIndex = 16;
            this.username_signup.Text = "username";
            // 
            // GymHive
            // 
            this.GymHive.AutoSize = true;
            this.GymHive.BackColor = System.Drawing.Color.Transparent;
            this.GymHive.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GymHive.ForeColor = System.Drawing.Color.DarkOrange;
            this.GymHive.Location = new System.Drawing.Point(385, 87);
            this.GymHive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GymHive.Name = "GymHive";
            this.GymHive.Size = new System.Drawing.Size(231, 308);
            this.GymHive.TabIndex = 16;
            this.GymHive.Text = "look\r\ngood\r\nfeel\r\nbetter\r\n";
            this.GymHive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitForm
            // 
            this.exitForm.BackColor = System.Drawing.Color.Transparent;
            this.exitForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitForm.FlatAppearance.BorderSize = 0;
            this.exitForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.exitForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitForm.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitForm.ForeColor = System.Drawing.Color.DarkOrange;
            this.exitForm.Location = new System.Drawing.Point(971, 7);
            this.exitForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(40, 29);
            this.exitForm.TabIndex = 17;
            this.exitForm.Text = "X";
            this.exitForm.UseVisualStyleBackColor = false;
            this.exitForm.Click += new System.EventHandler(this.ExitForm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 490);
            this.ControlBox = false;
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.GymHive);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.TextBox usernameBox_login;
        private System.Windows.Forms.TextBox passwordBox_login;
        private System.Windows.Forms.Label username_login;
        private System.Windows.Forms.Label password_login;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Label GymHive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label password_signup;
        private System.Windows.Forms.TextBox passwordBox_signup;
        private System.Windows.Forms.Label username_signup;
        private System.Windows.Forms.TextBox usernameBox_signup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SignUpButton_login;
        private System.Windows.Forms.Label haveAccount_login;
        private System.Windows.Forms.Label activityType_signup;
        private System.Windows.Forms.TextBox vpasswordBox_signup;
        private System.Windows.Forms.Label vpassword_signup;
        private System.Windows.Forms.Label errorLabel_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton_signup;
        private System.Windows.Forms.Button exitForm;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.ComboBox activityTypecomboBox_signup;
    }
}

