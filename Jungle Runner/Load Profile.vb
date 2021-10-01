Imports System.IO

Public Class Load_Profile
    'THIS VARIABLE STORES IF THE PROFILE WAS FOIND
    Dim profileFound As Boolean = False
    'MAKES A LIST FOR ALL OF THE LINES IN THE "PROFILE.TXT" FILE
    Dim fileLines() As String

    Private Sub Load_Profile_Load(sender As Object, e As EventArgs) Handles Me.Load
        'OPENS THE PROFILES FILE
        Dim instance As New FileStream("Profiles.txt", FileMode.Open, FileAccess.Read)
        Dim textfile As New StreamReader(instance)
        'STORES ALL OF THE LINES IN THE PROFILES FILE TO THE FILELINES 
        Dim pos As Integer = 0
        Do While textfile.Peek <> -1
            ReDim Preserve fileLines(0 To pos + 1)
            fileLines(pos) = textfile.ReadLine()
            pos += 1
        Loop
        'CLOSE THE OPENED INSTANCES
        textfile.Close()
        instance.Close()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'PLAY BUTTON AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'STORE USERNAME AND PASSWORD
        Dim enteredUsername As String = txtUsername.Text
        Dim enteredPassword As String = txtPassword.Text
        'LOOPS THROUGH FILELINES TO SEE IF IT CAN FIND THE USERNAME AND PASSWORD
        If fileLines IsNot Nothing Then
            For profile As Integer = 0 To (fileLines.Length / 8) - 1
                If Split(fileLines(profile * 8))(1) = enteredUsername Then
                    If Split(fileLines((profile * 8) + 1))(1) = enteredPassword Then
                        'IF FOUND, STORE THE INFORMATION INTO GLOBAL VARIABLES
                        profileFound = True
                        unlockedLevels = Val(Split(fileLines((profile * 8) + 2))(2))
                        coins = Val(Split(fileLines((profile * 8) + 3))(1))
                        doubleCoins = Val(Split(fileLines((profile * 8) + 4))(2))
                        slows = Val(Split(fileLines((profile * 8) + 5))(1))
                        lives = Val(Split(fileLines((profile * 8) + 6))(1))
                    End If
                End If
            Next
        End If
        If Not profileFound Then
            'IF PROFILE NOT FOUND
            lblError.Text = "Profile Not Found"
        Else
            'IF PROFILE FOIND
            lblError.Text = "Profile Loaded"
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'IF MENU BUTTON IS CLICKED
        'PLAY BUTTON CLICKED AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW MAIN MENU
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'IF HELP IS CLICKED
        'PLAY BUTTON CLICK AUDIO
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'SHOW HELP FORM
        Me.Hide()
        Help.Show()
    End Sub

    Private Sub Load_Profile_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class