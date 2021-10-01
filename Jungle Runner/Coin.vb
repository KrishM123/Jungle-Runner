Public Class Coin
    'A COIN IS A MAPELEMENT
    Inherits mapElements
    Public Sub New(ByVal speed As Integer)
        'TAKES IN THE NUMBER OF PIXELS TO MOVE DOWN PER TICK OF THE TIMER
        MyBase.New(speed)
        'SETS THE CONTAINER IMAGE TO THAT OF A COIN
        container.Image = My.Resources.Coin
        container.Tag = "Coin"
    End Sub
End Class