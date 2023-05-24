<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Pnlup = New System.Windows.Forms.Panel()
        Me.PnlUser = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNamaUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtStatusUser = New System.Windows.Forms.TextBox()
        Me.TxtKodeUser = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtPasswordUser = New System.Windows.Forms.TextBox()
        Me.TxtUsernameUser = New System.Windows.Forms.TextBox()
        Me.BtnCancelUser = New System.Windows.Forms.Button()
        Me.BtnRegisterUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLoginUser = New System.Windows.Forms.Button()
        Me.Pnlup.SuspendLayout()
        Me.PnlUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.Transparent
        Me.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReturn.FlatAppearance.BorderSize = 0
        Me.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturn.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnReturn.Location = New System.Drawing.Point(396, 17)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(97, 37)
        Me.BtnReturn.TabIndex = 51
        Me.BtnReturn.Text = "RETURN"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'BtnUser
        '
        Me.BtnUser.BackColor = System.Drawing.Color.Transparent
        Me.BtnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUser.FlatAppearance.BorderSize = 0
        Me.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUser.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnUser.Location = New System.Drawing.Point(271, 16)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(97, 37)
        Me.BtnUser.TabIndex = 11
        Me.BtnUser.Text = "USER"
        Me.BtnUser.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnExit.Location = New System.Drawing.Point(513, 17)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(97, 37)
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Pnlup
        '
        Me.Pnlup.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Pnlup.BackgroundImage = CType(resources.GetObject("Pnlup.BackgroundImage"), System.Drawing.Image)
        Me.Pnlup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pnlup.Controls.Add(Me.BtnReturn)
        Me.Pnlup.Controls.Add(Me.BtnUser)
        Me.Pnlup.Controls.Add(Me.BtnExit)
        Me.Pnlup.Controls.Add(Me.PnlUser)
        Me.Pnlup.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnlup.Location = New System.Drawing.Point(0, 0)
        Me.Pnlup.Name = "Pnlup"
        Me.Pnlup.Size = New System.Drawing.Size(882, 498)
        Me.Pnlup.TabIndex = 3
        '
        'PnlUser
        '
        Me.PnlUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PnlUser.BackgroundImage = CType(resources.GetObject("PnlUser.BackgroundImage"), System.Drawing.Image)
        Me.PnlUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlUser.Controls.Add(Me.Label2)
        Me.PnlUser.Controls.Add(Me.TxtNamaUser)
        Me.PnlUser.Controls.Add(Me.Label5)
        Me.PnlUser.Controls.Add(Me.Label12)
        Me.PnlUser.Controls.Add(Me.TxtStatusUser)
        Me.PnlUser.Controls.Add(Me.TxtKodeUser)
        Me.PnlUser.Controls.Add(Me.Label13)
        Me.PnlUser.Controls.Add(Me.Label14)
        Me.PnlUser.Controls.Add(Me.TxtPasswordUser)
        Me.PnlUser.Controls.Add(Me.TxtUsernameUser)
        Me.PnlUser.Controls.Add(Me.BtnCancelUser)
        Me.PnlUser.Controls.Add(Me.BtnRegisterUser)
        Me.PnlUser.Controls.Add(Me.Label1)
        Me.PnlUser.Controls.Add(Me.BtnLoginUser)
        Me.PnlUser.Location = New System.Drawing.Point(0, 60)
        Me.PnlUser.Name = "PnlUser"
        Me.PnlUser.Size = New System.Drawing.Size(882, 438)
        Me.PnlUser.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Nama User"
        '
        'TxtNamaUser
        '
        Me.TxtNamaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaUser.Location = New System.Drawing.Point(283, 294)
        Me.TxtNamaUser.Name = "TxtNamaUser"
        Me.TxtNamaUser.Size = New System.Drawing.Size(300, 26)
        Me.TxtNamaUser.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(473, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Status User"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(474, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 20)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Kode User"
        '
        'TxtStatusUser
        '
        Me.TxtStatusUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStatusUser.Location = New System.Drawing.Point(477, 222)
        Me.TxtStatusUser.Name = "TxtStatusUser"
        Me.TxtStatusUser.Size = New System.Drawing.Size(300, 26)
        Me.TxtStatusUser.TabIndex = 61
        '
        'TxtKodeUser
        '
        Me.TxtKodeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKodeUser.Location = New System.Drawing.Point(477, 144)
        Me.TxtKodeUser.Name = "TxtKodeUser"
        Me.TxtKodeUser.Size = New System.Drawing.Size(300, 26)
        Me.TxtKodeUser.TabIndex = 60
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(107, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 20)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(109, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 20)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Username"
        '
        'TxtPasswordUser
        '
        Me.TxtPasswordUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswordUser.Location = New System.Drawing.Point(112, 222)
        Me.TxtPasswordUser.Name = "TxtPasswordUser"
        Me.TxtPasswordUser.Size = New System.Drawing.Size(300, 26)
        Me.TxtPasswordUser.TabIndex = 57
        '
        'TxtUsernameUser
        '
        Me.TxtUsernameUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsernameUser.Location = New System.Drawing.Point(112, 144)
        Me.TxtUsernameUser.Name = "TxtUsernameUser"
        Me.TxtUsernameUser.Size = New System.Drawing.Size(300, 26)
        Me.TxtUsernameUser.TabIndex = 56
        '
        'BtnCancelUser
        '
        Me.BtnCancelUser.BackColor = System.Drawing.Color.Black
        Me.BtnCancelUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelUser.FlatAppearance.BorderSize = 0
        Me.BtnCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelUser.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCancelUser.Location = New System.Drawing.Point(543, 343)
        Me.BtnCancelUser.Name = "BtnCancelUser"
        Me.BtnCancelUser.Size = New System.Drawing.Size(122, 42)
        Me.BtnCancelUser.TabIndex = 49
        Me.BtnCancelUser.Text = "Cancel"
        Me.BtnCancelUser.UseVisualStyleBackColor = False
        '
        'BtnRegisterUser
        '
        Me.BtnRegisterUser.BackColor = System.Drawing.Color.Black
        Me.BtnRegisterUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegisterUser.FlatAppearance.BorderSize = 0
        Me.BtnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegisterUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegisterUser.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnRegisterUser.Location = New System.Drawing.Point(371, 343)
        Me.BtnRegisterUser.Name = "BtnRegisterUser"
        Me.BtnRegisterUser.Size = New System.Drawing.Size(122, 42)
        Me.BtnRegisterUser.TabIndex = 48
        Me.BtnRegisterUser.Text = "Register"
        Me.BtnRegisterUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(240, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 42)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "FORM REGISTER USER"
        '
        'BtnLoginUser
        '
        Me.BtnLoginUser.BackColor = System.Drawing.Color.Black
        Me.BtnLoginUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoginUser.FlatAppearance.BorderSize = 0
        Me.BtnLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoginUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoginUser.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLoginUser.Location = New System.Drawing.Point(213, 343)
        Me.BtnLoginUser.Name = "BtnLoginUser"
        Me.BtnLoginUser.Size = New System.Drawing.Size(122, 42)
        Me.BtnLoginUser.TabIndex = 10
        Me.BtnLoginUser.Text = "Login"
        Me.BtnLoginUser.UseVisualStyleBackColor = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pnlup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Register"
        Me.Pnlup.ResumeLayout(False)
        Me.PnlUser.ResumeLayout(False)
        Me.PnlUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnReturn As Button
    Friend WithEvents BtnUser As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Pnlup As Panel
    Friend WithEvents PnlUser As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNamaUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtStatusUser As TextBox
    Friend WithEvents TxtKodeUser As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtPasswordUser As TextBox
    Friend WithEvents TxtUsernameUser As TextBox
    Friend WithEvents BtnCancelUser As Button
    Friend WithEvents BtnRegisterUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLoginUser As Button
End Class
