﻿Public Class FormCrystalReport

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        'Close()
        Dispose()
    End Sub

    Private Sub FormCrystalReport_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'CrystalRptVwr.ShowExportButton = True
    End Sub
End Class