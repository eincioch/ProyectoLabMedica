Option Explicit On

Imports Integration.BE.Campana
Imports Integration.BE.CtasCtes
Imports Integration.BL.BL_CtaCteListaServicio
Imports Integration.BL.BL_Campana
Imports Integration.BL.BL_CtaCtes
Imports Integration.BL.BL_CtasCtesMedica
Imports Integration.BE.PerUsuGruAcc
Imports Integration.BL

Public Class FormFiltroServicios

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Dim mdtbColourMap As DataTable = Nothing

    Dim Req_Campana As New BE_ReqCampana
    Dim Obj_Campana As New BL_Campana

#Region "Estructura Grilla"

    Enum GrillaServicios
        ColnKey = 0
        ColcPerJurCodigo = 1
        ColnCtaCteSerCodigo = 2
        ColcIntJerarquia = 3
        ColcCtaCteSerJerarquia = 4

        ColcCodGrupo = 5

        ColcCtaCteSerKeyWord = 6 '5
        ColnMonCodigo = 7 '6
        ColnIntCodigo = 8 '7

        ColnCtaCteSerImpDef = 9 '8
        ColnPorcDscto = 10 '9
        ColnCtaCteSerCosto = 11 '10 ' 8

        ColnFlag = 12 ' 11 '9
    End Enum

    Private Sub Formato01_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()

            Dim Colnkey As New DataGridViewCheckBoxColumn()
            With Colnkey
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = ""
                .HeaderText = "?"
                .FalseValue = 0
                .IndeterminateValue = 0
                .TrueValue = 1
                .Name = "nKey"
                .ReadOnly = True : .Visible = True
                .Width = 28
            End With
            .Columns.Add(Colnkey)

            Dim ColcPerJurCodigo As New DataGridViewTextBoxColumn()
            With ColcPerJurCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerJurCodigo"
                .HeaderText = "cPerJurCodigo"
                .Name = "cPerJurCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColcPerJurCodigo)

            Dim ColnCtaCteSerCodigo As New DataGridViewTextBoxColumn()
            With ColnCtaCteSerCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nCtaCteSerCodigo"
                .HeaderText = "nCtaCteSerCodigo"
                .Name = "nCtaCteSerCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 30
            End With
            .Columns.Add(ColnCtaCteSerCodigo)

            Dim ColcIntJerarquia As New DataGridViewTextBoxColumn()
            With ColcIntJerarquia
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.DefaultCellStyle.Format = "d"
                .DataPropertyName = "cIntJerarquia"
                .HeaderText = "cIntJerarquia"
                .Name = "cIntJerarquia"
                .ReadOnly = True : .Visible = False
                .Width = 90
                '.DefaultCellStyle = DataGridViewCellStyle { Format=N, Alignment=TopRight }
            End With
            .Columns.Add(ColcIntJerarquia)


            Dim ColcCtaCteSerJerarquia As New DataGridViewTextBoxColumn()
            With ColcCtaCteSerJerarquia
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cCtaCteSerJerarquia"
                .HeaderText = "Código"
                .Name = "cCtaCteSerJerarquia"
                .ReadOnly = True : .Visible = True
                .Width = 75
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColcCtaCteSerJerarquia)

            '(eincio) se agrego 2015-12-23
            Dim ColcCodGrupo As New DataGridViewTextBoxColumn()
            With ColcCodGrupo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cCodGrupo"
                .HeaderText = "cCodGrupo"
                .Name = "cCodGrupo"
                .ReadOnly = True : .Visible = False
                .Width = 90
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColcCodGrupo)

            Dim ColcCtaCteSerKeyWord As New DataGridViewTextBoxColumn()
            With ColcCtaCteSerKeyWord
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cCtaCteSerKeyWord"
                .HeaderText = "Descripción"
                .Name = "cCtaCteSerKeyWord"
                .ReadOnly = True : .Visible = True
                .Width = 480
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColcCtaCteSerKeyWord)

            Dim ColnMonCodigo As New DataGridViewTextBoxColumn()
            With ColnMonCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nMonCodigo"
                .HeaderText = "nMonCodigo"
                .Name = "nMonCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 20
            End With
            .Columns.Add(ColnMonCodigo)

            Dim ColnIntCodigo As New DataGridViewTextBoxColumn()
            With ColnIntCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nIntCodigo"
                .HeaderText = "nIntCodigo"
                .Name = "nIntCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 20
            End With
            .Columns.Add(ColnIntCodigo)

            Dim ColnCtaCteSerImpDef As New DataGridViewTextBoxColumn()
            With ColnCtaCteSerImpDef
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nCtaCteSerImpDef"
                .HeaderText = "Precio Original"
                .Name = "nCtaCteSerImpDef"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColnCtaCteSerImpDef)


            Dim ColnPorcDscto As New DataGridViewTextBoxColumn()
            With ColnPorcDscto
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.DefaultCellStyle.Format = "N2"
                '.DataPropertyName = "nPorcDscto"
                .HeaderText = "% Dscto."
                .Name = "nPorcDscto"
                .ReadOnly = True : .Visible = True
                .Width = 75
            End With
            .Columns.Add(ColnPorcDscto)

            Dim ColnCtaCteSerCosto As New DataGridViewTextBoxColumn()
            With ColnCtaCteSerCosto
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nCtaCteSerCosto"
                .HeaderText = "Precio Público"
                .Name = "nCtaCteSerCosto"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColnCtaCteSerCosto)

            Dim ColnFlag As New DataGridViewTextBoxColumn()
            With ColnFlag
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nFlag"
                .HeaderText = "nFlag"
                .Name = "nFlag"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColnFlag)

        End With

    End Sub
#End Region

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Select Case keyData
            Case Keys.F1
                TabControl1.SelectedIndex = 0
                Return True
            Case Keys.F2
                TabControl1.SelectedIndex = 1
                Return True
            Case Keys.F3
                TabControl1.SelectedIndex = 2
                Return True
            Case Keys.F12
                TabControl1.SelectedIndex = 3
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

    '(eincio f.2015-11-04)
    Function ValidarMuestra() As Boolean

        ValidarMuestra = False

        With Table1
            If Not .CurrentCell Is Nothing Then
                'Utilizando For
                '--------------
                For _xdtRow As Integer = 0 To .Rows.Count - 1
                    If .Rows(_xdtRow).Cells("nKey").Value = True Then
                        If .Rows(_xdtRow).Cells(CInt(GrillaServicios.ColnCtaCteSerCosto)).Value <= 0 Then
                            MessageBox.Show("Servicio " & .Rows(_xdtRow).Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & .Rows(_xdtRow).Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " , tiene Precio < Cero > por favor verifique.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Function
                        End If
                        If .Rows(_xdtRow).Cells(CInt(GrillaServicios.ColnCtaCteSerCosto)).Value > .Rows(_xdtRow).Cells(GrillaServicios.ColnCtaCteSerImpDef).Value Then
                            MessageBox.Show("Incoherencia con los precios, verifique por favor.", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Function
                        End If
                    End If
                Next

                'Utilizando For Each 
                '-------------------
                'For Each row As DataGridViewRow In .Rows
                '    If Convert.ToInt16(row.Cells("nKey").Value) = 1 Then
                '        If row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value <= 0 Then
                '            MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " , tiene Precio < Cero > por favor verifique.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '            Exit For
                '        End If
                '        If row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value > row.Cells(GrillaServicios.ColnCtaCteSerImpDef).Value Then
                '            MessageBox.Show("Incoherencia con los precios, verifique por favor.", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '            Exit For
                '        End If
                '    End If
                'Next
            End If
        End With
        ValidarMuestra = True
    End Function

    Private Sub FiltraServicio(ByVal Valor As String, Optional ByVal Flag As String = "C")
        Try
            Dim dt As New DataTable
            Dim nPos As Integer

            Dim Req_ListServicio As New BE_ReqCtaCtePrecioServicio
            Dim Obj_ListServicio As New BL_CtaCtePrecioServicio

            Req_ListServicio.cPerJurCodigo = StrcPerJuridica
            Req_ListServicio.nIntCodigo = IIf(FormServicios = 1, CLng(TokenByKey(StrPasaValores, "nIntCodigo")), CInt(TipoAtencion.Particular)) REM Recuperando Tipo de Atencion para Obtener el Precio de CtaCteServicios por cPerCodigo.
            Req_ListServicio.cCtaCteSerKeyWord = Valor 'Trim(TxtCaracter.Text)
            Req_ListServicio.cIntJerarquia = CboClase.SelectedValue.ToString '  Microsoft.VisualBasic.Left(CboClase.Text, 5)
            'Req_ListServicio.cPerCodigo = IIf(FormServicios = 1, TokenByKey(StrPasaValores, "cPerCodigo"), "")

            If FormServicios = 1 Then
                If CInt(TokenByKey(StrPasaValores, "nIntCodigo")) = CInt(TipoAtencion.Particular) Or CInt(TokenByKey(StrPasaValores, "nIntCodigo")) = CInt(TipoAtencion.AtencionExterna) Then
                    Req_ListServicio.cPerCodigo = TokenByKey(StrPasaValores, "cPerCodigo") 'Se cambio para Descuento a Personal de Medica  ""
                Else
                    Req_ListServicio.cPerCodigo = TokenByKey(StrPasaValores, "cPerJurCodigo")
                End If
            Else
                Req_ListServicio.cPerCodigo = ""
            End If
            Req_ListServicio.Flag = Flag '"C"

            'Table1.DataSource = Obj_ListServicio.Get_List_CtaCteServicio(Req_ListServicio)
            dt = Obj_ListServicio.Get_List_CtaCteServicio(Req_ListServicio)

            'Limpiando la Grilla antes de mostrar el resultado
            EliminarRowsDgView(Table1)

            'Leyendo un DataTable
            If dt.Rows.Count > 0 Then
                Dim row As DataRow
                'Llenando DataGridView
                For Each row In dt.Rows
                    With Table1
                        nPos = .RowCount()
                        .Rows.Add()
                        .Item("nKey", nPos).Value = False '--Todos activos "CheckBox"
                        .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                        .Item("nCtaCteSerCodigo", nPos).Value = CInt(row("nCtaCteSerCodigo").ToString)
                        .Item("cIntJerarquia", nPos).Value = CStr(row("cIntJerarquia").ToString)
                        .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)

                        .Item(GrillaServicios.ColcCodGrupo, nPos).Value = CStr(row("cCodGrupo")).ToString

                        .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                        .Item("nMonCodigo", nPos).Value = CInt(row("nMonCodigo").ToString)
                        .Item("nIntCodigo", nPos).Value = CInt(row("nIntCodigo").ToString)

                        'Update 2015-10-16 (eincio)
                        .Item("nCtaCteSerImpDef", nPos).Value = CDbl(row("nCtaCteSerImpDef").ToString)
                        .Item("nPorcDscto", nPos).Value = FormatNumber(row("nPorcDscto").ToString, True) + "%"
                        '
                        .Item("nCtaCteSerCosto", nPos).Value = CDbl(row("nCtaCteSerCosto").ToString)
                        .Item("nFlag", nPos).Value = CDbl(row("nFlag").ToString) '0=Proceso Local, 9=Proceso Lab. Terceros
                    End With

                Next

            End If

            Table1.PerformLayout()
            Table1.Enabled = True

            ''Define the search terms and color for each
            'mdtbColourMap = New DataTable
            'mdtbColourMap.Columns.Add(New DataColumn("SearchTerm", GetType(String)))
            'mdtbColourMap.Columns.Add(New DataColumn("TextColor", GetType(Brush)))
            'mdtbColourMap.Rows.Add("_", Drawing.Brushes.Red) 'Green)
            ''mdtbColourMap.Rows.Add("+", Drawing.Brushes.Red)
            ''mdtbColourMap.Rows.Add("-", Drawing.Brushes.Purple)
            'mdtbColourMap.Rows.Add("(", Drawing.Brushes.Red)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FormFiltroServicios_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Insert))
                Table1.Enabled = False
                Call BtnSeleccionar_Click(BtnSeleccionar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                Call BtnCancelar_Click(BtnCancelar, Nothing)
        End Select

    End Sub


    Private Sub FormFiltroServicios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try

            Req_Campana.cPerJurCodigo = StrcPerJuridica

            Table1.Enabled = True

            Formato01_DataGridView()
            FormatGrilla(Table1, Me, False, 25, False, DataGridViewSelectionMode.CellSelect)

            LstBoxCampana.Items.Clear()
            LlenaListBox(LstBoxCampana, Obj_Campana.Get_List_Campana(Req_Campana), "nIntCamp", "cNombreCamp")

            TabControl1.TabPages.Remove(TabPage4)

            If LstBoxCampana.Items.Count > 0 Then 'And FormServicios = 1 Then
                LstBoxCampana.Enabled = True
                Me.Width = 1252 '901
            Else
                Me.Width = 925
            End If

            'Ficha Atención y Campaña
            If FormServicios = 1 Or FormServicios = 0 Then
                TabControl1.TabPages.Add(TabPage4)
            End If

            REM LlenaDataCombo(CboCampana, Obj_Campana.Get_List_Campana(Req_Campana), "nIntCamp", "cNombreCamp")

            Me.StartPosition = FormStartPosition.CenterScreen

            Dim ObjPerJur As New BE_Req_PerUsuGruAcc
            Dim ObjPerJurProc As New BL_PerUsuGruAcc

            'Clase según Sede o Empresa
            ObjPerJur.cPerCodigo = StrcPerJuridica
            ObjPerJur.cIntJerarquia = ""
            ObjPerJur.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
            ObjPerJur.nSisGruTipo = 1004
            ObjPerJur.nObjTipo = 1014
            ObjPerJur.nIntTipo = 1000
            ObjPerJur.nObjCodigo = -1
            LlenaDataCombo(CboClase, ObjPerJurProc.Get_PerUsuGruAcc_Get_Interface(ObjPerJur), "nObjCodigo", "cIntDescripcion")

            'LlenaDataCombo(CboClase, ObjInterface.Get_Interface(CLng(TokenByKey(CboClase.Tag, "nIntClase")), CLng(TokenByKey(CboClase.Tag, "nIntTipo")), "F"), "nIntCodigo", "cIntDescripcion") REM "cIntJerarquia")

            'CboClase_SelectionChangeCommitted(CboClase, Nothing)

            'If TabControl1.SelectedTab.Name = "TabPage1" Then TxtCodigo.Focus()

            'Perfiles según Sede o Empresa
            ObjPerJur.cPerCodigo = StrcPerJuridica
            ObjPerJur.cIntJerarquia = ""
            ObjPerJur.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
            ObjPerJur.nSisGruTipo = 1004
            ObjPerJur.nObjTipo = 1060
            ObjPerJur.nIntTipo = 1000
            ObjPerJur.nObjCodigo = -1
            LlenaDataCombo(CboPerfil, ObjPerJurProc.Get_PerUsuGruAcc_Get_Interface(ObjPerJur), "nObjCodigo", "cIntDescripcion")


            'Carga de Perfiles (Grupo de Examenes)
            'LlenaDataCombo(CboPerfil, ObjInterface.Get_Interface(CLng(TokenByKey(CboPerfil.Tag, "nIntClase")), CLng(TokenByKey(CboPerfil.Tag, "nIntTipo")), "T"), "nIntCodigo", "cIntDescripcion")

            Me.ActiveControl = TxtCodigo
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub

    Private Sub BtnSeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles BtnSeleccionar.Click

        Try
            Dim Rows As Integer

            If Table1.RowCount = 0 Then Exit Sub

            With Table1
                If Not .CurrentCell Is Nothing Then
                    For Each row As DataGridViewRow In .Rows

                        REM Pasando solo los que tiene el Check 
                        If Convert.ToInt16(row.Cells("nKey").Value) = 1 Then

                            Select Case FormServicios
                                Case 0 REM Form Campaña
                                    'Verificando si el servicio ya fue ingresado 
                                    If BuscaCadenaDgView("nCtaCteSerCodigo", row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString, FormMaCampana.Table1) Then
                                        MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " ya esta siendo ingresado, no podra utilizar el mismo Servicio.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    Else
                                        REM Si No Existe, aqui insertas el fila
                                        With FormMaCampana.Table1
                                            Rows = .RowCount()
                                            .Rows.Add()
                                            .Item("cPerJurCodigo", Rows).Value = row.Cells(GrillaServicios.ColcPerJurCodigo).Value.ToString
                                            .Item("nCtaCteSerCodigo", Rows).Value = row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString
                                            .Item("cCodGrupo", Rows).Value = row.Cells(GrillaServicios.ColcCodGrupo).Value.ToString 'update 2015-01-14 (eincio)
                                            .Item("cCtaCteSerJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString
                                            .Item("cCtaCteSerKeyWord", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString
                                            .Item("nMonCodigo", Rows).Value = row.Cells(GrillaServicios.ColnMonCodigo).Value.ToString
                                            .Item("nIntCodigo", Rows).Value = row.Cells(GrillaServicios.ColnIntCodigo).Value.ToString
                                            .Item("nCtaCteSerCosto", Rows).Value = Format(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value, "##,##0.00")
                                            .Item("nFlag1", Rows).Value = row.Cells(GrillaServicios.ColnFlag).Value.ToString
                                        End With

                                    End If


                                Case 1
                                    '--------------------
                                    ' Form Ficha Atencion
                                    '---------------------
                                    'Verificando si el servicio ya fue ingresado
                                    If BuscaCadenaDgView("nCtaCteSerCodigo", row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString, FormPrcSolAtencion.Table1) Then
                                        MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " ya ha sido ingresado, no podra utilizar el mismo Servicio.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    Else
                                        If ValidarMuestra() Then
                                            'If row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value <= 0 Then
                                            '    MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " , tiene Precio < Cero > por favor verifique.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            '    Exit Sub
                                            'Else
                                            '    If row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value > row.Cells(GrillaServicios.ColnCtaCteSerImpDef).Value Then
                                            '        MessageBox.Show("Incoherencia con los precios, verifique por favor.", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            '        Exit Sub
                                            '    Else

                                            REM Si No existe y el Precio No es CERO, agregamos los item(s).
                                            With FormPrcSolAtencion.Table1
                                                Rows = .RowCount()
                                                .Rows.Add()
                                                .Item("cPerJurCodigo", Rows).Value = row.Cells(GrillaServicios.ColcPerJurCodigo).Value.ToString
                                                .Item("nCtaCteSerCodigo", Rows).Value = row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString
                                                .Item("cIntJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcIntJerarquia).Value.ToString
                                                .Item("cCtaCteSerJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString

                                                .Item("cCodGrupo", Rows).Value = row.Cells(GrillaServicios.ColcCodGrupo).Value.ToString 'Update 2015-12-24 (eincio)

                                                .Item("cCtaCteSerKeyWord", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString
                                                .Item("nMonCodigo", Rows).Value = row.Cells(GrillaServicios.ColnMonCodigo).Value.ToString
                                                .Item("nIntCodigo", Rows).Value = row.Cells(GrillaServicios.ColnIntCodigo).Value.ToString

                                                'Cargando Precio Original 
                                                .Item("nCtaCteSerImpDef", Rows).Value = Format(row.Cells(GrillaServicios.ColnCtaCteSerImpDef).Value, "##,##0.00")
                                                .Item("nTipoDscto", Rows).Value = 0 'Default precio normal, perfil y/o campaña

                                                .Item("nCtaCteCantidad", Rows).Value = 1 'Default
                                                .Item("nCtaCteSerCosto", Rows).Value = Format(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value, "##,##0.00")
                                                .Item("nCtaCteSubTotal", Rows).Value = Format(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value, "##,##0.00")
                                                'Manejo de Bloqueo si agrega items de campaña
                                                .Item("nFlag", Rows).Value = row.Cells(GrillaServicios.ColnFlag).Value.ToString

                                            End With

                                            FormPrcSolAtencion.CalcularVta()

                                        Else
                                            Exit Sub
                                            '    End If
                                            'End If
                                        End If
                                    End If

                                Case 2 REM Form Perfil Servicio
                                    'Verificando si el servicio ya fue ingresado
                                    If BuscaCadenaDgView("nCtaCteSerCodigo", row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString, FormMaPerfilServicios.Table1) Then
                                        MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " ya ha sido ingresado, no podra utilizar el mismo Servicio.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    Else
                                        If row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value <= 0 Then
                                            MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " , tiene Precio < Cero > por favor verifique.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Exit Sub
                                        Else
                                            REM Si No existe y el Precio no es CERO, agregamos los item(s).
                                            With FormMaPerfilServicios.Table1
                                                Rows = .RowCount()
                                                .Rows.Add()
                                                .Item("cPerJurCodigo", Rows).Value = row.Cells(GrillaServicios.ColcPerJurCodigo).Value.ToString
                                                .Item("nIntCodigo", Rows).Value = FormMaPerfilServicios.CboPerfil.SelectedValue
                                                .Item("nCtaCteSerCodigo", Rows).Value = row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString
                                                .Item("cCtaCteSerJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString
                                                .Item("cCtaCteSerKeyWord", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString
                                                .Item("nMonCodigo", Rows).Value = row.Cells(GrillaServicios.ColnMonCodigo).Value.ToString
                                                .Item("nCtaCteSerImpDef", Rows).Value = Format(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value, "##,##0.00")
                                                .Item("cPerUsuCodigo", Rows).Value = StrUser 'usuario actual conectado en el sistema

                                            End With
                                        End If

                                    End If
                                Case 3 REM Form Porcentaje Descuento
                                    'Verificando si el servicio ya fue ingresado 
                                    If BuscaCadenaDgView("nCtaCteSerCodigo", row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString, FormMaPorcDsctoEntidades.Table1) Then
                                        MessageBox.Show("Servicio " & row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString & " - " & row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString & " ya esta siendo ingresado, no podra utilizar el mismo Servicio.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Exit Sub
                                    Else
                                        'Dim Objeto As New BE_ReqCtaCteServicio
                                        'Dim Servicio As New BLCtaCteListaServicio
                                        'Dim dt As New DataTable

                                        REM Si No Existe, aqui insertas el fila
                                        With FormMaPorcDsctoEntidades.Table1
                                            Rows = .RowCount()
                                            .Rows.Add()
                                            ''recuperando precio actual
                                            'Objeto.cPerJurCodigo = StrcPerJuridica
                                            'Objeto.cCtaCteSerJerarquia = row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString
                                            'dt = Servicio.Get_CtaCteListaServicio_by_cPerJurCodigo_and_cCtaCteSerJerarquia(Objeto)

                                            .Item("cPerJurCodigo", Rows).Value = row.Cells(GrillaServicios.ColcPerJurCodigo).Value.ToString
                                            .Item("nCtaCteSerCodigo", Rows).Value = row.Cells(GrillaServicios.ColnCtaCteSerCodigo).Value.ToString
                                            .Item("cIntJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcIntJerarquia).Value.ToString
                                            .Item("cCtaCteSerJerarquia", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerJerarquia).Value.ToString
                                            .Item("cCtaCteSerKeyWord", Rows).Value = row.Cells(GrillaServicios.ColcCtaCteSerKeyWord).Value.ToString
                                            .Item("nMonCodigo", Rows).Value = row.Cells(GrillaServicios.ColnMonCodigo).Value.ToString
                                            .Item("nIntCodigo", Rows).Value = row.Cells(GrillaServicios.ColnIntCodigo).Value.ToString
                                            .Item("nCtaCteSerCosto", Rows).Value = Format(row.Cells(GrillaServicios.ColnCtaCteSerCosto).Value, "##,##0.00")
                                            '.Item("nTipoDscto", Rows).Value = Convert.ToInt16(TipoDsctoAplica.PrecioFijo) 'por default
                                            .Item("nCtaCtenValor", Rows).Value = 0
                                        End With

                                    End If
                            End Select

                        End If
                    Next

                    TxtCaracter.Text = "" : EliminarRowsDgView(Table1) : ActiveControl = TxtCaracter
                    'Me.Close()
                    'Me.Dispose()

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LstBoxCampana_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles LstBoxCampana.MouseDoubleClick

        Try
            Dim nPos As Integer
            Dim dt As New DataTable

            Req_Campana.cPerJurCodigo = StrcPerJuridica
            Req_Campana.nIntCamp = CLng(LstBoxCampana.SelectedValue)

            'Table1.DataSource = Obj_Campana.Get_Servicios_for_nIntCamp(Req_Campana)
            dt = Obj_Campana.Get_Servicios_for_nIntCamp(Req_Campana)

            EliminarRowsDgView(Table1)

            'Leyendo un DataTable
            If dt.Rows.Count > 0 Then
                Dim row As DataRow

                For Each row In dt.Rows
                    With Table1
                        nPos = .RowCount()
                        .Rows.Add()
                        .Item("nKey", nPos).Value = True '--Todos activos "CheckBox"
                        .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                        .Item("nCtaCteSerCodigo", nPos).Value = CInt(row("nCtaCteSerCodigo").ToString)
                        .Item("cIntJerarquia", nPos).Value = CStr(row("cIntJerarquia").ToString)
                        .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)

                        .Item(GrillaServicios.ColcCodGrupo, nPos).Value = CStr(row("cCodGrupo").ToString)

                        .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                        .Item("nMonCodigo", nPos).Value = CInt(row("nMonCodigo").ToString)
                        .Item("nIntCodigo", nPos).Value = CInt(row("nIntCodigo").ToString)

                        'Update 2015-10-16 (eincio)
                        .Item("nCtaCteSerImpDef", nPos).Value = CDbl(row("nCtaCteSerImpDef").ToString)
                        .Item("nPorcDscto", nPos).Value = FormatNumber(row("nPorcDscto").ToString, True) + "%"
                        '
                        .Item("nCtaCteSerCosto", nPos).Value = CDbl(row("nCtaCteSerCosto").ToString)
                        .Item("nFlag", nPos).Value = CInt(row("nFlag").ToString) 'CInt(TipoMuestraDscto.nCampana)  '1 =Indica que es Muestra seleccionada esta en Campaña
                    End With
                Next
            End If

            Table1.PerformLayout()
            Table1.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        FiltraServicio(TxtCodigo.Text)
    End Sub

    Private Sub CboClase_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboClase.SelectionChangeCommitted
        FiltraServicio("", "G")
    End Sub

    Private Sub TxtCaracter_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtCaracter.TextChanged
        FiltraServicio(TxtCaracter.Text, "D")
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        EliminarRowsDgView(Table1)
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                TxtCodigo.Text = vbNullString : TxtCodigo.Focus()
            Case 2
                TxtCaracter.Text = vbNullString : TxtCaracter.Focus()
            Case 1
                CboClase_SelectionChangeCommitted(CboClase, Nothing)
                CboClase.Focus()
        End Select
    End Sub

    Private Sub CboPerfil_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboPerfil.SelectionChangeCommitted

        '-----------------
        'Carga Perfil
        '-----------------
        Dim nPos As Integer = 0
        Dim Servicio As New BLPerfilServicio
        Dim dt As New DataTable

        EliminarRowsDgView(Table1)



        dt = Servicio.Get_PerfilServicio_Terceros(StrcPerJuridica, CInt(CboPerfil.SelectedValue), "B", TokenByKey(StrPasaValores, "cPerJurCodigo"), CInt(TokenByKey(StrPasaValores, "nIntCodigo")))
        'Datos enlazados no es factible para despues agregar mas items
        'Table1.DataSource = dt

        'Leyendo un DataTable
        If dt.Rows.Count > 0 Then
            Dim row As DataRow

            For Each row In dt.Rows
                With Table1
                    nPos = .RowCount()
                    .Rows.Add()
                    .Item("nKey", nPos).Value = True '--Todos activos "CheckBox"
                    .Item("cPerJurCodigo", nPos).Value = CStr(row("cPerJurCodigo").ToString)
                    .Item("nCtaCteSerCodigo", nPos).Value = CInt(row("nCtaCteSerCodigo").ToString)
                    .Item("cIntJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)
                    .Item("cCtaCteSerJerarquia", nPos).Value = CStr(row("cCtaCteSerJerarquia").ToString)

                    .Item(GrillaServicios.ColcCodGrupo, nPos).Value = CStr(row("cCodGrupo").ToString)

                    .Item("cCtaCteSerKeyWord", nPos).Value = CStr(row("cCtaCteSerKeyWord").ToString)
                    .Item("nMonCodigo", nPos).Value = CInt(row("nMonCodigo").ToString)
                    .Item("nIntCodigo", nPos).Value = CInt(row("nIntCodigo").ToString)

                    'Update 2015-10-16 (eincio)
                    .Item("nCtaCteSerImpDef", nPos).Value = CDbl(row("nCtaCteSerImpDef").ToString)
                    .Item("nPorcDscto", nPos).Value = FormatNumber(row("nPorcDscto").ToString, True) + "%"
                    '
                    .Item("nCtaCteSerCosto", nPos).Value = CDbl(row("nCtaCteSerCosto").ToString)
                    .Item("nFlag", nPos).Value = CInt(row("nFlag").ToString) 'CInt(TipoMuestraDscto.nPerfil)  '2=Indica que Muestra pertenece un a Perfil 
                End With

            Next

        End If

        Table1.PerformLayout()
        Table1.Enabled = False
        LblTotalPago.Text = FormatNumber(Suma_Columna("nCtaCteSerCosto", Table1), True)

    End Sub

    ' para editar el Check de Table1
    Private Sub Table1_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellContentClick

        If e.ColumnIndex = Me.Table1.Columns.Item(GrillaServicios.ColnKey).Index Then
            'Table1.Item(e.ColumnIndex, e.RowIndex + 1).Selected = True
            Dim chkCell As DataGridViewCheckBoxCell = Me.Table1.Rows(e.RowIndex).Cells(GrillaServicios.ColnKey)
            chkCell.Value = Not chkCell.Value
            'MsgBox("Estado: " & EstadoCheck(e.RowIndex))

            Table1.PerformLayout()
            Table1.Refresh()
        End If
    End Sub

    Private Function EstadoCheck(ByVal filaposicion As Integer) As Boolean

        Return Me.Table1.Rows(filaposicion).Cells("nKey").Value

    End Function

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Table1.CurrentCellDirtyStateChanged
        If Table1.IsCurrentCellDirty Then
            Table1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        Close()
        Dispose()
    End Sub

    Private Sub FormFiltroServicios_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub FormFiltroServicios_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub

    Private Sub FormFiltroServicios_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Arrastre = False
    End Sub

    'Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Table1.CellPainting

    '    If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
    '        Dim newRect As New Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1, _
    '            e.CellBounds.Width - 4, e.CellBounds.Height - 4)
    '        Dim backColorBrush As New SolidBrush(e.CellStyle.BackColor)
    '        Dim gridBrush As New SolidBrush(Me.Table1.GridColor)
    '        Dim gridLinePen As New Pen(gridBrush)
    '        Try
    '            ' Erase the cell.
    '            e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

    '            ' Draw the grid lines (only the right and bottom lines; 
    '            ' DataGridView takes care of the others).
    '            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, _
    '                e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, _
    '                e.CellBounds.Bottom - 1)
    '            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, _
    '                e.CellBounds.Top, e.CellBounds.Right - 1, _
    '                e.CellBounds.Bottom)

    '            ' Draw the inset highlight box.
    '            'e.Graphics.DrawRectangle(Pens.Blue, newRect)

    '            ' Draw the text content of the cell, ignoring alignment. 
    '            If (e.Value IsNot Nothing) Then
    '                Dim strValue As String = CStr(e.Value)
    '                Dim strWords() As String = Split(strValue, " ")
    '                Dim strAlignment As String = "LEFT"
    '                If e.ColumnIndex = 0 Then strAlignment = "RIGHT"
    '                Dim sngX As Integer
    '                If strAlignment = "LEFT" Then
    '                    sngX = e.CellBounds.X + 2
    '                Else
    '                    sngX = e.CellBounds.Right - 4 - e.Graphics.MeasureString(strValue, e.CellStyle.Font).Width
    '                End If
    '                For i As Integer = 0 To strWords.GetUpperBound(0)
    '                    Dim brsTextColor As Drawing.Brush = Nothing
    '                    For j As Integer = 0 To mdtbColourMap.Rows.Count - 1
    '                        Dim strSearchTerm As String = mdtbColourMap.Rows(j).Item("SearchTerm").ToString
    '                        If InStr(strWords(i), strSearchTerm) > 0 Then
    '                            brsTextColor = DirectCast(mdtbColourMap.Rows(j).Item("TextColor"), Drawing.Brush) 'change the color
    '                            Exit For
    '                        End If
    '                    Next j
    '                    If brsTextColor Is Nothing Then
    '                        brsTextColor = Brushes.Blue  'Black 'default
    '                    End If
    '                    e.Graphics.DrawString(strWords(i), e.CellStyle.Font, brsTextColor, sngX, e.CellBounds.Y + 2, StringFormat.GenericDefault)
    '                    sngX += e.Graphics.MeasureString(strWords(i), e.CellStyle.Font).Width
    '                Next i
    '            End If
    '            e.Handled = True
    '        Finally
    '            gridLinePen.Dispose()
    '            gridBrush.Dispose()
    '            backColorBrush.Dispose()
    '        End Try

    '    End If

    'End Sub


End Class