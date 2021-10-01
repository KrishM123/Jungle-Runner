Imports System.IO

Public Class Save_Profile
    'STORES IF THERE IS AN EXISTING PROFILE
    Dim existingProfile As Boolean = False
    'STORES THE LINES IN THE FILE
    Dim fileLines() As String

    Private Sub Save_Profile_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lblIndicator.Text = ""
        'OPENS "PROFILES.TXT"
        Dim instance As New FileStream("Profiles.txt", FileMode.Open, FileAccess.Read)
        Dim textfile As New StreamReader(instance)
        Dim pos As Integer = 0
        'STORES THE TEXT FILE IN FILELINES
        Do While textfile.Peek <> -1
            ReDim Preserve fileLines(0 To pos + 1)
            fileLines(pos) = textfile.ReadLine()
            pos += 1
        Loop
        'CLOSES THE FILE
        textfile.Close()
        instance.Close()

        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'PLAYS BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'STORES USERNAME AND PASSWORD
        Dim enteredUsername As String = txtUsername.Text
        Dim enteredPassword As String = txtPassword.Text
        Dim oldLength As Integer
        'MAKES SURE THE USERNAME AND PASSWORD DONT CONTAIN SPACES
        If Not containsSpace(enteredUsername) And Not containsSpace(enteredPassword) Then
            If fileLines Is Nothing Then
                oldLength = 0
            Else
                'LOOKS FOR FOR PROFILE AND IF FOUND, UPADTES THE PROFILE IN THE TEXT FILE
                For profile As Integer = 0 To (fileLines.Length / 8) - 1
                    If Split(fileLines(profile * 8))(1) = enteredUsername Then
                        If Split(fileLines((profile * 8) + 1))(1) = enteredPassword Then
                            existingProfile = True
                            fileLines((profile * 8) + 2) = "Unlocked Levels:" & Str(unlockedLevels)
                            fileLines((profile * 8) + 3) = "Coins:" & Str(coins)
                            fileLines((profile * 8) + 4) = "2X Coins:" & Str(doubleCoins)
                            fileLines((profile * 8) + 5) = "Slows:" & Str(slows)
                            fileLines((profile * 8) + 6) = "Lives:" & Str(lives)
                        End If
                    End If
                Next
                oldLength = fileLines.Length - 1
            End If
            'IF PROFILE IS NOT ALREADY EXISTING, MAKES NEW PROFILE
            If Not existingProfile Then
                ReDim Preserve fileLines(0 To oldLength + 7)
                fileLines(oldLength + 0) = "Username: " & enteredUsername
                fileLines(oldLength + 1) = "Password: " & enteredPassword
                fileLines(oldLength + 2) = "Unlocked Levels: " & Str(unlockedLevels)
                fileLines(oldLength + 3) = "Coins: " & Str(coins)
                fileLines(oldLength + 4) = "2X Coins: " & Str(doubleCoins)
                fileLines(oldLength + 5) = "Slows: " & Str(slows)
                fileLines(oldLength + 6) = "Lives: " & Str(lives)
            End If
            'STORES ALL OF THE CHANGES IN THE TEXT FILE
            Dim newFile As New FileStream("Profiles.txt", FileMode.Create, FileAccess.Write)
            Dim toWrite As StreamWriter = New StreamWriter(newFile)
            For pos As Integer = 0 To fileLines.Length - 1
                toWrite.WriteLine(fileLines(pos))
            Next
            toWrite.Close()
            newFile.Close()
            'INDICATES WHETHER THE PROFILE WAS SAVED OR NOT
            lblIndicator.Text = "Profile Saved"
            btnSave.Enabled = False
        Else
            lblIndicator.Text = "Spaces Not Allowed"
        End If

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'PLAYS BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOWS MAIN MENU
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'PLAYS BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOWS HELP FORM
        Me.Hide()
        Help.Show()
    End Sub

    Private Sub Save_Profile_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Function containsSpace(ByVal input As String) As Boolean
        'TAKES IN A STRING AND LOOPS THROUGH TO TO SEE IF IT CONTAINS A SPACE
        Dim contains As Boolean = False
        For pos As Integer = 0 To input.Length - 1
            If input(pos) = " " Then
                contains = True
            End If
        Next
        Return contains
    End Function


End Class