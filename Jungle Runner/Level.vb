Public Class Level
    'MAKES A LIST OF MAP ELEMENTS FOR THE LEVEL
    Public level() As mapElements
    'THE COINS COLLECTED IS STORED HERE
    Public coinsCollected As Integer = 0
    'CRATES HIT IS STORED HERE
    Public cratesHit As Integer = 0
    'ACTIVE ELEMENTS IS THE ELEMENTS IN THE LEVEL LIST THAT ARE ACTIVE AT THE MOMENT(MOVING DOWNWARDS)
    Dim activeElementPos As Integer = 0
    'NUMBER OF TIMES THE UPDATE METHOD IS CALLED
    Dim called As Integer = 0
    'DISTANCE WANTED IS THE DISTANCE BETWEEN EACH MAPELEMENT
    Dim distanceWanted As Integer
    'FINISHED IS IF ALL OF THE MAPELEMENTS HAVE TRAVELLED DOWNWARDS
    Public finished As Boolean = False
    'LASTOBJECTIDEEX IS THE INDEX OF THE LAST ELEMENT IN THE LEVEL LIST
    Dim lastObjectIndex As Integer

    Public Sub New(ByVal length As Integer, ByVal density As Integer, ByVal distance As Integer, ByVal speed As Integer)
        'LENGTH IS THE LENGTH OF THE LEVEL, DENSITY IS THE DENSITY OF CRATES AND COINS, DISTANCE IS THE DISTANCE BETWEEN EACH ELEMENT, SPEED IS THE AMOUNT OF PIXELS EACH MAPELEMENT MOVES DOWNWARDS WHEN UPDATED
        'MAKES LEVEL THE LENGTH SPECIFIED
        ReDim level(0 To length)
        Randomize()
        For index As Integer = 0 To length
            'POPULATES THE LEVEL VARIABLE WITH CRATES AND COINS RANDOMLY
            If (length - 1 + 1) * Rnd() + 1 < density + 1 Then
                level(index) = New Crate(speed)
                'CRATES ARE TWICE AS LIKELY TO APPEAR
            ElseIf (length - 1 + 1) * Rnd() + 1 < (density / 2) + 1 Then
                level(index) = New Coin(speed)
            End If
        Next
        'STORES DISTANCE IN DISTANCE WANTED
        distanceWanted = distance
        'STORES LAST OBJECT INDEX
        lastObjectIndex = level.Length - 1
        While level(lastObjectIndex) Is Nothing
            'MAKES SURE LAST OBJECT IS NOT NOTHING
            lastObjectIndex -= 1
        End While
    End Sub

    Public Sub updateMap(ByVal player As PictureBox)
        'IF IT IS TIME TO CALL ADD ANOTHER ELEMENT ONTO THE MAP
        'THIS IS DETERMINED IF THE DISTANCE BETWEEN 
        If Int(called / distanceWanted) = called / distanceWanted And called <> 0 Then
            If activeElementPos < level.Length - 1 Then
                activeElementPos += 1
            End If
        End If
        'ALL OF THE ACTIVE ELEMENTS WILL BE MOVED DOWNWARDS
        For index As Integer = 0 To activeElementPos
            If level(index) IsNot Nothing Then
                'UPDATES EACH MAPELEMENP
                level(index).Update()
                'IF COLLISION IS DETECTED FOR THE FIRST TIME,
                If level(index).detectCollision(player) And level(index).hitBefore = False Then
                    If level(index).container.Tag = "Coin" Then
                        'IF COIN IS HIT, INCREASE COINCOLLECTED AND PLAY COIN AUIO
                        coinsCollected += 1
                        My.Computer.Audio.Play(My.Resources.Coin_Sound, AudioPlayMode.Background)
                    Else
                        'IF CRATE IS HIT, INCREASE CRATES HIT AND PLAY CRATE AUDIO
                        cratesHit += 1
                        My.Computer.Audio.Play(My.Resources.Crash_Sound, AudioPlayMode.Background)
                    End If
                End If
                'ADD NEW PICTURE BOX FOR EACH ELEMENT
                Game.Controls.Add(level(index).container)
            End If
        Next
        called += 1
        If level(lastObjectIndex).container.Top >= 550 Then
            'IF ALL OF THE ELEMENTS HAVE PASSED, FINISHED IS TRUE
            finished = True
        End If
    End Sub

    Public Sub clearMap()
        For pos As Integer = 0 To level.Length - 1
            If level(pos) IsNot Nothing Then
                'IF THE MAP ELEMENT IS NOT NOTHING, MAKE THE CONTAINER INVISIBLE AND MOVE IT TO THE TOP
                level(pos).container.Visible = False
                level(pos).container.Top = -40
            End If
        Next
    End Sub
End Class
