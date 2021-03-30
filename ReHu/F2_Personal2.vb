Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Controls

Public Class F2_Personal2
#Region "VARIABLES"
    Dim _Inter As Integer = 0
    Private vlImagen As CImagen = Nothing
    Private vlRutaBase As String = gs_CarpetaRaiz

    Dim _Dsencabezado As DataSet
    Dim _Nuevo As Boolean
    Private _Pos As Integer
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public _nameButton As String
    Dim NumiVendedor As Integer = 0

#End Region
#Region "CLASE AUXILIAR"
    Public Class CImagen
        Public nombre As String
        Public direccion As String
        Public tipo As Integer

        Public Sub New(nom As String, dir As String, ti As Integer)
            nombre = nom
            direccion = dir
            tipo = ti
        End Sub

        Public Function getImagen()
            Return direccion
        End Function
    End Class
#End Region

#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        Me.Text = "P E R S O N A L"

        '_prCargarComboLibreria(tbTipo, gi_LibPERSONAL, gi_LibPERSTipo)
        '_prCargarComboLibreria(tbEstCivil, gi_LibPERSONAL, gi_LibPERSEstCivil)
        '_prCargarComboSucursal()

        _prAsignarPermisos()

        _prCargarPersonal()
        If grPersonal.RowCount > 0 Then
            SuperTabPrincipal.SelectedTabIndex = 1
            grPersonal.ContextMenuStrip = ConMenu_Opciones
        Else
            SuperTabPrincipal.SelectedTabIndex = 0

        End If
    End Sub

    Private Sub _prAsignarPermisos()

        Dim dtRolUsu As DataTable = L_prRolDetalleGeneral(gi_userRol, _nameButton)

        Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        If add = False Then
            btnNuevo.Visible = False
            NuevoItem.Visible = False
        End If
        If modif = False Then
            btnModificar.Visible = False
            ModificarItem.Visible = False
        End If
        If del = False Then
            btnEliminar.Visible = False
            EliminarItem.Visible = False
        End If

    End Sub
    Private Sub _prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String, cod2 As String)
        Dim dt As New DataTable
        dt = L_prLibreriaClienteLGeneral(cod1, cod2)
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 70
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 200
            .DropDownList.Columns("ycdes3").Caption = "DESCRIPCION"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub _prCargarPersonal()
        Dim dt As New DataTable
        dt = L_prPersonalGeneral()
        grPersonal.DataSource = dt
        grPersonal.RetrieveStructure()
        grPersonal.AlternatingColors = True

        With grPersonal.RootTable.Columns("panumi")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = True

        End With

        With grPersonal.RootTable.Columns("paestado")
            .Width = 90
            .Visible = False
        End With

        With grPersonal.RootTable.Columns("patipodoc")
            .Width = 90
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("panrodoc")
            .Width = 160
            .Visible = True
        End With
        With grPersonal.RootTable.Columns("pafnac")
            .Width = 90
            .Visible = True
            .Caption = "FECHA"
        End With
        With grPersonal.RootTable.Columns("pafingreso")
            .Width = 90
            .Visible = True
            .Caption = "FECHA ING."
        End With
        With grPersonal.RootTable.Columns("panombre")
            .Width = 250
            .Visible = True
            .Caption = "Nombres".ToUpper
        End With
        With grPersonal.RootTable.Columns("padirec")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With

        With grPersonal.RootTable.Columns("patelf1")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("patelf2")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("paestcivil")
            .Width = 250
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True

        End With

        With grPersonal.RootTable.Columns("pagenero")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("pamail")
            .Width = 150
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "MONEDA"
        End With
        With grPersonal.RootTable.Columns("paobs")
            .Width = 200
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "OBSERVACION"
        End With
        With grPersonal.RootTable.Columns("parutaimg")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("paaux1")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("paaux2")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("paaux3")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("pafact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("pahact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("pauact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With


        With grPersonal
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla

        End With
    End Sub

    Private Sub _PNuevoRegistro()
        _PHabilitar()

        _PLimpiar()

    End Sub
    Private Sub _PHabilitar()
        cbEstado.ReadOnly = False
        cbTipoDoc.ReadOnly = False

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = True

    End Sub
    Private Sub _PLimpiar()
        'Datos Generales
        tbNumi.Text = ""
        cbEstado.Text = ""
        cbTipoDoc.Text = ""
        tbNroDoc.Text = ""
        dtFNac.Value = Now.Date
        dtFIng.Value = Now.Date
        tbNombre.Text = ""
        tbDireccion.Text = ""
        tbTelef1.Text = ""
        tbTelef2.Text = ""
        cbEstCivil.Text = ""
        cbGenero.Text = ""
        tbEmail.Text = ""
        tbObs.Text = ""
        _prEliminarImagen()

        'Info Contrato
        dtFechaIni.Value = Now.Date
        dtFechaFin.Value = Now.Date
        tbRutaContrato.Text = ""
        cbTipoContrato.Text = ""
        swEstadoCont.Value = True

        'Info Familia
        tbNombresFlia.Text = ""
        dtFNacFlia.Value = Now.Date
        cbGeneroFlia.Text = ""
        cbTipoDocFlia.Text = ""
        tbNroDocFlia.Text = ""
        cbDependecia.Text = ""
        swEstadoFlia.Value = True

        'Info Cargo
        dtFechaCargo.Value = Now.Date
        cbCargo.Text = ""
        swEstadoCargo.Value = True

        'VACIO EL DETALLE SUELDOS
        _prCargarGridDetalleContrato(-1)
        grContrato.AllowAddNew = True

        _prCargarGridDetalleFamilia(-1)
        grFamilia.AllowAddNew = True

        _prCargarGridDetalleCargo(-1)
        grCargo.AllowAddNew = True

        _prCargarGridDetalleSueldos(-1)
        grDetalleSueldos.AllowUserToAddRows = True


    End Sub
    Private Sub _prEliminarImagen()
        vlImagen = Nothing
        pbImg.Image = Nothing
    End Sub
    Private Sub _prCargarGridDetalleContrato(idCabecera As String)
        Dim dt As New DataTable
        dt = L_prPersonalDetalleContrato(idCabecera)
        grContrato.DataSource = dt
        grContrato.RetrieveStructure()
        grContrato.AlternatingColors = True

        'dar formato a las columnas
        With grContrato.RootTable.Columns("pbnumi")
            .Caption = "Código"
            .Width = 50
            .Visible = True
        End With

        With grContrato.RootTable.Columns("pbpanumi")
            .Width = 60
            .Visible = False

        End With

        With grContrato.RootTable.Columns("pbfinicio")
            .Caption = "Fecha"
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With grContrato.RootTable.Columns("pbrutacont")
            .Caption = "Ruta Contrato"
            .Width = 90
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With grContrato.RootTable.Columns("pbestado")
            .Visible = False
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With grContrato.RootTable.Columns("estado")
            .Visible = False
        End With
        With grContrato
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
        End With

        grContrato.AllowAddNew = False
        grContrato.ContextMenuStrip = cmOpciones
    End Sub
    Private Sub _prCargarGridDetalleFamilia(idCabecera As String)
        Dim dt As New DataTable
        dt = L_prPersonalDetalleFamilia(idCabecera)
        grFamilia.DataSource = dt
        grFamilia.RetrieveStructure()
        grFamilia.AlternatingColors = True

        'dar formato a las columnas
        With grFamilia.RootTable.Columns("pcnumi")
            .Caption = "Código"
            .Width = 50
            .Visible = True
        End With

        With grFamilia.RootTable.Columns("pcpanumi")
            .Width = 60
            .Visible = False

        End With

        With grFamilia.RootTable.Columns("pcnombres")
            .Caption = "Nombres"
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With grFamilia.RootTable.Columns("pcfnac")
            .Caption = "Fecha Nac."
            .Width = 90
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With grFamilia.RootTable.Columns("pcgenero")
            .Visible = False
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With
        With grFamilia.RootTable.Columns("pcgenero")
            .Visible = False
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With
        With grFamilia.RootTable.Columns("pctipodoc")
            .Visible = False
        End With
        With grFamilia.RootTable.Columns("pcnrodoc")
            .Caption = "Nro. Doc."
            .Visible = True
        End With
        With grFamilia.RootTable.Columns("pcdependencia")
            .Visible = False
        End With
        With grFamilia.RootTable.Columns("pcestado")
            .Visible = False
        End With
        With grFamilia.RootTable.Columns("estado")
            .Visible = False
        End With
        With grFamilia
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
        End With

        grFamilia.AllowAddNew = False
        grFamilia.ContextMenuStrip = cmOpciones
    End Sub
    Private Sub _prCargarGridDetalleCargo(idCabecera As String)
        Dim dt As New DataTable
        dt = L_prPersonalDetalleCargo(idCabecera)
        grCargo.DataSource = dt
        grCargo.RetrieveStructure()
        grCargo.AlternatingColors = True

        'dar formato a las columnas
        With grCargo.RootTable.Columns("pdnumi")
            .Caption = "Código"
            .Width = 50
            .Visible = True
        End With

        With grCargo.RootTable.Columns("pdpanumi")
            .Width = 60
            .Visible = False

        End With

        With grCargo.RootTable.Columns("pdfecha")
            .Caption = "Fecha"
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With grCargo.RootTable.Columns("pdcargo")
            .Caption = "Cargo"
            .Width = 90
            .Visible = False
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With grCargo.RootTable.Columns("pdestado")
            .Visible = False
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With grCargo.RootTable.Columns("estado")
            .Visible = False
        End With
        With grCargo
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
        End With

        grCargo.AllowAddNew = False
        grCargo.ContextMenuStrip = cmOpciones
    End Sub


    Private Sub _prCargarGridDetalleSueldos(idCabecera As String)
        Dim dt As New DataTable
        dt = L_prPersonalDetalleSueldos(idCabecera)

        grDetalleSueldos.DataSource = dt

        'dar formato a las columnas
        With grDetalleSueldos.Columns("penumi")
            .Width = 50
            .Visible = False
        End With

        With grDetalleSueldos.Columns("pepanumi")
            .Width = 60
            .Visible = False
        End With

        With grDetalleSueldos.Columns("peano")
            .HeaderText = "AÑO"
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        With grDetalleSueldos.Columns("pemes")
            .HeaderText = "MES"
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        With grDetalleSueldos.Columns("pesueldo")
            .HeaderText = "SUELDO"
            .Width = 100
            .DefaultCellStyle.Format = "0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        With grDetalleSueldos.Columns("estado")
            .ReadOnly = True
            .Visible = False
        End With

        With grDetalleSueldos
            .AllowUserToAddRows = False
            .ContextMenuStrip = cmOpciones
        End With
    End Sub
    Public Sub _prGuardar()
        If _ValidarCampos() = False Then
            Exit Sub
        End If

        If (tbNumi.Text = String.Empty) Then
            _GuardarNuevo()
        Else
            If (tbNumi.Text <> String.Empty) Then
                _prGuardarModificado()
            End If
        End If
    End Sub
    Public Function _ValidarCampos() As Boolean
        Try
            If (cbTipoDoc.SelectedIndex < 0) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor Seleccione o Agregue un Tipo de Documento".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                cbTipoDoc.Focus()
                Return False
            End If
            If (tbNroDoc.Text = String.Empty) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor ingrese el Nro de Documento del personal.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                tbNombre.Focus()
                Return False
            End If
            If (tbNombre.Text = String.Empty) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor ponga nombre y apellido del personal.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                tbNombre.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
            Return False
        End Try
    End Function
    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               5000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)

    End Sub
    Public Sub _GuardarNuevo()
        Try
            'Dim nomImg As String
            'If IsNothing(vlImagen) = True Then
            '    nomImg = ""
            'Else
            '    nomImg = vlImagen.nombre
            'End If

            'Dim res As Boolean = L_prGrabarPersonal(tbNumi.Text, cbEstado.Value, cbTipoDoc.Value, tbNroDoc.Text, dtFNac.Value.ToString("yyyy/MM/dd"),
            '                                        dtFIng.Value.ToString("yyyy/MM/dd"), tbNombre.Text, tbNombre.Text, tbDireccion.Text, tbTelef1.Text,
            '                                        tbTelef2.Text, cbEstCivil, cbGenero.Value, tbEmail.Text, tbObs.Text, nomImg, CType(grDetalle.DataSource, DataTable))
            'If res Then
            '    If IsNothing(vlImagen) = False Then
            '        vlImagen.nombre = nomImg
            '        _prGuardarImagen()
            '    End If
            '    Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            '    ToastNotification.Show(Me, "Código de Personal ".ToUpper + tbNumi.Text + " Grabado con éxito.".ToUpper,
            '                              img, 2000,
            '                              eToastGlowColor.Green,
            '                              eToastPosition.TopCenter
            '                              )

            '    _prCargarPersonal()

            '    '_Limpiar()

            'Else
            '    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            '    ToastNotification.Show(Me, "El Personal no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

            'End If

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _prGuardarImagen()
        Dim rutaDestino As String = vlRutaBase + "\Imagenes\Imagenes Personal\"
        If System.IO.Directory.Exists(rutaDestino) = False Then
            If System.IO.Directory.Exists(vlRutaBase + "\Imagenes\") = False Then
                System.IO.Directory.CreateDirectory(vlRutaBase + "\Imagenes")
                If System.IO.Directory.Exists(vlRutaBase + "\Imagenes\Imagenes Personal\") = False Then
                    System.IO.Directory.CreateDirectory(vlRutaBase + "\Imagenes\Imagenes Personal")
                End If
            Else
                If System.IO.Directory.Exists(vlRutaBase + "\Imagenes\Imagenes Personal") = False Then
                    System.IO.Directory.CreateDirectory(vlRutaBase + "\Imagenes\Imagenes Personal")
                End If
            End If
        End If

        Dim rutaOrigen As String
        rutaOrigen = vlImagen.getImagen()
        FileCopy(rutaOrigen, rutaDestino + vlImagen.nombre + ".jpg")

    End Sub
    Private Sub _prGuardarModificado()
        Try

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _prLimpiarContrato()
        Try
            dtFechaIni.Value = Now.Date
            dtFechaFin.Value = Now.Date
            tbRutaContrato.Text = ""

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

#End Region

#Region "EVENTOS"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Inter = _Inter + 1
        If _Inter = 1 Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub F2_Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _PNuevoRegistro()
        btnNuevoCont.PerformClick()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        _prGuardar()
    End Sub

    Private Sub btnNuevoCont_Click(sender As Object, e As EventArgs) Handles btnNuevoCont.Click
        _prLimpiarContrato()
    End Sub
#End Region

End Class