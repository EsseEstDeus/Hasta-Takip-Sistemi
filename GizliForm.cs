using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bil102_Grup1_FinalProject
{
    public partial class GizliForm : Form
    {
        List<FireworkParticle> particles = new List<FireworkParticle>();
        Timer animationTimer;

        public GizliForm()
        {
            InitializeComponent();
            SetUp();
        }

        private void SetUp()
        {
            this.BackColor = Color.Black;
            this.Paint += FormPaintEvent;
            this.MouseDown += FormMouseDown;

            animationTimer = new Timer();
            animationTimer.Interval = 20;
            animationTimer.Tick += AnimationTimerEvent;
            animationTimer.Start();
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                particles.Add(FireworkParticle.Create(new PointF(e.X, e.Y)));
            }
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            foreach (FireworkParticle particle in particles.ToList())
            {
                particle.Draw(e.Graphics);
            }
        }

        private void AnimationTimerEvent(object sender, EventArgs e)
        {
            foreach (FireworkParticle particle in particles.ToList())
            {
                particle.Update();
                if (!particle.IsAlive())
                {
                    particles.Remove(particle);
                }
            }
            this.Invalidate();
        }

        private void GizliForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}