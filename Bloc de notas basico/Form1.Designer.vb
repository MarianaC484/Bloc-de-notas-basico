<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlocNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlocNotas))
        mnuPrincipal = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        mnuNuevo = New ToolStripMenuItem()
        mnuAbrir = New ToolStripMenuItem()
        mnuGuardar = New ToolStripMenuItem()
        mnuGuardarComo = New ToolStripMenuItem()
        mnuSalir = New ToolStripMenuItem()
        EdicionToolStripMenuItem = New ToolStripMenuItem()
        mnuDeshacer = New ToolStripMenuItem()
        mnuRehacer = New ToolStripMenuItem()
        mnuCortar = New ToolStripMenuItem()
        mnuCopiar = New ToolStripMenuItem()
        mnuPegar = New ToolStripMenuItem()
        mnuSeleccionarTodo = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        mnuFuente = New ToolStripMenuItem()
        mnuColorTexto = New ToolStripMenuItem()
        mnuAjusteDeLinea = New ToolStripMenuItem()
        VerToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        tsPrincipal = New ToolStrip()
        tsbNuevo = New ToolStripButton()
        tsbAbrir = New ToolStripButton()
        tsbGuardar = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        tsbCortar = New ToolStripButton()
        tsbCopiar = New ToolStripButton()
        tsbPegar = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        tsbNegrita = New ToolStripButton()
        tsbCursiva = New ToolStripButton()
        tsbSubrayado = New ToolStripButton()
        tscbFuente = New ToolStripComboBox()
        tscbTamano = New ToolStripComboBox()
        rtbDocumento = New RichTextBox()
        cmsTexto = New ContextMenuStrip(components)
        cmsCortar = New ToolStripMenuItem()
        cmsCopiar = New ToolStripMenuItem()
        cmsPegar = New ToolStripMenuItem()
        cmsSeleccionarTodo = New ToolStripMenuItem()
        cmsFuente = New ToolStripMenuItem()
        stsInferior = New StatusStrip()
        stsEstado = New ToolStripStatusLabel()
        stsPosicion = New ToolStripStatusLabel()
        stsCaracteres = New ToolStripStatusLabel()
        stsZoom = New ToolStripStatusLabel()
        stsFechaHora = New ToolStripStatusLabel()
        dlgAbrir = New OpenFileDialog()
        dlgGuardar = New SaveFileDialog()
        dlgFuente = New FontDialog()
        dlgColor = New ColorDialog()
        tmrReloj = New Timer(components)
        mnuAjusteLinea = New ToolStripMenuItem()
        mnuZoomMas = New ToolStripMenuItem()
        mnuZoomMenos = New ToolStripMenuItem()
        mnuZoomRestablecer = New ToolStripMenuItem()
        mnuAcercaDe = New ToolStripMenuItem()
        mnuPrincipal.SuspendLayout()
        tsPrincipal.SuspendLayout()
        cmsTexto.SuspendLayout()
        stsInferior.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.ImageScalingSize = New Size(24, 24)
        mnuPrincipal.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdicionToolStripMenuItem, FormatoToolStripMenuItem, VerToolStripMenuItem, AyudaToolStripMenuItem})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Size = New Size(822, 33)
        mnuPrincipal.TabIndex = 0
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuNuevo, mnuAbrir, mnuGuardar, mnuGuardarComo, mnuSalir})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(88, 29)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' mnuNuevo
        ' 
        mnuNuevo.Name = "mnuNuevo"
        mnuNuevo.ShortcutKeys = Keys.Control Or Keys.N
        mnuNuevo.Size = New Size(238, 34)
        mnuNuevo.Text = "&Nuevo"
        ' 
        ' mnuAbrir
        ' 
        mnuAbrir.Name = "mnuAbrir"
        mnuAbrir.ShortcutKeys = Keys.Control Or Keys.O
        mnuAbrir.Size = New Size(238, 34)
        mnuAbrir.Text = "&Abrir"
        ' 
        ' mnuGuardar
        ' 
        mnuGuardar.Name = "mnuGuardar"
        mnuGuardar.ShortcutKeys = Keys.Control Or Keys.S
        mnuGuardar.Size = New Size(238, 34)
        mnuGuardar.Text = "&Guardar"
        ' 
        ' mnuGuardarComo
        ' 
        mnuGuardarComo.Name = "mnuGuardarComo"
        mnuGuardarComo.Size = New Size(238, 34)
        mnuGuardarComo.Text = "Guardar &como"
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.ShortcutKeys = Keys.Alt Or Keys.F4
        mnuSalir.Size = New Size(238, 34)
        mnuSalir.Text = "&Salir"
        ' 
        ' EdicionToolStripMenuItem
        ' 
        EdicionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuDeshacer, mnuRehacer, mnuCortar, mnuCopiar, mnuPegar, mnuSeleccionarTodo})
        EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        EdicionToolStripMenuItem.Size = New Size(90, 29)
        EdicionToolStripMenuItem.Text = "Edicion "
        ' 
        ' mnuDeshacer
        ' 
        mnuDeshacer.Name = "mnuDeshacer"
        mnuDeshacer.ShortcutKeys = Keys.Control Or Keys.Z
        mnuDeshacer.Size = New Size(306, 34)
        mnuDeshacer.Text = "&Deshacer"
        ' 
        ' mnuRehacer
        ' 
        mnuRehacer.Name = "mnuRehacer"
        mnuRehacer.ShortcutKeys = Keys.Control Or Keys.Y
        mnuRehacer.Size = New Size(306, 34)
        mnuRehacer.Text = "&Rehacer"
        ' 
        ' mnuCortar
        ' 
        mnuCortar.Name = "mnuCortar"
        mnuCortar.ShortcutKeys = Keys.Control Or Keys.X
        mnuCortar.Size = New Size(306, 34)
        mnuCortar.Text = "Cortar"
        ' 
        ' mnuCopiar
        ' 
        mnuCopiar.Name = "mnuCopiar"
        mnuCopiar.ShortcutKeys = Keys.Control Or Keys.C
        mnuCopiar.Size = New Size(306, 34)
        mnuCopiar.Text = "Copiar"
        ' 
        ' mnuPegar
        ' 
        mnuPegar.Name = "mnuPegar"
        mnuPegar.ShortcutKeys = Keys.Control Or Keys.V
        mnuPegar.Size = New Size(306, 34)
        mnuPegar.Text = "Pegar"
        ' 
        ' mnuSeleccionarTodo
        ' 
        mnuSeleccionarTodo.Name = "mnuSeleccionarTodo"
        mnuSeleccionarTodo.ShortcutKeys = Keys.Control Or Keys.E
        mnuSeleccionarTodo.Size = New Size(306, 34)
        mnuSeleccionarTodo.Text = "Seleccionar todo"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuFuente, mnuColorTexto, mnuAjusteDeLinea})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(96, 29)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' mnuFuente
        ' 
        mnuFuente.Name = "mnuFuente"
        mnuFuente.Size = New Size(229, 34)
        mnuFuente.Text = "&Fuente"
        ' 
        ' mnuColorTexto
        ' 
        mnuColorTexto.Name = "mnuColorTexto"
        mnuColorTexto.Size = New Size(229, 34)
        mnuColorTexto.Text = "Color de texto"
        ' 
        ' mnuAjusteDeLinea
        ' 
        mnuAjusteDeLinea.CheckOnClick = True
        mnuAjusteDeLinea.Name = "mnuAjusteDeLinea"
        mnuAjusteDeLinea.Size = New Size(229, 34)
        mnuAjusteDeLinea.Text = "Ajuste de linea"
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuZoomMas, mnuZoomMenos, mnuZoomRestablecer})
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(53, 29)
        VerToolStripMenuItem.Text = "Ver"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAcercaDe})
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(79, 29)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.GripStyle = ToolStripGripStyle.Hidden
        tsPrincipal.ImageScalingSize = New Size(24, 24)
        tsPrincipal.Items.AddRange(New ToolStripItem() {tsbNuevo, tsbAbrir, tsbGuardar, ToolStripSeparator1, tsbCortar, tsbCopiar, tsbPegar, ToolStripSeparator2, tsbNegrita, tsbCursiva, tsbSubrayado, tscbFuente, tscbTamano})
        tsPrincipal.Location = New Point(0, 33)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Size = New Size(822, 33)
        tsPrincipal.TabIndex = 1
        tsPrincipal.Text = "ToolStrip1"
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), Image)
        tsbNuevo.ImageTransparentColor = Color.Magenta
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New Size(34, 28)
        tsbNuevo.Text = "ToolStripButton1"
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAbrir.Image = CType(resources.GetObject("tsbAbrir.Image"), Image)
        tsbAbrir.ImageTransparentColor = Color.Magenta
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New Size(34, 28)
        tsbAbrir.Text = "ToolStripButton2"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), Image)
        tsbGuardar.ImageTransparentColor = Color.Magenta
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New Size(34, 28)
        tsbGuardar.Text = "ToolStripButton3"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 33)
        ' 
        ' tsbCortar
        ' 
        tsbCortar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCortar.Image = CType(resources.GetObject("tsbCortar.Image"), Image)
        tsbCortar.ImageTransparentColor = Color.Magenta
        tsbCortar.Name = "tsbCortar"
        tsbCortar.Size = New Size(34, 28)
        tsbCortar.Text = "ToolStripButton4"
        ' 
        ' tsbCopiar
        ' 
        tsbCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCopiar.Image = CType(resources.GetObject("tsbCopiar.Image"), Image)
        tsbCopiar.ImageTransparentColor = Color.Magenta
        tsbCopiar.Name = "tsbCopiar"
        tsbCopiar.Size = New Size(34, 28)
        tsbCopiar.Text = "ToolStripButton5"
        ' 
        ' tsbPegar
        ' 
        tsbPegar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbPegar.Image = CType(resources.GetObject("tsbPegar.Image"), Image)
        tsbPegar.ImageTransparentColor = Color.Magenta
        tsbPegar.Name = "tsbPegar"
        tsbPegar.Size = New Size(34, 28)
        tsbPegar.Text = "ToolStripButton6"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 33)
        ' 
        ' tsbNegrita
        ' 
        tsbNegrita.CheckOnClick = True
        tsbNegrita.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNegrita.Image = CType(resources.GetObject("tsbNegrita.Image"), Image)
        tsbNegrita.ImageTransparentColor = Color.Magenta
        tsbNegrita.Name = "tsbNegrita"
        tsbNegrita.Size = New Size(34, 28)
        tsbNegrita.Text = "tsbNegrita"
        ' 
        ' tsbCursiva
        ' 
        tsbCursiva.CheckOnClick = True
        tsbCursiva.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCursiva.Image = CType(resources.GetObject("tsbCursiva.Image"), Image)
        tsbCursiva.ImageTransparentColor = Color.Magenta
        tsbCursiva.Name = "tsbCursiva"
        tsbCursiva.Size = New Size(34, 28)
        tsbCursiva.Text = "tsbCursiva"
        ' 
        ' tsbSubrayado
        ' 
        tsbSubrayado.CheckOnClick = True
        tsbSubrayado.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbSubrayado.Image = CType(resources.GetObject("tsbSubrayado.Image"), Image)
        tsbSubrayado.ImageTransparentColor = Color.Magenta
        tsbSubrayado.Name = "tsbSubrayado"
        tsbSubrayado.Size = New Size(34, 28)
        tsbSubrayado.Text = "tsbSubrayado"
        ' 
        ' tscbFuente
        ' 
        tscbFuente.Name = "tscbFuente"
        tscbFuente.Size = New Size(121, 33)
        ' 
        ' tscbTamano
        ' 
        tscbTamano.Name = "tscbTamano"
        tscbTamano.Size = New Size(121, 33)
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.ContextMenuStrip = cmsTexto
        rtbDocumento.Dock = DockStyle.Fill
        rtbDocumento.Font = New Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbDocumento.Location = New Point(0, 66)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(822, 431)
        rtbDocumento.TabIndex = 2
        rtbDocumento.Text = ""
        ' 
        ' cmsTexto
        ' 
        cmsTexto.ImageScalingSize = New Size(24, 24)
        cmsTexto.Items.AddRange(New ToolStripItem() {cmsCortar, cmsCopiar, cmsPegar, cmsSeleccionarTodo, cmsFuente})
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(217, 164)
        ' 
        ' cmsCortar
        ' 
        cmsCortar.Name = "cmsCortar"
        cmsCortar.Size = New Size(216, 32)
        cmsCortar.Text = "Cortar"
        ' 
        ' cmsCopiar
        ' 
        cmsCopiar.Name = "cmsCopiar"
        cmsCopiar.Size = New Size(216, 32)
        cmsCopiar.Text = "Copiar"
        ' 
        ' cmsPegar
        ' 
        cmsPegar.Name = "cmsPegar"
        cmsPegar.Size = New Size(216, 32)
        cmsPegar.Text = "Pegar"
        ' 
        ' cmsSeleccionarTodo
        ' 
        cmsSeleccionarTodo.Name = "cmsSeleccionarTodo"
        cmsSeleccionarTodo.Size = New Size(216, 32)
        cmsSeleccionarTodo.Text = "Seleccionar todo"
        ' 
        ' cmsFuente
        ' 
        cmsFuente.Name = "cmsFuente"
        cmsFuente.Size = New Size(216, 32)
        cmsFuente.Text = "Fuente..."
        ' 
        ' stsInferior
        ' 
        stsInferior.ImageScalingSize = New Size(24, 24)
        stsInferior.Items.AddRange(New ToolStripItem() {stsEstado, stsPosicion, stsCaracteres, stsZoom, stsFechaHora})
        stsInferior.Location = New Point(0, 465)
        stsInferior.Name = "stsInferior"
        stsInferior.Size = New Size(822, 32)
        stsInferior.TabIndex = 4
        stsInferior.Text = "StatusStrip1"
        ' 
        ' stsEstado
        ' 
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(314, 25)
        stsEstado.Spring = True
        stsEstado.Text = "Listo"
        ' 
        ' stsPosicion
        ' 
        stsPosicion.Name = "stsPosicion"
        stsPosicion.Size = New Size(178, 25)
        stsPosicion.Text = "Linea: 1 / Columna: 1"
        ' 
        ' stsCaracteres
        ' 
        stsCaracteres.Name = "stsCaracteres"
        stsCaracteres.Size = New Size(115, 25)
        stsCaracteres.Text = "stsCaracteres"
        ' 
        ' stsZoom
        ' 
        stsZoom.Name = "stsZoom"
        stsZoom.Size = New Size(82, 25)
        stsZoom.Text = "stsZoom"
        ' 
        ' stsFechaHora
        ' 
        stsFechaHora.Name = "stsFechaHora"
        stsFechaHora.Size = New Size(118, 25)
        stsFechaHora.Text = "stsFechaHora"
        ' 
        ' dlgAbrir
        ' 
        dlgAbrir.FileName = "OpenFileDialog1"
        dlgAbrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        ' 
        ' dlgGuardar
        ' 
        dlgGuardar.DefaultExt = "txt"
        ' 
        ' dlgFuente
        ' 
        dlgFuente.ShowColor = True
        ' 
        ' dlgColor
        ' 
        dlgColor.FullOpen = True
        ' 
        ' tmrReloj
        ' 
        tmrReloj.Enabled = True
        tmrReloj.Interval = 1000
        ' 
        ' mnuAjusteLinea
        ' 
        mnuAjusteLinea.CheckOnClick = True
        mnuAjusteLinea.Name = "mnuAjusteLinea"
        mnuAjusteLinea.Size = New Size(240, 32)
        mnuAjusteLinea.Text = "Ajuste de linea"
        ' 
        ' mnuZoomMas
        ' 
        mnuZoomMas.Name = "mnuZoomMas"
        mnuZoomMas.Size = New Size(270, 34)
        mnuZoomMas.Text = "Zoom + "
        ' 
        ' mnuZoomMenos
        ' 
        mnuZoomMenos.Name = "mnuZoomMenos"
        mnuZoomMenos.Size = New Size(270, 34)
        mnuZoomMenos.Text = "Zoom -"
        ' 
        ' mnuZoomRestablecer
        ' 
        mnuZoomRestablecer.Name = "mnuZoomRestablecer"
        mnuZoomRestablecer.Size = New Size(270, 34)
        mnuZoomRestablecer.Text = "Restablecer zoom"
        ' 
        ' mnuAcercaDe
        ' 
        mnuAcercaDe.Name = "mnuAcercaDe"
        mnuAcercaDe.Size = New Size(270, 34)
        mnuAcercaDe.Text = "Acerca de..."
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(822, 497)
        Controls.Add(stsInferior)
        Controls.Add(rtbDocumento)
        Controls.Add(tsPrincipal)
        Controls.Add(mnuPrincipal)
        MainMenuStrip = mnuPrincipal
        MinimumSize = New Size(600, 400)
        Name = "frmBlocNotas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bloc de Notas VB.NET "
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        tsPrincipal.ResumeLayout(False)
        tsPrincipal.PerformLayout()
        cmsTexto.ResumeLayout(False)
        stsInferior.ResumeLayout(False)
        stsInferior.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents tsPrincipal As ToolStrip
    Friend WithEvents rtbDocumento As RichTextBox
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsTexto As ContextMenuStrip
    Friend WithEvents stsInferior As StatusStrip
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents dlgAbrir As OpenFileDialog
    Friend WithEvents dlgGuardar As SaveFileDialog
    Friend WithEvents dlgFuente As FontDialog
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents tmrReloj As Timer
    Friend WithEvents tsbAbrir As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbNegrita As ToolStripButton
    Friend WithEvents tsbCursiva As ToolStripButton
    Friend WithEvents tsbSubrayado As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents stsEstado As ToolStripStatusLabel
    Friend WithEvents stsPosicion As ToolStripStatusLabel
    Friend WithEvents stsCaracteres As ToolStripStatusLabel
    Friend WithEvents stsFechaHora As ToolStripStatusLabel
    Friend WithEvents tsbCortar As ToolStripButton
    Friend WithEvents tsbCopiar As ToolStripButton
    Friend WithEvents tsbPegar As ToolStripButton
    Friend WithEvents tscbFuente As ToolStripComboBox
    Friend WithEvents tscbTamano As ToolStripComboBox
    Friend WithEvents mnuNuevo As ToolStripMenuItem
    Friend WithEvents mnuAbrir As ToolStripMenuItem
    Friend WithEvents mnuGuardar As ToolStripMenuItem
    Friend WithEvents mnuGuardarComo As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents mnuAjusteLinea As ToolStripMenuItem
    Friend WithEvents mnuDeshacer As ToolStripMenuItem
    Friend WithEvents mnuRehacer As ToolStripMenuItem
    Friend WithEvents mnuCortar As ToolStripMenuItem
    Friend WithEvents mnuCopiar As ToolStripMenuItem
    Friend WithEvents mnuPegar As ToolStripMenuItem
    Friend WithEvents mnuSeleccionarTodo As ToolStripMenuItem
    Friend WithEvents mnuFuente As ToolStripMenuItem
    Friend WithEvents mnuAjusteDeLinea As ToolStripMenuItem
    Friend WithEvents cmsCortar As ToolStripMenuItem
    Friend WithEvents cmsCopiar As ToolStripMenuItem
    Friend WithEvents cmsPegar As ToolStripMenuItem
    Friend WithEvents cmsSeleccionarTodo As ToolStripMenuItem
    Friend WithEvents cmsFuente As ToolStripMenuItem
    Friend WithEvents mnuColorTexto As ToolStripMenuItem
    Friend WithEvents stsZoom As ToolStripStatusLabel
    Friend WithEvents mnuZoomMas As ToolStripMenuItem
    Friend WithEvents mnuZoomMenos As ToolStripMenuItem
    Friend WithEvents mnuZoomRestablecer As ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As ToolStripMenuItem

End Class
