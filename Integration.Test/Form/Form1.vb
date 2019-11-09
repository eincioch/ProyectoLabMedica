
Imports Integration.DataIntegration
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim user As String = Me.TextBox1.Text
        Dim Pass As String = Me.TextBox2.Text
        'Dim dr As SqlDataReader
        Dim dt As New DataTable
        Dim objInterface As New Integration.DataIntegration.clsInterface


        Dim ObjEncrypt As New Integration.Conection.clsCrypt
        Dim vUser As String = ""
        Dim vPass As String = ""

        Dim Resultado As Long
        vUser = UCase(Me.TextBox1.Text)
        vPass = ObjEncrypt.EncryptByCode(vUser, Me.TextBox2.Text)
        MsgBox(vPass)
        Resultado = objInterface.Upd_InterfaceByClase(90000, 1006, "UNIVERSIDAD AUTONOMA DEL PERU")

        If Resultado = 0 Then
            dt = objInterface.GetInterfaceByClase(1006)

            ' dt.Load(dr)
            DataGridView1.DataSource = dt
        Else
            MsgBox("error")
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If MessageBox.Show("¿Desea cambiar los parametros de conexion.?", "Config Regedit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Dim Registro As New Integration.Conection.clsReadRegEdit
            Dim ObjEncrypt As New Integration.Conection.clsCrypt

            Dim Server As String = ObjEncrypt.EncryptReg(Trim(Me.TextBox3.Text))
            Dim db As String = ObjEncrypt.EncryptReg(Trim(Me.TextBox6.Text))
            Dim vUser As String = ObjEncrypt.EncryptReg(Trim(Me.TextBox4.Text))
            Dim vPass As String = ObjEncrypt.EncryptReg(Trim(Me.TextBox5.Text))

            Registro.SetValueRegEdit("Conexiones\Naylamp", "SERVER", Server)
            'Dim vBase As String = ObjEncrypt.EncryptReg(db)
            Registro.SetValueRegEdit("Conexiones\Naylamp", "DATABASE", db)
            Registro.SetValueRegEdit("Conexiones\Naylamp", "UID", vUser)
            Registro.SetValueRegEdit("Conexiones\Naylamp", "PWD", vPass)
            'Registro.SetValueRegEdit("Conexiones\Naylamp", "Path", "D:\")

        End If

    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click
        Dispose()
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
