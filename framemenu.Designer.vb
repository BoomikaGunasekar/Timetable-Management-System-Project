<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class framemenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(framemenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TIMETABLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffTimetableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassTimetableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWToolStripMenuItem, Me.TIMETABLEToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(882, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NEWToolStripMenuItem
        '
        Me.NEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem, Me.SubjectToolStripMenuItem, Me.ClassToolStripMenuItem, Me.StaffToolStripMenuItem1})
        Me.NEWToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NEWToolStripMenuItem.Name = "NEWToolStripMenuItem"
        Me.NEWToolStripMenuItem.Size = New System.Drawing.Size(153, 32)
        Me.NEWToolStripMenuItem.Text = "ADD RECORD"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(147, 28)
        Me.StaffToolStripMenuItem.Text = "Course"
        '
        'SubjectToolStripMenuItem
        '
        Me.SubjectToolStripMenuItem.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.SubjectToolStripMenuItem.Name = "SubjectToolStripMenuItem"
        Me.SubjectToolStripMenuItem.Size = New System.Drawing.Size(147, 28)
        Me.SubjectToolStripMenuItem.Text = "Subject"
        '
        'ClassToolStripMenuItem
        '
        Me.ClassToolStripMenuItem.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem"
        Me.ClassToolStripMenuItem.Size = New System.Drawing.Size(147, 28)
        Me.ClassToolStripMenuItem.Text = "Class"
        '
        'StaffToolStripMenuItem1
        '
        Me.StaffToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1"
        Me.StaffToolStripMenuItem1.Size = New System.Drawing.Size(147, 28)
        Me.StaffToolStripMenuItem1.Text = "Staff"
        '
        'TIMETABLEToolStripMenuItem
        '
        Me.TIMETABLEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem1, Me.GenerateToolStripMenuItem})
        Me.TIMETABLEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TIMETABLEToolStripMenuItem.Name = "TIMETABLEToolStripMenuItem"
        Me.TIMETABLEToolStripMenuItem.Size = New System.Drawing.Size(125, 32)
        Me.TIMETABLEToolStripMenuItem.Text = "GENERATE"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(229, 28)
        Me.ViewToolStripMenuItem1.Text = "Subject Alotment"
        '
        'GenerateToolStripMenuItem
        '
        Me.GenerateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffTimetableToolStripMenuItem, Me.ClassTimetableToolStripMenuItem})
        Me.GenerateToolStripMenuItem.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.GenerateToolStripMenuItem.Name = "GenerateToolStripMenuItem"
        Me.GenerateToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.GenerateToolStripMenuItem.Text = "Timetable"
        '
        'StaffTimetableToolStripMenuItem
        '
        Me.StaffTimetableToolStripMenuItem.Name = "StaffTimetableToolStripMenuItem"
        Me.StaffTimetableToolStripMenuItem.Size = New System.Drawing.Size(220, 28)
        Me.StaffTimetableToolStripMenuItem.Text = "Staff Timetable"
        '
        'ClassTimetableToolStripMenuItem
        '
        Me.ClassTimetableToolStripMenuItem.Name = "ClassTimetableToolStripMenuItem"
        Me.ClassTimetableToolStripMenuItem.Size = New System.Drawing.Size(220, 28)
        Me.ClassTimetableToolStripMenuItem.Text = "Class Timetable"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassReportsToolStripMenuItem, Me.StaffReportsToolStripMenuItem})
        Me.REPORTSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(111, 32)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'ClassReportsToolStripMenuItem
        '
        Me.ClassReportsToolStripMenuItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassReportsToolStripMenuItem.Name = "ClassReportsToolStripMenuItem"
        Me.ClassReportsToolStripMenuItem.Size = New System.Drawing.Size(207, 28)
        Me.ClassReportsToolStripMenuItem.Text = "Class Reports"
        '
        'StaffReportsToolStripMenuItem
        '
        Me.StaffReportsToolStripMenuItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffReportsToolStripMenuItem.Name = "StaffReportsToolStripMenuItem"
        Me.StaffReportsToolStripMenuItem.Size = New System.Drawing.Size(207, 28)
        Me.StaffReportsToolStripMenuItem.Text = "Staff Reports"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(66, 32)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'framemenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 600)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "framemenu"
        Me.Text = "TimeTable Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TIMETABLEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassTimetableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffTimetableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
