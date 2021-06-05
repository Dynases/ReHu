Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Controls

Public Class R_PlanillaSueldos
#Region "VARIABLES"
    Dim _Inter As Integer = 0
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public _nameButton As String

#End Region
#Region "MÉTODOS PRIVADOS"

    Private Sub _PIniciarTodo()
        Me.Text = "P L A N I L L A    D E    S U E L D O S"

        _PCargarComboEmpleados()

        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        tbAnio.Value = (Now.Year)
    End Sub

    Private Sub _PCargarComboEmpleados()
        Dim _Ds As New DataSet
        _Ds.Tables.Add(L_prPersonalGeneral())

        JMc_Persona.DropDownList.Columns.Clear()


        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("panumi").ToString).Width = 70
        JMc_Persona.DropDownList.Columns(0).Caption = "Código"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("panombre").ToString).Width = 250
        JMc_Persona.DropDownList.Columns(1).Caption = "Nombres"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("panrodoc").ToString).Width = 90
        JMc_Persona.DropDownList.Columns(2).Caption = "CI"


        JMc_Persona.ValueMember = _Ds.Tables(0).Columns("panumi").ToString
        JMc_Persona.DisplayMember = _Ds.Tables(0).Columns("panombre").ToString
        JMc_Persona.DataSource = _Ds.Tables(0)
        JMc_Persona.Refresh()
    End Sub
    Private Sub _PCargarReporte(codPer As Integer)
        Dim _Ds As New DataSet

        Dim objrep As New R_PlanillaSueldoGrabada
        Dim dt As New DataTable

        'dt = L_PlanillaSueldos(New Date(tbAnio.Value, tbMes.Value, 1).ToString("yyyy/MM/dd"))
        dt = L_PlanillaSueldosGrabada(tbMes.Value, tbAnio.Value)

        If dt.Rows.Count > 0 Then
            If codPer > 0 Then
                dt.Select("codPer=" + Str(codPer))

                Dim rows As DataRow()

                Dim dtNew As DataTable

                ' copy table structure
                dtNew = dt.Clone()

                ' sort and filter data
                rows = dt.Select("codPer=" + Str(codPer))

                ' fill dtNew with selected rows

                For Each dr As DataRow In rows
                    dtNew.ImportRow(dr)
                Next
                objrep.SetDataSource(dtNew)
            Else
                objrep.SetDataSource(dt)
            End If


            Dim mes As Integer = tbMes.Value
            Dim mesl As String
            Dim anio As Integer = tbAnio.Value

            If mes = 1 Then
                mesl = "Enero"
            End If
            If mes = 2 Then
                mesl = "Febrero"
            End If
            If mes = 3 Then
                mesl = "Marzo"
            End If
            If mes = 4 Then
                mesl = "Abril"
            End If
            If mes = 5 Then
                mesl = "Mayo"
            End If
            If mes = 6 Then
                mesl = "Junio"
            End If
            If mes = 7 Then
                mesl = "Julio"
            End If
            If mes = 8 Then
                mesl = "Agosto"
            End If
            If mes = 9 Then
                mesl = "Septiembre"
            End If
            If mes = 10 Then
                mesl = "Octubre"
            End If
            If mes = 11 Then
                mesl = "Noviembre"
            End If
            If mes = 12 Then
                mesl = "Diciembre"
            End If
            objrep.SetParameterValue("periodo", mesl + "-" + anio.ToString)

            MReportViewer.ReportSource = objrep
            MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Else
            ToastNotification.Show(Me, "NO HAY PLANILLA GRABADA PARA ESTE MES", My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.BottomLeft)
        End If


    End Sub

    Private Sub _PCargarReporteResumen()

        Dim objrep As New R_PlanillaSueldoResumen
        Dim dt As New DataTable

        'dt = L_PlanillaSueldos(New Date(tbAnio.Value, tbMes.Value, 1).ToString("yyyy/MM/dd"))
        dt = L_PlanillaSueldosGrabada(tbMes.Value, tbAnio.Value)

        If dt.Rows.Count > 0 Then

            objrep.SetDataSource(dt)


            Dim mes As Integer = tbMes.Value
            Dim mesl As String
            Dim anio As Integer = tbAnio.Value

            If mes = 1 Then
                mesl = "Enero"
            End If
            If mes = 2 Then
                mesl = "Febrero"
            End If
            If mes = 3 Then
                mesl = "Marzo"
            End If
            If mes = 4 Then
                mesl = "Abril"
            End If
            If mes = 5 Then
                mesl = "Mayo"
            End If
            If mes = 6 Then
                mesl = "Junio"
            End If
            If mes = 7 Then
                mesl = "Julio"
            End If
            If mes = 8 Then
                mesl = "Agosto"
            End If
            If mes = 9 Then
                mesl = "Septiembre"
            End If
            If mes = 10 Then
                mesl = "Octubre"
            End If
            If mes = 11 Then
                mesl = "Noviembre"
            End If
            If mes = 12 Then
                mesl = "Diciembre"
            End If
            objrep.SetParameterValue("periodo", mesl + "-" + anio.ToString)

            MReportViewer.ReportSource = objrep
            MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Else
            ToastNotification.Show(Me, "NO HAY PLANILLA GRABADA PARA ESTE MES", My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.BottomLeft)
        End If

    End Sub

#End Region
#Region "EVENTOS"


    Private Sub R_PlanillaSueldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If swTipo.Value = True Then
            If swFiltrar.Value = False Then
                If JMc_Persona.SelectedIndex >= 0 Then
                    Dim codPer As Integer
                    codPer = JMc_Persona.Value
                    _PCargarReporte(codPer)
                Else
                    ToastNotification.Show(Me, "SELECCIONE ALGÚN EMPLEADO", My.Resources.WARNING, 5000, eToastGlowColor.Red, eToastPosition.BottomLeft)
                End If

            Else
                _PCargarReporte(0)
            End If
        Else
            _PCargarReporteResumen()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Inter = _Inter + 1
        If _Inter = 1 Then
            Me.WindowState = FormWindowState.Normal
            Me.StartPosition = FormStartPosition.CenterScreen
        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub swFiltrar_ValueChanged(sender As Object, e As EventArgs) Handles swFiltrar.ValueChanged
        If swFiltrar.Value = True Then
            JMc_Persona.Visible = False
        Else
            JMc_Persona.Visible = True
        End If
    End Sub

    Private Sub swTipo_ValueChanged(sender As Object, e As EventArgs) Handles swTipo.ValueChanged
        If swTipo.Value = False Then
            swFiltrar.Value = True
        End If
    End Sub
#End Region
End Class