<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTerceros
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtRUC = New System.Windows.Forms.TextBox()
        Me.RBTRUC = New System.Windows.Forms.RadioButton()
        Me.RBTDescripcion = New System.Windows.Forms.RadioButton()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtRUC)
        Me.GroupBox1.Controls.Add(Me.RBTRUC)
        Me.GroupBox1.Controls.Add(Me.RBTDescripcion)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Table1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 334)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Parámetros de búsqueda"
        '
        'TxtRUC
        '
        Me.TxtRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRUC.Location = New System.Drawing.Point(261, 66)
        Me.TxtRUC.MaxLength = 11
        Me.TxtRUC.Name = "TxtRUC"
        Me.TxtRUC.Size = New System.Drawing.Size(184, 24)
        Me.TxtRUC.TabIndex = 18
        '
        'RBTRUC
        '
        Me.RBTRUC.AutoSize = True
        Me.RBTRUC.Location = New System.Drawing.Point(36, 70)
        Me.RBTRUC.Name = "RBTRUC"
        Me.RBTRUC.Size = New System.Drawing.Size(51, 17)
        Me.RBTRUC.TabIndex = 17
        Me.RBTRUC.Text = "RUC"
        Me.RBTRUC.UseVisualStyleBackColor = True
        '
        'RBTDescripcion
        '
        Me.RBTDescripcion.AutoSize = True
        Me.RBTDescripcion.Checked = True
        Me.RBTDescripcion.Location = New System.Drawing.Point(36, 36)
        Me.RBTDescripcion.Name = "RBTDescripcion"
        Me.RBTDescripcion.Size = New System.Drawing.Size(208, 17)
        Me.RBTDescripcion.TabIndex = 16
        Me.RBTDescripcion.TabStop = True
        Me.RBTDescripcion.Text = "Razón Social/Nombre Comercial"
        Me.RBTDescripcion.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(261, 32)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(523, 24)
        Me.TxtDescripcion.TabIndex = 15
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Location = New System.Drawing.Point(19, 105)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(850, 210)
        Me.Table1.TabIndex = 9
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Integration.Test.My.Resources.Resources.cancel1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(723, 357)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(157, 45)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "        &Cancelar (ESC)"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Image = Global.Integration.Test.My.Resources.Resources.accept
        Me.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeleccionar.Location = New System.Drawing.Point(559, 357)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(157, 45)
        Me.BtnSeleccionar.TabIndex = 2
        Me.BtnSeleccionar.Text = "          &Seleccionar (INS)"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'FormTerceros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(909, 423)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTerceros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTerceros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents TxtRUC As System.Windows.Forms.TextBox
    Friend WithEvents RBTRUC As System.Windows.Forms.RadioButton
    Friend WithEvents RBTDescripcion As System.Windows.Forms.RadioButton
End Class
