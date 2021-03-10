'Link do video -> https://www.youtube.com/watch?v=9QHYazC-nvI

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adicionar "event"(O que vão fazr) a todos os botões que estão dentro do Panel
        For Each c As Control In Panel2.Controls
            If c.GetType() = GetType(Button) Then
                AddHandler c.Click, AddressOf btn_Click
            End If
        Next
    End Sub

    Dim XorO As Integer = 0

    'Criar button event
    Private Sub btn_Click(sender As Object, e As EventArgs)
        Dim btn As Button = sender
        If btn.Text.Equals("") Then
            If XorO Mod 2 = 0 Then
                'Atribuição do Texto
                btn.Text = "X"
                'Atribuição da cor 
                btn.ForeColor = Color.Crimson
                'Mudar o texto "Let´s Start"
                Label1.Text = "O Turn"
                getTheWinner()
            Else
                'Atribuição do Texto
                btn.Text = "O"
                'Atribuição da cor 
                btn.ForeColor = Color.Blue
                'Mudar o texto "Let´s Start"
                Label1.Text = "X Turn"
                getTheWinner()
            End If
            XorO += 1
        End If
    End Sub

    Dim win As Boolean = False

    'Função obter o vencedor
    Private Sub getTheWinner()
        'Vitórias Possiveis
        If Not Button1.Text.Equals("") AndAlso Button1.Text.Equals(Button2.Text) AndAlso Button1.Text.Equals(Button3.Text) Then
            win = True
            winEffect(Button1, Button2, Button3)
        End If
        If Not Button4.Text.Equals("") AndAlso Button4.Text.Equals(Button5.Text) AndAlso Button4.Text.Equals(Button6.Text) Then
            win = True
            winEffect(Button4, Button5, Button6)
        End If
        If Not Button7.Text.Equals("") AndAlso Button7.Text.Equals(Button8.Text) AndAlso Button7.Text.Equals(Button9.Text) Then
            win = True
            winEffect(Button7, Button8, Button9)
        End If
        If Not Button1.Text.Equals("") AndAlso Button1.Text.Equals(Button4.Text) AndAlso Button1.Text.Equals(Button7.Text) Then
            win = True
            winEffect(Button1, Button4, Button7)
        End If
        If Not Button2.Text.Equals("") AndAlso Button2.Text.Equals(Button5.Text) AndAlso Button2.Text.Equals(Button8.Text) Then
            win = True
            winEffect(Button2, Button5, Button8)
        End If
        If Not Button3.Text.Equals("") AndAlso Button3.Text.Equals(Button6.Text) AndAlso Button3.Text.Equals(Button9.Text) Then
            win = True
            winEffect(Button3, Button6, Button9)
        End If
        If Not Button1.Text.Equals("") AndAlso Button1.Text.Equals(Button5.Text) AndAlso Button1.Text.Equals(Button9.Text) Then
            win = True
            winEffect(Button1, Button5, Button9)
        End If
        If Not Button3.Text.Equals("") AndAlso Button3.Text.Equals(Button5.Text) AndAlso Button3.Text.Equals(Button7.Text) Then
            win = True
            winEffect(Button3, Button5, Button7)
        End If
        'Se ninguém ganhar
        If allbuttonsTextLenght() = 9 AndAlso win = False Then
            Label1.Text = "Ninguém Ganhou"
        End If
    End Sub

    Function allbuttonsTextLenght() As Integer
        Dim btnsTxLenght As Integer = 0

        For Each c As Control In Panel2.Controls
            If c.GetType() = GetType(Button) Then
                btnsTxLenght += c.Text.Length
            End If
        Next

        Return btnsTxLenght
    End Function

    'Se ninguém ganhar
    Private Sub winEffect(ByVal b1 As Button, ByVal b2 As Button, ByVal b3 As Button)
        b1.BackColor = Color.Black
        b2.BackColor = Color.Black
        b3.BackColor = Color.Black

        b1.ForeColor = Color.White
        b2.ForeColor = Color.White
        b3.ForeColor = Color.White
        b3.ForeColor = Color.White

        Label1.Text = b1.Text + " Win"
    End Sub

    'Button Reset
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        XorO = 0
        win = False
        Label1.Text = "Let's Play Again"
        For Each c As Control In Panel2.Controls
            If c.GetType() = GetType(Button) Then
                c.BackColor = Color.White
                c.Text = ""
            End If
        Next
    End Sub
End Class
