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
            this.backButton_signup = new System.Windows.Forms.Button();
            this.errorLabel_login = new System.Windows.Forms.Label();
            this.activityType_signup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activityTypeBox_signup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vpasswordBox_signup = new System.Windows.Forms.TextBox();
            this.SignUpButton_login = new System.Windows.Forms.Button();
            this.vpassword_signup = new System.Windows.Forms.Label();
            this.haveAccount_login = new System.Windows.Forms.Label();
            this.password_signup = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordBox_signup = new System.Windows.Forms.TextBox();
            this.usernameBox_signup = new System.Windows.Forms.TextBox();
            this.username_signup = new System.Windows.Forms.Label();
            this.GymHive = new System.Windows.Forms.Label();
            this.exitForm = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
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
            this.buttonLogin.Location = new System.Drawing.Point(485, 494);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 58);
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
            this.buttonCreateUser.Location = new System.Drawing.Point(485, 676);
            this.buttonCreateUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(150, 58);
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
            this.usernameBox_login.Location = new System.Drawing.Point(50, 301);
            this.usernameBox_login.Name = "usernameBox_login";
            this.usernameBox_login.Size = new System.Drawing.Size(585, 64);
            this.usernameBox_login.TabIndex = 6;
            // 
            // passwordBox_login
            // 
            this.passwordBox_login.BackColor = System.Drawing.Color.White;
            this.passwordBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox_login.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox_login.ForeColor = System.Drawing.Color.DarkOrange;
            this.passwordBox_login.Location = new System.Drawing.Point(50, 404);
            this.passwordBox_login.Name = "passwordBox_login";
            this.passwordBox_login.Size = new System.Drawing.Size(585, 64);
            this.passwordBox_login.TabIndex = 7;
            // 
            // username_login
            // 
            this.username_login.AutoSize = true;
            this.username_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username_login.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_login.ForeColor = System.Drawing.Color.Gray;
            this.username_login.Location = new System.Drawing.Point(52, 274);
            this.username_login.Name = "username_login";
            this.username_login.Size = new System.Drawing.Size(98, 24);
            this.username_login.TabIndex = 8;
            this.username_login.Text = "username";
            // 
            // password_login
            // 
            this.password_login.AutoSize = true;
            this.password_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_login.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_login.ForeColor = System.Drawing.Color.Gray;
            this.password_login.Location = new System.Drawing.Point(52, 377);
            this.password_login.Name = "password_login";
            this.password_login.Size = new System.Drawing.Size(94, 24);
            this.password_login.TabIndex = 9;
            this.password_login.Text = "password";
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.White;
            this.SideBar.Controls.Add(this.helpButton);
            this.SideBar.Controls.Add(this.backButton_signup);
            this.SideBar.Controls.Add(this.errorLabel_login);
            this.SideBar.Controls.Add(this.vpasswordBox_signup);
            this.SideBar.Controls.Add(this.vpassword_signup);
            this.SideBar.Controls.Add(this.buttonCreateUser);
            this.SideBar.Controls.Add(this.activityType_signup);
            this.SideBar.Controls.Add(this.label1);
            this.SideBar.Controls.Add(this.activityTypeBox_signup);
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
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(700, 905);
            this.SideBar.TabIndex = 15;
            // 
            // backButton_signup
            // 
            this.backButton_signup.FlatAppearance.BorderSize = 0;
            this.backButton_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton_signup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton_signup.ForeColor = System.Drawing.Color.DarkOrange;
            this.backButton_signup.Location = new System.Drawing.Point(50, 201);
            this.backButton_signup.Name = "backButton_signup";
            this.backButton_signup.Size = new System.Drawing.Size(121, 50);
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
            this.errorLabel_login.Location = new System.Drawing.Point(52, 710);
            this.errorLabel_login.Name = "errorLabel_login";
            this.errorLabel_login.Size = new System.Drawing.Size(166, 24);
            this.errorLabel_login.TabIndex = 15;
            this.errorLabel_login.Text = "Invalid Username";
            this.errorLabel_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activityType_signup
            // 
            this.activityType_signup.AutoSize = true;
            this.activityType_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activityType_signup.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityType_signup.ForeColor = System.Drawing.Color.Gray;
            this.activityType_signup.Location = new System.Drawing.Point(52, 563);
            this.activityType_signup.Name = "activityType_signup";
            this.activityType_signup.Size = new System.Drawing.Size(119, 24);
            this.activityType_signup.TabIndex = 21;
            this.activityType_signup.Text = "activity type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 14;
            // 
            // activityTypeBox_signup
            // 
            this.activityTypeBox_signup.BackColor = System.Drawing.Color.White;
            this.activityTypeBox_signup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activityTypeBox_signup.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityTypeBox_signup.Location = new System.Drawing.Point(50, 590);
            this.activityTypeBox_signup.Name = "activityTypeBox_signup";
            this.activityTypeBox_signup.Size = new System.Drawing.Size(585, 64);
            this.activityTypeBox_signup.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(47, 836);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(574, 51);
            this.label8.TabIndex = 13;
            this.label8.Text = "Disclaimer: This app is for educational purpose only therefore,we do not own any " +
    "copyrights.\r\nWe reserve the rights to make any changes.\r\n ";
            // 
            // vpasswordBox_signup
            // 
            this.vpasswordBox_signup.BackColor = System.Drawing.Color.White;
            this.vpasswordBox_signup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vpasswordBox_signup.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpasswordBox_signup.Location = new System.Drawing.Point(50, 488);
            this.vpasswordBox_signup.Name = "vpasswordBox_signup";
            this.vpasswordBox_signup.Size = new System.Drawing.Size(585, 64);
            this.vpasswordBox_signup.TabIndex = 18;
            // 
            // SignUpButton_login
            // 
            this.SignUpButton_login.FlatAppearance.BorderSize = 0;
            this.SignUpButton_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SignUpButton_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SignUpButton_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton_login.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton_login.ForeColor = System.Drawing.Color.DarkOrange;
            this.SignUpButton_login.Location = new System.Drawing.Point(254, 510);
            this.SignUpButton_login.Name = "SignUpButton_login";
            this.SignUpButton_login.Size = new System.Drawing.Size(160, 46);
            this.SignUpButton_login.TabIndex = 12;
            this.SignUpButton_login.Text = "Sign up";
            this.SignUpButton_login.UseVisualStyleBackColor = true;
            this.SignUpButton_login.Click += new System.EventHandler(this.SignUpButton_login_Click);
            // 
            // vpassword_signup
            // 
            this.vpassword_signup.AutoSize = true;
            this.vpassword_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vpassword_signup.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpassword_signup.ForeColor = System.Drawing.Color.Gray;
            this.vpassword_signup.Location = new System.Drawing.Point(52, 461);
            this.vpassword_signup.Name = "vpassword_signup";
            this.vpassword_signup.Size = new System.Drawing.Size(149, 24);
            this.vpassword_signup.TabIndex = 20;
            this.vpassword_signup.Text = "verify password";
            // 
            // haveAccount_login
            // 
            this.haveAccount_login.AutoSize = true;
            this.haveAccount_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.haveAccount_login.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveAccount_login.ForeColor = System.Drawing.Color.Gray;
            this.haveAccount_login.Location = new System.Drawing.Point(52, 523);
            this.haveAccount_login.Name = "haveAccount_login";
            this.haveAccount_login.Size = new System.Drawing.Size(218, 24);
            this.haveAccount_login.TabIndex = 11;
            this.haveAccount_login.Text = "Don\'t have an account?";
            // 
            // password_signup
            // 
            this.password_signup.AutoSize = true;
            this.password_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_signup.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_signup.ForeColor = System.Drawing.Color.Gray;
            this.password_signup.Location = new System.Drawing.Point(52, 357);
            this.password_signup.Name = "password_signup";
            this.password_signup.Size = new System.Drawing.Size(94, 24);
            this.password_signup.TabIndex = 17;
            this.password_signup.Text = "password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(50, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 67);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // passwordBox_signup
            // 
            this.passwordBox_signup.BackColor = System.Drawing.Color.White;
            this.passwordBox_signup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox_signup.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox_signup.Location = new System.Drawing.Point(50, 384);
            this.passwordBox_signup.Name = "passwordBox_signup";
            this.passwordBox_signup.Size = new System.Drawing.Size(585, 64);
            this.passwordBox_signup.TabIndex = 15;
            // 
            // usernameBox_signup
            // 
            this.usernameBox_signup.BackColor = System.Drawing.Color.White;
            this.usernameBox_signup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox_signup.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox_signup.Location = new System.Drawing.Point(50, 281);
            this.usernameBox_signup.Name = "usernameBox_signup";
            this.usernameBox_signup.Size = new System.Drawing.Size(585, 64);
            this.usernameBox_signup.TabIndex = 14;
            // 
            // username_signup
            // 
            this.username_signup.AutoSize = true;
            this.username_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username_signup.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_signup.ForeColor = System.Drawing.Color.Gray;
            this.username_signup.Location = new System.Drawing.Point(52, 254);
            this.username_signup.Name = "username_signup";
            this.username_signup.Size = new System.Drawing.Size(98, 24);
            this.username_signup.TabIndex = 16;
            this.username_signup.Text = "username";
            // 
            // GymHive
            // 
            this.GymHive.AutoSize = true;
            this.GymHive.BackColor = System.Drawing.Color.Transparent;
            this.GymHive.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GymHive.ForeColor = System.Drawing.Color.DarkOrange;
            this.GymHive.Location = new System.Drawing.Point(706, 160);
            this.GymHive.Name = "GymHive";
            this.GymHive.Size = new System.Drawing.Size(405, 540);
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
            this.exitForm.Location = new System.Drawing.Point(1780, 12);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(73, 53);
            this.exitForm.TabIndex = 17;
            this.exitForm.Text = "X";
            this.exitForm.UseVisualStyleBackColor = false;
            this.exitForm.Click += new System.EventHandler(this.ExitForm_Click);
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
            this.helpButton.Location = new System.Drawing.Point(43, 794);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(166, 36);
            this.helpButton.TabIndex = 18;
            this.helpButton.Text = "need help?";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1865, 905);
            this.ControlBox = false;
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.GymHive);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
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
        private System.Windows.Forms.TextBox activityTypeBox_signup;
        private System.Windows.Forms.TextBox vpasswordBox_signup;
        private System.Windows.Forms.Label vpassword_signup;
        private System.Windows.Forms.Label errorLabel_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton_signup;
        private System.Windows.Forms.Button exitForm;
        private System.Windows.Forms.Button helpButton;
    }
}

