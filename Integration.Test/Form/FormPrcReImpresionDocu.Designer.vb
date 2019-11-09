<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcReImpresionDocu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcReImpresionDocu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCorrelativo = New System.Windows.Forms.TextBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.CboTipoDocu = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnReImprimir = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCorrelativo)
        Me.GroupBox1.Controls.Add(Me.TxtSerie)
        Me.GroupBox1.Controls.Add(Me.CboTipoDocu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtCorrelativo
        '
        Me.TxtCorrelativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCorrelativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorrelativo.Location = New System.Drawing.Point(309, 53)
        Me.TxtCorrelativo.Name = "TxtCorrelativo"
        Me.TxtCorrelativo.Size = New System.Drawing.Size(102, 23)
        Me.TxtCorrelativo.TabIndex = 2
        Me.TxtCorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSerie
        '
        Me.TxtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSerie.Location = New System.Drawing.Point(161, 53)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(63, 23)
        Me.TxtSerie.TabIndex = 1
        Me.TxtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboTipoDocu
        '
        Me.CboTipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDocu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoDocu.FormattingEnabled = True
        Me.CboTipoDocu.Location = New System.Drawing.Point(161, 18)
        Me.CboTipoDocu.Name = "CboTipoDocu"
        Me.CboTipoDocu.Size = New System.Drawing.Size(250, 24)
        Me.CboTipoDocu.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correlativo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Serie:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Documento:"
        '
        'BtnReImprimir
        '
        Me.BtnReImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReImprimir.Image = Global.Integration.Test.My.Resources.Resources.printer
        Me.BtnReImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReImprimir.Location = New System.Drawing.Point(147, 138)
        Me.BtnReImprimir.Name = "BtnReImprimir"
        Me.BtnReImprimir.Size = New System.Drawing.Size(147, 30)
        Me.BtnReImprimir.TabIndex = 0
        Me.BtnReImprimir.Text = "&Re-Imprimir"
        Me.BtnReImprimir.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(301, 138)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(125, 30)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.Text = "&Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(455, 33)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "҉     Re-Impresión documentos "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.PrintArea_32x32
        Me.PictureBox1.Location = New System.Drawing.Point(4, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'FormPrcReImpresionDocu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 180)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnReImprimir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPrcReImpresionDocu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re-Impresión documentos "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSerie As System.Windows.Forms.TextBox
    Friend WithEvents BtnReImprimir As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
