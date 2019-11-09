Imports Integration.BL.BL_Reportes
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormRptVentasxTurno


    'Private Sub BtnResumen_Click(sender As System.Object, e As System.EventArgs)

    '    Dim CrReport As New ReportDocument

    '    Try
    '        Dim BL As New BL_RptCuadreCaja

    '        ' Asigno el reporte 
    '        'If BL.Get_ReportCuadraCaja("RES", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub

    '        CrReport = New ReportDocument()
    '        CrReport.Load(cPathRPT & "rptCuadreCajaResumen.rpt")

    '        CrReport.DataDefinition.FormulaFields("rangofec").Text = Chr(34) & "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy") & Chr(34)

    '        CrReport.SetDataSource(BL.Get_ReportCuadraCaja(StrcPerJuridica, CLng(ObtenerParametroAppConfig("NroCaja")), FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)))

    '        FormCrystalReport.Text = "Reporte Cuadre Caja Resumen..."

    '        FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
    '        'Directo a la impresora
    '        'Form_CrystalReport.CrystalRptVwr.PrintReport()
    '        FormCrystalReport.Show()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try

    'End Sub

    Private Sub BtnDetalle_Click(sender As System.Object, e As System.EventArgs) Handles BtnDetalle.Click

        If Not ValidaRangoFechas(DtpFecIni.Value.Date, DtpFecFin.Value.Date) Then
            DtpFecIni.Value = DtpFecFin.Value
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor

        Dim CrReport As New ReportDocument

        Try
            Dim BL As New BLRptMaster

            'If BL.Get_ReportCuadraCaja("DET", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub
            ' Asigno el reporte 
            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT & "rptVentasxTurno.rpt")

            CrReport.DataDefinition.FormulaFields("rangofec").Text = Chr(34) & "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " 07:00 am hasta " & Format(DateAdd(DateInterval.Day, 1, DtpFecFin.Value), "dd/MM/yyyy") & " 06:59 am" & Chr(34)

            CrReport.SetDataSource(BL.Get_Ventas_Group_PerJur_Turno_TipoAtencion_by_Fechas(Format(DtpFecIni.Value, "yyyyMMdd"), Format(DtpFecFin.Value, "yyyyMMdd")))

            FormCrystalReport.Text = "Reporte Cuadre Caja Detalle..."

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora
            'Form_CrystalReport.CrystalRptVwr.PrintReport()
            FormCrystalReport.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click
        Dispose()
        Close()

    End Sub

    'Private Sub FormRptCuadreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    LlenaDataCombo(CboCaja, ObjConst.Get_Constante("X", CboCaja.Tag), "nConValor", "cConDescripcion")
    'End Sub

End Class