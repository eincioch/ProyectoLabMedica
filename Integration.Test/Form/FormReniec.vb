Public Class FormReniec
    Sub Mostrar(ByVal cTitulo As String, ByVal cURL As String, Optional ByVal nAncho As Integer = 621, Optional ByVal nAlto As Integer = 576)
        Try
            Dim Link As New Uri(cURL)
            WebBrowser1.Url = Link
            LblTitulo.Text = cTitulo
            Me.Width = nAncho
            Me.Height = nAlto
            Me.Show()
        Catch ex As Exception
            MessageBox.Show("La página consultada no está disponible.", "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub LblTitulo_DoubleClick(sender As Object, e As EventArgs) Handles LblTitulo.DoubleClick
        Me.Close()
        Me.Dispose()
    End Sub
End Class