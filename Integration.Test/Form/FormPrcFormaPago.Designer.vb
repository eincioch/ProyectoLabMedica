﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcFormaPago
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcFormaPago))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtpFecDeposito = New System.Windows.Forms.DateTimePicker()
        Me.Table2 = New System.Windows.Forms.DataGridView()
        Me.nCtaCteForPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescForPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerCodigoBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescrBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dCtaCteFecTransacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNroTarjCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroTrasacVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nMonCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCtePagImpMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCtePagImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nConValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboFormaPago = New System.Windows.Forms.ComboBox()
        Me.LblNroRecibo = New System.Windows.Forms.Label()
        Me.CboMoneda = New System.Windows.Forms.ComboBox()
        Me.LblImpRecibo = New System.Windows.Forms.Label()
        Me.GrpBox = New System.Windows.Forms.GroupBox()
        Me.GBCortesia = New System.Windows.Forms.GroupBox()
        Me.CboMotivDscto = New System.Windows.Forms.ComboBox()
        Me.TxtDetalleDscto = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.CboTipoVenta = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TxtImpPago = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.DtpFecPago = New System.Windows.Forms.DateTimePicker()
        Me.LblTC = New System.Windows.Forms.Label()
        Me.GrpBoxBco = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxtNroTarjeta = New System.Windows.Forms.TextBox()
        Me.TxtVoucher = New System.Windows.Forms.TextBox()
        Me.CboTipoTarj = New System.Windows.Forms.ComboBox()
        Me.CboBanco = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblTotalPago = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtStrDetalle = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrpBxNroCajaSerNum = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblCorrelativo = New System.Windows.Forms.Label()
        Me.LblSerie = New System.Windows.Forms.Label()
        Me.CboTipoDocu = New System.Windows.Forms.ComboBox()
        Me.LblNroCaja = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblnPerCtaCodigo = New System.Windows.Forms.Label()
        Me.LblcPerCodigo = New System.Windows.Forms.Label()
        Me.LblnSolAdmNumero = New System.Windows.Forms.Label()
        Me.LblnPerTipo = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPagoDet = New System.Windows.Forms.Button()
        Me.BtnRegPago = New System.Windows.Forms.Button()
        Me.GrpBoxDetCliente = New System.Windows.Forms.GroupBox()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.LblcNombre = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GrpBoxPersona = New System.Windows.Forms.GroupBox()
        Me.CboPerTipoDocu = New System.Windows.Forms.ComboBox()
        Me.CboTipoPer = New System.Windows.Forms.ComboBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtNroFind = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LblnIntCodigo = New System.Windows.Forms.Label()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox.SuspendLayout()
        Me.GBCortesia.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxBco.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBxNroCajaSerNum.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxDetCliente.SuspendLayout()
        Me.GrpBoxPersona.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Importe Recibo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(371, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha de Pago:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(48, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Moneda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(29, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nro. Recibo"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(982, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "҉҉    Registro de Pago Multiple"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtpFecDeposito
        '
        Me.DtpFecDeposito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtpFecDeposito.CustomFormat = ""
        Me.DtpFecDeposito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecDeposito.Location = New System.Drawing.Point(125, 96)
        Me.DtpFecDeposito.Name = "DtpFecDeposito"
        Me.DtpFecDeposito.Size = New System.Drawing.Size(94, 21)
        Me.DtpFecDeposito.TabIndex = 3
        Me.DtpFecDeposito.Value = New Date(2013, 10, 17, 0, 0, 0, 0)
        '
        'Table2
        '
        Me.Table2.AllowUserToAddRows = False
        Me.Table2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Table2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nCtaCteForPago, Me.cDescForPago, Me.cPerCodigoBanco, Me.cDescrBanco, Me.dCtaCteFecTransacion, Me.cNroTarjCta, Me.NroTrasacVoucher, Me.nMonCodigo, Me.cDescMoneda, Me.nCtaCtePagImpMon, Me.nTC, Me.nCtaCtePagImporte, Me.nConValor})
        Me.Table2.Location = New System.Drawing.Point(14, 379)
        Me.Table2.Name = "Table2"
        Me.Table2.Size = New System.Drawing.Size(957, 179)
        Me.Table2.TabIndex = 0
        '
        'nCtaCteForPago
        '
        Me.nCtaCteForPago.HeaderText = "nCtaCteForPago"
        Me.nCtaCteForPago.Name = "nCtaCteForPago"
        Me.nCtaCteForPago.Visible = False
        '
        'cDescForPago
        '
        Me.cDescForPago.HeaderText = "Forma de Pago"
        Me.cDescForPago.Name = "cDescForPago"
        Me.cDescForPago.Width = 110
        '
        'cPerCodigoBanco
        '
        Me.cPerCodigoBanco.HeaderText = "cPerCodigoBanco"
        Me.cPerCodigoBanco.Name = "cPerCodigoBanco"
        Me.cPerCodigoBanco.Visible = False
        '
        'cDescrBanco
        '
        Me.cDescrBanco.HeaderText = "Entidad"
        Me.cDescrBanco.Name = "cDescrBanco"
        Me.cDescrBanco.Width = 190
        '
        'dCtaCteFecTransacion
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dCtaCteFecTransacion.DefaultCellStyle = DataGridViewCellStyle2
        Me.dCtaCteFecTransacion.HeaderText = "Fecha Operación"
        Me.dCtaCteFecTransacion.Name = "dCtaCteFecTransacion"
        Me.dCtaCteFecTransacion.Width = 75
        '
        'cNroTarjCta
        '
        Me.cNroTarjCta.HeaderText = "Nro. Tarjeta / Nro. Cta. Corriente"
        Me.cNroTarjCta.Name = "cNroTarjCta"
        Me.cNroTarjCta.Width = 180
        '
        'NroTrasacVoucher
        '
        Me.NroTrasacVoucher.HeaderText = "Voucher / Nº. Ope - Tarj."
        Me.NroTrasacVoucher.Name = "NroTrasacVoucher"
        '
        'nMonCodigo
        '
        Me.nMonCodigo.HeaderText = "nMonCodigo"
        Me.nMonCodigo.Name = "nMonCodigo"
        Me.nMonCodigo.Visible = False
        '
        'cDescMoneda
        '
        Me.cDescMoneda.HeaderText = "Moneda"
        Me.cDescMoneda.Name = "cDescMoneda"
        Me.cDescMoneda.Width = 80
        '
        'nCtaCtePagImpMon
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        Me.nCtaCtePagImpMon.DefaultCellStyle = DataGridViewCellStyle3
        Me.nCtaCtePagImpMon.HeaderText = "Importe Recibe"
        Me.nCtaCtePagImpMon.Name = "nCtaCtePagImpMon"
        Me.nCtaCtePagImpMon.Width = 70
        '
        'nTC
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "N3"
        Me.nTC.DefaultCellStyle = DataGridViewCellStyle4
        Me.nTC.HeaderText = "TC"
        Me.nTC.Name = "nTC"
        Me.nTC.Width = 50
        '
        'nCtaCtePagImporte
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "N2"
        Me.nCtaCtePagImporte.DefaultCellStyle = DataGridViewCellStyle5
        Me.nCtaCtePagImporte.HeaderText = "Importe S/."
        Me.nCtaCtePagImporte.Name = "nCtaCtePagImporte"
        Me.nCtaCtePagImporte.Width = 70
        '
        'nConValor
        '
        Me.nConValor.HeaderText = "nConValor"
        Me.nConValor.Name = "nConValor"
        Me.nConValor.ReadOnly = True
        Me.nConValor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Forma de Pago"
        '
        'CboFormaPago
        '
        Me.CboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboFormaPago.ForeColor = System.Drawing.Color.Black
        Me.CboFormaPago.FormattingEnabled = True
        Me.CboFormaPago.Location = New System.Drawing.Point(107, 101)
        Me.CboFormaPago.Name = "CboFormaPago"
        Me.CboFormaPago.Size = New System.Drawing.Size(195, 23)
        Me.CboFormaPago.TabIndex = 0
        Me.CboFormaPago.Tag = "nConCodigo=1086"
        '
        'LblNroRecibo
        '
        Me.LblNroRecibo.BackColor = System.Drawing.SystemColors.Info
        Me.LblNroRecibo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNroRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroRecibo.ForeColor = System.Drawing.Color.Black
        Me.LblNroRecibo.Location = New System.Drawing.Point(108, 14)
        Me.LblNroRecibo.Name = "LblNroRecibo"
        Me.LblNroRecibo.Size = New System.Drawing.Size(165, 23)
        Me.LblNroRecibo.TabIndex = 115
        Me.LblNroRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboMoneda
        '
        Me.CboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboMoneda.ForeColor = System.Drawing.Color.Black
        Me.CboMoneda.FormattingEnabled = True
        Me.CboMoneda.Location = New System.Drawing.Point(107, 132)
        Me.CboMoneda.Name = "CboMoneda"
        Me.CboMoneda.Size = New System.Drawing.Size(195, 23)
        Me.CboMoneda.TabIndex = 1
        Me.CboMoneda.Tag = "nConCodigo=1001"
        '
        'LblImpRecibo
        '
        Me.LblImpRecibo.BackColor = System.Drawing.SystemColors.Info
        Me.LblImpRecibo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImpRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpRecibo.ForeColor = System.Drawing.Color.Black
        Me.LblImpRecibo.Location = New System.Drawing.Point(108, 42)
        Me.LblImpRecibo.Name = "LblImpRecibo"
        Me.LblImpRecibo.Size = New System.Drawing.Size(114, 23)
        Me.LblImpRecibo.TabIndex = 117
        Me.LblImpRecibo.Text = "0.00"
        Me.LblImpRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrpBox
        '
        Me.GrpBox.Controls.Add(Me.GBCortesia)
        Me.GrpBox.Controls.Add(Me.CboTipoVenta)
        Me.GrpBox.Controls.Add(Me.Label21)
        Me.GrpBox.Controls.Add(Me.PictureBox3)
        Me.GrpBox.Controls.Add(Me.TxtImpPago)
        Me.GrpBox.Controls.Add(Me.CboFormaPago)
        Me.GrpBox.Controls.Add(Me.Label5)
        Me.GrpBox.Controls.Add(Me.Label17)
        Me.GrpBox.Controls.Add(Me.BtnQuitar)
        Me.GrpBox.Controls.Add(Me.Label20)
        Me.GrpBox.Controls.Add(Me.Label2)
        Me.GrpBox.Controls.Add(Me.BtnAdd)
        Me.GrpBox.Controls.Add(Me.DtpFecPago)
        Me.GrpBox.Controls.Add(Me.Label4)
        Me.GrpBox.Controls.Add(Me.LblTC)
        Me.GrpBox.Controls.Add(Me.LblImpRecibo)
        Me.GrpBox.Controls.Add(Me.Label1)
        Me.GrpBox.Controls.Add(Me.CboMoneda)
        Me.GrpBox.Controls.Add(Me.Label3)
        Me.GrpBox.Controls.Add(Me.LblNroRecibo)
        Me.GrpBox.Controls.Add(Me.GrpBoxBco)
        Me.GrpBox.Location = New System.Drawing.Point(38, 123)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(905, 224)
        Me.GrpBox.TabIndex = 119
        Me.GrpBox.TabStop = False
        '
        'GBCortesia
        '
        Me.GBCortesia.Controls.Add(Me.CboMotivDscto)
        Me.GBCortesia.Controls.Add(Me.TxtDetalleDscto)
        Me.GBCortesia.Controls.Add(Me.Label44)
        Me.GBCortesia.Controls.Add(Me.Label43)
        Me.GBCortesia.Location = New System.Drawing.Point(363, 66)
        Me.GBCortesia.Name = "GBCortesia"
        Me.GBCortesia.Size = New System.Drawing.Size(524, 142)
        Me.GBCortesia.TabIndex = 120
        Me.GBCortesia.TabStop = False
        Me.GBCortesia.Text = "Detalle Cortesía"
        '
        'CboMotivDscto
        '
        Me.CboMotivDscto.BackColor = System.Drawing.SystemColors.Info
        Me.CboMotivDscto.DisplayMember = "cIntDescripcion"
        Me.CboMotivDscto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMotivDscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMotivDscto.FormattingEnabled = True
        Me.CboMotivDscto.Location = New System.Drawing.Point(97, 30)
        Me.CboMotivDscto.Name = "CboMotivDscto"
        Me.CboMotivDscto.Size = New System.Drawing.Size(405, 24)
        Me.CboMotivDscto.TabIndex = 29
        Me.CboMotivDscto.Tag = "nIntClase=2802;nIntTipo=1002"
        Me.CboMotivDscto.ValueMember = "nIntCodigo"
        '
        'TxtDetalleDscto
        '
        Me.TxtDetalleDscto.Location = New System.Drawing.Point(97, 60)
        Me.TxtDetalleDscto.MaxLength = 200
        Me.TxtDetalleDscto.Multiline = True
        Me.TxtDetalleDscto.Name = "TxtDetalleDscto"
        Me.TxtDetalleDscto.Size = New System.Drawing.Size(405, 67)
        Me.TxtDetalleDscto.TabIndex = 28
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(48, 31)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(43, 15)
        Me.Label44.TabIndex = 27
        Me.Label44.Text = "Motivo"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(16, 63)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(75, 15)
        Me.Label43.TabIndex = 26
        Me.Label43.Text = "Observación"
        '
        'CboTipoVenta
        '
        Me.CboTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboTipoVenta.ForeColor = System.Drawing.Color.Black
        Me.CboTipoVenta.FormattingEnabled = True
        Me.CboTipoVenta.Location = New System.Drawing.Point(107, 71)
        Me.CboTipoVenta.Name = "CboTipoVenta"
        Me.CboTipoVenta.Size = New System.Drawing.Size(195, 23)
        Me.CboTipoVenta.TabIndex = 119
        Me.CboTipoVenta.Tag = "nConCodigo=6010"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(19, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 15)
        Me.Label21.TabIndex = 118
        Me.Label21.Text = "Tipo de Venta"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Integration.Test.My.Resources.Resources.tarjeta
        Me.PictureBox3.Location = New System.Drawing.Point(477, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(300, 192)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'TxtImpPago
        '
        Me.TxtImpPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpPago.ForeColor = System.Drawing.Color.Black
        Me.TxtImpPago.Location = New System.Drawing.Point(106, 162)
        Me.TxtImpPago.Name = "TxtImpPago"
        Me.TxtImpPago.Size = New System.Drawing.Size(116, 22)
        Me.TxtImpPago.TabIndex = 2
        Me.TxtImpPago.Text = "0.00"
        Me.TxtImpPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(48, 165)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Importe"
        '
        'BtnQuitar
        '
        Me.BtnQuitar.ForeColor = System.Drawing.Color.Black
        Me.BtnQuitar.Image = Global.Integration.Test.My.Resources.Resources.money_delete
        Me.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitar.Location = New System.Drawing.Point(208, 189)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(142, 28)
        Me.BtnQuitar.TabIndex = 4
        Me.BtnQuitar.Text = "Quitar Item (SUPR)"
        Me.BtnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(670, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 15)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Tipo de Cambio:"
        '
        'BtnAdd
        '
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.Image = Global.Integration.Test.My.Resources.Resources.money_add
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(88, 190)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(114, 28)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "Agregar (INS)"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'DtpFecPago
        '
        Me.DtpFecPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtpFecPago.CustomFormat = ""
        Me.DtpFecPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecPago.Location = New System.Drawing.Point(474, 14)
        Me.DtpFecPago.Name = "DtpFecPago"
        Me.DtpFecPago.Size = New System.Drawing.Size(96, 21)
        Me.DtpFecPago.TabIndex = 112
        Me.DtpFecPago.Value = New Date(2013, 10, 17, 0, 0, 0, 0)
        '
        'LblTC
        '
        Me.LblTC.BackColor = System.Drawing.SystemColors.Info
        Me.LblTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTC.ForeColor = System.Drawing.Color.Black
        Me.LblTC.Location = New System.Drawing.Point(769, 15)
        Me.LblTC.Name = "LblTC"
        Me.LblTC.Size = New System.Drawing.Size(114, 23)
        Me.LblTC.TabIndex = 117
        Me.LblTC.Text = "0.00"
        Me.LblTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrpBoxBco
        '
        Me.GrpBoxBco.Controls.Add(Me.PictureBox2)
        Me.GrpBoxBco.Controls.Add(Me.TxtNroTarjeta)
        Me.GrpBoxBco.Controls.Add(Me.TxtVoucher)
        Me.GrpBoxBco.Controls.Add(Me.CboTipoTarj)
        Me.GrpBoxBco.Controls.Add(Me.CboBanco)
        Me.GrpBoxBco.Controls.Add(Me.Label15)
        Me.GrpBoxBco.Controls.Add(Me.Label10)
        Me.GrpBoxBco.Controls.Add(Me.Label14)
        Me.GrpBoxBco.Controls.Add(Me.Label12)
        Me.GrpBoxBco.Controls.Add(Me.Label13)
        Me.GrpBoxBco.Controls.Add(Me.DtpFecDeposito)
        Me.GrpBoxBco.ForeColor = System.Drawing.Color.Navy
        Me.GrpBoxBco.Location = New System.Drawing.Point(363, 66)
        Me.GrpBoxBco.Name = "GrpBoxBco"
        Me.GrpBoxBco.Size = New System.Drawing.Size(524, 152)
        Me.GrpBoxBco.TabIndex = 4
        Me.GrpBoxBco.TabStop = False
        Me.GrpBoxBco.Text = " Detalle "
        Me.GrpBoxBco.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Integration.Test.My.Resources.Resources.help1
        Me.PictureBox2.Location = New System.Drawing.Point(417, 74)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'TxtNroTarjeta
        '
        Me.TxtNroTarjeta.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNroTarjeta.ForeColor = System.Drawing.Color.Black
        Me.TxtNroTarjeta.Location = New System.Drawing.Point(125, 70)
        Me.TxtNroTarjeta.Name = "TxtNroTarjeta"
        Me.TxtNroTarjeta.Size = New System.Drawing.Size(286, 21)
        Me.TxtNroTarjeta.TabIndex = 2
        '
        'TxtVoucher
        '
        Me.TxtVoucher.BackColor = System.Drawing.SystemColors.Info
        Me.TxtVoucher.ForeColor = System.Drawing.Color.Black
        Me.TxtVoucher.Location = New System.Drawing.Point(125, 123)
        Me.TxtVoucher.Name = "TxtVoucher"
        Me.TxtVoucher.Size = New System.Drawing.Size(247, 21)
        Me.TxtVoucher.TabIndex = 4
        '
        'CboTipoTarj
        '
        Me.CboTipoTarj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoTarj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboTipoTarj.ForeColor = System.Drawing.Color.Black
        Me.CboTipoTarj.FormattingEnabled = True
        Me.CboTipoTarj.Location = New System.Drawing.Point(125, 43)
        Me.CboTipoTarj.Name = "CboTipoTarj"
        Me.CboTipoTarj.Size = New System.Drawing.Size(387, 23)
        Me.CboTipoTarj.TabIndex = 1
        Me.CboTipoTarj.Tag = "nConCodigo=1117"
        '
        'CboBanco
        '
        Me.CboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboBanco.ForeColor = System.Drawing.Color.Black
        Me.CboBanco.FormattingEnabled = True
        Me.CboBanco.Location = New System.Drawing.Point(125, 16)
        Me.CboBanco.Name = "CboBanco"
        Me.CboBanco.Size = New System.Drawing.Size(387, 23)
        Me.CboBanco.TabIndex = 0
        Me.CboBanco.Tag = "nPerJurSecEconomico=131"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(7, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Nro. Operacion:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Cuenta:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(7, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Fecha Deposito:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(7, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Tipo de Tarjeta:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(10, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 15)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Banco:"
        '
        'LblTotalPago
        '
        Me.LblTotalPago.BackColor = System.Drawing.SystemColors.Info
        Me.LblTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPago.ForeColor = System.Drawing.Color.Black
        Me.LblTotalPago.Location = New System.Drawing.Point(840, 561)
        Me.LblTotalPago.Name = "LblTotalPago"
        Me.LblTotalPago.Size = New System.Drawing.Size(114, 31)
        Me.LblTotalPago.TabIndex = 117
        Me.LblTotalPago.Text = "0.00"
        Me.LblTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(743, 571)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Cobrado:"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(15, 356)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(956, 23)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Detalle Pago Multiple"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtStrDetalle
        '
        Me.TxtStrDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStrDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStrDetalle.Enabled = False
        Me.TxtStrDetalle.Font = New System.Drawing.Font("Tahoma", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStrDetalle.Location = New System.Drawing.Point(10, 20)
        Me.TxtStrDetalle.Multiline = True
        Me.TxtStrDetalle.Name = "TxtStrDetalle"
        Me.TxtStrDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtStrDetalle.Size = New System.Drawing.Size(887, 90)
        Me.TxtStrDetalle.TabIndex = 121
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtStrDetalle)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(14, 618)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(905, 117)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Detalles... "
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
        Me.GrpBxNroCajaSerNum.Location = New System.Drawing.Point(38, 27)
        Me.GrpBxNroCajaSerNum.Name = "GrpBxNroCajaSerNum"
        Me.GrpBxNroCajaSerNum.Size = New System.Drawing.Size(904, 53)
        Me.GrpBxNroCajaSerNum.TabIndex = 123
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
        'LblnPerCtaCodigo
        '
        Me.LblnPerCtaCodigo.AutoSize = True
        Me.LblnPerCtaCodigo.Location = New System.Drawing.Point(635, 569)
        Me.LblnPerCtaCodigo.Name = "LblnPerCtaCodigo"
        Me.LblnPerCtaCodigo.Size = New System.Drawing.Size(14, 15)
        Me.LblnPerCtaCodigo.TabIndex = 124
        Me.LblnPerCtaCodigo.Text = "_"
        Me.LblnPerCtaCodigo.Visible = False
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
        'LblnSolAdmNumero
        '
        Me.LblnSolAdmNumero.AutoSize = True
        Me.LblnSolAdmNumero.Location = New System.Drawing.Point(523, 571)
        Me.LblnSolAdmNumero.Name = "LblnSolAdmNumero"
        Me.LblnSolAdmNumero.Size = New System.Drawing.Size(14, 15)
        Me.LblnSolAdmNumero.TabIndex = 126
        Me.LblnSolAdmNumero.Text = "_"
        Me.LblnSolAdmNumero.Visible = False
        '
        'LblnPerTipo
        '
        Me.LblnPerTipo.AutoSize = True
        Me.LblnPerTipo.Location = New System.Drawing.Point(635, 600)
        Me.LblnPerTipo.Name = "LblnPerTipo"
        Me.LblnPerTipo.Size = New System.Drawing.Size(14, 15)
        Me.LblnPerTipo.TabIndex = 127
        Me.LblnPerTipo.Text = "_"
        Me.LblnPerTipo.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources.Cancel_32x32
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(210, 565)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(171, 46)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "         Cancelar (ESC)"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.table_money
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 128
        Me.PictureBox1.TabStop = False
        '
        'BtnPagoDet
        '
        Me.BtnPagoDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagoDet.ForeColor = System.Drawing.Color.Black
        Me.BtnPagoDet.Image = Global.Integration.Test.My.Resources.Resources.google_adsense
        Me.BtnPagoDet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPagoDet.Location = New System.Drawing.Point(415, 565)
        Me.BtnPagoDet.Name = "BtnPagoDet"
        Me.BtnPagoDet.Size = New System.Drawing.Size(99, 46)
        Me.BtnPagoDet.TabIndex = 0
        Me.BtnPagoDet.Text = "      Más detalles (F8) »"
        Me.BtnPagoDet.UseVisualStyleBackColor = True
        Me.BtnPagoDet.Visible = False
        '
        'BtnRegPago
        '
        Me.BtnRegPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegPago.ForeColor = System.Drawing.Color.Black
        Me.BtnRegPago.Image = Global.Integration.Test.My.Resources.Resources.Apply_32x32
        Me.BtnRegPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegPago.Location = New System.Drawing.Point(14, 565)
        Me.BtnRegPago.Name = "BtnRegPago"
        Me.BtnRegPago.Size = New System.Drawing.Size(189, 46)
        Me.BtnRegPago.TabIndex = 1
        Me.BtnRegPago.Text = "          Registrar Pago (F4)"
        Me.BtnRegPago.UseVisualStyleBackColor = True
        '
        'GrpBoxDetCliente
        '
        Me.GrpBoxDetCliente.Controls.Add(Me.BtnCambiar)
        Me.GrpBoxDetCliente.Controls.Add(Me.LblcNombre)
        Me.GrpBoxDetCliente.Controls.Add(Me.Label19)
        Me.GrpBoxDetCliente.Controls.Add(Me.LblcPerCodigo)
        Me.GrpBoxDetCliente.Location = New System.Drawing.Point(38, 78)
        Me.GrpBoxDetCliente.Name = "GrpBoxDetCliente"
        Me.GrpBoxDetCliente.Size = New System.Drawing.Size(905, 45)
        Me.GrpBoxDetCliente.TabIndex = 129
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
        'GrpBoxPersona
        '
        Me.GrpBoxPersona.BackColor = System.Drawing.Color.Salmon
        Me.GrpBoxPersona.Controls.Add(Me.CboPerTipoDocu)
        Me.GrpBoxPersona.Controls.Add(Me.CboTipoPer)
        Me.GrpBoxPersona.Controls.Add(Me.BtnAgregar)
        Me.GrpBoxPersona.Controls.Add(Me.Label25)
        Me.GrpBoxPersona.Controls.Add(Me.Label26)
        Me.GrpBoxPersona.Controls.Add(Me.TxtNroFind)
        Me.GrpBoxPersona.Controls.Add(Me.Label28)
        Me.GrpBoxPersona.Location = New System.Drawing.Point(38, 78)
        Me.GrpBoxPersona.Name = "GrpBoxPersona"
        Me.GrpBoxPersona.Size = New System.Drawing.Size(904, 45)
        Me.GrpBoxPersona.TabIndex = 0
        Me.GrpBoxPersona.TabStop = False
        Me.GrpBoxPersona.Visible = False
        '
        'CboPerTipoDocu
        '
        Me.CboPerTipoDocu.BackColor = System.Drawing.SystemColors.Info
        Me.CboPerTipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPerTipoDocu.FormattingEnabled = True
        Me.CboPerTipoDocu.Location = New System.Drawing.Point(380, 13)
        Me.CboPerTipoDocu.Name = "CboPerTipoDocu"
        Me.CboPerTipoDocu.Size = New System.Drawing.Size(231, 23)
        Me.CboPerTipoDocu.TabIndex = 1
        '
        'CboTipoPer
        '
        Me.CboTipoPer.BackColor = System.Drawing.SystemColors.Info
        Me.CboTipoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPer.FormattingEnabled = True
        Me.CboTipoPer.Location = New System.Drawing.Point(116, 13)
        Me.CboTipoPer.Name = "CboTipoPer"
        Me.CboTipoPer.Size = New System.Drawing.Size(156, 23)
        Me.CboTipoPer.TabIndex = 0
        Me.CboTipoPer.Tag = "1010"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Image = Global.Integration.Test.My.Resources.Resources.user
        Me.BtnAgregar.Location = New System.Drawing.Point(851, 16)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(30, 21)
        Me.BtnAgregar.TabIndex = 3
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(279, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 15)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Tipo documento"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(32, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Tipo persona"
        '
        'TxtNroFind
        '
        Me.TxtNroFind.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNroFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroFind.Location = New System.Drawing.Point(724, 15)
        Me.TxtNroFind.Name = "TxtNroFind"
        Me.TxtNroFind.Size = New System.Drawing.Size(126, 21)
        Me.TxtNroFind.TabIndex = 2
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(621, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(97, 15)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Nro. Documento"
        '
        'LblnIntCodigo
        '
        Me.LblnIntCodigo.AutoSize = True
        Me.LblnIntCodigo.Location = New System.Drawing.Point(523, 597)
        Me.LblnIntCodigo.Name = "LblnIntCodigo"
        Me.LblnIntCodigo.Size = New System.Drawing.Size(14, 15)
        Me.LblnIntCodigo.TabIndex = 130
        Me.LblnIntCodigo.Text = "_"
        Me.LblnIntCodigo.Visible = False
        '
        'FormPrcFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(982, 621)
        Me.Controls.Add(Me.LblnIntCodigo)
        Me.Controls.Add(Me.GrpBxNroCajaSerNum)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblnPerTipo)
        Me.Controls.Add(Me.LblnSolAdmNumero)
        Me.Controls.Add(Me.LblnPerCtaCodigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GrpBox)
        Me.Controls.Add(Me.Table2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnPagoDet)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblTotalPago)
        Me.Controls.Add(Me.BtnRegPago)
        Me.Controls.Add(Me.GrpBoxDetCliente)
        Me.Controls.Add(Me.GrpBoxPersona)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormPrcFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Pago"
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox.ResumeLayout(False)
        Me.GrpBox.PerformLayout()
        Me.GBCortesia.ResumeLayout(False)
        Me.GBCortesia.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxBco.ResumeLayout(False)
        Me.GrpBoxBco.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpBxNroCajaSerNum.ResumeLayout(False)
        Me.GrpBxNroCajaSerNum.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxDetCliente.ResumeLayout(False)
        Me.GrpBoxDetCliente.PerformLayout()
        Me.GrpBoxPersona.ResumeLayout(False)
        Me.GrpBoxPersona.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtpFecDeposito As System.Windows.Forms.DateTimePicker
    Friend WithEvents Table2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents LblNroRecibo As System.Windows.Forms.Label
    Friend WithEvents CboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents LblImpRecibo As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxBco As System.Windows.Forms.GroupBox
    Friend WithEvents TxtVoucher As System.Windows.Forms.TextBox
    Friend WithEvents CboTipoTarj As System.Windows.Forms.ComboBox
    Friend WithEvents CboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DtpFecPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTotalPago As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnRegPago As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtImpPago As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LblTC As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnPagoDet As System.Windows.Forms.Button
    Friend WithEvents TxtStrDetalle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBxNroCajaSerNum As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblCorrelativo As System.Windows.Forms.Label
    Friend WithEvents LblSerie As System.Windows.Forms.Label
    Friend WithEvents CboTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents LblNroCaja As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNroTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents LblnPerCtaCodigo As System.Windows.Forms.Label
    Friend WithEvents LblcPerCodigo As System.Windows.Forms.Label
    Friend WithEvents LblnSolAdmNumero As System.Windows.Forms.Label
    Friend WithEvents LblnPerTipo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GrpBoxDetCliente As System.Windows.Forms.GroupBox
    Friend WithEvents LblcNombre As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxPersona As System.Windows.Forms.GroupBox
    Friend WithEvents CboPerTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents CboTipoPer As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtNroFind As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnCambiar As System.Windows.Forms.Button
    Friend WithEvents LblnIntCodigo As System.Windows.Forms.Label
    Friend WithEvents nCtaCteForPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescForPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerCodigoBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescrBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dCtaCteFecTransacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNroTarjCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroTrasacVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nMonCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCtePagImpMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCtePagImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nConValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CboTipoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GBCortesia As System.Windows.Forms.GroupBox
    Friend WithEvents CboMotivDscto As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDetalleDscto As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
End Class
