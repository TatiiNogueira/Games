/*
NOTAS:
Link dos Videos -> https://www.youtube.com/watch?v=hO-s_ibaIP0&list=PLcpBp05FYoeOWTtl7hwIjXnDuVqg7yHWC&index=4
A aplicação foi criado em -> Windows Forms App (.NET Framework)

Indice dos Botões:
0 1 2
3 4 5
6 7 8
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class form_Jogo_Velha : Form
    {

        //Variáveis
        int pontuacaoX = 0, pontuacaoO = 0, empates = 0, rodadas = 0;
        bool turno = true, fimJogo = false;
        //Define um array de strings com 9 posições
        string[] texto = new string[9];

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            fimJogo = false;

            //Array dos botões
            Button[] botoes = { btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9 };
            
            //Vai a todos os botões e coloca o texto vazio e coloca a cor inicial do botão
            foreach (Button btn in botoes)
            {
                btn.Text = string.Empty;
                btn.BackColor = Color.Blue;
            }

            //Limpar o array texto
            for (int i = 0; i < texto.Length; i++)
            {
                //Coloca cada elemento como uma string vazia
                texto[i] = string.Empty;
            }
        }

        public form_Jogo_Velha()
        {
            InitializeComponent();
        }

        //Método do click do botão
        private void btn_Click(object sender, EventArgs e)
        {
            //Serve para especificar o botão clicado
            //Exemplo: Se clicar no botão 1 vai ser o botão 1
            Button btn = (Button)sender;
            //Obetm o núemro definido em TabIndex, nas propriedades
            int buttonIndex = btn.TabIndex;

            //Só se o botão não estiver preenchido é que vai colocar texto
            //E não for fim de jogo
            //Caso contrario não faz nada ao botão
            if (btn.Text == "" && fimJogo == false)
            {
                //Se o turno for True é a vez do jogador X
                if (turno)
                {
                    //Texto que vai aparecer no botão
                    btn.Text = "X";
                    //Passa o turno para o jogador O
                    turno = false;
                }
                //Se o turno for False é a vez do jogador O
                else
                {
                    //Texto que vai aparecer no botão
                    btn.Text = "O";
                    //Passa o turno para o jogador X 
                    turno = true;
                }
                //Guarda o texto do botão na posição correta
                texto[buttonIndex] = btn.Text;
                //Verifica se houve alguma Vitória ou Empate
                VerificarVitoria(btn.Text);
                //Adicionado mais um valor às rodadas
                rodadas++;
            }
        }

        void VerificarVitoria(string jogador)
        {
            //Ciclo for para verificar a vitória na horizontal
            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                //Verifica se o primeiro botão tem o texto do Jogador
                if (jogador == texto[horizontal])
                {
                    //Verifica se os 3 botões da linha são iguais
                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        //Mudar a cor dos Botões da linha vencedora
                        for (int i = 0; i < 3; i++)
                        {
                            //Obter o botão
                            //Indices:
                            // 0, 3, 6
                            // 1, 4, 7
                            // 2, 5, 8
                            Button btn = ObterIndexButton(horizontal + i);
                            //Define a cor
                            btn.BackColor = Color.DeepPink;
                        }
                        Pontuacao(jogador);
                        return;
                    }
                }
            }

            //Ciclo for para verificar a vitória na vertical
            for (int vertical = 0; vertical < 3; vertical++)
            {
                //Verifica se o primeiro botão tem o texto do Jogador
                if (jogador == texto[vertical])
                {
                    //Verifica se os 3 botões da coluna são iguais
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        //Mudar a cor dos Botões da coluna vencedora
                        for (int i = 0; i < 3; i++)
                        {
                            //Obter o botão
                            //Indices:
                            // 0, 1, 2
                            // 3, 4, 5
                            // 6, 7, 8
                            Button btn = ObterIndexButton(vertical + i * 3); 
                            //Define a cor
                            btn.BackColor = Color.DeepPink;
                        }
                        Pontuacao(jogador);
                        return;
                    }
                }
            }

            //Verificação se os botões tem o mesmo texto na diagonal (da esquerda para a direita)
            if (jogador == texto[0] && texto[0] == texto[4] && texto[0] == texto[8])
            {
                //Mudar a cor dos Botões da diagonal vencedora
                for (int i = 0; i < 3; i++)
                {
                    //Obter o botão
                    //Indice:
                    // 0, 4, 8
                    Button btn = ObterIndexButton(i * 4);
                    //Define a cor
                    btn.BackColor = Color.DeepPink;
                }
                Pontuacao(jogador);
                return;
            }

            //Verificação se os botões tem o mesmo texto na diagonal (da direita para a esquerda)
            if (jogador == texto[2] && texto[2] == texto[4] && texto[2] == texto[6])
            {
                //Mudar a cor dos Botões da diagonal vencedora
                for (int i = 0; i < 3; i++)
                {
                    //Obter o botão
                    //Indice:
                    // 2, 4, 6
                    Button btn = ObterIndexButton(2 + i * 2);
                    //Define a cor
                    btn.BackColor = Color.DeepPink;
                }
                Pontuacao(jogador);
                return;
            }

            //Verificar se houve um empate
            //Verifica se todas as posições no array 'texto' estão preenchidas
            bool todosPreenchidos = texto.All(t => !string.IsNullOrEmpty(t));

            //Verifica se não há um vencedor
            if (todosPreenchidos && !fimJogo)
            {
                //Array dos botões
                Button[] botoes = { btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9 };
                //Mudar a cor dos Botões
                foreach (Button btn in botoes)
                {
                    btn.BackColor = Color.Black;
                }
                Pontuacao("Empate");
            }
        }

        //Função para obter o index do botão
        private Button ObterIndexButton(int index)
        {
            //Array dos botões
            Button[] botoes = { btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9 };
            //Retorna o index do botão
            return botoes[index];
        }

        private void Pontuacao(string jogador)
        {
            fimJogo = true;
            if (jogador == "X")
            {
                MessageBox.Show("A Vitória é do Jogador X", "Resultado do Jogo", MessageBoxButtons.OK);
                pontuacaoX++;
                lbl_PontuacaoX.Text = pontuacaoX.ToString();
            }
            else if (jogador == "O")
            {
                MessageBox.Show("A Vitória é do Jogador O", "Resultado do Jogo", MessageBoxButtons.OK);
                pontuacaoO++;
                lbl_PontuacaoO.Text = pontuacaoO.ToString();
            }
            else
            {
                MessageBox.Show("Ninguém ganhou foi um empate", "Resultado do Jogo", MessageBoxButtons.OK);
                empates++;
                lbl_Pontuacao_Empates.Text = empates.ToString();
            }
        }
    }

}
