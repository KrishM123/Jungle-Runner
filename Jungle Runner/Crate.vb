Public Class Crate
    'A CRATE IS A MAP ELEMENT
    Inherits mapElements
    Public Sub New(ByVal speed As Integer)
        'TAKES IN THE NUMBER OF PIXELS TO MOVE DOWN PER TICK OF THE TIMER
        MyBase.New(speed)
        'SETS THE CONTAINER IMAGE TO THAT OF A CRATE
        container.Image = My.Resources.Crate
        container.Tag = "Crate"
    End Sub
End Class