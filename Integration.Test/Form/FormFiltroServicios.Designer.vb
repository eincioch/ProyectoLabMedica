<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFiltroServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFiltroServicios))
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
        Me.LstBoxCampana = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboCampana = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Table1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(901, 388)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Parámetros de búsqueda"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Integration.Test.My.Resources.Resources.medica
        Me.PictureBox2.Location = New System.Drawing.Point(35, 54)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 37)
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
        Me.TabControl1.Location = New System.Drawing.Point(100, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(707, 95)
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
        Me.TabPage1.Size = New System.Drawing.Size(699, 64)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "por Codigo (F1)"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(120, 21)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(172, 24)
        Me.TxtCodigo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 25)
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
        Me.TabPage3.Size = New System.Drawing.Size(699, 64)
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
        Me.CboClase.Location = New System.Drawing.Point(109, 21)
        Me.CboClase.Name = "CboClase"
        Me.CboClase.Size = New System.Drawing.Size(559, 26)
        Me.CboClase.TabIndex = 1
        Me.CboClase.Tag = "nIntClase=1014;nIntTipo=1000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 26)
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
        Me.TabPage2.Size = New System.Drawing.Size(699, 64)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "por Descripción (F3)"
        '
        'TxtCaracter
        '
        Me.TxtCaracter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCaracter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCaracter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaracter.Location = New System.Drawing.Point(137, 20)
        Me.TxtCaracter.Name = "TxtCaracter"
        Me.TxtCaracter.Size = New System.Drawing.Size(523, 24)
        Me.TxtCaracter.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 24)
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
        Me.TabPage4.Size = New System.Drawing.Size(699, 64)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "por Perfiles (F12)"
        Me.TabPage4.ToolTipText = "Muestra Perfiles"
        '
        'LblTotalPago
        '
        Me.LblTotalPago.BackColor = System.Drawing.SystemColors.Info
        Me.LblTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPago.ForeColor = System.Drawing.Color.Black
        Me.LblTotalPago.Location = New System.Drawing.Point(565, 16)
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
        Me.CboPerfil.Location = New System.Drawing.Point(29, 21)
        Me.CboPerfil.Name = "CboPerfil"
        Me.CboPerfil.Size = New System.Drawing.Size(508, 23)
        Me.CboPerfil.TabIndex = 2
        Me.CboPerfil.Tag = "nIntClase=1060;nIntTipo=1000"
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Location = New System.Drawing.Point(7, 138)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(882, 242)
        Me.Table1.TabIndex = 9
        '
        'LstBoxCampana
        '
        Me.LstBoxCampana.BackColor = System.Drawing.Color.White
        Me.LstBoxCampana.Enabled = False
        Me.LstBoxCampana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBoxCampana.ForeColor = System.Drawing.Color.Maroon
        Me.LstBoxCampana.FormattingEnabled = True
        Me.LstBoxCampana.HorizontalScrollbar = True
        Me.LstBoxCampana.ItemHeight = 16
        Me.LstBoxCampana.Location = New System.Drawing.Point(934, 40)
        Me.LstBoxCampana.Name = "LstBoxCampana"
        Me.LstBoxCampana.Size = New System.Drawing.Size(303, 308)
        Me.LstBoxCampana.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(995, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Campaña Vigente(s) *"
        '
        'CboCampana
        '
        Me.CboCampana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CboCampana.FormattingEnabled = True
        Me.CboCampana.Location = New System.Drawing.Point(492, 398)
        Me.CboCampana.Name = "CboCampana"
        Me.CboCampana.Size = New System.Drawing.Size(70, 52)
        Me.CboCampana.TabIndex = 14
        Me.CboCampana.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(70, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(416, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Seleccione el Examen marcando el Check para agregarlo, por favor."
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(934, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(303, 32)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "҉    Campaña VIGENTES"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.CheckButtons_32x32
        Me.PictureBox1.Location = New System.Drawing.Point(27, 404)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 39)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Integration.Test.My.Resources.Resources.cancel1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(745, 398)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(157, 45)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "        &Cancelar (ESC)"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Image = Global.Integration.Test.My.Resources.Resources.accept
        Me.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeleccionar.Location = New System.Drawing.Point(581, 398)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(157, 45)
        Me.BtnSeleccionar.TabIndex = 0
        Me.BtnSeleccionar.Text = "          &Agregar (INS)"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'FormFiltroServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1250, 456)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LstBoxCampana)
        Me.Controls.Add(Me.CboCampana)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormFiltroServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Servicios"
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboClase As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCaracter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents LstBoxCampana As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents CboCampana As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents CboPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents LblTotalPago As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
End Class
