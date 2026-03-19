<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassTimetable
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSelectCourse = New System.Windows.Forms.Label()
        Me.lblSelectYear = New System.Windows.Forms.Label()
        Me.lblselectsemester = New System.Windows.Forms.Label()
        Me.cmbSelectCourse = New System.Windows.Forms.ComboBox()
        Me.cmbSelectSemester = New System.Windows.Forms.ComboBox()
        Me.cmbSelectYear = New System.Windows.Forms.ComboBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblSelectSection = New System.Windows.Forms.Label()
        Me.cmbSelectSection = New System.Windows.Forms.ComboBox()
        Me.GridClassTimetable = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbSelectProgrammae = New System.Windows.Forms.ComboBox()
        Me.lblprogrammae = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GridClassTimetable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(471, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLASS TIME TABLE"
        '
        'lblSelectCourse
        '
        Me.lblSelectCourse.AutoSize = True
        Me.lblSelectCourse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectCourse.Location = New System.Drawing.Point(18, 79)
        Me.lblSelectCourse.Name = "lblSelectCourse"
        Me.lblSelectCourse.Size = New System.Drawing.Size(134, 23)
        Me.lblSelectCourse.TabIndex = 1
        Me.lblSelectCourse.Text = "Select Course"
        '
        'lblSelectYear
        '
        Me.lblSelectYear.AutoSize = True
        Me.lblSelectYear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectYear.Location = New System.Drawing.Point(18, 136)
        Me.lblSelectYear.Name = "lblSelectYear"
        Me.lblSelectYear.Size = New System.Drawing.Size(112, 23)
        Me.lblSelectYear.TabIndex = 2
        Me.lblSelectYear.Text = "Select Year"
        '
        'lblselectsemester
        '
        Me.lblselectsemester.AutoSize = True
        Me.lblselectsemester.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselectsemester.Location = New System.Drawing.Point(18, 189)
        Me.lblselectsemester.Name = "lblselectsemester"
        Me.lblselectsemester.Size = New System.Drawing.Size(156, 23)
        Me.lblselectsemester.TabIndex = 3
        Me.lblselectsemester.Text = "Select Semester"
        '
        'cmbSelectCourse
        '
        Me.cmbSelectCourse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectCourse.FormattingEnabled = True
        Me.cmbSelectCourse.Location = New System.Drawing.Point(249, 79)
        Me.cmbSelectCourse.Name = "cmbSelectCourse"
        Me.cmbSelectCourse.Size = New System.Drawing.Size(200, 31)
        Me.cmbSelectCourse.TabIndex = 4
        '
        'cmbSelectSemester
        '
        Me.cmbSelectSemester.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectSemester.FormattingEnabled = True
        Me.cmbSelectSemester.Location = New System.Drawing.Point(249, 189)
        Me.cmbSelectSemester.Name = "cmbSelectSemester"
        Me.cmbSelectSemester.Size = New System.Drawing.Size(200, 31)
        Me.cmbSelectSemester.TabIndex = 5
        '
        'cmbSelectYear
        '
        Me.cmbSelectYear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectYear.FormattingEnabled = True
        Me.cmbSelectYear.Location = New System.Drawing.Point(249, 136)
        Me.cmbSelectYear.Name = "cmbSelectYear"
        Me.cmbSelectYear.Size = New System.Drawing.Size(200, 31)
        Me.cmbSelectYear.TabIndex = 6
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(489, 384)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(102, 52)
        Me.btnView.TabIndex = 8
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(628, 384)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 52)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CLOSE"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblSelectSection
        '
        Me.lblSelectSection.AutoSize = True
        Me.lblSelectSection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectSection.Location = New System.Drawing.Point(18, 244)
        Me.lblSelectSection.Name = "lblSelectSection"
        Me.lblSelectSection.Size = New System.Drawing.Size(136, 23)
        Me.lblSelectSection.TabIndex = 10
        Me.lblSelectSection.Text = "Select Section"
        '
        'cmbSelectSection
        '
        Me.cmbSelectSection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectSection.FormattingEnabled = True
        Me.cmbSelectSection.Location = New System.Drawing.Point(249, 244)
        Me.cmbSelectSection.Name = "cmbSelectSection"
        Me.cmbSelectSection.Size = New System.Drawing.Size(200, 31)
        Me.cmbSelectSection.TabIndex = 11
        '
        'GridClassTimetable
        '
        Me.GridClassTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridClassTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClassTimetable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridClassTimetable.DefaultCellStyle = DataGridViewCellStyle1
        Me.GridClassTimetable.Location = New System.Drawing.Point(248, 452)
        Me.GridClassTimetable.Name = "GridClassTimetable"
        Me.GridClassTimetable.RowHeadersVisible = False
        Me.GridClassTimetable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridClassTimetable.RowTemplate.Height = 24
        Me.GridClassTimetable.Size = New System.Drawing.Size(759, 267)
        Me.GridClassTimetable.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "DayOrder"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Hour1"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Hour2"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Hour3"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Hour4"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Hour5"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Hour6"
        Me.Column7.Name = "Column7"
        '
        'cmbSelectProgrammae
        '
        Me.cmbSelectProgrammae.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectProgrammae.FormattingEnabled = True
        Me.cmbSelectProgrammae.Location = New System.Drawing.Point(249, 27)
        Me.cmbSelectProgrammae.Name = "cmbSelectProgrammae"
        Me.cmbSelectProgrammae.Size = New System.Drawing.Size(200, 29)
        Me.cmbSelectProgrammae.TabIndex = 32
        '
        'lblprogrammae
        '
        Me.lblprogrammae.AutoSize = True
        Me.lblprogrammae.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogrammae.Location = New System.Drawing.Point(18, 27)
        Me.lblprogrammae.Name = "lblprogrammae"
        Me.lblprogrammae.Size = New System.Drawing.Size(179, 22)
        Me.lblprogrammae.TabIndex = 31
        Me.lblprogrammae.Text = "Select Programmae"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbSelectProgrammae)
        Me.Panel1.Controls.Add(Me.lblprogrammae)
        Me.Panel1.Controls.Add(Me.cmbSelectSection)
        Me.Panel1.Controls.Add(Me.lblSelectSection)
        Me.Panel1.Controls.Add(Me.cmbSelectYear)
        Me.Panel1.Controls.Add(Me.cmbSelectSemester)
        Me.Panel1.Controls.Add(Me.cmbSelectCourse)
        Me.Panel1.Controls.Add(Me.lblselectsemester)
        Me.Panel1.Controls.Add(Me.lblSelectYear)
        Me.Panel1.Controls.Add(Me.lblSelectCourse)
        Me.Panel1.Location = New System.Drawing.Point(355, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 292)
        Me.Panel1.TabIndex = 33
        '
        'ClassTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1166, 745)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridClassTimetable)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ClassTimetable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClassTimetable"
        CType(Me.GridClassTimetable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSelectCourse As System.Windows.Forms.Label
    Friend WithEvents lblSelectYear As System.Windows.Forms.Label
    Friend WithEvents lblselectsemester As System.Windows.Forms.Label
    Friend WithEvents cmbSelectCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSelectSemester As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSelectYear As System.Windows.Forms.ComboBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblSelectSection As System.Windows.Forms.Label
    Friend WithEvents cmbSelectSection As System.Windows.Forms.ComboBox
    Friend WithEvents GridClassTimetable As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSelectProgrammae As System.Windows.Forms.ComboBox
    Friend WithEvents lblprogrammae As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
