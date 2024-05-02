using gyak10.Models;

namespace gyak10
{
    public partial class Form1 : Form
    {





        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            hajosContext context = new();
            Pen toll = new Pen(Color.White);
            Brush brush = new SolidBrush(Color.White);
            var stars = (from s in context.StarData select new { s.Hip, s.X, s.Y, s.Magnitude }).ToList();
            double nagyitas = 300;
            int cx = ClientRectangle.Width / 2;
            int cy = ClientRectangle.Height / 2;

            g.Clear(Color.DarkBlue);

            foreach (var star in stars)
            {

                if (star.Magnitude > 6) continue;
                if (Math.Sqrt(Math.Pow(star.X, 2) + Math.Pow(star.Y, 2)) > 1) continue;

                float x = (float)(star.X * nagyitas + cx);
                float y = (float)(star.Y * nagyitas + cy);

                double size = 20 * Math.Pow(10, star.Magnitude / -2.5);

                g.FillEllipse(brush, x, y, (float)size, (float)size);


            }

            var lines = context.ConstellationLines.ToList();

            foreach (var line in lines)
            {
                var star1 = from x in context.StarData
                            where x.Hip == line.Star1
                            select x;


            }





        }
    }
}