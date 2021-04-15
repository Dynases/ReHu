<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F3_Configuracion
    Inherits Modelo.ModeloF3

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F3_Configuracion))
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGr_BonoAntiguedad = New Janus.Windows.GridEX.GridEX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbBonoMeses = New DevComponents.Editors.IntegerInput()
        Me.tbBonoImporte = New DevComponents.Editors.DoubleInput()
        Me.tbSueldoMin = New DevComponents.Editors.DoubleInput()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.dtBonoFecha = New System.Windows.Forms.DateTimePicker()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.tbNumiBono = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.RLAccionBono = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSalirBono = New DevComponents.DotNetBar.ButtonX()
        Me.btnGrabarBono = New DevComponents.DotNetBar.ButtonX()
        Me.btnEliminarBono = New DevComponents.DotNetBar.ButtonX()
        Me.btnModificarBono = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevoBono = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGr_Buscador = New Janus.Windows.GridEX.GridEX()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dtFInicio = New System.Windows.Forms.DateTimePicker()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.swTipoDesc = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dtFVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.swVencimiento = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.tbObservacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tbMonto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.swTMonto = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.tbNumi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGr_Vacacion = New Janus.Windows.GridEX.GridEX()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.tbNumiVacacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.swVacacionTipo = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.tbVacacionMeses = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.tbVacacionDias = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtVacacionFecha = New System.Windows.Forms.DateTimePicker()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.RLAccionVacacion = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnSalirVacacion = New DevComponents.DotNetBar.ButtonX()
        Me.btnGrabarVacacion = New DevComponents.DotNetBar.ButtonX()
        Me.btnEliminarVacacion = New DevComponents.DotNetBar.ButtonX()
        Me.btnModificarVacacion = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevoVacacion = New DevComponents.DotNetBar.ButtonX()
        Me.RLAccion = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGr_BuscadorEmp = New Janus.Windows.GridEX.GridEX()
        Me.MpanelSuperior.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MpanelBuscador.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.superTabControl1.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.JGr_BonoAntiguedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tbBonoMeses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBonoImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSueldoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.JGr_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.JGr_Vacacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        CType(Me.JGr_BuscadorEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.Panel7)
        Me.MpanelSuperior.Controls.Add(Me.Panel4)
        Me.MpanelSuperior.Size = New System.Drawing.Size(1350, 605)
        Me.MpanelSuperior.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.MpanelSuperior.Controls.SetChildIndex(Me.Panel4, 0)
        Me.MpanelSuperior.Controls.SetChildIndex(Me.Panel7, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.RLAccion)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        Me.PanelSuperior.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Controls.SetChildIndex(Me.PanelToolBar1, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.RLAccion, 0)
        '
        'btnSalir
        '
        '
        'btnGrabar
        '
        '
        'btnEliminar
        '
        '
        'btnModificar
        '
        '
        'btnNuevo
        '
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 677)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        Me.PanelInferior.Visible = False
        '
        'MpanelBuscador
        '
        Me.MpanelBuscador.Controls.Add(Me.PanelEx6)
        Me.MpanelBuscador.Size = New System.Drawing.Size(1350, 716)
        '
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.ReadOnly = True
        Me.TxtNombreUsu.Text = "DEFAULT"
        '
        'BubbleBarUsuario
        '
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'superTabItem2
        '
        Me.superTabItem2.Text = "BONO ANTIGUEDAD"
        '
        'superTabItem1
        '
        Me.superTabItem1.Text = "DESCUENTOS"
        '
        'superTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.superTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.superTabControl1.ControlBox.MenuBox.Name = ""
        Me.superTabControl1.ControlBox.Name = ""
        Me.superTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl1.ControlBox.MenuBox, Me.superTabControl1.ControlBox.CloseBox})
        Me.superTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.superTabControl1.SelectedTabIndex = 1
        Me.superTabControl1.Size = New System.Drawing.Size(1350, 741)
        Me.superTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem3})
        Me.superTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel3, 0)
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.GroupPanel2)
        Me.PanelEx6.Controls.Add(Me.PanelEx1)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx6.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(1350, 716)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 4
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.JGr_BonoAntiguedad)
        Me.GroupPanel2.Controls.Add(Me.Panel2)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 72)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1350, 644)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 0
        Me.GroupPanel2.Text = "BONO ANTIGUEDAD"
        '
        'JGr_BonoAntiguedad
        '
        Me.JGr_BonoAntiguedad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_BonoAntiguedad.Location = New System.Drawing.Point(0, 130)
        Me.JGr_BonoAntiguedad.Name = "JGr_BonoAntiguedad"
        Me.JGr_BonoAntiguedad.Size = New System.Drawing.Size(1344, 491)
        Me.JGr_BonoAntiguedad.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbBonoMeses)
        Me.Panel2.Controls.Add(Me.tbBonoImporte)
        Me.Panel2.Controls.Add(Me.tbSueldoMin)
        Me.Panel2.Controls.Add(Me.LabelX15)
        Me.Panel2.Controls.Add(Me.LabelX14)
        Me.Panel2.Controls.Add(Me.dtBonoFecha)
        Me.Panel2.Controls.Add(Me.LabelX12)
        Me.Panel2.Controls.Add(Me.LabelX4)
        Me.Panel2.Controls.Add(Me.tbNumiBono)
        Me.Panel2.Controls.Add(Me.LabelX3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1344, 130)
        Me.Panel2.TabIndex = 22
        '
        'tbBonoMeses
        '
        '
        '
        '
        Me.tbBonoMeses.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbBonoMeses.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbBonoMeses.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbBonoMeses.Location = New System.Drawing.Point(510, 18)
        Me.tbBonoMeses.Name = "tbBonoMeses"
        Me.tbBonoMeses.Size = New System.Drawing.Size(100, 22)
        Me.tbBonoMeses.TabIndex = 40
        '
        'tbBonoImporte
        '
        '
        '
        '
        Me.tbBonoImporte.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbBonoImporte.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbBonoImporte.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbBonoImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBonoImporte.Increment = 1.0R
        Me.tbBonoImporte.Location = New System.Drawing.Point(510, 49)
        Me.tbBonoImporte.MinValue = 0R
        Me.tbBonoImporte.Name = "tbBonoImporte"
        Me.tbBonoImporte.Size = New System.Drawing.Size(100, 21)
        Me.tbBonoImporte.TabIndex = 39
        Me.tbBonoImporte.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'tbSueldoMin
        '
        '
        '
        '
        Me.tbSueldoMin.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbSueldoMin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbSueldoMin.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbSueldoMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSueldoMin.Increment = 1.0R
        Me.tbSueldoMin.Location = New System.Drawing.Point(178, 83)
        Me.tbSueldoMin.MinValue = 0R
        Me.tbSueldoMin.Name = "tbSueldoMin"
        Me.tbSueldoMin.Size = New System.Drawing.Size(100, 21)
        Me.tbSueldoMin.TabIndex = 38
        Me.tbSueldoMin.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX15.Location = New System.Drawing.Point(16, 81)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(156, 23)
        Me.LabelX15.TabIndex = 35
        Me.LabelX15.Text = "SUELDO MÍNIMO:"
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX14.Location = New System.Drawing.Point(16, 49)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(135, 23)
        Me.LabelX14.TabIndex = 34
        Me.LabelX14.Text = "FECHA:"
        '
        'dtBonoFecha
        '
        Me.dtBonoFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBonoFecha.Location = New System.Drawing.Point(179, 50)
        Me.dtBonoFecha.Name = "dtBonoFecha"
        Me.dtBonoFecha.Size = New System.Drawing.Size(100, 22)
        Me.dtBonoFecha.TabIndex = 33
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX12.Location = New System.Drawing.Point(17, 17)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(156, 23)
        Me.LabelX12.TabIndex = 19
        Me.LabelX12.Text = "CÓDIGO:"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(348, 17)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(156, 23)
        Me.LabelX4.TabIndex = 14
        Me.LabelX4.Text = "MESES:"
        '
        'tbNumiBono
        '
        Me.tbNumiBono.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbNumiBono.Border.Class = "TextBoxBorder"
        Me.tbNumiBono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNumiBono.DisabledBackColor = System.Drawing.Color.White
        Me.tbNumiBono.Enabled = False
        Me.tbNumiBono.ForeColor = System.Drawing.Color.Black
        Me.tbNumiBono.Location = New System.Drawing.Point(179, 18)
        Me.tbNumiBono.Name = "tbNumiBono"
        Me.tbNumiBono.PreventEnterBeep = True
        Me.tbNumiBono.Size = New System.Drawing.Size(100, 22)
        Me.tbNumiBono.TabIndex = 26
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(348, 49)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(156, 23)
        Me.LabelX3.TabIndex = 15
        Me.LabelX3.Text = "IMPORTE DE BONO:"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.PanelEx1.Controls.Add(Me.RLAccionBono)
        Me.PanelEx1.Controls.Add(Me.Panel3)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1350, 72)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx1.Style.BackgroundImage = CType(resources.GetObject("PanelEx1.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx1.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx1.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx1.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx1.TabIndex = 8
        '
        'RLAccionBono
        '
        '
        '
        '
        Me.RLAccionBono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RLAccionBono.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RLAccionBono.ForeColor = System.Drawing.Color.Black
        Me.RLAccionBono.Location = New System.Drawing.Point(405, 6)
        Me.RLAccionBono.Name = "RLAccionBono"
        Me.RLAccionBono.Size = New System.Drawing.Size(409, 60)
        Me.RLAccionBono.TabIndex = 10
        Me.RLAccionBono.Text = "<b><font size=""+10""><font color=""#FF0000""></font></font></b>"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSalirBono)
        Me.Panel3.Controls.Add(Me.btnGrabarBono)
        Me.Panel3.Controls.Add(Me.btnEliminarBono)
        Me.Panel3.Controls.Add(Me.btnModificarBono)
        Me.Panel3.Controls.Add(Me.btnNuevoBono)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(376, 72)
        Me.Panel3.TabIndex = 5
        '
        'btnSalirBono
        '
        Me.btnSalirBono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalirBono.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnSalirBono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSalirBono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirBono.Image = Global.ReHu.My.Resources.Resources.Salir5
        Me.btnSalirBono.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnSalirBono.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSalirBono.Location = New System.Drawing.Point(288, 0)
        Me.btnSalirBono.Name = "btnSalirBono"
        Me.btnSalirBono.Size = New System.Drawing.Size(88, 72)
        Me.btnSalirBono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSalirBono.TabIndex = 10
        Me.btnSalirBono.Text = "SALIR"
        Me.btnSalirBono.TextColor = System.Drawing.Color.White
        '
        'btnGrabarBono
        '
        Me.btnGrabarBono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGrabarBono.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnGrabarBono.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGrabarBono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabarBono.Image = Global.ReHu.My.Resources.Resources.Guardar2
        Me.btnGrabarBono.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnGrabarBono.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnGrabarBono.Location = New System.Drawing.Point(216, 0)
        Me.btnGrabarBono.Name = "btnGrabarBono"
        Me.btnGrabarBono.Size = New System.Drawing.Size(72, 72)
        Me.btnGrabarBono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGrabarBono.TabIndex = 9
        Me.btnGrabarBono.Text = "GRABAR"
        Me.btnGrabarBono.TextColor = System.Drawing.Color.White
        '
        'btnEliminarBono
        '
        Me.btnEliminarBono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminarBono.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminarBono.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminarBono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarBono.Image = Global.ReHu.My.Resources.Resources.trash2
        Me.btnEliminarBono.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnEliminarBono.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEliminarBono.Location = New System.Drawing.Point(144, 0)
        Me.btnEliminarBono.Name = "btnEliminarBono"
        Me.btnEliminarBono.Size = New System.Drawing.Size(72, 72)
        Me.btnEliminarBono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminarBono.TabIndex = 8
        Me.btnEliminarBono.Text = "ELIMINAR"
        Me.btnEliminarBono.TextColor = System.Drawing.Color.White
        '
        'btnModificarBono
        '
        Me.btnModificarBono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificarBono.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnModificarBono.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModificarBono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarBono.Image = Global.ReHu.My.Resources.Resources.edit2
        Me.btnModificarBono.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnModificarBono.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnModificarBono.Location = New System.Drawing.Point(72, 0)
        Me.btnModificarBono.Name = "btnModificarBono"
        Me.btnModificarBono.Size = New System.Drawing.Size(72, 72)
        Me.btnModificarBono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnModificarBono.TabIndex = 7
        Me.btnModificarBono.Text = "MODIFICAR"
        Me.btnModificarBono.TextColor = System.Drawing.Color.White
        '
        'btnNuevoBono
        '
        Me.btnNuevoBono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevoBono.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoBono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoBono.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.btnNuevoBono.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNuevoBono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoBono.Image = Global.ReHu.My.Resources.Resources.add2
        Me.btnNuevoBono.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnNuevoBono.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNuevoBono.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevoBono.Name = "btnNuevoBono"
        Me.btnNuevoBono.Size = New System.Drawing.Size(72, 72)
        Me.btnNuevoBono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevoBono.TabIndex = 6
        Me.btnNuevoBono.Text = "NUEVO"
        Me.btnNuevoBono.TextColor = System.Drawing.Color.White
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.JGr_Buscador)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1344, 211)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 90
        Me.GroupPanel1.Text = "BUSCADOR DESCUENTOS LEY PERSONAL"
        '
        'JGr_Buscador
        '
        Me.JGr_Buscador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_Buscador.Location = New System.Drawing.Point(0, 0)
        Me.JGr_Buscador.Name = "JGr_Buscador"
        Me.JGr_Buscador.Size = New System.Drawing.Size(1338, 188)
        Me.JGr_Buscador.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dtFInicio)
        Me.Panel4.Controls.Add(Me.LabelX9)
        Me.Panel4.Controls.Add(Me.swTipoDesc)
        Me.Panel4.Controls.Add(Me.LabelX2)
        Me.Panel4.Controls.Add(Me.GroupPanel3)
        Me.Panel4.Controls.Add(Me.tbObservacion)
        Me.Panel4.Controls.Add(Me.LabelX1)
        Me.Panel4.Controls.Add(Me.tbMonto)
        Me.Panel4.Controls.Add(Me.swTMonto)
        Me.Panel4.Controls.Add(Me.LabelX5)
        Me.Panel4.Controls.Add(Me.tbNumi)
        Me.Panel4.Controls.Add(Me.LabelX6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1350, 170)
        Me.Panel4.TabIndex = 91
        '
        'dtFInicio
        '
        Me.dtFInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFInicio.Location = New System.Drawing.Point(665, 17)
        Me.dtFInicio.Name = "dtFInicio"
        Me.dtFInicio.Size = New System.Drawing.Size(147, 22)
        Me.dtFInicio.TabIndex = 24
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX9.Location = New System.Drawing.Point(555, 16)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(104, 23)
        Me.LabelX9.TabIndex = 23
        Me.LabelX9.Text = "FECHA INICIO:"
        '
        'swTipoDesc
        '
        '
        '
        '
        Me.swTipoDesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swTipoDesc.Location = New System.Drawing.Point(178, 45)
        Me.swTipoDesc.Name = "swTipoDesc"
        Me.swTipoDesc.OffText = "DESC. LEY EMPRESA"
        Me.swTipoDesc.OnText = "DESC. LEY PERSONAL"
        Me.swTipoDesc.Size = New System.Drawing.Size(195, 22)
        Me.swTipoDesc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swTipoDesc.TabIndex = 22
        Me.swTipoDesc.Value = True
        Me.swTipoDesc.ValueObject = "Y"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(40, 44)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(124, 23)
        Me.LabelX2.TabIndex = 21
        Me.LabelX2.Text = "TIPO DESCUENTO:"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.dtFVencimiento)
        Me.GroupPanel3.Controls.Add(Me.swVencimiento)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(555, 51)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(262, 57)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 20
        Me.GroupPanel3.Text = "FECHA VENCIMIENTO"
        '
        'dtFVencimiento
        '
        Me.dtFVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFVencimiento.Location = New System.Drawing.Point(99, 8)
        Me.dtFVencimiento.Name = "dtFVencimiento"
        Me.dtFVencimiento.Size = New System.Drawing.Size(147, 22)
        Me.dtFVencimiento.TabIndex = 1
        '
        'swVencimiento
        '
        '
        '
        '
        Me.swVencimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swVencimiento.Location = New System.Drawing.Point(3, 5)
        Me.swVencimiento.Name = "swVencimiento"
        Me.swVencimiento.Size = New System.Drawing.Size(86, 25)
        Me.swVencimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swVencimiento.TabIndex = 0
        '
        'tbObservacion
        '
        '
        '
        '
        Me.tbObservacion.Border.Class = "TextBoxBorder"
        Me.tbObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbObservacion.Location = New System.Drawing.Point(178, 104)
        Me.tbObservacion.MaxLength = 200
        Me.tbObservacion.Name = "tbObservacion"
        Me.tbObservacion.PreventEnterBeep = True
        Me.tbObservacion.Size = New System.Drawing.Size(299, 22)
        Me.tbObservacion.TabIndex = 18
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(40, 104)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(114, 23)
        Me.LabelX1.TabIndex = 17
        Me.LabelX1.Text = "OBSERVACIÓN.:"
        '
        'tbMonto
        '
        Me.tbMonto.AcceptsReturn = True
        '
        '
        '
        Me.tbMonto.Border.Class = "TextBoxBorder"
        Me.tbMonto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMonto.Location = New System.Drawing.Point(337, 76)
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.PreventEnterBeep = True
        Me.tbMonto.Size = New System.Drawing.Size(137, 22)
        Me.tbMonto.TabIndex = 15
        '
        'swTMonto
        '
        '
        '
        '
        Me.swTMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swTMonto.Location = New System.Drawing.Point(178, 76)
        Me.swTMonto.Name = "swTMonto"
        Me.swTMonto.OffText = "PORCENTAJE"
        Me.swTMonto.OnText = "MONTO"
        Me.swTMonto.Size = New System.Drawing.Size(155, 22)
        Me.swTMonto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swTMonto.TabIndex = 14
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(40, 75)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(104, 23)
        Me.LabelX5.TabIndex = 13
        Me.LabelX5.Text = "MONTO:"
        '
        'tbNumi
        '
        '
        '
        '
        Me.tbNumi.Border.Class = "TextBoxBorder"
        Me.tbNumi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNumi.Location = New System.Drawing.Point(178, 17)
        Me.tbNumi.Name = "tbNumi"
        Me.tbNumi.PreventEnterBeep = True
        Me.tbNumi.Size = New System.Drawing.Size(112, 22)
        Me.tbNumi.TabIndex = 12
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX6.Location = New System.Drawing.Point(40, 17)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(104, 23)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "CÓDIGO:"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.OfficeMobile2014Blue
        Me.SuperTabItem3.Text = "VACACIONES"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.PanelEx2)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(1350, 716)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.GroupPanel4)
        Me.PanelEx2.Controls.Add(Me.PanelEx3)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1350, 716)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 8
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.JGr_Vacacion)
        Me.GroupPanel4.Controls.Add(Me.Panel5)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 72)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(1350, 644)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 0
        Me.GroupPanel4.Text = "BONO ANTIGUEDAD"
        '
        'JGr_Vacacion
        '
        Me.JGr_Vacacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_Vacacion.Location = New System.Drawing.Point(0, 170)
        Me.JGr_Vacacion.Name = "JGr_Vacacion"
        Me.JGr_Vacacion.Size = New System.Drawing.Size(1344, 451)
        Me.JGr_Vacacion.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LabelX13)
        Me.Panel5.Controls.Add(Me.tbNumiVacacion)
        Me.Panel5.Controls.Add(Me.LabelX7)
        Me.Panel5.Controls.Add(Me.swVacacionTipo)
        Me.Panel5.Controls.Add(Me.LabelX8)
        Me.Panel5.Controls.Add(Me.LabelX10)
        Me.Panel5.Controls.Add(Me.tbVacacionMeses)
        Me.Panel5.Controls.Add(Me.LabelX11)
        Me.Panel5.Controls.Add(Me.tbVacacionDias)
        Me.Panel5.Controls.Add(Me.dtVacacionFecha)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1344, 170)
        Me.Panel5.TabIndex = 22
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX13.Location = New System.Drawing.Point(25, 12)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(156, 23)
        Me.LabelX13.TabIndex = 35
        Me.LabelX13.Text = "CÓDIGO:"
        '
        'tbNumiVacacion
        '
        Me.tbNumiVacacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbNumiVacacion.Border.Class = "TextBoxBorder"
        Me.tbNumiVacacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNumiVacacion.DisabledBackColor = System.Drawing.Color.White
        Me.tbNumiVacacion.Enabled = False
        Me.tbNumiVacacion.ForeColor = System.Drawing.Color.Black
        Me.tbNumiVacacion.Location = New System.Drawing.Point(188, 12)
        Me.tbNumiVacacion.Name = "tbNumiVacacion"
        Me.tbNumiVacacion.PreventEnterBeep = True
        Me.tbNumiVacacion.Size = New System.Drawing.Size(100, 22)
        Me.tbNumiVacacion.TabIndex = 36
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX7.Location = New System.Drawing.Point(25, 40)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(145, 23)
        Me.LabelX7.TabIndex = 27
        Me.LabelX7.Text = "MESES:"
        '
        'swVacacionTipo
        '
        '
        '
        '
        Me.swVacacionTipo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swVacacionTipo.Location = New System.Drawing.Point(188, 129)
        Me.swVacacionTipo.Name = "swVacacionTipo"
        Me.swVacacionTipo.OffText = "CALENDARIO"
        Me.swVacacionTipo.OnText = "DIAS HÁBILES"
        Me.swVacacionTipo.Size = New System.Drawing.Size(158, 22)
        Me.swVacacionTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swVacacionTipo.TabIndex = 34
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX8.Location = New System.Drawing.Point(25, 69)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(157, 23)
        Me.LabelX8.TabIndex = 28
        Me.LabelX8.Text = "DIAS DE VACACION:"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX10.Location = New System.Drawing.Point(25, 129)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(133, 22)
        Me.LabelX10.TabIndex = 33
        Me.LabelX10.Text = "TIPO:"
        '
        'tbVacacionMeses
        '
        Me.tbVacacionMeses.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbVacacionMeses.Border.Class = "TextBoxBorder"
        Me.tbVacacionMeses.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbVacacionMeses.DisabledBackColor = System.Drawing.Color.White
        Me.tbVacacionMeses.ForeColor = System.Drawing.Color.Black
        Me.tbVacacionMeses.Location = New System.Drawing.Point(188, 40)
        Me.tbVacacionMeses.Name = "tbVacacionMeses"
        Me.tbVacacionMeses.PreventEnterBeep = True
        Me.tbVacacionMeses.Size = New System.Drawing.Size(100, 22)
        Me.tbVacacionMeses.TabIndex = 29
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX11.Location = New System.Drawing.Point(25, 98)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(135, 23)
        Me.LabelX11.TabIndex = 32
        Me.LabelX11.Text = "FECHA:"
        '
        'tbVacacionDias
        '
        Me.tbVacacionDias.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbVacacionDias.Border.Class = "TextBoxBorder"
        Me.tbVacacionDias.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbVacacionDias.DisabledBackColor = System.Drawing.Color.White
        Me.tbVacacionDias.ForeColor = System.Drawing.Color.Black
        Me.tbVacacionDias.Location = New System.Drawing.Point(188, 68)
        Me.tbVacacionDias.Name = "tbVacacionDias"
        Me.tbVacacionDias.PreventEnterBeep = True
        Me.tbVacacionDias.Size = New System.Drawing.Size(100, 22)
        Me.tbVacacionDias.TabIndex = 30
        '
        'dtVacacionFecha
        '
        Me.dtVacacionFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVacacionFecha.Location = New System.Drawing.Point(188, 99)
        Me.dtVacacionFecha.Name = "dtVacacionFecha"
        Me.dtVacacionFecha.Size = New System.Drawing.Size(100, 22)
        Me.dtVacacionFecha.TabIndex = 31
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.PanelEx3.Controls.Add(Me.RLAccionVacacion)
        Me.PanelEx3.Controls.Add(Me.Panel6)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1350, 72)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx3.Style.BackgroundImage = CType(resources.GetObject("PanelEx3.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx3.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx3.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx3.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelEx3.TabIndex = 8
        '
        'RLAccionVacacion
        '
        '
        '
        '
        Me.RLAccionVacacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RLAccionVacacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RLAccionVacacion.ForeColor = System.Drawing.Color.Black
        Me.RLAccionVacacion.Location = New System.Drawing.Point(396, 6)
        Me.RLAccionVacacion.Name = "RLAccionVacacion"
        Me.RLAccionVacacion.Size = New System.Drawing.Size(409, 60)
        Me.RLAccionVacacion.TabIndex = 10
        Me.RLAccionVacacion.Text = "<b><font size=""+10""><font color=""#FF0000""></font></font></b>"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnSalirVacacion)
        Me.Panel6.Controls.Add(Me.btnGrabarVacacion)
        Me.Panel6.Controls.Add(Me.btnEliminarVacacion)
        Me.Panel6.Controls.Add(Me.btnModificarVacacion)
        Me.Panel6.Controls.Add(Me.btnNuevoVacacion)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(376, 72)
        Me.Panel6.TabIndex = 5
        '
        'btnSalirVacacion
        '
        Me.btnSalirVacacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalirVacacion.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnSalirVacacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSalirVacacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirVacacion.Image = Global.ReHu.My.Resources.Resources.Salir5
        Me.btnSalirVacacion.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnSalirVacacion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSalirVacacion.Location = New System.Drawing.Point(288, 0)
        Me.btnSalirVacacion.Name = "btnSalirVacacion"
        Me.btnSalirVacacion.Size = New System.Drawing.Size(88, 72)
        Me.btnSalirVacacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSalirVacacion.TabIndex = 10
        Me.btnSalirVacacion.Text = "SALIR"
        Me.btnSalirVacacion.TextColor = System.Drawing.Color.White
        '
        'btnGrabarVacacion
        '
        Me.btnGrabarVacacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGrabarVacacion.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnGrabarVacacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGrabarVacacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabarVacacion.Image = Global.ReHu.My.Resources.Resources.Guardar2
        Me.btnGrabarVacacion.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnGrabarVacacion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnGrabarVacacion.Location = New System.Drawing.Point(216, 0)
        Me.btnGrabarVacacion.Name = "btnGrabarVacacion"
        Me.btnGrabarVacacion.Size = New System.Drawing.Size(72, 72)
        Me.btnGrabarVacacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGrabarVacacion.TabIndex = 9
        Me.btnGrabarVacacion.Text = "GRABAR"
        Me.btnGrabarVacacion.TextColor = System.Drawing.Color.White
        '
        'btnEliminarVacacion
        '
        Me.btnEliminarVacacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminarVacacion.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminarVacacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminarVacacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarVacacion.Image = Global.ReHu.My.Resources.Resources.trash2
        Me.btnEliminarVacacion.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnEliminarVacacion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEliminarVacacion.Location = New System.Drawing.Point(144, 0)
        Me.btnEliminarVacacion.Name = "btnEliminarVacacion"
        Me.btnEliminarVacacion.Size = New System.Drawing.Size(72, 72)
        Me.btnEliminarVacacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminarVacacion.TabIndex = 8
        Me.btnEliminarVacacion.Text = "ELIMINAR"
        Me.btnEliminarVacacion.TextColor = System.Drawing.Color.White
        '
        'btnModificarVacacion
        '
        Me.btnModificarVacacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificarVacacion.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnModificarVacacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModificarVacacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarVacacion.Image = Global.ReHu.My.Resources.Resources.edit2
        Me.btnModificarVacacion.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnModificarVacacion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnModificarVacacion.Location = New System.Drawing.Point(72, 0)
        Me.btnModificarVacacion.Name = "btnModificarVacacion"
        Me.btnModificarVacacion.Size = New System.Drawing.Size(72, 72)
        Me.btnModificarVacacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnModificarVacacion.TabIndex = 7
        Me.btnModificarVacacion.Text = "MODIFICAR"
        Me.btnModificarVacacion.TextColor = System.Drawing.Color.White
        '
        'btnNuevoVacacion
        '
        Me.btnNuevoVacacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevoVacacion.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoVacacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoVacacion.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.btnNuevoVacacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNuevoVacacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoVacacion.Image = Global.ReHu.My.Resources.Resources.add2
        Me.btnNuevoVacacion.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnNuevoVacacion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNuevoVacacion.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevoVacacion.Name = "btnNuevoVacacion"
        Me.btnNuevoVacacion.Size = New System.Drawing.Size(72, 72)
        Me.btnNuevoVacacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevoVacacion.TabIndex = 6
        Me.btnNuevoVacacion.Text = "NUEVO"
        Me.btnNuevoVacacion.TextColor = System.Drawing.Color.White
        '
        'RLAccion
        '
        '
        '
        '
        Me.RLAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RLAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RLAccion.ForeColor = System.Drawing.Color.Black
        Me.RLAccion.Location = New System.Drawing.Point(394, 6)
        Me.RLAccion.Name = "RLAccion"
        Me.RLAccion.Size = New System.Drawing.Size(409, 60)
        Me.RLAccion.TabIndex = 9
        Me.RLAccion.Text = "<b><font size=""+10""><font color=""#FF0000""></font></font></b>"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 170)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1350, 435)
        Me.Panel7.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1350, 435)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'GroupPanel5
        '
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.JGr_BuscadorEmp)
        Me.GroupPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel5.Location = New System.Drawing.Point(3, 220)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(1344, 212)
        '
        '
        '
        Me.GroupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel5.Style.BackColorGradientAngle = 90
        Me.GroupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderBottomWidth = 1
        Me.GroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderLeftWidth = 1
        Me.GroupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderRightWidth = 1
        Me.GroupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderTopWidth = 1
        Me.GroupPanel5.Style.CornerDiameter = 4
        Me.GroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel5.TabIndex = 91
        Me.GroupPanel5.Text = "BUSCADOR DESCUENTOS LEY EMPRESA"
        '
        'JGr_BuscadorEmp
        '
        Me.JGr_BuscadorEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_BuscadorEmp.Location = New System.Drawing.Point(0, 0)
        Me.JGr_BuscadorEmp.Name = "JGr_BuscadorEmp"
        Me.JGr_BuscadorEmp.Size = New System.Drawing.Size(1338, 189)
        Me.JGr_BuscadorEmp.TabIndex = 1
        '
        'F3_Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 741)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "F3_Configuracion"
        Me.Opacity = 0.05R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Text = "F3_Configuracion"
        Me.MpanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MpanelBuscador.ResumeLayout(False)
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.superTabControl1.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.JGr_BonoAntiguedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.tbBonoMeses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBonoImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSueldoMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.JGr_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.JGr_Vacacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        CType(Me.JGr_BuscadorEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGr_BonoAntiguedad As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNumiBono As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGr_Buscador As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dtFVencimiento As DateTimePicker
    Friend WithEvents swVencimiento As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents tbObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbMonto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents swTMonto As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNumi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Protected WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Protected WithEvents Panel3 As Panel
    Protected WithEvents btnSalirBono As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnGrabarBono As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnEliminarBono As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnModificarBono As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnNuevoBono As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGr_Vacacion As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel5 As Panel
    Protected WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Protected WithEvents Panel6 As Panel
    Protected WithEvents btnSalirVacacion As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnGrabarVacacion As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnEliminarVacacion As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnModificarVacacion As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnNuevoVacacion As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents swTipoDesc As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtFInicio As DateTimePicker
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RLAccion As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swVacacionTipo As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbVacacionMeses As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbVacacionDias As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtVacacionFecha As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RLAccionBono As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents RLAccionVacacion As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNumiVacacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtBonoFecha As DateTimePicker
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbSueldoMin As DevComponents.Editors.DoubleInput
    Friend WithEvents tbBonoImporte As DevComponents.Editors.DoubleInput
    Friend WithEvents tbBonoMeses As DevComponents.Editors.IntegerInput
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGr_BuscadorEmp As Janus.Windows.GridEX.GridEX
End Class
