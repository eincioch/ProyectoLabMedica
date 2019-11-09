<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfigReportsLIS
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnAplicar = New System.Windows.Forms.Button()
        Me.rbtResConLogo = New System.Windows.Forms.RadioButton()
        Me.rbtResSinLogo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(367, 37)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "҉     Configuración Reportes LIS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtResConLogo)
        Me.GroupBox1.Controls.Add(Me.rbtResSinLogo)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 101)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(214, 168)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(91, 27)
        Me.BtnCerrar.TabIndex = 25
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnAplicar
        '
        Me.BtnAplicar.Image = Global.Integration.Test.My.Resources.Resources.Save_16x16
        Me.BtnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAplicar.Location = New System.Drawing.Point(61, 168)
        Me.BtnAplicar.Name = "BtnAplicar"
        Me.BtnAplicar.Size = New System.Drawing.Size(147, 27)
        Me.BtnAplicar.TabIndex = 24
        Me.BtnAplicar.Text = "    Aplicar cambios"
        Me.BtnAplicar.UseVisualStyleBackColor = True
        '
        'rbtResConLogo
        '
        Me.rbtResConLogo.AutoSize = True
        Me.rbtResConLogo.Location = New System.Drawing.Point(86, 54)
        Me.rbtResConLogo.Name = "rbtResConLogo"
        Me.rbtResConLogo.Size = New System.Drawing.Size(179, 17)
        Me.rbtResConLogo.TabIndex = 3
        Me.rbtResConLogo.Text = "Informe de Resultados con Logo"
        Me.rbtResConLogo.UseVisualStyleBackColor = True
        '
        'rbtResSinLogo
        '
        Me.rbtResSinLogo.AutoSize = True
        Me.rbtResSinLogo.Checked = True
        Me.rbtResSinLogo.Location = New System.Drawing.Point(86, 30)
        Me.rbtResSinLogo.Name = "rbtResSinLogo"
        Me.rbtResSinLogo.Size = New System.Drawing.Size(174, 17)
        Me.rbtResSinLogo.TabIndex = 2
        Me.rbtResSinLogo.TabStop = True
        Me.rbtResSinLogo.Text = "Informe de Resultados sin Logo"
        Me.rbtResSinLogo.UseVisualStyleBackColor = True
        '
        'FormConfigReportsLIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 227)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnAplicar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormConfigReportsLIS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "҉     Configuración Reportes LIS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnAplicar As System.Windows.Forms.Button
    Friend WithEvents rbtResConLogo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtResSinLogo As System.Windows.Forms.RadioButton
End Class
