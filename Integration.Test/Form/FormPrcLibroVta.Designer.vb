<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcLibroVta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcLibroVta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnExportTxt = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.CboMes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboAnno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.fCtaCtePagImporte1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGV1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGrabado1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table2 = New System.Windows.Forms.DataGridView()
        Me.tipoOpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorFOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroCModi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipodocMod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECoriginal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fCtaCtePagImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.otroImp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IArroz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIArroz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoSC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inafectas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotExonerado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGrabado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacExportado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nroDocumentoIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipDocumentoIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecVence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecEmision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumAsiContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnExportTxt)
        Me.GroupBox1.Controls.Add(Me.BtnCerrar)
        Me.GroupBox1.Controls.Add(Me.BtnExport)
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.CboMes)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CboAnno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(817, 44)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnExportTxt
        '
        Me.BtnExportTxt.BackColor = System.Drawing.SystemColors.Control
        Me.BtnExportTxt.Image = Global.Integration.Test.My.Resources.Resources.file_extension_txt
        Me.BtnExportTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExportTxt.Location = New System.Drawing.Point(629, 11)
        Me.BtnExportTxt.Name = "BtnExportTxt"
        Me.BtnExportTxt.Size = New System.Drawing.Size(105, 28)
        Me.BtnExportTxt.TabIndex = 21
        Me.BtnExportTxt.Text = "   Exportar a &TXT"
        Me.BtnExportTxt.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(740, 11)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(72, 28)
        Me.BtnCerrar.TabIndex = 2
        Me.BtnCerrar.Text = "   &Cerrar "
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnExport
        '
        Me.BtnExport.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.BtnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExport.Location = New System.Drawing.Point(507, 11)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(116, 28)
        Me.BtnExport.TabIndex = 2
        Me.BtnExport.Text = "     &Exportar a XLS"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Image = Global.Integration.Test.My.Resources.Resources.zoom_refresh
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(380, 11)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(121, 28)
        Me.BtnMostrar.TabIndex = 2
        Me.BtnMostrar.Text = "     &Mostrar resultado"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'CboMes
        '
        Me.CboMes.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMes.FormattingEnabled = True
        Me.CboMes.Location = New System.Drawing.Point(212, 16)
        Me.CboMes.Name = "CboMes"
        Me.CboMes.Size = New System.Drawing.Size(162, 21)
        Me.CboMes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Periodo:"
        '
        'CboAnno
        '
        Me.CboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnno.FormattingEnabled = True
        Me.CboAnno.Location = New System.Drawing.Point(56, 16)
        Me.CboAnno.Name = "CboAnno"
        Me.CboAnno.Size = New System.Drawing.Size(98, 21)
        Me.CboAnno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(823, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "҉     Libro Ventas Electronico"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Table2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Table1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(829, 397)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'fCtaCtePagImporte1
        '
        Me.fCtaCtePagImporte1.DataPropertyName = "fCtaCtePagImporte"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Format = "N2"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.fCtaCtePagImporte1.DefaultCellStyle = DataGridViewCellStyle25
        Me.fCtaCtePagImporte1.HeaderText = "Importe"
        Me.fCtaCtePagImporte1.Name = "fCtaCtePagImporte1"
        Me.fCtaCtePagImporte1.ReadOnly = True
        '
        'IGV1
        '
        Me.IGV1.DataPropertyName = "IGV"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle26.Format = "N2"
        Me.IGV1.DefaultCellStyle = DataGridViewCellStyle26
        Me.IGV1.HeaderText = "IGV"
        Me.IGV1.Name = "IGV1"
        Me.IGV1.ReadOnly = True
        '
        'IGrabado1
        '
        Me.IGrabado1.DataPropertyName = "IGrabado"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "N2"
        Me.IGrabado1.DefaultCellStyle = DataGridViewCellStyle27
        Me.IGrabado1.HeaderText = "Operacion Grabada"
        Me.IGrabado1.Name = "IGrabado1"
        Me.IGrabado1.ReadOnly = True
        '
        'cDesc
        '
        Me.cDesc.DataPropertyName = "cDesc"
        Me.cDesc.HeaderText = "Descripción"
        Me.cDesc.Name = "cDesc"
        Me.cDesc.ReadOnly = True
        Me.cDesc.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Periodo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Periodo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Table2
        '
        Me.Table2.AllowUserToAddRows = False
        Me.Table2.AllowUserToDeleteRows = False
        Me.Table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.cDesc, Me.IGrabado1, Me.IGV1, Me.fCtaCtePagImporte1})
        Me.Table2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Table2.Location = New System.Drawing.Point(3, 260)
        Me.Table2.Name = "Table2"
        Me.Table2.ReadOnly = True
        Me.Table2.Size = New System.Drawing.Size(823, 134)
        Me.Table2.TabIndex = 20
        '
        'tipoOpe
        '
        Me.tipoOpe.DataPropertyName = "tipoOpe"
        Me.tipoOpe.HeaderText = "Estado que identifica oportunidad anotación"
        Me.tipoOpe.Name = "tipoOpe"
        Me.tipoOpe.ReadOnly = True
        Me.tipoOpe.ToolTipText = resources.GetString("tipoOpe.ToolTipText")
        '
        'valorFOB
        '
        Me.valorFOB.DataPropertyName = "valorFOB"
        Me.valorFOB.HeaderText = "Valor FOB embarcado exportación"
        Me.valorFOB.Name = "valorFOB"
        Me.valorFOB.ReadOnly = True
        Me.valorFOB.ToolTipText = "Valor FOB embarcado de la exportación"
        '
        'NumeroCModi
        '
        Me.NumeroCModi.DataPropertyName = "NumeroCModi"
        Me.NumeroCModi.HeaderText = "NumeroCModi"
        Me.NumeroCModi.Name = "NumeroCModi"
        Me.NumeroCModi.ReadOnly = True
        Me.NumeroCModi.ToolTipText = "Número del comprobante de pago que se modifica (6) o Número de la DUA, de corresp" & _
    "onder"
        '
        'Serie
        '
        Me.Serie.DataPropertyName = "Serie"
        Me.Serie.HeaderText = "Serie comprobante que se modifica"
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
        Me.Serie.ToolTipText = "Número de serie del comprobante de pago que se modifica (6) o Código de la Depend" & _
    "encia Aduanera"
        '
        'tipodocMod
        '
        Me.tipodocMod.DataPropertyName = "tipodocMod"
        Me.tipodocMod.HeaderText = "Tipo comprobante que se modifica"
        Me.tipodocMod.Name = "tipodocMod"
        Me.tipodocMod.ReadOnly = True
        Me.tipodocMod.ToolTipText = "Tipo del comprobante de pago que se modifica"
        '
        'FECoriginal
        '
        Me.FECoriginal.DataPropertyName = "FECoriginal"
        Me.FECoriginal.HeaderText = "Fecha documento sustenta crédito fiscal"
        Me.FECoriginal.Name = "FECoriginal"
        Me.FECoriginal.ReadOnly = True
        Me.FECoriginal.ToolTipText = "Fecha de emisión del comprobante de pago o documento original que se modifica (6)" & _
    " o documento referencial al documento que sustenta el crédito fiscal"
        '
        'TC
        '
        Me.TC.DataPropertyName = "TC"
        Me.TC.HeaderText = "Tipo de cambio "
        Me.TC.Name = "TC"
        Me.TC.ReadOnly = True
        Me.TC.ToolTipText = "Tipo de cambio "
        '
        'fCtaCtePagImporte
        '
        Me.fCtaCtePagImporte.DataPropertyName = "fCtaCtePagImporte"
        DataGridViewCellStyle28.Format = "N2"
        Me.fCtaCtePagImporte.DefaultCellStyle = DataGridViewCellStyle28
        Me.fCtaCtePagImporte.HeaderText = "Importe total comprobante pago"
        Me.fCtaCtePagImporte.Name = "fCtaCtePagImporte"
        Me.fCtaCtePagImporte.ReadOnly = True
        Me.fCtaCtePagImporte.ToolTipText = "Importe total del comprobante de pago"
        '
        'otroImp
        '
        Me.otroImp.DataPropertyName = "otroImp"
        Me.otroImp.HeaderText = "Otros conceptos, tributos y cargos"
        Me.otroImp.Name = "otroImp"
        Me.otroImp.ReadOnly = True
        Me.otroImp.ToolTipText = "Otros conceptos, tributos y cargos que no forman parte de la base imponible"
        '
        'IArroz
        '
        Me.IArroz.DataPropertyName = "IArroz"
        Me.IArroz.HeaderText = "Impuesto Ventas Arroz Pilado "
        Me.IArroz.Name = "IArroz"
        Me.IArroz.ReadOnly = True
        Me.IArroz.ToolTipText = "Impuesto a las Ventas del Arroz Pilado "
        '
        'BIArroz
        '
        Me.BIArroz.DataPropertyName = "BIArroz"
        Me.BIArroz.HeaderText = "Base imponible Ventas Arroz Pilado"
        Me.BIArroz.Name = "BIArroz"
        Me.BIArroz.ReadOnly = True
        Me.BIArroz.ToolTipText = "Base imponible de la operación gravada con el Impuesto a las Ventas del Arroz Pil" & _
    "ado"
        '
        'IGV
        '
        Me.IGV.DataPropertyName = "IGV"
        DataGridViewCellStyle29.Format = "N2"
        Me.IGV.DefaultCellStyle = DataGridViewCellStyle29
        Me.IGV.HeaderText = "Impuesto General Ventas"
        Me.IGV.Name = "IGV"
        Me.IGV.ReadOnly = True
        Me.IGV.ToolTipText = "Impuesto General a las Ventas y/o Impuesto de Promoción Municipal"
        '
        'ImpuestoSC
        '
        Me.ImpuestoSC.DataPropertyName = "ImpuestoSC"
        Me.ImpuestoSC.HeaderText = "Impuesto Selectivo al Consumo"
        Me.ImpuestoSC.Name = "ImpuestoSC"
        Me.ImpuestoSC.ReadOnly = True
        Me.ImpuestoSC.ToolTipText = "Impuesto Selectivo al Consumo, de ser el caso."
        '
        'inafectas
        '
        Me.inafectas.DataPropertyName = "inafectas"
        Me.inafectas.HeaderText = "Importe total operación inafecta "
        Me.inafectas.Name = "inafectas"
        Me.inafectas.ReadOnly = True
        Me.inafectas.ToolTipText = "Importe total de la operación inafecta "
        '
        'TotExonerado
        '
        Me.TotExonerado.DataPropertyName = "TotExonerado"
        Me.TotExonerado.HeaderText = "Importe total operación exonerada"
        Me.TotExonerado.Name = "TotExonerado"
        Me.TotExonerado.ReadOnly = True
        Me.TotExonerado.ToolTipText = "Importe total de la operación exonerada"
        '
        'IGrabado
        '
        Me.IGrabado.DataPropertyName = "IGrabado"
        DataGridViewCellStyle30.Format = "N2"
        Me.IGrabado.DefaultCellStyle = DataGridViewCellStyle30
        Me.IGrabado.HeaderText = "Base imponible operación gravada"
        Me.IGrabado.Name = "IGrabado"
        Me.IGrabado.ReadOnly = True
        Me.IGrabado.ToolTipText = "Base imponible de la operación gravada"
        '
        'FacExportado
        '
        Me.FacExportado.DataPropertyName = "FacExportado"
        Me.FacExportado.HeaderText = "Valor facturado exportación"
        Me.FacExportado.Name = "FacExportado"
        Me.FacExportado.ReadOnly = True
        Me.FacExportado.ToolTipText = "Valor facturado de la exportación"
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Apellidos y nombres, denominación o razón social"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.ToolTipText = "Apellidos y nombres, denominación o razón social  del cliente. En caso de persona" & _
    "s naturales se debe consignar los datos en el siguiente orden: Apellido paterno," & _
    " apellido materno y nombre completo."
        Me.Cliente.Width = 280
        '
        'nroDocumentoIdentidad
        '
        Me.nroDocumentoIdentidad.DataPropertyName = "nroDocumentoIdentidad"
        Me.nroDocumentoIdentidad.HeaderText = "Número Documento Identidad"
        Me.nroDocumentoIdentidad.Name = "nroDocumentoIdentidad"
        Me.nroDocumentoIdentidad.ReadOnly = True
        Me.nroDocumentoIdentidad.ToolTipText = "Número de Documento de Identidad del cliente"
        '
        'TipDocumentoIdentidad
        '
        Me.TipDocumentoIdentidad.DataPropertyName = "TipDocumentoIdentidad"
        Me.TipDocumentoIdentidad.HeaderText = "Tipo Documento Identidad"
        Me.TipDocumentoIdentidad.Name = "TipDocumentoIdentidad"
        Me.TipDocumentoIdentidad.ReadOnly = True
        Me.TipDocumentoIdentidad.ToolTipText = "Tipo de Documento de Identidad del cliente"
        '
        'Col8
        '
        Me.Col8.DataPropertyName = "Col8"
        Me.Col8.HeaderText = "Col8"
        Me.Col8.Name = "Col8"
        Me.Col8.ReadOnly = True
        '
        'NumeroComprobante
        '
        Me.NumeroComprobante.DataPropertyName = "NumeroComprobante"
        Me.NumeroComprobante.HeaderText = "Numero Comprobante"
        Me.NumeroComprobante.Name = "NumeroComprobante"
        Me.NumeroComprobante.ReadOnly = True
        Me.NumeroComprobante.ToolTipText = "Número del comprobante de pago o documento. "
        Me.NumeroComprobante.Width = 110
        '
        'SerieComprobante
        '
        Me.SerieComprobante.DataPropertyName = "SerieComprobante"
        Me.SerieComprobante.HeaderText = "Serie Comprobante"
        Me.SerieComprobante.Name = "SerieComprobante"
        Me.SerieComprobante.ReadOnly = True
        Me.SerieComprobante.ToolTipText = "Número serie del comprobante de pago o documento o número de serie de la maquina " & _
    "registradora."
        Me.SerieComprobante.Width = 90
        '
        'TipoDocComp
        '
        Me.TipoDocComp.DataPropertyName = "TipoDocComp"
        Me.TipoDocComp.HeaderText = "Tipo de Comprobante"
        Me.TipoDocComp.Name = "TipoDocComp"
        Me.TipoDocComp.ReadOnly = True
        Me.TipoDocComp.ToolTipText = "Tipo de Comprobante de Pago o Documento"
        '
        'FecVence
        '
        Me.FecVence.DataPropertyName = "FecVence"
        Me.FecVence.HeaderText = "Fecha de Pago"
        Me.FecVence.Name = "FecVence"
        Me.FecVence.ReadOnly = True
        Me.FecVence.ToolTipText = "Fecha de Vencimiento o Fecha de Pago"
        '
        'FecEmision
        '
        Me.FecEmision.DataPropertyName = "FecEmision"
        Me.FecEmision.HeaderText = "Fecha de emisión del Comprobante"
        Me.FecEmision.Name = "FecEmision"
        Me.FecEmision.ReadOnly = True
        Me.FecEmision.ToolTipText = "Fecha de emisión del Comprobante de Pago"
        '
        'cNumAsiContable
        '
        Me.cNumAsiContable.DataPropertyName = "cNumAsiContable"
        Me.cNumAsiContable.HeaderText = "Número correlativo asiento contable"
        Me.cNumAsiContable.Name = "cNumAsiContable"
        Me.cNumAsiContable.ReadOnly = True
        Me.cNumAsiContable.ToolTipText = resources.GetString("cNumAsiContable.ToolTipText")
        '
        'Correlativo
        '
        Me.Correlativo.DataPropertyName = "Correlativo"
        Me.Correlativo.HeaderText = "Código Único de la Operación (CUO)"
        Me.Correlativo.Name = "Correlativo"
        Me.Correlativo.ReadOnly = True
        Me.Correlativo.ToolTipText = resources.GetString("Correlativo.ToolTipText")
        Me.Correlativo.Width = 110
        '
        'Periodo
        '
        Me.Periodo.DataPropertyName = "Periodo"
        Me.Periodo.HeaderText = "Periodo"
        Me.Periodo.Name = "Periodo"
        Me.Periodo.ReadOnly = True
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Periodo, Me.Correlativo, Me.cNumAsiContable, Me.FecEmision, Me.FecVence, Me.TipoDocComp, Me.SerieComprobante, Me.NumeroComprobante, Me.Col8, Me.TipDocumentoIdentidad, Me.nroDocumentoIdentidad, Me.Cliente, Me.FacExportado, Me.IGrabado, Me.TotExonerado, Me.inafectas, Me.ImpuestoSC, Me.IGV, Me.BIArroz, Me.IArroz, Me.otroImp, Me.fCtaCtePagImporte, Me.TC, Me.FECoriginal, Me.tipodocMod, Me.Serie, Me.NumeroCModi, Me.valorFOB, Me.tipoOpe})
        Me.Table1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table1.Location = New System.Drawing.Point(3, 73)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(823, 181)
        Me.Table1.TabIndex = 19
        '
        'FormPrcLibroVta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 397)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrcLibroVta"
        Me.Text = "Libro Ventas Electronico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents CboMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnExportTxt As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Table2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGrabado1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGV1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fCtaCtePagImporte1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents Periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correlativo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumAsiContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecEmision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecVence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocComp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipDocumentoIdentidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nroDocumentoIdentidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacExportado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGrabado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotExonerado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inafectas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoSC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BIArroz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IArroz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents otroImp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fCtaCtePagImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECoriginal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipodocMod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroCModi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valorFOB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoOpe As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
