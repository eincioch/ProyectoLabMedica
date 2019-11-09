<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionarPerOperacion
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
        Me.LblSubTitle = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblSubTitle
        '
        Me.LblSubTitle.AutoSize = True
        Me.LblSubTitle.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitle.ForeColor = System.Drawing.Color.White
        Me.LblSubTitle.Location = New System.Drawing.Point(129, 55)
        Me.LblSubTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSubTitle.Name = "LblSubTitle"
        Me.LblSubTitle.Size = New System.Drawing.Size(240, 33)
        Me.LblSubTitle.TabIndex = 0
        Me.LblSubTitle.Text = "Apertura de Sucursal"
        Me.LblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Integration.Test.My.Resources.Resources.Cancel_32x32
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(246, 254)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 73)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Image = Global.Integration.Test.My.Resources.Resources.accept
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAceptar.Location = New System.Drawing.Point(98, 254)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(140, 73)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "    &Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.BackColor = System.Drawing.Color.Teal
        Me.LblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(0, 0)
        Me.LblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(483, 39)
        Me.LblTitle.TabIndex = 42
        Me.LblTitle.Text = "҉    ?"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Observación:"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(42, 181)
        Me.TxtObservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(402, 56)
        Me.TxtObservacion.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(47, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Monto de Apertura:"
        '
        'TxtImporte
        '
        Me.TxtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImporte.Location = New System.Drawing.Point(195, 116)
        Me.TxtImporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(132, 29)
        Me.TxtImporte.TabIndex = 0
        Me.TxtImporte.Text = "0.00"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormGestionarPerOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(483, 353)
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.TxtObservacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblSubTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormGestionarPerOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar PerOperacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSubTitle As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Private WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
End Class
