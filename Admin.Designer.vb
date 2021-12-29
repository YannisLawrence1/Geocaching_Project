<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.txtLevelOfAccessDisplay = New System.Windows.Forms.Panel()
        Me.butRemove = New System.Windows.Forms.Button()
        Me.butNewAccount = New System.Windows.Forms.Button()
        Me.butChangeAccess = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.txtUserNameDisplay = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.butLogOut = New System.Windows.Forms.Button()
        Me.butAdminOpen = New System.Windows.Forms.Button()
        Me.butListsOpen = New System.Windows.Forms.Button()
        Me.butViewCacheOpen = New System.Windows.Forms.Button()
        Me.butEditCacheOpen = New System.Windows.Forms.Button()
        Me.butNewCacheOpen = New System.Windows.Forms.Button()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.txtLevelOfAccessDisplay.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLevelOfAccessDisplay
        '
        Me.txtLevelOfAccessDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtLevelOfAccessDisplay.Controls.Add(Me.butRemove)
        Me.txtLevelOfAccessDisplay.Controls.Add(Me.butNewAccount)
        Me.txtLevelOfAccessDisplay.Controls.Add(Me.butChangeAccess)
        Me.txtLevelOfAccessDisplay.Controls.Add(Me.Label2)
        Me.txtLevelOfAccessDisplay.Location = New System.Drawing.Point(161, 75)
        Me.txtLevelOfAccessDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLevelOfAccessDisplay.Name = "txtLevelOfAccessDisplay"
        Me.txtLevelOfAccessDisplay.Size = New System.Drawing.Size(1255, 750)
        Me.txtLevelOfAccessDisplay.TabIndex = 20
        '
        'butRemove
        '
        Me.butRemove.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butRemove.Location = New System.Drawing.Point(20, 185)
        Me.butRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.butRemove.Name = "butRemove"
        Me.butRemove.Size = New System.Drawing.Size(150, 51)
        Me.butRemove.TabIndex = 10
        Me.butRemove.Text = "Remove an account"
        Me.butRemove.UseVisualStyleBackColor = True
        '
        'butNewAccount
        '
        Me.butNewAccount.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butNewAccount.Location = New System.Drawing.Point(20, 76)
        Me.butNewAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.butNewAccount.Name = "butNewAccount"
        Me.butNewAccount.Size = New System.Drawing.Size(150, 51)
        Me.butNewAccount.TabIndex = 9
        Me.butNewAccount.Text = "Create a new account"
        Me.butNewAccount.UseVisualStyleBackColor = True
        '
        'butChangeAccess
        '
        Me.butChangeAccess.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butChangeAccess.Location = New System.Drawing.Point(20, 131)
        Me.butChangeAccess.Margin = New System.Windows.Forms.Padding(2)
        Me.butChangeAccess.Name = "butChangeAccess"
        Me.butChangeAccess.Size = New System.Drawing.Size(150, 51)
        Me.butChangeAccess.TabIndex = 8
        Me.butChangeAccess.Text = "Change accounts permissions"
        Me.butChangeAccess.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Admin"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(20, 5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 114)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtTimer)
        Me.Panel2.Controls.Add(Me.txtLevel)
        Me.Panel2.Controls.Add(Me.txtUserNameDisplay)
        Me.Panel2.Location = New System.Drawing.Point(161, 5)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1255, 53)
        Me.Panel2.TabIndex = 19
        '
        'txtTimer
        '
        Me.txtTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtTimer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtTimer.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTimer.Location = New System.Drawing.Point(1153, 15)
        Me.txtTimer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.ReadOnly = True
        Me.txtTimer.Size = New System.Drawing.Size(88, 19)
        Me.txtTimer.TabIndex = 22
        Me.txtTimer.Text = "<timer>"
        '
        'txtLevel
        '
        Me.txtLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLevel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtLevel.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtLevel.Location = New System.Drawing.Point(292, 15)
        Me.txtLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.ReadOnly = True
        Me.txtLevel.Size = New System.Drawing.Size(221, 19)
        Me.txtLevel.TabIndex = 8
        Me.txtLevel.Text = "<LevelOfAccess>"
        '
        'txtUserNameDisplay
        '
        Me.txtUserNameDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtUserNameDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtUserNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserNameDisplay.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtUserNameDisplay.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtUserNameDisplay.Location = New System.Drawing.Point(20, 15)
        Me.txtUserNameDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserNameDisplay.Name = "txtUserNameDisplay"
        Me.txtUserNameDisplay.ReadOnly = True
        Me.txtUserNameDisplay.Size = New System.Drawing.Size(150, 19)
        Me.txtUserNameDisplay.TabIndex = 7
        Me.txtUserNameDisplay.Text = "<UserName>"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.butLogOut)
        Me.Panel1.Controls.Add(Me.butAdminOpen)
        Me.Panel1.Controls.Add(Me.butListsOpen)
        Me.Panel1.Controls.Add(Me.butViewCacheOpen)
        Me.Panel1.Controls.Add(Me.butEditCacheOpen)
        Me.Panel1.Controls.Add(Me.butNewCacheOpen)
        Me.Panel1.Location = New System.Drawing.Point(8, 151)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 674)
        Me.Panel1.TabIndex = 18
        '
        'butLogOut
        '
        Me.butLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.butLogOut.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butLogOut.Location = New System.Drawing.Point(0, 561)
        Me.butLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.butLogOut.Name = "butLogOut"
        Me.butLogOut.Size = New System.Drawing.Size(136, 114)
        Me.butLogOut.TabIndex = 5
        Me.butLogOut.Text = "Log Out"
        Me.butLogOut.UseVisualStyleBackColor = False
        '
        'butAdminOpen
        '
        Me.butAdminOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.butAdminOpen.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butAdminOpen.Location = New System.Drawing.Point(0, 448)
        Me.butAdminOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.butAdminOpen.Name = "butAdminOpen"
        Me.butAdminOpen.Size = New System.Drawing.Size(136, 114)
        Me.butAdminOpen.TabIndex = 4
        Me.butAdminOpen.Text = "Admin"
        Me.butAdminOpen.UseVisualStyleBackColor = False
        '
        'butListsOpen
        '
        Me.butListsOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.butListsOpen.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butListsOpen.Location = New System.Drawing.Point(0, 336)
        Me.butListsOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.butListsOpen.Name = "butListsOpen"
        Me.butListsOpen.Size = New System.Drawing.Size(136, 114)
        Me.butListsOpen.TabIndex = 3
        Me.butListsOpen.Text = "Lists"
        Me.butListsOpen.UseVisualStyleBackColor = False
        '
        'butViewCacheOpen
        '
        Me.butViewCacheOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.butViewCacheOpen.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butViewCacheOpen.Location = New System.Drawing.Point(0, 224)
        Me.butViewCacheOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.butViewCacheOpen.Name = "butViewCacheOpen"
        Me.butViewCacheOpen.Size = New System.Drawing.Size(136, 114)
        Me.butViewCacheOpen.TabIndex = 2
        Me.butViewCacheOpen.Text = "View Cache"
        Me.butViewCacheOpen.UseVisualStyleBackColor = False
        '
        'butEditCacheOpen
        '
        Me.butEditCacheOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.butEditCacheOpen.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butEditCacheOpen.Location = New System.Drawing.Point(0, 112)
        Me.butEditCacheOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.butEditCacheOpen.Name = "butEditCacheOpen"
        Me.butEditCacheOpen.Size = New System.Drawing.Size(136, 114)
        Me.butEditCacheOpen.TabIndex = 1
        Me.butEditCacheOpen.Text = "Edit Cache"
        Me.butEditCacheOpen.UseVisualStyleBackColor = False
        '
        'butNewCacheOpen
        '
        Me.butNewCacheOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.butNewCacheOpen.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butNewCacheOpen.Location = New System.Drawing.Point(0, 0)
        Me.butNewCacheOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.butNewCacheOpen.Name = "butNewCacheOpen"
        Me.butNewCacheOpen.Size = New System.Drawing.Size(136, 114)
        Me.butNewCacheOpen.TabIndex = 0
        Me.butNewCacheOpen.Text = "New Cache"
        Me.butNewCacheOpen.UseVisualStyleBackColor = False
        '
        'timClock
        '
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1426, 835)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtLevelOfAccessDisplay)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1442, 876)
        Me.MinimumSize = New System.Drawing.Size(1442, 851)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.txtLevelOfAccessDisplay.ResumeLayout(False)
        Me.txtLevelOfAccessDisplay.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtLevelOfAccessDisplay As Panel
    Friend WithEvents butChangeAccess As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents txtUserNameDisplay As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents butLogOut As Button
    Friend WithEvents butAdminOpen As Button
    Friend WithEvents butListsOpen As Button
    Friend WithEvents butViewCacheOpen As Button
    Friend WithEvents butEditCacheOpen As Button
    Friend WithEvents butNewCacheOpen As Button
    Friend WithEvents butRemove As Button
    Friend WithEvents butNewAccount As Button
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents timClock As Timer
End Class
