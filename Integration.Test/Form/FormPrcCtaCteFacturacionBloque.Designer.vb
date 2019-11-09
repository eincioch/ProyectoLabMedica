<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcCtaCteFacturacionBloque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcCtaCteFacturacionBloque))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdoBtnMuestra = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RdoBtnPerfilMuestra = New System.Windows.Forms.RadioButton()
        Me.CboLabEmpresa = New System.Windows.Forms.ComboBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboTipoCta = New System.Windows.Forms.ComboBox()
        Me.DtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmndHldrFactGrp = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdFacturar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CmdProgramar = New C1.Win.C1Command.C1Command()
        Me.C1CmdExport = New C1.Win.C1Command.C1Command()
        Me.C1CmdExportExcelFichas = New C1.Win.C1Command.C1Command()
        Me.C1CmdDetalle = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.LblMsjError = New System.Windows.Forms.Label()
        Me.Table2 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblAmountMuestra = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblTotalPago = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CmndHldrFactGrp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(927, 37)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "҉    Facturación en Bloque -  Laboratorio Externo / Empresas (Convenio)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdoBtnMuestra)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.RdoBtnPerfilMuestra)
        Me.GroupBox1.Controls.Add(Me.CboLabEmpresa)
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CboTipoCta)
        Me.GroupBox1.Controls.Add(Me.DtpFecFin)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(907, 103)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'RdoBtnMuestra
        '
        Me.RdoBtnMuestra.AutoSize = True
        Me.RdoBtnMuestra.Location = New System.Drawing.Point(684, 67)
        Me.RdoBtnMuestra.Name = "RdoBtnMuestra"
        Me.RdoBtnMuestra.Size = New System.Drawing.Size(76, 19)
        Me.RdoBtnMuestra.TabIndex = 26
        Me.RdoBtnMuestra.Text = "&Muestras"
        Me.RdoBtnMuestra.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(476, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Agrupado por"
        '
        'RdoBtnPerfilMuestra
        '
        Me.RdoBtnPerfilMuestra.AutoSize = True
        Me.RdoBtnPerfilMuestra.Checked = True
        Me.RdoBtnPerfilMuestra.Location = New System.Drawing.Point(563, 67)
        Me.RdoBtnPerfilMuestra.Name = "RdoBtnPerfilMuestra"
        Me.RdoBtnPerfilMuestra.Size = New System.Drawing.Size(115, 19)
        Me.RdoBtnPerfilMuestra.TabIndex = 24
        Me.RdoBtnPerfilMuestra.TabStop = True
        Me.RdoBtnPerfilMuestra.Text = "&Perfil y Muestras"
        Me.RdoBtnPerfilMuestra.UseVisualStyleBackColor = True
        '
        'CboLabEmpresa
        '
        Me.CboLabEmpresa.FormattingEnabled = True
        Me.CboLabEmpresa.Location = New System.Drawing.Point(470, 27)
        Me.CboLabEmpresa.Name = "CboLabEmpresa"
        Me.CboLabEmpresa.Size = New System.Drawing.Size(406, 23)
        Me.CboLabEmpresa.TabIndex = 23
        Me.CboLabEmpresa.Tag = "nIntClase=1133;nIntTipo=0"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Image = Global.Integration.Test.My.Resources.Resources.Find_16x16
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(768, 56)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(128, 37)
        Me.BtnMostrar.TabIndex = 21
        Me.BtnMostrar.Text = "    Mostrar Datos"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Lab. Externo / Empresa"
        '
        'CboTipoCta
        '
        Me.CboTipoCta.FormattingEnabled = True
        Me.CboTipoCta.Location = New System.Drawing.Point(126, 27)
        Me.CboTipoCta.Name = "CboTipoCta"
        Me.CboTipoCta.Size = New System.Drawing.Size(156, 23)
        Me.CboTipoCta.TabIndex = 6
        Me.CboTipoCta.Tag = "nIntClase=1133;nIntTipo=0"
        '
        'DtpFecFin
        '
        Me.DtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFin.Location = New System.Drawing.Point(344, 67)
        Me.DtpFecFin.Name = "DtpFecFin"
        Me.DtpFecFin.Size = New System.Drawing.Size(110, 21)
        Me.DtpFecFin.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Desde"
        '
        'DtpFecIni
        '
        Me.DtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecIni.Location = New System.Drawing.Point(172, 67)
        Me.DtpFecIni.Name = "DtpFecIni"
        Me.DtpFecIni.Size = New System.Drawing.Size(110, 21)
        Me.DtpFecIni.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rango de Fechas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Atención"
        '
        'Table1
        '
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Location = New System.Drawing.Point(11, 206)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(753, 208)
        Me.Table1.TabIndex = 21
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CmndHldrFactGrp
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink6, Me.C1CommandLink3, Me.C1CommandLink1, Me.C1CommandLink4, Me.C1CommandLink5, Me.C1CommandLink2})
        Me.C1ToolBar1.Location = New System.Drawing.Point(58, 40)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(807, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmndHldrFactGrp
        '
        Me.C1CmndHldrFactGrp.Commands.Add(Me.C1CmdFacturar)
        Me.C1CmndHldrFactGrp.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmndHldrFactGrp.Commands.Add(Me.C1CmdProgramar)
        Me.C1CmndHldrFactGrp.Commands.Add(Me.C1CmdExport)
        Me.C1CmndHldrFactGrp.Commands.Add(Me.C1CmdExportExcelFichas)
        Me.C1CmndHldrFactGrp.Commands.Add(Me.C1CmdDetalle)
        Me.C1CmndHldrFactGrp.Owner = Me
        '
        'C1CmdFacturar
        '
        Me.C1CmdFacturar.Name = "C1CmdFacturar"
        Me.C1CmdFacturar.Text = "Facturar"
        Me.C1CmdFacturar.Visible = False
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "&Cerrar"
        '
        'C1CmdProgramar
        '
        Me.C1CmdProgramar.Image = Global.Integration.Test.My.Resources.Resources.money_add
        Me.C1CmdProgramar.Name = "C1CmdProgramar"
        Me.C1CmdProgramar.Text = "Programar Pago"
        '
        'C1CmdExport
        '
        Me.C1CmdExport.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExport.Name = "C1CmdExport"
        Me.C1CmdExport.Text = "Exportar Excel"
        '
        'C1CmdExportExcelFichas
        '
        Me.C1CmdExportExcelFichas.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExportExcelFichas.Name = "C1CmdExportExcelFichas"
        Me.C1CmdExportExcelFichas.Text = "Exportar Excel (Fichas)"
        '
        'C1CmdDetalle
        '
        Me.C1CmdDetalle.Name = "C1CmdDetalle"
        Me.C1CmdDetalle.Text = "Pendientes de Facturar"
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink6.Command = Me.C1CmdDetalle
        Me.C1CommandLink6.Text = "Pendientes de Facturar"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdProgramar
        Me.C1CommandLink3.SortOrder = 1
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdFacturar
        Me.C1CommandLink1.SortOrder = 2
        Me.C1CommandLink1.Text = "Realizar Pago"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdExport
        Me.C1CommandLink4.SortOrder = 3
        Me.C1CommandLink4.Text = "Exportar Excel (Muestras)"
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.C1CmdExportExcelFichas
        Me.C1CommandLink5.SortOrder = 4
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdCerrar
        Me.C1CommandLink2.SortOrder = 5
        '
        'LblMsjError
        '
        Me.LblMsjError.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.LblMsjError.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblMsjError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMsjError.ForeColor = System.Drawing.Color.White
        Me.LblMsjError.Location = New System.Drawing.Point(0, 680)
        Me.LblMsjError.Name = "LblMsjError"
        Me.LblMsjError.Size = New System.Drawing.Size(927, 19)
        Me.LblMsjError.TabIndex = 22
        Me.LblMsjError.Text = "Mensaje: "
        Me.LblMsjError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Table2
        '
        Me.Table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table2.Location = New System.Drawing.Point(12, 450)
        Me.Table2.Name = "Table2"
        Me.Table2.Size = New System.Drawing.Size(907, 227)
        Me.Table2.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gray
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(908, 19)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Muestra Atendidas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 428)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(907, 19)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Detalle de Fichas de Atención"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.LblQty)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.LblAmountMuestra)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.LblTotalPago)
        Me.Panel1.Location = New System.Drawing.Point(770, 206)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 208)
        Me.Panel1.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(6, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 13)
        Me.Label16.TabIndex = 127
        Me.Label16.Text = "CANTIDAD MUESTRA"
        '
        'LblQty
        '
        Me.LblQty.BackColor = System.Drawing.Color.Teal
        Me.LblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQty.ForeColor = System.Drawing.Color.White
        Me.LblQty.Location = New System.Drawing.Point(9, 40)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Size = New System.Drawing.Size(129, 27)
        Me.LblQty.TabIndex = 128
        Me.LblQty.Text = "0"
        Me.LblQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 27)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "S/."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(17, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 124
        Me.Label12.Text = "TOTAL MUESTRA"
        '
        'LblAmountMuestra
        '
        Me.LblAmountMuestra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblAmountMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountMuestra.ForeColor = System.Drawing.Color.White
        Me.LblAmountMuestra.Location = New System.Drawing.Point(25, 103)
        Me.LblAmountMuestra.Name = "LblAmountMuestra"
        Me.LblAmountMuestra.Size = New System.Drawing.Size(113, 27)
        Me.LblAmountMuestra.TabIndex = 125
        Me.LblAmountMuestra.Text = "0.00"
        Me.LblAmountMuestra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(13, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 27)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "S/."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(27, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "TOTAL FICHAS"
        '
        'LblTotalPago
        '
        Me.LblTotalPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPago.ForeColor = System.Drawing.Color.White
        Me.LblTotalPago.Location = New System.Drawing.Point(27, 169)
        Me.LblTotalPago.Name = "LblTotalPago"
        Me.LblTotalPago.Size = New System.Drawing.Size(113, 27)
        Me.LblTotalPago.TabIndex = 122
        Me.LblTotalPago.Text = "0.00"
        Me.LblTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources._327_Options_48x48_72
        Me.PictureBox1.Location = New System.Drawing.Point(4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'FormPrcCtaCteFacturacionBloque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 699)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Table2)
        Me.Controls.Add(Me.LblMsjError)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrcCtaCteFacturacionBloque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación en Bloque -  Laboratorio Externo / Empresas (Convenio)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CmndHldrFactGrp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboTipoCta As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmndHldrFactGrp As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CmdFacturar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents RdoBtnMuestra As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RdoBtnPerfilMuestra As System.Windows.Forms.RadioButton
    Friend WithEvents CboLabEmpresa As System.Windows.Forms.ComboBox
    Private WithEvents LblMsjError As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Table2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblTotalPago As System.Windows.Forms.Label
    Friend WithEvents C1CmdProgramar As C1.Win.C1Command.C1Command
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LblQty As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblAmountMuestra As System.Windows.Forms.Label
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdExport As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdExportExcelFichas As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents C1CmdDetalle As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
End Class
