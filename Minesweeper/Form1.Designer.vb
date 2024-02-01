<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTimeElapsed = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalMines = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFlaggedMines = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPlayerMode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPause = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHighScores = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRules = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.meneAI = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAboutAI = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPause = New System.Windows.Forms.Label()
        Me.AITimer = New System.Windows.Forms.Timer(Me.components)
        Me.menuAIGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAISettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(420, 63)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(214, 180)
        Me.TextBox1.TabIndex = 81
        Me.TextBox1.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightGray
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblTimeElapsed, Me.ToolStripStatusLabel3, Me.lblTotalMines, Me.ToolStripStatusLabel4, Me.lblFlaggedMines, Me.ToolStripStatusLabel2, Me.lblPlayerMode, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(637, 24)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(90, 316)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 82
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(85, 15)
        Me.ToolStripStatusLabel1.Text = "Time Elapsed:"
        '
        'lblTimeElapsed
        '
        Me.lblTimeElapsed.Margin = New System.Windows.Forms.Padding(0, 3, 0, 10)
        Me.lblTimeElapsed.Name = "lblTimeElapsed"
        Me.lblTimeElapsed.Size = New System.Drawing.Size(85, 15)
        Me.lblTimeElapsed.Text = "00:00"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(85, 15)
        Me.ToolStripStatusLabel3.Text = "Mines:"
        '
        'lblTotalMines
        '
        Me.lblTotalMines.Margin = New System.Windows.Forms.Padding(0, 3, 0, 10)
        Me.lblTotalMines.Name = "lblTotalMines"
        Me.lblTotalMines.Size = New System.Drawing.Size(85, 15)
        Me.lblTotalMines.Text = "10"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(85, 15)
        Me.ToolStripStatusLabel4.Text = "Flags:"
        '
        'lblFlaggedMines
        '
        Me.lblFlaggedMines.Margin = New System.Windows.Forms.Padding(0, 3, 0, 30)
        Me.lblFlaggedMines.Name = "lblFlaggedMines"
        Me.lblFlaggedMines.Size = New System.Drawing.Size(85, 15)
        Me.lblFlaggedMines.Text = "2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(85, 15)
        Me.ToolStripStatusLabel2.Text = "Current Mode:"
        '
        'lblPlayerMode
        '
        Me.lblPlayerMode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerMode.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblPlayerMode.Margin = New System.Windows.Forms.Padding(0, 3, 0, 50)
        Me.lblPlayerMode.Name = "lblPlayerMode"
        Me.lblPlayerMode.Size = New System.Drawing.Size(85, 16)
        Me.lblPlayerMode.Text = "Flag"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(85, 15)
        Me.ToolStripStatusLabel5.Text = "Flag (Press F)"
        Me.ToolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(85, 15)
        Me.ToolStripStatusLabel6.Text = "Dig (Press D)"
        Me.ToolStripStatusLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuGame, Me.meneAI, Me.menuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(727, 24)
        Me.MenuStrip1.TabIndex = 83
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuGame
        '
        Me.menuGame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNewGame, Me.menuPause, Me.menuHighScores, Me.menuExit})
        Me.menuGame.Name = "menuGame"
        Me.menuGame.ShortcutKeyDisplayString = ""
        Me.menuGame.Size = New System.Drawing.Size(50, 20)
        Me.menuGame.Text = "Game"
        '
        'menuNewGame
        '
        Me.menuNewGame.Name = "menuNewGame"
        Me.menuNewGame.ShortcutKeyDisplayString = ""
        Me.menuNewGame.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.menuNewGame.Size = New System.Drawing.Size(160, 22)
        Me.menuNewGame.Text = "New Game..."
        '
        'menuPause
        '
        Me.menuPause.Name = "menuPause"
        Me.menuPause.ShortcutKeyDisplayString = ""
        Me.menuPause.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.menuPause.Size = New System.Drawing.Size(160, 22)
        Me.menuPause.Text = "Pause"
        '
        'menuHighScores
        '
        Me.menuHighScores.Name = "menuHighScores"
        Me.menuHighScores.Size = New System.Drawing.Size(160, 22)
        Me.menuHighScores.Text = "High Scores..."
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(160, 22)
        Me.menuExit.Text = "Exit"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRules, Me.menuAbout})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(44, 20)
        Me.menuHelp.Text = "Help"
        '
        'menuRules
        '
        Me.menuRules.Name = "menuRules"
        Me.menuRules.Size = New System.Drawing.Size(116, 22)
        Me.menuRules.Text = "Rules..."
        '
        'menuAbout
        '
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(116, 22)
        Me.menuAbout.Text = "About..."
        '
        'meneAI
        '
        Me.meneAI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAboutAI, Me.menuAIGame, Me.menuAISettings})
        Me.meneAI.Name = "meneAI"
        Me.meneAI.Size = New System.Drawing.Size(127, 20)
        Me.meneAI.Text = "Artificial Intelligence"
        '
        'menuAboutAI
        '
        Me.menuAboutAI.Name = "menuAboutAI"
        Me.menuAboutAI.Size = New System.Drawing.Size(155, 22)
        Me.menuAboutAI.Text = "About the AI..."
        '
        'lblPause
        '
        Me.lblPause.BackColor = System.Drawing.Color.Aquamarine
        Me.lblPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPause.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPause.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.ForeColor = System.Drawing.Color.Indigo
        Me.lblPause.Location = New System.Drawing.Point(0, 0)
        Me.lblPause.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(727, 340)
        Me.lblPause.TabIndex = 84
        Me.lblPause.Text = "- Game Paused -"
        Me.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPause.Visible = False
        '
        'menuAIGame
        '
        Me.menuAIGame.Name = "menuAIGame"
        Me.menuAIGame.Size = New System.Drawing.Size(155, 22)
        Me.menuAIGame.Text = "Start AI Game..."
        '
        'menuAISettings
        '
        Me.menuAISettings.Name = "menuAISettings"
        Me.menuAISettings.Size = New System.Drawing.Size(155, 22)
        Me.menuAISettings.Text = "AI Settings..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(727, 340)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPause)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 383)
        Me.Name = "Form1"
        Me.Text = "Minesweeper"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTimeElapsed As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalMines As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblFlaggedMines As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPlayerMode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GameTimer As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNewGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPause As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHighScores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRules As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents meneAI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAboutAI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AITimer As System.Windows.Forms.Timer
    Friend WithEvents menuAIGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAISettings As System.Windows.Forms.ToolStripMenuItem

End Class
