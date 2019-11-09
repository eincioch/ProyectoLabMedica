Option Explicit On
Imports Integration.BE.CtasCtes
Imports Integration.BL

Public Class FormCtaCteDatosImpresora

    Dim nFlag As Integer

    Enum GrillaDatosPrint
        ColcPerJurCodigo = 0
        ColcEmpresa = 1
        ColnCajCodigo = 2
        ColcCaja = 3
        ColcSerie = 4
        ColcNombreImpresora = 5
        ColcPort = 6
        ColcCodAutSUNAT = 7

    End Enum

    Private Sub Inicializa()

        Dim RequestCtaCte As New BE_ReqCtaCteNumeracion
        Dim ObjCtaCteNum As New BL_CtaCteNumeracion

        LlenaDataCombo(CboCaja, ObjConst.Get_Constante("C", CboCaja.Tag), "nConValor", "cConDescripcion")
        LlenaDataCombo(CboPortPrint, ObjConst.Get_Constante("C", CboPortPrint.Tag), "nConValor", "cConDescripcion")

        'Llena Grid
        RequestCtaCte.cPerJurCodigo = StrcPerJuridica
        Table1.DataSource = ObjCtaCteNum.Get_Medica_CtaCteDatosImpresora_by_cPerJurCodigo(RequestCtaCte)

    End Sub

    Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False

        If CboCaja.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label1.Text, CboCaja)
            Exit Function
        End If

        If TxtSerial.Text = "" Then
            MsgInfoCampoObligatorio(Label8.Text, TxtSerial)
            Exit Function
        End If

        If TxtNombPrint.Text = "" Then
            MsgInfoCampoObligatorio(Label9.Text, TxtNombPrint)
            Exit Function
        End If

        If TxtCodSunat.Text = "" Then
            MsgInfoCampoObligatorio(Label10.Text, TxtCodSunat)
            Exit Function
        End If

        If CboPortPrint.SelectedIndex = -1 Then
            MsgInfoCampoObligatorio(Label11.Text, CboPortPrint)
            Exit Function
        End If

        ValidaCamposObligatorios = True

    End Function

    Private Sub FormCtaCteDatosImpresora_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F6))
                C1CmdNuevo_Click(C1CmdNuevo, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F4))
                C1CmdGuardar_Click(C1CmdGuardar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F7))
                C1CmdEdit_Click(C1CmdEdit, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select
    End Sub

    Private Sub FormCtaCteDatosImpresora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatGrilla(Table1, Me, False, 30)
        Call Inicializa()
        EstadoCmdLink(C1CmdNuevo, True, C1CmdGuardar, False, C1CmdCancelar, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBxKey, False)
    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub C1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdNuevo.Click
        nFlag = 0
        TxtSerial.Text = "" : TxtNombPrint.Text = "" : TxtCodSunat.Text = ""
        Table1.Enabled = False : CboCaja.Enabled = True
        EstadoCmdLink(C1CmdNuevo, False, C1CmdGuardar, True, C1CmdCancelar, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBxKey, True)
        Me.ActiveControl = CboCaja
    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click
        nFlag = 1
        EstadoCmdLink(C1CmdNuevo, False, C1CmdGuardar, True, C1CmdCancelar, True, C1CmdEdit, False, C1CmdCerrar, False, GrpBxKey, True)
        Table1.Enabled = False : CboCaja.Enabled = False : Me.ActiveControl = TxtSerial
    End Sub

    Private Sub C1CmdGuardar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdGuardar.Click

        Try
            Dim Objeto As New BE_ReqCtaCteNumeracion
            Dim Servicio As New BL_CtaCteNumeracion

            Dim Resultado As Boolean

            If ValidaCamposObligatorios() Then

                Objeto.cPerJurCodigo = StrcPerJuridica
                Objeto.nCajCodigo = CLng(CboCaja.SelectedValue)
                Objeto.cCtaCteSerie = TxtSerial.Text
                Objeto.cNombreImpresora = TxtNombPrint.Text
                Objeto.cCodAutSUNAT = TxtCodSunat.Text
                Objeto.cPort = CboPortPrint.Text

                Select nFlag
                    Case 0
                        REM insert
                        If Not Servicio.Ins_Medica_CtaCteDatosImpresora(Objeto) Then
                            Throw New System.Exception("Se encontraron errores. [Ins_Medica_CtaCteDatosImpresora], consulte al administrador del sistema")
                        Else
                            Resultado = True
                        End If

                    Case 1
                        REM update
                        If Not Servicio.Upd_Medica_CtaCteDatosImpresora(Objeto) Then
                            Throw New System.Exception("Se encontraron errores. [Upd_Medica_CtaCteDatosImpresora], consulte al administrador del sistema")
                        Else
                            Resultado = True
                        End If
                End Select

                If Resultado Then
                    MessageBox.Show("Operacion se realizo con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call C1CmdCancelar_Click(C1CmdCancelar, Nothing)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub C1CmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCancelar.Click
        EstadoCmdLink(C1CmdNuevo, True, C1CmdGuardar, False, C1CmdCancelar, False, C1CmdEdit, True, C1CmdCerrar, True, GrpBxKey, False)
        Call Inicializa()
        Table1.Enabled = True
    End Sub

    Private Sub Table1_SelectionChanged(sender As Object, e As System.EventArgs) Handles Table1.SelectionChanged

        With Table1
            If .RowCount > 0 Then
                CboCaja.SelectedValue = .Item(GrillaDatosPrint.ColnCajCodigo, .CurrentRow.Index).Value.ToString
                TxtSerial.Text = .Item(GrillaDatosPrint.ColcSerie, .CurrentRow.Index).Value.ToString
                TxtNombPrint.Text = .Item(GrillaDatosPrint.ColcNombreImpresora, .CurrentRow.Index).Value.ToString
                TxtCodSunat.Text = .Item(GrillaDatosPrint.ColcCodAutSUNAT, .CurrentRow.Index).Value.ToString
                CboPortPrint.Text = .Item(GrillaDatosPrint.ColcPort, .CurrentRow.Index).Value.ToString
            End If
        End With

    End Sub

End Class