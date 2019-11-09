<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaPorcDsctoEntidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaPorcDsctoEntidades))
        Me.GrpBoxDetalle = New System.Windows.Forms.GroupBox()
        Me.BtnQuitarTodo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdGuardar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdCancel = New C1.Win.C1Command.C1Command()
        Me.C1CmdSubirArchivo = New C1.Win.C1Command.C1Command()
        Me.C1CmdExportExcel = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.Table2 = New System.Windows.Forms.DataGridView()
        Me.cCtaCteSerJerarquia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCtePrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GrpBoxTodo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPorc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CboEmpresa = New System.Windows.Forms.ComboBox()
        Me.CboTipoCta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChckAplicaSucursales = New System.Windows.Forms.CheckBox()
        Me.ChckBoxTodo = New System.Windows.Forms.CheckBox()
        Me.ChckCargaPlantilla = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRutaArchivo = New System.Windows.Forms.TextBox()
        Me.BtnSeleccionarArchivo = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BtnSubeArchivo = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnBuscarEmpresa = New System.Windows.Forms.Button()
        Me.GrpBoxDetalle.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GrpBoxTodo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBoxDetalle
        '
        Me.GrpBoxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpBoxDetalle.Controls.Add(Me.BtnQuitarTodo)
        Me.GrpBoxDetalle.Controls.Add(Me.Button1)
        Me.GrpBoxDetalle.Controls.Add(Me.Table1)
        Me.GrpBoxDetalle.Controls.Add(Me.BtnAdd)
        Me.GrpBoxDetalle.Controls.Add(Me.BtnQuitar)
        Me.GrpBoxDetalle.Location = New System.Drawing.Point(14, 53)
        Me.GrpBoxDetalle.Name = "GrpBoxDetalle"
        Me.GrpBoxDetalle.Size = New System.Drawing.Size(944, 472)
        Me.GrpBoxDetalle.TabIndex = 134
        Me.GrpBoxDetalle.TabStop = False
        Me.GrpBoxDetalle.Text = "Aplica Precio Fijo y/o Porcentaje por Muestra"
        '
        'BtnQuitarTodo
        '
        Me.BtnQuitarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnQuitarTodo.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.BtnQuitarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitarTodo.Location = New System.Drawing.Point(819, 89)
        Me.BtnQuitarTodo.Name = "BtnQuitarTodo"
        Me.BtnQuitarTodo.Size = New System.Drawing.Size(110, 29)
        Me.BtnQuitarTodo.TabIndex = 142
        Me.BtnQuitarTodo.Text = "     Quitar Todas"
        Me.BtnQuitarTodo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.Integration.Test.My.Resources.Resources.Find_16x16
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(819, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 55)
        Me.Button1.TabIndex = 141
        Me.Button1.Text = "< Buscar por Código"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Table1
        '
        Me.Table1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Location = New System.Drawing.Point(6, 19)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(807, 447)
        Me.Table1.TabIndex = 140
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(819, 20)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 28)
        Me.BtnAdd.TabIndex = 134
        Me.BtnAdd.Text = "    Añadir [INS]"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnQuitar.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitar.Location = New System.Drawing.Point(819, 54)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(110, 29)
        Me.BtnQuitar.TabIndex = 135
        Me.BtnQuitar.Text = "     Quitar [SUPR]"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink3, Me.C1CommandLink1, Me.C1CommandLink4, Me.C1CommandLink6, Me.C1CommandLink5, Me.C1CommandLink2})
        Me.C1ToolBar1.Location = New System.Drawing.Point(3, 3)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(693, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdGuardar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdNuevo)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCancel)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdSubirArchivo)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExportExcel)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CmdGuardar
        '
        Me.C1CmdGuardar.Image = Global.Integration.Test.My.Resources.Resources.Save_16x16
        Me.C1CmdGuardar.Name = "C1CmdGuardar"
        Me.C1CmdGuardar.Text = "Aplicar Descuento"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "Cerrar (ESC)"
        '
        'C1CmdNuevo
        '
        Me.C1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.C1CmdNuevo.Name = "C1CmdNuevo"
        Me.C1CmdNuevo.Text = "Nuevo (F6)"
        '
        'C1CmdCancel
        '
        Me.C1CmdCancel.Image = Global.Integration.Test.My.Resources.Resources.Cancel_16x16
        Me.C1CmdCancel.Name = "C1CmdCancel"
        Me.C1CmdCancel.Text = "Cancelar"
        '
        'C1CmdSubirArchivo
        '
        Me.C1CmdSubirArchivo.Image = Global.Integration.Test.My.Resources.Resources.move_to_folder
        Me.C1CmdSubirArchivo.Name = "C1CmdSubirArchivo"
        Me.C1CmdSubirArchivo.Text = "Subir Archivo"
        '
        'C1CmdExportExcel
        '
        Me.C1CmdExportExcel.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExportExcel.Name = "C1CmdExportExcel"
        Me.C1CmdExportExcel.Text = "Exportar Excel (F8)"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdNuevo
        Me.C1CommandLink3.ToolTipText = "Nueva operación"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdGuardar
        Me.C1CommandLink1.SortOrder = 1
        Me.C1CommandLink1.Text = "Aplicar Descuento (F4)"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdCancel
        Me.C1CommandLink4.SortOrder = 2
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink6.Command = Me.C1CmdExportExcel
        Me.C1CommandLink6.SortOrder = 3
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.C1CmdSubirArchivo
        Me.C1CommandLink5.SortOrder = 4
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdCerrar
        Me.C1CommandLink2.SortOrder = 5
        '
        'Table2
        '
        Me.Table2.AllowUserToAddRows = False
        Me.Table2.AllowUserToDeleteRows = False
        Me.Table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCtaCteSerJerarquia, Me.nCtaCtePrecio, Me.nEstado})
        Me.Table2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table2.Location = New System.Drawing.Point(3, 98)
        Me.Table2.Name = "Table2"
        Me.Table2.ReadOnly = True
        Me.Table2.Size = New System.Drawing.Size(399, 391)
        Me.Table2.TabIndex = 141
        '
        'cCtaCteSerJerarquia
        '
        Me.cCtaCteSerJerarquia.DataPropertyName = "cCtaCteSerJerarquia"
        Me.cCtaCteSerJerarquia.HeaderText = "Código"
        Me.cCtaCteSerJerarquia.Name = "cCtaCteSerJerarquia"
        Me.cCtaCteSerJerarquia.ReadOnly = True
        '
        'nCtaCtePrecio
        '
        Me.nCtaCtePrecio.DataPropertyName = "nCtaCtePrecio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.nCtaCtePrecio.DefaultCellStyle = DataGridViewCellStyle1
        Me.nCtaCtePrecio.HeaderText = "Precio"
        Me.nCtaCtePrecio.Name = "nCtaCtePrecio"
        Me.nCtaCtePrecio.ReadOnly = True
        '
        'nEstado
        '
        Me.nEstado.DataPropertyName = "nEstado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.nEstado.DefaultCellStyle = DataGridViewCellStyle2
        Me.nEstado.HeaderText = "Estado"
        Me.nEstado.Name = "nEstado"
        Me.nEstado.ReadOnly = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1391, 759)
        Me.TableLayoutPanel1.TabIndex = 147
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1385, 33)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.dscto_32x32
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1385, 32)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "҉     Aplicar Descuento en Convenios por Entidad"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.C1ToolBar1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 42)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1385, 714)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1379, 678)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1373, 134)
        Me.TableLayoutPanel4.TabIndex = 147
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GrpBoxTodo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(794, 140)
        Me.Panel3.TabIndex = 0
        '
        'GrpBoxTodo
        '
        Me.GrpBoxTodo.Controls.Add(Me.BtnBuscarEmpresa)
        Me.GrpBoxTodo.Controls.Add(Me.Label2)
        Me.GrpBoxTodo.Controls.Add(Me.TxtPorc)
        Me.GrpBoxTodo.Controls.Add(Me.Label1)
        Me.GrpBoxTodo.Controls.Add(Me.Label10)
        Me.GrpBoxTodo.Controls.Add(Me.CboEmpresa)
        Me.GrpBoxTodo.Controls.Add(Me.CboTipoCta)
        Me.GrpBoxTodo.Controls.Add(Me.Label6)
        Me.GrpBoxTodo.Location = New System.Drawing.Point(8, 10)
        Me.GrpBoxTodo.Name = "GrpBoxTodo"
        Me.GrpBoxTodo.Size = New System.Drawing.Size(764, 118)
        Me.GrpBoxTodo.TabIndex = 35
        Me.GrpBoxTodo.TabStop = False
        Me.GrpBoxTodo.Text = "Aplica porcentaje a todos los Servicios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 29)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "%"
        '
        'TxtPorc
        '
        Me.TxtPorc.BackColor = System.Drawing.SystemColors.Info
        Me.TxtPorc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPorc.Location = New System.Drawing.Point(123, 73)
        Me.TxtPorc.Name = "TxtPorc"
        Me.TxtPorc.Size = New System.Drawing.Size(91, 35)
        Me.TxtPorc.TabIndex = 38
        Me.TxtPorc.Text = "0.00"
        Me.TxtPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Porcentaje"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Empresa"
        '
        'CboEmpresa
        '
        Me.CboEmpresa.BackColor = System.Drawing.SystemColors.Info
        Me.CboEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEmpresa.FormattingEnabled = True
        Me.CboEmpresa.Items.AddRange(New Object() {"BANCO DE CREDITO", "ALICOR SA"})
        Me.CboEmpresa.Location = New System.Drawing.Point(123, 46)
        Me.CboEmpresa.Name = "CboEmpresa"
        Me.CboEmpresa.Size = New System.Drawing.Size(607, 23)
        Me.CboEmpresa.TabIndex = 35
        '
        'CboTipoCta
        '
        Me.CboTipoCta.BackColor = System.Drawing.SystemColors.Info
        Me.CboTipoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoCta.FormattingEnabled = True
        Me.CboTipoCta.Location = New System.Drawing.Point(123, 20)
        Me.CboTipoCta.Name = "CboTipoCta"
        Me.CboTipoCta.Size = New System.Drawing.Size(221, 21)
        Me.CboTipoCta.TabIndex = 33
        Me.CboTipoCta.Tag = "nIntClase=1133;nIntTipo=1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Tipo Relación"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ChckAplicaSucursales)
        Me.Panel1.Controls.Add(Me.ChckBoxTodo)
        Me.Panel1.Controls.Add(Me.ChckCargaPlantilla)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(803, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(567, 140)
        Me.Panel1.TabIndex = 146
        '
        'ChckAplicaSucursales
        '
        Me.ChckAplicaSucursales.AutoSize = True
        Me.ChckAplicaSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChckAplicaSucursales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckAplicaSucursales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChckAplicaSucursales.Location = New System.Drawing.Point(29, 14)
        Me.ChckAplicaSucursales.Name = "ChckAplicaSucursales"
        Me.ChckAplicaSucursales.Size = New System.Drawing.Size(205, 24)
        Me.ChckAplicaSucursales.TabIndex = 139
        Me.ChckAplicaSucursales.Text = "Aplicar Todas Sucursales"
        Me.ChckAplicaSucursales.UseVisualStyleBackColor = True
        '
        'ChckBoxTodo
        '
        Me.ChckBoxTodo.AutoSize = True
        Me.ChckBoxTodo.Checked = True
        Me.ChckBoxTodo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChckBoxTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChckBoxTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckBoxTodo.ForeColor = System.Drawing.Color.Maroon
        Me.ChckBoxTodo.Location = New System.Drawing.Point(29, 84)
        Me.ChckBoxTodo.Name = "ChckBoxTodo"
        Me.ChckBoxTodo.Size = New System.Drawing.Size(127, 24)
        Me.ChckBoxTodo.TabIndex = 39
        Me.ChckBoxTodo.Text = "Aplicar a Todo"
        Me.ChckBoxTodo.UseVisualStyleBackColor = True
        '
        'ChckCargaPlantilla
        '
        Me.ChckCargaPlantilla.AutoSize = True
        Me.ChckCargaPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChckCargaPlantilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckCargaPlantilla.ForeColor = System.Drawing.Color.Blue
        Me.ChckCargaPlantilla.Location = New System.Drawing.Point(29, 49)
        Me.ChckCargaPlantilla.Name = "ChckCargaPlantilla"
        Me.ChckCargaPlantilla.Size = New System.Drawing.Size(132, 24)
        Me.ChckCargaPlantilla.TabIndex = 137
        Me.ChckCargaPlantilla.Text = "Cargar Plantilla"
        Me.ChckCargaPlantilla.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SplitContainer1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 143)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1373, 532)
        Me.Panel4.TabIndex = 148
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Size = New System.Drawing.Size(1373, 532)
        Me.SplitContainer1.SplitterDistance = 405
        Me.SplitContainer1.TabIndex = 149
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Table2, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel7, 0, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(405, 532)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txtRutaArchivo)
        Me.Panel5.Controls.Add(Me.BtnSeleccionarArchivo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(399, 89)
        Me.Panel5.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(399, 25)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "Subir Archivo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Seleccione archivo"
        '
        'txtRutaArchivo
        '
        Me.txtRutaArchivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRutaArchivo.Location = New System.Drawing.Point(8, 61)
        Me.txtRutaArchivo.Name = "txtRutaArchivo"
        Me.txtRutaArchivo.Size = New System.Drawing.Size(327, 21)
        Me.txtRutaArchivo.TabIndex = 143
        Me.txtRutaArchivo.Text = "F:\Aplicativos\SistemaMedica\Integration.System\Temp\Precios.txt"
        '
        'BtnSeleccionarArchivo
        '
        Me.BtnSeleccionarArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSeleccionarArchivo.Image = Global.Integration.Test.My.Resources.Resources.folder_explore
        Me.BtnSeleccionarArchivo.Location = New System.Drawing.Point(341, 56)
        Me.BtnSeleccionarArchivo.Name = "BtnSeleccionarArchivo"
        Me.BtnSeleccionarArchivo.Size = New System.Drawing.Size(35, 30)
        Me.BtnSeleccionarArchivo.TabIndex = 144
        Me.BtnSeleccionarArchivo.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.BtnSubeArchivo)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 495)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(399, 34)
        Me.Panel7.TabIndex = 142
        '
        'BtnSubeArchivo
        '
        Me.BtnSubeArchivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSubeArchivo.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnSubeArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSubeArchivo.Location = New System.Drawing.Point(97, 5)
        Me.BtnSubeArchivo.Name = "BtnSubeArchivo"
        Me.BtnSubeArchivo.Size = New System.Drawing.Size(166, 26)
        Me.BtnSubeArchivo.TabIndex = 143
        Me.BtnSubeArchivo.Text = "Aplicar cambios"
        Me.BtnSubeArchivo.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.GrpBoxDetalle)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(964, 532)
        Me.Panel6.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(964, 25)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Detalle de precios por Examen"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBuscarEmpresa
        '
        Me.BtnBuscarEmpresa.Image = Global.Integration.Test.My.Resources.Resources.Find_16x16
        Me.BtnBuscarEmpresa.Location = New System.Drawing.Point(733, 46)
        Me.BtnBuscarEmpresa.Name = "BtnBuscarEmpresa"
        Me.BtnBuscarEmpresa.Size = New System.Drawing.Size(25, 23)
        Me.BtnBuscarEmpresa.TabIndex = 41
        Me.BtnBuscarEmpresa.Tag = "Buscar Laboratorios/Convenios/etc."
        Me.BtnBuscarEmpresa.UseVisualStyleBackColor = True
        '
        'FormMaPorcDsctoEntidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1391, 759)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormMaPorcDsctoEntidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Porcentaje Descuento por Entidad"
        Me.GrpBoxDetalle.ResumeLayout(False)
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GrpBoxTodo.ResumeLayout(False)
        Me.GrpBoxTodo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBoxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CmdGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCancel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Table2 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSeleccionarArchivo As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GrpBoxTodo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPorc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents CboTipoCta As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChckAplicaSucursales As System.Windows.Forms.CheckBox
    Friend WithEvents ChckBoxTodo As System.Windows.Forms.CheckBox
    Friend WithEvents ChckCargaPlantilla As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtRutaArchivo As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents BtnSubeArchivo As System.Windows.Forms.Button
    Friend WithEvents cCtaCteSerJerarquia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCtePrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C1CmdSubirArchivo As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdExportExcel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents BtnQuitarTodo As System.Windows.Forms.Button
    Friend WithEvents BtnBuscarEmpresa As System.Windows.Forms.Button
End Class
