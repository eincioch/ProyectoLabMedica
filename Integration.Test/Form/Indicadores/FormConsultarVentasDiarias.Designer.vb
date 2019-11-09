<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultarVentasDiarias
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
        Me.C1CmdMostrar = New C1.Win.C1Command.C1Command()
        Me.C1CmdExportExcel = New C1.Win.C1Command.C1Command()
        Me.C1CmdExportDet = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdCancelar = New C1.Win.C1Command.C1Command()
        Me.C1CmdGuardar = New C1.Win.C1Command.C1Command()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTPFecFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPFecIni = New System.Windows.Forms.DateTimePicker()
        Me.LblReportes = New System.Windows.Forms.Label()
        Me.cboReporte = New System.Windows.Forms.ComboBox()
        Me.CboAnno = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1CmdMostrar
        '
        Me.C1CmdMostrar.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.C1CmdMostrar.Name = "C1CmdMostrar"
        Me.C1CmdMostrar.Text = "&Mostrar (F5)"
        '
        'C1CmdExportExcel
        '
        Me.C1CmdExportExcel.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExportExcel.Name = "C1CmdExportExcel"
        Me.C1CmdExportExcel.Text = "&Exportar Resumen (F8)"
        '
        'C1CmdExportDet
        '
        Me.C1CmdExportDet.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExportDet.Name = "C1CmdExportDet"
        Me.C1CmdExportDet.Text = "Exportar Detalle"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "&Cerrar (ESC)"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdMostrar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExportExcel)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExportDet)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCancelar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdGuardar)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CmdCancelar
        '
        Me.C1CmdCancelar.Enabled = False
        Me.C1CmdCancelar.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.C1CmdCancelar.Name = "C1CmdCancelar"
        Me.C1CmdCancelar.Text = "&Cancelar (F8)"
        '
        'C1CmdGuardar
        '
        Me.C1CmdGuardar.Enabled = False
        Me.C1CmdGuardar.Image = Global.Integration.Test.My.Resources.Resources.disk
        Me.C1CmdGuardar.Name = "C1CmdGuardar"
        Me.C1CmdGuardar.Text = "Guardar (F4)"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox)
        Me.Panel1.Location = New System.Drawing.Point(3, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1144, 144)
        Me.Panel1.TabIndex = 143
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Label9)
        Me.GroupBox.Controls.Add(Me.Label10)
        Me.GroupBox.Controls.Add(Me.DTPFecFin)
        Me.GroupBox.Controls.Add(Me.DTPFecIni)
        Me.GroupBox.Controls.Add(Me.LblReportes)
        Me.GroupBox.Controls.Add(Me.cboReporte)
        Me.GroupBox.Controls.Add(Me.CboAnno)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.CboPeriodo)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(779, 123)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Filtros"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(198, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "hasta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Desde:"
        '
        'DTPFecFin
        '
        Me.DTPFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecFin.Location = New System.Drawing.Point(240, 48)
        Me.DTPFecFin.Name = "DTPFecFin"
        Me.DTPFecFin.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecFin.TabIndex = 9
        '
        'DTPFecIni
        '
        Me.DTPFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecIni.Location = New System.Drawing.Point(93, 48)
        Me.DTPFecIni.Name = "DTPFecIni"
        Me.DTPFecIni.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecIni.TabIndex = 10
        '
        'LblReportes
        '
        Me.LblReportes.AutoSize = True
        Me.LblReportes.Location = New System.Drawing.Point(46, 81)
        Me.LblReportes.Name = "LblReportes"
        Me.LblReportes.Size = New System.Drawing.Size(48, 13)
        Me.LblReportes.TabIndex = 8
        Me.LblReportes.Text = "Reporte:"
        '
        'cboReporte
        '
        Me.cboReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReporte.FormattingEnabled = True
        Me.cboReporte.Location = New System.Drawing.Point(102, 78)
        Me.cboReporte.Name = "cboReporte"
        Me.cboReporte.Size = New System.Drawing.Size(392, 21)
        Me.cboReporte.TabIndex = 7
        Me.cboReporte.Tag = "nIntClase=2803;nIntTipo=0"
        '
        'CboAnno
        '
        Me.CboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnno.FormattingEnabled = True
        Me.CboAnno.Location = New System.Drawing.Point(81, 16)
        Me.CboAnno.Name = "CboAnno"
        Me.CboAnno.Size = New System.Drawing.Size(116, 21)
        Me.CboAnno.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Año:"
        '
        'CboPeriodo
        '
        Me.CboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(271, 16)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(232, 21)
        Me.CboPeriodo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Periodo"
        '
        'C1ToolBar
        '
        Me.C1ToolBar.AccessibleName = "Tool Bar"
        Me.C1ToolBar.CommandHolder = Nothing
        Me.C1ToolBar.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CmdLinkCerrar})
        Me.C1ToolBar.Location = New System.Drawing.Point(3, 35)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(336, 24)
        Me.C1ToolBar.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdMostrar
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdExportExcel
        Me.C1CommandLink2.SortOrder = 1
        Me.C1CommandLink2.Text = "&Exportar a Excel (F8)"
        '
        'C1CmdLinkCerrar
        '
        Me.C1CmdLinkCerrar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCerrar.Command = Me.C1CmdCerrar
        Me.C1CmdLinkCerrar.SortOrder = 2
        Me.C1CmdLinkCerrar.Text = "&Cerrar (ESC)"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1145, 32)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "҉     Ventas Diarias"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Table1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.C1ToolBar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1151, 758)
        Me.TableLayoutPanel1.TabIndex = 140
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table1.Location = New System.Drawing.Point(3, 239)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(1145, 516)
        Me.Table1.TabIndex = 144
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1145, 24)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Detalle"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormConsultarVentasDiarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 758)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormConsultarVentasDiarias"
        Me.Text = "FormConsultarVentasDiarias"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents C1CmdCancelar As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents C1CmdMostrar As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdExportExcel As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdExportDet As C1.Win.C1Command.C1Command
    Friend WithEvents LblReportes As System.Windows.Forms.Label
    Friend WithEvents cboReporte As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DTPFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Private WithEvents Label6 As System.Windows.Forms.Label
End Class
