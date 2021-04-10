<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F3_Personal
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
        Dim cbEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F3_Personal))
        Dim cbGenero_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbTipoDoc_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbEstCivil_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbTipoContrato_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbCargo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbDependecia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbTipoDocFlia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbGeneroFlia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btEstado = New DevComponents.DotNetBar.ButtonX()
        Me.cbEstado = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbGenero = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.dtFIng = New System.Windows.Forms.DateTimePicker()
        Me.dtFNac = New System.Windows.Forms.DateTimePicker()
        Me.PanelAgrImagen = New System.Windows.Forms.Panel()
        Me.ImgOpc = New DevComponents.DotNetBar.RadialMenu()
        Me.btnAgregar = New DevComponents.DotNetBar.RadialMenuItem()
        Me.btnElimImg = New DevComponents.DotNetBar.RadialMenuItem()
        Me.pbImg = New System.Windows.Forms.PictureBox()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.btTipoDoc = New DevComponents.DotNetBar.ButtonX()
        Me.cbTipoDoc = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.btEstadoCivil = New DevComponents.DotNetBar.ButtonX()
        Me.cbEstCivil = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.tbObs = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.tbEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.tbTelef2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.tbTelef1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.tbDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.tbNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.tbNroDoc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tbNumi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SuperTabControl_Imagenes_DetalleProducto = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grDetalleSueldos = New System.Windows.Forms.DataGridView()
        Me.SuperTabItem_Imagenes = New DevComponents.DotNetBar.SuperTabItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SuperTabControl2 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelInfo = New System.Windows.Forms.Panel()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grContrato = New Janus.Windows.GridEX.GridEX()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnExaminar = New DevComponents.DotNetBar.ButtonX()
        Me.btnAgregarCont = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevoCont = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.swEstadoCont = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.btTContrato = New DevComponents.DotNetBar.ButtonX()
        Me.cbTipoContrato = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.tbRutaContrato = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel5 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grCargo = New Janus.Windows.GridEX.GridEX()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnAgregarC = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevoC = New DevComponents.DotNetBar.ButtonX()
        Me.btCargo = New DevComponents.DotNetBar.ButtonX()
        Me.cbCargo = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX32 = New DevComponents.DotNetBar.LabelX()
        Me.swEstadoCargo = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX34 = New DevComponents.DotNetBar.LabelX()
        Me.dtFechaCargo = New System.Windows.Forms.DateTimePicker()
        Me.SuperTabItem5 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel6 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grFamilia = New Janus.Windows.GridEX.GridEX()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnAgregarF = New DevComponents.DotNetBar.ButtonX()
        Me.btnNuevoF = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX31 = New DevComponents.DotNetBar.LabelX()
        Me.tbNroDocFlia = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX()
        Me.btDependencia = New DevComponents.DotNetBar.ButtonX()
        Me.cbDependecia = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbTipoDocFlia = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX29 = New DevComponents.DotNetBar.LabelX()
        Me.cbGeneroFlia = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.swEstadoFlia = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX()
        Me.tbNombresFlia = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX()
        Me.dtFNacFlia = New System.Windows.Forms.DateTimePicker()
        Me.SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
        Me.GroupPanel7 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.grPersonal = New Janus.Windows.GridEX.GridEX()
        Me.cmEliminarSueldo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ELIMINARFILAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ConMenu_Opciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerRegistro = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.RLAccion = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.cmEliminarContrato = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarContrato = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmEliminarFamilia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarFamilia = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmEliminarCargo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarCargo = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.cbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAgrImagen.SuspendLayout()
        CType(Me.pbImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEstCivil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.SuperTabControl_Imagenes_DetalleProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl_Imagenes_DetalleProducto.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grDetalleSueldos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SuperTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl2.SuspendLayout()
        Me.SuperTabControlPanel4.SuspendLayout()
        Me.PanelInfo.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.grContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.cbTipoContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupPanel6.SuspendLayout()
        CType(Me.grCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.cbCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel6.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        CType(Me.grFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.cbDependecia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoDocFlia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGeneroFlia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.grPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmEliminarSueldo.SuspendLayout()
        Me.ConMenu_Opciones.SuspendLayout()
        Me.cmEliminarContrato.SuspendLayout()
        Me.cmEliminarFamilia.SuspendLayout()
        Me.cmEliminarCargo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.TableLayoutPanel1)
        Me.MpanelSuperior.Size = New System.Drawing.Size(1350, 605)
        Me.MpanelSuperior.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.MpanelSuperior.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
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
        '
        'btnUltimo
        '
        '
        'btnSiguiente
        '
        '
        'btnAnterior
        '
        '
        'btnPrimero
        '
        '
        'MpanelBuscador
        '
        Me.MpanelBuscador.Controls.Add(Me.GroupPanel7)
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
        Me.superTabControl1.SelectedTabIndex = 1
        Me.superTabControl1.Size = New System.Drawing.Size(1350, 741)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1350, 605)
        Me.TableLayoutPanel1.TabIndex = 229
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel3)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(480, 599)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText
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
        Me.GroupPanel1.TabIndex = 227
        Me.GroupPanel1.Text = "DATOS GENERALES"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.btEstado)
        Me.Panel3.Controls.Add(Me.cbEstado)
        Me.Panel3.Controls.Add(Me.cbGenero)
        Me.Panel3.Controls.Add(Me.LabelX4)
        Me.Panel3.Controls.Add(Me.LabelX12)
        Me.Panel3.Controls.Add(Me.LabelX13)
        Me.Panel3.Controls.Add(Me.dtFIng)
        Me.Panel3.Controls.Add(Me.dtFNac)
        Me.Panel3.Controls.Add(Me.PanelAgrImagen)
        Me.Panel3.Controls.Add(Me.pbImg)
        Me.Panel3.Controls.Add(Me.LabelX10)
        Me.Panel3.Controls.Add(Me.btTipoDoc)
        Me.Panel3.Controls.Add(Me.cbTipoDoc)
        Me.Panel3.Controls.Add(Me.LabelX20)
        Me.Panel3.Controls.Add(Me.btEstadoCivil)
        Me.Panel3.Controls.Add(Me.cbEstCivil)
        Me.Panel3.Controls.Add(Me.LabelX16)
        Me.Panel3.Controls.Add(Me.LabelX15)
        Me.Panel3.Controls.Add(Me.tbObs)
        Me.Panel3.Controls.Add(Me.LabelX8)
        Me.Panel3.Controls.Add(Me.tbEmail)
        Me.Panel3.Controls.Add(Me.LabelX7)
        Me.Panel3.Controls.Add(Me.tbTelef2)
        Me.Panel3.Controls.Add(Me.LabelX6)
        Me.Panel3.Controls.Add(Me.tbTelef1)
        Me.Panel3.Controls.Add(Me.LabelX5)
        Me.Panel3.Controls.Add(Me.tbDireccion)
        Me.Panel3.Controls.Add(Me.LabelX3)
        Me.Panel3.Controls.Add(Me.tbNombre)
        Me.Panel3.Controls.Add(Me.LabelX2)
        Me.Panel3.Controls.Add(Me.tbNroDoc)
        Me.Panel3.Controls.Add(Me.LabelX1)
        Me.Panel3.Controls.Add(Me.tbNumi)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(474, 576)
        Me.Panel3.TabIndex = 227
        '
        'btEstado
        '
        Me.btEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEstado.BackColor = System.Drawing.Color.Transparent
        Me.btEstado.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btEstado.Image = Global.ReHu.My.Resources.Resources.add
        Me.btEstado.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btEstado.Location = New System.Drawing.Point(242, 41)
        Me.btEstado.Name = "btEstado"
        Me.btEstado.Size = New System.Drawing.Size(28, 23)
        Me.btEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btEstado.TabIndex = 225
        Me.btEstado.Visible = False
        '
        'cbEstado
        '
        cbEstado_DesignTimeLayout.LayoutString = resources.GetString("cbEstado_DesignTimeLayout.LayoutString")
        Me.cbEstado.DesignTimeLayout = cbEstado_DesignTimeLayout
        Me.cbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.Location = New System.Drawing.Point(93, 42)
        Me.cbEstado.MaxLength = 40
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbEstado.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbEstado.SelectedIndex = -1
        Me.cbEstado.SelectedItem = Nothing
        Me.cbEstado.Size = New System.Drawing.Size(144, 22)
        Me.cbEstado.TabIndex = 2
        Me.cbEstado.TabStop = False
        Me.cbEstado.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cbGenero
        '
        cbGenero_DesignTimeLayout.LayoutString = resources.GetString("cbGenero_DesignTimeLayout.LayoutString")
        Me.cbGenero.DesignTimeLayout = cbGenero_DesignTimeLayout
        Me.cbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGenero.Location = New System.Drawing.Point(95, 348)
        Me.cbGenero.MaxLength = 40
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbGenero.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbGenero.SelectedIndex = -1
        Me.cbGenero.SelectedItem = Nothing
        Me.cbGenero.Size = New System.Drawing.Size(143, 22)
        Me.cbGenero.TabIndex = 12
        Me.cbGenero.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(5, 347)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(68, 23)
        Me.LabelX4.TabIndex = 223
        Me.LabelX4.Text = "GÉNERO:"
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.Location = New System.Drawing.Point(5, 169)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(86, 23)
        Me.LabelX12.TabIndex = 221
        Me.LabelX12.Text = "FECHA ING.:"
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.Location = New System.Drawing.Point(5, 138)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(86, 23)
        Me.LabelX13.TabIndex = 220
        Me.LabelX13.Text = "FECHA NAC.:"
        '
        'dtFIng
        '
        Me.dtFIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFIng.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFIng.Location = New System.Drawing.Point(95, 169)
        Me.dtFIng.Name = "dtFIng"
        Me.dtFIng.Size = New System.Drawing.Size(143, 22)
        Me.dtFIng.TabIndex = 6
        '
        'dtFNac
        '
        Me.dtFNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFNac.Location = New System.Drawing.Point(95, 138)
        Me.dtFNac.Name = "dtFNac"
        Me.dtFNac.Size = New System.Drawing.Size(143, 22)
        Me.dtFNac.TabIndex = 5
        '
        'PanelAgrImagen
        '
        Me.PanelAgrImagen.BackColor = System.Drawing.Color.Transparent
        Me.PanelAgrImagen.Controls.Add(Me.ImgOpc)
        Me.PanelAgrImagen.Location = New System.Drawing.Point(279, 8)
        Me.PanelAgrImagen.Name = "PanelAgrImagen"
        Me.PanelAgrImagen.Size = New System.Drawing.Size(39, 35)
        Me.PanelAgrImagen.TabIndex = 215
        '
        'ImgOpc
        '
        Me.ImgOpc.CenterButtonDiameter = 40
        Me.ImgOpc.Diameter = 200
        Me.ImgOpc.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnAgregar, Me.btnElimImg})
        Me.ImgOpc.Location = New System.Drawing.Point(5, 4)
        Me.ImgOpc.Name = "ImgOpc"
        Me.ImgOpc.Size = New System.Drawing.Size(28, 28)
        Me.ImgOpc.Symbol = ""
        Me.ImgOpc.SymbolSize = 23.0!
        Me.ImgOpc.TabIndex = 0
        Me.ImgOpc.Text = "RadialMenu1"
        '
        'btnAgregar
        '
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Symbol = ""
        Me.btnAgregar.Text = "Agregar"
        '
        'btnElimImg
        '
        Me.btnElimImg.Name = "btnElimImg"
        Me.btnElimImg.Symbol = ""
        Me.btnElimImg.Text = "Eliminar"
        '
        'pbImg
        '
        Me.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbImg.Location = New System.Drawing.Point(321, 7)
        Me.pbImg.Name = "pbImg"
        Me.pbImg.Size = New System.Drawing.Size(142, 153)
        Me.pbImg.TabIndex = 214
        Me.pbImg.TabStop = False
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(5, 74)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(75, 23)
        Me.LabelX10.TabIndex = 213
        Me.LabelX10.Text = "TIPO DOC."
        '
        'btTipoDoc
        '
        Me.btTipoDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btTipoDoc.BackColor = System.Drawing.Color.Transparent
        Me.btTipoDoc.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btTipoDoc.Image = Global.ReHu.My.Resources.Resources.add
        Me.btTipoDoc.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btTipoDoc.Location = New System.Drawing.Point(243, 74)
        Me.btTipoDoc.Name = "btTipoDoc"
        Me.btTipoDoc.Size = New System.Drawing.Size(28, 23)
        Me.btTipoDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btTipoDoc.TabIndex = 212
        Me.btTipoDoc.Visible = False
        '
        'cbTipoDoc
        '
        cbTipoDoc_DesignTimeLayout.LayoutString = resources.GetString("cbTipoDoc_DesignTimeLayout.LayoutString")
        Me.cbTipoDoc.DesignTimeLayout = cbTipoDoc_DesignTimeLayout
        Me.cbTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoDoc.Location = New System.Drawing.Point(94, 75)
        Me.cbTipoDoc.MaxLength = 40
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTipoDoc.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTipoDoc.SelectedIndex = -1
        Me.cbTipoDoc.SelectedItem = Nothing
        Me.cbTipoDoc.Size = New System.Drawing.Size(144, 22)
        Me.cbTipoDoc.TabIndex = 3
        Me.cbTipoDoc.TabStop = False
        Me.cbTipoDoc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX20
        '
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX20.Location = New System.Drawing.Point(7, 405)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(79, 23)
        Me.LabelX20.TabIndex = 134
        Me.LabelX20.Text = "OBS.:"
        '
        'btEstadoCivil
        '
        Me.btEstadoCivil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEstadoCivil.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btEstadoCivil.Image = Global.ReHu.My.Resources.Resources.add
        Me.btEstadoCivil.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btEstadoCivil.Location = New System.Drawing.Point(242, 316)
        Me.btEstadoCivil.Name = "btEstadoCivil"
        Me.btEstadoCivil.Size = New System.Drawing.Size(28, 23)
        Me.btEstadoCivil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btEstadoCivil.TabIndex = 130
        Me.btEstadoCivil.Visible = False
        '
        'cbEstCivil
        '
        cbEstCivil_DesignTimeLayout.LayoutString = resources.GetString("cbEstCivil_DesignTimeLayout.LayoutString")
        Me.cbEstCivil.DesignTimeLayout = cbEstCivil_DesignTimeLayout
        Me.cbEstCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstCivil.Location = New System.Drawing.Point(95, 319)
        Me.cbEstCivil.MaxLength = 40
        Me.cbEstCivil.Name = "cbEstCivil"
        Me.cbEstCivil.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbEstCivil.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbEstCivil.SelectedIndex = -1
        Me.cbEstCivil.SelectedItem = Nothing
        Me.cbEstCivil.Size = New System.Drawing.Size(143, 22)
        Me.cbEstCivil.TabIndex = 11
        Me.cbEstCivil.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX16
        '
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.Location = New System.Drawing.Point(5, 319)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(79, 23)
        Me.LabelX16.TabIndex = 128
        Me.LabelX16.Text = "EST. CIVIL :"
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.Location = New System.Drawing.Point(5, 40)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(75, 23)
        Me.LabelX15.TabIndex = 126
        Me.LabelX15.Text = "ESTADO:"
        '
        'tbObs
        '
        '
        '
        '
        Me.tbObs.Border.Class = "TextBoxBorder"
        Me.tbObs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObs.Location = New System.Drawing.Point(95, 405)
        Me.tbObs.MaxLength = 300
        Me.tbObs.Multiline = True
        Me.tbObs.Name = "tbObs"
        Me.tbObs.PreventEnterBeep = True
        Me.tbObs.Size = New System.Drawing.Size(360, 48)
        Me.tbObs.TabIndex = 14
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(6, 376)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(65, 23)
        Me.LabelX8.TabIndex = 123
        Me.LabelX8.Text = "E-MAIL:"
        '
        'tbEmail
        '
        '
        '
        '
        Me.tbEmail.Border.Class = "TextBoxBorder"
        Me.tbEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(95, 377)
        Me.tbEmail.MaxLength = 100
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.PreventEnterBeep = True
        Me.tbEmail.Size = New System.Drawing.Size(360, 22)
        Me.tbEmail.TabIndex = 13
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(6, 288)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(65, 23)
        Me.LabelX7.TabIndex = 122
        Me.LabelX7.Text = "CELULAR:"
        '
        'tbTelef2
        '
        '
        '
        '
        Me.tbTelef2.Border.Class = "TextBoxBorder"
        Me.tbTelef2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTelef2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelef2.Location = New System.Drawing.Point(94, 289)
        Me.tbTelef2.MaxLength = 20
        Me.tbTelef2.Name = "tbTelef2"
        Me.tbTelef2.PreventEnterBeep = True
        Me.tbTelef2.Size = New System.Drawing.Size(144, 22)
        Me.tbTelef2.TabIndex = 10
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(6, 260)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 121
        Me.LabelX6.Text = "TELÉFONO:"
        '
        'tbTelef1
        '
        '
        '
        '
        Me.tbTelef1.Border.Class = "TextBoxBorder"
        Me.tbTelef1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTelef1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelef1.Location = New System.Drawing.Point(95, 261)
        Me.tbTelef1.MaxLength = 20
        Me.tbTelef1.Name = "tbTelef1"
        Me.tbTelef1.PreventEnterBeep = True
        Me.tbTelef1.Size = New System.Drawing.Size(143, 22)
        Me.tbTelef1.TabIndex = 9
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(6, 232)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(78, 23)
        Me.LabelX5.TabIndex = 120
        Me.LabelX5.Text = "DIRECCIÓN:"
        '
        'tbDireccion
        '
        '
        '
        '
        Me.tbDireccion.Border.Class = "TextBoxBorder"
        Me.tbDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(94, 232)
        Me.tbDireccion.MaxLength = 300
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.PreventEnterBeep = True
        Me.tbDireccion.Size = New System.Drawing.Size(363, 22)
        Me.tbDireccion.TabIndex = 8
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(5, 200)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 118
        Me.LabelX3.Text = "NOMBRES:"
        '
        'tbNombre
        '
        '
        '
        '
        Me.tbNombre.Border.Class = "TextBoxBorder"
        Me.tbNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(94, 200)
        Me.tbNombre.MaxLength = 100
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.PreventEnterBeep = True
        Me.tbNombre.Size = New System.Drawing.Size(361, 22)
        Me.tbNombre.TabIndex = 7
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(5, 107)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 117
        Me.LabelX2.Text = "NRO. DOC.:"
        '
        'tbNroDoc
        '
        '
        '
        '
        Me.tbNroDoc.Border.Class = "TextBoxBorder"
        Me.tbNroDoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNroDoc.Location = New System.Drawing.Point(94, 107)
        Me.tbNroDoc.MaxLength = 20
        Me.tbNroDoc.Name = "tbNroDoc"
        Me.tbNroDoc.PreventEnterBeep = True
        Me.tbNroDoc.Size = New System.Drawing.Size(143, 22)
        Me.tbNroDoc.TabIndex = 4
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(5, 7)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 116
        Me.LabelX1.Text = "COD:"
        '
        'tbNumi
        '
        '
        '
        '
        Me.tbNumi.Border.Class = "TextBoxBorder"
        Me.tbNumi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNumi.Enabled = False
        Me.tbNumi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNumi.Location = New System.Drawing.Point(93, 10)
        Me.tbNumi.Name = "tbNumi"
        Me.tbNumi.PreventEnterBeep = True
        Me.tbNumi.Size = New System.Drawing.Size(143, 22)
        Me.tbNumi.TabIndex = 1
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.SuperTabControl_Imagenes_DetalleProducto)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(921, 3)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(426, 599)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText
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
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
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
        Me.GroupPanel3.TabIndex = 229
        '
        'SuperTabControl_Imagenes_DetalleProducto
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl_Imagenes_DetalleProducto.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl_Imagenes_DetalleProducto.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl_Imagenes_DetalleProducto.ControlBox.Name = ""
        Me.SuperTabControl_Imagenes_DetalleProducto.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl_Imagenes_DetalleProducto.ControlBox.MenuBox, Me.SuperTabControl_Imagenes_DetalleProducto.ControlBox.CloseBox})
        Me.SuperTabControl_Imagenes_DetalleProducto.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl_Imagenes_DetalleProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl_Imagenes_DetalleProducto.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl_Imagenes_DetalleProducto.Name = "SuperTabControl_Imagenes_DetalleProducto"
        Me.SuperTabControl_Imagenes_DetalleProducto.ReorderTabsEnabled = True
        Me.SuperTabControl_Imagenes_DetalleProducto.SelectedTabFont = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl_Imagenes_DetalleProducto.SelectedTabIndex = 0
        Me.SuperTabControl_Imagenes_DetalleProducto.Size = New System.Drawing.Size(420, 593)
        Me.SuperTabControl_Imagenes_DetalleProducto.TabFont = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl_Imagenes_DetalleProducto.TabIndex = 224
        Me.SuperTabControl_Imagenes_DetalleProducto.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem_Imagenes})
        Me.SuperTabControl_Imagenes_DetalleProducto.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.Panel2)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(420, 566)
        Me.SuperTabControlPanel3.TabIndex = 1
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem_Imagenes
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.grDetalleSueldos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(420, 566)
        Me.Panel2.TabIndex = 223
        '
        'grDetalleSueldos
        '
        Me.grDetalleSueldos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grDetalleSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grDetalleSueldos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grDetalleSueldos.Location = New System.Drawing.Point(0, 0)
        Me.grDetalleSueldos.Name = "grDetalleSueldos"
        Me.grDetalleSueldos.Size = New System.Drawing.Size(420, 566)
        Me.grDetalleSueldos.TabIndex = 100
        '
        'SuperTabItem_Imagenes
        '
        Me.SuperTabItem_Imagenes.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem_Imagenes.GlobalItem = False
        Me.SuperTabItem_Imagenes.Name = "SuperTabItem_Imagenes"
        Me.SuperTabItem_Imagenes.Text = "HISTORIAL DE SUELDOS"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Panel4)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(489, 3)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(426, 599)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedShadow
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
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
        Me.GroupPanel2.TabIndex = 228
        Me.GroupPanel2.Text = "DATOS COMPLEMENTARIOS"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.SuperTabControl2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(420, 576)
        Me.Panel4.TabIndex = 216
        '
        'SuperTabControl2
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl2.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl2.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl2.ControlBox.Name = ""
        Me.SuperTabControl2.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl2.ControlBox.MenuBox, Me.SuperTabControl2.ControlBox.CloseBox})
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel5)
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel6)
        Me.SuperTabControl2.Location = New System.Drawing.Point(8, 2)
        Me.SuperTabControl2.Name = "SuperTabControl2"
        Me.SuperTabControl2.ReorderTabsEnabled = True
        Me.SuperTabControl2.SelectedTabFont = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl2.SelectedTabIndex = 0
        Me.SuperTabControl2.Size = New System.Drawing.Size(402, 545)
        Me.SuperTabControl2.TabFont = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl2.TabIndex = 105
        Me.SuperTabControl2.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem3, Me.SuperTabItem4, Me.SuperTabItem5})
        Me.SuperTabControl2.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl2.Text = "Descuento"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.Controls.Add(Me.PanelInfo)
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(402, 518)
        Me.SuperTabControlPanel4.TabIndex = 1
        Me.SuperTabControlPanel4.TabItem = Me.SuperTabItem3
        '
        'PanelInfo
        '
        Me.PanelInfo.Controls.Add(Me.GroupPanel4)
        Me.PanelInfo.Controls.Add(Me.Panel5)
        Me.PanelInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelInfo.Location = New System.Drawing.Point(0, 0)
        Me.PanelInfo.Name = "PanelInfo"
        Me.PanelInfo.Size = New System.Drawing.Size(402, 518)
        Me.PanelInfo.TabIndex = 0
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GroupPanel4.Controls.Add(Me.grContrato)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 210)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(402, 308)
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
        Me.GroupPanel4.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.GroupPanel4.TabIndex = 46
        Me.GroupPanel4.Text = "B U S C A D O R"
        '
        'grContrato
        '
        Me.grContrato.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grContrato.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grContrato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grContrato.FlatBorderColor = System.Drawing.Color.AliceBlue
        Me.grContrato.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grContrato.HeaderFormatStyle.Alpha = 0
        Me.grContrato.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.grContrato.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grContrato.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grContrato.Location = New System.Drawing.Point(0, 0)
        Me.grContrato.Name = "grContrato"
        Me.grContrato.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grContrato.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grContrato.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.grContrato.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grContrato.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.grContrato.Size = New System.Drawing.Size(396, 285)
        Me.grContrato.TabIndex = 0
        Me.grContrato.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnExaminar)
        Me.Panel5.Controls.Add(Me.btnAgregarCont)
        Me.Panel5.Controls.Add(Me.btnNuevoCont)
        Me.Panel5.Controls.Add(Me.LabelX18)
        Me.Panel5.Controls.Add(Me.swEstadoCont)
        Me.Panel5.Controls.Add(Me.btTContrato)
        Me.Panel5.Controls.Add(Me.cbTipoContrato)
        Me.Panel5.Controls.Add(Me.LabelX14)
        Me.Panel5.Controls.Add(Me.LabelX9)
        Me.Panel5.Controls.Add(Me.tbRutaContrato)
        Me.Panel5.Controls.Add(Me.LabelX17)
        Me.Panel5.Controls.Add(Me.dtFechaFin)
        Me.Panel5.Controls.Add(Me.dtFechaIni)
        Me.Panel5.Controls.Add(Me.LabelX19)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(402, 210)
        Me.Panel5.TabIndex = 47
        '
        'btnExaminar
        '
        Me.btnExaminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExaminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnExaminar.Image = Global.ReHu.My.Resources.Resources.folder
        Me.btnExaminar.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnExaminar.Location = New System.Drawing.Point(129, 60)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(38, 28)
        Me.btnExaminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExaminar.TabIndex = 264
        '
        'btnAgregarCont
        '
        Me.btnAgregarCont.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarCont.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarCont.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarCont.FadeEffect = False
        Me.btnAgregarCont.FocusCuesEnabled = False
        Me.btnAgregarCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCont.Image = Global.ReHu.My.Resources.Resources.save
        Me.btnAgregarCont.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarCont.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarCont.Location = New System.Drawing.Point(211, 158)
        Me.btnAgregarCont.Name = "btnAgregarCont"
        Me.btnAgregarCont.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarCont.Size = New System.Drawing.Size(107, 40)
        Me.btnAgregarCont.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAgregarCont.TabIndex = 263
        Me.btnAgregarCont.Text = "AGREGAR"
        '
        'btnNuevoCont
        '
        Me.btnNuevoCont.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevoCont.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoCont.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnNuevoCont.FadeEffect = False
        Me.btnNuevoCont.FocusCuesEnabled = False
        Me.btnNuevoCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCont.Image = Global.ReHu.My.Resources.Resources.add2
        Me.btnNuevoCont.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnNuevoCont.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNuevoCont.Location = New System.Drawing.Point(78, 158)
        Me.btnNuevoCont.Name = "btnNuevoCont"
        Me.btnNuevoCont.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnNuevoCont.Size = New System.Drawing.Size(107, 40)
        Me.btnNuevoCont.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevoCont.TabIndex = 261
        Me.btnNuevoCont.Text = "NUEVO"
        '
        'LabelX18
        '
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.Location = New System.Drawing.Point(5, 125)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(115, 23)
        Me.LabelX18.TabIndex = 260
        Me.LabelX18.Text = "ESTADO:"
        '
        'swEstadoCont
        '
        '
        '
        '
        Me.swEstadoCont.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swEstadoCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swEstadoCont.Location = New System.Drawing.Point(133, 125)
        Me.swEstadoCont.Name = "swEstadoCont"
        Me.swEstadoCont.OffBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.swEstadoCont.OffText = "PASIVO"
        Me.swEstadoCont.OffTextColor = System.Drawing.Color.White
        Me.swEstadoCont.OnBackColor = System.Drawing.Color.Blue
        Me.swEstadoCont.OnText = "ACTIVO"
        Me.swEstadoCont.OnTextColor = System.Drawing.Color.White
        Me.swEstadoCont.Size = New System.Drawing.Size(136, 22)
        Me.swEstadoCont.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swEstadoCont.TabIndex = 259
        Me.swEstadoCont.TabStop = False
        Me.swEstadoCont.Value = True
        Me.swEstadoCont.ValueObject = "Y"
        '
        'btTContrato
        '
        Me.btTContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btTContrato.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btTContrato.Image = Global.ReHu.My.Resources.Resources.add
        Me.btTContrato.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btTContrato.Location = New System.Drawing.Point(315, 91)
        Me.btTContrato.Name = "btTContrato"
        Me.btTContrato.Size = New System.Drawing.Size(34, 29)
        Me.btTContrato.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btTContrato.TabIndex = 258
        Me.btTContrato.Visible = False
        '
        'cbTipoContrato
        '
        cbTipoContrato_DesignTimeLayout.LayoutString = resources.GetString("cbTipoContrato_DesignTimeLayout.LayoutString")
        Me.cbTipoContrato.DesignTimeLayout = cbTipoContrato_DesignTimeLayout
        Me.cbTipoContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoContrato.Location = New System.Drawing.Point(133, 94)
        Me.cbTipoContrato.MaxLength = 40
        Me.cbTipoContrato.Name = "cbTipoContrato"
        Me.cbTipoContrato.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTipoContrato.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTipoContrato.SelectedIndex = -1
        Me.cbTipoContrato.SelectedItem = Nothing
        Me.cbTipoContrato.Size = New System.Drawing.Size(176, 22)
        Me.cbTipoContrato.TabIndex = 23
        Me.cbTipoContrato.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.Location = New System.Drawing.Point(5, 95)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(115, 23)
        Me.LabelX14.TabIndex = 257
        Me.LabelX14.Text = "TIPO CONTRATO :"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(5, 62)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(122, 23)
        Me.LabelX9.TabIndex = 255
        Me.LabelX9.Text = "RUTA CONTRATO:"
        '
        'tbRutaContrato
        '
        '
        '
        '
        Me.tbRutaContrato.Border.Class = "TextBoxBorder"
        Me.tbRutaContrato.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbRutaContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRutaContrato.Location = New System.Drawing.Point(169, 62)
        Me.tbRutaContrato.MaxLength = 900
        Me.tbRutaContrato.Name = "tbRutaContrato"
        Me.tbRutaContrato.PreventEnterBeep = True
        Me.tbRutaContrato.Size = New System.Drawing.Size(205, 22)
        Me.tbRutaContrato.TabIndex = 22
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.Location = New System.Drawing.Point(5, 6)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(115, 23)
        Me.LabelX17.TabIndex = 252
        Me.LabelX17.Text = "FECHA INICIO:"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(133, 35)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(122, 22)
        Me.dtFechaFin.TabIndex = 21
        '
        'dtFechaIni
        '
        Me.dtFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIni.Location = New System.Drawing.Point(133, 7)
        Me.dtFechaIni.Name = "dtFechaIni"
        Me.dtFechaIni.Size = New System.Drawing.Size(122, 22)
        Me.dtFechaIni.TabIndex = 20
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.Location = New System.Drawing.Point(5, 32)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(109, 23)
        Me.LabelX19.TabIndex = 253
        Me.LabelX19.Text = "FECHA FIN:"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel4
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Info. Contrato"
        '
        'SuperTabControlPanel5
        '
        Me.SuperTabControlPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.SuperTabControlPanel5.Controls.Add(Me.Panel7)
        Me.SuperTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel5.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel5.Name = "SuperTabControlPanel5"
        Me.SuperTabControlPanel5.Size = New System.Drawing.Size(402, 518)
        Me.SuperTabControlPanel5.TabIndex = 2
        Me.SuperTabControlPanel5.TabItem = Me.SuperTabItem5
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GroupPanel6)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(402, 518)
        Me.Panel7.TabIndex = 2
        '
        'GroupPanel6
        '
        Me.GroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GroupPanel6.Controls.Add(Me.grCargo)
        Me.GroupPanel6.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel6.Location = New System.Drawing.Point(0, 200)
        Me.GroupPanel6.Name = "GroupPanel6"
        Me.GroupPanel6.Size = New System.Drawing.Size(402, 318)
        '
        '
        '
        Me.GroupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel6.Style.BackColorGradientAngle = 90
        Me.GroupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderBottomWidth = 1
        Me.GroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderLeftWidth = 1
        Me.GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderRightWidth = 1
        Me.GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderTopWidth = 1
        Me.GroupPanel6.Style.CornerDiameter = 4
        Me.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel6.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel6.TabIndex = 46
        Me.GroupPanel6.Text = "B U S C A D O R"
        '
        'grCargo
        '
        Me.grCargo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grCargo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grCargo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grCargo.FlatBorderColor = System.Drawing.Color.AliceBlue
        Me.grCargo.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grCargo.HeaderFormatStyle.Alpha = 0
        Me.grCargo.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.grCargo.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grCargo.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grCargo.Location = New System.Drawing.Point(0, 0)
        Me.grCargo.Name = "grCargo"
        Me.grCargo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grCargo.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grCargo.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.grCargo.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grCargo.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.grCargo.Size = New System.Drawing.Size(396, 295)
        Me.grCargo.TabIndex = 0
        Me.grCargo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnAgregarC)
        Me.Panel8.Controls.Add(Me.btnNuevoC)
        Me.Panel8.Controls.Add(Me.btCargo)
        Me.Panel8.Controls.Add(Me.cbCargo)
        Me.Panel8.Controls.Add(Me.LabelX27)
        Me.Panel8.Controls.Add(Me.LabelX32)
        Me.Panel8.Controls.Add(Me.swEstadoCargo)
        Me.Panel8.Controls.Add(Me.LabelX34)
        Me.Panel8.Controls.Add(Me.dtFechaCargo)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(402, 200)
        Me.Panel8.TabIndex = 47
        '
        'btnAgregarC
        '
        Me.btnAgregarC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarC.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarC.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarC.FadeEffect = False
        Me.btnAgregarC.FocusCuesEnabled = False
        Me.btnAgregarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarC.Image = Global.ReHu.My.Resources.Resources.save
        Me.btnAgregarC.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarC.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarC.Location = New System.Drawing.Point(219, 125)
        Me.btnAgregarC.Name = "btnAgregarC"
        Me.btnAgregarC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarC.Size = New System.Drawing.Size(107, 40)
        Me.btnAgregarC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAgregarC.TabIndex = 274
        Me.btnAgregarC.Text = "AGREGAR"
        '
        'btnNuevoC
        '
        Me.btnNuevoC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevoC.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoC.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnNuevoC.FadeEffect = False
        Me.btnNuevoC.FocusCuesEnabled = False
        Me.btnNuevoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoC.Image = Global.ReHu.My.Resources.Resources.add2
        Me.btnNuevoC.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnNuevoC.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNuevoC.Location = New System.Drawing.Point(73, 125)
        Me.btnNuevoC.Name = "btnNuevoC"
        Me.btnNuevoC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnNuevoC.Size = New System.Drawing.Size(107, 40)
        Me.btnNuevoC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevoC.TabIndex = 272
        Me.btnNuevoC.Text = "NUEVO"
        '
        'btCargo
        '
        Me.btCargo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCargo.BackColor = System.Drawing.Color.Transparent
        Me.btCargo.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btCargo.Image = Global.ReHu.My.Resources.Resources.add
        Me.btCargo.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btCargo.Location = New System.Drawing.Point(264, 44)
        Me.btCargo.Name = "btCargo"
        Me.btCargo.Size = New System.Drawing.Size(28, 23)
        Me.btCargo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btCargo.TabIndex = 266
        Me.btCargo.Visible = False
        '
        'cbCargo
        '
        cbCargo_DesignTimeLayout.LayoutString = resources.GetString("cbCargo_DesignTimeLayout.LayoutString")
        Me.cbCargo.DesignTimeLayout = cbCargo_DesignTimeLayout
        Me.cbCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCargo.Location = New System.Drawing.Point(115, 45)
        Me.cbCargo.MaxLength = 40
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbCargo.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbCargo.SelectedIndex = -1
        Me.cbCargo.SelectedItem = Nothing
        Me.cbCargo.Size = New System.Drawing.Size(144, 22)
        Me.cbCargo.TabIndex = 41
        Me.cbCargo.TabStop = False
        Me.cbCargo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX27
        '
        '
        '
        '
        Me.LabelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX27.Location = New System.Drawing.Point(5, 44)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(75, 23)
        Me.LabelX27.TabIndex = 264
        Me.LabelX27.Text = "CARGO:"
        '
        'LabelX32
        '
        '
        '
        '
        Me.LabelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX32.Location = New System.Drawing.Point(5, 77)
        Me.LabelX32.Name = "LabelX32"
        Me.LabelX32.Size = New System.Drawing.Size(89, 23)
        Me.LabelX32.TabIndex = 260
        Me.LabelX32.Text = "ESTADO:"
        '
        'swEstadoCargo
        '
        '
        '
        '
        Me.swEstadoCargo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swEstadoCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swEstadoCargo.Location = New System.Drawing.Point(115, 77)
        Me.swEstadoCargo.Name = "swEstadoCargo"
        Me.swEstadoCargo.OffBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.swEstadoCargo.OffText = "PASIVO"
        Me.swEstadoCargo.OffTextColor = System.Drawing.Color.White
        Me.swEstadoCargo.OnBackColor = System.Drawing.Color.Blue
        Me.swEstadoCargo.OnText = "ACTIVO"
        Me.swEstadoCargo.OnTextColor = System.Drawing.Color.White
        Me.swEstadoCargo.Size = New System.Drawing.Size(136, 22)
        Me.swEstadoCargo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swEstadoCargo.TabIndex = 259
        Me.swEstadoCargo.TabStop = False
        Me.swEstadoCargo.Value = True
        Me.swEstadoCargo.ValueObject = "Y"
        '
        'LabelX34
        '
        Me.LabelX34.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.LabelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX34.Location = New System.Drawing.Point(5, 14)
        Me.LabelX34.Name = "LabelX34"
        Me.LabelX34.Size = New System.Drawing.Size(89, 23)
        Me.LabelX34.TabIndex = 252
        Me.LabelX34.Text = "FECHA:"
        '
        'dtFechaCargo
        '
        Me.dtFechaCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaCargo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaCargo.Location = New System.Drawing.Point(115, 15)
        Me.dtFechaCargo.Name = "dtFechaCargo"
        Me.dtFechaCargo.Size = New System.Drawing.Size(122, 22)
        Me.dtFechaCargo.TabIndex = 40
        '
        'SuperTabItem5
        '
        Me.SuperTabItem5.AttachedControl = Me.SuperTabControlPanel5
        Me.SuperTabItem5.GlobalItem = False
        Me.SuperTabItem5.Name = "SuperTabItem5"
        Me.SuperTabItem5.Text = "Info. Cargo"
        '
        'SuperTabControlPanel6
        '
        Me.SuperTabControlPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.SuperTabControlPanel6.Controls.Add(Me.Panel6)
        Me.SuperTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel6.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel6.Name = "SuperTabControlPanel6"
        Me.SuperTabControlPanel6.Size = New System.Drawing.Size(402, 518)
        Me.SuperTabControlPanel6.TabIndex = 0
        Me.SuperTabControlPanel6.TabItem = Me.SuperTabItem4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupPanel5)
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(402, 518)
        Me.Panel6.TabIndex = 1
        '
        'GroupPanel5
        '
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GroupPanel5.Controls.Add(Me.grFamilia)
        Me.GroupPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel5.Location = New System.Drawing.Point(0, 280)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(402, 238)
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
        Me.GroupPanel5.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.GroupPanel5.TabIndex = 46
        Me.GroupPanel5.Text = "B U S C A D O R"
        '
        'grFamilia
        '
        Me.grFamilia.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grFamilia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grFamilia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grFamilia.FlatBorderColor = System.Drawing.Color.AliceBlue
        Me.grFamilia.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grFamilia.HeaderFormatStyle.Alpha = 0
        Me.grFamilia.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.grFamilia.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grFamilia.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grFamilia.Location = New System.Drawing.Point(0, 0)
        Me.grFamilia.Name = "grFamilia"
        Me.grFamilia.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grFamilia.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grFamilia.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.grFamilia.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grFamilia.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.grFamilia.Size = New System.Drawing.Size(396, 215)
        Me.grFamilia.TabIndex = 0
        Me.grFamilia.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnAgregarF)
        Me.Panel9.Controls.Add(Me.btnNuevoF)
        Me.Panel9.Controls.Add(Me.LabelX31)
        Me.Panel9.Controls.Add(Me.tbNroDocFlia)
        Me.Panel9.Controls.Add(Me.LabelX30)
        Me.Panel9.Controls.Add(Me.btDependencia)
        Me.Panel9.Controls.Add(Me.cbDependecia)
        Me.Panel9.Controls.Add(Me.cbTipoDocFlia)
        Me.Panel9.Controls.Add(Me.LabelX29)
        Me.Panel9.Controls.Add(Me.cbGeneroFlia)
        Me.Panel9.Controls.Add(Me.LabelX25)
        Me.Panel9.Controls.Add(Me.LabelX21)
        Me.Panel9.Controls.Add(Me.swEstadoFlia)
        Me.Panel9.Controls.Add(Me.LabelX23)
        Me.Panel9.Controls.Add(Me.tbNombresFlia)
        Me.Panel9.Controls.Add(Me.LabelX24)
        Me.Panel9.Controls.Add(Me.dtFNacFlia)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(402, 280)
        Me.Panel9.TabIndex = 47
        '
        'btnAgregarF
        '
        Me.btnAgregarF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarF.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarF.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarF.FadeEffect = False
        Me.btnAgregarF.FocusCuesEnabled = False
        Me.btnAgregarF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarF.Image = Global.ReHu.My.Resources.Resources.save
        Me.btnAgregarF.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarF.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarF.Location = New System.Drawing.Point(206, 222)
        Me.btnAgregarF.Name = "btnAgregarF"
        Me.btnAgregarF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarF.Size = New System.Drawing.Size(107, 40)
        Me.btnAgregarF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAgregarF.TabIndex = 274
        Me.btnAgregarF.Text = "AGREGAR"
        '
        'btnNuevoF
        '
        Me.btnNuevoF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevoF.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoF.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnNuevoF.FadeEffect = False
        Me.btnNuevoF.FocusCuesEnabled = False
        Me.btnNuevoF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoF.Image = Global.ReHu.My.Resources.Resources.add2
        Me.btnNuevoF.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnNuevoF.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNuevoF.Location = New System.Drawing.Point(70, 222)
        Me.btnNuevoF.Name = "btnNuevoF"
        Me.btnNuevoF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnNuevoF.Size = New System.Drawing.Size(107, 40)
        Me.btnNuevoF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevoF.TabIndex = 272
        Me.btnNuevoF.Text = "NUEVO"
        '
        'LabelX31
        '
        '
        '
        '
        Me.LabelX31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX31.Location = New System.Drawing.Point(6, 120)
        Me.LabelX31.Name = "LabelX31"
        Me.LabelX31.Size = New System.Drawing.Size(75, 23)
        Me.LabelX31.TabIndex = 271
        Me.LabelX31.Text = "NRO. DOC.:"
        '
        'tbNroDocFlia
        '
        '
        '
        '
        Me.tbNroDocFlia.Border.Class = "TextBoxBorder"
        Me.tbNroDocFlia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNroDocFlia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNroDocFlia.Location = New System.Drawing.Point(115, 121)
        Me.tbNroDocFlia.MaxLength = 20
        Me.tbNroDocFlia.Name = "tbNroDocFlia"
        Me.tbNroDocFlia.PreventEnterBeep = True
        Me.tbNroDocFlia.Size = New System.Drawing.Size(143, 22)
        Me.tbNroDocFlia.TabIndex = 34
        '
        'LabelX30
        '
        '
        '
        '
        Me.LabelX30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX30.Location = New System.Drawing.Point(5, 149)
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.Size = New System.Drawing.Size(101, 23)
        Me.LabelX30.TabIndex = 269
        Me.LabelX30.Text = "DEPENDENCIA:"
        '
        'btDependencia
        '
        Me.btDependencia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btDependencia.BackColor = System.Drawing.Color.Transparent
        Me.btDependencia.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btDependencia.Image = Global.ReHu.My.Resources.Resources.add
        Me.btDependencia.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btDependencia.Location = New System.Drawing.Point(264, 149)
        Me.btDependencia.Name = "btDependencia"
        Me.btDependencia.Size = New System.Drawing.Size(28, 23)
        Me.btDependencia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btDependencia.TabIndex = 268
        Me.btDependencia.Visible = False
        '
        'cbDependecia
        '
        cbDependecia_DesignTimeLayout.LayoutString = resources.GetString("cbDependecia_DesignTimeLayout.LayoutString")
        Me.cbDependecia.DesignTimeLayout = cbDependecia_DesignTimeLayout
        Me.cbDependecia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDependecia.Location = New System.Drawing.Point(115, 150)
        Me.cbDependecia.MaxLength = 40
        Me.cbDependecia.Name = "cbDependecia"
        Me.cbDependecia.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbDependecia.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbDependecia.SelectedIndex = -1
        Me.cbDependecia.SelectedItem = Nothing
        Me.cbDependecia.Size = New System.Drawing.Size(144, 22)
        Me.cbDependecia.TabIndex = 35
        Me.cbDependecia.TabStop = False
        Me.cbDependecia.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cbTipoDocFlia
        '
        cbTipoDocFlia_DesignTimeLayout.LayoutString = resources.GetString("cbTipoDocFlia_DesignTimeLayout.LayoutString")
        Me.cbTipoDocFlia.DesignTimeLayout = cbTipoDocFlia_DesignTimeLayout
        Me.cbTipoDocFlia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoDocFlia.Location = New System.Drawing.Point(115, 93)
        Me.cbTipoDocFlia.MaxLength = 40
        Me.cbTipoDocFlia.Name = "cbTipoDocFlia"
        Me.cbTipoDocFlia.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTipoDocFlia.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTipoDocFlia.SelectedIndex = -1
        Me.cbTipoDocFlia.SelectedItem = Nothing
        Me.cbTipoDocFlia.Size = New System.Drawing.Size(144, 22)
        Me.cbTipoDocFlia.TabIndex = 33
        Me.cbTipoDocFlia.TabStop = False
        Me.cbTipoDocFlia.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX29
        '
        '
        '
        '
        Me.LabelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX29.Location = New System.Drawing.Point(5, 92)
        Me.LabelX29.Name = "LabelX29"
        Me.LabelX29.Size = New System.Drawing.Size(75, 23)
        Me.LabelX29.TabIndex = 264
        Me.LabelX29.Text = "TIPO DOC.:"
        '
        'cbGeneroFlia
        '
        cbGeneroFlia_DesignTimeLayout.LayoutString = resources.GetString("cbGeneroFlia_DesignTimeLayout.LayoutString")
        Me.cbGeneroFlia.DesignTimeLayout = cbGeneroFlia_DesignTimeLayout
        Me.cbGeneroFlia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGeneroFlia.Location = New System.Drawing.Point(115, 64)
        Me.cbGeneroFlia.MaxLength = 40
        Me.cbGeneroFlia.Name = "cbGeneroFlia"
        Me.cbGeneroFlia.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbGeneroFlia.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbGeneroFlia.SelectedIndex = -1
        Me.cbGeneroFlia.SelectedItem = Nothing
        Me.cbGeneroFlia.Size = New System.Drawing.Size(143, 22)
        Me.cbGeneroFlia.TabIndex = 32
        Me.cbGeneroFlia.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX25
        '
        '
        '
        '
        Me.LabelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX25.Location = New System.Drawing.Point(5, 63)
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.Size = New System.Drawing.Size(68, 23)
        Me.LabelX25.TabIndex = 263
        Me.LabelX25.Text = "GÉNERO:"
        '
        'LabelX21
        '
        '
        '
        '
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX21.Location = New System.Drawing.Point(5, 179)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(89, 23)
        Me.LabelX21.TabIndex = 260
        Me.LabelX21.Text = "ESTADO:"
        '
        'swEstadoFlia
        '
        '
        '
        '
        Me.swEstadoFlia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swEstadoFlia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swEstadoFlia.Location = New System.Drawing.Point(115, 179)
        Me.swEstadoFlia.Name = "swEstadoFlia"
        Me.swEstadoFlia.OffBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.swEstadoFlia.OffText = "PASIVO"
        Me.swEstadoFlia.OffTextColor = System.Drawing.Color.White
        Me.swEstadoFlia.OnBackColor = System.Drawing.Color.Blue
        Me.swEstadoFlia.OnText = "ACTIVO"
        Me.swEstadoFlia.OnTextColor = System.Drawing.Color.White
        Me.swEstadoFlia.Size = New System.Drawing.Size(136, 22)
        Me.swEstadoFlia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swEstadoFlia.TabIndex = 259
        Me.swEstadoFlia.TabStop = False
        Me.swEstadoFlia.Value = True
        Me.swEstadoFlia.ValueObject = "Y"
        '
        'LabelX23
        '
        '
        '
        '
        Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX23.Location = New System.Drawing.Point(5, 6)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(89, 23)
        Me.LabelX23.TabIndex = 255
        Me.LabelX23.Text = "NOMBRES:"
        '
        'tbNombresFlia
        '
        '
        '
        '
        Me.tbNombresFlia.Border.Class = "TextBoxBorder"
        Me.tbNombresFlia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNombresFlia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombresFlia.Location = New System.Drawing.Point(115, 6)
        Me.tbNombresFlia.MaxLength = 100
        Me.tbNombresFlia.Name = "tbNombresFlia"
        Me.tbNombresFlia.PreventEnterBeep = True
        Me.tbNombresFlia.Size = New System.Drawing.Size(261, 22)
        Me.tbNombresFlia.TabIndex = 30
        '
        'LabelX24
        '
        Me.LabelX24.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.LabelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX24.Location = New System.Drawing.Point(5, 35)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.Size = New System.Drawing.Size(89, 23)
        Me.LabelX24.TabIndex = 252
        Me.LabelX24.Text = "FECHA NAC.:"
        '
        'dtFNacFlia
        '
        Me.dtFNacFlia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFNacFlia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFNacFlia.Location = New System.Drawing.Point(115, 36)
        Me.dtFNacFlia.Name = "dtFNacFlia"
        Me.dtFNacFlia.Size = New System.Drawing.Size(122, 22)
        Me.dtFNacFlia.TabIndex = 31
        '
        'SuperTabItem4
        '
        Me.SuperTabItem4.AttachedControl = Me.SuperTabControlPanel6
        Me.SuperTabItem4.GlobalItem = False
        Me.SuperTabItem4.Name = "SuperTabItem4"
        Me.SuperTabItem4.Text = "Info. Familia"
        '
        'GroupPanel7
        '
        Me.GroupPanel7.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel7.Controls.Add(Me.Panel10)
        Me.GroupPanel7.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel7.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel7.Name = "GroupPanel7"
        Me.GroupPanel7.Size = New System.Drawing.Size(1350, 716)
        '
        '
        '
        Me.GroupPanel7.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel7.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel7.Style.BackColorGradientAngle = 90
        Me.GroupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderBottomWidth = 1
        Me.GroupPanel7.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderLeftWidth = 1
        Me.GroupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderRightWidth = 1
        Me.GroupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderTopWidth = 1
        Me.GroupPanel7.Style.CornerDiameter = 4
        Me.GroupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel7.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel7.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel7.TabIndex = 6
        Me.GroupPanel7.Text = "BUSCADOR  PERSONAL"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.grPersonal)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1344, 693)
        Me.Panel10.TabIndex = 0
        '
        'grPersonal
        '
        Me.grPersonal.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grPersonal.BackColor = System.Drawing.Color.GhostWhite
        Me.grPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPersonal.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grPersonal.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grPersonal.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.grPersonal.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grPersonal.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grPersonal.Location = New System.Drawing.Point(0, 0)
        Me.grPersonal.Name = "grPersonal"
        Me.grPersonal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grPersonal.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grPersonal.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.grPersonal.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grPersonal.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.grPersonal.SelectOnExpand = False
        Me.grPersonal.Size = New System.Drawing.Size(1344, 693)
        Me.grPersonal.TabIndex = 0
        Me.grPersonal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cmEliminarSueldo
        '
        Me.cmEliminarSueldo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ELIMINARFILAToolStripMenuItem})
        Me.cmEliminarSueldo.Name = "cmOpciones"
        Me.cmEliminarSueldo.Size = New System.Drawing.Size(154, 26)
        '
        'ELIMINARFILAToolStripMenuItem
        '
        Me.ELIMINARFILAToolStripMenuItem.Image = Global.ReHu.My.Resources.Resources.cancel
        Me.ELIMINARFILAToolStripMenuItem.Name = "ELIMINARFILAToolStripMenuItem"
        Me.ELIMINARFILAToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ELIMINARFILAToolStripMenuItem.Text = "ELIMINAR FILA"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ConMenu_Opciones
        '
        Me.ConMenu_Opciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConMenu_Opciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerRegistro, Me.NuevoItem, Me.ModificarItem, Me.EliminarItem})
        Me.ConMenu_Opciones.Name = "ConMenu_Opciones"
        Me.ConMenu_Opciones.Size = New System.Drawing.Size(154, 108)
        '
        'VerRegistro
        '
        Me.VerRegistro.Image = Global.ReHu.My.Resources.Resources.verRegistros2
        Me.VerRegistro.Name = "VerRegistro"
        Me.VerRegistro.Size = New System.Drawing.Size(153, 26)
        Me.VerRegistro.Text = "VER REGISTRO"
        '
        'NuevoItem
        '
        Me.NuevoItem.Image = Global.ReHu.My.Resources.Resources.add2
        Me.NuevoItem.Name = "NuevoItem"
        Me.NuevoItem.Size = New System.Drawing.Size(153, 26)
        Me.NuevoItem.Text = "NUEVO"
        '
        'ModificarItem
        '
        Me.ModificarItem.Image = Global.ReHu.My.Resources.Resources.edit2
        Me.ModificarItem.Name = "ModificarItem"
        Me.ModificarItem.Size = New System.Drawing.Size(153, 26)
        Me.ModificarItem.Text = "MODIFICAR"
        '
        'EliminarItem
        '
        Me.EliminarItem.Image = Global.ReHu.My.Resources.Resources.cancel
        Me.EliminarItem.Name = "EliminarItem"
        Me.EliminarItem.Size = New System.Drawing.Size(153, 26)
        Me.EliminarItem.Text = "ELIMINAR"
        '
        'OfdFoto
        '
        Me.OfdFoto.FileName = "OpenFileDialog1"
        '
        'RLAccion
        '
        '
        '
        '
        Me.RLAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RLAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RLAccion.ForeColor = System.Drawing.Color.Black
        Me.RLAccion.Location = New System.Drawing.Point(383, 6)
        Me.RLAccion.Name = "RLAccion"
        Me.RLAccion.Size = New System.Drawing.Size(409, 60)
        Me.RLAccion.TabIndex = 8
        Me.RLAccion.Text = "<b><font size=""+10""><font color=""#FF0000""></font></font></b>"
        '
        'cmEliminarContrato
        '
        Me.cmEliminarContrato.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarContrato})
        Me.cmEliminarContrato.Name = "cmOpciones"
        Me.cmEliminarContrato.Size = New System.Drawing.Size(154, 26)
        '
        'EliminarContrato
        '
        Me.EliminarContrato.Image = Global.ReHu.My.Resources.Resources.cancel
        Me.EliminarContrato.Name = "EliminarContrato"
        Me.EliminarContrato.Size = New System.Drawing.Size(153, 22)
        Me.EliminarContrato.Text = "ELIMINAR FILA"
        '
        'cmEliminarFamilia
        '
        Me.cmEliminarFamilia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarFamilia})
        Me.cmEliminarFamilia.Name = "cmOpciones"
        Me.cmEliminarFamilia.Size = New System.Drawing.Size(154, 26)
        '
        'EliminarFamilia
        '
        Me.EliminarFamilia.Image = Global.ReHu.My.Resources.Resources.cancel
        Me.EliminarFamilia.Name = "EliminarFamilia"
        Me.EliminarFamilia.Size = New System.Drawing.Size(153, 22)
        Me.EliminarFamilia.Text = "ELIMINAR FILA"
        '
        'cmEliminarCargo
        '
        Me.cmEliminarCargo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarCargo})
        Me.cmEliminarCargo.Name = "cmOpciones"
        Me.cmEliminarCargo.Size = New System.Drawing.Size(154, 26)
        '
        'EliminarCargo
        '
        Me.EliminarCargo.Image = Global.ReHu.My.Resources.Resources.cancel
        Me.EliminarCargo.Name = "EliminarCargo"
        Me.EliminarCargo.Size = New System.Drawing.Size(153, 22)
        Me.EliminarCargo.Text = "ELIMINAR FILA"
        '
        'F3_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 741)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "F3_Personal"
        Me.Opacity = 0.05R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Text = "F3_Personal"
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGenero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAgrImagen.ResumeLayout(False)
        CType(Me.pbImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEstCivil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.SuperTabControl_Imagenes_DetalleProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl_Imagenes_DetalleProducto.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.SuperTabControlPanel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.grDetalleSueldos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.SuperTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl2.ResumeLayout(False)
        Me.SuperTabControlPanel4.ResumeLayout(False)
        Me.PanelInfo.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.grContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.cbTipoContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.GroupPanel6.ResumeLayout(False)
        CType(Me.grCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.cbCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel6.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        CType(Me.grFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.cbDependecia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoDocFlia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGeneroFlia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel7.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.grPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmEliminarSueldo.ResumeLayout(False)
        Me.ConMenu_Opciones.ResumeLayout(False)
        Me.cmEliminarContrato.ResumeLayout(False)
        Me.cmEliminarFamilia.ResumeLayout(False)
        Me.cmEliminarCargo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btEstado As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbEstado As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbGenero As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtFIng As DateTimePicker
    Friend WithEvents dtFNac As DateTimePicker
    Friend WithEvents PanelAgrImagen As Panel
    Friend WithEvents ImgOpc As DevComponents.DotNetBar.RadialMenu
    Friend WithEvents pbImg As PictureBox
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btTipoDoc As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTipoDoc As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btEstadoCivil As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbEstCivil As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbObs As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbTelef2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbTelef1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNroDoc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNumi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SuperTabControl_Imagenes_DetalleProducto As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grDetalleSueldos As DataGridView
    Friend WithEvents SuperTabItem_Imagenes As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SuperTabControl2 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelInfo As Panel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents grContrato As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnExaminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAgregarCont As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevoCont As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swEstadoCont As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents btTContrato As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTipoContrato As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbRutaContrato As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtFechaFin As DateTimePicker
    Friend WithEvents dtFechaIni As DateTimePicker
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel5 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents GroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents grCargo As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnAgregarC As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevoC As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btCargo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbCargo As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX32 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swEstadoCargo As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX34 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtFechaCargo As DateTimePicker
    Friend WithEvents SuperTabItem5 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel6 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents grFamilia As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnAgregarF As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevoF As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNroDocFlia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btDependencia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbDependecia As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbTipoDocFlia As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX29 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbGeneroFlia As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swEstadoFlia As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNombresFlia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtFNacFlia As DateTimePicker
    Friend WithEvents SuperTabItem4 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents GroupPanel7 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents grPersonal As Janus.Windows.GridEX.GridEX
    Friend WithEvents cmEliminarSueldo As ContextMenuStrip
    Friend WithEvents ELIMINARFILAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ConMenu_Opciones As ContextMenuStrip
    Friend WithEvents NuevoItem As ToolStripMenuItem
    Friend WithEvents ModificarItem As ToolStripMenuItem
    Friend WithEvents EliminarItem As ToolStripMenuItem
    Friend WithEvents OfdFoto As OpenFileDialog
    Friend WithEvents btnAgregar As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents btnElimImg As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents RLAccion As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents cmEliminarContrato As ContextMenuStrip
    Friend WithEvents EliminarContrato As ToolStripMenuItem
    Friend WithEvents cmEliminarFamilia As ContextMenuStrip
    Friend WithEvents EliminarFamilia As ToolStripMenuItem
    Friend WithEvents cmEliminarCargo As ContextMenuStrip
    Friend WithEvents EliminarCargo As ToolStripMenuItem
    Friend WithEvents VerRegistro As ToolStripMenuItem
End Class
