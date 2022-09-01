Public Class Peao
    Inherits Posicao_Pecas

    Private tipo As String = "Peao"

    'Jogadas que o Peão pode fazer
    Public Sub Jogadas_Peao(_x As Integer, _y As Integer)

        Dim x = _x / altura
        Dim y = _y / largura

        If cor = "p" Then
            'Jogadas na Diagonal apenas usadas para comer
            Jogada(x, y, 1, cor, tipo, AddressOf SE)
            Jogada(x, y, 1, cor, tipo, AddressOf SO)
            'Jogada normal do Peão
            Jogada(x, y, 1, cor, tipo, AddressOf Sul)

            'Se for a primeira jogada o Peão pode andar 2 casas
            If y = 1 Then
                Jogada(x, y, 2, cor, tipo, AddressOf Sul)
            End If

            If y = 7 Then
                selecionar_trocar_peca(peca)
            End If

        Else

            Jogada(x, y, 1, cor, tipo, AddressOf NE)
            Jogada(x, y, 1, cor, tipo, AddressOf NO)
            Jogada(x, y, 1, cor, tipo, AddressOf Norte)

            If y = 6 Then
                Jogada(x, y, 2, cor, tipo, AddressOf Norte)
            End If

            If y = 0 Then
                selecionar_trocar_peca(peca)
            End If

        End If

    End Sub


End Class


