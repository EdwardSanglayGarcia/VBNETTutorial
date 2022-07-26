<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.tbFirstPhone = New System.Windows.Forms.TextBox()
        Me.tbSecondPhone = New System.Windows.Forms.TextBox()
        Me.tbThirdPhone = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(22, 24)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(81, 15)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "List of Phones"
        '
        'tbFirstPhone
        '
        Me.tbFirstPhone.Location = New System.Drawing.Point(22, 42)
        Me.tbFirstPhone.Name = "tbFirstPhone"
        Me.tbFirstPhone.Size = New System.Drawing.Size(100, 23)
        Me.tbFirstPhone.TabIndex = 1
        '
        'tbSecondPhone
        '
        Me.tbSecondPhone.Location = New System.Drawing.Point(22, 71)
        Me.tbSecondPhone.Name = "tbSecondPhone"
        Me.tbSecondPhone.Size = New System.Drawing.Size(100, 23)
        Me.tbSecondPhone.TabIndex = 2
        '
        'tbThirdPhone
        '
        Me.tbThirdPhone.Location = New System.Drawing.Point(22, 100)
        Me.tbThirdPhone.Name = "tbThirdPhone"
        Me.tbThirdPhone.Size = New System.Drawing.Size(100, 23)
        Me.tbThirdPhone.TabIndex = 3
        '
        'PhoneControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbThirdPhone)
        Me.Controls.Add(Me.tbSecondPhone)
        Me.Controls.Add(Me.tbFirstPhone)
        Me.Controls.Add(Me.lblText)
        Me.Name = "PhoneControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblText As Label
    Friend WithEvents tbFirstPhone As TextBox
    Friend WithEvents tbSecondPhone As TextBox
    Friend WithEvents tbThirdPhone As TextBox
End Class
