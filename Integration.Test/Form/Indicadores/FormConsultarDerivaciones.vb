Imports Integration.BL.BL_Persona
Imports Integration.BE.Persona
Imports Integration.BE.Periodo

Public Class FormConsultarDerivaciones

    Private blnAjustarCeldas As Boolean = True

    Private Sub FormConsultarDerivaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FormatGrilla(Table1, Me)

            ' configurar el estilo predeterminado del DataGridView 
            ' para que divida el texto de las celdas en varias líneas 
            Me.Table1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub C1CmdMostrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdMostrar.Click

        Try
            Dim gestionarMetaPromotorServicio As New GestionarMetaPromotorServicio

            If Not RBtnDia.Checked Then
                If Not RBtnQTY.Checked Then
                    Table1.DataSource = gestionarMetaPromotorServicio.Get_Derivaciones_Qty_Amount(Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"), "M", "I")
                Else
                    Table1.DataSource = gestionarMetaPromotorServicio.Get_Derivaciones_Qty_Amount(Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"), "M", "C")
                End If

            Else
                If Not RBtnQTY.Checked Then
                    Table1.DataSource = gestionarMetaPromotorServicio.Get_Derivaciones_Qty_Amount(Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"), "D", "I")
                Else
                    Table1.DataSource = gestionarMetaPromotorServicio.Get_Derivaciones_Qty_Amount(Format(DTPFecIni.Value, "yyyy/MM/dd"), Format(DTPFecFin.Value, "yyyy/MM/dd"), "D", "C")
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub FormConsultarMetaPromotor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F5))
                C1CmdMostrar_Click(C1CmdMostrar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F8))
                C1CmdExportExcel_Click(C1CmdExportExcel, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select

    End Sub

    Private Sub C1CmdExportExcel_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExportExcel.Click
        If Table1.RowCount = 0 Then Exit Sub
        ExportarDatosExcel(Table1, "Derivación Médico por Promotor", "Agrupado por " & IIf(Not RBtnDia.Checked, " Mes con", " Día con") & IIf(Not RBtnQTY.Checked, " Importe", " Cantidad"))
    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Close()
        Dispose()

    End Sub

    Private Sub FormConsultarDerivaciones_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If blnAjustarCeldas Then
            blnAjustarCeldas = False
            Me.Table1.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
        End If
    End Sub

    Private Sub Table1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Table1.Scroll
        Me.Table1.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
    End Sub

End Class