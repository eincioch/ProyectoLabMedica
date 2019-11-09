Imports Integration.BE.Persona
Imports Integration.BL.BL_Persona
Imports System.Globalization

Public Class FormGestionarPerAsigPromotor

    Function ValidaExiste() As Boolean

        Return BuscaCadenaDgView("cPerAsigCodigo1", Table1.Item("cPerAsigCodigo", Table1.CurrentRow.Index).Value, Table2)

    End Function

    Function ValidarAsignacion(ByVal nPerAsigEstado As Integer, ByRef dataGridView As DataGridView, ByVal cNombreColumna As String) As Boolean
        'Verificando si fue retirado y validar que no se asigne el mismo dia de retirado

        Dim cFecha As String = ""

        Dim perAsigPromotor As PerAsigPromotor
        Dim gestionarPerAsigPromotorServicio As GestionarPerAsigPromotorServicio

        perAsigPromotor = New PerAsigPromotor
        perAsigPromotor.cPerAsigCodigo = dataGridView.Item(cNombreColumna, dataGridView.CurrentRow.Index).Value
        perAsigPromotor.nPerAsigEstado = nPerAsigEstado
        perAsigPromotor.nPerAsigTipo = IIf(RBtnMedico.Checked, 1, 2)

        gestionarPerAsigPromotorServicio = New GestionarPerAsigPromotorServicio
        cFecha = gestionarPerAsigPromotorServicio.Get_PerAsigPromotor_By_nPerAsigEstado_dEffDate(perAsigPromotor)

        If Len(Trim(cFecha)) > 0 Then
            Dim myFecha As Date
            Dim provider As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
            myFecha = Date.ParseExact(cFecha, "yyyyMMdd", provider)

            If Date.Parse(DtpFecAsigna.Value.Date) <= myFecha Then
                'MessageBox.Show("Médico no puede ser asignado, motivo que la fecha de retiro es igual a la de reasignación, por favor verifique.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Date.Parse(DtpFecAsigna.Value.Date) = myFecha And dataGridView.Item("nPerAsigEstado", Table1.CurrentRow.Index).Value = 0 And nPerAsigEstado = 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Else
            Return True
        End If

        '------ aqui ------
    End Function

    Private Sub GetPromotor()
        CboPromotor.DataSource = Nothing

        Dim gestionarPerAsigPromotorServicio As GestionarPerAsigPromotorServicio
        gestionarPerAsigPromotorServicio = New GestionarPerAsigPromotorServicio
        If RBtnMedico.Checked Then
            LlenaDataCombo(CboPromotor, gestionarPerAsigPromotorServicio.Get_PerAsigPromotor(1), "cPerPromCodigo", "cPromotor")
        ElseIf RBtnLaboratorio.Checked Then
            LlenaDataCombo(CboPromotor, gestionarPerAsigPromotorServicio.Get_PerAsigPromotor(2), "cPerPromCodigo", "cPromotor")
        ElseIf RBtnConvenio.Checked Then
            LlenaDataCombo(CboPromotor, gestionarPerAsigPromotorServicio.Get_PerAsigPromotor(3), "cPerPromCodigo", "cPromotor")
        ElseIf RBtnCSalud.Checked Then
            LlenaDataCombo(CboPromotor, gestionarPerAsigPromotorServicio.Get_PerAsigPromotor(5), "cPerPromCodigo", "cPromotor")
        End If

    End Sub

    Private Sub FormGestionarPerAsigPromotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormatGrilla(Table1, Me, False, 30)
        FormatGrilla(Table2, Me)

        'Ancho de Fila
        Table1.AutoSizeRowsMode = _
        DataGridViewAutoSizeRowsMode.AllCells

        Table2.AutoSizeRowsMode = _
        DataGridViewAutoSizeRowsMode.AllCells

        GetPromotor()
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RBtnMedico_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnMedico.CheckedChanged
        Try
            GetPromotor()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RBtnLaboratorio_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnLaboratorio.CheckedChanged
        Try
            GetPromotor()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
        Dispose()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If Len(TxtFiltroDato.Text.Trim) > 4 Then
            Call Busqueda()
        Else
            MessageBox.Show("Debe ingresar el dato para filtrar.", "Médica", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub Busqueda()
        Try
            CboPromotor_SelectionChangeCommitted(CboPromotor, Nothing)

            Dim gestionarPerAsigPromotorServicio As New GestionarPerAsigPromotorServicio
            Dim perAsigPromotor As New PerAsigPromotor

            perAsigPromotor.cNameDoctor = RTrim(TxtFiltroDato.Text)
            perAsigPromotor.cPerPromCodigo = CboPromotor.SelectedValue

            If RBtnMedico.Checked Then
                perAsigPromotor.nPerAsigTipo = 1
            ElseIf RBtnLaboratorio.Checked Then
                perAsigPromotor.nPerAsigTipo = 2
            ElseIf RBtnConvenio.Checked Then
                perAsigPromotor.nPerAsigTipo = 3
            ElseIf RBtnCSalud.Checked Then
                perAsigPromotor.nPerAsigTipo = 5
            End If

            Table1.DataSource = gestionarPerAsigPromotorServicio.Get_PerAsigPromotor_Listado_Medico(perAsigPromotor)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Médica", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CboPromotor_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboPromotor.SelectionChangeCommitted

        Try
            Dim gestionarPerAsigPromotorServicio As GestionarPerAsigPromotorServicio
            Dim perAsigPromotor As PerAsigPromotor

            gestionarPerAsigPromotorServicio = New GestionarPerAsigPromotorServicio

            perAsigPromotor = New PerAsigPromotor
            perAsigPromotor.cPerPromCodigo = CboPromotor.SelectedValue

            If RBtnMedico.Checked Then
                perAsigPromotor.nPerAsigTipo = 1
            ElseIf RBtnLaboratorio.Checked Then
                perAsigPromotor.nPerAsigTipo = 2
            ElseIf RBtnConvenio.Checked Then
                perAsigPromotor.nPerAsigTipo = 3
            ElseIf RBtnCSalud.Checked Then
                perAsigPromotor.nPerAsigTipo = 5
            End If

            Table2.DataSource = gestionarPerAsigPromotorServicio.Get_PerAsigPromotor_By_cPerPromCodigo(perAsigPromotor)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Médica", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        If Table1.RowCount = 0 Then Exit Sub

        Try

            If ValidarAsignacion(0, Table1, "cPerAsigCodigo") Then

                Dim perAsigPromotor As PerAsigPromotor
                Dim gestionarPerAsigPromotorServicio As GestionarPerAsigPromotorServicio

                Dim dFechaLim As Date = CDate("01/" & Format(DateAdd(DateInterval.Month, -1, Now.Date), "MM/yyyy"))

                If DtpFecAsigna.Value >= dFechaLim Then
                    If Not ValidaExiste() Then
                        gestionarPerAsigPromotorServicio = New GestionarPerAsigPromotorServicio
                        perAsigPromotor = New PerAsigPromotor

                        perAsigPromotor.cPerPromCodigo = CboPromotor.SelectedValue
                        perAsigPromotor.cPerAsigCodigo = Table1.Item("cPerAsigCodigo", Table1.CurrentRow.Index).Value
                        perAsigPromotor.dEffDate = DtpFecAsigna.Value
                        perAsigPromotor.nPerAsigTipo = IIf(RBtnMedico.Checked, 1, 2)
                        perAsigPromotor.nPerAsigEstado = 1 'Activo

                        If Not gestionarPerAsigPromotorServicio.Insert_PerAsigPromotor(perAsigPromotor) Then
                            Throw New ArgumentException("Ha ocurrido un error, al asignar!")
                        End If

                        BtnBuscar_Click(BtnBuscar, Nothing)
                        Dim cPromCodigo As Object = CboPromotor.SelectedValue
                        Call GetPromotor()
                        CboPromotor.SelectedValue = cPromCodigo
                        CboPromotor_SelectionChangeCommitted(CboPromotor, Nothing)
                    Else
                        MessageBox.Show("Código ya esta asignado al promotor!. Por favor verifique.", "Médica", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Sólo tiene permiso para asignar desde el " & Format(dFechaLim, "dd/MM/yyyy"), "Médica", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Médico no puede ser asignado, motivo que ya existe una asignación en esta fecha o posterior, por favor verifique.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Médica", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click

        If Table2.RowCount = 0 Then Exit Sub

        'Try
        If ValidarAsignacion(1, Table2, "cPerAsigCodigo1") Then
            Dim dFechaLim As Date = CDate("26/" & Format(DateAdd(DateInterval.Month, -1, Now.Date), "MM/yyyy"))

            If DtpFecAsigna.Value >= dFechaLim Then
                If MessageBox.Show("¿Desea quitar médico asignado?", "Sistema Médica", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim gestionarPerAsigPromotorServicio As New GestionarPerAsigPromotorServicio
                    Dim perAsigPromotor As New PerAsigPromotor

                    perAsigPromotor.cPerPromCodigo = CboPromotor.SelectedValue
                    perAsigPromotor.cPerAsigCodigo = Table2.Item("cPerAsigCodigo1", Table2.CurrentRow.Index).Value
                    perAsigPromotor.dEffDate = DtpFecAsigna.Value
                    perAsigPromotor.nPerAsigTipo = IIf(RBtnMedico.Checked, 1, 2)
                    perAsigPromotor.nPerAsigEstado = 0 'Retirado Inactivo

                    If Not gestionarPerAsigPromotorServicio.Insert_PerAsigPromotor(perAsigPromotor) Then
                        Throw New ArgumentException("Ha ocurrido un error, a quitar Médico!")
                    End If

                    BtnBuscar_Click(BtnBuscar, Nothing)
                    Dim cPromCodigo As Object = CboPromotor.SelectedValue
                    Call GetPromotor()
                    CboPromotor.SelectedValue = cPromCodigo
                    CboPromotor_SelectionChangeCommitted(CboPromotor, Nothing)

                    MessageBox.Show("Código fue retirado al promotor!. Por favor verifique.", "Médica", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Sólo tiene permiso para retirar desde el " & Format(dFechaLim, "dd/MM/yyyy"), "Médica", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Médico no puede ser retirado, motivo que existe una asignación en esta fecha o posterior, por favor verifique.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Médica", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub TxtFiltroDato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFiltroDato.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Call Busqueda()
        End If
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        If Table2.RowCount = 0 Then Exit Sub
        ExportarDatosExcel(Table2, "Lista Médicos asignados a: " & CboPromotor.SelectedText)
    End Sub

    Private Sub RBtnCSalud_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnCSalud.CheckedChanged
        Try
            GetPromotor()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RBtnConvenio_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnConvenio.CheckedChanged
        Try
            GetPromotor()
        Catch ex As Exception

        End Try
    End Sub
End Class