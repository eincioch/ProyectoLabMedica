<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultarDerivaciones
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdExportDet = New C1.Win.C1Command.C1Command()
        Me.C1CmdExportExcel = New C1.Win.C1Command.C1Command()
        Me.C1CmdMostrar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCancelar = New C1.Win.C1Command.C1Command()
        Me.C1CmdGuardar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.PnlRFechas = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RBtnAMOUNT = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTPFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPFecIni = New System.Windows.Forms.DateTimePicker()
        Me.RBtnQTY = New System.Windows.Forms.RadioButton()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Médico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promotor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.RBtnDia = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RBtnMes = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlRFechas.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1078, 24)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Resultado"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1CmdLinkCerrar
        '
        Me.C1CmdLinkCerrar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCerrar.Command = Me.C1CmdCerrar
        Me.C1CmdLinkCerrar.SortOrder = 2
        Me.C1CmdLinkCerrar.Text = "&Cerrar (ESC)"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "&Cerrar (ESC)"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExportDet)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExportExcel)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdMostrar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCancelar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdGuardar)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CmdExportDet
        '
        Me.C1CmdExportDet.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExportDet.Name = "C1CmdExportDet"
        Me.C1CmdExportDet.Text = "Exportar Detalle"
        '
        'C1CmdExportExcel
        '
        Me.C1CmdExportExcel.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExportExcel.Name = "C1CmdExportExcel"
        Me.C1CmdExportExcel.Text = "&Exportar (F8)"
        '
        'C1CmdMostrar
        '
        Me.C1CmdMostrar.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.C1CmdMostrar.Name = "C1CmdMostrar"
        Me.C1CmdMostrar.Text = "&Mostrar (F5)"
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
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdExportExcel
        Me.C1CommandLink2.SortOrder = 1
        '
        'PnlRFechas
        '
        Me.PnlRFechas.Controls.Add(Me.Label9)
        Me.PnlRFechas.Controls.Add(Me.RBtnAMOUNT)
        Me.PnlRFechas.Controls.Add(Me.Label10)
        Me.PnlRFechas.Controls.Add(Me.DTPFecFin)
        Me.PnlRFechas.Controls.Add(Me.Label4)
        Me.PnlRFechas.Controls.Add(Me.DTPFecIni)
        Me.PnlRFechas.Controls.Add(Me.RBtnQTY)
        Me.PnlRFechas.Location = New System.Drawing.Point(129, 45)
        Me.PnlRFechas.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlRFechas.Name = "PnlRFechas"
        Me.PnlRFechas.Size = New System.Drawing.Size(623, 33)
        Me.PnlRFechas.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(160, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "hasta:"
        '
        'RBtnAMOUNT
        '
        Me.RBtnAMOUNT.AutoSize = True
        Me.RBtnAMOUNT.Location = New System.Drawing.Point(494, 7)
        Me.RBtnAMOUNT.Name = "RBtnAMOUNT"
        Me.RBtnAMOUNT.Size = New System.Drawing.Size(103, 17)
        Me.RBtnAMOUNT.TabIndex = 7
        Me.RBtnAMOUNT.TabStop = True
        Me.RBtnAMOUNT.Text = "Importe (sin IGV)"
        Me.RBtnAMOUNT.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Desde:"
        '
        'DTPFecFin
        '
        Me.DTPFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecFin.Location = New System.Drawing.Point(202, 7)
        Me.DTPFecFin.Name = "DTPFecFin"
        Me.DTPFecFin.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecFin.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ver:"
        '
        'DTPFecIni
        '
        Me.DTPFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecIni.Location = New System.Drawing.Point(55, 7)
        Me.DTPFecIni.Name = "DTPFecIni"
        Me.DTPFecIni.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecIni.TabIndex = 4
        '
        'RBtnQTY
        '
        Me.RBtnQTY.AutoSize = True
        Me.RBtnQTY.Checked = True
        Me.RBtnQTY.Location = New System.Drawing.Point(362, 8)
        Me.RBtnQTY.Name = "RBtnQTY"
        Me.RBtnQTY.Size = New System.Drawing.Size(117, 17)
        Me.RBtnQTY.TabIndex = 7
        Me.RBtnQTY.TabStop = True
        Me.RBtnQTY.Text = "Cantidad Pacientes"
        Me.RBtnQTY.UseVisualStyleBackColor = True
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdMostrar
        '
        'C1ToolBar
        '
        Me.C1ToolBar.AccessibleName = "Tool Bar"
        Me.C1ToolBar.CommandHolder = Nothing
        Me.C1ToolBar.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CmdLinkCerrar})
        Me.C1ToolBar.Location = New System.Drawing.Point(3, 35)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(296, 24)
        Me.C1ToolBar.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.Médico, Me.Promotor})
        Me.Table1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table1.Location = New System.Drawing.Point(3, 207)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(1078, 197)
        Me.Table1.TabIndex = 144
        '
        'Código
        '
        Me.Código.DataPropertyName = "Código"
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.ReadOnly = True
        Me.Código.Width = 110
        '
        'Médico
        '
        Me.Médico.DataPropertyName = "Médico"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Médico.DefaultCellStyle = DataGridViewCellStyle3
        Me.Médico.HeaderText = "Médico"
        Me.Médico.Name = "Médico"
        Me.Médico.ReadOnly = True
        Me.Médico.Width = 250
        '
        'Promotor
        '
        Me.Promotor.DataPropertyName = "Promotor"
        Me.Promotor.HeaderText = "Promotor"
        Me.Promotor.Name = "Promotor"
        Me.Promotor.ReadOnly = True
        Me.Promotor.Width = 250
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1078, 32)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "҉     Derivaciones Médico por Promotor "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox)
        Me.Panel1.Location = New System.Drawing.Point(3, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1078, 111)
        Me.Panel1.TabIndex = 143
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.RBtnDia)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.RBtnMes)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.PnlRFechas)
        Me.GroupBox.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(781, 100)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = " Parametros "
        '
        'RBtnDia
        '
        Me.RBtnDia.AutoSize = True
        Me.RBtnDia.Location = New System.Drawing.Point(223, 23)
        Me.RBtnDia.Name = "RBtnDia"
        Me.RBtnDia.Size = New System.Drawing.Size(61, 17)
        Me.RBtnDia.TabIndex = 7
        Me.RBtnDia.TabStop = True
        Me.RBtnDia.Text = "por Día"
        Me.RBtnDia.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Agrupado por:"
        '
        'RBtnMes
        '
        Me.RBtnMes.AutoSize = True
        Me.RBtnMes.Checked = True
        Me.RBtnMes.Location = New System.Drawing.Point(140, 23)
        Me.RBtnMes.Name = "RBtnMes"
        Me.RBtnMes.Size = New System.Drawing.Size(63, 17)
        Me.RBtnMes.TabIndex = 7
        Me.RBtnMes.TabStop = True
        Me.RBtnMes.Text = "por Mes"
        Me.RBtnMes.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Filtro:"
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1084, 407)
        Me.TableLayoutPanel1.TabIndex = 140
        '
        'FormConsultarDerivaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 407)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormConsultarDerivaciones"
        Me.Text = "҉     Derivaciones Médico por Promotor "
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlRFechas.ResumeLayout(False)
        Me.PnlRFechas.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Private WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CmdExportDet As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdExportExcel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdMostrar As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdCancelar As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PnlRFechas As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DTPFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Código As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Médico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Promotor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RBtnAMOUNT As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RBtnQTY As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnDia As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RBtnMes As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
