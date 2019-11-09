Imports Integration.BL.BL_FichaAtencion

Public Class FormRptCER

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click

        Dim ObjBL As New BL_FichaAtencion

        Table1.DataSource = ObjBL.Get_CER(Format(DtpFecIni.Value, "yyyy/MM/dd"), Format(DtpFecFin.Value, "yyyy/MM/dd"))


    End Sub


    Private Sub FormRptCER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatGrilla(Table1, Me, True, 40)
    End Sub

    Private Sub BtnExportExcel_Click(sender As Object, e As EventArgs) Handles BtnExportExcel.Click
        If Table1.RowCount = 0 Then Exit Sub
        'Call GridAExcel(Table1)
        ExportarDatosExcel(Table1, "Control Entrega de Resultados", "Desde: " + Format(DtpFecIni.Value, "dd/MM/yyyy") + " hasta: " + Format(DtpFecFin.Value, "dd/MM/yyyy"))

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
        Dispose()

    End Sub
End Class