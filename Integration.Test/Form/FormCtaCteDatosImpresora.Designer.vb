<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCtaCteDatosImpresora
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCtaCteDatosImpresora))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GrpBxKey = New System.Windows.Forms.GroupBox()
        Me.CboPortPrint = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCodSunat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNombPrint = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtSerial = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboCaja = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.cPerJurCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCajCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombreImpresora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodAutSUNAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdHolderPrint = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdGuardar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCancelar = New C1.Win.C1Command.C1Command()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.GrpBxKey.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CmdHolderPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Teal
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(619, 28)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "҉    Datos Impresora Ticketera"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpBxKey
        '
        Me.GrpBxKey.Controls.Add(Me.CboPortPrint)
        Me.GrpBxKey.Controls.Add(Me.Label11)
        Me.GrpBxKey.Controls.Add(Me.TxtCodSunat)
        Me.GrpBxKey.Controls.Add(Me.Label10)
        Me.GrpBxKey.Controls.Add(Me.TxtNombPrint)
        Me.GrpBxKey.Controls.Add(Me.Label9)
        Me.GrpBxKey.Controls.Add(Me.TxtSerial)
        Me.GrpBxKey.Controls.Add(Me.Label8)
        Me.GrpBxKey.Controls.Add(Me.Label1)
        Me.GrpBxKey.Controls.Add(Me.CboCaja)
        Me.GrpBxKey.Location = New System.Drawing.Point(12, 61)
        Me.GrpBxKey.Name = "GrpBxKey"
        Me.GrpBxKey.Size = New System.Drawing.Size(595, 101)
        Me.GrpBxKey.TabIndex = 20
        Me.GrpBxKey.TabStop = False
        '
        'CboPortPrint
        '
        Me.CboPortPrint.FormattingEnabled = True
        Me.CboPortPrint.Location = New System.Drawing.Point(381, 66)
        Me.CboPortPrint.Name = "CboPortPrint"
        Me.CboPortPrint.Size = New System.Drawing.Size(204, 21)
        Me.CboPortPrint.TabIndex = 4
        Me.CboPortPrint.Tag = "1036"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(349, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Port"
        '
        'TxtCodSunat
        '
        Me.TxtCodSunat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodSunat.Location = New System.Drawing.Point(128, 67)
        Me.TxtCodSunat.MaxLength = 15
        Me.TxtCodSunat.Name = "TxtCodSunat"
        Me.TxtCodSunat.Size = New System.Drawing.Size(129, 20)
        Me.TxtCodSunat.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Cod. Autoriza SUNAT"
        '
        'TxtNombPrint
        '
        Me.TxtNombPrint.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombPrint.Location = New System.Drawing.Point(381, 41)
        Me.TxtNombPrint.MaxLength = 100
        Me.TxtNombPrint.Name = "TxtNombPrint"
        Me.TxtNombPrint.Size = New System.Drawing.Size(204, 20)
        Me.TxtNombPrint.TabIndex = 2
        Me.TxtNombPrint.Text = "STAR SP700 CUTTER (SP742)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(282, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Nombre Impresora"
        '
        'TxtSerial
        '
        Me.TxtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSerial.Location = New System.Drawing.Point(128, 41)
        Me.TxtSerial.MaxLength = 30
        Me.TxtSerial.Name = "TxtSerial"
        Me.TxtSerial.Size = New System.Drawing.Size(129, 20)
        Me.TxtSerial.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Nro. Serie equipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desc. Caja"
        '
        'CboCaja
        '
        Me.CboCaja.BackColor = System.Drawing.SystemColors.Info
        Me.CboCaja.FormattingEnabled = True
        Me.CboCaja.Location = New System.Drawing.Point(128, 14)
        Me.CboCaja.Name = "CboCaja"
        Me.CboCaja.Size = New System.Drawing.Size(129, 21)
        Me.CboCaja.TabIndex = 0
        Me.CboCaja.Tag = "1069"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.STAR_SP700R
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerJurCodigo, Me.Empresa, Me.nCajCodigo, Me.Caja, Me.cSerie, Me.cNombreImpresora, Me.cPort, Me.cCodAutSUNAT})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle9
        Me.Table1.Location = New System.Drawing.Point(12, 168)
        Me.Table1.Name = "Table1"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Table1.Size = New System.Drawing.Size(595, 138)
        Me.Table1.TabIndex = 25
        '
        'cPerJurCodigo
        '
        Me.cPerJurCodigo.DataPropertyName = "cPerJurCodigo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cPerJurCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.cPerJurCodigo.HeaderText = "cPerJurCodigo"
        Me.cPerJurCodigo.Name = "cPerJurCodigo"
        Me.cPerJurCodigo.ReadOnly = True
        Me.cPerJurCodigo.Visible = False
        Me.cPerJurCodigo.Width = 60
        '
        'Empresa
        '
        Me.Empresa.DataPropertyName = "Empresa"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Empresa.DefaultCellStyle = DataGridViewCellStyle3
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Width = 130
        '
        'nCajCodigo
        '
        Me.nCajCodigo.DataPropertyName = "nCajCodigo"
        Me.nCajCodigo.HeaderText = "nCajCodigo"
        Me.nCajCodigo.Name = "nCajCodigo"
        Me.nCajCodigo.ReadOnly = True
        Me.nCajCodigo.Visible = False
        '
        'Caja
        '
        Me.Caja.DataPropertyName = "Caja"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Caja.DefaultCellStyle = DataGridViewCellStyle4
        Me.Caja.HeaderText = "Caja Nro."
        Me.Caja.Name = "Caja"
        Me.Caja.Width = 60
        '
        'cSerie
        '
        Me.cSerie.DataPropertyName = "cSerie"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cSerie.DefaultCellStyle = DataGridViewCellStyle5
        Me.cSerie.HeaderText = "Serie Equipo"
        Me.cSerie.Name = "cSerie"
        Me.cSerie.ReadOnly = True
        Me.cSerie.Width = 90
        '
        'cNombreImpresora
        '
        Me.cNombreImpresora.DataPropertyName = "cNombreImpresora"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.cNombreImpresora.DefaultCellStyle = DataGridViewCellStyle6
        Me.cNombreImpresora.HeaderText = "Nombre Impresora"
        Me.cNombreImpresora.Name = "cNombreImpresora"
        Me.cNombreImpresora.Width = 170
        '
        'cPort
        '
        Me.cPort.DataPropertyName = "cPort"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cPort.DefaultCellStyle = DataGridViewCellStyle7
        Me.cPort.HeaderText = "Port"
        Me.cPort.Name = "cPort"
        Me.cPort.Width = 70
        '
        'cCodAutSUNAT
        '
        Me.cCodAutSUNAT.DataPropertyName = "cCodAutSUNAT"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cCodAutSUNAT.DefaultCellStyle = DataGridViewCellStyle8
        Me.cCodAutSUNAT.HeaderText = "Cod. Autorización SUNAT"
        Me.cCodAutSUNAT.Name = "cCodAutSUNAT"
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CmdHolderPrint
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink4, Me.C1CommandLink5})
        Me.C1ToolBar1.Location = New System.Drawing.Point(42, 32)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(472, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdHolderPrint
        '
        Me.C1CmdHolderPrint.Commands.Add(Me.C1CmdNuevo)
        Me.C1CmdHolderPrint.Commands.Add(Me.C1CmdGuardar)
        Me.C1CmdHolderPrint.Commands.Add(Me.C1CmdCancelar)
        Me.C1CmdHolderPrint.Commands.Add(Me.C1CmdEdit)
        Me.C1CmdHolderPrint.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmdHolderPrint.Owner = Me
        '
        'C1CmdNuevo
        '
        Me.C1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.C1CmdNuevo.Name = "C1CmdNuevo"
        Me.C1CmdNuevo.Text = "Nuevo (F6)"
        '
        'C1CmdGuardar
        '
        Me.C1CmdGuardar.Image = Global.Integration.Test.My.Resources.Resources.Save_16x16
        Me.C1CmdGuardar.Name = "C1CmdGuardar"
        Me.C1CmdGuardar.Text = "Guardar (F4)"
        '
        'C1CmdCancelar
        '
        Me.C1CmdCancelar.Image = Global.Integration.Test.My.Resources.Resources.Cancel_16x16
        Me.C1CmdCancelar.Name = "C1CmdCancelar"
        Me.C1CmdCancelar.Text = "Cancelar"
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
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdNuevo
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdGuardar
        Me.C1CommandLink2.SortOrder = 1
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdCancelar
        Me.C1CommandLink3.SortOrder = 2
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdEdit
        Me.C1CommandLink4.SortOrder = 3
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.C1CmdCerrar
        Me.C1CommandLink5.SortOrder = 4
        '
        'FormCtaCteDatosImpresora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 318)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GrpBxKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormCtaCteDatosImpresora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCtaCteDatosImpresora"
        Me.GrpBxKey.ResumeLayout(False)
        Me.GrpBxKey.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CmdHolderPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GrpBxKey As System.Windows.Forms.GroupBox
    Friend WithEvents CboPortPrint As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtCodSunat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNombPrint As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdHolderPrint As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Private WithEvents cPerJurCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCajCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Caja As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cSerie As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cNombreImpresora As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cPort As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cCodAutSUNAT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
