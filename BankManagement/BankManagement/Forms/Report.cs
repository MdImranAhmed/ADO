using BankManagement.Entities;
using BankManagement.Report;
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
    public partial class Report : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        int EmployeeId = 107;
        string imgName;
        int CustAccountNo = 0;
        string filePath = "";
        string folderPath = @"E:\ADO\Project\BankManagementSLN\BankManagement\Images\Customer_Images\";
        string imagePathFromData;
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
                LoadTheme();
            ShowInGridView();

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
            dgvReport.RowTemplate.Height = 52;
            dgvReport.DataSource = dt;
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage = (DataGridViewImageColumn)dgvReport.Columns[14];
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<CustomerViewModel> list = new List<CustomerViewModel>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string SqlQuery = "select cu.CusAccountNo, cu.CustFName,cu.CustLName,cu.CustFathersFName, cu.CustFathersLName,cu.CustDateofBirth,cu.CustNID,cu.CustOccupation,cu.CustPhoneNo,cu.CustDepositAmount, cu.CustImagePath,cu.CustGenderId,ge.Gender,cu.EmployeeId,emp.FullName,cu.CustAccountId,ac.AccountType from Customer cu join Gender ge on cu.CustGenderId=ge.GenderId join Employee emp on cu.EmployeeId=emp.EmployeeId join AccountType ac on cu.CustAccountId=ac.AccountId";
                SqlDataAdapter sda = new SqlDataAdapter(SqlQuery, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CustomerViewModel objViewModel = new CustomerViewModel();
                    objViewModel.CusAccountNo = Convert.ToInt32(dt.Rows[i]["CusAccountNo"].ToString());
                    objViewModel.CustFName = dt.Rows[i]["CustFName"].ToString();
                    objViewModel.CustLName = dt.Rows[i]["CustLName"].ToString();
                    objViewModel.CustFathersFName = dt.Rows[i]["CustFathersFName"].ToString();
                    objViewModel.CustFathersLName = dt.Rows[i]["CustFathersLName"].ToString();
                    objViewModel.CustDateofBirth = Convert.ToDateTime(dt.Rows[i]["CustDateofBirth"].ToString());
                    objViewModel.CustNID = dt.Rows[i]["CustNID"].ToString();
                    objViewModel.CustOccupation = dt.Rows[i]["CustOccupation"].ToString();
                    objViewModel.CustPhoneNo = dt.Rows[i]["CustPhoneNo"].ToString();
                    objViewModel.CustDepositAmount = Convert.ToDecimal(dt.Rows[i]["CustDepositAmount"].ToString());
                    objViewModel.CustImagePath = dt.Rows[i]["CustImagePath"].ToString();
                    objViewModel.CustGenderId = Convert.ToInt32(dt.Rows[i]["CustGenderId"].ToString());

                    objViewModel.Gender = dt.Rows[i]["Gender"].ToString();
                    objViewModel.EmployeeId = Convert.ToInt32(dt.Rows[i]["EmployeeId"].ToString());
                    objViewModel.FullName = dt.Rows[i]["FullName"].ToString();
                    objViewModel.CustAccountId = Convert.ToInt32(dt.Rows[i]["CustAccountId"].ToString());
                    objViewModel.AccountType = dt.Rows[i]["AccountType"].ToString();          
                    list.Add(objViewModel);
                }
            }
            using (CRForm form = new CRForm(list))
            {
                form.ShowDialog();
            }
        }
    }
}
