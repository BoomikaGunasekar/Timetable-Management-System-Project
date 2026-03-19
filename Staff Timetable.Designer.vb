<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Timetable
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
        Me.lblStafftimetable = New System.Windows.Forms.Label()
        Me.lblSelectStaff = New System.Windows.Forms.Label()
        Me.btnview = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.cmbSelectStaff = New System.Windows.Forms.ComboBox()
        Me.GridStafftimetable = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbSelectIDNumber = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GridStafftimetable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStafftimetable
        '
        Me.lblStafftimetable.AutoSize = True
        Me.lblStafftimetable.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStafftimetable.Location = New System.Drawing.Point(473, 81)
        Me.lblStafftimetable.Name = "lblStafftimetable"
        Me.lblStafftimetable.Size = New System.Drawing.Size(215, 28)
        Me.lblStafftimetable.TabIndex = 0
        Me.lblStafftimetable.Text = "STAFF TIMETABLE"
        '
        'lblSelectStaff
        '
        Me.lblSelectStaff.AutoSize = True
        Me.lblSelectStaff.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectStaff.Location = New System.Drawing.Point(81, 109)
        Me.lblSelectStaff.Name = "lblSelectStaff"
        Me.lblSelectStaff.Size = New System.Drawing.Size(113, 23)
        Me.lblSelectStaff.TabIndex = 1
        Me.lblSelectStaff.Text = "Select Staff"
        '
        'btnview
        '
        Me.btnview.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.Location = New System.Drawing.Point(405, 316)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(152, 56)
        Me.btnview.TabIndex = 4
        Me.btnview.Text = "GENERATE"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(722, 316)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(114, 56)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "CLOSE"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'cmbSelectStaff
        '
        Me.cmbSelectStaff.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectStaff.FormattingEnabled = True
        Me.cmbSelectStaff.Location = New System.Drawing.Point(265, 109)
        Me.cmbSelectStaff.Name = "cmbSelectStaff"
        Me.cmbSelectStaff.Size = New System.Drawing.Size(196, 31)
        Me.cmbSelectStaff.TabIndex = 6
        '
        'GridStafftimetable
        '
        Me.GridStafftimetable.AllowUserToAddRows = False
        Me.GridStafftimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridStafftimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridStafftimetable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.GridStafftimetable.Location = New System.Drawing.Point(224, 406)
        Me.GridStafftimetable.Name = "GridStafftimetable"
        Me.GridStafftimetable.RowHeadersVisible = False
        Me.GridStafftimetable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridStafftimetable.RowTemplate.Height = 24
        Me.GridStafftimetable.Size = New System.Drawing.Size(832, 316)
        Me.GridStafftimetable.TabIndex = 7
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbSelectIDNumber)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbSelectStaff)
        Me.Panel1.Controls.Add(Me.lblSelectStaff)
        Me.Panel1.Location = New System.Drawing.Point(331, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 171)
        Me.Panel1.TabIndex = 8
        '
        'cmbSelectIDNumber
        '
        Me.cmbSelectIDNumber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectIDNumber.FormattingEnabled = True
        Me.cmbSelectIDNumber.Location = New System.Drawing.Point(265, 60)
        Me.cmbSelectIDNumber.Name = "cmbSelectIDNumber"
        Me.cmbSelectIDNumber.Size = New System.Drawing.Size(196, 31)
        Me.cmbSelectIDNumber.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID Number"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(578, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 56)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "VIEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Staff_Timetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1179, 758)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridStafftimetable)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.lblStafftimetable)
        Me.Name = "Staff_Timetable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff_Timetable"
        CType(Me.GridStafftimetable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStafftimetable As System.Windows.Forms.Label
    Friend WithEvents lblSelectStaff As System.Windows.Forms.Label
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents cmbSelectStaff As System.Windows.Forms.ComboBox
    Friend WithEvents GridStafftimetable As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbSelectIDNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
