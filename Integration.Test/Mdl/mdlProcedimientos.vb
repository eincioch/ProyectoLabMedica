Option Explicit On
Imports CrystalDecisions.CrystalReports.Engine
Imports Integration.BE
Imports Integration.BE.PadronReniec
Imports Integration.BE.Sistema
Imports Integration.BL
Imports Integration.BL.BL_Reniec

Imports Integration.BL.GestionarAdmSolPerTokenServicio
Imports Integration.BE.AdmSolPerToken

'To include StarIO into your VB.NET project, please look at the README for a walkthrough
Imports StarMicronics.StarIO 'Added as a reference from the "Dependencies" directory 
Imports System.Text

Module mdlProcedimientos

    Private codePageClass As New codePage

    Public Function Get_DatosReniec(ByVal DNI As String) As DataTable

        Try
            Dim Objeto As New Reniec
            Dim servicio As New BL_Reniec

            Objeto.dni = DNI
            Return servicio.Get_Datos_Reniec_Local_by_dni(Objeto)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function Get_PorcIgv(ByVal cPerJuridica As String) As Double
        Try
            Dim sParamString As New BE_IGV
            sParamString.cPerJuridica = cPerJuridica
            Return ObjSistemaServicio.Get_PorcIGV_by_cPerJuridica(sParamString)
        Catch ex As Exception
            Return 0 'MessageBox.Show("Ha ocurrido un Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Public Sub MessageStateTool(ByRef Label As Label, ByVal Mensaje As String, Optional ByVal TipoError As Boolean = False)
        If Not TipoError Then
            Label.Text = Mensaje : Label.BackColor = Color.Red : Label.ForeColor = Color.White : Label.Visible = True
        Else
            Label.Text = Mensaje : Label.BackColor = Color.FromArgb(50, 107, 146) : Label.ForeColor = Color.White : Label.Visible = False
        End If
    End Sub

    Public Sub ResaltarTextBox(ByVal control As TextBox)
        control.SelectionStart = 0
        control.SelectionLength = control.Text.Length
    End Sub

    'Update 2016-01-19 (eincio)
    Public Sub ObtenerPeriodosPorSucursal(ByVal Combo As ComboBox, ByVal cPerCodSucursal As String, Optional ByVal nPeriodo As Integer = 0, Optional ByVal YearOMes As String = "A")
        Dim Request As New Sistema.BE_ReqPeriodo
        Dim Obj As New BL_Sistema

        Request.cPerJurCodigo = cPerCodSucursal
        Request.nSisGruCodigo = nPeriodo
        Request.cflag = YearOMes
        LlenaDataCombo(Combo, Obj.Get_Periodo(Request), "nPrdCodigo", "cPrdDescripcion")
    End Sub

    Public Sub Centrar(ByVal Objeto As Object)

        ' Centrar un Formulario ...  
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
                frm.Top = (.Height - frm.Height) \ 2
                frm.Left = (.Width - frm.Width) \ 2
            End With

            ' Centrar un control dentro del contenedor  
        Else
            ' referencia al control  
            Dim c As Control = CType(Objeto, Control)

            'le  establece el top y el Left dentro del Parent  
            With c
                .Top = (.Parent.ClientSize.Height - c.Height) \ 2
                .Left = (.Parent.ClientSize.Width - c.Width) \ 2
            End With
        End If
    End Sub

    Public Sub LimpiarTextBox(ByVal Form As Form)
        For Each Control In Form.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = "" 'vbNullString
            End If
        Next
    End Sub

    Public Sub LimpiarTextBoxGroup(ByVal Grupo As Windows.Forms.GroupBox)
        Dim miControl As Object
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                miControl.Clear()
            End If
            System.Windows.Forms.Application.DoEvents()
        Next
    End Sub

    Public Sub LimpiarTextBoxTabs(ByVal Grupo As Windows.Forms.TabPage)
        Dim miControl As Object
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                miControl.Clear()
            End If
            System.Windows.Forms.Application.DoEvents()
        Next
    End Sub

    'Function para abrir formularios 
    Public Sub llamarform(ByVal formulario As Form, _
                    ByVal mdi As Form, Optional cOpcion As String = "") ', ByVal tipo As Integer)

        Dim frmllamado As Form
        Dim escargado As Boolean = False

        Try
            'Chequea si el formulario ha sido cargado
            For Each frmllamado In mdi.MdiChildren
                'Compara si es igual y retorna verdadero si lo es.
                If frmllamado.Text = formulario.Text Then
                    escargado = True   'Marca la bandera
                    Exit For      'Sale del loop si es verdadero
                End If
            Next

            If Not escargado Then
                'Carga el formulario si no esta llamado
                formulario.Tag = cOpcion
                formulario.MdiParent = mdi
                formulario.Show()
            ElseIf escargado Then
                formulario.Focus()   'Enfoca el objeto
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        'formulario.WindowState = FormWindowState.Maximized
        formulario = Nothing  'Limpiar todo
        frmllamado = Nothing

    End Sub

    Public Sub EliminarRowsDgView(ByRef ControlDgView As DataGridView)

        With ControlDgView
            If .RowCount > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows.Remove(.CurrentRow)
                Next
            End If
        End With

    End Sub


    Public Sub EliminaRowSeleccionada(ByRef ControlDgView As DataGridView)

        With ControlDgView
            If .RowCount > 0 Then
                .Rows.Remove(.CurrentRow)
            Else
                MessageBox.Show("No existe ningúna fila (items) para quitar..!", "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With

    End Sub

    Public Sub EliminarRowsDg_for_Condicion(ByRef ControlDgView As DataGridView, ByRef NameColumn As String, Optional ByRef nCondicion As Integer = 1)

        REM Create: EIncio
        REM Metodo Elimina Rows de un DataGridView segun condicion y lo comienza desde la ultima fila hace la 1ra fila. 
        Dim nFila As Integer

        With ControlDgView
            For nFila = .Rows.Count - 1 To 0 Step -1
                If .Rows(nFila).Cells(NameColumn).Value = nCondicion Then
                    If Not (.Rows(nFila).IsNewRow) Then
                        .Rows.Remove(.Rows(nFila))
                    End If
                End If
            Next
        End With
    End Sub


    Public Sub CrearNodosDelPadre(ByVal indicePadre As Integer, ByVal nodePadre As TreeNode, _
                                        ByRef ControlTreeView As TreeView, ByRef DataSetArbol As DataSet)
        Dim dataViewHijos As DataView

        ' Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
        dataViewHijos = New DataView(DataSetArbol.Tables(0))

        dataViewHijos.RowFilter = DataSetArbol.Tables("Interface").Columns("cIntNombre").ColumnName + " = " + indicePadre.ToString()

        ' Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
        For Each dataRowCurrent As DataRowView In dataViewHijos

            Dim nuevoNodo As New TreeNode
            nuevoNodo.Text = dataRowCurrent("cIntDescripcion").ToString().Trim()
            nuevoNodo.Name = dataRowCurrent("nIntCodigo").ToString().Trim()
            ' nuevoNodo.ToolTipText = dataRowCurrent("nIntCodigo").ToString().Trim()

            nuevoNodo.Tag = dataRowCurrent("cIntNombre").ToString().Trim()
            nuevoNodo.ToolTipText = dataRowCurrent("cIntJerarquia").ToString().Trim()

            If nuevoNodo.Tag <> 0 Then
                nuevoNodo.ImageIndex = 2
                nuevoNodo.SelectedImageIndex = 3
            Else
                nuevoNodo.ImageIndex = 0
                nuevoNodo.SelectedImageIndex = 1
            End If

            ' si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
            ' del primer nivel que no dependen de otro nodo.
            If nodePadre Is Nothing Then
                ControlTreeView.Nodes.Add(nuevoNodo)
            Else
                ' se añade el nuevo nodo al nodo padre.
                nodePadre.Nodes.Add(nuevoNodo)
            End If

            ' Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
            REM CrearNodosDelPadre(Int32.Parse(dataRowCurrent("cIntJerarquia").ToString()), nuevoNodo, ControlTreeView, DataSetArbol)
            CrearNodosDelPadre(Int32.Parse(dataRowCurrent("nIntCodigo").ToString()), nuevoNodo, ControlTreeView, DataSetArbol)
        Next dataRowCurrent

    End Sub

    Public Sub Actualiza_AdmSolPerToken(ByVal cPerUsuDscto As String, ByVal StrcPerJuridica As String, ByVal cKeyToken As String, ByVal nTipo As Integer, ByVal nSolAtencion As String)

        Dim admSolPerToken As New AdmSolPerToken
        Dim gestionarAdmSolPerTokenServicio As New GestionarAdmSolPerTokenServicio

        admSolPerToken.cPerCodigo = cPerUsuDscto
        admSolPerToken.cPerJurCodigo = StrcPerJuridica
        admSolPerToken.cToken = cKeyToken
        admSolPerToken.nTipo = nTipo 'nSisGruCodigo.AdmisionAprobador
        admSolPerToken.nSolAdmNumero = nSolAtencion 'LblNroSolicitud.Text

        If Not gestionarAdmSolPerTokenServicio.Upd_AdmSolPerToken(admSolPerToken) Then
            Throw New System.Exception("Se encontraron errores en la transaccion: [Upd_AdmSolPerToken]")
        End If

    End Sub

    Public Function Validar_AdmSolPerToken(ByVal cPerUsuDscto As String, ByVal StrcPerJuridica As String, ByVal cKeyToken As String, ByVal nTipo As Integer) As Boolean

        Dim admSolPerToken As New AdmSolPerToken
        Dim gestionarAdmSolPerTokenServicio As New GestionarAdmSolPerTokenServicio

        admSolPerToken.cPerCodigo = cPerUsuDscto
        admSolPerToken.cPerJurCodigo = StrcPerJuridica
        admSolPerToken.cToken = cKeyToken
        admSolPerToken.nTipo = nTipo 'nSisGruCodigo.AdmisionAprobador

        cDT = gestionarAdmSolPerTokenServicio.Get_AdmSolPerToken(admSolPerToken)

        If cDT.Rows.Count > 0 Then Validar_AdmSolPerToken = True Else Validar_AdmSolPerToken = False

        Return Validar_AdmSolPerToken

    End Function

    Public Sub CargaReporte(ByVal cPathRPT As String, ByVal CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer, _
                            ByVal FormulaFields As Dictionary(Of String, String), ByVal Data As DataTable)

        Dim CrReport As New ReportDocument

        Try
            CrReport = New ReportDocument()
            CrReport.Load(cPathRPT)

            For Each Campo As KeyValuePair(Of String, String) In FormulaFields
                CrReport.DataDefinition.FormulaFields(Campo.Key).Text = Chr(34) & Campo.Value & Chr(34)
            Next

            CrReport.SetDataSource(Data)

            CRV.ReportSource = CrReport

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error A:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CrReport.Close()
        End Try

    End Sub

    Public Function WritePortHelper(ByVal activePort As IPort, ByVal writeBuffer() As Byte) As UInteger
        Dim zeroProgressOccurnaces As UInteger = 0
        Dim totalSizeCommunicated As UInteger = 0
        Try
            While ((totalSizeCommunicated < writeBuffer.Length) And (zeroProgressOccurnaces < 2)) ' adjust zeroProgressOccurances as needed
                Dim sizeCommunicated As UInteger = activePort.WritePort(writeBuffer, totalSizeCommunicated, CUInt(writeBuffer.Length) - totalSizeCommunicated)
                If (sizeCommunicated = 0) Then
                    zeroProgressOccurnaces += CType(1, UInteger)
                Else
                    totalSizeCommunicated = totalSizeCommunicated + sizeCommunicated
                    zeroProgressOccurnaces = 0
                End If
            End While
        Catch ex As PortException
            MessageBox.Show(ex.Message, "GetPort Error")
            'Me.lblPrinterStatus.Text = "GetPort Error"
            'Me.lblPrinterStatus.ForeColor = Color.Red
        End Try
        WritePortHelper = totalSizeCommunicated
    End Function

    Public Sub PrintStarIO(ByVal cPerJurCodigo As String, ByVal nCtaCteComCodigo As Integer, ByVal cCtaCteComNumero As String)

        Dim activePort As IPort = Nothing
        Dim command As Byte() = New Byte() {}

        Dim dtStarIO As New DataTable
        Dim ObjSis As New BL_Sistema

        Windows.Forms.Cursor.Current = Cursors.WaitCursor

        Try
            '------------------------------
            'Obteniendo datos de Impresora
            '------------------------------
            dtStarIO = ObjSis.Get_Value_Table("cSerie,cNombreImpresora,cPort,cCodAutSUNAT", "Medica.CtaCteDatosImpresora", "", 2, "cPerJurCodigo = '" & cPerJurCodigo & "' AND nCajCodigo = " & CInt(ObtenerParametroAppConfig("NroCaja")) & " ")
            If dtStarIO.Rows.Count > 0 Then
                '"Nº de Serie: " & dtStarIO.Rows(0).Item("cPort"))
                activePort = StarMicronics.StarIO.Factory.I.GetPort(dtStarIO.Rows(0).Item("cPort").ToString, "", 10000)
                'activePort = StarMicronics.StarIO.Factory.I.GetPort("USB001", "", 10000)
            Else
                MessageBox.Show("Impresora no encontrada.", "StarIO Line Mode VB.NET SDK", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim ServicioPrint As New BL_CtasCtesMedica.BL_CtaCteComprobante
            Dim cHeader As New DataTable

            Dim ServicioDocRef As New BL_CtasCtesMedica.BL_CtaCteComprobante
            Dim DetDocuRef As New DataTable

            cHeader = ServicioPrint.Get_Fiscal_Header(cPerJurCodigo, nCtaCteComCodigo, cCtaCteComNumero)
            If cHeader.Rows.Count = 0 Then
                MessageBox.Show("Número de Documento no Existe", "Imprimiendo..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            '----------------------------
            'Recuperando datos a Imprimir
            '----------------------------
            Dim encoding As UTF8Encoding = New UTF8Encoding()

            Dim commandList As List(Of Byte) = New List(Of Byte)

            commandList.AddRange(New Byte() {&H1B, &H1D, &H3, &H4, &H0, &H0, &H1B, &H1D, &H3, &H3, &H0, &H0}) ' Command A

            commandList.AddRange(New Byte() {&H1B, &H1C, &H70, &H1, &H0, &HD, &HA}) 'Stored Logo Printing - Refer to Pg. 3-38
            commandList.AddRange(New Byte() {&H1B, &H1D, &H61, &H1}) 'Center Alignment

            commandList.AddRange(encoding.GetBytes(vbLf + cHeader.Rows(0).Item("cSucursal").ToString + vbCrLf))
            commandList.AddRange(New Byte() {&H1B, &H45}) 'Bold
            commandList.AddRange(encoding.GetBytes(cHeader.Rows(0).Item("cEmpresa").ToString + vbCrLf))
            commandList.AddRange(encoding.GetBytes("R.U.C. " + cHeader.Rows(0).Item("cRUC").ToString + vbCrLf))
            commandList.AddRange(encoding.GetBytes(cHeader.Rows(0).Item("cDomicilioFiscal").ToString + vbCrLf))
            commandList.AddRange(New Byte() {&H1B, &H46}) 'Bold off
            commandList.AddRange(encoding.GetBytes("Telef. " + cHeader.Rows(0).Item("cFono").ToString + vbCrLf))
            commandList.AddRange(encoding.GetBytes(cHeader.Rows(0).Item("cUbigeo").ToString + vbCrLf + vbCrLf))

            Dim targetCodePage As Encoding '(1)
            Dim selectedCodePage As Object = "437" '(3)
            Dim codePage As Integer = System.Convert.ToInt32("437") '(4)
            targetCodePage = System.Text.Encoding.GetEncoding(codePage) '(5)
            Dim cmd As String = codePageClass.getStarIOcodePageCmd(selectedCodePage.ToString()) '(7)

            '----------
            'Nro. Caja
            '----------
            commandList.AddRange(targetCodePage.GetBytes(cmd + "Nro. Autorización SUNAT: " & dtStarIO.Rows(0).Item("cCodAutSUNAT").ToString + vbCrLf))
            commandList.AddRange(encoding.GetBytes("Nro. de Serie: " & dtStarIO.Rows(0).Item("cSerie").ToString + vbCrLf))
            commandList.AddRange(encoding.GetBytes("CAJA Nro. " & cHeader.Rows(0).Item("nCaja").ToString + vbCrLf + vbCrLf))
            commandList.AddRange(encoding.GetBytes(cHeader.Rows(0).Item("TipoDocu") + cHeader.Rows(0).Item("SerieCorrelativo").ToString + vbCrLf))
            commandList.AddRange(New Byte() {&H1B, &H69, &H1, &H1}) 'Character Expansion
            commandList.AddRange(encoding.GetBytes("FECHA Y HORA: " & cHeader.Rows(0).Item("dCtaCteEmiFecha").ToString + vbCrLf))
            commandList.AddRange(New Byte() {&H1B, &H69, &H0, &H0}) 'Cancel Character Expansion

            'Datos Cliente quien Factura 
            commandList.AddRange(New Byte() {&H1B, &H45}) 'Bold
            'If CInt(cHeader.Rows(0).Item("nCtaCteComCodigo")) = TipoDocuVta.Factura Then 'Factura
            If Len(Trim(cHeader.Rows(0).Item("cPerIdeNumero"))) = 11 Then 'T/Factura
                commandList.AddRange(encoding.GetBytes("R.U.C.: " & cHeader.Rows(0).Item("cPerIdeNumero").ToString + vbCrLf))
                commandList.AddRange(targetCodePage.GetBytes(cmd + "RAZON SOCIAL: " & cHeader.Rows(0).Item("Cliente").ToString + vbCrLf))
                commandList.AddRange(targetCodePage.GetBytes(cmd + "DOMICILIO FISCAL: " & cHeader.Rows(0).Item("DomicilioFiscal").ToString + vbCrLf + vbCrLf))
            Else
                commandList.AddRange(encoding.GetBytes("D.N.I: " & cHeader.Rows(0).Item("cPerIdeNumero").ToString + vbCrLf))
                commandList.AddRange(encoding.GetBytes("CLIENTE: " & Microsoft.VisualBasic.Left(cHeader.Rows(0).Item("Cliente").ToString, 35) + vbCrLf))
            End If
            commandList.AddRange(New Byte() {&H1B, &H46}) 'Bold off

            commandList.AddRange(New Byte() {&H1B, &H1D, &H61, &H0}) 'Left Alignment
            commandList.AddRange(New Byte() {&H1B, &H44, &H2, &H10, &H22, &H0}) 'Setting Horizontal Tab
            'commandList.AddRange(encoding.GetBytes("Date: MM/DD/YYYY" + "             Time:HH:MM PM" + vbCrLf))
            commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))

            commandList.AddRange(targetCodePage.GetBytes(cmd + "Código" + Chr(&H20) + Chr(&H20) + Microsoft.VisualBasic.Left("Descripción         ", 20) + Chr(&H20) + Chr(&H20) + Chr(&H20) + IIf((cHeader.Rows(0).Item("nIntClase") = 1014 Or cHeader.Rows(0).Item("nIntClase") = 1015), "Cant", "    ") + Chr(&H20) + "  Importe" + vbCrLf))
            'commandList.AddRange(encoding.GetBytes(Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H1) + "Código" + Chr(&H20) + Chr(&H20) + Microsoft.VisualBasic.Left("Descripción         ", 20) + Chr(&H20) + Chr(&H20) + Chr(&H20) + "Cant" + Chr(&H20) + "  Importe" + vbCrLf))
            commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))

            '--------------
            'Carga detalle  'Update (eincio) f.2015-01-08
            '--------------
            Dim Obj_DetAdmSol As New BL_FichaAtencion.BL_FichaAtencion
            Dim dtDetAdmSol As New DataTable

            Select Case Convert.ToInt32(cHeader.Rows(0).Item("nIntClase"))
                Case 1014 '//Pago Normal
                    'dtDetAdmSol = Obj_DetAdmSol.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(cPerJurCodigo, cHeader.Rows(0).Item("nSolAdmNumero"))
                    dtDetAdmSol = Obj_DetAdmSol.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero_Ticket(cPerJurCodigo, cHeader.Rows(0).Item("nSolAdmNumero"), cHeader.Rows(0).Item("cCtaCteRecibo")) 'Update 2015-01-14 (eincio) Correccion 2016-01-26 
                    'Leyendo un DataTable
                    If dtDetAdmSol.Rows.Count > 0 Then
                        Dim row As DataRow
                        For Each row In dtDetAdmSol.Rows
                            commandList.AddRange(targetCodePage.GetBytes(cmd + CStr(row("cCtaCteSerJerarquia").ToString) + Chr(&H20) + Chr(&H20) + Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left(CStr(row("cCtaCteSerKeyWord").ToString), 20) + "                    ", 20) + Chr(&H20) + Microsoft.VisualBasic.Right("    " + CStr(row("nCtaCteCantidad").ToString), 4) + Chr(&H20) + Microsoft.VisualBasic.Right("          " + FormatNumber(row("nCtaCteSerImpDef"), True), 10) + vbCrLf))
                        Next
                    End If
                Case 1015 '//Pago en Bloque
                    dtDetAdmSol = Obj_DetAdmSol.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(cPerJurCodigo, cHeader.Rows(0).Item("cCtaCteRecibo"))
                    'Leyendo un DataTable
                    If dtDetAdmSol.Rows.Count > 0 Then
                        Dim row As DataRow
                        For Each row In dtDetAdmSol.Rows
                            commandList.AddRange(targetCodePage.GetBytes(cmd + CStr(row("cCtaCteSerJerarquia").ToString) + Chr(&H20) + Chr(&H20) + Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left(CStr(row("cCtaCteSerKeyWord").ToString), 20) + "                    ", 20) + Chr(&H20) + Microsoft.VisualBasic.Right("    " + CStr(row("nCtaCteCantidad").ToString), 4) + Chr(&H20) + Microsoft.VisualBasic.Right("          " + FormatNumber(row("nCtaCteSerImpDef"), True), 10) + vbCrLf))
                        Next
                    End If
                Case 1013 '//Pago Anticipo
                    'Imprime cuando es por Anticipo
                    commandList.AddRange(targetCodePage.GetBytes(cmd + "ANT999" + Chr(&H20) + Chr(&H20) + Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left("PAGO POR ANTICIPO", 20) + "                    ", 20) + Chr(&H20) + Microsoft.VisualBasic.Right("    " + " ", 4) + Chr(&H20) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("fCtaCteImporte"), True), 10) + vbCrLf))
            End Select

            'If cHeader.Rows(0).Item("nIntClase") = 1014 Then
            '    'Dim nPos As Integer
            '    Dim Obj_DetAdmSol As New BL_FichaAtencion.BL_FichaAtencion
            '    Dim dtDetAdmSol As New DataTable

            '    dtDetAdmSol = Obj_DetAdmSol.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(cPerJurCodigo, cHeader.Rows(0).Item("nSolAdmNumero"))

            '    'Leyendo un DataTable
            '    If dtDetAdmSol.Rows.Count > 0 Then
            '        Dim row As DataRow

            '        For Each row In dtDetAdmSol.Rows
            '            commandList.AddRange(targetCodePage.GetBytes(cmd + CStr(row("cCtaCteSerJerarquia").ToString) + Chr(&H20) + Chr(&H20) + Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left(CStr(row("cCtaCteSerKeyWord").ToString), 20) + "                    ", 20) + Chr(&H20) + Microsoft.VisualBasic.Right("    " + CStr(row("nCtaCteCantidad").ToString), 4) + Chr(&H20) + Microsoft.VisualBasic.Right("          " + FormatNumber(row("nCtaCteSerImpDef"), True), 10) + vbCrLf))

            '        Next
            '    End If
            'Else
            '    'Imprime cuando es por Anticipo
            '    commandList.AddRange(targetCodePage.GetBytes(cmd + "ANT999" + Chr(&H20) + Chr(&H20) + Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left("PAGO POR ANTICIPO", 20) + "                    ", 20) + Chr(&H20) + Microsoft.VisualBasic.Right("    " + " ", 4) + Chr(&H20) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("fCtaCteImporte"), True), 10) + vbCrLf))
            'End If

            'El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio 
            If CInt(cHeader.Rows(0).Item("nConValor")) <> 5 Then 'cuando sea diferente de Cortesia
                If Convert.ToDouble(cHeader.Rows(0).Item("nCtaCteSerImpDef")) > Convert.ToDouble(cHeader.Rows(0).Item("fCtaCteImporte")) Then
                    commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
                    commandList.AddRange(encoding.GetBytes("IMP. BRUTO S/. " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("nCtaCteSerImpDef"), True), 10) + vbCrLf))
                    commandList.AddRange(New Byte() {&H1B, &H34}) 'Specify White/Black Invert
                    commandList.AddRange(encoding.GetBytes("DSCTO. S/. " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + Format(cHeader.Rows(0).Item("nCtaCteDscto"), "-#,###.#0"), 10) + vbCrLf))
                    commandList.AddRange(New Byte() {&H1B, &H35}) 'Cancel White/Black Invert
                End If
            End If

            If Len(Trim(cHeader.Rows(0).Item("cPerIdeNumero"))) = 11 Then 'T/Factura
                'If CInt(cHeader.Rows(0).Item("nCtaCteComCodigo")) = TipoDocuVta.TFactura Then 'Factura (se bloqueo 01-10-2015)
                commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
                commandList.AddRange(encoding.GetBytes("NETO S/. " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("fCtaCteImporte"), True), 10) + vbCrLf))
                If cHeader.Rows(0).Item("nIntClase") = 1014 And Convert.ToDouble(cHeader.Rows(0).Item("fCtaCteImporteA")) > 0 Then
                    commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
                    commandList.AddRange(New Byte() {&H1B, &H34}) 'Specify White/Black Invert
                    commandList.AddRange(encoding.GetBytes("ANTICIPO. S/. " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + Format(cHeader.Rows(0).Item("fCtaCteImporteA"), "-#,###.#0"), 10) + vbCrLf))
                    commandList.AddRange(New Byte() {&H1B, &H35}) 'Cancel White/Black Invert
                    commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
                    commandList.AddRange(encoding.GetBytes("IMPORTE. S/. " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("fnRestante"), True), 10) + vbCrLf))
                End If
                commandList.AddRange(encoding.GetBytes("SUBTOTAL " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("nGravada"), True), 10) + vbCrLf))
                commandList.AddRange(encoding.GetBytes("IGV 18% " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("nIgv"), True), 10) + vbCrLf))
                commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
                commandList.AddRange(New Byte() {&H1B, &H45}) 'Bold
                commandList.AddRange(encoding.GetBytes("IMPORTE. S/. " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("fnRestante"), True), 10) + vbCrLf))
                commandList.AddRange(New Byte() {&H1B, &H46}) 'Bold off
                commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf + vbCrLf))

            Else
                commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
                commandList.AddRange(New Byte() {&H1B, &H45}) 'Bold
                commandList.AddRange(encoding.GetBytes("IMP. TOTAL S/. " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("fCtaCteImporte"), True), 10) + vbCrLf))
                commandList.AddRange(New Byte() {&H1B, &H46}) 'Bold off
                commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
                If cHeader.Rows(0).Item("nIntClase") = 1014 And Convert.ToDouble(cHeader.Rows(0).Item("fCtaCteImporteA")) > 0 Then
                    'commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
                    commandList.AddRange(New Byte() {&H1B, &H34}) 'Specify White/Black Invert
                    commandList.AddRange(encoding.GetBytes("ANTICIPO. S/. " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + Format(cHeader.Rows(0).Item("fCtaCteImporteA"), "-#,###.#0"), 10) + vbCrLf))
                    commandList.AddRange(New Byte() {&H1B, &H35}) 'Cancel White/Black Invert
                    commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
                    commandList.AddRange(New Byte() {&H1B, &H45}) 'Bold
                    commandList.AddRange(encoding.GetBytes("IMPORTE. S/. " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("fnRestante"), True), 10) + vbCrLf))
                    commandList.AddRange(New Byte() {&H1B, &H46}) 'Bold off
                    commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf + vbCrLf))
                End If
            End If

            'commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
            'commandList.AddRange(New Byte() {&H1B, &H45}) 'Bold
            'commandList.AddRange(encoding.GetBytes("IMP. TOTAL S/. " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("fCtaCteImporte"), True), 10) + vbCrLf))
            'commandList.AddRange(New Byte() {&H1B, &H46}) 'Bold off
            'commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf + vbCrLf))

            '---------------
            'Datos Paciente
            '---------------
            commandList.AddRange(New Byte() {&H1B, &H45}) 'Bold
            commandList.AddRange(encoding.GetBytes("PACIENTE: " & Microsoft.VisualBasic.Left(cHeader.Rows(0).Item("Paciente").ToString, 34) + vbCrLf))
            commandList.AddRange(encoding.GetBytes("NRO. FICHA: " & cHeader.Rows(0).Item("nSolAdmNumero") + vbCrLf + vbCrLf))
            commandList.AddRange(New Byte() {&H1B, &H46}) 'Bold off

            '------------------------
            'Forma de Pago (Detalle)
            '-----------------------
            Dim fila As DataRow

            commandList.AddRange(encoding.GetBytes("FORMA DE PAGO:" + vbCrLf))
            For Each fila In cHeader.Rows
                commandList.AddRange(targetCodePage.GetBytes(cmd + fila("cConDescripcion") + Chr(&H20) + FormatNumber(fila("fCtaCtePagImporte"), True) + vbCrLf))
            Next
            commandList.AddRange(encoding.GetBytes(vbCrLf))

            'Al pagar completo.
            If cHeader.Rows(0).Item("nIntClase") = 1014 Then
                DetDocuRef = ServicioDocRef.Get_Detalle_DocuRef_Anticipo(cHeader.Rows(0).Item("nSolAdmNumero"))
                'Si hay anticipos los imprime como referencia
                If DetDocuRef.Rows.Count > 0 Then
                    commandList.AddRange(encoding.GetBytes("DOCU. REF. ANTICIPO:" + vbCrLf))
                    Dim row As DataRow

                    For Each row In DetDocuRef.Rows
                        commandList.AddRange(encoding.GetBytes(CStr(row("DocRef").ToString) + vbCrLf))
                    Next
                    commandList.AddRange(encoding.GetBytes(vbCrLf))
                End If
            End If

            '---------------------------------------
            'Usuario Cajero (quien hace la atencion)
            commandList.AddRange(encoding.GetBytes("ATENDIDO POR: " & cHeader.Rows(0).Item("cPerUsuCodigo") + vbCrLf + vbCrLf))
            '---------------------------------------

            '//El metodo AddFooterLine funciona igual que la cabecera 
            commandList.AddRange(New Byte() {&H1B, &H1D, &H61, &H1}) 'Center Alignment
            commandList.AddRange(encoding.GetBytes(cHeader.Rows(0).Item("Mensaje1") + vbCrLf + vbCrLf))

            'a.AnadeLineaAlPie("Toda devolución se efectuara con cheque o transferencia bancaria, en un plazo no mayor a 7 días.")

            commandList.AddRange(targetCodePage.GetBytes(cmd + cHeader.Rows(0).Item("Mensaje2") + vbCrLf))
            commandList.AddRange(targetCodePage.GetBytes(cmd + cHeader.Rows(0).Item("Mensaje3") + vbCrLf))
            commandList.AddRange(targetCodePage.GetBytes(cmd + cHeader.Rows(0).Item("Mensaje4")))
            commandList.AddRange(encoding.GetBytes(Chr(&H1B) & Chr(&H1D) & Chr(&H74) & Chr(&H4F) + "consultas@medica.com.pe" + vbCrLf))

            If cHeader.Rows(0).Item("cPerUsuCodCliente") <> "" And cHeader.Rows(0).Item("cPerUsuPwdCliente") <> "" Then
                commandList.AddRange(New Byte() {&H1B, &H45}) 'Bold
                commandList.AddRange(targetCodePage.GetBytes(cmd + vbCrLf))
                commandList.AddRange(targetCodePage.GetBytes(cmd + cHeader.Rows(0).Item("Mensaje5") + vbCrLf))
                commandList.AddRange(targetCodePage.GetBytes(cmd + cHeader.Rows(0).Item("Mensaje6") + vbCrLf))
                commandList.AddRange(targetCodePage.GetBytes(cmd + cHeader.Rows(0).Item("Mensaje7") + vbCrLf))
                commandList.AddRange(targetCodePage.GetBytes(cmd + cHeader.Rows(0).Item("cPerUsuCodCliente") + vbCrLf))
                commandList.AddRange(targetCodePage.GetBytes(cmd + cHeader.Rows(0).Item("cPerUsuPwdCliente") + vbCrLf))
                commandList.AddRange(New Byte() {&H1B, &H46}) 'Bold off
            End If

            'inverti color
            'commandList.AddRange(New Byte() {&H1B, &H34}) 'Specify White/Black Invert
            'commandList.AddRange(encoding.GetBytes("Refunds and Exchanges"))
            'commandList.AddRange(New Byte() {&H1B, &H35}) 'Cancel White/Black Invert


            commandList.AddRange(New Byte() {&H1B, &H64, &H2}) 'Cut
            commandList.Add(&H7)                                'Open Cash Drawer

            commandList.AddRange(New Byte() {&H1B, &H1D, &H3, &H4, &H0, &H0}) ' Command B

            command = commandList.ToArray()

            'Dim totalSizeCommunicated As UInteger = MainForm.WritePortHelper(activePort, command)
            Dim totalSizeCommunicated As UInteger = WritePortHelper(activePort, command)
            If totalSizeCommunicated <> command.Length Then
                Console.WriteLine("Error - not all data could be written out.")
                Exit Sub
            Else
                Console.WriteLine("Success")
            End If
        Catch px As PortException
            Console.WriteLine("Failure - see stack trace:" & vbLf & px.StackTrace)
        Finally
            If activePort IsNot Nothing Then
                StarMicronics.StarIO.Factory.I.ReleasePort(activePort)
            End If
        End Try

        'SMForm.appendLog(command)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Public Sub ImprimeTicket(ByVal cPerJurCodigo As String, ByVal nCtaCteComCodigo As Integer, ByVal cCtaCteComNumero As String)

        Try
            Static impresora As String

            Dim Objdt As New DataTable
            Dim ObjSis As New BL_Sistema

            Dim a As Imprimir = New Imprimir
            a.MargenIzquierdo = 1
            a.MargenSuperior = 1

            Dim ServicioPrint As New BL_CtasCtesMedica.BL_CtaCteComprobante
            Dim cHeader As New DataTable

            Dim ServicioDocRef As New BL_CtasCtesMedica.BL_CtaCteComprobante
            Dim DetDocuRef As New DataTable

            cHeader = ServicioPrint.Get_Fiscal_Header(cPerJurCodigo, nCtaCteComCodigo, cCtaCteComNumero)

            If cHeader.Rows.Count = 0 Then
                MessageBox.Show("Número de Documento no Existe", "Imprimiendo..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Logo Medica
            'a.HeaderImage = System.Drawing.Image.FromFile(Application.StartupPath & "\logo-medica.jpg")

            Dim sCadena As String = vbNullString

            '--------------------------
            'Datos Empresa y/o Sucursal
            '--------------------------
            sCadena = cHeader.Rows(0).Item("cSucursal")
            a.AnadirLineaCabeza(sCadena.PadLeft(41 - Len(sCadena)))

            sCadena = cHeader.Rows(0).Item("cEmpresa")
            a.AnadirLineaCabeza(sCadena.PadLeft(41 - Len(sCadena)))
            a.AnadirLineaCabeza("R.U.C. " & cHeader.Rows(0).Item("cRUC"))
            a.AnadirLineaCabeza(cHeader.Rows(0).Item("cDomicilioFiscal")) 'direccion
            a.AnadirLineaCabeza("Telef. " & cHeader.Rows(0).Item("cFono"))
            a.AnadirLineaCabeza(cHeader.Rows(0).Item("cUbigeo"))
            a.AnadirLineaCabeza("")

            'El metodo AddSubHeaderLine es lo mismo al de AddHeaderLine con la diferencia 
            'de que al final de cada linea agrega una linea punteada "==========" 

            '---------
            'Nro.Caja()
            '----------
            Objdt = ObjSis.Get_Value_Table("cSerie,cNombreImpresora,cCodAutSUNAT", "Medica.CtaCteDatosImpresora", "", 2, "cPerJurCodigo = '" & cPerJurCodigo & "' AND nCajCodigo = " & CInt(ObtenerParametroAppConfig("NroCaja")) & " ")
            If Objdt.Rows.Count > 0 Then
                a.AnadirLineaCabeza("Nro. Autoriza SUNAT: " & Objdt.Rows(0).Item("cCodAutSUNAT"))
                a.AnadirLineaCabeza("Nº de Serie: " & Objdt.Rows(0).Item("cSerie"))
                a.AnadirLineaCabeza("CAJA Nº. " & cHeader.Rows(0).Item("nCaja"))
                impresora = Objdt.Rows(0).Item("cNombreImpresora").ToString  ' "Star SP700 Cutter (SP742)" ' "\\192.168.1.65\EPSON L350 Series" '"PDF" 
            End If

            'Tipo Documento + Serie y Correlativo Example: BOLETA DE VENTA N. 0002-0000005
            a.AnadirLineaSubcabeza(cHeader.Rows(0).Item("TipoDocu") & cHeader.Rows(0).Item("SerieCorrelativo"))

            'Fecha y hora 08/09/2015 16:31:44
            a.AnadirLineaSubcabeza("FECHA Y HORA: " & cHeader.Rows(0).Item("dCtaCteEmiFecha"))

            'Datos Cliente quien Factura 
            If Len(Trim(cHeader.Rows(0).Item("cPerIdeNumero"))) = 11 Then 'T/Factura
                'If CInt(cHeader.Rows(0).Item("nCtaCteComCodigo")) = TipoDocuVta.Factura Then 'Factura
                a.AnadirLineaSubcabeza("R.U.C.: " & cHeader.Rows(0).Item("cPerIdeNumero"))
                a.AnadirLineaSubcabeza("RAZON SOCIAL: " & cHeader.Rows(0).Item("Cliente"))
                a.AnadirLineaSubcabeza("DOMICILIO FISCAL: " & cHeader.Rows(0).Item("DomicilioFiscal"))
            Else
                a.AnadirLineaSubcabeza("D.N.I: " & cHeader.Rows(0).Item("cPerIdeNumero"))
                a.AnadirLineaSubcabeza("CLIENTE: " & cHeader.Rows(0).Item("Cliente"))
            End If

            a.EncabezadoElementos = "Cant.   Descripción           Precio"
            '--------------
            'Carga detalle
            '--------------
            If cHeader.Rows(0).Item("nIntClase") = 1014 Then
                Dim Obj_DetAdmSol As New BL_FichaAtencion.BL_FichaAtencion
                Dim dtDetAdmSol As New DataTable

                dtDetAdmSol = Obj_DetAdmSol.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(cPerJurCodigo, cHeader.Rows(0).Item("nSolAdmNumero"))

                'Leyendo un DataTable
                If dtDetAdmSol.Rows.Count > 0 Then
                    Dim row As DataRow

                    For Each row In dtDetAdmSol.Rows
                        'commandList.AddRange(targetCodePage.GetBytes(cmd + CStr(row("cCtaCteSerJerarquia").ToString) + Chr(&H20) + Chr(&H20) + Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left(CStr(row("cCtaCteSerKeyWord").ToString), 20) + "                    ", 20) + Chr(&H20) + Microsoft.VisualBasic.Right("    " + CStr(row("nCtaCteCantidad").ToString), 4) + Chr(&H20) + Microsoft.VisualBasic.Right("          " + FormatNumber(row("nCtaCteSerImpDef"), True), 10) + vbCrLf))
                        a.AnadirElemento(CStr(row("nCtaCteCantidad").ToString), Microsoft.VisualBasic.Left(CStr(row("cCtaCteSerKeyWord").ToString), 20), FormatNumber(row("nCtaCteSerImpDef").ToString, True))
                    Next
                End If
            Else
                'Imprime cuando es por Anticipo ANT999
                a.AnadirElemento("1", Microsoft.VisualBasic.Left(CStr("PAGO POR ANTICIPO"), 20), FormatNumber(cHeader.Rows(0).Item("fCtaCteImporte"), True))
            End If

            'El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio 
            If CInt(cHeader.Rows(0).Item("nConValor")) <> 5 Then 'cuando sea diferente de Cortesia
                If Convert.ToDouble(cHeader.Rows(0).Item("nCtaCteSerImpDef")) > Convert.ToDouble(cHeader.Rows(0).Item("fCtaCteImporte")) Then
                    a.AnadirTotal("IMP. BRUTO S/.", FormatNumber(cHeader.Rows(0).Item("nCtaCteSerImpDef"), True))
                    a.AnadirTotal("DSCTO. S/.", Format(cHeader.Rows(0).Item("nCtaCteDscto"), "-#,###.#0"))
                End If
            End If

            If Len(Trim(cHeader.Rows(0).Item("cPerIdeNumero"))) = 11 Then 'T/Factura
                'If CInt(cHeader.Rows(0).Item("nCtaCteComCodigo")) = TipoDocuVta.TFactura Then 'Factura (se bloqueo 01-10-2015)
                'commandList.AddRange(Encoding.GetBytes("---------------------------------------------" + vbCrLf))
                a.AnadirTotal("NETO S/. ", FormatNumber(cHeader.Rows(0).Item("fCtaCteImporte"), True))
                If cHeader.Rows(0).Item("nIntClase") = 1014 And Convert.ToDouble(cHeader.Rows(0).Item("fCtaCteImporteA")) > 0 Then
                    'commandList.AddRange(Encoding.GetBytes("---------------------------------------------" + vbCrLf))
                    a.AnadirTotal("ANTICIPO. S/. ", Format(cHeader.Rows(0).Item("fCtaCteImporteA"), "-#,###.#0"))
                    'commandList.AddRange(Encoding.GetBytes("---------------------------------------------" + vbCrLf))
                    a.AnadirTotal("IMPORTE. S/. ", FormatNumber(cHeader.Rows(0).Item("fnRestante"), True))
                End If
                a.AnadirTotal("SUBTOTAL ", FormatNumber(cHeader.Rows(0).Item("nGravada"), True))
                'commandList.AddRange(encoding.GetBytes("IGV 18% " + Chr(&H9) + Chr(&H9) + Microsoft.VisualBasic.Right("          " + FormatNumber(cHeader.Rows(0).Item("nIgv"), True), 10) + vbCrLf))
                a.AnadirTotal("IGV 18p ", FormatNumber(cHeader.Rows(0).Item("nIgv"), True))
                'commandList.AddRange(Encoding.GetBytes("---------------------------------------------" + vbCrLf))
                a.AnadirTotal("IMPORTE. S/. ", FormatNumber(cHeader.Rows(0).Item("fnRestante"), True))
                'commandList.AddRange(Encoding.GetBytes("---------------------------------------------" + vbCrLf + vbCrLf))

            Else
                'commandList.AddRange(Encoding.GetBytes("---------------------------------------------" + vbCrLf))
                a.AnadirTotal("IMP. TOTAL S/. ", FormatNumber(cHeader.Rows(0).Item("fCtaCteImporte"), True))
                'commandList.AddRange(Encoding.GetBytes("---------------------------------------------" + vbCrLf))
                If cHeader.Rows(0).Item("nIntClase") = 1014 And Convert.ToDouble(cHeader.Rows(0).Item("fCtaCteImporteA")) > 0 Then
                    'commandList.AddRange(encoding.GetBytes("---------------------------------------------" + vbCrLf))
                    a.AnadirTotal("ANTICIPO. S/. ", Format(cHeader.Rows(0).Item("fCtaCteImporteA"), "-#,###.#0"))
                    'commandList.AddRange(Encoding.GetBytes("---------------------------------------------" + vbCrLf))
                    a.AnadirTotal("IMPORTE. S/. ", FormatNumber(cHeader.Rows(0).Item("fnRestante"), True))
                    'commandList.AddRange(Encoding.GetBytes("---------------------------------------------" + vbCrLf + vbCrLf))
                End If
            End If

            a.AnadirTotal("", "") ' //Ponemos un total en blanco que sirve de espacio 

            'Datos Paciente
            a.AnadeLineaAlPie("PACIENTE: " & cHeader.Rows(0).Item("Paciente"))
            a.AnadeLineaAlPie("NRO. FICHA: " & cHeader.Rows(0).Item("nSolAdmNumero"))

            'recorrer el datatable
            Dim fila As DataRow
            a.AnadeLineaAlPie("")
            a.AnadeLineaAlPie("F. PAGO:")
            For Each fila In cHeader.Rows
                a.AnadeLineaAlPie(fila("cConDescripcion") & " " & FormatNumber(fila("fCtaCtePagImporte"), True))
            Next
            a.AnadeLineaAlPie("")

            If cHeader.Rows(0).Item("nIntClase") = 1014 Then
                DetDocuRef = ServicioDocRef.Get_Detalle_DocuRef_Anticipo(cHeader.Rows(0).Item("nSolAdmNumero"))
                If DetDocuRef.Rows.Count > 0 Then
                    a.AnadeLineaAlPie("DOCU. REF. ANTICIPO:")
                    Dim row As DataRow

                    For Each row In DetDocuRef.Rows
                        a.AnadeLineaAlPie(CStr(row("DocRef").ToString))
                    Next
                    a.AnadeLineaAlPie("")
                End If
            End If

            '---------------------------------------
            'Usuario Cajero (quien hace la atencion)
            a.AnadeLineaAlPie("ATENDIDO POR: " & cHeader.Rows(0).Item("cPerUsuCodigo"))
            '---------------------------------------
            a.AnadeLineaAlPie("")

            '//El metodo AddFooterLine funciona igual que la cabecera 
            'commandList.AddRange(New Byte() {&H1B, &H1D, &H61, &H1}) 'Center Alignment
            a.AnadeLineaAlPie(cHeader.Rows(0).Item("Mensaje1"))
            a.AnadeLineaAlPie("")

            a.AnadeLineaAlPie("Toda devolución se efectuará con cheque o transferencia bancaria, en un plazo no mayor a 7 días. Escríbenos a: consultas@medica.com.pe")

            'a.AnadeLineaAlPie(cHeader.Rows(0).Item("Mensaje2"))
            'a.AnadeLineaAlPie(cHeader.Rows(0).Item("Mensaje3"))
            'a.AnadeLineaAlPie(cHeader.Rows(0).Item("Mensaje4") & "consultas@medica.com.pe")

            '//Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un 
            '//parametro de tipo string que debe de ser el nombre de la impresora. 
            a.ImprimeTicket(impresora)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Impresion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Sub Actualizar_Fecha_Servidor()
        REM Obteniendo fecha del servidor
        Dim Request As New BE.Sistema.BE_ReqFechaServidor
        Dim ObjBL As New BL_Sistema

        Request.dFechaServer = ""

        dFechaSistema = ObjBL.Get_FechaServidor(Request)
    End Sub

    Public Sub Actualizar_FechaHora_Servidor(Optional nSegundos As Long = 0)
        REM Obteniendo fecha y hora del servidor
        Dim Request As New BE.Sistema.BE_ReqFechaServidor
        Dim ObjBL As New BL_Sistema

        Request.dFechaServer = ""

        dFechaHoraSistema = ObjBL.Get_FechaHoraServidor(Request, nSegundos)
    End Sub

    ''    Paso 1:
    ''******
    ''Configuramos el nuevo tamaño de las columna al momento de cargar el formulario.
    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    ' Habilitar el cambio de tamaño en los encabezados de columna
    '    DataGridView1.ColumnHeadersHeightSizeMode = _
    '        DataGridViewColumnHeadersHeightSizeMode.EnableResizing
    '    'Ajustamos el alto para la columna cabecera 
    '    DataGridView1.ColumnHeadersHeight = _
    '        DataGridView1.ColumnHeadersHeight * 2
    '    ' Ajuste la alineación del texto en los encabezados de las  
    '    ' columnas para que la visualización de texto en el centro de la parte inferior
    '    DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = _
    '        DataGridViewContentAlignment.BottomCenter
    'End Sub


    ''    Paso 2:
    ''******
    ''Dibujamos las columnas
    'Private Sub DataGridView1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView1.Paint
    '    ' Datos para las celdas de cabezera 
    '    Dim Grupos As String() = {"GRUPO 1", "GRUPO 2"}
    '    For j As Integer = 0 To DataGridView1.ColumnCount - 1 Step 2
    '        ' Obtener los límites de encabezado de columna 
    '        Dim r1 As Rectangle = DataGridView1.GetCellDisplayRectangle(j, -1, True)
    '        r1.X += 1
    '        r1.Y += 1
    '        r1.Width = r1.Width * 2 - 2
    '        r1.Height = r1.Height / 2 - 2

    '        Using br As SolidBrush = _
    '          New SolidBrush(DataGridView1.ColumnHeadersDefaultCellStyle.BackColor)
    '            e.Graphics.FillRectangle(br, r1)
    '        End Using
    '        Using p As Pen = New Pen(SystemColors.InactiveBorder)
    '            e.Graphics.DrawLine(p, r1.X, r1.Bottom, r1.Right, r1.Bottom)
    '        End Using
    '        Using format As StringFormat = New StringFormat()
    '            Using br As SolidBrush = New SolidBrush(DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor)
    '                format.Alignment = StringAlignment.Center
    '                format.LineAlignment = StringAlignment.Center

    '                e.Graphics.DrawString(Grupos(j / 2), DataGridView1.ColumnHeadersDefaultCellStyle.Font, _
    '                            br, r1, format)
    '            End Using
    '        End Using
    '    Next
    'End Sub

    ''Paso 3:
    ''******
    ''Dibujamos las celdas
    'Private Sub DataGridView1_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
    '    If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
    '        e.PaintBackground(e.CellBounds, False)
    '        Dim r2 As Rectangle = e.CellBounds
    '        r2.Y += e.CellBounds.Height / 2
    '        r2.Height = e.CellBounds.Height / 2
    '        e.PaintContent(r2)
    '        e.Handled = True
    '    End If
    'End Sub


End Module
