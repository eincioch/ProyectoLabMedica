<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcSQLPrecio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcSQLPrecio))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CboClase = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtCaracter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LblTotalPago = New System.Windows.Forms.Label()
        Me.CboPerfil = New System.Windows.Forms.ComboBox()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.nKey = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cPerJurCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIntJerarquia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteSerJerarquia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteSerKeyWord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nMonCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nIntCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
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
        Me.Label6.Size = New System.Drawing.Size(940, 32)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "҉    Consulta de Precios"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(771, 504)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(118, 32)
        Me.BtnCancelar.TabIndex = 20
        Me.BtnCancelar.Text = "        &Cerrar (ESC)"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Table1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 451)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Filtro de busqueda"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Integration.Test.My.Resources.Resources.medica
        Me.PictureBox2.Location = New System.Drawing.Point(8, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(59, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(815, 95)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Bisque
        Me.TabPage1.Controls.Add(Me.TxtCodigo)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(807, 64)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "por Codigo (F1)"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(118, 16)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(172, 24)
        Me.TxtCodigo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Código"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Bisque
        Me.TabPage3.Controls.Add(Me.CboClase)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(807, 64)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Grupo / Clase (F2)"
        '
        'CboClase
        '
        Me.CboClase.BackColor = System.Drawing.SystemColors.Info
        Me.CboClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboClase.FormattingEnabled = True
        Me.CboClase.Location = New System.Drawing.Point(156, 15)
        Me.CboClase.Name = "CboClase"
        Me.CboClase.Size = New System.Drawing.Size(559, 26)
        Me.CboClase.TabIndex = 1
        Me.CboClase.Tag = "nIntClase=1014;nIntTipo=1000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clase"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Bisque
        Me.TabPage2.Controls.Add(Me.TxtCaracter)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(807, 64)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "por Descripción (F3)"
        '
        'TxtCaracter
        '
        Me.TxtCaracter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCaracter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCaracter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaracter.Location = New System.Drawing.Point(195, 20)
        Me.TxtCaracter.Name = "TxtCaracter"
        Me.TxtCaracter.Size = New System.Drawing.Size(523, 24)
        Me.TxtCaracter.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Bisque
        Me.TabPage4.Controls.Add(Me.LblTotalPago)
        Me.TabPage4.Controls.Add(Me.CboPerfil)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(807, 64)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "por Perfiles"
        Me.TabPage4.ToolTipText = "Muestra Perfiles"
        '
        'LblTotalPago
        '
        Me.LblTotalPago.BackColor = System.Drawing.SystemColors.Info
        Me.LblTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPago.ForeColor = System.Drawing.Color.Black
        Me.LblTotalPago.Location = New System.Drawing.Point(666, 13)
        Me.LblTotalPago.Name = "LblTotalPago"
        Me.LblTotalPago.Size = New System.Drawing.Size(114, 31)
        Me.LblTotalPago.TabIndex = 136
        Me.LblTotalPago.Text = "0.00"
        Me.LblTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboPerfil
        '
        Me.CboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPerfil.FormattingEnabled = True
        Me.CboPerfil.Location = New System.Drawing.Point(31, 18)
        Me.CboPerfil.Name = "CboPerfil"
        Me.CboPerfil.Size = New System.Drawing.Size(627, 23)
        Me.CboPerfil.TabIndex = 2
        Me.CboPerfil.Tag = "nIntClase=1060;nIntTipo=1000"
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nKey, Me.cPerJurCodigo, Me.nCtaCteSerCodigo, Me.cIntJerarquia, Me.cCtaCteSerJerarquia, Me.cCtaCteSerKeyWord, Me.nMonCodigo, Me.nIntCodigo, Me.nCtaCteSerCosto, Me.nFlag})
        Me.Table1.Location = New System.Drawing.Point(7, 138)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(890, 300)
        Me.Table1.TabIndex = 9
        '
        'nKey
        '
        Me.nKey.DataPropertyName = "nKey"
        Me.nKey.FalseValue = "0"
        Me.nKey.HeaderText = "?"
        Me.nKey.IndeterminateValue = "0"
        Me.nKey.Name = "nKey"
        Me.nKey.ReadOnly = True
        Me.nKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.nKey.TrueValue = "1"
        Me.nKey.Visible = False
        Me.nKey.Width = 30
        '
        'cPerJurCodigo
        '
        Me.cPerJurCodigo.DataPropertyName = "cPerJurCodigo"
        Me.cPerJurCodigo.HeaderText = "cPerJurCodigo"
        Me.cPerJurCodigo.Name = "cPerJurCodigo"
        Me.cPerJurCodigo.Visible = False
        Me.cPerJurCodigo.Width = 90
        '
        'nCtaCteSerCodigo
        '
        Me.nCtaCteSerCodigo.DataPropertyName = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.HeaderText = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.Name = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.Visible = False
        Me.nCtaCteSerCodigo.Width = 30
        '
        'cIntJerarquia
        '
        Me.cIntJerarquia.DataPropertyName = "cIntJerarquia"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cIntJerarquia.DefaultCellStyle = DataGridViewCellStyle1
        Me.cIntJerarquia.HeaderText = "Clase"
        Me.cIntJerarquia.Name = "cIntJerarquia"
        Me.cIntJerarquia.Width = 80
        '
        'cCtaCteSerJerarquia
        '
        Me.cCtaCteSerJerarquia.DataPropertyName = "cCtaCteSerJerarquia"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cCtaCteSerJerarquia.DefaultCellStyle = DataGridViewCellStyle2
        Me.cCtaCteSerJerarquia.HeaderText = "Cod. Laboratorio"
        Me.cCtaCteSerJerarquia.Name = "cCtaCteSerJerarquia"
        Me.cCtaCteSerJerarquia.ReadOnly = True
        Me.cCtaCteSerJerarquia.Width = 120
        '
        'cCtaCteSerKeyWord
        '
        Me.cCtaCteSerKeyWord.DataPropertyName = "cCtaCteSerKeyWord"
        Me.cCtaCteSerKeyWord.HeaderText = "Descripción"
        Me.cCtaCteSerKeyWord.Name = "cCtaCteSerKeyWord"
        Me.cCtaCteSerKeyWord.ReadOnly = True
        Me.cCtaCteSerKeyWord.Width = 460
        '
        'nMonCodigo
        '
        Me.nMonCodigo.DataPropertyName = "nMonCodigo"
        Me.nMonCodigo.HeaderText = "nMonCodigo"
        Me.nMonCodigo.Name = "nMonCodigo"
        Me.nMonCodigo.Visible = False
        Me.nMonCodigo.Width = 20
        '
        'nIntCodigo
        '
        Me.nIntCodigo.DataPropertyName = "nIntCodigo"
        Me.nIntCodigo.HeaderText = "nIntCodigo"
        Me.nIntCodigo.Name = "nIntCodigo"
        Me.nIntCodigo.Visible = False
        Me.nIntCodigo.Width = 20
        '
        'nCtaCteSerCosto
        '
        Me.nCtaCteSerCosto.DataPropertyName = "nCtaCteSerCosto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.nCtaCteSerCosto.DefaultCellStyle = DataGridViewCellStyle3
        Me.nCtaCteSerCosto.HeaderText = "Precio"
        Me.nCtaCteSerCosto.Name = "nCtaCteSerCosto"
        Me.nCtaCteSerCosto.ReadOnly = True
        '
        'nFlag
        '
        Me.nFlag.DataPropertyName = "nFlag"
        Me.nFlag.HeaderText = "nFlag"
        Me.nFlag.Name = "nFlag"
        Me.nFlag.Visible = False
        '
        'FormPrcSQLPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(940, 549)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormPrcSQLPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Precios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CboClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TxtCaracter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents LblTotalPago As System.Windows.Forms.Label
    Friend WithEvents CboPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents nKey As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cPerJurCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCteSerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIntJerarquia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCtaCteSerJerarquia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCtaCteSerKeyWord As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nMonCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nIntCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCteSerCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nFlag As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
