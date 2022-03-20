
namespace Flappy_Fish
{
    partial class FlappyFish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.score1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Restart = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Fish = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(3, 13);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(222, 59);
            this.score1.TabIndex = 4;
            this.score1.Text = "Score: 0 ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Restart.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Restart.Location = new System.Drawing.Point(65, 395);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(247, 113);
            this.Restart.TabIndex = 5;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(345, 395);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(247, 113);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::Flappy_Fish.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-14, 807);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(738, 112);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            // 
            // Fish
            // 
            this.Fish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Fish.Image = global::Flappy_Fish.Properties.Resources.bird;
            this.Fish.Location = new System.Drawing.Point(46, 288);
            this.Fish.Name = "Fish";
            this.Fish.Size = new System.Drawing.Size(68, 51);
            this.Fish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fish.TabIndex = 1;
            this.Fish.TabStop = false;
            // 
            // PipeBottom
            // 
            this.PipeBottom.Image = global::Flappy_Fish.Properties.Resources.pipe;
            this.PipeBottom.Location = new System.Drawing.Point(563, 543);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(118, 364);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 3;
            this.PipeBottom.TabStop = false;
            this.PipeBottom.Click += new System.EventHandler(this.GameTimerEvent);
            // 
            // PipeTop
            // 
            this.PipeTop.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop.Image = global::Flappy_Fish.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(563, -14);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(118, 353);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            // 
            // FlappyFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(693, 907);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Fish);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.PipeTop);
            this.Name = "FlappyFish";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyFish_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyFish_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox Fish;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button ExitButton;
    }
}

