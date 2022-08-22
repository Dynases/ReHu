Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Controls
Imports System.IO
Imports Microsoft.Office
Imports Microsoft.ACE.OLEDB

Public Class F3_PlanillaSueldos2
#Region "VARIABLES"
    Dim _Inter As Integer = 0
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public _nameButton As String
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim RutaTemporal As String = "C:\Temporal"

#End Region
#Region "MÉTODOS PRIVADOS"
    Private Sub _PIniciarTodo()
        Me.Text = "P L A N I L L A    D E    S U E L D O S"
        tbAnio.Value = (Now.Year)
    End Sub
    Private Sub _PCargarReporte()
        Dim dt As New DataTable
        dt = L_PlanillaSueldosGrabadaFormato2(tbMes.Value, tbAnio.Value)

        If dt.Rows.Count > 0 Then
            _prCargarPlanilla(dt)
            'JGr_Buscador.DataSource = dt
        Else
            ToastNotification.Show(Me, "NO HAY PLANILLA GRABADA PARA ESTE MES", My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
    End Sub
    Private Sub _prCargarPlanilla(dt As DataTable)
        DataGridView1.DataSource = dt
        JGr_Buscador.DataSource = dt
        JGr_Buscador.RetrieveStructure()
        JGr_Buscador.AlternatingColors = True

        With JGr_Buscador.RootTable.Columns("Nro")
            .Width = 60
            .Caption = "NRO."
            .Visible = True
        End With
        With JGr_Buscador.RootTable.Columns("pgnumi")
            .Visible = False
        End With
        With JGr_Buscador.RootTable.Columns("pganio")
            .Visible = False
        End With
        With JGr_Buscador.RootTable.Columns("pgmes")
            .Visible = False
        End With
        With JGr_Buscador.RootTable.Columns("panrodoc")
            .Width = 90
            .Visible = True
            .Caption = "CI"
        End With
        With JGr_Buscador.RootTable.Columns("codPer")
            .Visible = False
        End With
        With JGr_Buscador.RootTable.Columns("nombre")
            .Width = 200
            .Caption = "APELLIDOS Y NOMBRES"
        End With
        With JGr_Buscador.RootTable.Columns("ycdes3")
            .Width = 120
            .Visible = True
            .Caption = "NACIONALIDAD"
        End With
        With JGr_Buscador.RootTable.Columns("fechaNac")
            .Width = 120
            .Caption = "FECHA NAC."
        End With
        With JGr_Buscador.RootTable.Columns("codCargo")
            .Visible = False
        End With
        With JGr_Buscador.RootTable.Columns("cargo")
            .Width = 180
            .Visible = True
            .Caption = "CARGO"
        End With
        With JGr_Buscador.RootTable.Columns("fechaIng")
            .Width = 50
            .Caption = "FECHA ING."
        End With
        With JGr_Buscador.RootTable.Columns("DiasPag")
            .Width = 50
            .Caption = "DIAS PAG."
        End With
        With JGr_Buscador.RootTable.Columns("HorasPag")
            .Width = 50
            .Caption = "HORAS PAG."
        End With
        With JGr_Buscador.RootTable.Columns("tipo")
            .Visible = False
        End With
        With JGr_Buscador.RootTable.Columns("obs")
            .Visible = False
        End With
        With JGr_Buscador.RootTable.Columns("haberBasico")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "HABER BÁSICO"
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("SueldoMes")
            .Visible = False
        End With
        With JGr_Buscador.RootTable.Columns("BonoAnt")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "BONO ANTIGÜEDAD"
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("N")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "Nº"
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("MontoPag")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "MONTO PAG."
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("BonoProd")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "BONO PROD."
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("BonoDominical")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "DOMINICALES"
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("OtrosBonos")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "OTROS BONOS"
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("TotalGanado")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "TOTAL GANADO"
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("AFP")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "AFP 12.71%"
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("RCIVA")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "RC-IVA"
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("OtrosDesc")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "OTROS DSTOS."
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("TotalDesc")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "TOTAL DSTO."
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("LiqPagable")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "LÍQUIDO PAGABLE"
            .FormatString = "0.00"
        End With
        With JGr_Buscador.RootTable.Columns("Firma")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "FIRMA"
        End With

        With JGr_Buscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False

            'diseño de la grilla
            JGr_Buscador.VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prCrearCarpetaReportes()
        Dim rutaDestino As String = RutaGlobal + "\Reporte\Planilla Sueldos\"

        If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Planilla Sueldos\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Reporte") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte")
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Planilla Sueldos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Planilla Sueldos")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Planilla Sueldos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Planilla Sueldos")

                End If
            End If
        End If
    End Sub
    Public Function P_ExportarExcel(_ruta As String) As Boolean
        Dim _ubicacion As String
        'Dim _directorio As New FolderBrowserDialog

        If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            '_ubicacion = _directorio.SelectedPath
            _ubicacion = _ruta
            Try
                Dim _stream As Stream
                Dim _escritor As StreamWriter
                Dim _fila As Integer = JGr_Buscador.GetRows.Length
                Dim _columna As Integer = JGr_Buscador.RootTable.Columns.Count
                'Dim _archivo As String = _ubicacion & "\PlanillaSueldos_" & Now.Date.Day &
                '    "." & Now.Date.Month & "." & Now.Date.Year & "_" & Now.Hour & "." & Now.Minute & "." & Now.Second & ".csv"
                Dim _archivo As String = _ubicacion & "\PlanillaSueldos.csv"
                Dim _linea As String = ""
                Dim _filadata = 0, columndata As Int32 = 0
                'File.Delete(_archivo)
                _stream = File.OpenWrite(_archivo)
                _escritor = New StreamWriter(_stream, System.Text.Encoding.UTF8)

                'For Each _col As GridEXColumn In JGr_Buscador.RootTable.Columns
                '    If (_col.Visible) Then
                '        _linea = _linea & _col.Caption & ";"
                '    End If
                'Next

                '_linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                '_escritor.WriteLine(_linea)
                '_linea = Nothing

                'Pbx_Precios.Visible = True
                'Pbx_Precios.Minimum = 1
                'Pbx_Precios.Maximum = Dgv_Precios.RowCount
                'Pbx_Precios.Value = 1

                For Each _fil As GridEXRow In JGr_Buscador.GetRows
                    For Each _col As GridEXColumn In JGr_Buscador.RootTable.Columns
                        If (_col.Visible) Then
                            Dim data As String = CStr(_fil.Cells(_col.Key).Value)
                            data = data.Replace(";", ",")
                            _linea = _linea & data & ";"
                        End If
                    Next
                    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                    _escritor.WriteLine(_linea, 2, 2)
                    _linea = Nothing
                    'Pbx_Precios.Value += 1

                Next
                'For index = 1 To JGr_Buscador.RowCount
                '    For Each _col As GridEXColumn In JGr_Buscador.RootTable.Columns
                '        If (_col.Visible) Then
                '            'Dim data As String = CStr(index.Cells(_col.Key).Value)
                '            Dim data As String = CStr(_col.Key(index).ToString())

                '            data = data.Replace(";", ",")
                '            _linea = _linea & data & ";"
                '        End If
                '    Next
                '    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                '    _escritor.WriteLine(_linea)
                '    _linea = Nothing
                '    'Pbx_Precios.Value += 1
                'Next


                _escritor.Close()
                'Pbx_Precios.Visible = False
                Try
                    Dim ef = New Efecto
                    ef._archivo = _archivo

                    ef.tipo = 1
                    ef.Context = "Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?"
                    ef.Header = "PREGUNTA"
                    ef.ShowDialog()
                    Dim bandera As Boolean = False
                    bandera = ef.band
                    If (bandera = True) Then
                        Process.Start(_archivo)
                    End If

                    'If (MessageBox.Show("Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    '    Process.Start(_archivo)
                    'End If
                    Return True
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return False
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End If
        Return False
    End Function

    Public Function P_ExportarExcel2(_ruta As String) As Boolean
        Dim _ubicacion As String
        'Dim _directorio As New FolderBrowserDialog

        If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            '_ubicacion = _directorio.SelectedPath
            _ubicacion = _ruta
            Try
                Dim Excel As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
                Excel.Visible = True
                Dim workbook As Microsoft.Office.Interop.Excel.Workbook = Excel.Workbooks.Add(System.Reflection.Missing.Value)
                Dim sheet1 As Microsoft.Office.Interop.Excel.Worksheet = CType(workbook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                Dim StartCol As Integer = 1
                Dim StartRow As Integer = 15
                Dim j As Integer = 0, i As Integer = 0


                For j = 0 To DataGridView1.Columns.Count - 1
                    Dim myRange As Microsoft.Office.Interop.Excel.Range = CType(sheet1.Cells(StartRow, StartCol + j), Microsoft.Office.Interop.Excel.Range)
                    myRange.Value2 = DataGridView1.Columns(j).HeaderText
                Next

                StartRow += 1

                For i = 0 To DataGridView1.Rows.Count - 1

                    For j = 0 To DataGridView1.Columns.Count - 1

                        Try
                            Dim myRange As Microsoft.Office.Interop.Excel.Range = CType(sheet1.Cells(StartRow + i, StartCol + j), Microsoft.Office.Interop.Excel.Range)
                            myRange.Value2 = If(DataGridView1(j, i).Value Is Nothing, "", DataGridView1(j, i).Value)
                        Catch
                        End Try
                    Next
                Next


            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End If
        Return False
    End Function



#End Region

    Private Sub F3_PlanillaSueldos2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        _PCargarReporte()
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

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        _prCrearCarpetaReportes()
        'Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
        'If (P_ExportarExcel(RutaGlobal + "\Reporte\Planilla Sueldos")) Then
        '    ToastNotification.Show(Me, "EXPORTACIÓN DE LISTA DE PRODUCTOS EXITOSA..!!!",
        '                               img, 2000,
        '                               eToastGlowColor.Green,
        '                               eToastPosition.BottomCenter)
        'Else
        '    ToastNotification.Show(Me, "FALLO AL EXPORTACIÓN DE LISTA DE PRODUCTOS..!!!",
        '                               My.Resources.WARNING, 2000,
        '                               eToastGlowColor.Red,
        '                               eToastPosition.BottomLeft)
        'End If
        P_ExportarExcel2(RutaGlobal + "\Reporte\Planilla Sueldos")
    End Sub
End Class