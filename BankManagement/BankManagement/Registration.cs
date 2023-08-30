using BankManagement.Forms;
using BankManagement.Properties;
using BankManagement.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankManagement
{
    public partial class Registration : Form
    {
        //bool Status;
        string Status;
        Employee_E objEmployee = new Employee_E();
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        string imgName;
        string filePath = "";
        string folderPath = @"E:\ADO\Project\BankManagementSLN\BankManagement\Images\Employee_Images\";
        string imagePathFromData;
        public Registration()
        {
            InitializeComponent();
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            pbEmployee.Image = Resources.noImage;
        }

        private void ClearMethod()
        {
            pbEmployee.Image = Resources.noImage;
            
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

            try
            {
               
                objEmployee.Fullname = txtEmpFullName.Text;
                objEmployee.EmpNID = txtEmpNID.Text;
                objEmployee.EmpEmail = txtEmployeeEmail.Text;
                objEmployee.EmpAddress = txtEmployeeAddress.Text;
                objEmployee.EmpPassword = txtEmpPassword.Text;
                objEmployee.EmpUserName = txtEmpUserName.Text;
                objEmployee.ImagePath = folderPath + Path.GetFileName(openFileDialog1.FileName);
                objEmployee.EmpIsActive = Status;               
                objEmployee.EmpJoinDate = dtpJoinDate.Value;
                SqlConnection con = new SqlConnection(conStr);
                string SqlQuery = "Insert into Employee values(@Fullname,@EmpUserName,@EmpAddress,@EmpEmail,@EmpPassword,@ImagePath,@EmpNID,@EmpIsActive,@EmpJoinDate)";
                SqlCommand cmd = new SqlCommand(SqlQuery, con);
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
                cmd.Parameters.AddWithValue("@Fullname", objEmployee.Fullname);
                cmd.Parameters.AddWithValue("@EmpNID", objEmployee.EmpNID);
                cmd.Parameters.AddWithValue("@EmpEmail", objEmployee.EmpEmail);
                cmd.Parameters.AddWithValue("@EmpAddress", objEmployee.EmpAddress);
                cmd.Parameters.AddWithValue("@EmpPassword", objEmployee.EmpPassword);
                cmd.Parameters.AddWithValue("@EmpUserName", objEmployee.EmpUserName);
                cmd.Parameters.AddWithValue("@ImagePath", objEmployee.ImagePath);
                cmd.Parameters.AddWithValue("@EmpIsActive", objEmployee.EmpIsActive);
                cmd.Parameters.AddWithValue("@EmpJoinDate", objEmployee.EmpJoinDate);

                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                con.Close();
                if (rowCount > 0)
                {
                    MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogIn objLogin = new LogIn();
                    this.Hide();
                    objLogin.ShowDialog();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }    

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File(*.jpg; *.png; *.jpeg; *.gif; *.bmp)| *.jpg; *.png; *.jpeg; *.gif; *.bmp|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgName = openFileDialog1.SafeFileName;
                pbEmployee.Image = new Bitmap(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            Status = "Active";
        }

        private void rbNotActive_CheckedChanged(object sender, EventArgs e)
        {
            Status = "Not Active";
        }
    }
}
