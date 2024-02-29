namespace SzámolóGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int méret = 20;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {

                    SzámolóGomb b = new SzámolóGomb();
                    b.Top = sor * méret;
                    b.Left = oszlop * méret;
                    Controls.Add(b);
                }
            }
            
        }
    }
}