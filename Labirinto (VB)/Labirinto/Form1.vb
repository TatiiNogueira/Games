'Link -> https: //www.youtube.com/watch?v=X4qxc_sR5Yk

Public Class Labirintop
    Public Sub New()
        'Isto é requerido pelo designer
        InitializeComponent()
        'Chamar a função
        MoveToStart()
    End Sub

    Private Sub Final_MouseEnter(sender As Object, e As EventArgs) Handles Final.MouseEnter
        'Mensagem quando chegamos ao final
        MessageBox.Show("Muito Bem! Chegas te ao Final do Labirinto!!")
        Close()
    End Sub

    Private Sub MoveToStart()
        'Definir Variáveis
        Dim StartingPoint = Panel1.Location()
        'Coordenadas de inicio do rato
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label51.MouseEnter, Label50.MouseEnter
        MessageBox.Show("Ups!! Tenta novamente")
        MoveToStart()
    End Sub

End Class
