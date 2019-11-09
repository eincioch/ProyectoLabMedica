Option Explicit On
Imports Integration.BE.Persona
Imports Integration.BL

Public Class FormMarcacion

    Dim FechaHoraActual As Date

    Public Sub Carga_Formulario(Optional ByVal bFlag As Boolean = True)
        LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")
        CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI

        FechaHoraActual = Get_FechaHora_MasMenos(gnAdelantoReloj)
        TimerSegundo.Enabled = True
        TimerHora.Enabled = True
        TxtNroDocId.Focus()
        BtnCerrar.Visible = bFlag
        If bFlag Then
            Me.Show()
        Else
            Me.ShowDialog()
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.Click
        Try
            Dim Obj As New BE_Req_Marcacion
            Dim BL As New BL_Marcacion
            Dim objPer As New BE_ReqPersona()
            Dim BLPer As New BL_Personas

            LblMsg.Text = ""

            'Buscar Trabajador por DNI
            Dim ObjBuscar As New BE_ReqPerIdentifica

            ObjBuscar.nPerIdeTipo = CInt(CboTipoDocu.SelectedValue)
            ObjBuscar.cPerIdeNumero = TxtNroDocId.Text.Trim

            objPer = BLPer.Get_Trabajador_By_TipoDoc_DocId(ObjBuscar)
            'Si encontró al trabajador, registrar marcación
            If objPer.cPerCodigo <> "" Then
                Obj.cFechaHora = Format(FechaHoraActual, "yyyy-MM-dd HH:mm:ss")
                Obj.cHost = My.Computer.Name.ToUpper
                Obj.cPerIdeNumero = objPer.cPerIdeNumero
                Obj.cPerJurCodigo = StrcPerJuridica
                Obj.nDeviceID = 0
                Obj.nPerIdeTipo = ObjBuscar.nPerIdeTipo
                Obj.cPerCodigo = objPer.cPerCodigo

                If BL.Set_tb_reportslist(Obj) Then
                    LblMsg.Text = objPer.cNombreCompleto & vbCrLf & "Marcación Exitosa"
                    LblMsg.ForeColor = Color.Green
                Else
                    LblMsg.Text = "Error inesperado, vuelva a intentar."
                    LblMsg.ForeColor = Color.Red
                End If
                If BtnCerrar.Visible = False Then
                    Close()
                    Dispose()
                End If
            Else
                LblMsg.Text = "No se ha encontrado su DNI. Comuníquese con RRHH."
                LblMsg.ForeColor = Color.Red
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click
        Close()
        Dispose()
    End Sub

    Private Sub TimerSegundo_Tick(sender As Object, e As EventArgs) Handles TimerSegundo.Tick
        FechaHoraActual = DateAdd("s", 1, FechaHoraActual)
        LblHora.Text = Format(FechaHoraActual, "hh:mm:ss tt")
        LblFecha.Text = Format(FechaHoraActual, "Long Date")
    End Sub

    Private Function Get_FechaHora_MasMenos(Optional ByVal nSegundos As Long = 0) As Date
        Dim Request As New BE.Sistema.BE_ReqFechaServidor
        Dim ObjBL As New BL.BL_Sistema

        Get_FechaHora_MasMenos = ObjBL.Get_FechaHoraServidor_MasMenos(Request, nSegundos)
    End Function

    Private Sub TimerHora_Tick(sender As Object, e As EventArgs) Handles TimerHora.Tick
        TimerSegundo.Enabled = False
        FechaHoraActual = Get_FechaHora_MasMenos(gnAdelantoReloj)
        TimerSegundo.Enabled = True
    End Sub

    Private Sub FormMarcacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        If BtnCerrar.Visible Then Carga_Formulario(True)
    End Sub

    Private Sub TxtNroDocId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNroDocId.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Call BtnGuardar_Click(Nothing, Nothing)
        End If
    End Sub
End Class