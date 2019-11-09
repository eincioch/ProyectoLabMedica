Option Explicit On
Imports Integration.BE.Persona
Imports Integration.BE.FichaAtencion
Imports Integration.BE.CtasCtesMedica
Imports Integration.BL
Imports Integration.BL.BL_FichaAtencion
Imports Integration.BL.BL_CtasCtesMedica

Imports Integration.BL.BL_Reportes
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormPrcCtaCteFacturacionBloque

    Dim cStrNameReport As String = vbNullString
    Dim Servicio As New BLRptMaster

#Region "Formato Grilla"

    Private Sub Muestras_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()

            Dim ColnCtaCteSerCodigo As New DataGridViewTextBoxColumn()
            With ColnCtaCteSerCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nCtaCteSerCodigo"
                .Name = "nCtaCteSerCodigo"
                .HeaderText = "nCtaCteSerCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 80
            End With
            .Columns.Add(ColnCtaCteSerCodigo)

            Dim ColcIntJerarquia As New DataGridViewTextBoxColumn()
            With ColcIntJerarquia
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cIntJerarquia"
                .HeaderText = "Clase"
                .Name = "cIntJerarquia"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColcIntJerarquia)

            Dim ColcCtaCteSerJerarquia As New DataGridViewTextBoxColumn()
            With ColcCtaCteSerJerarquia
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cCtaCteSerJerarquia"
                .HeaderText = "Código"
                .Name = "cCtaCteSerJerarquia"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColcCtaCteSerJerarquia)

            Dim ColcCtaCteSerKeyWord As New DataGridViewTextBoxColumn()
            With ColcCtaCteSerKeyWord
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cCtaCteSerKeyWord"
                .Name = "cCtaCteSerKeyWord"
                .HeaderText = "Muestra / Descripción"
                .ReadOnly = True : .Visible = True
                .Width = 260
            End With
            .Columns.Add(ColcCtaCteSerKeyWord)


            Dim ColnCantidad As New DataGridViewTextBoxColumn()
            With ColnCantidad
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N0"
                .DataPropertyName = "nCantidad"
                .Name = "nCantidad"
                .HeaderText = "Cantidad"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColnCantidad)

            Dim ColnCtaCteCosto As New DataGridViewTextBoxColumn()
            With ColnCtaCteCosto
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nCtaCteCosto"
                .HeaderText = "Importe"
                .Name = "nCtaCteSerCosto"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColnCtaCteCosto)

        End With

    End Sub

    Private Sub DetFichas_DataGridView()

        With Table2
            .AutoGenerateColumns = False
            .Columns.Clear()

            Dim ColnSolAdmNumero As New DataGridViewTextBoxColumn()
            With ColnSolAdmNumero
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = ""
                .DataPropertyName = "nSolAdmNumero"
                .Name = "nSolAdmNumero"
                .HeaderText = "Nro. Ficha"
                .ReadOnly = True : .Visible = True
                .Width = 120
            End With
            .Columns.Add(ColnSolAdmNumero)

            Dim ColcIntJerarquia As New DataGridViewTextBoxColumn()
            With ColcIntJerarquia
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "Paciente"
                .HeaderText = "Paciente"
                .Name = "Paciente"
                .ReadOnly = True : .Visible = True
                .Width = 280
            End With
            .Columns.Add(ColcIntJerarquia)

            Dim ColdFecRegistro As New DataGridViewTextBoxColumn()
            With ColdFecRegistro
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy"
                .DataPropertyName = "dFecRegistro"
                .HeaderText = "Fecha Registro"
                .Name = "dFecRegistro"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColdFecRegistro)

            Dim ColnCtaCteCosto As New DataGridViewTextBoxColumn()
            With ColnCtaCteCosto
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nCtaCteCosto"
                .Name = "nImpTotald"
                .HeaderText = "Importe"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColnCtaCteCosto)
        End With

    End Sub

#End Region

    Function ValidaCamposObligatorios() As Boolean
        ValidaCamposObligatorios = False

        ValidaCamposObligatorios = True
    End Function

    Private Sub CargarForm()

        Muestras_DataGridView()
        DetFichas_DataGridView()

        FormatGrilla(Table1, Me)
        FormatGrilla(Table2, Me)

        'Carga: Interface: 1133
        LlenaDataCombo(CboTipoCta, ObjInterface.Get_Interface(CLng(TokenByKey(CboTipoCta.Tag, "nIntClase")), CLng(TokenByKey(CboTipoCta.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")

        'Me.WindowState = FormWindowState.Maximized

        CboTipoCta.Enabled = True 'Inicializamos

    End Sub

    Private Sub FormPrcCtaCteFacturacionBloque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarForm()

    End Sub

    Private Sub CboTipoCta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboTipoCta.SelectionChangeCommitted
        Dim Obj_Empresa As New BL_Personas

        Select Case CboTipoCta.SelectedValue
            Case CInt(TipoAtencion.Particular), CInt(TipoAtencion.AtencionExterna)
                MessageStateTool(LblMsjError, "Opción no valida para este proceso (Tipo Atención).")

            Case CInt(TipoAtencion.LabExterno)
                MessageStateTool(LblMsjError, "", True)

                '//LlenaDataCombo(CboLabEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, p.cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoLabExterno)), "cPerCodigo", "cPerNombre")

                LlenaDataCombo(CboLabEmpresa, ObjSistemaServicio.Get_Value_Table("DISTINCT p.cPerCodigo, p.cPerNombre + space(1) + '--- S/.' + space(1) + cast(SUM(asa.nImpTotal) as varchar) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) ON p.cPerCodigo = pr.cPerCodigo INNER JOIN AdmSolAtencion asa with(nolock) ON p.cPerCodigo = asa.cPerCodigoTerceros", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoLabExterno) & " AND asa.nAdmSolEstado NOT IN (3,7) AND asa.nIntCodigo = 1002 GROUP BY p.cPerCodigo, p.cPerNombre"), "cPerCodigo", "cPerNombre")

                CboLabEmpresa.AutoCompleteCustomSource = LoadAutoComplete(ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, p.cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoLabExterno)), "cPerNombre")
                CboLabEmpresa.AutoCompleteMode = AutoCompleteMode.Suggest
                CboLabEmpresa.AutoCompleteSource = AutoCompleteSource.CustomSource

            Case CInt(TipoAtencion.Convenio)
                MessageStateTool(LblMsjError, "", True)

                LlenaDataCombo(CboLabEmpresa, ObjSistemaServicio.Get_Value_Table("DISTINCT p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido + space(1) + p.cPerNombre ELSE p.cPerNombre END) + space(1) + '--- S/.' + space(1) + cast(SUM(asa.nImpTotal) as varchar) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) ON p.cPerCodigo = pr.cPerCodigo INNER JOIN AdmSolAtencion asa with(nolock) ON p.cPerCodigo = asa.cPerCodigoTerceros", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoEmpConvenio) & " AND asa.nAdmSolEstado NOT IN (3,7) AND asa.nIntCodigo = 1003 GROUP BY p.cPerCodigo, p.cPerNombre, p.nPerTipo,p.cPerApellido"), "cPerCodigo", "cPerNombre")
            Case CInt(TipoAtencion.CentroSalud)
                MessageStateTool(LblMsjError, "", True)

                LlenaDataCombo(CboLabEmpresa, ObjSistemaServicio.Get_Value_Table("DISTINCT p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido + space(1) + p.cPerNombre ELSE p.cPerNombre END) + space(1) + '--- S/.' + space(1) + cast(SUM(asa.nImpTotal) as varchar) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) ON p.cPerCodigo = pr.cPerCodigo INNER JOIN AdmSolAtencion asa with(nolock) ON p.cPerCodigo = asa.cPerCodigoTerceros", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoCentroSalud) & " AND asa.nAdmSolEstado NOT IN (3,7) AND asa.nIntCodigo = 1005 GROUP BY p.cPerCodigo, p.cPerNombre, p.nPerTipo,p.cPerApellido"), "cPerCodigo", "cPerNombre")
            Case CInt(TipoAtencion.Campaña)
                MessageStateTool(LblMsjError, "", True)

                LlenaDataCombo(CboLabEmpresa, ObjSistemaServicio.Get_Value_Table("DISTINCT p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido + space(1) + p.cPerNombre ELSE p.cPerNombre END) + space(1) + '--- S/.' + space(1) + cast(SUM(asa.nImpTotal) as varchar) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) ON p.cPerCodigo = pr.cPerCodigo INNER JOIN AdmSolAtencion asa with(nolock) ON p.cPerCodigo = asa.cPerCodigoTerceros", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoCampana) & " AND asa.nAdmSolEstado NOT IN (3,7) AND asa.nIntCodigo = 1006 GROUP BY p.cPerCodigo, p.cPerNombre, p.nPerTipo,p.cPerApellido"), "cPerCodigo", "cPerNombre")
        End Select

    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click

        Try
            Dim ServicioAdmSolAtencion As New BL_FichaAtencion

            If RdoBtnPerfilMuestra.Checked Then Table1.DataSource = ServicioAdmSolAtencion.Get_AdmSolAtencion_by_nIntCodigo_and_cPerCodigoTerceros_and_fecha(CLng(CboTipoCta.SelectedValue), CboLabEmpresa.SelectedValue.ToString, FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate), "G")
            If RdoBtnMuestra.Checked Then Table1.DataSource = ServicioAdmSolAtencion.Get_AdmSolAtencion_by_nIntCodigo_and_cPerCodigoTerceros_and_fecha(CLng(CboTipoCta.SelectedValue), CboLabEmpresa.SelectedValue.ToString, FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate), "M")

            Table2.DataSource = ServicioAdmSolAtencion.Get_AdmSolAtencion_by_nIntCodigo_and_cPerCodigoTerceros_and_fecha(CLng(CboTipoCta.SelectedValue), CboLabEmpresa.SelectedValue.ToString, DtpFecIni.Value, DtpFecFin.Value, "F")

            Label9.Text = "Detalle de Fichas de Atención - Nro. Fichas: " & Table2.RowCount.ToString

            LblQty.Text = Suma_Columna("nCantidad", Table1)
            LblAmountMuestra.Text = FormatNumber(Suma_Columna("nCtaCteSerCosto", Table1), True)
            LblTotalPago.Text = FormatNumber(Suma_Columna("nImpTotald", Table2), True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: al seleccionar.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try


    End Sub

    Private Sub C1CmdProgramar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdProgramar.Click

        If Table1.RowCount = 0 Then Exit Sub

        If RdoBtnPerfilMuestra.Checked Then Exit Sub

        Try
            If MessageBox.Show("¿Desea programar el Pago en Bloque.?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                BtnMostrar_Click(BtnMostrar, Nothing)

                Dim nPrdCodigo As Integer

                Dim ListCtaCteDetalle As New List(Of BE.CtasCtesMedica.BE_ReqCtaCteDetalle) REM Variable de tipo "List"
                Dim ListSolAtencion As New List(Of BE_ReqSolAtencion)
                Dim ListCtaCteIntDetalle As New List(Of ReqCtaCteIntDetalle)

                Dim ReqCtaCteDet As BE.CtasCtesMedica.BE_ReqCtaCteDetalle = Nothing REM Declaro variable "Item"
                Dim ObjAdmSolAtencion As BE_ReqSolAtencion = Nothing
                Dim ObjCtaCteIntDetalle As ReqCtaCteIntDetalle = Nothing

                Dim Obj_InsProgPago As New BL_CuentaCorriente

                If ValidaCamposObligatorios() Then
                    'Obtengo periodo Contable actual (nPrdCodigo) IMPORTANTE para Asiento de Ventas.
                    nPrdCodigo = ObjSistemaServicio.Get_Periodo_by_cPerJurCodigo(StrcPerJuridica)

                    '--------------------------------
                    'Llenando List para CtaCteDetalle
                    '--------------------------------
                    With Table1
                        For i As Integer = 0 To .Rows.Count - 1
                            ReqCtaCteDet = New BE.CtasCtesMedica.BE_ReqCtaCteDetalle 'Crear Nueva Instancia de clase(objeto) memoria
                            ReqCtaCteDet.nSerCodigo = CLng(.Item("nCtaCteSerCodigo", i).Value) REM Codigo de CtaCteServicio
                            ReqCtaCteDet.nCtaCteCantidad = CLng(.Item("nCantidad", i).Value) ' CLng(1) REM Default cantidad 1
                            ReqCtaCteDet.nMoneda = CLng(TipoMoneda.nSoles)
                            ReqCtaCteDet.fCtaCteTC = 0
                            ReqCtaCteDet.fCtaCteIGV = 0.18
                            ReqCtaCteDet.fCtaCteDetimporte = FormatNumber(.Item("nCtaCteSerCosto", i).Value, True) 'Coreccion cambio CLng por FormatNumber -- CLng(.Item("nCtaCteSerCosto", i).Value) REM Precio de Analisis
                            ReqCtaCteDet.dCtaCteDetRegistro = FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate)
                            ReqCtaCteDet.nCtaCtedetEstado = CLng(1) REM 1=Activo
                            ListCtaCteDetalle.Add(ReqCtaCteDet)
                        Next
                    End With

                    '-----------------------------------
                    'Llenando List para CtaCteIntDetalle
                    '-----------------------------------
                    With Table2
                        For i As Integer = 0 To .Rows.Count - 1
                            ObjCtaCteIntDetalle = New ReqCtaCteIntDetalle 'Crear Nueva Instancia de clase(objeto) memoria

                            'Update 2016-04-06(eincio) --nFlag para separar pagos en bloque y sacar el importe de la fichas (Vista)
                            ObjCtaCteIntDetalle.nIntCodigo = 2

                            ObjCtaCteIntDetalle.nIntClase = 1015 'Pago en bloque
                            ObjCtaCteIntDetalle.cIntJerarquia = ""
                            ObjCtaCteIntDetalle.cIntValor = .Item("nSolAdmNumero", i).Value.ToString
                            ListCtaCteIntDetalle.Add(ObjCtaCteIntDetalle)
                        Next
                    End With

                    '---------------------------------
                    'Llenando List para AdmSolAtencion
                    '---------------------------------
                    With Table2
                        For i As Integer = 0 To .Rows.Count - 1
                            ObjAdmSolAtencion = New BE_ReqSolAtencion 'Crear Nueva Instancia de clase(objeto) memoria
                            ObjAdmSolAtencion.nSolAdmNumero = .Item("nSolAdmNumero", i).Value.ToString
                            ObjAdmSolAtencion.nIntCodigo = CLng(CboTipoCta.SelectedValue)
                            ObjAdmSolAtencion.cPerCodigoTerceros = CboLabEmpresa.SelectedValue
                            ObjAdmSolAtencion.nAdmSolEstado = EstadoFichaAtencion.nProgramado
                            ObjAdmSolAtencion.cPerCodigoAut = StrUser
                            ListSolAtencion.Add(ObjAdmSolAtencion)
                        Next
                    End With

                    REM Registrando Programación
                    If Obj_InsProgPago.Ins_CuentaCorriente_ProgracionPagoBloque(CboLabEmpresa.SelectedValue.ToString, _
                                                                                StrcPerJuridica, TipoActividad.nPerTipoCliente, 1, _
                                                                                FormatNumber(LblTotalPago.Text, True), _
                                                                                FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate), FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate), _
                                                                                "Programación Pago Ficha Atención (Bloque)", nPrdCodigo, TipoMoneda.nSoles, ListCtaCteDetalle, ListCtaCteIntDetalle, ListSolAtencion) Then

                        MessageBox.Show("Programación de Pago se realizó con éxito.!" & Chr(13) & "Para facturar vaya a la ficha de atención y ubique las fichas.", "Programando Pago..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        BtnMostrar_Click(BtnMostrar, Nothing)
                    Else
                        Throw New ApplicationException("Se encontraron errores en la transaccion: " + "[Ins_CuentaCorriente_ProgracionPagoBloque]")
                    End If

                End If
            Else
                MessageBox.Show("Operación cancelada por el usuario.!", "Cancelando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Se encontraron errores. " & ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub C1CmdExport_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExport.Click

        If Table1.RowCount = 0 Then Exit Sub
        'Call GridAExcel(Table1)
        ExportarDatosExcel(Table1, "Detalle de Muestras", "Desde: " + Format(DtpFecIni.Value, "dd/MM/yyyy") + " hasta: " + Format(DtpFecFin.Value, "dd/MM/yyyy"))

    End Sub

    Private Sub C1CmdFacturar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdFacturar.Click

    End Sub

    Private Sub C1CmdExportExcelFichas_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportExcelFichas.Click
        If Table2.RowCount = 0 Then Exit Sub
        'Call GridAExcel(Table1)
        ExportarDatosExcel(Table2, "Listado de Fichas", "Desde: " + Format(DtpFecIni.Value, "dd/MM/yyyy") + " hasta: " + Format(DtpFecFin.Value, "dd/MM/yyyy"))
    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click

        Close()
        Dispose()

    End Sub

    Private Sub C1CmdDetalle_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdDetalle.Click
        Cursor.Current = Cursors.WaitCursor

        Dim CrReport As New ReportDocument

        Try
            Dim cPerJurLab As String
            If MessageBox.Show("¿Desea ver pendientes de facturar de todos los laboratorios/convenios?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cPerJurLab = ""
            Else
                cPerJurLab = CboLabEmpresa.SelectedValue.ToString
            End If
            'If BL.Get_ReportCuadraCaja("DET", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub
            ' Asigno el reporte 
            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT & "rptFactPendientes.rpt")

            CrReport.DataDefinition.FormulaFields("rangofec").Text = Chr(34) & "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy") & Chr(34)

            CrReport.SetDataSource(Servicio.Get_LabConv_Pendientes_de_Facturacion_By_RangoFecha(Format(DtpFecIni.Value, "yyyyMMdd"), Format(DtpFecFin.Value, "yyyyMMdd"), cPerJurLab))

            FormCrystalReport.Text = "Detalle de Atenciones por Laboratorio"

            FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
            'Directo a la impresora
            'Form_CrystalReport.CrystalRptVwr.PrintReport()
            FormCrystalReport.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Cursor.Current = Cursors.Default
    End Sub
End Class