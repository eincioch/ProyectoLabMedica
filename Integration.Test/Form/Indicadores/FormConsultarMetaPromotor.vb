Imports Integration.BL.BL_Persona
Imports Integration.BE.Persona
Imports Integration.BE.Periodo

Public Class FormConsultarMetaPromotor

    Private Sub CalcTotales()
        LblResumMeta.Text = FormatNumber(Suma_Columna("nMetValor", Table1), True)
        LblResumAvance.Text = FormatNumber(Suma_Columna("nImpTotal", Table1), True)
        LblResumNecesidad.Text = FormatNumber(Suma_Columna("nNecesidadxDia", Table1), True)
        LblResumFalta.Text = FormatNumber(Suma_Columna("nImpFalta", Table1), True)

        LblDetMeta.Text = FormatNumber(Suma_Columna("nMetValorDet", Table2), True)
        LblDetAvance.Text = FormatNumber(Suma_Columna("nImpTotalDet", Table2), True)
        LblDetNecesidad.Text = FormatNumber(Suma_Columna("nNecesidadxDiaDet", Table2), True)
        LblDetFalta.Text = FormatNumber(Suma_Columna("nImpFaltaDet", Table2), True)

    End Sub

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

    Private Sub FormConsultarMetaPromotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            FormatGrilla(Table1, Me)
            FormatGrilla(Table2, Me)

            Me.WindowState = FormWindowState.Maximized
            Table2.AutoGenerateColumns = False
            'Llena Año
            ObtenerPeriodosPorSucursal(CboAnno, StrcPerJuridica)
            'CboAnno.SelectedIndex = 1
            CboAnno_SelectionChangeCommitted(CboAnno, Nothing)
            CboAnno.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try


    End Sub

    Private Sub CboAnno_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboAnno.SelectionChangeCommitted

        If CboAnno.SelectedValue = -1 Then Exit Sub
        ObtenerPeriodosPorSucursal(CboPeriodo, StrcPerJuridica, CboAnno.SelectedValue, "M")

    End Sub

    Private Sub C1CmdMostrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdMostrar.Click

        Try
            Dim gestionarMetaPromotorServicio As New GestionarMetaPromotorServicio

            Dim periodo As New Periodo
            periodo.nPrdCodigo = CboPeriodo.SelectedValue


            If Not ChkRFechas.Checked Then
                periodo.cFlag = "R"
                Table1.DataSource = gestionarMetaPromotorServicio.Get_MetaPromotor_Avance(periodo)

                periodo.cFlag = "D"
                Table2.DataSource = gestionarMetaPromotorServicio.Get_MetaPromotor_Avance(periodo)
            Else
                periodo.cFlag = "R"
                Table1.DataSource = gestionarMetaPromotorServicio.Get_MetaPromotor_Avance(periodo, "F", Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"))

                periodo.cFlag = "D"
                Table2.DataSource = gestionarMetaPromotorServicio.Get_MetaPromotor_Avance(periodo, "F", Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"))
            End If

            CalcTotales()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub C1CmdExportExcel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportExcel.Click
        If Table1.RowCount = 0 Then Exit Sub
        ExportarDatosExcel(Table1, "Avance Meta según Indicador", "Periodo: " & CboPeriodo.Text & "Fecha: " & Date.Now & " Hora: " & Now.Hour & ":" & Now.Minute)
    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Close()
        Dispose()

    End Sub

    Private Sub C1CmdExportDet_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportDet.Click
        If Table2.RowCount = 0 Then Exit Sub
        ExportarDatosExcel(Table2, "Detalle Avance Meta por Asignación", "Periodo: " & CboPeriodo.Text & "Fecha: " & Date.Now & " Hora: " & Now.Hour & ":" & Now.Minute)
    End Sub

    Private Sub ChkRFechas_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRFechas.CheckedChanged
        If ChkRFechas.Checked Then PnlRFechas.Enabled = True Else PnlRFechas.Enabled = False

    End Sub

    Private Sub Table2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table2.CellContentDoubleClick
        Dim messageBoxVB As New System.Text.StringBuilder()
        
        Dim nTipo As Long
        nTipo = Table2.CurrentRow.Cells(0).Value

        If nTipo = TipoAtencion.LabExterno Then
            FormConsultarDetalleMetaPromotor.Mostrar(Table2.CurrentRow.Cells(2).Value, nTipo, Table2.CurrentRow.Cells(1).Value, CboPeriodo.SelectedValue, ChkRFechas.Checked, "L", Table2.CurrentRow.Cells(10).Value, Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"))
        ElseIf nTipo = TipoAtencion.Convenio Then
            FormConsultarDetalleMetaPromotor.Mostrar(Table2.CurrentRow.Cells(2).Value, nTipo, Table2.CurrentRow.Cells(1).Value, CboPeriodo.SelectedValue, ChkRFechas.Checked, "C", Table2.CurrentRow.Cells(10).Value, Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"))
        ElseIf nTipo = TipoAtencion.CentroSalud Then
            FormConsultarDetalleMetaPromotor.Mostrar(Table2.CurrentRow.Cells(2).Value, nTipo, Table2.CurrentRow.Cells(1).Value, CboPeriodo.SelectedValue, ChkRFechas.Checked, "U", Table2.CurrentRow.Cells(10).Value, Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"))
        ElseIf nTipo = TipoAtencion.Campaña Then
            FormConsultarDetalleMetaPromotor.Mostrar(Table2.CurrentRow.Cells(2).Value, nTipo, Table2.CurrentRow.Cells(1).Value, CboPeriodo.SelectedValue, ChkRFechas.Checked, "N", Table2.CurrentRow.Cells(10).Value, Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"))
        ElseIf nTipo = 1000 Then
            FormConsultarDetalleMetaPromotor.Mostrar(Table2.CurrentRow.Cells(2).Value, nTipo, Table2.CurrentRow.Cells(1).Value, CboPeriodo.SelectedValue, ChkRFechas.Checked, "M", Table2.CurrentRow.Cells(10).Value, Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"))
        Else
            MessageBox.Show("No hay información que mostrar para este tipo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class