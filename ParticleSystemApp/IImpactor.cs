using System.Drawing;

namespace ParticleSystemApp
{
    public interface IImpactor
    {
        void Impact(Particle particle);
        void Render(Graphics g);
    }
}