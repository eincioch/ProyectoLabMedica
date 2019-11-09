<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUbigeo
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
        Me.CboDst = New System.Windows.Forms.ComboBox()
        Me.CboPrv = New System.Windows.Forms.ComboBox()
        Me.CboDpto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSelecciona = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboDst)
        Me.GroupBox1.Controls.Add(Me.CboPrv)
        Me.GroupBox1.Controls.Add(Me.CboDpto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CboDst
        '
        Me.CboDst.FormattingEnabled = True
        Me.CboDst.Location = New System.Drawing.Point(110, 84)
        Me.CboDst.Name = "CboDst"
        Me.CboDst.Size = New System.Drawing.Size(254, 23)
        Me.CboDst.TabIndex = 2
        '
        'CboPrv
        '
        Me.CboPrv.FormattingEnabled = True
        Me.CboPrv.Location = New System.Drawing.Point(110, 53)
        Me.CboPrv.Name = "CboPrv"
        Me.CboPrv.Size = New System.Drawing.Size(254, 23)
        Me.CboPrv.TabIndex = 1
        '
        'CboDpto
        '
        Me.CboDpto.FormattingEnabled = True
        Me.CboDpto.Location = New System.Drawing.Point(110, 22)
        Me.CboDpto.Name = "CboDpto"
        Me.CboDpto.Size = New System.Drawing.Size(254, 23)
        Me.CboDpto.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Distrito:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Provincia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departamento:"
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources._16_em_cross
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(288, 161)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 31)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSelecciona
        '
        Me.BtnSelecciona.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnSelecciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSelecciona.Location = New System.Drawing.Point(174, 161)
        Me.BtnSelecciona.Name = "BtnSelecciona"
        Me.BtnSelecciona.Size = New System.Drawing.Size(113, 31)
        Me.BtnSelecciona.TabIndex = 3
        Me.BtnSelecciona.Text = "Seleccionar.."
        Me.BtnSelecciona.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSelecciona.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(405, 32)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Seleccionar Ubigeo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormUbigeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(405, 202)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSelecciona)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUbigeo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Ubigeo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSelecciona As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents CboDst As System.Windows.Forms.ComboBox
    Friend WithEvents CboPrv As System.Windows.Forms.ComboBox
    Friend WithEvents CboDpto As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
End Class
