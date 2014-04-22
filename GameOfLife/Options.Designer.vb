<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.lblColorScheme = New System.Windows.Forms.Label()
        Me.lblDead = New System.Windows.Forms.Label()
        Me.lblAlive = New System.Windows.Forms.Label()
        Me.cboAliveColor = New System.Windows.Forms.ComboBox()
        Me.cboDeadColor = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblRandom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRandom = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblColorScheme
        '
        Me.lblColorScheme.AutoSize = True
        Me.lblColorScheme.Font = New System.Drawing.Font("Hanzel Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColorScheme.Location = New System.Drawing.Point(115, 31)
        Me.lblColorScheme.Name = "lblColorScheme"
        Me.lblColorScheme.Size = New System.Drawing.Size(332, 22)
        Me.lblColorScheme.TabIndex = 0
        Me.lblColorScheme.Text = "Change Color Scheme"
        Me.lblColorScheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDead
        '
        Me.lblDead.AutoSize = True
        Me.lblDead.Font = New System.Drawing.Font("Hanzel Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDead.Location = New System.Drawing.Point(174, 92)
        Me.lblDead.Name = "lblDead"
        Me.lblDead.Size = New System.Drawing.Size(85, 22)
        Me.lblDead.TabIndex = 0
        Me.lblDead.Text = "Dead"
        '
        'lblAlive
        '
        Me.lblAlive.AutoSize = True
        Me.lblAlive.Font = New System.Drawing.Font("Hanzel Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlive.Location = New System.Drawing.Point(317, 92)
        Me.lblAlive.Name = "lblAlive"
        Me.lblAlive.Size = New System.Drawing.Size(81, 22)
        Me.lblAlive.TabIndex = 0
        Me.lblAlive.Text = "Alive"
        '
        'cboAliveColor
        '
        Me.cboAliveColor.FormattingEnabled = True
        Me.cboAliveColor.Items.AddRange(New Object() {"Green", "Red", "Blue", "White", "Black"})
        Me.cboAliveColor.Location = New System.Drawing.Point(297, 129)
        Me.cboAliveColor.Name = "cboAliveColor"
        Me.cboAliveColor.Size = New System.Drawing.Size(121, 21)
        Me.cboAliveColor.TabIndex = 2
        '
        'cboDeadColor
        '
        Me.cboDeadColor.FormattingEnabled = True
        Me.cboDeadColor.Items.AddRange(New Object() {"Green", "Red", "Blue", "White", "Black"})
        Me.cboDeadColor.Location = New System.Drawing.Point(150, 129)
        Me.cboDeadColor.Name = "cboDeadColor"
        Me.cboDeadColor.Size = New System.Drawing.Size(121, 21)
        Me.cboDeadColor.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Hanzel Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(343, 306)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(216, 58)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Hanzel Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(43, 306)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(216, 58)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblRandom
        '
        Me.lblRandom.AutoSize = True
        Me.lblRandom.Font = New System.Drawing.Font("Hanzel Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandom.Location = New System.Drawing.Point(77, 179)
        Me.lblRandom.Name = "lblRandom"
        Me.lblRandom.Size = New System.Drawing.Size(443, 22)
        Me.lblRandom.TabIndex = 0
        Me.lblRandom.Text = "Amount Randomly Generated"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hanzel Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "(Higher = Less)"
        '
        'txtRandom
        '
        Me.txtRandom.Location = New System.Drawing.Point(238, 233)
        Me.txtRandom.Name = "txtRandom"
        Me.txtRandom.Size = New System.Drawing.Size(100, 20)
        Me.txtRandom.TabIndex = 3
        Me.txtRandom.Text = "4"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 388)
        Me.Controls.Add(Me.txtRandom)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboDeadColor)
        Me.Controls.Add(Me.cboAliveColor)
        Me.Controls.Add(Me.lblAlive)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRandom)
        Me.Controls.Add(Me.lblDead)
        Me.Controls.Add(Me.lblColorScheme)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColorScheme As System.Windows.Forms.Label
    Friend WithEvents lblDead As System.Windows.Forms.Label
    Friend WithEvents lblAlive As System.Windows.Forms.Label
    Friend WithEvents cboAliveColor As System.Windows.Forms.ComboBox
    Friend WithEvents cboDeadColor As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblRandom As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRandom As System.Windows.Forms.TextBox
End Class
