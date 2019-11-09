Option Explicit On

Imports Integration.BE.Campana
Imports Integration.BE.CtasCtes
Imports Integration.BL.BL_CtaCteListaServicio
Imports Integration.BL
Imports Integration.BL.BL_Campana
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL.BL_CtasCtesMedica
Imports Integration.BE.PerUsuGruAcc

Public Class FormPrcSQLPrecio


    Dim mdtbColourMap As DataTable = Nothing

    Dim Req_Campana As New BE_ReqCampana
    Dim Obj_Campana As New BL_Campana

    Enum GrillaServicios
        ColnKey = 0
        ColcPerJurCodigo = 1
        ColnCtaCteSerCodigo = 2
        ColcIntJerarquia = 3
        ColcCtaCteSerJerarquia = 4
        ColcCtaCteSerKeyWord = 5
        ColnMonCodigo = 6
        ColnIntCodigo = 7
        ColnCtaCteSerCosto = 8
        ColnFlag = 9
    End Enum

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Select Case keyData
            Case Keys.F1
                TabControl1.SelectedIndex = 0
                Return True
            Case Keys.F2
                TabControl1.SelectedIndex = 1
                Return True
            Case Keys.F3
                TabControl1.SelectedIndex = 2
                Return True
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

    Private Sub FormPrcSQLPrecio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            Req_Campana.cPerJurCodigo = StrcPerJuridica

            Table1.Enabled = True
            FormatGrilla(Table1, Me, False, 25, False, DataGridViewSelectionMode.CellSelect)

            'LstBoxCampana.Items.Clear()
            'LlenaListBox(LstBoxCampana, Obj_Campana.Get_List_Campana(Req_Campana), "nIntCamp", "cNombreCamp")

            TabControl1.TabPages.Remove(TabPage4)

            'If LstBoxCampana.Items.Count > 0 And FormServicios = 1 Then
            '    LstBoxCampana.Enabled = True
            '    TabControl1.TabPages.Add(TabPage4)
            '    Me.Width = 949 '901
            'End If
            REM LlenaDataCombo(CboCampana, Obj_Campana.Get_List_Campana(Req_Campana), "nIntCamp", "cNombreCamp")

            Me.StartPosition = FormStartPosition.CenterScreen

            Dim ObjPerJur As New BE_Req_PerUsuGruAcc
            Dim ObjPerJurProc As New BL_PerUsuGruAcc

            'Clase según Sede o Empresa
            ObjPerJur.cPerCodigo = StrcPerJuridica
            ObjPerJur.cIntJerarquia = ""
            ObjPerJur.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
            ObjPerJur.nSisGruTipo = 1004
            ObjPerJur.nObjTipo = 1014
            ObjPerJur.nIntTipo = 1000
            ObjPerJur.nObjCodigo = -1
            LlenaDataCombo(CboClase, ObjPerJurProc.Get_PerUsuGruAcc_Get_Interface(ObjPerJur), "nObjCodigo", "cIntDescripcion")
            'CboClase_SelectionChangeCommitted(CboClase, Nothing)

            'If TabControl1.SelectedTab.Name = "TabPage1" Then TxtCodigo.Focus()

            'Perfiles según Sede o Empresa
            ObjPerJur.cPerCodigo = StrcPerJuridica
            ObjPerJur.cIntJerarquia = ""
            ObjPerJur.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
            ObjPerJur.nSisGruTipo = 1004
            ObjPerJur.nObjTipo = 1060
            ObjPerJur.nIntTipo = 1000
            ObjPerJur.nObjCodigo = -1
            LlenaDataCombo(CboPerfil, ObjPerJurProc.Get_PerUsuGruAcc_Get_Interface(ObjPerJur), "nObjCodigo", "cIntDescripcion")

            'Carga de Perfiles (Grupo de Examenes)
            'LlenaDataCombo(CboPerfil, ObjInterface.Get_Interface(CLng(TokenByKey(CboPerfil.Tag, "nIntClase")), CLng(TokenByKey(CboPerfil.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")

            Me.ActiveControl = TxtCodigo
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FiltraServicio(ByVal Valor As String, Optional ByVal Flag As String = "C")
        Try
            Dim dt As New DataTable
            Dim nPos As Integer

            Dim Req_ListServicio As New BE_ReqCtaCtePrecioServicio
            Dim Obj_ListServicio As New BL_CtaCtePrecioServicio

            'Req_ListServicio.cPerJurCodigo = StrcPerJuridica
            'Req_ListServicio.nIntCodigo = IIf(FormServicios = 1, CLng(TokenByKey(StrPasaValores, "nIntCodigo")), 1001) REM Recuperando Tipo de Atencion para Obtener el Precio de CtaCteServicios por cPerCodigo.
            'Req_ListServicio.cCtaCteSerKeyWord = Valor 'Trim(TxtCaracter.Text)
            'Req_ListServicio.cIntJerarquia = CboClase.SelectedValue.ToString 'Microsoft.VisualBasic.Left(CboClase.Text, 5)
            'Req_ListServicio.cPerCodigo = IIf(FormServicios = 1, TokenByKey(StrPasaValores, "cPerCodigo"), "")
            'Req_ListServicio.Flag = Flag '"C"

            Req_ListServicio.cPerJurCodigo = StrcPerJuridica
            Req_ListServicio.nIntCodigo = IIf(FormServicios = 1, CLng(TokenByKey(StrPasaValores, "nIntCodigo")), CInt(TipoAtencion.Particular)) REM Recuperando Tipo de Atencion para Obtener el Precio de CtaCteServicios por cPerCodigo.
            Req_ListServicio.cCtaCteSerKeyWord = Valor 'Trim(TxtCaracter.Text)
            Req_ListServicio.cIntJerarquia = CboClase.SelectedValue.ToString '  Microsoft.VisualBasic.Left(CboClase.Text, 5)
            'Req_ListServicio.cPerCodigo = IIf(FormServicios = 1, TokenByKey(StrPasaValores, "cPerCodigo"), "")
            If FormServicios = 1 Then
                If CInt(TokenByKey(StrPasaValores, "nIntCodigo")) = CInt(TipoAtencion.Particular) Then
                    Req_ListServicio.cPerCodigo = TokenByKey(StrPasaValores, "cPerCodigo") 'Se cambio para Descuento a Personal de Medica  ""
                Else
                    Req_ListServicio.cPerCodigo = TokenByKey(StrPasaValores, "cPerJurCodigo")
                End If
            Else
                Req_ListServicio.cPerCodigo = ""
            End If
            Req_ListServicio.Flag = Flag '"C"


            'Table1.DataSource = Obj_ListServicio.Get_List_CtaCteServicio(Req_ListServicio)
            dt = Obj_ListServicio.Get_List_CtaCteServicio(Req_ListServicio)

            'Limpiando la Grilla antes de mostrar el resultado
            EliminarRowsDgView(Table1)

            'Leyendo un DataTable
            If dt.Rows.Count > 0 Then
                Dim row As DataRow
                'Llenando DataGridView
                For Each row In dt.Rows
                    With Table1
                        nPos = .RowCount()
                        .Rows.Add()
                        .Item("nKey", nPos).Value = False '--Todos activos "CheckBox"
                        .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                        .Item("nCtaCteSerCodigo", nPos).Value = CInt(row("nCtaCteSerCodigo").ToString)
                        .Item("cIntJerarquia", nPos).Value = CStr(row("cIntJerarquia").ToString)
                        .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
                        .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                        .Item("nMonCodigo", nPos).Value = CInt(row("nMonCodigo").ToString)
                        .Item("nIntCodigo", nPos).Value = CInt(row("nIntCodigo").ToString)
                        .Item("nCtaCteSerCosto", nPos).Value = CDbl(row("nCtaCteSerCosto").ToString)
                        .Item("nFlag", nPos).Value = 0 'Indica que es Muestra seleccionada absoluta
                    End With

                Next

            End If

            Table1.PerformLayout()
            Table1.Enabled = True

            ''Define the search terms and color for each
            'mdtbColourMap = New DataTable
            'mdtbColourMap.Columns.Add(New DataColumn("SearchTerm", GetType(String)))
            'mdtbColourMap.Columns.Add(New DataColumn("TextColor", GetType(Brush)))
            'mdtbColourMap.Rows.Add("_", Drawing.Brushes.Red) 'Green)
            ''mdtbColourMap.Rows.Add("+", Drawing.Brushes.Red)
            ''mdtbColourMap.Rows.Add("-", Drawing.Brushes.Purple)
            'mdtbColourMap.Rows.Add("(", Drawing.Brushes.Red)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FormFiltroServicios_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                Table1.Enabled = False
                'Call BtnSeleccionar_Click(BtnSeleccionar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                Call BtnCancelar_Click(BtnCancelar, Nothing)
        End Select

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub


    'Private Sub LstBoxCampana_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles LstBoxCampana.MouseDoubleClick

    '    Try
    '        Dim nPos As Integer
    '        Dim dt As New DataTable

    '        Req_Campana.cPerJurCodigo = StrcPerJuridica
    '        Req_Campana.nIntCamp = CLng(LstBoxCampana.SelectedValue)

    '        'Table1.DataSource = Obj_Campana.Get_Servicios_for_nIntCamp(Req_Campana)
    '        dt = Obj_Campana.Get_Servicios_for_nIntCamp(Req_Campana)

    '        EliminarRowsDgView(Table1)

    '        'Leyendo un DataTable
    '        If dt.Rows.Count > 0 Then
    '            Dim row As DataRow

    '            For Each row In dt.Rows
    '                With Table1
    '                    nPos = .RowCount()
    '                    .Rows.Add()
    '                    .Item("nKey", nPos).Value = True '--Todos activos "CheckBox"
    '                    .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
    '                    .Item("nCtaCteSerCodigo", nPos).Value = CInt(row("nCtaCteSerCodigo").ToString)
    '                    .Item("cIntJerarquia", nPos).Value = CStr(row("cIntJerarquia").ToString)
    '                    .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
    '                    .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
    '                    .Item("nMonCodigo", nPos).Value = CInt(row("nMonCodigo").ToString)
    '                    .Item("nIntCodigo", nPos).Value = CInt(row("nIntCodigo").ToString)
    '                    .Item("nCtaCteSerCosto", nPos).Value = CDbl(row("nCtaCteSerCosto").ToString)
    '                    .Item("nFlag", nPos).Value = 1 'Indica que es Muestra seleccionada absoluta
    '                End With
    '            Next
    '        End If

    '        Table1.PerformLayout()
    '        Table1.Enabled = False
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        FiltraServicio(TxtCodigo.Text)
    End Sub

    Private Sub CboClase_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboClase.SelectionChangeCommitted
        FiltraServicio("", "G")
    End Sub

    Private Sub TxtCaracter_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtCaracter.TextChanged
        FiltraServicio(TxtCaracter.Text, "D")
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        EliminarRowsDgView(Table1)
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                TxtCodigo.Text = vbNullString : TxtCodigo.Focus()
            Case 2
                TxtCaracter.Text = vbNullString : TxtCaracter.Focus()
            Case 1
                CboClase_SelectionChangeCommitted(CboClase, Nothing)
                CboClase.Focus()
        End Select
    End Sub

    Private Sub CboPerfil_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboPerfil.SelectionChangeCommitted

        '-----------------
        'Carga Perfil
        '-----------------
        Dim nPos As Integer = 0
        Dim Servicio As New BLPerfilServicio
        Dim dt As New DataTable

        EliminarRowsDgView(Table1)

        dt = Servicio.Get_PerfilServicio(StrcPerJuridica, CInt(CboPerfil.SelectedValue), "B")
        'Datos enlazados no es factible para despues agregar mas items
        'Table1.DataSource = dt

        'Leyendo un DataTable
        If dt.Rows.Count > 0 Then
            Dim row As DataRow

            For Each row In dt.Rows
                With Table1
                    nPos = .RowCount()
                    .Rows.Add()
                    .Item("nKey", nPos).Value = True '--Todos activos "CheckBox"
                    .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                    .Item("nCtaCteSerCodigo", nPos).Value = CInt(row("nCtaCteSerCodigo").ToString)
                    .Item("cIntJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
                    .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
                    .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                    .Item("nMonCodigo", nPos).Value = CInt(row("nMonCodigo").ToString)
                    .Item("nIntCodigo", nPos).Value = CInt(row("nIntCodigo").ToString)
                    .Item("nCtaCteSerCosto", nPos).Value = CDbl(row("nCtaCteSerCosto").ToString)
                    .Item("nFlag", nPos).Value = 2 'Indica a Perfil 
                End With

            Next

        End If

        Table1.PerformLayout()
        Table1.Enabled = False
        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerCosto", Table1), True)

    End Sub

    ' para editar el Check de Table1
    Private Sub Table1_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellContentClick
        If e.ColumnIndex = Me.Table1.Columns.Item("nKey").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.Table1.Rows(e.RowIndex).Cells("nKey")
            chkCell.Value = Not chkCell.Value
        End If
        'MsgBox("Estado: " & EstadoCheck(e.RowIndex))
    End Sub

    Private Function EstadoCheck(ByVal filaposicion As Integer) As Boolean

        Return Me.Table1.Rows(filaposicion).Cells("nKey").Value

    End Function

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Table1.CurrentCellDirtyStateChanged
        If Table1.IsCurrentCellDirty Then
            Table1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
        Dispose()
    End Sub
End Class