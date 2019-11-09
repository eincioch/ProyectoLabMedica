<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportCtaCteListaServicio
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
        Me.C1BtnImprimir = New C1.Win.C1Input.C1Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPorc = New System.Windows.Forms.TextBox()
        Me.RBOption05 = New System.Windows.Forms.RadioButton()
        Me.RBOption04 = New System.Windows.Forms.RadioButton()
        Me.RBOption03 = New System.Windows.Forms.RadioButton()
        Me.RBOption02 = New System.Windows.Forms.RadioButton()
        Me.RBOption01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1BtnImprimir
        '
        Me.C1BtnImprimir.Image = Global.Integration.Test.My.Resources.Resources.printer
        Me.C1BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.C1BtnImprimir.Location = New System.Drawing.Point(317, 309)
        Me.C1BtnImprimir.Name = "C1BtnImprimir"
        Me.C1BtnImprimir.Size = New System.Drawing.Size(166, 36)
        Me.C1BtnImprimir.TabIndex = 0
        Me.C1BtnImprimir.Text = "&Imprimir"
        Me.C1BtnImprimir.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.TxtPorc)
        Me.GroupBox.Controls.Add(Me.RBOption05)
        Me.GroupBox.Controls.Add(Me.RBOption04)
        Me.GroupBox.Controls.Add(Me.RBOption03)
        Me.GroupBox.Controls.Add(Me.RBOption02)
        Me.GroupBox.Controls.Add(Me.RBOption01)
        Me.GroupBox.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(488, 270)
        Me.GroupBox.TabIndex = 5
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = " Tipo de Listado "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(399, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "%"
        '
        'TxtPorc
        '
        Me.TxtPorc.Location = New System.Drawing.Point(332, 200)
        Me.TxtPorc.Name = "TxtPorc"
        Me.TxtPorc.Size = New System.Drawing.Size(61, 21)
        Me.TxtPorc.TabIndex = 1
        Me.TxtPorc.Text = "0"
        Me.TxtPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RBOption05
        '
        Me.RBOption05.AutoSize = True
        Me.RBOption05.Location = New System.Drawing.Point(62, 200)
        Me.RBOption05.Name = "RBOption05"
        Me.RBOption05.Size = New System.Drawing.Size(264, 19)
        Me.RBOption05.TabIndex = 0
        Me.RBOption05.Text = "Listado de Examenes con precio aplicando "
        Me.RBOption05.UseVisualStyleBackColor = True
        '
        'RBOption04
        '
        Me.RBOption04.AutoSize = True
        Me.RBOption04.Location = New System.Drawing.Point(62, 160)
        Me.RBOption04.Name = "RBOption04"
        Me.RBOption04.Size = New System.Drawing.Size(397, 19)
        Me.RBOption04.TabIndex = 0
        Me.RBOption04.TabStop = True
        Me.RBOption04.Text = "Listado de Examenes con Precio indica proceso (Local/Tercerizada)"
        Me.RBOption04.UseVisualStyleBackColor = True
        '
        'RBOption03
        '
        Me.RBOption03.AutoSize = True
        Me.RBOption03.Location = New System.Drawing.Point(62, 122)
        Me.RBOption03.Name = "RBOption03"
        Me.RBOption03.Size = New System.Drawing.Size(310, 19)
        Me.RBOption03.TabIndex = 0
        Me.RBOption03.TabStop = True
        Me.RBOption03.Text = "Listado de Examenes con detalle con precio público"
        Me.RBOption03.UseVisualStyleBackColor = True
        '
        'RBOption02
        '
        Me.RBOption02.AutoSize = True
        Me.RBOption02.Location = New System.Drawing.Point(62, 85)
        Me.RBOption02.Name = "RBOption02"
        Me.RBOption02.Size = New System.Drawing.Size(200, 19)
        Me.RBOption02.TabIndex = 0
        Me.RBOption02.TabStop = True
        Me.RBOption02.Text = "Listado de Examenes sin precio"
        Me.RBOption02.UseVisualStyleBackColor = True
        '
        'RBOption01
        '
        Me.RBOption01.AutoSize = True
        Me.RBOption01.Checked = True
        Me.RBOption01.Location = New System.Drawing.Point(62, 45)
        Me.RBOption01.Name = "RBOption01"
        Me.RBOption01.Size = New System.Drawing.Size(247, 19)
        Me.RBOption01.TabIndex = 0
        Me.RBOption01.TabStop = True
        Me.RBOption01.Text = "Listado de Examenes con precio público"
        Me.RBOption01.UseVisualStyleBackColor = True
        '
        'FormReportCtaCteListaServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 357)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.C1BtnImprimir)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormReportCtaCteListaServicio"
        Me.Text = "Imprimir Relación Examenes"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1BtnImprimir As C1.Win.C1Input.C1Button
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPorc As System.Windows.Forms.TextBox
    Friend WithEvents RBOption05 As System.Windows.Forms.RadioButton
    Friend WithEvents RBOption03 As System.Windows.Forms.RadioButton
    Friend WithEvents RBOption02 As System.Windows.Forms.RadioButton
    Friend WithEvents RBOption01 As System.Windows.Forms.RadioButton
    Friend WithEvents RBOption04 As System.Windows.Forms.RadioButton
End Class
