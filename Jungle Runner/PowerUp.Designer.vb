<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PowerUp
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
        Me.lblSlow = New System.Windows.Forms.Label()
        Me.lblCoins = New System.Windows.Forms.Label()
        Me.lblSlowDesc = New System.Windows.Forms.Label()
        Me.lblCoinsDesc = New System.Windows.Forms.Label()
        Me.lblOwnedSlows = New System.Windows.Forms.Label()
        Me.lblOwnedCoins = New System.Windows.Forms.Label()
        Me.btnUseCoins = New System.Windows.Forms.Button()
        Me.btnUseSlow = New System.Windows.Forms.Button()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoEllipsis = True
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(88, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(283, 40)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Use Power-Ups"
        '
        'lblSlow
        '
        Me.lblSlow.AutoEllipsis = True
        Me.lblSlow.AutoSize = True
        Me.lblSlow.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSlow.ForeColor = System.Drawing.Color.White
        Me.lblSlow.Location = New System.Drawing.Point(273, 112)
        Me.lblSlow.Name = "lblSlow"
        Me.lblSlow.Size = New System.Drawing.Size(130, 30)
        Me.lblSlow.TabIndex = 41
        Me.lblSlow.Text = "Slowww"
        '
        'lblCoins
        '
        Me.lblCoins.AutoEllipsis = True
        Me.lblCoins.AutoSize = True
        Me.lblCoins.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCoins.ForeColor = System.Drawing.Color.White
        Me.lblCoins.Location = New System.Drawing.Point(66, 112)
        Me.lblCoins.Name = "lblCoins"
        Me.lblCoins.Size = New System.Drawing.Size(113, 30)
        Me.lblCoins.TabIndex = 40
        Me.lblCoins.Text = "2x Coins"
        '
        'lblSlowDesc
        '
        Me.lblSlowDesc.AutoSize = True
        Me.lblSlowDesc.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSlowDesc.ForeColor = System.Drawing.Color.White
        Me.lblSlowDesc.Location = New System.Drawing.Point(273, 142)
        Me.lblSlowDesc.Name = "lblSlowDesc"
        Me.lblSlowDesc.Size = New System.Drawing.Size(117, 45)
        Me.lblSlowDesc.TabIndex = 47
        Me.lblSlowDesc.Text = "Slows down the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "incoming crates " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and coins" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblCoinsDesc
        '
        Me.lblCoinsDesc.AutoSize = True
        Me.lblCoinsDesc.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCoinsDesc.ForeColor = System.Drawing.Color.White
        Me.lblCoinsDesc.Location = New System.Drawing.Point(66, 142)
        Me.lblCoinsDesc.Name = "lblCoinsDesc"
        Me.lblCoinsDesc.Size = New System.Drawing.Size(130, 45)
        Me.lblCoinsDesc.TabIndex = 46
        Me.lblCoinsDesc.Text = "Doubles all of the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "collected coins in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a level"
        '
        'lblOwnedSlows
        '
        Me.lblOwnedSlows.AutoSize = True
        Me.lblOwnedSlows.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOwnedSlows.ForeColor = System.Drawing.Color.White
        Me.lblOwnedSlows.Location = New System.Drawing.Point(273, 205)
        Me.lblOwnedSlows.Name = "lblOwnedSlows"
        Me.lblOwnedSlows.Size = New System.Drawing.Size(68, 15)
        Me.lblOwnedSlows.TabIndex = 49
        Me.lblOwnedSlows.Text = "Owned: 0"
        '
        'lblOwnedCoins
        '
        Me.lblOwnedCoins.AutoSize = True
        Me.lblOwnedCoins.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOwnedCoins.ForeColor = System.Drawing.Color.White
        Me.lblOwnedCoins.Location = New System.Drawing.Point(66, 205)
        Me.lblOwnedCoins.Name = "lblOwnedCoins"
        Me.lblOwnedCoins.Size = New System.Drawing.Size(68, 15)
        Me.lblOwnedCoins.TabIndex = 48
        Me.lblOwnedCoins.Text = "Owned: 0"
        '
        'btnUseCoins
        '
        Me.btnUseCoins.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnUseCoins.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUseCoins.ForeColor = System.Drawing.Color.White
        Me.btnUseCoins.Location = New System.Drawing.Point(66, 238)
        Me.btnUseCoins.Name = "btnUseCoins"
        Me.btnUseCoins.Size = New System.Drawing.Size(130, 30)
        Me.btnUseCoins.TabIndex = 54
        Me.btnUseCoins.Text = "Use"
        Me.btnUseCoins.UseVisualStyleBackColor = False
        '
        'btnUseSlow
        '
        Me.btnUseSlow.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnUseSlow.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUseSlow.ForeColor = System.Drawing.Color.White
        Me.btnUseSlow.Location = New System.Drawing.Point(273, 238)
        Me.btnUseSlow.Name = "btnUseSlow"
        Me.btnUseSlow.Size = New System.Drawing.Size(130, 30)
        Me.btnUseSlow.TabIndex = 55
        Me.btnUseSlow.Text = "Use"
        Me.btnUseSlow.UseVisualStyleBackColor = False
        '
        'btnSkip
        '
        Me.btnSkip.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSkip.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSkip.ForeColor = System.Drawing.Color.White
        Me.btnSkip.Location = New System.Drawing.Point(167, 289)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(137, 51)
        Me.btnSkip.TabIndex = 56
        Me.btnSkip.Text = "skip"
        Me.btnSkip.UseVisualStyleBackColor = False
        '
        'PowerUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 369)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.btnUseSlow)
        Me.Controls.Add(Me.btnUseCoins)
        Me.Controls.Add(Me.lblOwnedSlows)
        Me.Controls.Add(Me.lblOwnedCoins)
        Me.Controls.Add(Me.lblSlowDesc)
        Me.Controls.Add(Me.lblCoinsDesc)
        Me.Controls.Add(Me.lblSlow)
        Me.Controls.Add(Me.lblCoins)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "PowerUp"
        Me.Text = "Shop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSlow As Label
    Friend WithEvents lblCoins As Label
    Friend WithEvents lblSlowDesc As Label
    Friend WithEvents lblCoinsDesc As Label
    Friend WithEvents lblOwnedSlows As Label
    Friend WithEvents lblOwnedCoins As Label
    Friend WithEvents btnUseCoins As Button
    Friend WithEvents btnUseSlow As Button
    Friend WithEvents btnSkip As Button
End Class
