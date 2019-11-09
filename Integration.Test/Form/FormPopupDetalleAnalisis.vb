Imports Integration.BE.CtasCtes
Imports Integration.BL.BL_CtaCteListaServicio

Public Class FormPopupDetalleAnalisis

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click

        StrPasaValores = vbNullString
        Close()
        Dispose()

    End Sub

    Private Sub FormPopupDetalleAnalisis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim Objeto As New BE_ReqCtaCteServicio
        Dim Servicio As New BLCtaCteListaServicio
        Dim dt As New DataTable

        Objeto.cPerJurCodigo = StrcPerJuridica
        Objeto.cCtaCteSerJerarquia = TokenByKey(StrPasaValores, "cCtaCteSerJerarquia")

        dt = Servicio.Get_CtaCteListaServicio_by_cPerJurCodigo_and_cCtaCteSerJerarquia(Objeto)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow

            For Each row In dt.Rows
                LblAnalisis.Text = CStr(row("cCtaCteSerKeyWord").ToString)
                LblTipoMuestra.Text = CStr(row("TipoMuestra").ToString)
                LblVolumenMinimo.Text = CStr(row("cVolumMinimo").ToString)
                LblTipoEnvase.Text = CStr(row("TipoEnvase").ToString)
                LblDiasProceso.Text = CStr(row("cDiaHoraProceso").ToString)
                LblCondiciones.Text = CStr(row("cPreparaPaciente").ToString)
            Next
        End If

    End Sub

End Class