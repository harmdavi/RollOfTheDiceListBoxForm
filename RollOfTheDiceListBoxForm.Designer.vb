﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollOfTheDiceListBoxForm
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
        Me.RollTheDiceBox = New System.Windows.Forms.ListBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RollTheDiceBox
        '
        Me.RollTheDiceBox.FormattingEnabled = True
        Me.RollTheDiceBox.ItemHeight = 25
        Me.RollTheDiceBox.Location = New System.Drawing.Point(12, 68)
        Me.RollTheDiceBox.Name = "RollTheDiceBox"
        Me.RollTheDiceBox.Size = New System.Drawing.Size(1018, 604)
        Me.RollTheDiceBox.TabIndex = 0
        Me.RollTheDiceBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(803, 691)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(171, 94)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(490, 691)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(171, 94)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(120, 691)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(171, 94)
        Me.RollButton.TabIndex = 1
        Me.RollButton.Text = "Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1104, 40)
        Me.MenuStrip2.TabIndex = 7
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuToolStripMenuItem1
        '
        Me.MenuToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RollToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem1.Name = "MenuToolStripMenuItem1"
        Me.MenuToolStripMenuItem1.Size = New System.Drawing.Size(98, 36)
        Me.MenuToolStripMenuItem1.Text = "Menu"
        '
        'RollToolStripMenuItem
        '
        Me.RollToolStripMenuItem.Name = "RollToolStripMenuItem"
        Me.RollToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.RollToolStripMenuItem.Text = "Roll"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(85, 36)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'RollOfTheDiceListBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 835)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RollTheDiceBox)
        Me.Name = "RollOfTheDiceListBoxForm"
        Me.Text = "Roll of The Dice"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RollTheDiceBox As ListBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents RollButton As Button
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
