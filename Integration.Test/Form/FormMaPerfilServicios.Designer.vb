<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaPerfilServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaPerfilServicios))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPrecioPromo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblTotalPago = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.cPerJurCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nIntCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteSerJerarquia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteSerKeyWord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nMonCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerImpDef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerUsuCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboPerfil = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdAgregar = New C1.Win.C1Command.C1Command()
        Me.C1CmdQuitar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CmdGrabar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCalcPrecio = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(817, 32)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "҉    Perfil por Servicios (Grupo por Muestras)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtPrecioPromo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.LblTotalPago)
        Me.GroupBox1.Controls.Add(Me.Table1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 371)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(29, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(514, 15)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Para calcular precio por Muestra ""Precio Promoción"" debe ser < Menor a ""Total Pre" & _
    "cio Perfil""."
        '
        'TxtPrecioPromo
        '
        Me.TxtPrecioPromo.Location = New System.Drawing.Point(155, 316)
        Me.TxtPrecioPromo.Name = "TxtPrecioPromo"
        Me.TxtPrecioPromo.Size = New System.Drawing.Size(100, 21)
        Me.TxtPrecioPromo.TabIndex = 137
        Me.TxtPrecioPromo.Text = "0.00"
        Me.TxtPrecioPromo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(44, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Precio Promoción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(452, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 15)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "Total Precio Perfil"
        '
        'LblTotalPago
        '
        Me.LblTotalPago.BackColor = System.Drawing.SystemColors.Info
        Me.LblTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPago.ForeColor = System.Drawing.Color.Black
        Me.LblTotalPago.Location = New System.Drawing.Point(561, 313)
        Me.LblTotalPago.Name = "LblTotalPago"
        Me.LblTotalPago.Size = New System.Drawing.Size(98, 27)
        Me.LblTotalPago.TabIndex = 135
        Me.LblTotalPago.Text = "0.00"
        Me.LblTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerJurCodigo, Me.nIntCodigo, Me.nCtaCteSerCodigo, Me.cCtaCteSerJerarquia, Me.cCtaCteSerKeyWord, Me.nMonCodigo, Me.nCtaCteSerImpDef, Me.cPerUsuCodigo})
        Me.Table1.Location = New System.Drawing.Point(6, 74)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(778, 236)
        Me.Table1.TabIndex = 133
        '
        'cPerJurCodigo
        '
        Me.cPerJurCodigo.DataPropertyName = "cPerJurCodigo"
        Me.cPerJurCodigo.HeaderText = "cPerJurCodigo"
        Me.cPerJurCodigo.Name = "cPerJurCodigo"
        Me.cPerJurCodigo.Visible = False
        Me.cPerJurCodigo.Width = 90
        '
        'nIntCodigo
        '
        Me.nIntCodigo.DataPropertyName = "nIntCodigo"
        Me.nIntCodigo.HeaderText = "nIntCodigo"
        Me.nIntCodigo.Name = "nIntCodigo"
        Me.nIntCodigo.Visible = False
        Me.nIntCodigo.Width = 20
        '
        'nCtaCteSerCodigo
        '
        Me.nCtaCteSerCodigo.DataPropertyName = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.HeaderText = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.Name = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.Visible = False
        Me.nCtaCteSerCodigo.Width = 30
        '
        'cCtaCteSerJerarquia
        '
        Me.cCtaCteSerJerarquia.DataPropertyName = "cCtaCteSerJerarquia"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cCtaCteSerJerarquia.DefaultCellStyle = DataGridViewCellStyle1
        Me.cCtaCteSerJerarquia.HeaderText = "Cod. Laboratorio"
        Me.cCtaCteSerJerarquia.Name = "cCtaCteSerJerarquia"
        Me.cCtaCteSerJerarquia.ReadOnly = True
        Me.cCtaCteSerJerarquia.Width = 120
        '
        'cCtaCteSerKeyWord
        '
        Me.cCtaCteSerKeyWord.DataPropertyName = "cCtaCteSerKeyWord"
        Me.cCtaCteSerKeyWord.HeaderText = "Descripción"
        Me.cCtaCteSerKeyWord.Name = "cCtaCteSerKeyWord"
        Me.cCtaCteSerKeyWord.ReadOnly = True
        Me.cCtaCteSerKeyWord.Width = 320
        '
        'nMonCodigo
        '
        Me.nMonCodigo.DataPropertyName = "nMonCodigo"
        Me.nMonCodigo.HeaderText = "nMonCodigo"
        Me.nMonCodigo.Name = "nMonCodigo"
        Me.nMonCodigo.Visible = False
        Me.nMonCodigo.Width = 20
        '
        'nCtaCteSerImpDef
        '
        Me.nCtaCteSerImpDef.DataPropertyName = "nCtaCteSerImpDef"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.nCtaCteSerImpDef.DefaultCellStyle = DataGridViewCellStyle2
        Me.nCtaCteSerImpDef.HeaderText = "Precio"
        Me.nCtaCteSerImpDef.Name = "nCtaCteSerImpDef"
        '
        'cPerUsuCodigo
        '
        Me.cPerUsuCodigo.HeaderText = "Usuario"
        Me.cPerUsuCodigo.Name = "cPerUsuCodigo"
        Me.cPerUsuCodigo.Width = 150
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboPerfil)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(778, 58)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'CboPerfil
        '
        Me.CboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPerfil.FormattingEnabled = True
        Me.CboPerfil.Location = New System.Drawing.Point(134, 23)
        Me.CboPerfil.Name = "CboPerfil"
        Me.CboPerfil.Size = New System.Drawing.Size(633, 23)
        Me.CboPerfil.TabIndex = 1
        Me.CboPerfil.Tag = "nIntClase=1060;nIntTipo=1000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecciones Perfil"
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink5, Me.C1CommandLink4, Me.C1CommandLink3})
        Me.C1ToolBar1.Location = New System.Drawing.Point(14, 36)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(577, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdAgregar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdQuitar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdGrabar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCalcPrecio)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CmdAgregar
        '
        Me.C1CmdAgregar.Image = Global.Integration.Test.My.Resources.Resources.InsertRows_16x16
        Me.C1CmdAgregar.Name = "C1CmdAgregar"
        Me.C1CmdAgregar.Text = "Agregar (F6)"
        '
        'C1CmdQuitar
        '
        Me.C1CmdQuitar.Image = Global.Integration.Test.My.Resources.Resources.DeleteSheetRows_16x16
        Me.C1CmdQuitar.Name = "C1CmdQuitar"
        Me.C1CmdQuitar.Text = "Quitar (SUPR)"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "Cerrar (ESC)"
        '
        'C1CmdGrabar
        '
        Me.C1CmdGrabar.Image = Global.Integration.Test.My.Resources.Resources.Save_16x16
        Me.C1CmdGrabar.Name = "C1CmdGrabar"
        Me.C1CmdGrabar.Text = "Guardar(F4)"
        '
        'C1CmdCalcPrecio
        '
        Me.C1CmdCalcPrecio.Image = Global.Integration.Test.My.Resources.Resources.money_add
        Me.C1CmdCalcPrecio.Name = "C1CmdCalcPrecio"
        Me.C1CmdCalcPrecio.Text = "Calcular Precio"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdAgregar
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdQuitar
        Me.C1CommandLink2.SortOrder = 1
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.C1CmdCalcPrecio
        Me.C1CommandLink5.SortOrder = 2
        Me.C1CommandLink5.Text = "Calcular Precio (F11)"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdGrabar
        Me.C1CommandLink4.SortOrder = 3
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdCerrar
        Me.C1CommandLink3.SortOrder = 4
        '
        'FormMaPerfilServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 449)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMaPerfilServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfil por Servicios (Grupo por Muestras)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CboPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents C1CmdAgregar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdQuitar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblTotalPago As System.Windows.Forms.Label
    Friend WithEvents C1CmdGrabar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Private WithEvents cPerJurCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nIntCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteSerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cCtaCteSerJerarquia As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cCtaCteSerKeyWord As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nMonCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteSerImpDef As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cPerUsuCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C1CmdCalcPrecio As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents TxtPrecioPromo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
