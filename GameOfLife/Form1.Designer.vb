<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblMyName = New System.Windows.Forms.Label()
        Me.updater = New System.Windows.Forms.Timer(Me.components)
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Hanzel Extended", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(249, 440)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(249, 78)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Hanzel Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(230, 246)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(319, 37)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Game Of Life"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Hanzel Extended", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(210, 377)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(371, 17)
        Me.lblB.TabIndex = 1
        Me.lblB.Text = "Based on Conway's Game Of Life"
        '
        'lblMyName
        '
        Me.lblMyName.AutoSize = True
        Me.lblMyName.Font = New System.Drawing.Font("Hanzel Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyName.Location = New System.Drawing.Point(174, 309)
        Me.lblMyName.Name = "lblMyName"
        Me.lblMyName.Size = New System.Drawing.Size(444, 37)
        Me.lblMyName.TabIndex = 1
        Me.lblMyName.Text = "By Garrett Beatty"
        '
        'updater
        '
        '
        'mnuStrip
        '
        Me.mnuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(814, 24)
        Me.mnuStrip.TabIndex = 2
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 802)
        Me.Controls.Add(Me.lblMyName)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.mnuStrip)
        Me.DoubleBuffered = True
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuStrip
        Me.MaximumSize = New System.Drawing.Size(830, 850)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameOfLife"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblMyName As System.Windows.Forms.Label
    Friend WithEvents updater As System.Windows.Forms.Timer
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
