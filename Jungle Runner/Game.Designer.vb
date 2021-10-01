<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.picRunnerCenter = New System.Windows.Forms.PictureBox()
        Me.tmrMapElements = New System.Windows.Forms.Timer(Me.components)
        Me.picRunnerRight = New System.Windows.Forms.PictureBox()
        Me.picRunnerLeft = New System.Windows.Forms.PictureBox()
        Me.lblCoins = New System.Windows.Forms.Label()
        Me.grpWon = New System.Windows.Forms.GroupBox()
        Me.btnWonLevels = New System.Windows.Forms.Button()
        Me.btnNextLevel = New System.Windows.Forms.Button()
        Me.lblYouWon = New System.Windows.Forms.Label()
        Me.grpPause = New System.Windows.Forms.GroupBox()
        Me.btnPausedLevels = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblPaused = New System.Windows.Forms.Label()
        Me.picPause = New System.Windows.Forms.PictureBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblYouLost = New System.Windows.Forms.Label()
        Me.btnLoseLevels = New System.Windows.Forms.Button()
        Me.grpLost = New System.Windows.Forms.GroupBox()
        Me.lblLives = New System.Windows.Forms.Label()
        CType(Me.picRunnerCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRunnerRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRunnerLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWon.SuspendLayout()
        Me.grpPause.SuspendLayout()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLost.SuspendLayout()
        Me.SuspendLayout()
        '
        'picRunnerCenter
        '
        Me.picRunnerCenter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRunnerCenter.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.picRunnerCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRunnerCenter.Image = CType(resources.GetObject("picRunnerCenter.Image"), System.Drawing.Image)
        Me.picRunnerCenter.Location = New System.Drawing.Point(291, 466)
        Me.picRunnerCenter.Name = "picRunnerCenter"
        Me.picRunnerCenter.Size = New System.Drawing.Size(53, 63)
        Me.picRunnerCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRunnerCenter.TabIndex = 3
        Me.picRunnerCenter.TabStop = False
        '
        'tmrMapElements
        '
        Me.tmrMapElements.Enabled = True
        Me.tmrMapElements.Interval = 20
        '
        'picRunnerRight
        '
        Me.picRunnerRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRunnerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.picRunnerRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRunnerRight.Image = CType(resources.GetObject("picRunnerRight.Image"), System.Drawing.Image)
        Me.picRunnerRight.Location = New System.Drawing.Point(390, 466)
        Me.picRunnerRight.Name = "picRunnerRight"
        Me.picRunnerRight.Size = New System.Drawing.Size(53, 63)
        Me.picRunnerRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRunnerRight.TabIndex = 5
        Me.picRunnerRight.TabStop = False
        Me.picRunnerRight.Visible = False
        '
        'picRunnerLeft
        '
        Me.picRunnerLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRunnerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.picRunnerLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRunnerLeft.Image = CType(resources.GetObject("picRunnerLeft.Image"), System.Drawing.Image)
        Me.picRunnerLeft.Location = New System.Drawing.Point(195, 466)
        Me.picRunnerLeft.Name = "picRunnerLeft"
        Me.picRunnerLeft.Size = New System.Drawing.Size(53, 63)
        Me.picRunnerLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRunnerLeft.TabIndex = 4
        Me.picRunnerLeft.TabStop = False
        Me.picRunnerLeft.Visible = False
        '
        'lblCoins
        '
        Me.lblCoins.AutoSize = True
        Me.lblCoins.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblCoins.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCoins.ForeColor = System.Drawing.Color.White
        Me.lblCoins.Location = New System.Drawing.Point(519, 9)
        Me.lblCoins.Name = "lblCoins"
        Me.lblCoins.Size = New System.Drawing.Size(66, 20)
        Me.lblCoins.TabIndex = 0
        Me.lblCoins.Text = "Coins: 0"
        '
        'grpWon
        '
        Me.grpWon.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grpWon.Controls.Add(Me.btnWonLevels)
        Me.grpWon.Controls.Add(Me.btnNextLevel)
        Me.grpWon.Controls.Add(Me.lblYouWon)
        Me.grpWon.Location = New System.Drawing.Point(195, 140)
        Me.grpWon.Name = "grpWon"
        Me.grpWon.Size = New System.Drawing.Size(238, 216)
        Me.grpWon.TabIndex = 6
        Me.grpWon.TabStop = False
        Me.grpWon.Visible = False
        '
        'btnWonLevels
        '
        Me.btnWonLevels.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnWonLevels.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnWonLevels.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnWonLevels.Location = New System.Drawing.Point(121, 97)
        Me.btnWonLevels.Name = "btnWonLevels"
        Me.btnWonLevels.Size = New System.Drawing.Size(99, 91)
        Me.btnWonLevels.TabIndex = 2
        Me.btnWonLevels.Text = "Levels"
        Me.btnWonLevels.UseVisualStyleBackColor = False
        '
        'btnNextLevel
        '
        Me.btnNextLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnNextLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNextLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNextLevel.Location = New System.Drawing.Point(16, 97)
        Me.btnNextLevel.Name = "btnNextLevel"
        Me.btnNextLevel.Size = New System.Drawing.Size(99, 91)
        Me.btnNextLevel.TabIndex = 1
        Me.btnNextLevel.Text = "Next Level"
        Me.btnNextLevel.UseVisualStyleBackColor = False
        '
        'lblYouWon
        '
        Me.lblYouWon.AutoSize = True
        Me.lblYouWon.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblYouWon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.lblYouWon.Location = New System.Drawing.Point(51, 39)
        Me.lblYouWon.Name = "lblYouWon"
        Me.lblYouWon.Size = New System.Drawing.Size(117, 29)
        Me.lblYouWon.TabIndex = 0
        Me.lblYouWon.Text = "You Won!"
        '
        'grpPause
        '
        Me.grpPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grpPause.Controls.Add(Me.btnPausedLevels)
        Me.grpPause.Controls.Add(Me.btnContinue)
        Me.grpPause.Controls.Add(Me.lblPaused)
        Me.grpPause.Location = New System.Drawing.Point(195, 140)
        Me.grpPause.Name = "grpPause"
        Me.grpPause.Size = New System.Drawing.Size(238, 216)
        Me.grpPause.TabIndex = 7
        Me.grpPause.TabStop = False
        Me.grpPause.Visible = False
        '
        'btnPausedLevels
        '
        Me.btnPausedLevels.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnPausedLevels.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPausedLevels.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPausedLevels.Location = New System.Drawing.Point(16, 151)
        Me.btnPausedLevels.Name = "btnPausedLevels"
        Me.btnPausedLevels.Size = New System.Drawing.Size(204, 50)
        Me.btnPausedLevels.TabIndex = 2
        Me.btnPausedLevels.Text = "Levels"
        Me.btnPausedLevels.UseVisualStyleBackColor = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnContinue.Location = New System.Drawing.Point(16, 98)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(204, 47)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'lblPaused
        '
        Me.lblPaused.AutoSize = True
        Me.lblPaused.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPaused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.lblPaused.Location = New System.Drawing.Point(71, 39)
        Me.lblPaused.Name = "lblPaused"
        Me.lblPaused.Size = New System.Drawing.Size(95, 29)
        Me.lblPaused.TabIndex = 0
        Me.lblPaused.Text = "Paused"
        '
        'picPause
        '
        Me.picPause.BackColor = System.Drawing.Color.White
        Me.picPause.Image = CType(resources.GetObject("picPause.Image"), System.Drawing.Image)
        Me.picPause.Location = New System.Drawing.Point(12, 9)
        Me.picPause.Name = "picPause"
        Me.picPause.Size = New System.Drawing.Size(38, 39)
        Me.picPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPause.TabIndex = 8
        Me.picPause.TabStop = False
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRestart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRestart.Location = New System.Drawing.Point(16, 98)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(204, 47)
        Me.btnRestart.TabIndex = 4
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'lblYouLost
        '
        Me.lblYouLost.AutoSize = True
        Me.lblYouLost.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblYouLost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.lblYouLost.Location = New System.Drawing.Point(50, 39)
        Me.lblYouLost.Name = "lblYouLost"
        Me.lblYouLost.Size = New System.Drawing.Size(113, 29)
        Me.lblYouLost.TabIndex = 3
        Me.lblYouLost.Text = "You Lost!"
        '
        'btnLoseLevels
        '
        Me.btnLoseLevels.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnLoseLevels.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLoseLevels.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLoseLevels.Location = New System.Drawing.Point(16, 151)
        Me.btnLoseLevels.Name = "btnLoseLevels"
        Me.btnLoseLevels.Size = New System.Drawing.Size(204, 50)
        Me.btnLoseLevels.TabIndex = 5
        Me.btnLoseLevels.Text = "Levels"
        Me.btnLoseLevels.UseVisualStyleBackColor = False
        '
        'grpLost
        '
        Me.grpLost.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grpLost.Controls.Add(Me.btnLoseLevels)
        Me.grpLost.Controls.Add(Me.lblYouLost)
        Me.grpLost.Controls.Add(Me.btnRestart)
        Me.grpLost.Location = New System.Drawing.Point(195, 140)
        Me.grpLost.Name = "grpLost"
        Me.grpLost.Size = New System.Drawing.Size(238, 216)
        Me.grpLost.TabIndex = 9
        Me.grpLost.TabStop = False
        Me.grpLost.Visible = False
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLives.ForeColor = System.Drawing.Color.White
        Me.lblLives.Location = New System.Drawing.Point(524, 38)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(62, 20)
        Me.lblLives.TabIndex = 10
        Me.lblLives.Text = "Lives: 0"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(627, 541)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.grpLost)
        Me.Controls.Add(Me.picPause)
        Me.Controls.Add(Me.grpPause)
        Me.Controls.Add(Me.grpWon)
        Me.Controls.Add(Me.lblCoins)
        Me.Controls.Add(Me.picRunnerRight)
        Me.Controls.Add(Me.picRunnerLeft)
        Me.Controls.Add(Me.picRunnerCenter)
        Me.DoubleBuffered = True
        Me.Name = "Game"
        Me.Text = "Jungle Runner"
        CType(Me.picRunnerCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRunnerRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRunnerLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWon.ResumeLayout(False)
        Me.grpWon.PerformLayout()
        Me.grpPause.ResumeLayout(False)
        Me.grpPause.PerformLayout()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLost.ResumeLayout(False)
        Me.grpLost.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRunnerCenter As PictureBox
    Friend WithEvents tmrMapElements As Timer
    Friend WithEvents picRunnerRight As PictureBox
    Friend WithEvents picRunnerLeft As PictureBox
    Friend WithEvents lblCoins As Label
    Friend WithEvents grpWon As GroupBox
    Friend WithEvents btnNextLevel As Button
    Friend WithEvents lblYouWon As Label
    Friend WithEvents btnWonLevels As Button
    Friend WithEvents grpPause As GroupBox
    Friend WithEvents btnPausedLevels As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents lblPaused As Label
    Friend WithEvents picPause As PictureBox
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblYouLost As Label
    Friend WithEvents btnLoseLevels As Button
    Friend WithEvents grpLost As GroupBox
    Friend WithEvents lblLives As Label
End Class
