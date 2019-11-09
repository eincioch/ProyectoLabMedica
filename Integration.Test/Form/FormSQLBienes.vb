Option Explicit On

Imports Integration.BE.Campana
Imports Integration.BE.CtasCtes
Imports Integration.BL.BL_CtaCteListaServicio
Imports Integration.BL.BL_Campana
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL.BL_CtasCtesMedica
Imports Integration.BE.PerUsuGruAcc
Imports Integration.BL

Public Class FormSQLBienes
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Dim mdtbColourMap As DataTable = Nothing

    Dim Req_Campana As New BE_ReqCampana
    Dim Obj_Campana As New BL_Campana

#Region "Estructura Grilla"

    Enum GrillaServicios
        ColnKey = 0
        ColnBieCodigo = 1
        ColcBieCodigo = 2
        ColcBieDescripcion = 3
    End Enum

    Private Sub Formato01_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()

            Dim Colnkey As New DataGridViewCheckBoxColumn()
            With Colnkey
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = ""
                .HeaderText = "?"
                .FalseValue = 0
                .IndeterminateValue = 0
                .TrueValue = 1
                .Name = "nKey"
                .ReadOnly = True : .Visible = True
                .Width = 28
            End With
            .Columns.Add(Colnkey)

            Dim ColnBieCodigo As New DataGridViewTextBoxColumn()
            With ColnBieCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nBieCodigo"
                .HeaderText = "nBieCodigo"
                .Name = "nBieCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 30
            End With
            .Columns.Add(ColnBieCodigo)

            Dim ColcBieCodigo As New DataGridViewTextBoxColumn()
            With ColcBieCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.DefaultCellStyle.Format = "d"
                .DataPropertyName = "cBieCodigo"
                .HeaderText = "cBieCodigo"
                .Name = "cBieCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 90
                '.DefaultCellStyle = DataGridViewCellStyle { Format=N, Alignment=TopRight }
            End With
            .Columns.Add(ColcBieCodigo)

            Dim ColcBieDescripcion As New DataGridViewTextBoxColumn()
            With ColcBieDescripcion
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cBieDescripcion"
                .HeaderText = "Descripción"
                .Name = "cBieDescripcion"
                .ReadOnly = True : .Visible = True
                .Width = 480
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColcBieDescripcion)

        End With

    End Sub
#End Region

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

    Private Sub FiltraComponente(ByVal Valor As String, Optional ByVal Flag As String = "C")
        Try
            Dim dt As New DataTable
            Dim nPos As Integer

            Dim ObjBLBien As New BL_Interface

            Dim nNivel, nOrden As Integer
            Dim cBuscar As String = ""
            Dim cBieJerarquia As String = "01"

            If Valor.Trim.Length > 3 Then

                If Flag = "G" Then
                    nNivel = 0
                    nOrden = 2
                    cBuscar = ""
                    cBieJerarquia = Valor
                Else
                    nNivel = 0
                    nOrden = 2
                    cBuscar = Valor
                End If

                dt = ObjBLBien.Get_Bien_By_Jerarquia_Descripcion(cBuscar, cBieJerarquia, nOrden, StrcPerJuridica, nNivel)

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
                            .Item("nBieCodigo", nPos).Value = CInt(row("nBieCodigo").ToString)
                            .Item("cBieCodigo", nPos).Value = CStr(row("cBieCodigo").ToString)
                            .Item("cBieDescripcion", nPos).Value = CStr(row("cBieDescripcion").ToString)
                        End With

                    Next

                End If

                Table1.PerformLayout()
                Table1.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FormFiltroServicios_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                Table1.Enabled = False
                Call BtnSeleccionar_Click(BtnSeleccionar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                Call BtnCancelar_Click(BtnCancelar, Nothing)
        End Select

    End Sub


    Private Sub FormFiltroServicios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try

            Req_Campana.cPerJurCodigo = StrcPerJuridica

            Table1.Enabled = True

            Formato01_DataGridView()
            FormatGrilla(Table1, Me, False, 25, False, DataGridViewSelectionMode.CellSelect)

            Me.StartPosition = FormStartPosition.CenterScreen

            Dim ObjBL As New BL_Interface

            LlenaDataCombo(CboClase, ObjBL.Get_Bien_By_Jerarquia_Descripcion("", "01", 2, "1000098770", 2), "cBieCodigo", "cBieDescripcion")

            Me.ActiveControl = TxtCaracter
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub

    Private Sub BtnSeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles BtnSeleccionar.Click

        Try
            'Dim Rows As Integer

            If Table1.RowCount = 0 Then Exit Sub

            With Table1
                If Not .CurrentCell Is Nothing Then
                    For Each row As DataGridViewRow In .Rows

                        REM Pasando solo los que tiene el Check 
                        If Convert.ToInt16(row.Cells("nKey").Value) = 1 Then

                            Select Case FormServicios
                                Case 1
                                    '--------------------
                                    ' Form Servicios Componentes
                                    '---------------------
                                    'Verificando si el servicio ya fue ingresado
                                    If BuscaCadenaDgView("nCtaCteSerCmpCodigo", row.Cells(GrillaServicios.ColnBieCodigo).Value.ToString, FormMaServiciosComponentes.Table1) Then
                                        MessageBox.Show("Componente " & row.Cells(GrillaServicios.ColcBieCodigo).Value.ToString & " - " & row.Cells(GrillaServicios.ColcBieDescripcion).Value.ToString & " ya ha sido ingresado, no podrá utilizar el mismo componente.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    Else
                                        'With FormMaServiciosComponentes.Table1
                                        '    Rows = .RowCount()
                                        '    .Rows.Add()
                                        '    .Item("cPerJurCodigo", Rows).Value = row.Cells(GrillaServicios.ColcPerJurCodigo).Value.ToString
                                        '    .Item("nCtaCteSerCodigo", Rows).Value = row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString
                                        '    .Item("cIntJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcIntJerarquia).Value.ToString
                                        '    .Item("cCtaCteSerJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString

                                        '    .Item("cCodGrupo", Rows).Value = row.Cells(GrillaServicios.ColcCodGrupo).Value.ToString 'Update 2015-12-24 (eincio)

                                        '    .Item("cCtaCteSerKeyWord", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString
                                        '    .Item("nMonCodigo", Rows).Value = row.Cells(GrillaServicios.ColnMonCodigo).Value.ToString
                                        '    .Item("nIntCodigo", Rows).Value = row.Cells(GrillaServicios.ColnIntCodigo).Value.ToString


                                        '    '.Item("nCtaCteSerCodigo", Rows).Value = row.Cells(1).Value.ToString
                                        '    '.Item("cPerJurCodigo", Rows).Value = row.Cells(1).Value.ToString
                                        '    .Item("nCtaCteSerCmpCodigo", Rows).Value = row.Cells(GrillaServicios.ColnBieCodigo).Value.ToString
                                        '    .Item("cIntDescripcion", Rows).Value = row.Cells(GrillaServicios.ColcBieDescripcion).Value.ToString
                                        '    .Item("nCtaCteSerCmpUndDestino", Rows).Value = row.Cells(1).Value.ToString
                                        '    .Item("cUnidad", Rows).Value = row.Cells(1).Value.ToString
                                        '    .Item("nCtaCteSerCmpCantidad", Rows).Value = row.Cells(1).Value.ToString
                                        '    .Item("nCtaCteSerCmpEstado", Rows).Value = row.Cells(1).Value.ToString
                                        '    .Item("cEstado", Rows).Value = row.Cells(1).Value.ToString


                                        'End With

                                        'FormPrcSolAtencion.CalcularVta()

                                        FormMaServiciosComponentes.LblCtaCteSerCompDescripcion.Text = row.Cells(GrillaServicios.ColcBieDescripcion).Value.ToString
                                        FormMaServiciosComponentes.LblnCtaCteSerComCodigo.Text = row.Cells(GrillaServicios.ColnBieCodigo).Value.ToString
                                        Call BtnCancelar_Click(Nothing, Nothing)
                                    End If

                                Case 2 REM Form Perfil Servicio
                                    'Verificando si el servicio ya fue ingresado
                                    If BuscaCadenaDgView("nCtaCteSerCodigo", row.Cells(GrillaServicios.ColnBieCodigo).Value.ToString, FormMaPerfilServicios.Table1) Then
                                        MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcBieCodigo).Value.ToString & " - " & row.Cells(GrillaServicios.ColcBieDescripcion).Value.ToString & " ya ha sido ingresado, no podra utilizar el mismo componente.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    Else
                                        'If row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value <= 0 Then
                                        '    MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " , tiene Precio < Cero > por favor verifique.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        '    Exit Sub
                                        'Else
                                        '    REM Si No existe y el Precio no es CERO, agregamos los item(s).
                                        '    With FormMaPerfilServicios.Table1
                                        '        Rows = .RowCount()
                                        '        .Rows.Add()
                                        '        .Item("cPerJurCodigo", Rows).Value = row.Cells(GrillaServicios.ColcPerJurCodigo).Value.ToString
                                        '        .Item("nIntCodigo", Rows).Value = FormMaPerfilServicios.CboPerfil.SelectedValue
                                        '        .Item("nCtaCteSerCodigo", Rows).Value = row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString
                                        '        .Item("cCtaCteSerJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString
                                        '        .Item("cCtaCteSerKeyWord", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString
                                        '        .Item("nMonCodigo", Rows).Value = row.Cells(GrillaServicios.ColnMonCodigo).Value.ToString
                                        '        .Item("nCtaCteSerImpDef", Rows).Value = Format(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value, "##,##0.00")
                                        '        .Item("cPerUsuCodigo", Rows).Value = StrUser 'usuario actual conectado en el sistema

                                        '    End With
                                        'End If
                                        FormMaServiciosComponentes.LblCtaCteSerCompDescripcion.Text = row.Cells(GrillaServicios.ColcBieDescripcion).Value.ToString
                                        FormMaServiciosComponentes.LblnCtaCteSerComCodigo.Text = row.Cells(GrillaServicios.ColnBieCodigo).Value.ToString
                                        FormMaServiciosComponentes.TxtCantidad.Text = IIf(FormMaServiciosComponentes.TxtCantidad.Text = "", "1", FormMaServiciosComponentes.TxtCantidad.Text)
                                        Call BtnCancelar_Click(Nothing, Nothing)
                                    End If
                               
                            End Select

                        End If
                    Next

                    'TxtCaracter.Text = "" : EliminarRowsDgView(Table1) : ActiveControl = TxtCaracter
                    'Me.Close()
                    'Me.Dispose()

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        FiltraComponente(TxtCodigo.Text)
    End Sub

    Private Sub CboClase_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboClase.SelectionChangeCommitted
        FiltraComponente(CboClase.SelectedValue.ToString, "G")
    End Sub

    Private Sub TxtCaracter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCaracter.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            FiltraComponente(TxtCaracter.Text, "D")
        End If
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

    ' para editar el Check de Table1
    Private Sub Table1_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellContentClick

        If e.ColumnIndex = Me.Table1.Columns.Item(GrillaServicios.ColnKey).Index Then
            'Table1.Item(e.ColumnIndex, e.RowIndex + 1).Selected = True
            Dim chkCell As DataGridViewCheckBoxCell = Me.Table1.Rows(e.RowIndex).Cells(GrillaServicios.ColnKey)
            chkCell.Value = Not chkCell.Value
            'MsgBox("Estado: " & EstadoCheck(e.RowIndex))

            Table1.PerformLayout()
            Table1.Refresh()
        End If
    End Sub

    Private Function EstadoCheck(ByVal filaposicion As Integer) As Boolean

        Return Me.Table1.Rows(filaposicion).Cells("nKey").Value

    End Function

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Table1.CurrentCellDirtyStateChanged
        If Table1.IsCurrentCellDirty Then
            Table1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        Close()
        Dispose()
    End Sub

    Private Sub FormFiltroServicios_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub FormFiltroServicios_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub

    Private Sub FormFiltroServicios_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Arrastre = False
    End Sub
End Class