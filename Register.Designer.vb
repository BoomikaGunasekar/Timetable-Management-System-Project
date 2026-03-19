<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPasssword = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(163, 158)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(99, 23)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'lblPasssword
        '
        Me.lblPasssword.AutoSize = True
        Me.lblPasssword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasssword.Location = New System.Drawing.Point(163, 218)
        Me.lblPasssword.Name = "lblPasssword"
        Me.lblPasssword.Size = New System.Drawing.Size(98, 23)
        Me.lblPasssword.TabIndex = 1
        Me.lblPasssword.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(326, 150)
        Me.txtUser.Multiline = True
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(171, 31)
        Me.txtUser.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(326, 211)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(171, 30)
        Me.txtPass.TabIndex = 3
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(196, 292)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(109, 54)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(340, 292)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 54)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NEW REGISTRATION"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 451)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPasssword)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPasssword As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
