Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Controls
Public Class F3_Personal
#Region "VARIABLES"
    Dim _Inter As Integer = 0
    Private vlImagen As CImagen = Nothing
    Private vlRutaBase As String = gs_CarpetaRaiz
    Public TablaContrato As DataTable
    Public TablaFamilia As DataTable
    Public TablaGargo As DataTable


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
        _prCargarComboLibreria(cbEstado, 1, 1)
        _prCargarComboLibreria(cbTipoDoc, 1, 2)
        _prCargarComboLibreria(cbEstCivil, 1, 3)
        _prCargarComboLibreria(cbGenero, 1, 4)
        _prCargarComboLibreria(cbTipoContrato, 2, 1)
        _prCargarComboLibreria(cbGeneroFlia, 1, 4)
        _prCargarComboLibreria(cbTipoDocFlia, 1, 2)
        _prCargarComboLibreria(cbDependecia, 6, 1)
        _prCargarComboLibreria(cbCargo, 7, 1)

        _prCargarPersonal()
        _prInhabilitar()
        If grPersonal.RowCount > 0 Then
            superTabControl1.SelectedTabIndex = 1
            grPersonal.ContextMenuStrip = ConMenu_Opciones
        Else
            superTabControl1.SelectedTabIndex = 0
            btnNuevo.PerformClick()

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
            .Width = 120
            .Visible = True
            .Caption = "NRO. DOCUMENTO"
        End With
        With grPersonal.RootTable.Columns("pafnac")
            .Width = 90
            .Visible = True
            .Caption = "FECHA NAC."
        End With
        With grPersonal.RootTable.Columns("pafingreso")
            .Width = 90
            .Visible = True
            .Caption = "FECHA ING."
        End With
        With grPersonal.RootTable.Columns("panombre")
            .Width = 250
            .Visible = True
            .Caption = "NOMBRE"
        End With
        With grPersonal.RootTable.Columns("padirec")
            .Width = 140
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "DIRECCIÓN"
        End With

        With grPersonal.RootTable.Columns("patelf1")
            .Width = 90
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "TELÉFONO1"
        End With
        With grPersonal.RootTable.Columns("patelf2")
            .Width = 90
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "TELÉFONO2"
        End With
        With grPersonal.RootTable.Columns("paestcivil")
            .Width = 250
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("pagenero")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grPersonal.RootTable.Columns("paemail")
            .Width = 150
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "EMAIL"
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
        RLAccion.Text = "NUEVO"
    End Sub
    Private Sub _PModificarRegistro()
        _PHabilitar()
        RLAccion.Text = "MODIFICAR"
    End Sub
    Private Sub _PHabilitar()
        cbEstado.ReadOnly = False
        cbTipoDoc.ReadOnly = False
        tbNroDoc.ReadOnly = False
        dtFNac.Enabled = True
        dtFIng.Enabled = True
        tbNombre.ReadOnly = False
        tbDireccion.ReadOnly = False
        tbTelef1.ReadOnly = False
        tbTelef2.ReadOnly = False
        cbEstCivil.ReadOnly = False
        cbGenero.ReadOnly = False
        tbEmail.ReadOnly = False
        tbObs.ReadOnly = False

        _PHabilitarContrato()
        _PHabilitarFamilia()
        _PHabilitarCargo()

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = True

    End Sub
    Private Sub _PHabilitarContrato()

        dtFechaIni.Enabled = True
        dtFechaFin.Enabled = True
        tbRutaContrato.ReadOnly = False
        cbTipoContrato.ReadOnly = False
        swEstadoCont.Enabled = True

        btnNuevoCont.Enabled = True
        btnModificarCont.Enabled = True
        'btnAgregarCont.Enabled = True
    End Sub
    Private Sub _PHabilitarFamilia()
        tbNombresFlia.ReadOnly = False
        dtFNacFlia.Enabled = True
        cbGeneroFlia.ReadOnly = False
        cbTipoDocFlia.ReadOnly = False
        tbNroDocFlia.ReadOnly = False
        cbDependecia.ReadOnly = False
        swEstadoFlia.Enabled = True

        btnNuevoF.Enabled = True
        btnModificarF.Enabled = True
        'btnAgregarF.Enabled = True
    End Sub
    Private Sub _PHabilitarCargo()
        dtFechaCargo.Enabled = True
        cbCargo.ReadOnly = False
        swEstadoCargo.Enabled = True

        btnNuevoC.Enabled = True
        btnModificarC.Enabled = True
        'btnAgregarC.Enabled = True
    End Sub
    Private Sub _prInhabilitar()
        cbEstado.ReadOnly = True
        cbTipoDoc.ReadOnly = True
        tbNroDoc.ReadOnly = True
        dtFNac.Enabled = False
        dtFIng.Enabled = False
        tbNombre.ReadOnly = True
        tbDireccion.ReadOnly = True
        tbTelef1.ReadOnly = True
        tbTelef2.ReadOnly = True
        cbEstCivil.ReadOnly = True
        cbGenero.ReadOnly = True
        tbEmail.ReadOnly = True
        tbObs.ReadOnly = True

        _PInHabilitarContrato()
        _PInHabilitarFamilia()
        _PInHabilitarCargo()

        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGrabar.Enabled = False

    End Sub
    Private Sub _PInHabilitarContrato()

        dtFechaIni.Enabled = False
        dtFechaFin.Enabled = False
        tbRutaContrato.ReadOnly = True
        cbTipoContrato.ReadOnly = True
        swEstadoCont.Enabled = False

        btnNuevoCont.Enabled = False
        btnModificarCont.Enabled = False
        btnAgregarCont.Enabled = False
    End Sub
    Private Sub _PInHabilitarFamilia()
        tbNombresFlia.ReadOnly = True
        dtFNacFlia.Enabled = False
        cbGeneroFlia.ReadOnly = True
        cbTipoDocFlia.ReadOnly = True
        tbNroDocFlia.ReadOnly = True
        cbDependecia.ReadOnly = True
        swEstadoFlia.Enabled = False

        btnNuevoF.Enabled = False
        btnModificarF.Enabled = False
        btnAgregarF.Enabled = False
    End Sub
    Private Sub _PInHabilitarCargo()
        dtFechaCargo.Enabled = False
        cbCargo.ReadOnly = True
        swEstadoCargo.Enabled = False

        btnNuevoC.Enabled = False
        btnModificarC.Enabled = False
        btnAgregarC.Enabled = False
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
        'dtFechaIni.Value = Now.Date
        'dtFechaFin.Value = Now.Date
        'tbRutaContrato.Text = ""
        'cbTipoContrato.Text = ""
        'swEstadoCont.Value = True
        _prLimpiarContrato()
        btnNuevoCont.Enabled = False
        btnModificarCont.Enabled = False
        btnAgregarCont.Enabled = True

        'Info Familia
        'tbNombresFlia.Text = ""
        'dtFNacFlia.Value = Now.Date
        'cbGeneroFlia.Text = ""
        'cbTipoDocFlia.Text = ""
        'tbNroDocFlia.Text = ""
        'cbDependecia.Text = ""
        'swEstadoFlia.Value = True
        _prLimpiarFamilia()
        btnNuevoF.Enabled = False
        btnModificarF.Enabled = False
        btnAgregarF.Enabled = True

        'Info Cargo
        'dtFechaCargo.Value = Now.Date
        'cbCargo.Text = ""
        'swEstadoCargo.Value = True
        _prLimpiarCargo()
        btnNuevoC.Enabled = False
        btnModificarC.Enabled = False
        btnAgregarC.Enabled = True

        'VACIO LOS DETALLES 
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
        'CargarContrato
        Dim dt As New DataTable
        dt = L_prPersonalDetalleContrato(idCabecera)
        grContrato.DataSource = dt
        grContrato.RetrieveStructure()
        grContrato.AlternatingColors = True


        With grContrato.RootTable.Columns("pbnumi")
            .Caption = "Código"
            .Width = 50
            .Visible = False
        End With

        With grContrato.RootTable.Columns("pbpanumi")
            .Width = 60
            .Visible = False

        End With

        With grContrato.RootTable.Columns("pbfinicio")
            .Caption = "Fecha Inicio"
            .Width = 90
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With
        With grContrato.RootTable.Columns("pbffin")
            .Caption = "Fecha Fin"
            .Width = 90
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With
        With grContrato.RootTable.Columns("pbrutacont")
            .Caption = "Ruta Contrato"
            .Width = 150
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With grContrato.RootTable.Columns("pbtipocont")
            .Visible = False
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
        grContrato.ContextMenuStrip = cmEliminarSueldo
    End Sub
    Private Sub _prCargarGridDetalleFamilia(idCabecera As String)
        Dim dt As New DataTable
        dt = L_prPersonalDetalleFamilia(idCabecera)
        grFamilia.DataSource = dt
        grFamilia.RetrieveStructure()
        grFamilia.AlternatingColors = True


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
        grFamilia.ContextMenuStrip = cmEliminarSueldo
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
        grCargo.ContextMenuStrip = cmEliminarSueldo
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
        With grDetalleSueldos.Columns("peestado")
            .Visible = False
        End With
        With grDetalleSueldos.Columns("estado")
            .ReadOnly = True
            .Visible = False
        End With

        With grDetalleSueldos
            .AllowUserToAddRows = False
            .ContextMenuStrip = cmEliminarSueldo
        End With
    End Sub
    Public Sub _prGuardar()
        Try
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
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
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
            Dim nomImg As String
            If IsNothing(vlImagen) = True Then
                nomImg = ""
            Else
                nomImg = vlImagen.nombre
            End If

            Dim res As Boolean = L_prGrabarPersonal(tbNumi.Text, cbEstado.Value, cbTipoDoc.Value, tbNroDoc.Text, dtFNac.Value.ToString("yyyy/MM/dd"),
                                                    dtFIng.Value.ToString("yyyy/MM/dd"), tbNombre.Text, tbDireccion.Text, tbTelef1.Text,
                                                    tbTelef2.Text, cbEstCivil.Value, cbGenero.Value, tbEmail.Text, tbObs.Text, nomImg,
                                                    CType(grContrato.DataSource, DataTable), CType(grFamilia.DataSource, DataTable),
                                                    CType(grCargo.DataSource, DataTable), CType(grDetalleSueldos.DataSource, DataTable))
            If res Then
                If IsNothing(vlImagen) = False Then
                    vlImagen.nombre = nomImg
                    _prGuardarImagen()
                End If
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                ToastNotification.Show(Me, "Código de Personal ".ToUpper + tbNumi.Text + " Grabado con éxito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )

                _prCargarPersonal()

                '_Limpiar()

            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "El Personal no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

            End If

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
            Dim nomImg As String
            If IsNothing(vlImagen) = True Then
                nomImg = ""
            Else
                nomImg = vlImagen.nombre
            End If

            Dim res As Boolean = L_prModificarPersonal(tbNumi.Text, cbEstado.Value, cbTipoDoc.Value, tbNroDoc.Text, dtFNac.Value.ToString("yyyy/MM/dd"),
                                                    dtFIng.Value.ToString("yyyy/MM/dd"), tbNombre.Text, tbDireccion.Text, tbTelef1.Text,
                                                    tbTelef2.Text, cbEstCivil.Value, cbGenero.Value, tbEmail.Text, tbObs.Text, nomImg,
                                                    CType(grContrato.DataSource, DataTable), CType(grFamilia.DataSource, DataTable),
                                                    CType(grCargo.DataSource, DataTable), CType(grDetalleSueldos.DataSource, DataTable))

            If res Then
                If IsNothing(vlImagen) = False Then
                    If vlImagen.tipo = 0 Then
                        vlImagen.nombre = nomImg
                        _prGuardarImagen()
                    End If
                End If
                ToastNotification.Show(Me, "Código de Personal ".ToUpper + tbNumi.Text + " modificado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
            End If


        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _prLimpiarContrato()
        Try
            dtFechaIni.Value = Now.Date
            dtFechaFin.Value = Now.Date
            tbRutaContrato.Text = ""
            cbTipoContrato.Value = ""
            swEstadoCont.Value = True

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _prLimpiarFamilia()
        Try
            tbNombresFlia.Text = ""
            dtFNacFlia.Value = Now.Date
            cbGeneroFlia.Value = ""
            cbTipoDocFlia.Value = ""
            tbNroDocFlia.Text = ""
            cbDependecia.Value = ""
            swEstadoFlia.Value = True

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _prLimpiarCargo()
        Try

            dtFechaCargo.Value = Now.Date
            cbCargo.Value = ""
            swEstadoCargo.Value = True

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _prAgregarContrato()
        Try
            If cbTipoContrato.Value = Nothing Then
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "Debe elegir o agregar un Tipo de Contrato".ToUpper, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                Exit Sub
            End If
            TablaContrato = CType(grContrato.DataSource, DataTable)

            TablaContrato.Rows.Add(0, 0, dtFechaIni.Value.ToString("yyyy/MM/dd"), dtFechaFin.Value.ToString("yyyy/MM/dd"),
            tbRutaContrato.Text, cbTipoContrato.Value, swEstadoCont.Value, 0)

            grContrato.DataSource = TablaContrato

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _prAgregarFamilia()
        Try
            If cbGeneroFlia.Value = Nothing Then
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "Debe elegir o agregar Género".ToUpper, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                Exit Sub
            End If
            If cbTipoDocFlia.Value = Nothing Then
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "Debe elegir o agregar Tipo de Documento".ToUpper, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                Exit Sub
            End If
            If cbDependecia.Value = Nothing Then
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "Debe elegir o agregar Dependencia".ToUpper, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                Exit Sub
            End If
            TablaFamilia = CType(grFamilia.DataSource, DataTable)

            TablaFamilia.Rows.Add(0, 0, tbNombresFlia.Text, dtFNacFlia.Value.ToString("yyyy/MM/dd"),
            cbGeneroFlia.Value, cbTipoDocFlia.Value, tbNroDocFlia.Text, cbDependecia.Value, swEstadoCont.Value, 0)

            grFamilia.DataSource = TablaFamilia

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _prAgregarCargo()
        Try
            If cbCargo.Value = Nothing Then
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "Debe elegir o agregar Cargo".ToUpper, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                Exit Sub
            End If

            TablaGargo = CType(grCargo.DataSource, DataTable)

            TablaGargo.Rows.Add(0, 0, dtFechaCargo.Value.ToString("yyyy/MM/dd"), cbCargo.Value, swEstadoCont.Value, 0)

            grCargo.DataSource = TablaGargo

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _prMostrarRegistro(_N As Integer)
        Try

            With grPersonal
                tbNumi.Text = .GetValue("panumi").ToString
                cbEstado.Value = .GetValue("paestado")
                cbTipoDoc.Value = .GetValue("patipodoc")
                tbNroDoc.Text = .GetValue("panrodoc").ToString
                dtFNac.Value = .GetValue("pafnac")
                dtFIng.Value = .GetValue("pafingreso")
                tbNombre.Text = .GetValue("panombre").ToString
                tbDireccion.Text = .GetValue("padirec").ToString
                tbTelef1.Text = .GetValue("patelf1").ToString
                tbTelef2.Text = .GetValue("patelf2").ToString
                cbEstCivil.Value = .GetValue("paestcivil")
                cbGenero.Value = .GetValue("pagenero")
                tbEmail.Text = .GetValue("paemail").ToString
                tbObs.Text = .GetValue("paemail").ToString

                Dim nomImg = .GetValue("parutaimg").ToString
                If nomImg = String.Empty Then
                    pbImg.Image = Nothing
                Else
                    Dim rutaOrigen As String = vlRutaBase + "\Imagenes\Imagenes Personal\"
                    vlImagen = New CImagen(nomImg, rutaOrigen + nomImg, 1)
                    pbImg.SizeMode = PictureBoxSizeMode.StretchImage
                    Try
                        pbImg.Load(vlImagen.getImagen())
                    Catch ex As Exception
                        pbImg.Image = Nothing
                        vlImagen = Nothing
                    End Try
                End If

                _prCargarGridDetalleContrato(tbNumi.Text)
                _prCargarGridDetalleFamilia(tbNumi.Text)
                _prCargarGridDetalleCargo(tbNumi.Text)
                _prCargarGridDetalleSueldos(tbNumi.Text)

                lbFecha.Text = CType(.GetValue("pafact"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("pahact").ToString
                lbUsuario.Text = .GetValue("pauact").ToString


            End With

            LblPaginacion.Text = Str(grPersonal.Row + 1) + "/" + grPersonal.RowCount.ToString

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _prMostrarRegistroContrato(_N As Integer)
        Try
            With grContrato
                dtFechaIni.Value = .GetValue("pbfinicio")
                dtFechaFin.Value = .GetValue("pbffin")
                tbRutaContrato.Text = .GetValue("pbrutacont").ToString
                cbTipoContrato.Value = .GetValue("pbtipocont")
                swEstadoCont.Value = .GetValue("pbestado")
            End With

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _prMostrarRegistroFamilia(_N As Integer)
        Try
            With grFamilia
                tbNombresFlia.Text = .GetValue("pcnombres").ToString
                dtFNacFlia.Value = .GetValue("pcfnac")
                cbGeneroFlia.Value = .GetValue("pcgenero")
                cbTipoDocFlia.Value = .GetValue("pctipodoc")
                tbNroDocFlia.Text = .GetValue("pcnrodoc")
                cbDependecia.Value = .GetValue("pcdependencia")
                swEstadoFlia.Value = .GetValue("pcestado")
            End With

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub _prMostrarRegistroCargo(_N As Integer)
        Try
            With grCargo
                dtFechaCargo.Value = .GetValue("pdfecha")
                cbCargo.Value = .GetValue("pdcargo")
                swEstadoCargo.Text = .GetValue("pdestado")
            End With

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub _prCargarImagen()
        OfdFoto.InitialDirectory = "C:\Users\" + Environment.UserName + "\Pictures"
        OfdFoto.Filter = "Imagen|*.jpg;*.jpeg;*.png;*.bmp"
        OfdFoto.FilterIndex = 1
        If (OfdFoto.ShowDialog() = DialogResult.OK) Then
            vlImagen = New CImagen(OfdFoto.SafeFileName, OfdFoto.FileName, 0)
            pbImg.SizeMode = PictureBoxSizeMode.StretchImage
            pbImg.Load(vlImagen.getImagen())
        End If
    End Sub

    Private Sub _prSalir()
        If btnGrabar.Enabled = True Then
            _prInhabilitar()
            If grPersonal.RowCount > 0 Then
                _prMostrarRegistro(0)
            End If
        Else
            Me.Close()
            _modulo.Select()
        End If
    End Sub
#End Region
#Region "EVENTOS"
    Private Sub F3_Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _PNuevoRegistro()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        _prGuardar()
    End Sub

    Private Sub btnNuevoCont_Click(sender As Object, e As EventArgs) Handles btnNuevoCont.Click
        _prLimpiarContrato()
        btnNuevoCont.Enabled = False
        btnModificarCont.Enabled = False
        btnAgregarCont.Enabled = True
    End Sub

    Private Sub btnAgregarCont_Click(sender As Object, e As EventArgs) Handles btnAgregarCont.Click
        _prAgregarContrato()
    End Sub

    Private Sub btnNuevoF_Click(sender As Object, e As EventArgs) Handles btnNuevoF.Click
        _prLimpiarFamilia()
        btnNuevoF.Enabled = False
        btnModificarF.Enabled = False
        btnAgregarF.Enabled = True
    End Sub
    Private Sub btnAgregarF_Click(sender As Object, e As EventArgs) Handles btnAgregarF.Click
        _prAgregarFamilia()
    End Sub

    Private Sub btnAgregarC_Click(sender As Object, e As EventArgs) Handles btnAgregarC.Click
        _prAgregarCargo()
    End Sub

    Private Sub btnNuevoC_Click(sender As Object, e As EventArgs) Handles btnNuevoC.Click
        _prLimpiarCargo()
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

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click

        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            tbRutaContrato.Text = openFileDialog1.FileName()

        End If
    End Sub

    Private Sub NuevoItem_Click(sender As Object, e As EventArgs) Handles NuevoItem.Click
        btnNuevo.PerformClick()
        superTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _prSalir()
    End Sub

    Private Sub ImgOpc_ItemClick(sender As Object, e As EventArgs) Handles ImgOpc.ItemClick
        Dim item As RadialMenuItem = TryCast(sender, RadialMenuItem)
        If item IsNot Nothing AndAlso (Not String.IsNullOrEmpty(item.Text)) Then
            Select Case item.Name
                Case "btnAgregar"
                    _prCargarImagen()
                Case "btnElimImg"
                    _prEliminarImagen()
            End Select
        End If
    End Sub

    Private Sub grPersonal_SelectionChanged(sender As Object, e As EventArgs) Handles grPersonal.SelectionChanged
        If (grPersonal.RowCount >= 0 And grPersonal.Row >= 0) Then
            _prMostrarRegistro(grPersonal.Row)
        End If
    End Sub

    Private Sub grPersonal_KeyDown(sender As Object, e As KeyEventArgs) Handles grPersonal.KeyDown
        If e.KeyData = Keys.Enter Then
            superTabControl1.SelectedTabIndex = 0
        End If
    End Sub

    Private Sub grContrato_SelectionChanged(sender As Object, e As EventArgs) Handles grContrato.SelectionChanged
        If grContrato.Row >= 0 Then
            _prMostrarRegistroContrato(grContrato.Row)
        End If
    End Sub

    Private Sub grFamilia_SelectionChanged(sender As Object, e As EventArgs) Handles grFamilia.SelectionChanged
        If grFamilia.Row >= 0 Then
            _prMostrarRegistroFamilia(grFamilia.Row)
        End If
    End Sub

    Private Sub grCargo_SelectionChanged(sender As Object, e As EventArgs) Handles grCargo.SelectionChanged
        If grCargo.Row >= 0 Then
            _prMostrarRegistroCargo(grCargo.Row)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        _PModificarRegistro()
    End Sub

    Private Sub ModificarItem_Click(sender As Object, e As EventArgs) Handles ModificarItem.Click
        btnModificar.PerformClick()
        superTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub grDetalleSueldos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grDetalleSueldos.CellEndEdit
        Dim estado As Integer
        estado = grDetalleSueldos.Rows(e.RowIndex).Cells("estado").Value
        If estado = 1 Then
            grDetalleSueldos.Rows(e.RowIndex).Cells("estado").Value = 2
        End If
    End Sub

    Private Sub ELIMINARFILAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARFILAToolStripMenuItem.Click
        Dim pos As Integer = grDetalleSueldos.CurrentRow.Index
        If pos >= 0 And pos <= grDetalleSueldos.RowCount - 2 Then
            Dim estado As Integer
            estado = grDetalleSueldos.Rows(pos).Cells("estado").Value
            If estado = 1 Or estado = 2 Then ' si estoy eliminando una fila ya guardada le cambio el estado y lo oculto de la grilla
                grDetalleSueldos.Rows(pos).Cells("estado").Value = -1
                grDetalleSueldos.CurrentCell = Nothing
                grDetalleSueldos.Rows(pos).Visible = False
            Else 'si estoy eliminando una fila nueva, simplemente la elimino del grid
                grDetalleSueldos.Rows.RemoveAt(pos)
            End If
        End If
    End Sub

    Private Sub grPersonal_DoubleClick(sender As Object, e As EventArgs) Handles grPersonal.DoubleClick
        If (grPersonal.RowCount >= 0 And grPersonal.Row >= 0) Then
            _prMostrarRegistro(grPersonal.Row)
            superTabControl1.SelectedTabIndex = 0
        End If
    End Sub

#End Region
End Class