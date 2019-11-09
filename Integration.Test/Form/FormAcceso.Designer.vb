<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAcceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAcceso))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_RNewPass = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cbo_User = New System.Windows.Forms.ComboBox()
        Me.BtnAccesar = New System.Windows.Forms.Button()
        Me.Txt_Pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_NewPass = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Txt_PassActual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LnkLbl_ChangePass = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 72)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Seleccione nombre de usuario y introduce la contraseña para tener acceso al siste" & _
    "ma. "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Repetir nueva contraseña:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Nueva contraseña:"
        '
        'Txt_RNewPass
        '
        Me.Txt_RNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_RNewPass.Location = New System.Drawing.Point(177, 95)
        Me.Txt_RNewPass.MaxLength = 15
        Me.Txt_RNewPass.Name = "Txt_RNewPass"
        Me.Txt_RNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_RNewPass.Size = New System.Drawing.Size(191, 20)
        Me.Txt_RNewPass.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cbo_User)
        Me.GroupBox2.Controls.Add(Me.BtnAccesar)
        Me.GroupBox2.Controls.Add(Me.Txt_Pass)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(147, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 127)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Login "
        '
        'Cbo_User
        '
        Me.Cbo_User.FormattingEnabled = True
        Me.Cbo_User.Location = New System.Drawing.Point(90, 25)
        Me.Cbo_User.Name = "Cbo_User"
        Me.Cbo_User.Size = New System.Drawing.Size(191, 23)
        Me.Cbo_User.TabIndex = 20
        '
        'BtnAccesar
        '
        Me.BtnAccesar.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnAccesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAccesar.Location = New System.Drawing.Point(157, 90)
        Me.BtnAccesar.Name = "BtnAccesar"
        Me.BtnAccesar.Size = New System.Drawing.Size(122, 30)
        Me.BtnAccesar.TabIndex = 6
        Me.BtnAccesar.Text = "&Accesar"
        Me.BtnAccesar.UseVisualStyleBackColor = True
        '
        'Txt_Pass
        '
        Me.Txt_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Pass.Location = New System.Drawing.Point(90, 57)
        Me.Txt_Pass.MaxLength = 20
        Me.Txt_Pass.Name = "Txt_Pass"
        Me.Txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Pass.Size = New System.Drawing.Size(191, 21)
        Me.Txt_Pass.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Usuario"
        '
        'Txt_NewPass
        '
        Me.Txt_NewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NewPass.Location = New System.Drawing.Point(177, 65)
        Me.Txt_NewPass.MaxLength = 15
        Me.Txt_NewPass.Name = "Txt_NewPass"
        Me.Txt_NewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_NewPass.Size = New System.Drawing.Size(191, 20)
        Me.Txt_NewPass.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnCancel)
        Me.GroupBox4.Controls.Add(Me.BtnAceptar)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Txt_RNewPass)
        Me.GroupBox4.Controls.Add(Me.Txt_NewPass)
        Me.GroupBox4.Controls.Add(Me.Txt_PassActual)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(71, 76)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(388, 160)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Cambiando contraseña: "
        Me.GroupBox4.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(252, 121)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(117, 30)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "&Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(122, 121)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(122, 30)
        Me.BtnAceptar.TabIndex = 12
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'Txt_PassActual
        '
        Me.Txt_PassActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PassActual.Location = New System.Drawing.Point(177, 22)
        Me.Txt_PassActual.MaxLength = 15
        Me.Txt_PassActual.Name = "Txt_PassActual"
        Me.Txt_PassActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_PassActual.Size = New System.Drawing.Size(191, 20)
        Me.Txt_PassActual.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Constraseña actual:"
        '
        'LnkLbl_ChangePass
        '
        Me.LnkLbl_ChangePass.AutoSize = True
        Me.LnkLbl_ChangePass.Location = New System.Drawing.Point(155, 202)
        Me.LnkLbl_ChangePass.Name = "LnkLbl_ChangePass"
        Me.LnkLbl_ChangePass.Size = New System.Drawing.Size(127, 15)
        Me.LnkLbl_ChangePass.TabIndex = 8
        Me.LnkLbl_ChangePass.TabStop = True
        Me.LnkLbl_ChangePass.Text = "Cambiar contraseña..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.BtnCerrar)
        Me.GroupBox3.Controls.Add(Me.LnkLbl_ChangePass)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(461, 239)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(324, 194)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(117, 30)
        Me.BtnCerrar.TabIndex = 9
        Me.BtnCerrar.Text = "&Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.candado
        Me.PictureBox1.Location = New System.Drawing.Point(19, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Control de acceso"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboEmpresa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 62)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'CboEmpresa
        '
        Me.CboEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboEmpresa.FormattingEnabled = True
        Me.CboEmpresa.Location = New System.Drawing.Point(93, 24)
        Me.CboEmpresa.Name = "CboEmpresa"
        Me.CboEmpresa.Size = New System.Drawing.Size(354, 23)
        Me.CboEmpresa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(486, 32)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "҉     Acceso al Sistema"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Integration.Test.My.Resources.Resources.medica_icon
        Me.PictureBox2.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'FormAcceso
        '
        Me.AcceptButton = Me.BtnAccesar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCerrar
        Me.ClientSize = New System.Drawing.Size(486, 350)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAcceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Acceso al Sistema - MEDICA"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_RNewPass As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_NewPass As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_PassActual As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LnkLbl_ChangePass As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnAccesar As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Cbo_User As System.Windows.Forms.ComboBox
    Friend WithEvents CboEmpresa As System.Windows.Forms.ComboBox
End Class
