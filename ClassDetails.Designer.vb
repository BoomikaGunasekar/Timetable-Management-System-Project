<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassDetails
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
        Me.GridClassDetails = New System.Windows.Forms.DataGridView()
        Me.cmbProgrammae = New System.Windows.Forms.ComboBox()
        Me.lblprogrammae = New System.Windows.Forms.Label()
        Me.lblClassddetails = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.GridClassDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridClassDetails
        '
        Me.GridClassDetails.AllowUserToAddRows = False
        Me.GridClassDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridClassDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClassDetails.Location = New System.Drawing.Point(210, 467)
        Me.GridClassDetails.Name = "GridClassDetails"
        Me.GridClassDetails.RowTemplate.Height = 24
        Me.GridClassDetails.Size = New System.Drawing.Size(824, 298)
        Me.GridClassDetails.TabIndex = 32
        '
        'cmbProgrammae
        '
        Me.cmbProgrammae.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProgrammae.FormattingEnabled = True
        Me.cmbProgrammae.Location = New System.Drawing.Point(233, 56)
        Me.cmbProgrammae.Name = "cmbProgrammae"
        Me.cmbProgrammae.Size = New System.Drawing.Size(205, 29)
        Me.cmbProgrammae.TabIndex = 31
        '
        'lblprogrammae
        '
        Me.lblprogrammae.AutoSize = True
        Me.lblprogrammae.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogrammae.Location = New System.Drawing.Point(59, 59)
        Me.lblprogrammae.Name = "lblprogrammae"
        Me.lblprogrammae.Size = New System.Drawing.Size(120, 22)
        Me.lblprogrammae.TabIndex = 30
        Me.lblprogrammae.Text = "Programmae"
        '
        'lblClassddetails
        '
        Me.lblClassddetails.AutoSize = True
        Me.lblClassddetails.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassddetails.Location = New System.Drawing.Point(478, 52)
        Me.lblClassddetails.Name = "lblClassddetails"
        Me.lblClassddetails.Size = New System.Drawing.Size(186, 28)
        Me.lblClassddetails.TabIndex = 29
        Me.lblClassddetails.Text = "CLASS DETAILS"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(710, 401)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 49)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(483, 401)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 49)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmbCourse
        '
        Me.cmbCourse.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(233, 112)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(205, 29)
        Me.cmbCourse.TabIndex = 24
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(59, 219)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(74, 22)
        Me.lblSection.TabIndex = 23
        Me.lblSection.Text = "Section"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(59, 115)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(72, 22)
        Me.lblCourse.TabIndex = 21
        Me.lblCourse.Text = "Course"
        '
        'txtSection
        '
        Me.txtSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSection.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.Location = New System.Drawing.Point(233, 217)
        Me.txtSection.Multiline = True
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(205, 30)
        Me.txtSection.TabIndex = 33
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(59, 170)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 22)
        Me.lblYear.TabIndex = 34
        Me.lblYear.Text = "Year"
        '
        'cmbYear
        '
        Me.cmbYear.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(233, 167)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(205, 29)
        Me.cmbYear.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbYear)
        Me.Panel1.Controls.Add(Me.lblYear)
        Me.Panel1.Controls.Add(Me.txtSection)
        Me.Panel1.Controls.Add(Me.cmbProgrammae)
        Me.Panel1.Controls.Add(Me.lblprogrammae)
        Me.Panel1.Controls.Add(Me.cmbCourse)
        Me.Panel1.Controls.Add(Me.lblSection)
        Me.Panel1.Controls.Add(Me.lblCourse)
        Me.Panel1.Location = New System.Drawing.Point(354, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 277)
        Me.Panel1.TabIndex = 36
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(587, 401)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 49)
        Me.btnDelete.TabIndex = 37
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ClassDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1204, 777)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridClassDetails)
        Me.Controls.Add(Me.lblClassddetails)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "ClassDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClassDetails"
        CType(Me.GridClassDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridClassDetails As System.Windows.Forms.DataGridView
    Friend WithEvents cmbProgrammae As System.Windows.Forms.ComboBox
    Friend WithEvents lblprogrammae As System.Windows.Forms.Label
    Friend WithEvents lblClassddetails As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
