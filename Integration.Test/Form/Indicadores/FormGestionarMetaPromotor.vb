Imports Integration.BL.BL_Persona
Imports Integration.BE.Persona
Imports System.Transactions

Public Class FormGestionarMetaPromotor

    Dim nOperacion As Integer = 0

#Region "Forma Grilla"

    Enum ColumnGrid
        ColnMetCodigo = 0
        ColcIntNombre = 1
        ColcIntDescripcion = 2
        ColnMetValor = 3

    End Enum

    Private Sub Formato01_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()
            '0
            Dim ColnMetCodigo As New DataGridViewTextBoxColumn()
            With ColnMetCodigo
                .DefaultCellStyle.Format = "N0"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nIntDstCodigo"
                .Name = "nIntDstCodigo"
                .HeaderText = "Código"
                .ReadOnly = True : .Visible = True
                .Width = 70
            End With
            .Columns.Add(ColnMetCodigo)
            '1
            Dim ColcIntNombre As New DataGridViewTextBoxColumn()
            With ColcIntNombre
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cIntNombre"
                .HeaderText = "Nro. Indicador"
                .Name = "cIntNombre"
                .ReadOnly = True : .Visible = True
                .Width = 130
            End With
            .Columns.Add(ColcIntNombre)
            '2
            Dim ColcIntDescripcion As New DataGridViewTextBoxColumn()
            With ColcIntDescripcion
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cIntDescripcion"
                .HeaderText = "Descripción"
                .Name = "cIntDescripcion"
                .ReadOnly = True : .Visible = True
                .Width = 350
            End With
            .Columns.Add(ColcIntDescripcion)
            '3
            Dim ColnMetValor As New DataGridViewTextBoxColumn()
            With ColnMetValor
                .DefaultCellStyle.Format = "N2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DataPropertyName = "nMetValor"
                .Name = "nMetValor"
                .HeaderText = "Valor"
                .ReadOnly = False : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColnMetValor)

        End With

    End Sub

#End Region

    Private Sub GetPromotor()

        'Dim gestionarPerAsigPromotorServicio As GestionarPerAsigPromotorServicio

        'CboPromotor.Enabled = True

        'If RBtnMedico.Checked Then
        ' GestionarPerAsigPromotorServicio = New GestionarPerAsigPromotorServicio
        ' LlenaDataCombo(CboPromotor, GestionarPerAsigPromotorServicio.Get_PerAsigPromotor(1), "cPerPromCodigo", "cPromotor")
        ' ElseIf RBtnLaboratorio.Checked Then
        'GestionarPerAsigPromotorServicio = New GestionarPerAsigPromotorServicio
        'LlenaDataCombo(CboPromotor, GestionarPerAsigPromotorServicio.Get_PerAsigPromotor(2), "cPerPromCodigo", "cPromotor")
        'Else
        'CboPromotor.DataSource = Nothing
        'CboPromotor.Enabled = False
        'End If
        'CboPeriodo_SelectionChangeCommitted(CboPeriodo, Nothing)

    End Sub

    Private Sub FormGestionarMetaPromotor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F6))
                C1CmdNuevo_Click(C1CmdNuevo, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4))
                C1CmdGuardar_Click(C1CmdGuardar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F8))
                If GroupBox.Enabled Then C1CmdCancelar_Click(C1CmdCancelar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                If Not GroupBox.Enabled Then C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select

    End Sub

    Private Sub FormGestionarMetaPromotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        Formato01_DataGridView()
        FormatGrilla(Table1, Me, True, 30, False, DataGridViewSelectionMode.CellSelect)

        LlenaDataCombo(CboGrupoIndicador, ObjInterface.Get_Interface(CLng(TokenByKey(CboGrupoIndicador.Tag, "nIntClase")), CLng(TokenByKey(CboGrupoIndicador.Tag, "nIntTipo")), "C"), "nIntCodigo", "cIntDescripcion")
        CboGrupoIndicador.SelectedIndex = 1
        CboGrupoIndicador_SelectionChangeCommitted(CboGrupoIndicador, Nothing)

        'Llena Año
        ObtenerPeriodosPorSucursal(CboAnno, StrcPerJuridica)
        CboAnno.SelectedIndex = 1
        CboAnno_SelectionChangeCommitted(CboAnno, Nothing)

        'promotor
        GetPromotor()

    End Sub

    Private Sub RBtnMedico_Click(sender As Object, e As EventArgs) Handles RBtnMedico.Click

        GetPromotor()

    End Sub

    Private Sub RBtnLaboratorio_Click(sender As Object, e As EventArgs) Handles RBtnLaboratorio.Click

        GetPromotor()

    End Sub

    Private Sub RBtnMedParticular_Click(sender As Object, e As EventArgs) Handles RBtnMedParticular.Click

        GetPromotor()

    End Sub

    Private Sub CboAnno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAnno.SelectionChangeCommitted
        CboPeriodo_SelectionChangeCommitted(CboPeriodo, Nothing)
    End Sub

    Private Sub CboAnno_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboAnno.SelectionChangeCommitted

        If CboAnno.SelectedValue = -1 Then Exit Sub
        ObtenerPeriodosPorSucursal(CboPeriodo, StrcPerJuridica, CboAnno.SelectedValue, "M")

    End Sub


    Private Sub C1CmdGuardar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGuardar.Click

        Dim gestionarMetaPromotorServicio As GestionarMetaPromotorServicio
        Dim metaPromotor As MetaPromotor

        Try
            If Table1.RowCount > 0 Then

                Using scope As New TransactionScope()
                    With Table1
                        For Each row As DataGridViewRow In .Rows
                            If CLng(row.Cells("nMetValor").Value) <= 0 Then Throw New System.Exception("Valor con Cero, no se puede completar la operación. Verifique valor en la columna Valor.")
                            metaPromotor = New MetaPromotor

                            metaPromotor.cPerJurCodigo = cCodCorpoMedica
                            metaPromotor.nIntSrcCodigo = CboGrupoIndicador.SelectedValue  'IIf(RBtnMedico.Checked, 1, IIf(RBtnLaboratorio.Checked, 2, 3))
                            metaPromotor.nPrdCodigo = CLng(CboPeriodo.SelectedValue)
                            metaPromotor.cPerPromCodigo = IIf(CboGrupoIndicador.SelectedValue = 1000 Or CboGrupoIndicador.SelectedValue = 1002, CboPromotor.SelectedValue, "") 'IIf(Not RBtnMedParticular.Checked, CboPromotor.SelectedValue, "")

                            metaPromotor.nIntDstCodigo = CInt(row.Cells("nIntDstCodigo").Value)
                            metaPromotor.nMetValor = FormatNumber(row.Cells("nMetValor").Value, True)

                            gestionarMetaPromotorServicio = New GestionarMetaPromotorServicio
                            'Aqui determina si guarda o actualiza
                            If nOperacion = 0 Then
                                metaPromotor.cPerUsuCrea = StrUser
                                If Not gestionarMetaPromotorServicio.Insert_MetaPromotor(metaPromotor) Then Throw New ArgumentException("Se encontraron errores.")
                            Else
                                metaPromotor.cPerUsuModi = StrUser
                                If Not gestionarMetaPromotorServicio.Update_MetaPromotor(metaPromotor) Then Throw New ArgumentException("Se encontraron errores.")
                            End If
                        Next
                    End With

                    scope.Complete()
                End Using

                MessageBox.Show("operación se ha realizado con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CboPeriodo_SelectionChangeCommitted(CboPeriodo, Nothing)
                C1CmdCancelar_Click(C1CmdCancelar, Nothing)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CboPeriodo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboPeriodo.SelectionChangeCommitted

        Try
            Dim dataTable As New DataTable()
            Dim nPos As Integer = 0

            EliminarRowsDgView(Table1)

            'Verifica y carga si hay información registrada
            Dim metaPromotor As New MetaPromotor
            Dim metaPromotors As New List(Of MetaPromotor)

            Dim gestionarMetaPromotorServicio As New GestionarMetaPromotorServicio

            metaPromotor.cPerJurCodigo = cCodCorpoMedica
            metaPromotor.nIntSrcCodigo = CboGrupoIndicador.SelectedValue  'IIf(RBtnMedico.Checked, 1, IIf(RBtnLaboratorio.Checked, 2, 3)) 'IIf(RBtnMedico.Checked, 1, 2)
            metaPromotor.nPrdCodigo = CboPeriodo.SelectedValue
            metaPromotor.cPerPromCodigo = IIf(CboGrupoIndicador.SelectedValue = 1000 Or CboGrupoIndicador.SelectedValue = 1002 Or CboGrupoIndicador.SelectedValue = 1005, CboPromotor.SelectedValue, "") 'IIf(Not RBtnMedParticular.Checked, CboPromotor.SelectedValue, "")

            metaPromotors = gestionarMetaPromotorServicio.Get_MetaPromotor(metaPromotor)

            If metaPromotors.Count > 0 Then

                For Each metaPromotorRow As MetaPromotor In metaPromotors

                    'If metaPromotorRow.nPerAsigTipo = 1 Then
                    'RBtnMedico.Checked = True
                    'RBtnLaboratorio.Checked = False
                    'RBtnMedParticular.Checked = False
                    'ElseIf metaPromotorRow.nPerAsigTipo = 2 Then
                    'RBtnMedico.Checked = False
                    'RBtnLaboratorio.Checked = True
                    ' RBtnMedParticular.Checked = False
                    'Else
                    '    RBtnMedico.Checked = False
                    '   RBtnLaboratorio.Checked = False
                    '    RBtnMedParticular.Checked = True
                    'End If
                    CboPromotor.SelectedValue = metaPromotorRow.cPerPromCodigo

                    With Table1
                        nPos = .RowCount()
                        .Rows.Add()
                        .Item("nIntDstCodigo", nPos).Value = CInt(metaPromotorRow.nIntDstCodigo)
                        .Item("cIntNombre", nPos).Value = metaPromotorRow.objInterface.cIntNombre
                        .Item("cIntDescripcion", nPos).Value = metaPromotorRow.objInterface.cIntDescripcion.ToUpper
                        .Item("nMetValor", nPos).Value = FormatNumber(metaPromotorRow.nMetValor, True)
                    End With

                Next

                nOperacion = 1 'Ya hay registro
            Else
                'Muestra Indicadores de Interface
                'If RBtnMedico.Checked Then
                dataTable = ObjInterface.Get_Interface_IntInterface(1134, CboGrupoIndicador.SelectedValue)
                'If RBtnLaboratorio.Checked Then dataTable = ObjInterface.Get_Interface(2804, 2, "T")
                'If RBtnMedParticular.Checked Then dataTable = ObjInterface.Get_Interface(2804, 3, "T")

                If dataTable.Rows.Count > 0 Then

                    Dim row As DataRow

                    For Each row In dataTable.Rows
                        'MessageBox.Show(CStr(row("cIntDescripcion").ToString))
                        With Table1
                            nPos = .RowCount()
                            .Rows.Add()
                            .Item("nIntDstCodigo", nPos).Value = CInt(row("nIntDstCodigo").ToString)
                            .Item("cIntNombre", nPos).Value = CStr(row("cIntNombre").ToString)
                            .Item("cIntDescripcion", nPos).Value = CStr(row("cIntDescripcion").ToString)
                            .Item("nMetValor", nPos).Value = 0
                        End With

                    Next
                End If

                nOperacion = 0 'No hay informacion registrada
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CboGrupoIndicador_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboGrupoIndicador.SelectionChangeCommitted

        Dim gestionarPerAsigPromotorServicio As GestionarPerAsigPromotorServicio

        Select Case CLng(CboGrupoIndicador.SelectedValue)
            Case 1000 'Medico
                gestionarPerAsigPromotorServicio = New GestionarPerAsigPromotorServicio
                LlenaDataCombo(CboPromotor, gestionarPerAsigPromotorServicio.Get_PerAsigPromotor(1), "cPerPromCodigo", "cPromotor")
            Case 1002
                gestionarPerAsigPromotorServicio = New GestionarPerAsigPromotorServicio
                LlenaDataCombo(CboPromotor, gestionarPerAsigPromotorServicio.Get_PerAsigPromotor(2), "cPerPromCodigo", "cPromotor")
            Case 1003
                gestionarPerAsigPromotorServicio = New GestionarPerAsigPromotorServicio
                LlenaDataCombo(CboPromotor, gestionarPerAsigPromotorServicio.Get_PerAsigPromotor(3), "cPerPromCodigo", "cPromotor")
            Case 1005
                gestionarPerAsigPromotorServicio = New GestionarPerAsigPromotorServicio
                LlenaDataCombo(CboPromotor, gestionarPerAsigPromotorServicio.Get_PerAsigPromotor(5), "cPerPromCodigo", "cPromotor")
            Case Else
                CboPromotor.DataSource = Nothing
        End Select

        CboPeriodo_SelectionChangeCommitted(CboPeriodo, Nothing)

    End Sub

    Private Sub CboPromotor_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboPromotor.SelectionChangeCommitted
        CboPeriodo_SelectionChangeCommitted(CboPeriodo, Nothing)
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
        If columna = 3 Then ' Porcentaje

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

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Dispose()
        Close()
    End Sub

    Private Sub C1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevo.Click

        C1CmdNuevo.Enabled = False
        C1CmdGuardar.Enabled = True
        C1CmdCancelar.Enabled = True
        GroupBox.Enabled = True
        Table1.Enabled = True
        C1CmdCerrar.Enabled = False

    End Sub

    Private Sub C1CmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCancelar.Click
        C1CmdNuevo.Enabled = True
        C1CmdGuardar.Enabled = False
        C1CmdCancelar.Enabled = False
        GroupBox.Enabled = False
        Table1.Enabled = False
        C1CmdCerrar.Enabled = True
    End Sub

End Class