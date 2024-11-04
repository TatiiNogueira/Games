namespace Pong
{
    partial class Jogo_Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo_Pong));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Bola = new System.Windows.Forms.PictureBox();
            this.PaddleB = new System.Windows.Forms.PictureBox();
            this.PaddleA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddleB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddleA)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Bola
            // 
            this.Bola.Image = global::Pong.Properties.Resources.Bola;
            this.Bola.Location = new System.Drawing.Point(380, 210);
            this.Bola.Name = "Bola";
            this.Bola.Size = new System.Drawing.Size(30, 30);
            this.Bola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bola.TabIndex = 3;
            this.Bola.TabStop = false;
            // 
            // PaddleB
            // 
            this.PaddleB.Image = global::Pong.Properties.Resources.PaddleB;
            this.PaddleB.Location = new System.Drawing.Point(722, 142);
            this.PaddleB.Name = "PaddleB";
            this.PaddleB.Size = new System.Drawing.Size(30, 139);
            this.PaddleB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PaddleB.TabIndex = 2;
            this.PaddleB.TabStop = false;
            // 
            // PaddleA
            // 
            this.PaddleA.Image = global::Pong.Properties.Resources.Paddle;
            this.PaddleA.Location = new System.Drawing.Point(12, 142);
            this.PaddleA.Name = "PaddleA";
            this.PaddleA.Size = new System.Drawing.Size(30, 139);
            this.PaddleA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PaddleA.TabIndex = 0;
            this.PaddleA.TabStop = false;
            // 
            // Jogo_Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(764, 406);
            this.Controls.Add(this.Bola);
            this.Controls.Add(this.PaddleB);
            this.Controls.Add(this.PaddleA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jogo_Pong";
            this.Text = "Jogo do Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPressionada);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TeclaSolta);
            ((System.ComponentModel.ISupportInitialize)(this.Bola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddleB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddleA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PaddleA;
        private System.Windows.Forms.PictureBox PaddleB;
        private System.Windows.Forms.PictureBox Bola;
        private System.Windows.Forms.Timer GameTimer;
    }
}

