using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParticleSystemApp
{
    public partial class Form1 : Form
    {
        Emitter emitter = new Emitter();

        TeleportPoint teleport = new TeleportPoint { X = 300, Y = 350, TargetX = 500, TargetY = 500 };

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
                    Y = 150 + (float)Math.Sin(i) * 40,
                    Color = colors[i],
                    Radius = 40
                });
            }

            emitter.impactors.Add(teleport);

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
            if (ModifierKeys == Keys.Control)
            {
                if (e.Button == MouseButtons.Left)
                {
                    teleport.X = e.X;
                    teleport.Y = e.Y;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    teleport.TargetX = e.X;
                    teleport.TargetY = e.Y;
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    int startRadius = tbCounterRadius != null ? tbCounterRadius.Value : 50;
                    emitter.impactors.Add(new CounterPoint { X = e.X, Y = e.Y, Radius = startRadius });
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
        }

        private void tbParticlesCount_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbParticlesCount.Value;
            if (lblParticlesCount != null) lblParticlesCount.Text = $"Частиц за тик: {tbParticlesCount.Value}";
        }

        private void tbTeleportDirection_Scroll(object sender, EventArgs e)
        {
            teleport.SpawnDirection = tbTeleportDirection.Value;
            if (lblTeleportDirection != null) lblTeleportDirection.Text = $"Вылет из ТП: {tbTeleportDirection.Value}°";
        }

        private void tbRadius_Scroll(object sender, EventArgs e)
        {
            if (tbTeleportRadius != null && lblTeleportRadius != null)
            {
                teleport.Radius = tbTeleportRadius.Value;
                lblTeleportRadius.Text = $"Радиус телепорта: {tbTeleportRadius.Value}";
            }

            if (tbCounterRadius != null && lblCounterRadius != null)
            {
                lblCounterRadius.Text = $"Радиус счетчика: {tbCounterRadius.Value}";
            }

            if (tbColorRadius != null && lblColorRadius != null)
            {
                lblColorRadius.Text = $"Радиус окрашивания: {tbColorRadius.Value}";
                foreach (var imp in emitter.impactors)
                {
                    if (imp is ColorPoint cp) cp.Radius = tbColorRadius.Value;
                }
            }
        }
    }
}