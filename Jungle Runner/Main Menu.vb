'NAME: KRISH MODI
'PROJECT: FINAL PROJECT - JUNGLE RUNNER
'DESCRIPTION: AN ENDLESS RUNNER GAME

Public Class Main_Menu
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'PLAY BUTTON CLICK SOUND
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        'SHOW LEVEL MENU
        Level_Menu.Show()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'PLAY BUTTON CLICK SOUND
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW LOAD PROFILE
        Me.Hide()
        Load_Profile.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'PLAY BUTTON CLICK SOUND
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW HELP
        Me.Hide()
        Help.Show()
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        'PLAY BUTTON CLICK SOUND
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW SHOP
        Me.Hide()
        Shop.Show()
    End Sub

    Private Sub Main_Menu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class