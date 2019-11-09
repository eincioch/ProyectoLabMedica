<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRankingExamenes
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
        Me.RbtnExamen = New System.Windows.Forms.RadioButton()
        Me.RbtnPerfil = New System.Windows.Forms.RadioButton()
        Me.RbtnCampana = New System.Windows.Forms.RadioButton()
        Me.CboLista = New System.Windows.Forms.ComboBox()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.DtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.DtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnResultado = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtCodigos = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnExportExcel = New System.Windows.Forms.Button()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'RbtnExamen
        '
        Me.RbtnExamen.AutoSize = True
        Me.RbtnExamen.Checked = True
        Me.RbtnExamen.Location = New System.Drawing.Point(20, 15)
        Me.RbtnExamen.Name = "RbtnExamen"
        Me.RbtnExamen.Size = New System.Drawing.Size(113, 19)
        Me.RbtnExamen.TabIndex = 0
        Me.RbtnExamen.TabStop = True
        Me.RbtnExamen.Text = "por Exámen(es)"
        Me.RbtnExamen.UseVisualStyleBackColor = True
        '
        'RbtnPerfil
        '
        Me.RbtnPerfil.AutoSize = True
        Me.RbtnPerfil.Location = New System.Drawing.Point(171, 15)
        Me.RbtnPerfil.Name = "RbtnPerfil"
        Me.RbtnPerfil.Size = New System.Drawing.Size(87, 19)
        Me.RbtnPerfil.TabIndex = 1
        Me.RbtnPerfil.Text = "por Perfiles"
        Me.RbtnPerfil.UseVisualStyleBackColor = True
        '
        'RbtnCampana
        '
        Me.RbtnCampana.AutoSize = True
        Me.RbtnCampana.Location = New System.Drawing.Point(310, 15)
        Me.RbtnCampana.Name = "RbtnCampana"
        Me.RbtnCampana.Size = New System.Drawing.Size(100, 19)
        Me.RbtnCampana.TabIndex = 2
        Me.RbtnCampana.Text = "por Campaña"
        Me.RbtnCampana.UseVisualStyleBackColor = True
        '
        'CboLista
        '
        Me.CboLista.FormattingEnabled = True
        Me.CboLista.Location = New System.Drawing.Point(20, 24)
        Me.CboLista.Name = "CboLista"
        Me.CboLista.Size = New System.Drawing.Size(426, 23)
        Me.CboLista.TabIndex = 22
        '
        'Table1
        '
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table1.Location = New System.Drawing.Point(620, 124)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(419, 405)
        Me.Table1.TabIndex = 24
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(11, 20)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(114, 27)
        Me.BtnAgregar.TabIndex = 27
        Me.BtnAgregar.Text = "< Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'DtpFecIni
        '
        Me.DtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecIni.Location = New System.Drawing.Point(11, 49)
        Me.DtpFecIni.Name = "DtpFecIni"
        Me.DtpFecIni.Size = New System.Drawing.Size(114, 21)
        Me.DtpFecIni.TabIndex = 28
        '
        'DtpFecFin
        '
        Me.DtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFin.Location = New System.Drawing.Point(11, 91)
        Me.DtpFecFin.Name = "DtpFecFin"
        Me.DtpFecFin.Size = New System.Drawing.Size(114, 21)
        Me.DtpFecFin.TabIndex = 29
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1048, 577)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1042, 39)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "҉     Ranking Exámenes según filtro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Table1, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel7, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 42)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1042, 532)
        Me.TableLayoutPanel2.TabIndex = 23
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel5, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel6, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(476, 124)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(138, 405)
        Me.TableLayoutPanel3.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.DtpFecIni)
        Me.Panel4.Controls.Add(Me.DtpFecFin)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(132, 136)
        Me.Panel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Desde"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnResultado)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 145)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(132, 125)
        Me.Panel5.TabIndex = 1
        '
        'BtnResultado
        '
        Me.BtnResultado.Image = Global.Integration.Test.My.Resources.Resources.Find_16x16
        Me.BtnResultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnResultado.Location = New System.Drawing.Point(11, 48)
        Me.BtnResultado.Name = "BtnResultado"
        Me.BtnResultado.Size = New System.Drawing.Size(114, 45)
        Me.BtnResultado.TabIndex = 25
        Me.BtnResultado.Text = "Ver Resultado"
        Me.BtnResultado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnResultado.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.BtnExportExcel)
        Me.Panel6.Controls.Add(Me.BtnCerrar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 276)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(132, 126)
        Me.Panel6.TabIndex = 2
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCerrar.Location = New System.Drawing.Point(11, 70)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(114, 40)
        Me.BtnCerrar.TabIndex = 26
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(467, 115)
        Me.TableLayoutPanel4.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbtnExamen)
        Me.Panel1.Controls.Add(Me.RbtnPerfil)
        Me.Panel1.Controls.Add(Me.RbtnCampana)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 51)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.CboLista)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(461, 52)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 15)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Seleccion un Ítem por favor"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(476, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(138, 115)
        Me.TableLayoutPanel5.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnAgregar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(132, 52)
        Me.Panel3.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TxtCodigos, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.BtnLimpiar, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 124)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(467, 405)
        Me.TableLayoutPanel6.TabIndex = 29
        '
        'TxtCodigos
        '
        Me.TxtCodigos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCodigos.Location = New System.Drawing.Point(3, 43)
        Me.TxtCodigos.Multiline = True
        Me.TxtCodigos.Name = "TxtCodigos"
        Me.TxtCodigos.Size = New System.Drawing.Size(461, 359)
        Me.TxtCodigos.TabIndex = 0
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLimpiar.Location = New System.Drawing.Point(3, 3)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(461, 34)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.Text = "Limpiar Filtro"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Panel7, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(620, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(419, 115)
        Me.TableLayoutPanel7.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.ranking
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(119, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(297, 109)
        Me.Panel7.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(297, 31)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Resultados "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnExportExcel
        '
        Me.BtnExportExcel.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.BtnExportExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnExportExcel.Location = New System.Drawing.Point(11, 24)
        Me.BtnExportExcel.Name = "BtnExportExcel"
        Me.BtnExportExcel.Size = New System.Drawing.Size(114, 40)
        Me.BtnExportExcel.TabIndex = 24
        Me.BtnExportExcel.Text = "Exportar Excel"
        Me.BtnExportExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExportExcel.UseVisualStyleBackColor = True
        '
        'FormRankingExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 577)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormRankingExamenes"
        Me.Text = "Ranking Examenes según filtro"
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RbtnExamen As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnPerfil As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnCampana As System.Windows.Forms.RadioButton
    Friend WithEvents CboLista As System.Windows.Forms.ComboBox
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnResultado As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents DtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TxtCodigos As System.Windows.Forms.TextBox
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnExportExcel As System.Windows.Forms.Button
End Class
