using System;
using System.Drawing;

namespace ParticleSystemApp
{
    public class TeleportPoint : IImpactor
    {
        public float X; 
        public float Y; 
        public float TargetX = 500; 
        public float TargetY = 400; 
        public int Radius = 40;

        public void Impact(Particle particle)
        {
            float dX = particle.X - X;
            float dY = particle.Y - Y;
            double dist = Math.Sqrt(dX * dX + dY * dY);

            
            if (dist < Radius)
            {
                particle.X = TargetX;
                particle.Y = TargetY;
            }
        }

        public void Render(Graphics g)
        {
            
            g.DrawEllipse(new Pen(Color.DeepSkyBlue, 2), X - Radius, Y - Radius, Radius * 2, Radius * 2);
            g.FillEllipse(new SolidBrush(Color.FromArgb(30, Color.DeepSkyBlue)), X - Radius, Y - Radius, Radius * 2, Radius * 2);

            
            g.DrawEllipse(new Pen(Color.Lime, 2), TargetX - 15, TargetY - 15, 30, 30);
        }
    }
}