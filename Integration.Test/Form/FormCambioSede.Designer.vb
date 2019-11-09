<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCambioSede
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
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
        Me.Label6.Size = New System.Drawing.Size(479, 28)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "҉     Cambio de Sede"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboEmpresa
        '
        Me.CboEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboEmpresa.FormattingEnabled = True
        Me.CboEmpresa.Location = New System.Drawing.Point(92, 67)
        Me.CboEmpresa.Name = "CboEmpresa"
        Me.CboEmpresa.Size = New System.Drawing.Size(354, 21)
        Me.CboEmpresa.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Sucursal:"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(108, 116)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(122, 30)
        Me.BtnAceptar.TabIndex = 25
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(249, 116)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(117, 30)
        Me.BtnCancel.TabIndex = 26
        Me.BtnCancel.Text = "&Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormCambioSede
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 167)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.CboEmpresa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCambioSede"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Sede"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
