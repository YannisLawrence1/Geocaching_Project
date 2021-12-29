<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListCreate))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.butSubmitCache = New System.Windows.Forms.Button()
        Me.txtListName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel1.Controls.Add(Me.butSubmitCache)
        Me.Panel1.Controls.Add(Me.txtListName)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.MaximumSize = New System.Drawing.Size(372, 282)
        Me.Panel1.MinimumSize = New System.Drawing.Size(372, 282)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 282)
        Me.Panel1.TabIndex = 2
        '
        'butSubmitCache
        '
        Me.butSubmitCache.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.butSubmitCache.Location = New System.Drawing.Point(82, 164)
        Me.butSubmitCache.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.butSubmitCache.Name = "butSubmitCache"
        Me.butSubmitCache.Size = New System.Drawing.Size(200, 63)
        Me.butSubmitCache.TabIndex = 37
        Me.butSubmitCache.Text = "Submit"
        Me.butSubmitCache.UseVisualStyleBackColor = True
        '
        'txtListName
        '
        Me.txtListName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtListName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtListName.Location = New System.Drawing.Point(108, 94)
        Me.txtListName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtListName.Name = "txtListName"
        Me.txtListName.Size = New System.Drawing.Size(234, 30)
        Me.txtListName.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(7, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 23)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "List name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 45)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Create a list"
        '
        'ListCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(396, 306)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ListCreate"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents butSubmitCache As Button
    Friend WithEvents txtListName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
End Class
