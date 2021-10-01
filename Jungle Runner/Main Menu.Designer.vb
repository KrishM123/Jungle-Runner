<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(53, 165)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(181, 96)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLoad.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLoad.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLoad.Location = New System.Drawing.Point(281, 165)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(181, 96)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load Game"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnShop
        '
        Me.btnShop.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnShop.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnShop.ForeColor = System.Drawing.Color.White
        Me.btnShop.Location = New System.Drawing.Point(281, 297)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(181, 96)
        Me.btnShop.TabIndex = 4
        Me.btnShop.Text = "Shop"
        Me.btnShop.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnHelp.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Location = New System.Drawing.Point(53, 297)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(181, 96)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoEllipsis = True
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(1, 55)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(512, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Welcome To Jungle Runner!"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.btnShop)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Main_Menu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnShop As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents lblTitle As Label
End Class
