Option Explicit On

Imports Integration.BE
Imports Integration.BL
Imports System.Windows.Forms

Public Class FormMDI
    Private mMenu As New MainMenu()
    Dim Obj As New BL_Sistema

    Private Sub Actualizar_BarraEstado()
        Dim ObjInfo As New Sistema.BE_Info
        ObjInfo = Obj.Consulta_Info()
        Me.SSServer.Text = " " & ObjInfo.Server & " "
        Me.SSNameDB.Text = " " & ObjInfo.BD & " "
        Me.SSReport.Text = cPathRPT
    End Sub

    Private Sub FormMDI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Actualizar_BarraEstado()

        'carga periodo actual
        'CargarPeriodoActual()

        LblVersion.Text = SSVersion.Text & " " & Status_Version()
        Call Cargar_Menu(StrUser, Mod_AdmisionMedica)

        'validar si tiene fecha de apertura
        If Not ValidarApertura(1) Then
            FormGestionarPerOperacion.ShowDialog()
            If StrcPerJuridica = "4600000004" Or StrcPerJuridica = "4800000007" Or StrcPerJuridica = "4900000008" Then
                FormMarcacion.BtnCerrar.Visible = False
                FormMarcacion.Carga_Formulario(False)
            End If
        End If

    End Sub

    Sub Cargar_Menu(cPercodigo As String, cModulo As String)
        Dim Request As New BE.PerUsuGruAcc.BE_Req_PermisosMenu
        Dim Response As New List(Of BE.Interface.BE_Res_Interface)()
        Dim ObjBL As New BL_PerUsuGruAcc

        Request.cPerCodigo = StrUser
        Request.cModulo = cModulo

        Response = ObjBL.ObtenerPermisosMenu(Request)
        Dim cNivelAnt As String = ""
        Dim i As Long
        Dim MI As MenuItem
        For i = 0 To Response.Count - 1
            If i = 0 Then
                MI = New MenuItem
                MI.Name = Response.Item(i).cIntNombre
                MI.Text = Response.Item(i).cIntDescripcion
            ElseIf Len(cNivelAnt) <= Len(Response.Item(i).cIntJerarquia) Then
                Dim MIHijo As New MenuItem

                With MI.MenuItems.Add(Response.Item(i).cIntNombre, New EventHandler(AddressOf mnuDinamico_Click))
                    .Name = Response.Item(i).cIntNombre
                    .Text = Response.Item(i).cIntDescripcion
                    If .Name = "MNUADMMEDAYUVER" Then
                        .Shortcut = Shortcut.F1
                        .ShowShortcut = True
                    End If
                    If .Name = "MNUADMMEDVEN" Then
                        .MdiList = True
                    End If
                End With
            ElseIf Len(cNivelAnt) > Len(Response.Item(i).cIntJerarquia) Then
                mMenu.MenuItems.Add(MI)

                MI = New MenuItem
                MI.Name = Response.Item(i).cIntNombre
                MI.Text = Response.Item(i).cIntDescripcion

            End If

            If Response.Item(i).nIntTipo <> 1 Then
                cNivelAnt = Response.Item(i).cIntJerarquia
            End If

        Next
        If Response.Count > 0 Then
            mMenu.MenuItems.Add(MI)
            Me.Menu = mMenu
        End If
    End Sub

    Private Sub mnuDinamico_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case CType(sender, MenuItem).Name
            Case "MNUADMMEDUSU"

                llamarform(Form1, Me)


            Case "MNUADMMEDCONF"
                llamarform(FormConfigSys, Me)
            Case "MNUADMMEDCFGLIS"
                llamarform(FormConfigReportsLIS, Me)
            Case "MNUADMMEDCBOSEDE"
                llamarform(FormCambioSede, Me)
            Case "MNUADMMODAPERCIERSUC"
                If Not ValidarApertura(2) Then
                    FormGestionarPerOperacion.ShowDialog()
                Else
                    MessageBox.Show("Udted ya ha realizado el cierre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case "MNUADMMEDMARC"
                FormMarcacion.BtnCerrar.Visible = True
                llamarform(FormMarcacion, Me)
            Case "MNUADMMEDQUIT"
                Me.Close()
                Me.Dispose()
                Application.Exit()
                End

                'Maestros
            Case "MNUADMMEDMNTPER"
                llamarform(FormGridPersona, Me)
            Case "MNUADMMEDMNTTSERV"
                llamarform(FormMaTipoServicios, Me)
            Case "MNUADMMEDMNTCMPSERV"
                llamarform(FormMaServiciosComponentes, Me)
            Case "MNUADMMEDMNTPERFIL"
                llamarform(FormMaPerfilServicios, Me)
            Case "MNUADMMEDMNTCAMP"
                llamarform(FormMaCampana, Me)
            Case "MNUADMMEDCAJANUM"
                llamarform(FormCtaCteNumeracionC, Me)

            Case "MNUADMMEDMNTCONFIGPRINT"
                llamarform(FormCtaCteDatosImpresora, Me)

            Case "MNUADMMEDTIPOCAMBIO"
                llamarform(FormTipodeCambio, Me)
            Case "MNUADMMEDCONSIST"
                llamarform(FormConstante, Me)

                'Registro Adminision
            Case "MNUADMMEDREGFICADM"
                llamarform(FormGridFichaAtencion, Me)
            Case "MNUADMMEDREGFACTBLOQUE"
                llamarform(FormPrcCtaCteFacturacionBloque, Me)
            Case "MNUADMMEDREGSQLPRECIO"
                FormServicios = 0 'Setear que sólo será consulta de precios sin persona
                llamarform(FormPrcSQLPrecio, Me)
            Case "MNUADMMEDRPTREIMP"
                llamarform(FormPrcReImpresionDocu, Me)
            Case "MNUADMMEDREGANLCMP"
                llamarform(FormPrcAnulacionComprobante, Me, "ANULA")
            Case "MNUADMMEDREGNOTCRCMP"
                llamarform(FormPrcAnulacionComprobante, Me, "NOTACRED")
            Case "MNUADMMEDREGPORDCSTO"
                llamarform(FormMaPorcDsctoEntidades, Me)
            Case "MNUADMMEDREGASIGMEDPROM"
                llamarform(FormGestionarPerAsigPromotor, Me)
            Case "MNUADMMEDREGFORMINDICAVTAPROM"
                llamarform(FormGestionarMetaPromotor, Me)

                'Reporte
            Case "MNUADMMEDRPTCDRCJ"
                llamarform(FormRptCuadreCaja, Me)
            Case "MNUADMMEDRPTVTACONS"
                llamarform(FormRptVentaporSucursalConso, Me)
            Case "MNUADMMEDRPTVTAFECATEN"
                llamarform(FormRptVentaporFechaAtencion, Me)
            Case "MNUADMMEDRPTREGVTAS"
                llamarform(FormPrcLibroVta, Me)
            Case "MNUADMMEDRPTCOMISDOCTOR"
                llamarform(FormRptComisionDoctor, Me)
            Case "MNUADMMEDRPTINGLABCONV"
                llamarform(FormRptIngresosLabConv, Me)
            Case "MNUADMMEDRPTVTAXTURNO"
                llamarform(FormRptVentasxTurno, Me)
            Case "MNUADMMEDRPTVTASXEXAM"
                llamarform(FormRankingExamenes, Me)
            Case "MNUADMMEDRPTLISTEXAPRECIO"
                llamarform(FormReportCtaCteListaServicio, Me)
            Case "MNUADMMEDRPTSQLMETAAVANCE"
                llamarform(FormConsultarMetaPromotor, Me)
            Case "MNUADMMEDRPTCER"
                llamarform(FormRptCER, Me)

                'Analisis de venta
            Case "MNUADMMEDVTASDERIVACIONMED"
                llamarform(FormConsultarDerivaciones, Me)

            Case "MNUADMMEDVTASDIARIO"
                llamarform(FormConsultarVentasDiarias, Me)

                'Ventana
            Case "MNUADMMEDVENMIN"
                For i As Integer = 0 To Me.MdiChildren.Length - 1
                    Me.MdiChildren(i).WindowState = FormWindowState.Minimized
                Next
            Case "MNUADMMEDVENMAX"
                For i As Integer = 0 To Me.MdiChildren.Length - 1
                    Me.MdiChildren(i).WindowState = FormWindowState.Maximized
                Next
            Case "MNUADMMEDVENCAS"
                Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)

            Case "MNUADMMEDAYUVER"

                Dim exists As Boolean
                exists = System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory().ToString & "\Ayuda_Medica.chm")
                If exists Then
                    Process.Start(System.IO.Directory.GetCurrentDirectory().ToString & "\Ayuda_Medica.chm")
                Else
                    MessageBox.Show("Archivo Ayuda_Medica.chm no existe.!", "Sistema Médica", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case "MNUADMMEDAYUNOT"
                NotificarErrorAyuda.Show()
        End Select
        Actualizar_BarraEstado()
    End Sub

    Private Sub TSMnuItemConstante_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemConstante.Click
        llamarform(FormConstante, Me)
    End Sub


    Private Sub TSMnuItemTipoDocu_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemTipoDocu.Click
        llamarform(FormSunatTDocumento, Me)
    End Sub

    Private Sub TSMnuItemTipoProg_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemTipoProg.Click
        llamarform(FormTipoPrograma, Me)
    End Sub

    Private Sub TSMnuItemCajaNumeracion_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemCajaNumeracion.Click
        llamarform(FormCtaCteNumeracionC, Me)
    End Sub



    Private Sub TSMnuItemImpuesto_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemImpuesto.Click
        llamarform(FormMaImpuestoPais, Me)
    End Sub

    Private Sub TSMnuItemTCambio_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemTCambio.Click
        llamarform(FormTipodeCambio, Me)
    End Sub

    Private Sub TSMnuItemPrdContable_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemPrdContable.Click
        llamarform(FormMaPeriodo, Me)
    End Sub

    Private Sub TSMnuItemSQLSunat_Click_1(sender As System.Object, e As System.EventArgs) Handles TSMnuItemSQLSunat.Click
        llamarform(FormRucSunat, Me)
    End Sub

    Private Sub TSMnuItemPrcFactu_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemPrcFactu.Click

        If ObtenerParametroAppConfig("NroCaja") = vbNullString Or ObtenerParametroAppConfig("NroCaja") = "0" Then
            If MessageBox.Show("No se ha configurado ninguna Caja para este equipo; ¿Desea configurar una Nro. Caja al equipo.?", "Validando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                llamarform(FormConfigSys, Me)
            End If
        Else
            llamarform(FormPrcFacturacion, Me)
        End If

    End Sub

    Private Sub TSMnuItemConfigParamServ_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemConfigParamServ.Click
        llamarform(FormSysConfigServicio, Me)
    End Sub

    Private Sub TSMnuItemPrcProgramaCoutaOrdinaria_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemPrcProgramaCoutaOrdinaria.Click
        llamarform(FormPrcProgramaBathCuotaOrdinaria, Me)
    End Sub

    Private Sub TSMnuItemRptCuadreCaja_Click(sender As System.Object, e As System.EventArgs)
        llamarform(FormRptCuadreCaja, Me)
    End Sub

    Private Sub AnularComprobanteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnularComprobanteToolStripMenuItem.Click
        llamarform(FormPrcAnulacionComprobante, Me)
    End Sub

    Private Sub TSMnuItemRptGeneral_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemRptGeneral.Click
        llamarform(FormRptMaster, Me)
    End Sub

    Private Sub TSMnuItemRptBookVta_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemRptBookVta.Click
        llamarform(FormPrcLibroVta, Me)
    End Sub

    Private Sub TSMnuItemRptCole_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemRptCole.Click
        llamarform(FormRptMasterColegiado, Me)
    End Sub

    Private Sub TSMnuItemRptReImprimir_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemRptReImprimir.Click
        llamarform(FormPrcReImpresionDocu, Me)
    End Sub

    Private Sub TSMnuItemRptSQLEstadoCuentaCole_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemRptSQLEstadoCuentaCole.Click
        llamarform(FormSQLEstadoCuenta_for_Colegiado, Me)
    End Sub

    Private Sub TSMnuItemSysConfig_Click(sender As System.Object, e As System.EventArgs) Handles TSMnuItemSysConfig.Click
        llamarform(FormConfigSys, Me)
    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub


End Class