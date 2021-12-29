<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.radGeocacheNumber = New System.Windows.Forms.RadioButton()
        Me.radChurchMicro = New System.Windows.Forms.RadioButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.butSubmitCache = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.txtLevelOfAccessDisplay = New System.Windows.Forms.TextBox()
        Me.txtUserNameDisplay = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.butListsOpen = New System.Windows.Forms.Button()
        Me.butLogOut = New System.Windows.Forms.Button()
        Me.butAdminOpen = New System.Windows.Forms.Button()
        Me.butViewCacheOpen = New System.Windows.Forms.Button()
        Me.butEditCacheOpen = New System.Windows.Forms.Button()
        Me.butNewCacheOpen = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel3.Controls.Add(Me.radGeocacheNumber)
        Me.Panel3.Controls.Add(Me.radChurchMicro)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.butSubmitCache)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(163, 80)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1255, 750)
        Me.Panel3.TabIndex = 20
        '
        'radGeocacheNumber
        '
        Me.radGeocacheNumber.AutoSize = True
        Me.radGeocacheNumber.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.radGeocacheNumber.Location = New System.Drawing.Point(20, 84)
        Me.radGeocacheNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radGeocacheNumber.Name = "radGeocacheNumber"
        Me.radGeocacheNumber.Size = New System.Drawing.Size(144, 20)
        Me.radGeocacheNumber.TabIndex = 118
        Me.radGeocacheNumber.TabStop = True
        Me.radGeocacheNumber.Text = "Geocache Number"
        Me.radGeocacheNumber.UseVisualStyleBackColor = True
        '
        'radChurchMicro
        '
        Me.radChurchMicro.AutoSize = True
        Me.radChurchMicro.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.radChurchMicro.Location = New System.Drawing.Point(20, 106)
        Me.radChurchMicro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radChurchMicro.Name = "radChurchMicro"
        Me.radChurchMicro.Size = New System.Drawing.Size(163, 20)
        Me.radChurchMicro.TabIndex = 117
        Me.radChurchMicro.TabStop = True
        Me.radChurchMicro.Text = "Church Micro Number"
        Me.radChurchMicro.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(184, 92)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(176, 26)
        Me.txtSearch.TabIndex = 13
        '
        'butSubmitCache
        '
        Me.butSubmitCache.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butSubmitCache.Location = New System.Drawing.Point(90, 146)
        Me.butSubmitCache.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butSubmitCache.Name = "butSubmitCache"
        Me.butSubmitCache.Size = New System.Drawing.Size(150, 51)
        Me.butSubmitCache.TabIndex = 8
        Me.butSubmitCache.Text = "Submit"
        Me.butSubmitCache.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Edit A Cache"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtTimer)
        Me.Panel2.Controls.Add(Me.txtLevelOfAccessDisplay)
        Me.Panel2.Controls.Add(Me.txtUserNameDisplay)
        Me.Panel2.Location = New System.Drawing.Point(163, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.txtTimer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.ReadOnly = True
        Me.txtTimer.Size = New System.Drawing.Size(88, 19)
        Me.txtTimer.TabIndex = 10
        Me.txtTimer.Text = "<timer>"
        '
        'txtLevelOfAccessDisplay
        '
        Me.txtLevelOfAccessDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtLevelOfAccessDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLevelOfAccessDisplay.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtLevelOfAccessDisplay.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtLevelOfAccessDisplay.Location = New System.Drawing.Point(292, 15)
        Me.txtLevelOfAccessDisplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLevelOfAccessDisplay.Name = "txtLevelOfAccessDisplay"
        Me.txtLevelOfAccessDisplay.ReadOnly = True
        Me.txtLevelOfAccessDisplay.Size = New System.Drawing.Size(221, 19)
        Me.txtLevelOfAccessDisplay.TabIndex = 8
        Me.txtLevelOfAccessDisplay.Text = "<LevelOfAccess>"
        '
        'txtUserNameDisplay
        '
        Me.txtUserNameDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtUserNameDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtUserNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserNameDisplay.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtUserNameDisplay.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtUserNameDisplay.Location = New System.Drawing.Point(20, 15)
        Me.txtUserNameDisplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUserNameDisplay.Name = "txtUserNameDisplay"
        Me.txtUserNameDisplay.ReadOnly = True
        Me.txtUserNameDisplay.Size = New System.Drawing.Size(150, 19)
        Me.txtUserNameDisplay.TabIndex = 7
        Me.txtUserNameDisplay.Text = "<UserName>"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.butListsOpen)
        Me.Panel1.Controls.Add(Me.butLogOut)
        Me.Panel1.Controls.Add(Me.butAdminOpen)
        Me.Panel1.Controls.Add(Me.butViewCacheOpen)
        Me.Panel1.Controls.Add(Me.butEditCacheOpen)
        Me.Panel1.Controls.Add(Me.butNewCacheOpen)
        Me.Panel1.Location = New System.Drawing.Point(9, 156)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 674)
        Me.Panel1.TabIndex = 18
        '
        'butListsOpen
        '
        Me.butListsOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.butListsOpen.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butListsOpen.Location = New System.Drawing.Point(0, 336)
        Me.butListsOpen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butListsOpen.Name = "butListsOpen"
        Me.butListsOpen.Size = New System.Drawing.Size(136, 114)
        Me.butListsOpen.TabIndex = 6
        Me.butListsOpen.Text = "Lists"
        Me.butListsOpen.UseVisualStyleBackColor = False
        '
        'butLogOut
        '
        Me.butLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.butLogOut.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butLogOut.Location = New System.Drawing.Point(0, 561)
        Me.butLogOut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.butAdminOpen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAdminOpen.Name = "butAdminOpen"
        Me.butAdminOpen.Size = New System.Drawing.Size(136, 114)
        Me.butAdminOpen.TabIndex = 4
        Me.butAdminOpen.Text = "Admin"
        Me.butAdminOpen.UseVisualStyleBackColor = False
        '
        'butViewCacheOpen
        '
        Me.butViewCacheOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.butViewCacheOpen.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butViewCacheOpen.Location = New System.Drawing.Point(0, 224)
        Me.butViewCacheOpen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.butEditCacheOpen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.butNewCacheOpen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butNewCacheOpen.Name = "butNewCacheOpen"
        Me.butNewCacheOpen.Size = New System.Drawing.Size(136, 114)
        Me.butNewCacheOpen.TabIndex = 0
        Me.butNewCacheOpen.Text = "New Cache"
        Me.butNewCacheOpen.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(22, 10)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 114)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'timClock
        '
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1426, 839)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1442, 885)
        Me.MinimumSize = New System.Drawing.Size(1442, 850)
        Me.Name = "Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtLevelOfAccessDisplay As TextBox
    Friend WithEvents txtUserNameDisplay As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents butLogOut As Button
    Friend WithEvents butAdminOpen As Button
    Friend WithEvents butViewCacheOpen As Button
    Friend WithEvents butEditCacheOpen As Button
    Friend WithEvents butNewCacheOpen As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents butSubmitCache As Button
    Friend WithEvents radGeocacheNumber As RadioButton
    Friend WithEvents radChurchMicro As RadioButton
    Friend WithEvents butListsOpen As Button
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents timClock As Timer
End Class
