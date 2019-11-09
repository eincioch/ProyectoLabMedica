<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultRUCSUNATv2
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
        Me.txtCapcha = New System.Windows.Forms.TextBox()
        Me.txtNumDni = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.pictureCapcha = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureCapcha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCapcha
        '
        Me.txtCapcha.Location = New System.Drawing.Point(123, 34)
        Me.txtCapcha.Name = "txtCapcha"
        Me.txtCapcha.Size = New System.Drawing.Size(192, 20)
        Me.txtCapcha.TabIndex = 30
        '
        'txtNumDni
        '
        Me.txtNumDni.Location = New System.Drawing.Point(123, 12)
        Me.txtNumDni.Name = "txtNumDni"
        Me.txtNumDni.Size = New System.Drawing.Size(192, 20)
        Me.txtNumDni.TabIndex = 31
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(18, 37)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(83, 13)
        Me.label3.TabIndex = 28
        Me.label3.Text = "Codigo Captcha"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(18, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(30, 13)
        Me.label2.TabIndex = 29
        Me.label2.Text = "RUC"
        '
        'txtRazon
        '
        Me.txtRazon.Location = New System.Drawing.Point(15, 124)
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(455, 20)
        Me.txtRazon.TabIndex = 25
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(15, 167)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(455, 20)
        Me.txtRuc.TabIndex = 26
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(15, 206)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(455, 20)
        Me.txtDireccion.TabIndex = 27
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(15, 108)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(70, 13)
        Me.label5.TabIndex = 22
        Me.label5.Text = "Razon Social"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(15, 151)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(30, 13)
        Me.label4.TabIndex = 23
        Me.label4.Text = "RUC"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 190)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 13)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Direccion"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(318, 64)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(152, 33)
        Me.btnActualizar.TabIndex = 20
        Me.btnActualizar.Text = "Actualizar Captcha"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(12, 64)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(300, 33)
        Me.btnConsultar.TabIndex = 21
        Me.btnConsultar.Text = "Realizar Consulta"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'pictureCapcha
        '
        Me.pictureCapcha.Location = New System.Drawing.Point(321, 12)
        Me.pictureCapcha.Name = "pictureCapcha"
        Me.pictureCapcha.Size = New System.Drawing.Size(152, 46)
        Me.pictureCapcha.TabIndex = 19
        Me.pictureCapcha.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.Sunat_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(479, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'ConsultRUCSUNATv2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 249)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtCapcha)
        Me.Controls.Add(Me.txtNumDni)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtRazon)
        Me.Controls.Add(Me.txtRuc)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.pictureCapcha)
        Me.Name = "ConsultRUCSUNATv2"
        Me.Text = "ConsultRUCSUNATv2"
        CType(Me.pictureCapcha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtCapcha As System.Windows.Forms.TextBox
    Private WithEvents txtNumDni As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtRazon As System.Windows.Forms.TextBox
    Private WithEvents txtRuc As System.Windows.Forms.TextBox
    Private WithEvents txtDireccion As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnActualizar As System.Windows.Forms.Button
    Private WithEvents btnConsultar As System.Windows.Forms.Button
    Private WithEvents pictureCapcha As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
