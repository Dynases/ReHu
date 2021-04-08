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
    Public _modulo As SideNavItem
    Public _nameButton As String
    Dim _Dsencabezado As DataSet
    Dim _Pos As Integer
    Dim _Nuevo As Boolean

#End Region
#Region "Metodos Privados"
    Private Sub _PIniciarTodo()
        Me.Text = "D E S C U E N T O S     F I J O S"

        'abrir conexion
        _PCargarBuscador()

        '_PCargarComboEmpleados()

        '_PFiltrar()
        '_PInhabilitar()

        '_PHabilitarFocus()

        '_pCambiarFuente()
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
#End Region

#Region "Eventos"
    Private Sub F3_Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub
#End Region
End Class