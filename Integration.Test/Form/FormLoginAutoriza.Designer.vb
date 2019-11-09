<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoginAutoriza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginAutoriza))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnKeyToken = New System.Windows.Forms.Button()
        Me.Cbo_User = New System.Windows.Forms.ComboBox()
        Me.BtnAccesar = New System.Windows.Forms.Button()
        Me.Txt_Pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 32)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "҉     Autorizar Descuento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnKeyToken)
        Me.GroupBox2.Controls.Add(Me.Cbo_User)
        Me.GroupBox2.Controls.Add(Me.BtnAccesar)
        Me.GroupBox2.Controls.Add(Me.Txt_Pass)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 127)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Login "
        '
        'BtnKeyToken
        '
        Me.BtnKeyToken.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnKeyToken.ForeColor = System.Drawing.Color.White
        Me.BtnKeyToken.Image = Global.Integration.Test.My.Resources.Resources.key_go
        Me.BtnKeyToken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeyToken.Location = New System.Drawing.Point(6, 90)
        Me.BtnKeyToken.Name = "BtnKeyToken"
        Me.BtnKeyToken.Size = New System.Drawing.Size(145, 30)
        Me.BtnKeyToken.TabIndex = 21
        Me.BtnKeyToken.Text = "     &Obtener Clave Token"
        Me.BtnKeyToken.UseVisualStyleBackColor = False
        '
        'Cbo_User
        '
        Me.Cbo_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.BtnAccesar.Text = "&Permitir"
        Me.BtnAccesar.UseVisualStyleBackColor = True
        '
        'Txt_Pass
        '
        Me.Txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(23, 177)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(117, 30)
        Me.BtnCancel.TabIndex = 21
        Me.BtnCancel.Text = "&Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormLoginAutoriza
        '
        Me.AcceptButton = Me.BtnAccesar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(342, 216)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLoginAutoriza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLoginAutoriza"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cbo_User As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAccesar As System.Windows.Forms.Button
    Friend WithEvents Txt_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnKeyToken As System.Windows.Forms.Button
End Class
