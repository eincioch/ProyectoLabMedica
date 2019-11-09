Imports Integration.BE.Reportes
Imports Integration.BL.BL_CtaCteListaServicio

Public Class FormRankingExamenes

    Private Sub EstructuraGrillaProforma_Examen()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()
            '0
            Dim ColcCtaCteRecibo As New DataGridViewTextBoxColumn()
            With ColcCtaCteRecibo
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cCtaCteSerJerarquia"
                .Name = "cCtaCteSerJerarquia"
                .HeaderText = "Código"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColcCtaCteRecibo)
            '1
            Dim ColItem As New DataGridViewTextBoxColumn()
            With ColItem
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cCtaCteSerKeyWord"
                .Name = "cCtaCteSerKeyWord"
                .HeaderText = "Nombre Examen"
                .ReadOnly = True : .Visible = True
                .Width = 320
            End With
            .Columns.Add(ColItem)
            '2
            Dim ColnCtaCteCantidad As New DataGridViewTextBoxColumn()
            With ColnCtaCteCantidad
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "N0"
                .DataPropertyName = "QTY"
                .Name = "QTY"
                .HeaderText = "Cantidad"
                .ReadOnly = False : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColnCtaCteCantidad)
            '3
            Dim ColfCtaCteTC As New DataGridViewTextBoxColumn()
            With ColfCtaCteTC
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nImpVta"
                .Name = "nImpVta"
                .HeaderText = "Importe en Ventas"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCteTC)
            '4
            Dim ColnCtaCtedetEstado As New DataGridViewTextBoxColumn()
            With ColnCtaCtedetEstado
                .DataPropertyName = "cProceso"
                .Name = "cProceso"
                .HeaderText = "Proceso"
                .ReadOnly = True : .Visible = True
                .Width = 120
            End With
            .Columns.Add(ColnCtaCtedetEstado)

        End With

    End Sub

    Private Sub EstructuraGrillaProforma_GrupoPC()

        With Table1
            .AutoGenerateColumns = False
            .Columns.Clear()
            '0
            Dim ColdFecRegistro As New DataGridViewTextBoxColumn()
            With ColdFecRegistro
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "dFecRegistro"
                .Name = "dFecRegistro"
                .HeaderText = "Año|Mes"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColdFecRegistro)

            Dim ColcCtaCteRecibo As New DataGridViewTextBoxColumn()
            With ColcCtaCteRecibo
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DataPropertyName = "cIntJerarquia"
                .Name = "cIntJerarquia"
                .HeaderText = "Código"
                .ReadOnly = True : .Visible = True
                .Width = 100
            End With
            .Columns.Add(ColcCtaCteRecibo)
            '1
            Dim ColItem As New DataGridViewTextBoxColumn()
            With ColItem
                .DefaultCellStyle.Format = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DataPropertyName = "cIntDescripcion"
                .Name = "cIntDescripcion"
                .HeaderText = "Nombre Exámen"
                .ReadOnly = True : .Visible = True
                .Width = 320
            End With
            .Columns.Add(ColItem)
            '2
            Dim ColnCtaCteCantidad As New DataGridViewTextBoxColumn()
            With ColnCtaCteCantidad
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Format = "N0"
                .DataPropertyName = "QTY"
                .Name = "QTY"
                .HeaderText = "Cantidad"
                .ReadOnly = False : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColnCtaCteCantidad)
            '3
            Dim ColnPrecioPromocion As New DataGridViewTextBoxColumn()
            With ColnPrecioPromocion
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nPrecioPromocion"
                .Name = "nPrecioPromocion"
                .HeaderText = "Precio Promo"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColnPrecioPromocion)
            '4
            Dim ColfCtaCteTC As New DataGridViewTextBoxColumn()
            With ColfCtaCteTC
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "N2"
                .DataPropertyName = "nImpVta"
                .Name = "nImpVta"
                .HeaderText = "Importe en Ventas"
                .ReadOnly = True : .Visible = True
                .Width = 90
            End With
            .Columns.Add(ColfCtaCteTC)

        End With

    End Sub

    Private Sub CargarComboGrupo()

        Dim reqRptParametros As New ReqRptParametros

        reqRptParametros.cPerCodigo = StrcPerJuridica

        If RbtnExamen.Checked Then reqRptParametros.cTipo = "E"
        If RbtnPerfil.Checked Then reqRptParametros.cTipo = "P"
        If RbtnCampana.Checked Then reqRptParametros.cTipo = "C"

        Dim gestionarCtaCteListaServicioServicio As New GestionarCtaCteListaServicioServicio

        LlenaDataCombo(CboLista, gestionarCtaCteListaServicioServicio.Get_Lista_Grupo_Examenes(reqRptParametros), "Codigo", "Descripcion")


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormRankingExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatGrilla(Table1, Me, True, 40)

        DtpFecIni.Value = dFechaSistema
        DtpFecIni.Value = DtpFecIni.Value

    End Sub

    Private Sub RbtnExamen_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnExamen.CheckedChanged
        CargarComboGrupo()
    End Sub

    Private Sub RbtnPerfil_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnPerfil.CheckedChanged
        CargarComboGrupo()
    End Sub

    Private Sub RbtnCampana_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnCampana.CheckedChanged
        CargarComboGrupo()
    End Sub

    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click

        Dim reqRptParametros As New ReqRptParametros

        If CboLista.SelectedValue = "00000" Then reqRptParametros.cIntJerarquia = "" Else reqRptParametros.cIntJerarquia = TxtCodigos.Text

        reqRptParametros.cFecIni = Format(DtpFecIni.Value, "yyyy/MM/dd")
        reqRptParametros.cFecFin = Format(DtpFecFin.Value, "yyyy/MM/dd")

        If RbtnExamen.Checked Then reqRptParametros.cTipo = "E" : EstructuraGrillaProforma_Examen()
        If RbtnPerfil.Checked Then reqRptParametros.cTipo = "P" : EstructuraGrillaProforma_GrupoPC()
        If RbtnCampana.Checked Then reqRptParametros.cTipo = "C" : EstructuraGrillaProforma_GrupoPC()

        Dim gestionarCtaCteListaServicioServicio As New GestionarCtaCteListaServicioServicio

        Table1.DataSource = gestionarCtaCteListaServicioServicio.Get_Ranking_Grupo_Examenes(reqRptParametros)

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
        Dispose()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtCodigos.Text = ""
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        TxtCodigos.Text = TxtCodigos.Text + CboLista.SelectedValue.ToString + ","

    End Sub

    Private Sub BtnExportExcel_Click(sender As Object, e As EventArgs) Handles BtnExportExcel.Click
        If Table1.RowCount = 0 Then Exit Sub
        'Call GridAExcel(Table1)
        ExportarDatosExcel(Table1, "Ranking de Muestras", "Desde: " + Format(DtpFecIni.Value, "dd/MM/yyyy") + " hasta: " + Format(DtpFecFin.Value, "dd/MM/yyyy"))
    End Sub
End Class