Public Class Torre
    Inherits Posicao_Pecas

    Private tipo As String = "torre"

    Public Sub jogadas_torre(_x As Integer, _y As Integer)

        Dim x = _x / altura
        Dim y = _y / largura

        ' validar as jogadas
        Jogada(x, y, 8, cor, tipo, AddressOf Oeste)
        Jogada(x, y, 8, cor, tipo, AddressOf Este)
        Jogada(x, y, 8, cor, tipo, AddressOf Norte)
        Jogada(x, y, 8, cor, tipo, AddressOf Sul)

    End Sub

End Class
