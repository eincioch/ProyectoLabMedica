Option Explicit On

Imports Integration
Imports Integration.BE
Imports Integration.BE.CtasCtes
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL.BL_SeuConAssetModelo
Imports System.Data
Imports System.Data.SqlClient
Imports System.Transactions

Public Class FormMaServiciosComponentes

    Private dataSetArbol As DataSet
    Dim nFlag As Integer
    Dim KeyNodecIntNombre As Long
    Dim cPerJuridicaGeneral As String = "1000098770"

    Function ValidaCamposObligatorios() As Boolean

        Dim NroKey As Integer = 0

        ValidaCamposObligatorios = False

        If LblCodigo.Text = vbNullString Then MsgInfoCampoObligatorio(Label4.Text, TreeViewC) : Exit Function
        If LblJerarquia.Text = vbNullString Then MsgInfoCampoObligatorio(Label5.Text, TreeViewC) : Exit Function
        If CboUnidad.SelectedIndex = -1 Then MsgInfoCampoObligatorio(Label7.Text, CboUnidad) : Exit Function

        'If CboComponente.SelectedIndex = -1 Then MsgInfoCampoObligatorio(Label9.Text, CboComponente) : Exit Function

        ValidaCamposObligatorios = True

    End Function

    Private Sub CargarTreeview()

        '
        TreeViewC.Nodes.Clear()
        TreeViewC.BeginUpdate()

        Dim Ds As New DataSet

        Dim NodeForm As New TreeNode("TIPOS DE SERVICIOS")
        TreeViewC.Nodes.Add(NodeForm)

        Try
            '1014 '//Servicio
            Ds.Tables.Add(ObjInterface.Get_Interface(1014, 1000, "S"))
            Ds.Tables(0).TableName = "Interface"

            Call CrearNodosDelPadre(0, NodeForm, TreeViewC, Ds)

            ' habilita la actualización en pantalla del control TreeView
            TreeViewC.EndUpdate()

            ' modifico la propiedad Sorted a True para que los nodos estén ordenados
            TreeViewC.Sorted = True
            TreeViewC.ExpandAll()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub FormMaServiciosComponentes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        SplitContainer2.Panel2.Visible = False

        LlenaDataCombo(cboTipoAtencion, ObjInterface.Get_Interface(CLng(TokenByKey(cboTipoAtencion.Tag, "nIntClase")), CLng(TokenByKey(cboTipoAtencion.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")

        'Llenando combox
        LlenaDataCombo(CboUnidad, ObjConst.Get_Constante("C", CLng(TokenByKey(CboUnidad.Tag, "nConCodigo"))), "nConValor", "cConDescripcion")

        'LlenaDataCombo(CboComponente, ObjInterface.Get_Interface(CLng(TokenByKey(CboComponente.Tag, "nIntClase")), CLng(TokenByKey(CboComponente.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")
        'CboComponente.Enabled = True 'Inicializamos

        FormatGrilla(Table1, Me, False, 25, False, DataGridViewSelectionMode.CellSelect)

        Call CargarTreeview()

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)

        '
    End Sub

    Private Sub TreeViewC_AfterCollapse(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewC.AfterCollapse

        Select Case e.Node.Level
            Case 1
                e.Node.ImageKey = "folder"
                e.Node.SelectedImageKey = "folder"
                Return
            Case 2
                e.Node.ImageKey = "folder_add"
                e.Node.SelectedImageKey = "folder_add"
                Return
        End Select

    End Sub

    Private Sub TreeViewC_AfterExpand(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewC.AfterExpand

        Select Case e.Node.Level
            Case 1, 2
                e.Node.ImageKey = "folder_add"
                e.Node.SelectedImageKey = "folder_add"
                Return
        End Select

    End Sub

    Private Sub TreeView_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewC.AfterSelect
        If TreeViewC.SelectedNode Is Nothing Or TreeViewC.SelectedNode.Tag = "" Then Exit Sub

        If TreeViewC.SelectedNode.Tag > 0 Then
            SplitContainer2.Panel1.Enabled = True
            GrpBox.Visible = True
        Else
            SplitContainer2.Panel1.Enabled = False
            GrpBox.Visible = False
        End If

        TreeViewC.FullRowSelect = True

        Dim Request As New CtasCtes.BE_ReqCtaCteServBusca
        Dim ObjCtaCteServ As New BL_CtaCtaServicio

        Request.nCtaCteSerCodigo = TreeViewC.SelectedNode.Name
        Request.cPerJurCodigo = StrcPerJuridica 'EMPRESA
        Request.nCtaCteTipoCta = cboTipoAtencion.SelectedValue.ToString

        dtGenerico = ObjCtaCteServ.Get_CtaCteServicio(Request)

        Dim dtCmp = ObjCtaCteServ.Get_CtaCteServicioComponente(Request)

        EliminarRowsDgView(Table1)
        Dim nPos As Integer = 0

        If dtCmp.Rows.Count > 0 Then
            Dim row As DataRow

            Table1.DataSource = Nothing

            For Each row In dtCmp.Rows
                With Table1
                    nPos = .RowCount()
                    .Rows.Add()
                    .Item("nCtaCteSerCodigo", nPos).Value = CStr(row("nCtaCteSerCodigo").ToString)
                    .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                    .Item("nCtaCteSerCmpCodigo", nPos).Value = CStr(row("nCtaCteSerCmpCodigo").ToString)
                    .Item("cIntDescripcion", nPos).Value = CStr(row("cIntDescripcion").ToString)
                    .Item("nCtaCteSerCmpUndDestino", nPos).Value = CStr(row("nCtaCteSerCmpUndDestino").ToString)
                    .Item("cUnidad", nPos).Value = row("cUnidad").ToString
                    .Item("nCtaCteSerCmpCantidad", nPos).Value = CLng(row("nCtaCteSerCmpCantidad").ToString)
                    .Item("nCtaCteSerCmpEstado", nPos).Value = CLng(row("nCtaCteSerCmpEstado").ToString)
                    .Item("cEstado", nPos).Value = row("cEstado").ToString
                End With

            Next
        End If

        'Table1.DataSource = dtCmp

        If dtGenerico.Rows.Count > 0 Then
            With dtGenerico
                '//recuperando valores
                LblCodigo.Text = .Rows(0)("nCtaCteSerCodigo")
                LblJerarquia.Text = .Rows(0)("cCtaCteSerJerarquia") ' cIntDescripcion antes
                LblDescr.Text = .Rows(0)("cIntDescripcion")
                CboUnidad.SelectedValue = .Rows(0)("nMonCodigo")

                'CboComponente.SelectedValue = Convert.ToInt32(.Rows(0)("nCodEnvase"))
                'TxtCantidad.Text = .Rows(0)("cVolumMinimo").ToString
            End With

        Else
            LblCodigo.Text = vbNullString : LblJerarquia.Text = vbNullString : LblDescr.Text = vbNullString

            CboUnidad.SelectedValue = -1
        End If

        REM muestra el listado de precios
        dtGenerico.Dispose()
        dtCmp.Dispose()

    End Sub

    Private Sub TreeViewC_BeforeCollapse(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles TreeViewC.BeforeCollapse
        If (e.Node.Level = 0) Then
            e.Cancel = True
        End If
    End Sub

    'Private Sub ToolStripMnuPopupAddS_Click(sender As Object, e As System.EventArgs) Handles ToolStripMnuPopupAddS.Click

    '    'validando si no hay nada seleccionado
    '    If TreeViewC.SelectedNode Is Nothing Then Exit Sub

    '    nFlag = 0 'Agregando

    '    If TreeViewC.SelectedNode.Tag = "" Then 'para agregar padres
    '        KeyNodecIntNombre = 0
    '    Else
    '        'Obtengo el Key de árbol Padre el hijo seleccionado
    '        If TreeViewC.SelectedNode.Tag = 0 Then
    '            KeyNodecIntNombre = TreeViewC.SelectedNode.Name 'ToolTipText 'para agregar un primer Hijos
    '            Label13.Text = TreeViewC.SelectedNode.ToolTipText & " - " & TreeViewC.SelectedNode.Text

    '        Else
    '            KeyNodecIntNombre = TreeViewC.SelectedNode.Tag 'para agregar mas hijos
    '            Label13.Text = TreeViewC.SelectedNode.Tag & " - " & TreeViewC.SelectedNode.Parent.Text

    '        End If
    '        TxtcIntSubJerarquia.Visible = True : TxtcIntJerarquia.ReadOnly = True
    '    End If

    '    TreeViewC.HideSelection = True
    '    TreeViewC.Enabled = False

    '    'Obtengo correlativo sgte cIntJerarquia
    '    RequestInterface.nIntClase = TokenByKey(TxtJerarquia.Tag, "nIntClase")
    '    RequestInterface.nIntTipo = TokenByKey(TxtJerarquia.Tag, "nIntTipo")
    '    TxtJerarquia.Text = ObjInterface.Get_NewIdcIntJerarquia(RequestInterface)
    '    '
    '    TxtJerarquia.ReadOnly = True
    '    TxtcIntJerarquia.Text = vbNullString : TxtcIntSubJerarquia.Text = vbNullString : TxtDesc.Text = vbNullString
    '    TxtcIntJerarquia.Text = Microsoft.VisualBasic.Left(TreeViewC.SelectedNode.ToolTipText, 3)
    '    TxtcIntSubJerarquia.Text = Microsoft.VisualBasic.Right(TreeViewC.SelectedNode.ToolTipText, 3)

    '    If TxtcIntSubJerarquia.Visible Then
    '        TxtcIntSubJerarquia.Focus()
    '    Else
    '        TxtcIntJerarquia.Focus()
    '    End If

    'End Sub

    'Private Sub ToolStripMnuPopupEditS_Click(sender As Object, e As System.EventArgs) Handles ToolStripMnuPopupEditS.Click

    '    nFlag = 1 'modificando
    '    SplitContainer2.Panel2.Visible = True : TxtJerarquia.Enabled = False : Label1.Text = "Modificando Servicio.." : SplitContainer2.Panel1.Enabled = False

    '    If Len(TreeViewC.SelectedNode.ToolTipText) = 5 Then 'para agregar padres
    '        TxtcIntSubJerarquia.Visible = False
    '    Else
    '        TxtcIntSubJerarquia.Visible = True
    '    End If

    '    TxtJerarquia.Text = TreeViewC.SelectedNode.Name 'ToolTipText ' Microsoft.VisualBasic.Left(TreeViewC.SelectedNode.Text, 4)
    '    KeyNodecIntNombre = TreeViewC.SelectedNode.Tag

    '    TxtcIntJerarquia.Text = Microsoft.VisualBasic.Left(TreeViewC.SelectedNode.ToolTipText, 3)
    '    TxtcIntSubJerarquia.Text = Microsoft.VisualBasic.Right(TreeViewC.SelectedNode.ToolTipText, 3)

    '    TxtDesc.Text = TreeViewC.SelectedNode.Text 'Microsoft.VisualBasic.Mid(TreeViewC.SelectedNode.Text, 8, 250)
    '    If TxtcIntSubJerarquia.Visible Then
    '        TxtcIntSubJerarquia.Focus()
    '    Else
    '        TxtcIntJerarquia.Focus()
    '    End If

    'End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs)
        SplitContainer2.Panel2.Visible = False
        SplitContainer2.Panel1.Enabled = True
        TreeViewC.Enabled = True
        TreeViewC.Focus()
    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdNuevo.Click

        'Aqui es donde valido si es cabezera o Item
        If TreeViewC.SelectedNode.Tag = vbNullString Or TreeViewC.SelectedNode.Tag = 0 Then Exit Sub

        If Table1.Rows.Count > 0 Then MessageBox.Show("Servicio ya tiene componentes.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub

        TreeViewC.Enabled = False
        nFlag = 0

        'LimpiarTextBox(Me)
        'LimpiarTextBoxGroup(GrpBox)
        'LimpiarTextBoxTabs(TabPrecio)

        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBox, True)

        LblCodigo.Text = TreeViewC.SelectedNode.Name    'nIntCodigo

        LblJerarquia.Text = TreeViewC.SelectedNode.ToolTipText
        LblDescr.Text = TreeViewC.SelectedNode.Text

        CboUnidad.SelectedValue = 1
    End Sub

    Private Sub c1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdGrabar.Click

        Try

            If ValidaCamposObligatorios() Then
                'Capa: Presentacion
                Dim Obj As New CtasCtes.CtaCteListaServicioComponente
                Dim Servicio As New BL.BL_CtaCteListaServicioComponente.BLCtaCteListaServicioComponente
                'Dim Resultado As Boolean
                'Dim ResultadoDet As Boolean
                Dim nRows As Integer = 0

                'If ChckBoxTodo.CheckState = CheckState.Checked Then
                Using scope As New TransactionScope()
                    Obj.nCtaCteSerCodigo = CLng(TreeViewC.SelectedNode.Name)
                    Obj.cPerJurcodigo = cPerJuridicaGeneral
                    Obj.nTipoAtencionCodigo = CInt(cboTipoAtencion.SelectedValue)

                    '-----------
                    'Por Muestra
                    '-----------
                    Dim strXML As String

                    If Table1.RowCount > 0 Then
                        strXML = CreateNodeXML("MisComponentes", "", False)
                        With Table1
                            REM Recorriendo la Grilla
                            For Each row As DataGridViewRow In .Rows
                                Obj.nCtaCteSerCmpCodigo = Convert.ToInt32(row.Cells("nCtaCteSerCmpCodigo").Value)
                                Obj.nCtaCteSerCmpUndDestino = Convert.ToInt32(row.Cells("nCtaCteSerCmpUndDestino").Value)
                                Obj.nCtaCteSerCmpCantidad = Convert.ToDecimal(row.Cells("nCtaCteSerCmpCantidad").Value)
                                Obj.nCtaCteSerCmpEstado = 1

                                strXML = strXML & vbCrLf & CreateNodeXML("RegComponente", "", False)

                                strXML = strXML & vbCrLf & CreateNodeXML("nCtaCteSerCmpCodigo", Obj.nCtaCteSerCmpCodigo.ToString, True)
                                strXML = strXML & vbCrLf & CreateNodeXML("nCtaCteSerCmpUndDestino", Obj.nCtaCteSerCmpUndDestino.ToString, True)
                                strXML = strXML & vbCrLf & CreateNodeXML("nCtaCteSerCmpCantidad", Obj.nCtaCteSerCmpCantidad.ToString, True)

                                strXML = strXML & vbCrLf & "</RegComponente>"

                            Next
                        End With
                        strXML = strXML & vbCrLf & "</MisComponentes>"
                        Obj.strXML = strXML
                        Obj.cPerUsuCodigo = StrUser

                        If Not Servicio.Ins_CtaCteListaServicioComponente_By_XML(Obj) Then Throw New System.Exception("Se encontraron errores.") 'Else ResultadoDet = True

                    End If

                    scope.Complete()

                End Using

                'If Resultado Then
                MessageBox.Show("Operación se realizó con éxito.", "Sistema Médica", MessageBoxButtons.OK, MessageBoxIcon.Information)
                c1CmdCancel_Click(c1CmdCancel, Nothing)

                'Else
                '    MessageBox.Show("Se encontraron errores.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Sub
                'End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        If LblCodigo.Text = vbNullString Then
            MessageBox.Show("Selecciona un item de la grilla para modificar.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        nFlag = 1
        EstadoCmdLink(c1CmdNuevo, False, c1CmdGrabar, True, c1CmdCancel, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBox, True)

        TreeViewC.Enabled = False
    End Sub

    Private Sub c1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdCancel.Click

        EstadoCmdLink(c1CmdNuevo, True, c1CmdGrabar, False, c1CmdCancel, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBox, False)
        TreeViewC.Enabled = True

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Table1_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs)

        If Table1.IsCurrentCellDirty Then
            Table1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        StrPasaValores = vbNullString
        StrPasaValores = "nIntCodigo=" & "6000" & ";" 'pasando que tipo de precio va a utilizar
        StrPasaValores = StrPasaValores & "cPerJurCodigo=" & cPerJuridicaGeneral

        FormServicios = 1 'Seteo que sera para SolAtencion

        FormSQLBienes.ShowDialog()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If LblnCtaCteSerComCodigo.Text <> "" And TxtCantidad.Text <> "" Then
            Dim nPos As Integer

            If BuscaCadenaDgView("nCtaCteSerCmpCodigo", LblnCtaCteSerComCodigo.Text, Table1) Then
                'MessageBox.Show("Componente ya ha sido ingresado en la lista, verifique por favor.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)

                With Table1
                    For Each row As DataGridViewRow In .Rows
                        If CStr(row.Cells("nCtaCteSerCmpCodigo").Value) = LblnCtaCteSerComCodigo.Text Then
                            row.Cells("nCtaCteSerCmpUndDestino").Value = CboUnidad.SelectedValue.ToString
                            row.Cells("cUnidad").Value = CboUnidad.Text
                            row.Cells("nCtaCteSerCmpCantidad").Value = TxtCantidad.Text
                            row.Cells("nCtaCteSerCmpEstado").Value = 1
                            row.Cells("cEstado").Value = "ACTIVO"
                            Exit For
                        End If
                    Next
                End With
            Else
                With Table1
                    nPos = .RowCount()
                    .Rows.Add()
                    .Item("nCtaCteSerCodigo", nPos).Value = LblCodigo.Text
                    .Item("cPerJurCodigo", nPos).Value = cPerJuridicaGeneral
                    .Item("nCtaCteSerCmpCodigo", nPos).Value = LblnCtaCteSerComCodigo.Text
                    .Item("cIntDescripcion", nPos).Value = LblCtaCteSerCompDescripcion.Text
                    .Item("nCtaCteSerCmpUndDestino", nPos).Value = CboUnidad.SelectedValue.ToString
                    .Item("cUnidad", nPos).Value = CboUnidad.Text
                    .Item("nCtaCteSerCmpCantidad", nPos).Value = TxtCantidad.Text
                    .Item("nCtaCteSerCmpEstado", nPos).Value = 1
                    .Item("cEstado", nPos).Value = "ACTIVO"
                End With
            End If

            LblnCtaCteSerComCodigo.Text = ""
            LblCtaCteSerCompDescripcion.Text = ""
            CboUnidad.SelectedValue = 1
            TxtCantidad.Text = ""

        ElseIf LblnCtaCteSerComCodigo.Text = "" Then
            MessageBox.Show("No ha seleccionado ningún componente.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtCantidad.Text = "" Then
            MessageBox.Show("No ha ingresado la cantidad.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click
        Try

            Call EliminaRowSeleccionada(Table1)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Table1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table1.CellContentDoubleClick
        With Table1
            LblnCtaCteSerComCodigo.Text = .Item("nCtaCteSerCmpCodigo", e.RowIndex).Value
            LblCtaCteSerCompDescripcion.Text = .Item("cIntDescripcion", e.RowIndex).Value
            CboUnidad.SelectedValue = .Item("nCtaCteSerCmpUndDestino", e.RowIndex).Value
            CboUnidad.Text = .Item("cUnidad", e.RowIndex).Value
            TxtCantidad.Text = .Item("nCtaCteSerCmpCantidad", e.RowIndex).Value
        End With
    End Sub
End Class