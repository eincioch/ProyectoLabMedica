Option Explicit On

Imports Integration.BE.Persona
Imports Integration.BL
Imports System.Transactions
Imports System.IO
Imports Integration.BL.BL_CtaCteListaServicio
Imports Integration.BE.CtasCtes

Public Class FormMaPorcDsctoEntidades

#Region "Forma Grilla"

    Enum ColumnGrid
        ColcPerJurCodigo = 0
        ColnCtaCteSerCodigo = 1
        ColcIntJerarquia = 2
        ColcCtaCteSerJerarquia = 3
        ColcCtaCteSerKeyWord = 4
        ColnMonCodigo = 5
        ColnIntCodigo = 6
        ColnCtaCteSerCosto = 7
        ColnTipoDscto = 8
        ColnCtaCtenValor = 9
    End Enum

    Private Sub Formato01_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()
            '0
            Dim ColcPerJurCodigo As New DataGridViewTextBoxColumn()
            With ColcPerJurCodigo
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerJurCodigo"
                .HeaderText = "cPerJurCodigo"
                .Name = "cPerJurCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 100
            End With
            .Columns.Add(ColcPerJurCodigo)
            '1
            Dim ColnCtaCteSerCodigo As New DataGridViewTextBoxColumn()
            With ColnCtaCteSerCodigo
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "nCtaCteSerCodigo"
                .Name = "nCtaCteSerCodigo"
                .HeaderText = "nCtaCteSerCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 30
            End With
            .Columns.Add(ColnCtaCteSerCodigo)
            '2
            Dim ColcIntJerarquia As New DataGridViewTextBoxColumn()
            With ColcIntJerarquia
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cIntJerarquia"
                .HeaderText = "cIntJerarquia"
                .Name = "cIntJerarquia"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColcIntJerarquia)
            '3
            Dim ColcCtaCteSerJerarquia As New DataGridViewTextBoxColumn()
            With ColcCtaCteSerJerarquia
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cCtaCteSerJerarquia"
                .Name = "cCtaCteSerJerarquia"
                .HeaderText = "Cod. Laboratorio"
                .ReadOnly = True : .Visible = True
                .Width = 120
            End With
            .Columns.Add(ColcCtaCteSerJerarquia)
            '4
            Dim ColcCtaCteSerKeyWord As New DataGridViewTextBoxColumn()
            With ColcCtaCteSerKeyWord
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cCtaCteSerKeyWord"
                .Name = "cCtaCteSerKeyWord"
                .HeaderText = "Descripción Muestra"
                .ReadOnly = True : .Visible = True
                .Width = 350
            End With
            .Columns.Add(ColcCtaCteSerKeyWord)
            '5
            Dim ColnCtaCteCosto As New DataGridViewTextBoxColumn()
            With ColnCtaCteCosto
                .DefaultCellStyle.Format = "N0"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nMonCodigo"
                .Name = "nMonCodigo"
                .HeaderText = "nMonCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 30
            End With
            .Columns.Add(ColnCtaCteCosto)
            '6
            Dim ColnIntCodigo As New DataGridViewTextBoxColumn()
            With ColnIntCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nIntCodigo"
                .Name = "nIntCodigo"
                .HeaderText = "nIntCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 30
            End With
            .Columns.Add(ColnIntCodigo)
            '7
            Dim ColnCtaCteSerCosto As New DataGridViewTextBoxColumn()
            With ColnCtaCteSerCosto
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nCtaCteSerCosto"
                .Name = "nCtaCteSerCosto"
                .HeaderText = "Precio Actual"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColnCtaCteSerCosto)
            '8
            Dim ColnTipoDscto As New DataGridViewComboBoxColumn()
            With ColnTipoDscto
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "nTipoDscto"
                .Name = "nTipoDscto"
                .HeaderText = "Tipo Dscto."
                .ToolTipText = "Seleccione tipo de Dscto"
                .ReadOnly = False : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColnTipoDscto)
            '9
            Dim ColnCtaCtenValor As New DataGridViewTextBoxColumn()
            With ColnCtaCtenValor
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nCtaCtenValor"
                .Name = "nCtaCtenValor"
                .HeaderText = "Valor"
                .ToolTipText = "Ingrese Importe y/o Porcentaje a aplicar."
                .ReadOnly = False : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColnCtaCtenValor)

        End With

    End Sub

#End Region

    Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False

        If CboEmpresa.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label10.Text, CboEmpresa)
            Exit Function
        End If

        If ChckBoxTodo.CheckState = CheckState.Checked Then
            EliminarRowsDgView(Table1)
        End If

        'Aqui validar datagridview


        ValidaCamposObligatorios = True

    End Function

    Private Sub FormMaPorcDsctoEntidades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        FormatGrilla(Table1, Me, True)
        FormatGrilla(Table2, Me, True)

        Formato01_DataGridView()

        'poblando combo
        Dim comboboxColumn As DataGridViewComboBoxColumn = TryCast(Table1.Columns("nTipoDscto"), DataGridViewComboBoxColumn)

        'RequestConst.nConCodigo = 1006 '--PARENTESCO DE PERSONAS
        comboboxColumn.DataSource = ObjConst.Get_Constante("C", CInt(gConTipoDscto)) '1132
        comboboxColumn.DisplayMember = "cConDescripcion"
        comboboxColumn.ValueMember = "nConValor"

        'Interface: 1133
        LlenaDataCombo(CboTipoCta, ObjInterface.Get_Interface(CLng(TokenByKey(CboTipoCta.Tag, "nIntClase")), CLng(TokenByKey(CboTipoCta.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")
        CboTipoCta.SelectedIndex = 0
        CboTipoCta_SelectionChangeCommitted(CboTipoCta, Nothing)

        EstadoCmdLink(C1CmdNuevo, True, C1CmdGuardar, False, C1CmdCancel, False, C1CmdCancel, False, C1CmdCerrar, True, GrpBoxTodo, False)

        SplitContainer1.Panel1Collapsed = True

        Me.WindowState = FormWindowState.Maximized

        'If ChckBoxTodo.CheckState = CheckState.Checked Then Height = 197 Else Height = 493

    End Sub

    Private Sub CboTipoCta_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTipoCta.SelectionChangeCommitted

        'Dim Obj_Empresa As New BL_Persona

        Select Case CboTipoCta.SelectedValue
            'Case TipoAtencion.Particular
            '    CboTipoPer.Enabled = False : CboTipoPer.SelectedValue = nConTipoPersona.nPerNatural
            '    CboEmpresa.Visible = False : Label10.Visible = False

            Case TipoAtencion.LabExterno
                CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Laboratorio"
                LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, CASE nPerTipo WHEN 2 THEN p.cPerNombre ELSE p.cPerApellido+' '+p.cPerNombre END as cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & TipoActividad.nPerRelTipoLabExterno & " AND nPerRelEstado <> 0", "cPerNombre"), "cPerCodigo", "cPerNombre")
            Case TipoAtencion.Convenio
                CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Empresa"
                LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, CASE nPerTipo WHEN 2 THEN p.cPerNombre ELSE p.cPerApellido+' '+p.cPerNombre END as cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & TipoActividad.nPerRelTipoEmpConvenio & " AND nPerRelEstado <> 0", "cPerNombre"), "cPerCodigo", "cPerNombre")

            Case TipoAtencion.CentroSalud
                CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Centro Salud"
                LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, CASE nPerTipo WHEN 2 THEN p.cPerNombre ELSE p.cPerApellido+' '+p.cPerNombre END as cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & TipoActividad.nPerRelTipoCentroSalud & " AND nPerRelEstado <> 0", "cPerNombre"), "cPerCodigo", "cPerNombre")
            Case TipoAtencion.Campaña
                CboEmpresa.Text = vbNullString : Label10.Visible = True : Label10.Text = "Campaña"
                LlenaDataCombo(CboEmpresa, ObjSistemaServicio.Get_Value_Table("p.cPerCodigo, CASE nPerTipo WHEN 2 THEN p.cPerNombre ELSE p.cPerApellido+' '+p.cPerNombre END as cPerNombre", "persona p WITH(NOLOCK) INNER JOIN PerRelacion pr WITH(NOLOCK) on p.cPerCodigo = pr.cPerCodigo", "", 3, "nPerRelTipo = " & TipoActividad.nPerRelTipoCampana & " AND nPerRelEstado <> 0", "cPerNombre"), "cPerCodigo", "cPerNombre")
        End Select

    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click


        If ChckBoxTodo.CheckState = CheckState.Checked Then Exit Sub
        FormServicios = 3 'Form Porc. de descuento
        FormFiltroServicios.ShowDialog()

        Table1.PerformLayout()

        'Asignando Tipo de Dscto por Default
        With Table1
            For i As Integer = 0 To .Rows.Count - 1
                If .Rows(i).Cells("nTipoDscto").Value Is Nothing Then
                    'Define que tipo de Dscto. se aplicara.
                    .Rows(i).Cells("nTipoDscto").Value = CInt(TipoDsctoAplica.PrecioFijo)
                End If
            Next
        End With

        Table1.Refresh()
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
        If columna = 7 Then ' Porcentaje

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

    Private Sub ChckBoxTodo_CheckedChanged(sender As System.Object, e As System.EventArgs)

        'If ChckBoxTodo.CheckState = CheckState.Checked Then Height = 197 : GrpBoxTodo.Enabled = True Else Height = 493 : GrpBoxTodo.Enabled = False

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Dispose()
        Close()
    End Sub

    Private Sub C1CmdGuardar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGuardar.Click

        Try
            If ValidaCamposObligatorios() Then
                'Capa: Presentacion
                Dim Obj As New BE_ReqPerPorcentajeDscto
                Dim Servicio As New BL_PerPorcentajeDscto
                'Dim Resultado As Boolean
                'Dim ResultadoDet As Boolean
                Dim nRows As Integer = 0

                'If ChckBoxTodo.CheckState = CheckState.Checked Then
                Using scope As New TransactionScope()
                    Obj.cPerCodigo = StrcPerJuridica
                    Obj.cPerParCodigo = CboEmpresa.SelectedValue
                    Obj.nIntCodigo = CInt(CboTipoCta.SelectedValue)
                    Obj.nTipoDscto = 1 'por Default equivale en Porcentaje
                    Obj.nPorcDscto = CLng(TxtPorc.Text)
                    Obj.nAplicaTodo = IIf(ChckBoxTodo.Checked, 1, 0)
                    Obj.cPerUsuario = StrUser

                    If Not Servicio.Ins_PerPorcentajeDscto(Obj) Then Throw New System.Exception("Se encontraron errores.") 'Else Resultado = True
                    'Resultado = Servicio.Ins_PerPorcentajeDscto(Obj)
                    '-----------
                    'Por Muestra
                    '-----------
                    Dim strXML As String

                    If Table1.RowCount > 0 Then
                        strXML = CreateNodeXML("MisPruebas", "", False)
                        With Table1
                            REM Recorriendo la Grilla
                            For Each row As DataGridViewRow In .Rows
                                If CLng(row.Cells("nCtaCtenValor").Value) <= 0 Then Throw New System.Exception("Valor con Cero, no se puede completar la operación.")

                                Obj.nCtaCteSerCodigo = CInt(row.Cells("nCtaCteSerCodigo").Value)
                                Obj.nTipoDscto = CInt(row.Cells("nTipoDscto").Value)
                                Obj.nPorcDscto = FormatNumber(row.Cells("nCtaCtenValor").Value, True) 'Valor guardado 

                                strXML = strXML & vbCrLf & CreateNodeXML("RegPrueba", "", False)

                                strXML = strXML & vbCrLf & CreateNodeXML("nCtaCteSerCodigo", Obj.nCtaCteSerCodigo.ToString, True)
                                strXML = strXML & vbCrLf & CreateNodeXML("nTipoDscto", Obj.nTipoDscto.ToString, True)
                                strXML = strXML & vbCrLf & CreateNodeXML("nPorcDscto", Obj.nPorcDscto.ToString, True)

                                strXML = strXML & vbCrLf & "</RegPrueba>"

                                'nRows.- Devuelve si precio se mantiene y no estar duplicando registro con el mismo precio
                                '' ''nRows = Servicio.Get_PerDetallePorcentajeDscto_nReg(Obj)
                                '' ''If nRows = 0 Then
                                '' ''    If Not Servicio.Ins_PerDetallePorcentajeDscto(Obj) Then Throw New System.Exception("Se encontraron errores.") 'Else ResultadoDet = True
                                '' ''    'ResultadoDet = Servicio.Ins_PerDetallePorcentajeDscto(Obj)
                                '' ''End If
                            Next
                        End With
                        strXML = strXML & vbCrLf & "</MisPruebas>"
                        Obj.strXML = strXML
                        If Not Servicio.Ins_PerDetallePorcentajeDscto_By_XML(Obj) Then Throw New System.Exception("Se encontraron errores.") 'Else ResultadoDet = True

                    End If

                    scope.Complete()

                End Using

                'If Resultado Then
                MessageBox.Show("Operación se realizó con éxito.", "Sistema Médica", MessageBoxButtons.OK, MessageBoxIcon.Information)
                C1CmdCancel_Click(C1CmdCancel, Nothing)
                CboEmpresa_SelectionChangeCommitted(CboEmpresa, Nothing) 'vuelvo a cargar todas las pruebas.
                'Else
                '    MessageBox.Show("Se encontraron errores.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Sub
                'End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub C1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevo.Click
        EliminarRowsDgView(Table1)
        EstadoCmdLink(C1CmdNuevo, False, C1CmdGuardar, True, C1CmdCancel, True, C1CmdCancel, True, C1CmdCerrar, False, GrpBoxTodo, True)
    End Sub

    Private Sub C1CmdCancel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCancel.Click
        EstadoCmdLink(C1CmdNuevo, True, C1CmdGuardar, False, C1CmdCancel, False, C1CmdCancel, False, C1CmdCerrar, True, GrpBoxTodo, False)
    End Sub

    Private Sub FormMaPorcDsctoEntidades_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F6))
                C1CmdNuevo_Click(C1CmdNuevo, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4))
                C1CmdGuardar_Click(C1CmdGuardar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                C1CmdCerrar_Click(C1CmdCerrar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                BtnAdd_Click(BtnAdd, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Delete))
                BtnQuitar_Click(BtnQuitar, Nothing)
        End Select

    End Sub

    Private Sub BtnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuitar.Click

        If MessageBox.Show("¿Desea quitar el examen?", "Quitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If ChckBoxTodo.CheckState = CheckState.Checked Then Exit Sub
            Dim Obj As New BE_ReqPerPorcentajeDscto
            Dim Servicio As New BL_PerPorcentajeDscto

            Obj.cPerCodigo = StrcPerJuridica
            Obj.cPerParCodigo = CboEmpresa.SelectedValue
            Obj.nIntCodigo = CInt(CboTipoCta.SelectedValue)
            Obj.nCtaCteSerCodigo = Table1.Item(ColumnGrid.ColnCtaCteSerCodigo, Table1.CurrentRow.Index).Value

            Servicio.Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo_nCtaCteSerCodigo(Obj)

            EliminaRowSeleccionada(Table1)
        End If

    End Sub

    Private Sub CboEmpresa_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboEmpresa.SelectionChangeCommitted

        Dim dt As New DataTable
        Dim Objeto As New BE_ReqPerPorcentajeDscto
        Dim Servicio As New BL_PerPorcentajeDscto

        Dim nPos As Integer = 0

        EliminarRowsDgView(Table1)

        Objeto.cPerCodigo = StrcPerJuridica
        Objeto.cPerParCodigo = CStr(CboEmpresa.SelectedValue.ToString)
        Objeto.nIntCodigo = CInt(CboTipoCta.SelectedValue)
        Objeto.cFlag = "N" 'Muestra listado registrado

        dt = Servicio.Get_PerPorcentajeDscto_by_cPerJurCodigo_and_cPerParCodigo_and_nIntCodigo(Objeto)
        Table1.Rows.Clear()
        If dt.Rows.Count > 0 Then
            Dim row As DataRow

            For Each row In dt.Rows
                If CInt(row("nAplicaTodo").ToString) = 0 Then ChckBoxTodo.CheckState = CheckState.Unchecked Else ChckBoxTodo.CheckState = CheckState.Checked
                TxtPorc.Text = FormatNumber(CDbl(row("nPorcDscto").ToString) * 100, True)

                With Table1
                    nPos = .RowCount()
                    .Rows.Add()
                    .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                    .Item("nCtaCteSerCodigo", nPos).Value = CInt(row("nCtaCteSerCodigo").ToString)
                    .Item("cIntJerarquia", nPos).Value = CStr(row("cIntJerarquia").ToString)
                    .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
                    .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                    .Item("nMonCodigo", nPos).Value = CInt(row("nMonCodigo").ToString)
                    .Item("nIntCodigo", nPos).Value = CInt(row("nIntCodigo").ToString)
                    .Item("nCtaCteSerCosto", nPos).Value = CDbl(row("nCtaCteSerCosto").ToString)
                    .Item("nTipoDscto", nPos).Value = CInt(row("nTipoDscto").ToString)
                    If CInt(row("nTipoDscto").ToString) = 1 Then 'en porcentaje %
                        .Item("nCtaCtenValor", nPos).Value = CDbl(row("nCtaCtenValor").ToString) * 100
                    Else
                        .Item("nCtaCtenValor", nPos).Value = CDbl(row("nCtaCtenValor").ToString)
                    End If
                End With
            Next
            'ChckBoxTodo_CheckedChanged(ChckBoxTodo, Nothing)

            Label5.Text = "Detalle de precios por Examen (Nro. registros " & Table1.RowCount & ")"

        End If

    End Sub

    Private Sub ChckCargaPlantilla_CheckedChanged(sender As Object, e As EventArgs) Handles ChckCargaPlantilla.CheckedChanged

        If ChckCargaPlantilla.Checked Then
            If Not ChckBoxTodo.Checked Then
                Dim dt As New DataTable
                Dim Objeto As New BE_ReqPerPorcentajeDscto
                Dim Servicio As New BL_PerPorcentajeDscto
                Dim nPos As Integer = 0

                EliminarRowsDgView(Table1)

                Objeto.cPerCodigo = StrcPerJuridica
                Objeto.cPerParCodigo = CStr(CboEmpresa.SelectedValue.ToString)
                Objeto.nIntCodigo = CInt(CboTipoCta.SelectedValue)
                Objeto.cFlag = "P" 'Muestra Plantilla con muestra registradas

                dt = Servicio.Get_PerPorcentajeDscto_by_cPerJurCodigo_and_cPerParCodigo_and_nIntCodigo(Objeto)

                If dt.Rows.Count > 0 Then
                    Dim row As DataRow

                    For Each row In dt.Rows
                        If CInt(row("nAplicaTodo").ToString) = 0 Then ChckBoxTodo.CheckState = CheckState.Unchecked Else ChckBoxTodo.CheckState = CheckState.Checked
                        TxtPorc.Text = 0 'FormatNumber(CDbl(row("nPorcDscto").ToString) * 100, True)

                        With Table1
                            nPos = .RowCount()
                            .Rows.Add()
                            .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                            .Item("nCtaCteSerCodigo", nPos).Value = CInt(row("nCtaCteSerCodigo").ToString)
                            .Item("cIntJerarquia", nPos).Value = CStr(row("cIntJerarquia").ToString)
                            .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
                            .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                            .Item("nMonCodigo", nPos).Value = CInt(row("nMonCodigo").ToString)
                            .Item("nIntCodigo", nPos).Value = CInt(row("nIntCodigo").ToString)
                            .Item("nCtaCteSerCosto", nPos).Value = CDbl(row("nCtaCteSerCosto").ToString)
                            .Item("nTipoDscto", nPos).Value = CInt(row("nTipoDscto").ToString)
                            If CInt(row("nTipoDscto").ToString) = 1 Then 'en porcentaje %
                                .Item("nCtaCtenValor", nPos).Value = CDbl(row("nCtaCtenValor").ToString) * 100
                            Else
                                .Item("nCtaCtenValor", nPos).Value = CDbl(row("nCtaCtenValor").ToString)
                            End If
                        End With
                    Next
                    'ChckBoxTodo_CheckedChanged(ChckBoxTodo, Nothing)

                End If
            End If
        Else
            EliminarRowsDgView(Table1)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim textoBuscado As String

            If Table1.RowCount > 0 Then

                textoBuscado = InputBox("Ingrese aquí...", "Buscando")

                If Len(textoBuscado.Trim) = 0 Then Exit Sub

                For i As Integer = 0 To Table1.RowCount
                    If Table1.Rows(i).Cells("cCtaCteSerJerarquia").Value.ToString.ToUpper = textoBuscado.Trim.ToUpper Then

                        Table1.Rows(i).Selected = True
                        Table1.FirstDisplayedScrollingRowIndex = i

                        Exit Sub
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try


    End Sub

    Private Sub BtnSubeArchivo_Click(sender As Object, e As EventArgs) Handles BtnSubeArchivo.Click

        'Validando ingreso de precios
        Try
            If ValidaCamposObligatorios() Then
                'Capa: Presentacion
                Dim Obj As New BE_ReqPerPorcentajeDscto
                Dim Servicio As New BL_PerPorcentajeDscto

                Dim ctaCteListaServicio As New CtaCteListaServicio
                Dim gestionarCtaCteListaServicioServicio As New GestionarCtaCteListaServicioServicio

                Dim nRows As Integer = 0
                Dim nCtaCteSerCodigo As Integer = 0

                Using scope As New TransactionScope()

                    Obj.cPerCodigo = StrcPerJuridica
                    Obj.cPerParCodigo = CboEmpresa.SelectedValue
                    Obj.nIntCodigo = CInt(CboTipoCta.SelectedValue)
                    Obj.nTipoDscto = 2 'por Default precio fijo
                    Obj.cPerUsuario = StrUser

                    '-----------
                    'Por Muestra
                    '-----------
                    If Table2.RowCount > 0 Then
                        With Table2
                            REM Recorriendo la Grilla
                            For Each row As DataGridViewRow In .Rows
                                If CLng(row.Cells("nCtaCtePrecio").Value) <= 0 Then Throw New System.Exception("Precio no válido, no se puede completar la operación.")

                                ctaCteListaServicio.cPerJurCodigo = StrcPerJuridica
                                ctaCteListaServicio.cCtaCteSerJerarquia = row.Cells("cCtaCteSerJerarquia").Value
                                nCtaCteSerCodigo = gestionarCtaCteListaServicioServicio.Get_CtaCteListaServicio(ctaCteListaServicio)

                                Obj.nCtaCteSerCodigo = nCtaCteSerCodigo

                                If nCtaCteSerCodigo = 0 Then row.Cells("nEstado").Value = "NO Existe"
                                '--Obj.nTipoDscto = 2 --CInt(row.Cells("nTipoDscto").Value)
                                Obj.nPorcDscto = FormatNumber(row.Cells("nCtaCtePrecio").Value, True) 'Valor guardado 

                                'nRows.- Devuelve si precio se mantiene y no estar duplicando registro con el mismo precio
                                nRows = Servicio.Get_PerDetallePorcentajeDscto_nReg(Obj)
                                If nRows = 0 Then
                                    If Not Servicio.Ins_PerDetallePorcentajeDscto(Obj) Then Throw New System.Exception("Se encontraron errores.") 'Else ResultadoDet = True
                                    If nCtaCteSerCodigo > 0 Then row.Cells("nEstado").Value = "Actualizado"
                                    'ResultadoDet = Servicio.Ins_PerDetallePorcentajeDscto(Obj)
                                End If
                            Next
                        End With
                    End If

                    scope.Complete()

                End Using

                MessageBox.Show("Operación se realizó con éxito.", "Sistema Médica", MessageBoxButtons.OK, MessageBoxIcon.Information)
                C1CmdCancel_Click(C1CmdCancel, Nothing)
                CboEmpresa_SelectionChangeCommitted(CboEmpresa, Nothing) 'vuelvo a cargar todas las pruebas.

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnSeleccionarArchivo_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarArchivo.Click

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Archivo de Texto|*.txt"
        openFileDialog.Title = "Seleccionar archivo de texto con estructura definida precios..."

        ' Show el Dialog.
        If openFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtRutaArchivo.Text = openFileDialog.FileName
        End If

        'Llena el DataGridView
        If (txtRutaArchivo.Text <> "") Then
            EliminarRowsDgView(Table2)
            Using str As New StreamReader(txtRutaArchivo.Text)
                While Not str.EndOfStream()
                    Dim texto As String = str.ReadLine()
                    Dim div As String() = texto.Split(New Char() {";"c})
                    Table2.Rows.Add(div)
                End While
            End Using

            Label7.Text = "Subir Archivo (Filas " & Table2.RowCount & ")"

        End If

    End Sub

    Private Sub C1CmdSubirArchivo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdSubirArchivo.Click

        If SplitContainer1.Panel1Collapsed = True Then SplitContainer1.Panel1Collapsed = False Else SplitContainer1.Panel1Collapsed = True
        EliminarRowsDgView(Table2)

    End Sub

    Private Sub C1CmdExportExcel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportExcel.Click
        ExportarDatosExcel(Table1, "Listado de Precio: " & CboTipoCta.Text, "Laboratorio/Empresa: " & CboEmpresa.Text)
    End Sub

    Private Sub BtnQuitarTodo_Click(sender As Object, e As EventArgs) Handles BtnQuitarTodo.Click
        If MessageBox.Show("¿Desea quitar todos los exámenes?", "Quitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If ChckBoxTodo.CheckState = CheckState.Checked Then Exit Sub
            Dim Obj As New BE_ReqPerPorcentajeDscto
            Dim Servicio As New BL_PerPorcentajeDscto

            Obj.cPerCodigo = StrcPerJuridica
            Obj.cPerParCodigo = CboEmpresa.SelectedValue
            Obj.nIntCodigo = CInt(CboTipoCta.SelectedValue)

            Servicio.Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo(Obj)
            EliminarRowsDgView(Table1)

        End If
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
                    CboEmpresa_SelectionChangeCommitted(Nothing, Nothing)
                End If
            End If
            Frm.Close()
            Frm.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error inesperado en la búsqueda, comuníquese con el área de TI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CboEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboEmpresa.SelectedIndexChanged

    End Sub
End Class