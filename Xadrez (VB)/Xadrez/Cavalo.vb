'O Cabalo só anda em L
Public Class Cavalo
    Inherits Posicao_Pecas

    Private tipo As String = "cavalo"

    Public Sub jogadas_cavalo(_x As Integer, _y As Integer)

        Dim x = _x / altura
        Dim y = _y / largura

        'Possiveis Jogadas
        ' sul-oeste
        If x - 1 > -1 And y + 2 < 8 Then
            Dim suloeste As Button = Matriz(x - 1, y + 2)
            Selecionar(suloeste, cor, tipo, "suloeste", 1)
        End If

        ' sul-este
        If x + 1 < 8 And y + 2 < 8 Then
            Dim suleste As Button = Matriz(x + 1, y + 2)
            Selecionar(suleste, cor, tipo, "suleste", 1)
        End If

        ' este-sul
        If x + 2 < 8 And y + 1 < 8 Then
            Dim estesul As Button = Matriz(x + 2, y + 1)
            Selecionar(estesul, cor, tipo, "estesul", 1)
        End If

        ' este-norte
        If x + 2 < 8 And y - 1 > -1 Then
            Dim estenorte As Button = Matriz(x + 2, y - 1)
            Selecionar(estenorte, cor, tipo, "estenorte", 1)
        End If

        ' oeste-norte
        If x - 2 > -1 And y + 1 < 8 Then
            Dim oestenorte As Button = Matriz(x - 2, y + 1)
            Selecionar(oestenorte, cor, tipo, "oestenorte", 1)
        End If

        ' oeste-sul
        If x - 2 > -1 And y - 1 > -1 Then
            Dim oestesul As Button = Matriz(x - 2, y - 1)
            Selecionar(oestesul, cor, tipo, "oestesul", 1)
        End If

        ' norte-este
        If x + 1 < 8 And y - 2 > -1 Then
            Dim norteeste As Button = Matriz(x + 1, y - 2)
            Selecionar(norteeste, cor, tipo, "norteeste", 1)
        End If

        ' norte-oeste
        If x - 1 > -1 And y - 2 > -1 Then
            Dim norteoeste As Button = Matriz(x - 1, y - 2)
            Selecionar(norteoeste, cor, tipo, "norteoeste", 1)
        End If

    End Sub

End Class
