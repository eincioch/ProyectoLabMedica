Option Explicit On
Imports Integration.BL.BL_Reportes

Public Class FormRptIngresosLabConv

    Dim cStrNameReport As String = ""
    Dim Servicio As New BLRptMaster

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Try

            If Not ValidaRangoFechas(DTPFecIni.Value.Date, DTPFecFin.Value.Date) Then
                DTPFecIni.Value = DTPFecFin.Value
                Exit Sub
            End If

            Cursor.Current = Cursors.WaitCursor

            cStrNameReport = vbNullString
            Table1.DataSource = Nothing
            Table1.DataSource = Servicio.Get_Ingresos_LabExt_Convenio_by_rango_fechas(DTPFecIni.Value, DTPFecFin.Value)
            cStrNameReport = "Reporte Ingresos por Laboratorio Externo y Convenios"

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Se encontraron errores.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub FormRptIngresosLabConv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WindowState = FormWindowState.Maximized
        FormatGrilla(Table1, Me)
    End Sub

    Private Sub C1CmdExporExcel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExporExcel.Click
        If Table1.RowCount = 0 Then Exit Sub
        'Call GridAExcel(Table1)
        ExportarDatosExcel(Table1, cStrNameReport, "Desde: " + Format(DTPFecIni.Value, "dd/MM/yyyy") + " hasta: " + Format(DTPFecFin.Value, "dd/MM/yyyy"))
    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Close()
        Dispose()
    End Sub
End Class