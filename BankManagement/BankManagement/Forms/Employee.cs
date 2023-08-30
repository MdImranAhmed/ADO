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
    public partial class Employee : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        string status;
        string imgName;
        string filePath = "";
        string folderPath = @"E:\ADO\Project\BankManagementSLN\BankManagement\Images\Employee_Images\";
        string imagePathFromData;
        public Employee()
        {
            InitializeComponent();
            
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ShowInGridView();
            pbEmployee.Image = Resources.noImage;
        }

        private void ShowInGridView()
        {
            string sqlQuery = "Select * from Employee";
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
                    dr["Picture"] = File.ReadAllBytes(dr["ImagePath"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();
            dgvEmployee.RowTemplate.Height = 52;
            dgvEmployee.DataSource = dt;
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage = (DataGridViewImageColumn)dgvEmployee.Columns[10];
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellId = e.RowIndex;
            try
            {
                DataGridViewRow row = dgvEmployee.Rows[cellId];
                lblEmployeeId.Text = row.Cells[0].Value.ToString();
                txtEmpFullName.Text = row.Cells[1].Value.ToString();
                txtEmpUserName.Text = row.Cells[2].Value.ToString();
                txtEmployeeAddress.Text = row.Cells[3].Value.ToString();
                txtEmployeeEmail.Text = row.Cells[4].Value.ToString();
                txtEmpPassword.Text = row.Cells[5].Value.ToString();
                if (imagePathFromData == "No Image")
                {
                    pbEmployee.Image = Resources.noImage;
                }
                byte[] data = (byte[])row.Cells[10].Value;
                MemoryStream stream = new MemoryStream(data);
                pbEmployee.Image = Image.FromStream(stream);
                imagePathFromData = row.Cells[6].Value.ToString();
                txtEmpNID.Text = row.Cells[7].Value.ToString();
                
                dtpJoinDate.Text = row.Cells[9].Value.ToString();
                if (row.Cells[8].Value.ToString() == "Active")
                {
                    rbActive.Checked = true;
                }
                else if (row.Cells[8].Value.ToString() == "Not Active")
                {
                    rbNotActive.Checked = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee_E objEmployee = new Employee_E();
            objEmployee.Fullname = txtEmpFullName.Text;
            objEmployee.EmpUserName = txtEmpUserName.Text;
            objEmployee.EmpAddress=txtEmployeeAddress.Text;
            objEmployee.EmpEmail=txtEmployeeEmail.Text;
            objEmployee.EmpPassword=txtEmpPassword.Text;
            objEmployee.EmpNID=txtEmpNID.Text;
            objEmployee.EmpIsActive = status;
            objEmployee.EmpJoinDate=dtpJoinDate.Value;
            objEmployee.ImagePath = folderPath + Path.GetFileName(openFileDialog1.FileName);
            string sqlQuery = "Insert INTO Employee VALUES (@FullName,@EmpUserName,@EmpAddress,@EmpEmail,@EmpPassword,@ImagePath,@EmpNID,@EmpIsActive,@EmpJoinDate)";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            if (filePath == "")
            {
                cmd.Parameters.AddWithValue("@ImgPath", "No Image Found");
            }
            else
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ImgPath", objEmployee.ImagePath);
                try
                {
                    File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cmd.Parameters.AddWithValue("@FullName", objEmployee.Fullname);
            cmd.Parameters.AddWithValue("@EmpUserName", objEmployee.EmpUserName);
            cmd.Parameters.AddWithValue("@EmpAddress", objEmployee.EmpAddress);
            cmd.Parameters.AddWithValue("@EmpEmail", objEmployee.EmpEmail);
            cmd.Parameters.AddWithValue("@EmpPassword", objEmployee.EmpPassword);
            cmd.Parameters.AddWithValue("@ImagePath", objEmployee.ImagePath);
            cmd.Parameters.AddWithValue("@EmpNID", objEmployee.EmpNID);
            cmd.Parameters.AddWithValue("@EmpIsActive", objEmployee.EmpIsActive);
            cmd.Parameters.AddWithValue("@EmpJoinDate", objEmployee.EmpJoinDate);
            con.Open();
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount > 0)
            {
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK);
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Employee Insertion failed!", "Failure", MessageBoxButtons.OK);
                ClearMethod();
            }
            con.Close();
            ShowInGridView();
            ClearMethod();
        }

        private void ClearMethod()
        {
            lblEmployeeId.Text = "";
            txtEmpFullName.Text= "";           
            txtEmpUserName.Text="";
            txtEmployeeAddress.Text="";
            txtEmployeeEmail.Text="";
            txtEmpPassword.Text="";
            txtEmpNID.Text="";
            status="";
            pbEmployee.Image = Resources.noImage;
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            status = "Active";
        }

        private void rbNotActive_CheckedChanged(object sender, EventArgs e)
        {
            status = "Not Active";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblEmployeeId.Text))
            {
                Employee_E objEmployee = new Employee_E();
                objEmployee.Fullname = txtEmpFullName.Text;
                objEmployee.EmpUserName = txtEmpUserName.Text;
                objEmployee.EmpAddress = txtEmployeeAddress.Text;
                objEmployee.EmpEmail = txtEmployeeEmail.Text;
                objEmployee.EmpPassword = txtEmpPassword.Text;
                objEmployee.EmpNID = txtEmpNID.Text;
                objEmployee.EmpIsActive = status;
                objEmployee.EmpJoinDate = dtpJoinDate.Value;
                objEmployee.EmployeeId=Convert.ToInt16(lblEmployeeId.Text);
                objEmployee.ImagePath = folderPath + Path.GetFileName(openFileDialog1.FileName);
                string sqlQuery = "Update Employee set FullName=@FullName,EmpUserName=@EmpUserName,EmpAddress=@EmpAddress,EmpEmail=@EmpEmail,EmpPassword=@EmpPassword,ImagePath=@ImagePath,EmpNID=@EmpNID,EmpIsActive=@EmpIsActive,EmpJoinDate=@EmpJoinDate where EmployeeId=@EmployeeId";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                if (filePath == "")
                {
                    cmd.Parameters.AddWithValue("@ImagePath", imagePathFromData);
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ImgPath", objEmployee.ImagePath);
                    try
                    {
                        File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)), true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                cmd.Parameters.AddWithValue("@FullName", objEmployee.Fullname);
                cmd.Parameters.AddWithValue("@EmpUserName", objEmployee.EmpUserName);
                cmd.Parameters.AddWithValue("@EmpAddress", objEmployee.EmpAddress);
                cmd.Parameters.AddWithValue("@EmpEmail", objEmployee.EmpEmail);
                cmd.Parameters.AddWithValue("@EmpPassword", objEmployee.EmpPassword);
                cmd.Parameters.AddWithValue("@ImagePath", objEmployee.ImagePath);
                cmd.Parameters.AddWithValue("@EmpNID", objEmployee.EmpNID);
                cmd.Parameters.AddWithValue("@EmpIsActive", objEmployee.EmpIsActive);
                cmd.Parameters.AddWithValue("@EmpJoinDate", objEmployee.EmpJoinDate);
                cmd.Parameters.AddWithValue("@EmployeeId", objEmployee.EmployeeId);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    lblEmployeeId.Text = "";
                    MessageBox.Show("Employee Updated successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Employee Updated failed!", "Failure", MessageBoxButtons.OK);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblEmployeeId.Text))
            {
                Employee_E objEmployee = new Employee_E();
                objEmployee.EmployeeId = Convert.ToInt16(lblEmployeeId.Text);
                string sqlQuery = "DELETE FROM  Employee WHERE EmployeeId=@EmployeeId";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@EmployeeId", objEmployee.EmployeeId);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    lblEmployeeId.Text = "";
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
                MessageBox.Show("Please select Employee Id!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File(*.jpg; *.png; *.jpeg; *.gif; *.bmp)| *.jpg; *.png; *.jpeg; *.gif; *.bmp|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgName = openFileDialog1.SafeFileName;
                pbEmployee.Image = new Bitmap(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }
    }
}
