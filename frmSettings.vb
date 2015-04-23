Public Class frmSettings

    Private Sub frmSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim BoundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim BoundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim X As Integer = BoundWidth - Me.Width
        Dim Y As Integer = BoundHeight - Me.Height
        Me.Location = New Point(X / 2, Y / 2)

        txtScoreboardName.Text = frmScoreboard.ScoreboardName
        txtHomeTeam.Text = frmScoreboard.HomeTeamName
        txtAwayTeam.Text = frmScoreboard.AwayTeamName
        txtCountdownFrom.Text = frmScoreboard.CountdownFrom
        chkPlayBuzzerAtZeros.Checked = frmScoreboard.PlayBuzzerAtZeros
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        btnApply_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        frmScoreboard.ScoreboardName = txtScoreboardName.Text
        frmScoreboard.HomeTeamName = txtHomeTeam.Text
        frmScoreboard.AwayTeamName = txtAwayTeam.Text
        frmScoreboard.CountdownFrom = txtCountdownFrom.Text
        frmScoreboard.PlayBuzzerAtZeros = chkPlayBuzzerAtZeros.Checked
        frmScoreboard.UpdateNames()
        frmScoreboard.ResetClock()
    End Sub

End Class