<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProformaAndroid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProformaAndroid))
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdBuscar = New C1.Win.C1Command.C1Command()
        Me.c1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.c1CmdGenerarFicha = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CmdImprimir = New C1.Win.C1Command.C1Command()
        Me.C1CmdAnularFicha = New C1.Win.C1Command.C1Command()
        Me.C1CmdEnvio = New C1.Win.C1Command.C1Command()
        Me.C1CmdExport = New C1.Win.C1Command.C1Command()
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdLinkBuscar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkPago = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.ChkBoxFiltraFecha = New System.Windows.Forms.CheckBox()
        Me.GrpBoxPersona = New System.Windows.Forms.GroupBox()
        Me.BtnValidar = New System.Windows.Forms.Button()
        Me.LblcNombre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.LblcPerCodigo = New System.Windows.Forms.Label()
        Me.CboTipoDocu = New System.Windows.Forms.ComboBox()
        Me.CboTipoPer = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtNroFind = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtAppNombre2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtAppApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CboSexoTEmp = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnGuardarValidacion = New System.Windows.Forms.Button()
        Me.DtpAppFecNaci = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtAppNombre1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtAppApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAppNumDocu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboAppTipoDocu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Table2 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.GrpBoxPersona.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdBuscar)
        Me.C1CommandHolder1.Commands.Add(Me.c1CmdNuevo)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdEdit)
        Me.C1CommandHolder1.Commands.Add(Me.c1CmdGenerarFicha)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdImprimir)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdAnularFicha)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdEnvio)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExport)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CmdBuscar
        '
        Me.C1CmdBuscar.Image = Global.Integration.Test.My.Resources.Resources.find
        Me.C1CmdBuscar.Name = "C1CmdBuscar"
        '
        'c1CmdNuevo
        '
        Me.c1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.c1CmdNuevo.Name = "c1CmdNuevo"
        Me.c1CmdNuevo.Text = "&Nuevo"
        '
        'C1CmdEdit
        '
        Me.C1CmdEdit.Name = "C1CmdEdit"
        Me.C1CmdEdit.Text = "&Modificar"
        '
        'c1CmdGenerarFicha
        '
        Me.c1CmdGenerarFicha.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.c1CmdGenerarFicha.Name = "c1CmdGenerarFicha"
        Me.c1CmdGenerarFicha.Text = "&Realizar Pago"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "&Cerrar"
        '
        'C1CmdImprimir
        '
        Me.C1CmdImprimir.Name = "C1CmdImprimir"
        Me.C1CmdImprimir.Text = "Imprimir Ficha"
        '
        'C1CmdAnularFicha
        '
        Me.C1CmdAnularFicha.Name = "C1CmdAnularFicha"
        Me.C1CmdAnularFicha.Text = "Anular Ficha"
        '
        'C1CmdEnvio
        '
        Me.C1CmdEnvio.Name = "C1CmdEnvio"
        Me.C1CmdEnvio.Text = "Enviar a LIS (F12)"
        Me.C1CmdEnvio.Visible = False
        '
        'C1CmdExport
        '
        Me.C1CmdExport.Name = "C1CmdExport"
        Me.C1CmdExport.Text = "Exportar a Excel"
        '
        'C1ToolBar
        '
        Me.C1ToolBar.AccessibleName = "Tool Bar"
        Me.C1ToolBar.CommandHolder = Nothing
        Me.C1ToolBar.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CmdLinkBuscar, Me.C1CmdLinkPago, Me.C1CmdLinkCerrar})
        Me.C1ToolBar.Location = New System.Drawing.Point(3, 39)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(411, 24)
        Me.C1ToolBar.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.C1ToolBar.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdLinkBuscar
        '
        Me.C1CmdLinkBuscar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkBuscar.Command = Me.C1CmdBuscar
        Me.C1CmdLinkBuscar.Text = "&Buscar (F5)"
        '
        'C1CmdLinkPago
        '
        Me.C1CmdLinkPago.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkPago.Command = Me.c1CmdGenerarFicha
        Me.C1CmdLinkPago.SortOrder = 1
        Me.C1CmdLinkPago.Text = "&Generar Ficha de Atención (F9)"
        '
        'C1CmdLinkCerrar
        '
        Me.C1CmdLinkCerrar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCerrar.Command = Me.C1CmdCerrar
        Me.C1CmdLinkCerrar.SortOrder = 2
        Me.C1CmdLinkCerrar.Text = "&Cerrar (ESC)"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1189, 32)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "҉    Proforma Móvil - Android"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.ChkBoxFiltraFecha)
        Me.GroupBox.Controls.Add(Me.GrpBoxPersona)
        Me.GroupBox.Controls.Add(Me.CboTipoDocu)
        Me.GroupBox.Controls.Add(Me.CboTipoPer)
        Me.GroupBox.Controls.Add(Me.Label14)
        Me.GroupBox.Controls.Add(Me.Label15)
        Me.GroupBox.Controls.Add(Me.TxtNroFind)
        Me.GroupBox.Controls.Add(Me.Label16)
        Me.GroupBox.Controls.Add(Me.Panel1)
        Me.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox.Location = New System.Drawing.Point(3, 71)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(1189, 124)
        Me.GroupBox.TabIndex = 29
        Me.GroupBox.TabStop = False
        '
        'ChkBoxFiltraFecha
        '
        Me.ChkBoxFiltraFecha.AutoSize = True
        Me.ChkBoxFiltraFecha.Location = New System.Drawing.Point(677, 28)
        Me.ChkBoxFiltraFecha.Name = "ChkBoxFiltraFecha"
        Me.ChkBoxFiltraFecha.Size = New System.Drawing.Size(115, 19)
        Me.ChkBoxFiltraFecha.TabIndex = 2
        Me.ChkBoxFiltraFecha.Text = "Filtrar por Fecha"
        Me.ChkBoxFiltraFecha.UseVisualStyleBackColor = True
        '
        'GrpBoxPersona
        '
        Me.GrpBoxPersona.Controls.Add(Me.BtnValidar)
        Me.GrpBoxPersona.Controls.Add(Me.LblcNombre)
        Me.GrpBoxPersona.Controls.Add(Me.Label5)
        Me.GrpBoxPersona.Controls.Add(Me.Label4)
        Me.GrpBoxPersona.Controls.Add(Me.Label19)
        Me.GrpBoxPersona.Controls.Add(Me.LblEdad)
        Me.GrpBoxPersona.Controls.Add(Me.LblcPerCodigo)
        Me.GrpBoxPersona.Location = New System.Drawing.Point(40, 58)
        Me.GrpBoxPersona.Name = "GrpBoxPersona"
        Me.GrpBoxPersona.Size = New System.Drawing.Size(1078, 55)
        Me.GrpBoxPersona.TabIndex = 34
        Me.GrpBoxPersona.TabStop = False
        Me.GrpBoxPersona.Text = "Datos Persona"
        '
        'BtnValidar
        '
        Me.BtnValidar.BackColor = System.Drawing.Color.Maroon
        Me.BtnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValidar.ForeColor = System.Drawing.Color.White
        Me.BtnValidar.Image = Global.Integration.Test.My.Resources.Resources.user_nude
        Me.BtnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnValidar.Location = New System.Drawing.Point(872, 17)
        Me.BtnValidar.Name = "BtnValidar"
        Me.BtnValidar.Size = New System.Drawing.Size(180, 32)
        Me.BtnValidar.TabIndex = 0
        Me.BtnValidar.Text = "Validar Persona (F6)"
        Me.BtnValidar.UseVisualStyleBackColor = False
        Me.BtnValidar.Visible = False
        '
        'LblcNombre
        '
        Me.LblcNombre.BackColor = System.Drawing.Color.Azure
        Me.LblcNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblcNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcNombre.Location = New System.Drawing.Point(343, 22)
        Me.LblcNombre.Name = "LblcNombre"
        Me.LblcNombre.Size = New System.Drawing.Size(390, 23)
        Me.LblcNombre.TabIndex = 25
        Me.LblcNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Apellidos y Nombres"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(739, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 15)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Edad:"
        '
        'LblEdad
        '
        Me.LblEdad.BackColor = System.Drawing.Color.Azure
        Me.LblEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdad.Location = New System.Drawing.Point(784, 22)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(71, 23)
        Me.LblEdad.TabIndex = 27
        Me.LblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblcPerCodigo
        '
        Me.LblcPerCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.LblcPerCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblcPerCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcPerCodigo.Location = New System.Drawing.Point(97, 22)
        Me.LblcPerCodigo.Name = "LblcPerCodigo"
        Me.LblcPerCodigo.Size = New System.Drawing.Size(103, 23)
        Me.LblcPerCodigo.TabIndex = 24
        Me.LblcPerCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboTipoDocu
        '
        Me.CboTipoDocu.BackColor = System.Drawing.SystemColors.Info
        Me.CboTipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDocu.FormattingEnabled = True
        Me.CboTipoDocu.Location = New System.Drawing.Point(139, 29)
        Me.CboTipoDocu.Name = "CboTipoDocu"
        Me.CboTipoDocu.Size = New System.Drawing.Size(269, 23)
        Me.CboTipoDocu.TabIndex = 0
        '
        'CboTipoPer
        '
        Me.CboTipoPer.BackColor = System.Drawing.SystemColors.Info
        Me.CboTipoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPer.Enabled = False
        Me.CboTipoPer.FormattingEnabled = True
        Me.CboTipoPer.Location = New System.Drawing.Point(315, -3)
        Me.CboTipoPer.Name = "CboTipoPer"
        Me.CboTipoPer.Size = New System.Drawing.Size(181, 23)
        Me.CboTipoPer.TabIndex = 28
        Me.CboTipoPer.Tag = "1010"
        Me.CboTipoPer.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(37, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 15)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Tipo documento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(228, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Tipo persona"
        Me.Label15.Visible = False
        '
        'TxtNroFind
        '
        Me.TxtNroFind.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNroFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroFind.Location = New System.Drawing.Point(515, 28)
        Me.TxtNroFind.MaxLength = 15
        Me.TxtNroFind.Name = "TxtNroFind"
        Me.TxtNroFind.Size = New System.Drawing.Size(146, 21)
        Me.TxtNroFind.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(412, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 15)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Nro. Documento"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DtpFecFin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DtpFecIni)
        Me.Panel1.Location = New System.Drawing.Point(798, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 32)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
        '
        'DtpFecFin
        '
        Me.DtpFecFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFin.Location = New System.Drawing.Point(220, 6)
        Me.DtpFecFin.Name = "DtpFecFin"
        Me.DtpFecFin.Size = New System.Drawing.Size(100, 21)
        Me.DtpFecFin.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(19, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(177, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "hasta"
        '
        'DtpFecIni
        '
        Me.DtpFecIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecIni.Location = New System.Drawing.Point(70, 5)
        Me.DtpFecIni.Name = "DtpFecIni"
        Me.DtpFecIni.Size = New System.Drawing.Size(100, 21)
        Me.DtpFecIni.TabIndex = 0
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Location = New System.Drawing.Point(3, 30)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(983, 281)
        Me.Table1.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.tumblr_inline_n6yyjlpK9D1qhfbft
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtAppNombre2)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.TxtAppApellidoMaterno)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.CboSexoTEmp)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.BtnGuardarValidacion)
        Me.Panel2.Controls.Add(Me.DtpAppFecNaci)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxtAppNombre1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TxtAppApellidoPaterno)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TxtAppNumDocu)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.CboAppTipoDocu)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BtnCancel)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(326, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(437, 345)
        Me.Panel2.TabIndex = 35
        Me.Panel2.Visible = False
        '
        'TxtAppNombre2
        '
        Me.TxtAppNombre2.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAppNombre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAppNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppNombre2.Location = New System.Drawing.Point(140, 198)
        Me.TxtAppNombre2.MaxLength = 120
        Me.TxtAppNombre2.Name = "TxtAppNombre2"
        Me.TxtAppNombre2.Size = New System.Drawing.Size(269, 21)
        Me.TxtAppNombre2.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(27, 201)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 15)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Nombre 2"
        '
        'TxtAppApellidoMaterno
        '
        Me.TxtAppApellidoMaterno.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAppApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAppApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppApellidoMaterno.Location = New System.Drawing.Point(140, 144)
        Me.TxtAppApellidoMaterno.MaxLength = 120
        Me.TxtAppApellidoMaterno.Name = "TxtAppApellidoMaterno"
        Me.TxtAppApellidoMaterno.Size = New System.Drawing.Size(269, 21)
        Me.TxtAppApellidoMaterno.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(27, 147)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 15)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Apellido Materno"
        '
        'CboSexoTEmp
        '
        Me.CboSexoTEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSexoTEmp.FormattingEnabled = True
        Me.CboSexoTEmp.Location = New System.Drawing.Point(140, 252)
        Me.CboSexoTEmp.Name = "CboSexoTEmp"
        Me.CboSexoTEmp.Size = New System.Drawing.Size(269, 23)
        Me.CboSexoTEmp.TabIndex = 7
        Me.CboSexoTEmp.Tag = "1002"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 15)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Sexo"
        '
        'BtnGuardarValidacion
        '
        Me.BtnGuardarValidacion.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGuardarValidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarValidacion.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardarValidacion.Image = Global.Integration.Test.My.Resources.Resources.user_nude
        Me.BtnGuardarValidacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarValidacion.Location = New System.Drawing.Point(207, 290)
        Me.BtnGuardarValidacion.Name = "BtnGuardarValidacion"
        Me.BtnGuardarValidacion.Size = New System.Drawing.Size(160, 35)
        Me.BtnGuardarValidacion.TabIndex = 8
        Me.BtnGuardarValidacion.Text = "Validar Persona"
        Me.BtnGuardarValidacion.UseVisualStyleBackColor = False
        '
        'DtpAppFecNaci
        '
        Me.DtpAppFecNaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAppFecNaci.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpAppFecNaci.Location = New System.Drawing.Point(140, 225)
        Me.DtpAppFecNaci.Name = "DtpAppFecNaci"
        Me.DtpAppFecNaci.Size = New System.Drawing.Size(113, 21)
        Me.DtpAppFecNaci.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 228)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 15)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Fecha Nacimiento"
        '
        'TxtAppNombre1
        '
        Me.TxtAppNombre1.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAppNombre1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAppNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppNombre1.Location = New System.Drawing.Point(140, 171)
        Me.TxtAppNombre1.MaxLength = 120
        Me.TxtAppNombre1.Name = "TxtAppNombre1"
        Me.TxtAppNombre1.Size = New System.Drawing.Size(269, 21)
        Me.TxtAppNombre1.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Nombre 1"
        '
        'TxtAppApellidoPaterno
        '
        Me.TxtAppApellidoPaterno.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAppApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAppApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppApellidoPaterno.Location = New System.Drawing.Point(140, 117)
        Me.TxtAppApellidoPaterno.MaxLength = 120
        Me.TxtAppApellidoPaterno.Name = "TxtAppApellidoPaterno"
        Me.TxtAppApellidoPaterno.Size = New System.Drawing.Size(269, 21)
        Me.TxtAppApellidoPaterno.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 15)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Apellido Paterno"
        '
        'TxtAppNumDocu
        '
        Me.TxtAppNumDocu.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAppNumDocu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppNumDocu.Location = New System.Drawing.Point(140, 87)
        Me.TxtAppNumDocu.MaxLength = 20
        Me.TxtAppNumDocu.Name = "TxtAppNumDocu"
        Me.TxtAppNumDocu.Size = New System.Drawing.Size(146, 21)
        Me.TxtAppNumDocu.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Nro. Documento"
        '
        'CboAppTipoDocu
        '
        Me.CboAppTipoDocu.BackColor = System.Drawing.SystemColors.Info
        Me.CboAppTipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAppTipoDocu.Enabled = False
        Me.CboAppTipoDocu.FormattingEnabled = True
        Me.CboAppTipoDocu.Location = New System.Drawing.Point(140, 52)
        Me.CboAppTipoDocu.Name = "CboAppTipoDocu"
        Me.CboAppTipoDocu.Size = New System.Drawing.Size(269, 23)
        Me.CboAppTipoDocu.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Tipo documento"
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources.Cancel_16x16
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(65, 290)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(136, 35)
        Me.BtnCancel.TabIndex = 9
        Me.BtnCancel.Text = "&Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(437, 32)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "҉     Verificacion de Datos - Persona Móvil"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Table2
        '
        Me.Table2.AllowUserToAddRows = False
        Me.Table2.AllowUserToDeleteRows = False
        Me.Table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table2.Location = New System.Drawing.Point(3, 33)
        Me.Table2.Name = "Table2"
        Me.Table2.ReadOnly = True
        Me.Table2.Size = New System.Drawing.Size(181, 278)
        Me.Table2.TabIndex = 37
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.C1ToolBar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 325.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1195, 524)
        Me.TableLayoutPanel1.TabIndex = 38
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.31623!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.68377!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 201)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1189, 320)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Table2, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.872611!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.12739!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(187, 314)
        Me.TableLayoutPanel3.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 30)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Nro. Proforma(s)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Table1, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(196, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.917197!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.0828!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(990, 314)
        Me.TableLayoutPanel4.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(3, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(984, 27)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Detalle de Proforma"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormProformaAndroid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 524)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormProformaAndroid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proforma Móvil - Android"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.GrpBoxPersona.ResumeLayout(False)
        Me.GrpBoxPersona.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents C1CmdBuscar As C1.Win.C1Command.C1Command
    Private WithEvents c1CmdNuevo As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Private WithEvents c1CmdGenerarFicha As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdImprimir As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdAnularFicha As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdEnvio As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdExport As C1.Win.C1Command.C1Command
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdLinkBuscar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkPago As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents LblcPerCodigo As System.Windows.Forms.Label
    Friend WithEvents LblcNombre As System.Windows.Forms.Label
    Friend WithEvents LblEdad As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents CboTipoPer As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtNroFind As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxPersona As System.Windows.Forms.GroupBox
    Friend WithEvents BtnValidar As System.Windows.Forms.Button
    Friend WithEvents ChkBoxFiltraFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnGuardarValidacion As System.Windows.Forms.Button
    Friend WithEvents DtpAppFecNaci As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtAppNombre1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtAppApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtAppNumDocu As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboAppTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboSexoTEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Table2 As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtAppNombre2 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtAppApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
