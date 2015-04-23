<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScoreboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScoreboard))
        Me.lblScoreboardName = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.lblHomeTeam = New System.Windows.Forms.Label()
        Me.lblAwayTeam = New System.Windows.Forms.Label()
        Me.imgHomeLeft = New System.Windows.Forms.PictureBox()
        Me.imgHomeRight = New System.Windows.Forms.PictureBox()
        Me.imgAwayLeft = New System.Windows.Forms.PictureBox()
        Me.imgAwayRight = New System.Windows.Forms.PictureBox()
        Me.clkCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.imgMinuteLeft = New System.Windows.Forms.PictureBox()
        Me.imgMinuteRight = New System.Windows.Forms.PictureBox()
        Me.imgSecondRight = New System.Windows.Forms.PictureBox()
        Me.imgSecondLeft = New System.Windows.Forms.PictureBox()
        Me.imgColon = New System.Windows.Forms.PictureBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.imgHomeLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHomeRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAwayLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAwayRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgMinuteLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgMinuteRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSecondRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSecondLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgColon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScoreboardName
        '
        Me.lblScoreboardName.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreboardName.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.lblScoreboardName.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreboardName.ForeColor = System.Drawing.Color.White
        Me.lblScoreboardName.Location = New System.Drawing.Point(0, 1)
        Me.lblScoreboardName.Name = "lblScoreboardName"
        Me.lblScoreboardName.Size = New System.Drawing.Size(1024, 103)
        Me.lblScoreboardName.TabIndex = 1
        Me.lblScoreboardName.Text = "NAME OF SCOREBOARD"
        Me.lblScoreboardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(980, 741)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSettings.Location = New System.Drawing.Point(2, 741)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(55, 23)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.BackColor = System.Drawing.Color.Transparent
        Me.lblHomeTeam.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.lblHomeTeam.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeTeam.ForeColor = System.Drawing.Color.White
        Me.lblHomeTeam.Location = New System.Drawing.Point(59, 435)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(448, 53)
        Me.lblHomeTeam.TabIndex = 4
        Me.lblHomeTeam.Text = "HOME TEAM"
        Me.lblHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.BackColor = System.Drawing.Color.Transparent
        Me.lblAwayTeam.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.lblAwayTeam.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayTeam.ForeColor = System.Drawing.Color.White
        Me.lblAwayTeam.Location = New System.Drawing.Point(521, 435)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(450, 53)
        Me.lblAwayTeam.TabIndex = 5
        Me.lblAwayTeam.Text = "AWAY TEAM"
        Me.lblAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgHomeLeft
        '
        Me.imgHomeLeft.BackColor = System.Drawing.Color.Transparent
        Me.imgHomeLeft.Image = Global.Scoreboard.My.Resources.Resources.g_all_on
        Me.imgHomeLeft.Location = New System.Drawing.Point(115, 502)
        Me.imgHomeLeft.Name = "imgHomeLeft"
        Me.imgHomeLeft.Size = New System.Drawing.Size(160, 224)
        Me.imgHomeLeft.TabIndex = 6
        Me.imgHomeLeft.TabStop = False
        '
        'imgHomeRight
        '
        Me.imgHomeRight.BackColor = System.Drawing.Color.Transparent
        Me.imgHomeRight.Image = Global.Scoreboard.My.Resources.Resources.g_all_on
        Me.imgHomeRight.Location = New System.Drawing.Point(286, 502)
        Me.imgHomeRight.Name = "imgHomeRight"
        Me.imgHomeRight.Size = New System.Drawing.Size(160, 224)
        Me.imgHomeRight.TabIndex = 7
        Me.imgHomeRight.TabStop = False
        '
        'imgAwayLeft
        '
        Me.imgAwayLeft.BackColor = System.Drawing.Color.Transparent
        Me.imgAwayLeft.Image = Global.Scoreboard.My.Resources.Resources.g_all_on
        Me.imgAwayLeft.Location = New System.Drawing.Point(581, 502)
        Me.imgAwayLeft.Name = "imgAwayLeft"
        Me.imgAwayLeft.Size = New System.Drawing.Size(160, 224)
        Me.imgAwayLeft.TabIndex = 8
        Me.imgAwayLeft.TabStop = False
        '
        'imgAwayRight
        '
        Me.imgAwayRight.BackColor = System.Drawing.Color.Transparent
        Me.imgAwayRight.Image = Global.Scoreboard.My.Resources.Resources.g_all_on
        Me.imgAwayRight.Location = New System.Drawing.Point(751, 502)
        Me.imgAwayRight.Name = "imgAwayRight"
        Me.imgAwayRight.Size = New System.Drawing.Size(160, 224)
        Me.imgAwayRight.TabIndex = 9
        Me.imgAwayRight.TabStop = False
        '
        'clkCountdown
        '
        '
        'imgMinuteLeft
        '
        Me.imgMinuteLeft.BackColor = System.Drawing.Color.Transparent
        Me.imgMinuteLeft.Image = Global.Scoreboard.My.Resources.Resources.r_all_on
        Me.imgMinuteLeft.Location = New System.Drawing.Point(115, 130)
        Me.imgMinuteLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.imgMinuteLeft.Name = "imgMinuteLeft"
        Me.imgMinuteLeft.Size = New System.Drawing.Size(175, 245)
        Me.imgMinuteLeft.TabIndex = 10
        Me.imgMinuteLeft.TabStop = False
        '
        'imgMinuteRight
        '
        Me.imgMinuteRight.BackColor = System.Drawing.Color.Transparent
        Me.imgMinuteRight.Image = Global.Scoreboard.My.Resources.Resources.r_all_on
        Me.imgMinuteRight.Location = New System.Drawing.Point(307, 130)
        Me.imgMinuteRight.Margin = New System.Windows.Forms.Padding(0)
        Me.imgMinuteRight.Name = "imgMinuteRight"
        Me.imgMinuteRight.Size = New System.Drawing.Size(176, 245)
        Me.imgMinuteRight.TabIndex = 11
        Me.imgMinuteRight.TabStop = False
        '
        'imgSecondRight
        '
        Me.imgSecondRight.BackColor = System.Drawing.Color.Transparent
        Me.imgSecondRight.Image = Global.Scoreboard.My.Resources.Resources.r_all_on
        Me.imgSecondRight.Location = New System.Drawing.Point(736, 130)
        Me.imgSecondRight.Margin = New System.Windows.Forms.Padding(0)
        Me.imgSecondRight.Name = "imgSecondRight"
        Me.imgSecondRight.Size = New System.Drawing.Size(175, 245)
        Me.imgSecondRight.TabIndex = 12
        Me.imgSecondRight.TabStop = False
        '
        'imgSecondLeft
        '
        Me.imgSecondLeft.BackColor = System.Drawing.Color.Transparent
        Me.imgSecondLeft.Image = Global.Scoreboard.My.Resources.Resources.r_all_on
        Me.imgSecondLeft.Location = New System.Drawing.Point(544, 130)
        Me.imgSecondLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.imgSecondLeft.Name = "imgSecondLeft"
        Me.imgSecondLeft.Size = New System.Drawing.Size(175, 245)
        Me.imgSecondLeft.TabIndex = 13
        Me.imgSecondLeft.TabStop = False
        '
        'imgColon
        '
        Me.imgColon.BackColor = System.Drawing.Color.Transparent
        Me.imgColon.Image = Global.Scoreboard.My.Resources.Resources.r_dots_on
        Me.imgColon.Location = New System.Drawing.Point(496, 130)
        Me.imgColon.Margin = New System.Windows.Forms.Padding(0)
        Me.imgColon.Name = "imgColon"
        Me.imgColon.Size = New System.Drawing.Size(35, 245)
        Me.imgColon.TabIndex = 14
        Me.imgColon.TabStop = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHelp.Location = New System.Drawing.Point(56, 741)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(37, 23)
        Me.btnHelp.TabIndex = 15
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'frmScoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Scoreboard.My.Resources.Resources.scoreboard
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.imgColon)
        Me.Controls.Add(Me.imgSecondLeft)
        Me.Controls.Add(Me.imgSecondRight)
        Me.Controls.Add(Me.imgMinuteRight)
        Me.Controls.Add(Me.imgMinuteLeft)
        Me.Controls.Add(Me.imgAwayRight)
        Me.Controls.Add(Me.imgAwayLeft)
        Me.Controls.Add(Me.imgHomeRight)
        Me.Controls.Add(Me.imgHomeLeft)
        Me.Controls.Add(Me.lblAwayTeam)
        Me.Controls.Add(Me.lblHomeTeam)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblScoreboardName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScoreboard"
        Me.Text = "Scoreboard"
        CType(Me.imgHomeLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHomeRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAwayLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAwayRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgMinuteLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgMinuteRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSecondRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSecondLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgColon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblScoreboardName As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Private WithEvents lblHomeTeam As System.Windows.Forms.Label
    Private WithEvents lblAwayTeam As System.Windows.Forms.Label
    Friend WithEvents imgHomeLeft As System.Windows.Forms.PictureBox
    Friend WithEvents imgHomeRight As System.Windows.Forms.PictureBox
    Friend WithEvents imgAwayLeft As System.Windows.Forms.PictureBox
    Friend WithEvents imgAwayRight As System.Windows.Forms.PictureBox
    Friend WithEvents clkCountdown As System.Windows.Forms.Timer
    Friend WithEvents imgMinuteLeft As System.Windows.Forms.PictureBox
    Friend WithEvents imgMinuteRight As System.Windows.Forms.PictureBox
    Friend WithEvents imgSecondRight As System.Windows.Forms.PictureBox
    Friend WithEvents imgSecondLeft As System.Windows.Forms.PictureBox
    Friend WithEvents imgColon As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button

End Class
