using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParticleSystemApp
{
    public partial class Form1 : Form
    {
        Emitter emitter = new Emitter();

        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            emitter.X = picDisplay.Width / 2;
            emitter.Y = picDisplay.Height / 2;

            
            emitter.impactors.Add(new ColorPoint { X = 200, Y = 200, Color = Color.Yellow });

            picDisplay.MouseClick += picDisplay_MouseClick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                emitter.impactors.Add(new CounterPoint { X = e.X, Y = e.Y });
            }
        }

        private void tbRadius_Scroll(object sender, EventArgs e)
        {
            foreach (var imp in emitter.impactors)
            {
                if (imp is ColorPoint cp) cp.Radius = tbRadius.Value;
                if (imp is CounterPoint cnt) cnt.Radius = tbRadius.Value;
            }
        }
    }
}