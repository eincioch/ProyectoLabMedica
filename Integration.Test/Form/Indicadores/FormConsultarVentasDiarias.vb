'Imports Integration.BL.BL_Persona
'Imports Integration.BE.Persona
Imports Integration.BE.Periodo
Imports Integration.BL.BL_Sistema
Imports Integration.BE.Sistema
Imports Integration.BL.BL_Reportes

Public Class FormConsultarVentasDiarias

    Private Sub FormConsultarMetaPromotor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F5))
                C1CmdMostrar_Click(C1CmdMostrar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F8))
                C1CmdExportExcel_Click(C1CmdExportExcel, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select

    End Sub

    Private Sub FormConsultarVentasDiarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            FormatGrilla(Table1, Me)

            Me.WindowState = FormWindowState.Maximized

            'Llena Año
            ObtenerPeriodosPorSucursal(CboAnno, StrcPerJuridica)
            'CboAnno.SelectedIndex = 1
            CboAnno_SelectionChangeCommitted(CboAnno, Nothing)
            CboAnno.SelectedIndex = 0

            LlenaDataCombo(cboReporte, ObjInterface.Get_Interface(CLng(TokenByKey(cboReporte.Tag, "nIntClase")), CLng(TokenByKey(cboReporte.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")
            If cboReporte.Items.Count > 0 Then
                cboReporte.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try


    End Sub

    Private Sub CboAnno_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboAnno.SelectionChangeCommitted

        If CboAnno.SelectedValue = -1 Then Exit Sub
        ObtenerPeriodosPorSucursal(CboPeriodo, StrcPerJuridica, CboAnno.SelectedValue, "M")

        If CboPeriodo.SelectedValue = -1 Then Exit Sub

        Dim Request As New BE_ReqPeriodo
        Dim Obj As New BL.BL_Sistema

        Request.nObjCodigo = CboPeriodo.SelectedValue

        Dim dt As New DataTable
        dt = Obj.Get_Periodo_By_nPrdCodigo(Request)

        If dt.Rows.Count > 0 Then
            DTPFecIni.Text = dt.Rows(0)("dPrdIni")
            DTPFecFin.Text = dt.Rows(0)("dPrdFin")
        End If
        Table1.DataSource = Nothing
    End Sub

    Private Sub C1CmdMostrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdMostrar.Click

        Try
            Dim reporte As New BL.BL_Reportes.BLRptMaster
            Table1.DataSource = Nothing
            Table1.DataSource = reporte.Get_VentasDiarias_Segun_Reporte(Format(DTPFecIni.Value, "yyyyMMdd"), Format(DTPFecFin.Value, "yyyyMMdd"), cboReporte.SelectedValue.ToString)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub C1CmdExportExcel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportExcel.Click
        If Table1.RowCount = 0 Then Exit Sub
        ExportarDatosExcel(Table1, cboReporte.Text.ToString.ToUpper, "Periodo: Desde " & Format(DTPFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DTPFecFin.Value, "dd/MM/yyyy") & " - Fecha Emisión: " & Date.Now & " Hora: " & Now.Hour & ":" & Now.Minute)
    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Close()
        Dispose()

    End Sub

    Private Sub CboPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPeriodo.SelectedIndexChanged
        If CboPeriodo.SelectedValue = -1 Then Exit Sub
        Table1.DataSource = Nothing

        Dim Request As New BE_ReqPeriodo
        Dim Obj As New BL.BL_Sistema

        Request.nObjCodigo = CboPeriodo.SelectedValue

        Dim dt As New DataTable
        dt = Obj.Get_Periodo_By_nPrdCodigo(Request)

        If dt.Rows.Count > 0 Then
            DTPFecIni.Text = dt.Rows(0)("dPrdIni")
            DTPFecFin.Text = dt.Rows(0)("dPrdFin")
        End If
    End Sub

    Private Sub cboReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReporte.SelectedIndexChanged
        Table1.DataSource = Nothing
    End Sub
End Class