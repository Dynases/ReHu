<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits Modelo.ModeloF1

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim MultiColumnCombo1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.swEstado = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.MultiColumnCombo1 = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.tbFRet = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabPrincipal.SuspendLayout()
        Me.SuperTabControlPanelRegistro.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.MPanelSup.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.GroupPanelBuscador.SuspendLayout()
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MultiColumnCombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.MenuBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabPrincipal.ControlBox.MenuBox, Me.SuperTabPrincipal.ControlBox.CloseBox})
        Me.SuperTabPrincipal.Size = New System.Drawing.Size(853, 507)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelBuscador, 0)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelRegistro, 0)
        '
        'SuperTabControlPanelBuscador
        '
        Me.SuperTabControlPanelBuscador.Size = New System.Drawing.Size(821, 507)
        '
        'SuperTabControlPanelRegistro
        '
        Me.SuperTabControlPanelRegistro.Size = New System.Drawing.Size(821, 507)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(821, 72)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 471)
        Me.PanelInferior.Size = New System.Drawing.Size(821, 36)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
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
        'PanelToolBar2
        '
        Me.PanelToolBar2.Location = New System.Drawing.Point(741, 0)
        '
        'MPanelSup
        '
        Me.MPanelSup.Controls.Add(Me.LabelX18)
        Me.MPanelSup.Controls.Add(Me.swEstado)
        Me.MPanelSup.Controls.Add(Me.ButtonX1)
        Me.MPanelSup.Controls.Add(Me.MultiColumnCombo1)
        Me.MPanelSup.Controls.Add(Me.LabelX14)
        Me.MPanelSup.Controls.Add(Me.LabelX9)
        Me.MPanelSup.Controls.Add(Me.TextBoxX1)
        Me.MPanelSup.Controls.Add(Me.LabelX17)
        Me.MPanelSup.Controls.Add(Me.tbFRet)
        Me.MPanelSup.Controls.Add(Me.DateTimePicker1)
        Me.MPanelSup.Controls.Add(Me.LabelX19)
        Me.MPanelSup.Controls.Add(Me.Button1)
        Me.MPanelSup.Size = New System.Drawing.Size(821, 184)
        Me.MPanelSup.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.Button1, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.LabelX19, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.DateTimePicker1, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.tbFRet, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.LabelX17, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.TextBoxX1, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.LabelX9, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.LabelX14, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.MultiColumnCombo1, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.ButtonX1, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.swEstado, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.LabelX18, 0)
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Size = New System.Drawing.Size(821, 399)
        '
        'GroupPanelBuscador
        '
        Me.GroupPanelBuscador.Size = New System.Drawing.Size(821, 215)
        '
        '
        '
        Me.GroupPanelBuscador.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelBuscador.Style.BackColorGradientAngle = 90
        Me.GroupPanelBuscador.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelBuscador.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderBottomWidth = 1
        Me.GroupPanelBuscador.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelBuscador.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderLeftWidth = 1
        Me.GroupPanelBuscador.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderRightWidth = 1
        Me.GroupPanelBuscador.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderTopWidth = 1
        Me.GroupPanelBuscador.Style.CornerDiameter = 4
        Me.GroupPanelBuscador.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelBuscador.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelBuscador.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelBuscador.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelBuscador.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'JGrM_Buscador
        '
        Me.JGrM_Buscador.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.JGrM_Buscador.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGrM_Buscador.Size = New System.Drawing.Size(815, 192)
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(621, 0)
        '
        'Button1
        '
        Me.Button1.Image = Global.ReHu.My.Resources.Resources.add
        Me.Button1.Location = New System.Drawing.Point(652, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelX18
        '
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.Location = New System.Drawing.Point(238, 140)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(115, 23)
        Me.LabelX18.TabIndex = 249
        Me.LabelX18.Text = "ESTADO:"
        '
        'swEstado
        '
        '
        '
        '
        Me.swEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swEstado.Location = New System.Drawing.Point(366, 140)
        Me.swEstado.Name = "swEstado"
        Me.swEstado.OffBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.swEstado.OffText = "PASIVO"
        Me.swEstado.OffTextColor = System.Drawing.Color.White
        Me.swEstado.OnBackColor = System.Drawing.Color.Blue
        Me.swEstado.OnText = "ACTIVO"
        Me.swEstado.OnTextColor = System.Drawing.Color.White
        Me.swEstado.Size = New System.Drawing.Size(136, 22)
        Me.swEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swEstado.TabIndex = 248
        Me.swEstado.TabStop = False
        Me.swEstado.Value = True
        Me.swEstado.ValueObject = "Y"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX1.Image = Global.ReHu.My.Resources.Resources.add
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.ButtonX1.Location = New System.Drawing.Point(548, 106)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(34, 29)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 247
        Me.ButtonX1.Visible = False
        '
        'MultiColumnCombo1
        '
        MultiColumnCombo1_DesignTimeLayout.LayoutString = resources.GetString("MultiColumnCombo1_DesignTimeLayout.LayoutString")
        Me.MultiColumnCombo1.DesignTimeLayout = MultiColumnCombo1_DesignTimeLayout
        Me.MultiColumnCombo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiColumnCombo1.Location = New System.Drawing.Point(366, 109)
        Me.MultiColumnCombo1.Name = "MultiColumnCombo1"
        Me.MultiColumnCombo1.SelectedIndex = -1
        Me.MultiColumnCombo1.SelectedItem = Nothing
        Me.MultiColumnCombo1.Size = New System.Drawing.Size(176, 22)
        Me.MultiColumnCombo1.TabIndex = 245
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.Location = New System.Drawing.Point(238, 110)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(115, 23)
        Me.LabelX14.TabIndex = 246
        Me.LabelX14.Text = "TIPO CONTRATO :"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(238, 77)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(122, 23)
        Me.LabelX9.TabIndex = 244
        Me.LabelX9.Text = "RUTA CONTRATO:"
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.Location = New System.Drawing.Point(366, 77)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxX1.TabIndex = 243
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.Location = New System.Drawing.Point(238, 21)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(115, 23)
        Me.LabelX17.TabIndex = 241
        Me.LabelX17.Text = "FECHA INICIO:"
        '
        'tbFRet
        '
        Me.tbFRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFRet.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFRet.Location = New System.Drawing.Point(366, 50)
        Me.tbFRet.Name = "tbFRet"
        Me.tbFRet.Size = New System.Drawing.Size(122, 22)
        Me.tbFRet.TabIndex = 240
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(366, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(122, 22)
        Me.DateTimePicker1.TabIndex = 239
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.Location = New System.Drawing.Point(238, 47)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(109, 23)
        Me.LabelX19.TabIndex = 242
        Me.LabelX19.Text = "FECHA FIN:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 507)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Controls.SetChildIndex(Me.SuperTabPrincipal, 0)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabPrincipal.ResumeLayout(False)
        Me.SuperTabControlPanelRegistro.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.MPanelSup.ResumeLayout(False)
        Me.MPanelSup.PerformLayout()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.GroupPanelBuscador.ResumeLayout(False)
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MultiColumnCombo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swEstado As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MultiColumnCombo1 As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFRet As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
End Class
