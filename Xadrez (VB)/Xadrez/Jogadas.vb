Module Jogadas
    'N - Número máximo de Passos 

    'Jogadas possiveis, jogadas comuns 
    Public Sub Jogada(x As Integer, y As Integer, N As Integer, cor As String, tipo As String, f As Func(Of Integer, Integer, Integer, String, String, Boolean))

        Dim selecionado As Boolean = False
        Dim I As Integer = 1

        Do While I < N + 1

            If selecionado Then
                Exit Do
            End If
            selecionado = f(x, y, I, cor, tipo)
            I += 1
        Loop

    End Sub

    'Jogadas na Diagonal
    Public Function SE(x As Integer, y As Integer, I As Integer, cor As String, tipo As String) As Boolean
        If y + I < 8 And x + I < 8 Then
            Dim b As Button = Matriz(x + I, y + I)
            Return Selecionar(b, cor, tipo, "SE", I)
        End If
        Return True
    End Function

    Public Function SO(x As Integer, y As Integer, I As Integer, cor As String, tipo As String) As Boolean
        If y + I < 8 And x - I > -1 Then
            Dim b As Button = Matriz(x - I, y + I)
            Return Selecionar(b, cor, tipo, "SO", I)
        End If
        Return True
    End Function

    Public Function NE(x As Integer, y As Integer, I As Integer, cor As String, tipo As String) As Boolean
        If x + I < 8 And y - I > -1 Then
            Dim b As Button = Matriz(x + I, y - I)
            Return Selecionar(b, cor, tipo, "NE", I)
        End If
        Return True
    End Function

    Public Function NO(x As Integer, y As Integer, I As Integer, cor As String, tipo As String) As Boolean
        If x - I > -1 And y - I > -1 Then
            Dim b As Button = Matriz(x - I, y - I)
            Return Selecionar(b, cor, tipo, "NO", I)
        End If
        Return True
    End Function

    'Jogadas para a Frente
    Public Function Norte(x As Integer, y As Integer, I As Integer, cor As String, tipo As String) As Boolean
        If y - I > -1 Then
            Dim b As Button = Matriz(x, y - I)
            Return Selecionar(b, cor, tipo, "norte", I)
        End If
        Return True
    End Function

    Public Function Sul(x As Integer, y As Integer, I As Integer, cor As String, tipo As String) As Boolean
        If y + I < 8 Then
            Dim b As Button = Matriz(x, y + I)
            Return Selecionar(b, cor, tipo, "sul", I)
        End If
        Return True
    End Function

    'Jogadas para o lado
    Public Function Oeste(x As Integer, y As Integer, I As Integer, cor As String, tipo As String) As Boolean
        If x - I > -1 Then
            Dim b As Button = Matriz(x - I, y)
            Return Selecionar(b, cor, tipo, "oeste", I)
        End If
        Return True
    End Function

    Public Function Este(x As Integer, y As Integer, I As Integer, cor As String, tipo As String) As Boolean
        If x + I < 8 Then
            Dim b As Button = Matriz(x + I, y)
            Return Selecionar(b, cor, tipo, "este", I)
        End If
        Return True
    End Function
    Public Function Selecionar(peca As Button, cor As String, tipo As String, direcao As String, I As Integer) As Boolean

        'Peça do mesmo jogador
        If peca.Name.Contains(cor) Then
            Return True

            'Quadrado vazio
        ElseIf peca.Name.Contains("X") Then
            Const dierecao_peao As String = "nortesul"
            If tipo = "Peao" And Not dierecao_peao.Contains(direcao) Then
                Return False
            ElseIf tipo = "Rainha" And I = 2 Then
                Return False
            Else
                selecionar_peca_gren(peca)
                Return False
            End If

        Else 'Peça do adversario 
            selecionar_peca_gren(peca)
            Return True
        End If

    End Function

    'Selecionar a verde (Possiveis jogadas)
    Public Sub selecionar_peca_gren(b As Button)
        If Form1.mostrar_jogadas.Checked Then
            b.FlatAppearance.MouseOverBackColor = Color.LightGreen
        End If
        b.FlatAppearance.BorderColor = Color.LightGreen
    End Sub

    'Selecionar a azul (Mudar de peça)
    Public Sub selecionar_peca_blue(b As Button)
        b.FlatAppearance.BorderColor = Color.Blue
        b.FlatAppearance.MouseOverBackColor = Color.Blue
    End Sub
End Module