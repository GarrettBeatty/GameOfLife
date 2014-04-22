Public Class Cell

    'Declare variables
    Private alive As Boolean
    Private neighbors As Integer
    Private color As Color
    Private aliveColor As Color = Drawing.Color.Green
    Private deadColor As Color = Drawing.Color.White
    Private location As Point

    Public Sub New()
        alive = False 'By default sets cells to dead
    End Sub

    Public Function getAlive() As Boolean
        Return alive 'returns if alive
    End Function

    Public Sub setAlive(ByVal b As Boolean)
        alive = b 'sets alive
    End Sub

    Public Sub setColor(ByVal b As Color)
        color = b 'set color
    End Sub

    Public Function getColor() As Color
        Return color 'returns color
    End Function

    Public Sub setAliveColor(ByVal b As Color)
        aliveColor = b 'sets alive color
    End Sub

    Public Sub setDeadColor(ByVal b As Color)
        deadColor = b 'sets dead color
    End Sub

    Public Function getAliveColor() As Color
        Return aliveColor 'returns alive color
    End Function

    Public Function getDeadColor() As Color
        Return deadColor 'returns dead color
    End Function

    Public Sub setNeighbors(ByVal n As Integer)
        neighbors = n 'sets number of neighbors
    End Sub

    Public Function getNeighbors() As Integer
        Return neighbors 'gets number of neighboard
    End Function

    Public Sub updateAliveness()
        If (neighbors < 2) Then 'if cell has less than 2 neighbors, it dies
            alive = False
            color = deadColor
        End If
        If (neighbors > 3) Then 'if cell has more than 3 neighbors it dies.
            alive = False
            color = deadColor
        End If
        If (alive = False And neighbors = 3) Then 'if cell is dead and it has 3 neighbors it becomes alive
            alive = True
            color = aliveColor
        End If
    End Sub

    Public Sub updateColor()
        If (Form1.getPreGameRunning() Or Form1.getGameRunning()) Then  'updates color manually
            If (alive = False) Then
                color = deadColor
            Else
                color = aliveColor
            End If
        End If
    End Sub

End Class
