namespace BongcheonMonthlyRent
{
    public partial class Main_Form : Form
    {
        public MonthlyRent_Form monthlyRentForm;

        public Main_Form()
        {
            InitializeComponent();
            monthlyRentForm = new MonthlyRent_Form();
        }

        private void MonthlyRentButton_Click(object sender, EventArgs e)
        {
            monthlyRentForm.Show();
        }
    }
}
