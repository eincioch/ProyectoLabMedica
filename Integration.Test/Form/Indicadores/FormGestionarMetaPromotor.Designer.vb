<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionarMetaPromotor
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
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdLinkNuevo = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdGuardar = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkCancel = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdCancelar = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.RBtnMedico = New System.Windows.Forms.RadioButton()
        Me.RBtnMedParticular = New System.Windows.Forms.RadioButton()
        Me.RBtnLaboratorio = New System.Windows.Forms.RadioButton()
        Me.CboAnno = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboGrupoIndicador = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboPromotor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1ToolBar
        '
        Me.C1ToolBar.AccessibleName = "Tool Bar"
        Me.C1ToolBar.CommandHolder = Nothing
        Me.C1ToolBar.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CmdLinkNuevo, Me.C1CommandLink1, Me.C1CmdLinkCancel, Me.C1CmdLinkCerrar})
        Me.C1ToolBar.Location = New System.Drawing.Point(3, 35)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(391, 24)
        Me.C1ToolBar.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdLinkNuevo
        '
        Me.C1CmdLinkNuevo.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkNuevo.Command = Me.C1CmdNuevo
        Me.C1CmdLinkNuevo.Text = "&Nuevo (F6)"
        '
        'C1CmdNuevo
        '
        Me.C1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.C1CmdNuevo.Name = "C1CmdNuevo"
        Me.C1CmdNuevo.Text = "&Nuevo (F6)"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdGuardar
        Me.C1CommandLink1.SortOrder = 1
        Me.C1CommandLink1.Text = "&Guardar (F4)"
        '
        'C1CmdGuardar
        '
        Me.C1CmdGuardar.Enabled = False
        Me.C1CmdGuardar.Image = Global.Integration.Test.My.Resources.Resources.disk
        Me.C1CmdGuardar.Name = "C1CmdGuardar"
        Me.C1CmdGuardar.Text = "Guardar (F4)"
        '
        'C1CmdLinkCancel
        '
        Me.C1CmdLinkCancel.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCancel.Command = Me.C1CmdCancelar
        Me.C1CmdLinkCancel.SortOrder = 2
        Me.C1CmdLinkCancel.Text = "&Cancelar"
        '
        'C1CmdCancelar
        '
        Me.C1CmdCancelar.Enabled = False
        Me.C1CmdCancelar.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.C1CmdCancelar.Name = "C1CmdCancelar"
        Me.C1CmdCancelar.Text = "&Cancelar (F8)"
        '
        'C1CmdLinkCerrar
        '
        Me.C1CmdLinkCerrar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCerrar.Command = Me.C1CmdCerrar
        Me.C1CmdLinkCerrar.SortOrder = 3
        Me.C1CmdLinkCerrar.Text = "&Cerrar (ESC)"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "&Cerrar (ESC)"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.C1ToolBar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Table1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1140, 456)
        Me.TableLayoutPanel1.TabIndex = 138
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1134, 24)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "- Vista / Ingreso de datos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1134, 32)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "҉     Gestionar Indicadores de Ventas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Table1
        '
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table1.Enabled = False
        Me.Table1.Location = New System.Drawing.Point(3, 239)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(1134, 214)
        Me.Table1.TabIndex = 144
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 144)
        Me.Panel1.TabIndex = 143
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Panel7)
        Me.GroupBox.Controls.Add(Me.CboAnno)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.CboPeriodo)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.CboGrupoIndicador)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.CboPromotor)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Enabled = False
        Me.GroupBox.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(1110, 136)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = " Datos Indicador"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.RBtnMedico)
        Me.Panel7.Controls.Add(Me.RBtnMedParticular)
        Me.Panel7.Controls.Add(Me.RBtnLaboratorio)
        Me.Panel7.Location = New System.Drawing.Point(538, 20)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(559, 36)
        Me.Panel7.TabIndex = 6
        Me.Panel7.Visible = False
        '
        'RBtnMedico
        '
        Me.RBtnMedico.AutoSize = True
        Me.RBtnMedico.Checked = True
        Me.RBtnMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnMedico.Location = New System.Drawing.Point(59, 8)
        Me.RBtnMedico.Name = "RBtnMedico"
        Me.RBtnMedico.Size = New System.Drawing.Size(94, 20)
        Me.RBtnMedico.TabIndex = 0
        Me.RBtnMedico.TabStop = True
        Me.RBtnMedico.Text = "por &Médico"
        Me.RBtnMedico.UseVisualStyleBackColor = True
        '
        'RBtnMedParticular
        '
        Me.RBtnMedParticular.AutoSize = True
        Me.RBtnMedParticular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnMedParticular.Location = New System.Drawing.Point(367, 8)
        Me.RBtnMedParticular.Name = "RBtnMedParticular"
        Me.RBtnMedParticular.Size = New System.Drawing.Size(138, 20)
        Me.RBtnMedParticular.TabIndex = 1
        Me.RBtnMedParticular.TabStop = True
        Me.RBtnMedParticular.Text = "Médica (Particular)"
        Me.RBtnMedParticular.UseVisualStyleBackColor = True
        '
        'RBtnLaboratorio
        '
        Me.RBtnLaboratorio.AutoSize = True
        Me.RBtnLaboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnLaboratorio.Location = New System.Drawing.Point(202, 8)
        Me.RBtnLaboratorio.Name = "RBtnLaboratorio"
        Me.RBtnLaboratorio.Size = New System.Drawing.Size(118, 20)
        Me.RBtnLaboratorio.TabIndex = 1
        Me.RBtnLaboratorio.TabStop = True
        Me.RBtnLaboratorio.Text = "por &Laboratorio"
        Me.RBtnLaboratorio.UseVisualStyleBackColor = True
        '
        'CboAnno
        '
        Me.CboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnno.FormattingEnabled = True
        Me.CboAnno.Location = New System.Drawing.Point(108, 94)
        Me.CboAnno.Name = "CboAnno"
        Me.CboAnno.Size = New System.Drawing.Size(116, 23)
        Me.CboAnno.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Año:"
        '
        'CboPeriodo
        '
        Me.CboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(298, 94)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(232, 23)
        Me.CboPeriodo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(242, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Periodo"
        '
        'CboGrupoIndicador
        '
        Me.CboGrupoIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGrupoIndicador.FormattingEnabled = True
        Me.CboGrupoIndicador.Location = New System.Drawing.Point(108, 28)
        Me.CboGrupoIndicador.Name = "CboGrupoIndicador"
        Me.CboGrupoIndicador.Size = New System.Drawing.Size(422, 23)
        Me.CboGrupoIndicador.TabIndex = 1
        Me.CboGrupoIndicador.Tag = "nIntClase=1134;nIntTipo=1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tipo Indicador"
        '
        'CboPromotor
        '
        Me.CboPromotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPromotor.FormattingEnabled = True
        Me.CboPromotor.Location = New System.Drawing.Point(108, 62)
        Me.CboPromotor.Name = "CboPromotor"
        Me.CboPromotor.Size = New System.Drawing.Size(422, 23)
        Me.CboPromotor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Promotor"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdGuardar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdNuevo)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCancelar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Owner = Me
        '
        'FormGestionarMetaPromotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 456)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "FormGestionarMetaPromotor"
        Me.Text = "Gestionar Indicadores de Ventas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdLinkNuevo As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCancel As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents C1CmdGuardar As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdNuevo As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdCancelar As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents RBtnMedico As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnLaboratorio As System.Windows.Forms.RadioButton
    Friend WithEvents CboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboPromotor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents RBtnMedParticular As System.Windows.Forms.RadioButton
    Friend WithEvents CboGrupoIndicador As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
End Class
