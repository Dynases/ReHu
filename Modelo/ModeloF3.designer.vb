<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModeloF3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModeloF3))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.superTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.superTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.MpanelSuperior = New System.Windows.Forms.Panel()
        Me.PanelUsuario = New System.Windows.Forms.Panel()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PanelSuperior = New DevComponents.DotNetBar.PanelEx()
        Me.PanelToolBar1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.btnGrabar = New DevComponents.DotNetBar.ButtonX()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.PanelInferior = New DevComponents.DotNetBar.PanelEx()
        Me.MPanelUserAct = New System.Windows.Forms.Panel()
        Me.BubbleBarUsuario = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTabUsuario = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.BubbleButton3 = New DevComponents.DotNetBar.BubbleButton()
        Me.TxtNombreUsu = New System.Windows.Forms.TextBox()
        Me.PanelNavegacion = New System.Windows.Forms.Panel()
        Me.LblPaginacion = New System.Windows.Forms.Label()
        Me.btnUltimo = New DevComponents.DotNetBar.ButtonX()
        Me.btnSiguiente = New DevComponents.DotNetBar.ButtonX()
        Me.btnAnterior = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrimero = New DevComponents.DotNetBar.ButtonX()
        Me.superTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.superTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.MpanelBuscador = New System.Windows.Forms.Panel()
        Me.superTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.MEP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MHighlighterFocus = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.BBtnUsuario = New DevComponents.DotNetBar.BubbleButton()
        Me.BubbleButton1 = New DevComponents.DotNetBar.BubbleButton()
        Me.BubbleButton2 = New DevComponents.DotNetBar.BubbleButton()
        Me.MFlyoutUsuario = New DevComponents.DotNetBar.Controls.Flyout(Me.components)
        Me.panel1.SuspendLayout()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.superTabControl1.SuspendLayout()
        Me.superTabControlPanel1.SuspendLayout()
        Me.MpanelSuperior.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavegacion.SuspendLayout()
        Me.superTabControlPanel2.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.superTabControl1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1350, 719)
        Me.panel1.TabIndex = 1
        '
        'superTabControl1
        '
        Me.superTabControl1.BackColor = System.Drawing.Color.White
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
        Me.superTabControl1.Controls.Add(Me.superTabControlPanel1)
        Me.superTabControl1.Controls.Add(Me.superTabControlPanel2)
        Me.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superTabControl1.ForeColor = System.Drawing.Color.Black
        Me.superTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.superTabControl1.Name = "superTabControl1"
        Me.superTabControl1.ReorderTabsEnabled = True
        Me.superTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.superTabControl1.SelectedTabIndex = 0
        Me.superTabControl1.Size = New System.Drawing.Size(1350, 719)
        Me.superTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.superTabControl1.TabIndex = 88
        Me.superTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabItem1, Me.superTabItem2})
        Me.superTabControl1.Text = "superTabControl1"
        '
        'superTabControlPanel1
        '
        Me.superTabControlPanel1.Controls.Add(Me.MpanelSuperior)
        Me.superTabControlPanel1.Controls.Add(Me.PanelSuperior)
        Me.superTabControlPanel1.Controls.Add(Me.PanelInferior)
        Me.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.superTabControlPanel1.Name = "superTabControlPanel1"
        Me.superTabControlPanel1.Size = New System.Drawing.Size(1350, 694)
        Me.superTabControlPanel1.TabIndex = 1
        Me.superTabControlPanel1.TabItem = Me.superTabItem1
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.BackColor = System.Drawing.Color.White
        Me.MpanelSuperior.Controls.Add(Me.PanelUsuario)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Name = "MpanelSuperior"
        Me.MpanelSuperior.Size = New System.Drawing.Size(1350, 583)
        Me.MpanelSuperior.TabIndex = 103
        '
        'PanelUsuario
        '
        Me.PanelUsuario.Controls.Add(Me.lbHora)
        Me.PanelUsuario.Controls.Add(Me.lbFecha)
        Me.PanelUsuario.Controls.Add(Me.lbUsuario)
        Me.PanelUsuario.Controls.Add(Me.lblHora)
        Me.PanelUsuario.Controls.Add(Me.lblFecha)
        Me.PanelUsuario.Controls.Add(Me.lblUsuario)
        Me.PanelUsuario.Location = New System.Drawing.Point(465, 25)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(220, 100)
        Me.PanelUsuario.TabIndex = 89
        Me.PanelUsuario.TabStop = True
        Me.PanelUsuario.Visible = False
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHora.Location = New System.Drawing.Point(115, 65)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(79, 18)
        Me.lbHora.TabIndex = 6
        Me.lbHora.Text = "USUARIO:"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(115, 42)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(79, 18)
        Me.lbFecha.TabIndex = 5
        Me.lbFecha.Text = "USUARIO:"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.Location = New System.Drawing.Point(115, 19)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(79, 18)
        Me.lbUsuario.TabIndex = 4
        Me.lbUsuario.Text = "USUARIO:"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(31, 65)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(60, 18)
        Me.lblHora.TabIndex = 2
        Me.lblHora.Text = "HORA:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(31, 43)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(68, 18)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "FECHA:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(31, 19)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(87, 18)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "USUARIO:"
        '
        'PanelSuperior
        '
        Me.PanelSuperior.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelSuperior.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.PanelSuperior.Controls.Add(Me.PanelToolBar1)
        Me.PanelSuperior.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1350, 72)
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
        Me.PanelSuperior.TabIndex = 4
        '
        'PanelToolBar1
        '
        Me.PanelToolBar1.Controls.Add(Me.btnSalir)
        Me.PanelToolBar1.Controls.Add(Me.btnGrabar)
        Me.PanelToolBar1.Controls.Add(Me.btnEliminar)
        Me.PanelToolBar1.Controls.Add(Me.btnModificar)
        Me.PanelToolBar1.Controls.Add(Me.btnNuevo)
        Me.PanelToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.PanelToolBar1.Name = "PanelToolBar1"
        Me.PanelToolBar1.Size = New System.Drawing.Size(376, 72)
        Me.PanelToolBar1.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Modelo.My.Resources.Resources.Salir5
        Me.btnSalir.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSalir.Location = New System.Drawing.Point(288, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 72)
        Me.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.TextColor = System.Drawing.Color.White
        '
        'btnGrabar
        '
        Me.btnGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGrabar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnGrabar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGrabar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = Global.Modelo.My.Resources.Resources.Guardar2
        Me.btnGrabar.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnGrabar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnGrabar.Location = New System.Drawing.Point(216, 0)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(72, 72)
        Me.btnGrabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGrabar.TabIndex = 9
        Me.btnGrabar.Text = "GRABAR"
        Me.btnGrabar.TextColor = System.Drawing.Color.White
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Modelo.My.Resources.Resources.trash
        Me.btnEliminar.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEliminar.Location = New System.Drawing.Point(144, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(72, 72)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.TextColor = System.Drawing.Color.White
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModificar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.Modelo.My.Resources.Resources.edit
        Me.btnModificar.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnModificar.Location = New System.Drawing.Point(72, 0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(72, 72)
        Me.btnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.TextColor = System.Drawing.Color.White
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNuevo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Modelo.My.Resources.Resources.add
        Me.btnNuevo.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnNuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 72)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.TextColor = System.Drawing.Color.White
        '
        'PanelInferior
        '
        Me.PanelInferior.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelInferior.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelInferior.Controls.Add(Me.MPanelUserAct)
        Me.PanelInferior.Controls.Add(Me.PanelNavegacion)
        Me.PanelInferior.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 655)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(1350, 39)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        Me.PanelInferior.TabIndex = 91
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Controls.Add(Me.BubbleBarUsuario)
        Me.MPanelUserAct.Controls.Add(Me.TxtNombreUsu)
        Me.MPanelUserAct.Dock = System.Windows.Forms.DockStyle.Right
        Me.MPanelUserAct.Location = New System.Drawing.Point(1150, 0)
        Me.MPanelUserAct.Name = "MPanelUserAct"
        Me.MPanelUserAct.Size = New System.Drawing.Size(200, 39)
        Me.MPanelUserAct.TabIndex = 21
        '
        'BubbleBarUsuario
        '
        Me.BubbleBarUsuario.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.BubbleBarUsuario.AntiAlias = True
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
        Me.BubbleBarUsuario.Dock = System.Windows.Forms.DockStyle.Left
        Me.BubbleBarUsuario.ImageSizeNormal = New System.Drawing.Size(24, 24)
        Me.BubbleBarUsuario.Location = New System.Drawing.Point(0, 0)
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.Name = "BubbleBarUsuario"
        Me.BubbleBarUsuario.SelectedTab = Me.BubbleBarTabUsuario
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBarUsuario.Size = New System.Drawing.Size(50, 39)
        Me.BubbleBarUsuario.TabIndex = 17
        Me.BubbleBarUsuario.Tabs.Add(Me.BubbleBarTabUsuario)
        Me.BubbleBarUsuario.TabsVisible = False
        Me.BubbleBarUsuario.Text = "BubbleBar5"
        '
        'BubbleBarTabUsuario
        '
        Me.BubbleBarTabUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTabUsuario.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTabUsuario.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.BubbleButton3})
        Me.BubbleBarTabUsuario.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTabUsuario.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTabUsuario.Name = "BubbleBarTabUsuario"
        Me.BubbleBarTabUsuario.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTabUsuario.Text = "BubbleBarTab3"
        Me.BubbleBarTabUsuario.TextColor = System.Drawing.Color.Black
        '
        'BubbleButton3
        '
        Me.BubbleButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BubbleButton3.Image = Global.Modelo.My.Resources.Resources.usuario
        Me.BubbleButton3.Name = "BubbleButton3"
        '
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreUsu.Location = New System.Drawing.Point(45, 9)
        Me.TxtNombreUsu.Multiline = True
        Me.TxtNombreUsu.Name = "TxtNombreUsu"
        Me.TxtNombreUsu.Size = New System.Drawing.Size(142, 22)
        Me.TxtNombreUsu.TabIndex = 16
        Me.TxtNombreUsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelNavegacion
        '
        Me.PanelNavegacion.Controls.Add(Me.LblPaginacion)
        Me.PanelNavegacion.Controls.Add(Me.btnUltimo)
        Me.PanelNavegacion.Controls.Add(Me.btnSiguiente)
        Me.PanelNavegacion.Controls.Add(Me.btnAnterior)
        Me.PanelNavegacion.Controls.Add(Me.btnPrimero)
        Me.PanelNavegacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelNavegacion.Location = New System.Drawing.Point(0, 0)
        Me.PanelNavegacion.Name = "PanelNavegacion"
        Me.PanelNavegacion.Size = New System.Drawing.Size(288, 39)
        Me.PanelNavegacion.TabIndex = 20
        '
        'LblPaginacion
        '
        Me.LblPaginacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPaginacion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaginacion.ForeColor = System.Drawing.Color.White
        Me.LblPaginacion.Location = New System.Drawing.Point(172, 0)
        Me.LblPaginacion.Name = "LblPaginacion"
        Me.LblPaginacion.Size = New System.Drawing.Size(116, 39)
        Me.LblPaginacion.TabIndex = 22
        Me.LblPaginacion.Text = "0/0"
        Me.LblPaginacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUltimo
        '
        Me.btnUltimo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUltimo.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnUltimo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnUltimo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnUltimo.Location = New System.Drawing.Point(129, 0)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(43, 39)
        Me.btnUltimo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnUltimo.TabIndex = 14
        '
        'btnSiguiente
        '
        Me.btnSiguiente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSiguiente.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnSiguiente.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSiguiente.Location = New System.Drawing.Point(86, 0)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(43, 39)
        Me.btnSiguiente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSiguiente.TabIndex = 13
        '
        'btnAnterior
        '
        Me.btnAnterior.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAnterior.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnAnterior.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnAnterior.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAnterior.Location = New System.Drawing.Point(43, 0)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(43, 39)
        Me.btnAnterior.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAnterior.TabIndex = 12
        '
        'btnPrimero
        '
        Me.btnPrimero.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrimero.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnPrimero.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Image = CType(resources.GetObject("btnPrimero.Image"), System.Drawing.Image)
        Me.btnPrimero.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnPrimero.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnPrimero.Location = New System.Drawing.Point(0, 0)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(43, 39)
        Me.btnPrimero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrimero.TabIndex = 11
        '
        'superTabItem1
        '
        Me.superTabItem1.AttachedControl = Me.superTabControlPanel1
        Me.superTabItem1.GlobalItem = False
        Me.superTabItem1.Name = "superTabItem1"
        Me.superTabItem1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.OfficeMobile2014Blue
        Me.superTabItem1.Text = "REGISTRO"
        '
        'superTabControlPanel2
        '
        Me.superTabControlPanel2.Controls.Add(Me.MpanelBuscador)
        Me.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.superTabControlPanel2.Name = "superTabControlPanel2"
        Me.superTabControlPanel2.Size = New System.Drawing.Size(1350, 694)
        Me.superTabControlPanel2.TabIndex = 2
        Me.superTabControlPanel2.TabItem = Me.superTabItem2
        '
        'MpanelBuscador
        '
        Me.MpanelBuscador.BackColor = System.Drawing.Color.White
        Me.MpanelBuscador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelBuscador.Location = New System.Drawing.Point(0, 0)
        Me.MpanelBuscador.Name = "MpanelBuscador"
        Me.MpanelBuscador.Size = New System.Drawing.Size(1350, 694)
        Me.MpanelBuscador.TabIndex = 104
        '
        'superTabItem2
        '
        Me.superTabItem2.AttachedControl = Me.superTabControlPanel2
        Me.superTabItem2.GlobalItem = False
        Me.superTabItem2.Name = "superTabItem2"
        Me.superTabItem2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.OfficeMobile2014Blue
        Me.superTabItem2.Text = "BUSCADOR"
        '
        'MEP
        '
        Me.MEP.ContainerControl = Me
        '
        'MHighlighterFocus
        '
        Me.MHighlighterFocus.ContainerControl = Me
        '
        'BBtnUsuario
        '
        Me.BBtnUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBtnUsuario.Image = Global.Modelo.My.Resources.Resources.usuario
        Me.BBtnUsuario.Name = "BBtnUsuario"
        '
        'BubbleButton1
        '
        Me.BubbleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BubbleButton1.Image = Global.Modelo.My.Resources.Resources.usuario
        Me.BubbleButton1.Name = "BubbleButton1"
        '
        'BubbleButton2
        '
        Me.BubbleButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BubbleButton2.Image = Global.Modelo.My.Resources.Resources.usuario
        Me.BubbleButton2.Name = "BubbleButton2"
        '
        'MFlyoutUsuario
        '
        Me.MFlyoutUsuario.DropShadow = False
        Me.MFlyoutUsuario.TargetControl = Me.BubbleBarUsuario
        '
        'ModeloF3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 719)
        Me.Controls.Add(Me.panel1)
        Me.KeyPreview = True
        Me.Name = "ModeloF3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModeloF3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.panel1.ResumeLayout(False)
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.superTabControl1.ResumeLayout(False)
        Me.superTabControlPanel1.ResumeLayout(False)
        Me.MpanelSuperior.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.superTabControlPanel2.ResumeLayout(False)
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents superTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Protected WithEvents MpanelSuperior As Panel
    Protected WithEvents PanelSuperior As DevComponents.DotNetBar.PanelEx
    Protected WithEvents PanelToolBar1 As Panel
    Protected WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnGrabar As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Protected WithEvents PanelInferior As DevComponents.DotNetBar.PanelEx
    Protected WithEvents MPanelUserAct As Panel
    Protected WithEvents PanelNavegacion As Panel
    Protected WithEvents LblPaginacion As Label
    Protected WithEvents btnUltimo As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnSiguiente As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnAnterior As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnPrimero As DevComponents.DotNetBar.ButtonX
    Private WithEvents superTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Protected WithEvents MpanelBuscador As Panel
    Protected WithEvents TxtNombreUsu As TextBox
    Protected WithEvents MEP As ErrorProvider
    Protected WithEvents MHighlighterFocus As DevComponents.DotNetBar.Validator.Highlighter
    Protected WithEvents BBtnUsuario As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents BubbleButton1 As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents BubbleButton2 As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents BubbleBarUsuario As DevComponents.DotNetBar.BubbleBar
    Protected WithEvents BubbleBarTabUsuario As DevComponents.DotNetBar.BubbleBarTab
    Protected WithEvents BubbleButton3 As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents MFlyoutUsuario As DevComponents.DotNetBar.Controls.Flyout
    Protected WithEvents PanelUsuario As Panel
    Protected WithEvents lbHora As Label
    Protected WithEvents lbFecha As Label
    Protected WithEvents lbUsuario As Label
    Protected WithEvents lblHora As Label
    Protected WithEvents lblFecha As Label
    Protected WithEvents lblUsuario As Label
    Public WithEvents superTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Public WithEvents superTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Public WithEvents superTabControl1 As DevComponents.DotNetBar.SuperTabControl
End Class
