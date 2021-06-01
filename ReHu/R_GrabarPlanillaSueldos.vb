Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Controls

Public Class R_GrabarPlanillaSueldos
#Region "VARIABLES"
    Dim _Inter As Integer = 0
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public _nameButton As String
    Dim mes1 As Integer
    Dim anio1 As Integer
    Dim dtPlanilla As New DataTable

#End Region
#Region "MÉTODOS PRIVADOS"

    Private Sub _PIniciarTodo()
        Me.Text = "G R A B A R  P L A N I L L A    D E    S U E L D O S"

        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        'tbAnio.Value = (Now.Year)
    End Sub


    Public Sub _PCargarReporte(anio As Integer, mes As Integer)
        Dim _Ds As New DataSet

        Dim objrep As New R_PlanillaSueldo


        dtPlanilla = L_PlanillaSueldos(New Date(anio, mes, 1).ToString("yyyy/MM/dd"))
        objrep.SetDataSource(dtPlanilla)


        mes1 = mes
        anio1 = anio
        Dim mesl As String


        If mes1 = 1 Then
            mesl = "Enero"
        End If
        If mes1 = 2 Then
            mesl = "Febrero"
        End If
        If mes1 = 3 Then
            mesl = "Marzo"
        End If
        If mes1 = 4 Then
            mesl = "Abril"
        End If
        If mes1 = 5 Then
            mesl = "Mayo"
        End If
        If mes1 = 6 Then
            mesl = "Junio"
        End If
        If mes1 = 7 Then
            mesl = "Julio"
        End If
        If mes1 = 8 Then
            mesl = "Agosto"
        End If
        If mes1 = 9 Then
            mesl = "Septiembre"
        End If
        If mes1 = 10 Then
            mesl = "Octubre"
        End If
        If mes1 = 11 Then
            mesl = "Noviembre"
        End If
        If mes1 = 12 Then
            mesl = "Diciembre"
        End If
        objrep.SetParameterValue("periodo", mesl + "-" + anio1.ToString)

        MReportViewer.ReportSource = objrep
        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

    End Sub
    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               5000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)

    End Sub
    Public Sub _Guardar()
        Try
            Dim numi As String = ""

            Dim res As Boolean = L_GrabarPlanilla(numi, anio1, mes1, dtPlanilla)
            If res Then

                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                ToastNotification.Show(Me, "Planilla de Sueldos Grabada con éxito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )

            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "La Planilla de Sueldos no pudo ser insertada".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)

            End If
            'End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try


    End Sub
#End Region
#Region "EVENTOS"

    Private Sub R_PlanillaSueldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim dt As DataTable = L_VerificarPlanillaSueldos()
        Dim Anio As Integer = Now.Year
        Dim Mes As Integer = Now.Month
        If dt.Rows.Count = 0 Then
            Anio = Now.Year
            Mes = Now.Month - 1
            If Mes = 0 Then
                Anio = Anio - 1
                Mes = 12
            End If
            _PCargarReporte(Anio, Mes)
        Else

            Anio = dt.Rows(0).Item("phanio")
            Mes = dt.Rows(0).Item("phmes") + 1
            If Mes = 13 Then
                Anio = Anio + 1
                Mes = 1
            End If
            _PCargarReporte(Anio, Mes)
        End If

        gpDatos.Visible = True
        tbAnio.Value = anio1
        tbMes.Value = mes1

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

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            If mes1 = Now.Month Then
                ToastNotification.Show(Me, "No se puede grabar planilla antes que concluya el mes".ToUpper, My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                Dim dt As DataTable = L_VerificarSiSeGraboPlanilla(mes1, anio1)
                If dt.Rows.Count > 0 Then
                    ToastNotification.Show(Me, "Ya se grabó planilla de sueldos de este mes".ToUpper, My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
                Else
                    _Guardar()
                End If
            End If

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub


#End Region
End Class