using gyak09.Models;

namespace gyak09
{
    public partial class Form1 : Form
    {

        Models.StudentContext studentContext = new Models.StudentContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            studentBindingSource.DataSource = studentContext.Students.ToList(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception kiv�tel)
            {
                MessageBox.Show(kiv�tel.InnerException.Message);
            }
        }
    }
}