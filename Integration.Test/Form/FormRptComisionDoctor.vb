Option Explicit On

Imports CrystalDecisions.CrystalReports.Engine

Imports Integration.BL.BL_Reportes

Public Class FormRptComisionDoctor
    Dim cStrNameReport As String = vbNullString
    Dim Servicio As New BLRptMaster

#Region "Estrutura grilla"

    Private Sub Formato01_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()

            Dim ColnSolAdmNumero As New DataGridViewTextBoxColumn()
            With ColnSolAdmNumero
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nSolAdmNumero"
                .HeaderText = "    Nro. Ficha     "
                .ReadOnly = True : .Visible = True
                .Width = 150
            End With
            .Columns.Add(ColnSolAdmNumero)

            Dim ColcPerCodigo As New DataGridViewTextBoxColumn()
            With ColcPerCodigo
                .DataPropertyName = "cPerCodigo"
                .HeaderText = "Cod. Médico"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColcPerCodigo)

            Dim ColcTratamiento As New DataGridViewTextBoxColumn()
            With ColcTratamiento
                .DataPropertyName = "cTratamiento"
                .HeaderText = "Tratamiento"
                .ReadOnly = True : .Visible = True
                .Width = 60
            End With
            .Columns.Add(ColcTratamiento)

            Dim ColMedico As New DataGridViewTextBoxColumn()
            With ColMedico
                .DataPropertyName = "Medico"
                .HeaderText = "Médico"
                .ReadOnly = True : .Visible = True
                .Width = 280
            End With
            .Columns.Add(ColMedico)

            Dim ColPaciente As New DataGridViewTextBoxColumn()
            With ColPaciente
                .DataPropertyName = "Paciente"
                .HeaderText = "Apellidos y Nombres del Paciente"
                .ReadOnly = True : .Visible = True
                .Width = 280
            End With
            .Columns.Add(ColPaciente)

            Dim ColdFecRegistro As New DataGridViewTextBoxColumn()
            With ColdFecRegistro
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy"
                .DataPropertyName = "dFecRegistro"
                .HeaderText = "Fecha Registro"
                .ReadOnly = True : .Visible = True
                .Width = 120
                '.DefaultCellStyle = DataGridViewCellStyle { Format=N, Alignment=TopRight }
            End With
            .Columns.Add(ColdFecRegistro)

            Dim ColdFecPago As New DataGridViewTextBoxColumn()
            With ColdFecPago
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy"
                .DataPropertyName = "dCtaCteFecPago"
                .HeaderText = "Fecha Pago"
                .ReadOnly = True : .Visible = True
                .Width = 120
                '.DefaultCellStyle = DataGridViewCellStyle { Format=N, Alignment=TopRight }
            End With
            .Columns.Add(ColdFecPago)

            Dim ColMuestras As New DataGridViewTextBoxColumn()
            With ColMuestras
                .DataPropertyName = "Muestras"
                .Name = "Muestras"
                .HeaderText = "Lista de Examenes"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 450
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColMuestras)

            Dim ColnImpTotal As New DataGridViewTextBoxColumn()
            With ColnImpTotal
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nImpTotal"
                .HeaderText = "Importe Servicio"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 90
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColnImpTotal)

            Dim ColnPorcentaje As New DataGridViewTextBoxColumn()
            With ColnPorcentaje
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nPorcentaje"
                .Name = "nPorcentaje"
                .HeaderText = "% Comisión"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 90
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColnPorcentaje)

            Dim ColPromotor As New DataGridViewTextBoxColumn()
            With ColPromotor
                .DataPropertyName = "cNombresPromotor"
                .HeaderText = "Promotor"
                .ReadOnly = True : .Visible = True
                .Width = 280
            End With
            .Columns.Add(ColPromotor)

            Dim ColPeriodo As New DataGridViewTextBoxColumn()
            With ColPeriodo
                .DataPropertyName = "cPeriodo"
                .HeaderText = "Periodo"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColPeriodo)

        End With

    End Sub

#End Region

    Private Sub FormRptComisionDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WindowState = FormWindowState.Maximized

        Call CargarFiltro()

        Formato01_DataGridView()
        FormatGrilla(Table1, Me)

        CboFiltro.SelectedIndex = 0 : CboDerivMedico.Enabled = False

    End Sub

    Sub CargarFiltro()
        If CboFiltro.SelectedIndex = 2 Then
            LlenaDataCombo(CboDerivMedico, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo , p.cPerApellido + space(1) +  p.cPerNombre  cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & TipoActividad.nPerRelTipoPromotor & " AND nPerRelEstado = 1", "cPerNombre"), "cPerCodigo", "cPerNombre")
            CboDerivMedico.AutoCompleteCustomSource = LoadAutoComplete(ObjSistemaServicio.Get_Value_Table("p.cPerCodigo , p.cPerApellido + space(1) +  p.cPerNombre  cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & TipoActividad.nPerRelTipoPromotor, "cPerNombre"), "cPerNombre")
        Else
            LlenaDataCombo(CboDerivMedico, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo , p.cPerApellido + space(1) +  p.cPerNombre  cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo IN (" & TipoActividad.nPerRelTipoMedico & "," & TipoActividad.nPerRelTipoMedicoSinComision & ")", "cPerNombre"), "cPerCodigo", "cPerNombre")
            CboDerivMedico.AutoCompleteCustomSource = LoadAutoComplete(ObjSistemaServicio.Get_Value_Table("p.cPerCodigo , p.cPerApellido + space(1) +  p.cPerNombre  cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo IN (" & TipoActividad.nPerRelTipoMedico & "," & TipoActividad.nPerRelTipoMedicoSinComision & ")", "cPerNombre"), "cPerNombre")
        End If
        
        CboDerivMedico.AutoCompleteMode = AutoCompleteMode.Suggest
        CboDerivMedico.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Private Sub FormRptComisionDoctor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Table1.Width = Width - 35
        Table1.Height = Height - 195
    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Close()
        Dispose()
    End Sub

    Private Sub C1CmdExportPDF_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportPDF.Click
        If Table1.RowCount = 0 Then Exit Sub

        ExportarDatosPDF(Table1, "MÉDICA (Laboratorio Clínico Especializado)", cStrNameReport)
    End Sub

    Private Sub C1CmdExportExcel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportExcel.Click
        If Table1.RowCount = 0 Then Exit Sub
        'Call GridAExcel(Table1)
        ExportarDatosExcel(Table1, cStrNameReport, "Desde: " + Format(DTPFecIni.Value, "dd/MM/yyyy") + " hasta: " + Format(DTPFecFin.Value, "dd/MM/yyyy"))
    End Sub

    Private Sub C1CmdReporte_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdReporte.Click

        Cursor.Current = Cursors.WaitCursor

        Dim CrReport As New ReportDocument

        Try

            'If BL.Get_ReportCuadraCaja("DET", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub
            ' Asigno el reporte 
            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT & "rptComisionMedico.rpt")

            CrReport.DataDefinition.FormulaFields("rangofec").Text = Chr(34) & "Desde: " & Format(DTPFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DTPFecFin.Value, "dd/MM/yyyy") & Chr(34)

            CrReport.SetDataSource(Servicio.Get_ComisionMedico_by_cPerJuridica_cPerMedico(StrcPerJuridica, IIf(CboFiltro.SelectedIndex = 0 Or CboFiltro.SelectedIndex = 2, "", CboDerivMedico.SelectedValue), DTPFecIni.Value, DTPFecFin.Value, , IIf(CboFiltro.SelectedIndex = 2, CboDerivMedico.SelectedValue, "")))

            FormCrystalReport.Text = "Reporte Comisión agrupado por Médico..."

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora
            'Form_CrystalReport.CrystalRptVwr.PrintReport()
            FormCrystalReport.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Try

            If Not ValidaRangoFechas(DTPFecIni.Value.Date, DTPFecFin.Value.Date) Then
                DTPFecIni.Value = DTPFecFin.Value
                Exit Sub
            End If

            Cursor.Current = Cursors.WaitCursor

            cStrNameReport = vbNullString

            Table1.DataSource = Servicio.Get_ComisionMedico_by_cPerJuridica_cPerMedico(StrcPerJuridica, IIf(CboFiltro.SelectedIndex = 0 Or CboFiltro.SelectedIndex = 2, "", CboDerivMedico.SelectedValue), DTPFecIni.Value, DTPFecFin.Value, , IIf(CboFiltro.SelectedIndex = 2, CboDerivMedico.SelectedValue, ""))
            cStrNameReport = "Reporte Comisión Médico"

            LblnSaldo.Text = FormatNumber(Suma_Columna("nPorcentaje", Table1), True)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Se encontraron errores.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub Table1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles Table1.CellFormatting

        With Table1
            For i As Integer = 0 To .Rows.Count - 1

                'If (CDbl(.Item("nCtaCteImporte", i).Value) > 0 And CDbl(.Item("nCtaCteImpAplicado", i).Value) = 0) Then .Rows(i).Cells("nCtaCteEstado").Value = 3

                Dim columnHeaderStyle As New DataGridViewCellStyle()

                '.Rows(i).Cells("DescCtaCteEstado").Style.Font.Style = FontStyle.Bold.ToString
                columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)

                '.ColumnHeadersDefaultCellStyle = columnHeaderStyle
                .RowHeadersDefaultCellStyle = columnHeaderStyle

                If .Rows(i).Cells("Muestras").Value.ToString = "TOTAL ACUMULADO->" Then
                    .Rows(i).Cells("Muestras").Style.ForeColor = Color.Blue

                End If
            Next
        End With

    End Sub

    Private Sub Table1_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Table1.CellPainting

        '-----------------------
        '-- Combinando Column 3 
        '-----------------------
        If e.ColumnIndex = 1 AndAlso e.RowIndex <> -1 Then

            Using gridBrush As Brush = New SolidBrush(Me.Table1.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                Using gridLinePen As Pen = New Pen(gridBrush)
                    ' Clear cell   
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    ' Draw line (bottom border and right border of current cell)   
                    'If next row cell has different content, only draw bottom border line of current cell   
                    If e.RowIndex < Table1.Rows.Count - 2 AndAlso Table1.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    ' Draw right border line of current cell   
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                    ' draw/fill content in current cell, and fill only one cell of multiple same cells   
                    If Not e.Value Is Nothing Then
                        If e.RowIndex > 0 AndAlso Table1.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                        Else
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                        End If
                    End If

                    e.Handled = True
                End Using
            End Using
        End If

    End Sub

    Private Sub CboFiltro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboFiltro.SelectionChangeCommitted
        If CboFiltro.SelectedIndex = 0 Then
            CboDerivMedico.Enabled = False
            CboDerivMedico.Text = ""
        Else
            CboDerivMedico.Enabled = True
        End If
        Call CargarFiltro()
    End Sub
End Class