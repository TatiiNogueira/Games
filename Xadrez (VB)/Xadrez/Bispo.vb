'O Bispo só anda na Diagonal
Public Class Bispo
    Inherits Posicao_Pecas

    Private tipo As String = "bispo"

    Public Sub jogadas_bispo(_x As Integer, _y As Integer)

        Dim x = _x / largura
        Dim y = _y / altura

        'Jogadas Posiveis
        Jogada(x, y, 8, cor, tipo, AddressOf NE)
        Jogada(x, y, 8, cor, tipo, AddressOf NO)
        Jogada(x, y, 8, cor, tipo, AddressOf SE)
        Jogada(x, y, 8, cor, tipo, AddressOf SO)

    End Sub

End Class
