<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLevels = New System.Windows.Forms.Button()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblDescription1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDescription2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoEllipsis = True
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(295, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(102, 40)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Help"
        '
        'btnLevels
        '
        Me.btnLevels.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLevels.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLevels.ForeColor = System.Drawing.Color.White
        Me.btnLevels.Location = New System.Drawing.Point(166, 12)
        Me.btnLevels.Name = "btnLevels"
        Me.btnLevels.Size = New System.Drawing.Size(59, 27)
        Me.btnLevels.TabIndex = 40
        Me.btnLevels.Text = "Levels"
        Me.btnLevels.UseVisualStyleBackColor = False
        '
        'btnShop
        '
        Me.btnShop.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnShop.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnShop.ForeColor = System.Drawing.Color.White
        Me.btnShop.Location = New System.Drawing.Point(109, 12)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(51, 27)
        Me.btnShop.TabIndex = 39
        Me.btnShop.Text = "Shop"
        Me.btnShop.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnMenu.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(10, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(93, 27)
        Me.btnMenu.TabIndex = 38
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'lblDescription1
        '
        Me.lblDescription1.AutoSize = True
        Me.lblDescription1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDescription1.ForeColor = System.Drawing.Color.White
        Me.lblDescription1.Location = New System.Drawing.Point(10, 91)
        Me.lblDescription1.Name = "lblDescription1"
        Me.lblDescription1.Size = New System.Drawing.Size(681, 135)
        Me.lblDescription1.TabIndex = 42
        Me.lblDescription1.Text = resources.GetString("lblDescription1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(279, 242)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'lblDescription2
        '
        Me.lblDescription2.AutoSize = True
        Me.lblDescription2.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDescription2.ForeColor = System.Drawing.Color.White
        Me.lblDescription2.Location = New System.Drawing.Point(10, 363)
        Me.lblDescription2.Name = "lblDescription2"
        Me.lblDescription2.Size = New System.Drawing.Size(708, 30)
        Me.lblDescription2.TabIndex = 44
        Me.lblDescription2.Text = "To save your progress, you must go to the level menu and click the top right corn" &
    "er to save your current " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "progress. You may not have spaces in your username or " &
    "password."
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(730, 433)
        Me.Controls.Add(Me.lblDescription2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDescription1)
        Me.Controls.Add(Me.btnLevels)
        Me.Controls.Add(Me.btnShop)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Help"
        Me.Text = "Help"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLevels As Button
    Friend WithEvents btnShop As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblDescription1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDescription2 As Label
End Class
