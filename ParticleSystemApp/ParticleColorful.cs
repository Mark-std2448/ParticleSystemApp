using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystemApp
{
    public class ParticleColorful : Particle
    {
        public Color FromColor;
        public Color ToColor;

        public override void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);

            var color = MixColor(ToColor, FromColor, k);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }

        public static Color MixColor(Color color1, Color color2, float k)
        {
            return Color.FromArgb(
                (int)(color1.A * (1 - k) + color2.A * k),
                (int)(color1.R * (1 - k) + color2.R * k),
                (int)(color1.G * (1 - k) + color2.G * k),
                (int)(color1.B * (1 - k) + color2.B * k)
            );
        }
    }
}