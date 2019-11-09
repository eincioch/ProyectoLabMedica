<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptCuadreCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRptCuadreCaja))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboCaja = New System.Windows.Forms.ComboBox()
        Me.DtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.DtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDetalle = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnResumen = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.ChkIncluye = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label6.Size = New System.Drawing.Size(589, 32)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "҉     Reporte Cuadre de Caja"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CboCaja)
        Me.GroupBox1.Controls.Add(Me.DtpFecFin)
        Me.GroupBox1.Controls.Add(Me.DtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 71)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Desc. Caja"
        '
        'CboCaja
        '
        Me.CboCaja.BackColor = System.Drawing.SystemColors.Info
        Me.CboCaja.FormattingEnabled = True
        Me.CboCaja.Location = New System.Drawing.Point(93, 30)
        Me.CboCaja.Name = "CboCaja"
        Me.CboCaja.Size = New System.Drawing.Size(129, 23)
        Me.CboCaja.TabIndex = 3
        Me.CboCaja.Tag = "1069"
        '
        'DtpFecFin
        '
        Me.DtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFin.Location = New System.Drawing.Point(445, 30)
        Me.DtpFecFin.Name = "DtpFecFin"
        Me.DtpFecFin.Size = New System.Drawing.Size(106, 21)
        Me.DtpFecFin.TabIndex = 1
        '
        'DtpFecIni
        '
        Me.DtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecIni.Location = New System.Drawing.Point(287, 31)
        Me.DtpFecIni.Name = "DtpFecIni"
        Me.DtpFecIni.Size = New System.Drawing.Size(106, 21)
        Me.DtpFecIni.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(399, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'BtnDetalle
        '
        Me.BtnDetalle.Image = Global.Integration.Test.My.Resources.Resources.printer
        Me.BtnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDetalle.Location = New System.Drawing.Point(338, 112)
        Me.BtnDetalle.Name = "BtnDetalle"
        Me.BtnDetalle.Size = New System.Drawing.Size(128, 32)
        Me.BtnDetalle.TabIndex = 20
        Me.BtnDetalle.Text = "Detallado"
        Me.BtnDetalle.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.PrintArea_32x32
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'BtnResumen
        '
        Me.BtnResumen.Image = Global.Integration.Test.My.Resources.Resources.PrintArea_16x16
        Me.BtnResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResumen.Location = New System.Drawing.Point(368, 163)
        Me.BtnResumen.Name = "BtnResumen"
        Me.BtnResumen.Size = New System.Drawing.Size(112, 32)
        Me.BtnResumen.TabIndex = 20
        Me.BtnResumen.Text = "Resumido"
        Me.BtnResumen.UseVisualStyleBackColor = True
        Me.BtnResumen.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(472, 112)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(91, 32)
        Me.BtnCerrar.TabIndex = 22
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'ChkIncluye
        '
        Me.ChkIncluye.AutoSize = True
        Me.ChkIncluye.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChkIncluye.Location = New System.Drawing.Point(21, 125)
        Me.ChkIncluye.Name = "ChkIncluye"
        Me.ChkIncluye.Size = New System.Drawing.Size(133, 19)
        Me.ChkIncluye.TabIndex = 23
        Me.ChkIncluye.Text = "Incluir venta Credito"
        Me.ChkIncluye.UseVisualStyleBackColor = True
        Me.ChkIncluye.Visible = False
        '
        'FormRptCuadreCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 155)
        Me.Controls.Add(Me.ChkIncluye)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnDetalle)
        Me.Controls.Add(Me.BtnResumen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRptCuadreCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Cuadre de Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnResumen As System.Windows.Forms.Button
    Friend WithEvents BtnDetalle As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents ChkIncluye As System.Windows.Forms.CheckBox
End Class
