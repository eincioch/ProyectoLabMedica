Public Class FormPrcProgramarPago

    Dim Sep As Char


    Private Sub FormPrcProgramarPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Detectar el separador decimal de la aplicación.
        Sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'pasando un valor desde otro formulario
        TxtImpAnticipo.Text = CType(Me.Owner, FormPrcSolAtencion).LblnSaldo.Text
        TxtImpAnticipo.Focus()
    End Sub

    Private Sub TxtImpAnticipo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtImpAnticipo.KeyDown
        If e.KeyCode = 13 Then
            Aplica()
        End If
    End Sub

    'Private Sub TxtImpAnticipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtImpAnticipo.KeyPress
    '    If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True

    'End Sub

    Private Sub TxtImpAnticipo_TextChanged(sender As Object, e As EventArgs) Handles TxtImpAnticipo.TextChanged
        If TxtImpAnticipo.Text = Sep Then
            'si el separador decimal es tecleado directamente
            TxtImpAnticipo.Text = "0" & Sep
            TxtImpAnticipo.SelectionStart = Len(TxtImpAnticipo.Text)
        ElseIf Not IsNumeric(Trim(TxtImpAnticipo.Text)) Then
            Beep()
            If Len(TxtImpAnticipo.Text) < 1 Then
                TxtImpAnticipo.Text = ""
            Else
                TxtImpAnticipo.Text = Microsoft.VisualBasic.Left(TxtImpAnticipo.Text, Len(TxtImpAnticipo.Text) - 1)
                TxtImpAnticipo.SelectionStart = Len(TxtImpAnticipo.Text)
            End If
        End If
    End Sub

    Sub Aplica()
        Dim DT As String
        'Para adaptar a la configuracion del PC huesped.
        DT = Replace(TxtImpAnticipo.Text, ".", Sep)
        DT = Replace(DT, ",", Sep)
        'Label1.Text = CDbl(DT)
        On Error Resume Next
        TxtImpAnticipo.SelectionStart = 0
        TxtImpAnticipo.SelectionLength = Len(TxtImpAnticipo.Text)
        TxtImpAnticipo.Focus()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        nImpAnticipo = CDbl(TxtImpAnticipo.Text)

        Close()
        Dispose()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        nImpAnticipo = 0.0
        Close()
        Dispose()

    End Sub
End Class