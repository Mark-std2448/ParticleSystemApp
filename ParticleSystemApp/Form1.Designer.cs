namespace ParticleSystemApp
{
    partial class Form1
    {
        
        
        
        private System.ComponentModel.IContainer components = null;

        
        
        
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        
        
        
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbTeleportDirection = new System.Windows.Forms.TrackBar();
            this.lblParticlesCount = new System.Windows.Forms.Label();
            this.tbParticlesCount = new System.Windows.Forms.TrackBar();
            this.lblTeleportDirection = new System.Windows.Forms.Label();
            this.lblTeleportRadius = new System.Windows.Forms.Label();
            this.tbTeleportRadius = new System.Windows.Forms.TrackBar();
            this.lblCounterRadius = new System.Windows.Forms.Label();
            this.tbCounterRadius = new System.Windows.Forms.TrackBar();
            this.lblColorRadius = new System.Windows.Forms.Label();
            this.tbColorRadius = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleportDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticlesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleportRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCounterRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDisplay.Location = new System.Drawing.Point(0, 0);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1682, 1072);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbTeleportDirection
            // 
            this.tbTeleportDirection.Location = new System.Drawing.Point(1006, 1003);
            this.tbTeleportDirection.Maximum = 360;
            this.tbTeleportDirection.Name = "tbTeleportDirection";
            this.tbTeleportDirection.Size = new System.Drawing.Size(285, 69);
            this.tbTeleportDirection.TabIndex = 1;
            this.tbTeleportDirection.Scroll += new System.EventHandler(this.tbTeleportDirection_Scroll);
            // 
            // lblParticlesCount
            // 
            this.lblParticlesCount.AutoSize = true;
            this.lblParticlesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParticlesCount.Location = new System.Drawing.Point(1350, 975);
            this.lblParticlesCount.Name = "lblParticlesCount";
            this.lblParticlesCount.Size = new System.Drawing.Size(291, 25);
            this.lblParticlesCount.TabIndex = 2;
            this.lblParticlesCount.Text = "Количество частиц за тик: 10";
            // 
            // tbParticlesCount
            // 
            this.tbParticlesCount.Location = new System.Drawing.Point(1355, 1003);
            this.tbParticlesCount.Maximum = 50;
            this.tbParticlesCount.Minimum = 1;
            this.tbParticlesCount.Name = "tbParticlesCount";
            this.tbParticlesCount.Size = new System.Drawing.Size(267, 69);
            this.tbParticlesCount.TabIndex = 3;
            this.tbParticlesCount.Value = 10;
            this.tbParticlesCount.Scroll += new System.EventHandler(this.tbParticlesCount_Scroll);
            // 
            // lblTeleportDirection
            // 
            this.lblTeleportDirection.AutoSize = true;
            this.lblTeleportDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeleportDirection.Location = new System.Drawing.Point(1001, 975);
            this.lblTeleportDirection.Name = "lblTeleportDirection";
            this.lblTeleportDirection.Size = new System.Drawing.Size(135, 25);
            this.lblTeleportDirection.TabIndex = 4;
            this.lblTeleportDirection.Text = "Угол вылета:";
            // 
            // lblTeleportRadius
            // 
            this.lblTeleportRadius.AutoSize = true;
            this.lblTeleportRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeleportRadius.Location = new System.Drawing.Point(671, 975);
            this.lblTeleportRadius.Name = "lblTeleportRadius";
            this.lblTeleportRadius.Size = new System.Drawing.Size(215, 25);
            this.lblTeleportRadius.TabIndex = 5;
            this.lblTeleportRadius.Text = "Радиус телепорта: 40";
            // 
            // tbTeleportRadius
            // 
            this.tbTeleportRadius.Location = new System.Drawing.Point(676, 1003);
            this.tbTeleportRadius.Maximum = 100;
            this.tbTeleportRadius.Minimum = 10;
            this.tbTeleportRadius.Name = "tbTeleportRadius";
            this.tbTeleportRadius.Size = new System.Drawing.Size(284, 69);
            this.tbTeleportRadius.TabIndex = 6;
            this.tbTeleportRadius.Value = 40;
            this.tbTeleportRadius.Scroll += new System.EventHandler(this.tbRadius_Scroll);
            // 
            // lblCounterRadius
            // 
            this.lblCounterRadius.AutoSize = true;
            this.lblCounterRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounterRadius.Location = new System.Drawing.Point(344, 975);
            this.lblCounterRadius.Name = "lblCounterRadius";
            this.lblCounterRadius.Size = new System.Drawing.Size(200, 25);
            this.lblCounterRadius.TabIndex = 7;
            this.lblCounterRadius.Text = "Радиус счётчика: 50";
            // 
            // tbCounterRadius
            // 
            this.tbCounterRadius.Location = new System.Drawing.Point(349, 1003);
            this.tbCounterRadius.Maximum = 100;
            this.tbCounterRadius.Minimum = 10;
            this.tbCounterRadius.Name = "tbCounterRadius";
            this.tbCounterRadius.Size = new System.Drawing.Size(287, 69);
            this.tbCounterRadius.TabIndex = 8;
            this.tbCounterRadius.Value = 50;
            this.tbCounterRadius.Scroll += new System.EventHandler(this.tbRadius_Scroll);
            // 
            // lblColorRadius
            // 
            this.lblColorRadius.AutoSize = true;
            this.lblColorRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColorRadius.Location = new System.Drawing.Point(12, 975);
            this.lblColorRadius.Name = "lblColorRadius";
            this.lblColorRadius.Size = new System.Drawing.Size(236, 25);
            this.lblColorRadius.TabIndex = 9;
            this.lblColorRadius.Text = "Радиус окрашивания: 80";
            // 
            // tbColorRadius
            // 
            this.tbColorRadius.Location = new System.Drawing.Point(12, 1003);
            this.tbColorRadius.Maximum = 150;
            this.tbColorRadius.Minimum = 10;
            this.tbColorRadius.Name = "tbColorRadius";
            this.tbColorRadius.Size = new System.Drawing.Size(293, 69);
            this.tbColorRadius.TabIndex = 10;
            this.tbColorRadius.Value = 80;
            this.tbColorRadius.Scroll += new System.EventHandler(this.tbRadius_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 1072);
            this.Controls.Add(this.tbColorRadius);
            this.Controls.Add(this.lblColorRadius);
            this.Controls.Add(this.tbCounterRadius);
            this.Controls.Add(this.lblCounterRadius);
            this.Controls.Add(this.tbTeleportRadius);
            this.Controls.Add(this.lblTeleportRadius);
            this.Controls.Add(this.lblTeleportDirection);
            this.Controls.Add(this.tbParticlesCount);
            this.Controls.Add(this.lblParticlesCount);
            this.Controls.Add(this.tbTeleportDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleportDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticlesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleportRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCounterRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbTeleportDirection;
        private System.Windows.Forms.Label lblParticlesCount;
        private System.Windows.Forms.TrackBar tbParticlesCount;
        private System.Windows.Forms.Label lblTeleportDirection;
        private System.Windows.Forms.Label lblTeleportRadius;
        private System.Windows.Forms.TrackBar tbTeleportRadius;
        private System.Windows.Forms.Label lblCounterRadius;
        private System.Windows.Forms.TrackBar tbCounterRadius;
        private System.Windows.Forms.Label lblColorRadius;
        private System.Windows.Forms.TrackBar tbColorRadius;
    }
}

