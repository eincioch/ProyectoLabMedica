Option Explicit On

Imports Integration.BE
Imports Integration.BE.FichaAtencion
Imports Integration.BE.Android
Imports Integration.BL.BL_Android
Imports Integration.BL
Imports Integration.BL.BL_FichaAtencion

Imports System.Transactions

Public Class FormProformaAndroid

#Region "Estrutura grilla"

    Enum GrillaProformaCab
        ColnCorrelativo = 0
        ColDescrProforma = 1
    End Enum

    Enum GrillaProforma
        ColnCorrelativo = 0
        ColnItem = 1
        ColnIntJerarquia = 2
        ColnCtaCteSerCodigo = 3
        ColNameGrupo = 4
        ColcCtaCteSerKeyWord = 5
        ColnPrecio = 6
        ColnCtaCteSerImpDef = 7
        ColnEstado = 8
        ColdFechaRegistro = 9
        ColnFlagGrupo = 10
    End Enum

    Private Sub EstructuraGrillaProformaCab_DataGridView()

        With Table2
            .AutoGenerateColumns = False
            .Columns.Clear()

            Dim ColnCorrelativo As New DataGridViewTextBoxColumn()
            With ColnCorrelativo
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nCorrelativo"
                .Name = "nCorrelativo"
                .HeaderText = "nCorrelativo"
                .ReadOnly = True : .Visible = False
                .Width = 50
            End With
            .Columns.Add(ColnCorrelativo)

            Dim ColnItem As New DataGridViewTextBoxColumn()
            With ColnItem
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "DescrProforma"
                .Name = "DescrProforma"
                .HeaderText = "Seleccione"
                .ReadOnly = True : .Visible = True
                .Width = 178
            End With
            .Columns.Add(ColnItem)

        End With

    End Sub

    Private Sub EstructuraGrillaProforma_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()

            Dim ColnCorrelativo As New DataGridViewTextBoxColumn()
            With ColnCorrelativo
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nCorrelativo"
                .Name = "nCorrelativo"
                .HeaderText = "Nro. Proforma"
                .ReadOnly = True : .Visible = False
                .Width = 80
            End With
            .Columns.Add(ColnCorrelativo)

            Dim ColnItem As New DataGridViewTextBoxColumn()
            With ColnItem
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nItem"
                .Name = "nItem"
                .HeaderText = "Item"
                .ReadOnly = True : .Visible = True
                .Width = 60
            End With
            .Columns.Add(ColnItem)

            Dim ColnIntJerarquia As New DataGridViewTextBoxColumn()
            With ColnIntJerarquia
                .DataPropertyName = "nIntJerarquia"
                .Name = "nIntJerarquia"
                .HeaderText = "Código Exámen"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColnIntJerarquia)

            Dim ColnCtaCteSerCodigo As New DataGridViewTextBoxColumn()
            With ColnCtaCteSerCodigo
                .DataPropertyName = "nCtaCteSerCodigo"
                .Name = "nCtaCteSerCodigo"
                .HeaderText = "Código Interno"
                .ReadOnly = True : .Visible = False
                .Width = 100
            End With
            .Columns.Add(ColnCtaCteSerCodigo)

            Dim ColNameGrupo As New DataGridViewTextBoxColumn()
            With ColNameGrupo
                .DataPropertyName = "NameGrupo"
                .Name = "NameGrupo"
                .HeaderText = "Descripción Exámen / Grupo"
                .ReadOnly = True : .Visible = True
                .Width = 260
            End With
            .Columns.Add(ColNameGrupo)

            Dim ColcCtaCteSerKeyWord As New DataGridViewTextBoxColumn()
            With ColcCtaCteSerKeyWord
                .DataPropertyName = "cCtaCteSerKeyWord"
                .Name = "cCtaCteSerKeyWord"
                .HeaderText = "Descripción Exámen"
                .ReadOnly = True : .Visible = True
                .Width = 260
            End With
            .Columns.Add(ColcCtaCteSerKeyWord)

            Dim ColnPrecio As New DataGridViewTextBoxColumn()
            With ColnPrecio
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nPrecio"
                .Name = "nPrecio"
                .HeaderText = "Precio Proforma"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 85
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColnPrecio)

            Dim ColnCtaCteSerImpDef As New DataGridViewTextBoxColumn()
            With ColnCtaCteSerImpDef
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nCtaCteSerImpDef"
                .Name = "nCtaCteSerImpDef"
                .HeaderText = "Precio Original"
                '.ImageLayout = DataGridViewImageCellLayout.Zoom
                .ReadOnly = True : .Visible = True
                .Width = 85
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColnCtaCteSerImpDef)

            Dim ColnEstado As New DataGridViewTextBoxColumn()
            With ColnEstado
                .DataPropertyName = "nEstado"
                .Name = "nEstado"
                .HeaderText = "nEstado"
                .ReadOnly = True : .Visible = False
                .Width = 50
            End With
            .Columns.Add(ColnEstado)

            Dim ColdFechaRegistro As New DataGridViewTextBoxColumn()
            With ColdFechaRegistro
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy"
                .DataPropertyName = "dFechaRegistro"
                .Name = "dFechaRegistro"
                .HeaderText = "Fecha Proforma"
                .ReadOnly = True : .Visible = True
                .Width = 100
                '.DefaultCellStyle = DataGridViewCellStyle { Format=N, Alignment=TopRight }
            End With
            .Columns.Add(ColdFechaRegistro)

            Dim ColnFlagGrupo As New DataGridViewTextBoxColumn()
            With ColnFlagGrupo
                .DataPropertyName = "nFlagGrupo"
                .Name = "nFlagGrupo"
                .HeaderText = "nFlagGrupo"
                .ReadOnly = True : .Visible = False
                .Width = 50
            End With
            .Columns.Add(ColnFlagGrupo)

        End With

    End Sub

#End Region

    Private nValida As Integer = 0

    Private Function GeneraNewIdcPerCodigo() As String
        Dim ObjNewId As New BL_Personas

        Return ObjNewId.Get_NewIdcPerCodigo_Out(StrcPerJuridica)
    End Function

    Private Function ValidaCamposObligatorios() As Boolean

        ValidaCamposObligatorios = False
        If BtnValidar.Visible Then
            MessageBox.Show("Tiene que válidar la Persona para proceder a Generar la Ficha.", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If

        If Table1.RowCount = 0 Then
            MessageBox.Show("No existe ningún detalle de proforma, verifique por favor.", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If

        ValidaCamposObligatorios = True

    End Function

    Private Sub mLimpiar()
        LblcPerCodigo.Text = ""
        LblcNombre.Text = ""
        LblEdad.Text = ""
    End Sub

    Private Sub Table1_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Table1.CellPainting

        '-----------------------
        '-- Combinando Column 0 
        '-----------------------
        If e.ColumnIndex = 0 AndAlso e.RowIndex <> -1 Then

            Using gridBrush As Brush = New SolidBrush(Me.Table1.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                Using gridLinePen As Pen = New Pen(gridBrush)
                    ' Clear cell   
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    ' Draw line (bottom border and right border of current cell)   
                    'If next row cell has different content, only draw bottom border line of current cell   
                    If e.RowIndex < Table1.Rows.Count - 2 AndAlso Table1.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    ' Draw right border line of current cell   
                    'e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Left, e.CellBounds.Top)


                    ' draw/fill content in current cell, and fill only one cell of multiple same cells   
                    If Not e.Value Is Nothing Then
                        If e.RowIndex > 0 AndAlso Table1.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                        Else
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                        End If
                    End If
                    Me.Table1.Columns(GrillaProforma.ColnCorrelativo).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    e.Handled = True
                End Using
            End Using
        End If

    End Sub

    Private Sub BuscarPersona(ByVal nPerIdeTipo As Integer, ByVal cPerIdeNumero As String)

        Try
            Dim objeto As New Proforma
            Dim servicio As New BL_Proforma
            Dim dt As New DataTable

            objeto.nPerIdeTipo = nPerIdeTipo
            objeto.cPerIdeNumero = cPerIdeNumero

            dt = servicio.Android_Get_Persona_by_nPerIdeTipo_cPerIdeNumero(objeto)

            If dt.Rows.Count > 0 Then
                '//Los campos deben ser igual al select de la consulta del Store Procedure
                LblcPerCodigo.Text = dt.Rows(0)("cPerCodigo").ToString
                LblcNombre.Text = dt.Rows(0)("cPerApellido").ToString & "," & Space(1) & dt.Rows(0)("cPerNombre").ToString
                LblEdad.Text = dt.Rows(0)("nEdad")
                nValida = dt.Rows(0)("cPerValida")

                'Cuando persona ya existe en nuestra sistema principal
                If nValida = 1 Then
                    BtnValidar.Visible = False
                    FiltrarDetalleProforma(nPerIdeTipo, cPerIdeNumero)
                End If

                'cuando persona es nueva y tendra que validar datos
                If nValida = 2 Then
                    BtnValidar.Visible = True
                    '//Cambio oculTO DNI
                    TxtAppNumDocu.Text = dt.Rows(0)("cPerIdeNumero").ToString
                    TxtAppApellidoPaterno.Text = dt.Rows(0)("ApellidoPaterno").ToString
                    TxtAppApellidoMaterno.Text = dt.Rows(0)("ApellidoMaterno").ToString
                    TxtAppNombre1.Text = dt.Rows(0)("Nombre1").ToString
                    TxtAppNombre2.Text = dt.Rows(0)("Nombre2").ToString
                    DtpAppFecNaci.Value = Format(Convert.ToDateTime(dt.Rows(0)("dPerNacimiento")), "dd/MM/yyyy")
                    'Automaticamente se carga ventana para validar
                    BtnValidar_Click(BtnValidar, Nothing)
                End If

            Else
                mLimpiar()
                MessageBox.Show("Persona Móvil No registrada, consulte con que numero de documento se ha registro.", "Buscando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FiltrarDetalleProforma(ByVal nPerIdeTipo As Integer, ByVal cPerIdeNumero As String)

        If ChkBoxFiltraFecha.Checked Then
            CargaGrilla(nPerIdeTipo, cPerIdeNumero, Format(DtpFecIni.Value, "yyyy/MM/dd"), Format(DtpFecFin.Value, "yyyy/MM/dd"), "Y", Table2)
        Else
            CargaGrilla(nPerIdeTipo, cPerIdeNumero, Format(DtpFecIni.Value, "yyyy/MM/dd"), Format(DtpFecFin.Value, "yyyy/MM/dd"), "X", Table2)
        End If

        If Table2.RowCount = 0 Then
            Table1.DataSource = Nothing
            MessageBox.Show("No se encontró ninguna Proforma con fecha de hoy " & Format(Date.Now, "dd/MM/yyyy") & " . Consulte a la persona lo siguiente: " & Chr(13) & Chr(13) & " - Tipo Documento y Número con el que registró." & Chr(13) & Chr(13) & " - Fecha/día que generó la proforma, y filtre por fechas.", "App Médica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Table2_CellContentClick(Table2, Nothing)
        End If
    End Sub

    Function ActualizaProformaPorCambioDocumento(ByVal nPerIdeTipo As Integer, ByVal cPerIdeNumero As String, ByVal nPerIdeTipo_New As Integer, ByVal cPerIdeNumero_New As String) As Boolean

        Dim proforma As New Proforma
        Dim Servicio As New BL_Proforma

        proforma.nPerIdeTipo = nPerIdeTipo
        proforma.cPerIdeNumero = cPerIdeNumero
        proforma.nPerIdeTipo_New = nPerIdeTipo_New
        proforma.cPerIdeNumero_New = cPerIdeNumero_New

        Return Servicio.Android_Update_Proforma_by_cPerIdeNumero(proforma)

    End Function

    Private Sub CargaGrilla(ByVal nPerIdeTipo As Integer, ByVal cPerIdeNumero As String, ByVal cFecIni As String, cFecFin As String, ByVal cFlag As String, ByVal Table As DataGridView, Optional ByVal nCorrelativo As Integer = 0)

        Try
            Dim objeto As New Proforma
            Dim servicio As New BL_Proforma
            Dim dt As New DataTable

            objeto.nPerIdeTipo = nPerIdeTipo
            objeto.cPerIdeNumero = cPerIdeNumero
            objeto.cFecIni = cFecIni
            objeto.cFecFin = cFecFin
            objeto.cFlag = cFlag
            objeto.nCorrelativo = nCorrelativo

            dt = servicio.Get_Proforma_by_nPerIdeTipo_cPerIdeNumero(objeto)

            Table.DataSource = Nothing
            Table.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FormProformaAndroid_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F5))
                C1CmdBuscar_Click(C1CmdBuscar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F6))
                BtnValidar_Click(BtnValidar, Nothing)
                'Case AscW(Microsoft.VisualBasic.ChrW(Keys.F7))
                '    C1CmdEdit_Click(C1CmdEdit, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F9))
                c1CmdGenerarFicha_Click(c1CmdGenerarFicha, Nothing)
                'Case AscW(Microsoft.VisualBasic.ChrW(Keys.F10))
                '    C1CmdImprimir_Click(C1CmdImprimir, Nothing)
                'Case AscW(Microsoft.VisualBasic.ChrW(Keys.F11))
                '    C1CmdAnularFicha_Click(C1CmdAnularFicha, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select
    End Sub

    Private Sub FormProformaAndroid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            EstructuraGrillaProforma_DataGridView()
            FormatGrilla(Table1, Me, False, 40)

            EstructuraGrillaProformaCab_DataGridView()
            FormatGrilla(Table2, Me, False, 40)

            LlenaDataCombo(CboTipoPer, ObjConst.Get_Constante("C", CLng(CboTipoPer.Tag)), "nConValor", "cConDescripcion")
            LlenaDataCombo(CboTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")
            CboTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI

            LlenaDataCombo(CboSexoTEmp, ObjConst.Get_Constante("B", CLng(CboSexoTEmp.Tag)), "nConValor", "cConDescripcion")

            'Me.WindowState = FormWindowState.Maximized

            Me.ActiveControl = TxtNroFind

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error. " & ex.Message, "Médica", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub C1CmdBuscar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdBuscar.Click

        BuscarPersona(Convert.ToInt32(CboTipoDocu.SelectedValue), TxtNroFind.Text.Trim)

    End Sub

    Private Sub ChkBoxFiltraFecha_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxFiltraFecha.CheckedChanged
        If ChkBoxFiltraFecha.Checked Then Panel1.Visible = True Else Panel1.Visible = False
    End Sub

    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        C1ToolBar.Enabled = False : GroupBox.Enabled = False : Table1.Enabled = False : Table2.Enabled = False : Panel2.Visible = True : Centrar(Panel2) : CboAppTipoDocu.Focus() : TxtAppNumDocu.Focus()

        LlenaDataCombo(CboAppTipoDocu, ObjConst.Get_Constante("C", CLng(nConPerNatural)), "nConValor", "cConDescripcion")
        CboAppTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Panel2.Visible = False : C1ToolBar.Enabled = True : GroupBox.Enabled = True : Table1.Enabled = True : Table2.Enabled = True
    End Sub

    Private Sub TxtAppNumDocu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAppNumDocu.KeyPress, TxtAppApellidoPaterno.KeyPress, TxtAppApellidoMaterno.KeyPress, TxtAppNombre1.KeyPress, TxtAppNombre2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub CboSexoTEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboSexoTEmp.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub DtpAppFecNaci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DtpAppFecNaci.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then SendKeys.Send("{Tab}")
    End Sub

    Function Validar_Datos(ByRef cMsg As String) As Boolean
        Dim bFlag As String = True

        If TxtAppNumDocu.Text.Trim = "" Then
            cMsg = "El Nº de Documento es obligatorio."
            bFlag = False
        ElseIf CboAppTipoDocu.SelectedValue = nConTipoDocPerNatural.nDNI And Len(TxtAppNumDocu.Text) <> 8 Then
            cMsg = "El DNI debe tener 8 dígitos."
            bFlag = False
        ElseIf TxtAppApellidoPaterno.Text.Trim = "" Then
            cMsg = "El Apellido Paterno es obligatorio."
            bFlag = False
        ElseIf TxtAppApellidoMaterno.Text.Trim = "" Then
            cMsg = "El Apellido Materno es obligatorio."
            bFlag = False
        ElseIf TxtAppNombre1.Text.Trim = "" Then
            cMsg = "El Primer Nombre es obligatorio."
            bFlag = False
        ElseIf DateDiff(DateInterval.Year, CDate(DtpAppFecNaci.Text), Now.Date) > 110 Then
            cMsg = "La fecha de nacimiento ingresada no es válida."
            bFlag = False
        ElseIf DateDiff(DateInterval.Day, CDate(DtpAppFecNaci.Text), Now.Date) < 0 Then
            cMsg = "La fecha de nacimiento no debe exceder la fecha actual."
            bFlag = False
        ElseIf Val(CboSexoTEmp.SelectedValue) = 0 Then
            cMsg = "El sexo es un dato obligatorio."
            bFlag = False
        End If

        Return bFlag
    End Function


    Private Sub BtnGuardarValidacion_Click(sender As Object, e As EventArgs) Handles BtnGuardarValidacion.Click

        Try

            Dim cMensajito As String = ""

            If Validar_Datos(cMensajito) Then

                Dim var_cPerCodigo As String
                '//Instaciamos
                Dim servicioGuardarPersonas As New BL_Personas
                '//Generamos Codigo Persona
                var_cPerCodigo = GeneraNewIdcPerCodigo()

                If Not servicioGuardarPersonas.GuardarPersona(cPerCodigo:=var_cPerCodigo, cPerApellido:=TxtAppApellidoPaterno.Text & Space(1) & TxtAppApellidoMaterno.Text, cPerNombre:=TxtAppNombre1.Text & Space(1) & TxtAppNombre2.Text, nPerTipo:=nConTipoPersona.nPerNatural,
                                                                dPerNacimiento:=DtpAppFecNaci.Value, cUbiGeoCodigo:="", nUbiGeoCodigo:=0, nPerIdeTipo:=CboAppTipoDocu.SelectedValue,
                                                                cPerIdeNumero:=TxtAppNumDocu.Text, cPerApellPaterno:=TxtAppApellidoPaterno.Text, cPerApellMaterno:=TxtAppApellidoMaterno.Text, cPerPriNombre:=TxtAppNombre1.Text, cPerSegNombre:=TxtAppNombre2.Text, cPerTerNombre:="", nPerTratamiento:=0,
                                                                nPerNatSexo:=CboSexoTEmp.SelectedValue) Then

                    Throw New ArgumentException("Ha ocurrido un error al registrar la Persona, por favor verifique.")
                Else
                    'Update DNI en tabla <Android.Proforma> si el DNI tiene algun correccion
                    If String.Compare(RTrim(TxtNroFind.Text), RTrim(TxtAppNumDocu.Text), False) < 0 Then
                        'Code...
                        Dim proforma As New Proforma
                        Dim servicio As New BL_Proforma

                        proforma.nPerIdeTipo = CboTipoDocu.SelectedValue
                        proforma.cPerIdeNumero = TxtNroFind.Text
                        'Validando si hay registros en detalle de proforma
                        If servicio.Android_Listar_Proforma_by_nPerIdeTipo_and_cPerIdeNumero(proforma).Rows.Count > 0 Then
                            'realizando cambio de datos en proforma se actualizan documento de identidad
                            If Not ActualizaProformaPorCambioDocumento(CboTipoDocu.SelectedValue, TxtNroFind.Text, CboAppTipoDocu.SelectedValue, TxtAppNumDocu.Text) Then
                                Throw New ArgumentException("Ha ocurrido un error al actualizar proforma, por favor verifique.")
                            End If
                        End If
                    End If
                    MessageBox.Show("Persona Móvil ha sido válido y registrado con éxito.", "Persona Móvil", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Vuelvo a cargar valores NUEVOS segun Validación
                    CboTipoDocu.SelectedValue = CboAppTipoDocu.SelectedValue
                    TxtNroFind.Text = TxtAppNumDocu.Text
                    LblcPerCodigo.Text = var_cPerCodigo
                    LblcNombre.Text = TxtAppApellidoPaterno.Text & Space(1) & TxtAppApellidoMaterno.Text & ", " & Space(1) & TxtAppNombre1.Text & Space(1) & TxtAppNombre2.Text

                    BtnValidar.Visible = False
                    BtnCancel_Click(BtnCancel, Nothing)

                    'Filtrando detalle de proforma
                    'FiltrarDetalleProforma(CboAppTipoDocu.SelectedValue, TxtNroFind.Text)
                    C1CmdBuscar_Click(C1CmdBuscar, Nothing)

                End If
            Else
                MessageBox.Show(cMensajito, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Table2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table2.CellContentClick
        Try
            If Table2.RowCount = 0 Then Exit Sub

            With Table2
                If Not .CurrentCell Is Nothing Then

                    If ChkBoxFiltraFecha.Checked Then
                        CargaGrilla(CboTipoDocu.SelectedValue, TxtNroFind.Text, Format(DtpFecIni.Value, "yyyy/MM/dd"), Format(DtpFecFin.Value, "yyyy/MM/dd"), "F", Table1, .Item(GrillaProformaCab.ColnCorrelativo, .CurrentRow.Index).Value.ToString)
                    Else
                        CargaGrilla(CboTipoDocu.SelectedValue, TxtNroFind.Text, Format(DtpFecIni.Value, "yyyy/MM/dd"), Format(DtpFecFin.Value, "yyyy/MM/dd"), "N", Table1, .Item(GrillaProformaCab.ColnCorrelativo, .CurrentRow.Index).Value.ToString)
                    End If

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub c1CmdGenerarFicha_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdGenerarFicha.Click

        Try
            If ValidaCamposObligatorios() Then

                Dim exito As Boolean = False

                Using scope As New TransactionScope()

                    Dim var_NroFichas As String
                    Dim Obj_NewId As New BL_FichaAtencion

                    Dim Req_CabAdmSolAtencion As New BE_ReqSolAtencion
                    Dim Obj_CabAdmSolAtencion As New BL_FichaAtencion

                    var_NroFichas = Obj_NewId.Get_NewId_AdmSolAtencion()

                    REM CABECERA 
                    With Req_CabAdmSolAtencion
                        .cPerJuridica = StrcPerJuridica
                        .nIntCodigo = TipoAtencion.Particular  'CInt(CboTipoCta.SelectedValue)
                        .cPerCodigoTerceros = "" 'IIf((CboTipoCta.SelectedValue <> TipoAtencion.Particular And CboTipoCta.SelectedValue <> TipoAtencion.AtencionExterna), CboEmpresa.SelectedValue, "")  'IIf(CboEmpresa.Enabled, CboEmpresa.SelectedValue, "")
                        .nPerIntCodigo = 0 'IIf(CboSede.Visible, CboSede.SelectedValue, 0)
                        .nSolAdmNumero = var_NroFichas
                        .cPerCodigo = LblcPerCodigo.Text
                        .dFecExamen = FormatDateTime(Date.Now, DateFormat.GeneralDate)
                        .nImpTotal = FormatNumber(Suma_Columna("nPrecio", Table1), True)
                        .cPerUseCodigo = StrUser
                        .nFlagComision = 0 'IIf(ChkDeriv.Checked, IIf(RdoBtnConComision.Checked, 1, 0), 0) 'Update 2016-01-12 (EINCIO)
                    End With

                    REM Grabando Cabecera
                    If Not Obj_CabAdmSolAtencion.Ins_AdmSolAtencion(Req_CabAdmSolAtencion) Then
                        Throw New System.Exception("Se encontraron errores en la transacción: [Ins_AdmSolAtencion]")
                    End If

                    '-----------------------------
                    REM Grabando DetAdmSolAtencion 
                    '-----------------------------
                    With Table1
                        REM Recorriendo la Grilla
                        For Each row As DataGridViewRow In .Rows
                            'Throw New ApplicationException("Se encontraron errores en la transaccion: " + "[Ins_CuentaCorriente_ProgracionPago]")
                            If Convert.ToDouble(row.Cells(GrillaProforma.ColnPrecio).Value) <= 0 Then Throw New System.Exception("Precio con Cero, no se puede completar la operación.")

                            Req_CabAdmSolAtencion.nCtaCteSerCodigo = CLng(row.Cells(GrillaProforma.ColnCtaCteSerCodigo).Value)

                            'update 2015-12-23
                            Req_CabAdmSolAtencion.cIntJerarquia = row.Cells(GrillaProforma.ColnIntJerarquia).Value

                            'Update 01-10-2015
                            Req_CabAdmSolAtencion.nCtaCteSerImpDef = FormatNumber(row.Cells(GrillaProforma.ColnCtaCteSerImpDef).Value, True)
                            Req_CabAdmSolAtencion.nTipoDscto = 0 'CLng(row.Cells(GrillaProforma.ColnTipoDscto).Value)

                            Req_CabAdmSolAtencion.nCtaCteCantidad = 1 'CLng(row.Cells(GrillaProforma.ColnCtaCteCantidad).Value) '1 'Defautl
                            Req_CabAdmSolAtencion.nCtaCteCosto = FormatNumber(row.Cells(GrillaProforma.ColnPrecio).Value, True)
                            Req_CabAdmSolAtencion.nFlag = CLng(row.Cells(GrillaProforma.ColnFlagGrupo).Value)

                            REM Insert DET
                            If Not Obj_CabAdmSolAtencion.Ins_DetAdmSolAtencion(Req_CabAdmSolAtencion) Then
                                Throw New System.Exception("Se encontraron errores en la transacción: [Ins_DetAdmSolAtencion]")
                            End If
                        Next
                    End With

                    '//Update Proforma como Usada y con que ficha se genero
                    Dim servicio As New BL_Proforma
                    Dim Objeto As New Proforma

                    Objeto.nCorrelativo = Convert.ToInt32(Table2.Item(GrillaProformaCab.ColnCorrelativo, Table2.CurrentRow.Index).Value)
                    Objeto.nPerIdeTipo = CboTipoDocu.SelectedValue
                    Objeto.cPerIdeNumero = TxtNroFind.Text
                    Objeto.nSolAdmNumero = var_NroFichas

                    If Not servicio.Android_Update_Proforma(Objeto) Then
                        Throw New System.Exception("Se encontraron errores en la transacción: [Upd_Android_Proforma]")
                    End If

                    'Colocar datos en el Portapapeles 
                    Clipboard.SetDataObject(var_NroFichas)
                    FormGridFichaAtencion.TxtBuscar.Text = Clipboard.GetDataObject.ToString

                    exito = True
                    scope.Complete()

                End Using

                If exito Then
                    MessageBox.Show("Se ha Generado la Ficha de Atención con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    C1CmdCerrar_Click(C1CmdCerrar, Nothing)
                End If

            End If

        Catch ex As Exception 'TransactionAbortedException 'Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TxtNroFind_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNroFind.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then C1CmdBuscar_Click(C1CmdBuscar, Nothing)
    End Sub


End Class