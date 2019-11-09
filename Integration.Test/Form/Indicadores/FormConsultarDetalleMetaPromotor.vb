Imports Integration.BL.BL_Persona
Imports Integration.BE.Persona
Imports Integration.BE.Periodo

Public Class FormConsultarDetalleMetaPromotor

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim gcPromotor As String
    Dim gcTipo As String
    Dim gcIni As String
    Dim gcFin As String

    Sub Mostrar(pcNombrePromotor As String, pnTipoAtencion As Long, pcTipo As String, Optional pnPrdCodigo As Long = 0, Optional pcFlagFechas As Boolean = True, Optional pcFlag As String = "X", Optional pcPerPromCodigo As String = "X", Optional cFecIni As String = "1990/01/01", Optional cFecFin As String = "1990/01/01")
        Try
            Dim gestionarMetaPromotorServicio As New GestionarMetaPromotorServicio

            Dim periodo As New Periodo
            periodo.nPrdCodigo = pnPrdCodigo

            LblTipo.Text = "Tipo: " & pcTipo
            LblPromotor.Text = "Promotor: " & pcNombrePromotor

            gcTipo = pcTipo
            gcPromotor = pcNombrePromotor
            gcIni = cFecIni
            gcFin = cFecFin

            Table1.AutoGenerateColumns = False

            Table1.Columns("cPerTercero").HeaderText = pcTipo


            FormatGrilla(Table1, Me)
            If Not pcFlagFechas Then
                periodo.cFlag = pcFlag
                Table1.DataSource = gestionarMetaPromotorServicio.Get_MetaPromotor_Avance(periodo, , , , pcPerPromCodigo)
            Else
                periodo.cFlag = pcFlag
                Table1.DataSource = gestionarMetaPromotorServicio.Get_MetaPromotor_Avance(periodo, "F", cFecIni, cFecFin, pcPerPromCodigo)
            End If
            Me.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
        Dispose()
    End Sub

    Private Sub FormConsultarDetalleMetaPromotor_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub FormConsultarDetalleMetaPromotor_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub

    Private Sub FormConsultarDetalleMetaPromotor_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Arrastre = False
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        If Table1.RowCount = 0 Then Exit Sub
        ExportarDatosExcel(Table1, "Detalle de Ventas " & gcTipo & " - Promotora: " & gcPromotor, "Fecha: " & Date.Now & " Hora: " & Now.Hour & ":" & Now.Minute)
    End Sub
End Class