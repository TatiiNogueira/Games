'Link do Video -> https://www.youtube.com/watch?v=SzM9Daea2wg&t=1020s

Imports System.Reflection.Emit
Imports System.Threading
Imports System.Timers

Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Quando for Start muda a frase para Reiniciar e a cor passa a ser Vermelho
        'Se o botão disser Reiniciar, todos os botões param no número 1
        'E depois só quando clicarmos no botão que disser Start é que o mesmo
        'Será inicializado
        If btnStart.Text = "START" Then
            btnStart.Text = "Reiniciar"
            btnStart.BackColor = Color.Red
            Timer1.Enabled = True
            btn_Parar1.Enabled = True
            Timer2.Enabled = True
            btn_Parar2.Enabled = True
            Timer3.Enabled = True
            btn_Parar3.Enabled = True
            Timer4.Enabled = True
            btn_Parar4.Enabled = True
            Timer5.Enabled = True
            btn_Parar5.Enabled = True
        Else
            btnStart.Text = "START"
            btnStart.BackColor = Color.Lime
            Timer1.Enabled = False
            btn_Parar1.Enabled = False
            Label1.Text = "1"
            Timer2.Enabled = False
            btn_Parar2.Enabled = False
            Label2.Text = "1"
            Timer3.Enabled = False
            btn_Parar3.Enabled = False
            Label3.Text = "1"
            Timer4.Enabled = False
            btn_Parar4.Enabled = False
            Label4.Text = "1"
            Timer5.Enabled = False
            btn_Parar5.Enabled = False
            Label5.Text = "1"
        End If
    End Sub

    'Botões
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn_Parar1.Click
        Timer1.Enabled = False
        btn_Parar1.Enabled = False
        Verificar()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn_Parar2.Click
        Timer2.Enabled = False
        btn_Parar2.Enabled = False
        Verificar()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn_Parar3.Click
        Timer3.Enabled = False
        btn_Parar3.Enabled = False
        Verificar()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn_Parar4.Click
        Timer4.Enabled = False
        btn_Parar4.Enabled = False
        Verificar()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn_Parar5.Click
        Timer5.Enabled = False
        btn_Parar5.Enabled = False
        Verificar()
    End Sub

    'Timers
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = CInt(Rnd() * 9)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = CInt(Rnd() * 9)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label3.Text = CInt(Rnd() * 9)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label4.Text = CInt(Rnd() * 9)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Label5.Text = CInt(Rnd() * 9)
    End Sub

    Public Sub Verificar()
        'Verifica se todos os botões forams elecionados
        If Timer1.Enabled = False And Timer2.Enabled = False And Timer3.Enabled = False And Timer4.Enabled = False And Timer5.Enabled = False Then
            'Verifica se todos os números são iguais
            If Label1.Text = Label2.Text = Label3.Text = Label4.Text = Label5.Text Then
                MessageBox.Show("Muito Bem!Acertas te todos os números")

            Else
                MessageBox.Show("Que Pena Falhas te :(. Tenta novamente")
            End If
            'Reiniciaos núemeros
            btnStart.Text = "START"
            btnStart.BackColor = Color.Lime
            Timer1.Enabled = False
            btn_Parar1.Enabled = False
            Label1.Text = "1"
            Timer2.Enabled = False
            btn_Parar2.Enabled = False
            Label2.Text = "1"
            Timer3.Enabled = False
            btn_Parar3.Enabled = False
            Label3.Text = "1"
            Timer4.Enabled = False
            btn_Parar4.Enabled = False
            Label4.Text = "1"
            Timer5.Enabled = False
            btn_Parar5.Enabled = False
            Label5.Text = "1"
        End If
    End Sub
End Class
