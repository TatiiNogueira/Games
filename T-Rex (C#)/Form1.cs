using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Rex
{
    public partial class Form1 : Form
    {

        //Variaveis
        //bool - boliano - True ou False
        bool Saltar = false;
        int VelocidadeSalto;
        int Forca = 13;
        int score = 0;
        int VelocidadeObstaculo = 10;
        //Gerar um número aleatório entre um número nímino e um número máximo
        Random rand = new Random();
        int Posicao;
        bool isGameOver = false;

        //Função padrão que vem com o formulário do Windows(form)
        public Form1()
        {
            InitializeComponent();

            //Vincular função de redefinição do jogo
            //Sempre que o jogo for inicializado vai carregar a função
            GameReset();
        }

        //Temporizador do Jogo
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Dino.Top += VelocidadeSalto;
            //Pontuação
            txtScore.Text = "Pontuação: " + score;

            //Se saltar e a força for menor do que 0
            //Zero é o limite de saltos que o Boneco
            //Pode dar
            if (Saltar == true && Forca < 0)
            {
                Saltar = false;
            }
            //Se saltar envia o Dino para cima
            if (Saltar == true)
            {
                VelocidadeSalto = -13;
                //Reduzimos 1 da velocidade
                Forca -= 1;
            }
            //Quando o salto for False
            //a velocidade vai ser a indicada abaixo
            //O jogador começa a descer em direção à plataforma
            else
            {
                VelocidadeSalto = 13;
            }

            //A Forca é como se fosse a altura
            if (Dino.Top > 357  && Saltar == false)
            {
                Forca = 13;
                Dino.Top = 358;
                //Como a Velocidade será zero não há mais necessidade de empurrar o jogador para baixo
                VelocidadeSalto = 0;
            }

            //Obstáculos
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Obstaculos")
                {
                    x.Left -= VelocidadeObstaculo;
                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    //Quando o Dino bater nos obstáculos é GameOver
                    if (Dino.Bounds.IntersectsWith(x.Bounds))
                    {
                        TimerGame.Stop();
                        //Substitui o Dino pelo Dino morto
                        Dino.Image = Properties.Resources.Game_Over;
                        txtScore.Text += " Clique r para recomeçar o jogo!";
                        isGameOver = true;
                    }
                }
            }

            //Alterar a velocidade consoante a a pontuação
            if (score > 15)
            {
                VelocidadeObstaculo = 15;
            }
            if (score > 50)
            {
                VelocidadeObstaculo = 20;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //Se clicarmos mno espaço e Saltar for falso
            //Só queremos saltar quando não estivermos a saltar
            if (e.KeyCode == Keys.Space && Saltar == false)
            {
                Saltar = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (Saltar == true) 
            {
                Saltar = false;
            }
            //Se clicarmos na tecla R e for GameOver o jogo irá recomeçar
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        //Função Redefinir Jogo
        private void GameReset()
        {
            Forca = 13;
            VelocidadeSalto = 0;
            Saltar = false;
            score = 0;
            VelocidadeObstaculo = 10;
            txtScore.Text = "Pontuação: " + score;
            Dino.Image = Properties.Resources.Dino_Run;
            isGameOver = false;
            //Posição y do T-Rex
            Dino.Top = 358;

            //Um para cada
            foreach (Control x in this.Controls)
            {
                //Se o x for uma PictureBox e corresponder a um obstáculo
                if (x is  PictureBox && (string)x.Tag == "Obstaculos")
                {
                    //Coloca o Obstáculo numa posição aleatório
                    Posicao = this.ClientSize.Width + rand.Next(10, 100) + (x.Width * 10);
                    x.Left = Posicao;
                }
            }
            //Inicar o cronómetro do jogo
            TimerGame.Start();
        }

        private void Obstaculo1_Click(object sender, EventArgs e)
        {

        }

        private void Obstaculo2_Click(object sender, EventArgs e)
        {

        }
    }
}
