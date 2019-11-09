Imports Integration.BE.CtasCtes
Imports Integration.BL.BL_CtaCtes
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormReportCtaCteListaServicio


    Private Sub C1BtnImprimir_Click(sender As Object, e As EventArgs) Handles C1BtnImprimir.Click

        Cursor.Current = Cursors.WaitCursor

        Dim CrReport As New ReportDocument

        Try
            Dim title As String = ""
            Dim gestionarCtaCteListaServicioServicio As New GestionarCtaCteListaServicioServicio

            CrReport = New ReportDocument()

            If RBOption01.Checked Then CrReport.Load(cPathRPT & "rptListadoExamenesConPrecio.rpt") : title = RBOption01.Text
            If RBOption02.Checked Then CrReport.Load(cPathRPT & "rptListadoExamenes.rpt") : title = RBOption02.Text
            If RBOption03.Checked Then CrReport.Load(cPathRPT & "rptListadoExamenesDetConPrecio.rpt") : title = RBOption03.Text
            If RBOption04.Checked Then CrReport.Load(cPathRPT & "rptListadoExamenesLocalTercerizada.rpt") : title = RBOption04.Text
            If RBOption05.Checked Then
                CrReport.Load(cPathRPT & "rptListadoExamenesConPrecioDscto.rpt") : title = RBOption05.Text
                'Tick: Primero carga el RPT desde las FormulaFields
                CrReport.DataDefinition.FormulaFields("porcdscto").Text = Chr(34) & TxtPorc.Text & Chr(34)
            End If

            'CrReport.DataDefinition.FormulaFields("rangofec").Text = Chr(34) & "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy") & Chr(34)

            CrReport.SetDataSource(gestionarCtaCteListaServicioServicio.Get_CtaCteListaServicio())

            FormCrystalReport.Text = "Reporte " + title

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora
            'Form_CrystalReport.CrystalRptVwr.PrintReport()
            FormCrystalReport.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Cursor.Current = Cursors.Default


    End Sub

    Private Sub FormReportCtaCteListaServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class