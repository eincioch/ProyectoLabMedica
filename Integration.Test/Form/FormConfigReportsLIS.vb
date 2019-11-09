Public Class FormConfigReportsLIS

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Dispose()
        Close()
    End Sub

    Private Sub BtnAplicar_Click(sender As Object, e As EventArgs) Handles BtnAplicar.Click
        Try

            Dim cRutaResultOrigen As String
            Dim cRutaResultLIS As String
            Dim cNombre_Reporte As String

            Dim configurationAppSettings As New System.Configuration.AppSettingsReader

            cRutaResultLIS = CType(configurationAppSettings.GetValue("cRutaReportsLIS", GetType(System.String)), String)
            cNombre_Reporte = CType(configurationAppSettings.GetValue("cReporteResultLIS", GetType(System.String)), String)

            If rbtResConLogo.Checked Then
                cRutaResultOrigen = cRutaResultLIS & "Con_Logo\"
            Else
                cRutaResultOrigen = cRutaResultLIS & "Sin_Logo\"
            End If

            FileCopy(cRutaResultOrigen & cNombre_Reporte & ".jasper", cRutaResultLIS & cNombre_Reporte & ".jasper")
            FileCopy(cRutaResultOrigen & cNombre_Reporte & ".jrxml", cRutaResultLIS & cNombre_Reporte & ".jrxml")
            MessageBox.Show("Se ha cambiado satisfactoriamente.", "Cambio de Configuración LIS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error inesperado. Comuníquese con TI. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

End Class