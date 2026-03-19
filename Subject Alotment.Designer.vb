<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subject_Alotment
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
        Me.lblSubjectAlot = New System.Windows.Forms.Label()
        Me.btnAlot = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.lblsection = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblProgrammae = New System.Windows.Forms.Label()
        Me.GridSubjectAlotment = New System.Windows.Forms.DataGridView()
        Me.cmbProgrammae = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.lblSubjectName = New System.Windows.Forms.Label()
        Me.lblSubjectCode = New System.Windows.Forms.Label()
        Me.cmbStaffName = New System.Windows.Forms.ComboBox()
        Me.cmbSubjectName = New System.Windows.Forms.ComboBox()
        Me.cmbSubjectCode = New System.Windows.Forms.ComboBox()
        Me.lblNumberofHours = New System.Windows.Forms.Label()
        Me.cmbNumberofHours = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbIDNumber = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.GridSubjectAlotment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubjectAlot
        '
        Me.lblSubjectAlot.AutoSize = True
        Me.lblSubjectAlot.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectAlot.Location = New System.Drawing.Point(428, 21)
        Me.lblSubjectAlot.Name = "lblSubjectAlot"
        Me.lblSubjectAlot.Size = New System.Drawing.Size(246, 28)
        Me.lblSubjectAlot.TabIndex = 18
        Me.lblSubjectAlot.Text = "SUBJECT ALOTMENT"
        '
        'btnAlot
        '
        Me.btnAlot.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlot.Location = New System.Drawing.Point(433, 365)
        Me.btnAlot.Name = "btnAlot"
        Me.btnAlot.Size = New System.Drawing.Size(113, 50)
        Me.btnAlot.TabIndex = 19
        Me.btnAlot.Text = "ALOT"
        Me.btnAlot.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(881, 364)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 50)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "CLOSE"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmbSection
        '
        Me.cmbSection.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(212, 235)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(194, 29)
        Me.cmbSection.TabIndex = 30
        '
        'cmbSemester
        '
        Me.cmbSemester.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Location = New System.Drawing.Point(212, 184)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(194, 29)
        Me.cmbSemester.TabIndex = 29
        '
        'cmbYear
        '
        Me.cmbYear.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(212, 129)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(194, 29)
        Me.cmbYear.TabIndex = 28
        '
        'lblsection
        '
        Me.lblsection.AutoSize = True
        Me.lblsection.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsection.Location = New System.Drawing.Point(15, 238)
        Me.lblsection.Name = "lblsection"
        Me.lblsection.Size = New System.Drawing.Size(74, 22)
        Me.lblsection.TabIndex = 25
        Me.lblsection.Text = "Section"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(12, 187)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(93, 22)
        Me.lblSemester.TabIndex = 24
        Me.lblSemester.Text = "Semester"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(15, 132)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 22)
        Me.lblYear.TabIndex = 23
        Me.lblYear.Text = "Year"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(12, 81)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(72, 22)
        Me.lblCourse.TabIndex = 22
        Me.lblCourse.Text = "Course"
        '
        'lblProgrammae
        '
        Me.lblProgrammae.AutoSize = True
        Me.lblProgrammae.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgrammae.Location = New System.Drawing.Point(12, 29)
        Me.lblProgrammae.Name = "lblProgrammae"
        Me.lblProgrammae.Size = New System.Drawing.Size(120, 22)
        Me.lblProgrammae.TabIndex = 21
        Me.lblProgrammae.Text = "Programmae"
        '
        'GridSubjectAlotment
        '
        Me.GridSubjectAlotment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSubjectAlotment.Location = New System.Drawing.Point(117, 430)
        Me.GridSubjectAlotment.Name = "GridSubjectAlotment"
        Me.GridSubjectAlotment.RowTemplate.Height = 24
        Me.GridSubjectAlotment.Size = New System.Drawing.Size(917, 329)
        Me.GridSubjectAlotment.TabIndex = 31
        '
        'cmbProgrammae
        '
        Me.cmbProgrammae.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProgrammae.FormattingEnabled = True
        Me.cmbProgrammae.Location = New System.Drawing.Point(212, 26)
        Me.cmbProgrammae.Name = "cmbProgrammae"
        Me.cmbProgrammae.Size = New System.Drawing.Size(194, 29)
        Me.cmbProgrammae.TabIndex = 26
        '
        'cmbCourse
        '
        Me.cmbCourse.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(212, 78)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(194, 29)
        Me.cmbCourse.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbSection)
        Me.Panel1.Controls.Add(Me.cmbSemester)
        Me.Panel1.Controls.Add(Me.cmbYear)
        Me.Panel1.Controls.Add(Me.cmbCourse)
        Me.Panel1.Controls.Add(Me.cmbProgrammae)
        Me.Panel1.Controls.Add(Me.lblsection)
        Me.Panel1.Controls.Add(Me.lblSemester)
        Me.Panel1.Controls.Add(Me.lblYear)
        Me.Panel1.Controls.Add(Me.lblCourse)
        Me.Panel1.Controls.Add(Me.lblProgrammae)
        Me.Panel1.Location = New System.Drawing.Point(117, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 273)
        Me.Panel1.TabIndex = 33
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffName.Location = New System.Drawing.Point(32, 81)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(105, 22)
        Me.lblStaffName.TabIndex = 5
        Me.lblStaffName.Text = "Staff Name"
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectName.Location = New System.Drawing.Point(32, 129)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(129, 22)
        Me.lblSubjectName.TabIndex = 6
        Me.lblSubjectName.Text = "Subject Name"
        '
        'lblSubjectCode
        '
        Me.lblSubjectCode.AutoSize = True
        Me.lblSubjectCode.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectCode.Location = New System.Drawing.Point(31, 174)
        Me.lblSubjectCode.Name = "lblSubjectCode"
        Me.lblSubjectCode.Size = New System.Drawing.Size(126, 22)
        Me.lblSubjectCode.TabIndex = 7
        Me.lblSubjectCode.Text = "Subject Code"
        '
        'cmbStaffName
        '
        Me.cmbStaffName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStaffName.FormattingEnabled = True
        Me.cmbStaffName.Location = New System.Drawing.Point(217, 74)
        Me.cmbStaffName.Name = "cmbStaffName"
        Me.cmbStaffName.Size = New System.Drawing.Size(198, 29)
        Me.cmbStaffName.TabIndex = 13
        '
        'cmbSubjectName
        '
        Me.cmbSubjectName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubjectName.FormattingEnabled = True
        Me.cmbSubjectName.Location = New System.Drawing.Point(217, 120)
        Me.cmbSubjectName.Name = "cmbSubjectName"
        Me.cmbSubjectName.Size = New System.Drawing.Size(198, 29)
        Me.cmbSubjectName.TabIndex = 14
        '
        'cmbSubjectCode
        '
        Me.cmbSubjectCode.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubjectCode.FormattingEnabled = True
        Me.cmbSubjectCode.Location = New System.Drawing.Point(217, 167)
        Me.cmbSubjectCode.Name = "cmbSubjectCode"
        Me.cmbSubjectCode.Size = New System.Drawing.Size(198, 29)
        Me.cmbSubjectCode.TabIndex = 15
        '
        'lblNumberofHours
        '
        Me.lblNumberofHours.AutoSize = True
        Me.lblNumberofHours.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofHours.Location = New System.Drawing.Point(31, 223)
        Me.lblNumberofHours.Name = "lblNumberofHours"
        Me.lblNumberofHours.Size = New System.Drawing.Size(154, 22)
        Me.lblNumberofHours.TabIndex = 16
        Me.lblNumberofHours.Text = "Number of Hours"
        '
        'cmbNumberofHours
        '
        Me.cmbNumberofHours.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumberofHours.FormattingEnabled = True
        Me.cmbNumberofHours.Location = New System.Drawing.Point(217, 220)
        Me.cmbNumberofHours.Name = "cmbNumberofHours"
        Me.cmbNumberofHours.Size = New System.Drawing.Size(198, 29)
        Me.cmbNumberofHours.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbIDNumber)
        Me.Panel2.Controls.Add(Me.cmbNumberofHours)
        Me.Panel2.Controls.Add(Me.lblNumberofHours)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cmbSubjectCode)
        Me.Panel2.Controls.Add(Me.cmbSubjectName)
        Me.Panel2.Controls.Add(Me.cmbStaffName)
        Me.Panel2.Controls.Add(Me.lblSubjectCode)
        Me.Panel2.Controls.Add(Me.lblSubjectName)
        Me.Panel2.Controls.Add(Me.lblStaffName)
        Me.Panel2.Location = New System.Drawing.Point(601, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 273)
        Me.Panel2.TabIndex = 34
        '
        'cmbIDNumber
        '
        Me.cmbIDNumber.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIDNumber.FormattingEnabled = True
        Me.cmbIDNumber.Location = New System.Drawing.Point(217, 26)
        Me.cmbIDNumber.Name = "cmbIDNumber"
        Me.cmbIDNumber.Size = New System.Drawing.Size(198, 29)
        Me.cmbIDNumber.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 22)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "IDNumber"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(583, 365)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(115, 50)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(731, 364)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 51)
        Me.btnSearch.TabIndex = 38
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Subject_Alotment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1154, 761)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridSubjectAlotment)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAlot)
        Me.Controls.Add(Me.lblSubjectAlot)
        Me.Name = "Subject_Alotment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject_Alotment"
        CType(Me.GridSubjectAlotment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSubjectAlot As System.Windows.Forms.Label
    Friend WithEvents btnAlot As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSemester As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblsection As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblProgrammae As System.Windows.Forms.Label
    Friend WithEvents GridSubjectAlotment As System.Windows.Forms.DataGridView
    Friend WithEvents cmbProgrammae As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblStaffName As System.Windows.Forms.Label
    Friend WithEvents lblSubjectName As System.Windows.Forms.Label
    Friend WithEvents lblSubjectCode As System.Windows.Forms.Label
    Friend WithEvents cmbStaffName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubjectName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubjectCode As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumberofHours As System.Windows.Forms.Label
    Friend WithEvents cmbNumberofHours As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbIDNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
