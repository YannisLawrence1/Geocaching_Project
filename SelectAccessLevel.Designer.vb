<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectAccessLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectAccessLevel))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.comAccessLevel = New System.Windows.Forms.ComboBox()
        Me.txtLevelOfAccessDisplay = New System.Windows.Forms.TextBox()
        Me.butSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel2.Controls.Add(Me.comAccessLevel)
        Me.Panel2.Controls.Add(Me.txtLevelOfAccessDisplay)
        Me.Panel2.Controls.Add(Me.butSubmit)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(408, 282)
        Me.Panel2.TabIndex = 2
        '
        'comAccessLevel
        '
        Me.comAccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comAccessLevel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comAccessLevel.FormattingEnabled = True
        Me.comAccessLevel.Items.AddRange(New Object() {"read only", "read and write", "read, write and remove", "admin"})
        Me.comAccessLevel.Location = New System.Drawing.Point(139, 93)
        Me.comAccessLevel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comAccessLevel.MaxDropDownItems = 6
        Me.comAccessLevel.Name = "comAccessLevel"
        Me.comAccessLevel.Size = New System.Drawing.Size(233, 31)
        Me.comAccessLevel.TabIndex = 39
        '
        'txtLevelOfAccessDisplay
        '
        Me.txtLevelOfAccessDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtLevelOfAccessDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLevelOfAccessDisplay.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtLevelOfAccessDisplay.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txtLevelOfAccessDisplay.Location = New System.Drawing.Point(11, 20)
        Me.txtLevelOfAccessDisplay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLevelOfAccessDisplay.Name = "txtLevelOfAccessDisplay"
        Me.txtLevelOfAccessDisplay.ReadOnly = True
        Me.txtLevelOfAccessDisplay.Size = New System.Drawing.Size(378, 27)
        Me.txtLevelOfAccessDisplay.TabIndex = 38
        Me.txtLevelOfAccessDisplay.Text = "Select access level for <User>"
        '
        'butSubmit
        '
        Me.butSubmit.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butSubmit.Location = New System.Drawing.Point(100, 162)
        Me.butSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.butSubmit.Name = "butSubmit"
        Me.butSubmit.Size = New System.Drawing.Size(200, 63)
        Me.butSubmit.TabIndex = 37
        Me.butSubmit.Text = "Submit"
        Me.butSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Access Level"
        '
        'SelectAccessLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 306)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelectAccessLevel"
        Me.Text = "SelectAccessLevel"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Private WithEvents txtLevelOfAccessDisplay As TextBox
    Friend WithEvents butSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents comAccessLevel As ComboBox
End Class
