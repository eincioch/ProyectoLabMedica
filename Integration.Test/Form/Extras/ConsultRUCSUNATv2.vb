Option Explicit On

Imports ConsultSUNAT.evSUNAT

Public Class ConsultRUCSUNATv2

    Dim myInfo As ConsultSUNAT.evSUNAT

    Private Sub CargarImagen()
        Try
            'If IsNothing(myInfo) Then
            myInfo = New ConsultSUNAT.evSUNAT()
            pictureCapcha.Image = myInfo.GetCapcha
            'End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ConsultRUCSUNATv2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarImagen()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            'llamamos a los metodos de la libreria ConsultaReniec...
            myInfo.GetInfo(txtNumDni.Text, txtCapcha.Text)
            txtDireccion.Text = myInfo.ApeMaterno
            txtRazon.Text = myInfo.Nombres
            txtRuc.Text = txtNumDni.Text

            txtNumDni.Text = ""
            txtCapcha.Text = ""
            CargarImagen()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarImagen()
    End Sub

    Private Sub txtNumDni_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDni.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            myInfo.GetInfo(txtNumDni.Text, myInfo.UseTesseract())
            If (myInfo.Nombres = "Error!") Then

                CargarImagen()
                myInfo.GetInfo(txtNumDni.Text, myInfo.UseTesseract())
                txtDireccion.Text = myInfo.ApeMaterno
                txtRazon.Text = myInfo.Nombres
                txtRuc.Text = txtNumDni.Text
                txtNumDni.Text = ""
                txtCapcha.Text = ""
                CargarImagen()

            Else
                txtDireccion.Text = myInfo.ApeMaterno
                txtRazon.Text = myInfo.Nombres
                txtRuc.Text = txtNumDni.Text
                txtNumDni.Text = ""
                txtCapcha.Text = ""
                CargarImagen()
            End If
        End If

    End Sub

End Class