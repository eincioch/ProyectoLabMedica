<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptIngresosLabConv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRptIngresosLabConv))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.GrpBx = New System.Windows.Forms.GroupBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPFecFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPFecIni = New System.Windows.Forms.DateTimePicker()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdExporExcel = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBx.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(551, 37)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "҉     Ingresos por Convenios con Laboratorio y Empresa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Table1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GrpBx, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.C1ToolBar1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 37)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.27273!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(551, 228)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table1.Location = New System.Drawing.Point(3, 90)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(545, 135)
        Me.Table1.TabIndex = 28
        '
        'GrpBx
        '
        Me.GrpBx.Controls.Add(Me.BtnMostrar)
        Me.GrpBx.Controls.Add(Me.Label1)
        Me.GrpBx.Controls.Add(Me.Label4)
        Me.GrpBx.Controls.Add(Me.DTPFecFin)
        Me.GrpBx.Controls.Add(Me.DTPFecIni)
        Me.GrpBx.Location = New System.Drawing.Point(3, 35)
        Me.GrpBx.Name = "GrpBx"
        Me.GrpBx.Size = New System.Drawing.Size(536, 49)
        Me.GrpBx.TabIndex = 26
        Me.GrpBx.TabStop = False
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Image = Global.Integration.Test.My.Resources.Resources.table_refresh
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(401, 11)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(104, 36)
        Me.BtnMostrar.TabIndex = 23
        Me.BtnMostrar.Text = "    &Mostrar..."
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Desde:"
        '
        'DTPFecFin
        '
        Me.DTPFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecFin.Location = New System.Drawing.Point(244, 20)
        Me.DTPFecFin.Name = "DTPFecFin"
        Me.DTPFecFin.Size = New System.Drawing.Size(116, 21)
        Me.DTPFecFin.TabIndex = 1
        '
        'DTPFecIni
        '
        Me.DTPFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecIni.Location = New System.Drawing.Point(71, 20)
        Me.DTPFecIni.Name = "DTPFecIni"
        Me.DTPFecIni.Size = New System.Drawing.Size(116, 21)
        Me.DTPFecIni.TabIndex = 1
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2})
        Me.C1ToolBar1.Location = New System.Drawing.Point(3, 3)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(193, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExporExcel)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CmdExporExcel
        '
        Me.C1CmdExporExcel.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExporExcel.Name = "C1CmdExporExcel"
        Me.C1CmdExporExcel.Text = "Exportar a Excel"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "Cerrar"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdExporExcel
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdCerrar
        Me.C1CommandLink2.SortOrder = 1
        '
        'FormRptIngresosLabConv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 265)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRptIngresosLabConv"
        Me.Text = "Ingresos por Convenios con Laboratorio y Empresa"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBx.ResumeLayout(False)
        Me.GrpBx.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GrpBx As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTPFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CmdExporExcel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
End Class
