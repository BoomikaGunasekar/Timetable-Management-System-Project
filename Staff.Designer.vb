<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Me.components = New System.ComponentModel.Container()
        Me.GridStaffdetails = New System.Windows.Forms.DataGridView()
        Me.lblStaffDetails = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblQualification = New System.Windows.Forms.Label()
        Me.lblMobNumber = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtQualification = New System.Windows.Forms.TextBox()
        Me.txtMobilenumber = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.RbtnMale = New System.Windows.Forms.RadioButton()
        Me.RBtnFemale = New System.Windows.Forms.RadioButton()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.GridStaffdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridStaffdetails
        '
        Me.GridStaffdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridStaffdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridStaffdetails.Location = New System.Drawing.Point(70, 434)
        Me.GridStaffdetails.Name = "GridStaffdetails"
        Me.GridStaffdetails.RowTemplate.Height = 24
        Me.GridStaffdetails.Size = New System.Drawing.Size(1017, 348)
        Me.GridStaffdetails.TabIndex = 20
        '
        'lblStaffDetails
        '
        Me.lblStaffDetails.AutoSize = True
        Me.lblStaffDetails.Font = New System.Drawing.Font("Arial Black", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffDetails.Location = New System.Drawing.Point(449, 29)
        Me.lblStaffDetails.Name = "lblStaffDetails"
        Me.lblStaffDetails.Size = New System.Drawing.Size(218, 31)
        Me.lblStaffDetails.TabIndex = 0
        Me.lblStaffDetails.Text = " STAFF DETAILS "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(31, 90)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(102, 22)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID Number"
        '
        'lblQualification
        '
        Me.lblQualification.AutoSize = True
        Me.lblQualification.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualification.Location = New System.Drawing.Point(31, 224)
        Me.lblQualification.Name = "lblQualification"
        Me.lblQualification.Size = New System.Drawing.Size(113, 22)
        Me.lblQualification.TabIndex = 3
        Me.lblQualification.Text = "Qualification"
        '
        'lblMobNumber
        '
        Me.lblMobNumber.AutoSize = True
        Me.lblMobNumber.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobNumber.Location = New System.Drawing.Point(31, 273)
        Me.lblMobNumber.Name = "lblMobNumber"
        Me.lblMobNumber.Size = New System.Drawing.Size(138, 22)
        Me.lblMobNumber.TabIndex = 4
        Me.lblMobNumber.Text = "Mobile Number"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(31, 174)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(109, 22)
        Me.lblDepartment.TabIndex = 5
        Me.lblDepartment.Text = "Department"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(196, 44)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 29)
        Me.txtName.TabIndex = 6
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(196, 90)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(200, 29)
        Me.txtID.TabIndex = 7
        '
        'txtQualification
        '
        Me.txtQualification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQualification.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQualification.Location = New System.Drawing.Point(196, 217)
        Me.txtQualification.Multiline = True
        Me.txtQualification.Name = "txtQualification"
        Me.txtQualification.Size = New System.Drawing.Size(200, 29)
        Me.txtQualification.TabIndex = 8
        '
        'txtMobilenumber
        '
        Me.txtMobilenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobilenumber.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobilenumber.Location = New System.Drawing.Point(196, 266)
        Me.txtMobilenumber.MaxLength = 10
        Me.txtMobilenumber.Multiline = True
        Me.txtMobilenumber.Name = "txtMobilenumber"
        Me.txtMobilenumber.Size = New System.Drawing.Size(200, 29)
        Me.txtMobilenumber.TabIndex = 9
        '
        'txtDepartment
        '
        Me.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepartment.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(196, 167)
        Me.txtDepartment.Multiline = True
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(200, 29)
        Me.txtDepartment.TabIndex = 10
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.MintCream
        Me.btnInsert.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(152, 377)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(108, 41)
        Me.btnInsert.TabIndex = 11
        Me.btnInsert.Text = "INSERT"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.MintCream
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(784, 256)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 45)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'RbtnMale
        '
        Me.RbtnMale.AutoSize = True
        Me.RbtnMale.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnMale.Location = New System.Drawing.Point(196, 131)
        Me.RbtnMale.Name = "RbtnMale"
        Me.RbtnMale.Size = New System.Drawing.Size(71, 26)
        Me.RbtnMale.TabIndex = 13
        Me.RbtnMale.TabStop = True
        Me.RbtnMale.Text = "Male"
        Me.RbtnMale.UseVisualStyleBackColor = True
        '
        'RBtnFemale
        '
        Me.RBtnFemale.AutoSize = True
        Me.RBtnFemale.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnFemale.Location = New System.Drawing.Point(301, 131)
        Me.RBtnFemale.Name = "RBtnFemale"
        Me.RBtnFemale.Size = New System.Drawing.Size(95, 26)
        Me.RBtnFemale.TabIndex = 14
        Me.RBtnFemale.TabStop = True
        Me.RBtnFemale.Text = "Female"
        Me.RBtnFemale.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(31, 131)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(74, 22)
        Me.lblGender.TabIndex = 15
        Me.lblGender.Text = "Gender"
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.Location = New System.Drawing.Point(11, 32)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(102, 22)
        Me.lblIDNumber.TabIndex = 16
        Me.lblIDNumber.Text = "ID Number"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDNumber.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.Location = New System.Drawing.Point(150, 29)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(198, 27)
        Me.txtIDNumber.TabIndex = 17
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MintCream
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(696, 183)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(115, 48)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MintCream
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(294, 370)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 48)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.MintCream
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(836, 183)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 48)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.RBtnFemale)
        Me.Panel1.Controls.Add(Me.RbtnMale)
        Me.Panel1.Controls.Add(Me.txtDepartment)
        Me.Panel1.Controls.Add(Me.txtMobilenumber)
        Me.Panel1.Controls.Add(Me.txtQualification)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.lblDepartment)
        Me.Panel1.Controls.Add(Me.lblMobNumber)
        Me.Panel1.Controls.Add(Me.lblQualification)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(57, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 315)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtIDNumber)
        Me.Panel2.Controls.Add(Me.lblIDNumber)
        Me.Panel2.Location = New System.Drawing.Point(598, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(384, 89)
        Me.Panel2.TabIndex = 23
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1189, 777)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GridStaffdetails)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.lblStaffDetails)
        Me.Name = "Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        CType(Me.GridStaffdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridStaffdetails As System.Windows.Forms.DataGridView
    Friend WithEvents lblStaffDetails As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblQualification As System.Windows.Forms.Label
    Friend WithEvents lblMobNumber As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtQualification As System.Windows.Forms.TextBox
    Friend WithEvents txtMobilenumber As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents RbtnMale As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents txtIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
