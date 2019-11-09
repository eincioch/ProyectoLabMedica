<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPopupDetalleAnalisis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPopupDetalleAnalisis))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblAnalisis = New System.Windows.Forms.Label()
        Me.LblTipoMuestra = New System.Windows.Forms.Label()
        Me.LblVolumenMinimo = New System.Windows.Forms.Label()
        Me.LblTipoEnvase = New System.Windows.Forms.Label()
        Me.LblDiasProceso = New System.Windows.Forms.Label()
        Me.LblCondiciones = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(637, 34)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "҉    Detalle del análisis"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(51, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Análisis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(48, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de Muestra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(48, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Volúmen mínimo requerido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(48, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo de envase"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(48, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Días de proceso"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(48, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Condiciones pre-analíticas"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Teal
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 449)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(637, 49)
        Me.Label8.TabIndex = 8
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAnalisis
        '
        Me.LblAnalisis.AutoSize = True
        Me.LblAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnalisis.ForeColor = System.Drawing.Color.Teal
        Me.LblAnalisis.Location = New System.Drawing.Point(74, 96)
        Me.LblAnalisis.Name = "LblAnalisis"
        Me.LblAnalisis.Size = New System.Drawing.Size(55, 16)
        Me.LblAnalisis.TabIndex = 9
        Me.LblAnalisis.Text = "Label9"
        '
        'LblTipoMuestra
        '
        Me.LblTipoMuestra.AutoSize = True
        Me.LblTipoMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoMuestra.ForeColor = System.Drawing.Color.Navy
        Me.LblTipoMuestra.Location = New System.Drawing.Point(74, 147)
        Me.LblTipoMuestra.Name = "LblTipoMuestra"
        Me.LblTipoMuestra.Size = New System.Drawing.Size(63, 16)
        Me.LblTipoMuestra.TabIndex = 10
        Me.LblTipoMuestra.Text = "Label10"
        '
        'LblVolumenMinimo
        '
        Me.LblVolumenMinimo.AutoSize = True
        Me.LblVolumenMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVolumenMinimo.ForeColor = System.Drawing.Color.Navy
        Me.LblVolumenMinimo.Location = New System.Drawing.Point(74, 202)
        Me.LblVolumenMinimo.Name = "LblVolumenMinimo"
        Me.LblVolumenMinimo.Size = New System.Drawing.Size(63, 16)
        Me.LblVolumenMinimo.TabIndex = 11
        Me.LblVolumenMinimo.Text = "Label11"
        '
        'LblTipoEnvase
        '
        Me.LblTipoEnvase.AutoSize = True
        Me.LblTipoEnvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoEnvase.ForeColor = System.Drawing.Color.Navy
        Me.LblTipoEnvase.Location = New System.Drawing.Point(74, 259)
        Me.LblTipoEnvase.Name = "LblTipoEnvase"
        Me.LblTipoEnvase.Size = New System.Drawing.Size(63, 16)
        Me.LblTipoEnvase.TabIndex = 12
        Me.LblTipoEnvase.Text = "Label12"
        '
        'LblDiasProceso
        '
        Me.LblDiasProceso.AutoSize = True
        Me.LblDiasProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasProceso.ForeColor = System.Drawing.Color.Navy
        Me.LblDiasProceso.Location = New System.Drawing.Point(74, 317)
        Me.LblDiasProceso.Name = "LblDiasProceso"
        Me.LblDiasProceso.Size = New System.Drawing.Size(63, 16)
        Me.LblDiasProceso.TabIndex = 13
        Me.LblDiasProceso.Text = "Label13"
        '
        'LblCondiciones
        '
        Me.LblCondiciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCondiciones.ForeColor = System.Drawing.Color.Navy
        Me.LblCondiciones.Location = New System.Drawing.Point(74, 377)
        Me.LblCondiciones.Name = "LblCondiciones"
        Me.LblCondiciones.Size = New System.Drawing.Size(524, 61)
        Me.LblCondiciones.TabIndex = 14
        Me.LblCondiciones.Text = "Label14"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(522, 457)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(91, 32)
        Me.BtnCerrar.TabIndex = 23
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Teal
        Me.LinkLabel1.Location = New System.Drawing.Point(28, 465)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(131, 16)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.medica.com.pe"
        '
        'FormPopupDetalleAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CancelButton = Me.BtnCerrar
        Me.ClientSize = New System.Drawing.Size(637, 498)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LblCondiciones)
        Me.Controls.Add(Me.LblDiasProceso)
        Me.Controls.Add(Me.LblTipoEnvase)
        Me.Controls.Add(Me.LblVolumenMinimo)
        Me.Controls.Add(Me.LblTipoMuestra)
        Me.Controls.Add(Me.LblAnalisis)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPopupDetalleAnalisis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de análisis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblAnalisis As System.Windows.Forms.Label
    Friend WithEvents LblTipoMuestra As System.Windows.Forms.Label
    Friend WithEvents LblVolumenMinimo As System.Windows.Forms.Label
    Friend WithEvents LblTipoEnvase As System.Windows.Forms.Label
    Friend WithEvents LblDiasProceso As System.Windows.Forms.Label
    Friend WithEvents LblCondiciones As System.Windows.Forms.Label
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
