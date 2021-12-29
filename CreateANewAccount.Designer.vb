<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateANewAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateANewAccount))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.butSubmit = New System.Windows.Forms.Button()
        Me.comAccessLevel = New System.Windows.Forms.ComboBox()
        Me.picFirstName = New System.Windows.Forms.PictureBox()
        Me.picLevelOfAccess = New System.Windows.Forms.PictureBox()
        Me.picEmail = New System.Windows.Forms.PictureBox()
        Me.picUsername = New System.Windows.Forms.PictureBox()
        Me.picLastName = New System.Windows.Forms.PictureBox()
        Me.picLevelOfAccessX = New System.Windows.Forms.PictureBox()
        Me.picFirstNameX = New System.Windows.Forms.PictureBox()
        Me.picUsernameX = New System.Windows.Forms.PictureBox()
        Me.picEmailX = New System.Windows.Forms.PictureBox()
        Me.picLastNameX = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLevelOfAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLevelOfAccessX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFirstNameX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsernameX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEmailX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLastNameX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel1.Controls.Add(Me.butCancel)
        Me.Panel1.Controls.Add(Me.butSubmit)
        Me.Panel1.Controls.Add(Me.comAccessLevel)
        Me.Panel1.Controls.Add(Me.picFirstName)
        Me.Panel1.Controls.Add(Me.picLevelOfAccess)
        Me.Panel1.Controls.Add(Me.picEmail)
        Me.Panel1.Controls.Add(Me.picUsername)
        Me.Panel1.Controls.Add(Me.picLastName)
        Me.Panel1.Controls.Add(Me.picLevelOfAccessX)
        Me.Panel1.Controls.Add(Me.picFirstNameX)
        Me.Panel1.Controls.Add(Me.picUsernameX)
        Me.Panel1.Controls.Add(Me.picEmailX)
        Me.Panel1.Controls.Add(Me.picLastNameX)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 376)
        Me.Panel1.TabIndex = 0
        '
        'butSubmit
        '
        Me.butSubmit.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butSubmit.Location = New System.Drawing.Point(17, 287)
        Me.butSubmit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butSubmit.Name = "butSubmit"
        Me.butSubmit.Size = New System.Drawing.Size(150, 51)
        Me.butSubmit.TabIndex = 70
        Me.butSubmit.Text = "Submit"
        Me.butSubmit.UseVisualStyleBackColor = True
        '
        'comAccessLevel
        '
        Me.comAccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comAccessLevel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comAccessLevel.FormattingEnabled = True
        Me.comAccessLevel.Items.AddRange(New Object() {"read only", "read and write", "read, write and remove", "admin"})
        Me.comAccessLevel.Location = New System.Drawing.Point(129, 229)
        Me.comAccessLevel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.comAccessLevel.MaxDropDownItems = 6
        Me.comAccessLevel.Name = "comAccessLevel"
        Me.comAccessLevel.Size = New System.Drawing.Size(176, 26)
        Me.comAccessLevel.TabIndex = 69
        '
        'picFirstName
        '
        Me.picFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picFirstName.Image = CType(resources.GetObject("picFirstName.Image"), System.Drawing.Image)
        Me.picFirstName.Location = New System.Drawing.Point(309, 60)
        Me.picFirstName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picFirstName.Name = "picFirstName"
        Me.picFirstName.Size = New System.Drawing.Size(38, 32)
        Me.picFirstName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFirstName.TabIndex = 59
        Me.picFirstName.TabStop = False
        Me.picFirstName.Visible = False
        '
        'picLevelOfAccess
        '
        Me.picLevelOfAccess.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picLevelOfAccess.Image = CType(resources.GetObject("picLevelOfAccess.Image"), System.Drawing.Image)
        Me.picLevelOfAccess.Location = New System.Drawing.Point(309, 222)
        Me.picLevelOfAccess.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picLevelOfAccess.Name = "picLevelOfAccess"
        Me.picLevelOfAccess.Size = New System.Drawing.Size(38, 32)
        Me.picLevelOfAccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLevelOfAccess.TabIndex = 68
        Me.picLevelOfAccess.TabStop = False
        Me.picLevelOfAccess.Visible = False
        '
        'picEmail
        '
        Me.picEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picEmail.Image = CType(resources.GetObject("picEmail.Image"), System.Drawing.Image)
        Me.picEmail.Location = New System.Drawing.Point(309, 182)
        Me.picEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picEmail.Name = "picEmail"
        Me.picEmail.Size = New System.Drawing.Size(38, 32)
        Me.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmail.TabIndex = 67
        Me.picEmail.TabStop = False
        Me.picEmail.Visible = False
        '
        'picUsername
        '
        Me.picUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picUsername.Image = CType(resources.GetObject("picUsername.Image"), System.Drawing.Image)
        Me.picUsername.Location = New System.Drawing.Point(309, 141)
        Me.picUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picUsername.Name = "picUsername"
        Me.picUsername.Size = New System.Drawing.Size(38, 32)
        Me.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUsername.TabIndex = 66
        Me.picUsername.TabStop = False
        Me.picUsername.Visible = False
        '
        'picLastName
        '
        Me.picLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picLastName.Image = CType(resources.GetObject("picLastName.Image"), System.Drawing.Image)
        Me.picLastName.Location = New System.Drawing.Point(309, 101)
        Me.picLastName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picLastName.Name = "picLastName"
        Me.picLastName.Size = New System.Drawing.Size(38, 32)
        Me.picLastName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLastName.TabIndex = 65
        Me.picLastName.TabStop = False
        Me.picLastName.Visible = False
        '
        'picLevelOfAccessX
        '
        Me.picLevelOfAccessX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picLevelOfAccessX.Image = CType(resources.GetObject("picLevelOfAccessX.Image"), System.Drawing.Image)
        Me.picLevelOfAccessX.Location = New System.Drawing.Point(309, 222)
        Me.picLevelOfAccessX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picLevelOfAccessX.Name = "picLevelOfAccessX"
        Me.picLevelOfAccessX.Size = New System.Drawing.Size(30, 32)
        Me.picLevelOfAccessX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLevelOfAccessX.TabIndex = 64
        Me.picLevelOfAccessX.TabStop = False
        '
        'picFirstNameX
        '
        Me.picFirstNameX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picFirstNameX.Image = CType(resources.GetObject("picFirstNameX.Image"), System.Drawing.Image)
        Me.picFirstNameX.Location = New System.Drawing.Point(309, 60)
        Me.picFirstNameX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picFirstNameX.Name = "picFirstNameX"
        Me.picFirstNameX.Size = New System.Drawing.Size(30, 32)
        Me.picFirstNameX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFirstNameX.TabIndex = 63
        Me.picFirstNameX.TabStop = False
        '
        'picUsernameX
        '
        Me.picUsernameX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picUsernameX.Image = CType(resources.GetObject("picUsernameX.Image"), System.Drawing.Image)
        Me.picUsernameX.Location = New System.Drawing.Point(309, 141)
        Me.picUsernameX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picUsernameX.Name = "picUsernameX"
        Me.picUsernameX.Size = New System.Drawing.Size(30, 32)
        Me.picUsernameX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUsernameX.TabIndex = 62
        Me.picUsernameX.TabStop = False
        '
        'picEmailX
        '
        Me.picEmailX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picEmailX.Image = CType(resources.GetObject("picEmailX.Image"), System.Drawing.Image)
        Me.picEmailX.Location = New System.Drawing.Point(309, 182)
        Me.picEmailX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picEmailX.Name = "picEmailX"
        Me.picEmailX.Size = New System.Drawing.Size(30, 32)
        Me.picEmailX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmailX.TabIndex = 61
        Me.picEmailX.TabStop = False
        '
        'picLastNameX
        '
        Me.picLastNameX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picLastNameX.Image = CType(resources.GetObject("picLastNameX.Image"), System.Drawing.Image)
        Me.picLastNameX.Location = New System.Drawing.Point(309, 101)
        Me.picLastNameX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picLastNameX.Name = "picLastNameX"
        Me.picLastNameX.Size = New System.Drawing.Size(30, 32)
        Me.picLastNameX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLastNameX.TabIndex = 60
        Me.picLastNameX.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(14, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Level of Access"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(129, 190)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(176, 26)
        Me.txtEmail.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(14, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(14, 150)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(129, 149)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(176, 26)
        Me.txtUsername.TabIndex = 17
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtLastName.Location = New System.Drawing.Point(129, 109)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(176, 26)
        Me.txtLastName.TabIndex = 16
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(129, 68)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(176, 26)
        Me.txtFirstName.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(14, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Last name"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label.Location = New System.Drawing.Point(14, 70)
        Me.Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(82, 18)
        Me.Label.TabIndex = 11
        Me.Label.Text = "First name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create a new account"
        '
        'butCancel
        '
        Me.butCancel.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butCancel.Location = New System.Drawing.Point(197, 287)
        Me.butCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(150, 51)
        Me.butCancel.TabIndex = 71
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'CreateANewAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 396)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CreateANewAccount"
        Me.Text = "S"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLevelOfAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLevelOfAccessX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFirstNameX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsernameX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEmailX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLastNameX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picFirstName As PictureBox
    Friend WithEvents picLevelOfAccess As PictureBox
    Friend WithEvents picEmail As PictureBox
    Friend WithEvents picUsername As PictureBox
    Friend WithEvents picLastName As PictureBox
    Friend WithEvents picLevelOfAccessX As PictureBox
    Friend WithEvents picFirstNameX As PictureBox
    Friend WithEvents picUsernameX As PictureBox
    Friend WithEvents picEmailX As PictureBox
    Friend WithEvents picLastNameX As PictureBox
    Friend WithEvents comAccessLevel As ComboBox
    Friend WithEvents butSubmit As Button
    Friend WithEvents butCancel As Button
End Class
