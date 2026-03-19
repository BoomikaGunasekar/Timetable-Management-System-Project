Imports System.Data.SqlClient
Public Class ClassTimetable
    Dim conn As New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub ClassTimetable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridClassTimetable.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
        GridClassTimetable.RowsDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
        GridClassTimetable.RowTemplate.Height = 40
        GridClassTimetable.ColumnHeadersHeight = 40
        Dim newRow As DataGridViewRow = New DataGridViewRow()
        newRow.CreateCells(GridClassTimetable, "I")
        GridClassTimetable.Rows.Add(newRow)

        Dim newRow2 As DataGridViewRow = New DataGridViewRow()
        newRow2.CreateCells(GridClassTimetable, "II")
        GridClassTimetable.Rows.Add(newRow2)

        Dim newRow3 As DataGridViewRow = New DataGridViewRow()
        newRow3.CreateCells(GridClassTimetable, "III")
        GridClassTimetable.Rows.Add(newRow3)

        Dim newRow4 As DataGridViewRow = New DataGridViewRow()
        newRow4.CreateCells(GridClassTimetable, "IV")
        GridClassTimetable.Rows.Add(newRow4)

        Dim newRow5 As DataGridViewRow = New DataGridViewRow()
        newRow5.CreateCells(GridClassTimetable, "V")
        GridClassTimetable.Rows.Add(newRow5)

        conn.Open()
        Dim strsql As New SqlCommand("select distinct SelectProgrammae from programdetails", conn)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbSelectProgrammae.Items.Clear()
        While myreader.Read()
            cmbSelectProgrammae.Items.Add(myreader("SelectProgrammae"))
        End While
        conn.Close()


       

    End Sub

    Private Sub cmbSelectProgrammae_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSelectProgrammae.SelectedIndexChanged
        conn.Open()
        Dim strsql2 As New SqlCommand("select Course from programdetails where Selectprogrammae='" + cmbSelectProgrammae.Text + "'", conn)
        Dim myreader2 As SqlDataReader = strsql2.ExecuteReader
        cmbSelectCourse.Text = ""
        cmbSelectCourse.Items.Clear()
        While myreader2.Read()
            cmbSelectCourse.Items.Add(myreader2("Course"))
        End While
        conn.Close()

        conn.Open()
        Dim strsql3 As New SqlCommand("select distinct Years from Subject_Details where Programmae='" + cmbSelectProgrammae.Text + "'", conn)
        Dim myreader3 As SqlDataReader = strsql3.ExecuteReader
        cmbSelectYear.Text = ""
        cmbSelectYear.Items.Clear()
        While myreader3.Read()
            cmbSelectYear.Items.Add(myreader3("Years"))
        End While
        conn.Close()

        conn.Open()
        Dim strsql4 As New SqlCommand("select distinct Semester from Subject_Details where Programmae='" + cmbSelectProgrammae.Text + "'", conn)
        Dim myreader4 As SqlDataReader = strsql4.ExecuteReader
        cmbSelectSemester.Text = ""
        cmbSelectSemester.Items.Clear()
        While myreader4.Read()
            cmbSelectSemester.Items.Add(myreader4("Semester"))
        End While
        conn.Close()



    End Sub


    
  
    Private Function GetSubject_NameForRows() As List(Of List(Of String))
        Dim Subject_NameForRows As New List(Of List(Of String))()
        Using connection As New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Alotment;Integrated Security=True")
            connection.Open()
            Dim query As String = "SELECT Subject_Name FROM Subject_Alotment"
            Using cmd As New SqlCommand(query, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Dim rowSubject_Name As New List(Of String)()
                    While reader.Read()
                        rowSubject_Name.Add(reader("Subject_Name").ToString())
                    End While
                    Subject_NameForRows.Add(rowSubject_Name)

                End Using
            End Using
        End Using

        Return Subject_NameForRows

    End Function
    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim Subject_NameForRows As List(Of List(Of String)) = GetSubject_NameForRows()

        For rowIndex As Integer = 0 To Subject_NameForRows.Count - 1
            Dim rowSubject_Name As List(Of String) = Subject_NameForRows(rowIndex)

            For columnIndex As Integer = 1 To Math.Min(rowSubject_Name.Count, GridClassTimetable.Columns.Count - 1)
                GridClassTimetable.Rows(rowIndex).Cells(columnIndex).Value = rowSubject_Name(columnIndex - 1)
            Next
        Next

    End Sub

    Private Sub cmbSelectCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSelectCourse.SelectedIndexChanged
        conn.Open()
        Dim strsql2 As New SqlCommand("select distinct Section from Class_Details where Course='" + cmbSelectCourse.Text + "'", conn)
        Dim myreader2 As SqlDataReader = strsql2.ExecuteReader
        cmbSelectSection.Text = ""
        cmbSelectSection.Items.Clear()
        While myreader2.Read()
            cmbSelectSection.Items.Add(myreader2("Section"))
        End While
        conn.Close()
    End Sub
End Class
