<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMarcacion
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
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtNroDocId = New System.Windows.Forms.TextBox()
        Me.CboTipoDocu = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TimerSegundo = New System.Windows.Forms.Timer(Me.components)
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.Label6.Size = New System.Drawing.Size(457, 33)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "҉     Marcación de Asistencias "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNroDocId)
        Me.GroupBox1.Controls.Add(Me.CboTipoDocu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 95)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'TxtNroDocId
        '
        Me.TxtNroDocId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNroDocId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroDocId.Location = New System.Drawing.Point(161, 53)
        Me.TxtNroDocId.MaxLength = 10
        Me.TxtNroDocId.Name = "TxtNroDocId"
        Me.TxtNroDocId.Size = New System.Drawing.Size(132, 23)
        Me.TxtNroDocId.TabIndex = 0
        Me.TxtNroDocId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboTipoDocu
        '
        Me.CboTipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDocu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoDocu.FormattingEnabled = True
        Me.CboTipoDocu.Location = New System.Drawing.Point(161, 18)
        Me.CboTipoDocu.Name = "CboTipoDocu"
        Me.CboTipoDocu.Size = New System.Drawing.Size(250, 24)
        Me.CboTipoDocu.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nº Doc. Id.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Documento:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Teal
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.icono_marcacion_32x32
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(299, 238)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(125, 30)
        Me.BtnCerrar.TabIndex = 24
        Me.BtnCerrar.Text = "&Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.Integration.Test.My.Resources.Resources.Save_16x16
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(145, 238)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(147, 30)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TimerSegundo
        '
        Me.TimerSegundo.Interval = 1000
        '
        'TimerHora
        '
        Me.TimerHora.Interval = 360000
        '
        'LblMsg
        '
        Me.LblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMsg.Location = New System.Drawing.Point(12, 280)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(428, 40)
        Me.LblMsg.TabIndex = 30
        Me.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblFecha)
        Me.Panel1.Controls.Add(Me.LblHora)
        Me.Panel1.Location = New System.Drawing.Point(15, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 91)
        Me.Panel1.TabIndex = 31
        '
        'LblFecha
        '
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblFecha.Location = New System.Drawing.Point(62, 14)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(304, 23)
        Me.LblFecha.TabIndex = 32
        Me.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblHora
        '
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblHora.Location = New System.Drawing.Point(62, 47)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(304, 30)
        Me.LblHora.TabIndex = 31
        Me.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormMarcacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 329)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMarcacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNroDocId As System.Windows.Forms.TextBox
    Friend WithEvents CboTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TimerSegundo As System.Windows.Forms.Timer
    Friend WithEvents TimerHora As System.Windows.Forms.Timer
    Friend WithEvents LblMsg As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblHora As System.Windows.Forms.Label
End Class
