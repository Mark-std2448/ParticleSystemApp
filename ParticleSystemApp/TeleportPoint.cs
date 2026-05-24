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

        public int SpawnDirection = 270; 

        public void Impact(Particle particle)
        {
            float dX = particle.X - X;
            float dY = particle.Y - Y;
            double dist = Math.Sqrt(dX * dX + dY * dY);

            if (dist < Radius)
            {
                particle.X = TargetX + dX;
                particle.Y = TargetY + dY;

                float currentSpeed = (float)Math.Sqrt(particle.SpeedX * particle.SpeedX + particle.SpeedY * particle.SpeedY);
                double rad = SpawnDirection * Math.PI / 180.0;
                
                particle.SpeedX = (float)(Math.Cos(rad) * currentSpeed);
                particle.SpeedY = (float)-(Math.Sin(rad) * currentSpeed);
            }
        }

        public void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.DeepSkyBlue, 2), X - Radius, Y - Radius, Radius * 2, Radius * 2);
            g.FillEllipse(new SolidBrush(Color.FromArgb(30, Color.DeepSkyBlue)), X - Radius, Y - Radius, Radius * 2, Radius * 2);

            g.DrawEllipse(new Pen(Color.Lime, 2), TargetX - Radius, TargetY - Radius, Radius * 2, Radius * 2);
            g.FillEllipse(new SolidBrush(Color.FromArgb(30, Color.Lime)), TargetX - Radius, TargetY - Radius, Radius * 2, Radius * 2);
            
            double rad = SpawnDirection * Math.PI / 180.0;
            float lineX = TargetX + (float)(Math.Cos(rad) * Radius);
            float lineY = TargetY - (float)(Math.Sin(rad) * Radius);
            g.DrawLine(new Pen(Color.Lime, 2), TargetX, TargetY, lineX, lineY);
        }
    }
}