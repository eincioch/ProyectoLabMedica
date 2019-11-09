<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaServiciosComponentes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaServiciosComponentes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeViewC = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GrpBox = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPrecio = New System.Windows.Forms.TabPage()
        Me.LblnCtaCteSerComCodigo = New System.Windows.Forms.Label()
        Me.LblCtaCteSerCompDescripcion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoAtencion = New System.Windows.Forms.ComboBox()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.nCtaCteSerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerJurCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCmpCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIntDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCmpUndDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCmpCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCmpEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CboUnidad = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LblDescr = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblJerarquia = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdLinkNuevo = New C1.Win.C1Command.C1CommandLink()
        Me.c1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkGrabar = New C1.Win.C1Command.C1CommandLink()
        Me.c1CmdGrabar = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkCancel = New C1.Win.C1Command.C1CommandLink()
        Me.c1CmdCancel = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkEdit = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CmdHldr = New C1.Win.C1Command.C1CommandHolder()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GrpBox.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPrecio.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeViewC)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1360, 713)
        Me.SplitContainer1.SplitterDistance = 279
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeViewC
        '
        Me.TreeViewC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewC.ImageIndex = 0
        Me.TreeViewC.ImageList = Me.ImageList1
        Me.TreeViewC.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewC.Name = "TreeViewC"
        Me.TreeViewC.SelectedImageIndex = 0
        Me.TreeViewC.Size = New System.Drawing.Size(277, 711)
        Me.TreeViewC.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder")
        Me.ImageList1.Images.SetKeyName(1, "folder_add")
        Me.ImageList1.Images.SetKeyName(2, "document_comment_above")
        Me.ImageList1.Images.SetKeyName(3, "document_inspect")
        Me.ImageList1.Images.SetKeyName(4, "7009.ico")
        Me.ImageList1.Images.SetKeyName(5, "7008.ico")
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GrpBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.C1ToolBar)
        Me.SplitContainer2.Panel1.Enabled = False
        Me.SplitContainer2.Size = New System.Drawing.Size(1075, 711)
        Me.SplitContainer2.SplitterDistance = 556
        Me.SplitContainer2.TabIndex = 0
        '
        'GrpBox
        '
        Me.GrpBox.Controls.Add(Me.TabControl1)
        Me.GrpBox.Controls.Add(Me.LblDescr)
        Me.GrpBox.Controls.Add(Me.Label11)
        Me.GrpBox.Controls.Add(Me.LblCodigo)
        Me.GrpBox.Controls.Add(Me.Label4)
        Me.GrpBox.Controls.Add(Me.LblJerarquia)
        Me.GrpBox.Controls.Add(Me.Label5)
        Me.GrpBox.Location = New System.Drawing.Point(6, 35)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(850, 609)
        Me.GrpBox.TabIndex = 0
        Me.GrpBox.TabStop = False
        Me.GrpBox.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPrecio)
        Me.TabControl1.Location = New System.Drawing.Point(6, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(835, 546)
        Me.TabControl1.TabIndex = 0
        '
        'TabPrecio
        '
        Me.TabPrecio.Controls.Add(Me.LblnCtaCteSerComCodigo)
        Me.TabPrecio.Controls.Add(Me.LblCtaCteSerCompDescripcion)
        Me.TabPrecio.Controls.Add(Me.Label1)
        Me.TabPrecio.Controls.Add(Me.cboTipoAtencion)
        Me.TabPrecio.Controls.Add(Me.BtnQuitar)
        Me.TabPrecio.Controls.Add(Me.BtnAdd)
        Me.TabPrecio.Controls.Add(Me.BtnBuscar)
        Me.TabPrecio.Controls.Add(Me.Table1)
        Me.TabPrecio.Controls.Add(Me.TxtCantidad)
        Me.TabPrecio.Controls.Add(Me.Label18)
        Me.TabPrecio.Controls.Add(Me.Label7)
        Me.TabPrecio.Controls.Add(Me.Label9)
        Me.TabPrecio.Controls.Add(Me.CboUnidad)
        Me.TabPrecio.Controls.Add(Me.ShapeContainer1)
        Me.TabPrecio.Location = New System.Drawing.Point(4, 25)
        Me.TabPrecio.Name = "TabPrecio"
        Me.TabPrecio.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPrecio.Size = New System.Drawing.Size(827, 517)
        Me.TabPrecio.TabIndex = 0
        Me.TabPrecio.Text = "Componentes de Servicio"
        Me.TabPrecio.UseVisualStyleBackColor = True
        '
        'LblnCtaCteSerComCodigo
        '
        Me.LblnCtaCteSerComCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblnCtaCteSerComCodigo.Location = New System.Drawing.Point(608, 60)
        Me.LblnCtaCteSerComCodigo.Name = "LblnCtaCteSerComCodigo"
        Me.LblnCtaCteSerComCodigo.Size = New System.Drawing.Size(85, 21)
        Me.LblnCtaCteSerComCodigo.TabIndex = 153
        Me.LblnCtaCteSerComCodigo.Visible = False
        '
        'LblCtaCteSerCompDescripcion
        '
        Me.LblCtaCteSerCompDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCtaCteSerCompDescripcion.Location = New System.Drawing.Point(129, 60)
        Me.LblCtaCteSerCompDescripcion.Name = "LblCtaCteSerCompDescripcion"
        Me.LblCtaCteSerCompDescripcion.Size = New System.Drawing.Size(442, 21)
        Me.LblCtaCteSerCompDescripcion.TabIndex = 152
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Atención"
        '
        'cboTipoAtencion
        '
        Me.cboTipoAtencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoAtencion.FormattingEnabled = True
        Me.cboTipoAtencion.Location = New System.Drawing.Point(129, 16)
        Me.cboTipoAtencion.Name = "cboTipoAtencion"
        Me.cboTipoAtencion.Size = New System.Drawing.Size(352, 21)
        Me.cboTipoAtencion.TabIndex = 151
        Me.cboTipoAtencion.Tag = "nIntClase=1133;nIntTipo=0"
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Image = Global.Integration.Test.My.Resources.Resources.DeleteSheetRows_16x16
        Me.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitar.Location = New System.Drawing.Point(207, 175)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(132, 29)
        Me.BtnQuitar.TabIndex = 148
        Me.BtnQuitar.Text = "      Quitar [SUPR]"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Image = Global.Integration.Test.My.Resources.Resources.InsertRows_16x16
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(65, 175)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(132, 28)
        Me.BtnAdd.TabIndex = 147
        Me.BtnAdd.Text = "     Añadir [INS]"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.Integration.Test.My.Resources.Resources.Find_16x16
        Me.BtnBuscar.Location = New System.Drawing.Point(577, 58)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(25, 23)
        Me.BtnBuscar.TabIndex = 146
        Me.BtnBuscar.Tag = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nCtaCteSerCodigo, Me.cPerJurCodigo, Me.nCtaCteSerCmpCodigo, Me.cIntDescripcion, Me.nCtaCteSerCmpUndDestino, Me.cUnidad, Me.nCtaCteSerCmpCantidad, Me.nCtaCteSerCmpEstado, Me.cEstado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Table1.Location = New System.Drawing.Point(3, 239)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table1.Size = New System.Drawing.Size(1145, 516)
        Me.Table1.TabIndex = 145
        '
        'nCtaCteSerCodigo
        '
        Me.nCtaCteSerCodigo.DataPropertyName = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.HeaderText = "Cód. Prueba"
        Me.nCtaCteSerCodigo.Name = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.ReadOnly = True
        Me.nCtaCteSerCodigo.Visible = False
        '
        'cPerJurCodigo
        '
        Me.cPerJurCodigo.DataPropertyName = "cPerJurCodigo"
        Me.cPerJurCodigo.HeaderText = "Cód. Sede"
        Me.cPerJurCodigo.Name = "cPerJurCodigo"
        Me.cPerJurCodigo.ReadOnly = True
        Me.cPerJurCodigo.Visible = False
        '
        'nCtaCteSerCmpCodigo
        '
        Me.nCtaCteSerCmpCodigo.DataPropertyName = "nCtaCteSerCmpCodigo"
        Me.nCtaCteSerCmpCodigo.HeaderText = "Cód. Componente"
        Me.nCtaCteSerCmpCodigo.Name = "nCtaCteSerCmpCodigo"
        Me.nCtaCteSerCmpCodigo.ReadOnly = True
        Me.nCtaCteSerCmpCodigo.Visible = False
        '
        'cIntDescripcion
        '
        Me.cIntDescripcion.DataPropertyName = "cIntDescripcion"
        Me.cIntDescripcion.HeaderText = "Descripción"
        Me.cIntDescripcion.MinimumWidth = 150
        Me.cIntDescripcion.Name = "cIntDescripcion"
        Me.cIntDescripcion.ReadOnly = True
        Me.cIntDescripcion.Width = 250
        '
        'nCtaCteSerCmpUndDestino
        '
        Me.nCtaCteSerCmpUndDestino.DataPropertyName = "nCtaCteSerCmpUndDestino"
        Me.nCtaCteSerCmpUndDestino.HeaderText = "Cód. Unidad"
        Me.nCtaCteSerCmpUndDestino.Name = "nCtaCteSerCmpUndDestino"
        Me.nCtaCteSerCmpUndDestino.ReadOnly = True
        Me.nCtaCteSerCmpUndDestino.Visible = False
        '
        'cUnidad
        '
        Me.cUnidad.DataPropertyName = "cUnidad"
        Me.cUnidad.HeaderText = "Unidad"
        Me.cUnidad.MinimumWidth = 100
        Me.cUnidad.Name = "cUnidad"
        Me.cUnidad.ReadOnly = True
        '
        'nCtaCteSerCmpCantidad
        '
        Me.nCtaCteSerCmpCantidad.DataPropertyName = "nCtaCteSerCmpCantidad"
        Me.nCtaCteSerCmpCantidad.HeaderText = "Cantidad"
        Me.nCtaCteSerCmpCantidad.Name = "nCtaCteSerCmpCantidad"
        Me.nCtaCteSerCmpCantidad.ReadOnly = True
        '
        'nCtaCteSerCmpEstado
        '
        Me.nCtaCteSerCmpEstado.DataPropertyName = "nCtaCteSerCmpEstado"
        Me.nCtaCteSerCmpEstado.HeaderText = "Cód. Estado"
        Me.nCtaCteSerCmpEstado.Name = "nCtaCteSerCmpEstado"
        Me.nCtaCteSerCmpEstado.ReadOnly = True
        Me.nCtaCteSerCmpEstado.Visible = False
        '
        'cEstado
        '
        Me.cEstado.DataPropertyName = "cEstado"
        Me.cEstado.HeaderText = "Estado"
        Me.cEstado.Name = "cEstado"
        Me.cEstado.ReadOnly = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(129, 131)
        Me.TxtCantidad.MaxLength = 5
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCantidad.Size = New System.Drawing.Size(106, 20)
        Me.TxtCantidad.TabIndex = 64
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(62, 134)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Unidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Componente"
        '
        'CboUnidad
        '
        Me.CboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUnidad.FormattingEnabled = True
        Me.CboUnidad.Location = New System.Drawing.Point(129, 97)
        Me.CboUnidad.Name = "CboUnidad"
        Me.CboUnidad.Size = New System.Drawing.Size(245, 21)
        Me.CboUnidad.TabIndex = 1
        Me.CboUnidad.Tag = "nConCodigo=1004"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(821, 511)
        Me.ShapeContainer1.TabIndex = 149
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 58
        Me.LineShape1.X2 = 598
        Me.LineShape1.Y1 = 43
        Me.LineShape1.Y2 = 43
        '
        'LblDescr
        '
        Me.LblDescr.BackColor = System.Drawing.SystemColors.Info
        Me.LblDescr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescr.Location = New System.Drawing.Point(497, 19)
        Me.LblDescr.Name = "LblDescr"
        Me.LblDescr.Size = New System.Drawing.Size(334, 20)
        Me.LblDescr.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(355, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Servicio y/o Descr. Analisis"
        '
        'LblCodigo
        '
        Me.LblCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.Location = New System.Drawing.Point(102, 16)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(52, 20)
        Me.LblCodigo.TabIndex = 0
        Me.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Código"
        '
        'LblJerarquia
        '
        Me.LblJerarquia.BackColor = System.Drawing.SystemColors.Info
        Me.LblJerarquia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblJerarquia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJerarquia.Location = New System.Drawing.Point(244, 18)
        Me.LblJerarquia.Name = "LblJerarquia"
        Me.LblJerarquia.Size = New System.Drawing.Size(105, 20)
        Me.LblJerarquia.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cod. Laboratorio"
        '
        'C1ToolBar
        '
        Me.C1ToolBar.AccessibleName = "Tool Bar"
        Me.C1ToolBar.CommandHolder = Nothing
        Me.C1ToolBar.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CmdLinkNuevo, Me.C1CmdLinkGrabar, Me.C1CmdLinkCancel, Me.C1CmdLinkEdit, Me.C1CmdLinkCerrar})
        Me.C1ToolBar.Location = New System.Drawing.Point(6, 5)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(472, 24)
        Me.C1ToolBar.Text = "C1ToolBar1"
        Me.C1ToolBar.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdLinkNuevo
        '
        Me.C1CmdLinkNuevo.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkNuevo.Command = Me.c1CmdNuevo
        '
        'c1CmdNuevo
        '
        Me.c1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.c1CmdNuevo.Name = "c1CmdNuevo"
        Me.c1CmdNuevo.Text = "&Nuevo (F6)"
        '
        'C1CmdLinkGrabar
        '
        Me.C1CmdLinkGrabar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkGrabar.Command = Me.c1CmdGrabar
        Me.C1CmdLinkGrabar.SortOrder = 1
        Me.C1CmdLinkGrabar.Text = "&Guardar (F4)"
        '
        'c1CmdGrabar
        '
        Me.c1CmdGrabar.Image = Global.Integration.Test.My.Resources.Resources.disk
        Me.c1CmdGrabar.Name = "c1CmdGrabar"
        Me.c1CmdGrabar.Text = "&Save"
        '
        'C1CmdLinkCancel
        '
        Me.C1CmdLinkCancel.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCancel.Command = Me.c1CmdCancel
        Me.C1CmdLinkCancel.SortOrder = 2
        Me.C1CmdLinkCancel.Text = "&Cancelar"
        '
        'c1CmdCancel
        '
        Me.c1CmdCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.c1CmdCancel.Name = "c1CmdCancel"
        Me.c1CmdCancel.Text = "Cancel"
        '
        'C1CmdLinkEdit
        '
        Me.C1CmdLinkEdit.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkEdit.Command = Me.C1CmdEdit
        Me.C1CmdLinkEdit.SortOrder = 3
        Me.C1CmdLinkEdit.Text = "&Modificar (F7)"
        '
        'C1CmdEdit
        '
        Me.C1CmdEdit.Image = Global.Integration.Test.My.Resources.Resources._16_em_pencil
        Me.C1CmdEdit.Name = "C1CmdEdit"
        Me.C1CmdEdit.Text = "&Modificar"
        '
        'C1CmdLinkCerrar
        '
        Me.C1CmdLinkCerrar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCerrar.Command = Me.C1CmdCerrar
        Me.C1CmdLinkCerrar.SortOrder = 4
        Me.C1CmdLinkCerrar.Text = "&Cerrar (ESC)"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "&Cerrar"
        '
        'C1CmdHldr
        '
        Me.C1CmdHldr.Commands.Add(Me.c1CmdNuevo)
        Me.C1CmdHldr.Commands.Add(Me.c1CmdGrabar)
        Me.C1CmdHldr.Commands.Add(Me.c1CmdCancel)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdEdit)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmdHldr.Owner = Me
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label6)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer3.Size = New System.Drawing.Size(1360, 742)
        Me.SplitContainer3.SplitterDistance = 25
        Me.SplitContainer3.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1360, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "҉     Componentes de Servicios"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormMaServiciosComponentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 742)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMaServiciosComponentes"
        Me.Text = "1014 - Componentes de Servicios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GrpBox.ResumeLayout(False)
        Me.GrpBox.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPrecio.ResumeLayout(False)
        Me.TabPrecio.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeViewC As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents LblJerarquia As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents C1CmdHldr As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdLinkNuevo As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkGrabar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCancel As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkEdit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Private WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblDescr As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPrecio As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Private WithEvents c1CmdGrabar As C1.Win.C1Command.C1Command
    Private WithEvents c1CmdCancel As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Private WithEvents c1CmdNuevo As C1.Win.C1Command.C1Command
    Private WithEvents nCtaCteSerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cPerJurCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteSerCmpCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cIntDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteSerCmpUndDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteSerCmpCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteSerCmpEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoAtencion As System.Windows.Forms.ComboBox
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LblnCtaCteSerComCodigo As System.Windows.Forms.Label
    Friend WithEvents LblCtaCteSerCompDescripcion As System.Windows.Forms.Label
    Private WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
