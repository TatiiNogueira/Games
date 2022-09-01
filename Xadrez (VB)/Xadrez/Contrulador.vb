Public Class Contrulador

    Private peca As Button
    Private selecionado As Boolean

    Public Sub click_tabuleiro(btn As Button)

        If selecionado Then
            'Jogada para uma casa livre
            If btn.FlatAppearance.BorderColor = Color.LightGreen Then
                vez = mudar_vez(vez)
                jogar(peca, btn, vez)
                selecionado = False
            End If
        End If
    End Sub

    Public Function mudar_vez(vez As String) As String
        'Mudar de Jogador
        Form1.lb_Tempo.ForeColor = Color.Green
        Form1.lb_Tempo.Text = "02:00"
        tempo = TimeSpan.FromMinutes(2)

        'O jogador que estiver a jogar fica a Verde
        'E do outro jogador fica a branco
        If vez = "b" Then
            Form1.l_jogador_1.ForeColor = Color.Green
            Form1.l_jogador_2.ForeColor = Color.Snow
            Form1.lb_Tempo.Location = New System.Drawing.Point(Form1.l_jogador_1.Location.X + Form1.l_jogador_1.Width + 10, Form1.l_jogador_1.Location.Y + 1)
            Return "p"
        Else
            Form1.l_jogador_2.ForeColor = Color.Green
            Form1.l_jogador_1.ForeColor = Color.Snow
            Form1.lb_Tempo.Location = New System.Drawing.Point(Form1.l_jogador_2.Location.X + Form1.l_jogador_2.Width + 10, Form1.l_jogador_2.Location.Y + 1)
            Return "b"
        End If
    End Function
    Public Sub click_peao(p As Peao)
        If partida Then
            If click_peca(p.peca, p.cor, AddressOf p.Jogadas_Peao) Then
                peca = p.peca
                selecionado = True
            End If
        Else
        End If
    End Sub

    Private Function click_peca(p As Button, cor As String, f As Action(Of Integer, Integer)) As Boolean

        'Eliminar peça
        If p.FlatAppearance.BorderColor = Color.LightGreen Then
            vez = mudar_vez(vez)
            jogar(peca, p, vez)
            selecionado = False
            eliminar_peca(p, vez)

            'Se o Rei for comido é Vitória para o jogador que comeu o Rei
            If p.Name.Contains("Rei") Then
                Dim vencedor As String = ""
                If cor = "b" Then
                    vencedor = Form1.l_jogador_1.Text
                    vitorias_jogador_1 += 1
                    Form1.lb_Vitoriasp.Text = "Vitórias - " & vitorias_jogador_1
                Else
                    vencedor = Form1.l_jogador_2.Text
                    vitorias_jogador_2 += 1
                    Form1.lb_Vitoriasb.Text = "Vitórias - " & vitorias_jogador_2
                End If
                MsgBox("Parabéns " & vencedor & " ganhou a partida!")

                Form1.btn_Partida.PerformClick()
            End If

            Return False
        End If

        'Se não for a vez 
        If Not cor = vez Or p.FlatAppearance.BorderColor = Color.Indigo Then
            Return False
        End If

        'Resgatar peça - Troca do Peão
        If p.BackColor = Color.Transparent Then
            vez = mudar_vez(vez)
            mudar_peca(peca, p, vez)
            selecionado = False
            Return False
        End If

        reset_selecao(vez)

        p.FlatAppearance.BorderColor = Color.Indigo
        If Not Form1.mostrar_jogadas.Checked Then
            p.FlatAppearance.BorderSize = 1
        End If

        f(p.Location.X, p.Location.Y)

        Return True

    End Function
    Public Sub click_torre(p As Torre)
        If partida Then
            If click_peca(p.peca, p.cor, AddressOf p.jogadas_torre) Then
                peca = p.peca
                selecionado = True
            End If
        End If
    End Sub

    Public Sub click_cavalo(p As Cavalo)
        If partida Then
            If click_peca(p.peca, p.cor, AddressOf p.jogadas_cavalo) Then
                peca = p.peca
                selecionado = True
            End If
        End If
    End Sub

    Public Sub click_bispo(p As Bispo)
        If partida Then
            If click_peca(p.peca, p.cor, AddressOf p.jogadas_bispo) Then
                peca = p.peca
                selecionado = True
            End If
        End If
    End Sub


    Public Sub click_rei(p As Rei)
        If partida Then
            If click_peca(p.peca, p.cor, AddressOf p.jogadas_rei) Then
                peca = p.peca
                selecionado = True
            End If
        End If
    End Sub

    Public Sub click_rainha(p As Rainha)
        If partida Then
            If click_peca(p.peca, p.cor, AddressOf p.jogadas_rainha) Then
                peca = p.peca
                selecionado = True
            End If
        End If
    End Sub
End Class
