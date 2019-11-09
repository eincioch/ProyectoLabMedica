
Imports Integration.BE
Imports Integration.BL
Imports Integration.BL.BL_Reportes

Public Class FormPrcLibroVta

    Private Sub FormPrcLibroVta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        FormatGrilla(Table1, Me, True, 60)
        FormatGrilla(Table2, Me, True, 40)

        'Llena Año
        ObtenerPeriodosPorSucursal(CboAnno, StrcPerJuridica)
        CboAnno.SelectedIndex = 1
        CboAnno_SelectionChangeCommitted(CboAnno, Nothing)

    End Sub

    Private Sub FormPrcLibroVta_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        'Table1.Width = Width - 30
        'Table1.Height = Height - 125
        'Table1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top _
        '    Or System.Windows.Forms.AnchorStyles.Bottom _
        '    Or System.Windows.Forms.AnchorStyles.Left _
        '    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

    End Sub

    Private Sub BtnMostrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnMostrar.Click

        Dim BL As New BL_BookElectronicoVta
        Table1.DataSource = BL.Get_CtasCtes_Get_LibroVentas_Electronico(Convert.ToInt32(CboMes.SelectedValue))
        Table2.DataSource = BL.Get_CtasCtes_Get_LibroVentas_Electronico(Convert.ToInt32(CboMes.SelectedValue), "R")
        'LblImpPeriodo.Text = FormatNumber(Suma_Columna("fCtaCtePagImporte", Table1), True)

    End Sub

    Private Sub BtnExport_Click(sender As System.Object, e As System.EventArgs) Handles BtnExport.Click
        'ExportarDatosPDF(Table1)
        ExportarDatosExcel(Table2, "Libro Electronico Ventas")

    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub BtnExportTxt_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportTxt.Click

        If Table1.RowCount = 0 Then Exit Sub

        ExportTXT(Table1, "LE20548626014" & Table1.Rows(0).Cells(0).Value.ToString & "140100001111.txt", "|")

    End Sub

    Private Sub CboAnno_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboAnno.SelectionChangeCommitted

        If CboAnno.SelectedValue = -1 Then Exit Sub

        ObtenerPeriodosPorSucursal(CboMes, StrcPerJuridica, CboAnno.SelectedValue, "M")

    End Sub

End Class