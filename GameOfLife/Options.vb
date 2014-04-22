Public Class Options

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim a As Color = Color.Green
        Dim d As Color = Color.White
        Dim r As Integer = Val(txtRandom.Text)

        If (cboAliveColor.SelectedIndex = 0) Then
            a = Color.Green
        ElseIf (cboAliveColor.SelectedIndex = 1) Then
            a = Color.Red
        ElseIf (cboAliveColor.SelectedIndex = 2) Then
            a = Color.Blue
        ElseIf (cboAliveColor.SelectedIndex = 3) Then
            a = Color.White
        ElseIf (cboAliveColor.SelectedIndex = 4) Then
            a = Color.Black
        End If
        If (cboDeadColor.SelectedIndex = 0) Then
            d = Color.Green
        ElseIf (cboDeadColor.SelectedIndex = 1) Then
            d = Color.Red
        ElseIf (cboDeadColor.SelectedIndex = 2) Then
            d = Color.Blue
        ElseIf (cboDeadColor.SelectedIndex = 3) Then
            d = Color.White
        ElseIf (cboDeadColor.SelectedIndex = 4) Then
            d = Color.Black
        End If
        Me.Hide()
        Form1.getBoard().setRandomModular(r)
        Form1.getBoard().setColorScheme(a, d)
        Form1.getBoard().updateCellColor()
        Form1.Refresh()
    End Sub 'Sets the bg color and alive cell color

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class