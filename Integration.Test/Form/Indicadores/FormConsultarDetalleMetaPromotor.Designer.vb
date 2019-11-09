<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultarDetalleMetaPromotor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.cPerTercero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nAtenciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nImpTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nIntCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerPromCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombresPromotor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblPromotor = New System.Windows.Forms.Label()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label6.Size = New System.Drawing.Size(776, 28)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "҉     Detalle de Ventas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerTercero, Me.nAtenciones, Me.nImpTotal, Me.nIntCodigo, Me.cPerPromCodigo, Me.cNombresPromotor})
        Me.Table1.Location = New System.Drawing.Point(12, 96)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(752, 398)
        Me.Table1.TabIndex = 145
        '
        'cPerTercero
        '
        Me.cPerTercero.DataPropertyName = "cPerTercero"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.cPerTercero.DefaultCellStyle = DataGridViewCellStyle1
        Me.cPerTercero.HeaderText = "Empresa"
        Me.cPerTercero.Name = "cPerTercero"
        Me.cPerTercero.ReadOnly = True
        Me.cPerTercero.Width = 480
        '
        'nAtenciones
        '
        Me.nAtenciones.DataPropertyName = "nAtenciones"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.nAtenciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.nAtenciones.HeaderText = "Nº Atenciones"
        Me.nAtenciones.Name = "nAtenciones"
        Me.nAtenciones.ReadOnly = True
        Me.nAtenciones.Width = 80
        '
        'nImpTotal
        '
        Me.nImpTotal.DataPropertyName = "nImpTotal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.nImpTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.nImpTotal.HeaderText = "Avance S/ (Vta)"
        Me.nImpTotal.Name = "nImpTotal"
        Me.nImpTotal.ReadOnly = True
        '
        'nIntCodigo
        '
        Me.nIntCodigo.HeaderText = "nTipo"
        Me.nIntCodigo.Name = "nIntCodigo"
        Me.nIntCodigo.ReadOnly = True
        Me.nIntCodigo.Visible = False
        '
        'cPerPromCodigo
        '
        Me.cPerPromCodigo.HeaderText = "Cód. Promotor"
        Me.cPerPromCodigo.Name = "cPerPromCodigo"
        Me.cPerPromCodigo.ReadOnly = True
        Me.cPerPromCodigo.Visible = False
        '
        'cNombresPromotor
        '
        Me.cNombresPromotor.HeaderText = "Promotor"
        Me.cNombresPromotor.Name = "cNombresPromotor"
        Me.cNombresPromotor.ReadOnly = True
        Me.cNombresPromotor.Visible = False
        '
        'LblPromotor
        '
        Me.LblPromotor.AutoSize = True
        Me.LblPromotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPromotor.Location = New System.Drawing.Point(12, 68)
        Me.LblPromotor.Name = "LblPromotor"
        Me.LblPromotor.Size = New System.Drawing.Size(74, 15)
        Me.LblPromotor.TabIndex = 146
        Me.LblPromotor.Text = "Promotor: "
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.Location = New System.Drawing.Point(12, 43)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(43, 15)
        Me.LblTipo.TabIndex = 147
        Me.LblTipo.Text = "Tipo: "
        '
        'BtnExportar
        '
        Me.BtnExportar.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExportar.Location = New System.Drawing.Point(185, 512)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(117, 30)
        Me.BtnExportar.TabIndex = 148
        Me.BtnExportar.Text = "&Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(370, 512)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(117, 30)
        Me.BtnCancel.TabIndex = 27
        Me.BtnCancel.Text = "&Cerrar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormConsultarDetalleMetaPromotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(776, 566)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.LblPromotor)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormConsultarDetalleMetaPromotor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents LblPromotor As System.Windows.Forms.Label
    Friend WithEvents LblTipo As System.Windows.Forms.Label
    Friend WithEvents BtnExportar As System.Windows.Forms.Button
    Friend WithEvents cPerTercero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nAtenciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nImpTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nIntCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerPromCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNombresPromotor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
