using BankManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.Report
{
    public partial class CRForm : Form
    {
        List<CustomerViewModel> lst;
        public CRForm(List<CustomerViewModel> list)
        {
            InitializeComponent();
            lst = list;
        }

        
        public CRForm()
        {
            InitializeComponent();
        }

        private void CRForm_Load_1(object sender, EventArgs e)
        {
            CustomerReport objRpt = new CustomerReport();
            objRpt.SetDataSource(lst);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
