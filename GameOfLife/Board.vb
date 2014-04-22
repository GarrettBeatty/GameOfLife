Public Class Board
    'Garrett Beatty
    'Code is highly innificient because it checks all the cells, instead of just alive cells


    'Declare variables
    Private cells(numCols, numRows) As Cell
    Private recs(numCols, numRows) As Rectangle
    Private widthOfCell As Integer
    Private heightOfCell As Integer
    Private numCols As Integer
    Private numRows As Integer
    Private grid As Pen = Pens.Black
    Private gridShown As Boolean = True
    'Private scale As Integer = 1
    Private randomModular As Integer = 4

    Public Sub New()

        widthOfCell = 8 'Sets width of one cell to 8
        heightOfCell = 8 'Sets height of one cell to 8
        numRows = 100 'num cells in a row
        numCols = 100 'num cells in a col

        ReDim cells(numCols, numRows) 'updates array
        ReDim recs(numCols, numRows) 'updates array

        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2
                cells(j, i) = New Cell 'creates a new cell
                recs(j, i) = New Rectangle 'creates a new rectangle
                recs(j, i).Width = widthOfCell 'sets width of rectangle to width of cell
                recs(j, i).Height = heightOfCell ' sets height of rectangle to height of cell

                If (j <> 0) Then
                    recs(j, i).X = recs(j - 1, i).X + widthOfCell 'puts rectangles next to eachother
                Else
                    recs(j, i).X = widthOfCell 'prevents error
                End If
                If (i <> 0) Then
                    recs(j, i).Y = recs(j, i - 1).Y + heightOfCell 'puts rectangle below eachother
                Else
                    recs(j, i).Y = heightOfCell 'prevents erro
                End If
                cells(j, i).setColor(Color.White) 'sets default color to white
                cells(j, i).setAliveColor(cells(j, i).getAliveColor) 'sets alive color 
                cells(j, i).setDeadColor(cells(j, i).getDeadColor) ' sets dead color
            Next
        Next
    End Sub

    Public Sub drawBoard(sender As Object, e As PaintEventArgs) ' Draw Board
        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2
                e.Graphics.FillRectangle(New SolidBrush(cells(j, i).getColor()), recs(j, i)) 'draws all the rectangles
                If (gridShown) Then
                    e.Graphics.DrawRectangle(grid, recs(j, i)) 'draws grid
                End If
            Next
        Next
    End Sub

    Public Sub makeCell(ByVal x As Integer, ByVal y As Integer) ' Make Cell
        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2
                If (recs(j, i).Contains(x, y)) Then 'find where user clicked
                    cells(j, i).setColor(cells(j, i).getAliveColor()) 'changes color
                    cells(j, i).setAlive(True) 'sets cell to alive
                End If
            Next
        Next
    End Sub

    Public Sub killCell(ByVal x As Integer, ByVal y As Integer) ' Kill Cell
        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2
                If (recs(j, i).Contains(x, y)) Then 'find where user clicked
                    cells(j, i).setColor(cells(j, i).getDeadColor()) 'changes color
                    cells(j, i).setAlive(False) 'sets alive to false
                End If
            Next
        Next
    End Sub

    Public Sub updateNeighbors() ' Update Neighboards
        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2

                'All of this checks to see how many neighbors each cell has(8 possible locations)
                If (j < numCols - 2) Then
                    If (cells(j + 1, i).getAlive = True) Then
                        cells(j, i).setNeighbors(cells(j, i).getNeighbors + 1)
                    End If
                End If

                If (j <> 0) Then
                    If (cells(j - 1, i).getAlive = True) Then
                        cells(j, i).setNeighbors(cells(j, i).getNeighbors + 1)
                    End If
                End If

                If (i < numRows - 2) Then
                    If (cells(j, i + 1).getAlive = True) Then
                        cells(j, i).setNeighbors(cells(j, i).getNeighbors + 1)
                    End If
                End If

                If (i <> 0) Then
                    If (cells(j, i - 1).getAlive = True) Then
                        cells(j, i).setNeighbors(cells(j, i).getNeighbors + 1)
                    End If
                End If

                If (i < numRows - 2 And j < numCols - 2) Then
                    If (cells(j + 1, i + 1).getAlive = True) Then
                        cells(j, i).setNeighbors(cells(j, i).getNeighbors + 1)
                    End If
                End If

                If (j <> 0 And i < numRows - 2) Then
                    If (cells(j - 1, i + 1).getAlive = True) Then
                        cells(j, i).setNeighbors(cells(j, i).getNeighbors + 1)
                    End If
                End If


                If (j < numCols - 2 And i <> 0) Then
                    If (cells(j + 1, i - 1).getAlive = True) Then
                        cells(j, i).setNeighbors(cells(j, i).getNeighbors + 1)
                    End If
                End If

                If (j <> 0 And i <> 0) Then
                    If (cells(j - 1, i - 1).getAlive = True) Then
                        cells(j, i).setNeighbors(cells(j, i).getNeighbors + 1)
                    End If
                End If
                
            Next
        Next
    End Sub

    Public Sub updateCells() 'Updates Cells
        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2
                cells(j, i).updateAliveness() 'updates cell
            Next
        Next
    End Sub

    Public Sub resetNeighbors()
        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2
                cells(j, i).setNeighbors(0) 'Reset neighbors to zero
            Next
        Next
    End Sub

    Public Sub resetBoard()
        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2
                cells(j, i).setAlive(False) 'kills all cells
                cells(j, i).setColor(cells(j, i).getDeadColor()) 'changes color
            Next
        Next
    End Sub

    Public Sub setGridShown(ByVal b As Boolean)
        gridShown = b 'sets grid shown to true or false
    End Sub

    Public Function getGridShown() As Boolean
        Return gridShown 'says if grid is shown or not
    End Function

    Public Sub setColorScheme(ByVal a As Color, ByVal d As Color)
        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2
                cells(j, i).setAliveColor(a) 'sets the color scheme from user input
                cells(j, i).setDeadColor(d)
                grid = New Pen(a)
            Next
        Next
    End Sub

    Public Sub updateCellColor()
        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2
                cells(j, i).updateColor() 'updates cell color
            Next
        Next
    End Sub

    'Public Function saveLayout() As String
    '    Dim s As String = ""
    '    For j As Integer = 0 To numCols - 2
    '        For i As Integer = 0 To numRows - 2
    '            If (cells(j, i).getAlive()) Then
    '                s = s + "j" + Format(j) + "i" + Format(i) + vbNewLine
    '            End If
    '        Next
    '    Next
    '    Return s
    'End Function

    'Public Sub loadBoard(ByVal s As String)
    '    For i As Integer = 0 To s.Length - 2
    '        Dim x As Integer
    '        Dim y As Integer
    '        If (s.Chars(i).ToString = "j") Then
    '            If (i < s.Length - 2) Then 'prevents error
    '                If (s.Chars(i + 2).ToString = "i") Then 'If the digit does not have two digits(blank space after it)
    '                    Dim tempj As Integer = FormatNumber(s.Chars(i + 1).ToString)
    '                    x = tempj
    '                Else
    '                    Dim temps As String
    '                    Dim tempj As Integer
    '                    temps = s.Chars(i + 1) + s.Chars(i + 2)
    '                    tempj = FormatNumber(temps)
    '                    x = tempj
    '                End If
    '            End If
    '        End If

    '        If (s.Chars(i).ToString = "i") Then
    '            If (i < s.Length - 2) Then 'prevents error
    '                If (s.Chars(i + 2).ToString = "j") Then 'If the digit does not have two digits
    '                    Dim tempi As Integer = FormatNumber(s.Chars(i + 1).ToString)
    '                    y = tempi
    '                Else
    '                    Dim temps As String
    '                    Dim tempi As Integer
    '                    temps = s.Chars(i + 1) + s.Chars(i + 2)
    '                    tempi = FormatNumber(temps)
    '                    y = tempi
    '                End If
    '            End If
    '        End If
    '        cells(x, y).setAlive(True)
    '        cells(x, y).setColor(cells(x, y).getAliveColor())
    '    Next
    'End Sub

    'Public Sub setScale(ByVal t As Integer)
    '    scale = t
    'End Sub

    'Public Function getScale() As Integer
    '    Return scale
    'End Function

    'Public Sub updateScale()
    '    widthOfCell = 8 / scale
    '    heightOfCell = 8 / scale
    '    numRows = 100 * scale
    '    numCols = 100 * scale

    '    ReDim cells(numCols, numRows)
    '    ReDim recs(numCols, numRows)

    '    For j As Integer = 0 To numCols - 2
    '        For i As Integer = 0 To numRows - 2
    '            cells(j, i) = New Cell
    '            recs(j, i) = New Rectangle
    '            recs(j, i).Width = widthOfCell
    '            recs(j, i).Height = heightOfCell

    '            If (j <> 0) Then
    '                recs(j, i).X = recs(j - 1, i).X + widthOfCell
    '            Else
    '                recs(j, i).X = widthOfCell
    '            End If
    '            If (i <> 0) Then
    '                recs(j, i).Y = recs(j, i - 1).Y + heightOfCell
    '            Else
    '                recs(j, i).Y = heightOfCell
    '            End If
    '            cells(j, i).setColor(Color.White)
    '            cells(j, i).setAliveColor(cells(j, i).getAliveColor)
    '            cells(j, i).setDeadColor(cells(j, i).getDeadColor)
    '        Next
    '    Next
    'End Sub

    Public Sub randomBoard()
        For j As Integer = 0 To numCols - 2
            For i As Integer = 0 To numRows - 2
                Randomize()
                Dim r As Integer = System.DateTime.Now.Millisecond * (Rnd() * System.DateTime.Now.Second) 'gets a random number
                If (r Mod randomModular = 0) Then 'sees if number is divisible by the users input number
                    cells(j, i).setAlive(True) 'if it is makes cell alive
                    cells(j, i).setColor(cells(j, i).getAliveColor()) 'changes color
                End If
            Next
        Next
    End Sub

    Public Sub setRandomModular(ByVal r As Integer)
        randomModular = r 'sets the users divisible number
    End Sub

End Class
