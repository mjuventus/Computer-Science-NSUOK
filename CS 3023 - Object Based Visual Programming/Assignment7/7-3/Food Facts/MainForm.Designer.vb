<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.radBanana = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radPopcorn = New System.Windows.Forms.RadioButton()
        Me.radMuffin = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radBanana
        '
        Me.radBanana.AutoSize = True
        Me.radBanana.Location = New System.Drawing.Point(29, 30)
        Me.radBanana.Name = "radBanana"
        Me.radBanana.Size = New System.Drawing.Size(71, 17)
        Me.radBanana.TabIndex = 0
        Me.radBanana.TabStop = True
        Me.radBanana.Text = "1 Banana"
        Me.radBanana.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMuffin)
        Me.GroupBox1.Controls.Add(Me.radPopcorn)
        Me.GroupBox1.Controls.Add(Me.radBanana)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 123)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Food"
        '
        'radPopcorn
        '
        Me.radPopcorn.AutoSize = True
        Me.radPopcorn.Location = New System.Drawing.Point(29, 53)
        Me.radPopcorn.Name = "radPopcorn"
        Me.radPopcorn.Size = New System.Drawing.Size(160, 17)
        Me.radPopcorn.TabIndex = 0
        Me.radPopcorn.TabStop = True
        Me.radPopcorn.Text = "1 Cup of air-popped popcorn"
        Me.radPopcorn.UseVisualStyleBackColor = True
        '
        'radMuffin
        '
        Me.radMuffin.AutoSize = True
        Me.radMuffin.Location = New System.Drawing.Point(29, 76)
        Me.radMuffin.Name = "radMuffin"
        Me.radMuffin.Size = New System.Drawing.Size(138, 17)
        Me.radMuffin.TabIndex = 0
        Me.radMuffin.TabStop = True
        Me.radMuffin.Text = "1 Large blueberry muffin"
        Me.radMuffin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 48)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Display Food Facts"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(195, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 277)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radBanana As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMuffin As RadioButton
    Friend WithEvents radPopcorn As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
