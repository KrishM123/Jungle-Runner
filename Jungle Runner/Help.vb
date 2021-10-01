Public Class Help
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'WHEN THE MENU BUTTON IS CLICKED,
        'PLAY BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW MAIN MENU
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        'WHEN THE SHOP BUTTON IS CLICKED,
        'PLAY BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW SHOP
        Me.Hide()
        Shop.Show()
    End Sub

    Private Sub btnLevels_Click(sender As Object, e As EventArgs) Handles btnLevels.Click
        'WHEN THE LEVELS BUTTON IS CLICKED,
        'PLAY BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW LEVELS MENU
        Me.Hide()
        Level_Menu.Show()
    End Sub

    Private Sub Help_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class