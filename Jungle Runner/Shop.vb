Public Class Shop

    Private Sub Shop_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'SHOW WHAT THE USER CURRENTLY POSSESSES
        lblCurrentBalance.Text = "Current Balance: " & Str(coins)
        lblOwnedCoins.Text = "Owned: " & Str(doubleCoins)
        lblOwnedLives.Text = "Owned: " & Str(lives)
        lblOwnedSlows.Text = "Owned: " & Str(slows)
    End Sub

    Private Sub btnBuyCoins_Click(sender As Object, e As EventArgs) Handles btnBuyCoins.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'IF ENOUGH COINS, BUY THE POWERUP AND DISPLAY THE UPDATED NUMBERS
        If coins >= 5 Then
            doubleCoins += 1
            coins -= 5
        End If
        lblOwnedCoins.Text = "Owned: " & Str(doubleCoins)
        lblCurrentBalance.Text = "Current Balance: " & Str(coins)
    End Sub

    Private Sub btnSellCoins_Click(sender As Object, e As EventArgs) Handles btnSellCoins.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'IF ENOUGH POWERUPS, BUY THE POWERUP AND DISPLAY THE UPDATED NUMBERS
        If doubleCoins >= 1 Then
            doubleCoins -= 1
            coins += 4
        End If
        lblOwnedCoins.Text = "Owned: " & Str(doubleCoins)
        lblCurrentBalance.Text = "Current Balance: " & Str(coins)
    End Sub

    Private Sub btnBuySlow_Click(sender As Object, e As EventArgs) Handles btnBuySlow.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'IF ENOUGH COINS, BUY THE POWERUP AND DISPLAY THE UPDATED NUMBERS
        If coins >= 7 Then
            slows += 1
            coins -= 7
        End If
        lblOwnedSlows.Text = "Owned: " & Str(slows)
        lblCurrentBalance.Text = "Current Balance: " & Str(coins)
    End Sub

    Private Sub btnSellSlow_Click(sender As Object, e As EventArgs) Handles btnSellSlow.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'IF ENOUGH POWERUPS, BUY THE POWERUP AND DISPLAY THE UPDATED NUMBERS
        If slows >= 1 Then
            slows -= 1
            coins += 6
        End If
        lblOwnedSlows.Text = "Owned: " & Str(slows)
        lblCurrentBalance.Text = "Current Balance: " & Str(coins)
    End Sub

    Private Sub btnBuyLives_Click(sender As Object, e As EventArgs) Handles btnBuyLives.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'IF ENOUGH COINS, BUY THE POWERUP AND DISPLAY THE UPDATED NUMBERS
        If coins >= 10 Then
            lives += 1
            coins -= 10
        End If
        lblOwnedLives.Text = "Owned: " & Str(lives)
        lblCurrentBalance.Text = "Current Balance: " & Str(coins)
    End Sub

    Private Sub btnSellLives_Click(sender As Object, e As EventArgs) Handles btnSellLives.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'IF ENOUGH POWERUPS, BUY THE POWERUP AND DISPLAY THE UPDATED NUMBERS
        If lives >= 2 Then
            lives -= 2
            coins += 9
        End If
        lblOwnedLives.Text = "Owned: " & Str(lives)
        lblCurrentBalance.Text = "Current Balance: " & Str(coins)
    End Sub

    Private Sub btnLevels_Click(sender As Object, e As EventArgs) Handles btnLevels.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'OPENS LEVEL FORM
        Me.Hide()
        Level_Menu.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'OPENS HELP FORM
        Me.Hide()
        Help.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'OPENS MENU FORM
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub Shop_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class