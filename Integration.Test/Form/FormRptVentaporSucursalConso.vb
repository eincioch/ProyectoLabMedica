Option Explicit On

Imports CrystalDecisions.CrystalReports.Engine
Imports Integration.BL.BL_Reportes
Imports Integration.DataIntegration
Imports Integration.BE
Imports Integration.BL
Imports System.Windows.Forms.DataVisualization.Charting


Public Class FormRptVentaporSucursalConso

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
                .DataPropertyName = "cPerApellido"
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
            Dim ColnCantMuestra As New DataGridViewTextBoxColumn()
            With ColnCantMuestra
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nCantMuestra"
                .HeaderText = "Cant. Muestras"
                .ReadOnly = True : .Visible = True
                .Width = 80
            End With
            .Columns.Add(ColnCantMuestra)

            '4
            Dim ColnImpTotal As New DataGridViewTextBoxColumn()
            With ColnImpTotal
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nImpTotal"
                .Name = "nImpTotal"
                .HeaderText = "Importe Fichas"
                .ReadOnly = True : .Visible = False
                .Width = 120
            End With
            .Columns.Add(ColnImpTotal)

            '5
            Dim ColnCtaCteCosto As New DataGridViewTextBoxColumn()
            With ColnCtaCteCosto
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nCtaCteCosto"
                .Name = "nImpTotalDet"
                .HeaderText = "Importe Fichas Detalle"
                .ReadOnly = True : .Visible = False
                .Width = 120
            End With
            .Columns.Add(ColnCtaCteCosto)

            '6
            Dim ColcCtaCteRecibo As New DataGridViewTextBoxColumn()
            With ColcCtaCteRecibo
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cCtaCteRecibo"
                .HeaderText = "cCtaCteRecibo"
                .ReadOnly = True : .Visible = False
                .Width = 100
            End With
            .Columns.Add(ColcCtaCteRecibo)

            '7
            Dim ColfCtaCteImporteB As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteB
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCteImporteB"
                .Name = "fCtaCteImporteB"
                .HeaderText = "Importe Total Bruto"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCteImporteB)

            '8
            Dim ColfCtaCtePagImporte As New DataGridViewTextBoxColumn()
            With ColfCtaCtePagImporte
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCtePagImporte"
                .Name = "fCtaCtePagImporte"
                .HeaderText = "P. Efectivo"
                .ToolTipText = "Pago en Efectivo"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCtePagImporte)

            '9
            Dim ColfCtaCtePagImportet As New DataGridViewTextBoxColumn()
            With ColfCtaCtePagImportet
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCtePagImportet"
                .Name = "fCtaCteImportet"
                .HeaderText = "P. Tarjeta"
                .ToolTipText = "Pago con Tarjeta"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCtePagImportet)

            '10
            Dim ColfCtaCtePagImportec As New DataGridViewTextBoxColumn()
            With ColfCtaCtePagImportec
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCtePagImportec"
                .Name = "fCtaCtePagImportec"
                .HeaderText = "Cortesía"
                .ToolTipText = "Importe por Cortesía"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCtePagImportec)

            '11
            Dim ColfCtaCteImporte As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporte
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCteImporte"
                .Name = "fCtaCteImporte"
                .HeaderText = "Importe Venta"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCteImporte)

            '12
            Dim ColnSaldoPendienteporPagar As New DataGridViewTextBoxColumn()
            With ColnSaldoPendienteporPagar
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                '.DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nSaldoPendienteporPagar"
                .Name = "nSaldoPendienteporPagar"
                .HeaderText = "Saldo Pendiente"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColnSaldoPendienteporPagar)

            '13
            Dim ColfCtaCtePagImportecred As New DataGridViewTextBoxColumn()
            With ColfCtaCtePagImportecred
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                '.DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCtePagImportecred"
                .Name = "fCtaCtePagImportecred"
                .HeaderText = "Credito Pendiente"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCtePagImportecred)

            '14
            Dim ColnImpTotalBruto As New DataGridViewTextBoxColumn()
            With ColnImpTotalBruto
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nImpTotalBruto"
                .Name = "nImpTotalBruto"
                .HeaderText = "nImpTotalBruto"
                .ReadOnly = True : .Visible = False
                .Width = 100
            End With
            .Columns.Add(ColnImpTotalBruto)

            '15
            Dim ColfCtaCteImporteSinIGV As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteSinIGV
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCteImporteSinIGV"
                .Name = "fCtaCteImporteSinIGV"
                .HeaderText = "Venta sin IGV"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCteImporteSinIGV)


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
                .Width = 180

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
                .Width = 200
            End With
            .Columns.Add(ColcIntDescripcion)

            '4
            Dim ColQtyFichas As New DataGridViewTextBoxColumn()
            With ColQtyFichas
                .DefaultCellStyle.Format = "#,##0"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "QtyFichas"
                .Name = "QtyFichas"
                .HeaderText = "Cantida Fichas"
                .ToolTipText = "Pago pendiente por cobrar."
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColQtyFichas)

            '5
            Dim ColfCtaCteImporteB As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteB
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCteImporteB"
                .Name = "fCtaCteImporteB"
                .HeaderText = "Importe Bruto"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteB)

            '6
            Dim ColfCtaCteImporteG As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteG
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCteImporteG"
                .Name = "fCtaCteImporteG"
                .HeaderText = "Importe Sin I.G.V."
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteG)

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
                .Width = 180

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
                .Width = 200
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
                .DataPropertyName = "QtyFichas"
                .Name = "QtyFichas"
                .HeaderText = "Cantida Fichas"
                .ToolTipText = "Pago pendiente por cobrar."
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColQtyFichas)

            '7
            Dim ColfCtaCteImporteB As New DataGridViewTextBoxColumn()
            With ColfCtaCteImporteB
                .DefaultCellStyle.Format = "#,##0.00 ; ( -#,##0.00)"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "fCtaCteImporteB"
                .Name = "fCtaCteImporteB"
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
                .DataPropertyName = "fCtaCteImporteG"
                .Name = "fCtaCteImporteG"
                .HeaderText = "Importe Sin I.G.V."
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColfCtaCteImporteG)

        End With

    End Sub

#End Region

    Private Sub VerDetalle_Filtros(nflagFiltro As String _
                                   , nflag As String)
        'detalle saldo pendiente
        Table2.DataSource = Servicio.Get_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo(IIf(CboFiltro.SelectedIndex = 0, "", CbocPerJurCodigo.SelectedValue), Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"), nflagFiltro, nflag)
    End Sub

    Private Sub GraficoTorta()

        For Each series As Object In Chart1.Series
            series.Points.Clear()
        Next

        Chart1.Series("Series1").XValueMember = "cPerApellido"
        Chart1.Series("Series1").YValueMembers = "fCtaCteImporte"

        Chart1.DataSource = Servicio.Get_Venta_by_cPerJurCodigo_and_fecini_fecfin(IIf(CboFiltro.SelectedIndex = 0, "", CbocPerJurCodigo.SelectedValue), DTPFecIni.Value, DTPFecFin.Value)

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

            Table1.DataSource = Servicio.Get_Venta_by_cPerJurCodigo_and_fecini_fecfin(IIf(CboFiltro.SelectedIndex = 0, "", CbocPerJurCodigo.SelectedValue), DTPFecIni.Value, DTPFecFin.Value)
            cStrNameReport = "Reporte Venta Consolidado por Sucursal"

            If RbtPendientes.Checked Then
                RbtPendientes_Click(RbtPendientes, Nothing)
            ElseIf RbtVtaTipoAtencion.Checked Then
                RbtVtaTipoAtencion_Click(RbtVtaTipoAtencion, Nothing)
            ElseIf RbtDetVtaLabConv.Checked Then
                RbtDetVtaLabConv_Click(RbtDetVtaLabConv, Nothing)
            End If

            LblImpMedico.Text = FormatNumber(Suma_Columna("fCtaCteImporte", Table1), True)
            LblImpSinIGV.Text = FormatNumber(Suma_Columna("fCtaCteImporteSinIGV", Table1), True)
            LblnSaldo.Text = FormatNumber(Suma_Columna("nImpTotalBruto", Table1), True)

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
            tb2.Width = Me.Table1.Columns(7).Width
            X = Me.Table1.GetCellDisplayRectangle(7, -1, True).Location.X
            tb2.Location = New Point(X, Me.Table1.Height - tb2.Height)
            Me.Table1.Controls.Add(tb2)

            'tb3
            tb3.Width = Me.Table1.Columns(8).Width
            X = Me.Table1.GetCellDisplayRectangle(8, -1, True).Location.X
            tb3.Location = New Point(X, Me.Table1.Height - tb3.Height)
            Me.Table1.Controls.Add(tb3)

            'tb4
            tb4.Width = Me.Table1.Columns(9).Width
            X = Me.Table1.GetCellDisplayRectangle(9, -1, True).Location.X
            tb4.Location = New Point(X, Me.Table1.Height - tb4.Height)
            Me.Table1.Controls.Add(tb4)

            'tb5
            tb5.Width = Me.Table1.Columns(10).Width
            X = Me.Table1.GetCellDisplayRectangle(10, -1, True).Location.X
            tb5.Location = New Point(X, Me.Table1.Height - tb5.Height)
            Me.Table1.Controls.Add(tb5)

            'tb6
            tb6.Width = Me.Table1.Columns(11).Width
            X = Me.Table1.GetCellDisplayRectangle(11, -1, True).Location.X
            tb6.Location = New Point(X, Me.Table1.Height - tb6.Height)
            Me.Table1.Controls.Add(tb6)

            'tb7
            tb7.Width = Me.Table1.Columns(12).Width
            X = Me.Table1.GetCellDisplayRectangle(12, -1, True).Location.X
            tb7.Location = New Point(X, Me.Table1.Height - tb7.Height)
            Me.Table1.Controls.Add(tb7)

            'tb9
            tb9.Width = Me.Table1.Columns(13).Width
            X = Me.Table1.GetCellDisplayRectangle(13, -1, True).Location.X
            tb9.Location = New Point(X, Me.Table1.Height - tb9.Height)
            Me.Table1.Controls.Add(tb9)

            'tb8
            tb8.Width = Me.Table1.Columns(15).Width
            X = Me.Table1.GetCellDisplayRectangle(15, -1, True).Location.X
            tb8.Location = New Point(X, Me.Table1.Height - tb8.Height)
            Me.Table1.Controls.Add(tb8)

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
                sum += Convert.ToDouble(Me.Table1(7, i).Value)
            Next

            tb2.ReadOnly = True
            tb2.TextAlign = HorizontalAlignment.Right
            tb2.Text = FormatNumber(sum, True)

            'tb3
            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(8, i).Value)
            Next
            tb3.ReadOnly = True
            tb3.TextAlign = HorizontalAlignment.Right
            tb3.Text = FormatNumber(sum, True)

            'tb4
            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(9, i).Value)
            Next
            tb4.ReadOnly = True
            tb4.TextAlign = HorizontalAlignment.Right
            tb4.Text = FormatNumber(sum, True)

            'tb5
            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(10, i).Value)
            Next
            tb5.ReadOnly = True
            tb5.TextAlign = HorizontalAlignment.Right
            tb5.Text = Format(sum, "#,##0.00 ; ( -#,##0.00)")

            'tb6
            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(11, i).Value)
            Next
            tb6.ReadOnly = True
            tb6.TextAlign = HorizontalAlignment.Right
            tb6.Text = FormatNumber(sum, True)

            'tb7
            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(12, i).Value)
            Next
            tb7.ReadOnly = True
            tb7.TextAlign = HorizontalAlignment.Right
            tb7.Text = Format(sum, "#,##0.00 ; ( -#,##0.00)")

            'tb9
            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(13, i).Value)
            Next
            tb9.ReadOnly = True
            tb9.TextAlign = HorizontalAlignment.Right
            tb9.Text = Format(sum, "#,##0.00 ; ( -#,##0.00)")


            'tb8
            sum = 0
            For i As Integer = 0 To Me.Table1.Rows.Count - 1
                sum += Convert.ToDouble(Me.Table1(15, i).Value)
            Next
            tb8.ReadOnly = True
            tb8.TextAlign = HorizontalAlignment.Right
            tb8.Text = FormatNumber(sum, True)

            GraficoTorta()

            System.Windows.Forms.Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Se encontraron errores.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    '//Para mostrar Footer en un DataGridView
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

    '//Para mostrar Footer en un DataGridView
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

        'tb2
        tb2.Width = Me.Table1.Columns(7).Width
        X = Me.Table1.GetCellDisplayRectangle(7, -1, True).Location.X
        tb2.Location = New Point(X, Me.Table1.Height - tb2.Height)

        'tb3
        tb3.Width = Me.Table1.Columns(8).Width
        X = Me.Table1.GetCellDisplayRectangle(8, -1, True).Location.X
        tb3.Location = New Point(X, Me.Table1.Height - tb3.Height)

        'tb4
        tb4.Width = Me.Table1.Columns(9).Width
        X = Me.Table1.GetCellDisplayRectangle(9, -1, True).Location.X
        tb4.Location = New Point(X, Me.Table1.Height - tb4.Height)

        'tb5
        tb5.Width = Me.Table1.Columns(10).Width
        X = Me.Table1.GetCellDisplayRectangle(10, -1, True).Location.X
        tb5.Location = New Point(X, Me.Table1.Height - tb5.Height)

        'tb6
        tb6.Width = Me.Table1.Columns(11).Width
        X = Me.Table1.GetCellDisplayRectangle(11, -1, True).Location.X
        tb6.Location = New Point(X, Me.Table1.Height - tb6.Height)

        'tb7
        tb7.Width = Me.Table1.Columns(12).Width
        X = Me.Table1.GetCellDisplayRectangle(12, -1, True).Location.X
        tb7.Location = New Point(X, Me.Table1.Height - tb7.Height)

        'tb9
        tb9.Width = Me.Table1.Columns(13).Width
        X = Me.Table1.GetCellDisplayRectangle(13, -1, True).Location.X
        tb9.Location = New Point(X, Me.Table1.Height - tb9.Height)

        'tb8
        tb8.Width = Me.Table1.Columns(15).Width
        X = Me.Table1.GetCellDisplayRectangle(15, -1, True).Location.X
        tb8.Location = New Point(X, Me.Table1.Height - tb8.Height)
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

                If Convert.ToDouble(.Rows(i).Cells("fCtaCtePagImportec").Value) < 0 Then
                    .Rows(i).Cells("fCtaCtePagImportec").Style.ForeColor = Color.Red
                Else
                    .Rows(i).Cells("fCtaCtePagImportec").Style.ForeColor = Color.Black
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

    'Private Sub dg_ESC_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Table1.CellPainting

    '    If e.RowIndex = 0 AndAlso (e.ColumnIndex = 2 Or e.ColumnIndex = 3) Then
    '        Using gridBrush As Brush = New SolidBrush(Me.Table1.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)
    '            Using gridLinePen As Pen = New Pen(gridBrush)
    '                ' Clear cell 
    '                e.Graphics.FillRectangle(backColorBrush, e.CellBounds)
    '                'Bottom line drawing
    '                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
    '                'top line drawing
    '                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Top)
    '                'Drawing Right line
    '                If e.ColumnIndex = 3 Then
    '                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)
    '                End If
    '                'Inserting text
    '                If e.ColumnIndex = 3 Then
    '                    e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X - (e.CellBounds.X / 4), e.CellBounds.Y + 5)
    '                End If
    '                e.Handled = True
    '            End Using
    '        End Using
    '    End If
    'End Sub

    'Private Sub dataGridView1_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Table1.CellPainting
    '    If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
    '        e.PaintBackground(e.CellBounds, False)
    '        Dim r2 As Rectangle = e.CellBounds
    '        r2.Y += e.CellBounds.Height / 2
    '        r2.Height = e.CellBounds.Height / 2
    '        e.PaintContent(r2)
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub dataGridView1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Table1.Paint
    '    ' Data for the "merged" header cells
    '    Dim monthes As String() = {"January", "February", "March"}
    '    For j As Integer = 0 To Me.Table1.ColumnCount - 1 Step 2
    '        ' Get the column header cell bounds
    '        Dim r1 As Rectangle = Me.Table1.GetCellDisplayRectangle(j, -1, True)

    '        r1.X += 1
    '        r1.Y += 1
    '        r1.Width = r1.Width * 2 - 2
    '        r1.Height = r1.Height / 2 - 2

    '        Using br As SolidBrush = New SolidBrush(Me.Table1.ColumnHeadersDefaultCellStyle.BackColor)
    '            e.Graphics.FillRectangle(br, r1)
    '        End Using

    '        Using p As Pen = New Pen(SystemColors.InactiveBorder)
    '            e.Graphics.DrawLine(p, r1.X, r1.Bottom, r1.Right, r1.Bottom)
    '        End Using

    '        Using format As StringFormat = New StringFormat()
    '            Using br As SolidBrush = New SolidBrush(Me.Table1.ColumnHeadersDefaultCellStyle.ForeColor)
    '                format.Alignment = StringAlignment.Center
    '                format.LineAlignment = StringAlignment.Center
    '                e.Graphics.DrawString(monthes(j / 2), Me.Table1.ColumnHeadersDefaultCellStyle.Font, br, r1, format)
    '            End Using
    '        End Using
    '    Next
    'End Sub


    Private Sub C1CmdExportSaldo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportSaldo.Click

        If Table2.RowCount = 0 Then Exit Sub
        If RbtPendientes.Checked Then
            cNameRptFiltro = "Pendientes/Créditos por Cobrar"
        ElseIf RbtVtaTipoAtencion.Checked Then
            cNameRptFiltro = "Ventas Agrupado por Tipo Atención (Ingresos)"
        ElseIf RbtDetVtaLabConv.Checked Then
            cNameRptFiltro = "Ventas Agrupado por Tipo Atención y por Laboratorio/Convenio (Ingresos)"
        End If
        'Call GridAExcel(Table1)
        ExportarDatosExcel(Table2, cNameRptFiltro, "Desde: " + Format(DTPFecIni.Value, "dd/MM/yyyy") + " hasta: " + Format(DTPFecFin.Value, "dd/MM/yyyy"))

    End Sub


    Private Sub RbtPendientes_Click(sender As Object, e As EventArgs) Handles RbtPendientes.Click

        Formato02_DataGridView()

        Select Case CboFiltro.SelectedIndex
            Case 0 'Todos
                VerDetalle_Filtros("P", "T")
            Case Else 'Detalle
                VerDetalle_Filtros("P", "D")
        End Select
    End Sub

    Private Sub RbtVtaTipoAtencion_Click(sender As Object, e As EventArgs) Handles RbtVtaTipoAtencion.Click

        Formato03_DataGridView()

        Select Case CboFiltro.SelectedIndex
            Case 0 'Todos
                VerDetalle_Filtros("A", "T")
            Case Else 'Detalle
                VerDetalle_Filtros("A", "D")
        End Select

    End Sub

    Private Sub RbtDetVtaLabConv_Click(sender As Object, e As EventArgs) Handles RbtDetVtaLabConv.Click

        Formato04_DataGridView()

        Select Case CboFiltro.SelectedIndex
            Case 0 'Todos
                VerDetalle_Filtros("E", "T")
            Case Else 'Detalle
                VerDetalle_Filtros("E", "D")
        End Select

    End Sub


End Class