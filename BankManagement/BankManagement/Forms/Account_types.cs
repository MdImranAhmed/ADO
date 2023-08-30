using BankManagement.Entities;
using BankManagement.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.Forms
{
    public partial class Account_types : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public Account_types()
        {
            InitializeComponent();
           
        }
       

        private void Account_types_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ShowInGridView();
        }

        private void ShowInGridView()
        {
            string sqlQuery = "Select * from AccountType";
           SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvAccountType.RowTemplate.Height = 30;
            dgvAccountType.DataSource = dt;
            dgvAccountType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            
        }

        private void dgvAccountType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellId = e.RowIndex;
            try
            {
                DataGridViewRow row = dgvAccountType.Rows[cellId];
                lblAccountid.Text = row.Cells[0].Value.ToString();
                txtAccountTypeName.Text = row.Cells[1].Value.ToString();
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountTypeName.Text) == true)
            {
                txtAccountTypeName.Focus();
                errorProvider1.SetError(this.txtAccountTypeName, "Please Enter Account Type");
                ClearMethod();
            }
            else
            {
                Account_Types_E objAccountType=new Account_Types_E();
                objAccountType.AccountType = txtAccountTypeName.Text;
                string sqlQuery = "Insert INTO AccountType (AccountType) VALUES ('" + objAccountType.AccountType + "')";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Account Type added successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Account Type Insertion failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                }
                con.Close();
                ShowInGridView();

            }
        }
        private void ClearMethod()
        {

            txtAccountTypeName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblAccountid.Text))
            {
                Account_Types_E objAccountType = new Account_Types_E();
                objAccountType.AccountType = txtAccountTypeName.Text;
                objAccountType.AccountId= Convert.ToInt16(lblAccountid.Text);
                string sqlQuery = "UPDATE AccountType Set AccountType= @AccountType where AccountId=@AccountId"; 
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@AccountType", objAccountType.AccountType);
                cmd.Parameters.AddWithValue("@AccountId", objAccountType.AccountId);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    lblAccountid.Text = "";
                    MessageBox.Show("Account Type  Updated successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Account Type  Updated failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                }
                con.Close();
                ShowInGridView();
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Please select Account Id!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblAccountid.Text))
            {
                Account_Types_E objAccountType = new Account_Types_E();
                objAccountType.AccountType = txtAccountTypeName.Text;
                objAccountType.AccountId = Convert.ToInt16(lblAccountid.Text);
                string sqlQuery = "DELETE FROM  AccountType WHERE AccountId=@AccountId";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@AccountId", objAccountType.AccountId);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    lblAccountid.Text = "";
                    MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Deletion failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                }
                con.Close();
                ShowInGridView();
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Please select Account Id!", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
