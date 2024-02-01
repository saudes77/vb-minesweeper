Module Minefield

    Public Minefield(50, 50) As Integer

    Dim intRandom As New Random(DateTime.Now.Millisecond)

    Public Sub GenerateMines(rowCount As Integer, colCount As Integer, mineCount As Integer)

        Dim intMineRow As Integer
        Dim intMineColumn As Integer

        For i = 1 To mineCount

            Do ' generate a random place for a mine
                intMineRow = intRandom.Next(0, rowCount)
                intMineColumn = intRandom.Next(0, colCount)

                ' ensure that this spot is empty first
            Loop Until Minefield(intMineRow, intMineColumn) <> -1

            Minefield(intMineRow, intMineColumn) = -1 ' place the mine

        Next i

    End Sub

    Public Sub GenerateNumbers(rows As Integer, cols As Integer)

        For i = 0 To rows - 1
            For j = 0 To cols - 1

                If Minefield(i, j) = -1 Then ' there is a bomb at (i,j)

                    IncrementSurroundingNumbers(i, j, rows, cols)

                End If

            Next j
        Next i

    End Sub

    Private Sub IncrementSurroundingNumbers(intMineRow As Integer, intMineColumn As Integer, intRowCount As Integer, intColCount As Integer)

        ' increment starting one row and column back, and going one row and column forward
        Dim intStartRow As Integer = intMineRow - 1
        Dim intEndRow As Integer = intMineRow + 1
        Dim intStartColumn As Integer = intMineColumn - 1
        Dim intEndColumn As Integer = intMineColumn + 1

        ' check for boundaries
        If intStartColumn < 0 Then intStartColumn = 0
        If intEndColumn > (intColCount - 1) Then intEndColumn = (intColCount - 1)
        If intStartRow < 0 Then intStartRow = 0
        If intEndRow > (intRowCount - 1) Then intEndRow = (intRowCount - 1)

        ' go through each position that is adjacent to the given position
        For i = intStartRow To intEndRow
            For j = intStartColumn To intEndColumn

                ' increment positions that do not contain bombs
                If Minefield(i, j) >= 0 Then Minefield(i, j) += 1

            Next j
        Next i

    End Sub

End Module
