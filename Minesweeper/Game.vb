Module Game

    Public intRowCount As Integer
    Public intColCount As Integer
    Public intMineCount As Integer
    Public intCurrentPlayerMode As Integer             ' 0 = Flag, 1 = Dig
    Public intPlayingField(50, 50) As Integer          ' -2 = unclicked, -1 = flagged, 0 = empty, 1-8 number of bombs
    Public blnGameOver As Boolean = True
    Public blnFirstMove As Boolean = True
    Public blnPaused As Boolean = False

    Public intElapsedSeconds As Integer
    Public intTotalFlagged As Integer

    Public Sub NewGame()

        Form1.GameTimer.Enabled = False

        ClearFormButtons()

        ' gather game parameters from user
        frmNewGame.ShowDialog()

        ' prep/reset user interface
        Form1.lblTotalMines.Text = intMineCount.ToString
        Form1.lblFlaggedMines.Text = "0"
        Form1.lblTimeElapsed.Text = "00:00"
        Form1.Cursor = Cursors.UpArrow
        Form1.lblPause.Visible = False
        Form1.menuPause.Enabled = True

        ' prep/reset game variables
        blnGameOver = False
        blnFirstMove = True
        blnPaused = False
        intCurrentPlayerMode = 0
        intElapsedSeconds = 0
        intTotalFlagged = 0

        ' prep/reset the minefield matrix and the playing field matrix
        For row = 0 To intRowCount - 1
            For col = 0 To intColCount - 1

                Minefield.Minefield(row, col) = 0
                intPlayingField(row, col) = -2

            Next col
        Next row

        GenerateMines(intRowCount, intColCount, intMineCount)

        GenerateNumbers(intRowCount, intColCount)

        GenerateButtons(intRowCount, intColCount)

        '' TEMP inspect random generation of mines by putting it into a textbox
        'Form1.TextBox1.Text = ""
        'Form1.TextBox1.Visible = True
        'For i = 0 To intRowCount - 1
        '    For j = 0 To intColCount - 1

        '        Form1.TextBox1.Text &= Minefield.Minefield(i, j).ToString & "    "

        '    Next j
        '    Form1.TextBox1.Text &= vbNewLine
        'Next i

    End Sub


    Public Sub Flag(row As Integer, col As Integer, btn As Button)

        If intPlayingField(row, col) <> -2 Then Exit Sub ' only unclicked buttons can be flagged

        intPlayingField(row, col) = -1
        btn.Text = "#"
        intTotalFlagged += 1
        Form1.lblFlaggedMines.Text = intTotalFlagged.ToString

    End Sub

    Public Sub Unflag(row As Integer, col As Integer, btn As Button)

        If intPlayingField(row, col) <> -1 Then Exit Sub ' only flagged buttons can be unflagged

        intPlayingField(row, col) = -2
        btn.Text = ""
        intTotalFlagged -= 1
        Form1.lblFlaggedMines.Text = intTotalFlagged.ToString

    End Sub

    Public Sub Dig(row As Integer, col As Integer, btn As Button)

        If intPlayingField(row, col) <> -2 Then Exit Sub ' only unclicked buttons can be dug up

        Dim intUnderneath As Integer = Minefield.Minefield(row, col)   ' store the minefield number that is "underneath"

        Select Case intUnderneath

            Case -1 ' Player has dug up a bomb!
                btn.Text = "!!!"
                btn.FlatStyle = FlatStyle.Flat
                GameOver()

            Case 0 ' no number underneath
                intPlayingField(row, col) = intUnderneath
                btn.FlatStyle = FlatStyle.Flat
                DigSurrounding(row, col)

            Case Else
                intPlayingField(row, col) = intUnderneath
                btn.Text = intUnderneath.ToString
                btn.FlatStyle = FlatStyle.Flat
                CheckForWin()

        End Select

        
    End Sub

    Private Sub DigSurrounding(row As Integer, col As Integer)

        ' dig starting one row and column back, and going one row and column forward
        Dim intStartRow As Integer = row - 1
        Dim intEndRow As Integer = row + 1
        Dim intStartColumn As Integer = col - 1
        Dim intEndColumn As Integer = col + 1

        ' check for boundaries
        If intStartColumn < 0 Then intStartColumn = 0
        If intEndColumn > (intColCount - 1) Then intEndColumn = (intColCount - 1)
        If intStartRow < 0 Then intStartRow = 0
        If intEndRow > (intRowCount - 1) Then intEndRow = (intRowCount - 1)

        ' go through each position that is adjacent to the given position
        For i = intStartRow To intEndRow
            For j = intStartColumn To intEndColumn

                Dig(i, j, Buttons.btnGridButtons(i, j))

            Next j
        Next i

    End Sub

    Public Sub GameOver()

        MessageBox.Show("BOOM!", "GAME OVER!")
        blnGameOver = True
        Form1.GameTimer.Enabled = False
        Form1.menuPause.Enabled = False

    End Sub

    Private Sub CheckForWin()

        Dim intUnclickedCount As Integer = CountUnclickedLocations()

        If (intUnclickedCount + intTotalFlagged) = intMineCount Then ' the player has won!

            Form1.GameTimer.Enabled = False
            Form1.menuPause.Enabled = False
            blnGameOver = True
            MessageBox.Show("Congratulations! You've won!", "Complete!")

        End If

    End Sub

    Private Function CountUnclickedLocations() As Integer

        Dim intTotalUnclicked As Integer = 0

        For row = 0 To intRowCount - 1
            For col = 0 To intColCount - 1

                If intPlayingField(row, col) = -2 Then intTotalUnclicked += 1

            Next col
        Next row

        Return intTotalUnclicked
    End Function

End Module
