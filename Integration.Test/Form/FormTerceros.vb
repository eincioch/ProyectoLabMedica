Imports Integration.BE.Persona
Imports Integration.BL.BL_Persona

Public Class FormTerceros
    Dim lnTipoTercero As Long

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub FormTerceros_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                Table1.Enabled = False
                'Call BtnSeleccionar_Click(BtnSeleccionar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                Call BtnCancelar_Click(BtnCancelar, Nothing)
        End Select
    End Sub

    Private Sub FormTerceros_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub FormTerceros_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub

    Private Sub FormTerceros_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Arrastre = False
    End Sub

    Public Sub CargarFormulario(ByVal nTipoAtencion As Long)
        If nTipoAtencion <> 0 Then
            lnTipoTercero = nTipoAtencion
            TxtRUC.Enabled = False
            Formato01_DataGridView()
            FormatGrilla(Table1, Me, False, 25, False, DataGridViewSelectionMode.FullRowSelect)
            TxtDescripcion.Text = ""
            TxtDescripcion.Enabled = True
            TxtDescripcion.Focus()
            Me.ShowDialog()
        End If
    End Sub

    Private Sub FiltraTercero(ByVal Valor As String)
        Try
            Table1.DataSource = Nothing
            If Valor.Trim <> "" Then
                Dim dt As New DataTable

                Dim Obj_Empresa As New BL.BL_Personas

                Dim Obj As New BE.Persona.BE_Req_Persona
                Obj.nPerRelTipo = lnTipoTercero
                Obj.cPerApellido = IIf(RBTDescripcion.Checked, TxtDescripcion.Text.Trim, TxtRUC.Text)
                Obj.nPerTipo = IIf(RBTDescripcion.Checked, 1, 2)

                Table1.DataSource = Obj_Empresa.Get_Busqueda_Terceros_By_Tipo_Descr(Obj)
                Table1.PerformLayout()
                Table1.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        Close()
        Dispose()
    End Sub

    Private Sub TxtDescripcion_TextChange(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged
        If RBTDescripcion.Checked And TxtDescripcion.Text.Trim.Length >= 3 Then
            FiltraTercero(TxtDescripcion.Text)
        Else
            Table1.DataSource = Nothing
        End If
    End Sub

    Private Sub RBTDescripcion_CheckedChanged(sender As Object, e As EventArgs) Handles RBTDescripcion.CheckedChanged
        If sender.Checked Then
            TxtDescripcion.Text = ""
            TxtDescripcion.Enabled = True
            TxtDescripcion.Focus()
        Else
            TxtDescripcion.Enabled = False
        End If
    End Sub

    Private Sub RBTRUC_CheckedChanged(sender As Object, e As EventArgs) Handles RBTRUC.CheckedChanged
        If sender.Checked Then
            TxtRUC.Text = ""
            TxtRUC.Enabled = True
            TxtRUC.Focus()
        Else
            TxtRUC.Enabled = False
        End If
    End Sub

    Private Sub TxtRUC_TextChanged(sender As Object, e As EventArgs) Handles TxtRUC.TextChanged
        If RBTRUC.Checked And TxtRUC.Text.Trim.Length = 11 Then
            FiltraTercero(TxtRUC.Text)
        Else
            Table1.DataSource = Nothing
        End If
    End Sub

    Private Sub Formato01_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()

            'Dim Colnkey As New DataGridViewCheckBoxColumn()
            'With Colnkey
            '    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '    .DataPropertyName = ""
            '    .HeaderText = "?"
            '    .FalseValue = 0
            '    .IndeterminateValue = 0
            '    .TrueValue = 1
            '    .Name = "nKey"
            '    .ReadOnly = True : .Visible = True
            '    .Width = 28
            'End With
            '.Columns.Add(Colnkey)

            Dim ColcPerJurCodigo As New DataGridViewTextBoxColumn()
            With ColcPerJurCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerCodigo"
                .HeaderText = "cPerCodigo"
                .Name = "cPerCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColcPerJurCodigo)


            Dim ColcRazonSocial As New DataGridViewTextBoxColumn()
            With ColcRazonSocial
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cPerNombre"
                .HeaderText = "Razón Social / Nombre Comercial"
                .Name = "cPerNombre"
                .ReadOnly = True : .Visible = True
                .Width = 500
            End With
            .Columns.Add(ColcRazonSocial)

            Dim ColcRUC As New DataGridViewTextBoxColumn()
            With ColcRUC
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cRUC"
                .HeaderText = "RUC"
                .Name = "cRUC"
                .ReadOnly = True : .Visible = True
                .Width = 100
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColcRUC)


        End With

    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        If Table1.Rows.Count > 0 And Not Table1.CurrentRow Is Nothing Then
            Me.Hide()
        Else
            MessageBox.Show("No se ha seleccionado ningún resultado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class