using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystemApp
{
    public class Emitter
    {
        public List<Particle> particles = new List<Particle>();
        public int X;
        public int Y;
        public int Direction = 0;
        public int Spreading = 360;
        public int SpeedMin = 1;
        public int SpeedMax = 10;
        public int RadiusMin = 2;
        public int RadiusMax = 10;
        public int LifeMin = 20;
        public int LifeMax = 100;

        public void UpdateState()
        {
            int particlesToCreate = 10;

            for (int i = 0; i < particles.Count; i++)
            {
                var particle = particles[i];
                particle.Life -= 1;

                if (particle.Life < 0)
                {
                    particles.RemoveAt(i);
                    i--;
                }
                else
                {
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }

            while (particlesToCreate > 0)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                particle.X = X;
                particle.Y = Y;
                particles.Add(particle);
            }
        }

        public virtual Particle CreateParticle()
        {
            var particle = new Particle();
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);

            var speed = Particle.rand.Next(SpeedMin, SpeedMax);
            var direction = Direction + (double)Particle.rand.Next(Spreading) - Spreading / 2;

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = (float)-(Math.Sin(direction / 180 * Math.PI) * speed);

            return particle;
        }

        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }
    }
}