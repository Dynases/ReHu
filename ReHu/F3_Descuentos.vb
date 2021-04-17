Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Controls

Public Class F3_Descuentos
#Region "Variables Lcales"
    Dim _Inter As Integer = 0
    Public _modulo As SideNavItem
    Public _nameButton As String
    Dim _Dsencabezado As DataTable
    Dim _Pos As Integer
    Dim _Nuevo As Boolean

#End Region

#Region "Metodos Privados"

    Private Sub _PCargarBuscador()
        Dim dt As New DataTable
        dt = L_prDescuentoGeneralPersonal()

        JGr_Buscador.BoundMode = BoundMode.Bound
        JGr_Buscador.DataSource = dt
        JGr_Buscador.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Buscador.RootTable.Columns("dbnumi")
            .Caption = "Codigo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_Buscador.RootTable.Columns("dbcper")
            .Caption = "Cod. Persona"
            .Width = 90
            .Visible = False
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("panombre")
            .Caption = "Nombres"
            .Width = 250
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With JGr_Buscador.RootTable.Columns("dbtipo")
            .Caption = "Tipo Desc."
            .Width = 90
            .Visible = False
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("dbvalor")
            .Caption = "Descuento"
            .Width = 130
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With

        With JGr_Buscador.RootTable.Columns("dbobs")
            .Caption = "Observación"
            .Width = 300
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With JGr_Buscador.RootTable.Columns("dbfinicio")
            .Caption = "Fecha Inicio"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_Buscador.RootTable.Columns("dbvenc")
            .Caption = "Estado Venc."
            .Visible = False
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .EditType = EditType.CheckBox
            .ColumnType = ColumnType.CheckBox
            .CheckBoxFalseValue = 0
            .CheckBoxTrueValue = 1
        End With

        With JGr_Buscador.RootTable.Columns("dbfvenc")
            .Caption = "Fecha Venc"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With JGr_Buscador.RootTable.Columns("dbestado")
            .Visible = False
        End With
        With JGr_Buscador.RootTable.Columns("dbfact")
            .Caption = "Fecha Registro"
            .Width = 100
        End With
        With JGr_Buscador.RootTable.Columns("dbhact")
            .Caption = "Hora Registro"
            .Width = 100
        End With
        With JGr_Buscador.RootTable.Columns("dbuact")
            .Caption = "Usuario"
            .Width = 100
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

    Private Sub _PHabilitar()

        JMc_Persona.ReadOnly = False
        Tb_TipoMov.Enabled = True
        Tb_Valor.IsInputReadOnly = False
        Tb_Observacion.ReadOnly = False
        dtFInicio.Enabled = True
        tbVencimiento.Enabled = True

        If tbVencimiento.Value = True Then
            dtFechaVenc.Enabled = True
        End If

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = True

    End Sub
    Private Sub _PInhabilitar()

        Tb_Id.ReadOnly = True
        JMc_Persona.ReadOnly = True
        Tb_TipoMov.Enabled = False
        Tb_Valor.IsInputReadOnly = True
        Tb_Observacion.ReadOnly = True
        dtFInicio.Enabled = False
        dtFechaVenc.Enabled = False
        tbVencimiento.Enabled = False

        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGrabar.Enabled = False

    End Sub

    Private Sub _PLimpiar()
        Tb_Id.Text = ""
        JMc_Persona.Text = ""
        Tb_TipoMov.Value = True
        Tb_Valor.Text = ""
        Tb_Observacion.Text = ""
        dtFInicio.Value = Today.Date
        dtFechaVenc.Value = Today.Date
        tbVencimiento.Value = False
    End Sub
    Private Sub _PHabilitarFocus()

        MHighlighterFocus.SetHighlightOnFocus(Tb_TipoMov, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        MHighlighterFocus.SetHighlightOnFocus(Tb_Valor, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        MHighlighterFocus.SetHighlightOnFocus(JMc_Persona, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        MHighlighterFocus.SetHighlightOnFocus(Tb_Observacion, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        MHighlighterFocus.SetHighlightOnFocus(tbVencimiento, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        MHighlighterFocus.SetHighlightOnFocus(dtFechaVenc, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)

        JMc_Persona.TabIndex = 1
        Tb_TipoMov.TabIndex = 2
        Tb_Valor.TabIndex = 3
        Tb_Observacion.TabIndex = 4
        dtFInicio.TabIndex = 5
        GroupPanel1.TabIndex = 5
        tbVencimiento.TabIndex = 1
        dtFechaVenc.TabIndex = 2
    End Sub

    Private Sub _PIniciarTodo()
        Me.Text = "D E S C U E N T O S   P E R S O N A L"

        _prAsignarPermisos()

        _PCargarBuscador()
        _PCargarComboEmpleados()
        _PFiltrar()
        _PInhabilitar()
        _PHabilitarFocus()

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

    Private Sub _PFiltrar()
        _Dsencabezado = New DataTable
        _Dsencabezado = L_prDescuentoGeneralPersonal()
        '_First = False
        If _Dsencabezado.Rows.Count <> 0 Then
            _Pos = 0
            _PMostrarRegistro(_Pos)
            If _Dsencabezado.Rows.Count > 0 Then
                btnPrimero.Visible = True
                btnAnterior.Visible = True
                btnSiguiente.Visible = True
                btnUltimo.Visible = True
            End If
        End If

    End Sub
    Private Sub _PMostrarRegistro(_N As Integer)

        JGr_Buscador.Row = _Pos
        With JGr_Buscador

            Tb_Id.Text = .GetValue("dbnumi").ToString
            JMc_Persona.Value = .GetValue("dbcper")
            Tb_TipoMov.Value = .GetValue("dbtipo")
            Tb_Valor.Value = .GetValue("dbvalor")
            Tb_Observacion.Text = .GetValue("dbobs").ToString
            dtFInicio.Value = .GetValue("dbfinicio")
            tbVencimiento.Value = IIf(.GetValue("dbvenc") = 1, True, False)
            dtFechaVenc.Value = .GetValue("dbfvenc")

        End With
        LblPaginacion.Text = Str(_Pos + 1) + "/" + JGr_Buscador.RowCount.ToString
    End Sub
    Private Function _PValidar() As Boolean
        Dim _Error As Boolean = False
        Try
            If Tb_Valor.Text = "" Then
                Tb_Valor.BackColor = Color.Red
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor ingrese el Monto de Descuento.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                Tb_Valor.Focus()
                _Error = True
            Else
                Tb_Valor.BackColor = Color.White

            End If

            If JMc_Persona.SelectedIndex < 0 Then
                JMc_Persona.BackColor = Color.Red
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor seleccione un Personal.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                JMc_Persona.Focus()
                _Error = True
            Else
                JMc_Persona.BackColor = Color.White
            End If

            Return _Error
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
            Return _Error
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
    Private Sub _PGrabarRegistro()
        Dim _Error As Boolean = False
        If _PValidar() Then
            Exit Sub
        End If
        If btnGrabar.Enabled = False Then
            Exit Sub
        End If

        If False Then 'bbtGrabar.Tag = 0 
            'bbtGrabar.Tag = 1
            'bbtGrabar.Image = My.Resources.CONFIRMACION
            'bbtGrabar.ImageLarge = My.Resources.CONFIRMACION
            'BubbleBar6.Refresh()
            'Exit Sub
        Else
            btnGrabar.Tag = 0
        End If


        If _Nuevo Then
            Dim tipo As String
            If Tb_TipoMov.Value Then
                tipo = "1"
            Else
                tipo = "0"
            End If

            Dim res As Boolean = L_prGrabarDescuentoPer(Tb_Id.Text, JMc_Persona.Value, tipo, Tb_Valor.Value, Tb_Observacion.Text,
                                                        dtFechaVenc.Value.ToString("yyyy/MM/dd"), IIf(tbVencimiento.Value = True, "1", "0"),
                                                        dtFechaVenc.Value.ToString("yyyy/MM/dd"))
            If res Then
                _PCargarBuscador()
                JMc_Persona.Focus()
                ToastNotification.Show(Me, "Código de Descuento ".ToUpper + Tb_Id.Text + " Grabado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)
                _PLimpiar()
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "El Descuento no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            End If

        Else
            Dim tipo As String
            If Tb_TipoMov.Value Then
                tipo = "1"
            Else
                tipo = "0"
            End If
            Dim res As Boolean = L_prModificarDescuentoPer(Tb_Id.Text, JMc_Persona.Value, tipo, Tb_Valor.Value, Tb_Observacion.Text,
                                                        dtFechaVenc.Value.ToString("yyyy/MM/dd"), IIf(tbVencimiento.Value = True, "1", "0"),
                                                        dtFechaVenc.Value.ToString("yyyy/MM/dd"))
            If res Then
                ToastNotification.Show(Me, "Código de descuento ".ToUpper + Tb_Id.Text + " Modificado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)
                _Nuevo = False 'aumentado danny

                _PInhabilitar()
                _PCargarBuscador()
                _PFiltrar()

            End If
        End If
    End Sub

    Private Sub _PNuevoRegistro()
        _PHabilitar()
        _PLimpiar()
        Tb_Valor.Focus()
        _Nuevo = True
        RLAccion.Text = "NUEVO"
    End Sub

    Private Sub _PModificarRegistro()
        _Nuevo = False
        _PHabilitar()
        RLAccion.Text = "MODIFICAR"
    End Sub

    Private Sub _PEliminarRegistro()
        Dim info As New TaskDialogInfo("eliminacion".ToUpper, eTaskDialogIcon.Delete, "¿esta seguro de eliminar el registro?".ToUpper, "".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
        Dim result As eTaskDialogResult = TaskDialog.Show(info)
        If result = eTaskDialogResult.Yes Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_prEliminarDescuentoPer(Tb_Id.Text, mensajeError)
            If res Then
                ToastNotification.Show(Me, "Código de Descuento ".ToUpper + Tb_Id.Text + " eliminado con éxito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                _PCargarBuscador()

                _PInhabilitar()
            Else
                ToastNotification.Show(Me, mensajeError, My.Resources.WARNING, 8000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub

    Private Sub _PSalirRegistro()
        If btnGrabar.Enabled = True Then
            _PInhabilitar()
            _PFiltrar()
            RLAccion.Text = ""
        Else
            Me.Close()
        End If
    End Sub

    Private Sub _PPrimerRegistro()
        If JGr_Buscador.RowCount > 0 Then
            _Pos = 0
            _PMostrarRegistro(_Pos)
        End If
    End Sub
    Private Sub _PAnteriorRegistro()
        If _Pos > 0 Then
            _Pos = _Pos - 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub
    Private Sub _PSiguienteRegistro()
        If _Pos < JGr_Buscador.RowCount - 1 Then
            _Pos = _Pos + 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub
    Private Sub _PUltimoRegistro()
        If JGr_Buscador.RowCount > 0 Then
            _Pos = JGr_Buscador.RowCount - 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub

#End Region

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _PNuevoRegistro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        _PModificarRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        _PEliminarRegistro()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        _PGrabarRegistro()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _PSalirRegistro()
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        _PPrimerRegistro()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        _PAnteriorRegistro()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        _PSiguienteRegistro()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        _PUltimoRegistro()
    End Sub

    Private Sub F0_DescuentosFijos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub JGr_Buscador_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_Buscador.EditingCell
        e.Cancel = True
    End Sub

    Private Sub tbVencimiento_ValueChanged(sender As Object, e As EventArgs) Handles tbVencimiento.ValueChanged
        If btnGrabar.Enabled = True Then
            dtFechaVenc.Enabled = tbVencimiento.Value
        End If
    End Sub


    Private Sub JGr_Buscador_SelectionChanged(sender As Object, e As EventArgs) Handles JGr_Buscador.SelectionChanged
        If JGr_Buscador.Row >= 0 Then
            _Pos = JGr_Buscador.Row
            _PMostrarRegistro(_Pos)
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
End Class