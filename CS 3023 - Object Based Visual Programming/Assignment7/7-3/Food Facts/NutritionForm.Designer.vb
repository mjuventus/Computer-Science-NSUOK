﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NutritionForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.lblCarb = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Food"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Calories"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fat Grams"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(108, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Carb Grams"
        '
        'lblFood
        '
        Me.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFood.Location = New System.Drawing.Point(202, 80)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(167, 23)
        Me.lblFood.TabIndex = 1
        '
        'lblCalories
        '
        Me.lblCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalories.Location = New System.Drawing.Point(202, 111)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(167, 23)
        Me.lblCalories.TabIndex = 1
        '
        'lblFat
        '
        Me.lblFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFat.Location = New System.Drawing.Point(202, 140)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(167, 23)
        Me.lblFat.TabIndex = 1
        '
        'lblCarb
        '
        Me.lblCarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarb.Location = New System.Drawing.Point(202, 169)
        Me.lblCarb.Name = "lblCarb"
        Me.lblCarb.Size = New System.Drawing.Size(167, 23)
        Me.lblCarb.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NutritionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 329)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCarb)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NutritionForm"
        Me.Text = "Nutritional Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFood As Label
    Friend WithEvents lblCalories As Label
    Friend WithEvents lblFat As Label
    Friend WithEvents lblCarb As Label
    Friend WithEvents Button1 As Button
End Class
