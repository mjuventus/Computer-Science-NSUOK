<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TextDay = New System.Windows.Forms.TextBox()
        Me.TextMonth = New System.Windows.Forms.TextBox()
        Me.TextDate = New System.Windows.Forms.TextBox()
        Me.TextYear = New System.Windows.Forms.TextBox()
        Me.LblDateString = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnShowData = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextDay
        '
        Me.TextDay.Location = New System.Drawing.Point(210, 50)
        Me.TextDay.Name = "TextDay"
        Me.TextDay.Size = New System.Drawing.Size(213, 20)
        Me.TextDay.TabIndex = 0
        '
        'TextMonth
        '
        Me.TextMonth.Location = New System.Drawing.Point(210, 87)
        Me.TextMonth.Name = "TextMonth"
        Me.TextMonth.Size = New System.Drawing.Size(213, 20)
        Me.TextMonth.TabIndex = 1
        '
        'TextDate
        '
        Me.TextDate.Location = New System.Drawing.Point(210, 125)
        Me.TextDate.Name = "TextDate"
        Me.TextDate.Size = New System.Drawing.Size(213, 20)
        Me.TextDate.TabIndex = 2
        '
        'TextYear
        '
        Me.TextYear.Location = New System.Drawing.Point(210, 163)
        Me.TextYear.Name = "TextYear"
        Me.TextYear.Size = New System.Drawing.Size(213, 20)
        Me.TextYear.TabIndex = 3
        '
        'LblDateString
        '
        Me.LblDateString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDateString.Location = New System.Drawing.Point(69, 199)
        Me.LblDateString.Name = "LblDateString"
        Me.LblDateString.Size = New System.Drawing.Size(354, 23)
        Me.LblDateString.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter the day of the week:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter the month:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enter the day of the month:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Enter the year:"
        '
        'btnShowData
        '
        Me.btnShowData.Location = New System.Drawing.Point(72, 237)
        Me.btnShowData.Name = "btnShowData"
        Me.btnShowData.Size = New System.Drawing.Size(75, 23)
        Me.btnShowData.TabIndex = 9
        Me.btnShowData.Text = "Show Date"
        Me.btnShowData.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(210, 237)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(348, 237)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 336)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDateString)
        Me.Controls.Add(Me.TextYear)
        Me.Controls.Add(Me.TextDate)
        Me.Controls.Add(Me.TextMonth)
        Me.Controls.Add(Me.TextDay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextDay As TextBox
    Friend WithEvents TextMonth As TextBox
    Friend WithEvents TextDate As TextBox
    Friend WithEvents TextYear As TextBox
    Friend WithEvents LblDateString As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnShowData As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
