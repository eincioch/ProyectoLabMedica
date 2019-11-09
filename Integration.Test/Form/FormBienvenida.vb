Public Class FormBienvenida

    Dim Contador As Byte = 0

    Sub Temporizador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Temporizador.Tick

        If ProgressBar1.Value < 99 Then
            Contador = Contador + 33
            ProgressBar1.Value = Contador
        Else
            Me.Hide()
            FormAcceso.Show()
            Temporizador.Enabled = False
        End If
    End Sub

    Private Sub FormBienvenida_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Opacity = 0.9
        Label1.Text = "Módulo Admisión - Caja (Ver. " + Space(1) + Status_Version() + ")"
    End Sub

 
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
        Dispose()
        End
    End Sub
End Class