Public Class framemenu

    Private Sub framemenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
    End Sub

 
    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click
        Course.MdiParent = Me
        Course.Show()
        Subjecttext.Hide()
        Staff.Hide()
        ClassTimetable.Hide()
        Staff_Timetable.Hide()
        Subject_Alotment.Hide()
        ClassDetails.Hide()
        Subjecttext.Hide()
    End Sub

    Private Sub SubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectToolStripMenuItem.Click
        Subjecttext.MdiParent = Me
        Subjecttext.Show()
        Course.Hide()
        Staff.Hide()
        ClassTimetable.Hide()
        Staff_Timetable.Hide()
        Subject_Alotment.Hide()
        ClassDetails.Hide()
    End Sub

    Private Sub StaffToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem1.Click
        Staff.MdiParent = Me
        Staff.Show()
        Subjecttext.Hide()
        Course.Hide()
        ClassTimetable.Hide()
        Staff_Timetable.Hide()
        Subject_Alotment.Hide()
        ClassDetails.Hide()
        Subjecttext.Hide()
    End Sub


    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub ClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassToolStripMenuItem.Click
        ClassDetails.MdiParent = Me
        ClassDetails.Show()
        Subject_Alotment.Hide()
        ClassTimetable.Hide()
        Course.Hide()
        Staff.Hide()
        ClassTimetable.Hide()
        Staff_Timetable.Hide()
        Subjecttext.Hide()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem1.Click
        Subject_Alotment.MdiParent = Me
        Subject_Alotment.Show()
        ClassDetails.Hide()
        ClassTimetable.Hide()
        Course.Hide()
        Staff.Hide()
        ClassTimetable.Hide()
        Staff_Timetable.Hide()
        Subjecttext.Hide()
    End Sub

    Private Sub ClassTimetableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassTimetableToolStripMenuItem.Click
        ClassTimetable.MdiParent = Me
        ClassTimetable.Show()
        Subject_Alotment.Hide()
        ClassDetails.Hide()
        Course.Hide()
        Staff.Hide()
        Staff_Timetable.Hide()
        Subjecttext.Hide()
    End Sub

    Private Sub StaffTimetableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffTimetableToolStripMenuItem.Click
        Staff_Timetable.MdiParent = Me
        Staff_Timetable.Show()
        Subject_Alotment.Hide()
        ClassDetails.Hide()
        ClassTimetable.Hide()
        Course.Hide()
        Staff.Hide()
        ClassTimetable.Hide()
        Subjecttext.Hide()

    End Sub

End Class