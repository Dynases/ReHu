Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Controls
Public Class F3_PedidoVacacion
#Region "VARIABLES"
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public _nameButton As String

    Dim _Dsencabezado As DataSet
    Dim _Pos As Integer
    Dim _Nuevo As Boolean
    Dim _Modificar As Boolean
#End Region

#Region "Metodos Privados"
    Private Sub _PIniciarTodo()
        Me.Text = "P E D I D O   D E   V A C A C I Ó N"

        _PCargarComboEmpleados()
        _PInhabilitar()
        _PFiltrar()

        '_PHabilitarFocus()

        '_PCargarBuscador()
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
    Private Sub _PInhabilitar()
        Tb_Id.Enabled = False
        Tb_Fecha.Enabled = False
        Tb_Estado.Enabled = False
        Tb_Obs.Enabled = False
        Tb_DiasPedidos.Enabled = False
        Tb_DiasPermitidos.Enabled = False
        Tb_FechaIngreso.Enabled = False
        Tb_FechaSalida.Enabled = False

        JMc_Persona.Enabled = False

        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGrabar.Enabled = False

        btnGrabar.Image = My.Resources.GUARDAR

        _PLimpiarErrores()

        JGr_Buscador.Enabled = True

        _Nuevo = False
        _Modificar = False
    End Sub
    Private Sub _PLimpiarErrores()
        MEP.Clear()
        Tb_Fecha.BackColor = Color.White
        Tb_Fecha.BackColor = Color.White
        Tb_Obs.BackColor = Color.White
    End Sub
    Private Sub _PFiltrar()
        '_Dsencabezado = New DataSet
        '_Dsencabezado = L_PedidoVacacionCabecera_General(0)
        ''_First = False
        'If _Dsencabezado.Tables(0).Rows.Count <> 0 Then
        '    _Pos = 0
        '    _PMostrarRegistro(_Pos)
        '    LblPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        '    If _Dsencabezado.Tables(0).Rows.Count > 0 Then
        '        btnPrimero.Visible = True
        '        btnAnterior.Visible = True
        '        btnSiguiente.Visible = True
        '        btnUltimo.Visible = True
        '    End If
        'End If

    End Sub
#End Region
    Private Sub F3_PedidoVacacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()

    End Sub
End Class