<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptVentaporFechaAtencion
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRptVentaporFechaAtencion))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdExportExcel = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CmdExportSaldo = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.GrpBx = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbocPerJurCodigo = New System.Windows.Forms.ComboBox()
        Me.CboFiltro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFecFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPFecIni = New System.Windows.Forms.DateTimePicker()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblImpSinIGV = New System.Windows.Forms.Label()
        Me.LblImpMedico = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Table2 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RbtVtaTipoAtencion = New System.Windows.Forms.RadioButton()
        Me.RbtDetVtaLabConv = New System.Windows.Forms.RadioButton()
        Me.RbtPendientes = New System.Windows.Forms.RadioButton()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBx.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5614!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.4386!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1301, 124)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1295, 28)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "҉     Reporte Consolidado de Ventas por Fecha de Atención"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 820.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.C1ToolBar1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GrpBx, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnMostrar, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1295, 88)
        Me.TableLayoutPanel3.TabIndex = 28
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.ButtonLookHorz = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1ToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink3, Me.C1CommandLink2})
        Me.C1ToolBar1.Location = New System.Drawing.Point(3, 3)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(353, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExportExcel)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExportSaldo)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CmdExportExcel
        '
        Me.C1CmdExportExcel.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExportExcel.Name = "C1CmdExportExcel"
        Me.C1CmdExportExcel.Text = "Exportar Ventas"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "Cerrar"
        '
        'C1CmdExportSaldo
        '
        Me.C1CmdExportSaldo.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExportSaldo.Name = "C1CmdExportSaldo"
        Me.C1CmdExportSaldo.Text = "Expotar Saldo"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdExportExcel
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.Command = Me.C1CmdExportSaldo
        Me.C1CommandLink3.SortOrder = 1
        Me.C1CommandLink3.Text = "Expotar Filtro Seleccionado"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.C1CmdCerrar
        Me.C1CommandLink2.SortOrder = 2
        '
        'GrpBx
        '
        Me.GrpBx.Controls.Add(Me.PictureBox1)
        Me.GrpBx.Controls.Add(Me.CbocPerJurCodigo)
        Me.GrpBx.Controls.Add(Me.CboFiltro)
        Me.GrpBx.Controls.Add(Me.Label3)
        Me.GrpBx.Controls.Add(Me.Label2)
        Me.GrpBx.Controls.Add(Me.Label1)
        Me.GrpBx.Controls.Add(Me.DTPFecFin)
        Me.GrpBx.Controls.Add(Me.DTPFecIni)
        Me.GrpBx.Location = New System.Drawing.Point(3, 31)
        Me.GrpBx.Name = "GrpBx"
        Me.GrpBx.Size = New System.Drawing.Size(783, 54)
        Me.GrpBx.TabIndex = 26
        Me.GrpBx.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.chart44
        Me.PictureBox1.Location = New System.Drawing.Point(3, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'CbocPerJurCodigo
        '
        Me.CbocPerJurCodigo.FormattingEnabled = True
        Me.CbocPerJurCodigo.Location = New System.Drawing.Point(196, 19)
        Me.CbocPerJurCodigo.Name = "CbocPerJurCodigo"
        Me.CbocPerJurCodigo.Size = New System.Drawing.Size(285, 21)
        Me.CbocPerJurCodigo.TabIndex = 5
        '
        'CboFiltro
        '
        Me.CboFiltro.AutoCompleteCustomSource.AddRange(New String() {"Médico", "Rango Fechas"})
        Me.CboFiltro.FormattingEnabled = True
        Me.CboFiltro.Items.AddRange(New Object() {"<TODOS>", "por Sucursal"})
        Me.CboFiltro.Location = New System.Drawing.Point(54, 19)
        Me.CboFiltro.Name = "CboFiltro"
        Me.CboFiltro.Size = New System.Drawing.Size(140, 21)
        Me.CboFiltro.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Filtro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(640, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(487, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde:"
        '
        'DTPFecFin
        '
        Me.DTPFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecFin.Location = New System.Drawing.Point(682, 21)
        Me.DTPFecFin.Name = "DTPFecFin"
        Me.DTPFecFin.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecFin.TabIndex = 1
        '
        'DTPFecIni
        '
        Me.DTPFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecIni.Location = New System.Drawing.Point(534, 21)
        Me.DTPFecIni.Name = "DTPFecIni"
        Me.DTPFecIni.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecIni.TabIndex = 1
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Image = Global.Integration.Test.My.Resources.Resources.table_refresh
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(823, 31)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(133, 36)
        Me.BtnMostrar.TabIndex = 28
        Me.BtnMostrar.Text = "    &Generar Reporte"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.SplitContainer1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 133)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.06195!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93805!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1301, 438)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 379)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1295, 56)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LblImpSinIGV)
        Me.Panel1.Controls.Add(Me.LblImpMedico)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1289, 50)
        Me.Panel1.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(681, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Sin IGV:"
        '
        'LblImpSinIGV
        '
        Me.LblImpSinIGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblImpSinIGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImpSinIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpSinIGV.ForeColor = System.Drawing.Color.White
        Me.LblImpSinIGV.Location = New System.Drawing.Point(756, 11)
        Me.LblImpSinIGV.Name = "LblImpSinIGV"
        Me.LblImpSinIGV.Size = New System.Drawing.Size(126, 25)
        Me.LblImpSinIGV.TabIndex = 123
        Me.LblImpSinIGV.Text = "0.00"
        Me.LblImpSinIGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblImpMedico
        '
        Me.LblImpMedico.BackColor = System.Drawing.SystemColors.Info
        Me.LblImpMedico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImpMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpMedico.ForeColor = System.Drawing.Color.Black
        Me.LblImpMedico.Location = New System.Drawing.Point(549, 11)
        Me.LblImpMedico.Name = "LblImpMedico"
        Me.LblImpMedico.Size = New System.Drawing.Size(126, 25)
        Me.LblImpMedico.TabIndex = 121
        Me.LblImpMedico.Text = "0.00"
        Me.LblImpMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(389, 13)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(154, 20)
        Me.Label33.TabIndex = 120
        Me.Label33.Text = "Importe Venta Total:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel7)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Chart1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1295, 370)
        Me.SplitContainer1.SplitterDistance = 732
        Me.SplitContainer1.TabIndex = 29
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.Table1, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.08791!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.91209!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(732, 370)
        Me.TableLayoutPanel7.TabIndex = 30
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table1.Location = New System.Drawing.Point(3, 3)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(814, 223)
        Me.Table1.TabIndex = 27
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Table2, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel9, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 232)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(814, 135)
        Me.TableLayoutPanel8.TabIndex = 28
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
        Me.Table2.Size = New System.Drawing.Size(808, 219)
        Me.Table2.TabIndex = 29
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 4
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.22293!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.77707!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.RbtVtaTipoAtencion, 2, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.RbtDetVtaLabConv, 3, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.RbtPendientes, 1, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(808, 24)
        Me.TableLayoutPanel9.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 24)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "-> Tipo de Filtro"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RbtVtaTipoAtencion
        '
        Me.RbtVtaTipoAtencion.AutoSize = True
        Me.RbtVtaTipoAtencion.Checked = True
        Me.RbtVtaTipoAtencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RbtVtaTipoAtencion.Location = New System.Drawing.Point(258, 3)
        Me.RbtVtaTipoAtencion.Name = "RbtVtaTipoAtencion"
        Me.RbtVtaTipoAtencion.Size = New System.Drawing.Size(163, 17)
        Me.RbtVtaTipoAtencion.TabIndex = 30
        Me.RbtVtaTipoAtencion.TabStop = True
        Me.RbtVtaTipoAtencion.Text = "Ver ventas por Tipo Atención"
        Me.RbtVtaTipoAtencion.UseVisualStyleBackColor = True
        '
        'RbtDetVtaLabConv
        '
        Me.RbtDetVtaLabConv.AutoSize = True
        Me.RbtDetVtaLabConv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RbtDetVtaLabConv.Location = New System.Drawing.Point(457, 3)
        Me.RbtDetVtaLabConv.Name = "RbtDetVtaLabConv"
        Me.RbtDetVtaLabConv.Size = New System.Drawing.Size(199, 17)
        Me.RbtDetVtaLabConv.TabIndex = 31
        Me.RbtDetVtaLabConv.Text = "Ver detalle ventas por Lab/Convenio"
        Me.RbtDetVtaLabConv.UseVisualStyleBackColor = True
        '
        'RbtPendientes
        '
        Me.RbtPendientes.AutoSize = True
        Me.RbtPendientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RbtPendientes.Location = New System.Drawing.Point(118, 3)
        Me.RbtPendientes.Name = "RbtPendientes"
        Me.RbtPendientes.Size = New System.Drawing.Size(131, 17)
        Me.RbtPendientes.TabIndex = 29
        Me.RbtPendientes.Text = "Ver detalle Pendientes"
        Me.RbtPendientes.UseVisualStyleBackColor = True
        Me.RbtPendientes.Visible = False
        '
        'Chart1
        '
        ChartArea1.Area3DStyle.Inclination = 50
        ChartArea1.Area3DStyle.IsRightAngleAxes = False
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.AutoFitMinFontSize = 10
        Legend1.Name = "Legend1"
        Legend1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.SmartLabelStyle.Enabled = False
        Series1.XValueMember = "cPerApellido"
        Series1.YValueMembers = "fCtaCteImporte"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(559, 370)
        Me.Chart1.TabIndex = 29
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Title1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Title1.Name = "Title1"
        Title1.Text = "Gráfico de Crecimiento por Sucursal"
        Title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Embed
        Me.Chart1.Titles.Add(Title1)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1307, 574)
        Me.TableLayoutPanel1.TabIndex = 126
        '
        'FormRptVentaporFechaAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1307, 574)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRptVentaporFechaAtencion"
        Me.Text = "     Reporte Consolidado de Ventas por Fecha de Atención"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBx.ResumeLayout(False)
        Me.GrpBx.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CmdExportExcel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdExportSaldo As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents GrpBx As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CbocPerJurCodigo As System.Windows.Forms.ComboBox
    Friend WithEvents CboFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblImpSinIGV As System.Windows.Forms.Label
    Friend WithEvents LblImpMedico As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Table2 As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RbtVtaTipoAtencion As System.Windows.Forms.RadioButton
    Friend WithEvents RbtDetVtaLabConv As System.Windows.Forms.RadioButton
    Friend WithEvents RbtPendientes As System.Windows.Forms.RadioButton
    Private WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
