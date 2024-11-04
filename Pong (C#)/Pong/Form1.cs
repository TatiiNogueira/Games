/*
Link do Video -> https://www.youtube.com/watch?v=d3SMWDPGQyw

Cada vez que o evento do Timer é chamado executa uma iteração
*/

using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class Jogo_Pong : Form
    {
        //Velocidade da Bola
        int velocidadeBolaX = 4;
        int velocidadeBolaY = 4;
        //Velocidade Base
        int velocidade = 2;
        //Gerar um valor aleatório
        Random random = new Random();
        //Definir movimento da Bola
        bool goDown, goUp;
        //Alterar a velocidade do computador
        int alteracaoVelocidadeComputador = 50;
        //Pontuações
        int pontuacaoJogador = 0;
        int pontuacaoComputador = 0;
        //Velocidade do Jogador
        int velocidadeJogador = 8;
        //Arrays
        int[] i = { 5, 6, 8, 9 };
        int[] j = { 10, 9, 8, 11, 12 };

        public Jogo_Pong()
        {
            InitializeComponent();
        }

        // Evento do temporizador que atualiza a posição da bola
        // e a pontuação do jogador e do computador
        private void GameTimerEvent(object sender, EventArgs e)
        {
            // Atualiza a posição vertical (Top) da bola, de acordo com a velocidade no eixo Y
            Bola.Top -= velocidadeBolaY;
            // Atualiza a posição horizontal (Left) da bola, de acordo com a velocidade no eixo X
            Bola.Left -= velocidadeBolaX;
            //Atualiza o texto das pontuações
            this.Text = $"Pontuação Jogador: {pontuacaoJogador} Vs Pontuação Computador: {pontuacaoComputador}";

            //Verificação se a bola colide com as margens superior ou inferior da janela do jogo
            if (Bola.Top < 0 || Bola.Bottom > this.ClientSize.Height)
            {
                //Inverte a direção da bola no eixo Y ao bater nas margens superior ou inferior
                velocidadeBolaY = -velocidadeBolaY;
            }

            //Verificação se a bola ultrapassou a margem esquerda (ponto para o computador)
            if (Bola.Left < -2)
            {
                ResetarBola();
                pontuacaoComputador++;
            }

            //Verificação se a bola ultrapassou a margem direita (ponto para o jogador)
            if (Bola.Right > this.ClientSize.Width + 2)
            {
                ResetarBola();
                pontuacaoJogador++;
            }

            //Verificação se o PaddleB ultrapassou o limite superior da área de jogo.
            // Se a posição superior do PaddleB for menor que 1 (ou seja, está a sair do jogo),
            // redefine a sua posição para 0 para mantê-lo dentro da área de jogo.
            if (PaddleB.Top <= 1)
            {
                PaddleB.Top = 0;
            }
            //Verificação se o PaddleB ultrapassou o limite inferior da área de jogo.
            // Se a borda inferior do PaddleB for maior ou igual à altura da área de jogo,
            // reposiciona o PaddleB para o limite inferior permitido.
            else if (PaddleB.Bottom >= this.ClientSize.Height)
            {
                PaddleB.Top = this.ClientSize.Height - PaddleB.Height;
            }

            //Verificação se a bola está acima do centro do PaddleB e posicionada à direita do campo,
            if (Bola.Top < PaddleB.Top + (PaddleB.Height / 2) && Bola.Left > 300)
            {
                //Movimenta o PaddleB para cima para seguir a posição da bola.
                PaddleB.Top -= velocidade;
            }

            //Verificação se a bola está abaixo do centro do PaddleB e posicionada à direita do campo,
            if (Bola.Top > PaddleB.Top + (PaddleB.Height / 2) && Bola.Left > 300)
            {
                //Movimenta o PaddleB para baixo para seguir a posição da bola.
                PaddleB.Top += velocidade;
            }

            //Diminiu  velocidade do computador a cada vez que o iteração do temporizador
            alteracaoVelocidadeComputador -= 1;

            // Verificação se o contador chegou a zero ou menos, indicando que é hora de alterar a velocidade do PaddleB.
            if (alteracaoVelocidadeComputador < 0)
            {
                //Escolhe um valor aleatório do array para a velocidade
                velocidade = i[random.Next(i.Length)];
                // Reinicia o contador para que a próxima alteração de velocidade ocorra após 50 iterações.
                alteracaoVelocidadeComputador = 50;
            }

            //Verificação se a tecla para baixo foi pressionada
            //e se o paddle ainda se encontra dentro do limite inferior do jogo
            if (goDown && PaddleA.Top + PaddleA.Height < this.ClientSize.Height)
            {
                //Move o PaddleA para baixo coma velocidade indicada
                PaddleA.Top += velocidadeJogador;
            }

            //Verificação se a tecla para cima foi pressionada
            // e se o PaddleA está a cima do limite do jogo
            if (goUp && PaddleA.Top > 0)
            {
                //Move o PaddleA para cima coma velocidade indicada
                PaddleA.Top -= velocidadeJogador;
            }

            //Chamar a função para verificar se existir a colisão da bola com um paddle
            VerificarColisao(Bola, PaddleA, PaddleA.Right + 5);
            VerificarColisao(Bola, PaddleB, PaddleB.Left - 35);

            //Quando alguém cheagr a 5 pontos ganha o jogo
            if (pontuacaoJogador == 5)
            {
                GameOver("Conseguis te vencer o BOT, PARABÉNS");
            }
            else if (pontuacaoComputador == 5)
            {
                GameOver("O BOT ganhou te! Tenta novamente");
            }
        }

        //Método para verificar se a tecla está pressionada
        private void TeclaPressionada(object sender, KeyEventArgs e)
        {
            //Verifica se a tecla para Baixo está pressionada
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            //Verifica se a tecla para cima está pressionada
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }

        //Método para verificar se a tecla não está pressionada
        private void TeclaSolta(object sender, KeyEventArgs e)
        {
            //Verifica se a tecla para Baixo não está pressionada
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            //Verifica se a tecla para cima não está pressionada
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        //Método que faz a verificação da colisão entre as PictureBoxes
        //O deslocamento é a posição para onde a bola será movida se houver uma colisão
        private void VerificarColisao(PictureBox bola, PictureBox paddle, int deslocamento)
        {
            //Verifica se os limites da bola intersectam com os limites do paddle
            if (bola.Bounds.IntersectsWith(paddle.Bounds))
            {
                //Move a bola para a posição especificada pelo deslocamento
                bola.Left = deslocamento;

                //Seleciona aleatoriamente um novo valor para a velocidade em X a partir do array j
                int novaVelocidadeX = j[random.Next(j.Length)];
                //Seleciona aleatoriamente um novo valor para a velocidade em Ys a partir do array j
                int novaVelocidadeY = j[random.Next(j.Length)];

                //Atualização da velocidade da bola em X
                if (velocidadeBolaX < 0)
                {
                    //Se a velocidade atual for negativa, define a nova velocidade positiva
                    velocidadeBolaX = novaVelocidadeX;
                }
                else
                {
                    //Se a velocidade atual for positiva, inverte a velocidade para negativa
                    velocidadeBolaX = -novaVelocidadeX;
                }
                //Atualização da velocidade da bola em Y
                if (velocidadeBolaY < 0)
                {
                    //Se a volicidade atual for negativa, inverte
                    velocidadeBolaY = -novaVelocidadeY;
                }
                else
                {
                    //Se a velocidade for positiva, define a nova velocidade para positiva
                    velocidadeBolaY = novaVelocidadeY;
                }
            }
        }

        //Método responsavel por reiniciar o jogo
        private void GameOver(string mensagem)
        {
            //O temporizador do jogo é terminado, pausando todas as atualizações
            GameTimer.Stop();
            //Mostra uma mensagem de fim de jogo ao jogador
            MessageBox.Show(mensagem, "Perdeste");
            //Reinicia a pontuação, colocando a 0
            pontuacaoComputador = 0;
            pontuacaoJogador = 0;
            //Define a velocidade da bola no eixo X para a velocidadeatual de Y - 4
            velocidadeBolaX = velocidadeBolaY - 4;
            // Ajusta a velocidade de reação do paddle do computador para o valor padrão
            alteracaoVelocidadeComputador = 50;
            //O temporizador do nogo é inicializado, começando assim um novo jogo
            GameTimer.Start();
        }

        //Função para colocar a bola no centro e inverter a direção no eixo X
        private void ResetarBola()
        {
            // Coloca a bola no centro do campo
            Bola.Left = 300;

            // Inverte a direção horizontal da bola
            velocidadeBolaX = -velocidadeBolaX;
        }
    }
}