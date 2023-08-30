using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class LogIn : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration objRegistration = new Registration();
            this.Hide();
            objRegistration.ShowDialog();
        }
        public static int EmployeeId { get; set; }
        public static string currentUser;
        public static string recby
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernName = txtUsername.Text;
            string pass = txtPassword.Text;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string SqlQuery = "Select * FROM Employee WHERE EmpUserName=@EmpUserName and EmpPassword=@EmpPassword";
            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            cmd.Parameters.AddWithValue("@EmpUserName", usernName);
            cmd.Parameters.AddWithValue("@EmpPassword", pass);           
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dtUser = new DataTable();
            da.Fill(dtUser);


           

            if (dtUser.Rows.Count>0)
            {
                LogIn.EmployeeId = Convert.ToInt32(dtUser.Rows[0]["EmployeeId"].ToString());               
                MessageBox.Show("Login Successfully");
                DashBoard objDashBoard = new DashBoard();
                this.Hide();
                objDashBoard.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid username/password");
            }
            con.Close();
         
        }
    }
}
