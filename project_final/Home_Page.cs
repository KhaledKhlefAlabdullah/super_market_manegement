using Microsoft.EntityFrameworkCore;
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
        // close home page button
        private void exit_home_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // go to UI change password
        private void go_to_changePassword_btn_Click(object sender, EventArgs e)
        {
            panel_changePassword.Visible=!panel_changePassword.Visible;
            go_back_home.Visible = true;
            panel_home_buttons.Visible = false;
            panel_store_data.Visible = false;
            panel_bills_data.Visible = false;
            panel_sales_data.Visible = false;

        }
        // make select color on old password faild in change password UI
        private void panel_old_password_Enter(object sender, EventArgs e)
        {
            panel_old_password.BackColor = Color.White;
            old_password_txt.BackColor = Color.White;
            if (old_password_txt.Text == "old password")
            {
                old_password_txt.Text = "";
                old_password_txt.ForeColor = Color.FromArgb(41, 128, 185);
                old_password_txt.UseSystemPasswordChar= true;
            }
            if (new_password_txt.Text == "")
            {
                new_password_txt.Text = "new password";
                new_password_txt.ForeColor = Color.LightSteelBlue;
                new_password_txt.UseSystemPasswordChar = false;
            }
            if (new_password_txt.Text == "")
            {
                new_password_txt.Text = "new password";
                new_password_txt.ForeColor = Color.LightSteelBlue;
                new_password_txt.UseSystemPasswordChar = false;
            }
            panel_new_password.BackColor = SystemColors.Control;
            new_password_txt.BackColor = SystemColors.Control;
            panel_confirme_new_password.BackColor = SystemColors.Control;
            confirm_new_password_txt.BackColor = SystemColors.Control;
        }
        // make select color on new password faild in change password UI
        private void panel_new_password_Enter(object sender, EventArgs e)
        {
            panel_old_password.BackColor = SystemColors.Control;
            old_password_txt.BackColor = SystemColors.Control;
            if (old_password_txt.Text == "")
            {
                old_password_txt.Text = "old password";
                old_password_txt.ForeColor = Color.LightSteelBlue;
                old_password_txt.UseSystemPasswordChar = false;
            }
            if (new_password_txt.Text == "new password")
            {
                new_password_txt.Text = "";
                new_password_txt.ForeColor = Color.FromArgb(41,128,185);
                new_password_txt.UseSystemPasswordChar = true;
            }
            if (confirm_new_password_txt.Text == "")
            {
                confirm_new_password_txt.Text = "confirm new password";
                confirm_new_password_txt.ForeColor = Color.LightSteelBlue;
                confirm_new_password_txt.UseSystemPasswordChar = false;
            }
            panel_new_password.BackColor =  Color.White;
            new_password_txt.BackColor = Color.White;
            panel_confirme_new_password.BackColor = SystemColors.Control;
            confirm_new_password_txt.BackColor = SystemColors.Control;
        }
        // make select color on confirm new password faild in change password UI
        private void panel_confirme_new_password_Enter(object sender, EventArgs e)
        {
            panel_old_password.BackColor = SystemColors.Control;
            old_password_txt.BackColor = SystemColors.Control;
            if (old_password_txt.Text == "")
            {
                old_password_txt.Text = "old password";
                old_password_txt.ForeColor = Color.LightSteelBlue;
                old_password_txt.UseSystemPasswordChar = false;
            }
            if (new_password_txt.Text == "")
            {
                new_password_txt.Text = "new password";
                new_password_txt.ForeColor = Color.LightSteelBlue;
                new_password_txt.UseSystemPasswordChar = false;
            }
            if (confirm_new_password_txt.Text == "confirm new password")
            {
                confirm_new_password_txt.Text = "";
                confirm_new_password_txt.ForeColor = Color.FromArgb(41, 128, 185);
                confirm_new_password_txt.UseSystemPasswordChar = true;
            }
            panel_new_password.BackColor = SystemColors.Control;
            new_password_txt.BackColor =SystemColors.Control;
            panel_confirme_new_password.BackColor =  Color.White;
            confirm_new_password_txt.BackColor = Color.White;
        }
        // show old password on click and change icon
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
        // show new password on click and change icon
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
        // show confirm new password on click and change icon
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
        // go back to home page from every another UI
        private void go_back_home_Click(object sender, EventArgs e)
        {
            if (panel_changePassword.Visible)
            {
                panel_changePassword.Visible = false;
            }
            if (panel_store_data.Visible)
            {
                panel_store_data.Visible = false;
            }
            if (panel_sales_data.Visible)
            {
                panel_sales_data.Visible = false;
            }
            if (panel_bills_data.Visible)
            {
                panel_bills_data.Visible=false;
            }
            go_back_home.Visible = false;
            panel_home_buttons.Visible = true;
        }
        // go to store UI and view store data in dataGrid view
        private void go_to_store_btn_Click(object sender, EventArgs e)
        {
            panel_store_data.Visible = true;
            go_back_home.Visible = true;
            panel_bills_data.Visible = false;
            panel_sales_data.Visible = false;
            panel_changePassword.Visible = false;
            // handeling exceptions
            try
            {
                // using dbContext to connet to database
                using(var dbContext=new SuperMarketDBcontext())
                {
                    // make users and bills as combo box to chose it
                    // users
                    var user_name_compobox = (DataGridViewComboBoxColumn)store_dataGridView.Columns["userName_store"];
                    user_name_compobox.DisplayMember = "Name";
                    user_name_compobox.ValueMember = "userId";
                    user_name_compobox.DataSource = dbContext.users.ToList();
                    // bills
                    var bill_compobox = (DataGridViewComboBoxColumn)store_dataGridView.Columns["bill_store"];
                    bill_compobox.DisplayMember = "billId";
                    bill_compobox.ValueMember = "billId";
                    bill_compobox.DataSource = dbContext.Bill.ToList();
                    // get products data from the database and display it in the DataGridView
                    var products = dbContext.stores.ToList();

                    foreach (var item in products)
                    {
                        store_dataGridView.Rows.Add();
                        int row_index = store_dataGridView.Rows.Count - 2;
                        store_dataGridView.Rows[row_index].Cells[0].Value = item.id;
                        store_dataGridView.Rows[row_index].Cells[1].Value = item.product_name;
                        store_dataGridView.Rows[row_index].Cells[2].Value = item.product_description;
                        store_dataGridView.Rows[row_index].Cells[3].Value = item.quintity;
                        store_dataGridView.Rows[row_index].Cells[4].Value = item.price_of_sale;
                        store_dataGridView.Rows[row_index].Cells[5].Value = item.price_of_purchase;
                        store_dataGridView.Rows[row_index].Cells[6].Value = item.profit;
                        store_dataGridView.Rows[row_index].Cells[7].Value = item.date_of_purchase;
                        // Set the selected user for the "userName_store" column
                        var userCell = (DataGridViewComboBoxCell)store_dataGridView.Rows[row_index].Cells["userName_store"];
                        userCell.Value = dbContext.users.FirstOrDefault(u => u.userId == item.userId)?.userId;
                        // Set the selected bill for the "bill_store" column
                        var billCell = (DataGridViewComboBoxCell)store_dataGridView.Rows[row_index].Cells["bill_store"];
                        billCell.Value = item.billId;
                    }
                }
            }
            catch(Exception ex)
            {
                // show message if there an error in fetch data
                MessageBox.Show($"there error to connect to database please try agin {ex.Message}","Error",MessageBoxButtons.OK);
            }
        }
        // go to sales UI
        private void go_to_sales_btn_Click(object sender, EventArgs e)
        {
            panel_sales_data.Visible=true;
            panel_store_data.Visible = false;
            panel_bills_data.Visible = false;   
            panel_changePassword.Visible = false;
            go_back_home.Visible=true;
        }
        // go to bills UI
        private void go_to_bills_btn_Click(object sender, EventArgs e)
        {
            panel_bills_data.Visible = true;
            panel_sales_data.Visible = false;
            panel_store_data.Visible = false;
            panel_changePassword.Visible = false;
            go_back_home.Visible = true;
        }
        // change password on click this button
        private void changePassword_btn_Click(object sender, EventArgs e)
        {
            // get old password and new password and make sure they complixe
            string old_password = old_password_txt.Text;
            string new_password = new_password_txt.Text;
            string confirm_new_password = new_password_txt.Text;
            bool old_password_containsSpecialCharacters = Regex.IsMatch(old_password, "[#@,*]");
            bool new_password_containsSpecialCharacters = Regex.IsMatch(new_password, "[#@,*]");
            bool confirm_new_password_containsSpecialCharacters = Regex.IsMatch(confirm_new_password, "[#@,*]");
            // handeling exceptions
            try
            {
                // using dbContext to connect with database
                using(var dbContext=new SuperMarketDBcontext())
                {
                    // get user whow we want to change his password
                    User user = dbContext.users.FirstOrDefault(u => u.userId == InternalVariples.userId);
                    // check if parameters is correct
                    if (old_password.Length < 8 || !old_password_containsSpecialCharacters && old_password.GetHashCode().ToString() == user.password)
                    {
                        old_password_message.Visible = true;
                        return;
                    }
                    if (new_password.Length < 8 || !new_password_containsSpecialCharacters)
                    {
                        new_password_message.Visible = true;
                        return;
                    }
                    if (confirm_new_password.Length < 8 || !confirm_new_password_containsSpecialCharacters)
                    {
                        confiram_new_password_message.Visible = true;
                        return;
                    }
                    // if parameters correct and whe fount user, change password
                    if (user!= null && confirm_new_password == new_password)
                    {
                        user.password = new_password.GetHashCode().ToString();
                        dbContext.SaveChanges();
                        // show message tell user password is changed
                        MessageBox.Show("your password changed", "Alert", MessageBoxButtons.OK);
                        panel_changePassword.Visible = false;
                        go_back_home.Visible = false;
                        panel_home_buttons.Visible = true;
                    }
                }
            }
            catch(Exception ex)
            {
                // if there error show message tell user about error and to try agin
                MessageBox.Show($"there an error in connect to database or entring parameter {ex.Message}","Error",MessageBoxButtons.OK);
            }
           
        }
        // add product to store dataGridView
        private void add_to_store_data_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get all selected rows
                List<DataGridViewRow> selectedRows = store_dataGridView.SelectedRows.Cast<DataGridViewRow>().ToList();
                // Check if any rows are selected
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("Please select rows to add.", "Notice", MessageBoxButtons.OK);
                    return;
                }
                using (var dbContext = new SuperMarketDBcontext())
                {
                    foreach (DataGridViewRow selectedRow in selectedRows)
                    {
                        // Retrieve the values from the selected row cells
                        string name = selectedRow.Cells["name_store"].Value.ToString();
                        string description = selectedRow.Cells["description_store"].Value?.ToString();
                        int quantity = Convert.ToInt32(selectedRow.Cells["quintity_store"].Value);
                        double purchase = Convert.ToDouble(selectedRow.Cells["price_store"].Value);
                        double sale = Convert.ToDouble(selectedRow.Cells["sales_price_store"].Value);
                        double profit = Convert.ToDouble(selectedRow.Cells["profit_store"].Value);
                        DateTime date = DateTime.Now;
                        string userId = selectedRow.Cells["userName_store"].Value?.ToString();
                        string billId = selectedRow.Cells["bill_store"].Value.ToString();


                        // Create a new Store object with the retrieved values
                        if (name!=null && quantity>0 && purchase > 0.0 && sale > 0.0 && profit > 0.0 && billId!=null)
                        {
                            Store store = new Store
                            {
                                id = DateTime.Now.GetHashCode().ToString() + selectedRow.Index,
                                product_name = name,
                                product_description = description,
                                quintity = quantity,
                                price_of_purchase = purchase,
                                price_of_sale = sale,
                                profit = profit,
                                date_of_purchase = date,
                                userId = string.IsNullOrEmpty(userId) ? InternalVariples.userId : userId,
                                billId = billId
                            };
                            // Add the new Store object to the database
                            dbContext.stores.Add(store);
                        }
                        else
                        {
                            MessageBox.Show($"the failds must not be null.", "Error", MessageBoxButtons.OK);
                            return;
                        }
                        
                    }

                    dbContext.SaveChanges();
                }
                // Clear the selection
                store_dataGridView.ClearSelection();
                
                MessageBox.Show("Data added successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                // Show an error message if there is an issue with inserting the data
                MessageBox.Show($"An error occurred while connecting to the database or inserting the data: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }
        // delete data from dataGridView and database on click button
        private void delete_store_data_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get all selected rows
                List<DataGridViewRow> selectedRows = store_dataGridView.SelectedRows.Cast<DataGridViewRow>().ToList();
                // Check if any rows are selected
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("Please select rows to add.", "Notice", MessageBoxButtons.OK);
                    return;
                }

                using (var dbContext = new SuperMarketDBcontext())
                {
                    foreach (DataGridViewRow selectedRow in selectedRows)
                    {
                        string selectedId = selectedRow.Cells["id_store"].Value.ToString();
                        Store product = dbContext.stores.FirstOrDefault(s => s.id == selectedId);
                        // Delete row from dataGridView and database
                        if(product != null)
                        {
                            dbContext.stores.Remove(product);
                            store_dataGridView.Rows.Remove(selectedRow);
                        }
                        else
                        {
                            MessageBox.Show("there now product with this Id.", "Error", MessageBoxButtons.OK);
                            return;
                        }
                    }

                    dbContext.SaveChanges();
                }

                // Clear the selection
                store_dataGridView.ClearSelection();
                MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                // Show an error message if there is an issue with inserting the data
                MessageBox.Show($"An error occurred while connecting to the database or deleting data: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }
        // updata row data in store dataGridView
        private void updata_store_data_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get all selected rows
                DataGridViewRow selectedRow = store_dataGridView.CurrentRow;
                // Check if any rows are selected
                if (selectedRow == null)
                {
                    MessageBox.Show("Please select rows to update.", "Notice", MessageBoxButtons.OK);
                    return;
                }
                using (var dbContext = new SuperMarketDBcontext())
                {
                    // Retrieve the values from the selected row cells
                    string name = selectedRow.Cells["name_store"].Value.ToString();
                    string description = selectedRow.Cells["description_store"].Value?.ToString();
                    int quantity = Convert.ToInt32(selectedRow.Cells["quintity_store"].Value);
                    double purchase = Convert.ToDouble(selectedRow.Cells["price_store"].Value);
                    double sale = Convert.ToDouble(selectedRow.Cells["sales_price_store"].Value);
                    double profit = Convert.ToDouble(selectedRow.Cells["profit_store"].Value);
                    DateTime date = DateTime.Now;
                    string userId = selectedRow.Cells["userName_store"].Value?.ToString();
                    string billId = selectedRow.Cells["bill_store"].Value.ToString();
                    // Update Store object with the retrieved values
                    if (name != null && quantity > 0 && purchase > 0.0 && sale > 0.0 && profit > 0.0 && billId != null)
                    {
                        string id = selectedRow.Cells["id_store"].Value.ToString();
                        Store store = dbContext.stores.FirstOrDefault(s => s.id == id);
                        if (store != null)
                        {
                            store.product_name = name;
                            store.product_description = description;
                            store.quintity = quantity;
                            store.price_of_purchase = purchase;
                            store.price_of_sale = sale;
                            store.profit = profit;
                            store.date_of_purchase = date;
                            store.userId = string.IsNullOrEmpty(userId) ? InternalVariples.userId : userId;
                            store.billId = billId;
                            dbContext.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"the failds must not be null.", "Error", MessageBoxButtons.OK);
                        return;
                    }
                    store_dataGridView.RefreshEdit();
                }
                // Clear the selection
                store_dataGridView.ClearSelection();
                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                // Show an error message if there is an issue with inserting the data
                MessageBox.Show($"An error occurred while connecting to the database or updateing the data: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
