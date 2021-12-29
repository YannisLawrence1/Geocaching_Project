<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.butEmail = New System.Windows.Forms.Button()
        Me.butinfo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.que1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel1.Controls.Add(Me.butCancel)
        Me.Panel1.Controls.Add(Me.butEmail)
        Me.Panel1.Controls.Add(Me.butinfo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.que1)
        Me.Panel1.Location = New System.Drawing.Point(10, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 275)
        Me.Panel1.TabIndex = 1
        '
        'butCancel
        '
        Me.butCancel.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butCancel.Location = New System.Drawing.Point(65, 195)
        Me.butCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(150, 51)
        Me.butCancel.TabIndex = 21
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'butEmail
        '
        Me.butEmail.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butEmail.Location = New System.Drawing.Point(65, 140)
        Me.butEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butEmail.Name = "butEmail"
        Me.butEmail.Size = New System.Drawing.Size(150, 51)
        Me.butEmail.TabIndex = 20
        Me.butEmail.Text = "via email"
        Me.butEmail.UseVisualStyleBackColor = True
        '
        'butinfo
        '
        Me.butinfo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butinfo.Location = New System.Drawing.Point(65, 85)
        Me.butinfo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butinfo.Name = "butinfo"
        Me.butinfo.Size = New System.Drawing.Size(150, 51)
        Me.butinfo.TabIndex = 19
        Me.butinfo.Text = "via Information"
        Me.butinfo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Password"
        '
        'que1
        '
        Me.que1.AutoSize = True
        Me.que1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.que1.Location = New System.Drawing.Point(2, 16)
        Me.que1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.que1.Name = "que1"
        Me.que1.Size = New System.Drawing.Size(222, 18)
        Me.que1.TabIndex = 17
        Me.que1.Text = "Select the method to reset your"
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(308, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(324, 342)
        Me.MinimumSize = New System.Drawing.Size(324, 342)
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ForgotPassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents butCancel As Button
    Friend WithEvents butEmail As Button
    Friend WithEvents butinfo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents que1 As Label
End Class
