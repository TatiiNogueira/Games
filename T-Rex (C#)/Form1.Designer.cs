
namespace T_Rex
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.TimerGame = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Obstaculo2 = new System.Windows.Forms.PictureBox();
            this.Obstaculo1 = new System.Windows.Forms.PictureBox();
            this.Dino = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstaculo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstaculo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtScore.Location = new System.Drawing.Point(12, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(187, 27);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Pontuação: 0";
            // 
            // TimerGame
            // 
            this.TimerGame.Interval = 20;
            this.TimerGame.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Obstaculo2
            // 
            this.Obstaculo2.Image = global::T_Rex.Properties.Resources.Obstaculo2;
            this.Obstaculo2.Location = new System.Drawing.Point(488, 368);
            this.Obstaculo2.Name = "Obstaculo2";
            this.Obstaculo2.Size = new System.Drawing.Size(32, 33);
            this.Obstaculo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstaculo2.TabIndex = 3;
            this.Obstaculo2.TabStop = false;
            this.Obstaculo2.Tag = "Obstaculos";
            this.Obstaculo2.Click += new System.EventHandler(this.Obstaculo2_Click);
            // 
            // Obstaculo1
            // 
            this.Obstaculo1.Image = global::T_Rex.Properties.Resources.Obstaculo1;
            this.Obstaculo1.Location = new System.Drawing.Point(341, 355);
            this.Obstaculo1.Name = "Obstaculo1";
            this.Obstaculo1.Size = new System.Drawing.Size(23, 46);
            this.Obstaculo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstaculo1.TabIndex = 2;
            this.Obstaculo1.TabStop = false;
            this.Obstaculo1.Tag = "Obstaculos";
            this.Obstaculo1.Click += new System.EventHandler(this.Obstaculo1_Click);
            // 
            // Dino
            // 
            this.Dino.Image = global::T_Rex.Properties.Resources.Dino_Run;
            this.Dino.Location = new System.Drawing.Point(35, 358);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(40, 43);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dino.TabIndex = 1;
            this.Dino.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Obstaculo2);
            this.Controls.Add(this.Obstaculo1);
            this.Controls.Add(this.Dino);
            this.Name = "Form1";
            this.Text = "T-Rex Run";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstaculo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstaculo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.PictureBox Obstaculo1;
        private System.Windows.Forms.PictureBox Obstaculo2;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer TimerGame;
    }
}

