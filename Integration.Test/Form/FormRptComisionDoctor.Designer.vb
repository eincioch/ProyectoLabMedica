<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptComisionDoctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRptComisionDoctor))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GrpBx = New System.Windows.Forms.GroupBox()
        Me.CboDerivMedico = New System.Windows.Forms.ComboBox()
        Me.CboFiltro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFecFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPFecIni = New System.Windows.Forms.DateTimePicker()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdExportPDF = New C1.Win.C1Command.C1Command()
        Me.C1CmdExportExcel = New C1.Win.C1Command.C1Command()
        Me.C1CmdReporte = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblnSaldo = New System.Windows.Forms.Label()
        Me.GrpBx.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label6.Size = New System.Drawing.Size(1352, 28)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "҉     Reporte de Comisión agrupado por Doctor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpBx
        '
        Me.GrpBx.Controls.Add(Me.CboDerivMedico)
        Me.GrpBx.Controls.Add(Me.CboFiltro)
        Me.GrpBx.Controls.Add(Me.Label3)
        Me.GrpBx.Controls.Add(Me.Label2)
        Me.GrpBx.Controls.Add(Me.Label1)
        Me.GrpBx.Controls.Add(Me.DTPFecFin)
        Me.GrpBx.Controls.Add(Me.DTPFecIni)
        Me.GrpBx.Location = New System.Drawing.Point(7, 58)
        Me.GrpBx.Name = "GrpBx"
        Me.GrpBx.Size = New System.Drawing.Size(843, 55)
        Me.GrpBx.TabIndex = 21
        Me.GrpBx.TabStop = False
        '
        'CboDerivMedico
        '
        Me.CboDerivMedico.FormattingEnabled = True
        Me.CboDerivMedico.Location = New System.Drawing.Point(192, 20)
        Me.CboDerivMedico.Name = "CboDerivMedico"
        Me.CboDerivMedico.Size = New System.Drawing.Size(329, 21)
        Me.CboDerivMedico.TabIndex = 5
        '
        'CboFiltro
        '
        Me.CboFiltro.AutoCompleteCustomSource.AddRange(New String() {"Médico", "Rango Fechas"})
        Me.CboFiltro.FormattingEnabled = True
        Me.CboFiltro.Items.AddRange(New Object() {"<TODOS>", "por Médico", "por Promotor"})
        Me.CboFiltro.Location = New System.Drawing.Point(54, 19)
        Me.CboFiltro.Name = "CboFiltro"
        Me.CboFiltro.Size = New System.Drawing.Size(132, 21)
        Me.CboFiltro.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Filtro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(689, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(536, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde:"
        '
        'DTPFecFin
        '
        Me.DTPFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecFin.Location = New System.Drawing.Point(731, 20)
        Me.DTPFecFin.Name = "DTPFecFin"
        Me.DTPFecFin.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecFin.TabIndex = 1
        '
        'DTPFecIni
        '
        Me.DTPFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecIni.Location = New System.Drawing.Point(583, 20)
        Me.DTPFecIni.Name = "DTPFecIni"
        Me.DTPFecIni.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecIni.TabIndex = 1
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Image = Global.Integration.Test.My.Resources.Resources.table_refresh
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(865, 69)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(81, 36)
        Me.BtnMostrar.TabIndex = 22
        Me.BtnMostrar.Text = "    &Mostrar..."
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink3, Me.C1CommandLink2, Me.C1CommandLink1, Me.C1CommandLink4})
        Me.C1ToolBar1.Location = New System.Drawing.Point(9, 31)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(349, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExportPDF)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdExportExcel)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdReporte)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CmdExportPDF
        '
        Me.C1CmdExportPDF.Image = Global.Integration.Test.My.Resources.Resources.file_extension_pdf
        Me.C1CmdExportPDF.Name = "C1CmdExportPDF"
        Me.C1CmdExportPDF.Text = "Exportar PDF"
        '
        'C1CmdExportExcel
        '
        Me.C1CmdExportExcel.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.C1CmdExportExcel.Name = "C1CmdExportExcel"
        Me.C1CmdExportExcel.Text = "Exportar Excel"
        '
        'C1CmdReporte
        '
        Me.C1CmdReporte.Image = Global.Integration.Test.My.Resources.Resources.report_add
        Me.C1CmdReporte.Name = "C1CmdReporte"
        Me.C1CmdReporte.Text = "Reporte"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "Cerrar"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdReporte
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdExportExcel
        Me.C1CommandLink2.SortOrder = 1
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdExportPDF
        Me.C1CommandLink1.SortOrder = 2
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdCerrar
        Me.C1CommandLink4.SortOrder = 3
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Location = New System.Drawing.Point(7, 119)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(730, 130)
        Me.Table1.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(952, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 20)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Importe Total Comisiones:"
        '
        'LblnSaldo
        '
        Me.LblnSaldo.BackColor = System.Drawing.Color.Maroon
        Me.LblnSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblnSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblnSaldo.ForeColor = System.Drawing.Color.White
        Me.LblnSaldo.Location = New System.Drawing.Point(1151, 74)
        Me.LblnSaldo.Name = "LblnSaldo"
        Me.LblnSaldo.Size = New System.Drawing.Size(126, 25)
        Me.LblnSaldo.TabIndex = 126
        Me.LblnSaldo.Text = "0.00"
        Me.LblnSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormRptComisionDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 277)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblnSaldo)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.GrpBx)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRptComisionDoctor"
        Me.Text = "Comisión Doctor"
        Me.GrpBx.ResumeLayout(False)
        Me.GrpBx.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents GrpBx As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdExportPDF As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdExportExcel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdReporte As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents CboFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboDerivMedico As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblnSaldo As System.Windows.Forms.Label
End Class
