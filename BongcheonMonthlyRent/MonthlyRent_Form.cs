using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace BongcheonMonthlyRent
{
    
    public partial class MonthlyRent_Form : Form
    {
        public MonthlyRent_Form()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            string tenantInfoCsvPath;
#if DEBUG
            tenantInfoCsvPath = Path.Combine(
                AppContext.BaseDirectory,
                "Resources",
                "DefaultTenantInfo.xlsx"
            );

#else
            string userFolder = Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyProgram");

            Directory.CreateDirectory(userFolder);

            tenantInfoCsvPath = Path.Combine(userFolder, "TenantInfo.csv");

            if (!File.Exists(userExcel))
            {
                string defaultTenantInfo = Path.Combine(
                    AppContext.BaseDirectory,
                    "Resources",
                    "DefaultTenantInfo.csv");

                File.Copy(defaultTenantInfo, tenantInfoCsvPath);
            }
#endif
            string[] lines = File.ReadAllLines(tenantInfoCsvPath);

            foreach (string line in lines)
            {
                string[] values = line.Split(',');


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetBankStatementButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
