<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNotaCredito
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrpBxNroCajaSerNum = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblCorrelativo = New System.Windows.Forms.Label()
        Me.LblSerie = New System.Windows.Forms.Label()
        Me.CboTipoDocu = New System.Windows.Forms.ComboBox()
        Me.LblNroCaja = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GrpBoxDetCliente = New System.Windows.Forms.GroupBox()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.LblcNombre = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LblcPerCodigo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboMotivoNC = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnRegPago = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblTotalPago = New System.Windows.Forms.Label()
        Me.DtpFecPago = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrpBxNroCajaSerNum.SuspendLayout()
        Me.GrpBoxDetCliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpBxNroCajaSerNum
        '
        Me.GrpBxNroCajaSerNum.Controls.Add(Me.Label16)
        Me.GrpBxNroCajaSerNum.Controls.Add(Me.Label11)
        Me.GrpBxNroCajaSerNum.Controls.Add(Me.LblCorrelativo)
        Me.GrpBxNroCajaSerNum.Controls.Add(Me.LblSerie)
        Me.GrpBxNroCajaSerNum.Controls.Add(Me.CboTipoDocu)
        Me.GrpBxNroCajaSerNum.Controls.Add(Me.LblNroCaja)
        Me.GrpBxNroCajaSerNum.Controls.Add(Me.Label6)
        Me.GrpBxNroCajaSerNum.Controls.Add(Me.Label7)
        Me.GrpBxNroCajaSerNum.Location = New System.Drawing.Point(12, 30)
        Me.GrpBxNroCajaSerNum.Name = "GrpBxNroCajaSerNum"
        Me.GrpBxNroCajaSerNum.Size = New System.Drawing.Size(904, 53)
        Me.GrpBxNroCajaSerNum.TabIndex = 124
        Me.GrpBxNroCajaSerNum.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(728, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 18)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Numero"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(624, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Serie"
        '
        'LblCorrelativo
        '
        Me.LblCorrelativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblCorrelativo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCorrelativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.LblCorrelativo.ForeColor = System.Drawing.Color.White
        Me.LblCorrelativo.Location = New System.Drawing.Point(796, 15)
        Me.LblCorrelativo.Name = "LblCorrelativo"
        Me.LblCorrelativo.Size = New System.Drawing.Size(101, 29)
        Me.LblCorrelativo.TabIndex = 22
        Me.LblCorrelativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSerie
        '
        Me.LblSerie.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblSerie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.LblSerie.ForeColor = System.Drawing.Color.White
        Me.LblSerie.Location = New System.Drawing.Point(672, 15)
        Me.LblSerie.Name = "LblSerie"
        Me.LblSerie.Size = New System.Drawing.Size(50, 29)
        Me.LblSerie.TabIndex = 21
        Me.LblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboTipoDocu
        '
        Me.CboTipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDocu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.CboTipoDocu.FormattingEnabled = True
        Me.CboTipoDocu.Location = New System.Drawing.Point(280, 16)
        Me.CboTipoDocu.Name = "CboTipoDocu"
        Me.CboTipoDocu.Size = New System.Drawing.Size(334, 26)
        Me.CboTipoDocu.TabIndex = 20
        '
        'LblNroCaja
        '
        Me.LblNroCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblNroCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNroCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.LblNroCaja.ForeColor = System.Drawing.Color.White
        Me.LblNroCaja.Location = New System.Drawing.Point(88, 13)
        Me.LblNroCaja.Name = "LblNroCaja"
        Me.LblNroCaja.Size = New System.Drawing.Size(52, 29)
        Me.LblNroCaja.TabIndex = 19
        Me.LblNroCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(156, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Caja Nro."
        '
        'GrpBoxDetCliente
        '
        Me.GrpBoxDetCliente.Controls.Add(Me.BtnCambiar)
        Me.GrpBoxDetCliente.Controls.Add(Me.LblcNombre)
        Me.GrpBoxDetCliente.Controls.Add(Me.Label19)
        Me.GrpBoxDetCliente.Controls.Add(Me.LblcPerCodigo)
        Me.GrpBoxDetCliente.Location = New System.Drawing.Point(11, 83)
        Me.GrpBoxDetCliente.Name = "GrpBoxDetCliente"
        Me.GrpBoxDetCliente.Size = New System.Drawing.Size(905, 45)
        Me.GrpBoxDetCliente.TabIndex = 130
        Me.GrpBoxDetCliente.TabStop = False
        '
        'BtnCambiar
        '
        Me.BtnCambiar.Image = Global.Integration.Test.My.Resources.Resources._16_em_pencil
        Me.BtnCambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCambiar.Location = New System.Drawing.Point(711, 14)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(120, 24)
        Me.BtnCambiar.TabIndex = 128
        Me.BtnCambiar.Text = "      &Cambiar... (F7)"
        Me.BtnCambiar.UseVisualStyleBackColor = True
        '
        'LblcNombre
        '
        Me.LblcNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblcNombre.Location = New System.Drawing.Point(215, 16)
        Me.LblcNombre.Name = "LblcNombre"
        Me.LblcNombre.Size = New System.Drawing.Size(490, 18)
        Me.LblcNombre.TabIndex = 127
        Me.LblcNombre.Text = "_"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(29, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 18)
        Me.Label19.TabIndex = 126
        Me.Label19.Text = "Cliente"
        '
        'LblcPerCodigo
        '
        Me.LblcPerCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcPerCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblcPerCodigo.Location = New System.Drawing.Point(107, 17)
        Me.LblcPerCodigo.Name = "LblcPerCodigo"
        Me.LblcPerCodigo.Size = New System.Drawing.Size(104, 18)
        Me.LblcPerCodigo.TabIndex = 125
        Me.LblcPerCodigo.Text = "_"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboMotivoNC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 61)
        Me.GroupBox1.TabIndex = 131
        Me.GroupBox1.TabStop = False
        '
        'CboMotivoNC
        '
        Me.CboMotivoNC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMotivoNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.CboMotivoNC.FormattingEnabled = True
        Me.CboMotivoNC.Location = New System.Drawing.Point(169, 21)
        Me.CboMotivoNC.Name = "CboMotivoNC"
        Me.CboMotivoNC.Size = New System.Drawing.Size(716, 26)
        Me.CboMotivoNC.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Seleccione mótivo"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(930, 28)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "҉     NOTA DE CRÉDITO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(12, 233)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(903, 23)
        Me.Label18.TabIndex = 133
        Me.Label18.Text = "Detalle Documento"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Table1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle11
        Me.Table1.Location = New System.Drawing.Point(11, 257)
        Me.Table1.Name = "Table1"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.Table1.Size = New System.Drawing.Size(904, 255)
        Me.Table1.TabIndex = 134
        '
        'BtnQuitar
        '
        Me.BtnQuitar.ForeColor = System.Drawing.Color.Black
        Me.BtnQuitar.Image = Global.Integration.Test.My.Resources.Resources.money_delete
        Me.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitar.Location = New System.Drawing.Point(767, 194)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(142, 28)
        Me.BtnQuitar.TabIndex = 136
        Me.BtnQuitar.Text = "Quitar Item (SUPR)"
        Me.BtnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.Image = Global.Integration.Test.My.Resources.Resources.money_add
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(647, 194)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(114, 28)
        Me.BtnAdd.TabIndex = 135
        Me.BtnAdd.Text = "Agregar (INS)"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = True
        Me.BtnAdd.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources.Cancel_32x32
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(229, 525)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(171, 46)
        Me.BtnCancel.TabIndex = 138
        Me.BtnCancel.Text = "         Cancelar (ESC)"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnRegPago
        '
        Me.BtnRegPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegPago.ForeColor = System.Drawing.Color.Black
        Me.BtnRegPago.Image = Global.Integration.Test.My.Resources.Resources.Apply_32x32
        Me.BtnRegPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegPago.Location = New System.Drawing.Point(27, 525)
        Me.BtnRegPago.Name = "BtnRegPago"
        Me.BtnRegPago.Size = New System.Drawing.Size(195, 46)
        Me.BtnRegPago.TabIndex = 137
        Me.BtnRegPago.Text = "          Registrar Documento (F4)"
        Me.BtnRegPago.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(747, 515)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 31)
        Me.Label13.TabIndex = 141
        Me.Label13.Text = "S/."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(629, 525)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "TOTAL IMPORTE"
        '
        'LblTotalPago
        '
        Me.LblTotalPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPago.ForeColor = System.Drawing.Color.White
        Me.LblTotalPago.Location = New System.Drawing.Point(764, 515)
        Me.LblTotalPago.Name = "LblTotalPago"
        Me.LblTotalPago.Size = New System.Drawing.Size(132, 31)
        Me.LblTotalPago.TabIndex = 140
        Me.LblTotalPago.Text = "0.00"
        Me.LblTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtpFecPago
        '
        Me.DtpFecPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtpFecPago.CustomFormat = ""
        Me.DtpFecPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecPago.Location = New System.Drawing.Point(180, 202)
        Me.DtpFecPago.Name = "DtpFecPago"
        Me.DtpFecPago.Size = New System.Drawing.Size(96, 20)
        Me.DtpFecPago.TabIndex = 142
        Me.DtpFecPago.Value = New Date(2013, 10, 17, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 18)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Seleccione fecha"
        '
        'FormNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 586)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DtpFecPago)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblTotalPago)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnRegPago)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.BtnQuitar)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpBoxDetCliente)
        Me.Controls.Add(Me.GrpBxNroCajaSerNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota Crédito"
        Me.GrpBxNroCajaSerNum.ResumeLayout(False)
        Me.GrpBxNroCajaSerNum.PerformLayout()
        Me.GrpBoxDetCliente.ResumeLayout(False)
        Me.GrpBoxDetCliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpBxNroCajaSerNum As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblCorrelativo As System.Windows.Forms.Label
    Friend WithEvents LblSerie As System.Windows.Forms.Label
    Friend WithEvents CboTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents LblNroCaja As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxDetCliente As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCambiar As System.Windows.Forms.Button
    Friend WithEvents LblcNombre As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LblcPerCodigo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboMotivoNC As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnRegPago As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblTotalPago As System.Windows.Forms.Label
    Friend WithEvents DtpFecPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
