Public Class Game
    'CURRENTPOSITION STORES THE CURRENT POSITION THE THE PLAYER
    Dim currentPosition As Integer = 1
    'GAME GAMEGOING STORES IF THE GAME SHOULD ALLOW THE USER TO MOVE THE CHARACTER
    Dim gameGoing As Boolean

    Private Sub Game_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'WHEN THE FORM IS ACTIVATED, START THE TIMER AND ALLOW THE CHARACTER TO MOVE
        tmrMapElements.Start()
        gameGoing = True
        grpPause.Visible = False
        btnContinue.Enabled = False
        btnPausedLevels.Enabled = False
    End Sub

    Private Sub FormMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'IF THE USER PRESSES THE RIGHT KEY AND THE CHARACTER IS NOT LOCKED,
        If e.KeyValue = Keys.Right And gameGoing Then
            'INCREASE CURRENT POSITION
            currentPosition += 1
            If currentPosition = 3 Then
                'DOESN'T ALLOW CURRENT POSITION TO GO ABOVE 2
                currentPosition = 2
            End If
        End If
        'IF THE USER PRESSES THE LEFT KEY AND THE CHARACTER IS NOT LOCKED,
        If e.KeyValue = Keys.Left And gameGoing Then
            'DECREASE CURRENT POSITION
            currentPosition -= 1
            If currentPosition = -1 Then
                'DOESN'T ALLOW CURRENT POSITION TO GO BELOW 0
                currentPosition = 0
            End If
        End If
        'MOVES THE CHARACTER ACCORDING TO CURRENTPOSITION
        Select Case currentPosition
            'IF CURRENTPOSITION IS 0, SHOW LEFT RUNNER
            Case 0
                picRunnerLeft.Visible = True
                picRunnerCenter.Visible = False
                picRunnerRight.Visible = False
            'IF CURRENTPOSITION IS 1, SHOW THE MIDDLE RUNNER
            Case 1
                picRunnerLeft.Visible = False
                picRunnerCenter.Visible = True
                picRunnerRight.Visible = False
            'IF CURRENTPOSITION IS 2, SHOW THE RIGHT RUNNER
            Case 2
                picRunnerLeft.Visible = False
                picRunnerCenter.Visible = False
                picRunnerRight.Visible = True
        End Select
    End Sub

    Private Sub tmrMapElements_Tick(sender As Object, e As EventArgs) Handles tmrMapElements.Tick
        'BASED ON THE CURRENTPOSITION, PASSES THE ACTIVE PICTUREBOX TO CHECK FOR COLLISION
        Select Case currentPosition
            Case 0
                currentLevel.updateMap(picRunnerLeft)
            Case 1
                currentLevel.updateMap(picRunnerCenter)
            Case 2
                currentLevel.updateMap(picRunnerRight)
        End Select

        'DISPLAYS THE COINS COLLECTED AND THE LIVES LEFT OF THE USER
        lblCoins.Text = "Coins: " & Str(currentLevel.coinsCollected * coinMultiplier)
        lblLives.Text = "Lives: " & Str(lives - currentLevel.cratesHit)

        'IF THE USER RUNS OUT OF LIVES,
        If currentLevel.cratesHit = lives Then
            'GIVE USER ONE LIFE
            lives = 1
            'SHOW THAT THE USER HAS LOST
            grpLost.Visible = True
            btnLoseLevels.Enabled = True
            btnRestart.Enabled = True
            'STOP THE MAPELEMENTS AND LOCK THE RUNNER
            tmrMapElements.Stop()
            gameGoing = False
        End If

        'IF THE USER FINISHED THE GAME,
        If currentLevel.finished = True Then
            'STOP THE MAPELEMENTS AND LOCK THE RUNNER
            tmrMapElements.Stop()
            gameGoing = False
            'SHOW THAT THE USER HAS WON
            grpWon.Visible = True
            btnNextLevel.Enabled = True
            btnWonLevels.Enabled = True
            'TAKE AWAY THE LIVES THAT THE USER LOST
            lives -= currentLevel.cratesHit
            'STORE ALL OF THE COINS THAT THE USER COLLECTED
            coins += currentLevel.coinsCollected * coinMultiplier
            'INCREASE THE NUMBER OF LEVELS THAT THE USER CAN PLAY
            If levelNum = unlockedLevels Then
                unlockedLevels += 1
            End If
        End If
    End Sub

    Private Sub picPause_Click(sender As Object, e As EventArgs) Handles picPause.Click
        'IF THE PAUSE BUTTON IS CLICKED,
        'PLAY THE BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'STOP THE MAP ELEMENTS AND LOCK THE RUNNER
        tmrMapElements.Stop()
        gameGoing = False
        'SHOW THE PAUSED POPUP
        grpPause.Visible = True
        btnPausedLevels.Enabled = True
        btnContinue.Enabled = True
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'IF THE CONTINUE BUTTON IS CLICKED ON THE PAUSE SCREEN,
        'PLAY THE BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'START THE MAPELEMENTS AND UNLOCK THE RUNNER
        tmrMapElements.Start()
        gameGoing = True
        'HIDE THE PAUSED POPUP
        grpPause.Visible = False
        btnPausedLevels.Enabled = False
        btnContinue.Enabled = False
    End Sub

    Private Sub btnPausedLevels_Click(sender As Object, e As EventArgs) Handles btnPausedLevels.Click
        'IF THE LEVELS BUTTON WAS CLICKED IN THE PAUSE MENU
        'PLAY THE BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SUBTRACT THE LIVES LOST BY THE USER IN THIS LEVEL
        lives -= currentLevel.cratesHit
        'CLEAR THE MAP OF ALL OF THE MAPELEMENTS
        currentLevel.clearMap()
        'HIDE THE PAUSE POPUP
        grpPause.Visible = False
        btnPausedLevels.Enabled = False
        btnContinue.Enabled = False
        'SHOW THE LEVEL MENU FORM
        Me.Hide()
        Level_Menu.Show()
    End Sub

    Private Sub btnWonLevels_Click(sender As Object, e As EventArgs) Handles btnWonLevels.Click
        'IF THE LEVELS BUTTON IS CLICKED IN THE WON POPUP,
        'PLAY THE BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'CLEAR THE MAP OF ALL MAPELEMENTS
        currentLevel.clearMap()
        'HIDE THE WON POPUP
        grpWon.Visible = False
        btnWonLevels.Enabled = False
        btnNextLevel.Enabled = False
        'SHOW THE LEVEL MENU
        Me.Hide()
        Level_Menu.Show()
    End Sub

    Private Sub btnNextLevel_Click(sender As Object, e As EventArgs) Handles btnNextLevel.Click
        'IF THE NEXT LEVEL BUTTON IS CLICKED,
        'PLAY THE BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'CLEAR THE MAP OF ALL MAPELEMENTS
        currentLevel.clearMap()
        'INCREASE THE CURRENT LEVEL
        levelNum += 1
        If levelNum = 31 Then
            'THERE ARE ONLY 30 LEVELS SO THE USER WILL GO BACK TO LEVEL ONE AFTER THEY HAVE WON
            levelNum = 1
        End If

        'CALCULATE ALL OF THE PARAMETERS FOR THE NEXT LEVEL BASED ON LEVEL NUMBER
        Dim length As Integer = Int((Val(levelNum) - 1) * 3.1 + 10)
        Dim density As Integer = length - Int(length / 4)
        Dim speed As Integer = Int((Val(levelNum) - 1) * 0.93 + 3)
        Dim distance As Integer = Int(300 \ speed)

        'GENERATE THE NEXT LEVEL
        currentLevel = New Level(length, density, distance, speed)

        'HIDE THE WON POPUP BOX
        grpWon.Visible = False
        btnNextLevel.Enabled = False
        btnWonLevels.Enabled = False

        'SHOW THE POWERUP SCREEN
        Me.Hide()
        PowerUp.Show()
    End Sub

    Private Sub btnLoseLevels_Click(sender As Object, e As EventArgs) Handles btnLoseLevels.Click
        'IF THE USER CLICKS ON THE LEVELS BUTTON ON THE LOSE POPUP,
        'PLAY THE BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'CLEAR MAP OF ALL MAPELEMENTS
        currentLevel.clearMap()
        'HIDE THE LOST POPUP
        grpLost.Visible = False
        btnLoseLevels.Enabled = False
        btnRestart.Enabled = False
        'SHOW LEVEL MENU
        Me.Hide()
        Level_Menu.Show()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        'IF THE RESTART BUTTON IS CLICKED,
        'PLAY THE BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'CLEAR MAP OF ALL MAPELEMENTS
        currentLevel.clearMap()

        'RECALCULATE PARAMETERS OF THE MAP BASED ON CURRENT LEVEL
        Dim length As Integer = Int((Val(levelNum) - 1) * 3.1 + 10)
        Dim density As Integer = length - Int(length / 4)
        Dim speed As Integer = Int((Val(levelNum) - 1) * 0.93 + 3)
        Dim distance As Integer = Int(300 \ speed)

        'REGENERATE CURRENT LEVEL
        currentLevel = New Level(length, density, distance, speed)

        'HIDE THE LOST POPUP
        grpLost.Visible = False
        btnLoseLevels.Enabled = False
        btnRestart.Enabled = False
        'SHOW POWERUP SCREEN
        Me.Hide()
        PowerUp.Show()
    End Sub

    Private Sub Game_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
