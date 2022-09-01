Module Jogo
    Public Sub finalizar()
        pausa_continuar()
        partida = False
        Form1.btn_Partida.Text = "Nova Partida"
        If vitorias_jogador_1 > 0 Or vitorias_jogador_2 > 0 Then
            Form1.btn_Limpar_Resultados.Visible = True
        End If
        Form1.mostrar_jogadas.Visible = True
        Form1.btn_Novo_Jogo.Visible = True
        Form1.Iniciar_Brancas.Visible = True
        Form1.Iniciar_Pretas.Visible = True
        Form1.lb_Tempo.Visible = False
        Form1.Timer1.Enabled = False
        Form1.btn_Pausa.Visible = False
        resetar_peca()
    End Sub
    Public Sub iniciar()
        'Verifica se os nomes dos jogadores foram preenchidos
        'só se os nomes dos jogadores estiverem preenchidos
        'é que o jogo irá ser inicializado
        If Form1.txt_Jogador1.Text = "" Or Form1.txt_Jogador2.Text = "" Then
            MsgBox("Por favor digite os nomes dos dois jogadores!")
        Else
            _iniciar()
        End If

    End Sub
    Private Sub _iniciar()
        partida = True
        Form1.l_jogador_1.Text = Form1.txt_Jogador1.Text
        Form1.l_jogador_2.Text = Form1.txt_Jogador2.Text
        If Form1.Iniciar_Pretas.Checked Then
            vez = mudar_vez("b")
        Else
            vez = mudar_vez("p")
        End If

        Form1.lb_Tempo.Visible = True
        Form1.Timer1.Enabled = True

        Form1.btn_Pausa.Visible = True
        Form1.mostrar_jogadas.Visible = False
        Form1.btn_Partida.Text = "Finalizar Partida"
        Form1.txt_Jogador1.Visible = False
        Form1.txt_Jogador2.Visible = False
        Form1.btn_Limpar_Resultados.Visible = False
        Form1.btn_Novo_Jogo.Visible = False
        Form1.Iniciar_Brancas.Visible = False
        Form1.Iniciar_Pretas.Visible = False

        If Form1.mostrar_jogadas.Checked Then
            reset_borda_quadrados(1)
        Else
            reset_borda_quadrados(0)
        End If

        reset_selecao(vez)
    End Sub
    Public Sub pausa_continuar()
        ' colocar o jogo em pausa e continuar o jogo
        If Form1.btn_Pausa.Text = "Pausa" Then
            Form1.Timer1.Enabled = False
            partida = False
            Form1.btn_Pausa.Text = "Continuar"
            reset_selecao("resetar")
        Else
            Form1.Timer1.Enabled = True
            partida = True
            Form1.btn_Pausa.Text = "Pausa"
            reset_selecao(vez)
        End If
    End Sub


    Public Sub marcar_tempo()
        ' maracar o tempo de jogo
        tempo -= TimeSpan.FromSeconds(1)
        Form1.lb_Tempo.Text = Format(Convert.ToDateTime(tempo.Duration.ToString), "mm:ss")
        If Form1.lb_Tempo.Text = "00:30" Then
            Form1.lb_Tempo.ForeColor = Color.Red
        ElseIf Form1.lb_Tempo.Text = "00:00" Then
            Form1.lb_Tempo.ForeColor = Color.Green
            vez = mudar_vez(vez)
            reset_selecao(vez)
        End If
    End Sub

    Public Sub mudar_jogadores()
        ' novos jogadores
        Form1.txt_Jogador1.Clear()
        Form1.txt_Jogador1.Visible = True
        Form1.txt_Jogador2.Clear()
        Form1.txt_Jogador2.Visible = True
        Form1.l_jogador_1.Text = "Jogador 1"
        Form1.l_jogador_2.Text = "Jogador 2"
        Form1.lb_Vitoriasp.Text = "Vitórias - 0"
        Form1.lb_Vitoriasb.Text = "Vitórias - 0"
        vitorias_jogador_1 = 0
        vitorias_jogador_2 = 0
        Form1.btn_Partida.Text = "Iniciar"
        Form1.btn_Limpar_Resultados.Visible = False
        Form1.btn_Novo_Jogo.Visible = False
    End Sub
    Public Sub novos_resultados()
        ' resetar os resultados das vitorias
        Form1.lb_Vitoriasp.Text = "Vitórias - 0"
        Form1.lb_Vitoriasb.Text = "Vitórias - 0"
        vitorias_jogador_1 = 0
        vitorias_jogador_2 = 0
        Form1.btn_Novo_Jogo.Visible = False
    End Sub
End Module
