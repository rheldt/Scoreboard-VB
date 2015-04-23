Imports System.Media

Public Class frmScoreboard

    Private Const HTCAPTION As Long = 2
    Private Const WM_NCLBUTTONDOWN = &HA1S

    Public ScoreboardName As String = "SCOREBOARD"
    Public HomeTeamName As String = "HOME TEAM"
    Public AwayTeamName As String = "AWAY TEAM"
    Public CountdownFrom As String = "01:10"
    Public PlayBuzzerAtZeros As Boolean = True

    Private HomeScore As Integer = 0
    Private AwayScore As Integer = 0
    Private CountdownClock As Integer
    Private ClockRequiresReset As Boolean = False

    Private Sub frmScoreboard_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim BoundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim BoundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim X As Integer = BoundWidth - Me.Width
        Dim Y As Integer = BoundHeight - Me.Height
        Me.Location = New Point(X / 2, Y / 2)

        imgHomeLeft.Image = My.Resources.ResourceManager.GetObject("g_0")
        imgHomeRight.Image = My.Resources.ResourceManager.GetObject("g_0")
        imgAwayLeft.Image = My.Resources.ResourceManager.GetObject("g_0")
        imgAwayRight.Image = My.Resources.ResourceManager.GetObject("g_0")

        imgMinuteLeft.Image = My.Resources.ResourceManager.GetObject("r_0")
        imgMinuteRight.Image = My.Resources.ResourceManager.GetObject("r_0")
        imgSecondLeft.Image = My.Resources.ResourceManager.GetObject("r_0")
        imgSecondRight.Image = My.Resources.ResourceManager.GetObject("r_0")

        UpdateNames()
        ResetClock()
    End Sub

    Private Sub frmScoreboard_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar.ToString = "q" Then
            ' Increase home score
            HomeScore = HomeScore + 1
            If HomeScore > 99 Then
                HomeScore = 99
            End If
        ElseIf e.KeyChar.ToString = "a" Then
            ' Decrease home score
            HomeScore = HomeScore - 1
            If HomeScore < 0 Then
                HomeScore = 0
            End If
        ElseIf e.KeyChar.ToString = "w" Then
            ' Increase away score
            AwayScore = AwayScore + 1
            If AwayScore > 99 Then
                AwayScore = 99
            End If
        ElseIf e.KeyChar.ToString = "s" Then
            ' Decrease away score
            AwayScore = AwayScore - 1
            If AwayScore < 0 Then
                AwayScore = 0
            End If
        ElseIf e.KeyChar.ToString = "c" Then
            ' Start/stop clock
            clkCountdown.Enabled = Not clkCountdown.Enabled
        ElseIf e.KeyChar.ToString = "r" Then
            ' Reset clock
            ResetClock()
        ElseIf e.KeyChar.ToString = "b" Then
            ' Play buzzer
            PlayBuzzer()
        End If

        If HomeScore < 10 Then
            imgHomeLeft.Image = My.Resources.ResourceManager.GetObject("g_0")
            imgHomeRight.Image = My.Resources.ResourceManager.GetObject("g_" & HomeScore.ToString)
        Else
            imgHomeLeft.Image = My.Resources.ResourceManager.GetObject("g_" & HomeScore.ToString.First)
            imgHomeRight.Image = My.Resources.ResourceManager.GetObject("g_" & HomeScore.ToString.Last)
        End If

        If AwayScore < 10 Then
            imgAwayLeft.Image = My.Resources.ResourceManager.GetObject("g_0")
            imgAwayRight.Image = My.Resources.ResourceManager.GetObject("g_" & AwayScore.ToString)
        Else
            imgAwayLeft.Image = My.Resources.ResourceManager.GetObject("g_" & AwayScore.ToString.First)
            imgAwayRight.Image = My.Resources.ResourceManager.GetObject("g_" & AwayScore.ToString.Last)
        End If
    End Sub

    Private Sub lblScoreboardName_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblScoreboardName.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lblScoreboardName.Capture = False
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub clkCountdown_Tick(sender As System.Object, e As System.EventArgs) Handles clkCountdown.Tick
        If Not ClockRequiresReset Then
            CountdownClock = CountdownClock - clkCountdown.Interval
            UpdateClock()
        End If
    End Sub

    Private Sub btnSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnSettings.Click
        frmSettings.Show()
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        frmHelp.Show()
    End Sub

    Public Sub UpdateNames()
        lblScoreboardName.Text = ScoreboardName
        lblHomeTeam.Text = HomeTeamName
        lblAwayTeam.Text = AwayTeamName
    End Sub

    Public Sub ResetClock()
        Dim Minutes As String = Mid(CountdownFrom, 1, 2)
        Dim Seconds As String = Mid(CountdownFrom, 4, 2)
        CountdownClock = (Minutes * 60 * 1000) + (Seconds * 1000)
        ClockRequiresReset = False
        clkCountdown.Enabled = False
        UpdateClock()
    End Sub

    Private Sub UpdateClock()
        Dim TimeLeft As String = Now.Subtract(Now.Add(TimeSpan.FromMilliseconds(CountdownClock))).ToString("mmssf")
        Dim Minutes As String = Mid(TimeLeft, 1, 2)
        Dim Seconds As String = Mid(TimeLeft, 3, 2)
        Dim Tenths As String = Mid(TimeLeft, 5, 1)

        If Convert.ToInt32(TimeLeft) <= 0 Then
            imgMinuteLeft.Image = My.Resources.ResourceManager.GetObject("r_0")
            imgMinuteRight.Image = My.Resources.ResourceManager.GetObject("r_0")
            imgSecondLeft.Image = My.Resources.ResourceManager.GetObject("r_0")
            imgSecondRight.Image = My.Resources.ResourceManager.GetObject("r_0")
            imgColon.Image = My.Resources.ResourceManager.GetObject("r_dots_on")
            clkCountdown.Enabled = False
            ClockRequiresReset = True
            If PlayBuzzerAtZeros Then
                PlayBuzzer()
            End If
        Else
            If Convert.ToInt32(Minutes) < 1 Then
                imgMinuteLeft.Image = My.Resources.ResourceManager.GetObject("r_" & Seconds.First)
                imgMinuteRight.Image = My.Resources.ResourceManager.GetObject("r_" & Seconds.Last)
                imgSecondLeft.Image = My.Resources.ResourceManager.GetObject("r_decimal")
                imgSecondRight.Image = My.Resources.ResourceManager.GetObject("r_" & Tenths)
                imgColon.Image = My.Resources.ResourceManager.GetObject("r_dots_off")
            Else
                imgMinuteLeft.Image = My.Resources.ResourceManager.GetObject("r_" & Minutes.First)
                imgMinuteRight.Image = My.Resources.ResourceManager.GetObject("r_" & Minutes.Last)
                imgSecondLeft.Image = My.Resources.ResourceManager.GetObject("r_" & Seconds.First)
                imgSecondRight.Image = My.Resources.ResourceManager.GetObject("r_" & Seconds.Last)
                If Convert.ToInt32(Seconds) Mod 2 = 0 Then
                    imgColon.Image = My.Resources.ResourceManager.GetObject("r_dots_on")
                Else
                    imgColon.Image = My.Resources.ResourceManager.GetObject("r_dots_off")
                End If
            End If
        End If
    End Sub

    Private Sub PlayBuzzer()
        Dim Player As New SoundPlayer(My.Resources.buzzer)
        Player.Play()
    End Sub

End Class