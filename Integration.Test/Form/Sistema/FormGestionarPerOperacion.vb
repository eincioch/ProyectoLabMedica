
Imports Integration.BE.Persona
Imports Integration.BL.BL_Persona

Public Class FormGestionarPerOperacion

    Private v_nOpeCodigo As Integer = 0

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        If Not ValidarApertura(1) Then Exit Sub
        Close()
        Dispose()

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Try
            Dim perOperacion As New PerOperacion
            Dim gestionarPerOperacionServicio As New GestionarPerOperacionServicio

            If ValidarApertura(2) Then
                MessageBox.Show("Ya se hizo cierre de Sucursal.", "Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            perOperacion.cPerJurCodigo = StrcPerJuridica
            perOperacion.nOpeCodigo = v_nOpeCodigo
            perOperacion.fMonto = FormatNumber(TxtImporte.Text, True)
            perOperacion.cOpeHost = My.Computer.Name.ToUpper
            perOperacion.cObservacion = TxtObservacion.Text

            If Not gestionarPerOperacionServicio.Insert_PerOperacion(perOperacion) Then
                Throw New ArgumentException("Se encontraron errores, por favor comuníquese con el área de Sistemas.")
            Else
                Call Actualizar_FechaHora_Servidor(gnAdelantoReloj)
                MessageBox.Show(LblTitle.Text & ": " & dFechaHoraSistema & ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BtnCancelar_Click(BtnCancelar, Nothing)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub FormGestionarPerOperacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not ValidarApertura(1) Then
            LblTitle.Text = "Apertura de Sucursal"
            LblSubTitle.Text = "Apertura de Sucursal"
            Label3.Text = "Monto de Apertura:"
            v_nOpeCodigo = 1
        Else
            LblTitle.Text = "Cierre de Sucursal"
            LblSubTitle.Text = "Cierre de Sucursal"
            Label3.Text = "Monto de Cierre:"
            v_nOpeCodigo = 2
        End If

    End Sub

End Class