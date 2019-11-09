Option Explicit On

Imports Integration.BE.Persona
Imports Integration.BE.CtasCtes
Imports Integration.BE.CtasCtesMedica
Imports Integration.BE.FichaAtencion

Imports Integration.BL
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL.BL_CtasCtesMedica
Imports Integration.BL.BL_FichaAtencion

Imports System.Transactions

Public Class FormPrcFormaPago

#Region "Estructura Grilla"

    Enum GrillaDetallePago
        ColnCtaCteForPago = 0
        ColcDescForPago = 1
        ColcPerCodigoBanco = 2
        ColcDescrBanco = 3
        ColdCtaCteFecTransacion = 4
        ColcNroTarjCta = 5
        ColNroTrasacVoucher = 6
        ColnMonCodigo = 7
        ColcDescMoneda = 8
        ColnCtaCtePagImpMon = 9
        ColnTC = 10
        ColnCtaCtePagImporte = 11
        ColnConValor = 12
    End Enum


#End Region

    Public bAutorizaModifFechas As Boolean = False

    Private Sub ObtenerPerCuentaPersona(ByVal cPerCodigo As String)
        'Obteniendo PerCuenta de la Persona
        Dim objPerCta As New BL.BL_CtasCtesMedica.BL_PerCuenta

        Dim nPerCtaCodigo As Integer
        nPerCtaCodigo = objPerCta.Ins_Get_PerCuenta(cPerCodigo, StrcPerJuridica)

        LblnPerCtaCodigo.Text = nPerCtaCodigo
    End Sub

    Private Sub InicilizarCampos()

        'Obteniendo Valores
        LblNroRecibo.Text = TokenByKey(StrPasaValores, "cNroRecibo")

        '--------------------------------------------------------------
        'Create: Enrique Incio
        'Comments: Obteniendo Importe de "Recibo Pendiente de Pago"
        'Date: 2015-11-02
        Dim dt As New DataTable
        dt = ObjSistemaServicio.Get_Value_Table("cc.fCtaCteImporte", "CuentaCorriente cc WITH(NOLOCK)", "", 3, "cc.cCtaCteRecibo = '" + TokenByKey(StrPasaValores, "cNroRecibo") + "' AND cc.dCtaCteFecPago IS NULL AND cc.nCtaCteEstado = 1")

        If dt.Rows.Count > 0 Then
            Dim row As DataRow
            'Llenando DataGridView
            For Each row In dt.Rows
                LblImpRecibo.Text = FormatNumber(row("fCtaCteImporte").ToString, True) 'Importe Recibo
            Next
            If FormatNumber(LblImpRecibo.Text, True) <= 0 Then
                MessageBox.Show("Incoherencia en el importe de pago, por favor verifique.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Incoherencia en el importe de pago, por favor verifique.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        '---------------------------------------------------------------------------

        LblnSolAdmNumero.Text = TokenByKey(StrPasaValores, "nSolAdmNumero")
        'LblImpRecibo.Text = TokenByKey(StrPasaValores, "nImpRecibo")
        LblcPerCodigo.Text = TokenByKey(StrPasaValores, "cPerCodigo")
        LblcNombre.Text = TokenByKey(StrPasaValores, "cPerNombreCompleto")
        LblnIntCodigo.Text = TokenByKey(StrPasaValores, "nIntCodigo")

        'Obteniendo Datos Laboratorio al Facturar
        If LblnIntCodigo.Text = TipoAtencion.LabExterno Or LblnIntCodigo.Text = TipoAtencion.CentroSalud Then
            Dim Servicio As New BL_FichaAtencion
            Dim dataTable As New DataTable

            dataTable = Servicio.Get_Datos_Facturacion_Laboratorio_Or_Convenio_by_nSolAdmNumero(LblnSolAdmNumero.Text)

            If dataTable.Rows.Count > 0 Then
                LblcPerCodigo.Text = dataTable.Rows(0)("cPerCodigo").ToString
                LblcNombre.Text = dataTable.Rows(0)("cRazonSocial").ToString
            End If

        End If
        '---- FIN -----
        LblnPerTipo.Text = TokenByKey(StrPasaValores, "nPerTipo") 'tipo de persona

        'Obteniendo PerCuenta de la Persona
        'Dim objPerCta As New BL.BL_CtasCtesMedica.BL_PerCuenta
        'Dim dtPerCta As New DataTable
        'dtPerCta = objPerCta.Get_PerCuenta(TokenByKey(StrPasaValores, "cPerCodigo"), StrcPerJuridica)

        'If dtPerCta.Rows.Count > 0 Then
        '    LblnPerCtaCodigo.Text = dtPerCta.Rows(0).Item("nPerCtaCodigo").ToString
        'Else
        '    LblnPerCtaCodigo.Text = 0
        'End If
        ObtenerPerCuentaPersona(TokenByKey(StrPasaValores, "cPerCodigo"))
        '--

        If CDbl(LblTotalPago.Text) = 0 Then
            TxtImpPago.Text = LblImpRecibo.Text 'TokenByKey(StrPasaValores, "nImpRecibo")
        End If

        'If TokenByKey(StrPasaValores, "nTipoDocu") = 3007 Then '//CONDONACION
        '    CboFormaPago.SelectedValue = 4 'Condonacion
        '    CboFormaPago.Enabled = False
        'Else
        CboFormaPago.SelectedValue = 1 'Defualt Nuevos Soles
        CboFormaPago.Enabled = True
        'End If

        CboMoneda_SelectionChangeCommitted(CboMoneda, Nothing)
        'TxtImpPago.Text = CDbl(0.0)

        CboBanco.SelectedValue = -1
        CboTipoTarj.SelectedValue = -1
        'CboNroCta_TarjetaDC.SelectedValue = -1
        TxtNroTarjeta.Text = vbNullString

        TxtVoucher.Text = vbNullString

        GrpBoxBco.Visible = False
        GBCortesia.Visible = False

    End Sub

    Function ValidarCampos() As Boolean
        ValidarCampos = False
        If FormatNumber(LblImpRecibo.Text, True) <> FormatNumber(LblTotalPago.Text, True) Then
            MessageBox.Show("Importe a Total a Pagar no es coherente..! por favor de revisar.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtImpPago.Text = FormatNumber(CDbl(LblImpRecibo.Text) - CDbl(LblTotalPago.Text), True)
            'MsgInfoCampoObligatorio("", TxtImpPago.Text)
            Exit Function
        ElseIf CLng(CboFormaPago.SelectedValue) = nFomaPago.nCortesia Then

            If CLng(CboMotivDscto.SelectedValue) = 0 Then
                MessageBox.Show("El Motivo de la cortesía es obligatorio.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.ActiveControl = CboMotivDscto
                Exit Function
            ElseIf TxtDetalleDscto.Text.Trim = "" Then
                MessageBox.Show("La observación de la cortesía es obligatoria.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.ActiveControl = TxtDetalleDscto
                Exit Function
            End If

        End If
        ValidarCampos = True
    End Function

    Function ValidarCamposForAddItemGrd() As Boolean

        ValidarCamposForAddItemGrd = False

        If LblNroRecibo.Text = vbNullString Or LblNroRecibo.Text = "" Then MsgInfoCampoObligatorio(Label5.Text, BtnCancel) : Exit Function
        If CDbl(LblImpRecibo.Text) <= 0 Then MsgInfoCampoObligatorio(Label2.Text, BtnCancel) : Exit Function

        'Update 2016-03-16 (EINCIO)
        If CboTipoVenta.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label21.Text, CboTipoVenta) : Exit Function

        If CboFormaPago.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label1.Text, CboFormaPago) : Exit Function
        If CboMoneda.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label4.Text, CboMoneda) : Exit Function
        If CDbl(TxtImpPago.Text) <= 0 Or TxtImpPago.Text = vbNullString Then MsgInfoCampoObligatorio(Label17.Text, TxtImpPago) : Exit Function

        If CLng(LblnPerCtaCodigo.Text) = 0 Or LblnPerCtaCodigo.Text = vbNullString Then MessageBox.Show("Persona NO tiene Codigo de Cuenta. [PerCuenta]", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Function

        'If Table2.RowCount = 0 Then MsgInfoCampoObligatorio("No existe ningun medio de pago en el Detalle de Pago.", BtnAdd) : Exit Function

        'If FormPrcFacturacion.CboTipoDocu.SelectedValue <> 3007 And CboFormaPago.SelectedValue = 4 Then '//recibo condonacion - forma pago: condonacion
        '    MessageBox.Show("No puede utilizar este medio de pago, para este tipo de comprobante de venta.", Label1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Function
        'End If

        If CboMoneda.SelectedValue <> nTipoMoneda.nSoles Then
            If CDbl(LblTC.Text) <= 0 Then MsgInfoCampoObligatorio(Label20.Text, BtnCancel) : Exit Function
        End If

        Select Case CboFormaPago.SelectedValue
            Case nFomaPago.nCheque

            Case nFomaPago.nDepositoBco
                If CboBanco.SelectedIndex = -1 Then MsgInfoCampoObligatorio(Label13.Text, CboBanco) : Exit Function
                'If CboNroCta_TarjetaDC.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label10.Text, CboNroCta_TarjetaDC) : Exit Function
                If TxtNroTarjeta.Text = vbNullString Or Len(TxtNroTarjeta.Text) = 0 Then MsgInfoCampoObligatorio(Label10.Text, TxtNroTarjeta) : Exit Function
                If TxtVoucher.Text = vbNullString Then MsgInfoCampoObligatorio(Label15.Text, TxtVoucher) : Exit Function

            Case nFomaPago.nTarjetaCred
                If CboBanco.SelectedIndex = -1 Then MsgInfoCampoObligatorio(Label13.Text, CboBanco) : Exit Function
                If CboTipoTarj.SelectedIndex = -1 Then MsgInfoCampoObligatorio(Label12.Text, CboTipoTarj) : Exit Function
                'If CboNroCta_TarjetaDC.SelectedValue = -1 Then MsgInfoCampoObligatorio(Label10.Text, CboNroCta_TarjetaDC) : Exit Function
                If TxtNroTarjeta.Text = vbNullString Or Len(TxtNroTarjeta.Text) = 0 Then MsgInfoCampoObligatorio(Label10.Text, TxtNroTarjeta) : Exit Function
                If TxtVoucher.Text = vbNullString Then MsgInfoCampoObligatorio(Label15.Text, TxtVoucher) : Exit Function
        End Select

        If CDbl(CDbl(Suma_Columna("nCtaCtePagImporte", Table2)) + CDbl(TxtImpPago.Text)) > CDbl(LblImpRecibo.Text) Then
            TxtImpPago.Text = 0
            MessageBox.Show("Importe a Pagar exede el importe.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If

        ValidarCamposForAddItemGrd = True

    End Function

    Public Sub BuscaPersona()

        Try

            Dim Request As New BE_ReqPersonaSearh
            Dim ObjPer As New BL_Personas

            Dim StrFilNroDocu As String = ""
            If TxtNroFind.Text = vbNullString Or Len(TxtNroFind.Text) <= 2 Then Exit Sub
            StrFilNroDocu = TxtNroFind.Text

            Request.cNombre = "Nulo"
            Request.cPerIdeNumero = StrFilNroDocu
            Request.nPerTipo = CboTipoPer.SelectedValue

            If ObjPer.Get_SearhPersona(Request) Is Nothing Then Exit Sub

            If ObjPer.Get_SearhPersona(Request).Rows.Count > 0 Then
                LblcPerCodigo.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cPerCodigo")
                LblcNombre.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cpernombre")

                'Obteniendo PerCuenta del Cliente para tener relacion "CuentaCorriente y CtaCtePago"
                ObtenerPerCuentaPersona(LblcPerCodigo.Text)

                GrpBoxDetCliente.Visible = True : GrpBoxPersona.Visible = False : Me.ActiveControl = CboMoneda
            Else
                If MessageBox.Show("Persona No registra en el sistema. ¿Desea registrar a la persona.?", "Buscando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call BtnAgregar_Click(BtnAgregar, Nothing)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FormPrcFormaPago_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Teclas de acceso rapido por teclado.
        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                BtnAdd_Click(BtnAdd, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Delete))
                BtnQuitar_Click(BtnQuitar, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4))
                BtnRegPago_Click(BtnRegPago, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F7))
                BtnCambiar_Click(BtnCambiar, Nothing)

        End Select

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click

        StrPasaValores = vbNullString
        FormGridFichaAtencion.CboFiltro.SelectedIndex = 0
        FormGridFichaAtencion.TxtBuscar.Text = LblnSolAdmNumero.Text
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub FormPrcFormaPago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Actualizar_Fecha_Servidor()

        bAutorizaModifFechas = Autorizacion_para_Modificacion_Fecha()

        LblNroCaja.Text = Microsoft.VisualBasic.Right("00" & ObtenerParametroAppConfig("NroCaja"), 2)

        'Llena CboTipoDocu segun caja asignada
        Dim ReqTDocu As New BE_TipoDocporNroCaja
        Dim ObjTDocu As New BL_CtaCteServicioFacturacion

        ReqTDocu.cPerJurCodigo = StrcPerJuridica
        ReqTDocu.nIntTipo = 1000
        ReqTDocu.nCajCodigo = CLng(ObtenerParametroAppConfig("NroCaja"))
        ReqTDocu.nIntTipo = 1000

        InicilizarCampos()

        'llena datacombo documentos + series asignadas a la caja actual
        LlenaDataCombo(CboTipoDocu, ObjTDocu.Get_TipoDocporNroCaja(ReqTDocu), "nIntCodigo", "cIntDescripcion")

        If LblnIntCodigo.Text = TipoAtencion.AtencionExterna Then
            CboTipoDocu.SelectedValue = CLng(TipoDocuVta.BoletaVta)
        Else
            'Activa tipo docu parametrizado por default
            CboTipoDocu.SelectedValue = CLng(ObtenerParametroAppConfig("nTipoDocuDefault"))
        End If
 
        Call CboTipoDocu_SelectionChangeCommitted(CboTipoDocu, Nothing)

        FormatGrilla(Table2, Me, False, 35)

        LlenaDataCombo(CboTipoVenta, ObjConst.Get_Constante("C", CLng(TokenByKey(CboTipoVenta.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")
        CboTipoVenta.SelectedValue = 1 'Default Contado

        LlenaDataCombo(CboFormaPago, ObjConst.Get_Constante("C", CLng(TokenByKey(CboFormaPago.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboMoneda, ObjConst.Get_Constante("C", CLng(TokenByKey(CboMoneda.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

        'nuevo cambio
        LlenaDataCombo(CboTipoPer, ObjConst.Get_Constante("C", CLng(CboTipoPer.Tag)), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboPerTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")
        CboPerTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI

        TxtImpPago.Text = FormatNumber(CDbl(LblImpRecibo.Text), True)

        DtpFecPago.Value = dFechaSistema
        DtpFecDeposito.Value = DtpFecPago.Value

        Me.ActiveControl = CboFormaPago
        'CboFormaPago.Focus()

    End Sub

    Private Function Autorizacion_para_Modificacion_Fecha() As Boolean
        Dim RequestPer As New BE.PerUsuario.BE_ReqSearhUsuario
        Dim ObjBLPerDesc As New BL_PerUsuario

        RequestPer.cPerUsuCodigo = FormMDI.SSUser.Text
        RequestPer.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
        RequestPer.nObjCodigo = nSisGruCodigo.ModificadorFechasComprobante

        Dim dt2 As New DataTable
        dt2 = ObjBLPerDesc.Get_UsuarioAutorizado(RequestPer)

        If dt2.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub CboTipoPer_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoPer.SelectionChangeCommitted

        Select Case CboTipoPer.SelectedValue
            Case nConTipoPersona.nPerNatural
                LlenaDataCombo(CboPerTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")
                CboPerTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI
                'CboTipoDocu.SelectedValue = TipoDocuVta.Ticket   'BoletaVta
            Case nConTipoPersona.nPerJuridica
                LlenaDataCombo(CboPerTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerJuridica)), "nConValor", "cConDescripcion")
                CboPerTipoDocu.SelectedValue = nConTipoDocPerJuridica.nRUC
                'CboTipoDocu.SelectedValue = TipoDocuVta.Ticket 'TipoDocuVta.TFactura  'Factura
        End Select
        CboTipoDocu_SelectionChangeCommitted(CboTipoDocu, Nothing)

    End Sub

    Private Sub CboTipoDocu_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoDocu.SelectionChangeCommitted

        'Define la serie en <LblSerie>
        LblSerie.Text = Microsoft.VisualBasic.Left(Trim(CboTipoDocu.Text), 4)

        Dim ObjSerieCorre As New BL_CtaCteNumeracion
        'Update paramString "@cCtaCteSerie_1"
        Dim strCorrelativoDocuVta As String = ObjSerieCorre.Get_CtaCteNumCorrelativo(StrcPerJuridica, CLng(ObtenerParametroAppConfig("NroCaja")), CLng(CboTipoDocu.SelectedValue), LblSerie.Text)

        LblSerie.Text = Microsoft.VisualBasic.Left(strCorrelativoDocuVta, 4)
        LblCorrelativo.Text = Microsoft.VisualBasic.Right(strCorrelativoDocuVta, 7)
        If CboTipoDocu.SelectedValue = 3012 Then
            DtpFecPago.Value = dFechaSistema
            DtpFecPago.Enabled = True ' bAutorizaModifFechas
        Else
            DtpFecPago.Enabled = True
        End If
    End Sub

    Private Sub BtnRegPago_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegPago.Click

        Try
            If ValidarCampos() Then

                '------------------------------------------------
                'Si el pago es por Cortesia necesita Autorizacion
                '------------------------------------------------
                If CboFormaPago.SelectedValue = nFomaPago.nCortesia Then
                    frmSisGruCodigo = nSisGruCodigo.AdmisionCortesia
                    FormLoginAutoriza.ShowDialog()
                    If nFlagCortesia = 0 Then ' denegar
                        Exit Sub
                    End If
                End If

                Dim BLCorrelativo As New BL_CtaCteNumeracion
                Dim ObjCompPago As New BL_CtaCteComprobante_Pago

                Dim ResultadoPago As Boolean
                Dim ResultadoComp As Boolean
                'Dim ResultadoAsiento As Boolean
                'Dim ReqCCDet As New BE_ReqCtaCteDetalle

                'Dim List As New List(Of BE_ReqCtaCteDetalle)
                'Dim Item As BE_ReqCtaCteDetalle = Nothing '//Declara variable

                'Dim ListRec As New Dictionary(Of String, Double)

                Dim cPerCodigo As String = Trim(LblcPerCodigo.Text)
                Dim nCajCodigo As Long = CLng(LblNroCaja.Text)

                Dim nCtaCteComCodigo As Long = CLng(CboTipoDocu.SelectedValue)

                'Update 2016-07-15 (EINCIO) 
                Dim cCtaCteComNumero As String = BLCorrelativo.Get_CtaCteNumCorrelativo(StrcPerJuridica, nCajCodigo, nCtaCteComCodigo, LblSerie.Text)
                '
                If MessageBox.Show("¿Desea registrar Comprobante de Venta.?", "Confirmar operación..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim fMontoCortesia As Double = 0
                    Using scope As New TransactionScope()

                        '-----------
                        'CtaCtePago
                        '-----------
                        With Table2
                            If .RowCount > 0 Then
                                For i As Integer = 0 To .Rows.Count - 1

                                    If CLng(.Item("nCtaCteForPago", i).Value) = nFomaPago.nCortesia Then
                                        fMontoCortesia = fMontoCortesia + CDbl(.Item("nCtaCtePagImporte", i).Value)
                                    End If

                                    ResultadoPago = ObjCompPago.Ins_CtaCtePago_PagDatos(cPerCodigo,
                                                                                    StrcPerJuridica,
                                                                                    LblNroRecibo.Text,
                                                                                    nCajCodigo,
                                                                                    CLng(.Item("nCtaCteForPago", i).Value),
                                                                                    "",
                                                                                    FormatDateTime(.Item("dCtaCteFecTransacion", i).Value & Space(1) & TimeOfDay, DateFormat.GeneralDate),
                                                                                    "Pago por derecho Ficha de Atención",
                                                                                    CDbl(.Item("nCtaCtePagImporte", i).Value),
                                                                                    .Item("cPerCodigoBanco", i).Value,
                                                                                    .Item("cDescrBanco", i).Value,
                                                                                    .Item("cNroTarjCta", i).Value,
                                                                                    .Item("NroTrasacVoucher", i).Value,
                                                                                    .Item("nConValor", i).Value)

                                Next
                            Else
                                MsgInfoCampoObligatorio("No existe ningún medio de Pago, por favor verifique.!", BtnAdd)
                                Exit Sub
                            End If

                        End With

                        '-----------------
                        'CtaCteComprobante
                        '-----------------
                        '1=Contado (Update Tipo de venta 2016-03-16 EINCIO)
                        '//Update 2016-07-15 (EINCIO) paramString <LblSerie.Text>
                        ResultadoComp = ObjCompPago.Ins_CtaCteComprobante_Upd_AdmSolAtencion_Upd_CtaCteNumeracion(LblNroRecibo.Text,
                                                                                                                  nCtaCteComCodigo,
                                                                                                                  cCtaCteComNumero,
                                                                                                                  CLng(CboTipoVenta.SelectedValue),
                                                                                                                  FormatDateTime(DtpFecPago.Value & Space(1) & TimeOfDay),
                                                                                                                  StrcPerJuridica,
                                                                                                                  LblnSolAdmNumero.Text,
                                                                                                                  StrUser,
                                                                                                                  nCajCodigo, LblSerie.Text)

                        ''EstadoFichaAtencion.nPagoRealizado,

                        '--------------------
                        'GenerandoAsientoVta
                        '--------------------
                        'Dim ObjAsiento As New BL_Asiento.BL_ConAsiento
                        'ResultadoAsiento = ObjAsiento.Ins_GenerandoAsientoVta(StrcPerJuridica,
                        '                                                      cPerCodigo,
                        '                                                      FormatDateTime(dFechaSistema & Space(1) & TimeOfDay),
                        '                                                      "Venta maquina registradora.",
                        '                                                      "1212101", "4011101", "7041001", "1091013",
                        '                                                      cCtaCteComNumero, nCtaCteComCodigo, 3003,
                        '                                                      LblNroRecibo.Text, cCtaCteComNumero,
                        '                                                      TipoMoneda.nSoles, 0.0, CLng(LblTotalPago.Text))

                        '----------------------
                        'Registrando Auditoria
                        '----------------------
                        If CboFormaPago.SelectedValue = nFomaPago.nCortesia Then
                            Dim Objeto As New BE_ReqSolAtencion
                            Dim Servicio As New BL_FichaAtencion
                            Objeto.cPerJuridica = StrcPerJuridica
                            Objeto.nIntCodigo = CInt(LblnIntCodigo.Text)
                            Objeto.nSolAdmNumero = LblnSolAdmNumero.Text
                            Objeto.nAudiIntClase = 1004 'poner en variable Global
                            Objeto.nAudiIntCodigo = TokenByKey(StrPasaValores, "nSisGruCodigo")
                            Objeto.cAudiDescripcion = TokenByKey(StrPasaValores, "cPerCodUsuario")
                            'Detalle de Cortesía
                            Objeto.nAudiMotivoDscto = Val(CboMotivDscto.SelectedValue)
                            Objeto.cAudiDetalleDscto = TxtDetalleDscto.Text.Trim
                            Objeto.fAudiPorcDscto = 100
                            Objeto.fAudiTotalDscto = fMontoCortesia

                            If Not Servicio.Ins_AdmSolAtenAuditoria(Objeto) Then Throw New System.Exception("Se encontraron errores, al agregar Auditoria.")
                        End If

                        '----------------------------------------------
                        'Si cumple esto se  actualiza "AdmSolPerToken"
                        '----------------------------------------------
                        If nFlagToken = 1 And Len(Trim(cKeyToken)) > 0 Then

                            'Dim admSolPerToken As New AdmSolPerToken
                            'Dim gestionarAdmSolPerTokenServicio As New GestionarAdmSolPerTokenServicio

                            'admSolPerToken.cPerCodigo = cPerUsuDscto
                            'admSolPerToken.cPerJurCodigo = StrcPerJuridica
                            'admSolPerToken.cToken = cKeyToken
                            'admSolPerToken.nTipo = nSisGruCodigo.AdmisionAprobador
                            'admSolPerToken.nSolAdmNumero = LblNroSolicitud.Text

                            'If Not gestionarAdmSolPerTokenServicio.Upd_AdmSolPerToken(admSolPerToken) Then
                            '    Throw New System.Exception("Se encontraron errores en la transaccion: [Upd_AdmSolPerToken]")
                            'End If

                            Actualiza_AdmSolPerToken(cPerAutToken, StrcPerJuridica, cKeyToken, nSisGruCodigo.AdmisionCortesia, LblnSolAdmNumero.Text)

                        End If

                        If ResultadoComp Then 'And ResultadoAsiento Then

                            scope.Complete()
                            'MessageBox.Show("Comprobante de Venta se registro con exitó.", "Imprimiendo..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'BtnCancel_Click(BtnCancel, Nothing)
                        Else
                            MessageBox.Show("Se encontraron errores..!", "Grabando..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    End Using

                    'Imprimir comprobante
                    'MessageBox.Show(StrcPerJuridica & " " & CboTipoDocu.SelectedValue.ToString & " " & Trim(LblSerie.Text) & Trim(LblCorrelativo.Text))
                    'ImprimeTicket(StrcPerJuridica, CboTipoDocu.SelectedValue, Trim(LblSerie.Text) & Trim(LblCorrelativo.Text))

                    'Update 2016-03-16 (JDEPAZ)
                    If CboTipoDocu.SelectedValue = 3012 Then 'LblnIntCodigo.Text <> TipoAtencion.AtencionExterna Then
                        PrintStarIO(StrcPerJuridica, CboTipoDocu.SelectedValue, Trim(LblSerie.Text) & Trim(LblCorrelativo.Text))
                        'ImprimeTicket(StrcPerJuridica, CboTipoDocu.SelectedValue, Trim(LblSerie.Text) & Trim(LblCorrelativo.Text))
                    End If

                    StrPasaValores = vbNullString
                    Close()
                    Dispose()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click

        Dim Rows As Integer

        If ValidarCamposForAddItemGrd() Then

            'Validando si el medio de pago ya es utilizado
            If BuscaCadenaDgView("nCtaCteForPago", CboFormaPago.SelectedValue.ToString, Table2) Then 'AndAlso BuscaCadenaDgView("cPerCodigoBanco", CboBanco.ToString, Table2) Then
                MessageBox.Show("Medio de Pago <YA> ha sido utilizado, no podra utilizar el mismo medio de pago para el pago, verifique por favor.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                REM si no existe, aqui insertas el fila
                With Table2
                    Rows = .RowCount()
                    .Rows.Add()
                    .Item("nCtaCteForPago", Rows).Value = CLng(CboFormaPago.SelectedValue)
                    .Item("cDescForPago", Rows).Value = UCase(CboFormaPago.Text) '**Desc Tipo de Moneda
                    .Item("cPerCodigoBanco", Rows).Value = CboBanco.SelectedValue
                    .Item("cDescrBanco", Rows).Value = CboBanco.Text
                    .Item("dCtaCteFecTransacion", Rows).Value = IIf(CboFormaPago.SelectedValue = nFomaPago.nEfectivo, FormatDateTime(DtpFecPago.Value, DateFormat.GeneralDate), FormatDateTime(DtpFecDeposito.Value, DateFormat.GeneralDate))
                    .Item("cNroTarjCta", Rows).Value = Trim(TxtNroTarjeta.Text)
                    .Item("NroTrasacVoucher", Rows).Value = Trim(TxtVoucher.Text)
                    .Item("nMonCodigo", Rows).Value = CLng(CboMoneda.SelectedValue)
                    .Item("cDescMoneda", Rows).Value = UCase(CboMoneda.Text)
                    .Item("nCtaCtePagImpMon", Rows).Value = CDbl(TxtImpPago.Text)
                    .Item("nTC", Rows).Value = IIf(CboMoneda.SelectedValue = nTipoMoneda.nSoles, 1, CDbl(LblTC.Text))
                    .Item("nCtaCtePagImporte", Rows).Value = IIf(CboMoneda.SelectedValue = nTipoMoneda.nSoles, CDbl(TxtImpPago.Text), CDbl(TxtImpPago.Text) * CDbl(LblTC.Text))

                    .Item("nConValor", Rows).Value = IIf(CboFormaPago.SelectedValue = nFomaPago.nEfectivo, 0, CLng(CboTipoTarj.SelectedValue)) 'add tipo de tarjeta (update 2016-01-15 eincio)
                End With

                REM limpio para seguir agregando mas
                'InicilizarCampos()
                LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCtePagImporte", Table2), True)

                'Cuanto le falta para completar el total del recibo
                TxtImpPago.Text = FormatNumber(CDbl(LblImpRecibo.Text) - Suma_Columna("nCtaCtePagImporte", Table2), True)
                If LblImpRecibo.Text <> LblTotalPago.Text Then CboFormaPago.Focus()
                CboTipoDocu.Enabled = False
                DtpFecPago.Enabled = True
            End If
        End If

    End Sub

    Private Sub BtnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuitar.Click

        Call EliminaRowSeleccionada(Table2)
        LblTotalPago.Text = Suma_Columna("nCtaCtePagImporte", Table2)

        TxtImpPago.Text = FormatNumber(CDbl(LblImpRecibo.Text) - CDbl(LblTotalPago.Text), True)
        If Table2.RowCount = 0 Then
            CboTipoDocu.Enabled = True

            DtpFecPago.Enabled = IIf(CboTipoDocu.SelectedValue = 3012, True, True) 'bAutorizaModifFechas, False)
        End If

    End Sub

    Private Sub CboFormaPago_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboFormaPago.KeyPress, CboTipoDocu.KeyPress, CboMoneda.KeyPress, CboBanco.KeyPress, CboTipoTarj.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub CboFormaPago_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboFormaPago.SelectionChangeCommitted

        'Update 2016-01-15 (eincio)
        If CDbl(Suma_Columna("nCtaCtePagImporte", Table2)) = CDbl(LblImpRecibo.Text) Then
            If MessageBox.Show("Usted ya ha definido Detalle Pago Multiple en su totalidad." & Chr(13) &
                        "¿Desea revertir y cambiar la forma de pago.?", "Validando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                EliminarRowsDgView(Table2)
                LblTotalPago.Text = Suma_Columna("nCtaCtePagImporte", Table2)
                TxtImpPago.Text = FormatNumber(CDbl(LblImpRecibo.Text) - CDbl(LblTotalPago.Text), True)
            Else
                CboFormaPago.SelectedValue = nFomaPago.nEfectivo 'Default
                'CboFormaPago_SelectionChangeCommitted(CboFormaPago, Nothing)
            End If
        End If


        Select Case CLng(CboFormaPago.SelectedValue)

            Case nFomaPago.nEfectivo
                GrpBoxBco.Visible = False
                GBCortesia.Visible = False
                CboBanco.SelectedValue = -1 : CboTipoTarj.SelectedValue = -1
                'CboNroCta_TarjetaDC.SelectedValue = -1
                TxtNroTarjeta.Text = "" : TxtVoucher.Text = ""

            Case nFomaPago.nCheque
                'se pone por default en efectivo
                CboFormaPago.SelectedValue = nFomaPago.nEfectivo

            Case nFomaPago.nDepositoBco

                Dim ReqBco As New BE_ReqBuscarEntidadFinanciera
                Dim daBco As New BL_CtaCteServicioFacturacion

                GrpBoxBco.Visible = True
                GBCortesia.Visible = False

                Label13.Text = "Entidad Financiera:"
                CboBanco.SelectedValue = -1

                ReqBco.cFlag = "EBS" '"EBE"
                ReqBco.cPerJurCodigo = StrcPerJuridica '// CboBanco.SelectedValue

                LlenaDataCombo(CboBanco, daBco.Get_EntidadFinaciera_Tarjetas(ReqBco), "cPerCodigo", "cPerApellido")

                CboTipoTarj.Enabled = False : CboTipoTarj.SelectedValue = -1
                Label12.Text = ""

                Label10.Text = "Nro. Cuenta:" 'Equipo se puden definir nro de cuenta de la empresa (agregar Combo)
                CboBanco_SelectionChangeCommitted(CboBanco, Nothing)
                Label15.Text = "Nro. Voucher:"

            Case nFomaPago.nTarjetaCred

                Dim ReqBco As New BE_ReqBuscarEntidadFinanciera
                Dim daBco As New BL_CtaCteServicioFacturacion

                Label13.Text = "Entidad Financiera:"
                CboBanco.SelectedValue = -1
                ReqBco.cFlag = "EBS" '--TODAS LAS ENTIDADES BANCARIAS DEL SISTEMA
                LlenaDataCombo(CboBanco, daBco.Get_EntidadFinaciera_Tarjetas(ReqBco), "cPerCodigo", "cPerApellido")

                Label12.Text = "Tipo Tarjeta:"
                CboTipoTarj.Enabled = True
                'LlenaDataCombo(CboTipoTarj, ObjInterface.Get_Interface(CLng(TokenByKey(CboTipoTarj.Tag, "nIntClase")), CLng(TokenByKey(CboTipoTarj.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")
                LlenaDataCombo(CboTipoTarj, ObjConst.Get_Constante("C", CLng(TokenByKey(CboTipoTarj.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

                Label10.Text = "Nro. de Tarjeta:"
                Call CboTipoTarj_SelectionChangeCommitted(CboTipoTarj, Nothing)

                Label15.Text = "Nº Ope./Transac.:"
                GrpBoxBco.Visible = True
                GBCortesia.Visible = False

            Case nFomaPago.nCortesia
                GrpBoxBco.Visible = False
                GBCortesia.Visible = True
                CboBanco.SelectedValue = -1 : CboTipoTarj.SelectedValue = -1
                'CboNroCta_TarjetaDC.SelectedValue = -1
                TxtNroTarjeta.Text = vbNullString : TxtVoucher.Text = vbNullString
                TxtDetalleDscto.Text = vbNullString

                'Carga: Interface: 2802
                Dim ObjInterface_2 As New BL_Interface
                LlenaDataCombo(CboMotivDscto, ObjInterface_2.Get_Interface(CLng(TokenByKey(CboMotivDscto.Tag, "nIntClase")), CLng(TokenByKey(CboMotivDscto.Tag, "nIntTipo")), "J"), "nIntCodigo", "cIntDescripcion")

            Case nFomaPago.nAnticipo
                'se pone por default en efectivo
                CboFormaPago.SelectedValue = nFomaPago.nEfectivo

        End Select

    End Sub

    Private Sub CboTipoTarj_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoTarj.SelectionChangeCommitted

        'Dim ReqBco As New BE_ReqBuscarEntidadFinanciera
        'Dim daBco As New BL_CtaCteServicioFacturacion

        'CboNroCta_TarjetaDC.SelectedValue = -1
        'CboNroCta_TarjetaDC.DataSource = Nothing
        'ReqBco.cFlag = "TDC"
        'ReqBco.cPerCodigo = CboBanco.SelectedValue.ToString
        'ReqBco.nPerIntCodigo = CboTipoTarj.SelectedValue
        'LlenaDataCombo(CboNroCta_TarjetaDC, daBco.Get_EntidadFinaciera_Tarjetas(ReqBco), "cPerCodigo", "cPerIntDescripcion")

        TxtNroTarjeta.Text = vbNullString
        TxtVoucher.Text = vbNullString

    End Sub

    Private Sub CboBanco_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboBanco.SelectionChangeCommitted

        'If CboFormaPago.SelectedValue = nFomaPago.nDepositoBco Then
        '    'MsgBox("Pasando por Aqui")
        '    Dim ReqBco As New BE_ReqBuscarEntidadFinanciera
        '    Dim daBco As New BL_CtaCteServicioFacturacion

        '    CboNroCta_TarjetaDC.SelectedValue = -1
        '    CboNroCta_TarjetaDC.DataSource = Nothing
        '    ReqBco.cFlag = "MCB"
        '    ReqBco.cPerJurCodigo = StrcPerJuridica
        '    ReqBco.cPerCodigo = CboBanco.SelectedValue
        '    LlenaDataCombo(CboNroCta_TarjetaDC, daBco.Get_EntidadFinaciera_Tarjetas(ReqBco), "nPerCtaCodigo", "cNroCuentaOpera")
        'End If

    End Sub

    Private Sub CboMoneda_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboMoneda.SelectionChangeCommitted

        LblTC.Text = TipoCambio(CboMoneda.SelectedValue, "TCD", dFechaSistema)

    End Sub

    Private Sub BtnPagoDet_Click(sender As System.Object, e As System.EventArgs) Handles BtnPagoDet.Click

        'If TxtStrDetalle.Enabled Then
        '    BtnPagoDet.Text = " Más detalles (F8) »"
        '    TxtStrDetalle.Enabled = False
        '    TxtStrDetalle.Text = vbNullString
        '    Me.Height = 444
        'Else
        '    BtnPagoDet.Text = " Quitar detalles (F8) «"
        '    Me.Height = 553
        '    TxtStrDetalle.Enabled = True
        '    TxtStrDetalle.Focus()

        'End If

    End Sub

    Private Sub TxtImpPago_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImpPago.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
        'e.Handled = Numero(e, TxtImpPago) ' TxtImpPago, caja de texto a validar
        e.Handled = TextBoxImporte(e, TxtImpPago)


    End Sub

    Private Sub PictureBox2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox3.Visible = True
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox3.Visible = False
    End Sub

    Private Sub TxtNroTarjeta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroTarjeta.KeyPress, TxtVoucher.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtImpPago_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtImpPago.Enter
        If (Not String.IsNullOrEmpty(TxtImpPago.Text)) Then
            TxtImpPago.SelectionStart = 0
            TxtImpPago.SelectionLength = TxtImpPago.Text.Length
        End If
    End Sub

    Private Sub BtnCambiar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCambiar.Click

        GrpBoxDetCliente.Visible = False : GrpBoxPersona.Visible = True : Me.ActiveControl = TxtNroFind

    End Sub

    Private Sub TxtNroFind_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroFind.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BuscaPersona()
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click


        nAccionBotones = nAccionButton.nAccionNuevo
        nFlagPersona = 1

        FormMaPersona.Width = 503 '435
        nFormPerPredeterminado = CboTipoPer.SelectedValue 'nConTipoPersona.nPerNatural
        FormMaPersona.TxtNroDocu.Text = TxtNroFind.Text
        Me.Opacity = 1.83
        FormMaPersona.Owner = Me
        FormMaPersona.ShowDialog(Me)

        BuscaPersona()

        Me.ActiveControl = CboMoneda

    End Sub

    Private Sub GrpBoxPersona_Click(sender As Object, e As System.EventArgs) Handles GrpBoxPersona.Click
        GrpBoxPersona.Visible = False : GrpBoxDetCliente.Visible = True
    End Sub

    Private Sub DtpFecPago_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DtpFecPago.Validating
        If CDate(DtpFecPago.Text) > CDate(dFechaSistema) Then
            MessageBox.Show("El comprobante no puede tener fecha futura.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub
End Class