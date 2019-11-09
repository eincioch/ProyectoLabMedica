Option Explicit On

Imports ConsultSUNAT.evSUNAT

Imports Integration.DataIntegration
Imports Integration.BE
Imports Integration.BE.Persona
Imports Integration.BL
Imports Integration.BL.BL_Persona

Imports System.Transactions

Public Class FormMaPersona
    Dim Obj_PerEdad As New BL_Personas

    Dim myInfo As ConsultSUNAT.evSUNAT

    Private Sub CargarImagen()
        Try
            If myInfo Is Nothing Then
                myInfo = New ConsultSUNAT.evSUNAT()
                pictureCapcha.Image = myInfo.GetCapcha
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Limpiar()
        TxtApePat.Text = ""
        TxtApeMat.Text = ""
        Txt1Nombre.Text = ""
        Txt2Nombre.Text = ""
        Txt3Nombre.Text = ""
    End Sub

    Private Sub Get_BuscarDatosPadron()
        If CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI Then '--DNI
            Dim dt As DataTable = Get_DatosReniec(Trim(TxtNroDocu.Text))
            If dt.Rows.Count > 0 Then
                TxtNroDocu.Text = dt.Rows(0)("dni").ToString
                TxtApePat.Text = dt.Rows(0)("apellido_paterno").ToString
                TxtApeMat.Text = dt.Rows(0)("apellido_materno").ToString

                Txt1Nombre.Text = dt.Rows(0)("nombre1").ToString
                Txt2Nombre.Text = dt.Rows(0)("nombre2").ToString

                MTxtFecNaci.Text = dt.Rows(0)("fecha_nacimiento").ToString
                CboSexoTEmp.SelectedValue = dt.Rows(0)("cod_sexo").ToString
            End If
        End If
    End Sub

    Private Sub ValidarNumeroDocuExiste()

        Try
            Dim ReqIdentifica As New BE_ReqPerIdentifica
            Dim ObjIdentifica As New BL_Personas
            '------------------
            'Verifica si existe
            '------------------
            ReqIdentifica.nPerIdeTipo = CLng(CboTipoDocu.SelectedValue)
            ReqIdentifica.cPerIdeNumero = Trim(TxtNroDocu.Text)

            If ObjIdentifica.Get_ExistePerIdentifica(ReqIdentifica) <> 0 Then
                ResaltarTextBox(TxtNroDocu)
                BtnGrabar.Enabled = False 'bloqueo para evitar que dupliquen persona
                MessageBox.Show("Número de Documento se encuentra ya registrado en la base de datos.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'TxtNroDocu.Focus()
                Exit Sub
            Else
                BtnGrabar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        REM SUNAT bloqueo su servicio por eso se comento este codigo
        'LblEstadoSUNAT.Visible = False : LblEstadoSUNAT.Text = vbNullString
        'If CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica And CboTipoDocu.SelectedValue = nConTipoDocPerJuridica.nRUC Then
        '    StrResultado = FindRUCPageSUNAT(Trim(TxtNroDocu.Text))
        '    If TokenByKey(StrResultado, "RazonSocial") = vbNullString Then Exit Sub
        '    Txt1Nombre.Text = TokenByKey(StrResultado, "RazonSocial")
        '    LblEstadoSUNAT.Visible = True : LblEstadoSUNAT.Text = TokenByKey(StrResultado, "Estado")
        'End If
    End Sub

    Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False

        If LblcPerCodigo.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label1.Text, CboTipoPer)
            Exit Function
        End If
        If CboTipoPer.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label5.Text, CboTipoPer)
            Exit Function
        End If
        If CboTipoDocu.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label11.Text, CboTipoDocu)
            Exit Function
        End If
        If Trim(TxtNroDocu.Text) = "" Then
            MsgInfoCampoObligatorio(LblNroDocu.Text, TxtNroDocu)
            Exit Function
        End If

        If CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then
            If CboTipoDocu.SelectedValue = 25 Then 'DNI
                If Len(TxtNroDocu.Text) <> 8 Then
                    MsgInfoCampoObligatorio("Nro. de documento no válido, debe tener 8 digitos.", TxtNroDocu)
                    Exit Function
                End If
            End If
        End If

        '------------
        ' Valida RUC
        '------------
        If CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
            If CboTipoDocu.SelectedValue = nConTipoDocPerJuridica.nRUC Then
                If Not Valida_RUT(TxtNroDocu.Text) Then
                    MsgInfoCampoObligatorio("RUC no es valido, por favor de verificar.", TxtNroDocu)
                    Exit Function
                End If
            End If
        End If

        If Trim(TxtApePat.Text) = "" Then
            MsgInfoCampoObligatorio(Label2.Text, TxtApePat)
            Exit Function
        End If

        If CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then
            If TxtApeMat.Text = vbNullString Then
                MsgInfoCampoObligatorio(Label3.Text, TxtApeMat)
                Exit Function
            End If

            MTxtFecNaci.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            If String.IsNullOrEmpty(MTxtFecNaci.Text) Or Len(MTxtFecNaci.Text) < 8 Then
                MsgInfoCampoObligatorio("Fecha no válida...!", MTxtFecNaci)
                Exit Function
            End If

            MTxtFecNaci.TextMaskFormat = MaskFormat.IncludePromptAndLiterals

            'El texto "Fecha de Nacimiento Invalida" viene de la function "CalculaEdad"
            If Trim(LblnEdad.Text) = "Fecha de Nacimiento Invalida" Then '<= 0 Then
                MsgInfoCampoObligatorio(Label18.Text, LblnEdad)
                Exit Function
            End If

            If Year(CDate(MTxtFecNaci.Text)) < 1910 Then
                MsgInfoCampoObligatorio("Fecha no válida...!", MTxtFecNaci)
                Exit Function
            End If

            Dim dateValue As Date
            If Not Date.TryParse(MTxtFecNaci.Text, dateValue) Then
                MsgInfoCampoObligatorio(Label4.Text, MTxtFecNaci)
                Exit Function
            End If
        End If

        If Txt1Nombre.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label6.Text, Txt1Nombre)
            Exit Function
            'ElseIf DateTime.TryParse(DtpFecNacCrea.Value, DtpFecNacCrea.Value) Then
            '    MsgInfoCampoObligatorio(Label4.Text, Txt1Nombre)
            '    Exit Function
        End If

        If CboNacionalidad.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label12.Text, CboNacionalidad)
            Exit Function
        End If

        If CboSexoTEmp.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label13.Text, CboSexoTEmp)
            Exit Function
        End If

        If CboEstadoCivil.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label8.Text, CboEstadoCivil)
            Exit Function
        End If

        ValidaCamposObligatorios = True

    End Function

    'Private Sub DtpFechaNacimiento()

    '    ''If Not MTxtFecNaci.ValidatingType.IsValueType Then Exit Sub
    '    'Try
    '    '    Dim DFecha As String = MTxtFecNaci.Text.ToString   'CboDia.Text + "/" + CboMes.SelectedValue.ToString + "/" + CboAnio.Text
    '    '    Dim dateValue As Date

    '    '    'validando fechas
    '    '    If DateTime.TryParse(DFecha, dateValue) Then
    '    '        DtpFecNacCrea.Value = CDate(DFecha)
    '    '    Else
    '    '        MsgInfoCampoObligatorio(Label4.Text & " no valida", MTxtFecNaci) 'CboDia)
    '    '    End If
    '    'Catch ex As Exception
    '    '    MessageBox.Show(ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    'End Try


    'End Sub

    Private Sub GeneraNewIdcPerCodigo()
        'Genera cPerCodigo nuevo "usp_Persona_Get_NewId"
        'Dim Request As New Persona.BE_ReqPersona
        Dim ObjNewId As New BL_Personas

        'Request.cPerJurCodigo = StrcPerJuridica
        'If ObjNewId.Get_NewIdcPerCodigo_Out(Request).Rows.Count > 0 Then
        LblcPerCodigo.Text = ObjNewId.Get_NewIdcPerCodigo_Out(StrcPerJuridica) '.Rows(0)("cPerCodigoV")
        'End If
    End Sub

    Private Sub EstablecerFormPredeterminado(ByVal nTipoPersona As Integer)

        If nTipoPersona = nConTipoPersona.nPerNatural Then

            CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural

            CboTratoPer.Enabled = True : TxtApePat.Enabled = True : TxtApeMat.Enabled = True : Txt2Nombre.Enabled = True : Txt3Nombre.Enabled = True
            Label4.Text = "Fecha Nacimiento:" : Label6.Text = "Primer nombre:" : Label13.Text = "Sexo:" : Label8.Text = "Estado civil:"

            LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")
            LlenaDataCombo(CboSexoTEmp, ObjConst.Get_Constante("C", CLng(CboSexoTEmp.Tag)), "nConValor", "cConDescripcion")
            LlenaDataCombo(CboEstadoCivil, ObjConst.Get_Constante("C", CLng(CboEstadoCivil.Tag)), "nConValor", "cConDescripcion")

            CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI

        End If

        If nTipoPersona = nConTipoPersona.nPerJuridica Then

            CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica

            LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerJuridica)), "nConValor", "cConDescripcion")

            CboTratoPer.Enabled = False : TxtApePat.Enabled = False : TxtApeMat.Enabled = False : Txt2Nombre.Enabled = False : Txt3Nombre.Enabled = False
            Label4.Text = "Fecha Creación" : Label6.Text = "Razon Social" : Label13.Text = "Tipo Empresa" : Label8.Text = "Rubro Empresa"

            'RequestConst.nConCodigo = 1023 'Tipo de Empresa
            LlenaDataCombo(CboSexoTEmp, ObjConst.Get_Constante("C", CLng(1023)), "nConValor", "cConDescripcion")

            'RequestConst.nConCodigo = 1024 'Sector economico
            LlenaDataCombo(CboEstadoCivil, ObjConst.Get_Constante("C", CLng(1024)), "nConValor", "cConDescripcion")

        End If

        TxtNroDocu.Focus()

    End Sub

    Private Sub FormMaPersona_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

        'Recupero la foto si tiene
        RequestImg.cPerCodigo = LblcPerCodigo.Text
        RequestImg.cUltimaPhoto = "A"

        If ObjImg.Get_PerImagen(RequestImg).Rows.Count > 0 Then
            PictureBox1.BackgroundImage = ObtenerPhoto(ObjImg.Get_PerImagen(RequestImg).Rows(0)("iPerImaFoto"))
        End If
    End Sub

    Private Sub FormMaPersona_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try
            Select Case e.KeyCode
                Case AscW(Microsoft.VisualBasic.ChrW(Keys.F1))
                    BtnDireccion_Click(BtnDireccion, Nothing)
                Case AscW(Microsoft.VisualBasic.ChrW(Keys.F2))
                    BtnFono_Click(BtnFono, Nothing)
                Case AscW(Microsoft.VisualBasic.ChrW(Keys.F3))
                    BtnEmail_Click(BtnEmail, Nothing)
                Case AscW(Microsoft.VisualBasic.ChrW(Keys.F5))
                    BtnTipoDocu_Click(BtnTipoDocu, Nothing)
                Case AscW(Microsoft.VisualBasic.ChrW(Keys.F6))
                    BtnFoto_Click(BtnFoto, Nothing)
                Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4))
                    BtnGrabar_Click(BtnGrabar, Nothing)
                Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                    BtnCancel_Click(BtnCancel, Nothing)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub FormMaPersona_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            MTxtFecNaci.Mask = "00/00/0000"
            MTxtFecNaci.ValidatingType = GetType(System.DateTime)
            MTxtFecNaci.TextMaskFormat = MaskFormat.IncludeLiterals

            Me.ToolTip1.IsBalloon = True

            LblMsg.Text = Me.Text
            'Tipo de persona
            LlenaDataCombo(CboTipoPer, ObjConst.Get_Constante("C", CLng(CboTipoPer.Tag)), "nConValor", "cConDescripcion")

            'Trato de persona
            LlenaDataCombo(CboTratoPer, ObjConst.Get_Constante("C", CLng(CboTratoPer.Tag)), "nConValor", "cConDescripcion")

            'CboDia.SelectedIndex = 0
            'Meses
            'LlenaDataCombo(CboMes, ObjConst.Get_Constante("C", CLng(CboMes.Tag)), "nConValor", "cConDescripcion")
            'Años
            'LlenaDataCombo(CboAnio, ObjConst.Get_Constante("C", CLng(CboAnio.Tag)), "nConValor", "cConDescripcion")

            'Nacionalidad
            LlenaDataCombo(CboNacionalidad, ObjInterface.Get_Interface(CLng(TokenByKey(CboNacionalidad.Tag, "nIntClase")), CLng(TokenByKey(CboNacionalidad.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")

            If nAccionBotones = nAccionButton.nAccionNuevo Then

                LimpiarTextBox(Me)
                'nuevo codigo 
                LblcPerCodigo.Text = "Nuevo"
                'GeneraNewIdcPerCodigo()

                If nFormPerPredeterminado = 0 Then
                    EstablecerFormPredeterminado(1)
                    CboTipoPer.Enabled = True
                Else
                    EstablecerFormPredeterminado(nFormPerPredeterminado)
                    CboTipoPer.Enabled = False
                End If

                CboTratoPer.SelectedValue = 4
                CboNacionalidad.SelectedValue = 9589 'Default: Perú (select * from interface i where nIntClase=4010 and nIntTipo=1000)
                CboTipoPer.Enabled = True
                TxtNroDocu.Enabled = True
            ElseIf nAccionBotones = nAccionButton.nAccionEdit Then

                EstablecerFormPredeterminado(nFormPerPredeterminado)
                'recuperando datos
                LblcPerCodigo.Text = TokenByKey(StrPasaValores, "cPerCodigo")
                CboTipoPer.SelectedValue = TokenByKey(StrPasaValores, "nPerTipo")
                Call CboTipoPer_SelectionChangeCommitted(CboTipoPer, Nothing)
                CboTipoDocu.SelectedValue = TokenByKey(StrPasaValores, "nPerIdeTipo")
                TxtNroDocu.Text = TokenByKey(StrPasaValores, "cPerIdeNumero")
                CboTratoPer.SelectedValue = IIf(TokenByKey(StrPasaValores, "nPerTratamiento") <> 0, TokenByKey(StrPasaValores, "nPerTratamiento"), CboTratoPer.SelectedValue = 1)
                TxtApePat.Text = TokenByKey(StrPasaValores, "cPerApellPaterno")
                TxtApeMat.Text = TokenByKey(StrPasaValores, "cPerApellMaterno")
                Txt1Nombre.Text = IIf(TokenByKey(StrPasaValores, "cPerPriNombre") <> vbNullString, TokenByKey(StrPasaValores, "cPerPriNombre"), TokenByKey(StrPasaValores, "cpernombre"))
                Txt2Nombre.Text = TokenByKey(StrPasaValores, "cPerSegNombre")
                Txt3Nombre.Text = TokenByKey(StrPasaValores, "cPerTerNombre")
                'DtpFecNacCrea.Value = CDate(TokenByKey(StrPasaValores, "dPerNacimiento"))


                MTxtFecNaci.Text = Format(CDate(TokenByKey(StrPasaValores, "dPerNacimiento")), "dd/MM/yyyy")

                MTxtFecNaci.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
                If Len(MTxtFecNaci.Text) = 8 Then
                    MTxtFecNaci.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
                    LblnEdad.Text = CalculaEdad(CDate(MTxtFecNaci.Text), CDate(dFechaSistema))
                End If

                'Llenando Combox Dia, Mes, Año
                'CboDia.Text = DtpFecNacCrea.Value.Day
                'CboMes.SelectedValue = DtpFecNacCrea.Value.Month
                'CboAnio.Text = DtpFecNacCrea.Value.Year.ToString

                CboSexoTEmp.SelectedValue = IIf(TokenByKey(StrPasaValores, "nPerNatSexo") <> 0, Val(TokenByKey(StrPasaValores, "nPerNatSexo")), TokenByKey(StrPasaValores, "nPerJurTipInversion"))
                CboEstadoCivil.SelectedValue = IIf(TokenByKey(StrPasaValores, "nPerNatEstCivil") <> 0, TokenByKey(StrPasaValores, "nPerNatEstCivil"), TokenByKey(StrPasaValores, "nPerJurSecEconomico"))
                LblUbigeo.Text = TokenByKey(StrPasaValores, "cUbiGeoCodigo")
                CboNacionalidad.SelectedValue = TokenByKey(StrPasaValores, "nIntCodigo")

                CboTipoPer.Enabled = False
                TxtNroDocu.Enabled = False

                'If CLng(LblnEdad.Text) < 18 Then BtnAddParentesco.Visible = True

            End If

            Me.ActiveControl = TxtNroDocu

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub BtnSelectUbigeo_Click(sender As System.Object, e As System.EventArgs) Handles BtnSelectUbigeo.Click
        FormUbigeo.ShowDialog()
    End Sub

    Private Sub LblUbigeo_TextChanged(sender As Object, e As System.EventArgs) Handles LblUbigeo.TextChanged

        Dim Request As New Sistema.BE_ReqUbigeo
        Dim ObjUbigeo As New BL_Sistema

        Request.Codigo = LblUbigeo.Text
        LblDetalleUbigeo.Text = ObjUbigeo.Get_Ubigeo(Request)
    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        StrPasaValores = vbNullString
        nFlagPersona = 0
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BtnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGrabar.Click

        Try
            Dim Request As New BE_ReqPersona
            Dim ObjPer As New BL_Personas

            Dim StrSQl As String = ""
            Dim Resultado As Boolean = False

            If ValidaCamposObligatorios() Then

                'Using scope As New TransactionScope
                'Request.cPerCodigo = LblcPerCodigo.Text
                Request.nPerIdeTipo = CboTipoDocu.SelectedValue
                Request.cPerIdeNumero = Trim(TxtNroDocu.Text)
                Request.cPerApellPaterno = Trim(Replace(TxtApePat.Text, "'", "{"))
                Request.cPerApellMaterno = Trim(Replace(TxtApeMat.Text, "'", "{"))
                Request.cPerPriNombre = Trim(Replace(Txt1Nombre.Text, "'", "{"))
                Request.cPerSegNombre = Trim(Replace(Txt2Nombre.Text, "'", "{"))
                Request.cPerTerNombre = Trim(Replace(Txt3Nombre.Text, "'", "{"))
                Request.dPerNacimiento = FormatDateTime(MTxtFecNaci.Text, DateFormat.ShortDate) 'FormatDateTime(DtpFecNacCrea.Value, DateFormat.ShortDate)
                Request.nPerTipo = CboTipoPer.SelectedValue
                Request.cUbiGeoCodigo = Trim(LblUbigeo.Text)
                Request.nPerTratamiento = CboTratoPer.SelectedValue
                Request.nPerNatSexo = CboSexoTEmp.SelectedValue
                Request.nPerNatEstCivil = CboEstadoCivil.SelectedValue
                Request.nPerNatTipResidencia = 0 'Tipo de residencia?
                Request.nPerNatSitLaboral = 0 'Situacion laboral?
                Request.nPerNatOcupacion = 0 'Ocupacion?
                Request.nPerNatCondicion = 0 'condicion?
                Request.cPerJurRepCodigo = vbNullString 'representante legal de la empresa
                Request.nPerJurTipInversion = CboSexoTEmp.SelectedValue
                Request.nPerJurSecEconomico = CboEstadoCivil.SelectedValue
                Request.nCarCodigo = CboNacionalidad.SelectedValue
                Request.cCarValor = CboNacionalidad.Text
                Request.dFecha = FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate)

                If MsgGrabar() = System.Windows.Forms.DialogResult.Yes Then

                    Select Case nFlagPersona
                        Case 1 'Add persona
                            'Genera Nuevo IdPersona
                            GeneraNewIdcPerCodigo()
                            Request.cPerCodigo = LblcPerCodigo.Text

                            If Not ObjPer.Ins_Persona(Request) Then
                                Throw New System.Exception("Se encontraron errores en la transaccion: [Ins_Persona]")
                            Else
                                Resultado = True 'ObjPer.Ins_Persona(Request)

                                traza = "Nueva Persona:  -Codigo: " & LblcPerCodigo.Text.ToString
                                Trace_Transaccion(CInt(Trace.RegistroPersona), StrUser, traza)
                            End If
                        Case 2 'Upd persona
                            Request.cPerCodigo = LblcPerCodigo.Text

                            If Not ObjPer.Upd_Persona(Request) Then
                                Throw New System.Exception("Se encontraron errores en la transaccion: [Upd_Persona]")
                            Else
                                Resultado = True 'ObjPer.Upd_Persona(Request)

                                traza = "Editando Persona:  -Codigo: " & LblcPerCodigo.Text.ToString
                                Trace_Transaccion(CInt(Trace.ActualizarPersona), StrUser, traza)
                            End If
                    End Select

                    If Resultado Then MessageBox.Show("Registro se ha realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    REM para registrar Familiar y/o Contacto 
                    If nFlagPersona = 1 Then
                        Select Case CboTipoPer.SelectedValue
                            REM si Persona es menor de Edad
                            Case nConTipoPersona.nPerNatural
                                'If LblnEdad.Text < 18 Then FormMaParentesco.ShowDialog()
                            Case nConTipoPersona.nPerJuridica
                                If MessageBox.Show("Desea registrar Persona de Contacto.!", "Contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    StrPasaValores = vbNullString 'seteo la variable 
                                    StrPasaValores = "cPerCodigo=" & LblcPerCodigo.Text
                                    nFlagNewPariente = CInt(AccionForm.Add) 'agregando
                                    FromParentesco = 1
                                    FormMaParentesco.ShowDialog()
                                End If
                        End Select
                    End If

                    StrPasaValores = vbNullString 'seteo la variable  
                    StrPasaValores = "cPerCodigo=" & LblcPerCodigo.Text & ";"
                    StrPasaValores = StrPasaValores & "cPerIdeNumero=" & TxtNroDocu.Text & ";"
                    StrPasaValores = StrPasaValores & "cNombCompleto=" & TxtApePat.Text & " " & TxtApeMat.Text & ", " & Txt1Nombre.Text & " " & Txt2Nombre.Text & " " & Txt3Nombre.Text & ";"
                    StrPasaValores = StrPasaValores & "nPerJurTipInversion=" & CboSexoTEmp.SelectedValue & ";"
                    StrPasaValores = StrPasaValores & "nPerJurSecEconomico=" & CboEstadoCivil.SelectedValue

                    If CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
                        If CboTipoDocu.SelectedValue = nConTipoDocPerJuridica.nRUC Then
                            MessageBox.Show("Debera registrar la Dirección Fiscal.", "Persona Juridica RUC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Width = 671 '578
                            BtnGrabar.Visible = False
                            GrpBoxDatos.Enabled = False
                            BtnDireccion_Click(BtnDireccion, Nothing)
                        Else
                            Call BtnCancel_Click(BtnCancel, Nothing)
                            BtnGrabar.Visible = True
                            GrpBoxDatos.Enabled = True
                        End If
                    Else
                        REM Detalles: Direccion / telefono / Email / foto
                        If MessageBox.Show("¿Desea agregar más información de la Persona y/o Empresa.?", "Detalles..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            Me.Width = 671 '578
                            BtnGrabar.Visible = False
                            GrpBoxDatos.Enabled = False
                        Else
                            Call BtnCancel_Click(BtnCancel, Nothing)
                            BtnGrabar.Visible = True
                            GrpBoxDatos.Enabled = True
                        End If
                    End If

                End If
            End If
            'End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CboTipoDocu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoDocu.KeyPress, CboTipoPer.KeyPress, CboTratoPer.KeyPress, CboSexoTEmp.KeyPress, CboEstadoCivil.KeyPress, CboNacionalidad.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtNroDocu_Enter(sender As Object, e As System.EventArgs) Handles TxtNroDocu.Enter
        ResaltarTextBox(TxtNroDocu)
    End Sub

    Private Sub TxtNroDocu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroDocu.KeyPress, TxtApePat.KeyPress, TxtApeMat.KeyPress, Txt1Nombre.KeyPress, Txt2Nombre.KeyPress, Txt3Nombre.KeyPress

        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                Limpiar()
                If CboTipoDocu.SelectedValue = nConTipoDocPerJuridica.nRUC Then
                    CargarImagen()

                    'myInfo.GetInfo(TxtNroDocu.Text, myInfo.UseTesseract())
                    'If (myInfo.Nombres = "Error!") Then

                    '    CargarImagen()
                    '    myInfo.GetInfo(TxtNroDocu.Text, myInfo.UseTesseract())
                    '    'Txt1Nombre.Text = myInfo.ApeMaterno
                    '    Txt1Nombre.Text = myInfo.Nombres

                    'Else
                    '    'Txt1Nombre.Text = myInfo.ApeMaterno
                    '    Txt1Nombre.Text = myInfo.Nombres

                    'End If
                Else
                    Get_BuscarDatosPadron()
                End If

                If nFlagPersona = 1 And Len(TxtNroDocu.Text) > 0 Then ValidarNumeroDocuExiste()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DtpFecNacCrea_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub BtnDireccion_Click(sender As System.Object, e As System.EventArgs) Handles BtnDireccion.Click
        nOperacion = BtnDireccion.Tag
        FormMaPerMasDetalle.ShowDialog()
    End Sub

    Private Sub BtnFono_Click(sender As System.Object, e As System.EventArgs) Handles BtnFono.Click
        nOperacion = BtnFono.Tag
        FormMaPerMasDetalle.ShowDialog()
    End Sub

    Private Sub BtnEmail_Click(sender As System.Object, e As System.EventArgs) Handles BtnEmail.Click
        nOperacion = BtnEmail.Tag
        FormMaPerMasDetalle.ShowDialog()
    End Sub

    Private Sub CboTipoPer_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoPer.SelectionChangeCommitted

        Limpiar()
        If pictureCapcha.Visible Then pictureCapcha.Visible = False

        If CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then EstablecerFormPredeterminado(nConTipoPersona.nPerNatural)
        If CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then EstablecerFormPredeterminado(nConTipoPersona.nPerJuridica)

    End Sub

    Private Sub BtnTipoDocu_Click(sender As System.Object, e As System.EventArgs) Handles BtnTipoDocu.Click
        nOperacion = BtnTipoDocu.Tag
        FormMaPerMasDetalle.ShowDialog()
    End Sub


    Private Sub BtnFoto_Click(sender As System.Object, e As System.EventArgs) Handles BtnFoto.Click
        nOperacion = BtnFoto.Tag
        FormMaPerMasDetalle.ShowDialog()
    End Sub

    Private Sub Txt1Nombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt1Nombre.TextChanged
        If CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
            TxtApePat.Text = Txt1Nombre.Text
        End If
    End Sub

    'Private Sub BtnJoby_Click(sender As System.Object, e As System.EventArgs)
    '    nOperacion = BtnJoby.Tag
    '    FormMaPerMasDetalle.ShowDialog()
    'End Sub

    Private Sub CboTipoDocu_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboTipoDocu.SelectedIndexChanged
        Limpiar()
        If CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI Then TxtNroDocu.MaxLength = 8
        If CboTipoDocu.SelectedValue = nConTipoDocPerJuridica.nRUC Then TxtNroDocu.MaxLength = 11
    End Sub

    'Private Sub CboMes_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs)
    '    DtpFechaNacimiento()
    'End Sub

    'Private Sub CboAnio_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs)
    '    DtpFechaNacimiento()
    'End Sub

    'Private Sub CboDia_SelectionChangeCommitted(sender As Object, e As System.EventArgs)
    '    DtpFechaNacimiento()
    'End Sub

    'Private Sub DtpFecNacCrea_ValueChanged(sender As System.Object, e As System.EventArgs)

    '    LblnEdad.Text = CalculaEdad(DtpFecNacCrea.Value.Date, CDate(dFechaSistema)) 'Obj_PerEdad.Get_ObtenerEdad(DtpFecNacCrea.Value)

    'End Sub

    'Private Sub BtnAddParentesco_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddParentesco.Click

    '    'Editando
    '    nAccionBotones = nAccionButton.nAccionEdit

    '    FormMaParentesco.ShowDialog()
    '    BtnAddParentesco.Visible = True

    'End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

    Private Sub TxtNroDocu_LostFocus(sender As Object, e As EventArgs) Handles TxtNroDocu.LostFocus
        Get_BuscarDatosPadron()
        If nFlagPersona = 1 And Len(TxtNroDocu.Text) > 0 Then ValidarNumeroDocuExiste()
    End Sub

    Private Sub MTxtFecNaci_KeyDown(sender As Object, e As KeyEventArgs) Handles MTxtFecNaci.KeyDown
        Me.ToolTip1.Hide(Me.MTxtFecNaci)
    End Sub

    Private Sub MTxtFecNaci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MTxtFecNaci.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
        'DtpFechaNacimiento()
    End Sub

    Private Sub MTxtFecNaci_LostFocus(sender As Object, e As EventArgs) Handles MTxtFecNaci.LostFocus
        'DtpFechaNacimiento()
        'validando fechas
        Dim fecha As DateTime

        If DateTime.TryParse(MTxtFecNaci.Text, fecha) Then
            LblnEdad.Text = CalculaEdad(CDate(MTxtFecNaci.Text), CDate(dFechaSistema))
        End If
    End Sub

    Private Sub MTxtFecNaci_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles MTxtFecNaci.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.ToolTip1.ToolTipTitle = "Fecha invalida"
            Me.ToolTip1.Show("Los datos que ha suministrado debe ser una fecha válida en el formato dd/mm/yyyy.", Me.MTxtFecNaci, 0, -20, 5000)
        Else
            ' Now that the type has passed basic type validation, enforce more specific type rules.
            Dim UserDate As DateTime = CDate(e.ReturnValue)
            If (UserDate < "01/01/1910" Or UserDate >= DateTime.Now) Then
                Me.ToolTip1.ToolTipTitle = "Fecha invalida"
                Me.ToolTip1.Show("La fecha en este campo debe ser menor o igual que la fecha de hoy.", Me.MTxtFecNaci, 0, -20, 5000)
                e.Cancel = True
                MTxtFecNaci.Focus()
                'SendKeys.Send("{End}")
            End If
        End If
    End Sub

    Private Sub TxtNroDocu_TextChanged(sender As Object, e As EventArgs) Handles TxtNroDocu.TextChanged

    End Sub
End Class