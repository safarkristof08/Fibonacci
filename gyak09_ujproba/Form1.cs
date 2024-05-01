using gyak09_ujproba.Models;

namespace gyak09_ujproba
{

    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();
        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = studentContext.Students.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception kivétel)
            {
                MessageBox.Show(kivétel.InnerException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
