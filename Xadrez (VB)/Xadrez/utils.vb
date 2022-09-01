Module utils
    'Variáveis Globais

    'Tamanho das peças
    Private quadrado As Dimensoes_Quadrados_Pecas = New Dimensoes_Quadrados_Pecas()
    Private altura As Integer = quadrado.altura
    Private largura As Integer = quadrado.largura

    'Lista de todas as peças do jogo
    Public Lista_Pecas() As Button

    'Matrizes para obter as posições das peças e prever as jogadas possiveis
    Public Matriz(8, 8) As Button
    Public Matriz_Tabuleiro(8, 8) As Button
    Public Matriz_Novo_Jogo(8, 8) As Button


    'Utilizado para resetar as bordas dos quadrados selecionados
    Public lista_quadrados_tabuleiro As List(Of Button) = New List(Of Button)

    'Variaveis utilizadas para controlar o fluxo do jogo
    Public vez As String = "b"
    Public partida As Boolean = False
    Public tempo As TimeSpan = TimeSpan.FromMinutes(2)

    'Lista das peças eliminadas
    Private lista_elinimados_preto As List(Of Button) = New List(Of Button)
    Private lista_elinimados_branco As List(Of Button) = New List(Of Button)

    'Pontuação
    Public vitorias_jogador_1 As Integer = 0
    Public vitorias_jogador_2 As Integer = 0

    'Variaveis para posicionar as peças eliminadas 
    Private i_eliminados_brnaco_x As Integer = 0
    Private i_eliminados_brnaco_y As Integer = 0
    Private i_eliminados_preto_x As Integer = 0
    Private i_eliminados_preto_y As Integer = 0

    Public Sub jogar(p1 As Button, p2 As Button, vez As String)
        ' efetuar uma jogada

        p1.BackColor = p2.BackColor

        Dim p1X = p1.Location.X / largura
        Dim p1Y = p1.Location.Y / altura

        Dim p2X = p2.Location.X / altura
        Dim p2Y = p2.Location.Y / largura

        ' atualizar a matriz
        Matriz(p1X, p1Y) = Matriz_Tabuleiro(p1X, p1Y)
        ' mover a peça para a nova posição
        mover_peca(p1, p2.Location.X, p2.Location.Y)

        Matriz(p2X, p2Y) = p1

        reset_selecao(vez)

    End Sub

    Private Sub mover_peca(peca As Button, x_fim As Integer, y_fim As Integer)
        ' mover peça com animação

        Dim x = peca.Location.X
        Dim y = peca.Location.Y

        Dim _x = x - x_fim
        Dim _y = y - y_fim

        For move = 1 To 10
            x -= _x / 10
            y -= _y / 10
            peca.Location = New System.Drawing.Point(x, y)
            peca.Refresh()
            Threading.Thread.Sleep(1)
        Next

    End Sub

    'Resetar as seleções
    Public Function reset_selecao(vez As String) As Boolean

        For Each b As Button In lista_quadrados_tabuleiro
            b.FlatAppearance.BorderColor = b.BackColor
            b.FlatAppearance.MouseOverBackColor = b.BackColor
        Next

        ' resetar as peças selecionadas
        For Each peca As Button In Lista_Pecas
            If Not peca.BackColor = Color.Transparent Then
                peca.FlatAppearance.BorderColor = peca.BackColor
                If peca.Name.Contains(vez) Then ' se for a vez da cor da peça 
                    peca.FlatAppearance.MouseDownBackColor = Color.Transparent
                    peca.FlatAppearance.MouseOverBackColor = Color.Indigo
                Else
                    peca.FlatAppearance.MouseOverBackColor = peca.BackColor
                    peca.FlatAppearance.MouseDownBackColor = peca.BackColor
                End If

                If Not Form1.mostrar_jogadas.Checked Then
                    peca.FlatAppearance.BorderSize = 0
                Else
                    peca.FlatAppearance.BorderSize = 1
                End If
            End If
        Next

        ' se tiver peças eliminadas vão ser resetadas
        For Each peca As Button In lista_elinimados_branco
            peca.BackColor = Color.Transparent
            peca.FlatAppearance.BorderSize = 0
            peca.FlatAppearance.MouseDownBackColor = Color.Green
            peca.FlatAppearance.MouseOverBackColor = Color.Green
            peca.Enabled = False
        Next

        For Each peca As Button In lista_elinimados_preto
            peca.BackColor = Color.Transparent
            peca.FlatAppearance.BorderSize = 0
            peca.FlatAppearance.MouseDownBackColor = Color.Green
            peca.FlatAppearance.MouseOverBackColor = Color.Green
            peca.Enabled = False
        Next

        Return False

    End Function

    Public Sub resetar_peca()
        ' resetar as peças

        ' variaves para controlar as posições onde ficam as peças eliminadas
        i_eliminados_brnaco_x = 0
        i_eliminados_brnaco_y = 0
        i_eliminados_preto_x = 0
        i_eliminados_preto_y = 0

        ' atualizar a matriz
        For x = 0 To 7
            For y = 0 To 7
                Matriz(x, y) = Matriz_Novo_Jogo(x, y)
            Next
        Next

        Form1.l_jogador_1.ForeColor = Color.White
        Form1.l_jogador_2.ForeColor = Color.White

        lista_elinimados_branco.Clear()
        lista_elinimados_preto.Clear()

        For Each peca As Button In Lista_Pecas
            Dim quadrado = Matriz_Tabuleiro(peca.Location.X / largura, peca.Location.Y / altura)
            peca.Enabled = True
            peca.BackColor = quadrado.BackColor
            peca.FlatAppearance.BorderColor = quadrado.BackColor
            peca.FlatAppearance.MouseDownBackColor = quadrado.FlatAppearance.MouseDownBackColor
            peca.FlatAppearance.MouseOverBackColor = quadrado.FlatAppearance.MouseOverBackColor
        Next
        reset_selecao("resetar")
    End Sub

    Public Function mudar_vez(vez As String) As String
        ' mudar vez de jogada
        Form1.lb_Tempo.ForeColor = Color.Green
        Form1.lb_Tempo.Text = "02:00"
        tempo = TimeSpan.FromMinutes(2)

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

    Public Sub reset_borda_quadrados(n As Integer)
        For Each b As Button In lista_quadrados_tabuleiro
            b.FlatAppearance.BorderSize = n
        Next
    End Sub

    Public Sub eliminar_peca(peca As Button, cor As String)
        ' eliminar e posicionar peça eliminada

        Dim pos_x As Integer = (largura * 8) + 200
        If cor = "p" Then

            peca.Location = New System.Drawing.Point(pos_x + (i_eliminados_preto_x * largura), (i_eliminados_preto_y * altura) + altura * 4)

            If i_eliminados_preto_y = 3 Then
                i_eliminados_preto_y = -1
                i_eliminados_preto_x += 1
            End If
            i_eliminados_preto_y += 1
            lista_elinimados_preto.Add(peca)

        Else
            peca.Location = New System.Drawing.Point(pos_x + (i_eliminados_brnaco_x * largura), i_eliminados_brnaco_y * altura)

            If i_eliminados_brnaco_y = 3 Then
                i_eliminados_brnaco_y = -1
                i_eliminados_brnaco_x += 1
            End If
            i_eliminados_brnaco_y += 1
            lista_elinimados_branco.Add(peca)

        End If

        peca.BackColor = Color.Transparent
        peca.FlatAppearance.BorderSize = 0
        peca.FlatAppearance.MouseDownBackColor = Color.Green
        peca.FlatAppearance.MouseOverBackColor = Color.Green
        peca.Enabled = False

    End Sub

    Public Sub mudar_peca(p1 As Button, p2 As Button, vez As String)
        ' efetuar uma troca de peça

        Dim p1X = p1.Location.X / largura
        Dim p1Y = p1.Location.Y / altura

        'atualizar a matriz
        Matriz(p1X, p1Y) = p2

        ' atualizar as listas as listas de peças eliminadas
        If p2.Name.Contains("p") Then
            lista_elinimados_preto.Remove(p2)
            lista_elinimados_preto.Add(p1)
        Else
            lista_elinimados_branco.Remove(p2)
            lista_elinimados_branco.Add(p1)
        End If

        ' atualizar os estilos e as posições
        Dim backcolor As Color = p1.BackColor
        Dim mouseDownBackColor As Color = p1.FlatAppearance.MouseDownBackColor
        Dim mouseOverBackColor As Color = p1.FlatAppearance.MouseOverBackColor

        p1.FlatAppearance.BorderSize = 0
        p1.BackColor = Color.Red

        p1X = p1.Location.X
        p1Y = p1.Location.Y
        Dim p2X As Integer = p2.Location.X
        Dim p2Y As Integer = p2.Location.Y

        mover_peca(p1, p2X, p2Y)

        p2.Size() = New System.Drawing.Size(largura, altura)
        p2.BackColor = Color.Green
        mover_peca(p2, p1X, p1Y)

        p2.BackColor = backcolor
        p2.FlatAppearance.BorderSize = 1
        p2.FlatAppearance.MouseDownBackColor = mouseDownBackColor
        p2.FlatAppearance.MouseOverBackColor = mouseOverBackColor

        reset_selecao(vez)

    End Sub

    Public Sub selecionar_trocar_peca(peca As Button)
        ' exibir as peças eliminadas para troca
        If peca.Name.Contains("p") Then
            exibir_pecas_eliminadas(lista_elinimados_preto)
        Else
            exibir_pecas_eliminadas(lista_elinimados_branco)
        End If
        ' o peão que vai ser trocado é selecionado a azul
        selecionar_peca_blue(peca)
    End Sub

    Private Sub exibir_pecas_eliminadas(lista As List(Of Button))
        For Each b As Button In lista ' disponibilizar as peças eliminadas para troca
            If Not b.Name.Contains("peao") Then ' não pode ser trocado com um peão
                b.Enabled = True
            End If
        Next
    End Sub
End Module