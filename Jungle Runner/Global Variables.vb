Module Global_Variables
    'THESE VARIABLES WILL BE ACCESSIBLE BY ALL OF THE FORMS

    'CURRENT LEVEL STORES THE LEVEL THAT THE USER IS PLAYING AT THE MOMENT
    Public currentLevel As New Level(10, 7, 100, 3)
    'LEVELNUM STORES THE LEVEL NUMBER THAT THE USER IS PLAYING
    Public levelNum As Integer
    'COIN MULTIPLIER STORES IF THE USER ACTIVATED THE 2X COIN MULTIPLIER
    Public coinMultiplier As Integer = 1
    'UNLOCKED LEVELS STORES THE LEVELS THAT THE USER HAS UNLOCKED
    Public unlockedLevels As Integer = 1

    'COINS STORES THE NUMBER OF COINS THE USER POSSESSES
    Public coins As Integer = 0

    'STORES THE NUMBER OF EACH POWERUP THE USER BOUGHT
    Public lives As Integer = 1
    Public slows As Integer = 0
    Public doubleCoins As Integer = 0

    'STORES THE CURRENT LEVEL ATTRIBUTES
    Public levelLength As Integer
    Public levelDensity As Integer
    Public levelDistance As Integer
    Public levelSpeed As Integer
End Module
