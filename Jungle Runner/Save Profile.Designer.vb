<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Save_Profile
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.Location = New System.Drawing.Point(36, 279)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(287, 56)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(36, 236)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(287, 23)
        Me.txtPassword.TabIndex = 48
        '
        'lblPassword
        '
        Me.lblPassword.AutoEllipsis = True
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(36, 213)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(158, 20)
        Me.lblPassword.TabIndex = 47
        Me.lblPassword.Text = "Enter Password:"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(36, 167)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(287, 23)
        Me.txtUsername.TabIndex = 46
        '
        'lblUsername
        '
        Me.lblUsername.AutoEllipsis = True
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(36, 144)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(152, 20)
        Me.lblUsername.TabIndex = 45
        Me.lblUsername.Text = "Enter Username:"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnHelp.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Location = New System.Drawing.Point(111, 17)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(51, 27)
        Me.btnHelp.TabIndex = 44
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnMenu.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(12, 17)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(93, 27)
        Me.btnMenu.TabIndex = 43
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoEllipsis = True
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(36, 67)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(274, 40)
        Me.lblTitle.TabIndex = 42
        Me.lblTitle.Text = "Save Progress"
        '
        'lblIndicator
        '
        Me.lblIndicator.AutoSize = True
        Me.lblIndicator.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIndicator.ForeColor = System.Drawing.Color.White
        Me.lblIndicator.Location = New System.Drawing.Point(337, 203)
        Me.lblIndicator.Name = "lblIndicator"
        Me.lblIndicator.Size = New System.Drawing.Size(0, 20)
        Me.lblIndicator.TabIndex = 50
        '
        'Save_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 371)
        Me.Controls.Add(Me.lblIndicator)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Save_Profile"
        Me.Text = "Save_Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblIndicator As Label
End Class
