<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.que1 = New System.Windows.Forms.Label()
        Me.que3 = New System.Windows.Forms.Label()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.que2 = New System.Windows.Forms.Label()
        Me.butSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.que1)
        Me.Panel1.Controls.Add(Me.que3)
        Me.Panel1.Controls.Add(Me.txtQuestion)
        Me.Panel1.Controls.Add(Me.que2)
        Me.Panel1.Controls.Add(Me.butSubmit)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 310)
        Me.Panel1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(324, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Incorrect question answer, try again"
        Me.Label5.Visible = False
        '
        'que1
        '
        Me.que1.AutoSize = True
        Me.que1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.que1.Location = New System.Drawing.Point(19, 88)
        Me.que1.Name = "que1"
        Me.que1.Size = New System.Drawing.Size(331, 23)
        Me.que1.TabIndex = 16
        Me.que1.Text = "What primary school did you attend?"
        Me.que1.Visible = False
        '
        'que3
        '
        Me.que3.AutoSize = True
        Me.que3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.que3.Location = New System.Drawing.Point(14, 88)
        Me.que3.Name = "que3"
        Me.que3.Size = New System.Drawing.Size(353, 23)
        Me.que3.TabIndex = 15
        Me.que3.Text = "What was your mothers maiden name?"
        Me.que3.Visible = False
        '
        'txtQuestion
        '
        Me.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtQuestion.Location = New System.Drawing.Point(80, 140)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(234, 30)
        Me.txtQuestion.TabIndex = 14
        '
        'que2
        '
        Me.que2.AutoSize = True
        Me.que2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.que2.Location = New System.Drawing.Point(14, 88)
        Me.que2.Name = "que2"
        Me.que2.Size = New System.Drawing.Size(336, 23)
        Me.que2.TabIndex = 10
        Me.que2.Text = "What was the name of your first pet?"
        '
        'butSubmit
        '
        Me.butSubmit.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butSubmit.Location = New System.Drawing.Point(93, 214)
        Me.butSubmit.Name = "butSubmit"
        Me.butSubmit.Size = New System.Drawing.Size(200, 63)
        Me.butSubmit.TabIndex = 8
        Me.butSubmit.Text = "Submit"
        Me.butSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Forgot Password"
        '
        'ForgotPassword2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(410, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ForgotPassword2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FogotPassword2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents que2 As Label
    Friend WithEvents butSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents que3 As Label
    Friend WithEvents que1 As Label
    Friend WithEvents Label5 As Label
End Class
