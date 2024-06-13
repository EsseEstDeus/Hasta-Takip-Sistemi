using System;
using System.Drawing;

namespace Bil102_Grup1_FinalProject
{
    internal class FireworkParticle
    {
        public PointF Position;
        public PointF Velocity;
        public float Life;
        public Color Color;

        private static Random rand = new Random();

        public FireworkParticle(PointF position, PointF velocity, Color color)
        {
            Position = position;
            Velocity = velocity;
            Color = color;
            Life = 1.0f;
        }

        public void Update()
        {
            Position.X += Velocity.X;
            Position.Y += Velocity.Y;
            Life -= 0.02f; // Particle fades out over time
        }

        public void Draw(Graphics g)
        {
            int alpha = (int)(255 * Life);
            using (Brush brush = new SolidBrush(Color.FromArgb(alpha, Color)))
            {
                g.FillEllipse(brush, Position.X, Position.Y, 5, 5);
            }
        }

        public bool IsAlive()
        {
            return Life > 0;
        }

        public static FireworkParticle Create(PointF origin)
        {
            float angle = (float)(rand.NextDouble() * 2 * Math.PI);
            float speed = (float)(rand.NextDouble() * 4 + 1);
            PointF velocity = new PointF(
                (float)(Math.Cos(angle) * speed),
                (float)(Math.Sin(angle) * speed)
            );

            return new FireworkParticle(origin, velocity, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
        }
    }
}