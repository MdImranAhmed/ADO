using BankManagement.Entities;
using BankManagement.Properties;
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
    public partial class Customer : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        
        int EmployeeId = LogIn.EmployeeId;
        string imgName;
        int CustAccountNo = 0;
        string filePath = "";
        string folderPath = @"E:\ADO\Project\BankManagementSLN\BankManagement\Images\Customer_Images\";
        string imagePathFromData;
        public Customer()
        {
            InitializeComponent();
           
        }
        

        public void Customer_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadEmployeeName();
            LoadAccountType();
            LoadGender();
            pbCustomer.Image = Resources.noImage;
            ShowInGridView();
            lblEmployeeId.Text =LogIn.EmployeeId.ToString();      

        }

       
        private void ShowInGridView()
        {
            string sqlQuery = "select cu.CusAccountNo, cu.CustFName,cu.CustLName,cu.CustFathersFName, cu.CustFathersLName,cu.CustDateofBirth,cu.CustNID,cu.CustOccupation,cu.CustPhoneNo,cu.CustDepositAmount, cu.CustImagePath,ge.Gender,emp.FullName,ac.AccountType from Customer cu join Gender ge on cu.CustGenderId=ge.GenderId join Employee emp on cu.EmployeeId=emp.EmployeeId join AccountType ac on cu.CustAccountId=ac.AccountId";
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);
            dt.Columns.Add("Picture", Type.GetType("System.Byte[]"));
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    dr["Picture"] = File.ReadAllBytes(dr["CustImagePath"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();
            dgvCustomer.RowTemplate.Height = 52;
            dgvCustomer.DataSource = dt;
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage = (DataGridViewImageColumn)dgvCustomer.Columns[14];
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadGender()
        {
            string sqlQuery = "SELECT * FROM Gender";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader, LoadOption.Upsert);
            if (dt != null)
            {
                cmbGender.DisplayMember = "Gender";
                cmbGender.ValueMember = "GenderId";
                cmbGender.DataSource = dt;
            }
            con.Close();
        }

        private void LoadAccountType()
        {
            string sqlQuery = "SELECT * FROM AccountType";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader, LoadOption.Upsert);
            if (dt != null)
            {
                cmbAccountType.DisplayMember = "AccountType";
                cmbAccountType.ValueMember = "AccountId";
                cmbAccountType.DataSource = dt;
            }
            con.Close();
        }

        public void LoadEmployeeName()
        {
            string EmpUserName = "";           
            string sqlQuery = "SELECT FullName FROM Employee WHERE EmployeeId='" + EmployeeId + "'";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            EmpUserName = (cmd.ExecuteScalar()).ToString();
            if (EmpUserName == "")
            {
                lblEmployeeName.Text = "Unknown";
            }
            lblEmployeeName.Text = EmpUserName;
            con.Close();
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
            groupBox1.ForeColor = ThemeColor.SecondaryColor;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer_E objCustomer = new Customer_E();
            objCustomer.CustFName=txtCustomerFName.Text;
            objCustomer.CustLName=txtCustLName.Text;
            objCustomer.CustFathersFName=txtFathersFName.Text;
            objCustomer.CustFathersLName=txtFathersLName.Text;
            objCustomer.CustDateofBirth=dtpDateofBirth.Value;
            objCustomer.CustNID = txtCustNID.Text;
            objCustomer.CustOccupation=txtCustOccupation.Text;
            objCustomer.CustPhoneNo=txtCustPhoneNumber.Text;
            objCustomer.CustDepositAmount = Convert.ToDecimal(txtDepositAmount.Text);
            objCustomer.CustImagePath = folderPath + Path.GetFileName(openFileDialog1.FileName);
            objCustomer.CustGenderId=Convert.ToInt16(cmbGender.SelectedValue);
            objCustomer.EmployeeId = EmployeeId;
            objCustomer.CustAccountId = Convert.ToInt32(cmbAccountType.SelectedValue);            
            string sqlQuery = "Insert INTO Customer VALUES (@CustFName,@CustLName,@CustFathersFName,@CustFathersLName,@CustDateofBirth,@CustNID,@CustOccupation,@CustPhoneNo,@CustDepositAmount,@CustImagePath,@CustGenderId,@EmployeeId,@CustAccountId)";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            if (filePath == "")
            {
                cmd.Parameters.AddWithValue("@CustImagePath", "No Image Found");
            }
            else
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ImgPath", objCustomer.CustImagePath);
                try
                {
                    File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cmd.Parameters.AddWithValue("@CustFName", objCustomer.CustFName);
            cmd.Parameters.AddWithValue("@CustLName", objCustomer.CustLName);
            cmd.Parameters.AddWithValue("@CustFathersFName", objCustomer.CustFathersFName);
            cmd.Parameters.AddWithValue("@CustFathersLName", objCustomer.CustFathersLName);
            cmd.Parameters.AddWithValue("@CustDateofBirth", objCustomer.CustDateofBirth);
            cmd.Parameters.AddWithValue("@CustNID", objCustomer.CustNID);
            cmd.Parameters.AddWithValue("@CustOccupation", objCustomer.CustOccupation);
            cmd.Parameters.AddWithValue("@CustPhoneNo", objCustomer.CustPhoneNo);
            cmd.Parameters.AddWithValue("@CustDepositAmount", objCustomer.CustDepositAmount);
            cmd.Parameters.AddWithValue("@CustImagePath", objCustomer.CustImagePath);
            cmd.Parameters.AddWithValue("@CustGenderId", objCustomer.CustGenderId);
            cmd.Parameters.AddWithValue("@EmployeeId", objCustomer.EmployeeId);
            cmd.Parameters.AddWithValue("@CustAccountId", objCustomer.CustAccountId);
            con.Open();
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount > 0)
            {
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK);
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Customer Insertion failed!", "Failure", MessageBoxButtons.OK);
                ClearMethod();
            }
            con.Close();
            ShowInGridView();
            ClearMethod();
        }

        private void ClearMethod()
        {
           txtCustomerFName.Text="";
           txtCustLName.Text = "";
           txtFathersFName.Text = "";
           txtFathersLName.Text = "";           
           txtCustNID.Text = "";
            txtCustOccupation.Text = "";
            txtCustPhoneNumber.Text = "";
            txtDepositAmount.Text = "";
            pbCustomer.Image = Resources.noImage;
            cmbAccountType.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
            lblCustAccountNo.Text = "";

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File(*.jpg; *.png; *.jpeg; *.gif; *.bmp)| *.jpg; *.png; *.jpeg; *.gif; *.bmp|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgName = openFileDialog1.SafeFileName;
                pbCustomer.Image = new Bitmap(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCustAccountNo.Text))
            {
                Customer_E objCustomer = new Customer_E();
                objCustomer.CustFName = txtCustomerFName.Text;
                objCustomer.CustLName = txtCustLName.Text;
                objCustomer.CustFathersFName = txtFathersFName.Text;
                objCustomer.CustFathersLName = txtFathersLName.Text;
                objCustomer.CustDateofBirth = dtpDateofBirth.Value;
                objCustomer.CustNID = txtCustNID.Text;
                objCustomer.CustOccupation = txtCustOccupation.Text;
                objCustomer.CustPhoneNo = txtCustPhoneNumber.Text;
                objCustomer.CustDepositAmount = Convert.ToDecimal(txtDepositAmount.Text);
                objCustomer.CustImagePath = folderPath + Path.GetFileName(openFileDialog1.FileName);
                objCustomer.CustGenderId = Convert.ToInt16(cmbGender.SelectedValue);
                objCustomer.EmployeeId = EmployeeId;
                objCustomer.CustAccountId = Convert.ToInt32(cmbAccountType.SelectedValue);
                objCustomer.CusAccountNo=Convert.ToInt32(lblCustAccountNo.Text);
                string sqlQuery = "UPDATE Customer SET CustFName = @CustFName, CustLName=@CustLName, CustFathersFName=@CustFathersFName,CustFathersLName=@CustFathersLName,CustDateofBirth=@CustDateofBirth,CustNID=@CustNID,CustOccupation=@CustOccupation,CustPhoneNo=@CustPhoneNo,CustDepositAmount=@CustDepositAmount,CustImagePath=@CustImagePath,CustGenderId=@CustGenderId,EmployeeId=@EmployeeId,CustAccountId=@CustAccountId WHERE CusAccountNo=@CusAccountNo";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                if (filePath == "")
                {
                    cmd.Parameters.AddWithValue("@ImgPath", imagePathFromData);
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ImgPath", objCustomer.CustImagePath);
                    try
                    {
                        File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)), true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                cmd.Parameters.AddWithValue("@CustFName", objCustomer.CustFName);
                cmd.Parameters.AddWithValue("@CustLName", objCustomer.CustLName);
                cmd.Parameters.AddWithValue("@CustFathersFName", objCustomer.CustFathersFName);
                cmd.Parameters.AddWithValue("@CustFathersLName", objCustomer.CustFathersLName);
                cmd.Parameters.AddWithValue("@CustDateofBirth", objCustomer.CustDateofBirth);
                cmd.Parameters.AddWithValue("@CustNID", objCustomer.CustNID);
                cmd.Parameters.AddWithValue("@CustOccupation", objCustomer.CustOccupation);
                cmd.Parameters.AddWithValue("@CustPhoneNo", objCustomer.CustPhoneNo);
                cmd.Parameters.AddWithValue("@CustDepositAmount", objCustomer.CustDepositAmount);
                cmd.Parameters.AddWithValue("@CustImagePath", objCustomer.CustImagePath);
                cmd.Parameters.AddWithValue("@CustGenderId", objCustomer.CustGenderId);
                cmd.Parameters.AddWithValue("@EmployeeId", objCustomer.EmployeeId);
                cmd.Parameters.AddWithValue("@CustAccountId", objCustomer.CustAccountId);
                cmd.Parameters.AddWithValue("@CusAccountNo", objCustomer.CusAccountNo);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    lblCustAccountNo.Text = "";
                    MessageBox.Show("Customer Updated  successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Customer Updated failed!", "Failure", MessageBoxButtons.OK);
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

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellId = e.RowIndex;
            try
            {
                DataGridViewRow row = dgvCustomer.Rows[cellId];
                lblCustAccountNo.Text = row.Cells[0].Value.ToString();
                txtCustomerFName.Text = row.Cells[1].Value.ToString(); 
                txtCustLName.Text = row.Cells[2].Value.ToString(); 
                txtFathersFName.Text = row.Cells[3].Value.ToString(); 
                txtFathersLName.Text = row.Cells[4].Value.ToString(); 
                dtpDateofBirth.Text = row.Cells[5].Value.ToString(); 
                txtCustNID.Text = row.Cells[6].Value.ToString(); 
                txtCustOccupation.Text = row.Cells[7].Value.ToString(); 
                txtCustPhoneNumber.Text = row.Cells[8].Value.ToString(); 
                txtDepositAmount.Text = row.Cells[9].Value.ToString(); 
                cmbGender.Text = row.Cells[11].Value.ToString(); 
                cmbAccountType.Text = row.Cells[13].Value.ToString();                 
                if (imagePathFromData == "No Image")
                {
                    pbCustomer.Image = Resources.noImage;
                }
                byte[] data = (byte[])row.Cells[14].Value;
                MemoryStream stream = new MemoryStream(data);
                pbCustomer.Image = Image.FromStream(stream);
                imagePathFromData = row.Cells[10].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCustAccountNo.Text))
            {
                Customer_E objCustomer = new Customer_E();
                objCustomer.CusAccountNo = Convert.ToInt32(lblCustAccountNo.Text);
                string sqlQuery = "DELETE FROM  Customer WHERE CusAccountNo=@CusAccountNo";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@CusAccountNo", objCustomer.CusAccountNo);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    lblCustAccountNo.Text = "";
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
                MessageBox.Show("Please select Purchase Id!", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
