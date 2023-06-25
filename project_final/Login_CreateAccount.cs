using project_final.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_final
{
    public partial class Login_CreateAccount : Form
    {
        public Login_CreateAccount()
        {
            InitializeComponent();
        }


        private void btn_go_to_create_Click_1(object sender, EventArgs e)
        {
            login_panel.Visible = false;
            create_account_panel.Visible = true;
        }

        private void btn_login_from_create_Click(object sender, EventArgs e)
        {
            login_panel.Visible = true;
            create_account_panel.Visible = false;
        }

        private void exit_login_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_password_login_Enter(object sender, EventArgs e)
        {
            panel_password_login.BackColor= Color.White;
            password_login_txt.BackColor= Color.White;
            panel_user_login.BackColor= SystemColors.Control;
            user_name_login_txt.BackColor = SystemColors.Control;
        }

        private void panel_user_login_Enter(object sender, EventArgs e)
        {
            panel_user_login.BackColor = Color.White;
            user_name_login_txt.BackColor = Color.White;
            panel_password_login.BackColor = SystemColors.Control;
            password_login_txt.BackColor = SystemColors.Control;
        }

        private void panel_user_name_create_Enter(object sender, EventArgs e)
        {
            panel_user_name_create.BackColor = Color.White;
            username_txt_create.BackColor= Color.White;
            panel_password_create.BackColor= SystemColors.Control;
            password_txt_create.BackColor= SystemColors.Control;
            panel_confirme_password_create.BackColor= SystemColors.Control;
            confirm_password_txt_create.BackColor= SystemColors.Control;
        }

        private void panel_password_create_Enter(object sender, EventArgs e)
        {
            
            panel_password_create.BackColor =Color.White;
            password_txt_create.BackColor = Color.White;
            panel_user_name_create.BackColor = SystemColors.Control;
            username_txt_create.BackColor =SystemColors.Control;
            panel_confirme_password_create.BackColor = SystemColors.Control;
            confirm_password_txt_create.BackColor = SystemColors.Control;
        }

        private void panel_confirme_password_create_Enter(object sender, EventArgs e)
        {
            panel_confirme_password_create.BackColor = Color.White;
            confirm_password_txt_create.BackColor = Color.White;
            panel_user_name_create.BackColor = SystemColors.Control;
            username_txt_create.BackColor = SystemColors.Control;
            panel_password_create.BackColor = SystemColors.Control;
            password_txt_create.BackColor = SystemColors.Control;
            
        }

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
    }
}
