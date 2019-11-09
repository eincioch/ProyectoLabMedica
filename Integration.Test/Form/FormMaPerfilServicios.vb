Option Explicit On

Imports Integration.BL.BL_CtasCtesMedica

Public Class FormMaPerfilServicios

    Enum GrillaPerfil
        ColcPerJurCodigo = 0
        ColnIntCodigo = 1
        ColnCtaCteSerCodigo = 2
        ColcCtaCteSerJerarquia = 3
        ColcCtaCteSerKeyWord = 4
        ColnMonCodigo = 5
        ColnCtaCteSerImpDef = 6
        ColcPerUsuCodigo = 7
    End Enum

    Private Sub FormMaPerfilServicios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FormatGrilla(Table1, Me, True)
        LlenaDataCombo(CboPerfil, ObjInterface.Get_Interface(CLng(TokenByKey(CboPerfil.Tag, "nIntClase")), CLng(TokenByKey(CboPerfil.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")
    End Sub

    Private Sub C1CmdAgregar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdAgregar.Click

        FormServicios = 2 '--FormMaPerfilServicios Form
        FormFiltroServicios.ShowDialog()

        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerImpDef", Table1), True)

        Table1.Refresh()

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Close()
        Dispose()
    End Sub

    Private Sub C1CmdGrabar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGrabar.Click

        Try
            Dim Servicio As New BLPerfilServicio

            With Table1
                For Each row As DataGridViewRow In .Rows
                    If Not Servicio.Ins_PerfilServicio(row.Cells(GrillaPerfil.ColcPerJurCodigo).Value.ToString, CInt(row.Cells(GrillaPerfil.ColnIntCodigo).Value), CInt(row.Cells(GrillaPerfil.ColnCtaCteSerCodigo).Value), CInt(row.Cells(GrillaPerfil.ColnMonCodigo).Value), CDbl(row.Cells(GrillaPerfil.ColnCtaCteSerImpDef).Value), StrUser) Then
                        Throw New System.Exception("Se encontraron errores [Ins_PerfilServicio]. Form")
                    End If
                Next
                CboPerfil_SelectionChangeCommitted(CboPerfil, Nothing)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Table1_CellEndEdit(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellEndEdit

        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerImpDef", Table1), True)

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
        If columna = 6 Then ' Precio

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

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

    Private Sub CboPerfil_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboPerfil.SelectionChangeCommitted

        '-----------------
        'Carga Perfil
        '-----------------
        Dim nPos As Integer = 0
        Dim Servicio As New BLPerfilServicio
        Dim dt As New DataTable

        EliminarRowsDgView(Table1)

        dt = Servicio.Get_PerfilServicio(StrcPerJuridica, CInt(CboPerfil.SelectedValue))
        'Datos enlazados no es factible para despues agregar mas items
        'Table1.DataSource = dtDetAdmSol

        'Leyendo un DataTable
        If dt.Rows.Count > 0 Then
            Dim row As DataRow

            For Each row In dt.Rows
                With Table1
                    nPos = .RowCount()
                    .Rows.Add()
                    .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                    .Item("nIntCodigo", nPos).Value = CInt(row("nIntCodigo").ToString)
                    .Item("nCtaCteSerCodigo", nPos).Value = CInt(row("nCtaCteSerCodigo").ToString)
                    .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
                    .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                    .Item("nMonCodigo", nPos).Value = CInt(row("nMonCodigo").ToString)
                    .Item("nCtaCteSerImpDef", nPos).Value = CDbl(row("nCtaCteSerImpDef").ToString)
                    .Item("cPerUsuCodigo", nPos).Value = CStr(row("cPerUsuCodigo").ToString)
                End With

            Next

        End If

        Table1.PerformLayout()
        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerImpDef", Table1), True)
    End Sub

    Private Sub C1CmdQuitar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdQuitar.Click
        If Table1.RowCount = 0 Then Exit Sub

        Try
            With Table1
                Dim Servicio As New BLPerfilServicio

                'Eliminar de BD
                Servicio.Del_PerfilServicio(StrcPerJuridica, CInt(.Rows(.CurrentRow.Index).Cells(GrillaPerfil.ColnIntCodigo).Value), .Rows(.CurrentRow.Index).Cells(GrillaPerfil.ColnCtaCteSerCodigo).Value.ToString)
                Call EliminaRowSeleccionada(Table1)
            End With

            LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerImpDef", Table1), True)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub C1CmdCalcPrecio_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCalcPrecio.Click

        If Len(LblTotalPago.Text) = 0 Then Exit Sub

        If FormatNumber(TxtPrecioPromo.Text) <= FormatNumber(LblTotalPago.Text) Then

            Dim nPorcentaje As Double

            nPorcentaje = TxtPrecioPromo.Text / LblTotalPago.Text

            With Table1
                For Renglones As Integer = 0 To .RowCount - 1
                    .Item("nCtaCteSerImpDef", Renglones).Value = Format(.Item("nCtaCteSerImpDef", Renglones).Value * nPorcentaje, "#,###.00")
                Next
            End With
        End If

        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerImpDef", Table1), True)

    End Sub

End Class