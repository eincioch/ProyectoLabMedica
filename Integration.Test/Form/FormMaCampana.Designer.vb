<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaCampana
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaCampana))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtPrecioPromo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.cPerJurCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteSerJerarquia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteSerKeyWord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nMonCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nIntCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nFlag1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblTotalPago = New System.Windows.Forms.Label()
        Me.DtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.DtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboAnio1 = New System.Windows.Forms.ComboBox()
        Me.CboMes1 = New System.Windows.Forms.ComboBox()
        Me.CboDia1 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CboAnio = New System.Windows.Forms.ComboBox()
        Me.CboMes = New System.Windows.Forms.ComboBox()
        Me.CboDia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDescrp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblnIntCamp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1CmdHldr = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdGrabar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCancel = New C1.Win.C1Command.C1Command()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CalcPrecio = New C1.Win.C1Command.C1Command()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Table2 = New System.Windows.Forms.DataGridView()
        Me.nIntCamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombreCamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFecIniCamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFecFinCamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtPrecioPromo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.BtnQuitar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Table1)
        Me.GroupBox1.Controls.Add(Me.LblTotalPago)
        Me.GroupBox1.Controls.Add(Me.DtpFecFin)
        Me.GroupBox1.Controls.Add(Me.DtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CboAnio1)
        Me.GroupBox1.Controls.Add(Me.CboMes1)
        Me.GroupBox1.Controls.Add(Me.CboDia1)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.CboAnio)
        Me.GroupBox1.Controls.Add(Me.CboMes)
        Me.GroupBox1.Controls.Add(Me.CboDia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtDescrp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblnIntCamp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(701, 552)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Definir datos "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(24, 520)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(483, 15)
        Me.Label12.TabIndex = 141
        Me.Label12.Text = "Para calcular precio por Muestra ""Precio Promoción"" debe ser < Menor a ""Total Pre" & _
    "cio""."
        '
        'TxtPrecioPromo
        '
        Me.TxtPrecioPromo.Location = New System.Drawing.Point(136, 481)
        Me.TxtPrecioPromo.Name = "TxtPrecioPromo"
        Me.TxtPrecioPromo.Size = New System.Drawing.Size(116, 21)
        Me.TxtPrecioPromo.TabIndex = 140
        Me.TxtPrecioPromo.Text = "0.00"
        Me.TxtPrecioPromo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(24, 486)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 15)
        Me.Label13.TabIndex = 139
        Me.Label13.Text = "Precio Promoción"
        '
        'BtnAdd
        '
        Me.BtnAdd.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(409, 201)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(134, 28)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "Añadir [INS]"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitar.Location = New System.Drawing.Point(551, 200)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(132, 29)
        Me.BtnQuitar.TabIndex = 8
        Me.BtnQuitar.Text = "Quitar [SUPR]"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(463, 486)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 15)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Total Precio"
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerJurCodigo, Me.nCtaCteSerCodigo, Me.cCodGrupo, Me.cCtaCteSerJerarquia, Me.cCtaCteSerKeyWord, Me.nMonCodigo, Me.nIntCodigo, Me.nCtaCteSerCosto, Me.nFlag1})
        Me.Table1.Location = New System.Drawing.Point(10, 231)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(672, 240)
        Me.Table1.TabIndex = 132
        '
        'cPerJurCodigo
        '
        Me.cPerJurCodigo.DataPropertyName = "cPerJurCodigo"
        Me.cPerJurCodigo.HeaderText = "cPerJurCodigo"
        Me.cPerJurCodigo.Name = "cPerJurCodigo"
        Me.cPerJurCodigo.Visible = False
        Me.cPerJurCodigo.Width = 90
        '
        'nCtaCteSerCodigo
        '
        Me.nCtaCteSerCodigo.DataPropertyName = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.HeaderText = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.Name = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.Visible = False
        Me.nCtaCteSerCodigo.Width = 30
        '
        'cCodGrupo
        '
        Me.cCodGrupo.DataPropertyName = "cCodGrupo"
        Me.cCodGrupo.HeaderText = "cCodGrupo"
        Me.cCodGrupo.Name = "cCodGrupo"
        Me.cCodGrupo.Visible = False
        '
        'cCtaCteSerJerarquia
        '
        Me.cCtaCteSerJerarquia.DataPropertyName = "cCtaCteSerJerarquia"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cCtaCteSerJerarquia.DefaultCellStyle = DataGridViewCellStyle1
        Me.cCtaCteSerJerarquia.HeaderText = "Cod. Laboratorio"
        Me.cCtaCteSerJerarquia.Name = "cCtaCteSerJerarquia"
        Me.cCtaCteSerJerarquia.ReadOnly = True
        Me.cCtaCteSerJerarquia.Width = 130
        '
        'cCtaCteSerKeyWord
        '
        Me.cCtaCteSerKeyWord.DataPropertyName = "cCtaCteSerKeyWord"
        Me.cCtaCteSerKeyWord.HeaderText = "Descripción"
        Me.cCtaCteSerKeyWord.Name = "cCtaCteSerKeyWord"
        Me.cCtaCteSerKeyWord.ReadOnly = True
        Me.cCtaCteSerKeyWord.Width = 350
        '
        'nMonCodigo
        '
        Me.nMonCodigo.DataPropertyName = "nMonCodigo"
        Me.nMonCodigo.HeaderText = "nMonCodigo"
        Me.nMonCodigo.Name = "nMonCodigo"
        Me.nMonCodigo.Visible = False
        Me.nMonCodigo.Width = 20
        '
        'nIntCodigo
        '
        Me.nIntCodigo.DataPropertyName = "nIntCodigo"
        Me.nIntCodigo.HeaderText = "nIntCodigo"
        Me.nIntCodigo.Name = "nIntCodigo"
        Me.nIntCodigo.Visible = False
        Me.nIntCodigo.Width = 20
        '
        'nCtaCteSerCosto
        '
        Me.nCtaCteSerCosto.DataPropertyName = "nCtaCteSerCosto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.nCtaCteSerCosto.DefaultCellStyle = DataGridViewCellStyle2
        Me.nCtaCteSerCosto.HeaderText = "Precio"
        Me.nCtaCteSerCosto.Name = "nCtaCteSerCosto"
        Me.nCtaCteSerCosto.Width = 110
        '
        'nFlag1
        '
        Me.nFlag1.DataPropertyName = "nFlag"
        Me.nFlag1.HeaderText = "nFlag"
        Me.nFlag1.Name = "nFlag1"
        Me.nFlag1.Visible = False
        '
        'LblTotalPago
        '
        Me.LblTotalPago.BackColor = System.Drawing.SystemColors.Info
        Me.LblTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPago.ForeColor = System.Drawing.Color.Black
        Me.LblTotalPago.Location = New System.Drawing.Point(545, 480)
        Me.LblTotalPago.Name = "LblTotalPago"
        Me.LblTotalPago.Size = New System.Drawing.Size(114, 24)
        Me.LblTotalPago.TabIndex = 130
        Me.LblTotalPago.Text = "0.00"
        Me.LblTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtpFecFin
        '
        Me.DtpFecFin.Enabled = False
        Me.DtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFin.Location = New System.Drawing.Point(474, 160)
        Me.DtpFecFin.Name = "DtpFecFin"
        Me.DtpFecFin.Size = New System.Drawing.Size(111, 21)
        Me.DtpFecFin.TabIndex = 48
        Me.DtpFecFin.Visible = False
        '
        'DtpFecIni
        '
        Me.DtpFecIni.Enabled = False
        Me.DtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecIni.Location = New System.Drawing.Point(476, 107)
        Me.DtpFecIni.Name = "DtpFecIni"
        Me.DtpFecIni.Size = New System.Drawing.Size(111, 21)
        Me.DtpFecIni.TabIndex = 47
        Me.DtpFecIni.Visible = False
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(374, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 21)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Año"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(10, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(672, 22)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Servicios que participan"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(213, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 21)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Mes"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(148, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 21)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Dia"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CboAnio1
        '
        Me.CboAnio1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnio1.FormattingEnabled = True
        Me.CboAnio1.Location = New System.Drawing.Point(374, 165)
        Me.CboAnio1.Name = "CboAnio1"
        Me.CboAnio1.Size = New System.Drawing.Size(94, 23)
        Me.CboAnio1.TabIndex = 6
        Me.CboAnio1.Tag = "1021"
        '
        'CboMes1
        '
        Me.CboMes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMes1.FormattingEnabled = True
        Me.CboMes1.Location = New System.Drawing.Point(213, 166)
        Me.CboMes1.Name = "CboMes1"
        Me.CboMes1.Size = New System.Drawing.Size(153, 23)
        Me.CboMes1.TabIndex = 5
        Me.CboMes1.Tag = "1005"
        '
        'CboDia1
        '
        Me.CboDia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDia1.FormattingEnabled = True
        Me.CboDia1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CboDia1.Location = New System.Drawing.Point(147, 166)
        Me.CboDia1.Name = "CboDia1"
        Me.CboDia1.Size = New System.Drawing.Size(59, 23)
        Me.CboDia1.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(374, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 21)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Año"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(213, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(154, 21)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Mes"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(148, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 21)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Dia"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CboAnio
        '
        Me.CboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnio.FormattingEnabled = True
        Me.CboAnio.Location = New System.Drawing.Point(374, 110)
        Me.CboAnio.Name = "CboAnio"
        Me.CboAnio.Size = New System.Drawing.Size(94, 23)
        Me.CboAnio.TabIndex = 3
        Me.CboAnio.Tag = "1021"
        '
        'CboMes
        '
        Me.CboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMes.FormattingEnabled = True
        Me.CboMes.Location = New System.Drawing.Point(213, 111)
        Me.CboMes.Name = "CboMes"
        Me.CboMes.Size = New System.Drawing.Size(153, 23)
        Me.CboMes.TabIndex = 2
        Me.CboMes.Tag = "1005"
        '
        'CboDia
        '
        Me.CboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDia.FormattingEnabled = True
        Me.CboDia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CboDia.Location = New System.Drawing.Point(147, 111)
        Me.CboDia.Name = "CboDia"
        Me.CboDia.Size = New System.Drawing.Size(59, 23)
        Me.CboDia.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Fecha Termina"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Fecha Inicio"
        '
        'TxtDescrp
        '
        Me.TxtDescrp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescrp.Location = New System.Drawing.Point(146, 60)
        Me.TxtDescrp.Name = "TxtDescrp"
        Me.TxtDescrp.Size = New System.Drawing.Size(437, 21)
        Me.TxtDescrp.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre Campaña"
        '
        'LblnIntCamp
        '
        Me.LblnIntCamp.BackColor = System.Drawing.SystemColors.Info
        Me.LblnIntCamp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblnIntCamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblnIntCamp.Location = New System.Drawing.Point(147, 29)
        Me.LblnIntCamp.Name = "LblnIntCamp"
        Me.LblnIntCamp.Size = New System.Drawing.Size(106, 23)
        Me.LblnIntCamp.TabIndex = 18
        Me.LblnIntCamp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'C1CmdHldr
        '
        Me.C1CmdHldr.Commands.Add(Me.C1CmdNuevo)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdGrabar)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdCancel)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdEdit)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmdHldr.Commands.Add(Me.C1CalcPrecio)
        Me.C1CmdHldr.Owner = Me
        '
        'C1CmdNuevo
        '
        Me.C1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.C1CmdNuevo.Name = "C1CmdNuevo"
        Me.C1CmdNuevo.Text = "Nuevo (F6)"
        Me.C1CmdNuevo.ToolTipText = "Agrega nuevo registro a la base datos."
        '
        'C1CmdGrabar
        '
        Me.C1CmdGrabar.Image = Global.Integration.Test.My.Resources.Resources.disk
        Me.C1CmdGrabar.Name = "C1CmdGrabar"
        Me.C1CmdGrabar.Text = "&Guardar"
        '
        'C1CmdCancel
        '
        Me.C1CmdCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.C1CmdCancel.Name = "C1CmdCancel"
        Me.C1CmdCancel.Text = "Cancelar (F8)"
        '
        'C1CmdEdit
        '
        Me.C1CmdEdit.Image = Global.Integration.Test.My.Resources.Resources._16_em_pencil
        Me.C1CmdEdit.Name = "C1CmdEdit"
        Me.C1CmdEdit.Text = "Modificar (F7)"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "Cerrar (ESC)"
        '
        'C1CalcPrecio
        '
        Me.C1CalcPrecio.Image = Global.Integration.Test.My.Resources.Resources.money_add
        Me.C1CalcPrecio.Name = "C1CalcPrecio"
        Me.C1CalcPrecio.Text = "Calcular Precio"
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.Border.DarkColor = System.Drawing.SystemColors.ControlLight
        Me.C1ToolBar1.CommandHolder = Me.C1CmdHldr
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink4, Me.C1CommandLink6, Me.C1CommandLink3, Me.C1CommandLink5})
        Me.C1ToolBar1.Location = New System.Drawing.Point(24, 36)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(644, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdNuevo
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdGrabar
        Me.C1CommandLink2.SortOrder = 1
        Me.C1CommandLink2.Text = "&Guardar (F4)"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdEdit
        Me.C1CommandLink4.SortOrder = 2
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink6.Command = Me.C1CalcPrecio
        Me.C1CommandLink6.SortOrder = 3
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdCancel
        Me.C1CommandLink3.SortOrder = 4
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.C1CmdCerrar
        Me.C1CommandLink5.SortOrder = 5
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(752, 32)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "҉    Crear / Modifica Campaña"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(724, 595)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(716, 567)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Adicionar / Modificar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Table2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(716, 567)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listar Campañas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Teal
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(710, 32)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Vigentes"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Table2
        '
        Me.Table2.AllowUserToAddRows = False
        Me.Table2.AllowUserToDeleteRows = False
        Me.Table2.ColumnHeadersHeight = 30
        Me.Table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Table2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nIntCamp, Me.cNombreCamp, Me.dFecIniCamp, Me.dFecFinCamp})
        Me.Table2.Location = New System.Drawing.Point(7, 39)
        Me.Table2.Name = "Table2"
        Me.Table2.ReadOnly = True
        Me.Table2.Size = New System.Drawing.Size(703, 519)
        Me.Table2.TabIndex = 1
        '
        'nIntCamp
        '
        Me.nIntCamp.DataPropertyName = "nIntCamp"
        Me.nIntCamp.HeaderText = "Id."
        Me.nIntCamp.Name = "nIntCamp"
        Me.nIntCamp.ReadOnly = True
        Me.nIntCamp.Width = 50
        '
        'cNombreCamp
        '
        Me.cNombreCamp.DataPropertyName = "cNombreCamp"
        Me.cNombreCamp.HeaderText = "Descripción"
        Me.cNombreCamp.Name = "cNombreCamp"
        Me.cNombreCamp.ReadOnly = True
        Me.cNombreCamp.Width = 310
        '
        'dFecIniCamp
        '
        Me.dFecIniCamp.DataPropertyName = "dFecIniCamp"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dFecIniCamp.DefaultCellStyle = DataGridViewCellStyle3
        Me.dFecIniCamp.HeaderText = "Inicio"
        Me.dFecIniCamp.Name = "dFecIniCamp"
        Me.dFecIniCamp.ReadOnly = True
        Me.dFecIniCamp.Width = 120
        '
        'dFecFinCamp
        '
        Me.dFecFinCamp.DataPropertyName = "dFecFinCamp"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.dFecFinCamp.DefaultCellStyle = DataGridViewCellStyle4
        Me.dFecFinCamp.HeaderText = "Termina"
        Me.dFecFinCamp.Name = "dFecFinCamp"
        Me.dFecFinCamp.ReadOnly = True
        Me.dFecFinCamp.Width = 120
        '
        'FormMaCampana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 680)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FormMaCampana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Campaña"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C1CmdHldr As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdGrabar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCancel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDescrp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblnIntCamp As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboAnio1 As System.Windows.Forms.ComboBox
    Friend WithEvents CboMes1 As System.Windows.Forms.ComboBox
    Friend WithEvents CboDia1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CboAnio As System.Windows.Forms.ComboBox
    Friend WithEvents CboMes As System.Windows.Forms.ComboBox
    Friend WithEvents CboDia As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFecIni As System.Windows.Forms.DateTimePicker
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblTotalPago As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Table2 As System.Windows.Forms.DataGridView
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecioPromo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents C1CalcPrecio As C1.Win.C1Command.C1Command
    Friend WithEvents nIntCamp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNombreCamp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dFecIniCamp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dFecFinCamp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Private WithEvents cPerJurCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteSerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cCodGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cCtaCteSerJerarquia As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cCtaCteSerKeyWord As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nMonCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nIntCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteSerCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nFlag1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
