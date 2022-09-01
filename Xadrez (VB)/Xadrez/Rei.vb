Public Class Rei
    Inherits Posicao_Pecas

    Private tipo As String = "Rei"

    Public Sub jogadas_rei(_x As Integer, _y As Integer)

        Dim x = _x / altura
        Dim y = _y / largura

        ' validar as jogadas
        Jogada(x, y, 8, cor, tipo, AddressOf Oeste)
        Jogada(x, y, 8, cor, tipo, AddressOf Este)
        Jogada(x, y, 8, cor, tipo, AddressOf Norte)
        Jogada(x, y, 8, cor, tipo, AddressOf Sul)

        Jogada(x, y, 8, cor, tipo, AddressOf NE)
        Jogada(x, y, 8, cor, tipo, AddressOf NO)
        Jogada(x, y, 8, cor, tipo, AddressOf SE)
        Jogada(x, y, 8, cor, tipo, AddressOf SO)

    End Sub

End Class
