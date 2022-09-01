'p -> São Peças Pretas
'b -> São as Peças Brancas

Public Class Form1
    'Variáveis do Tabuleiro
    Private tabuleiro As Tabuleiro = New Tabuleiro
    Public controler As Contrulador = New Contrulador
    Dim pecas As New Pecas

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lista das Peças do Jogo
        Lista_Pecas = {Peao1p, Peao2p, Peao3p, Peao4p, Peao5p, Peao6p, Peao7p, Peao8p,
            Peao1b, Peao2b, Peao3b, Peao4b, Peao5b, Peao6b, Peao7b, Peao8b,
            Torre1p, Torre2p, Torre1b, Torre2b, Cavalo1p, Cavalo2p, Cavalo1b, Cavalo2b,
            Bispo1p, Bispo2p, Bispo1b, Bispo2b, Reip, Reib, Rainhap, Rainhab}

        posicao_inicial_pecas()
        tabuleiro.Criar()
    End Sub

    'Funçao onde é indicado a posição inicial das peças
    Private Sub posicao_inicial_pecas()
        'Peões Pretos
        pecas.Peao1p.Posicao(Peao1p, 0, 1, "p")
        pecas.Peao2p.Posicao(Peao2p, 1, 1, "p")
        pecas.Peao3p.Posicao(Peao3p, 2, 1, "p")
        pecas.Peao4p.Posicao(Peao4p, 3, 1, "p")
        pecas.Peao5p.Posicao(Peao5p, 4, 1, "p")
        pecas.Peao6p.Posicao(Peao6p, 5, 1, "p")
        pecas.Peao7p.Posicao(Peao7p, 6, 1, "p")
        pecas.Peao8p.Posicao(Peao8p, 7, 1, "p")
        'Peões Brancos
        pecas.Peao1b.Posicao(Peao1b, 0, 6, "b")
        pecas.Peao2b.Posicao(Peao2b, 1, 6, "b")
        pecas.Peao3b.Posicao(Peao3b, 2, 6, "b")
        pecas.Peao4b.Posicao(Peao4b, 3, 6, "b")
        pecas.Peao5b.Posicao(Peao5b, 4, 6, "b")
        pecas.Peao6b.Posicao(Peao6b, 5, 6, "b")
        pecas.Peao7b.Posicao(Peao7b, 6, 6, "b")
        pecas.Peao8b.Posicao(Peao8b, 7, 6, "b")

        'Torres Pretas
        pecas.Torre1p.Posicao(Torre1p, 0, 0, "p")
        pecas.Torre2p.Posicao(Torre2p, 7, 0, "p")
        'Torres Brancas
        pecas.Torre1b.Posicao(Torre1b, 0, 7, "b")
        pecas.Torre2b.Posicao(Torre2b, 7, 7, "b")


        'Cavalos Pretos
        pecas.Cavalo1p.Posicao(Cavalo1p, 1, 0, "p")
        pecas.Cavalo2p.Posicao(Cavalo2p, 6, 0, "p")
        'Cavalos Brancos
        pecas.Cavalo1b.Posicao(Cavalo1b, 1, 7, "b")
        pecas.Cavalo2b.Posicao(Cavalo2b, 6, 7, "b")

        'Bispos Pretos
        pecas.Bispo1p.Posicao(Bispo1p, 2, 0, "p")
        pecas.Bispo2p.Posicao(Bispo2p, 5, 0, "p")
        'Bispos Brancos
        pecas.Bispo1b.Posicao(Bispo1b, 2, 7, "b")
        pecas.Bispo2b.Posicao(Bispo2b, 5, 7, "b")

        'Rei Preto
        pecas.Reip.Posicao(Reip, 4, 0, "p")
        'Rei Branco
        pecas.Reib.Posicao(Reib, 4, 7, "b")

        'Rainha Preta
        pecas.Rainhap.Posicao(Rainhap, 3, 0, "p")
        'Rainha Branca
        pecas.Rainhab.Posicao(Rainhab, 3, 7, "b")
    End Sub

    Private Sub btn_Partida_Click(sender As Object, e As EventArgs) Handles btn_Partida.Click
        If btn_Partida.Text = "Finalizar Partida" Then
            posicao_inicial_pecas()
            finalizar()
            'Coloca o botão da Pausa a dizer Pausa
            'Pois se clicarmos em Pausa e depois Terminar Partida
            'O botão vai ficar como se estive se em Pausa
            btn_Pausa.Text = "Pausa"
        Else
            iniciar()
        End If
    End Sub

    'Botões
    Private Sub btn_Pausa_Click(sender As Object, e As EventArgs) Handles btn_Pausa.Click
        pausa_continuar()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        marcar_tempo()
    End Sub

    Private Sub btn_Novo_Jogo_Click(sender As Object, e As EventArgs) Handles btn_Novo_Jogo.Click
        mudar_jogadores()
    End Sub

    Private Sub btn_Limpar_Resultados_Click(sender As Object, e As EventArgs) Handles btn_Limpar_Resultados.Click
        novos_resultados()
    End Sub

    Private Sub Torre1p_Click(sender As Object, e As EventArgs) Handles Torre1p.Click
        controler.click_torre(pecas.Torre1p)
    End Sub

    Private Sub Peao1p_Click(sender As Object, e As EventArgs) Handles Peao1p.Click
        controler.click_peao(pecas.Peao1p)
    End Sub

    Private Sub Cavalo1p_Click(sender As Object, e As EventArgs) Handles Cavalo1p.Click
        controler.click_cavalo(pecas.Cavalo1p)
    End Sub

    Private Sub Peao1b_Click(sender As Object, e As EventArgs) Handles Peao1b.Click
        controler.click_peao(pecas.Peao1b)
    End Sub

    Private Sub Cavalo2p_Click(sender As Object, e As EventArgs) Handles Cavalo2p.Click
        controler.click_cavalo(pecas.Cavalo2p)
    End Sub

    Private Sub Cavalo1b_Click(sender As Object, e As EventArgs) Handles Cavalo1b.Click
        controler.click_cavalo(pecas.Cavalo1b)
    End Sub

    Private Sub Cavalo2b_Click(sender As Object, e As EventArgs) Handles Cavalo2b.Click
        controler.click_cavalo(pecas.Cavalo2b)
    End Sub

    Private Sub Torre2p_Click(sender As Object, e As EventArgs) Handles Torre2p.Click
        controler.click_torre(pecas.Torre2p)
    End Sub

    Private Sub Torre1b_Click(sender As Object, e As EventArgs) Handles Torre1b.Click
        controler.click_torre(pecas.Torre1b)
    End Sub

    Private Sub Torre2b_Click(sender As Object, e As EventArgs) Handles Torre2b.Click
        controler.click_torre(pecas.Torre2b)
    End Sub

    Private Sub Peao2p_Click(sender As Object, e As EventArgs) Handles Peao2p.Click
        controler.click_peao(pecas.Peao2p)
    End Sub

    Private Sub Peao3p_Click(sender As Object, e As EventArgs) Handles Peao3p.Click
        controler.click_peao(pecas.Peao3p)
    End Sub

    Private Sub Peao4p_Click(sender As Object, e As EventArgs) Handles Peao4p.Click
        controler.click_peao(pecas.Peao4p)
    End Sub

    Private Sub Peao5p_Click(sender As Object, e As EventArgs) Handles Peao5p.Click
        controler.click_peao(pecas.Peao5p)
    End Sub

    Private Sub Peao6p_Click(sender As Object, e As EventArgs) Handles Peao6p.Click
        controler.click_peao(pecas.Peao6p)
    End Sub

    Private Sub Peao7p_Click(sender As Object, e As EventArgs) Handles Peao7p.Click
        controler.click_peao(pecas.Peao7p)
    End Sub

    Private Sub Peao8p_Click(sender As Object, e As EventArgs) Handles Peao8p.Click
        controler.click_peao(pecas.Peao8p)
    End Sub

    Private Sub Peao2b_Click(sender As Object, e As EventArgs) Handles Peao2b.Click
        controler.click_peao(pecas.Peao2b)
    End Sub

    Private Sub Peao3b_Click(sender As Object, e As EventArgs) Handles Peao3b.Click
        controler.click_peao(pecas.Peao3b)
    End Sub

    Private Sub Peao4b_Click(sender As Object, e As EventArgs) Handles Peao4b.Click
        controler.click_peao(pecas.Peao4b)
    End Sub

    Private Sub Peao5b_Click(sender As Object, e As EventArgs) Handles Peao5b.Click
        controler.click_peao(pecas.Peao5b)
    End Sub

    Private Sub Peao6b_Click(sender As Object, e As EventArgs) Handles Peao6b.Click
        controler.click_peao(pecas.Peao6b)
    End Sub

    Private Sub Peao7b_Click(sender As Object, e As EventArgs) Handles Peao7b.Click
        controler.click_peao(pecas.Peao7b)
    End Sub

    Private Sub Peao8b_Click(sender As Object, e As EventArgs) Handles Peao8b.Click
        controler.click_peao(pecas.Peao8b)
    End Sub

    Private Sub Bispo1p_Click(sender As Object, e As EventArgs) Handles Bispo1p.Click
        controler.click_bispo(pecas.Bispo1p)
    End Sub

    Private Sub Bispo2p_Click(sender As Object, e As EventArgs) Handles Bispo2p.Click
        controler.click_bispo(pecas.Bispo2p)
    End Sub

    Private Sub Bispo1b_Click(sender As Object, e As EventArgs) Handles Bispo1b.Click
        controler.click_bispo(pecas.Bispo1b)
    End Sub

    Private Sub Bispo2b_Click(sender As Object, e As EventArgs) Handles Bispo2b.Click
        controler.click_bispo(pecas.Bispo2b)
    End Sub

    Private Sub Reip_Click(sender As Object, e As EventArgs) Handles Reip.Click
        controler.click_rei(pecas.Reip)
    End Sub

    Private Sub Reib_Click(sender As Object, e As EventArgs) Handles Reib.Click
        controler.click_rei(pecas.Reib)
    End Sub

    Private Sub Rainhap_Click(sender As Object, e As EventArgs) Handles Rainhap.Click
        controler.click_rainha(pecas.Rainhap)
    End Sub

    Private Sub Rainhab_Click(sender As Object, e As EventArgs) Handles Rainhab.Click
        controler.click_rainha(pecas.Rainhab)
    End Sub
End Class
