
Public Class Tabuleiro
    Inherits Dimensoes_Quadrados_Pecas
    Public Sub Criar()

        Dim preto As Color = Color.LightBlue
        Dim branco As Color = Color.LightPink
        Dim cor As Color
        Dim n_pecas As Integer

        ' criar 64 quadrados
        For Y As Integer = 0 To 7
            n_pecas = Y
            For X As Integer = 0 To 7
                n_pecas += 1

                If n_pecas Mod 2 = 0 Then
                    cor = branco
                Else
                    cor = preto
                End If

                Dim quadrado As Button = New Button()
                quadrado.Name = "X" & X & " Y" & Y

                Matriz_Tabuleiro(X, Y) = quadrado
                lista_quadrados_tabuleiro.Add(quadrado)
                AddHandler quadrado.Click, AddressOf HandleDynamicButtonclick

                Criar_Quadrado(quadrado, X, Y, cor)

                Dim quadrado_com_peca As Boolean = False
                For Each peca As Button In Lista_Pecas
                    If peca.Location.Y = quadrado.Location.Y And peca.Location.X = quadrado.Location.X Then
                        peca.BackColor = cor
                        peca.FlatAppearance.MouseOverBackColor = cor
                        peca.FlatAppearance.MouseDownBackColor = cor
                        peca.FlatAppearance.BorderColor = cor
                        Matriz(X, Y) = peca
                        Matriz_Novo_Jogo(X, Y) = peca
                        quadrado_com_peca = True
                    End If
                Next

                If Not quadrado_com_peca Then
                    Matriz(X, Y) = quadrado
                    Matriz_Novo_Jogo(X, Y) = quadrado
                End If
            Next
        Next

    End Sub

    Public Sub Criar_Quadrado(peca As Button, _x As Integer, _y As Integer, cor As Color)
        'criar os quadrados do tabuleiro
        With peca
            .Location = New System.Drawing.Point(_x * largura, _y * altura)
            .Size() = New System.Drawing.Size(largura, altura)
            .BackColor = cor
            .FlatAppearance.BorderColor = cor
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.MouseDownBackColor = cor
            .FlatAppearance.MouseOverBackColor = cor
        End With

        Form1.Controls.Add(peca)

    End Sub

    Private Sub HandleDynamicButtonclick(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Form1.controler.click_tabuleiro(btn)
    End Sub
End Class
