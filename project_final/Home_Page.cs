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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void exit_home_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void go_to_changePassword_btn_Click(object sender, EventArgs e)
        {
            panel_changePassword.Visible=!panel_changePassword.Visible;
            go_back_home.Visible = true;
            panel_home_buttons.Visible = false;
            
        }

        private void panel_old_password_Enter(object sender, EventArgs e)
        {
            panel_old_password.BackColor = Color.White;
            old_password_txt.BackColor = Color.White;
            panel_new_password.BackColor = SystemColors.Control;
            new_password_txt.BackColor = SystemColors.Control;
            panel_confirme_new_password.BackColor = SystemColors.Control;
            confirm_new_password_txt.BackColor = SystemColors.Control;
        }

        private void panel_new_password_Enter(object sender, EventArgs e)
        {
            panel_old_password.BackColor = SystemColors.Control;
            old_password_txt.BackColor = SystemColors.Control;
            panel_new_password.BackColor =  Color.White;
            new_password_txt.BackColor = Color.White;
            panel_confirme_new_password.BackColor = SystemColors.Control;
            confirm_new_password_txt.BackColor = SystemColors.Control;
        }

        private void panel_confirme_new_password_Enter(object sender, EventArgs e)
        {
            panel_old_password.BackColor = SystemColors.Control;
            old_password_txt.BackColor = SystemColors.Control;
            panel_new_password.BackColor = SystemColors.Control;
            new_password_txt.BackColor =SystemColors.Control;
            panel_confirme_new_password.BackColor =  Color.White;
            confirm_new_password_txt.BackColor = Color.White;
        }

        private void old_password_show_Click(object sender, EventArgs e)
        {
            if (old_password_txt.UseSystemPasswordChar)
            {
                old_password_txt.UseSystemPasswordChar = false;
                old_password_show.Image = Resources.show;
            }
            else
            {
                old_password_txt.UseSystemPasswordChar = true;
                old_password_show.Image = Resources._lock;
            }
        }

        private void new_password_show_Click(object sender, EventArgs e)
        {
            if (new_password_txt.UseSystemPasswordChar)
            {
                new_password_txt.UseSystemPasswordChar = false;
                new_password_show.Image = Resources.show;
            }
            else
            {
                new_password_txt.UseSystemPasswordChar = true;
                new_password_show.Image = Resources._lock;
            }
        }

        private void confirm_new_password_show_Click(object sender, EventArgs e)
        {
            if (confirm_new_password_txt.UseSystemPasswordChar)
            {
                confirm_new_password_txt.UseSystemPasswordChar = false;
                confirm_new_password_show.Image = Resources.show;
            }
            else
            {
                confirm_new_password_txt.UseSystemPasswordChar = true;
                confirm_new_password_show.Image = Resources._lock;
            }
        }

        private void go_back_home_Click(object sender, EventArgs e)
        {
            panel_changePassword.Visible = false;
            go_back_home.Visible = false;
            panel_home_buttons.Visible = true;
            
        }

       
    }
}
