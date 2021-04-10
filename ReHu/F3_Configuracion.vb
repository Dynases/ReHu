Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Controls
Public Class F3_Configuracion
#Region "Variables Locales"
    Dim _Inter As Integer = 0
    Public _modulo As SideNavItem
    Public _nameButton As String
    Dim _Dsencabezado As DataSet
    Dim _Pos As Integer
    Dim _Nuevo As Boolean

#End Region
#Region "Metodos Privados"
    Private Sub _PIniciarTodo()
        Me.Text = "P A R Á M E T R O S"

        _prAsignarPermisos()
        _PCargarBuscador()
        _PCargarBuscadorBono()
        _PCargarBuscadorVacacion()
        _PInhabilitar()

        superTabControl1.SelectedTabIndex = 0

    End Sub
    Private Sub _prAsignarPermisos()

        Dim dtRolUsu As DataTable = L_prRolDetalleGeneral(gi_userRol, _nameButton)

        Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        If add = False Then
            btnNuevo.Visible = False
        End If
        If modif = False Then
            btnModificar.Visible = False
        End If
        If del = False Then
            btnEliminar.Visible = False
        End If

    End Sub
    Private Sub _PCargarBuscador()
        Dim dt As New DataTable
        dt = L_prDescuentoGeneral()

        JGr_Buscador.BoundMode = BoundMode.Bound
        JGr_Buscador.DataSource = dt
        JGr_Buscador.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Buscador.RootTable.Columns("danumi")
            .Caption = "Codigo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("datipo")
            .Caption = "Tipo Desc."
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_Buscador.RootTable.Columns("datipomonto")
            .Caption = "Tipo Monto"
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("damonto")
            .Caption = "Monto"
            .Width = 130
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With

        With JGr_Buscador.RootTable.Columns("daobs")
            .Caption = "Observacion"
            .Width = 300
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With JGr_Buscador.RootTable.Columns("dafinicio")
            .Caption = "Fecha Inicio"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_Buscador.RootTable.Columns("davenc")
            .Caption = "Estado Vencimiento"
            .Visible = True
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .EditType = EditType.CheckBox
            .ColumnType = ColumnType.CheckBox
            .CheckBoxFalseValue = 0
            .CheckBoxTrueValue = 1
        End With

        With JGr_Buscador.RootTable.Columns("dafvenc")
            .Caption = "Fecha Venc."
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("daestado")
            .Visible = False
        End With

        With JGr_Buscador.RootTable.Columns("dafact")
            .Visible = False
        End With

        With JGr_Buscador.RootTable.Columns("dahact")
            .Visible = False
        End With

        With JGr_Buscador.RootTable.Columns("dauact")
            .Visible = False
        End With
        'Habilitar Filtradores
        With JGr_Buscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            JGr_Buscador.VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _PCargarBuscadorBono()
        Dim dt As New DataTable
        dt = L_prDescuentoGeneral()

        JGr_BonoAntiguedad.BoundMode = BoundMode.Bound
        JGr_BonoAntiguedad.DataSource = dt
        JGr_BonoAntiguedad.RetrieveStructure()

        'dar formato a las columnas
        With JGr_BonoAntiguedad.RootTable.Columns("banumi")
            .Caption = "Codigo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_BonoAntiguedad.RootTable.Columns("bameses")
            .Caption = "Meses"
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_BonoAntiguedad.RootTable.Columns("bamonto")
            .Caption = "Monto"
            .Width = 130
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With

        With JGr_BonoAntiguedad.RootTable.Columns("baestado")
            .Caption = "Estado"
            .Width = 300
            .Visible = False
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With JGr_BonoAntiguedad.RootTable.Columns("bafact")
            .Visible = False
        End With

        With JGr_BonoAntiguedad.RootTable.Columns("bahact")
            .Visible = False
        End With

        With JGr_BonoAntiguedad.RootTable.Columns("bauact")
            .Visible = False
        End With
        'Habilitar Filtradores
        With JGr_BonoAntiguedad
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            JGr_BonoAntiguedad.VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _PCargarBuscadorVacacion()
        Dim dt As New DataTable
        dt = L_prVacacionGeneral()

        JGr_Vacacion.BoundMode = BoundMode.Bound
        JGr_Vacacion.DataSource = dt
        JGr_Vacacion.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Vacacion.RootTable.Columns("vanumi")
            .Caption = "Codigo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Vacacion.RootTable.Columns("vameses")
            .Caption = "Meses"
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Vacacion.RootTable.Columns("vadias")
            .Caption = "Dias"
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_Vacacion.RootTable.Columns("vadias")
            .Caption = "Dias"
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Vacacion.RootTable.Columns("vafvig")
            .Caption = "Fecha Vigencia"
            .Width = 1500
            .Visible = True
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With JGr_Vacacion.RootTable.Columns("vatipo")
            .Visible = False
        End With
        With JGr_Vacacion.RootTable.Columns("vaestado")
            .Visible = False
        End With
        With JGr_Vacacion.RootTable.Columns("vafact")
            .Visible = False
        End With
        With JGr_Vacacion.RootTable.Columns("vahact")
            .Visible = False
        End With
        With JGr_Vacacion.RootTable.Columns("vauact")
            .Visible = False
        End With
        'Habilitar Filtradores
        With JGr_Vacacion
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            JGr_Vacacion.VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _PInhabilitar()
        tbNumi.ReadOnly = True
        swTipoDesc.Enabled = False
        swTMonto.Enabled = False
        tbMonto.ReadOnly = True
        tbObservacion.ReadOnly = True
        dtFInicio.Enabled = False
        swVencimiento.Enabled = False
        dtFVencimiento.Enabled = False

        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGrabar.Enabled = False
    End Sub
    Private Sub _PInhabilitarBono()
        tbNumiBono.ReadOnly = True
        tbBonoMeses.ReadOnly = True
        tbBonoImporte.ReadOnly = True

        btnNuevoBono.Enabled = True
        btnModificarBono.Enabled = True
        btnEliminarBono.Enabled = True
        btnGrabarBono.Enabled = False
    End Sub
    Private Sub _PInhabilitarVacacion()
        tbNumiVacacion.ReadOnly = True
        tbVacacionMeses.ReadOnly = True
        tbVacacionDias.ReadOnly = True
        dtVacacionFecha.Enabled = False
        swVacacionTipo.Enabled = False

        btnNuevoVacacion.Enabled = True
        btnModificarVacacion.Enabled = True
        btnEliminarVacacion.Enabled = True
        btnGrabarVacacion.Enabled = False
    End Sub
    Private Sub _PHabilitar()

        swTipoDesc.Enabled = True
        swTMonto.Enabled = True
        tbMonto.ReadOnly = False
        tbObservacion.ReadOnly = False
        dtFInicio.Enabled = True
        swVencimiento.Enabled = True
        dtFVencimiento.Enabled = True

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = True

    End Sub
    Private Sub _PLimpiar()
        'Datos Generales
        tbNumi.Text = ""
        swTipoDesc.Text = ""
        swTMonto.Text = ""
        tbMonto.Text = ""
        tbObservacion.Text = ""
        dtFInicio.Value = Now.Date
        swVencimiento.Value = False
        dtFVencimiento.Value = Now.Date
    End Sub
    Private Sub _PNuevoRegistro()
        _PHabilitar()
        _PLimpiar()
        RLAccion.Text = "NUEVO"
    End Sub
    Private Sub _PModificarRegistro()
        _PHabilitar()
        RLAccion.Text = "MODIFICAR"
    End Sub
    Public Sub _PGuardar()
        Try
            If _ValidarCampos() = False Then
                Exit Sub
            End If

            If (tbNumi.Text = String.Empty) Then
                _GuardarNuevo()
            Else
                If (tbNumi.Text <> String.Empty) Then
                    _GuardarModificado()
                End If
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Function _ValidarCampos() As Boolean
        Try
            If (tbMonto.Text = String.Empty) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor ingrese el Monto de Descuento.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                tbMonto.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
            Return False
        End Try
    End Function
    Public Sub _GuardarNuevo()
        Try
            Dim res As Boolean = L_prGrabarDescuento(tbNumi.Text, IIf(swTipoDesc.Value = True, "1", "0"),
                                                     IIf(swTMonto.Value = True, "1", "0"), tbMonto.Text, tbObservacion.Text,
                                                     dtFInicio.Value.ToString("yyyy/MM/dd"), IIf(swVencimiento.Value = True, "1", "0"),
                                                     dtFVencimiento.Value.ToString("yyyy/MM/dd"))
            If res Then

                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                ToastNotification.Show(Me, "Código de Descuento ".ToUpper + tbNumi.Text + " Grabado con éxito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )

                _PCargarBuscador()
                _PLimpiar()

            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "El Descuento no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

            End If

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _GuardarModificado()
        Try

            Dim res As Boolean = L_prModificarDescuento(tbNumi.Text, IIf(swTipoDesc.Value = True, "1", "0"),
                                                        IIf(swTMonto.Value = True, "1", "0"), tbMonto.Text, tbObservacion.Text,
                                                        dtFInicio.Value.ToString("yyyy/MM/dd"), IIf(swVencimiento.Value = True, "1", "0"),
                                                        dtFVencimiento.Value.ToString("yyyy/MM/dd"))

            If res Then

                ToastNotification.Show(Me, "Código de Descuento ".ToUpper + tbNumi.Text + " modificado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                _PCargarBuscador()
                _prSalir()
            End If


        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               5000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)

    End Sub
    Public Sub _prMostrarRegistro(_N As Integer)
        Try

            With JGr_Buscador
                tbNumi.Text = .GetValue("danumi").ToString
                swTipoDesc.Value = .GetValue("datipo")
                swTMonto.Value = .GetValue("datipomonto")
                tbMonto.Text = .GetValue("damonto").ToString
                tbObservacion.Text = .GetValue("daobs").ToString
                dtFInicio.Value = .GetValue("dafinicio")
                swVencimiento.Value = .GetValue("davenc")
                dtFVencimiento.Value = .GetValue("dafvenc")

                lbFecha.Text = CType(.GetValue("dafact"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("dahact").ToString
                lbUsuario.Text = .GetValue("dauact").ToString


            End With

            LblPaginacion.Text = Str(JGr_Buscador.Row + 1) + "/" + JGr_Buscador.RowCount.ToString

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _EliminarRegistro()
        Dim info As New TaskDialogInfo("eliminacion".ToUpper, eTaskDialogIcon.Delete, "¿esta seguro de eliminar el registro?".ToUpper, "".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
        Dim result As eTaskDialogResult = TaskDialog.Show(info)
        If result = eTaskDialogResult.Yes Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_prEliminarDescuento(tbNumi.Text, mensajeError)
            If res Then
                ToastNotification.Show(Me, "Codigo de Descuento ".ToUpper + tbNumi.Text + " eliminado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                _PCargarBuscador()
                _PInhabilitar()
            Else
                ToastNotification.Show(Me, mensajeError, My.Resources.WARNING, 8000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub
    Private Sub _prSalir()
        If btnGrabar.Enabled = True Then
            _PInhabilitar()

            If JGr_Buscador.RowCount > 0 Then
                _prMostrarRegistro(0)
            End If
        Else
            Me.Close()
            _modulo.Select()
        End If
    End Sub

#End Region

#Region "Eventos"
    Private Sub F3_Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _PNuevoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        _PModificarRegistro()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        _PGuardar()
    End Sub

    Private Sub JGr_Buscador_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_Buscador.EditingCell
        e.Cancel = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _prSalir()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        _EliminarRegistro()
    End Sub

    Private Sub JGr_Buscador_SelectionChanged(sender As Object, e As EventArgs) Handles JGr_Buscador.SelectionChanged
        If (JGr_Buscador.RowCount >= 0 And JGr_Buscador.Row >= 0) Then
            _prMostrarRegistro(JGr_Buscador.Row)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Inter = _Inter + 1
        If _Inter = 1 Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub btnNuevoBono_Click(sender As Object, e As EventArgs) Handles btnNuevoBono.Click

    End Sub

#End Region
End Class