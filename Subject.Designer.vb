<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subjecttext
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
        Me.lblAddSubject = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcourse = New System.Windows.Forms.Label()
        Me.lblsemester = New System.Windows.Forms.Label()
        Me.txtSem = New System.Windows.Forms.TextBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblprogrammae = New System.Windows.Forms.Label()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.lblhours = New System.Windows.Forms.Label()
        Me.txtsubjectcode = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblsubjectcode = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.GridSubjectdetails = New System.Windows.Forms.DataGridView()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.cmbprogrammae = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.GridSubjectdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddSubject
        '
        Me.lblAddSubject.AutoSize = True
        Me.lblAddSubject.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddSubject.Location = New System.Drawing.Point(450, 29)
        Me.lblAddSubject.Name = "lblAddSubject"
        Me.lblAddSubject.Size = New System.Drawing.Size(213, 33)
        Me.lblAddSubject.TabIndex = 0
        Me.lblAddSubject.Text = "ADD SUBJECT "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-92, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 1
        '
        'lblcourse
        '
        Me.lblcourse.AutoSize = True
        Me.lblcourse.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourse.Location = New System.Drawing.Point(4, 70)
        Me.lblcourse.Name = "lblcourse"
        Me.lblcourse.Size = New System.Drawing.Size(72, 22)
        Me.lblcourse.TabIndex = 2
        Me.lblcourse.Text = "Course"
        '
        'lblsemester
        '
        Me.lblsemester.AutoSize = True
        Me.lblsemester.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemester.Location = New System.Drawing.Point(4, 167)
        Me.lblsemester.Name = "lblsemester"
        Me.lblsemester.Size = New System.Drawing.Size(93, 22)
        Me.lblsemester.TabIndex = 3
        Me.lblsemester.Text = "Semester"
        '
        'txtSem
        '
        Me.txtSem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSem.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSem.Location = New System.Drawing.Point(184, 167)
        Me.txtSem.Multiline = True
        Me.txtSem.Name = "txtSem"
        Me.txtSem.Size = New System.Drawing.Size(200, 26)
        Me.txtSem.TabIndex = 18
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(152, 354)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(107, 47)
        Me.btninsert.TabIndex = 10
        Me.btninsert.Text = "INSERT"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(825, 305)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(114, 48)
        Me.btncancel.TabIndex = 11
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lblprogrammae
        '
        Me.lblprogrammae.AutoSize = True
        Me.lblprogrammae.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogrammae.Location = New System.Drawing.Point(4, 20)
        Me.lblprogrammae.Name = "lblprogrammae"
        Me.lblprogrammae.Size = New System.Drawing.Size(120, 22)
        Me.lblprogrammae.TabIndex = 12
        Me.lblprogrammae.Text = "Programmae"
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyear.Location = New System.Drawing.Point(4, 122)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(47, 22)
        Me.lblyear.TabIndex = 14
        Me.lblyear.Text = "Year"
        '
        'txtYear
        '
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYear.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(184, 122)
        Me.txtYear.Multiline = True
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(200, 26)
        Me.txtYear.TabIndex = 18
        '
        'txtHours
        '
        Me.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHours.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(224, 79)
        Me.txtHours.Multiline = True
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(200, 26)
        Me.txtHours.TabIndex = 22
        '
        'lblhours
        '
        Me.lblhours.AutoSize = True
        Me.lblhours.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhours.Location = New System.Drawing.Point(22, 83)
        Me.lblhours.Name = "lblhours"
        Me.lblhours.Size = New System.Drawing.Size(154, 22)
        Me.lblhours.TabIndex = 21
        Me.lblhours.Text = "Number of Hours"
        '
        'txtsubjectcode
        '
        Me.txtsubjectcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsubjectcode.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjectcode.Location = New System.Drawing.Point(225, 20)
        Me.txtsubjectcode.Multiline = True
        Me.txtsubjectcode.Name = "txtsubjectcode"
        Me.txtsubjectcode.Size = New System.Drawing.Size(200, 26)
        Me.txtsubjectcode.TabIndex = 23
        '
        'txtSubject
        '
        Me.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubject.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(184, 221)
        Me.txtSubject.Multiline = True
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(200, 26)
        Me.txtSubject.TabIndex = 24
        '
        'lblsubjectcode
        '
        Me.lblsubjectcode.AutoSize = True
        Me.lblsubjectcode.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubjectcode.Location = New System.Drawing.Point(22, 26)
        Me.lblsubjectcode.Name = "lblsubjectcode"
        Me.lblsubjectcode.Size = New System.Drawing.Size(126, 22)
        Me.lblsubjectcode.TabIndex = 20
        Me.lblsubjectcode.Text = "Subject Code"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(4, 221)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(74, 22)
        Me.lblSubject.TabIndex = 19
        Me.lblSubject.Text = "Subject"
        '
        'GridSubjectdetails
        '
        Me.GridSubjectdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridSubjectdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSubjectdetails.Location = New System.Drawing.Point(54, 418)
        Me.GridSubjectdetails.Name = "GridSubjectdetails"
        Me.GridSubjectdetails.RowTemplate.Height = 24
        Me.GridSubjectdetails.Size = New System.Drawing.Size(1034, 312)
        Me.GridSubjectdetails.TabIndex = 25
        '
        'cmbcourse
        '
        Me.cmbcourse.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Location = New System.Drawing.Point(184, 67)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(200, 29)
        Me.cmbcourse.TabIndex = 26
        '
        'cmbprogrammae
        '
        Me.cmbprogrammae.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbprogrammae.FormattingEnabled = True
        Me.cmbprogrammae.Location = New System.Drawing.Point(184, 20)
        Me.cmbprogrammae.Name = "cmbprogrammae"
        Me.cmbprogrammae.Size = New System.Drawing.Size(200, 29)
        Me.cmbprogrammae.TabIndex = 30
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.MintCream
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(905, 237)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 48)
        Me.btnUpdate.TabIndex = 31
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MintCream
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(303, 354)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 48)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(749, 237)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 48)
        Me.btnSearch.TabIndex = 33
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbprogrammae)
        Me.Panel1.Controls.Add(Me.cmbcourse)
        Me.Panel1.Controls.Add(Me.txtSubject)
        Me.Panel1.Controls.Add(Me.lblSubject)
        Me.Panel1.Controls.Add(Me.txtYear)
        Me.Panel1.Controls.Add(Me.lblyear)
        Me.Panel1.Controls.Add(Me.lblprogrammae)
        Me.Panel1.Controls.Add(Me.txtSem)
        Me.Panel1.Controls.Add(Me.lblsemester)
        Me.Panel1.Controls.Add(Me.lblcourse)
        Me.Panel1.Location = New System.Drawing.Point(78, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 258)
        Me.Panel1.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtHours)
        Me.Panel2.Controls.Add(Me.lblhours)
        Me.Panel2.Controls.Add(Me.txtsubjectcode)
        Me.Panel2.Controls.Add(Me.lblsubjectcode)
        Me.Panel2.Location = New System.Drawing.Point(590, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(469, 130)
        Me.Panel2.TabIndex = 35
        '
        'Subjecttext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1143, 756)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GridSubjectdetails)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAddSubject)
        Me.Name = "Subjecttext"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject"
        CType(Me.GridSubjectdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddSubject As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblcourse As System.Windows.Forms.Label
    Friend WithEvents lblsemester As System.Windows.Forms.Label
    Friend WithEvents txtSem As System.Windows.Forms.TextBox
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lblprogrammae As System.Windows.Forms.Label
    Friend WithEvents lblyear As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents lblhours As System.Windows.Forms.Label
    Friend WithEvents txtsubjectcode As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblsubjectcode As System.Windows.Forms.Label
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents GridSubjectdetails As System.Windows.Forms.DataGridView
    Friend WithEvents cmbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbprogrammae As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
