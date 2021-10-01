Public Class Level_Menu
    Private Sub Level_Menu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'MAKE A LIST OF ALL OF THE BUTTONS
        Dim buttons() As Button = {btnLevel1, btnLevel2, btnLevel3, btnLevel4, btnLevel5, btnLevel6, btnLevel7, btnLevel8, btnLevel9, btnLevel10, btnLevel11, btnLevel12, btnLevel13, btnLevel14, btnLevel15, btnLevel16, btnLevel17, btnLevel18, btnLevel19, btnLevel20, btnLevel21, btnLevel22, btnLevel23, btnLevel24, btnLevel25, btnLevel26, btnLevel27, btnLevel28, btnLevel29, btnLevel30}
        'MAKE ALL OF THE UUNLOCKED LEVELS ENABLED
        For pos As Integer = 0 To unlockedLevels - 1
            buttons(pos).Enabled = True
        Next
        'LOCK THE REST OF THE BUTTONS
        For pos As Integer = unlockedLevels To buttons.Length - 1
            buttons(pos).Enabled = False
        Next
    End Sub

    Private Sub btnLevel1_Click(sender As Object, e As EventArgs) Handles btnLevel1.Click, btnLevel2.Click, btnLevel3.Click, btnLevel4.Click, btnLevel5.Click, btnLevel6.Click, btnLevel7.Click, btnLevel8.Click, btnLevel9.Click, btnLevel10.Click, btnLevel11.Click, btnLevel12.Click, btnLevel13.Click, btnLevel14.Click, btnLevel15.Click, btnLevel16.Click, btnLevel17.Click, btnLevel18.Click, btnLevel19.Click, btnLevel20.Click, btnLevel21.Click, btnLevel22.Click, btnLevel23.Click, btnLevel24.Click, btnLevel25.Click, btnLevel26.Click, btnLevel27.Click, btnLevel28.Click, btnLevel29.Click, btnLevel30.Click
        'IF EITHER ONE OF THE LEVEL BUTTONS ARE CLICKED,
        'PLAY THE BUTTON CLICK SHOUND
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SET LEVELNUM TO THE LEVEL NUMBER
        levelNum = sender.Text()
        'CALCULATE ALL OF THE LEVEL PARAMETERS
        levelLength = Int((Val(levelNum) - 1) * 3.1 + 10)
        levelDensity = levelLength - Int(levelLength / 4)
        levelSpeed = Int((Val(levelNum) - 1) * 0.93 + 3)
        levelDistance = Int(300 \ levelSpeed)

        'GENERATES NEW LEVEL
        currentLevel = New Level(levelLength, levelDensity, levelDistance, levelSpeed)
        'SHOW POWERUP SCREEN
        PowerUp.Show()
        Me.Hide()
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        'IF THE SHOP BUTTON IS CLICKED,
        'PLAY BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW SHOP
        Me.Hide()
        Shop.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'IF THE HELP BUTTON IS CLICKED,
        'PLAY THE BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW HELP
        Me.Hide()
        Help.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'IF THE MENU BUTTON IS CLICKED,
        'PLAY THE BUTTON CILCK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW MAIN MENU
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'IF THE SAVE BUTTON IS CLICKED
        'PLAY THE BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW SAVE SCREEN
        Me.Hide()
        Save_Profile.Show()
    End Sub

    Private Sub Level_Menu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class