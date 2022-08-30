'Link do Video -> https://www.youtube.com/watch?v=gzU_ly_k_qA

Public Class Form1
    Dim clicou As Boolean = False
    Dim Imagem1, Imagem2 As String

    'Função que não retorna nada
    Sub Verificar()
        If Imagem1 = Imagem2 Then
            'MsgBox("Parabéns!", MessageBoxIcon.Information)
        Else
            MsgBox("Tente novamente", MessageBoxIcon.Error)
            Reset()
        End If
    End Sub

    'Função que reinicia o jogo
    Sub Reset()
        clicou = False
        Imagem1 = "1"
        Imagem2 = "2"
        PictureBox1.Image = My.Resources.Ponto_Interrugação
        PictureBox2.Image = My.Resources.Ponto_Interrugação
        PictureBox3.Image = My.Resources.Ponto_Interrugação
        PictureBox4.Image = My.Resources.Ponto_Interrugação
        PictureBox5.Image = My.Resources.Ponto_Interrugação
        PictureBox6.Image = My.Resources.Ponto_Interrugação
        PictureBox7.Image = My.Resources.Ponto_Interrugação
        PictureBox8.Image = My.Resources.Ponto_Interrugação
        PictureBox9.Image = My.Resources.Ponto_Interrugação
        PictureBox10.Image = My.Resources.Ponto_Interrugação
        PictureBox11.Image = My.Resources.Ponto_Interrugação
        PictureBox12.Image = My.Resources.Ponto_Interrugação
        PictureBox13.Image = My.Resources.Ponto_Interrugação
        PictureBox14.Image = My.Resources.Ponto_Interrugação
        PictureBox15.Image = My.Resources.Ponto_Interrugação
        PictureBox16.Image = My.Resources.Ponto_Interrugação
        PictureBox17.Image = My.Resources.Ponto_Interrugação
        PictureBox18.Image = My.Resources.Ponto_Interrugação


    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "r"
            PictureBox1.Image = My.Resources.rosa
        Else
            clicou = False
            Imagem2 = "r"
            PictureBox1.Image = My.Resources.rosa
            Verificar()
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "l"
            PictureBox2.Image = My.Resources.lirio
        Else
            clicou = False
            Imagem2 = "l"
            PictureBox2.Image = My.Resources.lirio
            Verificar()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "l"
            PictureBox3.Image = My.Resources.lirio
        Else
            clicou = False
            Imagem2 = "l"
            PictureBox3.Image = My.Resources.lirio
            Verificar()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reset()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "r"
            PictureBox4.Image = My.Resources.rosa
        Else
            clicou = False
            Imagem2 = "r"
            PictureBox4.Image = My.Resources.rosa
            Verificar()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "bp"
            PictureBox5.Image = My.Resources.brincosdeprincesa
        Else
            clicou = False
            Imagem2 = "bp"
            PictureBox5.Image = My.Resources.brincosdeprincesa
            Verificar()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "e"
            PictureBox6.Image = My.Resources.estrelicia
        Else
            clicou = False
            Imagem2 = "e"
            PictureBox6.Image = My.Resources.estrelicia
            Verificar()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "g"
            PictureBox7.Image = My.Resources.girasol
        Else
            clicou = False
            Imagem2 = "g"
            PictureBox7.Image = My.Resources.girasol
            Verificar()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "m"
            PictureBox8.Image = My.Resources.margaridas
        Else
            clicou = False
            Imagem2 = "m"
            PictureBox8.Image = My.Resources.margaridas
            Verificar()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "j"
            PictureBox9.Image = My.Resources.jarros
        Else
            clicou = False
            Imagem2 = "j"
            PictureBox9.Image = My.Resources.jarros
            Verificar()
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "m"
            PictureBox10.Image = My.Resources.margaridas
        Else
            clicou = False
            Imagem2 = "m"
            PictureBox10.Image = My.Resources.margaridas
            Verificar()
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "o1"
            PictureBox11.Image = My.Resources.orquidea
        Else
            clicou = False
            Imagem2 = "o1"
            PictureBox11.Image = My.Resources.orquidea
            Verificar()
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "o2"
            PictureBox12.Image = My.Resources.ortence
        Else
            clicou = False
            Imagem2 = "o2"
            PictureBox12.Image = My.Resources.ortence
            Verificar()
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "o2"
            PictureBox13.Image = My.Resources.ortence
        Else
            clicou = False
            Imagem2 = "o2"
            PictureBox13.Image = My.Resources.ortence
            Verificar()
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "o1"
            PictureBox14.Image = My.Resources.orquidea
        Else
            clicou = False
            Imagem2 = "o1"
            PictureBox14.Image = My.Resources.orquidea
            Verificar()
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "j"
            PictureBox15.Image = My.Resources.jarros
        Else
            clicou = False
            Imagem2 = "j"
            PictureBox15.Image = My.Resources.jarros
            Verificar()
        End If
    End Sub


    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "e"
            PictureBox16.Image = My.Resources.estrelicia
        Else
            clicou = False
            Imagem2 = "e"
            PictureBox16.Image = My.Resources.estrelicia
            Verificar()
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "bp"
            PictureBox17.Image = My.Resources.brincosdeprincesa
        Else
            clicou = False
            Imagem2 = "bp"
            PictureBox17.Image = My.Resources.brincosdeprincesa
            Verificar()
        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If clicou = False Then
            clicou = True
            Imagem1 = "g"
            PictureBox18.Image = My.Resources.girasol
        Else
            clicou = False
            Imagem2 = "g"
            PictureBox18.Image = My.Resources.girasol
            Verificar()
        End If
    End Sub
End Class
