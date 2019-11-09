Option Explicit On

Imports Integration.DataIntegration
Imports Integration.BE
Imports Integration.BL

Public Class FormLoginAutoriza

    Dim ObjEncrypt As New Integration.Conection.clsCrypt

    Dim RequestPer As New BE.PerUsuario.BE_ReqSearhUsuario
    Dim ObjBLPer As New BL_PerUsuario

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        nFlagDscto = 0 'denegado
        nFlagCortesia = 0 'denegado
        Close()
        Dispose()
    End Sub

    Private Sub BtnAccesar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAccesar.Click

        If Cbo_User.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un usuario de la lista..!!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cbo_User.Focus()
            Exit Sub
        End If

        Dim Usuario As String = UCase(Trim(Cbo_User.Text))

        RequestPer.cPerUsuCodigo = Usuario
        RequestPer.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
        RequestPer.nObjCodigo = nSisGruCodigo.AdmisionAprobador

        Dim dt2 As New DataTable
        dt2 = ObjBLPer.Get_UsuarioAutorizado(RequestPer)

        If dt2.Rows.Count > 0 And ObjEncrypt.EncryptByCode(Usuario, Txt_Pass.Text) = dt2.Rows(0).Item("cClave").ToString Then

            If frmSisGruCodigo = nSisGruCodigo.AdmisionAprobador Then
                nFlagDscto = 1    'permitir descuento
            Else
                nFlagCortesia = 1 'permitir cortesía
            End If

            StrPasaValores = vbNullString
            StrPasaValores = "cPerCodUsuario=" & Cbo_User.SelectedValue.ToString & ";"
            StrPasaValores = StrPasaValores & "nSisGruCodigo=" & CStr(frmSisGruCodigo)

            Close()
            Dispose()
        Else
            MsgBox("Usted No tiene permiso, para aplicar Descuentos.", vbExclamation, "Denegado...")
            Txt_Pass.Text = ""
            Txt_Pass.Focus()
        End If

        'Seteo la variable
        cKeyToken = ""
        nFlagToken = 0 'Seteo variable a 0-No utilizo Token
        dt2.Dispose()

    End Sub

    Private Sub FormLoginAutoriza_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            'Lista los usuario que tienen permiso
            RequestPer.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
            If frmSisGruCodigo = nSisGruCodigo.AdmisionAprobador Then
                RequestPer.nObjCodigo = nSisGruCodigo.AdmisionAprobador
            Else
                RequestPer.nObjCodigo = nSisGruCodigo.AdmisionCortesia
            End If
            LlenaDataCombo(Cbo_User, ObjBLPer.Get_CboListUsuarioAutorizado(RequestPer), "cPerCodigo", "cPerUsuCodigo")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnKeyToken_Click(sender As Object, e As EventArgs) Handles BtnKeyToken.Click

        If Cbo_User.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un usuario de la lista..!!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cbo_User.Focus()
            Exit Sub
        End If

        Dim Usuario As String = UCase(Trim(Cbo_User.SelectedValue))

        RequestPer.cPercodigo = Usuario
        RequestPer.cPerJurCodigo = StrcPerJuridica
        RequestPer.nObjCodigo = frmSisGruCodigo

        Dim dt2 As New DataTable
        dt2 = ObjBLPer.ADMISION_Get_Token_By_Per_Sede_Tipo(RequestPer)

        If dt2.Rows.Count > 0 Then
            Txt_Pass.Text = dt2.Rows(0).Item("cToken").ToString
            If Not Validar_AdmSolPerToken(Cbo_User.SelectedValue.ToString, StrcPerJuridica, Txt_Pass.Text, frmSisGruCodigo) Then
                MessageBox.Show("Clave Token ya ha sido utilizada en otra operación, por favor verifique.", "Token", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'Seteo la variable para almacenar Token
            cPerAutToken = Cbo_User.SelectedValue.ToString
            cKeyToken = dt2.Rows(0).Item("cToken").ToString
            nFlagToken = 1 'Seteo variable a 1-Se ha obtenido Token.

            FormPrcSolAtencion.TxtValor.Text = dt2.Rows(0).Item("fPorcentaje")
            FormPrcSolAtencion.TxtValor.Enabled = False
            If frmSisGruCodigo = nSisGruCodigo.AdmisionAprobador Then
                nFlagDscto = 1    'permitir descuento
            Else
                nFlagCortesia = 1 'permitir cortesía
            End If
            StrPasaValores = vbNullString
            StrPasaValores = "cPerCodUsuario=" & Cbo_User.SelectedValue.ToString & ";"
            StrPasaValores = StrPasaValores & "nSisGruCodigo=" & CStr(frmSisGruCodigo)
            Close()
            Dispose()
        Else
            MsgBox("No se ha encontrado Clave Token, por favor verifique que Usuario esta autorizando.", vbExclamation, "Denegado...")
            nFlagToken = 0
            Txt_Pass.Text = ""
            Txt_Pass.Focus()
        End If
        dt2.Dispose()

    End Sub

End Class