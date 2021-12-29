<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectSecurityQuestionvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectSecurityQuestionvb))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.comQuestion = New System.Windows.Forms.ComboBox()
        Me.butLogIn = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel1.Controls.Add(Me.comQuestion)
        Me.Panel1.Controls.Add(Me.butLogIn)
        Me.Panel1.Controls.Add(Me.txtAnswer)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 326)
        Me.Panel1.TabIndex = 3
        '
        'comQuestion
        '
        Me.comQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comQuestion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comQuestion.FormattingEnabled = True
        Me.comQuestion.Items.AddRange(New Object() {"What primary school did you attend?", "What was the name of your fist pet?", "What was your mothers maiden name?"})
        Me.comQuestion.Location = New System.Drawing.Point(116, 115)
        Me.comQuestion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comQuestion.MaxDropDownItems = 6
        Me.comQuestion.Name = "comQuestion"
        Me.comQuestion.Size = New System.Drawing.Size(390, 31)
        Me.comQuestion.TabIndex = 34
        '
        'butLogIn
        '
        Me.butLogIn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butLogIn.Location = New System.Drawing.Point(91, 231)
        Me.butLogIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.butLogIn.Name = "butLogIn"
        Me.butLogIn.Size = New System.Drawing.Size(200, 63)
        Me.butLogIn.TabIndex = 8
        Me.butLogIn.Text = "Submit"
        Me.butLogIn.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtAnswer.Location = New System.Drawing.Point(116, 173)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(234, 30)
        Me.txtAnswer.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Answer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select the security question for your Account"
        '
        'SelectSecurityQuestionvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(543, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(561, 395)
        Me.MinimumSize = New System.Drawing.Size(561, 395)
        Me.Name = "SelectSecurityQuestionvb"
        Me.Text = "SelectSecurityQuestionvb"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents butLogIn As Button
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents comQuestion As ComboBox
End Class
