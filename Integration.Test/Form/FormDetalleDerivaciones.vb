Imports Integration.BL.BL_FichaAtencion
Imports Integration.BL.BL_Persona

Public Class FormDetalleDerivaciones

    'Dim dtPruebas As New DataTable

    Sub Mostrar(ByVal pnSolAdmNumero As String, pcPaciente As String)
        If pnSolAdmNumero <> "" Then
            LblnSolNumero.Text = pnSolAdmNumero
            LblPaciente.Text = pcPaciente

            FormatGrilla(TPruebas, Me, False, 25, False, DataGridViewSelectionMode.CellSelect)

            Dim ObjPer As New BL.BL_Personas

            Dim dt As New DataTable
            dt = ObjPer.Get_ListPer_By_cPerRelTipo("57")

            If dt.Rows.Count > 0 Then
                Dim row As DataRow
                row = dt.NewRow()
                row("cPerCodigo") = "1000098770"
                row("cNombre") = "LOCAL"
                dt.Rows.Add(row)
            End If

            LlenaDataCombo(CboLabRef, dt, "cPerCodigo", "cNombre")

            CboLabRef.SelectedValue = "1000098770"

            Call Cargar()

            'LlenaListBox(LBPruebas, dtPruebas, "nCtaCteSerCodigo", "cPrueba")

            ' ''Set view property
            'LVLista.View = View.Details
            'LVLista.GridLines = True
            'LVLista.FullRowSelect = True

            ''Add column header
            'LVLista.Columns.Add("Código", 0)
            'LVLista.Columns.Add("Prueba", 150)
            'LVLista.Columns.Add("Cód. Procesado en", 0)
            'LVLista.Columns.Add("Procesado en", 100)

            Me.CenterToScreen()
            Me.ShowDialog()

        End If
    End Sub


    Sub Cargar()
        Dim ObjFicha As New BL_FichaAtencion


        Dim dt As DataTable = ObjFicha.Get_Pruebas_By_nSolAdmNumero(LblnSolNumero.Text.Trim)

            EliminarRowsDgView(TPruebas)
            Dim nPos As Integer = 0

        If dt.Rows.Count > 0 Then
            Dim row As DataRow

            TPruebas.DataSource = Nothing

            For Each row In dt.Rows
                With TPruebas
                    nPos = .RowCount()
                    .Rows.Add()
                    .Item("nFlag", nPos).Value = False 'CStr(row("nCtaCteSerCodigo").ToString)
                    .Item("cPrueba", nPos).Value = CStr(row("cPrueba").ToString)
                End With
            Next
        End If

        dt.Dispose()

    End Sub

    Private Sub ChkMarcarPruebas_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMarcarPruebas.CheckedChanged
        Dim a As Integer
        For a = 0 To LBPruebas.Items.Count - 1
            LBPruebas.SetSelected(a, ChkMarcarPruebas.Checked)
        Next a
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Call CargarDetalle()

        'LVLista.Items.Add, , "Carlos", "normal", "pequeño"
        'Dim arr(4) As String
        'Dim itm As ListViewItem

        'For Each item As DataRowView In LBPruebas.SelectedItems
        '    Dim row As DataRow = item.Row

        '    arr(0) = CStr(row(1))
        '    arr(1) = CStr(row(0))
        '    arr(2) = CboLabRef.SelectedValue.ToString
        '    arr(3) = CboLabRef.Text
        '    itm = New ListViewItem(arr)
        '    LVLista.Items.Add(itm)
        '    Dim borra As DataRow = Nothing
        '    For Each fila In dtPruebas.Rows
        '        If fila("nCtaCteSerCodigo") = arr(0) Then
        '            borra = fila
        '            Exit For
        '        End If
        '    Next

        '    If Not borra Is Nothing Then
        '        LBPruebas.DataSource = Nothing
        '        dtPruebas.Rows.Remove(row)
        '        LBPruebas.DataSource = dtPruebas
        '    End If

        'Next




    End Sub

    Sub CargarDetalle()

        ''EliminarRowsDgView(TPruebas)
        'Dim nPos As Integer = 0

        'If dt.Rows.Count > 0 Then
        '    Dim row As DataRow

        '    TPruebas.DataSource = Nothing

        '    For Each row In dt.Rows
        '        With TPruebas
        '            nPos = .RowCount()
        '            .Rows.Add()
        '            .Item("nFlag", nPos).Value = "0" 'CStr(row("nCtaCteSerCodigo").ToString)
        '            .Item("cPrueba", nPos).Value = CStr(row("cPrueba").ToString)
        '        End With
        '    Next
        'End If

        'dt.Dispose()

    End Sub


End Class