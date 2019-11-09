﻿Option Explicit On
Imports System.IO
Imports Integration.BE.Persona
Imports Integration.BE.CtasCtes
Imports Integration.BE.CtasCtesMedica
Imports Integration.BE.FichaAtencion
'Imports Integration.BE.AdmSolPerToken
Imports Integration.BL
Imports Integration.BL.BL_Persona
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL.BL_CtasCtesMedica
Imports Integration.BL.BL_FichaAtencion
Imports Integration.BL.BL_Reportes
'Imports Integration.BL.GestionarAdmSolPerTokenServicio

Imports System.Transactions
Imports Integration.BE

Public Class FormPrcSolAtencion

    Private WithEvents taskbarNotifier3 As TaskBarNotifier

    Dim nEstado As Integer
    Dim dateValue As Date
    Dim cPerUsuDscto As String = ""
    Dim nPorcentajeMax As Long
    Dim nMotivoDscto As Long = 0
    Dim cPorcDscto As String
    Dim nFlagIniciarDscto As Long = 0

    Enum GrillaServicios
        ColcPerJurCodigo = 0
        ColnCtaCteSerCodigo = 1
        ColcIntJerarquia = 2
        ColcCodGrupo = 3
        ColcCtaCteSerJerarquia = 4 '3
        ColcCtaCteSerKeyWord = 5 '4
        ColnMonCodigo = 6 '5
        ColnIntCodigo = 7 '6
        ColnCtaCteSerImpDef = 8 '7
        ColnTipoDscto = 9 '8
        ColnCtaCteCantidad = 10 '9 '7
        ColnCtaCteSerCosto = 11 '10 '8
        ColnCtaCteSubTotal = 12 '11 '9
        ColnFlag = 13 '12 '10
    End Enum

    Private Sub Inicializar()
        TxtNroFind.Text = vbNullString
        LblcPerCodigo.Text = vbNullString
        LblcNombre.Text = vbNullString
        LblEdad.Text = vbNullString
        TxtNroFindAutoriza.Text = vbNullString
        LblcPerCodigoAut.Text = vbNullString
        LblcAutoriza.Text = vbNullString
        TxtFindEmpl.Text = vbNullString
        LblcPerCodEmpl.Text = vbNullString
        LblcNombEmpl.Text = vbNullString
    End Sub

    Private Sub DetalleComisionMedico()

        Dim Servicio As New BLRptMaster
        Dim dt As New DataTable

        dt = ObjSistemaServicio.Get_Value_Table("p.cPerCodigo , p.cPerApellido + space(1) +  p.cPerNombre  cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, " p.cPerCodigo = '" & LblcPerCodigo.Text & "' AND nPerRelTipo IN (" & TipoActividad.nPerRelTipoMedico & "," & TipoActividad.nPerRelTipoMedicoSinComision & ")")

        If dt.Rows.Count > 0 Then
            Table5.DataSource = Servicio.Get_Derivacion_Medico_by_cPerCodMedico_and_dFecIni_dFecFin(LblcPerCodigo.Text, FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate), FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate))
            LblImpMedico.Text = FormatNumber(Suma_Columna("nImpTotal", Table5), True)
            Label36.Text = "Médico"
            Label36.Text = Label36.Text + Space(1) + LblcNombre.Text.ToString
            Centrar(PanelMedico)
            PanelMedico.Visible = True : GroupBox1.Enabled = False
        End If

    End Sub

    Public Sub CalcularVta()
        'LblTBruto.Text = FormatNumber(Suma_Columna("nCtaCteSerImpDef", Table1), True)
        'LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True) 'nCtaCteSubTotal
        'LblnPorcDscto.Text = FormatNumber(Suma_Columna("nCtaCteSerImpDef", Table1) - CDbl(LblTotalPago.Text), True)

        LblTBruto.Text = FormatNumber(Suma_Columna_SubTotal("nCtaCteCantidad", "nCtaCteSerImpDef", Table1), True)
        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True) 'nCtaCteSubTotal
        LblnPorcDscto.Text = FormatNumber(Suma_Columna_SubTotal("nCtaCteCantidad", "nCtaCteSerImpDef", Table1) - CDbl(LblTotalPago.Text), True)
    End Sub

    Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False

        If CboDia.Text = "" Then
            MsgInfoCampoObligatorio(Label18.Text, CboDia)
            Exit Function
        End If

        If CboMes.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label12.Text, CboMes)
            Exit Function
        End If

        If CboAnio.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label17.Text, CboAnio)
            Exit Function
        End If

        If CboTipoPer.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label15.Text, CboTipoPer)
            Exit Function
        End If

        If CboTipoDocu.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label14.Text, CboTipoDocu)
            Exit Function
        End If

        If TxtNroFind.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label16.Text, TxtNroFind)
            Exit Function
        End If

        If LblcPerCodigo.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label16.Text, TxtNroFind)
            Exit Function
        End If

        If LblcNombre.Text = vbNullString Then
            MsgInfoCampoObligatorio(Label16.Text, TxtNroFind)
            Exit Function
        End If

        If CboTipoCta.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label6.Text, CboTipoCta)
            Exit Function
        End If

        Select Case CboTipoCta.SelectedValue
            Case TipoAtencion.LabExterno Or TipoAtencion.Convenio Or TipoAtencion.CentroSalud 'EINCIO Upd.2017.05.10
                'CboEmpresa.SelectedIndex.Equals(-1)
                If CboEmpresa.SelectedIndex = -1 Or CboEmpresa.Text = vbNullString Then
                    MsgInfoCampoObligatorio(Label10.Text, CboEmpresa)
                    Exit Function
                End If
                If CboSede.Visible Then
                    MsgInfoCampoObligatorio(Label39.Text, CboSede)
                    Exit Function
                End If
        End Select

        If CboDerivMedico.SelectedValue = Nothing Or ChkDeriv.Checked = False Then
            If MessageBox.Show("¿Está seguro de guardar sin médico?", "Validando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                Exit Function
            End If
        ElseIf ChkDeriv.Checked And CboDerivMedico.SelectedValue <> Nothing Then
            If MessageBox.Show("¿Está seguro de guardar la ficha con el médico: " & CboDerivMedico.Text & "?", "Validando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                Exit Function
            End If
        End If

        'EINCIO upd.2017.05.10
        If (CboTipoCta.SelectedValue <> TipoAtencion.LabExterno And CboTipoCta.SelectedValue <> TipoAtencion.CentroSalud) And CLng(LblEdad.Text) < 18 And Len(Microsoft.VisualBasic.Trim(TxtNroFindAutoriza.Text)) = 0 Then 'And CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural  Then
            GrpBoxAutoriza.Enabled = True
            MessageBox.Show("Persona es un Menor de Edad, por tal motivo se debe registrar y/o indicar quien Autoriza el Exámen al menor.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            TxtNroFindAutoriza.Focus()
            Exit Function
        End If

        If Table1.RowCount = 0 Then
            MessageBox.Show("No hay ningún detalle (Análisis) para la atención.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Function
        End If

        If CboTipoCta.SelectedValue = TipoAtencion.Convenio And CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
            If Table6.RowCount = 0 Then
                MessageBox.Show("Debe agregar la lista de personas que participan en el Convenio.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Function
            End If
        End If

        If ChkDeriv.CheckState = CheckState.Checked And ChkDeriv.Checked Then
            If CboDerivMedico.SelectedIndex = -1 Or CboDerivMedico.SelectedValue = Nothing Then
                MsgInfoCampoObligatorio(Label9.Text, CboDerivMedico)
                Exit Function
            End If
        End If

        If Convert.ToDouble(LblTotalPago.Text) <= 0 Then
            MessageBox.Show("Total a Pagar no puede ser valor cero...!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Function
        End If

        If Not CboDerivMedico.SelectedValue = Nothing Then
            If LblcPerCodigo.Text = CboDerivMedico.SelectedValue.ToString And RdoBtnConComision.Checked And Len(cPerUsuDscto) > 0 And CLng(LblnPorcDscto.Text) > 0 Then
                MessageBox.Show("Imposible derivar médico quien a la vez esta como paciente...!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Function
            End If
        End If

        ValidaCamposObligatorios = True

    End Function

    Private Sub InicializarForm()
        LblcPerCodigo.Text = vbNullString
        LblcNombre.Text = vbNullString
        LblNroSolicitud.Text = vbNullString
        LimpiarTextBox(Me)
    End Sub

    Private Sub DtpFechaExamen()
        Dim DFecha As String = CboDia.Text + "/" + CboMes.SelectedValue.ToString + "/" + CboAnio.Text

        If DateTime.TryParse(DFecha, dateValue) Then
            DTPFecExamen.Value = CDate(DFecha)
        Else
            MsgInfoCampoObligatorio(Label4.Text & " no valida", CboDia)
        End If

    End Sub

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
                If CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then LblEdad.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("nEdad") Else LblEdad.Text = 0

                If (CboTipoCta.SelectedValue <> TipoAtencion.LabExterno Or CboTipoCta.SelectedValue <> TipoAtencion.CentroSalud) And CLng(LblEdad.Text) < 18 Then 'And CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then
                    GrpBoxAutoriza.Enabled = True : TxtNroFindAutoriza.Focus()
                Else
                    GrpBoxAutoriza.Enabled = False
                    'Pasa
                    BtnCIE.Focus()
                End If
            Else
                If MessageBox.Show("¿Desea buscar por apellidos, para validar información, no tenga registrado su docuemnto de identidad.?", "Buscar por Apellidos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'Aqui buscar por apellido.
                    PanelBuscarApellidos.Visible = True
                    GroupBox1.Enabled = False
                    Centrar(PanelBuscarApellidos)
                    TxtBuscarPorApellidos.Text = ""
                    ActiveControl = TxtBuscarPorApellidos
                Else
                    If MessageBox.Show("¿Desea registrar a la persona.?", "Buscando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Call BtnAgregar_Click(BtnAgregar, Nothing)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub BuscaPersonaAutoriza()
        Try
            Dim Request As New BE_ReqPersonaSearh
            Dim ObjPer As New BL_Personas

            Dim StrFilNroDocu As String = ""
            If TxtNroFindAutoriza.Text = vbNullString Or Len(TxtNroFindAutoriza.Text) <= 2 Then Exit Sub
            StrFilNroDocu = TxtNroFindAutoriza.Text

            Request.cNombre = "Nulo"
            Request.cPerIdeNumero = StrFilNroDocu
            Request.nPerTipo = nConTipoPersona.nPerNatural 'CboTipoPer.SelectedValue

            If ObjPer.Get_SearhPersona(Request) Is Nothing Then Exit Sub

            If ObjPer.Get_SearhPersona(Request).Rows.Count > 0 Then
                LblcPerCodigoAut.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cPerCodigo")
                LblcAutoriza.Text = ObjPer.Get_SearhPersona(Request).Rows(0)("cpernombre")
                'pasa
                BtnCIE.Focus()
            Else
                If MessageBox.Show("Persona no se encuentra registrada en el sistema. ¿Desea registrar a la persona.?", "Buscando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    StrPasaValores = vbNullString 'seteo la variable 
                    StrPasaValores = "cPerCodigo=" & LblcPerCodigo.Text
                    Call BtnAutoriza_Click(BtnAutoriza, Nothing)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub BuscaEmpleado()
        Try
            Dim Request As New BE_ReqPersonaSearh
            Dim ObjPer As New BL_Personas
            Dim dtEmpl As New DataTable

            Dim StrFilNroDocu As String = ""
            If TxtFindEmpl.Text = vbNullString Or Len(TxtFindEmpl.Text) <= 2 Then Exit Sub
            StrFilNroDocu = TxtFindEmpl.Text

            Request.cNombre = "Nulo"
            Request.cPerIdeNumero = StrFilNroDocu
            Request.nPerTipo = nConTipoPersona.nPerNatural

            dtEmpl = ObjPer.Get_SearhPersona(Request)

            If dtEmpl.Rows.Count > 0 Then
                LblcPerCodEmpl.Text = dtEmpl.Rows(0)("cPerCodigo")
                LblcNombEmpl.Text = dtEmpl.Rows(0)("cpernombre")
            Else
                If MessageBox.Show("Persona no se encuentra registrada en el sistema. ¿Desea registrar a la persona.?", "Buscando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call BtnAddEmpl_Click(BtnAddEmpl, Nothing)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub validar_Keypress( _
                            ByVal sender As Object, _
                            ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' Obtener indice de la columna   
        Dim columna As Integer = Table1.CurrentCell.ColumnIndex

        ' Comprobar si la celda en edición corresponde a la columna 7   
        If columna = GrillaServicios.ColnCtaCteCantidad Then  'Cantidad

            ' Obtener caracter   
            Dim caracter As Char = e.KeyChar

            ' Comprobar si el caracter es un número o el retroceso   
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                'Me.Text = e.KeyChar
                e.KeyChar = Chr(0)
            End If
        End If

    End Sub


    Private Sub Table1_Click(sender As Object, e As System.EventArgs) Handles Table1.Click

        'If Table1.RowCount = 0 Then Exit Sub
        'Try

        '    Dim Servicio As New BL_CtaCtaServicio
        '    Dim cPrePaciente As String = Servicio.Get_CtaCteListaServicio_by_cPerJurCodigo_nCtaCteSerCodigo(StrcPerJuridica, Table1.Item(GrillaServicios.ColnCtaCteSerCodigo, Table1.CurrentRow.Index).Value)

        '    taskbarNotifier3 = New TaskBarNotifier()
        '    'taskbarNotifier3.SetBackgroundBitmap(New Bitmap(MyClass.GetType(), "skin3.bmp"), Color.FromArgb(255, 0, 255))
        '    taskbarNotifier3.SetBackgroundBitmap(My.Resources.skin3, Color.FromArgb(255, 0, 255))
        '    'taskbarNotifier3.SetCloseBitmap(New Bitmap(MyClass.GetType(), "close.bmp"), Color.FromArgb(255, 0, 255), New Point(280, 57))
        '    taskbarNotifier3.SetCloseBitmap(My.Resources.close, Color.FromArgb(255, 0, 255), New Point(280, 57))
        '    taskbarNotifier3.TitleRectangle = New Rectangle(150, 57, 125, 28)
        '    taskbarNotifier3.TextRectangle = New Rectangle(75, 92, 215, 55)

        '    With taskbarNotifier3
        '        .NormalTitleColor = Color.Black
        '        .HoverTitleColor = Color.Black
        '        .NormalContentColor = Color.Yellow
        '        .HoverContentColor = Color.White
        '        .CloseButtonClickEnabled = False 'checkBoxCloseClickable.Checked
        '        .TitleClickEnabled = False 'checkBoxTitleClickable.Checked
        '        .TextClickEnabled = False 'checkBoxContentClickable.Checked
        '        .DrawTextFocusRect = True 'checkBoxSelectionRectangle.Checked
        '        .KeepVisibleOnMouseOver = True 'checkBoxKeepVisibleOnMouseOver.Checked
        '        .ReShowOnMouseOver = False 'checkBoxReShowOnMouseOver.Checked
        '        .Show(Table1.Item(GrillaServicios.ColcCtaCteSerJerarquia, Table1.CurrentRow.Index).Value.ToString, _
        '              cPrePaciente, _
        '              Integer.Parse(500), _
        '              Integer.Parse(3000), _
        '              Integer.Parse(500))
        '    End With
        '    'cIntJerarquia
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
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

    Private Sub Table1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles Table1.CellFormatting

        'Agrupando Muestras con Grupo (Examenes solos, Perfiles y Cam)
        If Me.Table1.Columns(e.ColumnIndex).Name = "cCodGrupo" Then

            Dim grupo As String = Microsoft.VisualBasic.Left(CStr(e.Value), 3)

            Select Case grupo
                Case "PRF" 'Perfil
                    e.CellStyle.ForeColor = Color.Blue
                Case "CAM" 'Campaña
                    e.CellStyle.ForeColor = Color.Green
            End Select

        End If

    End Sub

    Private Sub Table1_CellEndEdit(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellEndEdit
        Try
            With Table1
                If .Item(GrillaServicios.ColnCtaCteCantidad, .CurrentRow.Index).Value <= 0 Then
                    .Item(GrillaServicios.ColnCtaCteCantidad, .CurrentRow.Index).Value = 1 'default
                End If

                Dim Dt_Valor1, Dt_Valor2, Dt_Resultado As Double

                If .Columns(e.ColumnIndex).Name = "nCtaCteCantidad" Then 'Or .Columns(e.ColumnIndex).Name = "nCtaCteSerCosto" Then

                    Dt_Valor1 = Convert.ToDouble(.Rows(e.RowIndex).Cells("nCtaCteCantidad").EditedFormattedValue)
                    Dt_Valor2 = Convert.ToDouble(.Rows(e.RowIndex).Cells("nCtaCteSerCosto").EditedFormattedValue)

                    Dt_Resultado = (Dt_Valor1 * Dt_Valor2)
                    .Rows(e.RowIndex).Cells("nCtaCteSubTotal").Value = (Dt_Resultado)

                End If
            End With

            'LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True)
            CalcularVta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Function ValidarCamposForAddItemGrd() As Boolean

    '    ValidarCamposForAddItemGrd = False

    '    REM If CDbl(CDbl(Suma_Columna("nCtaCtePagImporte", Table1)) + CDbl(TxtImpPago.Text)) > CDbl(LblImpRecibo.Text) Then MessageBox.Show("Importe a Pagar exede el importe.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Function

    '    ValidarCamposForAddItemGrd = True

    'End Function

    Private Sub FormPrcFichaAtencion_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F2))
                BtnPermitirDscto_Click(BtnPermitirDscto, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4))
                Call c1CmdGrabar_Click(c1CmdGrabar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F8))
                C1CmdProgramar_Click(C1CmdProgramar, Nothing)
                c1CmdCancel_Click(c1CmdCancel, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                Call BtnAdd_Click(BtnAdd, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Delete))
                BtnQuitar_Click(BtnQuitar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                'validando hueco ya que si esta editando y quita todas las muestras no debe dejarle salir del form.
                If nFlagAdmision = 2 And Table1.RowCount = 0 Then
                    MessageBox.Show("No hay ningún detalle (Análisis) para la atención.!", "Validando Edición de Ficha..", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If

                Call c1CmdCancel_Click(c1CmdCancel, Nothing)
                Call C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select

    End Sub

    Private Sub FormPrcSolAtencion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Dim Req_ListServicios As New BE_ReqCtaCtePrecioServicio
            Dim Obj_ListServicios As New BL_CtaCtePrecioServicio

            'Descuento
            TabControl1.TabPages.Remove(TabPage2)

            'poblando combo
            Dim comboboxColumn As DataGridViewComboBoxColumn = TryCast(Table4.Columns("DsctonTipoDscto"), DataGridViewComboBoxColumn)

            comboboxColumn.DataSource = ObjConst.Get_Constante("C", CInt(gConTipoDscto)) '1132
            comboboxColumn.DisplayMember = "cConDescripcion"
            comboboxColumn.ValueMember = "nConValor"

            'Aplica Dscto a Todo
            LlenaDataCombo(CboTipoDscto, ObjConst.Get_Constante("C", CLng(CboTipoDscto.Tag)), "nConValor", "cConDescripcion")
            'Default
            CboTipoDscto.SelectedValue = 1

            'Meses
            LlenaDataCombo(CboMes, ObjConst.Get_Constante("C", CLng(CboMes.Tag)), "nConValor", "cConDescripcion")
            'Años
            LlenaDataCombo(CboAnio, ObjConst.Get_Constante("C", CLng(CboAnio.Tag)), "nConValor", "cConDescripcion")

            CboDia.SelectedIndex = 0

            LlenaDataCombo(CboTipoPer, ObjConst.Get_Constante("C", CLng(CboTipoPer.Tag)), "nConValor", "cConDescripcion")
            LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")
            CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI

            'Carga: Interface: 1133
            LlenaDataCombo(CboTipoCta, ObjInterface.Get_Interface(CLng(TokenByKey(CboTipoCta.Tag, "nIntClase")), CLng(TokenByKey(CboTipoCta.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")
            CboTipoCta.Enabled = True 'Inicializamos

            'Carga: Interface: 2802
            Dim ObjInterface_2 As New BL_Interface
            LlenaDataCombo(CboMotivDscto, ObjInterface_2.Get_Interface(CLng(TokenByKey(CboMotivDscto.Tag, "nIntClase")), CLng(TokenByKey(CboMotivDscto.Tag, "nIntTipo")), "J"), "nIntCodigo", "cIntDescripcion")


            'Llena valores en el ComboBox
            'CboMotivDscto.ValueMember = "nIntCodigo"
            'CboMotivDscto.DisplayMember = "cIntDescripcion"
            'CboMotivDscto.DataSource = ObjInterface_2.Get_Interface(CLng(TokenByKey(CboMotivDscto.Tag, "nIntClase")), CLng(TokenByKey(CboMotivDscto.Tag, "nIntTipo")), "J")

            CboMotivDscto.Enabled = True

            'PerRelacion
            'Dim Obj_Doctor As New BL_Persona
            'LlenaDataCombo(CboDerivMedico, Obj_Doctor.Get_List_Persona_PerRelacion_for_nPerRelTipo(CLng(CboDerivMedico.Tag)), "cPerCodigo", "cPerName")
            LlenaDataCombo(CboDerivMedico, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo , p.cPerApellido + space(1) +  p.cPerNombre  cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo IN (" & TipoActividad.nPerRelTipoMedico & "," & TipoActividad.nPerRelTipoMedicoSinComision & ")", "cPerNombre"), "cPerCodigo", "cPerNombre")

            CboDerivMedico.AutoCompleteCustomSource = LoadAutoComplete(ObjSistemaServicio.Get_Value_Table("p.cPerCodigo , p.cPerApellido + space(1) +  p.cPerNombre  cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo IN (" & TipoActividad.nPerRelTipoMedico & "," & TipoActividad.nPerRelTipoMedicoSinComision & ")", "cPerNombre"), "cPerNombre")
            CboDerivMedico.AutoCompleteMode = AutoCompleteMode.Suggest
            CboDerivMedico.AutoCompleteSource = AutoCompleteSource.CustomSource
            CboDerivMedico.SelectedIndex = -1

            EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False, C1CmdProgramar, False)

            FormatGrilla(Table1, Me, False, 30)
            FormatGrilla(Table2, Me, False, 25)
            FormatGrilla(Table4, Me, False, 25)
            FormatGrilla(Table5, Me, False, 25)
            FormatGrilla(Table6, Me, False, 25)
            FormatGrilla(Table7, Me, False, 25)

            cKeyToken = "" : nFlagToken = 0 'setando variables globales

            LblnItem.Text = "Item(s): 0"

            GrpBoxListEmpl.Enabled = True

            If nFlagAdmision = 1 Then
                c1CmdNuevo_Click(c1CmdNuevo, Nothing)
                CboTipoPer_SelectionChangeCommitted(CboTipoPer, Nothing)
            ElseIf nFlagAdmision = 2 Then
                C1CmdEdit_Click(C1CmdEdit, Nothing)
            End If

            LblnSaldo.Text = Convert.ToDouble(TokenByKey(StrPasaAdmFicha, "nSaldo"))

            'CboTipoCta.SelectedValue = 1002
            'Call ver()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Sub ver()
    '    Dim Obj_Empresa As New BL_Personas

    '    Select Case CboTipoCta.SelectedValue
    '        Case CInt(TipoAtencion.Particular), CInt(TipoAtencion.AtencionExterna)
    '            CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = CInt(nConTipoPersona.nPerNatural)
    '            CboEmpresa.Visible = False : Label10.Visible = False : BtnBuscarEmpresa.Visible = False

    '        Case CInt(TipoAtencion.LabExterno)
    '            CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = CInt(nConTipoPersona.nPerNatural)
    '            CboEmpresa.Visible = True : CboEmpresa.Enabled = True : CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Laboratorio" : BtnBuscarEmpresa.Visible = True
    '            LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido+' '+p.cPerNombre ELSE p.cPerNombre END) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoLabExterno) & " AND  nPerRelEstado <> 0"), "cPerCodigo", "cPerNombre")
    '            'LlenaDataCombo(CboEmpresa, Obj_Empresa.Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(1, 2), "cPerCodigo", "cPerNombre")

    '        Case CInt(TipoAtencion.Convenio)
    '            CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = CInt(nConTipoPersona.nPerNatural) 'nConTipoPersona.nPerJuridica
    '            CboEmpresa.Visible = True : CboEmpresa.Enabled = True : CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Empresa" : BtnBuscarEmpresa.Visible = True
    '            LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido+' '+p.cPerNombre ELSE p.cPerNombre END) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoEmpConvenio) & " AND  nPerRelEstado <> 0"), "cPerCodigo", "cPerNombre")
    '            'LlenaDataCombo(CboEmpresa, Obj_Empresa.Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(3, 131), "cPerCodigo", "cPerNombre")

    '        Case CInt(TipoAtencion.CentroSalud)
    '            CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = CInt(nConTipoPersona.nPerNatural)
    '            CboEmpresa.Visible = True : CboEmpresa.Enabled = True : CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Centro Salud" : BtnBuscarEmpresa.Visible = True
    '            LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido+' '+p.cPerNombre ELSE p.cPerNombre END) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoCentroSalud) & " AND  nPerRelEstado <> 0"), "cPerCodigo", "cPerNombre")

    '        Case CInt(TipoAtencion.Campaña)
    '            CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = CInt(nConTipoPersona.nPerNatural)
    '            CboEmpresa.Visible = True : CboEmpresa.Enabled = True : CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Campaña" : BtnBuscarEmpresa.Visible = True
    '            LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido+' '+p.cPerNombre ELSE p.cPerNombre END) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoCampana) & " AND  nPerRelEstado <> 0"), "cPerCodigo", "cPerNombre")

    '    End Select

    '    CboTipoPer_SelectionChangeCommitted(CboTipoPer, Nothing)
    'End Sub


    Private Sub TxtNroFind_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroFind.KeyPress

        'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BuscaPersona()
            DetalleComisionMedico()
        End If

    End Sub

    Private Sub CboTipoPer_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoPer.SelectionChangeCommitted

        Select Case CboTipoPer.SelectedValue
            Case nConTipoPersona.nPerNatural
                EliminarRowsDgView(Table6) 'vacio grilla para asegurar que no alla errores
                LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")
                CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI
                CboTipoDocu_SelectionChangeCommitted(CboTipoDocu, Nothing)
                Me.Width = 1146
                GrpBoxListEmpl.Visible = False
                'Case nConTipoPersona.nPerJuridica
                '    LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerJuridica)), "nConValor", "cConDescripcion")
                '    CboTipoDocu.SelectedValue = nConTipoDocPerJuridica.nRUC
                '    Me.Width = 1627
                '    GrpBoxListEmpl.Visible = True
        End Select
        Me.StartPosition = FormStartPosition.CenterParent
        Inicializar()
    End Sub

    Private Sub BtnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click

        nAccionBotones = nAccionButton.nAccionNuevo

        nFlagPersona = 1
        'nOperacion = 1

        'FormMaPersona.Width = 503 '435
        'nFormPerPredeterminado = CboTipoPer.SelectedValue 'nConTipoPersona.nPerNatural
        'FormMaPersona.TxtNroDocu.Text = TxtNroFind.Text
        'Me.Opacity = 1.83
        'FormMaPersona.ShowDialog()

        'Dim FormMaPersona As New FormMaPersona()
        FormMaPersona.Width = 503
        FormMaPersona.TxtNroDocu.Text = TxtNroFind.Text
        FormMaPersona.Owner = Me
        FormMaPersona.ShowDialog(Me)
        FormMaPersona.Dispose()

        'TxtNroFind.Text = TokenByKey(StrPasaValores, "cPerIdeNumero")

        BuscaPersona()

        BtnCIE.Focus()

    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdNuevo.Click
        Call Actualizar_Fecha_Servidor()

        InicializarForm()

        Dim Obj_NewId As New BL_FichaAtencion
        'correlativo solicitud
        LblNroSolicitud.Text = "Nueva Ficha" 'Obj_NewId.Get_NewId_AdmSolAtencion()  REM GetCorrelativo(StrcPerJuridica)

        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True, C1CmdProgramar, False)
        GrpBoxPersona.Enabled = True : CboTipoCta.Enabled = True

        CboDia.Text = Date.Now.Day.ToString
        CboAnio.Text = Year(CDate(dFechaSistema))
        CboMes.SelectedValue = Date.Now.Month

        'Foco por default
        Me.ActiveControl = TxtNroFind

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        Try

            CboTipoCta.SelectedValue = CLng(TokenByKey(StrPasaAdmFicha, "nIntCodigo"))
            CboTipoCta_SelectionChangeCommitted(CboTipoCta, Nothing)

            If CboEmpresa.Enabled Then CboEmpresa.SelectedValue = CLng(TokenByKey(StrPasaAdmFicha, "cPerCodigoTerceros"))
            If CboSede.Visible Then CboSede.SelectedValue = CLng(TokenByKey(StrPasaAdmFicha, "nPerIntCodigo"))

            'CboTipoPer.SelectedValue = Convert.ToInt32(TokenByKey(StrPasaAdmFicha, "nPerTipo"))
            CboTipoPer_SelectionChangeCommitted(CboTipoPer, Nothing)
            TxtNroFind.Text = TokenByKey(StrPasaAdmFicha, "cPerIdeNumero")

            BuscaPersona()

            If CboTipoCta.SelectedValue <> CInt(TipoAtencion.Particular) And CboTipoCta.SelectedValue <> CInt(TipoAtencion.AtencionExterna) Then
                CboEmpresa.SelectedValue = CLng(TokenByKey(StrPasaAdmFicha, "cPerCodigoTerceros")) 'LblcPerCodigo.Text
            End If

            LblNroSolicitud.Text = TokenByKey(StrPasaAdmFicha, "nSolAdmNumero")
            DTPFecRegistro.Value = CDate(TokenByKey(StrPasaAdmFicha, "dFecRegistro"))
            DTPFecExamen.Value = CDate(TokenByKey(StrPasaAdmFicha, "dFecExamen"))

            'Llenando Combox Dia, Mes, Año
            CboDia.Text = DTPFecExamen.Value.Day
            CboMes.SelectedValue = DTPFecExamen.Value.Month
            CboAnio.Text = DTPFecExamen.Value.Year.ToString

            nEstado = CLng(TokenByKey(StrPasaAdmFicha, "nAdmSolEstado"))

            If Convert.ToInt32(TokenByKey(StrPasaAdmFicha, "nFlagComision")) = 1 Then RdoBtnConComision.Checked = True Else RdoBtnSinnComision.Checked = True

            '---------------------------------------------------
            'Cargar Pariente cuando es paciente es menor de edad
            '---------------------------------------------------
            'If CboTipoCta.SelectedValue = TipoAtencion.Particular And CboTipoCta.SelectedValue = TipoAtencion.AtencionExterna And CLng(LblEdad.Text) < 18 And CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural Then
            Dim Servicio_AdmSolAut As New BL_FichaAtencion
            Dim dtAdmSolAut As New DataTable

            TxtNroFindAutoriza.Text = Servicio_AdmSolAut.Get_AdmSolAtenAutoriza(StrcPerJuridica, CInt(CboTipoCta.SelectedValue), LblNroSolicitud.Text)
            BuscaPersonaAutoriza()
            'End If
            '-----------------
            'Carga Diagnostico
            '-----------------
            Dim nPos As Integer = 0
            Dim Obj_AdmSolDiag As New BL_FichaAtencion
            Dim dtAdmSolDiag As New DataTable

            dtAdmSolDiag = Obj_AdmSolDiag.Get_AdmSolDiagnostico_for_cPerJuridica_nIntCodigo_nSolAdmNumero(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), Trim(LblNroSolicitud.Text))
            'Datos enlazados no es factible para despues agregar mas items
            'Table1.DataSource = dtDetAdmSol

            'Leyendo un DataTable
            If dtAdmSolDiag.Rows.Count > 0 Then
                Dim row As DataRow

                EliminarRowsDgView(Table2)
                Table2.DataSource = Nothing

                For Each row In dtAdmSolDiag.Rows
                    With Table2
                        nPos = .RowCount()
                        .Rows.Add()
                        .Item("cDiagCodigo", nPos).Value = CStr(row("cDiagCodigo").ToString)
                        .Item("cDiagDescripcion", nPos).Value = CStr(row("cDiagDescripcion").ToString)
                    End With

                Next
            End If

            Table2.PerformLayout()
            '--------------
            'Carga detalle
            '--------------
            'Dim nPos As Integer
            Dim Obj_DetAdmSol As New BL_FichaAtencion
            Dim dtDetAdmSol As New DataTable

            dtDetAdmSol = Obj_DetAdmSol.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(StrcPerJuridica, Trim(LblNroSolicitud.Text))
            'Datos enlazados no es factible para despues agregar mas items
            'Table1.DataSource = dtDetAdmSol

            'Leyendo un DataTable
            If dtDetAdmSol.Rows.Count > 0 Then
                Dim row As DataRow

                EliminarRowsDgView(Table1)
                Table1.DataSource = Nothing

                For Each row In dtDetAdmSol.Rows
                    With Table1
                        nPos = .RowCount()
                        .Rows.Add()
                        .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                        .Item("nCtaCteSerCodigo", nPos).Value = CStr(row("nCtaCteSerCodigo").ToString)
                        .Item("cIntJerarquia", nPos).Value = CStr(row("cIntJerarquia").ToString)
                        .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
                        'eincio (f.2015-12-23)
                        .Item("cCodGrupo", nPos).Value = CStr(row("cCodGrupo").ToString)

                        .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                        .Item("nMonCodigo", nPos).Value = CLng(row("nMonCodigo").ToString)
                        .Item("nIntCodigo", nPos).Value = CLng(row("nIntCodigo").ToString)
                        .Item("nCtaCteSerImpDef", nPos).Value = FormatNumber(row("nCtaCtePrecioOrig").ToString, True)
                        .Item("nTipoDscto", nPos).Value = CLng(row("nTipoDscto").ToString)
                        .Item("nCtaCteCantidad", nPos).Value = row("nCtaCteCantidad").ToString 'Precio
                        .Item("nCtaCteSerCosto", nPos).Value = FormatNumber(row("nCtaCteSerCosto").ToString, True) 'Precio
                        .Item("nCtaCteSubTotal", nPos).Value = FormatNumber(row("nCtaCteSubTotal").ToString, True) 'SubTotal
                        .Item("nFlag", nPos).Value = CLng(row("nFlag").ToString)
                    End With

                Next
            End If

            Table1.PerformLayout()

            '-------------------------
            'Carga Derivacion (Medico)
            '-------------------------
            'Dim nPos As Integer = 0
            Dim Servicio_AdmSolDerivacion As New BL_FichaAtencion
            Dim dt_AdmSolDerivacion As New DataTable

            dt_AdmSolDerivacion = Servicio_AdmSolDerivacion.Get_AdmSolDerivacion(StrcPerJuridica, Trim(LblNroSolicitud.Text))

            'Leyendo un DataTable
            If dt_AdmSolDerivacion.Rows.Count > 0 Then
                ChkDeriv.CheckState = CheckState.Checked
                Dim row As DataRow
                For Each row In dt_AdmSolDerivacion.Rows
                    CboDerivMedico.SelectedValue = CLng(row("cPerCodigoDoctor").ToString)
                Next
            End If

            '-----------------------------------------
            'Carga detalle Lista Empleados (CONVENIOS)
            '-----------------------------------------
            If CboTipoCta.SelectedValue = TipoAtencion.Convenio And CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
                Dim Obj_DetAdmSolListEmpl As New BL_FichaAtencion
                Dim dtDetAdmSolListEmpl As New DataTable

                dtDetAdmSolListEmpl = Obj_DetAdmSolListEmpl.Get_AdmSolListaEmpleado_by_cPerJuridica_nIntCodigo_cPerCodigoTerceros_nSolAdmNumero(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), LblcPerCodigo.Text, Trim(LblNroSolicitud.Text))

                'Leyendo un DataTable
                If dtDetAdmSolListEmpl.Rows.Count > 0 Then
                    Dim row As DataRow

                    EliminarRowsDgView(Table6)
                    'Table3.DataSource = Nothing

                    For Each row In dtDetAdmSolListEmpl.Rows
                        With Table6
                            nPos = .RowCount()
                            .Rows.Add()
                            .Item("cPerCodigo", nPos).Value = CStr(row("cPerCodigo").ToString)
                            .Item("cEmpleado", nPos).Value = CStr(row("cNombEmpl").ToString)
                        End With
                    Next
                End If

                Table6.PerformLayout()
                LblnEmpl.Text = Table6.RowCount.ToString
            End If

            'LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True)
            CalcularVta()

            LblnItem.Text = "Item(s): " & Table1.RowCount

            '(eincio f.2015-11-04)  -- Validando para evitar editar la ficha si ya tiene pagos (amortizaciones)
            If Convert.ToDouble(TokenByKey(StrPasaAdmFicha, "nImpAnticipo")) > 0 Then
                GroupBox1.Enabled = False : GroupBox4.Enabled = False : GroupBox3.Enabled = False : GrpBoxListEmpl.Enabled = False : c1CmdGrabar.Visible = False
            Else
                GroupBox1.Enabled = True : GroupBox4.Enabled = True : GroupBox3.Enabled = True : GrpBoxListEmpl.Enabled = True : c1CmdGrabar.Visible = True
            End If

            EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True, C1CmdProgramar, True)
            GrpBoxPersona.Enabled = False : CboTipoCta.Enabled = False : If CboEmpresa.Visible Then CboEmpresa.Enabled = False
            If CboSede.Visible Then CboSede.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdCancel.Click

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False, C1CmdProgramar, False)

        FormGridFichaAtencion.CboFiltro.SelectedIndex = FiltroFicha.nNroFichaAtencion
        FormGridFichaAtencion.TxtBuscar.Text = LblNroSolicitud.Text

        C1CmdCerrar_Click(C1CmdCerrar, Nothing)

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click

        nFlagAdmision = 0
        Close()
        Dispose()

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click

        'Validando que alla definido a la persona
        If Len(LblcPerCodigo.Text) = 0 Then
            MessageBox.Show("Por favor filtre los Datos del Paciente y/o Empresa, para poder continuar.", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNroFind.Focus()
            Exit Sub
        End If

        FormServicios = 1 'Seteo que sera para SolAtencion

        StrPasaValores = vbNullString
        StrPasaValores = "nIntCodigo=" & CboTipoCta.SelectedValue.ToString & ";" 'pasando que tipo de precio va a utilizar
        StrPasaValores = StrPasaValores & "cPerCodigo=" & Trim(LblcPerCodigo.Text) & ";"
        If CboEmpresa.Visible Then
            StrPasaValores = StrPasaValores & "cPerJurCodigo=" & CboEmpresa.SelectedValue
        End If

        FormFiltroServicios.ShowDialog()

        If Table1.RowCount > 0 Then CboTipoCta.Enabled = False 'Inhabilitamos ya que tenemos items agregados y el tipo de atencion ya tiene un precio preferencial

        'LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True)
        CalcularVta()

        LblnItem.Text = "Item(s): " & Table1.RowCount

    End Sub

    Private Sub ChkDeriv_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkDeriv.CheckedChanged
        If ChkDeriv.Checked Then
            CboDerivMedico.Visible = True : CboDerivMedico.Text = "" : Label9.Visible = True : BtnAddMedico.Visible = True : PanelComision.Visible = True
        Else
            CboDerivMedico.Visible = False : Label9.Visible = False : BtnAddMedico.Visible = False : PanelComision.Visible = False
        End If

    End Sub

    Private Sub CboMes_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboMes.SelectionChangeCommitted
        DtpFechaExamen()
    End Sub

    Private Sub CboAnio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboAnio.KeyPress, CboDia.KeyPress, CboMes.KeyPress, CboDerivMedico.KeyPress, CboEmpresa.KeyPress, CboTipoCta.KeyPress, CboTipoDocu.KeyPress, CboTipoPer.KeyPress, CboMinuto.KeyPress, CboHora.KeyPress, ComboBox1.KeyPress, ComboBox2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub CboAnio_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboAnio.SelectionChangeCommitted
        DtpFechaExamen()
    End Sub

    Private Sub CboDia_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboDia.SelectionChangeCommitted
        DtpFechaExamen()
    End Sub

    Private Sub CboTipoCta_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoCta.SelectionChangeCommitted

        Dim Obj_Empresa As New BL_Personas

        Select Case CboTipoCta.SelectedValue
            Case CInt(TipoAtencion.Particular), CInt(TipoAtencion.AtencionExterna)
                CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = CInt(nConTipoPersona.nPerNatural)
                CboEmpresa.Visible = False : Label10.Visible = False
                CboSede.Visible = False : Label39.Visible = False 'udpate 2016-04-20 (eincio)
                BtnBuscarEmpresa.Visible = False

            Case CInt(TipoAtencion.LabExterno)
                CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = CInt(nConTipoPersona.nPerNatural)
                CboEmpresa.Visible = True : CboEmpresa.Enabled = True : CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Laboratorio"
                CboSede.Visible = False : Label39.Visible = False
                BtnBuscarEmpresa.Visible = True
                LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido+' '+p.cPerNombre ELSE p.cPerNombre END) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoLabExterno) & " AND  nPerRelEstado <> 0", "cPerNombre"), "cPerCodigo", "cPerNombre")
                'LlenaDataCombo(CboEmpresa, Obj_Empresa.Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(1, 2), "cPerCodigo", "cPerNombre")
                CboEmpresa_SelectionChangeCommitted(CboEmpresa, Nothing) 'udpate 2016-04-20 (eincio)

            Case CInt(TipoAtencion.Convenio)
                CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = CInt(nConTipoPersona.nPerNatural) 'nConTipoPersona.nPerJuridica
                CboEmpresa.Visible = True : CboEmpresa.Enabled = True : CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Empresa"
                CboSede.Visible = False : Label39.Visible = False
                BtnBuscarEmpresa.Visible = True
                LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido+' '+p.cPerNombre ELSE p.cPerNombre END) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoEmpConvenio) & " AND  nPerRelEstado <> 0", "cPerNombre"), "cPerCodigo", "cPerNombre")
                'LlenaDataCombo(CboEmpresa, Obj_Empresa.Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(3, 131), "cPerCodigo", "cPerNombre")

            Case CInt(TipoAtencion.CentroSalud)
                CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = CInt(nConTipoPersona.nPerNatural)
                CboEmpresa.Visible = True : CboEmpresa.Enabled = True : CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Centro Salud"
                BtnBuscarEmpresa.Visible = True
                LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido+' '+p.cPerNombre ELSE p.cPerNombre END) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoCentroSalud) & " AND  nPerRelEstado <> 0", "cPerNombre"), "cPerCodigo", "cPerNombre")

            Case CInt(TipoAtencion.Campaña)
                CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = CInt(nConTipoPersona.nPerNatural)
                CboEmpresa.Visible = True : CboEmpresa.Enabled = True : CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Campaña"
                BtnBuscarEmpresa.Visible = True
                LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, (CASE nPerTipo WHEN 1 THEN p.cPerApellido+' '+p.cPerNombre ELSE p.cPerNombre END) cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & CInt(TipoActividad.nPerRelTipoCampana) & " AND  nPerRelEstado <> 0", "cPerNombre"), "cPerCodigo", "cPerNombre")

        End Select

        CboTipoPer_SelectionChangeCommitted(CboTipoPer, Nothing)

    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdGrabar.Click

        Try
            If ValidaCamposObligatorios() Then

                Me.Refresh()

                Dim ResultadoCab As Boolean
                Dim ResultadoDet As Boolean
                Dim ResultadoDerv As Boolean
                Dim ResultadoAut As Boolean

                Using scope As New TransactionScope()

                    Dim Obj_NewId As New BL_FichaAtencion

                    Dim Req_CabAdmSolAtencion As New BE_ReqSolAtencion
                    Dim Obj_CabAdmSolAtencion As New BL_FichaAtencion

                    If nFlagAdmision = 1 Then LblNroSolicitud.Text = Obj_NewId.Get_NewId_AdmSolAtencion()

                    REM CABECERA 
                    With Req_CabAdmSolAtencion
                        .cPerJuridica = StrcPerJuridica
                        .nIntCodigo = CInt(CboTipoCta.SelectedValue)
                        .cPerCodigoTerceros = IIf((CboTipoCta.SelectedValue <> TipoAtencion.Particular And CboTipoCta.SelectedValue <> TipoAtencion.AtencionExterna), CboEmpresa.SelectedValue, "")  'IIf(CboEmpresa.Enabled, CboEmpresa.SelectedValue, "")
                        .nPerIntCodigo = IIf(CboSede.Visible, CboSede.SelectedValue, 0)
                        .nSolAdmNumero = LblNroSolicitud.Text
                        .cPerCodigo = Trim(LblcPerCodigo.Text)
                        .dFecExamen = FormatDateTime(DTPFecExamen.Value, DateFormat.GeneralDate)
                        .nImpTotal = FormatNumber(LblTotalPago.Text, True)
                        .cPerUseCodigo = StrUser
                        .nFlagComision = IIf(ChkDeriv.Checked, IIf(RdoBtnConComision.Checked, 1, 0), 0) 'Update 2016-01-12 (EINCIO)
                    End With

                    REM Grabando Cabecera
                    If nFlagAdmision = 1 Then 'Agregando
                        If Not Obj_CabAdmSolAtencion.Ins_AdmSolAtencion(Req_CabAdmSolAtencion) Then
                            Throw New System.Exception("Se encontraron errores en la transacción: [Ins_AdmSolAtencion]")
                        Else
                            ResultadoCab = True 'Obj_CabAdmSolAtencion.Ins_AdmSolAtencion(Req_CabAdmSolAtencion)
                        End If
                    ElseIf nFlagAdmision = 2 Then
                        If Not Obj_CabAdmSolAtencion.Upd_AdmSolAtencion(Req_CabAdmSolAtencion) Then
                            Throw New System.Exception("Se encontraron errores en la transacción: [Upd_AdmSolAtencion]")
                        Else
                            ResultadoCab = True 'Obj_CabAdmSolAtencion.Upd_AdmSolAtencion(Req_CabAdmSolAtencion)
                        End If

                    End If

                    REM Diagnostico Clínico
                    With Table2
                        If .RowCount > 0 Then
                            For Each row As DataGridViewRow In .Rows
                                If Not Obj_CabAdmSolAtencion.Ins_AdmSolDiagnostico(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), LblNroSolicitud.Text, CStr(row.Cells("cDiagCodigo").Value)) Then
                                    Throw New System.Exception("Error grabando Diagnóstico Clínico, verifique por favor!.")
                                End If
                            Next
                        End If
                    End With

                    '-----------------------------
                    REM Grabando DetAdmSolAtencion 
                    '-----------------------------
                    With Table1
                        REM Recorriendo la Grilla
                        For Each row As DataGridViewRow In .Rows
                            'Throw New ApplicationException("Se encontraron errores en la transaccion: " + "[Ins_CuentaCorriente_ProgracionPago]")
                            If Convert.ToDouble(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value) <= 0 Then Throw New System.Exception("Precio con Cero, no se puede completar la operación.")
                            Req_CabAdmSolAtencion.nCtaCteSerCodigo = CLng(row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)

                            'update 2015-12-23
                            Req_CabAdmSolAtencion.cIntJerarquia = row.Cells(GrillaServicios.ColcCodGrupo).Value

                            'Update 01-10-2015
                            Req_CabAdmSolAtencion.nCtaCteSerImpDef = FormatNumber(row.Cells(GrillaServicios.ColnCtaCteSerImpDef).Value, True)
                            Req_CabAdmSolAtencion.nTipoDscto = CLng(row.Cells(GrillaServicios.ColnTipoDscto).Value)

                            Req_CabAdmSolAtencion.nCtaCteCantidad = CLng(row.Cells(GrillaServicios.ColnCtaCteCantidad).Value) '1 'Defautl
                            Req_CabAdmSolAtencion.nCtaCteCosto = FormatNumber(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value, True)
                            Req_CabAdmSolAtencion.nFlag = CLng(row.Cells(GrillaServicios.ColnFlag).Value)
                            'guardar precio original

                            REM Insert DET
                            If Not Obj_CabAdmSolAtencion.Ins_DetAdmSolAtencion(Req_CabAdmSolAtencion) Then
                                Throw New System.Exception("Se encontraron errores en la transacción: [Ins_DetAdmSolAtencion]")
                            Else
                                'ResultadoDet = Obj_CabAdmSolAtencion.Ins_DetAdmSolAtencion(Req_CabAdmSolAtencion)
                                ResultadoDet = True
                            End If
                        Next
                    End With

                    REM Grabando si es un Convenio con Empresas y con lista de Empleados
                    If CboTipoCta.SelectedValue = TipoAtencion.Convenio And CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica And Table6.RowCount > 0 Then
                        With Table6
                            If .RowCount > 0 Then
                                For Each row As DataGridViewRow In .Rows
                                    If Not Obj_CabAdmSolAtencion.Ins_Upd_AdmSolListaEmpleado(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), CboEmpresa.SelectedValue, LblNroSolicitud.Text, CStr(row.Cells("cPerCodigo").Value)) Then
                                        Throw New System.Exception("Error grabando Lista de Empleados, verifique por favor.!.")
                                    End If
                                Next
                            End If
                        End With
                    End If

                    REM Grabando persona que Autoriza examen si es un menor de edad (< 18 años)
                    If GrpBoxAutoriza.Enabled And LblcPerCodigoAut.Text <> vbNullString Then
                        If Not Obj_CabAdmSolAtencion.Ins_AdmSolAtenAutoriza(StrcPerJuridica, CInt(CboTipoCta.SelectedValue), LblNroSolicitud.Text, LblcPerCodigoAut.Text) Then
                            Throw New System.Exception("Se encontraron errores en la transacción: [Ins_AdmSolAtenAutoriza]")
                        Else
                            ResultadoAut = True
                            'ResultadoAut = Obj_CabAdmSolAtencion.Ins_AdmSolAtenAutoriza(StrcPerJuridica, CInt(CboTipoCta.SelectedValue), LblNroSolicitud.Text, LblcPerCodigoAut.Text)
                        End If
                    End If

                    If ChkDeriv.CheckState = CheckState.Checked And ChkDeriv.Checked Then 'nFlagAdmision = 1 And
                        Req_CabAdmSolAtencion.cPerCodigoDoctor = CboDerivMedico.SelectedValue.ToString
                        If Not Obj_CabAdmSolAtencion.Ins_AdmSolDerivacion(Req_CabAdmSolAtencion) Then
                            Throw New System.Exception("Se encontraron errores en la transacción: [Ins_AdmSolDerivacion]")
                        Else
                            ResultadoDerv = True
                            'ResultadoDerv = Obj_CabAdmSolAtencion.Ins_AdmSolDerivacion(Req_CabAdmSolAtencion)
                        End If

                    End If

                    '-------------------------------
                    ' Si aplicaron Dscto en la Ficha
                    '-------------------------------
                    If Len(cPerUsuDscto) > 0 And CLng(LblnPorcDscto.Text) > 0 Then
                        Dim Objeto As New BE_ReqSolAtencion
                        Dim Servicio As New BL_FichaAtencion
                        Objeto.cPerJuridica = StrcPerJuridica
                        Objeto.nIntCodigo = CInt(CboTipoCta.SelectedValue)
                        Objeto.nSolAdmNumero = LblNroSolicitud.Text
                        Objeto.nAudiIntClase = 1004 'poner en variable Global
                        Objeto.nAudiIntCodigo = TokenByKey(StrPasaValores, "nSisGruCodigo")
                        Objeto.cAudiDescripcion = TokenByKey(StrPasaValores, "cPerCodUsuario")
                        Objeto.nAudiMotivoDscto = nMotivoDscto
                        Objeto.cAudiDetalleDscto = TxtDetalleDscto.Text.Trim
                        Objeto.fAudiPorcDscto = Val(TxtValor.Text)
                        Objeto.fAudiTotalDscto = Val(LblnPorcDscto.Text)

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

                        Actualiza_AdmSolPerToken(cPerUsuDscto, StrcPerJuridica, cKeyToken, nSisGruCodigo.AdmisionAprobador, LblNroSolicitud.Text)
                        cKeyToken = "" : nFlagToken = 0 'setando variables
                    End If


                    'Creación de Usuario para Cliente / Laboratorio o Centro de Salud
                    Dim ObjBLPer As New BL_PerUsuario
                    Dim Response As New BE_ResGenerico
                    Dim RequestPer As New BE.PerUsuario.BE_ReqSearhUsuario

                    If CboTipoCta.SelectedValue = TipoAtencion.LabExterno Or CboTipoCta.SelectedValue = TipoAtencion.CentroSalud Then 'Laboratorios o Centro de Salud
                        RequestPer.PerCodigo = CboEmpresa.SelectedValue.ToString
                    Else
                        RequestPer.PerCodigo = Trim(LblcPerCodigo.Text)
                    End If
                    Response = ObjBLPer.Insert_PerUsuarioCliente(RequestPer)
                    If Response.Resultado = 0 Then Throw New System.Exception("Se encontraron errores, al generar usuario.")

                    scope.Complete()
                End Using

                If (ResultadoCab And ResultadoDet) Or ResultadoDerv Or ResultadoAut Then
                    GrpBoxListEmpl.Enabled = False
                    TxtValor.Enabled = True
                    nFlagToken = 0
                    MessageBox.Show("Ficha de Atención se registro con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ''OJO aqui con esto.
                'If MessageBox.Show("¿Desea Programar el Pago a la Ficha de Atención.?" & Chr(13) & "    NOTA.- Una vez programado el Pago no podra editar la Ficha.", "Programar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                '    C1CmdProgramar_Click(C1CmdProgramar, Nothing)
                'End If

                c1CmdCancel_Click(c1CmdCancel, Nothing)

            End If

        Catch ex As Exception 'TransactionAbortedException 'Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub BtnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuitar.Click

        Try
            If Table1.RowCount = 0 Then Exit Sub

            With Table1
                Dim Obj_DelDetAdmSolAtencion As New BL_FichaAtencion

                'Eliminar de BD
                Select Case CInt(.Item(GrillaServicios.ColnFlag, .CurrentRow.Index).Value)
                    Case 0, 9 'Normal / Lab Terceros
                        Obj_DelDetAdmSolAtencion.Del_DetAdmSolAtencion(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), IIf(Trim(LblNroSolicitud.Text) <> "Nueva Ficha", Trim(LblNroSolicitud.Text), 0), .Rows(.CurrentRow.Index).Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                        Call EliminaRowSeleccionada(Table1)
                    Case 1 ' Campaña 
                        MsgBox("No Puede eliminar un Item porque pertenece a una campaña.", vbInformation, "Validando..")
                        If MsgBox("¿Desea quitar todos los Items de la campaña.?", vbQuestion + vbYesNo, "Validando") = MsgBoxResult.Yes Then

                            Dim nFila As Integer
                            '1 es la condicion que indica Items de campaña.
                            For nFila = .Rows.Count - 1 To 0 Step -1
                                If .Rows(nFila).Cells(GrillaServicios.ColnFlag).Value = 1 Then
                                    If Not (Table1.Rows(nFila).IsNewRow) Then
                                        'Call EliminarRowsDg_for_Condicion(Table1, "nFlag", 1)
                                        Obj_DelDetAdmSolAtencion.Del_DetAdmSolAtencion(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), IIf(Trim(LblNroSolicitud.Text) <> "Nueva Ficha", Trim(LblNroSolicitud.Text), 0), .Rows(nFila).Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                                        .Rows.Remove(.Rows(nFila))
                                    End If
                                End If
                            Next

                        End If
                    Case 2 'Perfil detectado
                        MsgBox("No Puede eliminar un Item porque pertenece un Perfil.", vbInformation, "Validando..")
                        If MsgBox("¿Desea quitar todos los Items del Perfil.?", vbQuestion + vbYesNo, "Validando") = MsgBoxResult.Yes Then

                            Dim nFila As Integer
                            '1 es la condicion que indica Items de campaña.
                            For nFila = .Rows.Count - 1 To 0 Step -1
                                If .Rows(nFila).Cells(GrillaServicios.ColnFlag).Value = 2 Then
                                    If Not (Table1.Rows(nFila).IsNewRow) Then
                                        'Call EliminarRowsDg_for_Condicion(Table1, "nFlag", 1)
                                        Obj_DelDetAdmSolAtencion.Del_DetAdmSolAtencion(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), IIf(Trim(LblNroSolicitud.Text) <> "Nueva Ficha", Trim(LblNroSolicitud.Text), 0), .Rows(nFila).Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                                        .Rows.Remove(.Rows(nFila))
                                    End If
                                End If
                            Next

                        End If
                End Select

                'If .Item(GrillaServicios.ColnFlag, .CurrentRow.Index).Value = 1 Then

                '    MsgBox("No Puede eliminar un Item de campaña.", vbInformation, "Validando..")

                '    If MsgBox("¿Desea quitar todos los Items de la campaña.?", vbQuestion + vbYesNo, "Validando") = MsgBoxResult.Yes Then

                '        Dim nFila As Integer
                '        '1 es la condicion que indica Items de campaña.
                '        For nFila = .Rows.Count - 1 To 0 Step -1
                '            If .Rows(nFila).Cells(GrillaServicios.ColnFlag).Value = 1 Then
                '                If Not (Table1.Rows(nFila).IsNewRow) Then
                '                    'Call EliminarRowsDg_for_Condicion(Table1, "nFlag", 1)
                '                    Obj_DelDetAdmSolAtencion.Del_DetAdmSolAtencion(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), IIf(Trim(LblNroSolicitud.Text) <> "Nueva Ficha", Trim(LblNroSolicitud.Text), 0), .Rows(nFila).Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                '                    .Rows.Remove(.Rows(nFila))
                '                End If
                '            End If
                '        Next

                '    End If
                'Else
                '    Obj_DelDetAdmSolAtencion.Del_DetAdmSolAtencion(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), IIf(Trim(LblNroSolicitud.Text) <> "Nueva Ficha", Trim(LblNroSolicitud.Text), 0), .Rows(.CurrentRow.Index).Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                '    Call EliminaRowSeleccionada(Table1)
                'End If
            End With

            'LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True)
            CalcularVta()
            LblnItem.Text = "Item(s): " & Table1.RowCount

            If Table1.RowCount = 0 Then CboTipoCta.Enabled = True : LblnPorcDscto.Text = "0" 'habilitamos y podemos cambiar el tipo de atencion

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnAutoriza_Click(sender As System.Object, e As System.EventArgs) Handles BtnAutoriza.Click

        'nAccionBotones = nAccionButton.nAccionNuevo
        nFlagNewPariente = CInt(AccionForm.Add) 'Estado en 1 indica nuevo pariente
        FromParentesco = 2 'for FormPrcSolAtencion

        nFormPerPredeterminado = nConTipoPersona.nPerNatural

        'FormMaParentesco.TxtNroDocu.Text = TxtNroFindAutoriza.Text
        'FormMaParentesco.ShowDialog()

        Dim RegParentesco_Form As New FormMaParentesco()
        RegParentesco_Form.TxtNroDocu.Text = TxtNroFindAutoriza.Text
        RegParentesco_Form.Owner = Me
        RegParentesco_Form.ShowDialog(Me)
        RegParentesco_Form.Dispose()

        BuscaPersonaAutoriza()

        BtnCIE.Focus()

    End Sub

    Private Sub TxtNroFindAutoriza_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroFindAutoriza.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BuscaPersonaAutoriza()
        End If

    End Sub

    Private Sub C1CmdProgramar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdProgramar.Click

        Try
            Dim nClase As Integer = 0
            Dim nPrdCodigo As Integer
            Dim Resultado As Boolean

            Dim List As New List(Of BE.CtasCtesMedica.BE_ReqCtaCteDetalle) REM Variable de tipo "List"
            Dim ReqCtaCteDet As BE.CtasCtesMedica.BE_ReqCtaCteDetalle = Nothing REM Declaro variable "Item"

            Dim Obj_InsProgPago As New BL_CuentaCorriente

            If ValidaCamposObligatorios() Then
                'Obtengo periodo Contable actual (nPrdCodigo) IMPORTANTE para Asiento de Ventas.
                nPrdCodigo = ObjSistemaServicio.Get_Periodo_by_cPerJurCodigo(StrcPerJuridica)

                If MessageBox.Show("Seleccione como desea programar el Pago: " + Chr(13) + _
                                        " <SI> - Cancela el Total de la Ficha de Atención." + Chr(13) + _
                                        " <NO> - Dejar Anticipo (adelanto en Efectivo).", "Programar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    '------------------------------------------
                    'Llenando List con Lineas de CtaCteDetalle <List>
                    '------------------------------------------
                    With Table1
                        For i As Integer = 0 To .Rows.Count - 1
                            ReqCtaCteDet = New BE.CtasCtesMedica.BE_ReqCtaCteDetalle 'Crear Nueva Instancia de clase(objeto) memoria
                            '//Parametros
                            ReqCtaCteDet.nSerCodigo = CLng(.Item("nCtaCteSerCodigo", i).Value) REM Codigo de CtaCteServicio
                            ReqCtaCteDet.nCtaCteCantidad = CLng(.Item("nCtaCteCantidad", i).Value) ' CLng(1) REM Default cantidad 1
                            ReqCtaCteDet.nMoneda = CLng(TipoMoneda.nSoles)
                            ReqCtaCteDet.fCtaCteTC = 0
                            ReqCtaCteDet.fCtaCteIGV = Get_PorcIgv(cPerJuridica:=StrcPerJuridica) '<- para agregarlo con variable dinamica (ATENCION) eincio
                            ReqCtaCteDet.fCtaCteDetimporte = FormatNumber(.Item("nCtaCteSerCosto", i).Value, True) 'Coreccion cambio CLng por FormatNumber -- CLng(.Item("nCtaCteSerCosto", i).Value) REM Precio de Analisis
                            ReqCtaCteDet.dCtaCteDetRegistro = FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate)
                            ReqCtaCteDet.nCtaCtedetEstado = 1 REM 1=Activo param por default
                            '//Agrega linea segun la cantidad de lineas en la grilla
                            List.Add(ReqCtaCteDet)
                        Next
                    End With

                    nClase = 1014 'Pago total
                Else
                    'FormPrcProgramarPago.ShowDialog(Me)

                    Dim ProgPago_Form As New FormPrcProgramarPago()
                    ProgPago_Form.Owner = Me
                    ProgPago_Form.ShowDialog(Me)
                    ProgPago_Form.Dispose()
                    Dim nPorcentajeAnticipoMin As Double
                    Dim fMontoAnticipMin As Double
                    If nImpAnticipo = 0 Then nImpAnticipo = 0 : Exit Sub

                    nPorcentajeAnticipoMin = Convert.ToDouble(ObtenerParametroConfiguracion("28.CFGGENPORCANTIPMIN")) / 100.0
                    fMontoAnticipMin = Convert.ToDouble(TokenByKey(StrPasaAdmFicha, "nSaldo")) * nPorcentajeAnticipoMin
                    If nImpAnticipo < fMontoAnticipMin Then
                        MessageBox.Show("Importe de Anticipo debe ser como mínimo el " & nPorcentajeAnticipoMin * 100.0 & "% del saldo total de la ficha. Es decir, S/ " & Format(fMontoAnticipMin, "#######.00"), "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        nImpAnticipo = 0
                        Exit Sub
                    End If
                    'MessageBox.Show(nImpAnticipo + " - " + Convert.ToDouble(TokenByKey(StrPasaAdmFicha, "nSaldo")))

                    If nImpAnticipo >= Convert.ToDouble(TokenByKey(StrPasaAdmFicha, "nSaldo")) Then
                        MessageBox.Show("Importe de Anticipo supera el Pago y/o es igual al saldo del total de la ficha.", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        nImpAnticipo = 0
                        Exit Sub
                    End If
                    '------------------
                    'Pago por Anticipo
                    '------------------
                    ReqCtaCteDet = New BE.CtasCtesMedica.BE_ReqCtaCteDetalle 'Crear Nueva Instancia de clase(objeto) memoria
                    ReqCtaCteDet.nSerCodigo = 9999 'REM Codigo de CtaCteServicio pero de Anticipo ficticio
                    ReqCtaCteDet.nCtaCteCantidad = CLng(1) REM Default cantidad 1
                    ReqCtaCteDet.nMoneda = CLng(TipoMoneda.nSoles)
                    ReqCtaCteDet.fCtaCteTC = 0
                    ReqCtaCteDet.fCtaCteIGV = Get_PorcIgv(cPerJuridica:=StrcPerJuridica) '
                    ReqCtaCteDet.fCtaCteDetimporte = FormatNumber(nImpAnticipo, True)   'Importe de Anticipo
                    ReqCtaCteDet.dCtaCteDetRegistro = FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate)
                    ReqCtaCteDet.nCtaCtedetEstado = CLng(1) REM 1=Activo
                    List.Add(ReqCtaCteDet)

                    nClase = 1013 'Pago por Anticipo
                End If

                '-----------------------------
                REM Registrando Programacion
                '-----------------------------
                If Obj_InsProgPago.Ins_CuentaCorriente_ProgracionPago(LblcPerCodigo.Text, StrcPerJuridica, LblNroSolicitud.Text, _
                                                                        EstadoFichaAtencion.nProgramado, TipoActividad.nPerTipoCliente, nClase, _
                                                                        CInt(FormGridFichaAtencion.Table1.Item("nCtaCteCuota", FormGridFichaAtencion.Table1.CurrentRow.Index).Value) + 1, _
                                                                        IIf(nImpAnticipo > 0, FormatNumber(nImpAnticipo, True), FormatNumber(Convert.ToDouble(TokenByKey(StrPasaAdmFicha, "nSaldo")), True)), _
                                                                        FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate), _
                                                                        FormatDateTime(dFechaSistema & Space(1) & TimeOfDay, DateFormat.GeneralDate), _
                                                                        IIf(nImpAnticipo > 0, sGlosaCtaCteCorrienteAnticipo, sGlosaCtaCteCorriente), nPrdCodigo, TipoMoneda.nSoles, List, StrUser) Then
                    'FormatNumber(LblTotalPago.Text, True)

                    Resultado = True
                    MessageBox.Show("Programación de Pago se realizó con éxito.", "Programando Pago..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    c1CmdCancel_Click(c1CmdCancel, Nothing)
                Else
                    Throw New ApplicationException("Se encontraron errores en la transacción: " + "[Ins_CuentaCorriente_ProgracionPago]")
                End If

                'If Resultado Then
                '    MessageBox.Show("Programación de Pago se realizó con éxito.", "Programando Pago..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    'c1CmdCancel_Click(c1CmdCancel, Nothing)
                'End If

                'seteando variable
                nImpAnticipo = 0

            End If

        Catch ex As Exception
            MessageBox.Show("Se encontraron errores. " & ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnCIE_Click(sender As System.Object, e As System.EventArgs) Handles BtnCIE.Click

        FormDiagnosticoCIE10.ShowDialog()

    End Sub

    Private Sub BtnDel_Click(sender As System.Object, e As System.EventArgs) Handles BtnDel.Click

        If Table2.RowCount = 0 Then Exit Sub

        Try
            With Table2
                Dim Obj_DelDiag As New BL_FichaAtencion

                If MsgBox("¿Desea eliminar Diagnóstico seleccionado..?", vbQuestion + vbYesNo, "Validando") = MsgBoxResult.Yes Then
                    Obj_DelDiag.Del_AdmSolDiagnostico(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), IIf(Trim(LblNroSolicitud.Text) <> "Nueva Ficha", Trim(LblNroSolicitud.Text), 0), .Rows(.CurrentRow.Index).Cells("cDiagCodigo").Value)
                    Call EliminaRowSeleccionada(Table2)
                End If

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnAddEmpl_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddEmpl.Click

        nFlagPersona = 1
        'nOperacion = 1
        FormMaPersona.Width = 503
        nFormPerPredeterminado = nConTipoPersona.nPerNatural
        FormMaPersona.TxtNroDocu.Text = TxtNroFind.Text
        FormMaPersona.ShowDialog()

        BuscaEmpleado()

    End Sub

    Private Sub TxtFindEmpl_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFindEmpl.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            BuscaEmpleado()
        End If
    End Sub

    Private Sub BtnAddEmplGrd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddEmplGrd.Click
        Try
            Dim Rows As Integer

            If LblcPerCodEmpl.Text = vbNullString Then Exit Sub 'no permitir agregar si no hay dato

            If BuscaCadenaDgView("cPerCodigo", Trim(LblcPerCodEmpl.Text), Table6) Then
                MessageBox.Show("Empleado ya ha sido ingresado en la lista, verifique por favor.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                With Table6
                    Rows = .RowCount()
                    .Rows.Add()
                    .Item("cPerCodigo", Rows).Value = LblcPerCodEmpl.Text
                    .Item("cEmpleado", Rows).Value = LblcNombEmpl.Text
                End With
                TxtFindEmpl.Text = vbNullString : LblcPerCodEmpl.Text = vbNullString : LblcNombEmpl.Text = vbNullString
                LblnEmpl.Text = Table6.RowCount.ToString
            End If

            TxtFindEmpl.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnQuitarEmpl_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuitarEmpl.Click

        Try
            With Table6
                Dim Obj_DelDetListEmpl As New BL_FichaAtencion
                'Eliminar de BD
                Obj_DelDetListEmpl.Del_AdmSolListaEmpleado(StrcPerJuridica, CLng(CboTipoCta.SelectedValue), CboEmpresa.SelectedValue, Trim(LblNroSolicitud.Text), .Rows(.CurrentRow.Index).Cells("cPerCodigo").Value)
                Call EliminaRowSeleccionada(Table6)
                LblnEmpl.Text = Table6.RowCount.ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CboEmpresa_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboEmpresa.SelectedValueChanged
        CboEmpresa_SelectionChangeCommitted(CboEmpresa, Nothing)
    End Sub

    Private Sub CboEmpresa_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboEmpresa.SelectionChangeCommitted

        If CboEmpresa.Visible Then
            Dim dt As DataTable
            dt = ObjSistemaServicio.Get_Value_Table("pi.nPerIntCodigo , i.cIntDescripcion", "PerInterface pi WITH(NOLOCK) INNER JOIN Interface i WITH(NOLOCK) ON pi.nPerIntClase = i.nIntClase AND pi.nPerIntCodigo = i.nIntCodigo", "", 3, "pi.cPerCodigo = '" + CboEmpresa.SelectedValue + "' AND i.nIntTipo = 1", "i.cIntDescripcion")
            If dt.Rows.Count > 0 Then
                Label39.Visible = True : CboEmpresa.Width = 339 : CboSede.Visible = True : CboSede.Enabled = True
                CboSede.DataSource = Nothing
                LlenaDataCombo(CboSede, dt, "nPerIntCodigo", "cIntDescripcion")
            Else
                Label39.Visible = False : CboEmpresa.Width = 654 : CboSede.Visible = False : CboSede.Enabled = False
            End If
            BtnBuscarEmpresa.Left = CboEmpresa.Left + CboEmpresa.Width + 6
        End If

        'If CboTipoCta.SelectedValue = TipoAtencion.Convenio And CboTipoPer.SelectedValue = nConTipoPersona.nPerJuridica Then
        '    Dim dt As New DataTable
        '    dt = ObjSistemaServicio.Get_Value_Table("cPerIdeNumero", "PerIdentifica", "", 2, "cPerCodigo = '" & Trim(CboEmpresa.SelectedValue.ToString) & "' AND nPerIdeTipo = 11")
        '    If dt.Rows.Count > 0 Then
        '        TxtNroFind.Text = dt.Rows(0).Item("cPerIdeNumero").ToString
        '        BuscaPersona()
        '    End If
        'End If

    End Sub

    Private Sub BtnAddMedico_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddMedico.Click
        PanelMedica.Visible = True
    End Sub

    Private Sub BtnAddMedicoReg_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddMedicoReg.Click
        Try
            Dim Objeto As New BE_ReqPersona
            Dim Servicio As New BL_Personas

            If ValidarDatosMedico() Then
                Objeto.cPerJurCodigo = StrcPerJuridica
                Objeto.cPerApellPaterno = TxtApePaterno.Text
                Objeto.cPerApellMaterno = TxtApeMaterno.Text
                Objeto.cPerNombre = TxtNomb.Text
                Objeto.nPerNatSexo = IIf(RBtnSexoM.Checked, 1, 2)

                If Servicio.Ins_PerMedicoDetalle(Objeto) Then
                    CboDerivMedico.DataSource = Nothing
                    LlenaDataCombo(CboDerivMedico, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo , p.cPerApellido + space(1) +  p.cPerNombre  cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo IN (" & TipoActividad.nPerRelTipoMedico & "," & TipoActividad.nPerRelTipoMedicoSinComision & ")", "cPerNombre"), "cPerCodigo", "cPerNombre")
                    CboDerivMedico.AutoCompleteCustomSource = LoadAutoComplete(ObjSistemaServicio.Get_Value_Table("p.cPerCodigo , p.cPerApellido + space(1) +  p.cPerNombre  cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo IN (" & TipoActividad.nPerRelTipoMedico & "," & TipoActividad.nPerRelTipoMedicoSinComision & ")", "cPerNombre"), "cPerNombre")
                    CboDerivMedico.AutoCompleteMode = AutoCompleteMode.Suggest
                    CboDerivMedico.AutoCompleteSource = AutoCompleteSource.CustomSource

                    CboDerivMedico.SelectedText = Objeto.cPerApellPaterno & " " & Objeto.cPerApellMaterno & " " & Objeto.cPerNombre

                End If
                PanelMedica.Visible = False
                Me.ActiveControl = CboDerivMedico
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function ValidarDatosMedico() As Boolean
        Dim Res As Boolean = False
        If TxtApePaterno.Text.Trim = "" Then
            MessageBox.Show("Apellido Paterno es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtApePaterno.Focus()
        ElseIf TxtApeMaterno.Text.Trim = "" Then
            MessageBox.Show("Apellido Materno es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtApeMaterno.Focus()
        ElseIf TxtNomb.Text.Trim = "" Then
            MessageBox.Show("Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtNomb.Focus()
        ElseIf RBtnSexoM.Checked = False And RBtnSexoF.Checked = False Then
            MessageBox.Show("El sexo es un dato obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Res = True
        End If
        Return Res
    End Function

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        PanelMedica.Visible = False
        Me.ActiveControl = CboDerivMedico
    End Sub

    Private Sub Table1_DoubleClick(sender As Object, e As System.EventArgs) Handles Table1.DoubleClick

        StrPasaValores = vbNullString 'seteo la variable 
        StrPasaValores = "cCtaCteSerJerarquia=" & Table1.Item(GrillaServicios.ColcCtaCteSerJerarquia, Table1.CurrentRow.Index).Value.ToString

        FormPopupDetalleAnalisis.ShowDialog()

    End Sub

    Private Sub BtnPermitirDscto_Click(sender As System.Object, e As System.EventArgs) Handles BtnPermitirDscto.Click

        Try
            If Table1.RowCount = 0 Then Exit Sub

            Dim nPos As Integer = 0

            frmSisGruCodigo = nSisGruCodigo.AdmisionAprobador

            Dim RequestPer As New BE.PerUsuario.BE_ReqSearhUsuario
            Dim ObjBLPerDesc As New BL_PerUsuario

            'nPorcentajeMax = 30
            nPorcentajeMax = CLng(ObtenerParametroConfiguracion("28.CFGGENPORCMAX"))
            cPorcDscto = TxtValor.Text 'Antes de cambiar el porcentaje
            nFlagDescMax = False
            'TxtValor.Enabled = True
            If MessageBox.Show("¿El descuento que desea realizar supera " & CStr(nPorcentajeMax) & "%?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then

                RequestPer.cPerUsuCodigo = FormMDI.SSUser.Text
                RequestPer.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
                RequestPer.nObjCodigo = nSisGruCodigo.AdmisionDescuentosMax

                Dim dt2 As New DataTable
                dt2 = ObjBLPerDesc.Get_UsuarioAutorizado(RequestPer)

                If dt2.Rows.Count > 0 Then
                    nFlagDescMax = True
                    StrPasaValores = vbNullString
                    StrPasaValores = "cPerCodUsuario=" & StrUser & ";"
                    StrPasaValores = StrPasaValores & "nSisGruCodigo=" & CStr(frmSisGruCodigo)
                    'TxtValor.Enabled = False
                    TxtValor.Text = nPorcentajeMax
                End If
            Else
                FormLoginAutoriza.ShowDialog()
                FormLoginAutoriza.Dispose()
            End If
            Dim nAplicarTodasPruebas As Long = 0
            If nFlagDscto = 1 Or nFlagDescMax Then 'Permitir
                EliminarRowsDgView(Table4)
                nFlagIniciarDscto = 1
                cPerUsuDscto = TokenByKey(StrPasaValores, "cPerCodUsuario") 'Get <cPerCodigo> usuario quien esta autorizando el Dscto.

                nAplicarTodasPruebas = CLng(ObtenerParametroConfiguracion("28.CFGGENDSCTOALL"))

                Dim row As DataGridViewRow

                For Each row In Table1.Rows
                    With Table4
                        nPos = .RowCount()
                        '-----------------------------------------------------------------------
                        ' Pasan al Dscto solo servicios que NO pertenecen a Perfil y/o Campañas
                        ' 0=Normal (Solo muestras procesadas por nosotros) Equivalente = 9 en DetAdmSolAtencion(nFlag)
                        ' 1=Campaña
                        ' 2=Perfil
                        ' 9=Muestra enviadas a Lab. Terceros (No Aplica descuento)
                        '----------------------------------------------------------------------
                        Dim bCondicional As Boolean = False
                        If nAplicarTodasPruebas = 1 Then
                            bCondicional = CInt(row.Cells("nFlag").Value) = CInt(TipoMuestraDscto.nProcesoLocal) Or CInt(row.Cells("nFlag").Value) = CInt(TipoMuestraDscto.nPerfil) Or CInt(row.Cells("nFlag").Value) = CInt(TipoMuestraDscto.nProcesoLabTercero)  'Solo muestras procesadas por nosotros y Terceros
                        Else
                            bCondicional = CInt(row.Cells("nFlag").Value) = CInt(TipoMuestraDscto.nProcesoLocal) 'Solo muestras procesadas por nosotros
                        End If

                        If bCondicional Then
                            .Rows.Add()
                            .Item("DsctocPerJurCodigo", nPos).Value = row.Cells("cPerJurCodigo").Value
                            .Item("DsctonCtaCteSerCodigo", nPos).Value = CInt(row.Cells("nCtaCteSerCodigo").Value)
                            .Item("DsctocIntJerarquia", nPos).Value = row.Cells("cIntJerarquia").ToString
                            .Item("DsctocCtaCteSerJerarquia", nPos).Value = row.Cells("cCtaCteSerJerarquia").Value

                            'eincio (f.2015-12-23)
                            .Item("DsctocCodGrupo", nPos).Value = row.Cells("cCodGrupo").Value

                            .Item("DsctocCtaCteSerKeyWord", nPos).Value = row.Cells("cCtaCteSerKeyWord").Value
                            .Item("DsctonMonCodigo", nPos).Value = CInt(row.Cells("nMonCodigo").Value)
                            .Item("DsctonIntCodigo", nPos).Value = CInt(row.Cells("nIntCodigo").Value)
                            .Item("DsctonCtaCteCantidad", nPos).Value = CInt(row.Cells("nCtaCteCantidad").Value)

                            'Aqui siempre sera el precio venta NORMAL
                            .Item("DsctonCtaCteSerImpDef", nPos).Value = CDbl(row.Cells("nCtaCteSerImpDef").Value)

                            .Item("DsctonTipoDscto", nPos).Value = CInt(TipoDsctoAplica.Porcentaje)  '1- Default carga en Porcentaje (Cbo Grilla "Tipo Dscto")

                            .Item("DsctonCtaCteSerCosto", nPos).Value = CDbl(TxtValor.Text) 'row.Cells("nCtaCteSerImpDef").Value) 'cada vez debe volver a procesar
                            .Item("DsctonAplicado", nPos).Value = CDbl(row.Cells("nCtaCteSubTotal").Value)
                            .Item("DsctonFlag", nPos).Value = CInt(row.Cells("nFlag").Value)
                        End If
                    End With
                Next

                If Table4.RowCount > 0 Then
                    BtnPermitirDscto.Visible = False
                    Table4.PerformLayout()
                    TabControl1.TabPages.Add(TabPage2)
                    TabControl1.SelectedIndex = 1

                    'Bloqueo
                    BtnAdd.Enabled = False : BtnQuitar.Enabled = False : c1CmdGrabar.Enabled = False

                    If CboTipoCta.SelectedValue = TipoAtencion.AtencionExterna Then
                        ChckBoxDcstoTodo.Enabled = True : CboTipoDscto.Enabled = False : Table4.Enabled = True
                    Else
                        ChckBoxDcstoTodo.Enabled = False : CboTipoDscto.Enabled = False : Table4.Enabled = False
                    End If

                    Me.ActiveControl = TxtValor
                Else
                    cPerUsuDscto = ""
                    MessageBox.Show("No se encontraron examen(es) para aplicar descuento...! (Motivos)" & _
                                        Chr(13) & " * Pertenecen a Campaña y/o Perfil." & _
                                        Chr(13) & " * Derivada a Laboratorio (Terceros).", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

            ElseIf nFlagDescMax = False Then
                MessageBox.Show("No tiene permisos para efectuar descuentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub BtnAplicaDscto_Click(sender As System.Object, e As System.EventArgs) Handles BtnAplicaDscto.Click

        Try
            Dim nImpSinDscto As Double = 0
            Dim nPorcAplicadp As Double = 0

            nMotivoDscto = Val(CboMotivDscto.SelectedValue)
            If ChckBoxDcstoTodo.Checked Then
                If Convert.ToDouble(TxtValor.Text) <= 0 Or TxtValor.Text = "" AndAlso Len(TxtValor.Text) = 0 Then
                    MessageBox.Show("Porcentaje ingresado No es correcto.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ActiveControl = TxtValor
                    Exit Sub
                ElseIf nFlagDescMax And CboTipoDscto.SelectedValue = TipoDsctoAplica.Porcentaje And CDbl(TxtValor.Text) > nPorcentajeMax Then
                    MessageBox.Show("No está autorizado para dar más de " & CStr(nPorcentajeMax) & "% de descuento.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ActiveControl = TxtValor
                    Exit Sub
                ElseIf nMotivoDscto = 0 Then
                    MessageBox.Show("El Motivo del descuento es obligatorio.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ActiveControl = CboMotivDscto
                    Exit Sub
                ElseIf TxtDetalleDscto.Text.Trim = "" Then
                    MessageBox.Show("La observación del descuento es obligatorio. Ej." & Chr(10) & "  - Si es Tarifa Social, el nombre del médico." & _
                                    Chr(10) & "  - Si es Médico o Familiar de Médico, el nombre del médico." & _
                                    Chr(10) & "  - Si es Trabajador o Familiar de Trabajador, el nombre del trabajador.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ActiveControl = TxtDetalleDscto
                    Exit Sub
                End If
            End If

            If ChckBoxDcstoTodo.Checked = True Then
                With Table4
                    For i As Integer = 0 To .Rows.Count - 1
                        'Define que tipo de Dscto. se aplicara.
                        .Rows(i).Cells("DsctonTipoDscto").Value = CboTipoDscto.SelectedValue

                        If .Rows(i).Cells("DsctonTipoDscto").Value() = TipoDsctoAplica.Porcentaje Then ' por porcentaje
                            .Rows(i).Cells("DsctonCtaCteSerCosto").Value = FormatNumber(CDbl(.Rows(i).Cells("DsctonCtaCteSerImpDef").Value) - (CDbl(.Rows(i).Cells("DsctonCtaCteSerImpDef").Value) * (CDbl(TxtValor.Text) / 100)), True)
                        Else
                            .Rows(i).Cells("DsctonCtaCteSerCosto").Value = FormatNumber(CDbl(.Rows(i).Cells("DsctonCtaCteSerImpDef").Value), True) '- CDbl(TxtValor.Text)
                        End If
                        .Rows(i).Cells("DsctonAplicado").Value = FormatNumber(CDbl(.Rows(i).Cells("DsctonCtaCteCantidad").Value) * CDbl(.Rows(i).Cells("DsctonCtaCteSerCosto").Value), True)
                    Next
                End With
            Else
                With Table4
                    For i As Integer = 0 To .Rows.Count - 1
                        If .Rows(i).Cells("DsctonTipoDscto").Value = TipoDsctoAplica.Porcentaje Then ' por porcentaje
                            .Rows(i).Cells("DsctonCtaCteSerCosto").Value = FormatNumber(CDbl(.Rows(i).Cells("DsctonCtaCteSerImpDef").Value) - (CDbl(.Rows(i).Cells("DsctonCtaCteSerImpDef").Value) * (CDbl(.Rows(i).Cells("DsctonCtaCteSerCosto").Value) / 100)), True)
                        Else
                            .Rows(i).Cells("DsctonCtaCteSerCosto").Value = FormatNumber(CDbl(.Rows(i).Cells("DsctonCtaCteSerCosto").Value), True) '- CDbl(TxtValor.Text)
                        End If
                        .Rows(i).Cells("DsctonAplicado").Value = FormatNumber(CDbl(.Rows(i).Cells("DsctonCtaCteCantidad").Value) * CDbl(.Rows(i).Cells("DsctonCtaCteSerCosto").Value), True)
                    Next
                End With
            End If

            Table4.PerformLayout()

            '------------------------------------------------------------------
            'Pasando al TabPage1 Final que es lo que se guarda en la Base datos
            '------------------------------------------------------------------
            With Table4
                For i As Integer = 0 To .Rows.Count - 1
                    'Define que tipo de Dscto se aplicara
                    For j As Integer = 0 To Table1.Rows.Count - 1
                        'Validando que cCtaCteSerJerarquia = cCtaCteSerJerarquia
                        If Table1.Rows(j).Cells("cCtaCteSerJerarquia").Value() = .Rows(i).Cells("DsctocCtaCteSerJerarquia").Value() Then
                            Table1.Rows(j).Cells("nTipoDscto").Value() = CInt(.Rows(i).Cells("DsctonTipoDscto").Value())
                            Table1.Rows(j).Cells("nCtaCteCantidad").Value = CInt(.Rows(i).Cells("DsctonCtaCteCantidad").Value())
                            Table1.Rows(j).Cells("nCtaCteSerCosto").Value = FormatNumber(CDbl(.Rows(i).Cells("DsctonCtaCteSerCosto").Value), True)
                            Table1.Rows(j).Cells("nCtaCteSubTotal").Value = FormatNumber(CDbl(.Rows(i).Cells("DsctonAplicado").Value), True)
                        End If
                    Next
                    'Importe Total sin dscto
                    'nImpSinDscto = nImpSinDscto + CInt(.Rows(i).Cells("DsctonCtaCteCantidad").Value()) * CInt(.Rows(i).Cells("DsctonCtaCteSerImpDef").Value())
                Next
            End With

            Table1.PerformLayout()

            'Desbloqueo
            BtnAdd.Enabled = True : BtnQuitar.Enabled = True : c1CmdGrabar.Enabled = True

            'LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSubTotal", Table1), True)
            CalcularVta()

            'Calculando el porcentaje aplicado
            'LblnPorcDscto.Text = Math.Abs(100 - nImpSinDscto * (LblTotalPago.Text / nImpSinDscto))
            'LblTBruto.Text = FormatNumber(Suma_Columna("nCtaCteSerImpDef", Table1), True)
            'LblnPorcDscto.Text = FormatNumber(Suma_Columna("nCtaCteSerImpDef", Table1) - CDbl(LblTotalPago.Text), True)

            '            End If
            nFlagIniciarDscto = 2 'Se aplicó el Descuento

            TabControl1.TabPages.Remove(TabPage2)
            BtnPermitirDscto.Visible = True

            'Desbloqueo
            BtnAdd.Enabled = True : BtnQuitar.Enabled = True : c1CmdGrabar.Enabled = True

            CalcularVta()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        If nFlagIniciarDscto = 2 Then 'Si ya había aplicado descuento antes
            If TxtValor.Text <> cPorcDscto Then '¿Ha modificado el porcentaje de descuento?
                If MessageBox.Show("Si cancela en este momento, perderá los cambios ¿Está seguro de continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    TxtValor.Text = cPorcDscto
                End If
            End If
        Else
            nFlagIniciarDscto = 0
            nMotivoDscto = 0
        End If
        TabControl1.TabPages.Remove(TabPage2)
        BtnPermitirDscto.Visible = True

        'Desbloqueo
        BtnAdd.Enabled = True : BtnQuitar.Enabled = True : c1CmdGrabar.Enabled = True

        CalcularVta()

    End Sub

    Private Sub ChckBoxDcstoTodo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChckBoxDcstoTodo.CheckedChanged
        If ChckBoxDcstoTodo.Checked Then
            Table4.Enabled = False : TxtValor.Text = "0" : TxtValor.Enabled = True : CboTipoDscto.SelectedValue = TipoDsctoAplica.Porcentaje : CboTipoDscto.Enabled = False
        Else
            Table4.Enabled = True : TxtValor.Text = "" : TxtValor.Enabled = False : CboTipoDscto.SelectedValue = TipoDsctoAplica.Porcentaje : CboTipoDscto.Enabled = False
        End If
    End Sub

    Private Sub TxtNroFind_LostFocus(sender As Object, e As EventArgs) Handles TxtNroFind.LostFocus
        DetalleComisionMedico()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        EliminarRowsDgView(Table5)
        PanelMedico.Visible = False : GroupBox1.Enabled = True
    End Sub

    Private Sub Table5_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Table5.CellPainting

        '-----------------------
        '-- Combinando Column 3 
        '-----------------------
        Select Case e.ColumnIndex
            Case 2, 3
                Using gridBrush As Brush = New SolidBrush(Me.Table5.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                    Using gridLinePen As Pen = New Pen(gridBrush)
                        ' Clear cell   
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                        ' Draw line (bottom border and right border of current cell)   
                        'If next row cell has different content, only draw bottom border line of current cell   
                        If e.RowIndex < Table5.Rows.Count - 2 AndAlso Table5.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                        End If

                        ' Draw right border line of current cell   
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                        ' draw/fill content in current cell, and fill only one cell of multiple same cells   
                        If Not e.Value Is Nothing Then
                            If e.RowIndex > 0 AndAlso Table5.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                            Else
                                e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                            End If
                        End If

                        e.Handled = True
                    End Using
                End Using
        End Select

        'If (e.ColumnIndex = 2 And e.ColumnIndex = 3) AndAlso e.RowIndex <> -1 Then


        'End If

    End Sub


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        PanelBuscarApellidos.Visible = False : GroupBox1.Enabled = True : ActiveControl = TxtNroFind
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click

        With Table7
            If .Item("cPerIdeNumero", .CurrentRow.Index).Value.ToString = "" Then Exit Sub
            TxtNroFind.Text = .Item("cPerIdeNumero", .CurrentRow.Index).Value()
        End With
        PanelBuscarApellidos.Visible = False : GroupBox1.Enabled = True : ActiveControl = TxtNroFind

        BuscaPersona()

    End Sub

    Private Sub TxtBuscarPorApellidos_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarPorApellidos.TextChanged

        If Len(TxtBuscarPorApellidos.Text) = 0 Or Len(TxtBuscarPorApellidos.Text) <= 2 Or TxtBuscarPorApellidos.Text = "" Then Exit Sub

        Dim Request As New BE.Persona.BE_ReqPersonaSearh
        Request.cPerApellido = DBTilde(Replace(TxtBuscarPorApellidos.Text, "'", ""))

        Dim ObjBL As New BL_Personas

        Table7.DataSource = ObjBL.Get_Persona_by_cPerApellido(Request)
        Table7.PerformLayout()

    End Sub

    Private Sub BtnCancelDNI_Click(sender As Object, e As EventArgs) Handles BtnCancelDNI.Click
        TxtBuscarPorApellidos.Enabled = True : Table7.Enabled = True : PanelDNI.Visible = False
    End Sub

    Private Sub BtnUpdateDocu_Click(sender As Object, e As EventArgs) Handles BtnUpdateDocu.Click
        If Table7.Item("cPerIdeNumero", Table7.CurrentRow.Index).Value.ToString = "" Then
            TxtBuscarPorApellidos.Enabled = False : Table7.Enabled = False : PanelDNI.Visible = True : ActiveControl = TxtDNI
        End If
    End Sub

    Private Sub BtnUpdateDNI_Click(sender As Object, e As EventArgs) Handles BtnUpdateDNI.Click

        Try
            Dim Request As New BE.Persona.BE_ReqPerIdentifica
            Dim Obj As New BL.BL_Personas
            Dim Response As New BE_ResGenerico
            Dim Resultado As Long

            Request.cPerCodigo = Table7.Item("cPerCodigo2", Table7.CurrentRow.Index).Value.ToString
            Request.nPerIdeTipo = 25
            Request.cPerIdeNumero = TxtDNI.Text

            If TxtDNI.Text = "" Or TxtDNI.MaxLength <> 8 Then
                MessageBox.Show("Número de documento no es válido..!", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Response = Obj.InsPerIdentifica(Request)
                Resultado = Response.Resultado
                If Resultado = 0 Then
                    Throw New System.Exception("Se encontraron errores en la transaccion: [Ins_PerIdentifica]")
                Else
                    MessageBox.Show("Operación se realizó con éxito.", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TxtBuscarPorApellidos_TextChanged(TxtBuscarPorApellidos, Nothing)
                End If

            End If

            TxtBuscarPorApellidos.Enabled = True : Table7.Enabled = True : PanelDNI.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub CboTipoDocu_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboTipoDocu.SelectionChangeCommitted

        If CboTipoDocu.SelectedValue = 25 Then
            TxtNroFind.MaxLength = 8
        Else
            TxtNroFind.MaxLength = 15
        End If

    End Sub


    Private Sub LnkRENIEC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkRENIEC.LinkClicked
        FormReniec.Mostrar("҉ Validación RENIEC", "https://cel.reniec.gob.pe/valreg/valreg.do")
    End Sub

    Private Sub LnkEsSalud_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkEsSalud.LinkClicked
        FormReniec.Mostrar("҉ Validación EsSalud", "http://ww4.essalud.gob.pe:7777/acredita/", 700, 600)
    End Sub

    Private Sub LnkSUNAT_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkSUNAT.LinkClicked
        FormReniec.Mostrar("҉ Validación SUNAT", "http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias")
    End Sub

    Private Sub BtnBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles BtnBuscarEmpresa.Click
        Try
            Dim Frm As New FormTerceros
            Select Case CboTipoCta.SelectedValue
                Case CInt(TipoAtencion.LabExterno)
                    Frm.CargarFormulario(CLng(TipoActividad.nPerRelTipoLabExterno))
                Case CInt(TipoAtencion.Convenio)
                    Frm.CargarFormulario(CLng(TipoActividad.nPerRelTipoEmpConvenio))
                Case CInt(TipoAtencion.CentroSalud)
                    Frm.CargarFormulario(CLng(TipoActividad.nPerRelTipoCentroSalud))
                Case CInt(TipoAtencion.Campaña)
                    Frm.CargarFormulario(CLng(TipoActividad.nPerRelTipoCampana))
            End Select
            If Frm.Table1.Rows.Count > 0 Then
                If Not Frm.Table1.CurrentRow Is Nothing Then
                    'MessageBox.Show(Frm.Table1.Rows.Item(Frm.Table1.CurrentRow.Index).Cells("cPerCodigo").Value.ToString, "AVISO", MessageBoxButtons.OK)
                    CboEmpresa.SelectedValue = Frm.Table1.Rows.Item(Frm.Table1.CurrentRow.Index).Cells("cPerCodigo").Value.ToString
                End If
            End If
            Frm.Close()
            Frm.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error inesperado en la búsqueda, comuníquese conel área de TI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class