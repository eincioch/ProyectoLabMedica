Imports Integration.BL

Public Class FormCambioSede

    Dim ObjEncrypt As New Integration.Conection.clsCrypt

    Dim Request As New BE.Sistema.BE_ReqFechaServidor
    Dim RequestEmp As New BE.Sistema.BE_ReqSistema

    Dim RequestPer As New BE.PerUsuario.BE_ReqSearhUsuario
    Dim ObjBLPer As New BL_PerUsuario
    Dim ObjBL As New BL_Sistema

    'Dim StrUser As String
    Dim SrtPass As String

    Sub Cargar_Empresas_por_Permisos()
        Dim dt2 As New DataTable
        RequestPer.PerCodigo = FormMDI.SSUser.Text
        dt2 = ObjBLPer.Get_Persona_By_Usuario(RequestPer)
        StrUser = dt2.Rows(0).Item("cPerCodigo").ToString
        RequestEmp.cPerCodigo = StrUser
        RequestEmp.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
        LlenaDataCombo(CboEmpresa, ObjBL.Get_Empresas_Per_Mod(RequestEmp), "cPerCodigo", "cPerNombre")
    End Sub

    Private Sub FormCambioSede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Empresas_por_Permisos()
        CboEmpresa.SelectedValue = StrcPerJuridica
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
        Dispose()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If CboEmpresa.SelectedValue.ToString <> "" Then
            'Cambiando variable global de Sede
            StrcPerJuridica = CboEmpresa.SelectedValue.ToString
            FormMDI.SSSucursal.Text = UCase(CboEmpresa.Text)
            Close()
            Dispose()
        Else
            MessageBox.Show("No ha seleccionado ninguna sede.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class