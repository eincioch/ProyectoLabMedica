Option Explicit On

Imports Integration.BE.FichaAtencion
Imports Integration.BL.BL_FichaAtencion
Imports CrystalDecisions.CrystalReports.Engine
Imports ServicioHIS


Public Class FormGridFichaAtencion

#Region "Estructura Grilla"

    Enum GrillaAdmSolicitud

        ColnImgTipoAtencion = 0
        ColcPerJuridica = 1
        ColnIntCodigo = 2
        ColcIntDescripcion = 3
        ColcPerCodigoTerceros = 4
        ColnSolAdmNumero = 5
        ColcPerCodigo = 6
        ColcPerIdeNumero = 7
        ColcPerApellidos = 8
        ColcPerNombreCompleto = 9
        ColdPerNacimiento = 10
        ColdFecEntResultado = 13
        ColImgStatus = 14
        ColnAdmSolEstado = 15
        ColcConDescripcion = 16
        ColnImpTotal = 17
        ColnImpAnticipo = 18
        ColnSaldo = 19
        ColcCtaCteRecibo = 20
        ColcPerUseCodigo = 21
        ColnPerTipo = 22
        ColnCtaCteCuota = 23
        ColnExportEstado = 24
        ColImgExportLIS = 25
        ColcExportEstado = 26
        ColcNroOrdenLIS = 27
        ColnFlagComision = 28
        ColnPerIntCodigo = 29 'Update 2016-04-20 (EINCIO)
        ColnValidaToma = 30
        ColnValidaEntrega = 31
        ColnValidaResultado = 32
        ColnValidaRecogo = 33
        ColcTiempoEntrega = 11
        ColcEstadoResultado = 12
        ColdFecRegistro = 34
        ColdFecExamen = 35
        ColdFecEntResultado2 = 36
        ColdFecValidaResultado = 37
        ColdResFecCargaResult = 38
        ColdFecRecogeResultado = 39
    End Enum

    Private Sub Formato01_DataGridView()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()
            '0
            Dim ColnImgTipoAtencion As New DataGridViewImageColumn()
            With ColnImgTipoAtencion
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = ""
                .HeaderText = "!"
                .Name = "Imagen"
                .ReadOnly = True : .Visible = True
                .Width = 28
            End With
            .Columns.Add(ColnImgTipoAtencion)
            '1
            Dim ColcPerJuridica As New DataGridViewTextBoxColumn()
            With ColcPerJuridica
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerJuridica"
                .HeaderText = "cPerJuridica"
                .Name = "cPerJuridica"
                .ReadOnly = True : .Visible = False
                .Width = 60
            End With
            .Columns.Add(ColcPerJuridica)
            '2
            Dim ColnIntCodigo As New DataGridViewTextBoxColumn()
            With ColnIntCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nIntCodigo"
                .HeaderText = "nIntCodigo"
                .Name = "nIntCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 100
            End With
            .Columns.Add(ColnIntCodigo)
            '3
            Dim ColcIntDescripcion As New DataGridViewTextBoxColumn()
            With ColcIntDescripcion
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.Format = "d"
                .DataPropertyName = "cIntDescripcion"
                .HeaderText = "Tipo Atención"
                .Name = "cIntDescripcion"
                .ReadOnly = True : .Visible = True
                .Width = 100
                '.DefaultCellStyle = DataGridViewCellStyle { Format=N, Alignment=TopRight }
            End With
            .Columns.Add(ColcIntDescripcion)
            '4
            Dim ColcPerCodigoTerceros As New DataGridViewTextBoxColumn()
            With ColcPerCodigoTerceros
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerCodigoTerceros"
                .HeaderText = "cPerCodigoTerceros"
                .Name = "cPerCodigoTerceros"
                .ReadOnly = True : .Visible = False
                .Width = 100
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            .Columns.Add(ColcPerCodigoTerceros)
            '5
            Dim ColnSolAdmNumero As New DataGridViewTextBoxColumn()
            With ColnSolAdmNumero
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format.Length.ToString()
                .DataPropertyName = "nSolAdmNumero"
                .HeaderText = "Número Ficha"
                .Name = "nSolAdmNumero"
                .ReadOnly = True : .Visible = True
                .Width = 118
            End With
            .Columns.Add(ColnSolAdmNumero)
            '6
            Dim ColcPerCodigo As New DataGridViewTextBoxColumn()
            With ColcPerCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "cPerCodigo"
                .HeaderText = "cPerCodigo"
                .Name = "cPerCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 150
            End With
            .Columns.Add(ColcPerCodigo)
            '7
            Dim ColcPerIdeNumero As New DataGridViewTextBoxColumn()
            With ColcPerIdeNumero
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerIdeNumero"
                .HeaderText = "Nro. Documento"
                .Name = "cPerIdeNumero"
                .ReadOnly = True : .Visible = True
                .Width = 80
            End With
            .Columns.Add(ColcPerIdeNumero)
            '8
            Dim ColcPerApellidos As New DataGridViewTextBoxColumn()
            With ColcPerApellidos
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerApellidos"
                .HeaderText = "cPerApellidos"
                .Name = "cPerApellidos"
                .ReadOnly = True : .Visible = False
                .Width = 100
            End With
            .Columns.Add(ColcPerApellidos)
            '9
            Dim ColcPerNombreCompleto As New DataGridViewTextBoxColumn()
            With ColcPerNombreCompleto
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cPerNombreCompleto"
                .HeaderText = "Apellidos y Nombres"
                .Name = "cPerNombreCompleto"
                .ReadOnly = True : .Visible = True
                .Width = 300
            End With
            .Columns.Add(ColcPerNombreCompleto)
            '10
            Dim ColdPerNacimiento As New DataGridViewTextBoxColumn()
            With ColdPerNacimiento
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "d"
                .DataPropertyName = "dPerNacimiento"
                .HeaderText = "Edad"
                .Name = "dPerNacimiento"
                .ReadOnly = True : .Visible = True
                .Width = 40
            End With
            .Columns.Add(ColdPerNacimiento)


            '11
            Dim ColcTiempoEntrega As New DataGridViewTextBoxColumn()
            With ColcTiempoEntrega
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cTiempoEntrega"
                .HeaderText = "Tiempo Entrega"
                .Name = "cTiempoEntrega"
                .ReadOnly = True : .Visible = True
                .Width = 50
            End With
            .Columns.Add(ColcTiempoEntrega)

            '12
            Dim ColcEstadoResultado As New DataGridViewTextBoxColumn()
            With ColcEstadoResultado
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cEstadoResultado"
                .HeaderText = "Publicado"
                .Name = "cEstadoResultado"
                .ReadOnly = True : .Visible = True
                .Width = 60
            End With
            .Columns.Add(ColcEstadoResultado)


            '13
            Dim ColdFecEntResultado0 As New DataGridViewTextBoxColumn()
            With ColdFecEntResultado0
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                .DataPropertyName = "dFecEntResultado"
                .HeaderText = "Fecha Resultado"
                .Name = "dFecEntResultado"
                .ReadOnly = True : .Visible = False
                .Width = 95
            End With
            .Columns.Add(ColdFecEntResultado0)
            '14
            Dim ColImgStatus As New DataGridViewImageColumn()
            With ColImgStatus
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = ""
                .HeaderText = "?"
                .Name = "ImgStatus"
                .ReadOnly = True : .Visible = True
                .Width = 28
            End With
            .Columns.Add(ColImgStatus)
            '15
            Dim ColnAdmSolEstado As New DataGridViewTextBoxColumn()
            With ColnAdmSolEstado
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nAdmSolEstado"
                .HeaderText = "nAdmSolEstado"
                .Name = "nAdmSolEstado"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColnAdmSolEstado)
            '16
            Dim ColcConDescripcion As New DataGridViewTextBoxColumn()
            With ColcConDescripcion
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cConDescripcion"
                .HeaderText = "Estado"
                .Name = "cConDescripcion"
                .ReadOnly = True : .Visible = True
                .Width = 145
            End With
            .Columns.Add(ColcConDescripcion)
            '17
            Dim ColnImpTotal As New DataGridViewTextBoxColumn()
            With ColnImpTotal
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Font = New Font(Table1.Font, FontStyle.Bold)
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nImpTotal"
                .HeaderText = "Importe Total S/."
                .Name = "nImpTotal"
                .ReadOnly = True : .Visible = True
                .Width = 70
            End With
            .Columns.Add(ColnImpTotal)
            '18
            Dim ColnImpAnticipo As New DataGridViewTextBoxColumn()
            With ColnImpAnticipo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nImpAnticipo"
                .HeaderText = "Pagado S/."
                .Name = "nImpAnticipo"
                .ReadOnly = True : .Visible = True
                .Width = 60
            End With
            .Columns.Add(ColnImpAnticipo)
            '19
            Dim ColnSaldo As New DataGridViewTextBoxColumn()
            With ColnSaldo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nSaldo"
                .HeaderText = "Deuda S/."
                .Name = "nSaldo"
                .ReadOnly = True : .Visible = True
                .Width = 60
            End With
            .Columns.Add(ColnSaldo)
            '20
            Dim ColcCtaCteRecibo As New DataGridViewTextBoxColumn()
            With ColcCtaCteRecibo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.ForeColor = Color.SeaGreen
                .DefaultCellStyle.Font = New Font(Table1.Font, FontStyle.Bold)
                .DataPropertyName = "cCtaCteRecibo"
                .HeaderText = "Nro. Recibo Pendiente Pago"
                .Name = "cCtaCteRecibo"
                .ReadOnly = True : .Visible = False
                .Width = 130
            End With
            .Columns.Add(ColcCtaCteRecibo)
            '21
            Dim ColcPerUseCodigo As New DataGridViewTextBoxColumn()
            With ColcPerUseCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cPerUseCodigo"
                .HeaderText = "cPerUseCodigo"
                .Name = "cPerUseCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 100
            End With
            .Columns.Add(ColcPerUseCodigo)
            '22
            Dim ColnPerTipo As New DataGridViewTextBoxColumn()
            With ColnPerTipo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nPerTipo"
                .HeaderText = "nPerTipo"
                .Name = "nPerTipo"
                .ReadOnly = True : .Visible = False
                .Width = 100
            End With
            .Columns.Add(ColnPerTipo)
            '23
            Dim ColnCtaCteCuota As New DataGridViewTextBoxColumn()
            With ColnCtaCteCuota
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nCtaCteCuota"
                .HeaderText = "Nro. Pago(s)"
                .Name = "nCtaCteCuota"
                .ReadOnly = True : .Visible = True
                .Width = 60
            End With
            .Columns.Add(ColnCtaCteCuota)
            '24
            Dim ColnExportEstado As New DataGridViewTextBoxColumn()
            With ColnExportEstado
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nEstadoExportLIS"
                .HeaderText = "nExportEstado"
                .Name = "nEstadoExportLIS"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColnExportEstado)
            '25
            Dim ColnImgExportLIS As New DataGridViewImageColumn()
            With ColnImgExportLIS
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = ""
                .HeaderText = "?"
                .Name = "ImgExportLIS"
                .ReadOnly = True : .Visible = True
                .Width = 28
            End With
            .Columns.Add(ColnImgExportLIS)
            '26
            Dim ColcExportEstado As New DataGridViewTextBoxColumn()
            With ColcExportEstado
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.ForeColor = Color.White
                .DefaultCellStyle.Font = New Font("Tahoma", 12)
                '.DataPropertyName = "nEstadoExportLIS"
                .HeaderText = "Enviar a LIS"
                .Name = "cExportEstado"
                .ReadOnly = True : .Visible = True
                .Width = 95
            End With
            .Columns.Add(ColcExportEstado)
            '27
            Dim ColcNroOrdenLIS As New DataGridViewTextBoxColumn()
            With ColcNroOrdenLIS
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.ForeColor = Color.White
                '.DefaultCellStyle.Font = New Font("Tahoma", 12)
                .DataPropertyName = "cNroOrdenLIS"
                .HeaderText = "Nro. Orden (Generada)"
                .Name = "cNroOrdenLIS"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColcNroOrdenLIS)
            '28
            Dim ColnFlagComision As New DataGridViewTextBoxColumn()
            With ColnFlagComision
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "nFlagComision"
                .HeaderText = "nFlagComision"
                .Name = "nFlagComision"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColnFlagComision)

            '29
            Dim ColnPerIntCodigo As New DataGridViewTextBoxColumn()
            With ColnPerIntCodigo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "nPerIntCodigo"
                .HeaderText = "nPerIntCodigo"
                .Name = "nPerIntCodigo"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColnPerIntCodigo)

            '30
            Dim ColnValidaToma As New DataGridViewTextBoxColumn()
            With ColnValidaToma
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "nValidaToma"
                .HeaderText = "nValidaToma"
                .Name = "nValidaToma"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColnValidaToma)

            '31
            Dim ColnValidaEntrega As New DataGridViewTextBoxColumn()
            With ColnValidaEntrega
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "nValidaEntrega"
                .HeaderText = "nValidaEntrega"
                .Name = "nValidaEntrega"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColnValidaEntrega)

            '32
            Dim ColnValidaResultado As New DataGridViewTextBoxColumn()
            With ColnValidaResultado
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "nValidaResultado"
                .HeaderText = "nValidaResultado"
                .Name = "nValidaResultado"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColnValidaResultado)

            '33
            Dim ColnValidaRecogo As New DataGridViewTextBoxColumn()
            With ColnValidaRecogo
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "nValidaRecogo"
                .HeaderText = "nValidaRecogo"
                .Name = "nValidaRecogo"
                .ReadOnly = True : .Visible = False
                .Width = 90
            End With
            .Columns.Add(ColnValidaRecogo)

            '34
            Dim ColdFecRegistro As New DataGridViewTextBoxColumn()
            With ColdFecRegistro
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                .DataPropertyName = "dFecRegistro"
                .HeaderText = "Fecha registro"
                .Name = "dFecRegistro"
                .ReadOnly = True : .Visible = True
                .Width = 105
            End With
            .Columns.Add(ColdFecRegistro)
            '35
            Dim ColdFecExamen As New DataGridViewTextBoxColumn()
            With ColdFecExamen
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                .DataPropertyName = "dFecExamen"
                .HeaderText = "Fecha T. Muestra"
                .Name = "dFecExamen"
                .ReadOnly = True : .Visible = True
                .Width = 105
            End With
            .Columns.Add(ColdFecExamen)


            '36
            Dim ColdFecEntResultado As New DataGridViewTextBoxColumn()
            With ColdFecEntResultado
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                .DataPropertyName = "dFecEntResultado"
                .HeaderText = "Fecha Resultado"
                .Name = "dFecEntResultado"
                .ReadOnly = True : .Visible = True
                .Width = 105
            End With
            .Columns.Add(ColdFecEntResultado)

            '37
            Dim ColdFecValidaResultado As New DataGridViewTextBoxColumn()
            With ColdFecValidaResultado
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                .DataPropertyName = "dFecValidaResultado"
                .HeaderText = "Fecha Val. Result"
                .Name = "dFecValidaResultado"
                .ReadOnly = True : .Visible = True
                .Width = 105
            End With
            .Columns.Add(ColdFecValidaResultado)

            '38
            Dim ColdResFecCargaResult As New DataGridViewTextBoxColumn()
            With ColdResFecCargaResult
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                .DataPropertyName = "dResFecCargaResult"
                .HeaderText = "Fecha Carga Result"
                .Name = "dResFecCargaResult"
                .ReadOnly = True : .Visible = True
                .Width = 105
            End With
            .Columns.Add(ColdResFecCargaResult)

            '39
            Dim ColdFecRecogeResultado As New DataGridViewTextBoxColumn()
            With ColdFecRecogeResultado
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                .DataPropertyName = "dFecRecogeResultado"
                .HeaderText = "Fecha Recog. Result"
                .Name = "dFecRecogeResultado"
                .ReadOnly = True : .Visible = True
                .Width = 105
            End With
            .Columns.Add(ColdFecRecogeResultado)

        End With


    End Sub

#End Region

    Function PExportLIS() As String

        Try
            'ORD|MEDICA|R|1|2015xxx|0000|PARTICULAR|C
            Dim Objeto As New BE.FichaAtencion.BE_ReqSolAtencion
            Dim Servicio As New BL.BL_FichaAtencion.BL_FichaAtencion
            Dim dt As New DataTable

            PExportLIS = ""

            dt = Servicio.Get_Estructura_Export_LIS(Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value.ToString())

            If dt.Rows.Count > 0 Then
                Dim row As DataRow
                Dim i As Integer = 0

                For Each row In dt.Rows
                    PExportLIS = PExportLIS + CStr(row("cadena").ToString) & Chr(10) 'IIf(i = dt.Rows.Count - 1, "", Chr(10))
                    i = i + 1
                Next
            End If

            Dim cTramaWS As New ConsumoServicioHIS
            Dim Res_HIS As New BE.Servicios.Resultado_HIS

            Res_HIS = cTramaWS.EnviarTramaWS(PExportLIS)

            If Trim(Res_HIS.Code) = "0" Then 'si devuelve 0 es OK se actualiza la Ficha
                Objeto.nSolAdmNumero = Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value.ToString()
                Objeto.cNroOrdenLIS = Trim(Res_HIS.Descripcion)
                Servicio.Upd_AdmSolAtencion_Export_LIS(Objeto)
                MessageBox.Show("Se ha enviado correctamente. " & Chr(13) & "Nro. Orden LIS: " & Res_HIS.Descripcion, "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Actulizando Grid

                CboFiltro.SelectedIndex = 0
                TxtBuscar.Text = Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value.ToString()
                C1CmdBuscar_Click(C1CmdBuscar, Nothing)

            Else
                MessageBox.Show("Se encontraron errores, por favor de consultar a área de TI. " + Chr(10) + "Error Nº :" & Res_HIS.Code & Chr(10) & "Descripción: " & Res_HIS.Descripcion, "Error: No Enviado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Se encontraron errores. " + ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Private Sub PrintFichaAtencion()

        Dim CrReport As New ReportDocument
        Dim BL As New BL_FichaAtencion

        CrReport = New ReportDocument()
        CrReport.Load(cPathRPT & "rptFichaSolicitudporPaciente.rpt")
        CrReport.SetDataSource(BL.Get_Cab_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_cPerCodigo(StrcPerJuridica, table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, table1.CurrentRow.Index).Value.ToString(), table1.Item(GrillaAdmSolicitud.ColcPerCodigo, table1.CurrentRow.Index).Value.ToString()))
        FormCrystalReport.Text = "Ficha de Atención - Admisión"
        FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
        FormCrystalReport.Show()

    End Sub

    Private Sub CargaIconGrilla()

        If Table1.RowCount = 0 Then Exit Sub

        With Table1
            For i As Integer = 0 To .Rows.Count - 1

                'If (CDbl(.Item("nCtaCteImporte", i).Value) > 0 And CDbl(.Item("nCtaCteImpAplicado", i).Value) = 0) Then .Rows(i).Cells("nCtaCteEstado").Value = 3

                Dim columnHeaderStyle As New DataGridViewCellStyle()
                columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)

                '.ColumnHeadersDefaultCellStyle = columnHeaderStyle
                .RowHeadersDefaultCellStyle = columnHeaderStyle

                Select Case .Rows(i).Cells(GrillaAdmSolicitud.ColnAdmSolEstado).Value '  "nAdmSolEstado").Value
                    Case 1 'Pendiente de pago
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcConDescripcion).Style.ForeColor = Color.Red
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgStatus).Value = My.Resources.price_alert ' "ImgStatus"
                    Case 2  'Programado
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcConDescripcion).Style.ForeColor = Color.White
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcConDescripcion).Style.BackColor = Color.SeaGreen
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgStatus).Style.BackColor = Color.SeaGreen
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgStatus).Value = My.Resources.BONote_16x16
                    Case 3 'Cancelado  (Pago realizado)
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcConDescripcion).Style.ForeColor = Color.White
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcConDescripcion).Style.BackColor = Color.RoyalBlue
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgStatus).Style.BackColor = Color.RoyalBlue
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgStatus).Value = My.Resources.total_plan_cost
                    Case 4 'Toma de examen 
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcConDescripcion).Style.ForeColor = Color.Green
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgStatus).Value = My.Resources.injection
                    Case 5 'Finalizado
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcConDescripcion).Style.ForeColor = Color.AliceBlue
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgStatus).Value = My.Resources.client_account_template
                    Case 6 'Resultado Entregado
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgStatus).Value = My.Resources.license_management
                    Case 7 'Anulado
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcConDescripcion).Style.ForeColor = Color.Azure
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcConDescripcion).Style.BackColor = Color.Salmon
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgStatus).Style.BackColor = Color.Salmon
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgStatus).Value = My.Resources.DeleteHeader_16x16
                End Select

                If CDate(.Rows(i).Cells(GrillaAdmSolicitud.ColdFecEntResultado).Value) = CDate("1900-01-01") Then
                    .Rows(i).Cells(GrillaAdmSolicitud.ColdFecEntResultado).Style.Format = "d"
                    .Rows(i).Cells(GrillaAdmSolicitud.ColdFecEntResultado).Style.ForeColor = Color.White
                    .Rows(i).Cells(GrillaAdmSolicitud.ColdFecEntResultado).Style.SelectionForeColor = Color.CornflowerBlue
                End If

                'Carga png "nIntCodigo"
                Select Case .Rows(i).Cells(GrillaAdmSolicitud.ColnIntCodigo).Value
                    Case 1001 'Particular
                        .Rows(i).Cells(GrillaAdmSolicitud.ColnImgTipoAtencion).Value = My.Resources.Particular_16x16
                    Case 1002 'Lab. Externo
                        .Rows(i).Cells(GrillaAdmSolicitud.ColnImgTipoAtencion).Value = My.Resources.RunTests_8790
                    Case 1003 'Convenio
                        .Rows(i).Cells(GrillaAdmSolicitud.ColnImgTipoAtencion).Value = My.Resources.certificate_16xLG
                    Case 1004 'Atencion Externa
                        .Rows(i).Cells(GrillaAdmSolicitud.ColnImgTipoAtencion).Value = My.Resources.Home_5699
                        'Home_16x16
                    Case 1005 'Centro de Salud
                        .Rows(i).Cells(GrillaAdmSolicitud.ColnImgTipoAtencion).Value = My.Resources.house_two
                    Case 1006 'Campaña
                        .Rows(i).Cells(GrillaAdmSolicitud.ColnImgTipoAtencion).Value = My.Resources.campaña
                End Select

                'Carga png "nAdmSolEstado"
                Select Case .Rows(i).Cells(GrillaAdmSolicitud.ColnExportEstado).Value
                    Case 0 'pendiente
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcNroOrdenLIS).Style.BackColor = Color.Red
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcExportEstado).Style.ForeColor = Color.White
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcExportEstado).Style.BackColor = Color.Red
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcExportEstado).Value = "Pendiente"
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgExportLIS).Style.BackColor = Color.Red
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgExportLIS).Value = My.Resources.Inbox_16x16 '"ImgExportLIS"
                    Case 1 'Enviado
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcNroOrdenLIS).Style.BackColor = Color.Orange
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcExportEstado).Style.ForeColor = Color.White '"cExportEstado"
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcExportEstado).Style.BackColor = Color.Orange
                        .Rows(i).Cells(GrillaAdmSolicitud.ColcExportEstado).Value = "Enviado"
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgExportLIS).Style.BackColor = Color.Orange
                        .Rows(i).Cells(GrillaAdmSolicitud.ColImgExportLIS).Value = My.Resources.Outbox_16x16
                End Select

            Next
        End With
    End Sub

    Private Sub FormGridFichaAtencion_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F5))
                C1CmdBuscar_Click(C1CmdBuscar, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F6))
                c1CmdNuevo_Click(c1CmdNuevo, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F7))
                C1CmdEdit_Click(C1CmdEdit, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F9))
                c1CmdPago_Click(c1CmdPago, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F10))
                C1CmdImprimir_Click(C1CmdImprimir, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F11))
                C1CmdAnularFicha_Click(C1CmdAnularFicha, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.F12))
                C1CmdAppMovil_Click(C1CmdAppMovil, Nothing)
            Case AscW(Microsoft.VisualBasic.ChrW(Keys.Escape))
                C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        End Select

    End Sub

    Private Sub FormGridPersona_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Table1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top _
            Or System.Windows.Forms.AnchorStyles.Bottom _
            Or System.Windows.Forms.AnchorStyles.Left _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    End Sub

    Private Sub FormGridFichaAtencion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CboFiltro.SelectedIndex = 0
        CboFiltro_SelectionChangeCommitted(CboFiltro, Nothing)
        Me.WindowState = FormWindowState.Maximized

        Formato01_DataGridView()

        FormatGrilla(Table1, Me, True, 40)
        FormatGrilla(Table2, Me, True, 40)

        LlenaDataCombo(cboTipAtencion, ObjInterface.Get_Interface(CLng(TokenByKey(cboTipAtencion.Tag, "nIntClase")), CLng(TokenByKey(cboTipAtencion.Tag, "nIntTipo")), "A"), "nIntCodigo", "cIntDescripcion")
    End Sub

    Private Sub c1CmdNuevo_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdNuevo.Click

        nFlagAdmision = 1 'nuevo registro 

        'cNewCodigoPer = Get_Valor("Exec usp_Persona_Get_NewId", "NewCodigo")
        FormPrcSolAtencion.ShowDialog()

        CboFiltro.SelectedIndex = 0
        C1CmdBuscar_Click(C1CmdBuscar, Nothing)

    End Sub

    Private Sub C1CmdEdit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdEdit.Click

        Try
            If Table1.RowCount = 0 Then Exit Sub

            With Table1
                If Not .CurrentCell Is Nothing Then
                    If .Item(GrillaAdmSolicitud.ColnAdmSolEstado, .CurrentRow.Index).Value = EstadoFichaAtencion.nPendientePago Then
                        StrPasaAdmFicha = vbNullString
                        'StrPasaAdmFicha = "cPerJuridica=" & .Item(GrillaAdmSolicitud.ColcPerJuridica, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nIntCodigo=" & .Item(GrillaAdmSolicitud.ColnIntCodigo, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "cIntDescripcion=" & .Item(GrillaAdmSolicitud.ColcIntDescripcion, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "cPerCodigoTerceros=" & .Item(GrillaAdmSolicitud.ColcPerCodigoTerceros, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nSolAdmNumero=" & .Item(GrillaAdmSolicitud.ColnSolAdmNumero, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "cPerCodigo=" & .Item(GrillaAdmSolicitud.ColcPerCodigo, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "cPerIdeNumero=" & .Item(GrillaAdmSolicitud.ColcPerIdeNumero, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "cPerApellidos=" & .Item(GrillaAdmSolicitud.ColcPerApellidos, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "cPerNombreCompleto=" & .Item(GrillaAdmSolicitud.ColcPerNombreCompleto, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "dPerNacimiento=" & .Item(GrillaAdmSolicitud.ColdPerNacimiento, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "dFecRegistro=" & Strings.Left(.Item(GrillaAdmSolicitud.ColdFecRegistro, .CurrentRow.Index).Value.ToString, 10) & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "dFecExamen=" & IIf(.Item(GrillaAdmSolicitud.ColdFecExamen, .CurrentRow.Index).Value.ToString = "", "01/01/1900", Strings.Left(.Item(GrillaAdmSolicitud.ColdFecExamen, .CurrentRow.Index).Value.ToString, 10)) & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "dFecEntResultado=" & IIf(.Item(GrillaAdmSolicitud.ColdFecEntResultado, .CurrentRow.Index).Value.ToString = "", "01/01/1900", Strings.Left(.Item(GrillaAdmSolicitud.ColdFecEntResultado, .CurrentRow.Index).Value.ToString, 10)) & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nAdmSolEstado=" & .Item(GrillaAdmSolicitud.ColnAdmSolEstado, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "cConDescripcion=" & .Item(GrillaAdmSolicitud.ColcConDescripcion, .CurrentRow.Index).Value.ToString & ";"
                        'StrPasaAdmFicha = StrPasaAdmFicha & "nImpTotal=" & .Item(GrillaAdmSolicitud.ColnImpTotal, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "cPerUseCodigo=" & .Item(GrillaAdmSolicitud.ColcPerUseCodigo, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nPerTipo=" & .Item(GrillaAdmSolicitud.ColnPerTipo, .CurrentRow.Index).Value.ToString & ";"
                        '(eincio) f.2015-11-02
                        StrPasaAdmFicha = StrPasaAdmFicha & "nCtaCteCuota=" & .Item(GrillaAdmSolicitud.ColnCtaCteCuota, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nSaldo=" & .Item(GrillaAdmSolicitud.ColnSaldo, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nImpAnticipo=" & .Item(GrillaAdmSolicitud.ColnImpAnticipo, .CurrentRow.Index).Value.ToString & ";"
                        StrPasaAdmFicha = StrPasaAdmFicha & "nFlagComision=" & .Item(GrillaAdmSolicitud.ColnFlagComision, .CurrentRow.Index).Value.ToString & ";" 'update 2015-01-12
                        StrPasaAdmFicha = StrPasaAdmFicha & "nPerIntCodigo=" & .Item(GrillaAdmSolicitud.ColnPerIntCodigo, .CurrentRow.Index).Value.ToString
                        'Debug.Print(StrPasaAdmFicha)

                        'Determinando Accion
                        nFlagAdmision = 2 'modificando

                        FormPrcSolAtencion.Text = "Actualizando Registro Ficha de Atención..."
                        FormPrcSolAtencion.ShowDialog()
                        C1CmdBuscar_Click(C1CmdBuscar, Nothing)
                    End If

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub C1CmdBuscar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdBuscar.Click

        Try
            Dim StrFiltro As String = ""
            Dim StrFilNroDocu As String = ""
            Dim dtResultado As DataTable = Nothing

            Dim cIncluyeAnulados As String = IIf(ChkIncluirAnulados.Checked, "S", "N")

            Dim nPos As Integer = 0
            Dim ObjBL As New BL_FichaAtencion

            Select Case CboFiltro.SelectedIndex
                Case 0 'Nro.Ficha(Atención)
                    dtResultado = ObjBL.Get_List_AdmSolAtencion("S", TxtBuscar.Text, "", "", "", "", StrcPerJuridica, cIncluyeAnulados, Val(cboTipAtencion.SelectedValue))
                Case 1 'D.N.I.
                    dtResultado = ObjBL.Get_List_AdmSolAtencion("D", "", TxtBuscar.Text, "", "", "", StrcPerJuridica, cIncluyeAnulados, Val(cboTipAtencion.SelectedValue))
                Case 2 'Apellidos
                    If Len(TxtBuscar.Text) < 3 Then Exit Sub
                    dtResultado = ObjBL.Get_List_AdmSolAtencion("A", "", "", TxtBuscar.Text, "", "", StrcPerJuridica, cIncluyeAnulados, Val(cboTipAtencion.SelectedValue))
                Case 3 'Rango(Fechas)
                    'codigo obsoleto "ValidaRangoFechas"
                    'If Date.Parse(DtpFecIni.Value.Date) > Date.Parse(DtpFecFin.Value.Date) Then
                    '    MessageBox.Show("Rango de Fechas no son coherentes.!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '    DtpFecIni.Value = DtpFecFin.Value
                    '    Exit Sub
                    'End If
                    If Not ValidaRangoFechas(DtpFecIni.Value.Date, DtpFecFin.Value.Date) Then
                        DtpFecIni.Value = DtpFecFin.Value
                        Exit Sub
                    End If
                    dtResultado = ObjBL.Get_List_AdmSolAtencion("R", "", "", "", DtpFecIni.Value.ToString, DtpFecFin.Value.ToString, StrcPerJuridica, cIncluyeAnulados, Val(cboTipAtencion.SelectedValue))
                Case 4 'pendientes de pago
                    dtResultado = ObjBL.Get_List_AdmSolAtencion("P", "", "", "", "", "", StrcPerJuridica, cIncluyeAnulados, Val(cboTipAtencion.SelectedValue))
            End Select

            '------------------
            'Leeyendo DataTable
            '------------------
            EliminarRowsDgView(Table1)

            'Leyendo un DataTable
            If dtResultado.Rows.Count > 0 Then
                Dim row As DataRow

                For Each row In dtResultado.Rows
                    With Table1
                        nPos = .RowCount()
                        .Rows.Add()
                        .Item(GrillaAdmSolicitud.ColcPerJuridica, nPos).Value = row("cPerJuridica").ToString
                        .Item(GrillaAdmSolicitud.ColnIntCodigo, nPos).Value = row("nIntCodigo").ToString
                        .Item(GrillaAdmSolicitud.ColcIntDescripcion, nPos).Value = row("cIntDescripcion").ToString
                        .Item(GrillaAdmSolicitud.ColcPerCodigoTerceros, nPos).Value = row("cPerCodigoTerceros").ToString
                        .Item(GrillaAdmSolicitud.ColnSolAdmNumero, nPos).Value = row("nSolAdmNumero").ToString
                        .Item(GrillaAdmSolicitud.ColcPerCodigo, nPos).Value = row("cPerCodigo").ToString
                        .Item(GrillaAdmSolicitud.ColcPerIdeNumero, nPos).Value = row("cPerIdeNumero").ToString
                        .Item(GrillaAdmSolicitud.ColcPerApellidos, nPos).Value = row("cPerApellidos").ToString
                        .Item(GrillaAdmSolicitud.ColcPerNombreCompleto, nPos).Value = row("cPerNombreCompleto").ToString
                        .Item(GrillaAdmSolicitud.ColdPerNacimiento, nPos).Value = row("dPerNacimiento")
                        .Item(GrillaAdmSolicitud.ColdFecRegistro, nPos).Value = row("dFecRegistro")
                        .Item(GrillaAdmSolicitud.ColdFecEntResultado, nPos).Value = row("dFecEntResultado")


                        .Item(GrillaAdmSolicitud.ColnAdmSolEstado, nPos).Value = CInt(row("nAdmSolEstado").ToString)
                        .Item(GrillaAdmSolicitud.ColcConDescripcion, nPos).Value = row("cConDescripcion").ToString
                        .Item(GrillaAdmSolicitud.ColnImpTotal, nPos).Value = CDbl(row("nImpTotal").ToString)
                        .Item(GrillaAdmSolicitud.ColnImpAnticipo, nPos).Value = CDbl(row("nImpAnticipo").ToString)
                        .Item(GrillaAdmSolicitud.ColnSaldo, nPos).Value = CDbl(row("nSaldo").ToString)
                        .Item(GrillaAdmSolicitud.ColcCtaCteRecibo, nPos).Value = row("cCtaCteRecibo").ToString
                        .Item(GrillaAdmSolicitud.ColcPerUseCodigo, nPos).Value = row("cPerUseCodigo").ToString
                        .Item(GrillaAdmSolicitud.ColnPerTipo, nPos).Value = CInt(row("nPerTipo").ToString)
                        .Item(GrillaAdmSolicitud.ColnCtaCteCuota, nPos).Value = CInt(row("nCtaCteCuota").ToString)
                        .Item(GrillaAdmSolicitud.ColnExportEstado, nPos).Value = CInt(row("nEstadoExportLIS").ToString)
                        .Item(GrillaAdmSolicitud.ColnFlagComision, nPos).Value = CInt(row("nFlagComision").ToString) 'update 2015-01-12 (EINCIO)
                        .Item(GrillaAdmSolicitud.ColcNroOrdenLIS, nPos).Value = row("cNroOrdenLIS").ToString 'update 2015-01-13 (EINCIO)
                        .Item(GrillaAdmSolicitud.ColnPerIntCodigo, nPos).Value = CInt(row("nPerIntCodigo").ToString) 'Update 2016-04-20 (EINCIO)

                        .Item(GrillaAdmSolicitud.ColnValidaToma, nPos).Value = CInt(row("nValidaToma").ToString)
                        .Item(GrillaAdmSolicitud.ColnValidaEntrega, nPos).Value = CInt(row("nValidaEntrega").ToString)
                        .Item(GrillaAdmSolicitud.ColnValidaResultado, nPos).Value = CInt(row("nValidaResultado").ToString)
                        .Item(GrillaAdmSolicitud.ColnValidaRecogo, nPos).Value = CInt(row("nValidaRecogo").ToString)

                        .Item(GrillaAdmSolicitud.ColcTiempoEntrega, nPos).Value = row("cTiempoEntrega").ToString
                        .Item(GrillaAdmSolicitud.ColcEstadoResultado, nPos).Value = IIf(row("cEstadoResultado").ToString = "PUBLICADO", "SI", "NO")

                        .Item(GrillaAdmSolicitud.ColdFecExamen, nPos).Value = IIf(CInt(row("nValidaToma")) = 1, row("dFecExamen"), "")
                        .Item(GrillaAdmSolicitud.ColdFecEntResultado2, nPos).Value = IIf(CInt(row("nValidaEntrega")) = 1, row("dFecEntResultado"), "")
                        .Item(GrillaAdmSolicitud.ColdFecValidaResultado, nPos).Value = IIf(CInt(row("nValidaResultado")) = 1, row("dFecValidaResultado"), "")
                        .Item(GrillaAdmSolicitud.ColdResFecCargaResult, nPos).Value = IIf(row("cEstadoResultado").ToString = "PUBLICADO", row("dResFecCargaResult"), "")
                        .Item(GrillaAdmSolicitud.ColdFecRecogeResultado, nPos).Value = IIf(CInt(row("nValidaRecogo")) = 1, row("dFecRecogeResultado"), "")


                    End With
                Next
            End If

            CargaIconGrilla()

            LblMsg.Text = "Se encontraron " & Table1.RowCount & " registros, como resultado de la búsqueda."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: Get_List_AdmSolAtencion. Consulte al administrador de Sistemas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub CboFiltro_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboFiltro.SelectionChangeCommitted

        Select Case CboFiltro.SelectedIndex
            Case 0
                TxtBuscar.MaxLength = 15 : TxtBuscar.Visible = True : TxtBuscar.Text = vbNullString : TxtBuscar.Focus() : Panel1.Visible = False
                TxtBuscar.Text = Year(Date.Now).ToString + Microsoft.VisualBasic.Right("00" + Month(Date.Now).ToString, 2) + Microsoft.VisualBasic.Right("00" + Date.Now.Day.ToString, 2) + "0000000"
            Case 1, 2
                TxtBuscar.MaxLength = 100 : TxtBuscar.Visible = True : TxtBuscar.Text = vbNullString : TxtBuscar.Focus() : Panel1.Visible = False
            Case 3
                TxtBuscar.Visible = False : Panel1.Visible = True
            Case 4
                TxtBuscar.Visible = False : Panel1.Visible = False
        End Select
        EliminarRowsDgView(Table1)

    End Sub

    Private Sub Table1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellDoubleClick
        'Call C1CmdEdit_Click(C1CmdEdit, Nothing)
        Try
            Dim dt As New DataTable
            Dim Servicio As New BL.BL_CtasCtesMedica.BL_CtaCteComprobante

            dt = Servicio.Get_Detalle_DocuRef_by_nSolAdmNumero(table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, table1.CurrentRow.Index).Value.ToString())

            If dt.Rows.Count > 0 Then
                Table2.DataSource = dt
                LblTotalPago.Text = FormatNumber(Suma_Columna("fCtaCteImporte", Table2), True)
                Label5.Text = "Nro. Ficha"
                Label5.Text = Label5.Text + Space(1) + table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, table1.CurrentRow.Index).Value.ToString()
                Centrar(Panel2)
                Panel2.Visible = True : table1.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub TxtBuscar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then Call C1CmdCerrar_Click(C1CmdCerrar, Nothing)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then Call C1CmdBuscar_Click(C1CmdBuscar, Nothing)
    End Sub

    Private Sub C1CmdCerrar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub c1CmdPago_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles c1CmdPago.Click

        With Table1
            If .Rows.Count > 0 Then
                Select Case .Item(GrillaAdmSolicitud.ColnAdmSolEstado, .CurrentRow.Index).Value
                    Case EstadoFichaAtencion.nPendientePago
                        MessageBox.Show("Recibo de pago <No> ha sido programado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Case EstadoFichaAtencion.nProgramado

                        StrPasaValores = vbNullString
                        REM pasando valores 
                        StrPasaValores = "cNroRecibo=" & .Item(GrillaAdmSolicitud.ColcCtaCteRecibo, .CurrentRow.Index).Value.ToString() & ";"
                        StrPasaValores = StrPasaValores & "nSolAdmNumero=" & .Item(GrillaAdmSolicitud.ColnSolAdmNumero, .CurrentRow.Index).Value.ToString() & ";"
                        StrPasaValores = StrPasaValores & "nImpRecibo=" & .Item(GrillaAdmSolicitud.ColnImpTotal, .CurrentRow.Index).Value.ToString() & ";"
                        StrPasaValores = StrPasaValores & "cPerCodigo=" & .Item(GrillaAdmSolicitud.ColcPerCodigo, .CurrentRow.Index).Value.ToString() & ";"
                        StrPasaValores = StrPasaValores & "cPerNombreCompleto=" & .Item(GrillaAdmSolicitud.ColcPerNombreCompleto, .CurrentRow.Index).Value.ToString() & ";"
                        StrPasaValores = StrPasaValores & "nIntCodigo=" & .Item(GrillaAdmSolicitud.ColnIntCodigo, .CurrentRow.Index).Value.ToString() & ";"
                        StrPasaValores = StrPasaValores & "nPerTipo=" & .Item(GrillaAdmSolicitud.ColnPerTipo, .CurrentRow.Index).Value.ToString()
                        FormPrcFormaPago.ShowDialog()

                        'actualiza Grilla
                        C1CmdBuscar_Click(C1CmdBuscar, Nothing)

                    Case EstadoFichaAtencion.nPagoRealizado
                        MessageBox.Show("Recibo de pago, <Ya> ha sido cancelado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Case EstadoFichaAtencion.nTomaExamen
                        MessageBox.Show("Paciente esta pasando sus Exámenes en este momento.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Case EstadoFichaAtencion.nFinalizado
                        MessageBox.Show("La Toma de Exámen ya terminado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Case EstadoFichaAtencion.nEntregado
                        MessageBox.Show("Ficha de Atención ya ha sido Entregado al Paciente.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Select
            End If
        End With

    End Sub

    Private Sub Table1_ColumnHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Table1.ColumnHeaderMouseClick
        'evento cuando ordena por columnas 
        CargaIconGrilla()
    End Sub

    'Private Sub ImprimirFichaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirFichaToolStripMenuItem.Click

    '    If Table1.RowCount = 0 Then Exit Sub

    '    Dim CrReport As New ReportDocument

    '    Try
    '        Select Case Table1.Item(GrillaAdmSolicitud.ColnAdmSolEstado, Table1.CurrentRow.Index).Value
    '            Case EstadoFichaAtencion.nPendientePago
    '                MessageBox.Show("Recibo de pago <No> ha sido programado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '            Case EstadoFichaAtencion.nProgramado
    '                MessageBox.Show("Recibo de pago ha sido programadom aun falta realizar el pago.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Case EstadoFichaAtencion.nPagoRealizado
    '                Dim BL As New BL_FichaAtencion

    '                ' Asigno el reporte 
    '                'If BL.Get_ReportCuadraCaja("RES", FormatDateTime(DtpFecIni.Value, DateFormat.ShortDate), FormatDateTime(DtpFecFin.Value, DateFormat.ShortDate)).Rows.Count = 0 Then Exit Sub

    '                CrReport = New ReportDocument()
    '                CrReport.Load(cPathRPT & "rptFichaSolicitudporPaciente.rpt")

    '                'CrReport.DataDefinition.FormulaFields("rangofec").Text = Chr(34) & "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy") & Chr(34)

    '                CrReport.SetDataSource(BL.Get_Cab_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_cPerCodigo(StrcPerJuridica, Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value.ToString(), Table1.Item(GrillaAdmSolicitud.ColcPerCodigo, Table1.CurrentRow.Index).Value.ToString()))

    '                FormCrystalReport.Text = "Ficha de Atención - Admisión"

    '                FormCrystalReport.CrystalRptVwr.ReportSource = CrReport
    '                'Directo a la impresora
    '                'Form_CrystalReport.CrystalRptVwr.PrintReport()
    '                FormCrystalReport.Show()
    '            Case EstadoFichaAtencion.nTomaExamen
    '                MessageBox.Show("Paciente esta pasando sus Exámenes en este momento.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '            Case EstadoFichaAtencion.nFinalizado
    '                MessageBox.Show("La Toma de Exámen ya terminado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '            Case EstadoFichaAtencion.nEntregado
    '                MessageBox.Show("Ficha de Atención ya ha sido Entregado al Paciente.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        End Select

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    Private Sub C1CmdImprimir_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdImprimir.Click

        If Table1.RowCount = 0 Then Exit Sub

        Try
            Select Case Table1.Item(GrillaAdmSolicitud.ColnAdmSolEstado, Table1.CurrentRow.Index).Value
                Case EstadoFichaAtencion.nPendientePago
                    'MessageBox.Show("Recibo de pago <No> ha sido programado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Agrego para poder imprimir lab externo en estado "Pendiente de Pago".
                    If Table1.Item(GrillaAdmSolicitud.ColnImpAnticipo, Table1.CurrentRow.Index).Value > 0 Or
                                    (Table1.Item(GrillaAdmSolicitud.ColnIntCodigo, Table1.CurrentRow.Index).Value = CLng(TipoAtencion.LabExterno) Or
                                        Table1.Item(GrillaAdmSolicitud.ColnIntCodigo, Table1.CurrentRow.Index).Value = CLng(TipoAtencion.Convenio) Or
                                        Table1.Item(GrillaAdmSolicitud.ColnIntCodigo, Table1.CurrentRow.Index).Value = CLng(TipoAtencion.CentroSalud)) Then
                        PrintFichaAtencion()
                    Else
                        MessageBox.Show("Ficha no tiene ningún Pago.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case EstadoFichaAtencion.nProgramado
                    MessageBox.Show("Recibo de pago ha sido programado aún falta realizar el pago.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Case EstadoFichaAtencion.nPagoRealizado
                    PrintFichaAtencion()

                Case EstadoFichaAtencion.nTomaExamen
                    MessageBox.Show("Paciente está pasando sus Exámenes en este momento.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Case EstadoFichaAtencion.nFinalizado
                    MessageBox.Show("La Toma de Examen ya ha terminado.!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Case EstadoFichaAtencion.nEntregado
                    MessageBox.Show("Ficha de Atención ya ha sido Entregado al Paciente.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Panel2.Visible = False : Table1.Enabled = True
    End Sub

    Private Sub C1CmdAnularFicha_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdAnularFicha.Click

        If table1.RowCount = 0 Then Exit Sub

        If CInt(table1.Item(GrillaAdmSolicitud.ColnAdmSolEstado, table1.CurrentRow.Index).Value) = CInt(EstadoFichaAtencion.nAnulado) Then Exit Sub

        If Convert.ToDouble(table1.Item(GrillaAdmSolicitud.ColnImpAnticipo, table1.CurrentRow.Index).Value) = 0 Then
            If MessageBox.Show("Desea anular la Ficha de Atención Nro. " + table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, table1.CurrentRow.Index).Value.ToString, "Anulando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim ServicioUpd As New BL.BL_FichaAtencion.BL_FichaAtencion

                '(eincio f.2015-11-05) Cambio estado pendiente de pago
                If Not ServicioUpd.Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero(StrcPerJuridica, table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, table1.CurrentRow.Index).Value.ToString, "", CInt(EstadoFichaAtencion.nAnulado), StrUser) Then
                    Throw New ApplicationException("Se encontraron errores en la transacción: " + "[Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero]")
                End If
                C1CmdBuscar_Click(C1CmdBuscar, Nothing)
            End If
        End If

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Table1.CellClick

        If e.ColumnIndex = GrillaAdmSolicitud.ColcExportEstado Or e.ColumnIndex = GrillaAdmSolicitud.ColcNroOrdenLIS Then
            If Table1.Item(GrillaAdmSolicitud.ColnAdmSolEstado, Table1.CurrentRow.Index).Value = EstadoFichaAtencion.nAnulado Then
                MessageBox.Show("No puede enviar Ficha en estado Anulado.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Table1.Item(GrillaAdmSolicitud.ColnExportEstado, Table1.CurrentRow.Index).Value = 0 Then 'Pendiente
                'MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)
                If MessageBox.Show("¿Desea enviar Ficha Nro." & Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value & Chr(13) & "Paciente: " & Table1.Item(GrillaAdmSolicitud.ColcPerNombreCompleto, Table1.CurrentRow.Index).Value & Chr(13) & "a Sistema Enterprise TS LIS.?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    TextBox1.Text = PExportLIS()
                Else
                    MessageBox.Show("Operación cancelada por el usuario.!", "Cancelando...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Ficha Ya esta enviada, por favor verifique.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'ElseIf e.ColumnIndex = GrillaAdmSolicitud.ColcEstadoResultado Then
            '    If My.Computer.FileSystem.FileExists("F:\Rick\Drawings\" & ListBox1.Text) Then
            '        sMyFileName = "F:\Rick\Drawings\" & ListBox1.Text
            '        System.Diagnostics.Process.Start(sMyFileName)
            '    Else
            '        MsgBox(sMyFileName & " was not found.")
            '    End If
        End If

    End Sub

    Private Sub C1CmdExport_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdExport.Click

        If Table1.RowCount = 0 Then Exit Sub
        'Call GridAExcel(Table1)
        ExportarDatosExcel(Table1, "Listado de Fichas", "") '"Desde: " + Format(DtpFecIni.Value, "dd/MM/yyyy") + " hasta: " + Format(DtpFecFin.Value, "dd/MM/yyyy"))

    End Sub

    Private Sub FormGridFichaAtencion_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        CargaIconGrilla()
    End Sub

    Private Sub C1CmdAppMovil_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles C1CmdAppMovil.Click

        FormProformaAndroid.ShowDialog()

    End Sub

    Private Sub ContextMnuControlEntrega_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMnuControlEntrega.Opening
        If Table1.RowCount = 0 Then Exit Sub

        If Table1.Item(GrillaAdmSolicitud.ColnValidaRecogo, Table1.CurrentRow.Index).Value = 1 Then
            RecogoResultadoToolStripMenuItem.Enabled = False
        ElseIf Table1.Item(GrillaAdmSolicitud.ColnValidaRecogo, Table1.CurrentRow.Index).Value = 0 Then
            TomaDeResultadoToolStripMnuItem.Enabled = False
            EntregaResultadoToolStripMenuItem.Enabled = False
            ValidacionResultadoToolStripMenuItem.Enabled = False
            RecogoResultadoToolStripMenuItem.Enabled = True
        End If

        If Table1.Item(GrillaAdmSolicitud.ColnValidaResultado, Table1.CurrentRow.Index).Value = 1 Then
            ValidacionResultadoToolStripMenuItem.Enabled = False
        ElseIf Table1.Item(GrillaAdmSolicitud.ColnValidaResultado, Table1.CurrentRow.Index).Value = 0 Then
            TomaDeResultadoToolStripMnuItem.Enabled = False
            EntregaResultadoToolStripMenuItem.Enabled = False
            ValidacionResultadoToolStripMenuItem.Enabled = True
            RecogoResultadoToolStripMenuItem.Enabled = False
        End If

        If Table1.Item(GrillaAdmSolicitud.ColnValidaEntrega, Table1.CurrentRow.Index).Value = 1 Then
            EntregaResultadoToolStripMenuItem.Enabled = False
        ElseIf Table1.Item(GrillaAdmSolicitud.ColnValidaEntrega, Table1.CurrentRow.Index).Value = 0 Then
            TomaDeResultadoToolStripMnuItem.Enabled = False
            EntregaResultadoToolStripMenuItem.Enabled = True
            ValidacionResultadoToolStripMenuItem.Enabled = False
            RecogoResultadoToolStripMenuItem.Enabled = False
        End If

        If Table1.Item(GrillaAdmSolicitud.ColnValidaToma, Table1.CurrentRow.Index).Value = 1 Then
            TomaDeResultadoToolStripMnuItem.Enabled = False
        ElseIf Table1.Item(GrillaAdmSolicitud.ColnValidaToma, Table1.CurrentRow.Index).Value = 0 Then
            TomaDeResultadoToolStripMnuItem.Enabled = True
            EntregaResultadoToolStripMenuItem.Enabled = False
            ValidacionResultadoToolStripMenuItem.Enabled = False
            RecogoResultadoToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub TomaDeResultadoToolStripMnuItem_Click(sender As Object, e As EventArgs) Handles TomaDeResultadoToolStripMnuItem.Click

        If Table1.RowCount > 0 Then

            LblFicha.Text = Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value
            LblPaciente.Text = Table1.Item(GrillaAdmSolicitud.ColcPerNombreCompleto, Table1.CurrentRow.Index).Value

            Centrar(Panel3)
            LlbTituloCER.Text = "҉   " & TomaDeResultadoToolStripMnuItem.Text
            bEstadoPanelCER(True, False, False, True, True, True)

        End If
    End Sub

    Private Sub EntregaResultadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregaResultadoToolStripMenuItem.Click
        If Table1.RowCount > 0 Then

            LblFicha.Text = Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value
            LblPaciente.Text = Table1.Item(GrillaAdmSolicitud.ColcPerNombreCompleto, Table1.CurrentRow.Index).Value

            Centrar(Panel3)
            LlbTituloCER.Text = "҉   " & EntregaResultadoToolStripMenuItem.Text
            CboMes.SelectedIndex = 0 : CboDia.SelectedIndex = 0 : CboHora.SelectedIndex = 0 : CboMinuto.SelectedIndex = 0
            bEstadoPanelCER(True, False, True, False, True, True)

        End If
    End Sub

    Private Sub ValidaciónResultadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidacionResultadoToolStripMenuItem.Click
        If Table1.RowCount > 0 Then

            LblFicha.Text = Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value
            LblPaciente.Text = Table1.Item(GrillaAdmSolicitud.ColcPerNombreCompleto, Table1.CurrentRow.Index).Value

            Centrar(Panel3)
            LlbTituloCER.Text = "҉   " & ValidacionResultadoToolStripMenuItem.Text
            bEstadoPanelCER(True, False, True, True, False, True)

        End If
    End Sub

    Private Sub RecogoResultadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecogoResultadoToolStripMenuItem.Click
        If Table1.RowCount > 0 Then

            LblFicha.Text = Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value
            LblPaciente.Text = Table1.Item(GrillaAdmSolicitud.ColcPerNombreCompleto, Table1.CurrentRow.Index).Value

            Centrar(Panel3)
            LlbTituloCER.Text = "҉   " & RecogoResultadoToolStripMenuItem.Text
            bEstadoPanelCER(True, False, True, True, True, False)

        End If
    End Sub

    Private Sub BtnTomarMuestra_Click(sender As Object, e As EventArgs) Handles BtnTomarMuestra.Click
        Try
            Dim gestionarAdSolAtencionServicio As New BL_FichaAtencion

            If Not gestionarAdSolAtencionServicio.Update_AdmSolAtencion_CER(LblFicha.Text, "T") Then
                Throw New ArgumentException("Se encontraron errores, operación ha sido cancelada.")
            Else
                CancelarCER()
                C1CmdBuscar_Click(C1CmdBuscar, Nothing)
                ResaltarFilaEditada(LblFicha.Text)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub BtnFechaEntrega_Click(sender As Object, e As EventArgs) Handles BtnFechaEntrega.Click
        Try
            Dim gestionarAdSolAtencionServicio As New BL_FichaAtencion

            If CInt(CboMes.Text) + CInt(CboDia.Text) + CInt(CboHora.Text) + CInt(CboMinuto.Text) = 0 Then
                MessageBox.Show("Debe especificar tiempo de entrega de resultados al paciente.", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If Not gestionarAdSolAtencionServicio.Update_AdmSolAtencion_CER(LblFicha.Text, "E", CInt(CboMes.Text), CInt(CboDia.Text), CInt(CboHora.Text), CInt(CboMinuto.Text)) Then
                Throw New ArgumentException("Se encontraron errores, operación ha sido cancelada.")
            Else
                CancelarCER()
                C1CmdBuscar_Click(C1CmdBuscar, Nothing)
                ResaltarFilaEditada(LblFicha.Text)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub BtnValidaR_Click(sender As Object, e As EventArgs) Handles BtnValidaR.Click
        Try
            Dim gestionarAdSolAtencionServicio As New BL_FichaAtencion

            If Not gestionarAdSolAtencionServicio.Update_AdmSolAtencion_CER(LblFicha.Text, "V") Then
                Throw New ArgumentException("Se encontraron errores, operación ha sido cancelada.")
            Else
                CancelarCER()
                C1CmdBuscar_Click(C1CmdBuscar, Nothing)
                ResaltarFilaEditada(LblFicha.Text)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub BtnRecogoR_Click(sender As Object, e As EventArgs) Handles BtnRecogoR.Click
        Try
            Dim gestionarAdSolAtencionServicio As New BL_FichaAtencion

            If Not gestionarAdSolAtencionServicio.Update_AdmSolAtencion_CER(LblFicha.Text, "R") Then
                Throw New ArgumentException("Se encontraron errores, operación ha sido cancelada.")
            Else
                CancelarCER()
                C1CmdBuscar_Click(C1CmdBuscar, Nothing)
                ResaltarFilaEditada(LblFicha.Text)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub bEstadoPanelCER(bGrilla As Boolean, bpnlMasterCER As Boolean, bpnlTomaM As Boolean, bpnlEntregaR As Boolean, bpnlValidaR As Boolean, bpnlRecogoR As Boolean)

        Table1.Enabled = Not bGrilla
        Panel3.Visible = Not bpnlMasterCER
        PnlTomaM.Visible = Not bpnlTomaM
        PnlEntregaR.Visible = Not bpnlEntregaR
        PnlValidaR.Visible = Not bpnlValidaR
        PnlRecogoR.Visible = Not bpnlRecogoR
    End Sub

    Private Sub CancelarCER()
        LlbTituloCER.Text = "҉   ?"
        bEstadoPanelCER(False, True, True, True, True, True)
    End Sub

    Private Sub BtnCancelarT_Click(sender As Object, e As EventArgs) Handles BtnCancelarT.Click
        CancelarCER()
    End Sub

    Private Sub BtnCancelarE_Click(sender As Object, e As EventArgs) Handles BtnCancelarE.Click
        CancelarCER()
    End Sub

    Private Sub BtnCancelarV_Click(sender As Object, e As EventArgs) Handles BtnCancelarV.Click
        CancelarCER()
    End Sub

    Private Sub BtnCancelarR_Click(sender As Object, e As EventArgs) Handles BtnCancelarR.Click
        CancelarCER()
    End Sub

    Private Sub ResaltarFilaEditada(ByVal nSolAdmNumero As String)
        Try

            If Table1.RowCount > 0 Then

                If Len(nSolAdmNumero.Trim) = 0 Then Exit Sub

                For i As Integer = 0 To Table1.RowCount
                    If Table1.Rows(i).Cells("nSolAdmNumero").Value.ToString = nSolAdmNumero.Trim.ToUpper Then

                        Table1.Rows(i).Selected = True
                        Table1.FirstDisplayedScrollingRowIndex = i
                        Table1.CurrentCell = Table1.Rows(i).Cells(0)

                        Exit Sub
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub DerivacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DerivacionesToolStripMenuItem.Click
        If Table1.RowCount > 0 Then

            FormDetalleDerivaciones.Mostrar(Table1.Item(GrillaAdmSolicitud.ColnSolAdmNumero, Table1.CurrentRow.Index).Value, Table1.Item(GrillaAdmSolicitud.ColcPerNombreCompleto, Table1.CurrentRow.Index).Value)

        End If
    End Sub
End Class
