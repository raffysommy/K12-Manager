<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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


    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AutenticazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TokenDiAccessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodiciDiAutorizzazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TokenRigenerazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DidatticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestionariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DomandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArgomentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DomandeDeiQuestionariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessaggiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutenticazioneToolStripMenuItem, Me.DidatticaToolStripMenuItem, Me.ChatToolStripMenuItem, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'AutenticazioneToolStripMenuItem
        '
        Me.AutenticazioneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TokenDiAccessoToolStripMenuItem, Me.UtentiToolStripMenuItem, Me.CodiciDiAutorizzazioneToolStripMenuItem, Me.ClientToolStripMenuItem, Me.TokenRigenerazioneToolStripMenuItem})
        Me.AutenticazioneToolStripMenuItem.Name = "AutenticazioneToolStripMenuItem"
        Me.AutenticazioneToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AutenticazioneToolStripMenuItem.Text = "Autenticazione"
        '
        'TokenDiAccessoToolStripMenuItem
        '
        Me.TokenDiAccessoToolStripMenuItem.Name = "TokenDiAccessoToolStripMenuItem"
        Me.TokenDiAccessoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.TokenDiAccessoToolStripMenuItem.Text = "Token di Accesso"
        '
        'UtentiToolStripMenuItem
        '
        Me.UtentiToolStripMenuItem.Name = "UtentiToolStripMenuItem"
        Me.UtentiToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.UtentiToolStripMenuItem.Text = "Utenti"
        '
        'CodiciDiAutorizzazioneToolStripMenuItem
        '
        Me.CodiciDiAutorizzazioneToolStripMenuItem.Name = "CodiciDiAutorizzazioneToolStripMenuItem"
        Me.CodiciDiAutorizzazioneToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CodiciDiAutorizzazioneToolStripMenuItem.Text = "Codici di Autorizzazione"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'TokenRigenerazioneToolStripMenuItem
        '
        Me.TokenRigenerazioneToolStripMenuItem.Name = "TokenRigenerazioneToolStripMenuItem"
        Me.TokenRigenerazioneToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.TokenRigenerazioneToolStripMenuItem.Text = "Token Rigenerazione"
        '
        'DidatticaToolStripMenuItem
        '
        Me.DidatticaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuestionariToolStripMenuItem, Me.DomandeToolStripMenuItem, Me.ArgomentiToolStripMenuItem, Me.DomandeDeiQuestionariToolStripMenuItem})
        Me.DidatticaToolStripMenuItem.Name = "DidatticaToolStripMenuItem"
        Me.DidatticaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.DidatticaToolStripMenuItem.Text = "Didattica"
        '
        'QuestionariToolStripMenuItem
        '
        Me.QuestionariToolStripMenuItem.Name = "QuestionariToolStripMenuItem"
        Me.QuestionariToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.QuestionariToolStripMenuItem.Text = "Questionari"
        '
        'DomandeToolStripMenuItem
        '
        Me.DomandeToolStripMenuItem.Name = "DomandeToolStripMenuItem"
        Me.DomandeToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DomandeToolStripMenuItem.Text = "Domande"
        '
        'ArgomentiToolStripMenuItem
        '
        Me.ArgomentiToolStripMenuItem.Name = "ArgomentiToolStripMenuItem"
        Me.ArgomentiToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ArgomentiToolStripMenuItem.Text = "Argomenti"
        '
        'DomandeDeiQuestionariToolStripMenuItem
        '
        Me.DomandeDeiQuestionariToolStripMenuItem.Name = "DomandeDeiQuestionariToolStripMenuItem"
        Me.DomandeDeiQuestionariToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DomandeDeiQuestionariToolStripMenuItem.Text = "Domande dei Questionari"
        '
        'ChatToolStripMenuItem
        '
        Me.ChatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessaggiToolStripMenuItem})
        Me.ChatToolStripMenuItem.Name = "ChatToolStripMenuItem"
        Me.ChatToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ChatToolStripMenuItem.Text = "Chat"
        '
        'MessaggiToolStripMenuItem
        '
        Me.MessaggiToolStripMenuItem.Name = "MessaggiToolStripMenuItem"
        Me.MessaggiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MessaggiToolStripMenuItem.Text = "Messaggi"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(69, 20)
        Me.ViewMenu.Text = "&Visualizza"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Barra degli strumenti"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.StatusBarToolStripMenuItem.Text = "Barra di &stato"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(71, 20)
        Me.ToolsMenu.Text = "&Strumenti"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.OptionsToolStripMenuItem.Text = "&Opzioni"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(60, 20)
        Me.WindowsMenu.Text = "&Finestre"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.NewWindowToolStripMenuItem.Text = "&Nuova finestra"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CascadeToolStripMenuItem.Text = "&Sovrapponi"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Affianca &verticalmente"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Affianca &orizzontalmente"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&hiudi tutte"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Disponi icone"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(24, 20)
        Me.HelpMenu.Text = "&?"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ContentsToolStripMenuItem.Text = "&Sommario"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.IndexToolStripMenuItem.Text = "&Indice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SearchToolStripMenuItem.Text = "&Cerca"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(181, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AboutToolStripMenuItem.Text = "&Informazioni su..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel.Text = "Stato"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "K12 Manager"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutenticazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TokenDiAccessoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodiciDiAutorizzazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TokenRigenerazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DidatticaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuestionariToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DomandeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArgomentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DomandeDeiQuestionariToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessaggiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
