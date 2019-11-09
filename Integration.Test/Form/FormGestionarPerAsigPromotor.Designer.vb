<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionarPerAsigPromotor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestionarPerAsigPromotor))
        Me.RBtnMedico = New System.Windows.Forms.RadioButton()
        Me.RBtnLaboratorio = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboPromotor = New System.Windows.Forms.ComboBox()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.cPerAsigCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Doctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerAsigEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table2 = New System.Windows.Forms.DataGridView()
        Me.cPerAsigCodigo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Doctor1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFiltroDato = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.RBtnConvenio = New System.Windows.Forms.RadioButton()
        Me.RBtnCSalud = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DtpFecAsigna = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RBtnMedico
        '
        Me.RBtnMedico.AutoSize = True
        Me.RBtnMedico.Checked = True
        Me.RBtnMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnMedico.Location = New System.Drawing.Point(33, 7)
        Me.RBtnMedico.Name = "RBtnMedico"
        Me.RBtnMedico.Size = New System.Drawing.Size(71, 20)
        Me.RBtnMedico.TabIndex = 0
        Me.RBtnMedico.TabStop = True
        Me.RBtnMedico.Text = "Médico"
        Me.RBtnMedico.UseVisualStyleBackColor = True
        '
        'RBtnLaboratorio
        '
        Me.RBtnLaboratorio.AutoSize = True
        Me.RBtnLaboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnLaboratorio.Location = New System.Drawing.Point(122, 7)
        Me.RBtnLaboratorio.Name = "RBtnLaboratorio"
        Me.RBtnLaboratorio.Size = New System.Drawing.Size(95, 20)
        Me.RBtnLaboratorio.TabIndex = 1
        Me.RBtnLaboratorio.TabStop = True
        Me.RBtnLaboratorio.Text = "Laboratorio"
        Me.RBtnLaboratorio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione Promotor"
        '
        'CboPromotor
        '
        Me.CboPromotor.FormattingEnabled = True
        Me.CboPromotor.Location = New System.Drawing.Point(43, 9)
        Me.CboPromotor.Name = "CboPromotor"
        Me.CboPromotor.Size = New System.Drawing.Size(484, 23)
        Me.CboPromotor.TabIndex = 3
        '
        'Table1
        '
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerAsigCodigo, Me.Doctor, Me.nPerAsigEstado})
        Me.Table1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table1.Location = New System.Drawing.Point(3, 93)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(565, 476)
        Me.Table1.TabIndex = 4
        '
        'cPerAsigCodigo
        '
        Me.cPerAsigCodigo.DataPropertyName = "cPerAsigCodigo"
        Me.cPerAsigCodigo.FillWeight = 180.0!
        Me.cPerAsigCodigo.HeaderText = "Código"
        Me.cPerAsigCodigo.Name = "cPerAsigCodigo"
        Me.cPerAsigCodigo.Visible = False
        '
        'Doctor
        '
        Me.Doctor.DataPropertyName = "Doctor"
        Me.Doctor.HeaderText = "Médico / Laboratorio"
        Me.Doctor.MinimumWidth = 15
        Me.Doctor.Name = "Doctor"
        Me.Doctor.Width = 420
        '
        'nPerAsigEstado
        '
        Me.nPerAsigEstado.DataPropertyName = "nPerAsigEstado"
        Me.nPerAsigEstado.HeaderText = "Estado"
        Me.nPerAsigEstado.Name = "nPerAsigEstado"
        Me.nPerAsigEstado.Visible = False
        '
        'Table2
        '
        Me.Table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerAsigCodigo1, Me.Doctor1})
        Me.Table2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table2.Location = New System.Drawing.Point(685, 93)
        Me.Table2.Name = "Table2"
        Me.Table2.Size = New System.Drawing.Size(566, 476)
        Me.Table2.TabIndex = 5
        '
        'cPerAsigCodigo1
        '
        Me.cPerAsigCodigo1.DataPropertyName = "cPerAsigCodigo"
        Me.cPerAsigCodigo1.HeaderText = "cPerAsigCodigo"
        Me.cPerAsigCodigo1.Name = "cPerAsigCodigo1"
        Me.cPerAsigCodigo1.Visible = False
        '
        'Doctor1
        '
        Me.Doctor1.DataPropertyName = "Doctor"
        Me.Doctor1.HeaderText = "Médico / Laboratorio"
        Me.Doctor1.Name = "Doctor1"
        Me.Doctor1.Width = 420
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(6, 90)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(87, 27)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "> &Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Location = New System.Drawing.Point(6, 87)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(87, 27)
        Me.BtnQuitar.TabIndex = 7
        Me.BtnQuitar.Text = "< &Quitar"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCerrar.Location = New System.Drawing.Point(6, 16)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(87, 36)
        Me.BtnCerrar.TabIndex = 8
        Me.BtnCerrar.Text = "&Cerrar"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Buscar Médico"
        '
        'TxtFiltroDato
        '
        Me.TxtFiltroDato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFiltroDato.Location = New System.Drawing.Point(110, 8)
        Me.TxtFiltroDato.Name = "TxtFiltroDato"
        Me.TxtFiltroDato.Size = New System.Drawing.Size(362, 21)
        Me.TxtFiltroDato.TabIndex = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1260, 606)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1254, 28)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "҉    Gestionar Asignación Promotor(es)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Table1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Table2, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel6, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel8, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 31)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1254, 572)
        Me.TableLayoutPanel2.TabIndex = 22
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel7, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(565, 84)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.BtnBuscar)
        Me.Panel3.Controls.Add(Me.TxtFiltroDato)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(559, 36)
        Me.Panel3.TabIndex = 1
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.Integration.Test.My.Resources.Resources.find
        Me.BtnBuscar.Location = New System.Drawing.Point(478, 3)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(34, 31)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.RBtnConvenio)
        Me.Panel7.Controls.Add(Me.RBtnCSalud)
        Me.Panel7.Controls.Add(Me.RBtnMedico)
        Me.Panel7.Controls.Add(Me.RBtnLaboratorio)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(559, 36)
        Me.Panel7.TabIndex = 2
        '
        'RBtnConvenio
        '
        Me.RBtnConvenio.AutoSize = True
        Me.RBtnConvenio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnConvenio.Location = New System.Drawing.Point(350, 7)
        Me.RBtnConvenio.Name = "RBtnConvenio"
        Me.RBtnConvenio.Size = New System.Drawing.Size(83, 20)
        Me.RBtnConvenio.TabIndex = 3
        Me.RBtnConvenio.TabStop = True
        Me.RBtnConvenio.Text = "Convenio"
        Me.RBtnConvenio.UseVisualStyleBackColor = True
        '
        'RBtnCSalud
        '
        Me.RBtnCSalud.AutoSize = True
        Me.RBtnCSalud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnCSalud.Location = New System.Drawing.Point(223, 7)
        Me.RBtnCSalud.Name = "RBtnCSalud"
        Me.RBtnCSalud.Size = New System.Drawing.Size(122, 20)
        Me.RBtnCSalud.TabIndex = 2
        Me.RBtnCSalud.TabStop = True
        Me.RBtnCSalud.Text = "Centro de Salud"
        Me.RBtnCSalud.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel4, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel6, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(574, 93)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.09091!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(105, 476)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnCerrar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 399)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(99, 74)
        Me.Panel4.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DtpFecAsigna)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.BtnAgregar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(99, 156)
        Me.Panel5.TabIndex = 9
        '
        'DtpFecAsigna
        '
        Me.DtpFecAsigna.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecAsigna.Location = New System.Drawing.Point(6, 40)
        Me.DtpFecAsigna.Name = "DtpFecAsigna"
        Me.DtpFecAsigna.Size = New System.Drawing.Size(87, 21)
        Me.DtpFecAsigna.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha Asigna"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.BtnQuitar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 165)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(99, 228)
        Me.Panel6.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(9, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 99)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Para quitar un médico seleccione el registro del lado derecho, y luego presione &" & _
    "Quitar."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(685, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(566, 84)
        Me.TableLayoutPanel6.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnExportar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 27)
        Me.Panel1.TabIndex = 4
        '
        'BtnExportar
        '
        Me.BtnExportar.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExportar.Location = New System.Drawing.Point(374, 1)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(144, 23)
        Me.BtnExportar.TabIndex = 3
        Me.BtnExportar.Text = "Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CboPromotor)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 45)
        Me.Panel2.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.PictureBox1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(574, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(105, 84)
        Me.Panel8.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.asignacion
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormGestionarPerAsigPromotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 606)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGestionarPerAsigPromotor"
        Me.Text = "Gestionar Asignación Promotor(es)"
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RBtnMedico As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnLaboratorio As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboPromotor As System.Windows.Forms.ComboBox
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents Table2 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtFiltroDato As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DtpFecAsigna As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnExportar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cPerAsigCodigo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Doctor1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerAsigCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Doctor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerAsigEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RBtnCSalud As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnConvenio As System.Windows.Forms.RadioButton
End Class
