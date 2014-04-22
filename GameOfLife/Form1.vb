'Imports System.IO

Public Class Form1
    'Garrett Beatty
    'Game Of Life

    'declare variables

    Dim board As Board = New Board()
    Dim preGameRunning As Boolean = False
    Dim gameRunning As Boolean = False
    Dim paused As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    Dim mouseDown1 As Boolean = False
    Dim help As String = "Left Click- Make Cell Alive. Right Click- Make Cell Dead. S-Start Game. C-Clear. P-Pause. H-Help. G-Hide/Show Grid. O-Options. R-Random Board. I-Increase Speed. L-Lower Speed."
    Dim dir As String

    Private Sub startPreGame()
        lblB.Visible = False
        lblMyName.Visible = False
        lblName.Visible = False
        btnStart.Visible = False
        mnuStrip.Visible = False
        preGameRunning = True
        Me.Refresh()
    End Sub 'starts pre game

    Public Sub startGame()
        gameRunning = True
        preGameRunning = False
        updater.Enabled = True
    End Sub 'starts game

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If (preGameRunning Or gameRunning) Then
            board.drawBoard(sender, e)
        End If
    End Sub ' paints form

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        mouseX = e.X
        mouseY = e.Y
        If (mouseDown1) Then
            If (preGameRunning And e.Button = Windows.Forms.MouseButtons.Left) Then
                board.makeCell(mouseX, mouseY)
                Me.Refresh()
            ElseIf (preGameRunning And e.Button = Windows.Forms.MouseButtons.Right) Then
                board.killCell(mouseX, mouseY)
                Me.Refresh()
            End If
        End If
    End Sub 'used for updating mouse x/y. and dragging

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If (preGameRunning And e.Button = Windows.Forms.MouseButtons.Left) Then
            board.makeCell(mouseX, mouseY)
            Me.Refresh()
        ElseIf (preGameRunning And e.Button = Windows.Forms.MouseButtons.Right) Then
            board.killCell(mouseX, mouseY)
            Me.Refresh()
        End If
    End Sub 'mouse press

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mouseDown1 = False
    End Sub ' tells when user lets go of mouse

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        mouseDown1 = True
    End Sub 'Mouse press. used for holding down

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        startPreGame()
    End Sub 'Starts pre game

    Private Sub updater_Tick(sender As Object, e As EventArgs) Handles updater.Tick
        board.updateNeighbors()
        board.updateCells()
        board.resetNeighbors()
        Me.Refresh()
    End Sub 'Refreshes screen

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show(help)
    End Sub 'Help Bar

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'start
        If e.KeyCode = Keys.S Then
            If (preGameRunning) Then
                startGame()
            End If
        End If

        'If (e.KeyCode = Keys.J) Then
        '    board.setScale(board.getScale() * 1.5)
        '    board.updateScale()
        '    gameRunning = False
        '    updater.Enabled = False
        '    preGameRunning = True
        '    Me.Refresh()
        'End If

        'If (e.KeyCode = Keys.U) Then
        '    board.setScale(board.getScale() / 1.5)
        '    board.updateScale()
        '    gameRunning = False
        '    updater.Enabled = False
        '    preGameRunning = True
        '    Me.Refresh()
        'End If

        If (e.KeyCode = Keys.I) Then
            If (updater.Interval > 10) Then
                updater.Interval = updater.Interval - 10
            End If
        End If

        If (e.KeyCode = Keys.L) Then
            updater.Interval = updater.Interval + 10
        End If

        If (e.KeyCode = Keys.R And preGameRunning) Then
            board.resetBoard()
            board.randomBoard()
            Me.Refresh()
        End If

        'options
        If e.KeyCode = Keys.O Then
            If (gameRunning) Then
                updater.Enabled = False
                paused = True
            End If
            Options.Show()
        End If

        'clear
        If e.KeyCode = Keys.C Then
            board.resetBoard()
            updater.Enabled = False
            preGameRunning = True
            gameRunning = False
            Me.Refresh()
        End If

        'Pause
        If (e.KeyCode = Keys.P And gameRunning) Then
            If (paused) Then
                paused = False
                updater.Enabled = True
            Else
                paused = True
                updater.Enabled = False
            End If
        End If

        'help
        If e.KeyCode = Keys.H Then
            MessageBox.Show(help)
        End If

        If (e.KeyCode = Keys.G) Then
            If (board.getGridShown) Then
                board.setGridShown(False)
                Me.Refresh()
            Else
                board.setGridShown(True)
                Me.Refresh()
            End If
        End If

        'If (e.KeyCode = Keys.Z) Then
        '    My.Computer.FileSystem.WriteAllText(dir + "\save.txt", board.saveLayout(), False)
        '    MessageBox.Show("Saved")
        'End If

        'If (e.KeyCode = Keys.L) Then
        '    Dim s As String
        '    s = My.Computer.FileSystem.ReadAllText(dir + "\save.txt")
        '    board.loadBoard(s)
        '    MessageBox.Show(s)
        '    Me.Refresh()
        'End If

    End Sub ' Keypresses

    Public Function getBoard() As Board
        Return board
    End Function 'gets the current board

    Public Function getGameRunning() As Boolean
        Return gameRunning
    End Function ' tells if simulation is happening

    Public Function getPreGameRunning() As Boolean
        Return preGameRunning
    End Function 'Tells if person is selecting squares

    Public Sub setPaused(ByVal b As Boolean)
        paused = b
    End Sub 'Sets game to paused

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dir = Directory.GetCurrentDirectory()
        PlayBackgroundSoundFile()
    End Sub 'Starts music

    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play(CurDir() + "\music.wav", _
            AudioPlayMode.Background)
    End Sub 'Plays music

End Class
