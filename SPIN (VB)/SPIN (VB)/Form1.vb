'Link do Video -> https://www.youtube.com/watch?v=UQKhHKNmp8g&t=1054s

Public Class Form1
    Dim m, a, b, c As Integer

    'Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        m = m + 10
        If m < 1000 Then
            a = Int(1 + Rnd() * 5)
            b = Int(1 + Rnd() * 5)
            c = Int(1 + Rnd() * 5)

            'Enquanto as imagens estiverem a passar o botão do SPIN vai
            'ficar "..."
            btnSpin.Text = "..."

            Select Case a
                Case 1
                    PictureBox1.Image = My.Resources.gato
                Case 2
                    PictureBox1.Image = My.Resources.leao
                Case 3
                    PictureBox1.Image = My.Resources.pantera
                Case 4
                    PictureBox1.Image = My.Resources.tigre
                Case 5
                    PictureBox1.Image = My.Resources.gatoselvagem
            End Select

            Select Case b
                Case 1
                    PictureBox2.Image = My.Resources.gato
                Case 2
                    PictureBox2.Image = My.Resources.leao
                Case 3
                    PictureBox2.Image = My.Resources.pantera
                Case 4
                    PictureBox2.Image = My.Resources.tigre
                Case 5
                    PictureBox2.Image = My.Resources.gatoselvagem
            End Select

            Select Case c
                Case 1
                    PictureBox3.Image = My.Resources.gato
                Case 2
                    PictureBox3.Image = My.Resources.leao
                Case 3
                    PictureBox3.Image = My.Resources.pantera
                Case 4
                    PictureBox3.Image = My.Resources.tigre
                Case 5
                    PictureBox3.Image = My.Resources.gatoselvagem
            End Select
        Else
            Timer1.Enabled = False
            'Button do SPIN volta ao normal
            btnSpin.Text = "SPIN"
            m = 0
            If a = b Then
                Label1.Text = "Fraquinho! 100€"
            ElseIf a = c Then
                Label1.Text = "Nada mal! 200€"
            ElseIf b = c Then
                Label1.Text = "Boa! 300€"
            ElseIf a = b And b = c Then
                Label1.Text = "JACKPOT!! 1000€"
            Else
                Label1.Text = "Tenta de novo! 0€"
            End If
        End If
    End Sub

    'Button Spin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Timer1.Enabled = True
    End Sub
End Class
