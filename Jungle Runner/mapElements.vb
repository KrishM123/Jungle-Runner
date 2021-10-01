Public Class mapElements
    'STORES THE AMOUNT OF PIXELS ITS SUPPOSED TO MOVE DOWN
    Dim speed As Integer
    'STORES POSITION
    Dim position As Integer
    'MAKES NEW PICTUREBOX
    Public container As New PictureBox
    'IF IT HAS COLLIDED WITH ANYTHING
    Public hit As Boolean = False
    'IF IT HAS COLLIDED WITH ANYTHING PREVIOUSLY
    Public hitBefore As Boolean = False

    Public Sub New(ByVal wantedSpeed As Integer)
        'SETS CONTAINER PARAMETERS
        container.Height = 40
        container.Width = 40
        container.Top = -20
        container.BackColor = Color.FromArgb(123, 82, 74)
        container.SizeMode = PictureBoxSizeMode.StretchImage
        'RANDOMIZES THE POSITION OF THE MAPELEMENT
        Randomize()
        position = Int((3 - 1 + 1) * Rnd() + 1)
        Select Case position
            Case 1
                container.Left = 207
            Case 2
                container.Left = 298
            Case 3
                container.Left = 397
        End Select
        'SETS SPEED
        speed = wantedSpeed
    End Sub

    Public Sub Update()
        'MOVES CONTAINER DOWN
        container.Top += speed
    End Sub

    Function detectCollision(ByVal player As PictureBox) As Boolean
        'SETS HIT BEFORE
        If hit And Not hitBefore Then
            hitBefore = True
        End If
        If player.Bounds.IntersectsWith(container.Bounds) Then
            'SETS HIT TRUE
            hit = True
        End If
        Return hit
    End Function
End Class