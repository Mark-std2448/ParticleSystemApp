using System;
using System.Drawing;

namespace ParticleSystemApp
{
    public class CounterPoint : IImpactor
    {
        public float X, Y;
        public int Radius = 50;
        public int Count = 0;

        public void Impact(Particle particle)
        {
            float dX = particle.X - X;
            float dY = particle.Y - Y;
            if (Math.Sqrt(dX * dX + dY * dY) < Radius)
            {
                particle.Life = 0; 
                Count++;
            }
        }

        public void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.White, 3), X - Radius, Y - Radius, Radius * 2, Radius * 2);
            g.DrawString($"{Count}", new Font("Arial", 14), Brushes.White, X - 10, Y - 10);
        }
    }
}