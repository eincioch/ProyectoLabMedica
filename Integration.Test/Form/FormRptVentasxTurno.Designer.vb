<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptVentasxTurno
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
        Me.DtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.DtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboCaja = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnDetalle = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFecFin)
        Me.GroupBox1.Controls.Add(Me.DtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 71)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'DtpFecFin
        '
        Me.DtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFin.Location = New System.Drawing.Point(242, 29)
        Me.DtpFecFin.Name = "DtpFecFin"
        Me.DtpFecFin.Size = New System.Drawing.Size(106, 20)
        Me.DtpFecFin.TabIndex = 1
        '
        'DtpFecIni
        '
        Me.DtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecIni.Location = New System.Drawing.Point(84, 30)
        Me.DtpFecIni.Name = "DtpFecIni"
        Me.DtpFecIni.Size = New System.Drawing.Size(106, 20)
        Me.DtpFecIni.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Desc. Caja"
        Me.Label3.Visible = False
        '
        'CboCaja
        '
        Me.CboCaja.BackColor = System.Drawing.SystemColors.Info
        Me.CboCaja.FormattingEnabled = True
        Me.CboCaja.Location = New System.Drawing.Point(434, 145)
        Me.CboCaja.Name = "CboCaja"
        Me.CboCaja.Size = New System.Drawing.Size(129, 21)
        Me.CboCaja.TabIndex = 3
        Me.CboCaja.Tag = "1069"
        Me.CboCaja.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(419, 32)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "҉     Reporte Ventas por Turno"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(220, 138)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(91, 32)
        Me.BtnCerrar.TabIndex = 29
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnDetalle
        '
        Me.BtnDetalle.Image = Global.Integration.Test.My.Resources.Resources.printer
        Me.BtnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDetalle.Location = New System.Drawing.Point(64, 138)
        Me.BtnDetalle.Name = "BtnDetalle"
        Me.BtnDetalle.Size = New System.Drawing.Size(128, 32)
        Me.BtnDetalle.TabIndex = 26
        Me.BtnDetalle.Text = "Detallado"
        Me.BtnDetalle.UseVisualStyleBackColor = True
        '
        'FormRptVentasxTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 197)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CboCaja)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRptVentasxTurno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptVentasxTurno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnDetalle As System.Windows.Forms.Button
End Class
