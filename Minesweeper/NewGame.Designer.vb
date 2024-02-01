<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewGame
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudRows = New System.Windows.Forms.NumericUpDown()
        Me.nudColumns = New System.Windows.Forms.NumericUpDown()
        Me.nudMines = New System.Windows.Forms.NumericUpDown()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radBeginner = New System.Windows.Forms.RadioButton()
        Me.radIntermediate = New System.Windows.Forms.RadioButton()
        Me.radExpert = New System.Windows.Forms.RadioButton()
        Me.radCustom = New System.Windows.Forms.RadioButton()
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select your game settings:"
        '
        'nudRows
        '
        Me.nudRows.Location = New System.Drawing.Point(109, 17)
        Me.nudRows.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudRows.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudRows.Name = "nudRows"
        Me.nudRows.Size = New System.Drawing.Size(50, 20)
        Me.nudRows.TabIndex = 1
        Me.nudRows.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'nudColumns
        '
        Me.nudColumns.Location = New System.Drawing.Point(109, 43)
        Me.nudColumns.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudColumns.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudColumns.Name = "nudColumns"
        Me.nudColumns.Size = New System.Drawing.Size(50, 20)
        Me.nudColumns.TabIndex = 2
        Me.nudColumns.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'nudMines
        '
        Me.nudMines.Location = New System.Drawing.Point(109, 69)
        Me.nudMines.Maximum = New Decimal(New Integer() {1250, 0, 0, 0})
        Me.nudMines.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMines.Name = "nudMines"
        Me.nudMines.Size = New System.Drawing.Size(50, 20)
        Me.nudMines.TabIndex = 3
        Me.nudMines.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(67, 166)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnRules
        '
        Me.btnRules.Location = New System.Drawing.Point(234, 166)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Size = New System.Drawing.Size(75, 23)
        Me.btnRules.TabIndex = 5
        Me.btnRules.Text = "Rules..."
        Me.btnRules.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nudRows)
        Me.GroupBox1.Controls.Add(Me.nudColumns)
        Me.GroupBox1.Controls.Add(Me.nudMines)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(178, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Custom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mines:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Columns:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rows:"
        '
        'radBeginner
        '
        Me.radBeginner.AutoSize = True
        Me.radBeginner.Checked = True
        Me.radBeginner.Location = New System.Drawing.Point(15, 46)
        Me.radBeginner.Name = "radBeginner"
        Me.radBeginner.Size = New System.Drawing.Size(99, 17)
        Me.radBeginner.TabIndex = 7
        Me.radBeginner.TabStop = True
        Me.radBeginner.Text = "Beginner (9 x 9)"
        Me.radBeginner.UseVisualStyleBackColor = True
        '
        'radIntermediate
        '
        Me.radIntermediate.AutoSize = True
        Me.radIntermediate.Location = New System.Drawing.Point(15, 69)
        Me.radIntermediate.Name = "radIntermediate"
        Me.radIntermediate.Size = New System.Drawing.Size(127, 17)
        Me.radIntermediate.TabIndex = 8
        Me.radIntermediate.Text = "Intermediate (16 x 16)"
        Me.radIntermediate.UseVisualStyleBackColor = True
        '
        'radExpert
        '
        Me.radExpert.AutoSize = True
        Me.radExpert.Location = New System.Drawing.Point(15, 92)
        Me.radExpert.Name = "radExpert"
        Me.radExpert.Size = New System.Drawing.Size(99, 17)
        Me.radExpert.TabIndex = 9
        Me.radExpert.Text = "Expert (16 x 30)"
        Me.radExpert.UseVisualStyleBackColor = True
        '
        'radCustom
        '
        Me.radCustom.AutoSize = True
        Me.radCustom.Location = New System.Drawing.Point(15, 115)
        Me.radCustom.Name = "radCustom"
        Me.radCustom.Size = New System.Drawing.Size(60, 17)
        Me.radCustom.TabIndex = 10
        Me.radCustom.Text = "Custom"
        Me.radCustom.UseVisualStyleBackColor = True
        '
        'frmNewGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 201)
        Me.ControlBox = False
        Me.Controls.Add(Me.radCustom)
        Me.Controls.Add(Me.radExpert)
        Me.Controls.Add(Me.radIntermediate)
        Me.Controls.Add(Me.radBeginner)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRules)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewGame"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "New Game"
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudRows As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudColumns As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMines As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnRules As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radBeginner As System.Windows.Forms.RadioButton
    Friend WithEvents radIntermediate As System.Windows.Forms.RadioButton
    Friend WithEvents radExpert As System.Windows.Forms.RadioButton
    Friend WithEvents radCustom As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
