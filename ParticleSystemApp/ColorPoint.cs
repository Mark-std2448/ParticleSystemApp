using System;
using System.Drawing;

namespace ParticleSystemApp
{
    public class ColorPoint : IImpactor
    {
        public float X, Y;
        public int Radius = 80;
        public Color Color = Color.Red;

        public void Impact(Particle particle)
        {
            float dX = particle.X - X;
            float dY = particle.Y - Y;
            double dist = Math.Sqrt(dX * dX + dY * dY);

            if (dist < Radius && particle is ParticleColorful p)
            {
                p.FromColor = Color; 
            }
        }

        public void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color, 2), X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }
}