Option Explicit On

Imports CrystalDecisions.CrystalReports.Engine
Imports Integration.BL.BL_Reportes
Imports Integration.DataIntegration
Imports Integration.BE
Imports Integration.BL
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormRptVentaporFechaAtencion
    Private dt As New DataTable()

    Private tb As New TextBox()
    Private tb1 As New TextBox()
    Private tb2 As New TextBox()
    Private tb3 As New TextBox()
    Private tb4 As New TextBox()
    Private tb5 As New TextBox()
    Private tb6 As New TextBox()
    Private tb7 As New TextBox()
    Private tb8 As New TextBox()

    Private tb9 As New TextBox()

    Private lb As New Label()

    Dim cStrNameReport As String = vbNullString
    Dim Servicio As New BLRptMaster
    Dim RequestEmp As New BE.Sistema.BE_ReqSistema

    Dim cNameRptFiltro As String = ""

#Region "Forma Grilla"

    Private Sub Formato01_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()

            '0
            Dim ColcPerJuridica As New DataGridViewTextBoxColumn()
            With ColcPerJuridica
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerJuridica"
                .HeaderText = "cPerJuridica"
                .ReadOnly = True : .Visible = False
                .Width = 100

            End With
            .Columns.Add(ColcPerJuridica)

            '1
            Dim ColcPerApellido As New DataGridViewTextBoxColumn()
            With ColcPerApellido
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "sucursal"
                .HeaderText = "Sucursal"
                .ReadOnly = True : .Visible = True
                .Width = 170
            End With
            .Columns.Add(ColcPerApellido)

            '2
            Dim ColnQtyFicha As New DataGridViewTextBoxColumn()
            With ColnQtyFicha
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nQtyFicha"
                .HeaderText = "Cant. Fichas"
                .ReadOnly = True : .Visible = True
                .Width = 80
            End With
            .Columns.Add(ColnQtyFicha)

            '3
            Dim ColfCtaCteImporte As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporte
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nEfectivo"
                .Name = "nEfectivo"
                .HeaderText = "Importe Venta"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCteImporte)

            '4
            Dim ColfCtaCtePagImportec As New DataGridViewTextBoxColumn()
            With ColfCtaCtePagImportec
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nCortesia"
                .Name = "nCortesia"
                .HeaderText = "Cortesía"
                .ToolTipText = "Importe por Cortesía"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCtePagImportec)

            '5
            Dim ColfCtaCteImporteSinIGV As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteSinIGV
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nSinIGV"
                .Name = "nSinIGV"
                .HeaderText = "Venta sin IGV"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCteImporteSinIGV)

            '6
            Dim ColfCtaCteComisionMed As New DataGridViewTextBoxColumn()
            With ColfCtaCteComisionMed
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fComisionMedico"
                .Name = "fComisionMedico"
                .HeaderText = "Comisión Médico"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCteComisionMed)

            '7
            Dim ColfCtaCteUtilidadNeta As New DataGridViewTextBoxColumn()
            With ColfCtaCteUtilidadNeta
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fVentaSinComisionMed"
                .Name = "fVentaSinComisionMed"
                .HeaderText = "Utilidad Neta"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCteUtilidadNeta)

        End With

    End Sub

    'Pendientes
    Private Sub Formato02_DataGridView()

        With Table2
            .DataSource = Nothing
            .AutoGenerateColumns = False
            .Columns.Clear()

            '0
            Dim ColcPerJuridica As New DataGridViewTextBoxColumn()
            With ColcPerJuridica
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerJuridica"
                .Name = "cPerJuridica"
                .HeaderText = "cPerJuridica"
                .ReadOnly = True : .Visible = False
                .Width = 100

            End With
            .Columns.Add(ColcPerJuridica)

            '1
            Dim ColcSucursal As New DataGridViewTextBoxColumn()
            With ColcSucursal
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "Sucursal"
                .Name = "Sucursal"
                .HeaderText = "Sucursal"
                .ReadOnly = True : .Visible = True
                .Width = 180

            End With
            .Columns.Add(ColcSucursal)

            '2
            Dim ColcPerCodigoTerceros As New DataGridViewTextBoxColumn()
            With ColcPerCodigoTerceros
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerCodigoTerceros"
                .Name = "cPerCodigoTerceros"
                .HeaderText = "Código"
                .ReadOnly = True : .Visible = True
                .Width = 100

            End With
            .Columns.Add(ColcPerCodigoTerceros)

            '3
            Dim ColcPerApellido As New DataGridViewTextBoxColumn()
            With ColcPerApellido
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "Cliente"
                .Name = "Cliente"
                .HeaderText = "Cliente / Laboratorio / Convenio"
                .ReadOnly = True : .Visible = True
                .Width = 300
            End With
            .Columns.Add(ColcPerApellido)

            '4
            Dim ColfCtaCtePagImporte As New DataGridViewTextBoxColumn()
            With ColfCtaCtePagImporte
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nSaldo"
                .Name = "fCtaCtePagImporte"
                .HeaderText = "Saldo Pendiente"
                .ToolTipText = "Pago pendiente por cobrar."
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCtePagImporte)

            '5
            Dim ColfCtaCtePagImportecred As New DataGridViewTextBoxColumn()
            With ColfCtaCtePagImportecred
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCtePagImportecred"
                .Name = "fCtaCtePagImportecred"
                .HeaderText = "Credito Pendiente"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCtePagImportecred)

            '6
            Dim ColfImpTotal As New DataGridViewTextBoxColumn()
            With ColfImpTotal
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fImpTotal"
                .Name = "fImpTotal"
                .HeaderText = "Total por Cobrar"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfImpTotal)

        End With

    End Sub

    'Tipo Atencion
    Private Sub Formato03_DataGridView()

        With Table2
            .DataSource = Nothing
            .AutoGenerateColumns = False
            .Columns.Clear()

            '0
            Dim ColcPerJuridica As New DataGridViewTextBoxColumn()
            With ColcPerJuridica
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerJuridica"
                .Name = "cPerJuridica"
                .HeaderText = "cPerJuridica"
                .ReadOnly = True : .Visible = False
                .Width = 100

            End With
            .Columns.Add(ColcPerJuridica)

            '1
            Dim ColcSucursal As New DataGridViewTextBoxColumn()
            With ColcSucursal
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "Sucursal"
                .Name = "Sucursal"
                .HeaderText = "Sucursal"
                .ReadOnly = True : .Visible = True
                .Width = 140

            End With
            .Columns.Add(ColcSucursal)

            '2
            Dim ColnIntCodigo As New DataGridViewTextBoxColumn()
            With ColnIntCodigo
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nIntCodigo"
                .Name = "nIntCodigo"
                .HeaderText = "Código"
                .ReadOnly = True : .Visible = False
                .Width = 100

            End With
            .Columns.Add(ColnIntCodigo)

            '3
            Dim ColcIntDescripcion As New DataGridViewTextBoxColumn()
            With ColcIntDescripcion
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cIntDescripcion"
                .Name = "cIntDescripcion"
                .HeaderText = "Tipo Atención"
                .ReadOnly = True : .Visible = True
                .Width = 140
            End With
            .Columns.Add(ColcIntDescripcion)

            '4
            Dim ColQtyFichas As New DataGridViewTextBoxColumn()
            With ColQtyFichas
                .DefaultCellStyle.Format = "#,##0"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nQtyFichas"
                .Name = "nQtyFichas"
                .HeaderText = "Cantidad Fichas"
                .ToolTipText = "Fichas pagadas y no pagadas"
                .ReadOnly = True : .Visible = True
                .Width = 60
            End With
            .Columns.Add(ColQtyFichas)

            '5
            Dim ColfCtaCteImporteB As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteB
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nEfectivo"
                .Name = "nEfectivo"
                .HeaderText = "Importe con IGV"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteB)

            '6
            Dim ColfCtaCteImporteG As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteG
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nCortesia"
                .Name = "nCortesia"
                .HeaderText = "Cortesía"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteG)

            '7
            Dim ColfCtaCteImportenSinIGV As New DataGridViewTextBoxColumn()
            With ColfCtaCteImportenSinIGV
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nSinIGV"
                .Name = "nSinIGV"
                .HeaderText = "Importe sin IGV"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImportenSinIGV)

            '8
            Dim ColfCtaCteImporteComisionMedico As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteComisionMedico
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fComisionMedico"
                .Name = "fComisionMedico"
                .HeaderText = "Comisión Médico"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteComisionMedico)

            '9
            Dim ColfCtaCteImporteSinComisionMed As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteSinComisionMed
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fVentaSinComisionMed"
                .Name = "fVentaSinComisionMed"
                .HeaderText = "Venta Neta sin comisiones"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteSinComisionMed)

        End With

    End Sub

    'Venta Laboratorio / Convenio
    Private Sub Formato04_DataGridView()

        With Table2
            .DataSource = Nothing
            .AutoGenerateColumns = False
            .Columns.Clear()

            '0
            Dim ColcPerJuridica As New DataGridViewTextBoxColumn()
            With ColcPerJuridica
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerJuridica"
                .Name = "cPerJuridica"
                .HeaderText = "cPerJuridica"
                .ReadOnly = True : .Visible = False
                .Width = 100

            End With
            .Columns.Add(ColcPerJuridica)

            '1
            Dim ColcSucursal As New DataGridViewTextBoxColumn()
            With ColcSucursal
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "Sucursal"
                .Name = "Sucursal"
                .HeaderText = "Sucursal"
                .ReadOnly = True : .Visible = True
                .Width = 140

            End With
            .Columns.Add(ColcSucursal)

            '2
            Dim ColnIntCodigo As New DataGridViewTextBoxColumn()
            With ColnIntCodigo
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nIntCodigo"
                .Name = "nIntCodigo"
                .HeaderText = "Código"
                .ReadOnly = True : .Visible = False
                .Width = 100

            End With
            .Columns.Add(ColnIntCodigo)

            '3
            Dim ColcIntDescripcion As New DataGridViewTextBoxColumn()
            With ColcIntDescripcion
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cIntDescripcion"
                .Name = "cIntDescripcion"
                .HeaderText = "Tipo Atención"
                .ReadOnly = True : .Visible = True
                .Width = 140
            End With
            .Columns.Add(ColcIntDescripcion)

            '4
            Dim ColcPerCodigoTerceros As New DataGridViewTextBoxColumn()
            With ColcPerCodigoTerceros
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerCodigoTerceros"
                .Name = "cPerCodigoTerceros"
                .HeaderText = "Código Cliente"
                .ReadOnly = True : .Visible = True
                .Width = 100

            End With
            .Columns.Add(ColcPerCodigoTerceros)

            '5
            Dim ColCliente As New DataGridViewTextBoxColumn()
            With ColCliente
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "Cliente"
                .Name = "Cliente"
                .HeaderText = "Laboratorio / Convenio"
                .ReadOnly = True : .Visible = True
                .Width = 300
            End With
            .Columns.Add(ColCliente)

            '6
            Dim ColQtyFichas As New DataGridViewTextBoxColumn()
            With ColQtyFichas
                .DefaultCellStyle.Format = "#,##0"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nQtyFichas"
                .Name = "nQtyFichas"
                .HeaderText = "Cantidad Fichas"
                .ToolTipText = ""
                .ReadOnly = True : .Visible = True
                .Width = 60
            End With
            .Columns.Add(ColQtyFichas)

            '7
            Dim ColfCtaCteImporteB As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteB
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nEfectivo"
                .Name = "nEfectivo"
                .HeaderText = "Importe Bruto"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteB)

            '8
            Dim ColfCtaCteImporteG As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteG
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nCortesia"
                .Name = "nCortesia"
                .HeaderText = "Cortesía"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteG)


            '9
            Dim ColfCtaCteImportenSinIGV As New DataGridViewTextBoxColumn()
            With ColfCtaCteImportenSinIGV
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nSinIGV"
                .Name = "nSinIGV"
                .HeaderText = "Importe sin IGV"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImportenSinIGV)

            '10
            Dim ColfCtaCteImporteComisionMedico As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteComisionMedico
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fComisionMedico"
                .Name = "fComisionMedico"
                .HeaderText = "Comisión Médico"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteComisionMedico)

            '11
            Dim ColfCtaCteImporteSinComisionMed As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteSinComisionMed
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fVentaSinComisionMed"
                .Name = "fVentaSinComisionMed"
                .HeaderText = "Venta Neta sin comisiones"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteSinComisionMed)



        End With

    End Sub

#End Region

    Private Sub VerDetalle_Filtros(nflagFiltro As String)
        Table2.DataSource = Nothing
        'detalle saldo pendiente
        Table2.DataSource = Servicio.Get_Detalle_Venta_by_Tipo_FechaAtencion_Group_cPerJurCodigo(IIf(CboFiltro.SelectedIndex = 0, "", CbocPerJurCodigo.SelectedValue), Format(DTPFecIni.Value, "yyyyMMdd"), Format(DTPFecFin.Value, "yyyyMMdd"), nflagFiltro)
    End Sub

    Private Sub GraficoTorta()

        For Each series As Object In Chart1.Series
            series.Points.Clear()
        Next

        Chart1.Series("Series1").XValueMember = "sucursal"
        Chart1.Series("Series1").YValueMembers = "nEfectivo"

        Chart1.DataSource = Servicio.Get_Venta_by_cPerJurCodigo_and_FechaAtencion(IIf(CboFiltro.SelectedIndex = 0, "", CbocPerJurCodigo.SelectedValue), Format(DTPFecIni.Value, "yyyyMMdd"), Format(DTPFecFin.Value, "yyyyMMdd"))

        Chart1.Series(0)("PieLabelStyle") = "Outside"
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
        Chart1.ChartAreas(0).Area3DStyle.Inclination = 0
        Chart1.ChartAreas(0).Area3DStyle.Rotation = 0
        Chart1.Series(0).LegendText = "#PERCENT{P2}"

    End Sub

    Sub Cargar_Empresas_por_Permisos()

        Dim ObjBL As New BL_Sistema

        RequestEmp.cPerCodigo = StrUser
        RequestEmp.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
        LlenaDataCombo(CbocPerJurCodigo, ObjBL.Get_Empresas_Per_Mod(RequestEmp), "cPerCodigo", "cPerNombre")

    End Sub

    Private Sub CboFiltro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboFiltro.SelectionChangeCommitted
        If CboFiltro.SelectedIndex = 0 Then CbocPerJurCodigo.Enabled = False : CbocPerJurCodigo.Text = "" Else CbocPerJurCodigo.Enabled = True
    End Sub

    Private Sub FormRptVentaporSucursalConso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Formato01_DataGridView()
        FormatGrilla(Table1, Me, True, 40)

        'Formato02_DataGridView()
        FormatGrilla(Table2, Me, True, 40)

        Cargar_Empresas_por_Permisos()
        CboFiltro.SelectedIndex = 0 : CbocPerJurCodigo.Enabled = False

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click

        Close()
        Dispose()

    End Sub

    Private Sub C1CmdExportExcel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportExcel.Click

        If Table1.RowCount = 0 Then Exit Sub
        'Call GridAExcel(Table1)
        ExportarDatosExcel(Table1, cStrNameReport, "Desde: " + Format(DTPFecIni.Value, "dd/MM/yyyy") + " hasta: " + Format(DTPFecFin.Value, "dd/MM/yyyy"))

    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click

        Try

            If Not ValidaRangoFechas(DTPFecIni.Value.Date, DTPFecFin.Value.Date) Then
                DTPFecIni.Value = DTPFecFin.Value
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            cStrNameReport = vbNullString

            Table1.DataSource = Servicio.Get_Venta_by_cPerJurCodigo_and_FechaAtencion(IIf(CboFiltro.SelectedIndex = 0, "", CbocPerJurCodigo.SelectedValue), Format(DTPFecIni.Value, "yyyyMMdd"), Format(DTPFecFin.Value, "yyyyMMdd"))
            cStrNameReport = "Reporte Venta Consolidado por Fecha de Atención"

            If RbtVtaTipoAtencion.Checked Then
                RbtVtaTipoAtencion_Click(RbtVtaTipoAtencion, Nothing)
            ElseIf RbtDetVtaLabConv.Checked Then
                RbtDetVtaLabConv_Click(RbtDetVtaLabConv, Nothing)
            End If

            LblImpMedico.Text = FormatNumber(Suma_Columna("nEfectivo", Table1), True)
            LblImpSinIGV.Text = FormatNumber(Suma_Columna("nSinIGV", Table1), True)
            'LblnSaldo.Text = FormatNumber(Suma_Columna("nImpTotalBruto", Table1), True)

            '//Mostrando Footer en un DataGridView
            lb.Text = "Totales ->"
            lb.Height = tb.Height
            lb.AutoSize = False
            lb.TextAlign = ContentAlignment.MiddleCenter

            'Col1
            Dim X As Integer = Me.Table1.GetCellDisplayRectangle(1, -1, True).Location.X
            lb.Width = Me.Table1.Columns(1).Width + X
            lb.Location = New Point(1, Me.Table1.Height - tb.Height)
            Me.Table1.Controls.Add(lb)

            tb.Width = Me.Table1.Columns(2).Width
            X = Me.Table1.GetCellDisplayRectangle(2, -1, True).Location.X
            tb.Location = New Point(X, Me.Table1.Height - tb.Height)
            Me.Table1.Controls.Add(tb)

            'tb1
            tb1.Width = Me.Table1.Columns(3).Width
            X = Me.Table1.GetCellDisplayRectangle(3, -1, True).Location.X
            tb1.Location = New Point(X, Me.Table1.Height - tb1.Height)
            Me.Table1.Controls.Add(tb1)

            'tb2
            tb2.Width = Me.Table1.Columns(4).Width
            X = Me.Table1.GetCellDisplayRectangle(4, -1, True).Location.X
            tb2.Location = New Point(X, Me.Table1.Height - tb2.Height)
            Me.Table1.Controls.Add(tb2)

            'tb3
            tb3.Width = Me.Table1.Columns(5).Width
            X = Me.Table1.GetCellDisplayRectangle(5, -1, True).Location.X
            tb3.Location = New Point(X, Me.Table1.Height - tb3.Height)
            Me.Table1.Controls.Add(tb3)

            'tb4
            tb4.Width = Me.Table1.Columns(6).Width
            X = Me.Table1.GetCellDisplayRectangle(6, -1, True).Location.X
            tb4.Location = New Point(X, Me.Table1.Height - tb4.Height)
            Me.Table1.Controls.Add(tb4)

            'tb5
            tb5.Width = Me.Table1.Columns(7).Width
            X = Me.Table1.GetCellDisplayRectangle(7, -1, True).Location.X
            tb5.Location = New Point(X, Me.Table1.Height - tb5.Height)
            Me.Table1.Controls.Add(tb5)

            AddHandler Me.Table1.CellPainting, AddressOf DataGridView1_CellPainting
            AddHandler Me.Table1.CellEndEdit, AddressOf DataGridView1_CellEndEdit

            Dim sum As Double = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(2, i).Value)
            Next

            tb.ReadOnly = True
            tb.TextAlign = HorizontalAlignment.Center
            tb.Text = sum.ToString()

            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(3, i).Value)
            Next

            tb1.ReadOnly = True
            tb1.TextAlign = HorizontalAlignment.Center
            tb1.Text = sum.ToString()

            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(4, i).Value)
            Next

            tb2.ReadOnly = True
            tb2.TextAlign = HorizontalAlignment.Right
            tb2.Text = FormatNumber(sum, True)

            'tb3
            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(5, i).Value)
            Next
            tb3.ReadOnly = True
            tb3.TextAlign = HorizontalAlignment.Right
            tb3.Text = FormatNumber(sum, True)

            'tb4
            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(6, i).Value)
            Next
            tb4.ReadOnly = True
            tb4.TextAlign = HorizontalAlignment.Right
            tb4.Text = Format(sum, "#,##0.00 ; ( -#,##0.00)")

            'tb5
            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(7, i).Value)
            Next
            tb5.ReadOnly = True
            tb5.TextAlign = HorizontalAlignment.Right
            tb5.Text = Format(sum, "#,##0.00 ; ( -#,##0.00)")

            GraficoTorta()

            System.Windows.Forms.Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Se encontraron errores.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    '//Para mostrar Foorter en un DataGridView
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Table1.CellEndEdit

        Select Case e.ColumnIndex
            Case 2, 3, 7, 8, 9, 10, 11, 12, 14
                'calculate the sum total
                Dim sum As Double = 0
                For i As Integer = 0 To Me.Table1.Rows.Count - 1
                    sum += Convert.ToDouble(Me.Table1(2, i).Value)
                Next
                tb.Text = sum.ToString()

                'tb1
                sum = 0
                For i As Integer = 0 To Me.Table1.Rows.Count - 1
                    sum += Convert.ToDouble(Me.Table1(3, i).Value)
                Next
                tb1.Text = FormatNumber(sum, True)

                'tb2
                sum = 0
                For i As Integer = 0 To Me.Table1.Rows.Count - 1
                    sum += Convert.ToDouble(Me.Table1(7, i).Value)
                Next
                tb2.Text = FormatNumber(sum, True)

                'tb3
                sum = 0
                For i As Integer = 0 To Me.Table1.Rows.Count - 1
                    sum += Convert.ToDouble(Me.Table1(8, i).Value)
                Next
                tb3.Text = FormatNumber(sum, True)

                'tb4
                sum = 0
                For i As Integer = 0 To Me.Table1.Rows.Count - 1
                    sum += Convert.ToDouble(Me.Table1(9, i).Value)
                Next
                tb4.Text = FormatNumber(sum, True)

                'tb5
                sum = 0
                For i As Integer = 0 To Me.Table1.Rows.Count - 1
                    sum += Convert.ToDouble(Me.Table1(10, i).Value)
                Next
                tb5.Text = FormatNumber(sum, True)

                'tb6
                sum = 0
                For i As Integer = 0 To Me.Table1.Rows.Count - 1
                    sum += Convert.ToDouble(Me.Table1(11, i).Value)
                Next
                tb6.Text = FormatNumber(sum, True)

                'tb7
                sum = 0
                For i As Integer = 0 To Me.Table1.Rows.Count - 1
                    sum += Convert.ToDouble(Me.Table1(12, i).Value)
                Next
                tb7.Text = FormatNumber(sum, True)

                'tb9
                sum = 0
                For i As Integer = 0 To Me.Table1.Rows.Count - 1
                    sum += Convert.ToDouble(Me.Table1(13, i).Value)
                Next
                tb9.Text = FormatNumber(sum, True)

                'tb8
                sum = 0
                For i As Integer = 0 To Me.Table1.Rows.Count - 1
                    sum += Convert.ToDouble(Me.Table1(15, i).Value)
                Next
                tb8.Text = FormatNumber(sum, True)

        End Select

    End Sub

    '//Para mostrar Foorter en un DataGridView
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Table1.CellPainting
        Dim X As Integer = Me.Table1.GetCellDisplayRectangle(1, -1, True).Location.X
        lb.Width = Me.Table1.Columns(1).Width + X
        lb.Location = New Point(1, Me.Table1.Height - tb.Height)

        tb.Width = Me.Table1.Columns(2).Width
        X = Me.Table1.GetCellDisplayRectangle(2, -1, True).Location.X
        tb.Location = New Point(X, Me.Table1.Height - tb.Height)

        'tb1
        tb1.Width = Me.Table1.Columns(3).Width
        X = Me.Table1.GetCellDisplayRectangle(3, -1, True).Location.X
        tb1.Location = New Point(X, Me.Table1.Height - tb1.Height)

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

                If Convert.ToDouble(.Rows(i).Cells("nCortesia").Value) < 0 Then
                    .Rows(i).Cells("nCortesia").Style.ForeColor = Color.Red
                Else
                    .Rows(i).Cells("nCortesia").Style.ForeColor = Color.Black
                End If
            Next
        End With

    End Sub

    Private Sub Table2_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Table2.CellPainting

        '-----------------------
        '-- Combinando Column 3 
        '-----------------------
        If e.ColumnIndex = 1 AndAlso e.RowIndex <> -1 Then

            Using gridBrush As Brush = New SolidBrush(Me.Table2.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                Using gridLinePen As Pen = New Pen(gridBrush)
                    ' Clear cell   
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    ' Draw line (bottom border and right border of current cell)   
                    'If next row cell has different content, only draw bottom border line of current cell   
                    If e.RowIndex < Table2.Rows.Count - 2 AndAlso Table2.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    ' Draw right border line of current cell   
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                    ' draw/fill content in current cell, and fill only one cell of multiple same cells   
                    If Not e.Value Is Nothing Then
                        If e.RowIndex > 0 AndAlso Table2.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                        Else
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                        End If
                    End If

                    e.Handled = True
                End Using
            End Using
        End If

    End Sub

    Private Sub C1CmdExportSaldo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportSaldo.Click

        If Table2.RowCount = 0 Then Exit Sub
        If RbtPendientes.Checked Then
            cNameRptFiltro = "Pendientes/Créditos por Cobrar"
        ElseIf RbtVtaTipoAtencion.Checked Then
            cNameRptFiltro = "Ventas según Fecha de Atención agrupado por Tipo Atención"
        ElseIf RbtDetVtaLabConv.Checked Then
            cNameRptFiltro = "Ventas según Fecha de Atención agrupado por Laboratorio/Convenio"
        End If

        ExportarDatosExcel(Table2, cNameRptFiltro, "Desde: " + Format(DTPFecIni.Value, "dd/MM/yyyy") + " hasta: " + Format(DTPFecFin.Value, "dd/MM/yyyy"))

    End Sub

    Private Sub RbtVtaTipoAtencion_Click(sender As Object, e As EventArgs) Handles RbtVtaTipoAtencion.Click

        Formato03_DataGridView()
        VerDetalle_Filtros("TA")

    End Sub

    Private Sub RbtDetVtaLabConv_Click(sender As Object, e As EventArgs) Handles RbtDetVtaLabConv.Click

        Formato04_DataGridView()
        VerDetalle_Filtros("LC")

    End Sub

    Private Sub RbtVtaTipoAtencion_CheckedChanged(sender As Object, e As EventArgs) Handles RbtVtaTipoAtencion.CheckedChanged

    End Sub
End Class