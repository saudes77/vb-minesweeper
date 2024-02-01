Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NewGame()

    End Sub


    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        Select Case e.KeyChar.ToString

            Case "d", "D"
                intCurrentPlayerMode = 1 ' the player is now in "dig" mode
                lblPlayerMode.Text = "Dig"
                lblPlayerMode.ForeColor = Color.Crimson
                Me.Cursor = Cursors.PanSW

            Case "f", "F"
                intCurrentPlayerMode = 0 ' the player is now in "flag" mode
                lblPlayerMode.Text = "Flag"
                lblPlayerMode.ForeColor = Color.Goldenrod
                Me.Cursor = Cursors.UpArrow

        End Select

    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        intElapsedSeconds += 1

        Dim intMinutes As Integer = intElapsedSeconds \ 60
        Dim intSeconds As Integer = intElapsedSeconds Mod 60

        Dim strMinutes As String = intMinutes.ToString
        Dim strSeconds As String = intSeconds.ToString

        If strMinutes.Length = 1 Then strMinutes = "0" & strMinutes
        If strSeconds.Length = 1 Then strSeconds = "0" & strSeconds

        lblTimeElapsed.Text = strMinutes & ":" & strSeconds

    End Sub

    Private Sub menuNewGame_Click(sender As Object, e As EventArgs) Handles menuNewGame.Click

        NewGame()

    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click

        Me.Close()

    End Sub

    Private Sub menuPause_Click(sender As Object, e As EventArgs) Handles menuPause.Click


        If blnPaused Then ' unpause the game
            blnPaused = False
            menuPause.Text = "Pause"
            lblPause.Visible = False
            GameTimer.Enabled = True

        Else ' pause the game
            blnPaused = True
            menuPause.Text = "Unpause"
            lblPause.Visible = True
            GameTimer.Enabled = False

        End If

    End Sub

End Class
