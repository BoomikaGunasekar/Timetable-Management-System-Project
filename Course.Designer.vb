<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course
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
        Me.lblAddCourse = New System.Windows.Forms.Label()
        Me.lblcourse = New System.Windows.Forms.Label()
        Me.txtcourse = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblProgrammae = New System.Windows.Forms.Label()
        Me.RbtnUG = New System.Windows.Forms.RadioButton()
        Me.RbtnPG = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddCourse
        '
        Me.lblAddCourse.AutoSize = True
        Me.lblAddCourse.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddCourse.ForeColor = System.Drawing.Color.Black
        Me.lblAddCourse.Location = New System.Drawing.Point(497, 180)
        Me.lblAddCourse.Name = "lblAddCourse"
        Me.lblAddCourse.Size = New System.Drawing.Size(192, 33)
        Me.lblAddCourse.TabIndex = 0
        Me.lblAddCourse.Text = "ADD COURSE"
        '
        'lblcourse
        '
        Me.lblcourse.AutoSize = True
        Me.lblcourse.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourse.Location = New System.Drawing.Point(31, 124)
        Me.lblcourse.Name = "lblcourse"
        Me.lblcourse.Size = New System.Drawing.Size(77, 22)
        Me.lblcourse.TabIndex = 1
        Me.lblcourse.Text = "Course "
        '
        'txtcourse
        '
        Me.txtcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcourse.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcourse.Location = New System.Drawing.Point(271, 124)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(222, 28)
        Me.txtcourse.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(492, 479)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(79, 60)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(621, 479)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 60)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblProgrammae
        '
        Me.lblProgrammae.AutoSize = True
        Me.lblProgrammae.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgrammae.Location = New System.Drawing.Point(30, 40)
        Me.lblProgrammae.Name = "lblProgrammae"
        Me.lblProgrammae.Size = New System.Drawing.Size(179, 22)
        Me.lblProgrammae.TabIndex = 9
        Me.lblProgrammae.Text = "Select Programmae"
        '
        'RbtnUG
        '
        Me.RbtnUG.AutoSize = True
        Me.RbtnUG.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnUG.Location = New System.Drawing.Point(271, 42)
        Me.RbtnUG.Name = "RbtnUG"
        Me.RbtnUG.Size = New System.Drawing.Size(59, 26)
        Me.RbtnUG.TabIndex = 11
        Me.RbtnUG.TabStop = True
        Me.RbtnUG.Text = "UG"
        Me.RbtnUG.UseVisualStyleBackColor = True
        '
        'RbtnPG
        '
        Me.RbtnPG.AutoSize = True
        Me.RbtnPG.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnPG.Location = New System.Drawing.Point(397, 42)
        Me.RbtnPG.Name = "RbtnPG"
        Me.RbtnPG.Size = New System.Drawing.Size(59, 26)
        Me.RbtnPG.TabIndex = 12
        Me.RbtnPG.TabStop = True
        Me.RbtnPG.Text = "PG"
        Me.RbtnPG.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbtnPG)
        Me.Panel1.Controls.Add(Me.RbtnUG)
        Me.Panel1.Controls.Add(Me.lblProgrammae)
        Me.Panel1.Controls.Add(Me.txtcourse)
        Me.Panel1.Controls.Add(Me.lblcourse)
        Me.Panel1.Location = New System.Drawing.Point(323, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 190)
        Me.Panel1.TabIndex = 13
        '
        'Course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1136, 742)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblAddCourse)
        Me.Name = "Course"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddCourse As System.Windows.Forms.Label
    Friend WithEvents lblcourse As System.Windows.Forms.Label
    Friend WithEvents txtcourse As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblProgrammae As System.Windows.Forms.Label
    Friend WithEvents RbtnUG As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnPG As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
