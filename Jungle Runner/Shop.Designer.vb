<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLevels = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblCoins = New System.Windows.Forms.Label()
        Me.lblSlow = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblOwnedCoins = New System.Windows.Forms.Label()
        Me.lblOwnedSlows = New System.Windows.Forms.Label()
        Me.lblOwnedLives = New System.Windows.Forms.Label()
        Me.lblCoinsDesc = New System.Windows.Forms.Label()
        Me.lblSlowDesc = New System.Windows.Forms.Label()
        Me.lblLivesDesc = New System.Windows.Forms.Label()
        Me.lblPriceCoins = New System.Windows.Forms.Label()
        Me.lblPriceSlows = New System.Windows.Forms.Label()
        Me.lblPriceLives = New System.Windows.Forms.Label()
        Me.lblSellCoins = New System.Windows.Forms.Label()
        Me.lblSellSlow = New System.Windows.Forms.Label()
        Me.lbLSellLives = New System.Windows.Forms.Label()
        Me.btnBuyCoins = New System.Windows.Forms.Button()
        Me.btnSellCoins = New System.Windows.Forms.Button()
        Me.btnSellSlow = New System.Windows.Forms.Button()
        Me.btnBuySlow = New System.Windows.Forms.Button()
        Me.btnSellLives = New System.Windows.Forms.Button()
        Me.btnBuyLives = New System.Windows.Forms.Button()
        Me.lblCurrentBalance = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoEllipsis = True
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(177, 59)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(107, 40)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Shop"
        '
        'btnLevels
        '
        Me.btnLevels.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLevels.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLevels.ForeColor = System.Drawing.Color.White
        Me.btnLevels.Location = New System.Drawing.Point(168, 12)
        Me.btnLevels.Name = "btnLevels"
        Me.btnLevels.Size = New System.Drawing.Size(59, 27)
        Me.btnLevels.TabIndex = 37
        Me.btnLevels.Text = "Levels"
        Me.btnLevels.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnHelp.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Location = New System.Drawing.Point(111, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(51, 27)
        Me.btnHelp.TabIndex = 36
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnMenu.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(93, 27)
        Me.btnMenu.TabIndex = 35
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'lblCoins
        '
        Me.lblCoins.AutoEllipsis = True
        Me.lblCoins.AutoSize = True
        Me.lblCoins.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCoins.ForeColor = System.Drawing.Color.White
        Me.lblCoins.Location = New System.Drawing.Point(23, 123)
        Me.lblCoins.Name = "lblCoins"
        Me.lblCoins.Size = New System.Drawing.Size(113, 30)
        Me.lblCoins.TabIndex = 38
        Me.lblCoins.Text = "2x Coins"
        '
        'lblSlow
        '
        Me.lblSlow.AutoEllipsis = True
        Me.lblSlow.AutoSize = True
        Me.lblSlow.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSlow.ForeColor = System.Drawing.Color.White
        Me.lblSlow.Location = New System.Drawing.Point(177, 123)
        Me.lblSlow.Name = "lblSlow"
        Me.lblSlow.Size = New System.Drawing.Size(130, 30)
        Me.lblSlow.TabIndex = 39
        Me.lblSlow.Text = "Slowww"
        '
        'lblLives
        '
        Me.lblLives.AutoEllipsis = True
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLives.ForeColor = System.Drawing.Color.White
        Me.lblLives.Location = New System.Drawing.Point(336, 123)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(75, 30)
        Me.lblLives.TabIndex = 40
        Me.lblLives.Text = "Lives"
        '
        'lblOwnedCoins
        '
        Me.lblOwnedCoins.AutoSize = True
        Me.lblOwnedCoins.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOwnedCoins.ForeColor = System.Drawing.Color.White
        Me.lblOwnedCoins.Location = New System.Drawing.Point(23, 229)
        Me.lblOwnedCoins.Name = "lblOwnedCoins"
        Me.lblOwnedCoins.Size = New System.Drawing.Size(68, 15)
        Me.lblOwnedCoins.TabIndex = 41
        Me.lblOwnedCoins.Text = "Owned: 0"
        '
        'lblOwnedSlows
        '
        Me.lblOwnedSlows.AutoSize = True
        Me.lblOwnedSlows.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOwnedSlows.ForeColor = System.Drawing.Color.White
        Me.lblOwnedSlows.Location = New System.Drawing.Point(177, 229)
        Me.lblOwnedSlows.Name = "lblOwnedSlows"
        Me.lblOwnedSlows.Size = New System.Drawing.Size(68, 15)
        Me.lblOwnedSlows.TabIndex = 42
        Me.lblOwnedSlows.Text = "Owned: 0"
        '
        'lblOwnedLives
        '
        Me.lblOwnedLives.AutoSize = True
        Me.lblOwnedLives.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOwnedLives.ForeColor = System.Drawing.Color.White
        Me.lblOwnedLives.Location = New System.Drawing.Point(336, 229)
        Me.lblOwnedLives.Name = "lblOwnedLives"
        Me.lblOwnedLives.Size = New System.Drawing.Size(65, 15)
        Me.lblOwnedLives.TabIndex = 43
        Me.lblOwnedLives.Text = "Owned: 1"
        '
        'lblCoinsDesc
        '
        Me.lblCoinsDesc.AutoSize = True
        Me.lblCoinsDesc.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCoinsDesc.ForeColor = System.Drawing.Color.White
        Me.lblCoinsDesc.Location = New System.Drawing.Point(23, 153)
        Me.lblCoinsDesc.Name = "lblCoinsDesc"
        Me.lblCoinsDesc.Size = New System.Drawing.Size(130, 45)
        Me.lblCoinsDesc.TabIndex = 44
        Me.lblCoinsDesc.Text = "Doubles all of the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "collected coins in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a level"
        '
        'lblSlowDesc
        '
        Me.lblSlowDesc.AutoSize = True
        Me.lblSlowDesc.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSlowDesc.ForeColor = System.Drawing.Color.White
        Me.lblSlowDesc.Location = New System.Drawing.Point(177, 153)
        Me.lblSlowDesc.Name = "lblSlowDesc"
        Me.lblSlowDesc.Size = New System.Drawing.Size(117, 45)
        Me.lblSlowDesc.TabIndex = 45
        Me.lblSlowDesc.Text = "Slows down the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "incoming crates " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and coins" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblLivesDesc
        '
        Me.lblLivesDesc.AutoSize = True
        Me.lblLivesDesc.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLivesDesc.ForeColor = System.Drawing.Color.White
        Me.lblLivesDesc.Location = New System.Drawing.Point(336, 153)
        Me.lblLivesDesc.Name = "lblLivesDesc"
        Me.lblLivesDesc.Size = New System.Drawing.Size(131, 60)
        Me.lblLivesDesc.TabIndex = 46
        Me.lblLivesDesc.Text = "Gives you an extra " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "chance after " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "running into a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "crate"
        '
        'lblPriceCoins
        '
        Me.lblPriceCoins.AutoSize = True
        Me.lblPriceCoins.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPriceCoins.ForeColor = System.Drawing.Color.White
        Me.lblPriceCoins.Location = New System.Drawing.Point(23, 253)
        Me.lblPriceCoins.Name = "lblPriceCoins"
        Me.lblPriceCoins.Size = New System.Drawing.Size(54, 15)
        Me.lblPriceCoins.TabIndex = 47
        Me.lblPriceCoins.Text = "Price: 5"
        '
        'lblPriceSlows
        '
        Me.lblPriceSlows.AutoSize = True
        Me.lblPriceSlows.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPriceSlows.ForeColor = System.Drawing.Color.White
        Me.lblPriceSlows.Location = New System.Drawing.Point(177, 253)
        Me.lblPriceSlows.Name = "lblPriceSlows"
        Me.lblPriceSlows.Size = New System.Drawing.Size(54, 15)
        Me.lblPriceSlows.TabIndex = 48
        Me.lblPriceSlows.Text = "Price: 7"
        '
        'lblPriceLives
        '
        Me.lblPriceLives.AutoSize = True
        Me.lblPriceLives.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPriceLives.ForeColor = System.Drawing.Color.White
        Me.lblPriceLives.Location = New System.Drawing.Point(336, 253)
        Me.lblPriceLives.Name = "lblPriceLives"
        Me.lblPriceLives.Size = New System.Drawing.Size(61, 15)
        Me.lblPriceLives.TabIndex = 49
        Me.lblPriceLives.Text = "Price: 10"
        '
        'lblSellCoins
        '
        Me.lblSellCoins.AutoSize = True
        Me.lblSellCoins.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSellCoins.ForeColor = System.Drawing.Color.White
        Me.lblSellCoins.Location = New System.Drawing.Point(23, 277)
        Me.lblSellCoins.Name = "lblSellCoins"
        Me.lblSellCoins.Size = New System.Drawing.Size(83, 15)
        Me.lblSellCoins.TabIndex = 50
        Me.lblSellCoins.Text = "Sell Price: 4"
        '
        'lblSellSlow
        '
        Me.lblSellSlow.AutoSize = True
        Me.lblSellSlow.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSellSlow.ForeColor = System.Drawing.Color.White
        Me.lblSellSlow.Location = New System.Drawing.Point(177, 277)
        Me.lblSellSlow.Name = "lblSellSlow"
        Me.lblSellSlow.Size = New System.Drawing.Size(82, 15)
        Me.lblSellSlow.TabIndex = 51
        Me.lblSellSlow.Text = "Sell Price: 6"
        '
        'lbLSellLives
        '
        Me.lbLSellLives.AutoSize = True
        Me.lbLSellLives.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLSellLives.ForeColor = System.Drawing.Color.White
        Me.lbLSellLives.Location = New System.Drawing.Point(336, 277)
        Me.lbLSellLives.Name = "lbLSellLives"
        Me.lbLSellLives.Size = New System.Drawing.Size(83, 15)
        Me.lbLSellLives.TabIndex = 52
        Me.lbLSellLives.Text = "Sell Price: 9"
        '
        'btnBuyCoins
        '
        Me.btnBuyCoins.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnBuyCoins.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuyCoins.ForeColor = System.Drawing.Color.White
        Me.btnBuyCoins.Location = New System.Drawing.Point(23, 307)
        Me.btnBuyCoins.Name = "btnBuyCoins"
        Me.btnBuyCoins.Size = New System.Drawing.Size(54, 27)
        Me.btnBuyCoins.TabIndex = 53
        Me.btnBuyCoins.Text = "Buy"
        Me.btnBuyCoins.UseVisualStyleBackColor = False
        '
        'btnSellCoins
        '
        Me.btnSellCoins.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSellCoins.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSellCoins.ForeColor = System.Drawing.Color.White
        Me.btnSellCoins.Location = New System.Drawing.Point(83, 307)
        Me.btnSellCoins.Name = "btnSellCoins"
        Me.btnSellCoins.Size = New System.Drawing.Size(56, 27)
        Me.btnSellCoins.TabIndex = 54
        Me.btnSellCoins.Text = "Sell"
        Me.btnSellCoins.UseVisualStyleBackColor = False
        '
        'btnSellSlow
        '
        Me.btnSellSlow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSellSlow.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSellSlow.ForeColor = System.Drawing.Color.White
        Me.btnSellSlow.Location = New System.Drawing.Point(238, 307)
        Me.btnSellSlow.Name = "btnSellSlow"
        Me.btnSellSlow.Size = New System.Drawing.Size(56, 27)
        Me.btnSellSlow.TabIndex = 56
        Me.btnSellSlow.Text = "Sell"
        Me.btnSellSlow.UseVisualStyleBackColor = False
        '
        'btnBuySlow
        '
        Me.btnBuySlow.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnBuySlow.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuySlow.ForeColor = System.Drawing.Color.White
        Me.btnBuySlow.Location = New System.Drawing.Point(178, 307)
        Me.btnBuySlow.Name = "btnBuySlow"
        Me.btnBuySlow.Size = New System.Drawing.Size(54, 27)
        Me.btnBuySlow.TabIndex = 55
        Me.btnBuySlow.Text = "Buy"
        Me.btnBuySlow.UseVisualStyleBackColor = False
        '
        'btnSellLives
        '
        Me.btnSellLives.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSellLives.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSellLives.ForeColor = System.Drawing.Color.White
        Me.btnSellLives.Location = New System.Drawing.Point(399, 307)
        Me.btnSellLives.Name = "btnSellLives"
        Me.btnSellLives.Size = New System.Drawing.Size(56, 27)
        Me.btnSellLives.TabIndex = 58
        Me.btnSellLives.Text = "Sell"
        Me.btnSellLives.UseVisualStyleBackColor = False
        '
        'btnBuyLives
        '
        Me.btnBuyLives.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnBuyLives.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuyLives.ForeColor = System.Drawing.Color.White
        Me.btnBuyLives.Location = New System.Drawing.Point(339, 307)
        Me.btnBuyLives.Name = "btnBuyLives"
        Me.btnBuyLives.Size = New System.Drawing.Size(54, 27)
        Me.btnBuyLives.TabIndex = 57
        Me.btnBuyLives.Text = "Buy"
        Me.btnBuyLives.UseVisualStyleBackColor = False
        '
        'lblCurrentBalance
        '
        Me.lblCurrentBalance.AutoEllipsis = True
        Me.lblCurrentBalance.AutoSize = True
        Me.lblCurrentBalance.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCurrentBalance.ForeColor = System.Drawing.Color.White
        Me.lblCurrentBalance.Location = New System.Drawing.Point(62, 376)
        Me.lblCurrentBalance.Name = "lblCurrentBalance"
        Me.lblCurrentBalance.Size = New System.Drawing.Size(357, 40)
        Me.lblCurrentBalance.TabIndex = 59
        Me.lblCurrentBalance.Text = "Current Balance: 0"
        '
        'Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 450)
        Me.Controls.Add(Me.lblCurrentBalance)
        Me.Controls.Add(Me.btnSellLives)
        Me.Controls.Add(Me.btnBuyLives)
        Me.Controls.Add(Me.btnSellSlow)
        Me.Controls.Add(Me.btnBuySlow)
        Me.Controls.Add(Me.btnSellCoins)
        Me.Controls.Add(Me.btnBuyCoins)
        Me.Controls.Add(Me.lbLSellLives)
        Me.Controls.Add(Me.lblSellSlow)
        Me.Controls.Add(Me.lblSellCoins)
        Me.Controls.Add(Me.lblPriceLives)
        Me.Controls.Add(Me.lblPriceSlows)
        Me.Controls.Add(Me.lblPriceCoins)
        Me.Controls.Add(Me.lblLivesDesc)
        Me.Controls.Add(Me.lblSlowDesc)
        Me.Controls.Add(Me.lblCoinsDesc)
        Me.Controls.Add(Me.lblOwnedLives)
        Me.Controls.Add(Me.lblOwnedSlows)
        Me.Controls.Add(Me.lblOwnedCoins)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblSlow)
        Me.Controls.Add(Me.lblCoins)
        Me.Controls.Add(Me.btnLevels)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Shop"
        Me.Text = "Shop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLevels As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblCoins As Label
    Friend WithEvents lblSlow As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents lblOwnedCoins As Label
    Friend WithEvents lblOwnedSlows As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCoinsDesc As Label
    Friend WithEvents lblSlowDesc As Label
    Friend WithEvents lblLivesDesc As Label
    Friend WithEvents lblPriceCoins As Label
    Friend WithEvents lblPriceSlows As Label
    Friend WithEvents lblPriceLives As Label
    Friend WithEvents lblSellCoins As Label
    Friend WithEvents lblSellSlow As Label
    Friend WithEvents lbLSellLives As Label
    Friend WithEvents btnBuyCoins As Button
    Friend WithEvents btnSellCoins As Button
    Friend WithEvents btnSellSlow As Button
    Friend WithEvents btnBuySlow As Button
    Friend WithEvents btnSellLives As Button
    Friend WithEvents btnBuyLives As Button
    Friend WithEvents lblCurrentBalance As Label
    Friend WithEvents lblOwnedLives As Label
End Class
