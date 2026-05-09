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
            emitter.Y = 20;
            emitter.Direction = 270; 
            emitter.Spreading = 70;  

            
            Color[] colors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Purple };

            for (int i = 0; i < colors.Length; i++)
            {
                emitter.impactors.Add(new ColorPoint
                {
                    X = 60 + i * (picDisplay.Width / colors.Length),
                    Y = 200 + (float)Math.Sin(i) * 40, 
                    Color = colors[i],
                    Radius = 40
                });
            }

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
            
            else if (e.Button == MouseButtons.Right)
            {
                
                for (int i = emitter.impactors.Count - 1; i >= 0; i--)
                {
                    var imp = emitter.impactors[i];
                    if (imp is CounterPoint cp)
                    {
                        
                        float dX = e.X - cp.X;
                        float dY = e.Y - cp.Y;
                        if (Math.Sqrt(dX * dX + dY * dY) < cp.Radius)
                        {
                            emitter.impactors.RemoveAt(i);
                            break; 
                        }
                    }
                }
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