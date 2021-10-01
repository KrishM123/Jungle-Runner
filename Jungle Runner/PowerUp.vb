Public Class PowerUp

    Private Sub PowerUp_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'SHOW THE OWNED POWERUPS
        lblOwnedCoins.Text = "Owned: " & doubleCoins
        lblOwnedSlows.Text = "Owned: " & slows
    End Sub

    Private Sub btnUseCoins_Click(sender As Object, e As EventArgs) Handles btnUseCoins.Click
        'PLAYS THE BUTTON AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'DOUBLE THE COLLECTED COINS AND GET RID OF A POWERUP
        If doubleCoins >= 1 Then
            doubleCoins -= 1
            coinMultiplier = 2
            Me.Hide()
            Game.Show()
        End If
    End Sub

    Private Sub btnUseSlow_Click(sender As Object, e As EventArgs) Handles btnUseSlow.Click
        'PLAYS THE BUTTON CLICKED AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        coinMultiplier = 1
        If slows >= 1 Then
            'SLOW THE LEVEL AND REGENERATE IT
            slows -= 1
            levelSpeed = levelSpeed / 2
            levelDistance = levelDistance * 2
            currentLevel = New Level(levelLength, levelDensity, levelDistance, levelSpeed)
            Me.Hide()
            Game.Show()
        End If
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        'PLAYS THE BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        coinMultiplier = 1
        'SHOWS GAME
        Me.Hide()
        Game.Show()
    End Sub

    Private Sub PowerUp_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class