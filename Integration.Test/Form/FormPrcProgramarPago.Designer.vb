<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcProgramarPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcProgramarPago))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtImpAnticipo = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(295, 37)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "҉     Pago Anticipo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Importe"
        '
        'TxtImpAnticipo
        '
        Me.TxtImpAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpAnticipo.Location = New System.Drawing.Point(141, 57)
        Me.TxtImpAnticipo.Name = "TxtImpAnticipo"
        Me.TxtImpAnticipo.Size = New System.Drawing.Size(119, 29)
        Me.TxtImpAnticipo.TabIndex = 22
        Me.TxtImpAnticipo.Text = "0.0"
        Me.TxtImpAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(166, 108)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(117, 30)
        Me.BtnCancel.TabIndex = 24
        Me.BtnCancel.Text = "&Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(28, 108)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(122, 30)
        Me.BtnAceptar.TabIndex = 23
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FormPrcProgramarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 150)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtImpAnticipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrcProgramarPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programar Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtImpAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
End Class
