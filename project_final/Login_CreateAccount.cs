using Azure;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using project_final.Models;
using project_final.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace project_final
{
    public partial class Login_CreateAccount : Form
    {
        public Login_CreateAccount()
        {
            InitializeComponent();
        }

        // move to UI create account
        private void btn_go_to_create_Click_1(object sender, EventArgs e)
        {
            login_panel.Visible = false;
            create_account_panel.Visible = true;
        }
        // move to login UI from create UI
        private void btn_login_from_create_Click(object sender, EventArgs e)
        {
            login_panel.Visible = true;
            create_account_panel.Visible = false;
        }
        // close app button
        private void exit_login_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // make selected color on password fialde in login UI
        private void panel_password_login_Enter(object sender, EventArgs e)
        {
            panel_password_login.BackColor= Color.White;
            password_login_txt.BackColor= Color.White;
            if (password_login_txt.Text == "password")
            {
                password_login_txt.Text = "";
                password_login_txt.ForeColor = Color.FromArgb(41, 128, 185);
                password_login_txt.UseSystemPasswordChar= true;
            }
            if (user_name_login_txt.Text == "")
            {
                user_name_login_txt.Text = "user name";
                user_name_login_txt.ForeColor = Color.LightSteelBlue;
            }
            panel_user_login.BackColor= SystemColors.Control;
            user_name_login_txt.BackColor = SystemColors.Control;
        }
        // make selected color on uder nsme fialde in login UI
        private void panel_user_login_Enter(object sender, EventArgs e)
        {
            panel_user_login.BackColor = Color.White;
            user_name_login_txt.BackColor = Color.White;
            if(user_name_login_txt.Text=="user name")
            {
                user_name_login_txt.Text = "";
                user_name_login_txt.ForeColor = Color.FromArgb(41, 128, 185);
            }
            if (password_login_txt.Text == "")
            {
                password_login_txt.Text = "password";
                password_login_txt.ForeColor = Color.LightSteelBlue;
                password_login_txt.UseSystemPasswordChar = false;
            }
            panel_password_login.BackColor = SystemColors.Control;
            password_login_txt.BackColor = SystemColors.Control;
        }
        // make selected color on user name fialde in create account UI
        private void panel_user_name_create_Enter(object sender, EventArgs e)
        {
            panel_user_name_create.BackColor = Color.White;
            user_name_txt_create.BackColor= Color.White;
            if (user_name_txt_create.Text == "user name")
            {
                user_name_txt_create.Text = "";
                user_name_txt_create.ForeColor = Color.FromArgb(41, 128, 185);
            }
            if (password_txt_create.Text == "")
            {
                password_txt_create.Text = "password";
                password_txt_create.ForeColor = Color.LightSteelBlue;
                password_txt_create.UseSystemPasswordChar = false;
            }
            if (confirm_password_txt_create.Text == "")
            {
                confirm_password_txt_create.Text = "confirm password";
                confirm_password_txt_create.ForeColor = Color.LightSteelBlue;
                confirm_password_txt_create.UseSystemPasswordChar = false;
            }
            panel_password_create.BackColor= SystemColors.Control;
            password_txt_create.BackColor= SystemColors.Control;
            panel_confirme_password_create.BackColor= SystemColors.Control;
            confirm_password_txt_create.BackColor= SystemColors.Control;
        }
        // make selected color on password fialde in create account UI
        private void panel_password_create_Enter(object sender, EventArgs e)
        {
            
            panel_password_create.BackColor =Color.White;
            password_txt_create.BackColor = Color.White;
            if (user_name_txt_create.Text == "")
            {
                user_name_txt_create.Text = "user name";
                user_name_txt_create.ForeColor = Color.LightSteelBlue;
            }
            if (password_txt_create.Text == "password")
            {
                password_txt_create.Text = "";
                password_txt_create.ForeColor = Color.FromArgb(41,128,185);
                password_txt_create.UseSystemPasswordChar = true;
            }
            if (confirm_password_txt_create.Text == "")
            {
                confirm_password_txt_create.Text = "confirm password";
                confirm_password_txt_create.ForeColor = Color.LightSteelBlue;
                confirm_password_txt_create.UseSystemPasswordChar = false;
            }
            panel_user_name_create.BackColor = SystemColors.Control;
            user_name_txt_create.BackColor =SystemColors.Control;
            panel_confirme_password_create.BackColor = SystemColors.Control;
            confirm_password_txt_create.BackColor = SystemColors.Control;
        }
        // make selected color on confrim password fialde in create account UI
        private void panel_confirme_password_create_Enter(object sender, EventArgs e)
        {
            panel_confirme_password_create.BackColor = Color.White;
            confirm_password_txt_create.BackColor = Color.White;
            if (user_name_txt_create.Text == "")
            {
                user_name_txt_create.Text = "user name";
                user_name_txt_create.ForeColor = Color.LightSteelBlue;
            }
            if (password_txt_create.Text == "")
            {
                password_txt_create.Text = "password";
                password_txt_create.ForeColor = Color.LightSteelBlue;
                password_txt_create.UseSystemPasswordChar = false;
            }
            if (confirm_password_txt_create.Text == "confirm password")
            {
                confirm_password_txt_create.Text = "";
                confirm_password_txt_create.ForeColor = Color.FromArgb(41, 128, 185);
                confirm_password_txt_create.UseSystemPasswordChar = true;
            }
            panel_user_name_create.BackColor = SystemColors.Control;
            user_name_txt_create.BackColor = SystemColors.Control;
            panel_password_create.BackColor = SystemColors.Control;
            password_txt_create.BackColor = SystemColors.Control;
            
        }
        // show password in login UI on click password icon and haid and change icon
        private void password_show_login_logo_Click(object sender, EventArgs e)
        {
            if (password_login_txt.UseSystemPasswordChar)
            {
                password_login_txt.UseSystemPasswordChar = false;
                password_show_login_logo.Image = Resources.show;
            }
            else
            {
                password_login_txt.UseSystemPasswordChar = true;
                password_show_login_logo.Image = Resources._lock;
            }

        }
        // show password in create account UI on click password icon and haid and change icon
        private void show_password_create_Click(object sender, EventArgs e)
        {
            if (password_txt_create.UseSystemPasswordChar)
            {
                password_txt_create.UseSystemPasswordChar = false;
                show_password_create.Image = Resources.show;
            }
            else
            {
                password_txt_create.UseSystemPasswordChar = true;
                show_password_create.Image = Resources._lock;
            }
        }
        // show confirm password in create account UI on click password icon and haid and change icon
        private void show_password_confirm_create_Click(object sender, EventArgs e)
        {
            if (confirm_password_txt_create.UseSystemPasswordChar)
            {
                confirm_password_txt_create.UseSystemPasswordChar = false;
                show_password_confirm_create.Image = Resources.show;
            }
            else
            {
                confirm_password_txt_create.UseSystemPasswordChar = true;
                show_password_confirm_create.Image = Resources._lock;
            }
        }
        // login by user name and password
        private void login_btn_Click(object sender, EventArgs e)
        {
            // handeling exception
            try
            {
                using (var dbContext = new SuperMarketDBcontext())
                {
                    // get all users
                    List<User> users = dbContext.users.ToList();
                    bool isUserFound = false;
                    // check if ther user by entrying value
                    foreach (var user in users)
                    {
                        if (user.Name == user_name_login_txt.Text.Trim() && BCrypt.Net.BCrypt.Verify(password_login_txt.Text, user.password))
                        {
                            isUserFound = true;
                            this.Hide();
                            InternalVariples.userId = user.userId;
                            Home_Page homePage = new Home_Page();
                            homePage.Show();
                            MessageBox.Show("You are logged in", "Welcome!", MessageBoxButtons.OK);
                            break;
                        }
                    }
                    // view error message if dont found the user
                    if (!isUserFound)
                    {
                        password_login_errorMessage.Visible = true;
                        MessageBox.Show("There is no user with this name or the password is incorrect", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot connect to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // show error message if user name in login not correct
        private void user_name_login_txt_TextChanged(object sender, EventArgs e)
        {
            string name = user_name_login_txt.Text;
            if (name.Length <= 2)
                user_name_login_errorMessage.Visible = true;
            else
                user_name_login_errorMessage.Visible = false;
        }
        // show error message if password in login not correct
        private void password_login_txt_TextChanged(object sender, EventArgs e)
        {
            string password = password_login_txt.Text;
            bool containsSpecialCharacters = Regex.IsMatch(password, "[#@,*]");
            if (password.Length < 8 || !containsSpecialCharacters)
                password_login_errorMessage.Visible = true;
            else
                password_login_errorMessage.Visible = false;
        }
        // create account on click this button if information is true
        private void btn_create_and_login_Click(object sender, EventArgs e)
        {
            // handeling exciptions
            try
            {
                // using db context to connect to database
                using (var dbContext=new SuperMarketDBcontext())
                {
                    // initialize variables for id,name,password
                    string id=null;
                    string name = null;
                    string pass=null;
                    // get all ids in users table 
                    var ids = from users in dbContext.users
                              select users.userId;
                    // check if id not in ids to remain unique
                    while (true)
                    {   
                        string idg = Guid.NewGuid().ToString();
                        if (!ids.Contains(idg))
                        {
                            id = idg;
                            break;
                        }
                    }
                    // check if user name is correct
                    if (user_name_txt_create.Text.Length > 2)
                        name= user_name_txt_create.Text.Trim();
                    else
                        user_name_create_errorMessage.Visible = true;
                    // check if password and confirm password is corrct and if they are same
                    string password = password_txt_create.Text;
                    string confirm_password = confirm_password_txt_create.Text;
                    bool password_containsSpecialCharacters = Regex.IsMatch(password, "[#@,*]");
                    bool confirm_password_containsSpecialCharacters = Regex.IsMatch(confirm_password, "[#@,*]");
                    if (password.Length > 8 && password_containsSpecialCharacters && confirm_password == password)
                        pass = password.Trim();
                    else
                        password_create_errorMessage.Visible = true;
                    if (confirm_password != password)
                        confirm_password_create_errorMessage.Visible = true;
                    // insert new user to database if data was correct, close create acount window and show home window
                    if(id!= null && name!=null && pass != null)
                    {
                        User user = new User
                        {
                            userId = id+DateTime.Now.ToString(), Name = name, password = BCrypt.Net.BCrypt.HashPassword(pass) 
                        };
                        dbContext.users.Add(user);
                        dbContext.SaveChanges();
                        this.Hide();
                        // save userId to use't in change password
                        InternalVariples.userId = id;
                        Home_Page home_page = new Home_Page();
                        home_page.Show();
                        MessageBox.Show("welcom you are created account succesfuly and logined", "Alert", MessageBoxButtons.OK);

                    }
                }
            }
            catch(Exception ex)
            {
                // show message box with error text
                MessageBox.Show($"there problem to insert new user to data base {ex.Message}","Error",MessageBoxButtons.OK);
            }
        }
        // show error message if confirm password not like password in create account
        private void confirm_password_txt_create_TextChanged(object sender, EventArgs e)
        {
            if (confirm_password_txt_create.Text != password_txt_create.Text)
                confirm_password_create_errorMessage.Visible = true;
            else
                confirm_password_create_errorMessage.Visible = false;
        }
        // show error message if password correct in create account
        private void password_txt_create_TextChanged(object sender, EventArgs e)
        {
            string password = password_txt_create.Text;
            bool password_containsSpecialCharacters = Regex.IsMatch(password, "[#@,*]");
            if (password.Length < 8 && !password_containsSpecialCharacters)
                password_create_errorMessage.Visible = true;
            else
                password_create_errorMessage.Visible = false;
        }
        // show error message if user name not correct in create account
        private void user_name_txt_create_TextChanged(object sender, EventArgs e)
        {
            if (user_name_txt_create.Text.Length <= 2)
                user_name_create_errorMessage.Visible = true;
            else
                user_name_create_errorMessage.Visible = false;
        }
    }
}
