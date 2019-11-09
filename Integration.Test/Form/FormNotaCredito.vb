Imports Integration.BE.CtasCtes
Imports Integration.BE.CtasCtesMedica
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL
Imports Integration.BL.BL_CtasCtesMedica
Imports Integration.BE

Imports System.Transactions

Public Class FormNotaCredito

#Region "Estructura Grilla"
    Enum ColumnGrilla
        ColcCtaCteRecibo = 0
        ColItem = 1
        ColnSerCodigo = 2
        ColcCtaCteSerJerarquia = 3
        ColcCtaCteSerKeyWord = 4
        ColnCtaCteCantidad = 5
        ColnMoneda = 6
        ColfCtaCteTC = 7
        ColfCtaCteIGV = 8
        ColfCtaCteDetimporte = 9
        ColfCtaCteDetImpTotal = 10
        ColdCtaCteDetRegistro = 11
        ColnCtaCtedetEstado = 12
    End Enum

    Private Sub EstructuraGrillaProforma_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()
            '0
            Dim ColcCtaCteRecibo As New DataGridViewTextBoxColumn()
            With ColcCtaCteRecibo
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cCtaCteRecibo"
                .Name = "cCtaCteRecibo"
                .HeaderText = "cCtaCteRecibo"
                .ReadOnly = True : .Visible = False
                .Width = 100
            End With
            .Columns.Add(ColcCtaCteRecibo)
            '1
            Dim ColItem As New DataGridViewTextBoxColumn()
            With ColItem
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "Item"
                .Name = "Item"
                .HeaderText = "Item"
                .ReadOnly = True : .Visible = True
                .Width = 60
            End With
            .Columns.Add(ColItem)
            '2
            Dim ColnSerCodigo As New DataGridViewTextBoxColumn()
            With ColnSerCodigo
                .DataPropertyName = "nSerCodigo"
                .Name = "nSerCodigo"
                .HeaderText = "nSerCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 100
            End With
            .Columns.Add(ColnSerCodigo)
            '3
            Dim ColcCtaCteSerJerarquia As New DataGridViewTextBoxColumn()
            With ColcCtaCteSerJerarquia
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cCtaCteSerJerarquia"
                .Name = "cCtaCteSerJerarquia"
                .HeaderText = "Código Exámen"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColcCtaCteSerJerarquia)
            '4
            Dim ColcCtaCteSerKeyWord As New DataGridViewTextBoxColumn()
            With ColcCtaCteSerKeyWord
                .DataPropertyName = "cCtaCteSerKeyWord"
                .Name = "cCtaCteSerKeyWord"
                .HeaderText = "Descripción - Exámen"
                .ReadOnly = True : .Visible = True
                .Width = 390
            End With
            .Columns.Add(ColcCtaCteSerKeyWord)
            '5
            Dim ColnCtaCteCantidad As New DataGridViewTextBoxColumn()
            With ColnCtaCteCantidad
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nCtaCteCantidad"
                .Name = "nCtaCteCantidad"
                .HeaderText = "Cantidad"
                .ReadOnly = False : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColnCtaCteCantidad)
            '6
            Dim ColnMoneda As New DataGridViewTextBoxColumn()
            With ColnMoneda
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nMoneda"
                .Name = "nMoneda"
                .HeaderText = "nMoneda"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColnMoneda)
            '7
            Dim ColfCtaCteTC As New DataGridViewTextBoxColumn()
            With ColfCtaCteTC
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "fCtaCteTC"
                .Name = "fCtaCteTC"
                .HeaderText = "fCtaCteTC"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = False
                .Width = 85
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColfCtaCteTC)
            '8
            Dim ColfCtaCteIGV As New DataGridViewTextBoxColumn()
            With ColfCtaCteIGV
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "fCtaCteIGV"
                .Name = "fCtaCteIGV"
                .HeaderText = "fCtaCteIGV"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = False
                .Width = 85
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColfCtaCteIGV)
            '9
            Dim ColfCtaCteDetimporte As New DataGridViewTextBoxColumn()
            With ColfCtaCteDetimporte
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "fCtaCteDetimporte"
                .Name = "fCtaCteDetimporte"
                .HeaderText = "Precio Unit."
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = False : .Visible = True
                .Width = 90
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColfCtaCteDetimporte)
            '10
            Dim ColfCtaCteDetImpTotal As New DataGridViewTextBoxColumn()
            With ColfCtaCteDetImpTotal
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "fCtaCteDetImpTotal"
                .Name = "fCtaCteDetImpTotal"
                .HeaderText = "Sub. Total"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 90
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColfCtaCteDetImpTotal)

            '11
            Dim ColdCtaCteDetRegistro As New DataGridViewTextBoxColumn()
            With ColdCtaCteDetRegistro
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy"
                .DataPropertyName = "dCtaCteDetRegistro"
                .Name = "dCtaCteDetRegistro"
                .HeaderText = "Fecha Item"
                .ReadOnly = True : .Visible = False
                .Width = 100
                '.DefaultCellStyle = DataGridViewCellStyle { Format=N, Alignment=TopRight }
            End With
            .Columns.Add(ColdCtaCteDetRegistro)
            '12
            Dim ColnCtaCtedetEstado As New DataGridViewTextBoxColumn()
            With ColnCtaCtedetEstado
                .DataPropertyName = "nCtaCtedetEstado"
                .Name = "nCtaCtedetEstado"
                .HeaderText = "nCtaCtedetEstado"
                .ReadOnly = True : .Visible = False
                .Width = 50
            End With
            .Columns.Add(ColnCtaCtedetEstado)

        End With

    End Sub

#End Region

    Function ValidarCampos() As Boolean
        Return True
    End Function

    Private Sub CargaGrilla()

        LblcPerCodigo.Text = TokenByKey(vCtaCteRecibo, "cPerCodigoCli").Trim
        LblcNombre.Text = TokenByKey(vCtaCteRecibo, "Cliente").Trim

        Dim ctaCteDetalle As New CtasCtesMedica.BE_ReqCtaCteDetalle

        ctaCteDetalle.cCtaCteRecibo = TokenByKey(vCtaCteRecibo, "cCtaCteRecibo")

        Dim servicio As New BL_CtasCtesMedica.BLCtaCteDetalle
        Table1.DataSource = servicio.Get_CtaCteDetalle(ctaCteDetalle)

        LblTotalPago.Text = FormatNumber(Suma_Columna("fCtaCteDetImpTotal", Table1), True)

    End Sub

    Private Sub FormNotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Nro. Caja
        LblNroCaja.Text = Microsoft.VisualBasic.Right("00" & ObtenerParametroAppConfig("NroCaja"), 2)

        'Llena CboTipoDocu segun Caja asignada
        Dim ReqTDocu As New BE_TipoDocporNroCaja
        Dim ObjTDocu As New BL_CtaCteServicioFacturacion

        ReqTDocu.cPerJurCodigo = StrcPerJuridica
        ReqTDocu.nCajCodigo = CLng(ObtenerParametroAppConfig("NroCaja"))
        ReqTDocu.nIntTipo = 1004 '--nopta de credito

        'InicilizarCampos()

        'llena datacombo documentos + series asignadas a la caja actual
        LlenaDataCombo(CboTipoDocu, ObjTDocu.Get_TipoDocporNroCaja(ReqTDocu), "nIntCodigo", "cIntDescripcion")

        Call CboTipoDocu_SelectionChangeCommitted(CboTipoDocu, Nothing)

        LlenaDataCombo(CboMotivoNC, ObjConst.Get_Constante("C", 7003), "nConValor", "cConDescripcion")

        EstructuraGrillaProforma_DataGridView()
        FormatGrilla(Table1, Me, False, 35)

        CargaGrilla()
        DtpFecPago.Value = dFechaSistema

        Me.ActiveControl = CboMotivoNC

    End Sub

    Private Sub CboTipoDocu_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoDocu.SelectionChangeCommitted

        'Define la serie en <LblSerie>
        LblSerie.Text = Microsoft.VisualBasic.Left(Trim(CboTipoDocu.Text), 4)

        Dim ObjSerieCorre As New BL_CtaCteNumeracion
        Dim strCorrelativoDocuVta As String = ObjSerieCorre.Get_CtaCteNumCorrelativo(StrcPerJuridica, CLng(ObtenerParametroAppConfig("NroCaja")), CLng(CboTipoDocu.SelectedValue), LblSerie.Text)

        LblSerie.Text = Microsoft.VisualBasic.Left(strCorrelativoDocuVta, 4)
        LblCorrelativo.Text = Microsoft.VisualBasic.Right(strCorrelativoDocuVta, 7)

    End Sub

    Private Sub BtnRegPago_Click(sender As Object, e As EventArgs) Handles BtnRegPago.Click

        Try
            If ValidarCampos() Then

                If MessageBox.Show("¿Desea registrar Nota de Crédito?", "Confirmar operación..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Using scope As New TransactionScope()

                        Dim nPrdCodigo As Integer
                        Dim BLCorrelativo As New BL_CtaCteNumeracion
                        Dim ObjCompPago As New BL_CtasCtesMedica.BL_CtaCteComprobante_Pago

                        Dim cPerCodigo As String = Trim(LblcPerCodigo.Text)
                        Dim nCajCodigo As Long = CLng(LblNroCaja.Text)
                        Dim nCtaCteComCodigo As Long = CLng(CboTipoDocu.SelectedValue)

                        'Genera correlativo Recibo
                        Dim cCtaCteComNumero As String = BLCorrelativo.Get_CtaCteNumCorrelativo(StrcPerJuridica, nCajCodigo, nCtaCteComCodigo, LblSerie.Text)

                        '-------
                        'Periodo
                        '-------
                        'Obtengo periodo Contable actual (nPrdCodigo) IMPORTANTE para Asiento de Ventas.
                        nPrdCodigo = ObjSistemaServicio.Get_Periodo_by_cPerJurCodigo(StrcPerJuridica)

                        '-------------------------
                        'Genero New cCtaCteRecibo
                        '------------------------
                        Dim gestionar As New BL_CuentaCorriente
                        Dim newcCtaCteRecibo As String = gestionar.Get_NewCorrelativoRecCtaCteItem(StrcPerJuridica)

                        '//Get PerCuenta
                        Dim nPerCtaCodigo As Int32
                        Dim gestionarPerCuentaServicio As New BL_PerCuenta()
                        Dim dataTable As DataTable = gestionarPerCuentaServicio.Get_PerCuenta(cPerCodigo, StrcPerJuridica)

                        If dataTable.Rows.Count > 0 Then
                            nPerCtaCodigo = Convert.ToInt32(dataTable.Rows(0)("nPerCtaCodigo"))
                        End If

                        '-----------------------
                        'Insert CuentaCorriente
                        '----------------------
                        Dim cuentaCorriente As New BE.CtasCtesMedica.BE_ReqCuentaCorriente()
                        cuentaCorriente.cCtaCteRecibo = newcCtaCteRecibo
                        cuentaCorriente.nPerCtaCodigo = nPerCtaCodigo
                        cuentaCorriente.nCtaCteTipo = 16 'Cliente -> Default 
                        cuentaCorriente.fCtaCteImporte = -Convert.ToDouble(LblTotalPago.Text) '-> en negativo
                        cuentaCorriente.nCtaCteCuota = 0
                        cuentaCorriente.nCtaCteEstado = 1
                        cuentaCorriente.dCtaCteFecVence = FormatDateTime(DtpFecPago.Value & Space(1) & TimeOfDay)
                        cuentaCorriente.dCtaCteFecPago = FormatDateTime(DtpFecPago.Value & Space(1) & TimeOfDay)
                        cuentaCorriente.dCtaCteFecEmis = FormatDateTime(DtpFecPago.Value & Space(1) & TimeOfDay)
                        cuentaCorriente.cCtaCteGlosa = CboMotivoNC.Text
                        cuentaCorriente.nPrdCodigo = nPrdCodigo
                        cuentaCorriente.nMonCodigo = CLng(TipoMoneda.nSoles) '->default soles
                        cuentaCorriente.fCtaCteIgv = Get_PorcIgv(StrcPerJuridica)
                        cuentaCorriente.dCtaCteFecProg = FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate)
                        cuentaCorriente.cSerDescripcion = ""
                        cuentaCorriente.fCtaCteSaldo = 0

                        Dim gestionarCuentaCorrienteServicio As New BL.BL_CtasCtesMedica.BL_CuentaCorriente()
                        If Not gestionarCuentaCorrienteServicio.Insert_CuentaCorriente(cuentaCorriente) Then
                            Throw New ApplicationException("Se encontraron errores en la transacción: BL-Ins_CuentaCorriente.!")
                        End If


                        '-------------
                        'CtaCteDetalle.- Detalle de los Items (Examenes)
                        '-------------
                        Dim listCtaCteDetalle As New List(Of BE.CtasCtesMedica.BE_ReqCtaCteDetalle)
                        Dim ctaCteDetalle As BE.CtasCtesMedica.BE_ReqCtaCteDetalle = Nothing

                        For i As Integer = 0 To Table1.Rows.Count - 1
                            ctaCteDetalle = New BE.CtasCtesMedica.BE_ReqCtaCteDetalle 'Crear Nueva Instancia de clase(objeto) memoria
                            ctaCteDetalle.cCtaCteRecibo = newcCtaCteRecibo
                            ctaCteDetalle.Item = i + 1
                            ctaCteDetalle.nSerCodigo = Table1.Item("nSerCodigo", i).Value
                            ctaCteDetalle.nCtaCteCantidad = Table1.Item("nCtaCteCantidad", i).Value
                            ctaCteDetalle.nMoneda = CLng(TipoMoneda.nSoles)
                            ctaCteDetalle.fCtaCteTC = 0
                            ctaCteDetalle.fCtaCteIGV = Get_PorcIgv(StrcPerJuridica)
                            ctaCteDetalle.fCtaCteDetimporte = Convert.ToDouble(Table1.Item("fCtaCteDetimporte", i).Value)
                            ctaCteDetalle.dCtaCteDetRegistro = FormatDateTime(DtpFecPago.Value & Space(1) & TimeOfDay)
                            ctaCteDetalle.nCtaCtedetEstado = 1
                            'se va llenando la lista con cada registro
                            listCtaCteDetalle.Add(ctaCteDetalle)
                        Next

                        Dim gestionarCtaCteDetalleServicio As New BL.BL_CtasCtesMedica.BLCtaCteDetalle
                        If Not gestionarCtaCteDetalleServicio.Insert_CtaCteDetalle(listCtaCteDetalle) Then
                            Throw New ApplicationException("Se encontraron errores en la transacción: BL-Insert_CtaCteDetalle.!")
                        End If

                        '-----------
                        'CtaCtePago.- Forma de Pago
                        '-----------
                        Dim ctaCtePago As New BE.CtasCtesMedica.BE_ReqCtaCtePago()
                        ctaCtePago.cCtaCteRecibo = newcCtaCteRecibo
                        ctaCtePago.cPerCodigo = LblcPerCodigo.Text.Trim '->Cliente
                        ctaCtePago.nPerCtaCodigo = nPerCtaCodigo
                        ctaCtePago.nTurno = CLng(LblNroCaja.Text) '->numero de caja
                        ctaCtePago.nForPago = 1 'contado
                        ctaCtePago.dCtaCtePagfecha = FormatDateTime(DtpFecPago.Value & Space(1) & TimeOfDay)
                        ctaCtePago.cCtaCtePagNroOperacion = ""
                        ctaCtePago.CtaCtePagGlosa = CboMotivoNC.Text
                        ctaCtePago.fCtaCtePagImporte = -Convert.ToDouble(LblTotalPago.Text) '-> en negativousp_Upd_CtaCteNumeracion_nCtaCteNumero

                        Dim gestionarCtaCtePagoServicio As New BL.BL_CtasCtesMedica.BL_CtaCtePago()
                        If gestionarCtaCtePagoServicio.Insert_CtaCtePago(ctaCtePago) <= 0 Then
                            Throw New ApplicationException("Se encontraron errores en la transacción: BL-Insert_CtaCtePago.!")
                        End If

                        '-----------------
                        'CtaCteComprobante.- Datos del Comprobante Fisico
                        '-----------------
                        Dim ctaCteComprobante As New BE.CtasCtesMedica.BE_ReqCtaCteComprobante()
                        ctaCteComprobante.cCtaCteRecibo = newcCtaCteRecibo
                        ctaCteComprobante.nCtaCteComCodigo = CboTipoDocu.SelectedValue
                        ctaCteComprobante.cCtaCteComNumero = cCtaCteComNumero
                        ctaCteComprobante.nCtaCteTipoPago = 1
                        ctaCteComprobante.cPerCodigo = StrUser
                        ctaCteComprobante.dCtaCteEmiFecha = FormatDateTime(DtpFecPago.Value & Space(1) & TimeOfDay)

                        Dim gestionarCtaCteComprobante As New BL.BL_CtasCtesMedica.BL_CtaCteComprobante()
                        If Not gestionarCtaCteComprobante.Insert_CtaCteComprobante(ctaCteComprobante) Then
                            Throw New ApplicationException("Se encontraron errores en la transacción: BL-Insert_CtaCteComprobante.!")
                        End If

                        '-----------------
                        'CtaCteReferencia.- Ammarre entre Factura y Nota de credito
                        '-----------------
                        Dim ctaCteReferencia As New CtaCteReferencia
                        ctaCteReferencia.cCtaCteRecibo = newcCtaCteRecibo '->N/C
                        ctaCteReferencia.cCtaCteRefRecibo = TokenByKey(vCtaCteRecibo, "cCtaCteRecibo") '->Factura
                        ctaCteReferencia.nCtaCteRefTipo = CboMotivoNC.SelectedValue
                        ctaCteReferencia.dCtaCteRefFecha = FormatDateTime(DtpFecPago.Value & Space(1) & TimeOfDay)
                        ctaCteReferencia.cCtaCteRefGlosa = CboMotivoNC.Text
                        ctaCteReferencia.fCtaCteRefImporte = -Convert.ToDouble(LblTotalPago.Text) '-> en negativo

                        Dim gestionarCtaCteReferencia As New GestionarCtaCteReferenciaServicio()
                        If Not gestionarCtaCteReferencia.Insert_CtaCteReferencia(ctaCteReferencia) Then
                            Throw New ApplicationException("Se encontraron errores en ctaCteReferencia transacción: BL-Insert_CtaCteReferencia.!")
                        End If

                        '-----------------
                        'NC por Anulación.- Liberamos las fichas para volver hacer nueva Factura.
                        '-----------------
                        If CboMotivoNC.SelectedValue = 8040 Then
                            Dim BL As New BL.BL_FichaAtencion.BL_FichaAtencion

                            If Not BL.Update_AdmSolAtencion_By_NotaCreditoAnulacion(TokenByKey(vCtaCteRecibo, "cCtaCteRecibo")) Then
                                Throw New ApplicationException("Se encontraron errores en la transacción: " + "[Upd_Update_AdmSolAtencion_By_NotaCreditoAnulacion]")
                            End If

                        End If

                        '------------------------
                        'Actualizando Correlativo.- 
                        '------------------------
                        Dim blCCNumeracion As New BL_CtaCteNumeracion()

                        If Not blCCNumeracion.Upd_CtaCteNumeracion_nCtaCteNumero(StrcPerJuridica, nCajCodigo, nCtaCteComCodigo, CDbl(LblCorrelativo.Text), LblSerie.Text.Trim) Then
                            Throw New ApplicationException("Se encontraron errores en la transacción: [Upd_Upd_CtaCteNumeracion_nCtaCteNumero].!")
                        End If

                        scope.Complete() '-> Commit a todo la transaccion si todo salio OK

                        MessageBox.Show("Nota de Crédito se registró con éxito.", "Grabando..", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End Using

                    Close()
                    Dispose()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click

        EliminaRowSeleccionada(Table1)
        CalcularVta()

    End Sub

    Private Sub Table1_CellEndEdit(ByVal sender As Object, _
                               ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellEndEdit
        'Try
        With Table1
            If .Item(ColumnGrilla.ColnCtaCteCantidad, .CurrentRow.Index).Value <= 0 Then
                .Item(ColumnGrilla.ColnCtaCteCantidad, .CurrentRow.Index).Value = 1 'default
            End If

            Dim Dt_Valor1, Dt_Valor2, Dt_Resultado As Double

            If .Columns(e.ColumnIndex).Name = "nCtaCteCantidad" Or .Columns(e.ColumnIndex).Name = "fCtaCteDetimporte" Then

                Dt_Valor1 = Convert.ToDouble(.Rows(e.RowIndex).Cells("nCtaCteCantidad").EditedFormattedValue)
                Dt_Valor2 = Convert.ToDouble(.Rows(e.RowIndex).Cells("fCtaCteDetimporte").EditedFormattedValue)

                Dt_Resultado = (Dt_Valor1 * Dt_Valor2)
                'sub-total
                .Rows(e.RowIndex).Cells("fCtaCteDetImpTotal").Value = Dt_Resultado

            End If
        End With

        'LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True)
        CalcularVta()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub Table1_EditingControlShowing(ByVal sender As Object, _
                   ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) _
               Handles Table1.EditingControlShowing

        On Error Resume Next

        ' referencia a la celda   
        Dim validar As TextBox = CType(e.Control, TextBox)

        ' agregar el controlador de eventos para el KeyPress   
        AddHandler validar.KeyPress, AddressOf validar_Keypress

    End Sub

    Private Sub validar_Keypress( _
                            ByVal sender As Object, _
                            ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' Obtener indice de la columna   
        Dim columna As Integer = Table1.CurrentCell.ColumnIndex

        ' Comprobar si la celda en edición corresponde a la columna 7   
        If columna = ColumnGrilla.ColnCtaCteCantidad Or columna = ColumnGrilla.ColfCtaCteDetimporte Then

            ' Obtener caracter   
            Dim caracter As Char = e.KeyChar

            ' Comprobar si el caracter es un número o el retroceso   
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                'Me.Text = e.KeyChar
                e.KeyChar = Chr(0)
            End If
        End If

    End Sub

    Public Sub CalcularVta()

        'LblTBruto.Text = FormatNumber(Suma_Columna_SubTotal("nCtaCteCantidad", "nCtaCteSerImpDef", Table1), True)
        LblTotalPago.Text = FormatNumber(Suma_Columna("fCtaCteDetImpTotal", Table1), True) 'nCtaCteSubTotal
        'LblnPorcDscto.Text = FormatNumber(Suma_Columna_SubTotal("nCtaCteCantidad", "nCtaCteSerImpDef", Table1) - CDbl(LblTotalPago.Text), True)
    End Sub

End Class