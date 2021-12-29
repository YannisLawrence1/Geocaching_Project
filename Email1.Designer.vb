<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Email1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.butSubmit = New System.Windows.Forms.Button()
        Me.que1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.butCancel)
        Me.Panel1.Controls.Add(Me.butSubmit)
        Me.Panel1.Controls.Add(Me.que1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.MaximumSize = New System.Drawing.Size(335, 327)
        Me.Panel1.MinimumSize = New System.Drawing.Size(335, 327)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 327)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "email"
        Me.Label1.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(65, 94)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(234, 30)
        Me.txtEmail.TabIndex = 22
        '
        'butCancel
        '
        Me.butCancel.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butCancel.Location = New System.Drawing.Point(73, 214)
        Me.butCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(200, 63)
        Me.butCancel.TabIndex = 21
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'butSubmit
        '
        Me.butSubmit.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butSubmit.Location = New System.Drawing.Point(73, 147)
        Me.butSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.butSubmit.Name = "butSubmit"
        Me.butSubmit.Size = New System.Drawing.Size(200, 63)
        Me.butSubmit.TabIndex = 20
        Me.butSubmit.Text = "Submit"
        Me.butSubmit.UseVisualStyleBackColor = True
        '
        'que1
        '
        Me.que1.AutoSize = True
        Me.que1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.que1.Location = New System.Drawing.Point(3, 23)
        Me.que1.Name = "que1"
        Me.que1.Size = New System.Drawing.Size(219, 23)
        Me.que1.TabIndex = 17
        Me.que1.Text = "Enter your email adress"
        '
        'Email1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(361, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(379, 400)
        Me.MinimumSize = New System.Drawing.Size(379, 400)
        Me.Name = "Email1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Email1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents butCancel As Button
    Friend WithEvents butSubmit As Button
    Friend WithEvents que1 As Label
End Class
