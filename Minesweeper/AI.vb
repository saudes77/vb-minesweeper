Module AI
    'NOTE: The AI can only see what a human player can see. At no time does it get to "peek" at the minefield underneath unclicked tiles.

    Dim intRandom As New Random(DateTime.Now.Millisecond)
    
    Public Sub AIFirstMove()

        Form1.AITimer.Enabled = True

        Dim intStartRow As Integer = intRandom.Next(intRowCount)
        Dim intStartCol As Integer = intRandom.Next(intColCount)

        Dig(intStartRow, intStartCol, btnGridButtons(intStartRow, intStartCol))

    End Sub

    Private Sub NumberBasedSearch(rows As Integer, cols As Integer)

        For row = 0 To rows - 1

            For col = 0 To cols - 1

                ' select a tile and determine if there are number tiles adjacent to it.
                If NumbersAdjacent(row, col) Then ' there is at least one number adjacent



                End If

            Next col

        Next row

    End Sub


    Private Sub ProbabilityBasedSearch()


    End Sub


    Private Function NumbersAdjacent(row As Integer, col As Integer) As Boolean

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

                ' determine if the position is a number
                If Game.intPlayingField(i, j) > 0 Then Return True

            Next j
        Next i

        Return False
    End Function

End Module
