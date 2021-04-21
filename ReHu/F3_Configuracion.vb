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
        _prCargarComboLibreria(cbTipoDesc, 8, 1)

        _PCargarBuscadorLeyPersonal()
        _PCargarBuscadorLeyEmpresa()
        _PCargarBuscadorOtros()
        _PCargarBuscadorBono()
        _PCargarBuscadorVacacion()

        _PInhabilitar()
        _PInhabilitarBono()
        _PInhabilitarVacacion()

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
            btnNuevoBono.Visible = False
            btnNuevoVacacion.Visible = False
        End If
        If modif = False Then
            btnModificar.Visible = False
            btnModificarBono.Visible = False
            btnModificarVacacion.Visible = False
        End If
        If del = False Then
            btnEliminar.Visible = False
            btnEliminarBono.Visible = False
            btnEliminarVacacion.Visible = False
        End If

    End Sub
    Private Sub _prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String, cod2 As String)
        Dim dt As New DataTable
        dt = L_prLibreriaClienteLGeneral(cod1, cod2)
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 70
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 230
            .DropDownList.Columns("ycdes3").Caption = "DESCRIPCION"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub _PCargarBuscadorLeyPersonal()
        Dim dt As New DataTable
        dt = L_prDescuentoGeneralPer()

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
            .Visible = False
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_Buscador.RootTable.Columns("datipomonto")
            .Caption = "TipoMonto"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("damonto")
            .Caption = "Monto"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With

        With JGr_Buscador.RootTable.Columns("daobs")
            .Caption = "Observacion"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With JGr_Buscador.RootTable.Columns("dafinicio")
            .Caption = "Fecha Inicio"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With JGr_Buscador.RootTable.Columns("davenc")
            .Caption = "Estado Vencimiento"
            .Width = 160
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .EditType = EditType.CheckBox
            .ColumnType = ColumnType.CheckBox
            .CheckBoxFalseValue = 0
            .CheckBoxTrueValue = 1
            .Visible = False
        End With

        With JGr_Buscador.RootTable.Columns("dafvenc")
            .Caption = "Fecha Venc."
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
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
            .RecordNavigator = True
        End With
    End Sub
    Private Sub _PCargarBuscadorLeyEmpresa()
        Dim dt As New DataTable
        dt = L_prDescuentoGeneralEmp()

        JGr_BuscadorEmp.BoundMode = BoundMode.Bound
        JGr_BuscadorEmp.DataSource = dt
        JGr_BuscadorEmp.RetrieveStructure()

        'dar formato a las columnas
        With JGr_BuscadorEmp.RootTable.Columns("danumi")
            .Caption = "Codigo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_BuscadorEmp.RootTable.Columns("datipo")
            .Caption = "Tipo Desc."
            .Width = 90
            .Visible = False
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_BuscadorEmp.RootTable.Columns("datipomonto")
            .Caption = "TipoMonto"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_BuscadorEmp.RootTable.Columns("damonto")
            .Caption = "Monto"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With

        With JGr_BuscadorEmp.RootTable.Columns("daobs")
            .Caption = "Observacion"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With JGr_BuscadorEmp.RootTable.Columns("dafinicio")
            .Caption = "Fecha Inicio"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With JGr_BuscadorEmp.RootTable.Columns("davenc")
            .Caption = "Estado Vencimiento"
            .Width = 160
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .EditType = EditType.CheckBox
            .ColumnType = ColumnType.CheckBox
            .CheckBoxFalseValue = 0
            .CheckBoxTrueValue = 1
            .Visible = False
        End With

        With JGr_BuscadorEmp.RootTable.Columns("dafvenc")
            .Caption = "Fecha Venc."
            .Width = 100
            .Visible = False
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_BuscadorEmp.RootTable.Columns("daestado")
            .Visible = False
        End With

        With JGr_BuscadorEmp.RootTable.Columns("dafact")
            .Visible = False
        End With

        With JGr_BuscadorEmp.RootTable.Columns("dahact")
            .Visible = False
        End With

        With JGr_BuscadorEmp.RootTable.Columns("dauact")
            .Visible = False
        End With
        'Habilitar Filtradores
        With JGr_BuscadorEmp
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            JGr_BuscadorEmp.VisualStyle = VisualStyle.Office2007
            .RecordNavigator = True
        End With
    End Sub
    Private Sub _PCargarBuscadorOtros()
        Dim dt As New DataTable
        dt = L_prDescuentoGeneralOtros()

        JGr_BuscadorOtros.BoundMode = BoundMode.Bound
        JGr_BuscadorOtros.DataSource = dt
        JGr_BuscadorOtros.RetrieveStructure()

        'dar formato a las columnas
        With JGr_BuscadorOtros.RootTable.Columns("danumi")
            .Caption = "Codigo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_BuscadorOtros.RootTable.Columns("datipo")
            .Caption = "Tipo Desc."
            .Width = 90
            .Visible = False
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_BuscadorOtros.RootTable.Columns("datipomonto")
            .Caption = "TipoMonto"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_BuscadorOtros.RootTable.Columns("damonto")
            .Caption = "Monto"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With

        With JGr_BuscadorOtros.RootTable.Columns("daobs")
            .Caption = "Observacion"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With JGr_BuscadorOtros.RootTable.Columns("dafinicio")
            .Caption = "Fecha Inicio"
            .Width = 100
            .Visible = False
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_BuscadorOtros.RootTable.Columns("davenc")
            .Caption = "Estado Vencimiento"
            .Visible = False
            .Width = 160
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .EditType = EditType.CheckBox
            .ColumnType = ColumnType.CheckBox
            .CheckBoxFalseValue = 0
            .CheckBoxTrueValue = 1
        End With

        With JGr_BuscadorOtros.RootTable.Columns("dafvenc")
            .Caption = "Fecha Venc."
            .Width = 100
            .Visible = False
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_BuscadorOtros.RootTable.Columns("daestado")
            .Visible = False
        End With

        With JGr_BuscadorOtros.RootTable.Columns("dafact")
            .Visible = False
        End With

        With JGr_BuscadorOtros.RootTable.Columns("dahact")
            .Visible = False
        End With

        With JGr_BuscadorOtros.RootTable.Columns("dauact")
            .Visible = False
        End With
        'Habilitar Filtradores
        With JGr_BuscadorOtros
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            JGr_BuscadorOtros.VisualStyle = VisualStyle.Office2007
            .RecordNavigator = True
        End With
    End Sub
    Private Sub _PCargarBuscadorBono()
        Dim dt As New DataTable
        dt = L_prBonoGeneral()

        JGr_BonoAntiguedad.BoundMode = BoundMode.Bound
        JGr_BonoAntiguedad.DataSource = dt
        JGr_BonoAntiguedad.RetrieveStructure()

        'dar formato a las columnas
        With JGr_BonoAntiguedad.RootTable.Columns("banumi")
            .Caption = "Codigo"
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_BonoAntiguedad.RootTable.Columns("bafecha")
            .Caption = "Fecha"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_BonoAntiguedad.RootTable.Columns("basueldomin")
            .Caption = "Sueldo Mínimo"
            .Width = 130
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With

        With JGr_BonoAntiguedad.RootTable.Columns("bameses")
            .Caption = "Meses"
            .Width = 100
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
            .RecordNavigator = True
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
            .Width = 150
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
            .RecordNavigator = True
        End With
    End Sub
    Private Sub _PInhabilitar()
        tbNumi.ReadOnly = True
        cbTipoDesc.Enabled = False
        swTMonto.Enabled = False
        tbMonto.IsInputReadOnly = True
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
        dtBonoFecha.Enabled = False
        tbSueldoMin.IsInputReadOnly = True
        tbBonoMeses.IsInputReadOnly = True
        tbBonoImporte.IsInputReadOnly = True

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
        cbTipoDesc.Enabled = True
        swTMonto.Enabled = True
        tbMonto.IsInputReadOnly = False
        tbObservacion.ReadOnly = False
        dtFInicio.Enabled = True
        swVencimiento.Enabled = True
        dtFVencimiento.Enabled = True

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = True
    End Sub
    Private Sub _PHabilitarBono()
        dtBonoFecha.Enabled = True
        tbSueldoMin.IsInputReadOnly = False
        tbBonoMeses.IsInputReadOnly = False
        tbBonoImporte.IsInputReadOnly = False

        btnNuevoBono.Enabled = False
        btnModificarBono.Enabled = False
        btnEliminarBono.Enabled = False
        btnGrabarBono.Enabled = True
    End Sub
    Private Sub _PHabilitarVacacion()
        tbVacacionMeses.ReadOnly = False
        tbVacacionDias.ReadOnly = False
        dtVacacionFecha.Enabled = True
        swVacacionTipo.Enabled = True

        btnNuevoVacacion.Enabled = False
        btnModificarVacacion.Enabled = False
        btnEliminarVacacion.Enabled = False
        btnGrabarVacacion.Enabled = True

    End Sub
    Private Sub _PLimpiar()
        tbNumi.Text = ""
        cbTipoDesc.Text = ""
        swTMonto.Text = ""
        tbMonto.Text = ""
        tbObservacion.Text = ""
        dtFInicio.Value = Now.Date
        swVencimiento.Value = False
        dtFVencimiento.Value = Now.Date
    End Sub
    Private Sub _PLimpiarBono()
        tbNumiBono.Text = ""
        dtBonoFecha.Value = Now.Date
        tbSueldoMin.Value = 0
        tbBonoMeses.Text = ""
        tbBonoImporte.Value = 0
    End Sub
    Private Sub _PLimpiarVacacion()
        tbNumiVacacion.Text = ""
        tbVacacionMeses.Text = ""
        tbVacacionDias.Text = ""
        dtVacacionFecha.Value = Now.Date
        swVacacionTipo.Value = False

    End Sub
    Private Sub _PNuevoRegistro()
        _PHabilitar()
        _PLimpiar()
        RLAccion.Text = "NUEVO"
        tbMonto.Focus()
    End Sub
    Private Sub _PNuevoRegistroBono()
        _PHabilitarBono()
        _PLimpiarBono()
        RLAccionBono.Text = "NUEVO"
        tbBonoMeses.Focus()
    End Sub
    Private Sub _PNuevoRegistroVacacion()
        _PHabilitarVacacion()
        _PLimpiarVacacion()
        RLAccionVacacion.Text = "NUEVO"
        tbVacacionMeses.Focus()
    End Sub
    Private Sub _PModificarRegistro()
        _PHabilitar()
        RLAccion.Text = "MODIFICAR"
    End Sub
    Private Sub _PModificarRegistroBono()
        _PHabilitarBono()
        RLAccionBono.Text = "MODIFICAR"
    End Sub
    Private Sub _PModificarRegistroVacacion()
        _PHabilitarVacacion()
        RLAccionVacacion.Text = "MODIFICAR"
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
    Public Sub _PGuardarBono()
        Try
            If _ValidarCamposBono() = False Then
                Exit Sub
            End If

            If (tbNumiBono.Text = String.Empty) Then
                _GuardarNuevoBono()
            Else
                If (tbNumiBono.Text <> String.Empty) Then
                    _GuardarModificadoBono()
                End If
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _PGuardarVacacion()
        Try
            If _ValidarCamposVacacion() = False Then
                Exit Sub
            End If

            If (tbNumiVacacion.Text = String.Empty) Then
                _GuardarNuevoVacacion()
            Else
                If (tbNumiVacacion.Text <> String.Empty) Then
                    _GuardarModificadoVacacion()
                End If
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Function _ValidarCampos() As Boolean
        Try
            If (cbTipoDesc.SelectedIndex < 0) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor Seleccione un Tipo de Descuento".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                cbTipoDesc.Focus()
                Return False
            End If
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
    Public Function _ValidarCamposBono() As Boolean
        Try
            If (tbBonoMeses.Text = String.Empty) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor ingrese la cantidad de meses expresado en número.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                tbBonoMeses.Focus()
                Return False
            End If
            If (tbBonoImporte.Text = String.Empty) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor ingrese importe del bono.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                tbBonoImporte.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
            Return False
        End Try
    End Function
    Public Function _ValidarCamposVacacion() As Boolean
        Try
            If (tbVacacionMeses.Text = String.Empty) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor ingrese la cantidad de meses expresado en número.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                tbVacacionMeses.Focus()
                Return False
            End If
            If (tbVacacionDias.Text = String.Empty) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor ingrese la cantidad de dias.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                tbVacacionDias.Focus()
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
            Dim res As Boolean = L_prGrabarDescuento(tbNumi.Text, cbTipoDesc.Value, IIf(swTMonto.Value = True, "1", "0"),
                                                     tbMonto.Value, tbObservacion.Text, dtFInicio.Value.ToString("yyyy/MM/dd"),
                                                     IIf(swVencimiento.Value = True, "1", "0"),
                                                     dtFVencimiento.Value.ToString("yyyy/MM/dd"))
            If res Then

                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                ToastNotification.Show(Me, "Código de Descuento ".ToUpper + tbNumi.Text + " Grabado con éxito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )

                _PCargarBuscadorLeyPersonal()
                _PCargarBuscadorLeyEmpresa()
                _PCargarBuscadorOtros()
                _PLimpiar()

            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "El Descuento no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

            End If

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _GuardarNuevoBono()
        Try
            Dim res As Boolean = L_prGrabarBono(tbNumiBono.Text, dtBonoFecha.Value, tbSueldoMin.Value, tbBonoMeses.Value, tbBonoImporte.Value)
            If res Then

                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                ToastNotification.Show(Me, "Código de Parámetro de Bono ".ToUpper + tbNumi.Text + " Grabado con éxito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )

                _PCargarBuscadorBono()
                _PLimpiarBono()

            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "El Parámetro de Bono no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

            End If

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _GuardarNuevoVacacion()
        Try
            Dim res As Boolean = L_prGrabarVacacion(tbNumiVacacion.Text, tbVacacionMeses.Text, tbVacacionDias.Text,
                                                    dtVacacionFecha.Value, IIf(swVacacionTipo.Value = True, "1", "0"))
            If res Then

                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                ToastNotification.Show(Me, "Código de Parámetro de Vacación ".ToUpper + tbNumi.Text + " Grabado con éxito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )

                _PCargarBuscadorVacacion()
                _PLimpiarVacacion()

            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "El Parámetro de Vacación no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

            End If

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _GuardarModificado()
        Try

            Dim res As Boolean = L_prModificarDescuento(tbNumi.Text, cbTipoDesc.Value, IIf(swTMonto.Value = True, "1", "0"),
                                                        tbMonto.Value, tbObservacion.Text, dtFInicio.Value.ToString("yyyy/MM/dd"),
                                                        IIf(swVencimiento.Value = True, "1", "0"),
                                                        dtFVencimiento.Value.ToString("yyyy/MM/dd"))

            If res Then

                ToastNotification.Show(Me, "Código de Descuento ".ToUpper + tbNumi.Text + " modificado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                _PCargarBuscadorLeyPersonal()
                _PCargarBuscadorLeyEmpresa()
                _PCargarBuscadorOtros()
                _prSalir()
            End If


        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _GuardarModificadoBono()
        Try

            Dim res As Boolean = L_prModificarBono(tbNumiBono.Text, dtBonoFecha.Value, tbSueldoMin.Value, tbBonoMeses.Value, tbBonoImporte.Value)

            If res Then

                ToastNotification.Show(Me, "Código de Parámetro de Bono ".ToUpper + tbNumi.Text + " modificado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                _PCargarBuscadorBono()
                _prSalirBono()
            End If


        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _GuardarModificadoVacacion()
        Try

            Dim res As Boolean = L_prModificarVacacion(tbNumiVacacion.Text, tbVacacionMeses.Text, tbVacacionDias.Text,
                                                       dtVacacionFecha.Value, IIf(swVacacionTipo.Value = True, "1", "0"))

            If res Then

                ToastNotification.Show(Me, "Código de Parámetro de Vacación ".ToUpper + tbNumi.Text + " modificado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                _PCargarBuscadorVacacion()
                _prSalirVacacion()
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
                cbTipoDesc.Value = .GetValue("datipo")
                swTMonto.Value = .GetValue("datipomonto")
                tbMonto.Value = .GetValue("damonto")
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
    Public Sub _prMostrarRegistroLeyEmpresa(_N As Integer)
        Try

            With JGr_BuscadorEmp
                tbNumi.Text = .GetValue("danumi").ToString
                cbTipoDesc.Value = .GetValue("datipo")
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

            LblPaginacion.Text = Str(JGr_BuscadorEmp.Row + 1) + "/" + JGr_BuscadorEmp.RowCount.ToString

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _prMostrarRegistroOtros(_N As Integer)
        Try

            With JGr_BuscadorOtros
                tbNumi.Text = .GetValue("danumi").ToString
                cbTipoDesc.Value = .GetValue("datipo")
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

            LblPaginacion.Text = Str(JGr_BuscadorOtros.Row + 1) + "/" + JGr_BuscadorOtros.RowCount.ToString

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _prMostrarRegistroBono(_N As Integer)
        Try

            With JGr_BonoAntiguedad
                tbNumiBono.Text = .GetValue("banumi").ToString
                dtBonoFecha.Value = .GetValue("bafecha")
                tbSueldoMin.Value = .GetValue("basueldomin")
                tbBonoMeses.Value = .GetValue("bameses")
                tbBonoImporte.Value = .GetValue("bamonto")

                lbFecha.Text = CType(.GetValue("bafact"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("bahact").ToString
                lbUsuario.Text = .GetValue("bauact").ToString
            End With

            LblPaginacion.Text = Str(JGr_BonoAntiguedad.Row + 1) + "/" + JGr_BonoAntiguedad.RowCount.ToString

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _prMostrarRegistroVacacion(_N As Integer)
        Try

            With JGr_Vacacion
                tbNumiVacacion.Text = .GetValue("vanumi").ToString
                tbVacacionMeses.Text = .GetValue("vameses").ToString
                tbVacacionDias.Text = .GetValue("vadias").ToString
                dtVacacionFecha.Value = .GetValue("vafvig")
                swVacacionTipo.Value = .GetValue("vatipo")

                lbFecha.Text = CType(.GetValue("vafact"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("vahact").ToString
                lbUsuario.Text = .GetValue("vauact").ToString

            End With

            LblPaginacion.Text = Str(JGr_Vacacion.Row + 1) + "/" + JGr_Vacacion.RowCount.ToString

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
                _PCargarBuscadorLeyPersonal()
                _PCargarBuscadorLeyEmpresa()
                _PCargarBuscadorOtros()
                _PInhabilitar()
            Else
                ToastNotification.Show(Me, mensajeError, My.Resources.WARNING, 8000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub
    Public Sub _EliminarRegistroBono()
        Dim info As New TaskDialogInfo("eliminacion".ToUpper, eTaskDialogIcon.Delete, "¿esta seguro de eliminar el registro?".ToUpper, "".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
        Dim result As eTaskDialogResult = TaskDialog.Show(info)
        If result = eTaskDialogResult.Yes Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_prEliminarBono(tbNumiBono.Text, mensajeError)
            If res Then
                ToastNotification.Show(Me, "Codigo de Parámetro de Bono ".ToUpper + tbNumiBono.Text + " eliminado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                _PCargarBuscadorBono()
                _PInhabilitarBono()
            Else
                ToastNotification.Show(Me, mensajeError, My.Resources.WARNING, 8000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub
    Public Sub _EliminarRegistroVacacion()
        Dim info As New TaskDialogInfo("eliminacion".ToUpper, eTaskDialogIcon.Delete, "¿esta seguro de eliminar el registro?".ToUpper, "".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
        Dim result As eTaskDialogResult = TaskDialog.Show(info)
        If result = eTaskDialogResult.Yes Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_prEliminarVacacion(tbNumiVacacion.Text, mensajeError)
            If res Then
                ToastNotification.Show(Me, "Codigo de Parámetro de Vacación ".ToUpper + tbNumiVacacion.Text + " eliminado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                _PCargarBuscadorVacacion()
                _PInhabilitarVacacion()
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
            RLAccion.Text = ""
        Else
            Me.Close()
            _modulo.Select()
        End If
    End Sub
    Private Sub _prSalirBono()
        If btnGrabarBono.Enabled = True Then
            _PInhabilitarBono()

            If JGr_BonoAntiguedad.RowCount > 0 Then
                _prMostrarRegistroBono(0)
            End If
            RLAccionBono.Text = ""
        Else
            Me.Close()
            _modulo.Select()
        End If
    End Sub
    Private Sub _prSalirVacacion()
        If btnGrabarVacacion.Enabled = True Then
            _PInhabilitarVacacion()
            If JGr_Vacacion.RowCount > 0 Then
                _prMostrarRegistroVacacion(0)
            End If
            RLAccionVacacion.Text = " "
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
        _PNuevoRegistroBono()
    End Sub

    Private Sub btnModificarBono_Click(sender As Object, e As EventArgs) Handles btnModificarBono.Click
        _PModificarRegistroBono()
    End Sub
    Private Sub btnGrabarBono_Click(sender As Object, e As EventArgs) Handles btnGrabarBono.Click
        _PGuardarBono()
    End Sub

    Private Sub btnSalirBono_Click(sender As Object, e As EventArgs) Handles btnSalirBono.Click
        _prSalirBono()
    End Sub

    Private Sub btnEliminarBono_Click(sender As Object, e As EventArgs) Handles btnEliminarBono.Click
        _EliminarRegistroBono()
    End Sub

    Private Sub JGr_BonoAntiguedad_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_BonoAntiguedad.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGr_BonoAntiguedad_SelectionChanged(sender As Object, e As EventArgs) Handles JGr_BonoAntiguedad.SelectionChanged
        If (JGr_BonoAntiguedad.RowCount >= 0 And JGr_BonoAntiguedad.Row >= 0) Then
            _prMostrarRegistroBono(JGr_BonoAntiguedad.Row)
        End If
    End Sub

    Private Sub btnNuevoVacacion_Click(sender As Object, e As EventArgs) Handles btnNuevoVacacion.Click
        _PNuevoRegistroVacacion()
    End Sub

    Private Sub btnModificarVacacion_Click(sender As Object, e As EventArgs) Handles btnModificarVacacion.Click
        _PModificarRegistroVacacion()
    End Sub

    Private Sub btnGrabarVacacion_Click(sender As Object, e As EventArgs) Handles btnGrabarVacacion.Click
        _PGuardarVacacion()
    End Sub

    Private Sub btnSalirVacacion_Click(sender As Object, e As EventArgs) Handles btnSalirVacacion.Click
        _prSalirVacacion()
    End Sub

    Private Sub btnEliminarVacacion_Click(sender As Object, e As EventArgs) Handles btnEliminarVacacion.Click
        _EliminarRegistroVacacion()
    End Sub

    Private Sub JGr_Vacacion_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_Vacacion.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGr_Vacacion_SelectionChanged(sender As Object, e As EventArgs) Handles JGr_Vacacion.SelectionChanged
        If (JGr_Vacacion.RowCount >= 0 And JGr_Vacacion.Row >= 0) Then
            _prMostrarRegistroVacacion(JGr_Vacacion.Row)
        End If
    End Sub

    Private Sub JGr_BuscadorEmp_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_BuscadorEmp.EditingCell
        e.Cancel = True
    End Sub

    'Private Sub JGr_BuscadorEmp_SelectionChanged(sender As Object, e As EventArgs) Handles JGr_BuscadorEmp.SelectionChanged
    '    Dim pos As Integer = JGr_BuscadorEmp.CurrentRow.RowIndex
    '    If (JGr_BuscadorEmp.RowCount >= 0 And JGr_BuscadorEmp.Row >= 0) Then
    '        ' _prMostrarRegistroLeyEmpresa(CType(JGr_BuscadorEmp.DataSource, DataTable).Rows(pos).Item("danumi"))
    '        _prMostrarRegistroLeyEmpresa(JGr_BuscadorEmp.Row)
    '    End If
    'End Sub


    Private Sub JGr_BuscadorOtros_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_BuscadorOtros.EditingCell
        e.Cancel = True
    End Sub



    Private Sub JGr_BuscadorOtros_Click(sender As Object, e As EventArgs) Handles JGr_BuscadorOtros.Click
        If (JGr_BuscadorOtros.RowCount >= 0 And JGr_BuscadorOtros.Row >= 0) Then
            _prMostrarRegistroOtros(JGr_BuscadorOtros.CurrentRow.RowIndex)
        End If
    End Sub

    Private Sub JGr_BuscadorEmp_Click(sender As Object, e As EventArgs) Handles JGr_BuscadorEmp.Click
        If (JGr_BuscadorEmp.RowCount >= 0 And JGr_BuscadorEmp.Row >= 0) Then
            _prMostrarRegistroLeyEmpresa(JGr_BuscadorEmp.CurrentRow.RowIndex)
        End If
    End Sub

    Private Sub JGr_Buscador_Click(sender As Object, e As EventArgs) Handles JGr_Buscador.Click
        If (JGr_Buscador.RowCount >= 0 And JGr_Buscador.Row >= 0) Then
            _prMostrarRegistro(JGr_Buscador.CurrentRow.RowIndex)
        End If
    End Sub


#End Region
End Class