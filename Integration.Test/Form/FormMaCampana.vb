Option Explicit On
Imports Integration.BE
Imports Integration.BE.Campana
Imports Integration.BL.BL_Campana

Imports System.Transactions

Public Class FormMaCampana

    Dim nFlag As Integer REM nglag = 0 , Agregando, 1 = modificando

    Dim dateValue As Date

    Dim Req_Campana As New BE_ReqCampana
    Dim Obj_Campana As New BL_Campana
    Dim Response As New BE_ResGenerico

    Enum GrillaServicios
        ColcPerJurCodigo = 0
        ColnCtaCteSerCodigo = 1
        ColcCodGrupo = 2
        ColcCtaCteSerJerarquia = 3
        ColcCtaCteSerKeyWord = 4
        ColnMonCodigo = 5
        ColnIntCodigo = 6
        ColnCtaCteSerCosto = 7
        ColnFlag = 8
    End Enum

    Enum GrillaListVigencia
        ColnIntCamp = 0
        ColcNombreCamp = 1
        ColdFecIniCamp = 2
        ColdFecFinCamp = 3
    End Enum

    Private Sub GeneraNewIdCampana()
        'Genera nIntCamp nuevo "[usp_Get_NewId_nIntCampana]"
        Req_Campana.cPerJurCodigo = StrcPerJuridica
        LblnIntCamp.Text = Obj_Campana.Get_NewId_nIntCampana(Req_Campana)

    End Sub

    Private Sub ListarCampanaVigente()
        'Llena Table1
        Dim Objeto As New BE_ReqCampana
        Dim Servicio As New BL_Campana

        Objeto.cPerJurCodigo = StrcPerJuridica
        Table2.DataSource = Servicio.Get_Campana_Historial(Objeto)
    End Sub

    Private Sub DtpFechaInicio()
        Dim DFecha As String = CboDia.Text + "/" + CboMes.SelectedValue.ToString + "/" + CboAnio.Text


        If DateTime.TryParse(DFecha, dateValue) Then
            DtpFecIni.Value = CDate(DFecha)
        Else
            MsgInfoCampoObligatorio(Label4.Text & " no valida", CboDia)
        End If

    End Sub

    Private Sub DtpFechaFin()
        Dim DFecha As String = CboDia1.Text + "/" + CboMes1.SelectedValue.ToString + "/" + CboAnio1.Text

        If DateTime.TryParse(DFecha, dateValue) Then
            DtpFecFin.Value = CDate(DFecha)
        Else
            MsgInfoCampoObligatorio(Label4.Text & " no valida", CboDia)
        End If

    End Sub

    Private Sub FormMaCampana_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        REM Utilizando teclado 
        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert)) 'insert
                BtnAdd_Click(BtnAdd, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Delete)) 'suprimir
                BtnQuitar_Click(BtnQuitar, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4)) 'save
                C1CmdGrabar_Click(C1CmdGrabar, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F6)) 'new
                C1CmdNuevo_Click(C1CmdNuevo, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F7)) 'edit
                C1CmdEdit_Click(C1CmdEdit, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F8)) 'cancel
                c1CmdCancel_Click(C1CmdCancel, Nothing)

            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape)) 'salir
                C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select
    End Sub

    Private Sub FormMaCampana_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        FormatGrilla(Table1, Me, True)
        FormatGrilla(Table2, Me, True)
        REM estado de los botones
        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False)

        'Meses
        LlenaDataCombo(CboMes, ObjConst.Get_Constante("C", CLng(CboMes.Tag)), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboMes1, ObjConst.Get_Constante("C", CLng(CboMes1.Tag)), "nConValor", "cConDescripcion")
        'Años
        LlenaDataCombo(CboAnio, ObjConst.Get_Constante("C", CLng(CboAnio.Tag)), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboAnio1, ObjConst.Get_Constante("C", CLng(CboAnio1.Tag)), "nConValor", "cConDescripcion")

        ListarCampanaVigente()

        CboDia.SelectedIndex = 0
        CboDia1.SelectedIndex = 0

    End Sub

    Private Sub CboMes_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboMes.SelectionChangeCommitted
        DtpFechaInicio()
    End Sub

    Private Sub CboAnio_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboAnio.SelectionChangeCommitted
        DtpFechaInicio()
    End Sub

    Private Sub CboDia_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboDia.SelectionChangeCommitted
        DtpFechaInicio()
    End Sub

    Private Sub CboMes1_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboMes1.SelectionChangeCommitted
        DtpFechaFin()
    End Sub

    Private Sub CboAnio1_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CboAnio1.SelectionChangeCommitted
        DtpFechaFin()
    End Sub

    Private Sub CboDia1_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboDia1.SelectionChangeCommitted
        DtpFechaFin()
    End Sub

    Private Sub C1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevo.Click

        nAccionBotones = nAccionButton.nAccionNuevo

        nFlag = 0  'Agregando
        GeneraNewIdCampana()

        CboDia.Text = Date.Now.Day.ToString
        CboDia1.Text = Date.Now.Day.ToString

        CboAnio.Text = Year(CDate(dFechaSistema))
        CboAnio1.Text = Year(CDate(dFechaSistema))

        CboMes.SelectedValue = Date.Now.Month
        CboMes1.SelectedValue = Date.Now.Month

        If Table1.RowCount > 0 Then EliminarRowsDgView(Table1)

        TxtDescrp.Text = vbNullString

        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GroupBox1, True)

        TxtDescrp.Focus()

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCancel.Click

        EstadoCmdLink(C1CmdNuevo, True, C1CmdGrabar, False, C1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GroupBox1, False)
        nAccionBotones = 0

    End Sub

    Private Sub Combobox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CboDia.KeyPress, CboDia1.KeyPress, CboMes.KeyPress, CboMes1.KeyPress, CboAnio.KeyPress, CboAnio1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtDescrp_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescrp.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click

        FormServicios = 0
        FormFiltroServicios.ShowDialog()

        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerCosto", Table1), True)

        Table1.Refresh()

    End Sub

    Private Sub Table1_CellEndEdit(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellEndEdit

        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerCosto", Table1), True)

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

        ' obtener indice de la columna   
        Dim columna As Integer = Table1.CurrentCell.ColumnIndex

        ' comprobar si la celda en edición corresponde a la columna 1 o 3   
        If columna = 7 Then ' Precio

            ' Obtener caracter   
            Dim caracter As Char = e.KeyChar

            ' comprobar si es un número con isNumber, si es el backspace, si el caracter   
            ' es el separador decimal, y que no contiene ya el separador  
            If (Char.IsNumber(caracter)) Or _
                        (caracter = ChrW(Keys.Back)) Or _
                        (caracter = ".") And _
                        (Me.Text.Contains(".") = False) Then


                e.Handled = False
            Else
                e.Handled = True
            End If

        End If

    End Sub

    Private Sub C1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGrabar.Click

        Try
            Dim Resultado As Boolean
            Dim ResultadoDet As Boolean

            Using scope As New TransactionScope

                Req_Campana.nIntCamp = CLng(LblnIntCamp.Text)
                Req_Campana.cPerJurCodigo = StrcPerJuridica
                Req_Campana.cNombreCamp = Trim(TxtDescrp.Text)
                Req_Campana.dFecIniCamp = DtpFecIni.Value
                Req_Campana.dFecFinCamp = DtpFecFin.Value
                Req_Campana.nTCostoCamp = FormatNumber(LblTotalPago.Text, True)
                Req_Campana.cPerUseCodigo = StrUser


                REM Insert CAB
                If nAccionBotones = nAccionButton.nAccionNuevo Then
                    Resultado = Obj_Campana.Ins_Campana(Req_Campana)
                Else
                    'editando
                    Resultado = Obj_Campana.Upd_Campana(Req_Campana)
                End If

                'Guardando detalle campaña
                With Table1
                    For Each row As DataGridViewRow In .Rows
                        Req_Campana.nCtaCteSerCodigo = CLng(row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                        Req_Campana.nCtaCteCosto = FormatNumber(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value, True)
                        Req_Campana.cIntJerarquia = row.Cells(GrillaServicios.ColcCodGrupo).Value.ToString
                        Req_Campana.nFlag = CLng(row.Cells(GrillaServicios.ColnFlag).Value)

                        If nAccionBotones = nAccionButton.nAccionNuevo Then
                            ResultadoDet = Obj_Campana.Ins_DetalleCampana(Req_Campana)
                        Else
                            'editando
                            ResultadoDet = Obj_Campana.Upd_DetalleCampana(Req_Campana)
                        End If
                    Next
                End With

                If Resultado And ResultadoDet Then
                    'termina todo OK
                    ListarCampanaVigente()
                    scope.Complete()
                    MessageBox.Show("Operación se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call c1CmdCancel_Click(C1CmdCancel, Nothing)
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Table2_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table2.CellDoubleClick
        Call C1CmdEdit_Click(C1CmdEdit, Nothing)
    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click
        Try
            If Table2.RowCount = 0 Then Exit Sub

            'determinando acccion
            nAccionBotones = nAccionButton.nAccionEdit

            With Table2
                If Not .CurrentCell Is Nothing Then
                    If .RowCount > 0 Then
                        LblnIntCamp.Text = .Item(GrillaListVigencia.ColnIntCamp, .CurrentRow.Index).Value
                        TxtDescrp.Text = .Item(GrillaListVigencia.ColcNombreCamp, .CurrentRow.Index).Value.ToString
                        DtpFecIni.Value = CDate(.Item(GrillaListVigencia.ColdFecIniCamp, .CurrentRow.Index).Value)
                        'Llenando Combox Dia, Mes, Año
                        CboDia.Text = DtpFecIni.Value.Day
                        CboMes.SelectedValue = DtpFecIni.Value.Month
                        CboAnio.Text = DtpFecIni.Value.Year.ToString
                        DtpFecFin.Value = CDate(.Item(GrillaListVigencia.ColdFecFinCamp, .CurrentRow.Index).Value)
                        'Llenando Combox Dia1, Mes1, Año1
                        CboDia1.Text = DtpFecFin.Value.Day
                        CboMes1.SelectedValue = DtpFecFin.Value.Month
                        CboAnio1.Text = DtpFecFin.Value.Year.ToString

                        'Recuperando detalle
                        Dim Objeto As New BE_ReqCampana
                        Dim Servicio As New BL_Campana
                        Dim dt As New DataTable
                        Dim nPos As Integer

                        Objeto.cPerJurCodigo = StrcPerJuridica
                        Objeto.nIntCamp = CInt(LblnIntCamp.Text)

                        dt = Servicio.Get_List_Campana_Detalle(Objeto)
                        'Leyendo un DataTable
                        If dt.Rows.Count > 0 Then
                            Dim row As DataRow

                            EliminarRowsDgView(Table1)

                            For Each row In dt.Rows
                                With Table1
                                    nPos = .RowCount()
                                    .Rows.Add()
                                    .Item(GrillaServicios.ColcPerJurCodigo, nPos).Value = CStr(row("cPerJurCodigo").ToString)
                                    .Item(GrillaServicios.ColnCtaCteSerCodigo, nPos).Value = CInt(row("nCtaCteSerCodigo").ToString)
                                    .Item(GrillaServicios.ColcCodGrupo, nPos).Value = CStr(row("cCodGrupo").ToString)
                                    .Item(GrillaServicios.ColcCtaCteSerJerarquia, nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
                                    .Item(GrillaServicios.ColcCtaCteSerKeyWord, nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                                    .Item(GrillaServicios.ColnMonCodigo, nPos).Value = CInt(row("nMonCodigo").ToString)
                                    .Item(GrillaServicios.ColnIntCodigo, nPos).Value = CInt(row("nIntCodigo").ToString)
                                    .Item(GrillaServicios.ColnCtaCteSerCosto, nPos).Value = CDbl(row("nCtaCteSerCosto").ToString)
                                    .Item(GrillaServicios.ColnFlag, nPos).Value = CDbl(row("nFlag").ToString)
                                End With

                            Next
                        End If

                        Table1.PerformLayout()
                        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerCosto", Table1), True)

                        TabControl1.SelectedIndex = 0 'Add
                        EstadoCmdLink(C1CmdNuevo, False, C1CmdGrabar, True, C1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, True, GroupBox1, True)

                    End If

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuitar.Click

        If Table1.RowCount = 0 Then Exit Sub

        Try
            With Table1
                Dim Servicio As New BL_Campana
                Select CInt(.Item(GrillaServicios.ColnFlag, .CurrentRow.Index).Value)
                    Case 0, 9
                        'Eliminar de BD
                        Servicio.Del_DetalleCampana_by_nIntCamp_cPerJurCodigo_nCtaCteSerCodigo(CInt(LblnIntCamp.Text), StrcPerJuridica, CInt(.Rows(.CurrentRow.Index).Cells(GrillaServicios.ColnCtaCteSerCodigo).Value))
                        Call EliminaRowSeleccionada(Table1)
                    Case 2 'Perfil detectado
                        MsgBox("No Puede eliminar un Item porque pertenece un Perfil.", vbInformation, "Validando..")
                        If MsgBox("¿Desea quitar todos los Items del Perfil.?", vbQuestion + vbYesNo, "Validando") = MsgBoxResult.Yes Then

                            Dim nFila As Integer
                            '1 es la condicion que indica Items de campaña.
                            For nFila = .Rows.Count - 1 To 0 Step -1
                                If .Rows(nFila).Cells(GrillaServicios.ColnFlag).Value = 2 Then
                                    If Not (Table1.Rows(nFila).IsNewRow) Then
                                        'Call EliminarRowsDg_for_Condicion(Table1, "nFlag", 1)
                                        Servicio.Del_DetalleCampana_by_nIntCamp_cPerJurCodigo_nCtaCteSerCodigo(CInt(LblnIntCamp.Text), StrcPerJuridica, .Rows(nFila).Cells(GrillaServicios.ColnCtaCteSerCodigo).Value)
                                        .Rows.Remove(.Rows(nFila))
                                    End If
                                End If
                            Next

                        End If
                End Select
            End With

            LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerCosto", Table1), True)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub C1CalcPrecio_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CalcPrecio.Click

        If Len(LblTotalPago.Text) = 0 Then Exit Sub

        If CDbl(TxtPrecioPromo.Text) <= CDbl(LblTotalPago.Text) Then
            With Table1
                For Renglones As Integer = 0 To .RowCount - 1
                    .Item("nCtaCteSerCosto", Renglones).Value = Format((TxtPrecioPromo.Text * .Item("nCtaCteSerCosto", Renglones).Value) / LblTotalPago.Text, "#,###.00")
                Next
            End With
        Else
            MessageBox.Show("Precio promoción debe ser menor al total a aplicar.")
        End If

        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerCosto", Table1), True)

    End Sub

End Class