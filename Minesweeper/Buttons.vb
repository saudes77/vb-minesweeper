Module Buttons

    Const intBUTTON_HEIGHT_WIDTH As Integer = 25
    Const intBUTTON_SPACING As Integer = 5
    Const intGRID_LEFT As Integer = 10
    Const intGRID_TOP As Integer = 34

    Public btnGridButtons(50, 50) As Button

    Public Sub GenerateButtons(intRows As Integer, intCols As Integer)

        Dim intRowPosition As Integer = intGRID_TOP
        Dim intColPosition As Integer = intGRID_LEFT

        For row = 0 To intRows - 1

            For col = 0 To intCols - 1

                ' create a new button
                Dim btnButton As Button = New Button

                ' assign the appropriate properties
                btnButton.Name = "btn" & row.ToString & "-" & col.ToString
                btnButton.Width = intBUTTON_HEIGHT_WIDTH
                btnButton.Height = intBUTTON_HEIGHT_WIDTH
                btnButton.BackColor = Color.LimeGreen

                ' associate button with a position in the minefield
                Dim gridPosition As Point = New Point(row, col)
                btnButton.Tag = gridPosition

                ' give the button a handler for the click event
                AddHandler btnButton.Click, AddressOf ButtonHandler

                ' add the button to the form
                Form1.Controls.Add(btnButton)

                ' place the button in the right spot on the form
                Dim PositionPoint As System.Drawing.Point = New System.Drawing.Point(intColPosition, intRowPosition)
                btnButton.Location = PositionPoint

                ' store button in the button matrix
                btnGridButtons(row, col) = btnButton

                ' increment intColPosition for the next button
                intColPosition += (intBUTTON_HEIGHT_WIDTH + intBUTTON_SPACING)

                ' adjust grid margins on right and bottom
                If (row = intRows - 1) And (col = intCols - 1) Then

                    Dim margin As Padding = New Padding(0, 0, 100, 10)

                    btnButton.Margin = margin

                End If

            Next col

            intColPosition = intGRID_LEFT
            intRowPosition += (intBUTTON_HEIGHT_WIDTH + intBUTTON_SPACING)

        Next row

    End Sub

    Public Sub ButtonHandler(sender As Object, e As EventArgs)

        If Game.blnGameOver Then Exit Sub

        ' start the game timer when the player makes the first move
        If Game.blnFirstMove Then
            Form1.GameTimer.Enabled = True
            blnFirstMove = False
        End If

        Dim pos As Point = sender.Tag
        Dim row As Integer = pos.X
        Dim col As Integer = pos.Y

        Select Case Game.intCurrentPlayerMode

            Case 0 ' current mode is flag
                If Game.intPlayingField(row, col) <> -1 Then ' the button is not currently flagged
                    Game.Flag(row, col, sender)
                Else
                    Game.Unflag(row, col, sender)
                End If

            Case 1 ' current mode is dig
                Game.Dig(row, col, sender)

        End Select

    End Sub

    Public Sub ClearFormButtons()

        For i = 0 To intRowCount - 1
            For j = 0 To intColCount - 1

                Form1.Controls.Remove(btnGridButtons(i, j))

            Next j
        Next i


    End Sub

End Module
