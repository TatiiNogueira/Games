Public Class Rainha
    Inherits Posicao_Pecas

    Private tipo As String = "Rainha"

    Public Sub jogadas_rainha(_x As Integer, _y As Integer)

        Dim x = _x / altura
        Dim y = _y / largura

        ' validar as jogadas
        Jogada(x, y, 2, cor, tipo, AddressOf Oeste)
        Jogada(x, y, 2, cor, tipo, AddressOf Este)
        Jogada(x, y, 2, cor, tipo, AddressOf Norte)
        Jogada(x, y, 2, cor, tipo, AddressOf Sul)

        Jogada(x, y, 1, cor, tipo, AddressOf NE)
        Jogada(x, y, 1, cor, tipo, AddressOf NO)
        Jogada(x, y, 1, cor, tipo, AddressOf SE)
        Jogada(x, y, 1, cor, tipo, AddressOf SO)

    End Sub

End Class
