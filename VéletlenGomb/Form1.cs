namespace VéletlenGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
               

                
                int width = rnd.Next(20,50);
                int height = rnd.Next(20,50);
                int r = rnd.Next(0, 250);
                int g = rnd.Next(0,250);
                int b = rnd.Next(0, 250);
                int left = rnd.Next(ClientSize.Width - width);
                int top = rnd.Next(ClientSize.Height - height);



                Button gomb = new Button();
                gomb.Width = width; 
                gomb.Height = height;
                gomb.BackColor = Color.FromArgb(r, g, b);
                gomb.Left = left;
                gomb.Top = top;


                Controls.Add(gomb);
            }
        }
    }
}
