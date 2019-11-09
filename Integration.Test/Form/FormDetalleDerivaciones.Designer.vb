<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetalleDerivaciones
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
        Me.ChkMarcarPruebas = New System.Windows.Forms.CheckBox()
        Me.CboLabRef = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAddMedicoReg = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblnSolNumero = New System.Windows.Forms.Label()
        Me.LblPaciente = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LBPruebas = New System.Windows.Forms.ListBox()
        Me.TPruebas = New System.Windows.Forms.DataGridView()
        Me.nFlag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cPrueba = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPruebas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChkMarcarPruebas
        '
        Me.ChkMarcarPruebas.AutoSize = True
        Me.ChkMarcarPruebas.Location = New System.Drawing.Point(16, 58)
        Me.ChkMarcarPruebas.Name = "ChkMarcarPruebas"
        Me.ChkMarcarPruebas.Size = New System.Drawing.Size(115, 17)
        Me.ChkMarcarPruebas.TabIndex = 2
        Me.ChkMarcarPruebas.Text = "Marcar/Desmarcar"
        Me.ChkMarcarPruebas.UseVisualStyleBackColor = True
        '
        'CboLabRef
        '
        Me.CboLabRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLabRef.FormattingEnabled = True
        Me.CboLabRef.Location = New System.Drawing.Point(334, 56)
        Me.CboLabRef.Name = "CboLabRef"
        Me.CboLabRef.Size = New System.Drawing.Size(172, 21)
        Me.CboLabRef.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Referenciar a:"
        '
        'BtnAddMedicoReg
        '
        Me.BtnAddMedicoReg.Image = Global.Integration.Test.My.Resources.Resources.disk
        Me.BtnAddMedicoReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddMedicoReg.Location = New System.Drawing.Point(12, 458)
        Me.BtnAddMedicoReg.Name = "BtnAddMedicoReg"
        Me.BtnAddMedicoReg.Size = New System.Drawing.Size(106, 27)
        Me.BtnAddMedicoReg.TabIndex = 8
        Me.BtnAddMedicoReg.Text = "   &Guardar"
        Me.BtnAddMedicoReg.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Integration.Test.My.Resources.Resources.Cancel_16x16
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(124, 458)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(106, 27)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "   &Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 491)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(494, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'BtnQuitar
        '
        Me.BtnQuitar.ForeColor = System.Drawing.Color.Black
        Me.BtnQuitar.Image = Global.Integration.Test.My.Resources.Resources.money_delete
        Me.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitar.Location = New System.Drawing.Point(12, 647)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(142, 28)
        Me.BtnQuitar.TabIndex = 11
        Me.BtnQuitar.Text = "Quitar Item (SUPR)"
        Me.BtnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Observaciones:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 404)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(493, 48)
        Me.TextBox1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nº Ficha:"
        '
        'LblnSolNumero
        '
        Me.LblnSolNumero.Location = New System.Drawing.Point(79, 9)
        Me.LblnSolNumero.Name = "LblnSolNumero"
        Me.LblnSolNumero.Size = New System.Drawing.Size(119, 13)
        Me.LblnSolNumero.TabIndex = 15
        '
        'LblPaciente
        '
        Me.LblPaciente.Location = New System.Drawing.Point(79, 28)
        Me.LblPaciente.Name = "LblPaciente"
        Me.LblPaciente.Size = New System.Drawing.Size(330, 13)
        Me.LblPaciente.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Paciente:"
        '
        'BtnAdd
        '
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.Image = Global.Integration.Test.My.Resources.Resources.money_add
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(13, 224)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(114, 28)
        Me.BtnAdd.TabIndex = 18
        Me.BtnAdd.Text = "Agregar (INS)"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'LBPruebas
        '
        Me.LBPruebas.FormattingEnabled = True
        Me.LBPruebas.Location = New System.Drawing.Point(368, 160)
        Me.LBPruebas.Name = "LBPruebas"
        Me.LBPruebas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LBPruebas.Size = New System.Drawing.Size(138, 56)
        Me.LBPruebas.TabIndex = 19
        '
        'TPruebas
        '
        Me.TPruebas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TPruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TPruebas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nFlag, Me.cPrueba})
        Me.TPruebas.Location = New System.Drawing.Point(16, 83)
        Me.TPruebas.Name = "TPruebas"
        Me.TPruebas.Size = New System.Drawing.Size(490, 133)
        Me.TPruebas.TabIndex = 141
        '
        'nFlag
        '
        Me.nFlag.HeaderText = "?"
        Me.nFlag.Name = "nFlag"
        Me.nFlag.Width = 30
        '
        'cPrueba
        '
        Me.cPrueba.HeaderText = "Prueba"
        Me.cPrueba.Name = "cPrueba"
        Me.cPrueba.ReadOnly = True
        Me.cPrueba.Width = 350
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn1})
        Me.DataGridView2.Location = New System.Drawing.Point(16, 258)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(490, 116)
        Me.DataGridView2.TabIndex = 142
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "?"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Prueba"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 350
        '
        'FormDetalleDerivaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 707)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TPruebas)
        Me.Controls.Add(Me.LBPruebas)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.LblPaciente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblnSolNumero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnQuitar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAddMedicoReg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboLabRef)
        Me.Controls.Add(Me.ChkMarcarPruebas)
        Me.Name = "FormDetalleDerivaciones"
        Me.Text = "Detalle de Derivaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPruebas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkMarcarPruebas As System.Windows.Forms.CheckBox
    Friend WithEvents CboLabRef As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAddMedicoReg As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblnSolNumero As System.Windows.Forms.Label
    Friend WithEvents LblPaciente As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LBPruebas As System.Windows.Forms.ListBox
    Friend WithEvents TPruebas As System.Windows.Forms.DataGridView
    Friend WithEvents nFlag As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cPrueba As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
