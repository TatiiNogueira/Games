Public Class Posicao_Pecas
    'Classe Derivada
    Inherits Dimensoes_Quadrados_Pecas

    Public cor As String
    Public peca As Button

    'Função Geral para a Posição das Peças
    Public Sub Posicao(_peca As Button, _x As Integer, _y As Integer, _cor As String)
        peca = _peca
        cor = _cor
        With peca
            'Localização da peça
            .Location = New System.Drawing.Point(_x * largura, _y * altura)
            'Tamanho da Peça
            .Size() = New System.Drawing.Size(largura, altura)
            'Indica que a aparência do botão será plana com uma cor de fundo sólida
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
        End With
    End Sub
End Class
